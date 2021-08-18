using System;


namespace OPPDemo
{
    //  This program demo. how to call functions from static class
    class StaticDemo
    {
        static void Main()
        {
            Console.WriteLine("Total Amount of Product with GST is:{0}", GstStat.TotalAmount(1000, 8));
            Console.ReadLine();
        }
    }
}
