using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDemo
{
    //  This program demo. how to call functions from partial class
    class PartialDemo
    {
        static void Main()
        {
            FourWheeler fourWheeler = new FourWheeler();
            Console.WriteLine(fourWheeler.Start());
            Console.WriteLine(fourWheeler.StartWithPetrol());
            Console.ReadLine();
        }
    }
}
