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
    public class Out_Rez_TestViewModel : DocumentViewModel
    {
        #region Private fields
        private List<Out_Rez_Test> _data;
        private Out_Rez_Test _itogPass;
        private Out_Rez_Test _itogNotPass;
        private List<Spr_Sotr> _sotrs;
        private RelayCommand _selectCommand;
        private bool _isEditing;
        private OperationType _opType = OperationType.None;
        #endregion

        #region Constructors
        public Out_Rez_TestViewModel(string docName, MainWindowViewModel mainModelView)
            : base(docName, mainModelView)
        {
        }
        #endregion

        #region Public properties
        public List<Out_Rez_Test> Data
        {
            get
            {
                if (_data == null)
                    _data = new List<Out_Rez_Test>();
                return _data;
            }
            private set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }
        public Out_Rez_Test ItogPass
        {
            get
            {
                if (_itogPass == null)
                    _itogPass = new Out_Rez_Test();
                return _itogPass;
            }
            private set
            {
                _itogPass = value;
                OnPropertyChanged("ItogPass");
            }
        }
        public Out_Rez_Test ItogNotPass
        {
            get
            {
                if (_itogNotPass == null)
                    _itogNotPass = new Out_Rez_Test();
                return _itogNotPass;
            }
            private set
            {
                _itogNotPass = value;
                OnPropertyChanged("ItogNotPass");
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
        
        #region Operations methods
        #region Refresh
        public override void Refresh()
        {
            this.Data.Clear();
            Data = new List<Out_Rez_Test>(DataBase.DataBase.GetOut_Rez_Test());
            ItogNotPass = DataBase.DataBase.GetItogNotPass();
            ItogPass = DataBase.DataBase.GetItogPass();
            
        }

        public override bool CanRefresh()
        {
            return true && _opType == OperationType.None;
        }
        #endregion

        #region Delete
        public override void Delete()
        {
            
        }

        public override bool CanDelete()
        {
            
                return false;
        }
        #endregion

        #region Add
        public override void Add()
        {
        }

        public override bool CanAdd()
        {
            return false;
        }
        #endregion

        #region Edit
        public override void Edit()
        {
            
        }

        public override bool CanEdit()
        {
                return false;
        }
        #endregion
        #endregion        
    }
}
