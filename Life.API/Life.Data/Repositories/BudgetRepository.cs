using Life.Data;
using MongoDB.Driver;
using Life.API.Models.Budget;

namespace MyProject.Data.Repositories
{
    public class BudgetRepository
    {
        private readonly IMongoCollection<BudgetModel> _budgets;

        public BudgetRepository(DataContext dataContext)
        {
            _budgets = dataContext.Budgets;
        }

        public void AddBudget(BudgetModel budget)
        {
            _budgets.InsertOne(budget);
        }

        // Other repository methods
    }
}
