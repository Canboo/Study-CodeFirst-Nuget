using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api;

public partial class ApiContext : DbContext
{
    public DbSet<City> Cities { get; set; }
}