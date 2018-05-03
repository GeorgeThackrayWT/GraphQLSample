using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace Abstractions
{
    // we need 3 layers here
    //1 control used multiple times
    
    public interface IEvaluationModel : IBaseModel, INotifyPropertyChanged
    {
        //ObservableRangeCollection<EvaluationEditDto> EvaluationsFlip { get; }

        //EvaluationEditDto SelecteDesignatorDto { get; set; }

        EvaluationEditEdit EditRecord { get; set; }

        ExtRangeCollection<EvaluationEditEdit> RecordsFlip { get; set; }

        int ParentAcquistionUnit { get; set; }

        int EvaluationTypeId { get; set; }
    }
}