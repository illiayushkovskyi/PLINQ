using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new int[1000000];

            for (int i = 0; i < number.Length; i++)
                number[i] = i;

            number[800] = 3000;
            number[6789] = -2;
            number[7000] = 94;
            number[85500] = -91107;
            number[802300] = 300;
            number[999000] = -70456;
            

            var negatives = from val in number.AsParallel()where val < 0 select val;

            foreach(var var in negatives)
            {
                Console.WriteLine(var);

                Console.ReadKey();
;            }
        }
    }
}
