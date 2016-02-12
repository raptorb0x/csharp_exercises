using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Ved_Potr_Kadr : BaseModel
    {
        public int Id_Dolj { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string Plan_Kolvo { get; set; }
        public string Uch_Kolvo { get; set; }
        public string Tr_Kolvo { get; set; }

        public Out_Ved_Potr_Kadr()
        {
            Id_Dolj = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            Plan_Kolvo = string.Empty;
            Uch_Kolvo = string.Empty;
            Tr_Kolvo = string.Empty;
        }

        public override BaseModel Copy()
        {
            return new Out_Ved_Potr_Kadr() { Tr_Kolvo = this.Tr_Kolvo, Id_Dolj = this.Id_Dolj, Dolj_Name = this.Dolj_Name, Uch_Kolvo = this.Uch_Kolvo, Plan_Kolvo = this.Plan_Kolvo, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Dolj.GetHashCode();
        }
    }
}
