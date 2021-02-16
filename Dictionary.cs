using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<T,K>
    {
        T[] Names;
        K[] Numbers;

        T[] TempNames;
        K[] TempNumbers;
        public Dictionary()
        {
            Names = new T[0];
            Numbers = new K[0];
        }
        public void Add(T names , K numbers)
        {
            TempNames = Names;
            TempNumbers = Numbers;

            Names = new T[Names.Length + 1];
            Numbers = new K[Numbers.Length + 1];

            for (int i = 0; i < TempNames.Length; i++)
            {
                TempNames[i] = Names[i];
            }
            for (int i = 0; i < TempNumbers.Length; i++)
            {
                TempNumbers[i] = Numbers[i];
            }
            Names[Names.Length - 1] = names;
            Numbers[Numbers.Length - 1] = numbers;

        }
        public int Count
        {
            get { return Numbers.Length; }
        }
        public int countt
        {
            get { return Names.Length; }
        }
    }
}

