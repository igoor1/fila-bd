using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaBD
{
    class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Preferencial { get; set; }

        public void cadastro()
        {
            Console.Clear();

            Console.WriteLine("Digite o Cpf:");
            Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o sexo (f/m):");
            Sexo = Console.ReadLine();
            Console.WriteLine("Digite a Idade:");
            Idade = Console.ReadLine();
            Console.WriteLine("Digite o email:");
            Email = Console.ReadLine();
            Console.WriteLine("Digite se é preferencial(s/n):");
            Preferencial = Console.ReadLine();
        }

        public void atualizar()
        {
            Console.Clear();
            Console.WriteLine("Digite o Cpf que quer atualizar:");
            Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o sexo (f/m):");
            Sexo = Console.ReadLine();
            Console.WriteLine("Digite a Idade:");
            Idade = Console.ReadLine();
            Console.WriteLine("Digite o email:");
            Email = Console.ReadLine();
            Console.WriteLine("Digite se é preferencial(s/n):");
            Preferencial = Console.ReadLine();
        }

        public void delete()
        {
            Console.WriteLine("\n Digite qual cpf você deseja excluir:");
            Cpf = Console.ReadLine();
        }
    }
}
