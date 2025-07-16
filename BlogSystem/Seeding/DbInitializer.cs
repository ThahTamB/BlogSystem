using BlogSystem.Data;
using BlogSystem.Models;

namespace BlogSystem.Seeding
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {

            
            if (!context.Roles.Any())
            {
                var adminRole = new Role { Name = "Admin", Id = 1 };
                var userRole = new Role { Name = "User" };
               

                context.Roles.AddRange(adminRole, userRole);
                context.SaveChanges();

                var admin = new User
                {
                    Username = "admin",
                    Email = "admin@blog.com",
                    DisplayName = "Jackson",
                    PasswordHash = "$2a$11$gS7FgEZuDqB8PUuMBxVZ3ucROkNB8pHglkkF5YuRSuJrHe7q9ZDJi",
                    RoleId = adminRole.Id,
                    IsActive = true,
                    JoinedAt = DateTime.Now
                };

                context.Users.Add(admin);
                context.SaveChanges();
            }
        }
    }
}
