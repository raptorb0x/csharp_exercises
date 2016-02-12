using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPRRabpoWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRrpINS newf = new Forms.SPRWork.SPRrpINS();
            newf.Show();
        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRrpDEL newf = new Forms.SPRWork.SPRrpDEL();
            newf.ShowDialog();


        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRrpUP newf = new Forms.SPRWork.SPRrpUP();
            newf.ShowDialog();
        }
    }
}
