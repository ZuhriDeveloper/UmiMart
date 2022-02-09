using System;
using System.Collections.Generic;
using System.Text;

namespace UMApplication.Domain.Entities
{
    public class V_SalesSummary
    {
        public string No_Faktur { get; set; }
        public DateTime Tgl_Transaksi { get; set; }
        public decimal Total_Bayar { get; set; }
        public decimal Bayar { get; set; }
        public decimal Diskon { get; set; }

        public decimal TotalHpp { get; set; }

        public decimal Kembali { get; set; }
        public string Nama_Kasir { get; set; }
        public string Nama_Pelanggan { get; set; }

        public string Metode_Pembayaran { get; set; }
    }
}
