using System;
using NameLocacao;
using NameFilme;
using NameClienteLoc;

namespace Locadora
{
    public interface IPrincipal
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }

    public class Principal : IPrincipal
    {

        public static void Main(String[] args)
        {
            //Entrada IdCliente no switch


            Console.WriteLine("LOCADORA");

            // Lista com 5 Clientes
            ClienteLoc cliente1 = new ClienteLoc(1, "aaaaaa", "15/15/15","456.456.456.15" 3);
            ClienteLoc cliente2 = new ClienteLoc(2, "bbbbbb", "15/15/15","456.456.456.15", 2);
            ClienteLoc cliente3 = new ClienteLoc(3, "", 3);
            ClienteLoc cliente4 = new ClienteLoc(4, "", 2);
            ClienteLoc cliente5 = new ClienteLoc(5, "", 3);

            // Lista com 10 Filmes
            Filme filme1 = new Filme(1, ");
            Filme filme2 = new Filme(2, ");
            Filme filme3 = new Filme(3, ");
            Filme filme4 = new Filme(4, ");
            Filme filme5 = new Filme(5, ");
   

            // IdCliente / Menu
            int idCliente = 0;
            Locacao locacao;
            do
            {
                Console.WriteLine("\nInforme o ID do CLIENTE: ");
                String entrada = Console.ReadLine();
                idCliente = Convert.ToInt32(entrada);
                switch (idCliente)
                {
                    case 1:
                        cliente1.mostrarCliente();
                        locacao = new Locacao(01, cliente1);
                        filme1.mostrarFilme();
                        filme4.mostrarFilme();
                        filme5.mostrarFilme();
                        locacao.AdicFilme(filme1);
                        locacao.AdicFilme(filme4);
                        locacao.AdicFilme(filme5);
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 2:
                        cliente2.mostrarCliente();
                        locacao = new Locacao(02, cliente2);
                        filme2.mostrarFilme();
                        filme3.mostrarFilme();
                        locacao.AdicFilme(filme2);
                        locacao.AdicFilme(filme3);
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 3:
                        cliente3.mostrarCliente();
                        locacao = new Locacao(03, cliente3);
                        filme2.mostrarFilme();
                        filme3.mostrarFilme();
                        filme4.mostrarFilme();
                        filme5.mostrarFilme();
                        locacao.AdicFilme(filme5);
                        locacao.AdicFilme(filme2);
                        locacao.AdicFilme(filme3);
                        locacao.AdicFilme(filme4);
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 4:
                        cliente4.mostrarCliente();
                        locacao = new Locacao(04, cliente1);
                        filme4.mostrarFilme();
                        filme1.mostrarFilme();
                        locacao.AdicFilme(filme4);
                        locacao.AdicFilme(filme1);
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                    case 5:
                        cliente5.mostrarCliente();
                        locacao = new Locacao(05, cliente1);
                        filme1.mostrarFilme();
                        filme5.mostrarFilme();
                        filme2.mostrarFilme();
                        locacao.AdicFilme(filme1);
                        locacao.AdicFilme(filme5);
                        locacao.AdicFilme(filme2);
                        Console.WriteLine("-> PREÇO TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> DATA DE DEVOLUÇÃO: " + locacao.calculoData());
                        Console.WriteLine("-> QTDE TOTAL DE FILMES LOCADOS: " + locacao.QtdeFilmesLoc());
                        break;
                }
            } while (idCliente <= 5);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}