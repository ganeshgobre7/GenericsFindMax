﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsFindMax
{
    class FindMaxNumber
    {
        public static int IntMaxNumber(int value1,int value2,int value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0)
            {
                return value1;
            }
            if(value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0)
            {
                return value2;
            }
            if(value3.CompareTo(value1)> 0 && value3.CompareTo(value2) > 0)
            {
                return value3;
            }
            return value1;
        }
    }
}
