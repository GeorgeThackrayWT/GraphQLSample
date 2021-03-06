﻿using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAHumanImpactshModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATHumanImpactsDTOEdit CATHumanImpactsDTO { get; set; }
    }
}