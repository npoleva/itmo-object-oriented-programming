using Domain.Abstraction.Repositories;
using Npgsql;

namespace Infrastructure.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly string _connectionString;

    public AdminRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string? GetAdminId()
    {
        using var connection = new NpgsqlConnection(_connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("SELECT system_password FROM Administrators", connection);
        object? result = command.ExecuteScalar();

        connection.Close();

        return result?.ToString();
    }
}