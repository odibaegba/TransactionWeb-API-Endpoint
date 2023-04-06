using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface ITransactionRepository
	{
		Task<IEnumerable<Transaction>> GetAllTransactionAsync();
		Task<Transaction> GetTransactionByIdAsync(Guid id);
		Task AddTransactionAsync(Transaction data);
	}
}
