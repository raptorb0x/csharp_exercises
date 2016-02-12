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
    public class Spr_OrgViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Spr_Org> _data;
        private List<Spr_Theme> _themes;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region Spr_Org binding fields
        private Spr_Org _editingElem;

        public Spr_Org EditingElem
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
        public Spr_OrgViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<Spr_Org> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Spr_Org>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public List<Spr_Theme> Themes
        {
            get
            {
                if (_themes == null)
                    _themes = new List<Spr_Theme>();
                return _themes;
            }
            private set
            {
                _themes = value;
                OnPropertyChanged("Themes");
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
                    Spr_Org addElem = EditingElem.Copy() as Spr_Org; 
                    DataBase.DataBase.AddSpr_Org(addElem);
                    break;
                case OperationType.Edit:
                    Spr_Org editElem = EditingElem.Copy() as Spr_Org;
                    DataBase.DataBase.EditSpr_Org(editElem);
                    break;
            }

            _opType = OperationType.None;
            EditingElem = null;
            IsEditing = false;
            this.Refresh();
        }

        public bool CanApprove()
        {
            double e;
            return EditingElem != null && EditingElem.Theme != null && !(EditingElem.Theme.Id==0) && double.TryParse(EditingElem.Cost, out e);
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

            Data = new List<Spr_Org>(DataBase.DataBase.GetSpr_Org());
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
                Spr_Org item = collectionView.CurrentItem as Spr_Org;
                if (item != null)
                    DataBase.DataBase.DeleteSpr_Org(item);
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
            EditingElem = new Spr_Org();
            Themes = DataBase.DataBase.GetSpr_Theme();
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
                Spr_Org item = collectionView.CurrentItem as Spr_Org;
                if (item != null)
                {
                    Themes = DataBase.DataBase.GetSpr_Theme();
                    EditingElem = item.Copy() as Spr_Org;
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
