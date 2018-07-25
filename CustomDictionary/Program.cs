using System;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomDictionary<int,string> cd = new CustomDictionary<int,string>();
            cd.Add(1,"One");
            cd.Add(2,"Two");
            cd.Add(3,"Three");
            Console.WriteLine(cd[2]);
        }
    }
}
