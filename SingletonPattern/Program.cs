using System;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton object1 = Singleton.Intance();
            Singleton object2 = Singleton.Intance();

            if(object1 == object2)
            {
                Console.WriteLine("It is Singleton!");
            }

            Console.ReadKey();
        }
    }
}
