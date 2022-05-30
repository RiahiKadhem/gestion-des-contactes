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
using Controller;
using Model;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*string login = TestLogin.Text;
            string password = TextPassword.Text;
            Console.WriteLine("code de login");
            Console.WriteLine(login);
            Console.WriteLine(password);
            Users show = MonControlleur.CheckLogin();
            TestLogin.Text = show.UserLogin;
            TextPassword.Text = show.UserPassword;
            Menu m = new Menu();
            m.Show();
            this.Hide();*/
            Users loginUser = Controller.MonControlleur.CheckLogin(TextLogin.Text, TextPassword.Text);
            if (loginUser.UserId != 0)
            {
                Menu m = new Menu();
                m.Show();
                this.Close();
            }

        }

        private void TestLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
