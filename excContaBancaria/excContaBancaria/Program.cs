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
			Customer baseCustomer = new Customer { Cpf= "11111", Name="Marcelo", 
							address= new Address { PublicArea="Rua Gilberto primeiro", Number="222A", Neighborhood="Bairro da turma", ZipCode=1234567}, 
							account= new Account { Agency= 0009, Number= 919293, Balance=10000}};

			Customer customer;

			int op;

			do
			{
				op = Menu();

				switch (op)
				{
					case 1:
						customer = RegisterCustomerAndAccount();
						break;
				}
			} while (op != 0);

			Console.ReadKey();
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

		static Customer RegisterCustomerAndAccount() 
		{
			Console.WriteLine("\nInserindo dados do cliente:");
			Console.Write("Informe o Cpf: ");
			string cpf = Console.ReadLine();
			Console.Write("Informe o Nome: ");
			string name = Console.ReadLine();
			Console.Write("Informe seu logradouro: ");
			string publicArea = Console.ReadLine();
			Console.Write("Informe o número de sua residencia");
			string number = Console.ReadLine();
			Console.Write("Informe o Bairro: ");
			string neighborhood = Console.ReadLine();
			Console.Write("Informe o CEP: ");
			int zipCode = int.Parse(Console.ReadLine());
			Console.Write("\nDados para sua conta bancária");
			Console.Write("Informe a agencia: ");
			int agency = int.Parse(Console.ReadLine());
			Console.Write("Informe o numero da sua conta: ");
			int accNumber = int.Parse(Console.ReadLine());

			Customer customer = new Customer
			{		Cpf = cpf, Name = name,
					address = new Address { PublicArea = publicArea, Number = number, Neighborhood = neighborhood, ZipCode = zipCode },
					account = new Account { Agency = agency, Number = accNumber}
			};

			Console.Clear();
			Console.WriteLine("Cliente e conta cadastrados com sucesso!!!\n");

			return customer;
		}
	}
}
