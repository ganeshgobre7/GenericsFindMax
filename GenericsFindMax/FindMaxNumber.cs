using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsFindMax
{
    class FindMaxNumber<classtype>
    {
        dynamic value1, value2, value3;
        public FindMaxNumber(classtype value1,classtype value2,classtype value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public void MaxNumber()
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                Console.WriteLine("Max value is :"+ value1);
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                Console.WriteLine("Max value is :"+ value2);
            }
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0)
            {
                Console.WriteLine("Max value is :"+ value3);
            }
            
        }       
    }
}
