using bytebank.Modelos.Conta;
using bytebank__Atendimento.bytebank.Exceptions;
using bytebank__Atendimento.bytebank.Util;
using System.Collections;
using System.Xml.Serialization;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
// //TestaArrayInt();
// void TestaArrayInt()
// {
//     int[] idades = new int[5];
//     idades[0] = 15;
//     idades[1] = 28;
//     idades[2] = 35;
//     idades[3] = 50;
//     idades[4] = 42;

//     Console.WriteLine($"Tamanho do Array{idades.Length}");

//     int acumulador = 0;
//     for (int i = 0; i < idades.Length; i++)
//     {
//         int idade = idades[i];
//         Console.WriteLine($"Idade no índice [{i}] é {idade}");
//         acumulador += idade;
//     }
//     int media = acumulador / idades.Length;
//     Console.WriteLine($"Média de idades é {media}");

//     Console.WriteLine("Pressione qualquer tecla para sair...");
//     Console.ReadKey();
// }

// //TestaBuscarPalavra();
// void TestaBuscarPalavra()
// {
//     string[] arrayDePalavras = new string[5];
//     for (int i = 0; i < arrayDePalavras.Length; i++)
//     {

//         Console.Write($"Digite {i + 1}ª Palavra: ");
//         arrayDePalavras[i] = Console.ReadLine();
//     }

//     Console.Write("Digite a palavra a ser encontrada: ");
//     var busca = Console.ReadLine();

//     foreach (string palavra in arrayDePalavras)
//     {
//         if (palavra.Equals(busca))
//         {
//             Console.WriteLine($"Palavra {busca} encontrada!");
//             break;
//         }
//     }
//     Console.WriteLine("Pressione qualquer tecla para sair...");
//     Console.ReadKey();
// }

// //TestaMediana(amostra);
// Array amostra = Array.CreateInstance(typeof(double), 5);
// amostra.SetValue(5.9, 0);
// amostra.SetValue(6.7, 1);
// amostra.SetValue(7.1, 2);
// amostra.SetValue(8.3, 3);
// amostra.SetValue(9.4, 4);
// //[5.9] [6.7] [7.1] [8.3] [9.4]
// void TestaMediana(Array array)
// {
//     if ((array == null) || (array.Length == 0))
//     {
//         Console.WriteLine("Array para cálculo da mediana é nulo ou vazio.");
//         return;
//     }
//     double[] numerosOrdenados = (double[])array.Clone();
//     Array.Sort(numerosOrdenados);
//     //[5.9] [6.7] [7.1] [8.3] [9.4]

//     int tamanho = numerosOrdenados.Length;
//     int meio = tamanho / 2;
//     double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

//     Console.WriteLine($"Com base na amostra a mediana: {mediana}");

//     Console.WriteLine("Pressione qualquer tecla para sair...");
//     Console.ReadKey();
// }

// void TestaArrayDeContasCorrentes()
// {
//     ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//     //listaDeContas.Adicionar(new ContaCorrente(874, "1234567-A"));
//     //listaDeContas.Adicionar(new ContaCorrente(874, "9876543-B"));
//     //listaDeContas.Adicionar(new ContaCorrente(874, "1928374-C"));
//     //listaDeContas.Adicionar(new ContaCorrente(874, "1234567-A"));
//     //listaDeContas.Adicionar(new ContaCorrente(874, "1234567-A"));
//     //listaDeContas.Adicionar(new ContaCorrente(874, "1234567-A"));

//     var contaDoEric = new ContaCorrente(416, "1234567-Z");
//     listaDeContas.Adicionar(contaDoEric);
//     //listaDeContas.ExibeLista();
//     //Console.WriteLine("==============");
//     //listaDeContas.Remover(contaDoEric);
//     //listaDeContas.ExibeLista();

//     for (int i = 0; i < listaDeContas.Tamanho; i++)
//     {
//         ContaCorrente conta = listaDeContas[i];
//         Console.WriteLine($"Indice[{i}] = {conta.Conta}/{conta.Numero_agencia}");
//     }

//     ////Desafio 1 proposto pelo curso: Achar a conta com maior saldo (complementação do código da classe ListaDeContasCorrentes)
//     //    ContaCorrente contaMaiorSaldo = listaDeContas.MaiorSaldo();
//     //    if (contaMaiorSaldo != null)
//     //    {
//     //        Console.WriteLine($"Conta do maior saldo: {contaMaiorSaldo.Conta}, Saldo: {contaMaiorSaldo.Saldo}");
//     //    }
//     //    else
//     //    {
//     //        Console.WriteLine("Não há contas na lista.");
//     //    }

// }
// //TestaArrayDeContasCorrentes();
#endregion

#region Exemplos de uso do List
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Teste Genérica");

//public class Generica<T>
//{
//    public void MostrarMensagem (T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}

//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");
//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{range[i].Conta}]");
//}
#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(95, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60}
};

AtendimentoCliente();
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("===        Atendimento       ===");
            Console.WriteLine("===  1 - Cadastrar Conta     ===");
            Console.WriteLine("===  2 - Listar Contas       ===");
            Console.WriteLine("===  3 - Remover Conta       ===");
            Console.WriteLine("===  4 - Ordenar Contas      ===");
            Console.WriteLine("===  5 - Pesquisar Conta     ===");
            Console.WriteLine("===  6 - Sair do Sistema     ===");
            Console.WriteLine("================================");
            Console.WriteLine("\n\n");
            Console.WriteLine("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {

                throw new ByteBankException(excecao.Message);
            }
            
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());
    ContaCorrente conta = new ContaCorrente(numeroAgencia);
    Console.WriteLine($"Número da conta [NOVA] : {conta.Conta}");
    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();

}
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta: " + item.Conta);
        Console.WriteLine("Saldo da Conta: " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular: " + item.Titular.Cpf);
        Console.WriteLine("profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

