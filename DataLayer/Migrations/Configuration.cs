namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.MyContext context)
        {
            if (!context.Users.Any())
            {
                User usr = new User()
                {
                    UserName = "Milad",
                    Password = "123456789",
                    Date = DateTime.Now,
                    Name = "میلاد اسدی",
                    Phone = "09117449564"
                };
                context.Users.Add(usr);
                context.SaveChanges();
            }
        }
    }
}
