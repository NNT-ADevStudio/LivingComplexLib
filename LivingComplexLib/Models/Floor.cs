using System;
using System.Collections.Generic;
using System.Text;

namespace LivingComplexLib.Models
{
    public class Floor
    {
        public int Number { get; set; }

        public Section Section { get; set; }

        public List<Apatrament> Apatraments { get; set; } = new List<Apatrament>();

        public Floor(int number, Section section)
        {
            Number = number;
            Section = section;
        }
    }
}
