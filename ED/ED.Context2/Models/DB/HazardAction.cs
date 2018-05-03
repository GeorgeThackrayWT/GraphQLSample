using System;

namespace EDC_Estate.Models.DB
{
    public partial class HazardAction
    {
        public int Id { get; set; }
        public int HazardId { get; set; }
        public string Description { get; set; }
        public int? SeverityProbabilityOfHarmId { get; set; }
        public string FurtherAction { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? FollowOnActionId { get; set; }
        public DateTime? FollowOnDeadline { get; set; }
        public DateTime? FollowOnComplete { get; set; }
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

        public virtual FollowOnActionType FollowOnAction { get; set; }
        public virtual Hazard Hazard { get; set; }
        public virtual User Lmu { get; set; }
        public virtual SeverityProbabilityOfHarm SeverityProbabilityOfHarm { get; set; }
    }
}
