using System;

class Program
{
    static void Main()
    {
                                                //EXERCÍCIO 1: MANIPULAÇÃO BÁSICA DE EXCEÇÕES
                                //Descrição: Crie um programa que leia um número inteiro do usuário e divida 100
                                    //por esse número.Trate as exceções que possam ocorrer, como a tentativa de
                                                //divisão por zero e a entrada inválida do usuário.
        try
        {
            // Solicita ao usuário para inserir um número
            Console.Write("\n\n\n                                            Digite um número inteiro: ");
            string input = Console.ReadLine();

            // Converte a entrada para um número inteiro
            int divisor = int.Parse(input);

            // Calcula a divisão
            int resultado = 100 / divisor;

            // Exibe o resultado
            Console.WriteLine($"\n\n\n                                      O resultado da divisão de 100 por {divisor} é {resultado}.");
        }
        catch (DivideByZeroException)
        {
            // Tratamento para divisão por zero
            Console.WriteLine("\n\n                             Erro: Não é possível dividir por zero.");
        }
        catch (FormatException)
        {
            // Tratamento para entrada inválida
            Console.WriteLine("\n\n                            Erro: Entrada inválida. Por favor, insira um número inteiro.");
        }
        catch (Exception ex)
        {
            // Tratamento para outras exceções
            Console.WriteLine($"\n\n                          Ocorreu um erro inesperado: {ex.Message}");
        }

        // Aguarda a entrada do usuário para encerrar o programa
        Console.WriteLine("\n\n                                             Pressione Enter para sair...");
        Console.ReadLine();
    }
}
