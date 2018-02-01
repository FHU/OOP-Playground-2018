using System;

namespace OOPPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Director sidney = new Director("Sidney", "Harmon");
            sidney.Dance();

            Faculty kenan = new Faculty();

            Person p = sidney;
            p = kenan;

            p.Dance();

            p = new CastMember("Cam", "McG");

            sidney.Cheer();
            sidney.BirthDate = new DateTime(1998, 5, 14);

            Console.WriteLine(sidney.ToString());


            //Person j = new Person("Jeremy", "Beard");
            Person jeremy = new CastMember("Jeremy", "Beard");

            Console.WriteLine($"Population Size: {Person.numberOfPersons}");
        }
    }
}
