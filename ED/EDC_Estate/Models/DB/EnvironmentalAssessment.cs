using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class EnvironmentalAssessment
    {
        public EnvironmentalAssessment()
        {
            EnvAssessmentSubCompartmentMap = new HashSet<EnvAssessmentSubCompartmentMap>();
            EnvironmentalAssessmentMitigation = new HashSet<EnvironmentalAssessmentMitigation>();
        }

        public int Id { get; set; }
        public int WorkProgrammeId { get; set; }
        public int TypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ActionedById { get; set; }
        public string PreviousIncidentsOfDamage { get; set; }
        public bool NotApplicable { get; set; }
        public string BurningJustificationForBurning { get; set; }
        public bool BurningConfirmFireSitesLocation { get; set; }
        public bool BurningBurningCloseToResidences { get; set; }
        public bool EngineeringLossDamageToAncientWoodland { get; set; }
        public bool EngineeringConfirmEngineeringImpact { get; set; }
        public string EngineeringImpactDescription { get; set; }
        public string EngineeringFillMaterial { get; set; }
        public int? PesticideTargetSpeciesId { get; set; }
        public string PesticideWhyChemicalControlNeeded { get; set; }
        public bool PesticideIsControlPractical { get; set; }
        public bool PesticideNonChemicalConsidered { get; set; }
        public string PesticideChemicalUsed { get; set; }
        public int? PesticideApplicationMethodId { get; set; }
        public double? PesticideApplicationRate { get; set; }
        public int? PesticideNumberYearsEstimated { get; set; }
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

        public virtual ICollection<EnvAssessmentSubCompartmentMap> EnvAssessmentSubCompartmentMap { get; set; }
        public virtual ICollection<EnvironmentalAssessmentMitigation> EnvironmentalAssessmentMitigation { get; set; }
        public virtual User ActionedBy { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ApplicationMethod PesticideApplicationMethod { get; set; }
        public virtual TargetSpecies PesticideTargetSpecies { get; set; }
        public virtual EnvironmentalAssessmentType Type { get; set; }
        public virtual Expenditure WorkProgramme { get; set; }
    }
}
