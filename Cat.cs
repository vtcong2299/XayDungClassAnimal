using System;

namespace XayDungClassAnimal
{
    class Cat : Animal
    {
        protected string Name {get;set;}
        public Cat (string weight, string height, string name) : base( weight,  height)
        { 
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Ten: "+this.Name+"\nCan nang: " + this.Weight + "\nChieu cao: "+ this.Height);
        }
    }
}