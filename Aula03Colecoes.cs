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
               
                //CriarLista();
                //ExibirLista();
                ExemplosListasColecoes();


            }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Duds";
            f1.Cpf = "12345677791011";
            f1.Datadeadimissao = DateTime.Parse("01/07/2000");
            f1.Salario = 141.000M;
            f1.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "VALTER";
            f2.Cpf = "1232457891011";
            f2.Datadeadimissao = DateTime.Parse("01/04/2000");
            f2.Salario = 120.000M;
            f2.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "JACKCHAN";
            f3.Cpf = "123454711011";
            f3.Datadeadimissao = DateTime.Parse("02/05/2020");
            f3.Salario = 156.000M;
            f3.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "viado";
            f4.Cpf = "1234567253011";
            f4.Datadeadimissao = DateTime.Parse("04/05/2014");
            f4.Salario = 178.000M;
            f4.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "olipop";
            f5.Cpf = "12345677898411";
            f5.Datadeadimissao = DateTime.Parse("06/03/2010");
            f5.Salario = 112.000M;
            f5.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Bruno";
            f6.Cpf = "1234978554";
            f6.Datadeadimissao = DateTime.Parse("05/02/2012");
            f6.Salario = 179.000M;
            f6.Tipofuncionario = TipofuncionarioEnum.clt;
            lista.Add(f6);

        }

        public static void ExibirLista()
        {
            string dados = "";

            for(int i=0; i < lista.Count; i++)
            {
                dados += "=====================================\n";
                dados += string.Format("Id: {0}\n", lista[i].Id);
                dados += string.Format("Nome: {0 \n}", lista[i].Nome);
                dados += string.Format("CPF: {0} \n", lista[i].Cpf);
                dados += string.Format("Adimissão: {0:dd/mm/yyyy}");
                dados += string.Format("Salario: {0:c2 \n", lista[i].Salario);
                dados += string.Format("Salario: {0:c2 \n", lista[1].Tipofuncionario);
                dados += "======================================= \n";
            }

            Console.WriteLine(dados);

        }

        public static void ObterPorId(int Id)
        {
            Funcionario fbusca = lista.Find( x => x.Id == Id);

            Console.WriteLine($"Personagem encontrado : {fbusca.Nome}");



        }

        public static void ExemplosListasColecoes() 
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******");
            Console.WriteLine("==================================================");
            CriarLista(); 
            int opcaoEscolhida = 0; 
            do 
            {    Console.WriteLine("==================================================");       
                 Console.WriteLine("---Digite o número referente a opção desejada: ---");
                 Console.WriteLine("1 - Obter Por Id"); 
                 Console.WriteLine("2 - Adicionar Funcionario");
                 Console.WriteLine("3 - Obter por Id digtado");
                 Console.WriteLine("4 - Obter por Nome");
                 Console.WriteLine("5 - Tipo do funcionario ");
                 Console.WriteLine("6 - Valide o Nome");
                 Console.WriteLine("7 - Exibit Estatstica");
                 Console.WriteLine("8 - Filtragem");
                 Console.WriteLine("==================================================");
                 Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");
                 Console.WriteLine("==================================================");       

                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                
                switch (opcaoEscolhida) 

                { 
                    case 1:
                        Console.WriteLine(" Jesus");
                        break;
                    case 2:
                         AdicionarFuncionario();
                         break;
                         
                    case 3:
                    Console.WriteLine("Digte o ID do Funcionario que você deseja buscar");
                    int id = int.Parse(Console.ReadLine());
                    ObterPorId(id);
                    break;
                    
                    case 4:
                    Console.WriteLine("Digte o Nome do Funcionario:");
                    string nome = Console.ReadLine();
                    ObterPorNome(nome);
                    break;

                    case 5:
                    Console.WriteLine("Digite o Nome do Funcionario e O tipo sera Exibido");
                    int f = int.Parse(Console.ReadLine());
                    ObeterPorTipo(f);
                    break;

                    case 6:
                    Console.WriteLine("Digte um nome:");
                    string name = Console.ReadLine();
                    validarNome(name);
                    break;

                    case 7:
                
                        obterEstat();

                    break;

                    case 8:
                     
                        filtragem();

                     break;





                    default: 
                        Console.WriteLine("Saindo do sistema....");
                        break; 
                } 
            } 
            
            while (opcaoEscolhida >= 1 && opcaoEscolhida <= 10);
           
            Console.WriteLine("==================================================");
            Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *");
            Console.WriteLine("==================================================");    
            
            }             


            public static void AdicionarFuncionario()

            {
                Funcionario f = new Funcionario();

                Console.WriteLine("Digite o nome: ");
                f.Nome = Console.ReadLine();

                Console.WriteLine("Digite o Salario: ");
                f.Salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Dt de adimissão: ");
                f.Datadeadimissao = Convert.ToDateTime(Console.ReadLine());

                if (string.IsNullOrEmpty(f.Nome))
                {
                    Console.WriteLine("Valor do Salario não pode ser 0");
                    return;
                }
                else if (f.Salario == 0)
                {
                    Console.WriteLine("Valor do Salario nao pode ser 0");
                    return;
                }
                else
                {
                    lista.Add(f);
                    ExibirLista();
                }
            }

            public static void ObterPorNome(string Nome)
        {
            
            if(lista.Find( x => x.Nome == Nome) != null)
            {
                Funcionario fbusca = lista.Find( x => x.Nome == Nome);

                Console.WriteLine($"Personagem encontrado : {fbusca.Nome}");
            }
            else
            {
                Console.WriteLine("Funcionario não Existe");
            }
            

        }

        public static void ObeterPorTipo(int id )
        {
            Funcionario fbusca = lista.Find( x => x.Id == id);

            Console.WriteLine($"Personagem encontrado : {fbusca.Nome}");

        }

         public static void teste(int id )
        {
            Funcionario fbusca = lista.Find( x => x.Id == id);

            Console.WriteLine($"Personagem encontrado : {fbusca.Nome}");

        }

        public static void validarNome( string name)

        {
            if(name.Length <= 2)
            {
                Console.WriteLine("Nome Invalido");

            }
            else
            {
                Console.WriteLine("Nome Valido");
            }
            

        }

        public static void obterEstat()
        {
            int qtd = lista.Count();
            decimal somatoria = lista.Sum(x => x.Salario);

            Console.WriteLine(string.Format("Existem {0} Funcionarios, A soma dos salario é {1}", qtd, somatoria));

        }

        public static void filtragem()
        {
            lista.RemoveAll(x => x.Id < 4);
            lista  = lista.OrderBy(x => x.Id).ToList();
            ExibirLista();


        }

    


}
}