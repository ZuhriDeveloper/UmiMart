using UMApplication.Domain.Common;

namespace UMApplication.Domain.Entities
{
   public class AddressInfo : AuditableEntity
    {
        public int AddressInfoId { get; set; }
        public string PostalCode { get; set; }
        public string Village { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }

    }
}
