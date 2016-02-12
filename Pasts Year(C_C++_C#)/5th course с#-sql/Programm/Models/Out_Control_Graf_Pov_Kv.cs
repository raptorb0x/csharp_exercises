using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Control_Graf_Pov_Kv : BaseModel
    {
        public int Id_Prikaz { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string SotrName { get; set; }
        public string OrgName { get; set; }
        public string ThemeName { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? FactDate { get; set; }
        public string DocName { get; set; }

        public Out_Control_Graf_Pov_Kv()
        {
            Id_Prikaz = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            SotrName = string.Empty;
            OrgName = string.Empty;
            OrgName = string.Empty;
            PlanDate = null;
            FactDate = null;
            DocName = string.Empty;
        }

        public override BaseModel Copy()
        {
            return new Out_Control_Graf_Pov_Kv() { DocName = this.DocName, FactDate = this.FactDate, OrgName = this.OrgName, ThemeName = this.ThemeName, PlanDate = this.PlanDate, Id_Prikaz = this.Id_Prikaz, Dolj_Name = this.Dolj_Name, SotrName = this.SotrName, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Prikaz.GetHashCode();
        }
    }
}
