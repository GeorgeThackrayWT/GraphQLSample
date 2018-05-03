using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IContactsModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {  
        ExtRangeCollection<ContactEdit> Records { get; set; }

        ContactEdit EditRecord { get; set; }
    }
}