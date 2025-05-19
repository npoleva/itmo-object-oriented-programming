namespace Domain.Models.Accounts;

public class Account
{
    public Account(int accountId, string pin)
    {
        AccountId = accountId;
        Pin = pin;
    }

    public int AccountId { get; init; }
    public double Balance { get; set; }
    public string Pin { get; set; }
}