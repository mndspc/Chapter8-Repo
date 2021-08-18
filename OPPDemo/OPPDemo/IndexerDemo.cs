using System;

namespace OPPDemo
{
    //  This program demo. how to use indexers
    class IndexerDemo
    {
        static void Main()
        {
            StrIndexer strings = new StrIndexer();
            strings[0] = "Sachin";
            strings[1] = "Rahul";
            strings[2] = "Yuvraj";
            strings[3] = "Virat";

           foreach(var str in strings)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
