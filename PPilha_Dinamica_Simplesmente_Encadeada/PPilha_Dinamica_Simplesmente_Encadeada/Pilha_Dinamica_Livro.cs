using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Dinamica_Simplesmente_Encadeada
{
    class Pilha_Dinamica_Livro
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)
        {
            //if (vazia()) //Verifica se a pilha está vazia
            //{
            //    Topo = aux;
            //}
            //else
            //{
                aux.Anterior = Topo;
                Topo = aux;
            //}
            Console.WriteLine("Elemento inserido com sucesso!");
            return;
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;
            return false;
        }

        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Pilha Vazia!");
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Remover! Pilha Vazia!");
            }
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Elemento Removido!");
            }
        }

        public int QtdElementos()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível contar! Pilha Vazia!");
                return 0;
            }
            else
            {
                Livro aux = Topo;
                int count=1;

                while (aux.Anterior != null)
                {
                    count++;
                    aux = aux.Anterior;
                }

                return count;
            }
        }

        public void FindByTitle()
        {
            if (Vazia())
                Console.WriteLine("Impossível realizar busca! Pilha Vazia!");
            else
            {
                Livro aux = Topo;
                int count=1;
                string nomeLivro;

                Console.Write("Informe o nome do livro que deseja procurar: ");
                nomeLivro = Console.ReadLine();

                do
                {
                    if(aux.Titulo == nomeLivro)
                    {
                        Console.WriteLine("Achei o livro que voce buscou: ");
                        Console.WriteLine(aux.ToString());
                        return;
                    }
                    else
                        aux = aux.Anterior;
                }while (aux.Anterior != null);

                Console.WriteLine("Não foi encontrado nenhum livro com esse titulo!!!");
                return;
            }
        }

    }
}
