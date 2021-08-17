using System;


namespace OPPDemo
{
    //  This program demo. how to do hybrid inheritance
    class HybridInheritance
    {
        static void Main()
        {
            NOKIA2700 nokia2700 = new NOKIA2700();
            Console.WriteLine(nokia2700.Calling());
            Console.WriteLine(nokia2700.SendSMS());
            Console.WriteLine(nokia2700.Camera());
            Console.ReadLine();
        }
    }
}
