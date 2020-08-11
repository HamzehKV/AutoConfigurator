using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations;
using System.Collections.Generic;

namespace AutoConfiguratorApp.Migrations
{
    // We now want to ensure that when we update our database via code first migrations  our CreatedDate and ModifiedDate properties gets a default value of NOW() utc Datetime. 
    // To that end, I defined a custom Migration class specific to PostgreSql to add the default values when performing AddColumn and CreateTable operations.
    
    class CustomNpgsqlMigrationsSqlGenerator : NpgsqlMigrationsSqlGenerator
    {
        public CustomNpgsqlMigrationsSqlGenerator(
            MigrationsSqlGeneratorDependencies dependencies,
            IMigrationsAnnotationProvider migrationsAnnotations, 
            INpgsqlOptions npgsqlOptions)
            : base(dependencies, migrationsAnnotations, npgsqlOptions)
        {
        }

        protected override void Generate(
            MigrationOperation operation,
            IModel model,
            MigrationCommandListBuilder builder)
        {
            if (operation is AddColumnOperation addColumnOperation)
            {
                SetCreatedUtcColumn(addColumnOperation);
            }
            else if (operation is CreateTableOperation createTableOperation)
            {
                SetCreatedUtcColumn(createTableOperation.Columns);
            }
            base.Generate(operation, model, builder);
        }

        private static void SetCreatedUtcColumn(IEnumerable<AddColumnOperation> columns)
        {
            foreach (var columnModel in columns)
            {
                SetCreatedUtcColumn(columnModel);
            }
        }

        private static void SetCreatedUtcColumn(AddColumnOperation column)
        {
            if (column.Name == "CreatedDate" || column.Name == "ModifiedDate")
            {
                column.DefaultValueSql = "(now() at time zone 'utc')";
            }
        }
    }
}
