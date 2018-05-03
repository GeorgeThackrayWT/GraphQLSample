using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;
using MvvmHelpers;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IFundingModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
        ExtRangeCollection<FundingEditList> Records { get; set; }

        FundingEditList EditRecord { get; set; }

        ObservableRangeCollection<ComboBoxValue> FundingTypes { get; }
    }
}