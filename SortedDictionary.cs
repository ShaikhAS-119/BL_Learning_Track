using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structure
{
    internal class SortedDictionary
    {
        public static void SDictionaryDemo()
        {
          
            SortedDictionary<int, string> sdic = new SortedDictionary<int, string>();
            sdic.Add(23, "Sorted");
            sdic.Add(19, "Thane");
            sdic.Add(29, null);
            sdic.Add(14, "Mumbai");

            //check presence of key
             Console.WriteLine(sdic.ContainsKey(29));

            //Remove particular elemnent
            sdic.Remove(29);

            //clear all element
            sdic.Clear();

            //perform operation check given value is present or not. if present print 
            //its key and value
            string name = "Thane";
            foreach (KeyValuePair<int, string> value in sdic)
            {
                if (value.Value == name)
                {
                    Console.WriteLine("key for the Thane is: "+value.Key + "and value is :"+ value.Value);

                }
                Console.WriteLine(value.Key + " and " + value.Value);
            }

        }
    }
}
