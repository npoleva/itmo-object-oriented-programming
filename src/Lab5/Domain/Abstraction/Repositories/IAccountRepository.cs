namespace Domain.Abstraction.Repositories;

public interface IAccountRepository
{
    public string? GetAccountId();
    public decimal GetBalance(int accountId);
    public string? GetPin(int accountId);
    public void TopUpAccountBalance(int accountId, decimal amount);
    public void WithDrawBalance(int accountId, decimal amount);
}