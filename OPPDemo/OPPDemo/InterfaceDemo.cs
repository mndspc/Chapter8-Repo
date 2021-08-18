using System;


namespace OPPDemo
{
    class InterfaceDemo
    {
        static void Main()
        {
            // To invoke functions using Interface object
            //IWifi iwifi = new NOKIALUMIA();
            //Console.WriteLine(iwifi.StartWifi());
            //Console.WriteLine(iwifi.StopWifi());
            // To Invoke functions from Derive class
            NOKIALUMIA nokiaLumia = new NOKIALUMIA();
            Console.WriteLine( nokiaLumia.StartWifi());
            Console.WriteLine(nokiaLumia.StopWifi());
            Console.WriteLine(nokiaLumia.Calling());
            Console.WriteLine(nokiaLumia.PushMessage());
            //nokiaLumia.TroubleShoot();//Unhandled Exception
            Console.ReadLine();
        }
    }
}
