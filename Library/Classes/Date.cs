using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    internal class Date
    {
        private int day { get; set; }
        private int month { get; set; }
        private int year { get; set; }

        public Date(int day ,int mounth , int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }
}
