using System;


namespace OPPDemo
{
    //  This class demo. how to do multi-level inheritance
    class MultiLevelInheritance
    {
        static void Main()
        {
            NOKIA1100 nokia1100 = new NOKIA1100();
            Console.WriteLine(nokia1100.Calling());
            Console.WriteLine(nokia1100.SendSMS());
            Console.WriteLine(nokia1100.MP3());
            Console.WriteLine(nokia1100.MP4());
            Console.ReadLine();
        }
    }
}
