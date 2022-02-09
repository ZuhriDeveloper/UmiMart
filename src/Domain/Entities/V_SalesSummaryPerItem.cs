using System;


namespace UMApplication.Domain.Entities
{
    public class V_SalesSummaryPerItem
    {
        public DateTime Tgl_Transaksi { get; set; }
        public string Code { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Sales { get; set; }
        public decimal Hpp { get; set; }
        public int Tax { get; set; }
        public decimal SalesNet { get; set; }
        public decimal Margin { get; set; }
    }
}
