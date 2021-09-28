using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project.Models
{
    public class MyPoint
    {
        public double X { get; set; }

        public double Y { get; set; }

        public MyPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
