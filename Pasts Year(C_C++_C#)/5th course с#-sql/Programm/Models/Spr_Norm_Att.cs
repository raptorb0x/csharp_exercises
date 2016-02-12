using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Norm_Att : BaseModel
    {
        public int Id { get; set; }
        public Spr_Dolj Dolj { get; set; }
        public string Period { get; set; }

        public Spr_Norm_Att()
        {
            Id = 0;
            Dolj = new Spr_Dolj();
            Period = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Dolj newDolj = this.Dolj == null ? null : this.Dolj.Copy() as Spr_Dolj;

            return new Spr_Norm_Att() { Dolj = newDolj, Id = this.Id, Period = this.Period };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
