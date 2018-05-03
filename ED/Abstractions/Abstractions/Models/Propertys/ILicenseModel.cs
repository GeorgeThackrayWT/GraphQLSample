using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS;

namespace Abstractions
{
    public interface ILicenseModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
      //  LicenseDtos LicenseDtos { get; set; }

        string LicenseTypeLabel { get; set; }

        ExtRangeCollection<LicenseEdit> Records { get; set; }

        LicenseEdit EditRecord { get; set; }
    }
}