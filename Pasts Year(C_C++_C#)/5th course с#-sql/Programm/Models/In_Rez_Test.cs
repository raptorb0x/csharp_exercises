using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Rez_Test : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public string SummBall { get; set; }
        public string ProhodBall { get; set; }

        public In_Rez_Test()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            SummBall = string.Empty;
            ProhodBall = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;

            return new In_Rez_Test() { Sotr = newSotr, Id = this.Id, ProhodBall = this.ProhodBall, SummBall = this.SummBall };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

