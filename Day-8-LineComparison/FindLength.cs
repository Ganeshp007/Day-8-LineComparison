using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_LineComparison
{
    internal class FindLength
    {
        public int len1;
        public int len2;
        public int x1;
        public int y1;
        public int x2;
        public int y2;


        public FindLength()//Constructor
        { 
            double[] StoringLength = new double[5];
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter value for  coordinate x1");
                this.x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for   coordinate y1");
                this.y1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter value for  first coordinate x2");
                this.x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for  first coordinate y2");
                this.y2 = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double FindingLength()//methd to calculate length
        {
         
            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }


        
    }
}
