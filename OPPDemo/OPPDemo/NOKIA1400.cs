using System;

namespace OPPDemo
{
    class NOKIA1400:MobilePhone
    {
       
        public NOKIA1400()
        {
            Console.WriteLine("Default constructor of NOKIA1400");
        }

        public NOKIA1400(int modelNo, string modelName, int yearOfManu, int screenSize, int internalStorage, int ram) :base (modelNo, modelName, yearOfManu, screenSize, internalStorage, ram)
        {
         
        }
        public string MP3()
        {
            return "This is MP3() from NOKIA1400";
        }


    }
}
