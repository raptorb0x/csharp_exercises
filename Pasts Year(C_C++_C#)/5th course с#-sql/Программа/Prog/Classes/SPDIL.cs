using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class SPDIL:Classes.Documents
    {
         
    public SPDIL()
    {
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.SPDIL newf = new Forms.SPDIL("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.SPDIL newf = new Forms.SPDIL("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.SPDIL newf = new Forms.SPDIL("Удалить");
            newf.ShowDialog();
        }
    }
}
