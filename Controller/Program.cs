using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL_TP;

namespace Controller
{
    class ProgramController
    {
        static void Main(string[] args)
        {
            /*Ajouter test = new Ajouter();
            test.*/
        }
    }
    public class MonControlleur
    {
        public static Users CheckLogin(string name, string password)
        {
            return (ProgramDAL.CheckLogin(name, password));
        }
        public static bool AddContact(Contacts contact)
        {
           return (ProgramDAL.AddContact(contact));
        }

        public static bool DeleteContact(string phone)
        {
           return (ProgramDAL.DeleteContact(phone));
        }
        public static string ShowContact(string nom, bool? tri)
        {
            return ProgramDAL.ShowContact(nom,tri);
        }
        public static string ShowAllContact(string group, bool? tri)
        {
            return ProgramDAL.ShowAllContact(group, tri);
        }

        public static string ShowContactPhone(string tel, bool? tri)
        {
            return ProgramDAL.ShowContactPhone(tel, tri);
        }

    }
}
