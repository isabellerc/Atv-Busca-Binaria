//Questão 1

using Questão_1;
using System;

class Program
{
    static int BuscaBinaria(string[] vetor, string palavra)
    {
        int limiteInicial = 0;
        int limiteFinal = vetor.Length - 1;

        while (limiteInicial <= limiteFinal)
        {
            int indiceMedio = (limiteInicial + limiteFinal) / 2;
            string palavraMedio = vetor[indiceMedio];

            if (palavraMedio == palavra)
            {
                return indiceMedio;
            }
            else if (palavra.CompareTo(palavraMedio) < 0)
            {
                limiteFinal = indiceMedio - 1;
            }
            else
            {
                limiteInicial = indiceMedio + 1;
            }
        }

        return -1; // Palavra não encontrada
    }

    static void Main(string[] args)
    {
        string[] vetorPalavras = new string[5];
        Console.WriteLine("Digite 5 palavras");
        
        for (int i = 0; i<vetorPalavras.Length; i++)
        {
            vetorPalavras[i] = Console.ReadLine();
        }

        Console.Write("Digite a palavra que deseja buscar: ");
        string palavraBuscada = Console.ReadLine();

        //int indice = BuscaBinaria(Array.Sort(vetorPalavras), palavraBuscada);
        int indice = BuscaBinaria(vetorPalavras, palavraBuscada);

        if (indice != -1)
        {
            Console.WriteLine($"A palavra '{palavraBuscada}' foi encontrada no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavraBuscada}' não foi encontrada.");
        }
    }
}




