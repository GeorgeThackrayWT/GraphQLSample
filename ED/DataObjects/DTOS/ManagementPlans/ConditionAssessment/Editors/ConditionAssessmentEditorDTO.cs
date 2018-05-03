using System.Collections.Generic;
using MvvmHelpers;

namespace DataObjects
{
    public class ConditionAssessmentEditorDto : ObservableObject
    {
        public List<ConditionAssessmentEditorEntryDto> ConditionAssessmentList { get; set; }

    }
}