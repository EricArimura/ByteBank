using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TestaArrayInt();
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 15;
    idades[1] = 28;
    idades[2] = 35;
    idades[3] = 50;
    idades[4] = 42;

    Console.WriteLine($"Tamanho do Array{idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Idade no índice [{i}] é {idade}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades é {media}");

    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}

//TestaBuscarPalavra();
void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {

        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra {busca} encontrada!");
            break;
        }
    }
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}

//TestaMediana(amostra);
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(6.7, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(8.3, 3);
amostra.SetValue(9.4, 4);
//[5.9] [6.7] [7.1] [8.3] [9.4]

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana é nulo ou vazio.");
        return;
    }
    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[5.9] [6.7] [7.1] [8.3] [9.4]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana: {mediana}");

    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}

void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "1234567-A"),
        new ContaCorrente(874, "9876543-B"),
        new ContaCorrente(874, "1928374-C")
    };

    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
    }
}

TestaArrayDeContasCorrentes();
