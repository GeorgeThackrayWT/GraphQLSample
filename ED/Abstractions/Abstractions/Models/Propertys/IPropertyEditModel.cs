using System.Collections.Generic;
using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS;
using MvvmHelpers;

namespace Abstractions
{
    public interface IPropertyEditModel : IBaseModel, INotifyPropertyChanged
    {
        int Id { get; set; }

        ExtRangeCollection<AUIDEdit> Records { get; set; }

        AUIDEdit EditRecord { get; set; }

        double GisTotalAcres { get; set; }

        double WoodTotalAcres { get; set; }

        double LandTotalAcres { get; set; }

        void Dispose();
    }
}