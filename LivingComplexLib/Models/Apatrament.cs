using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LivingComplexLib.Models
{
    public class Apatrament
    {
        /// <summary>
        /// Код планировки
        /// </summary>
        public string Kod { get; set; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; } = 0;

        /// <summary>
        /// Этаж
        /// </summary>
        public Floor Floor { get; set; }


        /// <summary>
        /// Общая площадь 
        /// </summary>
        public double TotalArea { get; set; } = 0;

        /// <summary>
        /// Gets or sets the summer room.
        /// </summary>
        /// <value>
        /// The summer room.
        /// </value>
        public string SummerRoom { get; set; }

        public Apatrament() { }

        public Apatrament(string number, Floor floor)
        {
            Number = number;
            Floor = floor;
        }
    }
}
