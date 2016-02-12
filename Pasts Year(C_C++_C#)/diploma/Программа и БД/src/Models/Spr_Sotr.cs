using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Sotr : BaseModel
    {
        public int Id { get; set; }
        public Spr_Dolj Dolj { get; set; }
        public string Name { get; set; }
        public string Staj { get; set; }

        public Spr_Sotr()
        {
            Id = 0;
            Dolj = new Spr_Dolj();
            Name = string.Empty;
            Staj = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Dolj newDolj = this.Dolj == null ? null : this.Dolj.Copy() as Spr_Dolj;

            return new Spr_Sotr() { Dolj = newDolj, Id = this.Id, Name = this.Name, Staj = this.Staj };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
