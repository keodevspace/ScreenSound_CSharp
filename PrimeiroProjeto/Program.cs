// Screen Sound

string boasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(boasVindas);
    Console.WriteLine("\nBoas Vindas ao Screen Sound!");
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nMenu Principal");
    Console.WriteLine("1 - Cadastrar Banda");
    Console.WriteLine("2 - Mostrar Bandas");
    Console.WriteLine("3 - Avaliar Banda");
    Console.WriteLine("4 - Exibir Média de Banda");
    Console.WriteLine("5 - Sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("\nCadastrar Banda");
            break;
        case 2:
            Console.WriteLine("\nMostrar Bandas");
            break;
        case 3:
            Console.WriteLine("\nAvaliar Banda");
            break;
        case 4:
            Console.WriteLine("\nExibir Média de Banda");
            break;
        case 5:
            Console.WriteLine("\nSair");
            break;
        default:
            Console.WriteLine("\nOpção Inválida");
            break;
    }

}  

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();



