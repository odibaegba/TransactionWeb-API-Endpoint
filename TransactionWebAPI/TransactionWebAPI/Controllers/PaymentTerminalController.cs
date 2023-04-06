using Microsoft.AspNetCore.Mvc;
using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Interfaces;

namespace TransactionWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentTerminalController : ControllerBase
	{
		private readonly IPaymentTerminalService _service;

		public PaymentTerminalController(IPaymentTerminalService service)
		{
			_service = service;
		}

		[HttpGet("get-all-paymentTerminal")]
		public async Task<IActionResult> GetAllPaymentTerminalAsync()
		{
			var allTerminal = await _service.GetAllPaymentTerminalAsync();
			return Ok(allTerminal);
		}

		[HttpPost("get-paymentTerminal/{id}")]
		public async Task<IActionResult> GetPaymentTerminalById(Guid id)
		{
			var terminal = await _service.GetPaymentTerminalByIdAsync(id);
			if (terminal == null)
			{
				return NotFound();
			}
			return Ok(terminal);
		}

		[HttpPost("add-merchant")]
		public async Task<IActionResult> AddPaymentTerminalAsync([FromBody] CreatePaymentTerminalDTO terminal)
		{
			await _service.AddPaymentTerminalAsync(terminal);
			return Ok();
		}
	}
}
