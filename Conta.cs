using System;

public abstract class Conta
{
    public Cliente Titular { get; set; }
    public long Numero { get; set; }
    public int Agencia { get; set; }
    public double Saldo { get; set; }
    public double TaxaSaque { get; set; }

    public abstract void Sacar(double valor);
    public abstract double ConsultarSaldo();
    public abstract void Transferir(Conta conta, double valor);
    public abstract void Depositar(double valor); 
}
