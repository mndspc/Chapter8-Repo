using System;


namespace OPPDemo
{
 public abstract  class Animal
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("default constructor of abstract class Animal");
        }
        public string Run()
        {
            return "The Run() calling from Animal";
        }
        public string Eat()
        {
            return "The Eat() calling from Animal";
        }

        public abstract string VegOrNonVeg();
    }
    class Mammals: Animal 
    {

        public Mammals()
        {
            Console.WriteLine("Default constructor of Mammal");
        }
        public sealed override string VegOrNonVeg()
        {
            return "It may be Veg. or Non-Veg.";
        }
    }
    class Mammals1 : Mammals
    {
        // Error
        //public override string VegOrNonVeg()
        //{

        //}
    }
}
