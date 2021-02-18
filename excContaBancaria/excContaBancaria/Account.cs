namespace excContaBancaria
{
	public class Account
	{
		public int Agency { get; set; } //Agencia
		public int Number { get; set; } //Numero da conta
		public float Balance { get; set; } //Saldo

		public Account() 
		{
			Balance = 0;
		}
	}
}