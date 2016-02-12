using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.NEW.Class
{
    class SPDOC : Classes.Documents
    {
        public void Insert(object sender, EventArgs e)
        {
            NEW.SPDOC newf = new NEW.SPDOC("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            NEW.SPDOC newf = new NEW.SPDOC("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            NEW.SPDOC newf = new NEW.SPDOC("Удалить");
            newf.ShowDialog();
        }
    }
}
