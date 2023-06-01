// Questão 3 C

using System;

using System;

class Program
{
    static int[] vetor = new int[100];
    static int tamanho = 0;

    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Inserir no vetor");
            Console.WriteLine("2 - Buscar no vetor por busca binária");
            Console.WriteLine("3 - Buscar no vetor por busca sequencial");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirNoVetor();
                    break;
                case "2":
                    BuscarPorBuscaBinaria();
                    break;
                case "3":
                    BuscarPorBuscaSequencial();
                    break;
                case "4":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void InserirNoVetor()
    {
        Console.Write("Digite o valor a ser inserido: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        vetor[tamanho] = valor;
        tamanho++;

        Console.WriteLine("Valor inserido no vetor.");
    }

    static void BuscarPorBuscaBinaria()
    {
        if (tamanho == 0)
        {
            Console.WriteLine("O vetor está vazio. Nenhum valor para buscar.");
            return;
        }

        Console.Write("Digite o valor a ser buscado: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        Array.Sort(vetor);

        int indice = BuscaBinaria(vetor, valor);

        if (indice != -1)
        {
            Console.WriteLine($"O valor {valor} foi encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não foi encontrado no vetor.");
        }
    }

    static void BuscarPorBuscaSequencial()
    {
        if (tamanho == 0)
        {
            Console.WriteLine("O vetor está vazio. Nenhum valor para buscar.");
            return;
        }

        Console.Write("Digite o valor a ser buscado: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        int indice = BuscaSequencial(vetor, valor);

        if (indice != -1)
        {
            Console.WriteLine($"O valor {valor} foi encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não foi encontrado no vetor.");
        }
    }

    static int BuscaBinaria(int[] vetor, int valor)
    {
        int limiteInicial = 0;
        int limiteFinal = tamanho - 1;

        while (limiteInicial <= limiteFinal)
        {
            int indiceMedio = (limiteInicial + limiteFinal) / 2;
            int valorMedio = vetor[indiceMedio];

            if (valorMedio == valor)
            {
                return indiceMedio;
            }
            else if (valor < valorMedio)
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

    static int BuscaSequencial(int[] vetor, int valor)
    {
        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] == valor)
            {
                return i;
            }
        }

        return -1;
    }
}