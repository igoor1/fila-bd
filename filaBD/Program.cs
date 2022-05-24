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
            DAO Dao;
            Pessoa P = new Pessoa();
            Menu menu = new Menu();

            do
            {
                Dao = new DAO();
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
                        P.atualizar();
                        Dao.atualiza(P);
                        break;
                    case "4":
                        Dao.exibircpf();
                        P.delete();
                        Dao.delete(P);
                        break;
                }
            } while (op != "Q");
        }
    }
}
