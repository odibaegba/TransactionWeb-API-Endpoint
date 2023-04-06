using System.ComponentModel.DataAnnotations;

namespace TransactionWebAPI.Core.DTOs
{
	public class CreateMerchantDTO
	{
		[Required(ErrorMessage = "Merchant name is required")]
		[RegularExpression(@"^[A-Za-z]+(?:\\s[A-Za-z]+)?$",
		ErrorMessage = "Please enter a valid name")]

		public string Name { get; set; } = string.Empty;

		[Required]
		public string Address { get; set; } = string.Empty;

		[Required(ErrorMessage = "Merchant Email is required")]
		[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
		 ErrorMessage = "Please enter a valid email.")]
		public string Email { get; set; } = string.Empty;

		[Required]
		[StringLength(11, ErrorMessage = "Phone number is required, 11 digit")]
		public string Phone { get; set; } = string.Empty;
	}
}
