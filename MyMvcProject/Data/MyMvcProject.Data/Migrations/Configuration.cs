namespace MyMvcProject.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<MyMvcProject.Data.MyMvcProjectDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyMvcProjectDbContext context)
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

            if (context.Books.Any())
            {
                return;
            }

            var categoryOne = new Category() { Name = "Cat 1" };

            for (int i = 0; i < 10; i++)
            {
                var book = new Book()
                {
                    Title = $"Title {i}",
                    Resume = $"Resume {i}"
                };

                categoryOne.Books.Add(book);
            }

            context.Categories.Add(categoryOne);
            context.SaveChanges();
        }
    }
}
