using System;


namespace OPPDemo
{
    class NOKIA1100:NOKIA1400
    {
        public NOKIA1100()
        {
            Console.WriteLine("Default constructor of NOKIA1100");
        }
        public NOKIA1100(int modelNo, string modelName, int yearOfManu, int screenSize, int internalStorage, int ram) : base(modelNo, modelName, yearOfManu, screenSize, internalStorage, ram)
        {

        }
        public string MP4()
        {
            return "This is MP4() from NOKIA1100";
        }
    }
}
