using PizzaApp.Models;


namespace PizzaApp.Services
{
public interface IPizzaService
{
Task<List<Pizza>> GetAllAsync();
Task<Pizza?> GetByIdAsync(int id);
Task<Pizza> AddAsync(Pizza pizza);
Task<Pizza?> UpdateAsync(Pizza pizza);
Task<bool> DeleteAsync(int id);
}
}