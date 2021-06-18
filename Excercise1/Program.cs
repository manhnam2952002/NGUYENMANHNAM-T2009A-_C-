using System;

namespace Excercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            
            person.Name = "Amar";
            person.Age = 40;
            Console.WriteLine("Person detail - {0}", person);

            person.Age += 1;
            Console.WriteLine("Person details <After incrementing age> - {0}", person);
        }
    }
}