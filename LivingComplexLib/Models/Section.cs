using System;
using System.Collections.Generic;
using System.Text;

namespace LivingComplexLib.Models
{
    internal class Section
    {
        public string Title { get; set; }
        public List<Floor> Floors { get; set; } = new List<Floor>();
        public House House { get; set; }

        public Section(string title, House house)
        {
            Title = title;
            House = house;
        }
    }
}
