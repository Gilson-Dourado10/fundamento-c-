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
        }

        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        static string RetornaNome
        (
            string nome,
            string sobrenome,
            int idade = 35
        )
        {
            return (nome + " " + sobrenome + " tem " + idade.ToString() + " anos");
        }

    }

}
