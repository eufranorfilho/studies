using desafio_fundamentos_dio.models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0; 

Console.WriteLine("Seja bem vindo ao sistema de estacionamento csharp! \n" + "Digite o preço inicial: ");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite abaixo o preço por hora: ");

precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

var exibirMenu = true; 
var opcao = string.Empty;
while (exibirMenu)
{
    Console.WriteLine("Digite sua opção abaixo: ");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": 
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculo();
            break;
        case "4":
            exibirMenu = false;
            break;

        default: Console.WriteLine("Opção invalida.");
        break;
    }

}

Console.WriteLine("Pressione qualquer tecla para continuar.");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("O programa se encerrou");
