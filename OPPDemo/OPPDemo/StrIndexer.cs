using System;
using System.Collections;
namespace OPPDemo
{
    // This class shows how can we create indexer property
    class StrIndexer:IEnumerable
    {
        private string[] names = new string[10];

        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return names.GetEnumerator();
        }
    }
}
