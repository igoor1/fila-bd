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
            string sair;
            DAO Dao = new DAO();
            Pessoa Pessoa = new Pessoa();

            do
            {
                Console.WriteLine("1 - cadastrar \n 2- atualizar \n 3- deletar \n 4-consultar \n q - sair");
                sair = Console.ReadLine().ToUpper();
                switch (sair)
                {
                    case "1":
                        Pessoa.cadastro();
                        Dao.insert(Pessoa);
                        break;
                    case "2":
                        Dao.select();
                        break;

                }
            } while (sair != "Q");
        }
    }
}
