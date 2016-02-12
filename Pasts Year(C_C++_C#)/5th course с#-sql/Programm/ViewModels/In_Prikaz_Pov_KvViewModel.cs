using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Programm.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Programm.Helpers;

namespace Programm.ViewModels
{
    public class In_Prikaz_Pov_KvViewModel : DocumentViewModel
    {
        #region Private fields
        private List<In_Prikaz_Pov_Kv> _data;
        private List<In_Zayav_Pov_Kv> _sotrs;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region In_Prikaz_Pov_Kv binding fields
        private In_Prikaz_Pov_Kv _editingElem;

        public In_Prikaz_Pov_Kv EditingElem
        {
            get { return _editingElem; }
            set
            {
                _editingElem = value;
                OnPropertyChanged("EditingElem");
            }
        }

        #endregion

        #region Constructors
        public In_Prikaz_Pov_KvViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        
        public List<In_Prikaz_Pov_Kv> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<In_Prikaz_Pov_Kv>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public List<In_Zayav_Pov_Kv> Sotrs
        {
            get
            {
                if (_sotrs == null)
                    _sotrs = new List<In_Zayav_Pov_Kv>();
                return _sotrs;
            }
            private set
            {
                _sotrs = value;
                OnPropertyChanged("Sotrs");
            }
        }
        public bool IsEditing
        {
            get { return _isEditing; }
            set
            {
                _isEditing = value;
                OnPropertyChanged("IsEditing");
            }
        }
        #endregion

        #region SelectCommand
        public ICommand SelectCommand
        {
            get
            {
                if (_selectCommand == null)
                {
                    _selectCommand = new RelayCommand(param => this.Select());
                }

                return _selectCommand;
            }
        }

        public void Select()
        {
            _mainModelView.SelectDocument(this);
            this.Refresh();
        }
        #endregion

        #region Add/Edit Commands
        public ICommand AddApproveCommand
        {
            get
            {
                if (_addApproveCommand == null)
                {
                    _addApproveCommand = new RelayCommand(param => this.AddApprove(), param => this.CanApprove());
                }

                return _addApproveCommand;
            }
        }

        public void AddApprove()
        {
            switch (_opType)
            {
                case OperationType.Add:
                    In_Prikaz_Pov_Kv addElem = EditingElem.Copy() as In_Prikaz_Pov_Kv; 
                    DataBase.DataBase.AddIn_Prikaz_Pov_Kv(addElem);
                    break;
                case OperationType.Edit:
                    In_Prikaz_Pov_Kv editElem = EditingElem.Copy() as In_Prikaz_Pov_Kv;
                    DataBase.DataBase.EditIn_Prikaz_Pov_Kv(editElem);
                    break;
            }

            _opType = OperationType.None;
            IsEditing = false;
            EditingElem = null;
            this.Refresh();
        }

        public bool CanApprove()
        {
            return EditingElem != null;
        }

        public ICommand AddCancellCommand
        {
            get
            {
                if (_addCancellCommand == null)
                {
                    _addCancellCommand = new RelayCommand(param => this.AddCancell());
                }

                return _addCancellCommand;
            }
        }

        public void AddCancell()
        {
            EditingElem = null;
            _opType = OperationType.None;
            IsEditing = false;
            this.Refresh();
        }
        #endregion

        #region Operations methods
        #region Refresh
        public override void Refresh()
        {
            this.Data.Clear();

            Data = new List<In_Prikaz_Pov_Kv>(DataBase.DataBase.GetIn_Prikaz_Pov_Kv());
        }

        public override bool CanRefresh()
        {
            return true && _opType == OperationType.None;
        }
        #endregion

        #region Delete
        public override void Delete()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            if (collectionView != null)
            {
                In_Prikaz_Pov_Kv item = collectionView.CurrentItem as In_Prikaz_Pov_Kv;
                if (item != null)
                    DataBase.DataBase.DeleteIn_Prikaz_Pov_Kv(item);
            }
            Refresh();
        }

        public override bool CanDelete()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            if (collectionView != null)
            {
                return collectionView.CurrentItem != null && _opType == OperationType.None;
            }
            else
                return false;
        }
        #endregion

        #region Add
        public override void Add()
        {
            EditingElem = new In_Prikaz_Pov_Kv();
            Sotrs = DataBase.DataBase.GetIn_Zayav_Pov_Kv();
            _opType = OperationType.Add;
            IsEditing = true;
        }

        public override bool CanAdd()
        {
            return true && _opType == OperationType.None;
        }
        #endregion

        #region Edit
        public override void Edit()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            if (collectionView != null)
            {
                In_Prikaz_Pov_Kv item = collectionView.CurrentItem as In_Prikaz_Pov_Kv;
                if (item != null)
                {
                    Sotrs = DataBase.DataBase.GetIn_Zayav_Pov_Kv();
                    EditingElem = item.Copy() as In_Prikaz_Pov_Kv;
                    _opType = OperationType.Edit;
                    IsEditing = true;
                }
            }
        }

        public override bool CanEdit()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            if (collectionView != null)
            {
                return collectionView.CurrentItem != null && _opType == OperationType.None;
            }
            else
                return false;
        }
        #endregion
        #endregion        
    }
}
