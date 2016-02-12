using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class WorkJrRem : Interface.WorkDocInter
    {
        public void InsertIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.JrRemmsINS newf = new Forms.WorkDocs.JrRemmsINS();
             newf.ShowDialog();
        }

        public void DeleteIntoTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.JrRemmsDEL newf = new Forms.WorkDocs.JrRemmsDEL();
             newf.ShowDialog();
        }

        public void EditTable(object sender, EventArgs e)
        {
            Forms.WorkDocs.JrRemmsUP newf = new Forms.WorkDocs.JrRemmsUP();
             newf.ShowDialog();
        }
    }
}
