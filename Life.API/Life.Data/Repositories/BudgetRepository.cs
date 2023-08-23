using Life.Data;
using MongoDB.Driver;
using Life.API.Models.Budget;

namespace MyProject.Data.Repositories
{
    public class BudgetRepository
    {
        private readonly IMongoCollection<BudgetItemModel> _budgets;

        public BudgetRepository(DataContext dataContext)
        {
            _budgets = dataContext.Budgets;
        }

        public void AddBudget(BudgetItemModel budget)
        {
            _budgets.InsertOne(budget);
        }

        // Other repository methods
    }
}
