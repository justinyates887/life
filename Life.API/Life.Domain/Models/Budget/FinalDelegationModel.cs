namespace Life.API.Models.Budget
{
    public class FinalDelegationModel
    {
        public int BudgetOwnerId { get; set; }

        public string Name { get; set; }

        public string? DelegationDescription { get; set; }

        public float Amount { get; set; }

        public string IncomeCategory { get; set; }
    }
}
