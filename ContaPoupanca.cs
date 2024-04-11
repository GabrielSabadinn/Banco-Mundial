using System;

public class ContaPoupanca : Conta
{
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
  public override void Depositar(double valor)
  {
      Saldo += valor;
      Console.WriteLine("Depósito realizado com sucesso!");
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
}