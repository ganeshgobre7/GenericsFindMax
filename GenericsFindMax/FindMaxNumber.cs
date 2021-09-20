using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsFindMax
{
    class FindMaxNumber
    {
        public static dynamic MaxNumber<datatype>(dynamic value1, dynamic value2, dynamic value3) where datatype : IComparable
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                return value2;
            }
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0)
            {
                return value3;
            }
            return value1;
        }       
    }
}
