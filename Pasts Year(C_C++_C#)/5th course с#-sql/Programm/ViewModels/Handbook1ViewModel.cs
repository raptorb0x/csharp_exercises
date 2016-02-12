using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Programm.Models;
using System.Collections.ObjectModel;

namespace Programm.ViewModels
{
    public class Handbook1ViewModel:DocumentViewModel
    {
        private ObservableCollection<Handbook1> _data;
        private RelayCommand _selectCommand;

        public Handbook1ViewModel(string docName)
            : base(docName)
        {
        }

        public ObservableCollection<Handbook1> Data
        {
            get
            {
                if (_data == null)
                    _data = new ObservableCollection<Handbook1>();
                return _data;
            }
        }

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
            MainWindowViewModel.SelectDocument(this);
            this.Refresh();
        }
        #endregion

        public override void Refresh()
        {
            this.Data.Clear();

            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = r.Next(10); i < 10; i++)
            {
                this.Data.Add(new Handbook1() { Key = i.ToString(), Value = (i * 2).ToString() });
            }
        }
    }
}
