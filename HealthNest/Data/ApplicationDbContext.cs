using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthNest.Models;

namespace HealthNest.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<CheckIn> CheckIns { get; set; }
    public DbSet<Goal> Goals { get; set; }

}
