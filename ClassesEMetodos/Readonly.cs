using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNacimento()
            {
                return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }

        public static void Executar()
        {
            var novoCliente = new Cliente("Augusto Santos", new DateTime(1999, 04, 04));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNacimento());
        }
    }
}
