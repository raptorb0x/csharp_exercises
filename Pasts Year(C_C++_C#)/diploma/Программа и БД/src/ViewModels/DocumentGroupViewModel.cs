using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Programm.ViewModels
{
    public class DocumentGroupViewModel:BaseViewModel
    {
        private List<DocumentViewModel> _documents;
        private string _groupName;

        public DocumentGroupViewModel(string groupName)
        {
            _documents = new List<DocumentViewModel>();
            _groupName = groupName;
        }

        public string GroupName
        {
            get { return _groupName; }
        }
        public List<DocumentViewModel> Documents
        {
            get { return _documents; }
        }
    }
}
