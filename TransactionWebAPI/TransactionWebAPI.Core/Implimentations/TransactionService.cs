using TransactionWebAPI.Core.DTOs;
using TransactionWebAPI.Core.Exceptions;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Implimentations
{
	public class TransactionService : ITransactionService
	{
		private readonly ITransactionRepository _repository;
		public TransactionService(ITransactionRepository repository)
		{
			_repository = repository;
		}

		public async Task AddTransactionAsync(CreateTransactionDTO data)
		{
			var transaction = new Transaction()
			{
				Amount = data.Amount,
				CardType = data.CardType,
			};
			await _repository.AddTransactionAsync(transaction);
		}

		public async Task<IEnumerable<TransactionDTO>> GetAllTransactionAsync()
		{
			var result = await _repository.GetAllTransactionAsync();
			var transactions = result.Select(r => new TransactionDTO()
			{
				Id = r.Id,
				Amount = r.Amount,
				CardType = r.CardType,
				RRN = r.RRN,
				PaymentTerminalId = r.PaymentTerminalId,
			}).ToList();
			return transactions;
		}

		public async Task<TransactionDTO> GetTransactionByIdAsync(Guid id)
		{
			var result = await _repository.GetTransactionByIdAsync(id);
			if (result == null)
			{
				throw new NotFoundException();
			}
			var transaction = new TransactionDTO()
			{
				Id = result.Id,
				Amount = result.Amount,
				CardType = result.CardType,
				RRN = result.RRN,
				PaymentTerminalId = result.PaymentTerminalId,
			};
			return transaction;
		}


	}
}
