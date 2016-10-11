namespace Demo.Migrations
{
	using Models;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Demo.Models.DemoContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(Demo.Models.DemoContext context)
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
			context.People.AddOrUpdate(
				new Person
				{
					Id = 1,
					FirstName = "John",
					LastName = "Testerson",
					Age = 32,
					PhoneNumber = "1-555-695-8752",
					Email = "Testerson@theFacebook.com",
					AddressOne = "1234 Madison Road",
					City = "Madison",
					State = "Wisconsin",
					Zip = "55555",
					Country = "USA"
				}
			);
		}
	}
}