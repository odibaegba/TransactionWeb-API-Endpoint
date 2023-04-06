using TransactionWebAPI.Core.DTOs;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface ITransactionService
	{
		Task<IEnumerable<TransactionDTO>> GetAllTransactionAsync();
		Task<TransactionDTO> GetTransactionByIdAsync(Guid id);
		Task AddTransactionAsync(CreateTransactionDTO data);
	}
}
