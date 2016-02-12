using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Ob_Den_Srv : BaseModel
    {
        public string Year { get; set; }
        public string Summ { get; set; }

        public override BaseModel Copy()
        {
            return new Spr_Ob_Den_Srv() { Year = this.Year, Summ = this.Summ };
        }

        public Spr_Ob_Den_Srv()
        {
            Year = string.Empty;
            Summ = string.Empty;
        }

        public override int GetHashCode()
        {
            return Year.GetHashCode();
        }
    }
}
