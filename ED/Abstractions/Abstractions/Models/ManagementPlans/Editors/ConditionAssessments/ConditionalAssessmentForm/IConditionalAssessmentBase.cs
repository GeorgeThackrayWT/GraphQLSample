namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IConditionalAssessmentBase : IBaseModel
    {
        int ManagementId { get; set; }

        int WoodlandConditionSubSectionId { get; set; }
    }
}