using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class SPMAT:Documents
    {
         public SPMAT()
    {
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.SPRMAT newf = new Forms.SPRMAT("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.SPRMAT newf = new Forms.SPRMAT("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.SPRMAT newf = new Forms.SPRMAT("Удалить");
            newf.ShowDialog();
        }

    }
}
