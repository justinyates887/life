namespace Life.API.Models.Budget
{
    public class AssetModel
    {
        public Guid Id { get; set; }

        public int OwnerID { get; set; }

        public string Name { get; set; }

        public float Amount { get; set; }
    }
}
