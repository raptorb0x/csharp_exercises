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
    public class In_Uch_SotrViewModel : DocumentViewModel
    {
        #region Private fields
        private List<In_Uch_Sotr> _data;
        private List<Spr_Sotr> _sotrs;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region In_Uch_Sotr binding fields
        private In_Uch_Sotr _editingElem;

        public In_Uch_Sotr EditingElem
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
        public In_Uch_SotrViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<In_Uch_Sotr> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<In_Uch_Sotr>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public List<Spr_Sotr> Sotrs
        {
            get
            {
                if (_sotrs == null)
                    _sotrs = new List<Spr_Sotr>();
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
                    _addApproveCommand = new RelayCommand(param => this.AddApprove());
                }

                return _addApproveCommand;
            }
        }

        public void AddApprove()
        {
            switch (_opType)
            {
                case OperationType.Add:
                    //In_Uch_Sotr addElem = EditingElem.Copy() as In_Uch_Sotr; 
                    //DataBase.DataBase.AddIn_Uch_Sotr(addElem);
                    break;
                case OperationType.Edit:
                    //In_Uch_Sotr editElem = EditingElem.Copy() as In_Uch_Sotr;
                    //DataBase.DataBase.EditIn_Uch_Sotr(editElem);
                    break;
            }

            _opType = OperationType.None;
            IsEditing = false;
            EditingElem = null;
            this.Refresh();
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

            Data = new List<In_Uch_Sotr>(DataBase.DataBase.GetIn_Uch_Sotr());
        }

        public override bool CanRefresh()
        {
            return true && _opType == OperationType.None;
        }
        #endregion

        #region Delete
        public override void Delete()
        {
            //ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            //if (collectionView != null)
            //{
            //    In_Uch_Sotr item = collectionView.CurrentItem as In_Uch_Sotr;
            //    if (item != null)
            //        DataBase.DataBase.DeleteIn_Uch_Sotr(item);
            //}
            //Refresh();
        }

        public override bool CanDelete()
        {           
                return false;
        }
        #endregion

        #region Add
        public override void Add()
        {
            EditingElem = new In_Uch_Sotr();
            Sotrs = DataBase.DataBase.GetSpr_Sotr();
            _opType = OperationType.Add;
            IsEditing = true;
        }

        public override bool CanAdd()
        {
            return false;
        }
        #endregion

        #region Edit
        public override void Edit()
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(Data);
            if (collectionView != null)
            {
                In_Uch_Sotr item = collectionView.CurrentItem as In_Uch_Sotr;
                if (item != null)
                {
                    Sotrs = DataBase.DataBase.GetSpr_Sotr();
                    EditingElem = item.Copy() as In_Uch_Sotr;
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
