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
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=fila;uid=root;password=root");
            try
            {
                conexao.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("erro");
            }

            DAO Daoo = new DAO();
            
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            Daoo.cadastrar();
            Daoo.insert();

            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("cadastro concluido");
                Console.ReadKey();
            }

        }
    }
}
