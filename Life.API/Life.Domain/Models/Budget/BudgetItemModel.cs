namespace Life.API.Models.Budget
{
    public class BudgetItemModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateOnly? Date { get; set; }

        //a.e monthly, weekly, daily
        public string Schedule { get; set; }

        public float Amount { get; set; }

        public string ExpenseCategory { get; set; }

        public bool Essential { get; set; }

        public bool Automated { get; set; }

        public bool Variable { get; set; }
    }
}
