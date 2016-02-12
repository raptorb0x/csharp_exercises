using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DezTEPWork.Interface
{
    interface WorkDocInter
    {
        void InsertIntoTable(object sender, EventArgs e);
        void DeleteIntoTable(object sender, EventArgs e);
        void EditTable(object sender, EventArgs e);
    }

}
