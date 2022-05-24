using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaBD
{
    class Menu
    {
        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar Paciente");
            Console.WriteLine("2 - Exibir pacientes");
            Console.WriteLine("3 - Atualizar Paciente");
            Console.WriteLine("4 - Deletar Paciente");
            Console.WriteLine("Q - Sair");
            string op;
            op = Console.ReadLine();
            return op.ToUpper();
        }
    }
}
