using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    /// <summary>
    /// Interaction logic for WindowOne.xaml
    /// </summary>
    public partial class WindowOne : Window
    {

        public WindowOne()
        {
            InitializeComponent();

            // Use ItemsSource, not .Items
            lbTeams.ItemsSource = Data.Teams;
        }

        private void btnAddTeam_Click(object sender, RoutedEventArgs e)
        {
            string name = txtTeamName.Text;
            string city = txtBoxTeamCity.Text;
            string mascot = txtBoxTeamMascot.Text;

            Team newTeam = new Team(name, mascot, city);
            Data.Teams.Add(newTeam); 
        }


    }
}
