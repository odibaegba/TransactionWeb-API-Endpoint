using TransactionWebAPI.Core.DTOs;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface IMerchantService
	{
		Task<IEnumerable<MerchantDTO>> GetAllMerchantAsync();
		Task<MerchantDTO> GetMerchantByIdAsync(Guid id);
		Task AddMerchantAsync(CreateMerchantDTO data);
	}
}
