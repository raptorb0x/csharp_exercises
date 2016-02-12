using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Ved_Zat_Tr : BaseModel
    {
        public int Id { get; set; }
        public Spr_Vid_Rab VidRab { get; set; }
        public string NormVr { get; set; }
        public string ChelChas { get; set; }
        public string ChelDni { get; set; }

        public In_Ved_Zat_Tr()
        {
            Id = 0;
            VidRab = new Spr_Vid_Rab();
            NormVr = string.Empty;
            ChelChas = string.Empty;
            ChelDni = string.Empty;
        }
        public override BaseModel Copy()
        {
            return new In_Ved_Zat_Tr() { VidRab = this.VidRab == null ? null : this.VidRab.Copy() as Spr_Vid_Rab, ChelChas = this.ChelChas, ChelDni = this.ChelDni, Id = this.Id, NormVr = this.NormVr };
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
