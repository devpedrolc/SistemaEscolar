using System;
using System.Globalization;


namespace ProjetoSistemaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual nome do aluno:");
            String nome = Console.ReadLine();
            
            Console.WriteLine("Digite a nota prova A ");
            double nota1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nota prova B ");
            double nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nota prova B ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("---- RESULTADO FINAL----");

           
            if (media < 5)
            {
                Console.WriteLine($"nota final = {media:F2} REPROVADO ! ");
            }
             else if (media > 5.1 || media <=6.9)
            {
                Console.WriteLine($"nota final = {media:F2} RECUPERAÇÃO ! ");
            }
            else
            {
                Console.WriteLine($"nota final = {media:F2} APROVADO ! ");
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Fim do Programa ! ");

        }
    }
}
