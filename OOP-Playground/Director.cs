using System;
namespace OOPPlayground
{
    public class Director: CastMember
    {
        public Director(string first, string last) : base(first, last)
        {
        }

        public sealed override void Sing() {
            //This is the only way to sing.
        }

        public override void  Complain()
        {
            Console.WriteLine("The Cast members are complaining too much about practice.");

        }

        public override void Dance() {
            Console.WriteLine("I'm a director and I can really get down.");
        }
    }
}
