// O desafio é criar um programa que me diga se a entrada é um palíndromo ou não
namespace Palíndromo;
class Program
{
    public static void Main ()
    {
        Console.Write("é um palíndromo ou não é? eis a questão! Digite uma palavra e te direi: ");
        string awnser = Console.ReadLine();
        String reverseAwnser = new 
        string(awnser.Reverse().ToArray());  //reverter a palavra e transofrmar em array para reverter
        if (reverseAwnser.Equals(awnser, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("É um palíndromo");
        }
        else
        {
            Console.WriteLine("não é um palíndromo");
        }

    }
}