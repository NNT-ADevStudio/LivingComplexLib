using System;
using System.Collections.Generic;
using System.Text;

namespace LivingComplexLib.Models
{
    internal class House
    {
        public string Title { get; set; }
        public Project Project { get; set; } = new Project();

        public List<Section> Sections { get; set; } = new List<Section>();

        public House() { }

        public House(string title, Project project)
        {
            Title = title;
            Project = project;
        }
    }
}
