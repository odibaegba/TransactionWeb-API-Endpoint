using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TransactionWebAPI.Domain.Enums;
using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Infrastructure
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();



				if (!context.Transactions.Any())
				{
					context.Transactions.AddRange(new Transaction()
					{
						Amount = 100,
						CardType = CardType.Verve,
						PaymentTerminal = new PaymentTerminal()
						{
							TerminalType = Terminal.POS,
							Location = "Lagos",
							Merchant = new Merchant()
							{
								Name = "Max Exchange",
								Address = "Asajon way",
								Email = "MaxExchange@gmail.com",
								Phone = "09032528236"
							}
						},

					},
					new Transaction()
					{
						Amount = 500,
						CardType = CardType.MasterCard,
						PaymentTerminal = new PaymentTerminal()
						{
							TerminalType = Terminal.ATM,
							Location = "Abuja",
							Merchant = new Merchant()
							{
								Name = "Delux Exchange",
								Address = "Wuse zone 6",
								Email = "DeluxExchange@gmail.com",
								Phone = "08180510238"

							}
						},
					});
					context.SaveChanges();
				}
			}
		}
	}
}
