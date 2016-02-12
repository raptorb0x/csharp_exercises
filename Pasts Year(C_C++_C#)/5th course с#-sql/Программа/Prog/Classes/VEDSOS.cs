using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class VEDSOS: Documents
    {
         public VEDSOS()
    {
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.VEDOST newf = new Forms.VEDOST("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.VEDOST newf = new Forms.VEDOST("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.VEDOST newf = new Forms.VEDOST("Удалить");
            newf.ShowDialog();
        }

    }
}
