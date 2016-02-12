using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class VEDP:Documents
    {
        public VEDP()
    {
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.VEDP newf = new Forms.VEDP("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.VEDP newf = new Forms.VEDP("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.VEDP newf = new Forms.VEDP("Удалить");
            newf.ShowDialog();
        }
    }
}
