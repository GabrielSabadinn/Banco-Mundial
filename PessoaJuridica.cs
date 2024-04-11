using System;
using System.Collections.Generic;

public class PessoaJuridica : Cliente
{
    public List<PessoaFisica> Socios { get; set; }
    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public int InscEstadual { get; set; }
    public DateTime DataAbertura { get; set; }
    public int Idade { get; set; }
    public double Faturamento { get; set; }
}
