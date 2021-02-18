
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1-inserir - ok
                2-remover - ok
                3-imprimir - ok
                4-retornar quantidade de livros - ok
                5-Buscar livros pelo nome
                0-sair - ok

                -contar quantos livros tem (retornar a quantidade de livros da pilha)
                -Busca pelo titulo do livro 
            */

            int opMenu;

            Pilha_Dinamica_Livro minha_pilha = new Pilha_Dinamica_Livro { Topo = null };

            do
            {
                opMenu = Menu();
                switch (opMenu)
	            {
		            case 1:
                        InserirLivro(minha_pilha);
                        break;
                    case 2:
                        RemoverLivro(minha_pilha);
                        break;
                    case 3:
                        ImprimirPilha(minha_pilha);
                        break;
                    case 4:
                        QtdLivros(minha_pilha);
                        break;
                    case 5:
                        BuscarLivroPorTitulo(minha_pilha);
                        break;
	            }
            }while(opMenu != 0);



          /*
           * minha_pilha.Imprimir();
            Console.ReadKey();


            minha_pilha.Imprimir();

            minha_pilha.pop();
            minha_pilha.Imprimir();
            minha_pilha.pop();
            minha_pilha.Imprimir();
            minha_pilha.pop();*/

            Console.ReadKey();
        }

        static int Menu()
        {
            int op;

            Console.WriteLine(">>>>>>>>>>>   Menu   <<<<<<<<<<<\n");
            Console.WriteLine("1 - Inserir livro");
            Console.WriteLine("2 - Remover livro");
            Console.WriteLine("3 - Imprimir pilha de livros");
            Console.WriteLine("4 - Quantidade de elementos na pilha");
            Console.WriteLine("5 - Buscar livro na pilha por título");
            Console.WriteLine("0 - Sair");

            if(int.TryParse(Console.ReadLine(), out op))
                return op;

            Console.WriteLine("Você nao digitou um numero.");
            return -1;
        }

        static void InserirLivro(Pilha_Dinamica_Livro minha_pilha)
        {
            string t = Console.ReadLine();
            string a = Console.ReadLine();
            int i = int.Parse(Console.ReadLine());
            
            minha_pilha.Push(new Livro { Titulo = t, Autor = a, Isbn = i });
        }

        static void RemoverLivro(Pilha_Dinamica_Livro minha_pilha)
        {
            minha_pilha.Pop();
        }

        static void ImprimirPilha(Pilha_Dinamica_Livro minha_pilha)
        {
            minha_pilha.Imprimir();
        }

        static void QtdLivros(Pilha_Dinamica_Livro minha_pilha)
        {
            Console.WriteLine("Existem {0} livros empilhados!!!", minha_pilha.QtdElementos());
        }

        static void BuscarLivroPorTitulo(Pilha_Dinamica_Livro minha_pilha)
        {
            minha_pilha.FindByTitle();
        }
    }
}
