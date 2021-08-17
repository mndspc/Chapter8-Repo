using System;


namespace OPPDemo
{
    class NOKIA2700:MobilePhone
    {
        public NOKIA2700()
        {
            Console.WriteLine("Default constructor of NOKIA2700");
        }
        public NOKIA2700(int modelNo, string modelName, int yearOfManu, int screenSize, int internalStorage, int ram) : base(modelNo, modelName, yearOfManu, screenSize, internalStorage, ram)
        {

        }

        public string Camera()
        {
            return "This is Camera() from NOKIA2700";
        }
    }
}
