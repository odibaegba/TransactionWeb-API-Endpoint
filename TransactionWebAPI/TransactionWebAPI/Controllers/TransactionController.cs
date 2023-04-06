using Microsoft.AspNetCore.Mvc;
using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Interfaces;

namespace TransactionWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionController : ControllerBase
	{
		private readonly ITransactionService _service;
		public TransactionController(ITransactionService service)
		{
			_service = service;
		}

		[HttpGet("get-all-transactions")]
		public async Task<IActionResult> GetAllTransactionAsync()
		{
			var allTransactions = await _service.GetAllTransactionAsync();
			return Ok(allTransactions);
		}

		[HttpPost("get-transaction/{id}")]
		public async Task<IActionResult> GetTransactionByIdAsync(Guid id)
		{
			var transaction = await _service.GetTransactionByIdAsync(id);
			return Ok(transaction);
		}

		[HttpPost("add-transaction")]
		public async Task<IActionResult> AddTransactionAsync([FromBody] CreateTransactionDTO transaction)
		{
			await _service.AddTransactionAsync(transaction);
			return Ok(transaction);
		}
	}
}
