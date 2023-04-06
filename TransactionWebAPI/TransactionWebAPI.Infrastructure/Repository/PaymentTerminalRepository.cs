using Microsoft.EntityFrameworkCore;
using TransactionWebAPI.Core.Interfaces;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Infrastructure.Repository
{
	public class PaymentTerminalRepository : IPaymentTerminalRepository
	{
		private readonly AppDbContext _context;
		public PaymentTerminalRepository(AppDbContext context)
		{
			_context = context;
		}
		public async Task AddPaymentTerminalAsync(PaymentTerminal data)
		{

			await _context.PaymentTerminals.AddAsync(data);
			await _context.SaveChangesAsync();
		}

		public async Task<IEnumerable<PaymentTerminal>> GetAllPaymentTerminalAsync()
		{
			var result = await _context.PaymentTerminals.ToListAsync();
			return result;
		}

		public async Task<PaymentTerminal> GetPaymentTerminalByIdAsync(Guid id)
		{
			var result = await _context.PaymentTerminals.FirstOrDefaultAsync(n => n.Id == id);
			return result;
		}
	}
}
