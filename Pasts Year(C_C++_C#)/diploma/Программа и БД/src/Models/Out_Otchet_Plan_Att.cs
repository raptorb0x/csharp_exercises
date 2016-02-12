using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Otchet_Plan_Att : BaseModel
    {
        public string Id_Sotr { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string SotrName { get; set; }
        public string MinBall { get; set; }
        public string Ball { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? FactDate { get; set; }
        public DateTime? PovtDate { get; set; }

        public Out_Otchet_Plan_Att()
        {
            Id_Sotr = string.Empty;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            SotrName = string.Empty;
            MinBall = string.Empty;
            Ball = string.Empty;
            PlanDate = null;
            FactDate = null;
            PovtDate = null;
        }

        public override BaseModel Copy()
        {
            return new Out_Otchet_Plan_Att() { Ball = this.Ball, MinBall = this.MinBall, FactDate = this.FactDate, PovtDate = this.PovtDate, PlanDate = this.PlanDate, Id_Sotr = this.Id_Sotr, Dolj_Name = this.Dolj_Name, SotrName = this.SotrName, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Sotr.GetHashCode();
        }
    }
}
