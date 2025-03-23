using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComun
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }   
        public int Subtrair(int a, int b)
        {
            return a - b;
        }   
        
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar (int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprmir()
        {
            Console.WriteLine(memoria);
            return this;
        }   

        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComun = new CalculadoraComun();
            var resultado = calculadoraComun.Somar(2, 3);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComun.Subtrair (2, 7));
            Console.WriteLine(calculadoraComun.Multiplicar (4,5));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multplicar(3).Imprmir().Limpar().Imprmir();
        }
    }
}
