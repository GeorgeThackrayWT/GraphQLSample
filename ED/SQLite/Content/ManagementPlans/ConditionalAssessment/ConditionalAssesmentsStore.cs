using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using DataObjects.DTOS.ManagementPlans.SearchScreens;
using EDCORE.ViewModel;
using SQLite.DataTypes;
using Stores;

namespace SQLite
{


    public class ConditionalAssesmentsStore : BaseStore, IConditionalAssessmentsStore
    {
        public ConditionalAssesmentsStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public void UpdateCafkfSummaries(int Id, CafkfSummaries cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CAFOverallDTO GetCafOverallDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCAFOverallDTO(int Id, CAFOverallDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetCAStratums()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetCAKeyFeatures(int filter)
        {
            throw new NotImplementedException();
        }

        public CafStrataSummaryDto GetCAFStrataSummaryDTO(int featureMonitoringID)
        {

            var featureTypeLookupStr = @"SELECT f.ID as ID, ft.Description
                                        FROM  Feature f 
                                        JOIN FeatureType ft on f.TypeID= ft.ID";

            var cAFStrataSummaryDTO = new CafStrataSummaryDto();

            var sqlString = @"SELECT fm.ID
                              FROM  FeatureMonitoring fm
                              JOIN Feature f
                              on fm.FeatureID = f.ID 
                              where f.Reference ='F97' 
                              and fm.ID = " + featureMonitoringID;


            //KeyFeatureCADTO

            var featureLookup = _sqLiteSyncConnection.Query<KeyFeatureCADTO>(featureTypeLookupStr).ToList();


            var IDs = _sqLiteSyncConnection.Query<FeatureMonitoring>(sqlString).ToList();

            var stratum = _sqLiteSyncConnection.Table<WoodlandConditionStratum>().ToList();


            var list = IDs.Select(p => p.ID).ToList();

            var conditions = _sqLiteSyncConnection.Table<WoodlandConditionSubSection>().Where(f => list.Contains(f.FeatureMonitoringID)).ToList();

            cAFStrataSummaryDTO.CafSummaryObjsList = new List<CAFSummaryObjDTO>();

            foreach (var con in conditions)
            {

                string strataDesc = "Not Applicable";

                var slookup = stratum.FirstOrDefault(f => f.ID == con.StratumID.GetValueOrDefault());

                if (slookup != null)
                {
                    strataDesc = slookup.Description;
                }



                string featureDescription = "Not Applicable";


                var flookup = featureLookup.FirstOrDefault(f => f.ID == con.KeyFeatureID.GetValueOrDefault());

                if (flookup != null)
                {
                    featureDescription = flookup.Description;
                }


                var cafContainer = new CAFSummaryObjDTO()
                {
                    WoodlandConditionSubSectionID = con.ID,
                    StratumID = con.StratumID.GetValueOrDefault(),
                    WholeSite = con.WholeSite,
                    StratumDescription = strataDesc,
                    KeyFeatureID = con.KeyFeatureID.GetValueOrDefault(),
                    FeatureDescription = featureDescription,
                    NoOfPlots = 0,
                    OverallInterventionDesirable = con.OverallInterventionDesirable,
                    OverallInterventionAchievable = con.OverallInterventionAchievable,
                    OverallConclusionsAndRecommendations = con.OverallConclusionsAndRecommendations,

                    InterventionDesirable = con.InterventionDesirable,
                    InterventionAchievable = con.InterventionAchievable,
                    NotesAction = con.NotesAction,

                    TAInterventionDesirable = con.TAInterventionDesirable,
                    TAInterventionAchievable = con.TAInterventionAchievable,
                    TANotesActions = con.TANotesActions,

                    TSInterventionDesirable = con.TSInterventionDesirable,
                    TSInterventionAchievable = con.TSInterventionAchievable,
                    TSNotesActions = con.TSNotesActions,

                    SSInterventionDesirable = con.SSInterventionDesirable,
                    SSInterventionAchievable = con.SSInterventionAchievable,
                    SSNotesActions = con.SSNotesActions,

                    LTRInterventionDesirable = con.LTRInterventionDesirable,
                    LTRInterventionAchievable = con.LTRInterventionAchievable,
                    LTRNotesActions = con.LTRNotesActions,

                    LSRInterventionDesirable = con.LSRInterventionDesirable,
                    LSRInterventionAchievable = con.LSRInterventionAchievable,
                    LSRNotesActions = con.LSRNotesActions,

                    RTSInterventionDesirable = con.RTSInterventionDesirable,
                    RTSInterventionAchievable = con.RTSInterventionAchievable,
                    RTSNotesActions = con.RTSNotesActions,

                    RSSInterventionDesirable = con.RSSInterventionDesirable,
                    RSSInterventionAchievable = con.RSSInterventionAchievable,
                    RSSNotesActions = con.RSSNotesActions,

                    FInterventionDesirable = con.FInterventionDesirable,
                    FInterventionAchievable = con.FInterventionAchievable,
                    FNotesActions = con.FNotesActions,

                    DInterventionDesirable = con.DInterventionDesirable,
                    DInterventionAchievable = con.DInterventionAchievable,
                    DNotesActions = con.DNotesActions,

                    ADInterventionDesirable = con.ADInterventionDesirable,
                    ADInterventionAchievable = con.ADInterventionAchievable,
                    ADNotesActions = con.ADNotesActions,

                    IInterventionDesirable = con.IInterventionDesirable,
                    IInterventionAchievable = con.IInterventionAchievable,
                    INotesActions = con.INotesActions,

                    THInterventionDesirable = con.THInterventionDesirable,
                    THInterventionAchievable = con.THInterventionAchievable,
                    THNotesActions = con.THNotesActions,

                    HIInterventionDesirable = con.HIInterventionDesirable,
                    HIInterventionAchievable = con.HIInterventionAchievable,
                    HINotesActions = con.HINotesActions,


                };


                cAFStrataSummaryDTO.CafSummaryObjsList.Add(cafContainer);
            }
            


            return cAFStrataSummaryDTO;
        }

        public void UpdateCATDeadWoodDTO(int Id, CATDeadWoodDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATAnimalDamageDTO GetCatAnimalDamageDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATAnimalDamageDTO(int Id, CATAnimalDamageDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATFloraDTO(int Id, CATFloraDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATDeadWoodDTO GetCatDeadWoodDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATRegenerationShrubSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATFloraDTO GetCatFloraDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATTreeHealthDTO(int Id, CATTreeHealthDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATHumanImpactsDTO GetCatHumanImpactsDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATHumanImpactsDTO(int Id, CATHumanImpactsDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATInvasivesDTO GetCatInvasivesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATInvasivesDTO(int Id, CATInvasivesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATShrubSpeciesDTO(int Id, CATShrubSpeciesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATLevelOfShrubRegenerationDTO GetCatLevelOfShrubRegenerationDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATLevelOfShrubRegenerationDTO(int Id, CATLevelOfShrubRegenerationDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATLevelOfTreeRegenerationDTO GetCatLevelOfTreeRegenerationDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATLevelOfTreeRegenerationDTO(int Id, CATLevelOfTreeRegenerationDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATRegenerationTreeSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATRegenerationTreeSpeciesDTO GetCatRegenerationShrubSpeciesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public CATRegenerationTreeSpeciesDTO GetCatRegenerationTreeSpeciesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATTreeSpeciesDTO(int Id, CATTreeSpeciesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATShrubSpeciesDTO GetCatShrubSpeciesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public CATTreeAgesDTO GetCatTreeAgesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCATTreeAgesDTO(int Id, CATTreeAgesDTO cafkfSummaries)
        {
            throw new NotImplementedException();
        }

        public CATTreeHealthDTO GetCatTreeHealthDto(int Id)
        {
            throw new NotImplementedException();
        }

        public CATTreeSpeciesDTO GetCatTreeSpeciesDto(int Id)
        {
            throw new NotImplementedException();
        }

        public List<WoodlandSubsectionDto> GetCFContainerCollection(int featureMonitoringId)
        {

          //  managementUnitID = 4951;
 
            return new List<WoodlandSubsectionDto>();
        }

        public void UpdateCFContainerCollection(int managementUnitId, int featureMonitoringId, List<WoodlandSubsectionDto> editSet)
        {
            throw new NotImplementedException();
        }

        public ConditionAssessmentEditorDto GetConditionAssessmentEditorDto(int managementUnitID)
        {
            ConditionAssessmentEditorDto conditionalAssessmentDTO = new ConditionAssessmentEditorDto();

            string magicString = @"select fm.ID AS FeatureMonitoringID,
                                    FeatureID,
                                    f.Description,
                                    w.ID AS WoodlandConditionExtensionID,
                                    fm.PlannedObservationDate,
                                    fm.ActualObservationDate,
                                    fm.DeadlineActionDate ,
                                    fm.ActualActionDate,
                                    fm.PredictionShortTermObjective,
                                    fm.ActualObservation,
                                    fm.PlannedObservation,
                                    fm.SuggestionsAndActions,
                                    w.Surveyor,
                                    w.AreaHa,
                                    w.AreaAWHa,
                                    w.ChangeInAreaAWSinceLastSurveyHa,
                                    w.ChangeInAreaSinceLastSurveyHa,
                                    w.OverallDesirable,
                                    w.OverallAchievable,
                                    w.ConclusionsAndRecommendations,
                                    f.ManagementUnitID
                                    FROM            Feature AS f INNER JOIN
                                                            FeatureMonitoring AS fm ON f.ID = fm.FeatureID LEFT OUTER JOIN
                                                             WoodlandConditionExtension AS w ON fm.ID = w.FeatureMonitoringID
                                    WHERE  ([Description] = 'Condition Assessment' or [Description] = 'Woodland Condition' ) AND f.ManagementUnitID = " + managementUnitID +
                                 " order by PlannedObservationDate";

            var conditions = _sqLiteSyncConnection.Query<ConditionAssessmentEditorEntryDto>(magicString).ToList();

            conditionalAssessmentDTO.ConditionAssessmentList = conditions;

            if (conditionalAssessmentDTO.ConditionAssessmentList.Count == 0)
            {
                conditionalAssessmentDTO.ConditionAssessmentList.Add(new ConditionAssessmentEditorEntryDto());
            }
            return conditionalAssessmentDTO;
        }

        public List<ConditionAssessmentListDTO> GetConditionAssessmentListDtos()
        {
            //which also doesnt work 
            #region idiot select query that needs turning into c# at some point
            string magicString = "SELECT id, " +
                                 "\r\n       featuremonitoringid, " +
                                 "\r\n       wholesite, " +
                                 "\r\n       keyfeatureid, " +
                                 "\r\n       stratumid, " +
                                 "\r\n       stratumdescription, " +
                                 "\r\n       overallinterventiondesirable, " +
                                 "\r\n       overallinterventionachievable, " +
                                 "\r\n       overallconclusionsandrecommendations, " +
                                 "\r\n       totaltreecanopycoverpercentcurrent, " +
                                 "\r\n       totaltreecanopycoverpercentmin, " +
                                 "\r\n       totaltreecanopycoverpercentmax, " +
                                 "\r\n       openspaceseminaturalhabitatpercentcurrent, " +
                                 "\r\n       openspaceseminaturalhabitatpercentmin," +
                                 " \r\n       openspaceseminaturalhabitatpercentmax, " +
                                 "\r\n       openspaceridespercentcurrent, " +
                                 "\r\n       openspaceridespercentmin, " +
                                 "\r\n       openspaceridespercentmax, " +
                                 "\r\n       openspacetemporarypercentcurrent, " +
                                 "\r\n       openspacetemporarypercentmin, " +
                                 "\r\n       openspacetemporarypercentmax, " +
                                 "\r\n       openspacewaterfeaturespercentcurrent, " +
                                 "\r\n       openspacewaterfeaturespercentmin, " +
                                 "\r\n       openspacewaterfeaturespercentmax, " +
                                 "\r\n       shrubcoverpercentcurrent, " +
                                 "\r\n       shrubcoverpercentmin, " +
                                 "\r\n       shrubcoverpercentmax, " +
                                 "\r\n       interventiondesirable, " +
                                 "\r\n       interventionachievable, " +
                                 "\r\n       notesaction, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsid, 0) | ifnull( " +
                                 "\r\n            ta100_200yearsid, 0) " +
                                 "\r\n            | ifnull(ta50_100yearsid, 0) | ifnull(ta20_50yearsid, 0) | " +
                                 "\r\n                 ifnull(ta20yearsid, 0) AS BIT) " +
                                 "\r\n       AS TAOverall, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsplot1id, 0) | ifnull( " +
                                 "\r\n                 ta100_200yearsplot1id, 0) | ifnull(ta50_100yearsplot1id, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ta20_50yearsplot1id, 0) | ifnull(ta20yearsplot1id, 0) AS BIT) " +
                                 "\r\n       AS " +
                                 "\r\n       TAPlot1, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsplot2id, 0) | ifnull( " +
                                 "\r\n                 ta100_200yearsplot2id, 0) | ifnull(ta50_100yearsplot2id, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ta20_50yearsplot2id, 0) | ifnull(ta20yearsplot2id, 0) AS BIT) " +
                                 "\r\n       AS " +
                                 "\r\n       TAPlot2, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsplot3id, 0) | ifnull( " +
                                 "\r\n                 ta100_200yearsplot3id, 0) | ifnull(ta50_100yearsplot3id, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ta20_50yearsplot3id, 0) | ifnull(ta20yearsplot3id, 0) AS BIT) " +
                                 "\r\n       AS " +
                                 "\r\n       TAPlot3, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsplot4id, 0) | ifnull( " +
                                 "\r\n                 ta100_200yearsplot4id, 0) | ifnull(ta50_100yearsplot4id, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ta20_50yearsplot4id, 0) | ifnull(ta20yearsplot4id, 0) AS BIT) " +
                                 "\r\n       AS " +
                                 "\r\n       TAPlot4, " +
                                 "\r\n       Cast(ifnull(taveteranpollardsancientcoppicestoolsplot5id, 0) | ifnull( " +
                                 "\r\n                 ta100_200yearsplot5id, 0) | ifnull(ta50_100yearsplot5id, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ta20_50yearsplot5id, 0) | ifnull(ta20yearsplot5id, 0) AS BIT) " +
                                 "\r\n       AS " +
                                 "\r\n       TAPlot5, " +
                                 "\r\n       tainterventiondesirable, " +
                                 "\r\n       tainterventionachievable, " +
                                 "\r\n       tanotesactions, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresent, 0) | " +
                                 "\r\n            ifnull(tsnonnativesnumberpresent, 0) AS " +
                                 "\r\n            BIT) " +
                                 "\r\n       AS TSOverall, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresentplot1, 0) | " +
                                 "\r\n                 ifnull(tsnonnativesnumberpresentplot1, 0) AS BIT) " +
                                 "\r\n       AS TSPlot1, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresentplot2, 0) | " +
                                 "\r\n                 ifnull(tsnonnativesnumberpresentplot2, 0) AS BIT) " +
                                 "\r\n       AS TSPlot2, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresentplot3, 0) | " +
                                 "\r\n                 ifnull(tsnonnativesnumberpresentplot3, 0) AS BIT) " +
                                 "\r\n       AS TSPlot3, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresentplot4, 0) | " +
                                 "\r\n                 ifnull(tsnonnativesnumberpresentplot4, 0) AS BIT) " +
                                 "\r\n       AS TSPlot4, " +
                                 "\r\n       Cast(ifnull(tsnativesnumberpresentplot5, 0) | " +
                                 "\r\n                 ifnull(tsnonnativesnumberpresentplot5, 0) AS BIT) " +
                                 "\r\n       AS TSPlot5, " +
                                 "\r\n       tscanopydominatedbyoneortwospp, " +
                                 "\r\n       tsinterventiondesirable, " +
                                 "\r\n       tsinterventionachievable, " +
                                 "\r\n       tsnotesactions, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresent, 0) | " +
                                 "\r\n            ifnull(ssnonnativesnumberpresent, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverid, 0) AS BIT) " +
                                 "\r\n       AS SSOverall, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresentplot1, 0) | " +
                                 "\r\n                 ifnull(ssnonnativesnumberpresentplot1, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverplot1id, 0) AS BIT) " +
                                 "\r\n       AS SSPlot1, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresentplot2, 0) | " +
                                 "\r\n                 ifnull(ssnonnativesnumberpresentplot2, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverplot2id, 0) AS BIT) " +
                                 "\r\n       AS SSPlot2, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresentplot3, 0) | " +
                                 "\r\n                 ifnull(ssnonnativesnumberpresentplot3, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverplot3id, 0) AS BIT) " +
                                 "\r\n       AS SSPlot3, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresentplot4, 0) | " +
                                 "\r\n                 ifnull(ssnonnativesnumberpresentplot4, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverplot4id, 0) AS BIT) " +
                                 "\r\n       AS SSPlot4, " +
                                 "\r\n       Cast(ifnull(ssnativesnumberpresentplot5, 0) | " +
                                 "\r\n                 ifnull(ssnonnativesnumberpresentplot5, 0) | " +
                                 "\r\n                 ifnull(ssdaforofcoverplot5id, 0) AS BIT) " +
                                 "\r\n       AS SSPlot5, " +
                                 "\r\n       ssshrublayerdominatedbyoneortwospp, " +
                                 "\r\n       ssinterventiondesirable, " +
                                 "\r\n       ssinterventionachievable, " +
                                 "\r\n       ssnotesactions, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmid, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmid, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 ltrsaplingsgreater100cmid, 0) | ifnull( " +
                                 "\r\n            ltrcoppiceregrowthorsuckeringid " +
                                 "\r\n                                                 , 0) AS BIT) " +
                                 "\r\n       AS LTROverall, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmplot1id, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmplot1id, 0) " +
                                 "\r\n            | ifnull(ltrsaplingsgreater100cmplot1id, 0) | ifnull( " +
                                 "\r\n                 ltrcoppiceregrowthorsuckeringplot1id, 0) AS BIT) " +
                                 "\r\n       AS LTRPlot1, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmplot2id, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmplot2id, 0) " +
                                 "\r\n            | ifnull(ltrsaplingsgreater100cmplot2id, 0) | ifnull( " +
                                 "\r\n                 ltrcoppiceregrowthorsuckeringplot2id, 0) AS BIT) " +
                                 "\r\n       AS LTRPlot2, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmplot3id, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmplot3id, 0) " +
                                 "\r\n            | ifnull(ltrsaplingsgreater100cmplot3id, 0) | ifnull( " +
                                 "\r\n                 ltrcoppiceregrowthorsuckeringplot3id, 0) AS BIT) " +
                                 "\r\n       AS LTRPlot3, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmplot4id, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmplot4id, 0) " +
                                 "\r\n            | ifnull(ltrsaplingsgreater100cmplot4id, 0) | ifnull( " +
                                 "\r\n                 ltrcoppiceregrowthorsuckeringplot4id, 0) AS BIT) " +
                                 "\r\n       AS LTRPlot4, " +
                                 "\r\n       Cast(ifnull(ltrseedlingsless10cmplot5id, 0) | " +
                                 "\r\n            ifnull(ltrseedlings10_100cmplot5id, 0) " +
                                 "\r\n            | ifnull(ltrsaplingsgreater100cmplot5id, 0) | ifnull( " +
                                 "\r\n                 ltrcoppiceregrowthorsuckeringplot5id, 0) AS BIT) " +
                                 "\r\n       AS LTRPlot5, " +
                                 "\r\n       ltrinterventiondesirable, " +
                                 "\r\n       ltrinterventionachievable, " +
                                 "\r\n       ltrnotesactions, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmid, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmid, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 lsrsaplingsgreater100cmid, 0) | ifnull( " +
                                 "\r\n            lsrcoppiceregrowthorsuckeringid " +
                                 "\r\n                                                 , 0) AS BIT) " +
                                 "\r\n       AS LSROverall, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmplot1id, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmplot1id, 0) " +
                                 "\r\n            | ifnull(lsrsaplingsgreater100cmplot1id, 0) | ifnull( " +
                                 "\r\n                 lsrcoppiceregrowthorsuckeringplot1id, 0) AS BIT) " +
                                 "\r\n       AS LSRPlot1, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmplot2id, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmplot2id, 0) " +
                                 "\r\n            | ifnull(lsrsaplingsgreater100cmplot2id, 0) | ifnull( " +
                                 "\r\n                 lsrcoppiceregrowthorsuckeringplot2id, 0) AS BIT) " +
                                 "\r\n       AS LSRPlot2, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmplot3id, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmplot3id, 0) " +
                                 "\r\n            | ifnull(lsrsaplingsgreater100cmplot3id, 0) | ifnull(" +
                                 "\r\n                 lsrcoppiceregrowthorsuckeringplot3id, 0) AS BIT) " +
                                 "\r\n       AS LSRPlot3, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmplot4id, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmplot4id, 0) " +
                                 "\r\n            | ifnull(lsrsaplingsgreater100cmplot4id, 0) | ifnull( " +
                                 "\r\n                 lsrcoppiceregrowthorsuckeringplot4id, 0) AS BIT) " +
                                 "\r\n       AS LSRPlot4, " +
                                 "\r\n       Cast(ifnull(lsrseedlingsless10cmplot5id, 0) | " +
                                 "\r\n            ifnull(lsrseedlings10_100cmplot5id, 0) " +
                                 "\r\n            | ifnull(lsrsaplingsgreater100cmplot5id, 0) | ifnull( " +
                                 "\r\n                 lsrcoppiceregrowthorsuckeringplot5id, 0) AS BIT) " +
                                 "\r\n       AS LSRPlot5, " +
                                 "\r\n       lsrinterventiondesirable, " +
                                 "\r\n       lsrinterventionachievable, " +
                                 "\r\n       lsrnotesactions, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresent, 0) | ifnull( " +
                                 "\r\n            rtsnonnativesnumberpresent, 0) " +
                                 "\r\n            AS " +
                                 "\r\n            BIT) " +
                                 "\r\n       AS RTSOverall, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresentplot1, 0) | " +
                                 "\r\n                 ifnull(rtsnonnativesnumberpresentplot1, 0) AS BIT) " +
                                 "\r\n       AS RTSPlot1, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresentplot2, 0) | " +
                                 "\r\n                 ifnull(rtsnonnativesnumberpresentplot2, 0) AS BIT) " +
                                 "\r\n       AS RTSPlot2, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresentplot3, 0) | " +
                                 "\r\n                 ifnull(rtsnonnativesnumberpresentplot3, 0) AS BIT) " +
                                 "\r\n       AS RTSPlot3, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresentplot4, 0) | " +
                                 "\r\n                 ifnull(rtsnonnativesnumberpresentplot4, 0) AS BIT) " +
                                 "\r\n       AS RTSPlot4, " +
                                 "\r\n       Cast(ifnull(rtsnativesnumberpresentplot5, 0) | " +
                                 "\r\n                 ifnull(rtsnonnativesnumberpresentplot5, 0) AS BIT) " +
                                 "\r\n       AS RTSPlot5, " +
                                 "\r\n       rtsinterventiondesirable, " +
                                 "\r\n       rtsinterventionachievable, " +
                                 "\r\n       rtsnotesactions, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresent, 0) | ifnull( " +
                                 "\r\n            rssnonnativesnumberpresent, 0) " +
                                 "\r\n            AS " +
                                 "\r\n            BIT) " +
                                 "\r\n       AS RSSOverall, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresentplot1, 0) | " +
                                 "\r\n                 ifnull(rssnonnativesnumberpresentplot1, 0) AS BIT) " +
                                 "\r\n       AS RSSPlot1, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresentplot2, 0) | " +
                                 "\r\n                 ifnull(rssnonnativesnumberpresentplot2, 0) AS BIT) " +
                                 "\r\n       AS RSSPlot2, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresentplot3, 0) | " +
                                 "\r\n                 ifnull(rssnonnativesnumberpresentplot3, 0) AS BIT) " +
                                 "\r\n       AS RSSPlot3, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresentplot4, 0) | " +
                                 "\r\n                 ifnull(rssnonnativesnumberpresentplot4, 0) AS BIT) " +
                                 "\r\n       AS RSSPlot4, " +
                                 "\r\n       Cast(ifnull(rssnativesnumberpresentplot5, 0) | " +
                                 "\r\n                 ifnull(rssnonnativesnumberpresentplot5, 0) AS BIT) " +
                                 "\r\n       AS RSSPlot5, " +
                                 "\r\n       rssinterventiondesirable, " +
                                 "\r\n       rssinterventionachievable, " +
                                 "\r\n       rssnotesactions, " +
                                 "\r\n       Cast(ifnull(fancientwoodlandplantsspecialistsid, 0) | ifnull( " +
                                 "\r\n                 fotherwoodlandplantsgeneralistsid, 0) | " +
                                 "\r\n            ifnull(fothernativeplantsid, 0) | " +
                                 "\r\n                 ifnull(fcoarsevegetationid, 0) | ifnull(fotherplantsid, 0) | " +
                                 "\r\n            ifnull( " +
                                 "\r\n                 fnovegetationid, 0) AS BIT) " +
                                 "\r\n       AS FOverall, " +
                                 "\r\n       Cast(ifnull(fancientwoodlandplantsspecialistsplot1id, 0) | ifnull( " +
                                 "\r\n                 fotherwoodlandplantsgeneralistsplot1id, 0) | ifnull( " +
                                 "\r\n                 fothernativeplantsplot1id, 0) | " +
                                 "\r\n            ifnull(fcoarsevegetationplot1id, 0) | " +
                                 "\r\n                 ifnull(fotherplantsplot1id, 0) | " +
                                 "\r\n            ifnull(fnovegetationplot1id, 0) AS " +
                                 "\r\n            BIT) " +
                                 "\r\n       AS FPlot1, " +
                                 "\r\n       Cast(ifnull(fancientwoodlandplantsspecialistsplot2id, 0) | ifnull( " +
                                 "\r\n                 fotherwoodlandplantsgeneralistsplot2id, 0) | ifnull( " +
                                 "\r\n                 fothernativeplantsplot2id, 0) | " +
                                 "\r\n            ifnull(fcoarsevegetationplot2id, 0) | " +
                                 "\r\n                 ifnull(fotherplantsplot2id, 0) | " +
                                 "\r\n            ifnull(fnovegetationplot2id, 0) AS " +
                                 "\r\n            BIT) " +
                                 "\r\n       AS FPlot2, " +
                                 "\r\n       Cast(ifnull(fancientwoodlandplantsspecialistsplot3id, 0) | ifnull( " +
                                 "\r\n                 fotherwoodlandplantsgeneralistsplot3id, 0) | ifnull( " +
                                 "\r\n                 fothernativeplantsplot3id, 0) | \r\n            ifnull(fcoarsevegetationplot3id, 0) | \r\n                 ifnull(fotherplantsplot3id, 0) | \r\n            " +
                                 "ifnull(fnovegetationplot3id, 0) AS \r\n            BIT) \r\n       AS FPlot3, \r\n       " +
                                 "Cast(ifnull(fancientwoodlandplantsspecialistsplot4id, 0) | ifnull( \r\n                 " +
                                 "fotherwoodlandplantsgeneralistsplot4id, 0) | ifnull( \r\n             " +
                                 "    fothernativeplantsplot4id, 0) | \r\n          " +
                                 "  ifnull(fcoarsevegetationplot4id, 0) | \r\n            " +
                                 "     ifnull(fotherplantsplot4id, 0) | \r\n         " +
                                 "   ifnull(fnovegetationplot4id, 0) AS \r\n            BIT) \r\n       AS FPlot4," +
                                 " \r\n       Cast(ifnull(fancientwoodlandplantsspecialistsplot5id, 0) | " +
                                 "ifnull( \r\n                 fotherwoodlandplantsgeneralistsplot5id, 0) | " +
                                 "ifnull( \r\n                 fothernativeplantsplot5id, 0) | \r\n            " +
                                 "ifnull(fcoarsevegetationplot5id, 0) | \r\n                 " +
                                 "ifnull(fotherplantsplot5id, 0) | \r\n            " +
                                 "ifnull(fnovegetationplot5id, 0) AS \r\n            BIT) \r\n       AS FPlot5," +
                                 " \r\n       finterventiondesirable, \r\n       " +
                                 "finterventionachievable, \r\n       " +
                                 "fnotesactions, \r\n       Cast(ifnull(dstandingid, 0) | ifnull(dfallenid, 0) AS BIT) \r\n       AS DOverall," +
                                 " \r\n       Cast(ifnull(dstandingplot1id, 0) | ifnull(dfallenplot1id, 0) AS BIT) \r\n       AS DPlot1, " +
                                 "\r\n       Cast(ifnull(dstandingplot2id, 0) | ifnull(dfallenplot2id, 0) AS BIT) \r\n       AS DPlot2," +
                                 " \r\n       Cast(ifnull(dstandingplot3id, 0) | ifnull(dfallenplot3id, 0) AS BIT) \r\n       AS DPlot3, " +
                                 "\r\n       Cast(ifnull(dstandingplot4id, 0) | ifnull(dfallenplot4id, 0) AS BIT) \r\n       AS DPlot4, " +
                                 "\r\n       Cast(ifnull(dstandingplot5id, 0) | ifnull(dfallenplot5id, 0) AS BIT) \r\n       AS DPlot5, " +
                                 "\r\n       dinterventiondesirable, \r\n       dinterventionachievable, \r\n       dnotesactions," +
                                 " \r\n       Cast(ifnull(adsquirrelsid, 0) | ifnull(addeerid, 0) | \r\n            " +
                                 "ifnull(adrabbitsid, 0) | \r\n            ifnull \r\n                 (adotherid, 0) AS BIT) \r\n       AS ADOverall," +
                                 " \r\n       Cast(ifnull(adsquirrelsplot1id, 0) | ifnull(addeerplot1id, 0) | " +
                                 "ifnull( \r\n                 adrabbitsplot1id, 0) | ifnull(adotherplot1id, 0) AS BIT) \r\n       AS ADPlot1," +
                                 " \r\n       Cast(ifnull(adsquirrelsplot2id, 0) | ifnull(addeerplot2id, 0) | ifnull( \r\n                 adrabbitsplot2id, 0) | ifnull(adotherplot2id, 0) AS BIT) \r\n       AS ADPlot2, \r\n       Cast(ifnull(adsquirrelsplot3id, 0) | ifnull(addeerplot3id, 0) | ifnull( \r\n                 adrabbitsplot3id, 0) | ifnull(adotherplot3id, 0) AS BIT) \r\n       AS ADPlot3, \r\n       Cast(ifnull(adsquirrelsplot4id, 0) | ifnull(addeerplot4id, 0) | ifnull( \r\n                 adrabbitsplot4id, 0) | ifnull(adotherplot4id, 0) AS BIT) \r\n       AS ADPlot4, \r\n       Cast(ifnull(adsquirrelsplot5id, 0) | ifnull(addeerplot5id, 0) | ifnull( \r\n                 adrabbitsplot5id, 0) | ifnull(adotherplot5id, 0) AS BIT) \r\n       AS ADPlot5, \r\n       adinterventiondesirable, \r\n       adinterventionachievable, \r\n       adnotesactions, \r\n       Cast(ifnull(irhododendronid, 0) | ifnull(ihimalayanbalsamid, 0) | ifnull( \r\n                 ijapaneseknotweedid, 0) | ifnull(iotherid, 0) AS BIT) \r\n       AS IOverall, \r\n       Cast(ifnull(irhododendronplot1id, 0) | ifnull(ihimalayanbalsamplot1id, 0) \r\n            | \r\n            ifnull( \r\n                 ijapaneseknotweedplot1id, 0) | ifnull(iotherplot1id, 0) AS BIT) \r\n       AS \r\n       IPlot1, \r\n       Cast(ifnull(irhododendronplot2id, 0) | ifnull(ihimalayanbalsamplot2id, 0) \r\n            | \r\n            ifnull( \r\n                 ijapaneseknotweedplot2id, 0) | ifnull(iotherplot2id, 0) AS BIT) \r\n       AS \r\n       IPlot2, \r\n       Cast(ifnull(irhododendronplot3id, 0) | ifnull(ihimalayanbalsamplot3id, 0) \r\n            | \r\n            ifnull( \r\n                 ijapaneseknotweedplot3id, 0) | ifnull(iotherplot3id, 0) AS BIT) \r\n       AS \r\n       IPlot3, \r\n       Cast(ifnull(irhododendronplot4id, 0) | ifnull(ihimalayanbalsamplot4id, 0) \r\n            | \r\n            ifnull( \r\n                 ijapaneseknotweedplot4id, 0) | ifnull(iotherplot4id, 0) AS BIT) \r\n       AS \r\n       IPlot4, \r\n       Cast(ifnull(irhododendronplot5id, 0) | ifnull(ihimalayanbalsamplot5id, 0) \r\n            | \r\n            ifnull( \r\n                 ijapaneseknotweedplot5id, 0) | ifnull(iotherplot5id, 0) AS BIT) \r\n       AS \r\n       IPlot5, \r\n       iinterventiondesirable, \r\n       iinterventionachievable, \r\n       inotesactions, \r\n       Cast(ifnull(thnotifiablepestordiseaseid, 0) | ifnull( \r\n            thotherdiseaseorpestid, 0) \r\n            AS \r\n            BIT) \r\n       AS THOverall, \r\n       Cast(ifnull(thnotifiablepestordiseaseplot1id, 0) | \r\n                 ifnull(thotherdiseaseorpestplot1id, 0) AS BIT) \r\n       AS THPlot1, \r\n       Cast(ifnull(thnotifiablepestordiseaseplot2id, 0) | \r\n                 ifnull(thotherdiseaseorpestplot2id, 0) AS BIT) \r\n       AS THPlot2, \r\n       Cast(ifnull(thnotifiablepestordiseaseplot3id, 0) | \r\n                 ifnull(thotherdiseaseorpestplot3id, 0) AS BIT) \r\n       AS THPlot3, \r\n       Cast(ifnull(thnotifiablepestordiseaseplot4id, 0) | \r\n                 ifnull(thotherdiseaseorpestplot4id, 0) AS BIT) \r\n       AS THPlot4, \r\n       Cast(ifnull(thnotifiablepestordiseaseplot5id, 0) | \r\n                 ifnull(thotherdiseaseorpestplot5id, 0) AS BIT) \r\n       AS THPlot5, \r\n       thinterventiondesirable, \r\n       thinterventionachievable, \r\n       thnotesactions, \r\n       Cast(ifnull(hioneoffimpactsid, 0) | ifnull(hicontinuousimpactsid, 0) AS \r\n            BIT) AS \r\n       HIOverall, \r\n       Cast(ifnull(hioneoffimpactsplot1id, 0) | ifnull( \r\n            hicontinuousimpactsplot1id, 0) \r\n            AS BIT) \r\n       AS HIPlot1, \r\n       Cast(ifnull(hioneoffimpactsplot2id, 0) | ifnull( \r\n            hicontinuousimpactsplot2id, 0) \r\n            AS BIT) \r\n       AS HIPlot2, \r\n       Cast(ifnull(hioneoffimpactsplot3id, 0) | ifnull( \r\n            hicontinuousimpactsplot3id, 0) \r\n            AS BIT) \r\n       AS HIPlot3, \r\n       Cast(ifnull(hioneoffimpactsplot4id, 0) | ifnull( \r\n            hicontinuousimpactsplot4id, 0) \r\n            AS BIT) \r\n       AS HIPlot4, \r\n       Cast(ifnull(hioneoffimpactsplot5id, 0) | ifnull( \r\n            hicontinuousimpactsplot5id, 0) \r\n            AS BIT) \r\n       AS HIPlot5, \r\n       hiinterventiondesirable, \r\n       hiinterventionachievable, \r\n       hinotesactions, \r\n       deleted, \r\n       isprotected, \r\n       ishistorical, \r\n       isdefaultvalue, " +
                                 "\r\n       lmdt, \r\n       lmuid, \r\n       crdt, \r\n       cruid, \r\n       dldt, \r\n       dluid \r\n" +
                                 "FROM   woodlandconditionsubsection AS s ";

            #endregion

            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetConditionAssessmentListDtos started");

            var returnList = new List<ConditionAssessmentListDTO>();

            //  var data = _sqLiteSyncConnection.Table<ManagementUnit>().ToList();
            var features = _sqLiteSyncConnection.Query<Feature>("SELECT ID,ManagementUnitID,Reference,Deleted FROM Feature").ToList();

            var featureMonitoring = _sqLiteSyncConnection.Query<FeatureMonitoring>("SELECT ID,FeatureID,ActualObservationDate,Deleted FROM FeatureMonitoring").ToList();

            var woodlandconditionsubsection = _sqLiteSyncConnection.Query<WoodlandconditionsubsectionDTO>(magicString).ToList();



            foreach (var v in _iCache.ManagementUnits.OrderBy(o=>o.Name))
            {

                ConditionAssessmentListDTO cdass = new ConditionAssessmentListDTO();

                var manu = _iCache.ManagementPlans.FirstOrDefault(p => p.Id == v.ManagementPlanId.GetValueOrDefault());

                // get features for management unit
                var managementUnitFeatures = features.Where(m => m.ManagementUnitID == v.Id && m.Reference == "F97" && !m.Deleted);


                int noInterventions = 0;
                int noDesirableInterventions = 0;
                int noTotalNoOfPlots = 0;
                int counditionCount = 0;
                bool wholeSite = false;
                int stratum = 0;
                //loop through features
                foreach (var feature in managementUnitFeatures)
                {

                    var featureMonitor =
                        featureMonitoring.Where(
                                fm => fm.FeatureID == feature.ID && fm.ActualObservationDate != null && !fm.Deleted)
                            .OrderBy(o => o.ActualObservationDate.GetValueOrDefault())
                            .FirstOrDefault();

                    counditionCount = featureMonitoring.Count(fm => fm.FeatureID == feature.ID && !fm.Deleted);

                    if (featureMonitor != null)
                    {
                        var subSections =
                            woodlandconditionsubsection.Where(w => w.FeatureMonitoringID == featureMonitor.ID);


                        foreach (var sub in subSections)
                        {


                            noInterventions = sub.GetAchievableInterventions();
                            noDesirableInterventions = sub.GetDesirableInterventions();
                            noTotalNoOfPlots = sub.GetTotalNoOfPlots();
                            wholeSite = sub.WholeSite;
                            stratum = sub.StratumID.GetValueOrDefault();
                        }

                    }
                    else
                    {
                        noInterventions = 0;
                        noDesirableInterventions = 0;
                        noTotalNoOfPlots = 0;
                    }
                }

                cdass.TotalNoOfPlots = noTotalNoOfPlots;
                cdass.DesirableInterventions = noDesirableInterventions;
                cdass.AchievableInterventions = noInterventions;
                cdass.NoOfConditionsAssessments = counditionCount;
                cdass.Name = v.Name;
                cdass.CostCentre = v.Id;
                cdass.WholeSite = wholeSite;
                cdass.NoOfStrata = stratum;
                cdass.Region = _iCache.RegionLookup[v.RegionId.GetValueOrDefault()];
                cdass.Manager = _iCache.UserLookup[v.WoodlandOfficerId];
                cdass.ManagementUnitID = v.Id;
                returnList.Add(cdass);
            }

            stopwatch.Stop();

            Debug.WriteLine("GetConditionAssessmentListDtos ended in: " + stopwatch.ElapsedMilliseconds);

            return returnList;
        }

        public CafkfSummaries GetKfSummaries(int featureMonitoringID)
        {
            var result = new CafkfSummaries();

            var woodExt = @"SELECT ID,ConclusionsAndRecommendations,OverallDesirable,OverallAchievable 
                              FROM WoodlandConditionExtension
                              WHERE FeatureMonitoringID = " + featureMonitoringID;

            var featStr = @"SELECT wc.ID,ft.Description AS StratumDescription, wc.OverallInterventionDesirable, wc.OverallInterventionAchievable, wc.OverallConclusionsAndRecommendations 
                                    FROM  WoodlandConditionSubSection wc
                                        JOIN  Feature f on wc.KeyFeatureID = f.ID
                                        JOIN FeatureType ft on f.TypeID= ft.ID
	                                    join FeatureMonitoring fm
	                                    ON wc.FeatureMonitoringID = fm.ID
		                                    WHERE wc.Deleted =0 AND					
		                                    wc.FeatureMonitoringID= " + featureMonitoringID;
 
            var woodlandConditionSubSections = _sqLiteSyncConnection.Query<WoodlandConditionSubSection>(featStr).ToList();

            var woodlandConditionSubSectionsExt = _sqLiteSyncConnection.Query<WoodlandConditionExtension>(woodExt).ToList();


            var summaries = new List<CafkfSummary>();


            foreach (var condition in woodlandConditionSubSections)
            {
                summaries.Add(new CafkfSummary()
                {
                    WoodlandConditionSubSectionId = condition.ID,
                    OverallInterventionAchievable = condition.OverallInterventionAchievable.GetValueOrDefault(),
                    OverallInterventionDesirable = condition.OverallInterventionAchievable.GetValueOrDefault(),
                    OverallConclusionsAndRecommendations = condition.OverallConclusionsAndRecommendations,
                    Description = condition.StratumDescription
                });
            }
            
            result.SummariesList = summaries;

            result.OverallSummary = new CafkfSummary();

            if (woodlandConditionSubSectionsExt.Count > 0)
            {
                result.OverallSummary.OverallConclusionsAndRecommendations =
                    woodlandConditionSubSectionsExt[0].ConclusionsAndRecommendations;
                result.OverallSummary.OverallInterventionAchievable =
                    woodlandConditionSubSectionsExt[0].OverallAchievable;
                result.OverallSummary.OverallInterventionDesirable =
                    woodlandConditionSubSectionsExt[0].OverallDesirable;                
            }

            return result;
        }

        List<ConditionAssessmentEditorEntryDto> IConditionalAssessmentsStore.GetConditionAssessmentEditorDto(int managementUnitID)
        {
            throw new NotImplementedException();
        }

        public void UpdateConditionAssessmentEditorEntryDtos(int managementUnitId, List<ConditionAssessmentEditorEntryDto> editSet)
        {
            throw new NotImplementedException();
        }

        public List<ConditionAssessmentListDTO> GetConditionAssessmentListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }
}