using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma pessoa física
        PessoaFisica pessoaFisica = new PessoaFisica
        {
            Nome = "Gabriel",
            Sobrenome = "Sabadin",
            RG = "123456789",
            CPF = "123.456.789-00",
            DataNascimento = new DateTime(1990, 1, 1),
            Id = 1,
            Endereco = "Av. Dr. Walter so jobim",
            Telefone = "(51) 99383-8045",
            Email = "gbsabadin@example.com"
        };

        // Criando uma conta corrente para a pessoa física
        ContaCorrente contaCorrente = new ContaCorrente
        {
            Titular = pessoaFisica,
            Numero = 123456,
            Agencia = 1234,
            TaxaSaque = 1.00
        };

        // Depositar e sacar na conta corrente
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(200);

        // Exibir saldo da conta corrente
        Console.WriteLine($"Saldo da Conta Corrente: {contaCorrente.ConsultarSaldo()}");

        // Criando uma conta poupança
        ContaPoupanca contaPoupanca = new ContaPoupanca
        {
            Titular = pessoaFisica,
            Numero = 789012,
            Agencia = 5678
        };

        // Depositar e sacar na conta poupança
        contaPoupanca.Depositar(500);
        contaPoupanca.Sacar(100);

        // Exibir saldo da conta poupança
        Console.WriteLine($"Saldo da Conta Poupança: {contaPoupanca.ConsultarSaldo()}");

        // Criando uma pessoa jurídica
        PessoaJuridica pessoaJuridica = new PessoaJuridica
        {
            CNPJ = "00.000.000/0000-00",
            RazaoSocial = "Empresa JC ALIMENTACAO",
            NomeFantasia = "PIAZZA66",
            InscEstadual = 123456,
            DataAbertura = new DateTime(2000, 1, 1),
            Id = 2,
            Endereco = "Voluntarios da Patria 66",
            Telefone = "(55) 99999-999",
            Email = "piazza66@example.com",
            Faturamento = 1000000
        };

        // Exibir informações da pessoa jurídica
        Console.WriteLine($"Razão Social: {pessoaJuridica.RazaoSocial}");
        Console.WriteLine($"Faturamento: {pessoaJuridica.Faturamento}");

        // Realizar um pagamento e um empréstimo na conta corrente
        contaCorrente.Pagar(100);
        contaCorrente.Emprestimo(5000);

        // Exibir saldo da conta corrente após pagamento e empréstimo
        Console.WriteLine($"Saldo da Conta Corrente: {contaCorrente.ConsultarSaldo()}");
    }
}
