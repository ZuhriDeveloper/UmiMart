using System;


namespace UMApplication.UI.Models
{
    public class PembayaranSOModel
    {

        public PembayaranSOModel()
        {
            SoId = 0;
            PaidDate = DateTime.Now;
        }
        public int SoId { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
