using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class SubCompartment
    {
        public SubCompartment()
        {
            EnvAssessmentSubCompartmentMap = new HashSet<EnvAssessmentSubCompartmentMap>();
            EnvironmentalAssessmentMitigation = new HashSet<EnvironmentalAssessmentMitigation>();
            Harvesting = new HashSet<Harvesting>();
            MajorManagementConstraintMap = new HashSet<MajorManagementConstraintMap>();
            SubCompartmentDesignationMap = new HashSet<SubCompartmentDesignationMap>();
            SubCompartmentFeatureMap = new HashSet<SubCompartmentFeatureMap>();
            TreePlanting = new HashSet<TreePlanting>();
        }

        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public int Compartment { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public double AreaInHectares { get; set; }
        public int? Pawsstatus { get; set; }
        public bool IsWoodland { get; set; }
        public bool IsWoodlandCreation { get; set; }
        public bool IsOtherHabitat { get; set; }
        public int? Year { get; set; }
        public int? MainSpeciesId { get; set; }
        public int? SecondSpeciesId { get; set; }
        public int? ManagementRegimeId { get; set; }
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
        public virtual ICollection<Harvesting> Harvesting { get; set; }
        public virtual ICollection<MajorManagementConstraintMap> MajorManagementConstraintMap { get; set; }
        public virtual ICollection<SubCompartmentDesignationMap> SubCompartmentDesignationMap { get; set; }
        public virtual ICollection<SubCompartmentFeatureMap> SubCompartmentFeatureMap { get; set; }
        public virtual ICollection<TreePlanting> TreePlanting { get; set; }
        public virtual User Lmu { get; set; }
        public virtual Species MainSpecies { get; set; }
        public virtual ManagementRegime ManagementRegime { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual Species SecondSpecies { get; set; }
    }
}
