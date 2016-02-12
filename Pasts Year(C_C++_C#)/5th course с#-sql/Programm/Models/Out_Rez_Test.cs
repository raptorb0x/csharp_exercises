using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Out_Rez_Test : BaseModel
    {
        public int Id { get; set; }
        public Spr_Sotr Sotr { get; set; }
        public string SummBall { get; set; }
        public string ProhodBall { get; set; }
        public string Result { get; set; }

        public Out_Rez_Test()
        {
            Id = 0;
            Sotr = new Spr_Sotr();
            SummBall = string.Empty;
            ProhodBall = string.Empty;
            Result = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Sotr newSotr = this.Sotr == null ? null : this.Sotr.Copy() as Spr_Sotr;

            return new Out_Rez_Test() { Result = this.Result, Sotr = newSotr, Id = this.Id, ProhodBall = this.ProhodBall, SummBall = this.SummBall };
        }

        public void CalcResult()
        {
            double pb, sb;

            if (double.TryParse(SummBall, out sb) && double.TryParse(ProhodBall, out pb))
            {
                if (!(pb == sb && pb == 0))
                    Result = sb >= pb? "Прошел" : "Не прошел";
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

