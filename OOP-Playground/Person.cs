using System;

namespace OOPPlayground
{
    public enum Role {
        CastMember, Staff, Host, Director, Emcee, ShowBandMember, Coordinator
    }

    public abstract class Person
    {
        public static int numberOfPersons = 0;

        string firstName;
        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }

        public string LastName
        {
            get;
            set;
        } = "Casey";

        public string email;

        DateTime birthdate;
        public DateTime BirthDate {
            get {
                return birthdate;
            }
            set {
                if (value.Year < 1900) {
                    var d = new DateTime(1900, value.Month, value.Day);
                    birthdate = d;
                }
                else {
                    birthdate = value;
                }
            }
        }

        public int Age {
            get {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

        //public string role = "Cast Mebmer";
        public Role Role { get; set; } = Role.CastMember;

        public Person(string firstName="", string lastName="")
        {
            FirstName = firstName;
            LastName = lastName;

            numberOfPersons++;
        }

        public void Cheer() {
            Console.WriteLine("Yay!!!");
        }

        public abstract void Dance();

        public override string ToString() {
            return $"{FirstName} {LastName}, {Age} years old";
        }
    }
}
