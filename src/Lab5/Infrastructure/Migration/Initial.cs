using FluentMigrator;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Migration;

[Migration(1, "Initial")]
public class Initial : FluentMigrator.Migration
{
    public static void ConfigureFluentMigrator(IServiceCollection services)
    {
        services.AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
                .AddPostgres()
                .WithGlobalConnectionString("Server=localhost;Port=6432;Database=postgres;User Id=postgres;Password=postgres;")
                .ScanIn(typeof(Initial).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole());
    }

    public override void Up()
    {
        Create.Table("Accounts")
            .WithColumn("user_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("user_name").AsString().NotNullable()
            .WithColumn("user_role").AsString().NotNullable();

        Create.Table("Users")
            .WithColumn("user_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("account_id").AsString().NotNullable();

        Create.Table("Administrators")
            .WithColumn("system_password").AsInt32().PrimaryKey().Identity();
    }

    public override void Down()
    {
        Delete.Table("Accounts");
        Delete.Table("Users");
    }
}