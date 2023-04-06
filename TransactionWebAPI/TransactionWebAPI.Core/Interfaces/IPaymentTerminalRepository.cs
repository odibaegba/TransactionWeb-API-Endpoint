using TransactionWebAPI.Domain.Models;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface IPaymentTerminalRepository
	{
		Task<IEnumerable<PaymentTerminal>> GetAllPaymentTerminalAsync();
		Task<PaymentTerminal> GetPaymentTerminalByIdAsync(Guid id);
		Task AddPaymentTerminalAsync(PaymentTerminal data);
	}
}
