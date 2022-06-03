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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }
        private static Random rng = new Random();
        

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐱","🐺","🐶","🐵","🦝","🐮","🐸","🐔"
            };
            var shuffledAnimals = animalEmoji.Concat(animalEmoji).OrderBy(a => rng.Next()).ToList();
            var i = 0;
            foreach (var item in MainGrid.Children.OfType<TextBlock>())
            {
                item.Text = shuffledAnimals[i];
                i++;
            }
        }

        
    }
}
