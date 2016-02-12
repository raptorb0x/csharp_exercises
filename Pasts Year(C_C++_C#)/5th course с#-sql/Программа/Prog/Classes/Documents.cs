using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog.Classes
{
    interface Documents
    {
        void Insert(object sender, EventArgs e);
        void Update(object sender, EventArgs e);
        void Delete(object sender, EventArgs e);
    }
}
