using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class WorkPlRemYear : Interface.WorkDocInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.PlYearINS newf = new Forms.WorkDocs.PlYearINS();
             newf.ShowDialog();
        }

        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.PlYearDEL newf = new Forms.WorkDocs.PlYearDEL();
             newf.ShowDialog();
        }

        public void EditTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.PlYearUP newf = new Forms.WorkDocs.PlYearUP();
             newf.ShowDialog();
        }
    }
}
