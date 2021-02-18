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
			Customer baseCustomer = new Customer
			{
				Cpf = "11111",
				Name = "Marcelo",
				address = new Address { PublicArea = "Rua Gilberto primeiro", Number = "222A", Neighborhood = "Bairro da turma", ZipCode = 1234567 },
				account = new Account { Agency = 0009, Number = 919293, Balance = 10000 }
			};

			Customer customer = new Customer { address = new Address(), account = new Account() };

			int op;

			do
			{
				op = Menu();

				switch (op)
				{
					case 1:
						RegisterCustomerAndAccount(customer);
						break;
					case 2:
						MakeDeposit(customer);
						break;
					case 3:
						MakeWithdraw(customer);
						break;
					case 5:
						PrintBalance(customer);
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

		static void RegisterCustomerAndAccount(Customer customer)
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


			customer.Cpf = cpf;
			customer.Name = name;
			customer.address.PublicArea = publicArea;
			customer.address.Number = number;
			customer.address.Neighborhood = neighborhood;
			customer.address.ZipCode = zipCode;
			customer.account.Agency = agency;
			customer.account.Number = accNumber;

			Console.Clear();
			Console.WriteLine("Cliente e conta cadastrados com sucesso!!!\n");

			return;
		}

		static bool VerifyCustomer(Customer customer)
		{
			if (customer.Cpf != null)
				return true;
			else
			{
				Console.Clear();
				Console.WriteLine("Não existe cliente cadastrado!!!!");
			}
			return false;
		}

		static void MakeDeposit(Customer customer)
		{
			if (VerifyCustomer(customer))
			{
				Console.WriteLine("Qual o valor você deseja depositar?");
				long value = long.Parse(Console.ReadLine());

				customer.account.Balance += value;

				Console.Clear();
				Console.WriteLine("Depósito realizado com sucesso!!!!");
			}

			return;
		}

		static void MakeWithdraw(Customer customer) //Realizar saque
		{
			if (VerifyCustomer(customer))
			{
				Console.WriteLine("Qual valor você deseja Sacar?");
				long value = long.Parse(Console.ReadLine());
				long aux = customer.account.Balance - value;

				if (customer.account.Balance < value || customer.account.Balance == 0 || aux < 0)
					Console.WriteLine("Saldo insuficiente!!!");
				else
				{
					customer.account.Balance -= value;
					Console.Clear();
					Console.WriteLine("Saque realizado com sucesso!!!!");
				}
			}

			return;
		}

		static void PrintBalance(Customer customer)
		{
			if (VerifyCustomer(customer))
			{
				Console.Clear();
				Console.WriteLine("Saldo da conta: {0}\n\n", customer.account.Balance.ToString());		
			}

			return;
		}
	}
}
