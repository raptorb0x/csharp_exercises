using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Prog.NEW.Class
{
    class NACKOT : Classes.Documents
    {
        public void Insert(object sender, EventArgs e)
        {
            NEW.NACKOT newf = new NEW.NACKOT("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            NEW.NACKOT newf = new NEW.NACKOT("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            NEW.NACKOT newf = new NEW.NACKOT("Удалить");
            newf.ShowDialog();
        }
    }
}
