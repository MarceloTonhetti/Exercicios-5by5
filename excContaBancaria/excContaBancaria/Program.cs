using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excContaBancaria
{
	class Program
	{
		static void Main(string[] args)
		{
			int op;

			do
			{
				op = Menu();

				switch (op)
				{
					case 1:
						break;
				}
			} while (op != 0);
		}

		static int Menu()
		{
			int op;

			Console.WriteLine("1 - Cadastrar dados do Cliente e da Conta.");
			Console.WriteLine("2 - Realizar Depositósito.");
			Console.WriteLine("3 - Realizar Saque");
			Console.WriteLine("4 - Realzar Transferência");
			Console.WriteLine("5 - Imprimir Saldo");
			Console.WriteLine("0 - Sair do Sistema");

			Console.Write("Escolha a opção do menu: ");
			op = int.Parse(Console.ReadLine());

			return op;
		}


	}
}
