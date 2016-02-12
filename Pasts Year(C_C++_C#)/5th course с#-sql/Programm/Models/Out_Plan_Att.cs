using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Plan_Att : BaseModel
    {
        public int Id_Sotr { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string SotrName { get; set; }
        public DateTime? PlanDate { get; set; }

        public Out_Plan_Att()
        {
            Id_Sotr = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            SotrName = string.Empty;
            PlanDate = null;
        }

        public override BaseModel Copy()
        {
            return new Out_Plan_Att() { PlanDate = this.PlanDate, Id_Sotr = this.Id_Sotr, Dolj_Name = this.Dolj_Name, SotrName = this.SotrName, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Sotr.GetHashCode();
        }
    }
}
