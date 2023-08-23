namespace Life.API.Models.Budget
{
    public class BudgetModel
    {
        public Guid Id { get; set; }

        public int OwnerID { get; set; }

        public List<BudgetItemModel>? MonthlyItems { get; set; }

        public List<BudgetItemModel>? WeeklyItems { get; set; }

        public List<BudgetItemModel>? DailyItems { get; set; }

        public float? MonthlyIncomeNet { get; set; }

        public float? ExpensesTotal { get; set; }

        public float? LeftOverFunds { get; set; }

        public List<FinalDelegationModel> LeftOverDelegations { get; set; }
    }
}
