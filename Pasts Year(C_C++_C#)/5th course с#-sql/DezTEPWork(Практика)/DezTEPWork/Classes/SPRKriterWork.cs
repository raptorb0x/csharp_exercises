using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPRKriterWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRKritINS newf = new Forms.SPRWork.SPRKritINS();
             newf.ShowDialog();

        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRKritDEL newf = new Forms.SPRWork.SPRKritDEL();
            newf.ShowDialog();
        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRKritUP newf = new Forms.SPRWork.SPRKritUP();
            newf.ShowDialog();
        }
    }
}
