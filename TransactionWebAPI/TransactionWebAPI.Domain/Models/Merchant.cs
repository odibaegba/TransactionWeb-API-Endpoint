namespace TransactionWebAPI.Domain.Models
{
	public class Merchant
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;

		public ICollection<PaymentTerminal> PaymentTerminal { get; set; }

		public Merchant()
		{
			PaymentTerminal = new List<PaymentTerminal>();
		}
	}
}
