using TransactionWebAPI.Core.DTOs;

namespace TransactionWebAPI.Core.Interfaces
{
	public interface IPaymentTerminalService
	{
		Task<IEnumerable<PaymentTerminalDTO>> GetAllPaymentTerminalAsync();
		Task<PaymentTerminalDTO> GetPaymentTerminalByIdAsync(Guid id);
		Task AddPaymentTerminalAsync(CreatePaymentTerminalDTO data);
	}
}
