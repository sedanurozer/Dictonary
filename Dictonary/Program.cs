using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> words = new MyDictonary<string>();
            words.Add("Country");
            words.Add("Apple");
            words.Add("Travel");

            words.Listele();
        }
    }
}
