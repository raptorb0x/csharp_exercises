using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_An_Tek : BaseModel
    {
        public int Id_Prikaz { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string SotrName { get; set; }
        public string OrgName { get; set; }
        public string ThemeName { get; set; }
        public DateTime? PlanDate { get; set; }

        public Out_An_Tek()
        {
            Id_Prikaz = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            SotrName = string.Empty;
            OrgName = string.Empty;
            OrgName = string.Empty;
            PlanDate = null;
        }

        public override BaseModel Copy()
        {
            return new Out_An_Tek() { OrgName = this.OrgName, ThemeName = this.ThemeName, PlanDate = this.PlanDate, Id_Prikaz = this.Id_Prikaz, Dolj_Name = this.Dolj_Name, SotrName = this.SotrName, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Prikaz.GetHashCode();
        }
    }
}
