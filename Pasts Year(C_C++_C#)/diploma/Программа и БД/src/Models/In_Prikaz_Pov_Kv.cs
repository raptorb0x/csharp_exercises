using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programm.Models
{
    public class In_Prikaz_Pov_Kv : BaseModel
    {
        public int Id { get; set; }
        public In_Zayav_Pov_Kv Zayav { get; set; }

        public In_Prikaz_Pov_Kv()
        {
            Id = 0;
            Zayav = new In_Zayav_Pov_Kv();
        }

        public override BaseModel Copy()
        {
            In_Zayav_Pov_Kv newZayav = this.Zayav == null ? null : this.Zayav.Copy() as In_Zayav_Pov_Kv;

            return new In_Prikaz_Pov_Kv() { Zayav = newZayav, Id = this.Id };
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

