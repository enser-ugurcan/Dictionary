using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string,int>();
            dictionary.Add("İstanbul", 1);
            dictionary.Add("Ankara", 2);
            dictionary.Add("İzmir", 3);
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.countt);
        }
    }
}
