using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_LineComparison
{
    internal class CompareLines
    {
        public void Comparelines(double len1, double len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("both lines are equal");
            }
        }
    }
}
