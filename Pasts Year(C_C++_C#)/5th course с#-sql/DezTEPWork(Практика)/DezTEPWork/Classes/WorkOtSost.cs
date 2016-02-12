using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class WorkOtSost : Interface.WorkDocInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.OtSostINS newf = new Forms.WorkDocs.OtSostINS();
             newf.ShowDialog();
        }

        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.OtSostDEL newf = new Forms.WorkDocs.OtSostDEL();
             newf.ShowDialog();
        }

        public void EditTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.OtSostUP newf = new Forms.WorkDocs.OtSostUP();
             newf.ShowDialog();
        }
    }
}
