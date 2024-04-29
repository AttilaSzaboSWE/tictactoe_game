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

namespace tictactoe_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum Player
        {
            X, O
        }

        Player player1;
        int player1wins_count = 0;
        int player2wins_count = 0;

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }


        private void exit(object sender, RoutedEventArgs e) //Kilépés gomb
        {
            if (MessageBox.Show("Biztos ki akarsz lépni?", "Megerősítés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void NewGame() //Új game teljesen lenullázva minden - Új játék gomb
        {
            List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {

            }
        }

        private void NextRound() //Nem új game,nem nullázunk le semmit, viszont itt csak a button-öket fogjuk resetelni. - Következő forduló gomb
        {

        }
    }
       
}
