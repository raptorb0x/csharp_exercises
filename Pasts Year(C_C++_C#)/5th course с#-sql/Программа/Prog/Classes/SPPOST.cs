using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    class SPPOST: Classes.Documents
    {

        public SPPOST()
        { 
        
        }

        public void Insert(object sender, EventArgs e)
        {
            Forms.SPPOSTForm newf = new Forms.SPPOSTForm("Вставить");
            newf.ShowDialog();
        }
        public void Update(object sender, EventArgs e)
        {
            Forms.SPPOSTForm newf = new Forms.SPPOSTForm("Изменить");
            newf.ShowDialog();
        }
        public void Delete(object sender, EventArgs e)
        {
            Forms.SPPOSTForm newf = new Forms.SPPOSTForm("Удалить");
            newf.ShowDialog();
        }
    }
}
