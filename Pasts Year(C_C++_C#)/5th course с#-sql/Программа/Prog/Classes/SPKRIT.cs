using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class SPKRIT:Documents
    {
        public SPKRIT()
        {
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.SPCRIT newf = new Forms.SPCRIT("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.SPCRIT newf = new Forms.SPCRIT("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.SPCRIT newf = new Forms.SPCRIT("Удалить");
            newf.ShowDialog();
        }
    }
}
