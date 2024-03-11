using System;
using System.Collections.Generic;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;


namespace Aula03Colecoes
{
    
    class Teste
    {
         static List<Funcionario> lista = new List<Funcionario>();
            static void Main(string[] args) 
            {
               
                CriarLista();
                ExibirLista();


            }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "1234567891011";
            f1.Datadeadimissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f6);

        }

        public static void ExibirLista()
        {
            string dados = "";

            for(int i=0; i < lista.Count; i++)
            {
                dados += "=====================================\n";
                dados += string.Format("Id: {0}\n", lista[i].Id);
                dados +=
                dados +=
                dados +=
                dados +=
                dados +=
                dados +=


            }

        }


    }


}