using System;


      public class PessoaFisica : Cliente
      {
          public string Nome { get; set; }
          public string Sobrenome { get; set; }
          public string RG { get; set; }
          public string CPF { get; set; }
          public DateTime DataNascimento { get; set; }
          public int Idade { get; set; }
          public string FaixaEtaria { get; set; }
          public double Renda { get; set; }
  
       
          public void CalcularIdade()
          {
              Idade = DateTime.Now.Year - DataNascimento.Year;
              if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                  Idade = Idade - 1;
  
              if (Idade <= 11)
                  FaixaEtaria = "criança";
              else if (Idade >= 12 && Idade <= 21)
                  FaixaEtaria = "jovem";
              else if (Idade >= 22 && Idade <= 59)
                  FaixaEtaria = "adulto";
              else
                  FaixaEtaria = "idoso";
          }
      }
  
