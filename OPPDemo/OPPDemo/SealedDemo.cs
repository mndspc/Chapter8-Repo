using System;

namespace OPPDemo
{
    //  This program shows how to call functions from Sealed Class
    class SealedDemo
    {
        static void Main()
        {
            Gst gst = new Gst(1000, 8);
            Console.WriteLine("Total Amount of Product including GST is:{0}", gst.TotalAmount());
            Console.ReadLine();
        }
    }
}
