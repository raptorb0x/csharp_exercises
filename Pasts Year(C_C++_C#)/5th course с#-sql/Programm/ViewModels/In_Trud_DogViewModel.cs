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
    public class In_Trud_DogViewModel : DocumentViewModel
    {
        #region Private fields
        private List<In_Trud_Dog> _data;
        private List<Spr_Sotr> _sotrs;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region In_Trud_Dog binding fields
        private In_Trud_Dog _editingElem;

        public In_Trud_Dog EditingElem
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
        public In_Trud_DogViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<In_Trud_Dog> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<In_Trud_Dog>();
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
                    In_Trud_Dog addElem = EditingElem.Copy() as In_Trud_Dog; 
                    DataBase.DataBase.AddIn_Trud_Dog(addElem);
                    break;
                case OperationType.Edit:
                    In_Trud_Dog editElem = EditingElem.Copy() as In_Trud_Dog;
                    DataBase.DataBase.EditIn_Trud_Dog(editElem);
                    break;
            }

            _opType = OperationType.None;
            IsEditing = false;
            EditingElem = null;
            this.Refresh();
        }

        public bool CanApprove()
        {
            double r;
            return EditingElem == null ? false : double.TryParse(EditingElem.Nadbavki, out r) && double.TryParse(EditingElem.PrVyp, out r) && double.TryParse(EditingElem.Oklad, out r);
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

            Data = new List<In_Trud_Dog>(DataBase.DataBase.GetIn_Trud_Dog());
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
                In_Trud_Dog item = collectionView.CurrentItem as In_Trud_Dog;
                if (item != null)
                    DataBase.DataBase.DeleteIn_Trud_Dog(item);
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
            EditingElem = new In_Trud_Dog();
            Sotrs = DataBase.DataBase.GetSpr_Sotr();
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
                In_Trud_Dog item = collectionView.CurrentItem as In_Trud_Dog;
                if (item != null)
                {
                    Sotrs = DataBase.DataBase.GetSpr_Sotr();
                    EditingElem = item.Copy() as In_Trud_Dog;
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
