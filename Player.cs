using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    internal class Player
    {
        //public Person Person;

        public string FirstName;
        public string LastName;
        public string Number;

        public Player(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} - {FirstName} {LastName}";
        }

        //public Player(Person person, string number)
        //{
        //    Person = person;
        //    Number = number;
        //}
    }
}
