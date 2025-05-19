namespace Domain.Abstraction.Repositories;

public interface IUserRepository
{
    public string GetUserId(string userName);
}