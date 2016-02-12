using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Ved_Dv_Kadr : BaseModel
    {
        public string Year { get; set; }
        public int Id_Podr { get; set; }
        public string Podr_Name { get; set; }
        public string Dolj_Name { get; set; }
        public string Prinyato { get; set; }
        public string Uvoleno { get; set; }
        public string Perevedeno { get; set; }

        public Out_Ved_Dv_Kadr()
        {
            Year = string.Empty;
            Id_Podr = 0;
            Podr_Name = string.Empty;
            Dolj_Name = string.Empty;
            Prinyato = string.Empty;
            Uvoleno = string.Empty;
            Perevedeno = string.Empty;
        }

        public override BaseModel Copy()
        {
            return new Out_Ved_Dv_Kadr() { Year = this.Year, Dolj_Name = this.Dolj_Name, Perevedeno = this.Perevedeno, Prinyato = this.Prinyato, Uvoleno = this.Uvoleno, Id_Podr = this.Id_Podr, Podr_Name = this.Podr_Name };
        }

        public override int GetHashCode()
        {
            return Id_Podr.GetHashCode();
        }
    }
}
