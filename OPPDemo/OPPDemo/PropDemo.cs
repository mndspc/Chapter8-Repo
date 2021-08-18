using System;


namespace OPPDemo
{
    //  This program demo. how to use properties.
    class PropDemo
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.ModelNo = 11;
            // Read-only property
            //vehicle.LaunchCountry = "U.K.";
            vehicle.ModelName = "Four Wheeler";
            Console.WriteLine("Model no={0}\tModelName={1}\tCountry={2}",vehicle.ModelNo,vehicle.ModelName,vehicle.LaunchCountry);
            
            //Prop. intializer syntax
            Vehicle vehicle1 = new Vehicle { ModelNo = 123, ModelName = "Three Wheeler", NoWheeles = 3, LaunchDate = new DateTime(2021, 08, 18),IsPetrol=false};
            Console.WriteLine("Model no={0}\tModelName={1}\tCountry={2}\tNo.of Wheeles={3}\tLaunch Date={4}\tpertrol version={5}", vehicle1.ModelNo, vehicle1.ModelName, vehicle1.LaunchCountry,vehicle1.NoWheeles,vehicle1.LaunchDate,vehicle1.IsPetrol);
        
            Console.ReadLine();
        }
    }
}
