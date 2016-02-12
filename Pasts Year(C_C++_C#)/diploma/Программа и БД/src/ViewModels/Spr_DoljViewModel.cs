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
    public class Spr_DoljViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Spr_Dolj> _data;
        private List<Spr_Struct_Podr> _podrs;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region Spr_Dolj binding fields
        private Spr_Dolj _editingElem;

        public Spr_Dolj EditingElem
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
        public Spr_DoljViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<Spr_Dolj> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Spr_Dolj>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public List<Spr_Struct_Podr> Podrs
        {
            get
            {
                if (_podrs == null)
                    _podrs = new List<Spr_Struct_Podr>();
                return _podrs;
            }
            private set
            {
                _podrs = value;
                OnPropertyChanged("Podrs");
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
                    Spr_Dolj addElem = EditingElem.Copy() as Spr_Dolj; 
                    DataBase.DataBase.AddSpr_Dolj(addElem);
                    break;
                case OperationType.Edit:
                    Spr_Dolj editElem = EditingElem.Copy() as Spr_Dolj;
                    DataBase.DataBase.EditSpr_Dolj(editElem);
                    break;
            }

            _opType = OperationType.None;
            EditingElem = null;
            IsEditing = false;
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
           // List<Spr_Dolj> _spr_dolj_list = DataBase.DataBase.GetSpr_Dolj().ToList();
            Data = new List<Spr_Dolj>(DataBase.DataBase.GetSpr_Dolj());
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
                Spr_Dolj item = collectionView.CurrentItem as Spr_Dolj;
                if (item != null)
                    DataBase.DataBase.DeleteSpr_Dolj(item);
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
            EditingElem = new Spr_Dolj();
            Podrs = DataBase.DataBase.GetSpr_Struct_Podr();
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
                Spr_Dolj item = collectionView.CurrentItem as Spr_Dolj;
                if (item != null)
                {
                    Podrs = DataBase.DataBase.GetSpr_Struct_Podr();
                    EditingElem = item.Copy() as Spr_Dolj;
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
