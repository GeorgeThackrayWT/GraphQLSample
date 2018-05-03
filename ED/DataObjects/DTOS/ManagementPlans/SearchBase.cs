using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EDCORE.ViewModel;
using MvvmHelpers;

namespace DataObjects
{
    public class SearchBase : ObservableObject, IModel, IDuplicate
    {

        public SearchBase()
        {
             Random rnd = new Random();

            Id = 0-rnd.Next(52);

            Validator += (i) => { };
        }

        public int ManagementUnitID { get; set; }

        public int CostCentre { get; set; }

        public string Region { get; set; }

        public int RegionId { get; set; }

        public int ApplicationId { get; set; }

        public string Manager { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int WoodlandOfficerID { get; set; }


        public int AcquisitionOfficerID { get; set; }

        public int DeputyID { get; set; }

        public int Id { get; set; }

        public bool Deleted { get; set; }

        public DateTime LMDT { get; set; }

        public int? LMUID { get; set; }

        public DateTime? CRDT { get; set; }

        public int? CRUID { get; set; }

        public DateTime? DLDT { get; set; }

        public int? DLUID { get; set; }

        public DateTime? ULMDT { get; set; }
        public int? ULMUID { get; set; }

        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }

        public int RecordId => throw new NotImplementedException();

        public ObservableCollection<string> Errors => new ObservableCollection<string>();

        public Action<IModel> Validator { get; set; }

        public bool IsValid => true;

        public bool IsDirty => true;

        public bool Disposed => false;

        public void Dispose()
        {
           
        }

        public void MakeFromExisting(object existingRecord, int id)
        {
          
        }

        public void ResetChanges()
        {
           
        }

        public void Revert()
        {
          
        }

        public void SetPropChanged()
        {
          
        }

        public bool Validate()
        {
            return true;
        }


        public bool ValidManagementUnit(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {

            // pass in current application and current region.
            // if user is in groups 1 to 3 then we want to see all 
            // sites filtered only by application

            var roleList = userRole.Select(s => s.RoleId).ToList();

            if (roleList.Contains( 1) || roleList.Contains( 2) || roleList.Contains( 3))
            {



                if (application == 0 || application == 9) return true;


                if (application == 1 && ApplicationId == 1)
                {
                    return true;
                }

                if (application == 2 && ApplicationId == 2)
                {
                    return true;
                }

            }

            if (roleList.Contains( 4))
            {
                var reg = userRole.First(f => f.RoleId == 4).RegionId;


                if (ApplicationId == application && reg == RegionId)
                    return true;
            }

            if (roleList.Contains( 5))
            {
                var reg = userRole.First(f => f.RoleId == 5).RegionId;

                if (ApplicationId == application && reg == RegionId && (WoodlandOfficerID == userId || DeputyID == userId))
                    return true;
            }


            if (roleList.Contains( 6))
            {
           //     var reg = userRole.First(f => f.RoleId == 4).RegionId;

                if (ApplicationId == application && AcquisitionOfficerID == userId )
                    return true;
            }

            return false;
        }

    }
}