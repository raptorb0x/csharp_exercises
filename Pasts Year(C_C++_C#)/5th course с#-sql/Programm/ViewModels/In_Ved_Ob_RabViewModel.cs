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
    public class In_Ved_Ob_RabViewModel : DocumentViewModel
    {
        #region Private fields
        private List<In_Ved_Ob_Rab> _data;
        private List<Spr_Vid_Rab> _vidrabs;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region In_Ved_Ob_Rab binding fields
        private In_Ved_Ob_Rab _editingElem;

        public In_Ved_Ob_Rab EditingElem
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
        public In_Ved_Ob_RabViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<In_Ved_Ob_Rab> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<In_Ved_Ob_Rab>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public List<Spr_Vid_Rab> VidRabs
        {
            get
            {
                if (_vidrabs == null)
                    _vidrabs = new List<Spr_Vid_Rab>();
                return _vidrabs;
            }
            private set
            {
                _vidrabs = value;
                OnPropertyChanged("VidRabs");
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
                    In_Ved_Ob_Rab addElem = EditingElem.Copy() as In_Ved_Ob_Rab; 
                    DataBase.DataBase.AddIn_Ved_Ob_Rab(addElem);
                    break;
                case OperationType.Edit:
                    In_Ved_Ob_Rab editElem = EditingElem.Copy() as In_Ved_Ob_Rab;
                    DataBase.DataBase.EditIn_Ved_Ob_Rab(editElem);
                    break;
            }

            _opType = OperationType.None;
            EditingElem = null;
            IsEditing = false;
            this.Refresh();
        }

        public bool CanApprove()
        {
            double r;
            return EditingElem == null ? false : double.TryParse(EditingElem.Kolvo, out r);
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

            Data = new List<In_Ved_Ob_Rab>(DataBase.DataBase.GetIn_Ved_Ob_Rab());
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
                In_Ved_Ob_Rab item = collectionView.CurrentItem as In_Ved_Ob_Rab;
                if (item != null)
                    DataBase.DataBase.DeleteIn_Ved_Ob_Rab(item);
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
            EditingElem = new In_Ved_Ob_Rab();
            VidRabs = DataBase.DataBase.GetSpr_Vid_Rab();
            ICollectionView colV = CollectionViewSource.GetDefaultView(VidRabs);
            if (colV != null)
                colV.MoveCurrentToFirst();
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
                In_Ved_Ob_Rab item = collectionView.CurrentItem as In_Ved_Ob_Rab;
                if (item != null)
                {
                    VidRabs = DataBase.DataBase.GetSpr_Vid_Rab();
                    EditingElem = item.Copy() as In_Ved_Ob_Rab;
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
