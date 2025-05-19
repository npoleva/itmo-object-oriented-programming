namespace Domain.Abstraction.Repositories;

public interface ITransactionRepository
{
    public string? GetTransactionId();
    public string? GetAccountId(string transactionId);
    public double GetAmount(string transactionId);
}