using Abstractions.Helpers;

namespace Abstractions.Navigation
{
    
    public interface ILinkContainer
    {
        INavCouple SalesOrder { get; }
        INavCouple Adminstration { get; }
        INavCouple GrantContracts { get; }
        INavCouple ConditionAssessment { get; }
        INavCouple ConditionAssessmentForm { get; }
        INavCouple SummaryDescription { get; }
        INavCouple ObjectivesKF { get; }
        INavCouple WorkProgramme { get; }
        INavCouple PurchaseOrder { get; }      
        INavCouple Monitoring { get; }
        INavCouple Harvesting { get; }
        INavCouple ReferenceInformation { get; }
        INavCouple Pesticide { get; }
        INavCouple InternalAuditsEditor { get; }
        INavCouple PublicInfoEditor { get; }
        INavCouple TreePlantingEditor { get; }
        INavCouple SafetyEditor { get; }


        INavCouple DocumentsEditor { get; }
        INavCouple VATRatesEditor { get; }
        INavCouple ExpendtureProductsEditor { get; }
        INavCouple IncomeProductsEditor { get; }

        INavCouple FundedProjectSitesEditor { get; }
        INavCouple WTFLEditor { get; }
        INavCouple LookupEditor { get; }
        INavCouple VATCodesEditor { get; }

        INavCouple GeneralDetailsEditor { get; }
        INavCouple ReportEditor { get; }
        INavCouple WorkProgrammeEditor { get; }
        INavCouple UsersAndGroupsEditor { get; }

        INavCouple BeneficialCovenantsEditor { get; }
        INavCouple BoundariesPlansEditor { get; }
        INavCouple ContactsEditor { get; }
        INavCouple PropertyInfoDescriptionEditor { get; }
        INavCouple DrainageRatesEditor { get; }
        INavCouple EnvironmentEditor { get; }
        INavCouple FormerNamesEditor { get; }
        INavCouple FundingEditor { get; }
        INavCouple MineralRightsEditor { get; }
        INavCouple ManagementAccessEditor { get; }
        INavCouple ManagementInformationEditor { get; }
        INavCouple OtherRightsEditor { get; }
        INavCouple PartDisposalsEditor { get; }
        INavCouple PlanningExtraEditor { get; }
        INavCouple PublicAccessEditor { get; }
        INavCouple PublicRightsOfWay { get; }
        INavCouple RestrictiveCovenantsEditor { get; }
        INavCouple ShootingFishingEditor { get; }
        INavCouple StructuresEditor { get; }
        INavCouple ThirdPartyRightsEditor { get; }
        INavCouple LicenseEditor { get; }
        INavCouple DirectoryInfoEditor { get; }

        INavCouple PropertyPageEditor { get; }
        INavCouple TenderEditor { get; }

    }



}
