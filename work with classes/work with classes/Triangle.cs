using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_classes
{
    internal class Triangle
    {
        public Triangle(double ang, double rand)
        {
            Ang1 = ang;
            Ang2 = 180 - ang - rand;
            Ang3 = 180 - ang - (180 - ang - rand);

        }

        public double Ang1 { get; set; }                          
        public double Ang2 { get; set; }
        public double Ang3 { get; set; }

        public override string ToString()
        {
            return "(" +Ang1 + "+" + Ang2 + "+" + Ang3+ ")";
        }
    }
    



}
