using System;

namespace XayDungClassAnimal
{
    class Program
    {
        static void Main(string[]args)
        {
            Cat cat1 = new Cat("5.3 kg", "0.7 m\n", "Mini");
            Cat cat2 = new Cat("4.8 kg", "0.7 m\n", "Bong");
            cat1.PrintInfo();
            cat2.PrintInfo();
        }
    }
}