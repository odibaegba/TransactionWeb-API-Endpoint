using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Domain.Models
{
	public class Transaction
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public decimal Amount { get; set; }
		public CardType CardType { get; set; }
		public Guid RRN { get; set; } = Guid.NewGuid();

		public Guid PaymentTerminalId { get; set; }
		public PaymentTerminal PaymentTerminal { get; set; }

		public Transaction()
		{
			PaymentTerminal = new PaymentTerminal();
		}
	}
}
