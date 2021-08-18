using System;

namespace OPPDemo
{
    class Vehicle
    {
        #region Read Write Properties
            private int modelno;
            private string modelname;

             public int ModelNo
            {
                get
                {
                    modelno++;
                    return modelno;
                }
                set
                {
                    if (value > 0)
                    {
                        modelno = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Model No");
                    }
                }
            }

            public string ModelName
            {
                get
                {
                    return modelname;
                }
                set
                {
                    modelname = value;
                }
            }
        #endregion

        //  Read-only property
        public string LaunchCountry
        {
            get
            {
                return "India";
            }
        }

        #region Auto Implemented Properties
            public int NoWheeles { get; set; }
            public DateTime LaunchDate { get; set; }
            public bool IsPetrol { get; set; }
        #endregion
    }
}
