using Microsoft.EntityFrameworkCore;
using PizzaApp.Data;
using PizzaApp.Models;


namespace PizzaApp.Services
{
public class PizzaService : IPizzaService
{
private readonly ApplicationDbContext _db;
public PizzaService(ApplicationDbContext db) => _db = db;


public async Task<List<Pizza>> GetAllAsync() => await _db.Pizzas.ToListAsync();


public async Task<Pizza?> GetByIdAsync(int id) => await _db.Pizzas.FindAsync(id);


public async Task<Pizza> AddAsync(Pizza pizza)
{
_db.Pizzas.Add(pizza);
await _db.SaveChangesAsync();
return pizza;
}


public async Task<Pizza?> UpdateAsync(Pizza pizza)
{
var exists = await _db.Pizzas.FindAsync(pizza.Id);
if (exists == null) return null;
exists.Name = pizza.Name;
exists.Description = pizza.Description;
exists.Price = pizza.Price;
exists.IsVegetarian = pizza.IsVegetarian;
await _db.SaveChangesAsync();
return exists;
}


public async Task<bool> DeleteAsync(int id)
{
var p = await _db.Pizzas.FindAsync(id);
if (p == null) return false;
_db.Pizzas.Remove(p);
await _db.SaveChangesAsync();
return true;
}
}
}