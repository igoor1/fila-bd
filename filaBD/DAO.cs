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
                Console.ReadKey();
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

            Console.Clear();
            Console.WriteLine("Cadastro efetuado!");
            Console.ReadKey();
            conexao.Close();
        }

        public void select()
        {
            Console.Clear();

            String sql = "SELECT * from paciente order by preferencial desc";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("Paciente: {0}", rdr["id"]);
                Console.WriteLine("Nome: {0}, \nSexo:{1}, \nIdade:{2}, \nEmail:{3}, \nPreferencial:{4} \n", rdr["nome"], rdr["sexo"], rdr["idade"], rdr["email"], rdr["preferencial"]);
            }
            Console.ReadKey();
            conexao.Close();
        }

        public void atualiza(Pessoa p)
        {
            String sql = "update paciente set nome=@nome, sexo=@sexo, idade=@idade, email=@email, preferencial=@preferencial where cpf=@cpf";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", p.Cpf);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@sexo", p.Sexo);
            cmd.Parameters.AddWithValue("@idade", p.Idade);
            cmd.Parameters.AddWithValue("@email", p.Email);
            cmd.Parameters.AddWithValue("@preferencial", p.Preferencial);
            cmd.ExecuteNonQuery();

            Console.Clear();
            Console.WriteLine("Cadastro atualizado");
            Console.ReadKey();
            conexao.Close();
        }

        public void delete(Pessoa p)
        {
            try
            {
                conexao.Open();
            }
            catch
            {
                Console.WriteLine("conexao já aberta");
                Console.ReadKey();
            }
            Console.Clear();

            String sql = "DELETE from paciente where cpf=@cpf";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", p.Cpf);
            cmd.ExecuteNonQuery();
            Console.Clear();
            Console.WriteLine("Paciente deletado");
            Console.ReadKey();
            conexao.Close();
        }

        public void exibircpf()
        {
            Console.Clear();

            String sql = "SELECT cpf,nome from paciente";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("cpf: {0}, Nome:{1}", rdr["cpf"], rdr["nome"]);
                }
            }
            else
            {
                Console.WriteLine("nada cadastrado");
            }
            Console.ReadKey();
            conexao.Close();

        }
    }
}
