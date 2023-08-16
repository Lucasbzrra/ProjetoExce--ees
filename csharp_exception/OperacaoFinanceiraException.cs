using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception;

public class OperacaoFinanceiraException : Exception
{
    public OperacaoFinanceiraException(string mensagem) : base(mensagem) 
    {

    }
    public OperacaoFinanceiraException(string mensagem, Exception exceçaoineterna): base (mensagem,exceçaoineterna)
    {

    }

}
