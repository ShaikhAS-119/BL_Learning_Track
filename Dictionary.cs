using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structure
{
    internal class Dictionary
    {
        public static void DictionaryDemo()
        {
            Dictionary<object,Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(1,34);
            dictionary.Add("k", "hello");
            dictionary.Add("unique", null);
            dictionary.Add("keys", 2345);
            dictionary[32] = "thane";
           
            //it will show some num i.e. hash
            Console.WriteLine(dictionary.GetHashCode());

            Console.WriteLine("count is :"+dictionary.Count);

            //remove key: it will remove element also
            dictionary.Remove("k");          
            Console.WriteLine("count is after :" + dictionary.Count);

            //check key/ value dictionary is contained or not 
            Console.WriteLine("added: "+dictionary.ContainsValue("hello"));

            foreach (KeyValuePair<object, Object> pair in dictionary)
            {
                Console.WriteLine("key: " + pair.Key + " and value: " + pair.Value);
            }
            //get value by index
            Console.WriteLine("value of geiven key: " + dictionary["keys"]);
            //using for loop
            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary.Keys.ElementAt(i)+" and "+
                                   dictionary[dictionary.Keys.ElementAt(i)]);
            }
        }
    }
}
