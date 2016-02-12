using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DezTEPWork.Classes
{
    class SPRFondWork : Interface.SPRInter
    {
        public void InsertIntoTable(object sender, EventArgs e) 
        {
            Forms.SPRWork.SprFond newf = new Forms.SPRWork.SprFond();
            newf.ShowDialog();
            
        }
       public void UpdateTable(object sender, EventArgs e) 
        {
            
        }
       public void DeleteIntoTable(object sender, EventArgs e) 
        {
            Forms.SPRWork.SPRFondDEL newf = new Forms.SPRWork.SPRFondDEL();
              newf.ShowDialog();

        }
       public void EditTable(object sender, EventArgs e) 
       {
           Forms.SPRWork.SPRFondUP newf = new Forms.SPRWork.SPRFondUP();
              newf.ShowDialog();
       }
    }
}
