using System.Globalization;
using Domain.Abstraction.Repositories;
using Npgsql;

namespace Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
    {
        private readonly string _connectionString;

        public TransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string? GetAccountId()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT account_id FROM Transactions", connection);
            object? result = command.ExecuteScalar();

            connection.Close();

            return result?.ToString();
        }

        public string? GetTransactionId()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT transaction_id FROM Transactions", connection);
            object? result = command.ExecuteScalar();

            connection.Close();

            return result?.ToString();
        }

        public string? GetAccountId(string transactionId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT account_id FROM Transactions WHERE transaction_id = @transactionId", connection);
            command.Parameters.AddWithValue("@transactionId", transactionId);

            object? result = command.ExecuteScalar();

            connection.Close();

            return result?.ToString();
        }

        public double GetAmount(string transactionId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT amount FROM Transactions WHERE transaction_id = @transactionId", connection);
            command.Parameters.AddWithValue("@transactionId", transactionId);

            object? result = command.ExecuteScalar();

            connection.Close();

            return result == null ? 0.0 : Convert.ToDouble(result, CultureInfo.InvariantCulture);
        }

        public string? GetPin(string accountId)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using var command = new NpgsqlCommand("SELECT pin FROM Transactions WHERE account_id = @accountId", connection);
            command.Parameters.AddWithValue("@accountId", accountId);

            object? result = command.ExecuteScalar();

            connection.Close();

            return result?.ToString();
        }
    }