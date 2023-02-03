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
using System.Windows.Shapes;

namespace Prog_124_W23_Lecture_10_Midterm_Review
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        public AddPlayer()
        {
            InitializeComponent();
            lbPlayers.ItemsSource = Data.Players;
        }

        private void btnAddTeam_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string number = txtNumber.Text;

            Player player = new Player(firstName, lastName, number);
            Data.Players.Add(player);
        }
    }
}
