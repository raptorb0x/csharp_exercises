using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Vid_Rab : BaseModel
    {
        public int Id { get; set; }
        public Spr_Dolj Dolj { get; set; }
        public string Name { get; set; }
        public string EdIzm { get; set; }

        public Spr_Vid_Rab()
        {
            Id = 0;
            Dolj = new Spr_Dolj();
            Name = string.Empty;
            EdIzm = string.Empty;
        }

        public override BaseModel Copy()
        {
            Spr_Dolj newDolj = this.Dolj == null ? null : this.Dolj.Copy() as Spr_Dolj;

            return new Spr_Vid_Rab() { Dolj = newDolj, Id = this.Id, Name = this.Name, EdIzm = this.EdIzm };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
