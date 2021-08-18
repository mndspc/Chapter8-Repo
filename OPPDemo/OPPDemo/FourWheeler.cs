using System;

namespace OPPDemo
{
   partial class FourWheeler
    {
        //  This contains functionality for SUV four Wheeler
        public FourWheeler()
        {
            Console.WriteLine("default constructor of FourWheeler");
        }

        public string Start()
        {
            return "Startting Four Wheeler";
        }
    }

    partial class FourWheeler
    {
        public FourWheeler(string ModelYear)
        {
            Console.WriteLine("Launched in the Year:{0}",ModelYear);
        }
        public string StartWithPetrol()
        {
            return "Startting with Petrol";
        }
    }
}
