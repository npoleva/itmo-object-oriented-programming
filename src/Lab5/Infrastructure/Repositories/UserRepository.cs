using System.Globalization;
using Domain.Abstraction.Repositories;
using Domain.Models.Accounts;
using Npgsql;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string GetUserId(string userName)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("SELECT user_id FROM Users WHERE user_name = @userName", connection);
        command.Parameters.AddWithValue("@userName", userName);

        object? result = command.ExecuteScalar();
        return result?.ToString() ?? string.Empty;
    }

    public Account? GetAccount(int userId, string pincode)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("SELECT * FROM Accounts WHERE user_id = @userId", connection);
        command.Parameters.AddWithValue("@userId", userId);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            var account = new Account(userId, pincode)
            {
                AccountId = Convert.ToInt32(reader["user_id"], CultureInfo.InvariantCulture),
            };

            return account;
        }

        return null;
    }
}