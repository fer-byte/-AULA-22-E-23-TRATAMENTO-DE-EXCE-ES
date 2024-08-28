using System;

                                        //EXERCÍCIO 2:LANÇAMENTOECAPTURA DE EXCEÇÕES PERSONALIZADAS
                                //Descrição: Crie uma exceção personalizada chamada InvalidAgeException para
                                //lidar com erros relacionados à idade. Implemente uma função que verifica se a
                                //idade fornecida está dentro de um intervalo válido (0 a 120 anos). Lance e capture
                                            //a exceção personalizada se a idade estiver fora do intervalo.



// Define a exceção personalizada
public class InvalidAgeException : Exception
{
    public InvalidAgeException() { }

    public InvalidAgeException(string message)
        : base(message) { }

    public InvalidAgeException(string message, Exception innerException)
        : base(message, innerException) { }
}

class Program
{
    static void Main()
    {
        try
        {
            // Solicita ao usuário para inserir a idade
            Console.Write("\n\n\n                                       Digite a idade: ");
            string input = Console.ReadLine();

            // Converte a entrada para um número inteiro
            int idade = int.Parse(input);

            // Verifica se a idade está dentro do intervalo válido
            VerificarIdade(idade);

            // Se a idade estiver válida
            Console.WriteLine($"\n\n\n                                      A idade {idade} é válida.");
        }
        catch (InvalidAgeException ex)
        {
            // Tratamento para a exceção personalizada
            Console.WriteLine($"\n\n                                Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            // Tratamento para entrada inválida
            Console.WriteLine("\n\n                                 Erro: Entrada inválida. Por favor, insira um número inteiro.");
        }
        catch (Exception ex)
        {
            // Tratamento para outras exceções
            Console.WriteLine($"\n\n                                Ocorreu um erro inesperado: {ex.Message}");
        }

        // Aguarda a entrada do usuário para encerrar o programa
        Console.WriteLine("\n\n\n                                   Pressione Enter para sair...");
        Console.ReadLine();
    }

    static void VerificarIdade(int idade)
    {
        // Verifica se a idade está fora do intervalo válido
        if (idade < 0 || idade > 120)
        {
            // Lança a exceção personalizada se a idade estiver fora do intervalo
            throw new InvalidAgeException("\n\n\n                   A idade deve estar entre 0 e 120 anos.");
        }
    }
}

