using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class Spr_Org : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Spr_Theme Theme { get; set; }
        public DateTime? Date { get; set; }
        public string Cost { get; set; }

        public override BaseModel Copy()
        {
            return new Spr_Org() { Cost = this.Cost, Date = this.Date, Id = this.Id, Name = this.Name, Theme = this.Theme == null ? null : this.Theme.Copy() as Spr_Theme };
        }

        public Spr_Org()
        {
            Id = 0;
            Name = string.Empty;
            Theme = new Spr_Theme();
            Cost = string.Empty;
            Date = null;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
