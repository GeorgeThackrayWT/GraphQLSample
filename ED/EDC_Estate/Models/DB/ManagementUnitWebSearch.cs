using System;

namespace EDC_Estate.Models.DB
{
    public partial class ManagementUnitWebSearch
    {
        public int? Id { get; set; }
        public double? AreaInHectares { get; set; }
        public long? DirectoryInformation { get; set; }
        public long? CombinedDirectoryInformation { get; set; }
        public string HistoricName { get; set; }
        public string Designation { get; set; }
        public string AcquisitionName { get; set; }
        public string Region { get; set; }
        public int ManagementUnitWebSearchId { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }
    }
}
