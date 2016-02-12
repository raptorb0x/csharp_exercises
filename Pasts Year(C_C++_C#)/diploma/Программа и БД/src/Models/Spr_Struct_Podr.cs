using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Struct_Podr : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

     public override BaseModel Copy()
        {
            return new Spr_Struct_Podr() { Id = this.Id, Name = this.Name };
      }

        public Spr_Struct_Podr()
        {
           Id = 0;
           Name = string.Empty;
        }
        
        public override int GetHashCode()
       {
         return Id.GetHashCode();
        }
    }
}
