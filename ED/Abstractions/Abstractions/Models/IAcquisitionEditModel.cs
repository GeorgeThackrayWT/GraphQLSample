using System;
using System.ComponentModel;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;

namespace Abstractions
{
    public interface IAcquisitionEditModel : IBaseModel, INotifyPropertyChanged
    {
        AUIDEdit ParentMU { get; set; }

        ExtRangeCollection<AUIDEdit> ParentRecords { get; set; }

    
        PropertyGeneralDetailsEdit PropertyGeneralDetails { get; }

        PropertyLegalTitleEdit PropertyLegalTitle { get; }

        PropertyFarmingEdit PropertyFarming { get; }

        MainSectionEdit AcquisitionMainSection { get;  }

        bool CostCenterReadOnly { get; }

        AUIDEdit Record { get; set; }

        int Id { get;  }

        int ManagementUnitId { get; set; }

        ILinkContainer AcquisitionLinkContainer { get; set; }
 
        Property<string> ApplicationName { get;  }

        Tuple<int,string> Grazing { get; }

        Tuple<int, string> Other { get; }

        Tuple<int, string> Fishing { get; }

        Tuple<int, string> Tenancy { get; }

        void Dispose();
    }
}

//other fishing tenancies