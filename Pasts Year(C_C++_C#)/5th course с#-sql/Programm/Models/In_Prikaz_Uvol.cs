using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Prikaz_Uvol : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public Spr_Struct_Podr OldPodr { get; set; }
        public DateTime DatePr { get; set; }
        public string PrType { get; set; }
        public string Prichina { get; set; }

        public In_Prikaz_Uvol()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            OldPodr = new Spr_Struct_Podr();
            PrType = string.Empty;
            Prichina = string.Empty;
            DatePr = DateTime.Now;
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;
            Spr_Struct_Podr newOldPodr = this.OldPodr == null ? null : this.OldPodr.Copy() as Spr_Struct_Podr;

            return new In_Prikaz_Uvol() { Sotr = newSotr, Id = this.Id, OldPodr = newOldPodr, PrType = this.PrType, Prichina = this.Prichina, DatePr = this.DatePr };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

