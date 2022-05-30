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
using Model;
using Controller;


namespace View
{
    /// <summary>
    /// Interaction logic for Ajouter.xaml
    /// </summary>
    public partial class Ajouter : Window
    {
        public Ajouter()
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

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Contacts c = new Contacts();
            c.Name = nom.Text;
            c.Prenom = prenom.Text;
            c.Phone = telephone.Text;
            c.Email = email.Text;
            c.Addresse = adresse.Text;
            c.Groupe = groupe.Text;
            if (MonControlleur.AddContact(c))
            {
                MessageBox.Show("contact added");
            }
            else
            {
                MessageBox.Show("contact already exists");
            }
        }
    }
}
