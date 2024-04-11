using System;

public class ContaCorrente : Conta
{
    public string TipoConta { get; set; }
    public double Limite { get; set; }
    public double TaxaJuros { get; set; }

    public override void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }

    public override double ConsultarSaldo()
    {
        return Saldo;
    }

    public override void Transferir(Conta contaDestino, double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Transferência realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar a transferência.");
        }
    }

   public override void Depositar(double valor) 
    {
        Saldo += valor;
        Console.WriteLine("Depósito realizado com sucesso!");
    }

    public void Pagar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine("Pagamento realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o pagamento.");
        }
    }

    public void Emprestimo(double valor)
    {
       
        if (valor > 0)
        {
            
            Saldo += valor;
            Console.WriteLine("Empréstimo de R$ " + valor + " realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor do empréstimo inválido.");
        }
    }
}
