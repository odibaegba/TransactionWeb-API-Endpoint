﻿namespace TransactionWebAPI.Core.DTOs
{
	public class MerchantDTO
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
	}
}
