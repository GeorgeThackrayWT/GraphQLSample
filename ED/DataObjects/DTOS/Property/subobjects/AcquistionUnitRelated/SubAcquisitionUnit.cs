using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class SubAcquisitionUnit : BaseDto, IRecord
    {
        public bool BeneficialCovenantsExist { get; set; }

        public string BeneficialCovenantText { get; set; }

        public string HazardsLiabilities { get; set; }

        public string Contamination { get; set; }

        public string Names { get; set; }

        public string ManagementAccess { get; set; }

        public string ManagementInformation { get; set; }

        public int MineralRightTypeId { get; set; }

        public string MineralRightsDescription { get; set; }

        public bool OtherRightsConveyedExists { get; set; }

        public string OtherRightsConveyedDescription { get; set; }

        public bool PermissiveAccessExists { get; set; }

        public string PermissiveAccessDescription { get; set; }

        public string PlanningMattersDescription { get; set; }

        public string PropertyInfoDescription { get; set; }

        public string Comment { get; set; }

        public bool RestrictiveCovenantsExist { get; set; }

        public string RestrictiveCovenantDescription { get; set; }

        public int ShootingFishingTypeId { get; set; }

        public string ShootingDescription { get; set; }

        public string AdditionalInformationDescription { get; set; }

        public string BoundariesDescription { get; set; } 

        public bool DrainageRatesExist { get; set; }

        public DateTime? HighwayAct { get; set; }

        public DateTime? HighwayActNext { get; set; }

        public DateTime? StatutoryDeclarations { get; set; }

        public DateTime? StatutoryDeclarationsNext { get; set; }

        public bool PublicRightsOfWayExist { get; set; }

        public int HighwayAuthorityId { get; set; }

        public bool StructuresExist { get; set; }

        public string StructuresDescription { get; set; }

        public bool ThirdPartyRightsExist { get; set; }

        public string ThirdPartyRightsDescription { get; set; }

        public bool ServicesExist { get; set; }

        public string ServicesDescription { get; set; }

        public SubAcquisitionUnit Clone()
        {
            return new SubAcquisitionUnit()
            {
                BeneficialCovenantsExist = this.BeneficialCovenantsExist,
                BeneficialCovenantText = this.BeneficialCovenantText,
                HazardsLiabilities = this.HazardsLiabilities,
                Contamination = this.Contamination,
                Names = this.Names,
                ManagementAccess = this.ManagementAccess,
                ManagementInformation = this.ManagementInformation,
                MineralRightTypeId = this.MineralRightTypeId,
                MineralRightsDescription = this.MineralRightsDescription,
                OtherRightsConveyedExists = this.OtherRightsConveyedExists,
                OtherRightsConveyedDescription = this.OtherRightsConveyedDescription,
                PermissiveAccessExists = this.PermissiveAccessExists,
                PermissiveAccessDescription = this.PermissiveAccessDescription,
                PlanningMattersDescription = this.PlanningMattersDescription,
                PropertyInfoDescription = this.PropertyInfoDescription,
                Comment = this.Comment,
                RestrictiveCovenantsExist = this.RestrictiveCovenantsExist,
                RestrictiveCovenantDescription = this.RestrictiveCovenantDescription,
                ShootingFishingTypeId = this.ShootingFishingTypeId,
                ShootingDescription = this.ShootingDescription,
                AdditionalInformationDescription = this.AdditionalInformationDescription,
                BoundariesDescription = this.BoundariesDescription,
                DrainageRatesExist = this.DrainageRatesExist,
                HighwayAct = this.HighwayAct,
                HighwayActNext = this.HighwayActNext,
                StatutoryDeclarations = this.StatutoryDeclarations,
                StatutoryDeclarationsNext = this.StatutoryDeclarationsNext,
                PublicRightsOfWayExist = this.PublicRightsOfWayExist,
                HighwayAuthorityId = this.HighwayAuthorityId,
                StructuresExist = this.StructuresExist,
                StructuresDescription = this.StructuresDescription,
                ThirdPartyRightsExist = this.ThirdPartyRightsExist,
                ThirdPartyRightsDescription = this.ThirdPartyRightsDescription,
                ServicesExist = this.ServicesExist,
                ServicesDescription = this.ServicesDescription,
            };
        }//endofclonemethods
    }

    public class SubAcquisitionUnitEdit : PropertyBase<SubAcquisitionUnitEdit>, IDuplicate
    {

        private SubAcquisitionUnit _dto;


        public SubAcquisitionUnitEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<bool> BeneficialCovenantsExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> BeneficialCovenantText { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> HazardsLiabilities { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Contamination { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Names { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> ManagementAccess { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> ManagementInformation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> MineralRightTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> MineralRightsDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> OtherRightsConveyedExists { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> OtherRightsConveyedDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> PermissiveAccessExists { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> PermissiveAccessDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> PlanningMattersDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> PropertyInfoDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Comment { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> RestrictiveCovenantsExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> RestrictiveCovenantDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> ShootingFishingTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> ShootingDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> AdditionalInformationDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> BoundariesDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> DrainageRatesExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> HighwayAct { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> HighwayActNext { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> StatutoryDeclarations { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> StatutoryDeclarationsNext { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> PublicRightsOfWayExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> HighwayAuthorityId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> StructuresExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> StructuresDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> ThirdPartyRightsExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> ThirdPartyRightsDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> ServicesExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> ServicesDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public SubAcquisitionUnit ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.BeneficialCovenantsExist = BeneficialCovenantsExist.Value;
            returnVal.BeneficialCovenantText = BeneficialCovenantText.Value;
            returnVal.HazardsLiabilities = HazardsLiabilities.Value;
            returnVal.Contamination = Contamination.Value;
            returnVal.Names = Names.Value;
            returnVal.ManagementAccess = ManagementAccess.Value;
            returnVal.ManagementInformation = ManagementInformation.Value;
            returnVal.MineralRightTypeId = MineralRightTypeId.Value;
            returnVal.MineralRightsDescription = MineralRightsDescription.Value;
            returnVal.OtherRightsConveyedExists = OtherRightsConveyedExists.Value;
            returnVal.OtherRightsConveyedDescription = OtherRightsConveyedDescription.Value;
            returnVal.PermissiveAccessExists = PermissiveAccessExists.Value;
            returnVal.PermissiveAccessDescription = PermissiveAccessDescription.Value;
            returnVal.PlanningMattersDescription = PlanningMattersDescription.Value;
            returnVal.PropertyInfoDescription = PropertyInfoDescription.Value;
            returnVal.Comment = Comment.Value;
            returnVal.RestrictiveCovenantsExist = RestrictiveCovenantsExist.Value;
            returnVal.RestrictiveCovenantDescription = RestrictiveCovenantDescription.Value;
            returnVal.ShootingFishingTypeId = ShootingFishingTypeId.Value;
            returnVal.ShootingDescription = ShootingDescription.Value;
            returnVal.AdditionalInformationDescription = AdditionalInformationDescription.Value;
            returnVal.BoundariesDescription = BoundariesDescription.Value;
            returnVal.DrainageRatesExist = DrainageRatesExist.Value;
            returnVal.HighwayAct = HighwayAct.Value;
            returnVal.HighwayActNext = HighwayActNext.Value;
            returnVal.StatutoryDeclarations = StatutoryDeclarations.Value;
            returnVal.StatutoryDeclarationsNext = StatutoryDeclarationsNext.Value;
            returnVal.PublicRightsOfWayExist = PublicRightsOfWayExist.Value;
            returnVal.HighwayAuthorityId = HighwayAuthorityId.Value;
            returnVal.StructuresExist = StructuresExist.Value;
            returnVal.StructuresDescription = StructuresDescription.Value;
            returnVal.ThirdPartyRightsExist = ThirdPartyRightsExist.Value;
            returnVal.ThirdPartyRightsDescription = ThirdPartyRightsDescription.Value;
            returnVal.ServicesExist = ServicesExist.Value;
            returnVal.ServicesDescription = ServicesDescription.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SubAcquisitionUnitEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SubAcquisitionUnit test)
        {

            this.BeneficialCovenantsExist = Property<bool>.Make(test.BeneficialCovenantsExist,BeneficialCovenantsExist);
            this.BeneficialCovenantText = Property<string>.Make(test.BeneficialCovenantText,BeneficialCovenantText);
            this.HazardsLiabilities = Property<string>.Make(test.HazardsLiabilities,HazardsLiabilities);
            this.Contamination = Property<string>.Make(test.Contamination,Contamination);
            this.Names = Property<string>.Make(test.Names,Names);
            this.ManagementAccess = Property<string>.Make(test.ManagementAccess,ManagementAccess);
            this.ManagementInformation = Property<string>.Make(test.ManagementInformation,ManagementInformation);
            this.MineralRightTypeId = Property<int>.Make(test.MineralRightTypeId,MineralRightTypeId);
            this.MineralRightsDescription = Property<string>.Make(test.MineralRightsDescription,MineralRightsDescription);
            this.OtherRightsConveyedExists = Property<bool>.Make(test.OtherRightsConveyedExists,OtherRightsConveyedExists);
            this.OtherRightsConveyedDescription = Property<string>.Make(test.OtherRightsConveyedDescription,OtherRightsConveyedDescription);
            this.PermissiveAccessExists = Property<bool>.Make(test.PermissiveAccessExists,PermissiveAccessExists);
            this.PermissiveAccessDescription = Property<string>.Make(test.PermissiveAccessDescription,PermissiveAccessDescription);
            this.PlanningMattersDescription = Property<string>.Make(test.PlanningMattersDescription,PlanningMattersDescription);
            this.PropertyInfoDescription = Property<string>.Make(test.PropertyInfoDescription,PropertyInfoDescription);
            this.Comment = Property<string>.Make(test.Comment,Comment);
            this.RestrictiveCovenantsExist = Property<bool>.Make(test.RestrictiveCovenantsExist,RestrictiveCovenantsExist);
            this.RestrictiveCovenantDescription = Property<string>.Make(test.RestrictiveCovenantDescription,RestrictiveCovenantDescription);
            this.ShootingFishingTypeId = Property<int>.Make(test.ShootingFishingTypeId,ShootingFishingTypeId);
            this.ShootingDescription = Property<string>.Make(test.ShootingDescription,ShootingDescription);
            this.AdditionalInformationDescription = Property<string>.Make(test.AdditionalInformationDescription,AdditionalInformationDescription);
            this.BoundariesDescription = Property<string>.Make(test.BoundariesDescription,BoundariesDescription);
            this.DrainageRatesExist = Property<bool>.Make(test.DrainageRatesExist,DrainageRatesExist);
            this.HighwayAct = Property<DateTime?>.Make(test.HighwayAct,HighwayAct);
            this.HighwayActNext = Property<DateTime?>.Make(test.HighwayActNext,HighwayActNext);
            this.StatutoryDeclarations = Property<DateTime?>.Make(test.StatutoryDeclarations,StatutoryDeclarations);
            this.StatutoryDeclarationsNext = Property<DateTime?>.Make(test.StatutoryDeclarationsNext,StatutoryDeclarationsNext);
            this.PublicRightsOfWayExist = Property<bool>.Make(test.PublicRightsOfWayExist,PublicRightsOfWayExist);
            this.HighwayAuthorityId = Property<int>.Make(test.HighwayAuthorityId,HighwayAuthorityId);
            this.StructuresExist = Property<bool>.Make(test.StructuresExist,StructuresExist);
            this.StructuresDescription = Property<string>.Make(test.StructuresDescription,StructuresDescription);
            this.ThirdPartyRightsExist = Property<bool>.Make(test.ThirdPartyRightsExist,ThirdPartyRightsExist);
            this.ThirdPartyRightsDescription = Property<string>.Make(test.ThirdPartyRightsDescription,ThirdPartyRightsDescription);
            this.ServicesExist = Property<bool>.Make(test.ServicesExist,ServicesExist);
            this.ServicesDescription = Property<string>.Make(test.ServicesDescription,ServicesDescription);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            BeneficialCovenantsExist.Revert();
            BeneficialCovenantText.Revert();
            HazardsLiabilities.Revert();
            Contamination.Revert();
            Names.Revert();
            ManagementAccess.Revert();
            ManagementInformation.Revert();
            MineralRightTypeId.Revert();
            MineralRightsDescription.Revert();
            OtherRightsConveyedExists.Revert();
            OtherRightsConveyedDescription.Revert();
            PermissiveAccessExists.Revert();
            PermissiveAccessDescription.Revert();
            PlanningMattersDescription.Revert();
            PropertyInfoDescription.Revert();
            Comment.Revert();
            RestrictiveCovenantsExist.Revert();
            RestrictiveCovenantDescription.Revert();
            ShootingFishingTypeId.Revert();
            ShootingDescription.Revert();
            AdditionalInformationDescription.Revert();
            BoundariesDescription.Revert();
            DrainageRatesExist.Revert();
            HighwayAct.Revert();
            HighwayActNext.Revert();
            StatutoryDeclarations.Revert();
            StatutoryDeclarationsNext.Revert();
            PublicRightsOfWayExist.Revert();
            HighwayAuthorityId.Revert();
            StructuresExist.Revert();
            StructuresDescription.Revert();
            ThirdPartyRightsExist.Revert();
            ThirdPartyRightsDescription.Revert();
            ServicesExist.Revert();
            ServicesDescription.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SubAcquisitionUnitEdit> MakeCollection(List<SubAcquisitionUnit> records)
        {

            var newData = new ExtRangeCollection<SubAcquisitionUnitEdit>();

            foreach (var rec in records)
            {
                var e = new SubAcquisitionUnitEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SubAcquisitionUnitEditList : ListObj<SubAcquisitionUnit>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private SubAcquisitionUnit _dto;


        public SubAcquisitionUnitEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public bool BeneficialCovenantsExist { get => _current.BeneficialCovenantsExist; set { _current.BeneficialCovenantsExist = value; OnPropertyChanged(); } }

        public string BeneficialCovenantText { get => _current.BeneficialCovenantText; set { _current.BeneficialCovenantText = value; OnPropertyChanged(); } }

        public string HazardsLiabilities { get => _current.HazardsLiabilities; set { _current.HazardsLiabilities = value; OnPropertyChanged(); } }

        public string Contamination { get => _current.Contamination; set { _current.Contamination = value; OnPropertyChanged(); } }

        public string Names { get => _current.Names; set { _current.Names = value; OnPropertyChanged(); } }

        public string ManagementAccess { get => _current.ManagementAccess; set { _current.ManagementAccess = value; OnPropertyChanged(); } }

        public string ManagementInformation { get => _current.ManagementInformation; set { _current.ManagementInformation = value; OnPropertyChanged(); } }

        public int MineralRightTypeId { get => _current.MineralRightTypeId; set { _current.MineralRightTypeId = value; OnPropertyChanged(); } }

        public string MineralRightsDescription { get => _current.MineralRightsDescription; set { _current.MineralRightsDescription = value; OnPropertyChanged(); } }

        public bool OtherRightsConveyedExists { get => _current.OtherRightsConveyedExists; set { _current.OtherRightsConveyedExists = value; OnPropertyChanged(); } }

        public string OtherRightsConveyedDescription { get => _current.OtherRightsConveyedDescription; set { _current.OtherRightsConveyedDescription = value; OnPropertyChanged(); } }

        public bool PermissiveAccessExists { get => _current.PermissiveAccessExists; set { _current.PermissiveAccessExists = value; OnPropertyChanged(); } }

        public string PermissiveAccessDescription { get => _current.PermissiveAccessDescription; set { _current.PermissiveAccessDescription = value; OnPropertyChanged(); } }

        public string PlanningMattersDescription { get => _current.PlanningMattersDescription; set { _current.PlanningMattersDescription = value; OnPropertyChanged(); } }

        public string PropertyInfoDescription { get => _current.PropertyInfoDescription; set { _current.PropertyInfoDescription = value; OnPropertyChanged(); } }

        public string Comment { get => _current.Comment; set { _current.Comment = value; OnPropertyChanged(); } }

        public bool RestrictiveCovenantsExist { get => _current.RestrictiveCovenantsExist; set { _current.RestrictiveCovenantsExist = value; OnPropertyChanged(); } }

        public string RestrictiveCovenantDescription { get => _current.RestrictiveCovenantDescription; set { _current.RestrictiveCovenantDescription = value; OnPropertyChanged(); } }

        public int ShootingFishingTypeId { get => _current.ShootingFishingTypeId; set { _current.ShootingFishingTypeId = value; OnPropertyChanged(); } }

        public string ShootingDescription { get => _current.ShootingDescription; set { _current.ShootingDescription = value; OnPropertyChanged(); } }

        public string AdditionalInformationDescription { get => _current.AdditionalInformationDescription; set { _current.AdditionalInformationDescription = value; OnPropertyChanged(); } }

        public string BoundariesDescription { get => _current.BoundariesDescription; set { _current.BoundariesDescription = value; OnPropertyChanged(); } }

        public bool DrainageRatesExist { get => _current.DrainageRatesExist; set { _current.DrainageRatesExist = value; OnPropertyChanged(); } }

        public DateTime? HighwayAct { get => _current.HighwayAct; set { _current.HighwayAct = value; OnPropertyChanged(); } }

        public DateTime? HighwayActNext { get => _current.HighwayActNext; set { _current.HighwayActNext = value; OnPropertyChanged(); } }

        public DateTime? StatutoryDeclarations { get => _current.StatutoryDeclarations; set { _current.StatutoryDeclarations = value; OnPropertyChanged(); } }

        public DateTime? StatutoryDeclarationsNext { get => _current.StatutoryDeclarationsNext; set { _current.StatutoryDeclarationsNext = value; OnPropertyChanged(); } }

        public bool PublicRightsOfWayExist { get => _current.PublicRightsOfWayExist; set { _current.PublicRightsOfWayExist = value; OnPropertyChanged(); } }

        public int HighwayAuthorityId { get => _current.HighwayAuthorityId; set { _current.HighwayAuthorityId = value; OnPropertyChanged(); } }

        public bool StructuresExist { get => _current.StructuresExist; set { _current.StructuresExist = value; OnPropertyChanged(); } }

        public string StructuresDescription { get => _current.StructuresDescription; set { _current.StructuresDescription = value; OnPropertyChanged(); } }

        public bool ThirdPartyRightsExist { get => _current.ThirdPartyRightsExist; set { _current.ThirdPartyRightsExist = value; OnPropertyChanged(); } }

        public string ThirdPartyRightsDescription { get => _current.ThirdPartyRightsDescription; set { _current.ThirdPartyRightsDescription = value; OnPropertyChanged(); } }

        public bool ServicesExist { get => _current.ServicesExist; set { _current.ServicesExist = value; OnPropertyChanged(); } }

        public string ServicesDescription { get => _current.ServicesDescription; set { _current.ServicesDescription = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public SubAcquisitionUnit ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.BeneficialCovenantsExist = this.BeneficialCovenantsExist;
            returnVal.BeneficialCovenantText = this.BeneficialCovenantText;
            returnVal.HazardsLiabilities = this.HazardsLiabilities;
            returnVal.Contamination = this.Contamination;
            returnVal.Names = this.Names;
            returnVal.ManagementAccess = this.ManagementAccess;
            returnVal.ManagementInformation = this.ManagementInformation;
            returnVal.MineralRightTypeId = this.MineralRightTypeId;
            returnVal.MineralRightsDescription = this.MineralRightsDescription;
            returnVal.OtherRightsConveyedExists = this.OtherRightsConveyedExists;
            returnVal.OtherRightsConveyedDescription = this.OtherRightsConveyedDescription;
            returnVal.PermissiveAccessExists = this.PermissiveAccessExists;
            returnVal.PermissiveAccessDescription = this.PermissiveAccessDescription;
            returnVal.PlanningMattersDescription = this.PlanningMattersDescription;
            returnVal.PropertyInfoDescription = this.PropertyInfoDescription;
            returnVal.Comment = this.Comment;
            returnVal.RestrictiveCovenantsExist = this.RestrictiveCovenantsExist;
            returnVal.RestrictiveCovenantDescription = this.RestrictiveCovenantDescription;
            returnVal.ShootingFishingTypeId = this.ShootingFishingTypeId;
            returnVal.ShootingDescription = this.ShootingDescription;
            returnVal.AdditionalInformationDescription = this.AdditionalInformationDescription;
            returnVal.BoundariesDescription = this.BoundariesDescription;
            returnVal.DrainageRatesExist = this.DrainageRatesExist;
            returnVal.HighwayAct = this.HighwayAct;
            returnVal.HighwayActNext = this.HighwayActNext;
            returnVal.StatutoryDeclarations = this.StatutoryDeclarations;
            returnVal.StatutoryDeclarationsNext = this.StatutoryDeclarationsNext;
            returnVal.PublicRightsOfWayExist = this.PublicRightsOfWayExist;
            returnVal.HighwayAuthorityId = this.HighwayAuthorityId;
            returnVal.StructuresExist = this.StructuresExist;
            returnVal.StructuresDescription = this.StructuresDescription;
            returnVal.ThirdPartyRightsExist = this.ThirdPartyRightsExist;
            returnVal.ThirdPartyRightsDescription = this.ThirdPartyRightsDescription;
            returnVal.ServicesExist = this.ServicesExist;
            returnVal.ServicesDescription = this.ServicesDescription;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SubAcquisitionUnitEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SubAcquisitionUnit test)
        {
            _original.BeneficialCovenantsExist = test.BeneficialCovenantsExist;
            _current.BeneficialCovenantsExist = test.BeneficialCovenantsExist;
            _original.BeneficialCovenantText = test.BeneficialCovenantText;
            _current.BeneficialCovenantText = test.BeneficialCovenantText;
            _original.HazardsLiabilities = test.HazardsLiabilities;
            _current.HazardsLiabilities = test.HazardsLiabilities;
            _original.Contamination = test.Contamination;
            _current.Contamination = test.Contamination;
            _original.Names = test.Names;
            _current.Names = test.Names;
            _original.ManagementAccess = test.ManagementAccess;
            _current.ManagementAccess = test.ManagementAccess;
            _original.ManagementInformation = test.ManagementInformation;
            _current.ManagementInformation = test.ManagementInformation;
            _original.MineralRightTypeId = test.MineralRightTypeId;
            _current.MineralRightTypeId = test.MineralRightTypeId;
            _original.MineralRightsDescription = test.MineralRightsDescription;
            _current.MineralRightsDescription = test.MineralRightsDescription;
            _original.OtherRightsConveyedExists = test.OtherRightsConveyedExists;
            _current.OtherRightsConveyedExists = test.OtherRightsConveyedExists;
            _original.OtherRightsConveyedDescription = test.OtherRightsConveyedDescription;
            _current.OtherRightsConveyedDescription = test.OtherRightsConveyedDescription;
            _original.PermissiveAccessExists = test.PermissiveAccessExists;
            _current.PermissiveAccessExists = test.PermissiveAccessExists;
            _original.PermissiveAccessDescription = test.PermissiveAccessDescription;
            _current.PermissiveAccessDescription = test.PermissiveAccessDescription;
            _original.PlanningMattersDescription = test.PlanningMattersDescription;
            _current.PlanningMattersDescription = test.PlanningMattersDescription;
            _original.PropertyInfoDescription = test.PropertyInfoDescription;
            _current.PropertyInfoDescription = test.PropertyInfoDescription;
            _original.Comment = test.Comment;
            _current.Comment = test.Comment;
            _original.RestrictiveCovenantsExist = test.RestrictiveCovenantsExist;
            _current.RestrictiveCovenantsExist = test.RestrictiveCovenantsExist;
            _original.RestrictiveCovenantDescription = test.RestrictiveCovenantDescription;
            _current.RestrictiveCovenantDescription = test.RestrictiveCovenantDescription;
            _original.ShootingFishingTypeId = test.ShootingFishingTypeId;
            _current.ShootingFishingTypeId = test.ShootingFishingTypeId;
            _original.ShootingDescription = test.ShootingDescription;
            _current.ShootingDescription = test.ShootingDescription;
            _original.AdditionalInformationDescription = test.AdditionalInformationDescription;
            _current.AdditionalInformationDescription = test.AdditionalInformationDescription;
            _original.BoundariesDescription = test.BoundariesDescription;
            _current.BoundariesDescription = test.BoundariesDescription;
            _original.DrainageRatesExist = test.DrainageRatesExist;
            _current.DrainageRatesExist = test.DrainageRatesExist;
            _original.HighwayAct = test.HighwayAct;
            _current.HighwayAct = test.HighwayAct;
            _original.HighwayActNext = test.HighwayActNext;
            _current.HighwayActNext = test.HighwayActNext;
            _original.StatutoryDeclarations = test.StatutoryDeclarations;
            _current.StatutoryDeclarations = test.StatutoryDeclarations;
            _original.StatutoryDeclarationsNext = test.StatutoryDeclarationsNext;
            _current.StatutoryDeclarationsNext = test.StatutoryDeclarationsNext;
            _original.PublicRightsOfWayExist = test.PublicRightsOfWayExist;
            _current.PublicRightsOfWayExist = test.PublicRightsOfWayExist;
            _original.HighwayAuthorityId = test.HighwayAuthorityId;
            _current.HighwayAuthorityId = test.HighwayAuthorityId;
            _original.StructuresExist = test.StructuresExist;
            _current.StructuresExist = test.StructuresExist;
            _original.StructuresDescription = test.StructuresDescription;
            _current.StructuresDescription = test.StructuresDescription;
            _original.ThirdPartyRightsExist = test.ThirdPartyRightsExist;
            _current.ThirdPartyRightsExist = test.ThirdPartyRightsExist;
            _original.ThirdPartyRightsDescription = test.ThirdPartyRightsDescription;
            _current.ThirdPartyRightsDescription = test.ThirdPartyRightsDescription;
            _original.ServicesExist = test.ServicesExist;
            _current.ServicesExist = test.ServicesExist;
            _original.ServicesDescription = test.ServicesDescription;
            _current.ServicesDescription = test.ServicesDescription;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SubAcquisitionUnitEditList> MakeCollection(List<SubAcquisitionUnit> records)
        {

            var newData = new ExtRangeCollection<SubAcquisitionUnitEditList>();

            foreach (var rec in records)
            {
                var e = new SubAcquisitionUnitEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}