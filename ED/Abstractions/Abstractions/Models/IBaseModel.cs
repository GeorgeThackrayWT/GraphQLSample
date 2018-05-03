using System.Windows.Input;
using DataObjects;

namespace Abstractions
{

    public interface ICommonInterface
    {


        bool SaveEnabled { get; set; }
        bool AddEnabled { get; set; }
        bool DelEnabled { get; set; }
        bool CloseEnabled { get; set; }
        bool HelpEnabled { get; set; }
        bool CancelItemsEnabled { get; set; }
        bool AddTreesEnabled { get; set; }

        bool DuplicateFourEnabled { get; set; }

        bool DuplicateSingleEnabled { get; set; }

        bool DuplicateEnabled { get; set; }

        bool SearchEnabled { get; set; }


        ICommand Loaded { get; }

        ICommand SearchCommand { get; }

        ICommand DuplicateCommand { get; }

        ICommand DuplicateSingleCommand { get; }

        ICommand DuplicateFourCommand { get; }

        ICommand AddCommand { get; }

        ICommand AddTreesCommand { get; }

        ICommand CancelItemsCommand { get; }

        ICommand DeleteCommand { get; }

        ICommand SaveCommand { get; }

        ICommand HelpCommand { get; }

        ICommand DataCommand { get; }

        ICommand FocusCommand { get; }


    }

    

    public interface IBaseModel
    {
   


        void ForceRefresh(object sender, object e);
     
        void Focused(object sender, object e);
        void Unsubscribe();

        int ParentID { get;  }

        IBaseModel ParentInstance { get; set; }
        string InstanceID { get; set; }
        string ModelName { get; }


        StateContainer State  { get; set; }
        
        // the binding doesnt actually need this to run, but designer sometimes seems to crash without it
        // it being set so just set to dummy value. this isnt used for any other reason than stopping designer crashing.
        string hack { get; }

        void Dispose();

        bool IsDisposed { get; }
    }

    public interface INewRecord
    {
        bool NewRecord { get; set; }
    }



}