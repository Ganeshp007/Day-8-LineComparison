using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_LineComparison
{
    internal class FindEquality
    {
        public void EqualityMethod(double len1, double len2)
        {
            if (len1.Equals(len2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}
