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
using Controller;

namespace View
{
    /// <summary>
    /// Interaction logic for Supprimer.xaml
    /// </summary>
    public partial class Supprimer : Window
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            string tel = telephone.Text;
            if (MonControlleur.DeleteContact(tel))
            {
                MessageBox.Show("contact deleted");
            }
            else
            {
                MessageBox.Show("contact doesn't exist");

            }
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
