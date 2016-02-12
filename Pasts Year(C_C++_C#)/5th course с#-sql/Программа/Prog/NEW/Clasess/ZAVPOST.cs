using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.NEW.Class
{
    class ZAVPOST: Classes.Documents
    {
        public void Insert(object sender, EventArgs e)
        {
            NEW.ZAVPOST newf = new NEW.ZAVPOST("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            NEW.ZAVPOST newf = new NEW.ZAVPOST("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            NEW.ZAVPOST newf = new NEW.ZAVPOST("Удалить");
            newf.ShowDialog();
        }
    }
}
