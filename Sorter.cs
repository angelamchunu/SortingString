using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SortingString
{
   public  class Sorter
    {

        public SortedDictionary<char,int> Sort(string inputString)
        {
            inputString = Regex.Replace(inputString, "[^\\w\\d]","");
            inputString = Regex.Replace(inputString, " ", "");
            char[] charArray = inputString.ToLower().ToCharArray();

            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (sortedDictionary.ContainsKey(charArray[i]))
                {
                    int val = sortedDictionary[charArray[i]];
                    sortedDictionary.Remove(charArray[i]);
                    sortedDictionary.Add(charArray[i], val + 1);
                }
                else
                    sortedDictionary.Add(charArray[i], 1);
            }

            return sortedDictionary;
        }

     
    }
}
