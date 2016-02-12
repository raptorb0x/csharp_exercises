using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Shtat_Rasp : BaseModel
    {
        public int Id_Dolj { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string Plan_Kolvo { get; set; }
        public string Oklad { get; set; }
        public string Nadbavki { get; set; }
        public string Pr_Vyplaty { get; set; }
        public string Fond { get; set; }

        public Out_Shtat_Rasp()
        {
            Id_Dolj = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            Plan_Kolvo = string.Empty;
            Oklad = string.Empty;
            Nadbavki = string.Empty;
            Fond = string.Empty;
            Pr_Vyplaty = string.Empty;
        }

        public override BaseModel Copy()
        {
            return new Out_Shtat_Rasp() { Pr_Vyplaty = this.Pr_Vyplaty, Id_Dolj = this.Id_Dolj, Dolj_Name = this.Dolj_Name, Fond = this.Fond, Nadbavki = this.Nadbavki, Oklad = this.Oklad, Plan_Kolvo = this.Plan_Kolvo, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Dolj.GetHashCode();
        }
    }
}
