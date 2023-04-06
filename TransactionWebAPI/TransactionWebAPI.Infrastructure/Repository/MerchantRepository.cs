using Microsoft.EntityFrameworkCore;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Infrastructure.Repository
{
	public class MerchantRepository : IMerchantRepository
	{
		private readonly AppDbContext _context;
		public MerchantRepository(AppDbContext context)
		{
			_context = context;
		}
		public async Task AddMerchantAsync(Merchant data)
		{
			await _context.Merchants.AddAsync(data);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<Merchant>> GetAllMerchantAsync()
		{
			var result = await _context.Merchants.ToListAsync();
			return result;
		}

		public async Task<Merchant> GetMerchantByIdAsync(Guid id)
		{
			var result = await _context.Merchants.FirstOrDefaultAsync(n => n.Id == id);
			return result;

		}
	}
}
