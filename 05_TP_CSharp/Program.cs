using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Users
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int TypeUser { get; set; }
        /*public Users(string login , string password , int type)
        {
            this.UserLogin = login;
            this.UserPassword = password;
            this.TypeUser = type;
        }*/
        public void Afficher()
        {
            Console.WriteLine("affichage users");
            Console.WriteLine("user id: "+ this.UserId);
            Console.WriteLine("user Login: " + this.UserLogin);
            Console.WriteLine("user Password: " + this.UserPassword);
            Console.WriteLine("user type: " + this.TypeUser);
            Console.WriteLine("--------------------------------------------------");
        }
    }

    public class Contacts
    {
        public int ID { get; set; }
        public int UId { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Addresse { get; set; }
        public string Groupe { get; set; }
        /*public Contacts()
        {

        }*/
        public void Afficher()
        {
            Console.WriteLine("affichage Contact");
            Console.WriteLine("Contact id: " + this.ID);
            Console.WriteLine("User ID: " + this.UId);
            Console.WriteLine("Contact Name: " + this.Name);
            Console.WriteLine("Contact Prenom: " + this.Prenom);
            Console.WriteLine("Contact phone :"+this.Phone);
            Console.WriteLine("Contact Email :" + this.Email);
            Console.WriteLine("Contact Adresse :" + this.Addresse);
            Console.WriteLine("Contact Groupe :" + this.Groupe);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
