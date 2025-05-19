using System.Globalization;
using Domain.Abstraction.Repositories;
using Npgsql;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
    {
        private readonly string _connectionString;

        public AccountRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string? GetAccountId()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT user_id FROM Users LIMIT 1;", connection);
            return (string?)command.ExecuteScalar();
        }

        public decimal GetBalance(int accountId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT balance FROM Accounts WHERE user_id = @accountId;", connection);
            command.Parameters.AddWithValue("@accountId", accountId);

            object? result = command.ExecuteScalar();
            return result == null ? 0.0m : Convert.ToDecimal(result, CultureInfo.InvariantCulture);
        }

        public string? GetPin(int accountId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT pin FROM Accounts WHERE user_id = @accountId;", connection);
            command.Parameters.AddWithValue("@accountId", accountId);

            return (string?)command.ExecuteScalar();
        }

        public void AddAccount(int userId, double balance, string pin)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var command = new NpgsqlCommand())
            {
                command.Connection = connection;

                command.CommandText = "INSERT INTO Accounts (account_id, balance, pin) VALUES (@account_id, @balance, @pin)";

                var parameter = new NpgsqlParameter("@account_id", NpgsqlTypes.NpgsqlDbType.Integer);
                parameter.Value = userId;
                command.Parameters.Add(parameter);

                command.Parameters.AddWithValue("@balance", balance);
                command.Parameters.AddWithValue("@pin", pin);

                command.ExecuteNonQuery();
            }
        }

        public void TopUpAccountBalance(int accountId, decimal amount)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("UPDATE Accounts SET balance = balance + @amount WHERE account_id = @accountId;", connection);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@amount", amount);

            command.ExecuteNonQuery();
        }

        public void WithDrawBalance(int accountId, decimal amount)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("UPDATE Accounts SET balance = balance - @amount WHERE account_id = @accountId;", connection);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@amount", amount);

            command.ExecuteNonQuery();
        }
    }