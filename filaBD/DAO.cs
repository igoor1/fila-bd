using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace filaBD
{
    class DAO
    {
        string cpf, nome, sexo, idade, endereco;


        public void cadastrar()
        {
            Console.WriteLine("cpf:");
            cpf = Console.ReadLine();

            Console.WriteLine("nome:");
            nome = Console.ReadLine();

            Console.WriteLine("sexo:");
            sexo = Console.ReadLine();

            Console.WriteLine("idade:");
            idade = Console.ReadLine();
                        Console.WriteLine("nome:");
            nome = Console.ReadLine();

            Console.WriteLine("endereco:");
            endereco = Console.ReadLine();

        }

        public void insert()
        {
            String sql = "insert into paciente values(null,@cpf,@nome,@sexo,@idade,@endereco)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sexo",sexo);
            cmd.Parameters.AddWithValue("@idade",idade);
            cmd.Parameters.AddWithValue("@endereco", endereco);
        }


    }
}
