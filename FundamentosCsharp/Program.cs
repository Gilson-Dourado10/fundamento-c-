using System;

namespace FundamentosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo(" C# É MUITO LEGAL  ");
            var nome = RetornaNome("Gilson", "Dourado");
            Console.WriteLine(nome);
            
            var resultado = SomaDouble(20.5, 3.5);
            Console.WriteLine("A soma do resultado é: " + resultado);
            
        }

        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
            
        }
        static string RetornaNome(string nome, string sobrenome, int idade = 36)
        {
            return (nome + " " + sobrenome + " tem " + idade.ToString() + " anos");
        }
        static double SomaDouble(double var1, double var2)
        {
            return (var1) + (var2);
        }
        static void EscrevaLinha(string linha)
        {
            Console.WriteLine(linha);
            EscrevaLinha("********---------------***********");
        }
    }
}
