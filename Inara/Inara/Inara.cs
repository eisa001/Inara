using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocaliser;

namespace Inara
{
    class Core
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            IVocaliser output = new Vocaliser.Vocaliser();

            Console.WriteLine(output.Speaker(input));
        }
    }
}
