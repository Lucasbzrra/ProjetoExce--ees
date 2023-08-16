using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo("Teste");
try
{
    // Tenta ler a próxima linha do arquivo.
    leitorDeArquivo.LerProximaLinha();
}
catch (IOException)
{
    // Se ocorrer uma exceção do tipo IOException ao ler o arquivo,
    // imprime a mensagem de erro informando que o arquivo foi interrompido.
    Console.WriteLine("Arquivo interropido");
}
finally
{
    // No final, independentemente de ocorrer ou não uma exceção,
    // o método Fechar() é chamado para garantir que o recurso do arquivo seja liberado.
    leitorDeArquivo.Fechar();
}

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(2, "1234-X");
    conta1.Sacar(500);
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
*/
