using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Insuree> Insurees { get; set; } = null!;
}