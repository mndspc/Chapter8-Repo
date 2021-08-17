using System;

namespace OPPDemo
{
    class MobilePhone
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public int YearOfManu { get; set; }
        public int ScreenSize { get; set; }
        public int InternalStorage { get; set; }
        public int Ram { get; set; }
        public MobilePhone()
        {
            Console.WriteLine("Default constructor of MobilePhone");
        }
        public MobilePhone(int modelNo,string modelName,int yearOfManu,int screenSize,int internalStorage,int ram)
        {
            ModelNo = modelNo;
            ModelName = modelName;
            YearOfManu = yearOfManu;
            ScreenSize = screenSize;
            InternalStorage = internalStorage;
            Ram = ram;
        }

        public string Calling()
        {
            return "This is Calling() from MobilePhone";
        }

        public string SendSMS()
        {
            return "This is SendSMS() from MobilePhone";
        }

        public string AboutMobilePhone()
        {
            return string.Format("Model No={0} Name={1} Year of Manu={2} Screen Size={3}-inches Internal Storage={4}-GB,Ram={5}-GB",this.ModelNo,this.ModelName,this.YearOfManu,this.ScreenSize,this.InternalStorage,this.Ram);
        }
    }
}
