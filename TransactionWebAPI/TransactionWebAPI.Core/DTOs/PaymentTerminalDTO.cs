using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Core.DTOs
{
	public class PaymentTerminalDTO
	{
		public Guid Id { get; set; }
		public Terminal TerminalType { get; set; }
		public string Location { get; set; } = string.Empty;
		public Guid MerchantId { get; set; }
	}
}
