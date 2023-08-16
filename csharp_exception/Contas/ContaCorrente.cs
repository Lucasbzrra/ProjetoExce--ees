using csharp_exception.Titular;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Contas;

public class ContaCorrente
{
    public static int TotalDeContasCriadas { get; private set; }

    public static float TaxaOperacao { get; private set; }

    private int numero_agencia;
    public int Numero_agencia
    {
        get { return numero_agencia; }
        private set
        {
            if (value > 0)
            {
                numero_agencia = value;
            }
        }
    }


    public string Conta { get; set; }

    private double saldo = 100;

    public Cliente Titular { get; set; }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    /// <summary>
    /// Realiza um saque da conta corrente.
    /// </summary>
    /// <param name="valor">O valor a ser sacado.</param>
    /// <returns>Verdadeiro se o saque for bem-sucedido, falso caso contrário.</returns>
    /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o saldo é insuficiente.</exception>

    public bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            throw new SaldoInsuficienteException ( $"Valor do saque e maior que o saldo {nameof(saldo)}") ;

        }
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (saldo < valor)
        {
            return false;
        }
        else
        {
            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }

    public void SetSaldo(double valor)
    {
        if (valor < 0)
        {
            return;
        }
        else
        {
            saldo = valor;
        }
    }

    public double GetSaldo()
    {
        return saldo;
    }
    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="ContaCorrente"/>.
    /// </summary>
    /// <param name="numero_agencia">O número da agência.</param>
    /// <param name="numero_conta">O número da conta.</param>
    /// <exception cref="ArgumentException">Exceção lançada quando o número da agência é menor ou igual a zero.</exception>
    public ContaCorrente(int numero_agencia, string numero_conta)
    {
        Numero_agencia = numero_agencia;
        Conta = numero_conta;

        if (numero_agencia <= 0)
        {
            throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
        }


        /* try
         {
             TaxaOperacao = 30 / TotalDeContasCriadas;
         }
         catch (DivideByZeroException)
         {
             Console.WriteLine("Ocorreu um erro! Não é possível fazer uma divisão por zero!");
         }          

         TotalDeContasCriadas++;
        */
    }


}
