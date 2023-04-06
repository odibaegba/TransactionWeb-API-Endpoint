using Microsoft.AspNetCore.Mvc;
using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Interfaces;

namespace TransactionWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MerchantController : ControllerBase
	{
		private readonly IMerchantService _service;
		public MerchantController(IMerchantService service)
		{
			_service = service;
		}

		[HttpGet("get-all-merchant")]
		public async Task<IActionResult> GetAllMerchantAsync()
		{
			var allMerchant = await _service.GetAllMerchantAsync();
			return Ok(allMerchant);
		}

		[HttpPost("get-merchant/{id}")]
		public async Task<IActionResult> GetMerchantByIdAsync(Guid id)
		{
			var merchant = await _service.GetMerchantByIdAsync(id);
			if (merchant == null)
			{
				return NotFound();
			}
			return Ok(merchant);
		}

		[HttpPost("add-merchant")]
		public async Task<IActionResult> AddMerchantAsync([FromBody] CreateMerchantDTO merchant)
		{
			await _service.AddMerchantAsync(merchant);
			return Ok();
		}
	}
}
