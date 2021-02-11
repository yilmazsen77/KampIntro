using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1,"adfee");
            myDictionary.Add(4,"adfd");
            myDictionary.Add(77,"abv");
            myDictionary.Add(1234,"ab");

            myDictionary.ToList();
        }
    }
}
