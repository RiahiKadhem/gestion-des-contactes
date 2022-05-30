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

namespace View
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Ajouter a = new Ajouter();
            a.Show();
            this.Close();
            
          
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            Supprimer s = new Supprimer();
            s.Show();
            this.Close();

        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            Modifier m = new Modifier();
            m.Show();
            this.Close();

        }

        private void Afficher_Click(object sender, RoutedEventArgs e)
        {
            Afficher af = new Afficher();
            af.Show();
            this.Close();
        }
    }
}
