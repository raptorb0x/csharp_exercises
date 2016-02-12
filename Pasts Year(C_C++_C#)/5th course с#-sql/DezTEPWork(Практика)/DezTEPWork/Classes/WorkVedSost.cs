using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Classes
{
    class WorkVedSost : Interface.WorkDocInter
    {
        public void InsertIntoTable(object sender, EventArgs e) 
        {
            Forms.WorkDocs.VedSostINS newf = new Forms.WorkDocs.VedSostINS();
            newf.ShowDialog();
        }

        public void DeleteIntoTable(object sender, EventArgs e) 
        {
            Forms.WorkDocs.VedSostDEL newf = new Forms.WorkDocs.VedSostDEL();
            newf.ShowDialog();
        }

        public  void EditTable(object sender, EventArgs e) 
        {
            Forms.WorkDocs.VedSostUP newf = new Forms.WorkDocs.VedSostUP();
            newf.ShowDialog();
        }
    }
}
