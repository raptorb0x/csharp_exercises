using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.NEW.Clasess
{
    class JRRR : Classes.Documents
    {
        public void Insert(object sender, EventArgs e)
        {
            NEW.OUT2.JORPOSTOB newf = new NEW.OUT2.JORPOSTOB("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            NEW.OUT2.JORPOSTOB newf = new NEW.OUT2.JORPOSTOB("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            NEW.OUT2.JORPOSTOB newf = new NEW.OUT2.JORPOSTOB("Удалить");
            newf.ShowDialog();
        }
    }
}