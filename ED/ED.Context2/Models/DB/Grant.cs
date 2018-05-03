using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Grant
    {
        public Grant()
        {
            Income = new HashSet<Income>();
        }

        public int Id { get; set; }
        public int ManagementPlanId { get; set; }
        public int GrantBodyId { get; set; }
        public int SchemeId { get; set; }
        public string Reference { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comments { get; set; }
        public bool IsMainContract { get; set; }
        public bool IsClumpedContract { get; set; }
        public int? ClumpedWithId { get; set; }
        public bool Completed { get; set; }
        public int? CompletedById { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool Authorised { get; set; }
        public int? AuthorisedById { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public bool Archived { get; set; }
        public int? ArchivedById { get; set; }
        public DateTime? DateArchived { get; set; }
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

        public virtual ICollection<Income> Income { get; set; }
        public virtual User ArchivedBy { get; set; }
        public virtual User AuthorisedBy { get; set; }
        public virtual Grant ClumpedWith { get; set; }
        public virtual ICollection<Grant> InverseClumpedWith { get; set; }
        public virtual User CompletedBy { get; set; }
        public virtual GrantBody GrantBody { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementPlan ManagementPlan { get; set; }
        public virtual AwardingScheme Scheme { get; set; }
    }
}
