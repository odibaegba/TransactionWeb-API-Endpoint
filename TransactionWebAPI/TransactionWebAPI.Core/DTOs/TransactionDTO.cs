using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Core.DTOs
{
	public class TransactionDTO
	{
		public Guid Id { get; set; }
		public decimal Amount { get; set; }
		public CardType CardType { get; set; }

		public Guid RRN { get; set; }

		public Guid PaymentTerminalId { get; set; }
	}
}
