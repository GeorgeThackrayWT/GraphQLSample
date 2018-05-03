using System;

namespace EDC_Estate.Models.DB
{
    public partial class WoodlandConditionSubSection
    {
        public int Id { get; set; }
        public int FeatureMonitoringId { get; set; }
        public bool WholeSite { get; set; }
        public int? KeyFeatureId { get; set; }
        public int? StratumId { get; set; }
        public string StratumDescription { get; set; }
        public bool? OverallInterventionDesirable { get; set; }
        public bool? OverallInterventionAchievable { get; set; }
        public string OverallConclusionsAndRecommendations { get; set; }
        public int? TotalTreeCanopyCoverPercentCurrent { get; set; }
        public int? TotalTreeCanopyCoverPercentMin { get; set; }
        public int? TotalTreeCanopyCoverPercentMax { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentCurrent { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentMin { get; set; }
        public int? OpenSpaceSemiNaturalHabitatPercentMax { get; set; }
        public int? OpenSpaceRidesPercentCurrent { get; set; }
        public int? OpenSpaceRidesPercentMin { get; set; }
        public int? OpenSpaceRidesPercentMax { get; set; }
        public int? OpenSpaceTemporaryPercentCurrent { get; set; }
        public int? OpenSpaceTemporaryPercentMin { get; set; }
        public int? OpenSpaceTemporaryPercentMax { get; set; }
        public int? OpenSpaceWaterFeaturesPercentCurrent { get; set; }
        public int? OpenSpaceWaterFeaturesPercentMin { get; set; }
        public int? OpenSpaceWaterFeaturesPercentMax { get; set; }
        public int? ShrubCoverPercentCurrent { get; set; }
        public int? ShrubCoverPercentMin { get; set; }
        public int? ShrubCoverPercentMax { get; set; }
        public bool? InterventionDesirable { get; set; }
        public bool? InterventionAchievable { get; set; }
        public string NotesAction { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsId { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsPlot1Id { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsPlot2Id { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsPlot3Id { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsPlot4Id { get; set; }
        public int? TaveteranPollardsAncientCoppiceStoolsPlot5Id { get; set; }
        public int? Ta100200yearsId { get; set; }
        public int? Ta100200yearsPlot1Id { get; set; }
        public int? Ta100200yearsPlot2Id { get; set; }
        public int? Ta100200yearsPlot3Id { get; set; }
        public int? Ta100200yearsPlot4Id { get; set; }
        public int? Ta100200yearsPlot5Id { get; set; }
        public int? Ta50100yearsId { get; set; }
        public int? Ta50100yearsPlot1Id { get; set; }
        public int? Ta50100yearsPlot2Id { get; set; }
        public int? Ta50100yearsPlot3Id { get; set; }
        public int? Ta50100yearsPlot4Id { get; set; }
        public int? Ta50100yearsPlot5Id { get; set; }
        public int? Ta2050yearsId { get; set; }
        public int? Ta2050yearsPlot1Id { get; set; }
        public int? Ta2050yearsPlot2Id { get; set; }
        public int? Ta2050yearsPlot3Id { get; set; }
        public int? Ta2050yearsPlot4Id { get; set; }
        public int? Ta2050yearsPlot5Id { get; set; }
        public int? Ta20yearsId { get; set; }
        public int? Ta20yearsPlot1Id { get; set; }
        public int? Ta20yearsPlot2Id { get; set; }
        public int? Ta20yearsPlot3Id { get; set; }
        public int? Ta20yearsPlot4Id { get; set; }
        public int? Ta20yearsPlot5Id { get; set; }
        public bool TainterventionDesirable { get; set; }
        public bool TainterventionAchievable { get; set; }
        public string TanotesActions { get; set; }
        public int? TsnativesNumberPresent { get; set; }
        public int? TsnativesNumberPresentPlot1 { get; set; }
        public int? TsnativesNumberPresentPlot2 { get; set; }
        public int? TsnativesNumberPresentPlot3 { get; set; }
        public int? TsnativesNumberPresentPlot4 { get; set; }
        public int? TsnativesNumberPresentPlot5 { get; set; }
        public int? TsnonNativesNumberPresent { get; set; }
        public int? TsnonNativesNumberPresentPlot1 { get; set; }
        public int? TsnonNativesNumberPresentPlot2 { get; set; }
        public int? TsnonNativesNumberPresentPlot3 { get; set; }
        public int? TsnonNativesNumberPresentPlot4 { get; set; }
        public int? TsnonNativesNumberPresentPlot5 { get; set; }
        public bool TscanopyDominatedByOneOrTwoSpp { get; set; }
        public bool TscanopyDominatedByOneOrTwoSppplot1 { get; set; }
        public bool TscanopyDominatedByOneOrTwoSppplot2 { get; set; }
        public bool TscanopyDominatedByOneOrTwoSppplot3 { get; set; }
        public bool TscanopyDominatedByOneOrTwoSppplot4 { get; set; }
        public bool TscanopyDominatedByOneOrTwoSppplot5 { get; set; }
        public bool TsinterventionDesirable { get; set; }
        public bool TsinterventionAchievable { get; set; }
        public string TsnotesActions { get; set; }
        public int? SsnativesNumberPresent { get; set; }
        public int? SsnativesNumberPresentPlot1 { get; set; }
        public int? SsnativesNumberPresentPlot2 { get; set; }
        public int? SsnativesNumberPresentPlot3 { get; set; }
        public int? SsnativesNumberPresentPlot4 { get; set; }
        public int? SsnativesNumberPresentPlot5 { get; set; }
        public int? SsnonNativesNumberPresent { get; set; }
        public int? SsnonNativesNumberPresentPlot1 { get; set; }
        public int? SsnonNativesNumberPresentPlot2 { get; set; }
        public int? SsnonNativesNumberPresentPlot3 { get; set; }
        public int? SsnonNativesNumberPresentPlot4 { get; set; }
        public int? SsnonNativesNumberPresentPlot5 { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSpp { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSppplot1 { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSppplot2 { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSppplot3 { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSppplot4 { get; set; }
        public bool SsshrubLayerDominatedByOneOrTwoSppplot5 { get; set; }
        public int? SsdaforofCoverId { get; set; }
        public int? SsdaforofCoverPlot1Id { get; set; }
        public int? SsdaforofCoverPlot2Id { get; set; }
        public int? SsdaforofCoverPlot3Id { get; set; }
        public int? SsdaforofCoverPlot4Id { get; set; }
        public int? SsdaforofCoverPlot5Id { get; set; }
        public bool SsinterventionDesirable { get; set; }
        public bool SsinterventionAchievable { get; set; }
        public string SsnotesActions { get; set; }
        public int? LtrseedlingsLess10cmId { get; set; }
        public int? LtrseedlingsLess10cmPlot1Id { get; set; }
        public int? LtrseedlingsLess10cmPlot2Id { get; set; }
        public int? LtrseedlingsLess10cmPlot3Id { get; set; }
        public int? LtrseedlingsLess10cmPlot4Id { get; set; }
        public int? LtrseedlingsLess10cmPlot5Id { get; set; }
        public int? Ltrseedlings10100cmId { get; set; }
        public int? Ltrseedlings10100cmPlot1Id { get; set; }
        public int? Ltrseedlings10100cmPlot2Id { get; set; }
        public int? Ltrseedlings10100cmPlot3Id { get; set; }
        public int? Ltrseedlings10100cmPlot4Id { get; set; }
        public int? Ltrseedlings10100cmPlot5Id { get; set; }
        public int? LtrsaplingsGreater100cmId { get; set; }
        public int? LtrsaplingsGreater100cmPlot1Id { get; set; }
        public int? LtrsaplingsGreater100cmPlot2Id { get; set; }
        public int? LtrsaplingsGreater100cmPlot3Id { get; set; }
        public int? LtrsaplingsGreater100cmPlot4Id { get; set; }
        public int? LtrsaplingsGreater100cmPlot5Id { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringId { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringPlot1Id { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringPlot2Id { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringPlot3Id { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringPlot4Id { get; set; }
        public int? LtrcoppiceRegrowthOrSuckeringPlot5Id { get; set; }
        public bool LtrinterventionDesirable { get; set; }
        public bool LtrinterventionAchievable { get; set; }
        public string LtrnotesActions { get; set; }
        public int? LsrseedlingsLess10cmId { get; set; }
        public int? LsrseedlingsLess10cmPlot1Id { get; set; }
        public int? LsrseedlingsLess10cmPlot2Id { get; set; }
        public int? LsrseedlingsLess10cmPlot3Id { get; set; }
        public int? LsrseedlingsLess10cmPlot4Id { get; set; }
        public int? LsrseedlingsLess10cmPlot5Id { get; set; }
        public int? Lsrseedlings10100cmId { get; set; }
        public int? Lsrseedlings10100cmPlot1Id { get; set; }
        public int? Lsrseedlings10100cmPlot2Id { get; set; }
        public int? Lsrseedlings10100cmPlot3Id { get; set; }
        public int? Lsrseedlings10100cmPlot4Id { get; set; }
        public int? Lsrseedlings10100cmPlot5Id { get; set; }
        public int? LsrsaplingsGreater100cmId { get; set; }
        public int? LsrsaplingsGreater100cmPlot1Id { get; set; }
        public int? LsrsaplingsGreater100cmPlot2Id { get; set; }
        public int? LsrsaplingsGreater100cmPlot3Id { get; set; }
        public int? LsrsaplingsGreater100cmPlot4Id { get; set; }
        public int? LsrsaplingsGreater100cmPlot5Id { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringId { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringPlot1Id { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringPlot2Id { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringPlot3Id { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringPlot4Id { get; set; }
        public int? LsrcoppiceRegrowthOrSuckeringPlot5Id { get; set; }
        public bool LsrinterventionDesirable { get; set; }
        public bool LsrinterventionAchievable { get; set; }
        public string LsrnotesActions { get; set; }
        public int? RtsnativesNumberPresent { get; set; }
        public int? RtsnativesNumberPresentPlot1 { get; set; }
        public int? RtsnativesNumberPresentPlot2 { get; set; }
        public int? RtsnativesNumberPresentPlot3 { get; set; }
        public int? RtsnativesNumberPresentPlot4 { get; set; }
        public int? RtsnativesNumberPresentPlot5 { get; set; }
        public int? RtsnonNativesNumberPresent { get; set; }
        public int? RtsnonNativesNumberPresentPlot1 { get; set; }
        public int? RtsnonNativesNumberPresentPlot2 { get; set; }
        public int? RtsnonNativesNumberPresentPlot3 { get; set; }
        public int? RtsnonNativesNumberPresentPlot4 { get; set; }
        public int? RtsnonNativesNumberPresentPlot5 { get; set; }
        public bool RtsdominatedByOneOrTwoSpp { get; set; }
        public bool RtsdominatedByOneOrTwoSppplot1 { get; set; }
        public bool RtsdominatedByOneOrTwoSppplot2 { get; set; }
        public bool RtsdominatedByOneOrTwoSppplot3 { get; set; }
        public bool RtsdominatedByOneOrTwoSppplot4 { get; set; }
        public bool RtsdominatedByOneOrTwoSppplot5 { get; set; }
        public bool RtsinterventionDesirable { get; set; }
        public bool RtsinterventionAchievable { get; set; }
        public string RtsnotesActions { get; set; }
        public int? RssnativesNumberPresent { get; set; }
        public int? RssnativesNumberPresentPlot1 { get; set; }
        public int? RssnativesNumberPresentPlot2 { get; set; }
        public int? RssnativesNumberPresentPlot3 { get; set; }
        public int? RssnativesNumberPresentPlot4 { get; set; }
        public int? RssnativesNumberPresentPlot5 { get; set; }
        public int? RssnonNativesNumberPresent { get; set; }
        public int? RssnonNativesNumberPresentPlot1 { get; set; }
        public int? RssnonNativesNumberPresentPlot2 { get; set; }
        public int? RssnonNativesNumberPresentPlot3 { get; set; }
        public int? RssnonNativesNumberPresentPlot4 { get; set; }
        public int? RssnonNativesNumberPresentPlot5 { get; set; }
        public bool RssdominatedByOneOrTwoSpp { get; set; }
        public bool RssdominatedByOneOrTwoSppplot1 { get; set; }
        public bool RssdominatedByOneOrTwoSppplot2 { get; set; }
        public bool RssdominatedByOneOrTwoSppplot3 { get; set; }
        public bool RssdominatedByOneOrTwoSppplot4 { get; set; }
        public bool RssdominatedByOneOrTwoSppplot5 { get; set; }
        public bool RssinterventionDesirable { get; set; }
        public bool RssinterventionAchievable { get; set; }
        public string RssnotesActions { get; set; }
        public int? FancientWoodlandPlantsSpecialistsId { get; set; }
        public int? FancientWoodlandPlantsSpecialistsPlot1Id { get; set; }
        public int? FancientWoodlandPlantsSpecialistsPlot2Id { get; set; }
        public int? FancientWoodlandPlantsSpecialistsPlot3Id { get; set; }
        public int? FancientWoodlandPlantsSpecialistsPlot4Id { get; set; }
        public int? FancientWoodlandPlantsSpecialistsPlot5Id { get; set; }
        public int? FotherWoodlandPlantsGeneralistsId { get; set; }
        public int? FotherWoodlandPlantsGeneralistsPlot1Id { get; set; }
        public int? FotherWoodlandPlantsGeneralistsPlot2Id { get; set; }
        public int? FotherWoodlandPlantsGeneralistsPlot3Id { get; set; }
        public int? FotherWoodlandPlantsGeneralistsPlot4Id { get; set; }
        public int? FotherWoodlandPlantsGeneralistsPlot5Id { get; set; }
        public int? FotherNativePlantsId { get; set; }
        public int? FotherNativePlantsPlot1Id { get; set; }
        public int? FotherNativePlantsPlot2Id { get; set; }
        public int? FotherNativePlantsPlot3Id { get; set; }
        public int? FotherNativePlantsPlot4Id { get; set; }
        public int? FotherNativePlantsPlot5Id { get; set; }
        public int? FcoarseVegetationId { get; set; }
        public int? FcoarseVegetationPlot1Id { get; set; }
        public int? FcoarseVegetationPlot2Id { get; set; }
        public int? FcoarseVegetationPlot3Id { get; set; }
        public int? FcoarseVegetationPlot4Id { get; set; }
        public int? FcoarseVegetationPlot5Id { get; set; }
        public int? FotherPlantsId { get; set; }
        public int? FotherPlantsPlot1Id { get; set; }
        public int? FotherPlantsPlot2Id { get; set; }
        public int? FotherPlantsPlot3Id { get; set; }
        public int? FotherPlantsPlot4Id { get; set; }
        public int? FotherPlantsPlot5Id { get; set; }
        public int? FnoVegetationId { get; set; }
        public int? FnoVegetationPlot1Id { get; set; }
        public int? FnoVegetationPlot2Id { get; set; }
        public int? FnoVegetationPlot3Id { get; set; }
        public int? FnoVegetationPlot4Id { get; set; }
        public int? FnoVegetationPlot5Id { get; set; }
        public bool FinterventionDesirable { get; set; }
        public bool FinterventionAchievable { get; set; }
        public string FnotesActions { get; set; }
        public int? DstandingId { get; set; }
        public int? DstandingPlot1Id { get; set; }
        public int? DstandingPlot2Id { get; set; }
        public int? DstandingPlot3Id { get; set; }
        public int? DstandingPlot4Id { get; set; }
        public int? DstandingPlot5Id { get; set; }
        public int? DfallenId { get; set; }
        public int? DfallenPlot1Id { get; set; }
        public int? DfallenPlot2Id { get; set; }
        public int? DfallenPlot3Id { get; set; }
        public int? DfallenPlot4Id { get; set; }
        public int? DfallenPlot5Id { get; set; }
        public bool DinterventionDesirable { get; set; }
        public bool DinterventionAchievable { get; set; }
        public string DnotesActions { get; set; }
        public int? AdsquirrelsId { get; set; }
        public int? AdsquirrelsPlot1Id { get; set; }
        public int? AdsquirrelsPlot2Id { get; set; }
        public int? AdsquirrelsPlot3Id { get; set; }
        public int? AdsquirrelsPlot4Id { get; set; }
        public int? AdsquirrelsPlot5Id { get; set; }
        public int? AddeerId { get; set; }
        public int? AddeerPlot1Id { get; set; }
        public int? AddeerPlot2Id { get; set; }
        public int? AddeerPlot3Id { get; set; }
        public int? AddeerPlot4Id { get; set; }
        public int? AddeerPlot5Id { get; set; }
        public int? AdrabBitsId { get; set; }
        public int? AdrabBitsPlot1Id { get; set; }
        public int? AdrabBitsPlot2Id { get; set; }
        public int? AdrabBitsPlot3Id { get; set; }
        public int? AdrabBitsPlot4Id { get; set; }
        public int? AdrabBitsPlot5Id { get; set; }
        public int? AdotherId { get; set; }
        public int? AdotherPlot1Id { get; set; }
        public int? AdotherPlot2Id { get; set; }
        public int? AdotherPlot3Id { get; set; }
        public int? AdotherPlot4Id { get; set; }
        public int? AdotherPlot5Id { get; set; }
        public bool AdinterventionDesirable { get; set; }
        public bool AdinterventionAchievable { get; set; }
        public string AdnotesActions { get; set; }
        public int? IrhododendronId { get; set; }
        public int? IrhododendronPlot1Id { get; set; }
        public int? IrhododendronPlot2Id { get; set; }
        public int? IrhododendronPlot3Id { get; set; }
        public int? IrhododendronPlot4Id { get; set; }
        public int? IrhododendronPlot5Id { get; set; }
        public int? IhimalayanBalsamId { get; set; }
        public int? IhimalayanBalsamPlot1Id { get; set; }
        public int? IhimalayanBalsamPlot2Id { get; set; }
        public int? IhimalayanBalsamPlot3Id { get; set; }
        public int? IhimalayanBalsamPlot4Id { get; set; }
        public int? IhimalayanBalsamPlot5Id { get; set; }
        public int? IjapaneseKnotweedId { get; set; }
        public int? IjapaneseKnotweedPlot1Id { get; set; }
        public int? IjapaneseKnotweedPlot2Id { get; set; }
        public int? IjapaneseKnotweedPlot3Id { get; set; }
        public int? IjapaneseKnotweedPlot4Id { get; set; }
        public int? IjapaneseKnotweedPlot5Id { get; set; }
        public int? IotherId { get; set; }
        public int? IotherPlot1Id { get; set; }
        public int? IotherPlot2Id { get; set; }
        public int? IotherPlot3Id { get; set; }
        public int? IotherPlot4Id { get; set; }
        public int? IotherPlot5Id { get; set; }
        public bool IinterventionDesirable { get; set; }
        public bool IinterventionAchievable { get; set; }
        public string InotesActions { get; set; }
        public int? ThnotifiablePestOrDiseaseId { get; set; }
        public int? ThnotifiablePestOrDiseasePlot1Id { get; set; }
        public int? ThnotifiablePestOrDiseasePlot2Id { get; set; }
        public int? ThnotifiablePestOrDiseasePlot3Id { get; set; }
        public int? ThnotifiablePestOrDiseasePlot4Id { get; set; }
        public int? ThnotifiablePestOrDiseasePlot5Id { get; set; }
        public int? ThotherDiseaseOrPestId { get; set; }
        public int? ThotherDiseaseOrPestPlot1Id { get; set; }
        public int? ThotherDiseaseOrPestPlot2Id { get; set; }
        public int? ThotherDiseaseOrPestPlot3Id { get; set; }
        public int? ThotherDiseaseOrPestPlot4Id { get; set; }
        public int? ThotherDiseaseOrPestPlot5Id { get; set; }
        public bool ThinterventionDesirable { get; set; }
        public bool ThinterventionAchievable { get; set; }
        public string ThnotesActions { get; set; }
        public int? HioneOffImpactsId { get; set; }
        public int? HioneOffImpactsPlot1Id { get; set; }
        public int? HioneOffImpactsPlot2Id { get; set; }
        public int? HioneOffImpactsPlot3Id { get; set; }
        public int? HioneOffImpactsPlot4Id { get; set; }
        public int? HioneOffImpactsPlot5Id { get; set; }
        public int? HicontinuousImpactsId { get; set; }
        public int? HicontinuousImpactsPlot1Id { get; set; }
        public int? HicontinuousImpactsPlot2Id { get; set; }
        public int? HicontinuousImpactsPlot3Id { get; set; }
        public int? HicontinuousImpactsPlot4Id { get; set; }
        public int? HicontinuousImpactsPlot5Id { get; set; }
        public bool HiinterventionDesirable { get; set; }
        public bool HiinterventionAchievable { get; set; }
        public string HinotesActions { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual WoodlandConditionDafor Addeer { get; set; }
        public virtual WoodlandConditionDafor AddeerPlot1 { get; set; }
        public virtual WoodlandConditionDafor AddeerPlot2 { get; set; }
        public virtual WoodlandConditionDafor AddeerPlot3 { get; set; }
        public virtual WoodlandConditionDafor AddeerPlot4 { get; set; }
        public virtual WoodlandConditionDafor AddeerPlot5 { get; set; }
        public virtual WoodlandConditionDafor Adother { get; set; }
        public virtual WoodlandConditionDafor AdotherPlot1 { get; set; }
        public virtual WoodlandConditionDafor AdotherPlot2 { get; set; }
        public virtual WoodlandConditionDafor AdotherPlot3 { get; set; }
        public virtual WoodlandConditionDafor AdotherPlot4 { get; set; }
        public virtual WoodlandConditionDafor AdotherPlot5 { get; set; }
        public virtual WoodlandConditionDafor AdrabBits { get; set; }
        public virtual WoodlandConditionDafor AdrabBitsPlot1 { get; set; }
        public virtual WoodlandConditionDafor AdrabBitsPlot2 { get; set; }
        public virtual WoodlandConditionDafor AdrabBitsPlot3 { get; set; }
        public virtual WoodlandConditionDafor AdrabBitsPlot4 { get; set; }
        public virtual WoodlandConditionDafor AdrabBitsPlot5 { get; set; }
        public virtual WoodlandConditionDafor Adsquirrels { get; set; }
        public virtual WoodlandConditionDafor AdsquirrelsPlot1 { get; set; }
        public virtual WoodlandConditionDafor AdsquirrelsPlot2 { get; set; }
        public virtual WoodlandConditionDafor AdsquirrelsPlot3 { get; set; }
        public virtual WoodlandConditionDafor AdsquirrelsPlot4 { get; set; }
        public virtual WoodlandConditionDafor AdsquirrelsPlot5 { get; set; }
        public virtual WoodlandConditionDafor Dfallen { get; set; }
        public virtual WoodlandConditionDafor DfallenPlot1 { get; set; }
        public virtual WoodlandConditionDafor DfallenPlot2 { get; set; }
        public virtual WoodlandConditionDafor DfallenPlot3 { get; set; }
        public virtual WoodlandConditionDafor DfallenPlot4 { get; set; }
        public virtual WoodlandConditionDafor DfallenPlot5 { get; set; }
        public virtual WoodlandConditionDafor Dstanding { get; set; }
        public virtual WoodlandConditionDafor DstandingPlot1 { get; set; }
        public virtual WoodlandConditionDafor DstandingPlot2 { get; set; }
        public virtual WoodlandConditionDafor DstandingPlot3 { get; set; }
        public virtual WoodlandConditionDafor DstandingPlot4 { get; set; }
        public virtual WoodlandConditionDafor DstandingPlot5 { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialists { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialistsPlot1 { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialistsPlot2 { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialistsPlot3 { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialistsPlot4 { get; set; }
        public virtual WoodlandConditionDafor FancientWoodlandPlantsSpecialistsPlot5 { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetation { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetationPlot1 { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetationPlot2 { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetationPlot3 { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetationPlot4 { get; set; }
        public virtual WoodlandConditionDafor FcoarseVegetationPlot5 { get; set; }
        public virtual FeatureMonitoring FeatureMonitoring { get; set; }
        public virtual WoodlandConditionDafor FnoVegetation { get; set; }
        public virtual WoodlandConditionDafor FnoVegetationPlot1 { get; set; }
        public virtual WoodlandConditionDafor FnoVegetationPlot2 { get; set; }
        public virtual WoodlandConditionDafor FnoVegetationPlot3 { get; set; }
        public virtual WoodlandConditionDafor FnoVegetationPlot4 { get; set; }
        public virtual WoodlandConditionDafor FnoVegetationPlot5 { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlants { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlantsPlot1 { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlantsPlot2 { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlantsPlot3 { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlantsPlot4 { get; set; }
        public virtual WoodlandConditionDafor FotherNativePlantsPlot5 { get; set; }
        public virtual WoodlandConditionDafor FotherPlants { get; set; }
        public virtual WoodlandConditionDafor FotherPlantsPlot1 { get; set; }
        public virtual WoodlandConditionDafor FotherPlantsPlot2 { get; set; }
        public virtual WoodlandConditionDafor FotherPlantsPlot3 { get; set; }
        public virtual WoodlandConditionDafor FotherPlantsPlot4 { get; set; }
        public virtual WoodlandConditionDafor FotherPlantsPlot5 { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralists { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralistsPlot1 { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralistsPlot2 { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralistsPlot3 { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralistsPlot4 { get; set; }
        public virtual WoodlandConditionDafor FotherWoodlandPlantsGeneralistsPlot5 { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpacts { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpactsPlot1 { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpactsPlot2 { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpactsPlot3 { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpactsPlot4 { get; set; }
        public virtual WoodlandConditionDafor HicontinuousImpactsPlot5 { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpacts { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpactsPlot1 { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpactsPlot2 { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpactsPlot3 { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpactsPlot4 { get; set; }
        public virtual WoodlandConditionDafor HioneOffImpactsPlot5 { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsam { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsamPlot1 { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsamPlot2 { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsamPlot3 { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsamPlot4 { get; set; }
        public virtual WoodlandConditionDafor IhimalayanBalsamPlot5 { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweed { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweedPlot1 { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweedPlot2 { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweedPlot3 { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweedPlot4 { get; set; }
        public virtual WoodlandConditionDafor IjapaneseKnotweedPlot5 { get; set; }
        public virtual WoodlandConditionDafor Iother { get; set; }
        public virtual WoodlandConditionDafor IotherPlot1 { get; set; }
        public virtual WoodlandConditionDafor IotherPlot2 { get; set; }
        public virtual WoodlandConditionDafor IotherPlot3 { get; set; }
        public virtual WoodlandConditionDafor IotherPlot4 { get; set; }
        public virtual WoodlandConditionDafor IotherPlot5 { get; set; }
        public virtual WoodlandConditionDafor Irhododendron { get; set; }
        public virtual WoodlandConditionDafor IrhododendronPlot1 { get; set; }
        public virtual WoodlandConditionDafor IrhododendronPlot2 { get; set; }
        public virtual WoodlandConditionDafor IrhododendronPlot3 { get; set; }
        public virtual WoodlandConditionDafor IrhododendronPlot4 { get; set; }
        public virtual WoodlandConditionDafor IrhododendronPlot5 { get; set; }
        public virtual Feature KeyFeature { get; set; }
        public virtual User Lmu { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckering { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckeringPlot1 { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckeringPlot2 { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckeringPlot3 { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckeringPlot4 { get; set; }
        public virtual WoodlandConditionDafor LsrcoppiceRegrowthOrSuckeringPlot5 { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cm { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor LsrsaplingsGreater100cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cm { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor Lsrseedlings10100cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cm { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor LsrseedlingsLess10cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckering { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckeringPlot1 { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckeringPlot2 { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckeringPlot3 { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckeringPlot4 { get; set; }
        public virtual WoodlandConditionDafor LtrcoppiceRegrowthOrSuckeringPlot5 { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cm { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor LtrsaplingsGreater100cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cm { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor Ltrseedlings10100cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cm { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cmPlot1 { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cmPlot2 { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cmPlot3 { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cmPlot4 { get; set; }
        public virtual WoodlandConditionDafor LtrseedlingsLess10cmPlot5 { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCover { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCoverPlot1 { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCoverPlot2 { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCoverPlot3 { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCoverPlot4 { get; set; }
        public virtual WoodlandConditionDafor SsdaforofCoverPlot5 { get; set; }
        public virtual WoodlandConditionStratum Stratum { get; set; }
        public virtual WoodlandConditionDafor Ta100200years { get; set; }
        public virtual WoodlandConditionDafor Ta100200yearsPlot1 { get; set; }
        public virtual WoodlandConditionDafor Ta100200yearsPlot2 { get; set; }
        public virtual WoodlandConditionDafor Ta100200yearsPlot3 { get; set; }
        public virtual WoodlandConditionDafor Ta100200yearsPlot4 { get; set; }
        public virtual WoodlandConditionDafor Ta100200yearsPlot5 { get; set; }
        public virtual WoodlandConditionDafor Ta2050years { get; set; }
        public virtual WoodlandConditionDafor Ta2050yearsPlot1 { get; set; }
        public virtual WoodlandConditionDafor Ta2050yearsPlot2 { get; set; }
        public virtual WoodlandConditionDafor Ta2050yearsPlot3 { get; set; }
        public virtual WoodlandConditionDafor Ta2050yearsPlot4 { get; set; }
        public virtual WoodlandConditionDafor Ta2050yearsPlot5 { get; set; }
        public virtual WoodlandConditionDafor Ta20years { get; set; }
        public virtual WoodlandConditionDafor Ta20yearsPlot1 { get; set; }
        public virtual WoodlandConditionDafor Ta20yearsPlot2 { get; set; }
        public virtual WoodlandConditionDafor Ta20yearsPlot3 { get; set; }
        public virtual WoodlandConditionDafor Ta20yearsPlot4 { get; set; }
        public virtual WoodlandConditionDafor Ta20yearsPlot5 { get; set; }
        public virtual WoodlandConditionDafor Ta50100years { get; set; }
        public virtual WoodlandConditionDafor Ta50100yearsPlot1 { get; set; }
        public virtual WoodlandConditionDafor Ta50100yearsPlot2 { get; set; }
        public virtual WoodlandConditionDafor Ta50100yearsPlot3 { get; set; }
        public virtual WoodlandConditionDafor Ta50100yearsPlot4 { get; set; }
        public virtual WoodlandConditionDafor Ta50100yearsPlot5 { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStools { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStoolsPlot1 { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStoolsPlot2 { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStoolsPlot3 { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStoolsPlot4 { get; set; }
        public virtual WoodlandConditionDafor TaveteranPollardsAncientCoppiceStoolsPlot5 { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDisease { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDiseasePlot1 { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDiseasePlot2 { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDiseasePlot3 { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDiseasePlot4 { get; set; }
        public virtual WoodlandConditionDafor ThnotifiablePestOrDiseasePlot5 { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPest { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPestPlot1 { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPestPlot2 { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPestPlot3 { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPestPlot4 { get; set; }
        public virtual WoodlandConditionDafor ThotherDiseaseOrPestPlot5 { get; set; }
    }
}
