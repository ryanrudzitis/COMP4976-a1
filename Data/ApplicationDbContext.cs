using Assignment1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data;

public class ApplicationDbContext : IdentityDbContext<XUser, XRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // for seeding
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    // builder.Entity<ContactList>().Property(m => m.TeamName).IsRequired();

    // builder.Entity<Team>().Property(p => p.TeamName).HasMaxLength(30);

    builder.Entity<ContactList>().ToTable("Contact List");
        // Use seed method here
        builder.SeedUsersRoles();
        builder.Seed();
    }
}
