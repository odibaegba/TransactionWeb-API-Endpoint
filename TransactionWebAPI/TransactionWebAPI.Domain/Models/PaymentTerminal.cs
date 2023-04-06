using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Domain.Models
{
	public class PaymentTerminal
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Terminal TerminalType { get; set; }
		public string Location { get; set; } = string.Empty;

		public Guid MerchantId { get; set; }
		public Merchant Merchant { get; set; }

		public ICollection<Transaction> TransactionList { get; set; }

		public PaymentTerminal()
		{
			TransactionList = new List<Transaction>();
			Merchant = new Merchant();
		}
	}
}
