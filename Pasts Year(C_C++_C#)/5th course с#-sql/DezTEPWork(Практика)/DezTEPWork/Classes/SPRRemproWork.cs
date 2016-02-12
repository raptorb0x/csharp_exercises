using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPRRemproWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRremproINS newf = new Forms.SPRWork.SPRremproINS();
            newf.ShowDialog();
        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRremproDEL newf = new Forms.SPRWork.SPRremproDEL();
            newf.ShowDialog();

        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRremproUP newf = new Forms.SPRWork.SPRremproUP();
            newf.ShowDialog();
        }
    }
}
