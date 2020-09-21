namespace WebToDoList.Migrations
{
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using WebToDoList.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<WebToDoList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebToDoList.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }
        void AddUsers(WebToDoList.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user1@email.com" };
            var us = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            us.Create(user, "password");
        }
    }
}
