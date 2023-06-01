// Questão 2

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

        return -1; 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite as palavras separadas por espaço:");
        string entrada = Console.ReadLine();
        string[] vetorPalavras = entrada.Split(' ');

        Console.WriteLine("Digite a palavra que deseja buscar:");
        string palavraBuscada = Console.ReadLine();

        Array.Sort(vetorPalavras);
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

