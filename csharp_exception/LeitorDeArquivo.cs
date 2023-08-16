using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception;

public class LeitorDeArquivo
{
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
        Arquivo = arquivo;

        Console.WriteLine("Abrindo arquivo: " + arquivo);
    }
    /// <summary>
    /// Lê a próxima linha do arquivo.
    /// </summary>
    /// <returns>A próxima linha do arquivo.</returns>
    /// <exception cref="IOException">Exceção lançada quando ocorre um erro de leitura do arquivo.</exception>
    public string LerProximaLinha()
    {
        Console.WriteLine("Lendo linha. . .");

        throw new IOException() 
        {

        };

    }

    public void Fechar()
    {
        Console.WriteLine("Fechando arquivo.");
    }
}