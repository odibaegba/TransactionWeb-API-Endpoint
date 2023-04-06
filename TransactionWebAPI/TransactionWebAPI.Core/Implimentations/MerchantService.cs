using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Exceptions;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Implimentations
{
	public class MerchantService : IMerchantService
	{
		private readonly IMerchantRepository _repository;

		public MerchantService(IMerchantRepository repository)
		{
			_repository = repository;
		}

		public async Task AddMerchantAsync(CreateMerchantDTO data)
		{
			var merchant = new Merchant()
			{
				Name = data.Name,
				Address = data.Address,
				Email = data.Email,
				Phone = data.Phone,

			};
			await _repository.AddMerchantAsync(merchant);
		}

		public async Task<IEnumerable<MerchantDTO>> GetAllMerchantAsync()
		{
			var result = await _repository.GetAllMerchantAsync();
			var merchants = result.Select(r => new MerchantDTO
			{
				Id = r.Id,
				Name = r.Name,
				Address = r.Address,
				Email = r.Email,
				Phone = r.Phone,
			}).ToList();
			return merchants;
		}

		public async Task<MerchantDTO> GetMerchantByIdAsync(Guid id)
		{
			var result = await _repository.GetMerchantByIdAsync(id);
			if (result == null)
			{
				throw new NotFoundException();
			}
			var merchant = new MerchantDTO
			{
				Id = result.Id,
				Name = result.Name,
				Address = result.Address,
				Email = result.Email,
				Phone = result.Phone,
			};
			return merchant;
		}
	}
}
