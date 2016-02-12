using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Svid_Pov_Kv : BaseModel
    {
        public int Id { get; set; }
        public Out_An_Tek GrafSotr { get; set; }
        public string DocName { get; set; }
        public DateTime? FactDate { get; set; }

        public In_Svid_Pov_Kv()
        {
            Id = 0;
            GrafSotr = new Out_An_Tek();
            DocName = string.Empty;
            FactDate = null;
        }

        public override BaseModel Copy()
        {
            Out_An_Tek newGrafSotr = this.GrafSotr == null ? null : this.GrafSotr.Copy() as Out_An_Tek;

            return new In_Svid_Pov_Kv() { FactDate = this.FactDate, DocName = this.DocName, GrafSotr = newGrafSotr, Id = this.Id };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

