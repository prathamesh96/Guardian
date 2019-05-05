using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guardian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Member One Changes.");
        }


        public static void Display()
        {
            Console.WriteLine("Display Changed By Member Two");
        }
    }
}
