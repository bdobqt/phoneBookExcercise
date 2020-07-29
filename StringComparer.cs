using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int result = x.CompareTo(y);

            if (result == 0)
                return 1;   
            else
                return result;
        }
    }