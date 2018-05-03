using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel
{
    public class FocusParser
    {
        private string _parent = "";

        private IPlatformEventHandling _iPlatformEventHandling;

        private ITelerikConvertors _iTelerikConvertors;
        private string _clickedControl;
        private string _containerControl;

        public string Parent => _parent;

        public FocusParser(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, ITelerikConvertors iTelerikConvertors)
        {
            _iPlatformEventHandling = iPlatformEventHandling;
            _iTelerikConvertors = iTelerikConvertors;
        }

        public void Parse(object sender, object e)
        {
            _containerControl = _iTelerikConvertors.GetControlInfo(sender);

            _clickedControl = _iPlatformEventHandling.RoutedEventArgsHandler.Process(sender, e);

            _parent = _iPlatformEventHandling.RoutedEventArgsHandler.Parents(sender, e);
        }

        public bool ButtonClicked => _clickedControl == "AddButton"
                                     || _clickedControl == "DelButton"
                                     || _clickedControl == "SaveButton"
                                     || _clickedControl == "HeaderClipper";

        public InstanceData MakeInstanceData(string instanceClicked)
        {
            return new InstanceData()
            {
                InstanceID = instanceClicked,
                ControlName = _containerControl,
                Element = _clickedControl
            };

        }

    }
}