using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class EnvironmentalAssessmentMitigation
    {
        public EnvironmentalAssessmentMitigation()
        {
            EnvironmentalAssessmentMitigationAction = new HashSet<EnvironmentalAssessmentMitigationAction>();
        }

        public int Id { get; set; }
        public int EnvironmentalAssessmentId { get; set; }
        public int? SubCompartmentId { get; set; }
        public int RecordTypeId { get; set; }
        public int? DesignationId { get; set; }
        public int? MajorManagementConstraintId { get; set; }
        public int? ConservationFeatureId { get; set; }
        public int? ProtectedSpeciesId { get; set; }
        public int? MachineryId { get; set; }
        public int? OperationId { get; set; }
        public int? BurningId { get; set; }
        public int? TreeSafetyWorkId { get; set; }
        public int? PesticideUseId { get; set; }
        public int NeedToMitigateId { get; set; }
        public string ExplainationIfNo { get; set; }
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

        public virtual ICollection<EnvironmentalAssessmentMitigationAction> EnvironmentalAssessmentMitigationAction { get; set; }
        public virtual ConservationFeature ConservationFeature { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual EnvironmentalAssessment EnvironmentalAssessment { get; set; }
        public virtual User Lmu { get; set; }
        public virtual MajorManagementConstraint MajorManagementConstraint { get; set; }
        public virtual EnvironmentalAssessmentNeedToMitigate NeedToMitigate { get; set; }
        public virtual EnvironmentalAssessmentMitigationType RecordType { get; set; }
        public virtual SubCompartment SubCompartment { get; set; }
    }
}
