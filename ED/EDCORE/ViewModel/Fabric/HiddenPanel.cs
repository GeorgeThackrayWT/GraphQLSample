using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions.Models.ManagementPlans.Editors;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Fabric
{
    public class HiddenPanel : IHiddenPanel
    {
        public ICommand ShowHide { get; }

        public bool Visible { get; set; }

        public HiddenPanel( Action<bool> action,  bool visible=false)
        {
         
            Visible = visible;

            ShowHide = new RelayCommand((x) =>
            {
                Debug.WriteLine("HiddenPanel Clicked");
                Visible = !Visible;

                action.Invoke(Visible);
            });
        }

    }
}
