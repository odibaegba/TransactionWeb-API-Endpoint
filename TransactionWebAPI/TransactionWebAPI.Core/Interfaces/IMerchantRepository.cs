using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface IMerchantRepository
	{
		Task<IEnumerable<Merchant>> GetAllMerchantAsync();
		Task<Merchant> GetMerchantByIdAsync(Guid id);
		Task AddMerchantAsync(Merchant data);
	}
}
