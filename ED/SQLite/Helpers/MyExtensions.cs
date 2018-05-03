using System;

namespace DataObjects.DTOS.ManagementPlans.SearchScreens
{
    public static class MyExtensions
    {
        // Write custom extension methods here. They will be available to all queries.

        public static int ConvertToInt(this bool valToConv)
        {
            return Convert.ToInt32(valToConv);
        }
        public static int GetAchievableInterventions(this WoodlandconditionsubsectionDTO myDto)
        {
            return myDto.InterventionDesirable.GetValueOrDefault().ConvertToInt()
                   + myDto.TAInterventionDesirable.ConvertToInt()
                   + myDto.TSInterventionDesirable.ConvertToInt()
                   + myDto.SSInterventionDesirable.ConvertToInt()
                   + myDto.LTRInterventionDesirable.ConvertToInt()
                   + myDto.LSRInterventionDesirable.ConvertToInt()
                   + myDto.RTSInterventionDesirable.ConvertToInt()
                   + myDto.RSSInterventionDesirable.ConvertToInt()
                   + myDto.FInterventionDesirable.ConvertToInt()
                   + myDto.DInterventionDesirable.ConvertToInt()
                   + myDto.ADInterventionDesirable.ConvertToInt()
                   + myDto.IInterventionDesirable.ConvertToInt()
                   + myDto.THInterventionDesirable.ConvertToInt()
                   + myDto.HIInterventionDesirable.ConvertToInt();
        }

        public static int GetDesirableInterventions(this WoodlandconditionsubsectionDTO myDto)
        {
            return myDto.InterventionDesirable.GetValueOrDefault().ConvertToInt()
                   + myDto.TAInterventionDesirable.ConvertToInt()
                   + myDto.TSInterventionDesirable.ConvertToInt()
                   + myDto.SSInterventionDesirable.ConvertToInt()
                   + myDto.LTRInterventionDesirable.ConvertToInt()
                   + myDto.LSRInterventionDesirable.ConvertToInt()
                   + myDto.RTSInterventionDesirable.ConvertToInt()
                   + myDto.RSSInterventionDesirable.ConvertToInt()
                   + myDto.FInterventionDesirable.ConvertToInt()
                   + myDto.DInterventionDesirable.ConvertToInt()
                   + myDto.ADInterventionDesirable.ConvertToInt()
                   + myDto.IInterventionDesirable.ConvertToInt()
                   + myDto.THInterventionDesirable.ConvertToInt()
                   + myDto.HIInterventionDesirable.ConvertToInt();
        }

        public static int GetTotalNoOfPlots(this WoodlandconditionsubsectionDTO myDto)
        {
            return

                myDto.TAPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.TAPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.TAPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.TAPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.TAPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.TSPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.TSPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.TSPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.TSPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.TSPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.SSPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.SSPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.SSPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.SSPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.SSPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.LTRPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.LTRPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.LTRPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.LTRPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.LTRPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.LSRPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.LSRPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.LSRPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.LSRPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.LSRPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.RTSPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.RTSPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.RTSPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.RTSPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.RTSPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.RSSPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.RSSPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.RSSPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.RSSPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.RSSPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.FPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.FPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.FPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.FPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.FPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.DPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.DPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.DPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.DPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.DPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.ADPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.ADPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.ADPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.ADPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.ADPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.IPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.IPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.IPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.IPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.IPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.THPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.THPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.THPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.THPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.THPlot5.GetValueOrDefault().ConvertToInt()
                + myDto.HIPlot1.GetValueOrDefault().ConvertToInt()
                + myDto.HIPlot2.GetValueOrDefault().ConvertToInt()
                + myDto.HIPlot3.GetValueOrDefault().ConvertToInt()
                + myDto.HIPlot4.GetValueOrDefault().ConvertToInt()
                + myDto.HIPlot5.GetValueOrDefault().ConvertToInt();
            
        }
    }
}