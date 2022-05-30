using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL_TP
{
    public class ProgramDAL
    {
        public static Users Currentuser = new Users();

        static void Main(string[] args)
        {
            /*Users testUser = new Users();
            //testUser.UserId = 5;
            testUser.TypeUser = 3;
            testUser.UserLogin = "logintest5";
            testUser.UserPassword = "password5";
            //AddUser(testUser);
            GetAllUsers();
            //DeleteUser(testUser);
            GetAllUsers();*/
            /*CheckLogin("9annas", "bigboy");
            Contacts testContact = new Contacts();
            testContact.UId = Currentuser.UserId;
            testContact.Name = "Gojo";
            testContact.Prenom = "Satoru";
            testContact.Phone = "infinit number";
            testContact.Email = "Gojo.Satoru@kektus.com";
            testContact.Addresse = "japan 455 NIPON";

            AddContact(testContact);
            Console.WriteLine("test started");*/



        }
        public static List<Users> GetAllUsers()
        {

            List<Users> users = new List<Users>();
            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=DESKTOP-SB44L17\SQLEXPRESS01;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {
                    cmd.CommandText = @"select UserId,UserLogin,UserPassword,TypeUser  from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Users use = new Users();
                            use.UserId = reader.GetInt32(0);
                            use.UserLogin = reader.GetString(1);
                            use.UserPassword = reader.GetString(2);
                            use.TypeUser = reader.GetInt32(3);
                            //or stu.DOB = (DateTime?)reader["DoB"];
                            users.Add(use);
                        }
                    }
                    foreach (Users s in users)
                    {
                        s.Afficher();
                    }
                }
            }
            return users;
        }

        public static Users CheckLogin(string name, string password)
        {
            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {
                    cmd.CommandText = @"select * from Users where UserLogin = '" + name + "' and UserPassword = '" + password + "'";
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("in loop");
                            Currentuser.UserId = reader.GetInt32(0);
                            Currentuser.UserLogin = reader.GetString(1);
                            Currentuser.UserPassword = reader.GetString(2);
                            Currentuser.TypeUser = reader.GetInt32(3);
                        }
                    }
                }
                Currentuser.Afficher();
            }
            return Currentuser;
        }

        public static bool AddContact(Contacts contact)
        {
            bool test = true;

            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {

                connect.Open();
                Console.WriteLine(connect.State);
                string tel = null;
                using (SqlCommand cmd = connect.CreateCommand())
                {

                    cmd.CommandText = @"select Phone
                                    from Contacts
                                    where Phone=@phone1";
                    cmd.Parameters.Add(new SqlParameter("@phone1", contact.Phone));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            tel = reader.GetString(0);
                        }
                    }

                    if (tel == null)
                    {

                        Console.WriteLine("contact process");
                        cmd.CommandText = @"insert into Contacts(uid,Name,Prenom,Phone,Email,Adresse,Groupe)  values (@uid,@Name,@Prenom,@Phone,@Email,@Addresse,@Groupe)";
                        cmd.Parameters.Add(new SqlParameter("@uid",Currentuser.UserId));
                        cmd.Parameters.Add(new SqlParameter("@Name", contact.Name));
                        cmd.Parameters.Add(new SqlParameter("@Prenom", contact.Prenom));
                        cmd.Parameters.Add(new SqlParameter("@Phone", contact.Phone));
                        cmd.Parameters.Add(new SqlParameter("@Email", contact.Email));
                        cmd.Parameters.Add(new SqlParameter("@Addresse", contact.Addresse));
                        cmd.Parameters.Add(new SqlParameter("@Groupe", contact.Groupe));
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("contact added");
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                }
            }
            return test;
        }

        public static void AddUser(Users user)
        {
            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=DESKTOP-SB44L17\SQLEXPRESS01;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {
                    cmd.CommandText = @"insert into Users(UserLogin,UserPassword,TypeUser) values(@login,@password,@type)";
                    cmd.Parameters.AddWithValue("@login", user.UserLogin);
                    cmd.Parameters.AddWithValue("@password", user.UserPassword);
                    cmd.Parameters.AddWithValue("@type", 3);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(Users user)
        {
            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=DESKTOP-SB44L17\SQLEXPRESS01;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {
                    cmd.CommandText = @"Delete from Users where UserId=@UserId";
                    cmd.Parameters.Add(new SqlParameter("@UserId", user.UserId));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool DeleteContact(string phone)
        {
            bool test = true;

            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {

                connect.Open();
                Console.WriteLine(connect.State);
                string tel = null;
                using (SqlCommand cmd = connect.CreateCommand())
                {

                    cmd.CommandText = @"select Phone
                                    from Contacts
                                    where Phone=@phone1 and uid=@userId1";
                    cmd.Parameters.Add(new SqlParameter("@phone1", phone));
                    cmd.Parameters.Add(new SqlParameter("@userId1", Currentuser.UserId));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            tel = reader.GetString(0);
                        }
                    }

                    if (tel != null)
                    {
                        cmd.CommandText = @"Delete from Contacts where Phone=@phone and uid=@userId";
                        cmd.Parameters.Add(new SqlParameter("@phone", phone));
                        cmd.Parameters.Add(new SqlParameter("@userId", Currentuser.UserId));
                        cmd.ExecuteNonQuery();
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }
                }
            }
            return test;
        }

        public static string ShowContact(string nom,bool? tri)
        {
            string name;
            string phone;
            string prenom;
            string email;
            string adresse;
            string groupe;
            string str = "";

            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                string qry = "select Name, Prenom, Phone ,Email ,Adresse, Groupe from Contacts where Name = @nom and uid=@userId ";
                if (tri == true)
                {
                    qry+="order by Name ";
                }

                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {
                   

                    cmd.CommandText = @qry;
                    cmd.Parameters.Add(new SqlParameter("@nom", nom));
                    cmd.Parameters.Add(new SqlParameter("@userId", Currentuser.UserId));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            str += "nom : ";
                            name = reader.GetString(0);
                            str += name + "\r\n";
                            str += "prenom : ";
                            prenom = reader.GetString(1);
                            str += prenom + "\r\n";
                            str += "tel : ";
                            phone = reader.GetString(2);
                            str += phone + "\r\n";
                            str += "Email : ";
                            email = reader.GetString(3);
                            str += email + "\r\n";
                            str += "adresse : ";
                            adresse = reader.GetString(4);
                            str += adresse + "\r\n";
                            str += "groupe : ";
                            groupe = reader.GetString(5);
                            str += groupe + "\r\n";

                            str += "_____________________________\r\n";

                        }
                    }
                }
            }
            return str;
        }

        public static string ShowContactPhone(string tel, bool? tri)
        {
            string name;
            string phone;
            string prenom;
            string email;
            string adresse;
            string groupe;
            string str = "";

            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                string qry = "select Name, Prenom, Phone ,Email ,Adresse, Groupe from Contacts where Phone = @tel and uid=@userId ";
                if (tri == true)
                {
                    qry += "order by Name ";
                }

                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {


                    cmd.CommandText = @qry;
                    cmd.Parameters.Add(new SqlParameter("@tel", tel));
                    cmd.Parameters.Add(new SqlParameter("@userId", Currentuser.UserId));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            str += "nom : ";
                            name = reader.GetString(0);
                            str += name + "\r\n";
                            str += "prenom : ";
                            prenom = reader.GetString(1);
                            str += prenom + "\r\n";
                            str += "tel : ";
                            phone = reader.GetString(2);
                            str += phone + "\r\n";
                            str += "Email : ";
                            email = reader.GetString(3);
                            str += email + "\r\n";
                            str += "adresse : ";
                            adresse = reader.GetString(4);
                            str += adresse + "\r\n";
                            str += "groupe : ";
                            groupe = reader.GetString(5);
                            str += groupe + "\r\n";

                            str += "_____________________________\r\n";

                        }
                    }
                }
            }
            return str;
        }

        public static string ShowAllContact(string group, bool? tri)
        {
            string name;
            string phone;
            string prenom;
            string email;
            string adresse;
            string groupe;
            string str = "";

            using (SqlConnection connect = new SqlConnection(connectionString: @"Data Source=751FJW2\SQLEXPRESS;Initial Catalog=ContactTp;Integrated Security=True;Connect Timeout=10"))
            {
                string qry = "select Name, Prenom, Phone ,Email ,Adresse, Groupe from Contacts where uid=@userId ";
                if (tri == true)
                {
                    qry += "order by Name ";
                }
                else if (group != "selectionner un type de groupement")
                {
                    qry += "order by " + group;
                }

                connect.Open();
                Console.WriteLine(connect.State);
                using (SqlCommand cmd = connect.CreateCommand())
                {


                    cmd.CommandText = @qry;
                    cmd.Parameters.Add(new SqlParameter("@userId", Currentuser.UserId));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            str += "nom : ";
                            name = reader.GetString(0);
                            str += name + "\r\n";
                            str += "prenom : ";
                            prenom = reader.GetString(1);
                            str += prenom + "\r\n";
                            str += "tel : ";
                            phone = reader.GetString(2);
                            str += phone + "\r\n";
                            str += "Email : ";
                            email = reader.GetString(3);
                            str += email + "\r\n";
                            str += "adresse : ";
                            adresse = reader.GetString(4);
                            str += adresse + "\r\n";
                            str += "groupe : ";
                            groupe = reader.GetString(5);
                            str += groupe + "\r\n";

                            str += "_____________________________\r\n";

                        }
                    }
                }
            }
            return str;
        }
    }
}
