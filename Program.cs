using System;
using aula_1012.obj;



while (true)
{
    Console.Clear();
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1 - Fazer Teste RIASEC");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha: ");

    string opcao = Console.ReadLine()!;

    if (opcao == "1")
    {
        Console.Clear();
        var teste = new TesteRIASEC();
        teste.Iniciar();
    }
    else if (opcao == "0")
    {
        Console.WriteLine("Saindo...");
        return;
    }
    else
    {
        Console.WriteLine("Opção inválida!\n");
    }
}