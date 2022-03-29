using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split();
                var name = token[0];
                var age = int.Parse(token[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            


            Console.WriteLine(family.GetOldestMember().Representation());
        }
    }
}
