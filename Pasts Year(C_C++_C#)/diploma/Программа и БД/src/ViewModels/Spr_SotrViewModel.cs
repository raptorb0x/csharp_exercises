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
using System.Windows;

namespace Programm.ViewModels
{
    public class Spr_SotrViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Spr_Sotr> _data;
        private RelayCommand _selectCommand;
        private RelayCommand _addApproveCommand;
        private RelayCommand _addCancellCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region Spr_Sotr binding fields
        private Spr_Sotr _editingElem;

        public Spr_Sotr EditingElem
        {
            get { return _editingElem; }
            set
            {
                _editingElem = value;
                OnPropertyChanged("EditingElem");
            }
        }

        private List<Spr_Dolj> _doljColl;

        public List<Spr_Dolj> DoljColl
        {
            get 
            {
                if (_doljColl == null)
                    _doljColl = new List<Spr_Dolj>();
                return _doljColl; 
            }
            set 
            { 
                _doljColl = value;
                OnPropertyChanged("DoljColl");
            }
        }

        private List<Spr_Struct_Podr> _podrColl;

        public List<Spr_Struct_Podr> PodrColl
        {
            get 
            {
                if (_podrColl == null)
                    _podrColl = new List<Spr_Struct_Podr>();
                return _podrColl; 
            }
            set 
            { 
                _podrColl = value;
                OnPropertyChanged("PodrColl");
            }
        }

        private ICollectionView _podrsColView; 

        #endregion

        #region Constructors
        public Spr_SotrViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
            //_podrsColView = CollectionViewSource.GetDefaultView(PodrColl);
            //if (_podrsColView != null)
            //    _podrsColView.CurrentChanged += new EventHandler(_podrsColView_CurrentChanged);
        }

        void _podrsColView_CurrentChanged(object sender, EventArgs e)
        {
            Spr_Struct_Podr curPodr = _podrsColView.CurrentItem as Spr_Struct_Podr;
            if (curPodr != null)
            {
                DoljColl = DataBase.DataBase.GetDoljByPodr(curPodr);
                OnPropertyChanged("EditingElem");
            }
        }

        
        #endregion

        #region Public properties
        public List<Spr_Sotr> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Spr_Sotr>();
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
            //ICollectionView doljCollectionView = CollectionViewSource.GetDefaultView(DoljColl);
            //if (doljCollectionView != null)
            //{
            //    EditingElem.Dolj = doljCollectionView.CurrentItem as Spr_Dolj;
            //}

            //ICollectionView podrCollectionView = CollectionViewSource.GetDefaultView(PodrColl);
            //if (podrCollectionView != null)
            //{
            //    EditingElem.Podr = podrCollectionView.CurrentItem as Spr_Struct_Podr;
            //}

            switch (_opType)
            {
                case OperationType.Add:
                    Spr_Sotr addElem = EditingElem.Copy() as Spr_Sotr;
                    DataBase.DataBase.AddSpr_Sotr(addElem);
                    break;
                case OperationType.Edit:
                    Spr_Sotr editElem = EditingElem.Copy() as Spr_Sotr;
                    DataBase.DataBase.EditSpr_Sotr(editElem);
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

            Data = new List<Spr_Sotr>(DataBase.DataBase.GetSpr_Sotr());
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
                Spr_Sotr item = collectionView.CurrentItem as Spr_Sotr;
                if (item != null)
                    DataBase.DataBase.DeleteSpr_Sotr(item);
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
            EditingElem = new Spr_Sotr();
            PodrColl = DataBase.DataBase.GetSpr_Struct_Podr();
            if (_podrsColView != null)
                _podrsColView.CurrentChanged -= new EventHandler(_podrsColView_CurrentChanged);
            _podrsColView = CollectionViewSource.GetDefaultView(PodrColl);
            if (_podrsColView != null)
            {
                _podrsColView.CurrentChanged += new EventHandler(_podrsColView_CurrentChanged);
                _podrsColView.Refresh();
            }
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
                Spr_Sotr item = collectionView.CurrentItem as Spr_Sotr;
                if (item != null)
                {
                    PodrColl = DataBase.DataBase.GetSpr_Struct_Podr();
                    if (_podrsColView != null)
                        _podrsColView.CurrentChanged -= new EventHandler(_podrsColView_CurrentChanged);
                    _podrsColView = CollectionViewSource.GetDefaultView(PodrColl);
                    if (_podrsColView != null)
                    {
                        _podrsColView.CurrentChanged += new EventHandler(_podrsColView_CurrentChanged);
                        _podrsColView.Refresh();
                    }
                    EditingElem =item.Copy() as Spr_Sotr;

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