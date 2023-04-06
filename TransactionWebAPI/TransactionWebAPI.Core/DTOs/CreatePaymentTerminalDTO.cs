using System.ComponentModel.DataAnnotations;
using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Core.DTOs
{
	public class CreatePaymentTerminalDTO
	{
		[Required]
		public Terminal TerminalType { get; set; }

		[Required]
		public string Location { get; set; } = string.Empty;
	}
}
