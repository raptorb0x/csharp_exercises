using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.NEW.Class
{
    class MAGPOST : Classes.Documents
    {
        public void Insert(object sender, EventArgs e)
        {
            NEW.MAGPOST newf = new NEW.MAGPOST("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            NEW.MAGPOST newf = new NEW.MAGPOST("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            NEW.MAGPOST newf = new NEW.MAGPOST("Удалить");
            newf.ShowDialog();
        }
    }
}
