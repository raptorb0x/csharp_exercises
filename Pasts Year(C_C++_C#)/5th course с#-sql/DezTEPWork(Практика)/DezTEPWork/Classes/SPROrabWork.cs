using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPROrabWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRorINS newf = new Forms.SPRWork.SPRorINS();
            newf.ShowDialog();

        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {

            Forms.SPRWork.SPRorDEL newf = new Forms.SPRWork.SPRorDEL();
            newf.ShowDialog();
        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRorUP newf = new Forms.SPRWork.SPRorUP();
              newf.ShowDialog();
        }
    }
}
