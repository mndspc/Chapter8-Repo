using System;


namespace OPPDemo
{
    // This program demo. how to invoke functions of abstract class
    class AbstractDemo
    {
        static void Main()
        {
            // Error
            //Animal animal = new Animal();
            Mammals humans = new Mammals();
            Console.WriteLine(humans.Run());
           Console.WriteLine( humans.Eat());
            Console.WriteLine(humans.VegOrNonVeg());
            Console.ReadLine();
        }
    }
}
