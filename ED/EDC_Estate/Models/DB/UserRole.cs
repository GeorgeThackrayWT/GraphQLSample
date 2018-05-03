using System;

namespace EDC_Estate.Models.DB
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual Country Country { get; set; }
        public virtual Region Region { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
