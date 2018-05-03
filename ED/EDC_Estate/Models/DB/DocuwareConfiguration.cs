using System;

namespace EDC_Estate.Models.DB
{
    public partial class DocuwareConfiguration
    {
        public int Id { get; set; }
        public int CabinetId { get; set; }
        public string ServerName { get; set; }
        public string TargetDirectory { get; set; }
        public string PathExtension { get; set; }
        public string IntegrationIdentifier { get; set; }
        public int LoginTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginKey { get; set; }
        public string LoginToken { get; set; }
        public bool HttpSecure { get; set; }
        public bool Enabled { get; set; }
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

        public virtual DocuwareCabinet Cabinet { get; set; }
        public virtual User Lmu { get; set; }
        public virtual DocuwareLoginType LoginType { get; set; }
    }
}
