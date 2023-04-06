using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Exceptions;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Implimentations
{
	public class PaymentTerminalService : IPaymentTerminalService
	{
		private readonly IPaymentTerminalRepository _repository;
		public PaymentTerminalService(IPaymentTerminalRepository repository)
		{
			_repository = repository;
		}
		public async Task AddPaymentTerminalAsync(CreatePaymentTerminalDTO data)
		{

			var terminal = new PaymentTerminal()
			{
				TerminalType = data.TerminalType,
				Location = data.Location,
			};
			await _repository.AddPaymentTerminalAsync(terminal);

		}

		public async Task<IEnumerable<PaymentTerminalDTO>> GetAllPaymentTerminalAsync()
		{
			var result = await _repository.GetAllPaymentTerminalAsync();
			var terminal = result.Select(r => new PaymentTerminalDTO()
			{
				Id = r.Id,
				TerminalType = r.TerminalType,
				Location = r.Location,
				MerchantId = r.MerchantId,
			}).ToList();

			return terminal;
		}

		public async Task<PaymentTerminalDTO> GetPaymentTerminalByIdAsync(Guid id)
		{
			var result = await _repository.GetPaymentTerminalByIdAsync(id);
			if (result == null)
			{
				throw new NotFoundException();
			}
			var terminal = new PaymentTerminalDTO()
			{
				Id = result.Id,
				TerminalType = result.TerminalType,
				Location = result.Location,
				MerchantId = result.MerchantId,
			};
			return terminal;

		}
	}
}
