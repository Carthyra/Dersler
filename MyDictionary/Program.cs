using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ulaş");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(2, "Gizem");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(3, "Bıdık");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add(4, "Pofuduk");
            Console.WriteLine(myDictionary.Count);
        }
    }
}
