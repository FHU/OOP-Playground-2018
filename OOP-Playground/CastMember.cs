using System;

namespace OOPPlayground
{
    public class CastMember : Person
    {
        public CastMember(string first, string last): base(first, last)
        {
        }

        public SocialClub SocialClub { get; set; }

        public bool HasPaidMoney
        {
            get;
            set;
        }

        public virtual void Sing() {
            //Code to sing
        }

        public override void Dance() {
            Console.WriteLine("I'm a cast member and I don't dance that well.");
        }

        public virtual void Complain() {
            // Lots of code
            Console.WriteLine("Practice is too long.");
        }



    }
}
