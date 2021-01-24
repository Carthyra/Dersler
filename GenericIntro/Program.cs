using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.asd);
            isimler.Add("Ulaş");
            Console.WriteLine(isimler.asd);
            

            
        }
    }
}
