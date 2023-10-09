using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedUsersRoles(this ModelBuilder builder)
        {
            var pwd = "P@$$w0rd";
            var passwordHasher = new PasswordHasher<XUser>();
            // Seed Roles
            var adminRole = new XRole()
            {
                Name = "Admin",
                CreatedDate = DateTime.Now
            };
            adminRole.NormalizedName = adminRole.Name.ToUpper();
            var financeRole = new XRole()
            {
                Name = "Finance",
                CreatedDate = DateTime.Now
            };
            financeRole.NormalizedName = financeRole.Name.ToUpper();
            List<XRole> roles = new List<XRole>() {
adminRole,
financeRole
};
            builder.Entity<XRole>().HasData(roles);
            // Seed Users
            var adminUser = new XUser
            {
                UserName = "a@a.a",
                Email = "a@a.a",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);
            var financeUser = new XUser
            {
                UserName = "f@f.f",
                Email = "f@f.f",
                EmailConfirmed = true,
            };
            financeUser.NormalizedUserName = financeUser.UserName.ToUpper();
            financeUser.NormalizedEmail = financeUser.Email.ToUpper();
            financeUser.PasswordHash = passwordHasher.HashPassword(financeUser, pwd);
            List<XUser> users = new List<XUser>() {
adminUser,
financeUser,
};
            builder.Entity<XUser>().HasData(users);
            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(q => q.Name == "Admin").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,
                    RoleId = roles.First(q => q.Name == "Finance").Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}