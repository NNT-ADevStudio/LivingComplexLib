using System;
using System.Collections.Generic;
using System.Text;

namespace LivingComplexLib.Models
{
    internal class Project
    {
        public string Title { get; set; }
        public List<House> HouseList { get; set; } = new List<House>();

        public Project() { }

        public Project(string title)
            => Title = title;
    }
}
