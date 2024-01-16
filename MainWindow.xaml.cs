using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbTeams.ItemsSource = Data.Teams;
            lbPlayers.ItemsSource = Data.Players;

        }

        private void btnWindowOne_Click(object sender, RoutedEventArgs e)
        {
            // How to open up a new window
            WindowOne window = new WindowOne();

            // .Show is how you open a new window
            window.Show();
        }

        private void btnWindowTwo_Click(object sender, RoutedEventArgs e)
        {
            // Short hand version
            new AddPlayer().Show();
        }

        private void btnWindowThree_Click(object sender, RoutedEventArgs e)
        {

            // Adding the selected player to the selected team
            // Updating our windows
            Data.CurrentTeam.Players.Add(Data.CurrentPlayer);


        }

        private void cbTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Which team is selected
            int selectedTeamIndex = cbTeams.SelectedIndex;
            Data.CurrentTeam = Data.Teams[selectedTeamIndex];

            lbTeamRoster.ItemsSource = Data.CurrentTeam.Players;
        }

        private void lbPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Which player is selected
            int selectedPlayerIndex = lbPlayers.SelectedIndex;
            Data.CurrentPlayer = Data.Players[selectedPlayerIndex];

        }

        private void lbTeamRoster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Creating 3 buttons
        // Opening new windows with each button

        // Add multiple List and Combo Boxes

    }
}
