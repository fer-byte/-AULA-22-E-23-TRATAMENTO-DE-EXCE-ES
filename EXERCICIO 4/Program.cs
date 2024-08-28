using System;
                                                    //EXERCÍCIO 4: RE - LANÇAMENTO DE EXCEÇÕES
                                    //Descrição: Crie uma função que lança uma exceção quando um valor inválido é
                                     //passado. No bloco de captura, relance a exceção para que seja tratada em um nível superior.

public class ValorInvalidoException : Exception
{
    public ValorInvalidoException() { }

    public ValorInvalidoException(string message)
        : base(message) { }

    public ValorInvalidoException(string message, Exception innerException)
        : base(message, innerException) { }
}

class Program
{
    static void Main()
    {
        try
        {
            // Chama a função que pode lançar uma exceção
            ValidarValor(-1);
        }
        catch (ValorInvalidoException ex)
        {
            // Trata a exceção relançada
            Console.WriteLine($"\n\n\n        Erro: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Trata outras exceções inesperadas
            Console.WriteLine($"\n\n\n                      Ocorreu um erro inesperado: {ex.Message}");
        }

        // Aguarda a entrada do usuário para encerrar o programa
        Console.WriteLine("\n\n\n                               Pressione Enter para sair...");
        Console.ReadLine();
    }

    static void ValidarValor(int valor)
    {
        try
        {
            // Verifica se o valor é inválido
            if (valor < 0)
            {
                // Lança a exceção personalizada
                throw new ValorInvalidoException("\n\n\n                    O valor não pode ser negativo.");
            }

            // Se o valor for válido, exibe uma mensagem
            Console.WriteLine($"\n\n\n                                  O valor {valor} é válido.");
        }
        catch (ValorInvalidoException)
        {
            // Relança a exceção para que possa ser tratada em um nível superior
            throw;
        }
    }
}

