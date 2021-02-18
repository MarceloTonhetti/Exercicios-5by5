
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
            Console.Write("Informe o Titulo: ");
            string t = Console.ReadLine();
            Console.Write("Informe o Autor: ");
            string a = Console.ReadLine();
            Console.Write("Informe o Isbn: ");
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
