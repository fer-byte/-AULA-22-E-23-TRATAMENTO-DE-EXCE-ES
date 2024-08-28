using System;
using System.IO;
                                        //EXERCÍCIO 3: TRATAMENTO DE EXCEÇÕES EM OPERAÇÕES DE ARQUIVO
                                    //Descrição: Crie um programa que tente ler um arquivo de texto e exiba seu
                                          //conteúdo. Trate as exceções que possam ocorrer, como arquivos não
                                                //encontrados e problemas de acesso ao arquivo.

class Program
{
    static void Main()
    {
        // Nome do arquivo a ser lido
        string nomeArquivo = "exemplo.txt";

        try
        {
            // Tenta ler o conteúdo do arquivo
            string conteudo = File.ReadAllText(nomeArquivo);

            // Exibe o conteúdo do arquivo
            Console.WriteLine("\n\n\n                                       Conteúdo do arquivo:");
            Console.WriteLine(conteudo);
        }
        catch (FileNotFoundException)
        {
            // Tratamento para arquivo não encontrado
            Console.WriteLine($"\n\n                            Erro: O arquivo '{nomeArquivo}' não foi encontrado.");
        }
        catch (UnauthorizedAccessException)
        {
            // Tratamento para problemas de acesso ao arquivo
            Console.WriteLine($"\n\n                Erro: Acesso negado ao arquivo '{nomeArquivo}'. Verifique suas permissões.");
        }
        catch (IOException ex)
        {
            // Tratamento para outros erros de entrada/saída
            Console.WriteLine($"\n\n                Erro ao acessar o arquivo: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Tratamento para outras exceções inesperadas
            Console.WriteLine($"\n\n                Ocorreu um erro inesperado: {ex.Message}");
        }

        // Aguarda a entrada do usuário para encerrar o programa
        Console.WriteLine("\n\n                                     Pressione Enter para sair...");
        Console.ReadLine();
    }
}

