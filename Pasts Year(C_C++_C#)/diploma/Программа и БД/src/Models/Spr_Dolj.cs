using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Dolj : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Spr_Struct_Podr Podr { get; set; }

        public override BaseModel Copy()
        {
            return new Spr_Dolj() { Id = this.Id, Name = this.Name, Podr = this.Podr == null ? null : this.Podr.Copy() as Spr_Struct_Podr};
        }

        public Spr_Dolj()
        {
            Id = 0;
            Name = string.Empty;
            Podr = new Spr_Struct_Podr();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
