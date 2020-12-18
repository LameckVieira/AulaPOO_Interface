using System;
using Classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATENÇÂO: A cor azul indica que voçê alterou o carrinho!");
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo  = 123;
            p1.Nome    = "Playstatiion 5";
            p1.Preco   = 10000;

            Produto p2 = new Produto();
            p2.Codigo  = 124;
            p2.Nome    = "Xbox Series X";
            p2.Preco   = 5000;

            Produto p3 = new Produto();
            p3.Codigo  = 123;
            p3.Nome    = "Nitendo Switch";
            p3.Preco   = 4000;


            carrinho.Cadastrar(p1);
            carrinho.Listar();
            //carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Blue;

            carrinho.Alterar(p1.Codigo , p3);
            carrinho.Listar();

            Console.ResetColor();


        }
    }
}
