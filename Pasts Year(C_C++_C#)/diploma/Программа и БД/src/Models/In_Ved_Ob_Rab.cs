using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Ved_Ob_Rab : BaseModel
    {
        public int Id { get; set; }
        public Spr_Vid_Rab VidRab { get; set; }
        public string Kolvo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public In_Ved_Ob_Rab()
        {
            Id = 0;
            VidRab = new Spr_Vid_Rab();
            Kolvo = string.Empty;
            StartDate = DateTime.Now;
            FinishDate = DateTime.Now;
        }
        public override BaseModel Copy()
        {
            return new In_Ved_Ob_Rab() { FinishDate = this.FinishDate, StartDate = this.StartDate, Kolvo = this.Kolvo, Id = this.Id, VidRab = this.VidRab == null ? null : this.VidRab.Copy() as Spr_Vid_Rab };
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
