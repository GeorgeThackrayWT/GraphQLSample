using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Contact
    {
        public Contact()
        {
            AcquisitionUnitSellerDonorAgent = new HashSet<AcquisitionUnit>();
            AcquisitionUnitSellerDonor = new HashSet<AcquisitionUnit>();
            AcquisitionUnitSellerDonorSolicitor = new HashSet<AcquisitionUnit>();
        }

        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public string Name { get; set; }
        public int? StatusId { get; set; }
        public string OtherStatus { get; set; }
        public string Organisation { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
        public string Notes { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<AcquisitionUnit> AcquisitionUnitSellerDonorAgent { get; set; }
        public virtual ICollection<AcquisitionUnit> AcquisitionUnitSellerDonor { get; set; }
        public virtual ICollection<AcquisitionUnit> AcquisitionUnitSellerDonorSolicitor { get; set; }
        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ContactStatus Status { get; set; }
    }
}
