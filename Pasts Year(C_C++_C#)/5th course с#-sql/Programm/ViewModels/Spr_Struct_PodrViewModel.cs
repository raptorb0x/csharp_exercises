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
    public class Spr_Struct_PodrViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Spr_Struct_Podr> _data;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region Spr_Struct_Podr binding fields
        private Spr_Struct_Podr _editingElem;

        public Spr_Struct_Podr EditingElem
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
        public Spr_Struct_PodrViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<Spr_Struct_Podr> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Spr_Struct_Podr>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
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
                    Spr_Struct_Podr addElem = EditingElem.Copy() as Spr_Struct_Podr;
                    DataBase.DataBase.AddSpr_Struct_Podr(addElem);
                    break;
                case OperationType.Edit:
                    Spr_Struct_Podr editElem = EditingElem.Copy() as Spr_Struct_Podr;
                    DataBase.DataBase.EditSpr_Struct_Podr(editElem);
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
            EditingElem = null;
            this.Refresh();
        }
        #endregion

        #region Operations methods
        #region Refresh
        public override void Refresh()
        {
            this.Data.Clear();

            Data = new List<Spr_Struct_Podr>(DataBase.DataBase.GetSpr_Struct_Podr());
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
                Spr_Struct_Podr item = collectionView.CurrentItem as Spr_Struct_Podr;
                if (item != null)
                    DataBase.DataBase.DeleteSpr_Struct_Podr(item);
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
            EditingElem = new Spr_Struct_Podr();
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
                Spr_Struct_Podr item = collectionView.CurrentItem as Spr_Struct_Podr;
                if (item != null)
                {
                    EditingElem = item.Copy() as Spr_Struct_Podr;
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