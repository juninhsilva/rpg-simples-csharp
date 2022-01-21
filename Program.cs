using System.Globalization;
using System;
using rpgCSharp.src.Entities;

namespace rpgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 9, Type.KNIGHT);
            Console.WriteLine(arus.ToString());
            Hero thanos = new Hero("Aros", 12, Type.MONSTER);
            Console.WriteLine(thanos.ToString());
            Console.WriteLine(thanos.Attack(arus));
            Console.WriteLine(arus.ToString());
            Console.WriteLine(thanos.Attack(thanos));
            Console.WriteLine(thanos.ToString());
        }
    }
}
