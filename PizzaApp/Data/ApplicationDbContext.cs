using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;


namespace PizzaApp.Data
{
public class ApplicationDbContext : DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


public DbSet<Pizza> Pizzas => Set<Pizza>();
}
}