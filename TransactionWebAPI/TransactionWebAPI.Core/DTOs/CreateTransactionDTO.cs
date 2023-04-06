using System.ComponentModel.DataAnnotations;
using TransactionWebAPI.Domain.Enums;

namespace TransactionWebAPI.Core.DTOs
{
	public class CreateTransactionDTO
	{
		[Required]
		public decimal Amount { get; set; }

		[Required]
		public CardType CardType { get; set; }
	}
}
