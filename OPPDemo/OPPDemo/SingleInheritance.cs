using System;


namespace OPPDemo
{
    class SingleInheritance
    {
        static void Main()
        {
            // To invoke default constructor of derieved class along with base class constructor
            NOKIA1400 nk = new NOKIA1400();
            Console.WriteLine(nk.Calling());
            Console.WriteLine(nk.SendSMS());
            Console.WriteLine(nk.MP3());
            //  To invoke paramterized constructor of derieved class along with base class constructor
            NOKIA1400 nk1 = new NOKIA1400(1234, "NOKIA1400", 2020,6,64,6);
            Console.WriteLine(nk1.AboutMobilePhone());
            Console.ReadLine();
        }
    }
}
