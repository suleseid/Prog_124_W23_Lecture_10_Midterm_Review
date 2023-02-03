using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    public class Data
    {
        // Observable Collection
        static ObservableCollection<Team> teams;

        // Static list of players
        static ObservableCollection<Player> players;

        static Player currentPlayer = null;
        static Team currentTeam = null;

        // Static Constructor
        static Data() {
       
            teams = new ObservableCollection<Team>();
            players = new ObservableCollection<Player>();
        }

        internal static ObservableCollection<Team> Teams { get => teams; set => teams = value; }
        internal static ObservableCollection<Player> Players { get => players; set => players = value; }
        internal static Player CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        internal static Team CurrentTeam { get => currentTeam; set => currentTeam = value; }
    }
}
