using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class SPRTarifWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRtarifINS newf = new Forms.SPRWork.SPRtarifINS();
            newf.ShowDialog();
        }
        public void UpdateTable(object sender, EventArgs e)
        {

        }
        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRtarifDEL newf = new Forms.SPRWork.SPRtarifDEL();
            newf.ShowDialog();

        }
        public void EditTable(object sender, EventArgs e)
        {
            Forms.SPRWork.SPRtarifUP newf = new Forms.SPRWork.SPRtarifUP();
            newf.ShowDialog();
        }
    }
}
