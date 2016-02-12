using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class SPROBJ : Documents
    {

        public void Insert(object sender, EventArgs e)
        {
            Forms.SPROBJ newf = new Forms.SPROBJ("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.SPROBJ newf = new Forms.SPROBJ("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.SPROBJ newf = new Forms.SPROBJ("Удалить");
            newf.ShowDialog();
        }

    }
}
