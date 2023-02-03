using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    internal class Team
    {
        // Name
        string _name;
        // Mascot
        string _mascot;
        // City
        string _city;
        // Players
        ObservableCollection<Player> _players = new ObservableCollection<Player>();

        public Team(string name, string mascot, string city)
        {
            _name = name;
            _mascot = mascot;
            _city = city;         
        }

        internal ObservableCollection<Player> Players { get => _players; set => _players = value; }

        public void Example()
        {
            //Person personsName = new Person("Will", "Cram");
            // Aggregate
            //Player teamPlayer = new Player(personsName, "42");
            //_players.Add(teamPlayer);
        }

        // Seahawks - Seahawk - Seattle
        // City - Team

        // Override ToString()
        public override string ToString()
        {
            return _city + " " + _name + $" : Mascot - {_mascot}";
        }
    }
}
