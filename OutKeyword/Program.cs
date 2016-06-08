using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        private static void Write(out int x)
        {
            x = 1;
            Console.WriteLine(x);
            Console.ReadLine();

        }

        static int Main(string[] args)
        {
            int y = 3;
            Write(out y);
            return 0;
        }
    }
}
