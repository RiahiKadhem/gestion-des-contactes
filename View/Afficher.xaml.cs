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
    /// Interaction logic for Afficher.xaml
    /// </summary>
    public partial class Afficher : Window
    {
        public Afficher()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void Afficher_tout_Click(object sender, RoutedEventArgs e)
        {
            bool? trier = oui.IsChecked;
            affichage.Text = MonControlleur.ShowAllContact(champ.Text, trier);
        }

        private void Afficher_Click(object sender, RoutedEventArgs e)
        {
            bool? trier=oui.IsChecked;
            if (rnom.IsChecked==true)
            {
                affichage.Text = MonControlleur.ShowContact(txt.Text, trier);
            }
            else if(rtel.IsChecked==true)
            {
                affichage.Text = MonControlleur.ShowContactPhone(txt.Text, trier);
            }
            
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Oui_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Rnom_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
