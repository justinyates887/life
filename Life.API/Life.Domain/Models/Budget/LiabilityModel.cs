namespace Life.API.Models.Budget
{
    public class LiabilityModel
    {
        public Guid Id { get; set; }

        public int OwnerId { get; set; }

        public string Name { get; set; }

        public float Amount { get; set; }

        public float APR { get; set; }

        public bool? Maturing { get; set; }

        public float? Limit { get; set; }
    }
}
