using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Zayav_Pov_Kv : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public string SRO { get; set; }
        public Spr_Theme Theme { get; set; }

        public In_Zayav_Pov_Kv()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            SRO = string.Empty;
            Theme = new Spr_Theme();
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;
            Spr_Theme newTheme = this.Theme == null ? null : this.Theme.Copy() as Spr_Theme;

            return new In_Zayav_Pov_Kv() { Sotr = newSotr, Id = this.Id, SRO = this.SRO, Theme = newTheme };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

