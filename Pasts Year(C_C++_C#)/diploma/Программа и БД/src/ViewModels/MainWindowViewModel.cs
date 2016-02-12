using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Programm.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
namespace Programm.ViewModels
{
    public class MainWindowViewModel: BaseViewModel
    {
        #region Private fields
        private List<DocumentGroupViewModel> _documentGroups;
        private List<DocumentViewModel> _documents;
        private RelayCommand _refreshCommand;
        private RelayCommand _deleteCommand;
        private RelayCommand _addCommand;
        private RelayCommand _editCommand;
        private RelayCommand _exitCommand;
        private DocumentViewModel _currentDocument;
        #endregion

        #region Constructors
        public MainWindowViewModel()
        {
            CreateDocuments();
            DataBase.DataBase.GenerateData();
            //ICollectionView collectionView = CollectionViewSource.GetDefaultView(Documents);
            //if (collectionView != null)
            //    collectionView.MoveCurrentTo(null);
        }
        #endregion

        #region Public properties
        public List<DocumentGroupViewModel> DocumentGroups
        {
            get { return _documentGroups; }
        }
        public List<DocumentViewModel> Documents
        {
            get { return _documents; }
        }
        public DocumentViewModel CurrentDocument
        {
            get
            {
                return _currentDocument;
            }
            set
            {
                _currentDocument = value;
                OnPropertyChanged("CurrentDocument");
            }
        }
        #endregion

        #region Commands
        #region ExitCommand
        public ICommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new RelayCommand(param => this.Exit());
                }

                return _exitCommand;
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
        #endregion

        #region RefreshCommand
        public ICommand RefreshCommand
        {
            get
            {
                if (_refreshCommand == null)
                {
                    _refreshCommand = new RelayCommand(param => this.Refresh(),
                                                       param => this.CanRefresh());
                }

                return _refreshCommand;
            }
        }

        public void Refresh()
        {
            if (CurrentDocument != null)
                CurrentDocument.Refresh();
        }
        public bool CanRefresh()
        {
            if (CurrentDocument != null)
                return CurrentDocument.CanRefresh();
            else
                return false;
        }
        #endregion

        #region DeleteCommand
        public ICommand DeleteCommand
        {
            
            get
            {
                
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand(param => this.Delete(),
                                                       param => this.CanDelete());
                }

                return _deleteCommand;
            }
        }

        public void Delete()
        {
            if ((CurrentDocument != null) && (MessageBox.Show("Восстановление данных будет невозможно!\r\n Продолжить?", "Подтверждение удаления", MessageBoxButtons.OKCancel) == DialogResult.OK))
                CurrentDocument.Delete();
        }
        public bool CanDelete()
        {
            if (CurrentDocument != null)
                return CurrentDocument.CanDelete();
            else
                return false;
        }
        #endregion

        #region AddCommand
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(param => this.Add(),
                                                       param => this.CanAdd());
                }

                return _addCommand;
            }
        }

        public void Add()
        {
            if (CurrentDocument != null)
                CurrentDocument.Add();
        }
        public bool CanAdd()
        {
            if (CurrentDocument != null)
                return CurrentDocument.CanAdd();
            else
                return false;
        }
        #endregion

        #region EditCommand
        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new RelayCommand(param => this.Edit(),
                                                       param => this.CanEdit());
                }

                return _editCommand;
            }
        }

        public void Edit()
        {
            if (CurrentDocument != null)
                CurrentDocument.Edit();
        }
        public bool CanEdit()
        {
            if (CurrentDocument != null)
                return CurrentDocument.CanEdit();
            else
                return false;
        }
        #endregion
        #endregion

        #region Public methods
        public void SelectDocument(DocumentViewModel doc)
        {
            CurrentDocument = doc;
            //ICollectionView collectionView = CollectionViewSource.GetDefaultView(Documents);
            //if (collectionView != null)
            //    collectionView.MoveCurrentTo(doc);
        }
        #endregion

        #region Private methods
        private void CreateDocuments()
        {
            if (_documentGroups == null)
            {
                _documentGroups = new List<DocumentGroupViewModel>();
            }
            else
            {
                _documentGroups.Clear();
            }

            if (_documents == null)
            {
                _documents = new List<DocumentViewModel>();
            }
            else
            {
                _documents.Clear();
            }

            DocumentGroupViewModel sprs = new DocumentGroupViewModel("Справочники");
            sprs.Documents.Add(new Spr_Struct_PodrViewModel("Справочник структурных подразделений", this));
            sprs.Documents.Add(new Spr_DoljViewModel("Справочник должностей", this));
            sprs.Documents.Add(new Spr_SotrViewModel("Справочник сотрудников", this));
            sprs.Documents.Add(new Spr_Vid_RabViewModel("Справочник видов работ", this));
            sprs.Documents.Add(new Spr_Norm_AttViewModel("Нормативы проведения аттестации", this));
            sprs.Documents.Add(new Spr_ThemeViewModel("Справочник тем семинаров", this));
            sprs.Documents.Add(new Spr_OrgViewModel("Справочник организаций", this));
            _documentGroups.Add(sprs);

            DocumentGroupViewModel indocs = new DocumentGroupViewModel("Входные документы");
            indocs.Documents.Add(new In_Ved_Ob_RabViewModel("Ведомость объемов работ", this));
            indocs.Documents.Add(new In_Ved_Zat_TrViewModel("Ведомость затрат труда", this));
            indocs.Documents.Add(new In_Trud_DogViewModel("Трудовой договор", this));
            indocs.Documents.Add(new In_Prikaz_NaimViewModel("Приказ о приеме", this));
            indocs.Documents.Add(new In_Prikaz_PerevodViewModel("Приказ о переводе", this));
            indocs.Documents.Add(new In_Prikaz_UvolViewModel("Приказ об увольнении", this));
            indocs.Documents.Add(new In_Pr_Att_KommViewModel("Протокол аттестационной комиссии", this));
           // indocs.Documents.Add(new In_Zayav_Pov_KvViewModel("Заявление на повышение квалификации", this));
           // indocs.Documents.Add(new In_Prikaz_Pov_KvViewModel("Приказ на повышение квалификации", this));
           // indocs.Documents.Add(new In_Svid_Pov_KvViewModel("Свидетельство о повышении квалификации", this));
            _documentGroups.Add(indocs);

            DocumentGroupViewModel outdocs = new DocumentGroupViewModel("Выходные документы");
            outdocs.Documents.Add(new In_Uch_SotrViewModel("Учет сотрудников подразделений", this));
            outdocs.Documents.Add(new Out_Shtat_RaspViewModel("Штатное расписание", this));
            outdocs.Documents.Add(new Out_Ved_Potr_KadrViewModel("Ведомость потребности в недостающих кадрах", this));
            outdocs.Documents.Add(new Out_Ved_Dv_KadrViewModel("Ведомость о движении кадров", this));
            outdocs.Documents.Add(new Out_Plan_AttViewModel("План проведения аттестации", this));
            outdocs.Documents.Add(new Out_Rez_TestViewModel("Отчет по результам тестирования кадров", this));
            outdocs.Documents.Add(new Out_Otchet_Plan_AttViewModel("Отчет о выполнении плана проведения аттестации", this));
            outdocs.Documents.Add(new Out_An_TekViewModel("Анализ текучести кадров", this));
            //outdocs.Documents.Add(new Out_Control_Graf_Pov_KvViewModel("Отчет о выполнении графика повышения квалификации", this));
            _documentGroups.Add(outdocs);

            foreach (var group in _documentGroups)
            {
                foreach (var doc in group.Documents)
                {
                    if (!_documents.Contains(doc))
                        _documents.Add(doc);
                }
            }
        }
        #endregion
    }
}
