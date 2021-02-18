using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excContaBancaria
{
	class Customer
	{
		public string Cpf { get; set; }
		public string Name { get; set; }
		public Address address { get; set; }

		public Account account { get; set; }

	}
}
