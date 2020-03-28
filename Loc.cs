using System;
using System.Collections.Generic;
using static System.Console;

namespace Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "";
            String endereco = "";
            String tel = "";
            String email = "";
            String decisao = "";
            String filme = "";
            String valor = "";
            int quant = 0;
            int opcao = 0;
            
            // abertura do programa

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("           LOCADORA DE FILMES          ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            //Inicio do cadastro cliente

            Console.WriteLine("                                             ");
            Console.WriteLine("           CADASTRO DE CLIENTE               ");
            Console.WriteLine("          ---------------------              ");


            
            Console.WriteLine("");

            Console.Write("Nome do cliente: ");
            nome = Console.ReadLine();

            Console.Write("Endereco: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            tel = Console.ReadLine();

            Console.Write("E-mail: ");
            email = Console.ReadLine();

            Cliente cliente = new Cliente (nome, endereco, tel, email);



            Console.WriteLine("");
            Console.WriteLine("       O Cadastro ja esta pronto para Locar Filmes      ");
            Console.WriteLine("             Pressione ENTER para Continuar              ");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("                                             ");
            Console.WriteLine("             LOCAR FILMES               ");
            Console.WriteLine("          -----------------------            ");
            Console.WriteLine("");
            Console.WriteLine(" Cliente: " + nome);
            Console.WriteLine("");

            // Inicio para locacao de filmes com decisao de locar mais para adicionar noc=vas locacoes

            Locacao locacao = new Locacao (nome,valor);

            decisao = "s";
            do
            {
                if (quant <= 4)
                {
                    Console.Write("Nome do Filme " + (quant + 1) + ": ");
                    filme = Console.ReadLine();
                    quant = quant + 1;
                    Console.WriteLine("");


                    Console.Write("Valor da Locacao do Filme: ");
                    valor = Console.ReadLine();
                    valor = valor;
                    Console.WriteLine("");




                    Console.Write("Deseja alugar mais algum filme " + nome + "? (S = Sim ou N = Nao): ");
                    decisao = Console.ReadLine();
                    Console.WriteLine("");
                
                    if (decisao == "n")
                        break;
                }
                else

                //caso o cliente nao tenha mais credito para locar filmes 

                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("ATENCAO! " + nome + " Vc não tem mais creditos para locacao.");                            
                    Console.WriteLine("");
                    break;
                }

            } while (decisao != "n");

            // apos cliente cadastrado e filmes locados abaixo ira trazer nome e quantidade de filmes

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Nome do Cliente: " + cliente.nome);
            Console.WriteLine("Total de Filmes Alugados: " + quant);
            Console.WriteLine("Valor total dos filmes locados: " +valor); 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                OBRIGADO!                    ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
        }
    }
}


            public class Cliente{
                
                 public String nome;
                 public String endereco;
                 public String tel;
                 public String email;

                public Cliente(String nome, String endereco, String tel, String email){
                     
                     this.nome = nome;
                     this.endereco = endereco;
                     this.tel = tel;

                     this.email = email;

                 }
                
                
                }

                public class Locacao {

                    public String nome;

                    public String valor;

                    public Locacao ( String nome, String valor){

                        this.nome = nome;
                        this.valor = valor;


                    }
                }

            
