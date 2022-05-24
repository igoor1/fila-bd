using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace filaBD
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            DAO Dao = new DAO();
            Pessoa P = new Pessoa();
            Menu menu = new Menu();

            do
            {
                op = menu.menu();
                switch (op)
                {
                    case "1":
                        P.cadastro();
                        Dao.insert(P);
                        break;
                    case "2":
                        Dao.select();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            } while (op != "Q");
        }
    }
}
