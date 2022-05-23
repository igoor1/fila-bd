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
        public MySqlConnection conexao;
        public MySqlCommand cmd;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;database=fila;uid=root;password=root");
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("erro");
            }

        }

        public void insert(Pessoa p)
        {
            String sql = "insert into paciente (cpf, nome, sexo, idade, email, preferencial) values(@cpf,@nome,@sexo,@idade,@email,@preferencial)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", p.Cpf);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@sexo", p.Sexo);
            cmd.Parameters.AddWithValue("@idade", p.Idade);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@preferencial", p.Preferencial);
            cmd.ExecuteNonQuery();
        }

        public void select()
        {
            String sql = "SELECT * from paciente";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("nome: {0}, sexo:{1}, idade:{2}, email:{3}, preferencial:{4}", rdr["nome"], rdr["sexo"], rdr["idade"], rdr["email"], rdr["preferencial"]);
            }
            Console.ReadKey();
        }
    }
}
