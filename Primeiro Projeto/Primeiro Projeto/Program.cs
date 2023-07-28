// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>(); //criamos uma lista vazia 
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOperacoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcãoEscolhidaNumerica = int.Parse(opcaoEscolhida); //<-- Converção da opção escolhida que era string para int.

    switch (opcãoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcãoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcãoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Volte sempre :) ");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear(); //Comando para Limpar o Console.
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; //Sinal de ! no final para mostrar que não queremos trabalhar com valor nulo.
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso"); // o simbulo de $ no começo da frase junto das chaves {} se chama interpolação de string
    Thread.Sleep(2000); // essa função serve para esperar, no caso ele vai esperar 2 milissegundos
    Console.Clear();
    ExibirOperacoesDoMenu();
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas."); // o simbulo de \n serve para pular uma linha
    /*for (int i = 0; i < listaDasBandas.Count; i++)
        Console.WriteLine($"Banda: {listaDasBandas[i]}");*/
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOperacoesDoMenu();
}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
        
}

//Essa parte chama os void's.
ExibirLogo();
ExibirOperacoesDoMenu();