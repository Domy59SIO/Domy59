using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibDao;

namespace LibDao
{
    class Program
    {
        ConnexionSqlServer connexionSqlServer = null;
        public Program()
        {
            try
            {
                connexionSqlServer = new ConnexionSqlServer();
                Console.WriteLine("connexion au serveur bdd ok");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
