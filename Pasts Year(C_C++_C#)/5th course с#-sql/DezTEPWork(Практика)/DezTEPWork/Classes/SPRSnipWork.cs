using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPRSnipWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRsnipINS newf = new Forms.SPRWork.SPRsnipINS();
             newf.ShowDialog();
        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRsnipDEL newf = new Forms.SPRWork.SPRsnipDEL();
             newf.ShowDialog();

        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRsnipUP newf = new Forms.SPRWork.SPRsnipUP();
             newf.ShowDialog();
        }
    }
}
