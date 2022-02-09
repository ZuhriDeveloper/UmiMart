namespace UMApplication.Domain.Entities
{
    public class V_StockSummary
    {
        public int ProductId { get; set; }
        public string PLU { get; set; }
        public string ProductName { get; set; }

        public decimal Hpp { get; set; }

        public decimal SellPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }

    }
}
