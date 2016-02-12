using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Trud_Dog : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public string Oklad { get; set; }
        public string Nadbavki { get; set; }
        public string PrVyp { get; set; }
        public string Zp { get; set; }

        public In_Trud_Dog()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            Oklad = string.Empty;
            Nadbavki = string.Empty;
            PrVyp = string.Empty;
            Zp = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;

            return new In_Trud_Dog() { Sotr = newSotr, Id = this.Id, Zp = this.Zp, PrVyp = this.PrVyp, Nadbavki = this.Nadbavki, Oklad = this.Oklad};
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

