using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Pr_Att_Komm : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public string SummBall { get; set; }
        public string ProhodBall { get; set; }
        public DateTime? Date { get; set; }

        public In_Pr_Att_Komm()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            SummBall = string.Empty;
            ProhodBall = string.Empty;
            Date = null;
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;

            return new In_Pr_Att_Komm() { Date = this.Date, Sotr = newSotr, Id = this.Id, ProhodBall = this.ProhodBall, SummBall = this.SummBall };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

