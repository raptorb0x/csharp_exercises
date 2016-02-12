using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.ViewModels
{
    public abstract class DocumentViewModel:BaseViewModel
    {
        private string _documentName;
        protected MainWindowViewModel _mainModelView;

        public DocumentViewModel(string documentName, MainWindowViewModel mainModelView)
        {
            _documentName = documentName;
            _mainModelView = mainModelView;
        }

        public string DocumentName
        {
            get { return _documentName; }
        }

        public override string ToString()
        {
            return DocumentName;
        }

        public abstract void Refresh();
        public abstract bool CanRefresh();

        public abstract void Delete();
        public abstract bool CanDelete();

        public abstract void Add();
        public abstract bool CanAdd();

        public abstract void Edit();
        public abstract bool CanEdit();
    }
}
