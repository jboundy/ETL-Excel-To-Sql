using System.Data.Entity.Migrations;
using ETL.ExcelToSql.DAL.DataModel;
using ETL.ExcelToSql.DAL.Models;

namespace ETL.ExcelToSql.DAL.Migrations
{
    internal class Configuration : DbMigrationsConfiguration<DynamicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DynamicContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}