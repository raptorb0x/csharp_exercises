using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public abstract class BaseModel
    {
        public abstract BaseModel Copy();
       public override bool Equals(object obj)
        {
            return this.GetType().Equals(obj.GetType()) && this.GetHashCode().Equals(obj.GetHashCode());
       }

       public abstract override int GetHashCode();
    }
}
