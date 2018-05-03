using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IToolBarModel : ICommonInterface, INotifyPropertyChanged
    {     
        string SelectionInfo { get; set; }

        bool SaveRequired { get; set; }
        bool AddRequired { get; set; }
        bool DelRequired { get; set; }
        bool CloseRequired { get; set; }
        bool HelpRequired { get; set; }
        bool CancelItemsRequired { get; set; }
        bool AddTreesRequired { get; set; }

        bool DuplicateFourRequired { get; set; }

        bool DuplicateSingleRequired { get; set; }

        bool DuplicateRequired { get; set; }

        bool SearchRequired { get; set; }
        
        bool PleaseWaitVisible { get; set; }


        InstanceData Parent { get; set; }

        void ProgressLoaded();
    }


    public interface IHeaderBarModel : IBaseModel, INotifyPropertyChanged
    {
        string ScreenName { get; set; }

        string Label { get; set; }

        string SubLabel { get; set; }

        InstanceData Parent { get; set; }

        void ProgressLoaded();
    }
}