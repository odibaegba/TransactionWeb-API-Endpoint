using Microsoft.EntityFrameworkCore;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Infrastructure
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Merchant> Merchants { get; set; }
		public DbSet<PaymentTerminal> PaymentTerminals { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
	}
}
