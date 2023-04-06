using Microsoft.EntityFrameworkCore;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Infrastructure.Repository
{
	public class TransactionRepository : ITransactionRepository
	{
		private readonly AppDbContext _context;
		public TransactionRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task AddTransactionAsync(Transaction data)
		{

			await _context.Transactions.AddRangeAsync(data);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Transaction>> GetAllTransactionAsync()
		{
			var response = await _context.Transactions.ToListAsync();
			return response;
		}

		public async Task<Transaction> GetTransactionByIdAsync(Guid id)
		{
			var response = await _context.Transactions.FirstOrDefaultAsync(n => n.Id == id);
			return response;
		}
	}
}
