using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RDOS.BaseLine.RDOSInfratructure
{
    public partial class RDOSContext : DbContext
    {
        public RDOSContext()
        {
        }

        public RDOSContext(DbContextOptions<RDOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Actions { get; set; } = null!;
        public virtual DbSet<AdjustItemGroupPrice> AdjustItemGroupPrices { get; set; } = null!;
        public virtual DbSet<AdjustPriceListUoMitemGroup> AdjustPriceListUoMitemGroups { get; set; } = null!;
        public virtual DbSet<ApiMapping> ApiMappings { get; set; } = null!;
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<ApplicationAudit> ApplicationAudits { get; set; } = null!;
        public virtual DbSet<ApplicationInviteCode> ApplicationInviteCodes { get; set; } = null!;
        public virtual DbSet<ApplicationLanguagePack> ApplicationLanguagePacks { get; set; } = null!;
        public virtual DbSet<ApplicationLocalization> ApplicationLocalizations { get; set; } = null!;
        public virtual DbSet<ApplicationLocalizationHistory> ApplicationLocalizationHistories { get; set; } = null!;
        public virtual DbSet<ApplicationNotiDeviceToken> ApplicationNotiDeviceTokens { get; set; } = null!;
        public virtual DbSet<ApplicationNotiMessage> ApplicationNotiMessages { get; set; } = null!;
        public virtual DbSet<ApplicationNotiUrgent> ApplicationNotiUrgents { get; set; } = null!;
        public virtual DbSet<ApplicationOtpcode> ApplicationOtpcodes { get; set; } = null!;
        public virtual DbSet<ApplicationService> ApplicationServices { get; set; } = null!;
        public virtual DbSet<ApplicationThemesConfigure> ApplicationThemesConfigures { get; set; } = null!;
        public virtual DbSet<ApplicationThemesElement> ApplicationThemesElements { get; set; } = null!;
        public virtual DbSet<ApplicationThemesSetting> ApplicationThemesSettings { get; set; } = null!;
        public virtual DbSet<ApplicationThemesSuggestion> ApplicationThemesSuggestions { get; set; } = null!;
        public virtual DbSet<ApplicationUserMapping> ApplicationUserMappings { get; set; } = null!;
        public virtual DbSet<ApplicationVersion> ApplicationVersions { get; set; } = null!;
        public virtual DbSet<ApplicationVersionPrinciple> ApplicationVersionPrinciples { get; set; } = null!;
        public virtual DbSet<AsoRefResult> AsoRefResults { get; set; } = null!;
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<AutoKpisTarget> AutoKpisTargets { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetAchievementsCurrentYear> AutoKpisTargetAchievementsCurrentYears { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetAchievementsCurrentYearValue> AutoKpisTargetAchievementsCurrentYearValues { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetBusinessModel> AutoKpisTargetBusinessModels { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetBusinessModelValue> AutoKpisTargetBusinessModelValues { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetContributionBySic> AutoKpisTargetContributionBySics { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetContributionBySicValue> AutoKpisTargetContributionBySicValues { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetDevelopment> AutoKpisTargetDevelopments { get; set; } = null!;
        public virtual DbSet<AutoKpisTargetDevelopmentDetail> AutoKpisTargetDevelopmentDetails { get; set; } = null!;
        public virtual DbSet<BlAuditLog> BlAuditLogs { get; set; } = null!;
        public virtual DbSet<BlBlprocess> BlBlprocesses { get; set; } = null!;
        public virtual DbSet<BlBlsettingEmail> BlBlsettingEmails { get; set; } = null!;
        public virtual DbSet<BlBlsettingInformation> BlBlsettingInformations { get; set; } = null!;
        public virtual DbSet<BlBlsettingProcess> BlBlsettingProcesses { get; set; } = null!;
        public virtual DbSet<BlBlsettingProcessPending> BlBlsettingProcessPendings { get; set; } = null!;
        public virtual DbSet<BlBlsettingTransactionStatus> BlBlsettingTransactionStatuses { get; set; } = null!;
        public virtual DbSet<BlCloseStock> BlCloseStocks { get; set; } = null!;
        public virtual DbSet<BlConfirmPerformance> BlConfirmPerformances { get; set; } = null!;
        public virtual DbSet<BlConfirmPerformanceDetail> BlConfirmPerformanceDetails { get; set; } = null!;
        public virtual DbSet<BlConfirmPerformanceRawSo> BlConfirmPerformanceRawSos { get; set; } = null!;
        public virtual DbSet<BlCurrentCusPerDailySkubuyedDetail> BlCurrentCusPerDailySkubuyedDetails { get; set; } = null!;
        public virtual DbSet<BlCurrentCustomerPerformanceDaily> BlCurrentCustomerPerformanceDailys { get; set; } = null!;
        public virtual DbSet<BlCusPerDailySkubuyedDetail> BlCusPerDailySkubuyedDetails { get; set; } = null!;
        public virtual DbSet<BlCustomerPerformanceDaily> BlCustomerPerformanceDailys { get; set; } = null!;
        public virtual DbSet<BlFreeProcess> BlFreeProcesses { get; set; } = null!;
        public virtual DbSet<BlHistory> BlHistories { get; set; } = null!;
        public virtual DbSet<BlIssueQty> BlIssueQtys { get; set; } = null!;
        public virtual DbSet<BlNormOfBussinessModel> BlNormOfBussinessModels { get; set; } = null!;
        public virtual DbSet<BlOutletAccumulate> BlOutletAccumulates { get; set; } = null!;
        public virtual DbSet<BlPnM> BlPnMs { get; set; } = null!;
        public virtual DbSet<BlRawPo> BlRawPos { get; set; } = null!;
        public virtual DbSet<BlRawSo> BlRawSos { get; set; } = null!;
        public virtual DbSet<BlReceiptQty> BlReceiptQtys { get; set; } = null!;
        public virtual DbSet<BlRunningSale> BlRunningSales { get; set; } = null!;
        public virtual DbSet<BlSafetyStockAssessment> BlSafetyStockAssessments { get; set; } = null!;
        public virtual DbSet<BlSalesIndicator> BlSalesIndicators { get; set; } = null!;
        public virtual DbSet<City> Citys { get; set; } = null!;
        public virtual DbSet<CleanDataConfigure> CleanDataConfigures { get; set; } = null!;
        public virtual DbSet<Competitor> Competitors { get; set; } = null!;
        public virtual DbSet<ConditionstoExcludeSc> ConditionstoExcludeScs { get; set; } = null!;
        public virtual DbSet<ContactType> ContactTypes { get; set; } = null!;
        public virtual DbSet<Container> Containers { get; set; } = null!;
        public virtual DbSet<ContractType> ContractTypes { get; set; } = null!;
        public virtual DbSet<Country> Countrys { get; set; } = null!;
        public virtual DbSet<CronJobSchedule> CronJobSchedules { get; set; } = null!;
        public virtual DbSet<CustomerAdjustment> CustomerAdjustments { get; set; } = null!;
        public virtual DbSet<CustomerAdjustmentDataType> CustomerAdjustmentDataTypes { get; set; } = null!;
        public virtual DbSet<CustomerAdjustmentShipto> CustomerAdjustmentShiptos { get; set; } = null!;
        public virtual DbSet<CustomerApplyToValue> CustomerApplyToValues { get; set; } = null!;
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        public virtual DbSet<CustomerContactEmail> CustomerContactEmails { get; set; } = null!;
        public virtual DbSet<CustomerContactPhone> CustomerContactPhones { get; set; } = null!;
        public virtual DbSet<CustomerContract> CustomerContracts { get; set; } = null!;
        public virtual DbSet<CustomerDmsAttribute> CustomerDmsAttributes { get; set; } = null!;
        public virtual DbSet<CustomerHierarchy> CustomerHierarchies { get; set; } = null!;
        public virtual DbSet<CustomerHierarchyMapping> CustomerHierarchyMappings { get; set; } = null!;
        public virtual DbSet<CustomerInformation> CustomerInformations { get; set; } = null!;
        public virtual DbSet<CustomerSetting> CustomerSettings { get; set; } = null!;
        public virtual DbSet<CustomerSettingHierarchy> CustomerSettingHierarchies { get; set; } = null!;
        public virtual DbSet<CustomerShipto> CustomerShiptos { get; set; } = null!;
        public virtual DbSet<CustomerShiptoContact> CustomerShiptoContacts { get; set; } = null!;
        public virtual DbSet<DataLog> DataLogs { get; set; } = null!;
        public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; } = null!;
        public virtual DbSet<DataTypeDefinition> DataTypeDefinitions { get; set; } = null!;
        public virtual DbSet<DisApproveRegistrationCustomer> DisApproveRegistrationCustomers { get; set; } = null!;
        public virtual DbSet<DisApproveRegistrationCustomerDetail> DisApproveRegistrationCustomerDetails { get; set; } = null!;
        public virtual DbSet<DisBudget> DisBudgets { get; set; } = null!;
        public virtual DbSet<DisBudgetForCusAttribute> DisBudgetForCusAttributes { get; set; } = null!;
        public virtual DbSet<DisBudgetForScopeDsa> DisBudgetForScopeDsas { get; set; } = null!;
        public virtual DbSet<DisBudgetForScopeTerritory> DisBudgetForScopeTerritorys { get; set; } = null!;
        public virtual DbSet<DisBudgetUsed> DisBudgetUseds { get; set; } = null!;
        public virtual DbSet<DisConfirmResult> DisConfirmResults { get; set; } = null!;
        public virtual DbSet<DisConfirmResultDetail> DisConfirmResultDetails { get; set; } = null!;
        public virtual DbSet<DisCriteriaEvaluatePictureDisplay> DisCriteriaEvaluatePictureDisplays { get; set; } = null!;
        public virtual DbSet<DisCustomerAttributeLevel> DisCustomerAttributeLevels { get; set; } = null!;
        public virtual DbSet<DisCustomerAttributeValue> DisCustomerAttributeValues { get; set; } = null!;
        public virtual DbSet<DisCustomerShipto> DisCustomerShiptos { get; set; } = null!;
        public virtual DbSet<DisCustomerShiptoDetail> DisCustomerShiptoDetails { get; set; } = null!;
        public virtual DbSet<DisDefinitionCriteriaEvaluate> DisDefinitionCriteriaEvaluates { get; set; } = null!;
        public virtual DbSet<DisDefinitionGuideImage> DisDefinitionGuideImages { get; set; } = null!;
        public virtual DbSet<DisDefinitionProductTypeDetail> DisDefinitionProductTypeDetails { get; set; } = null!;
        public virtual DbSet<DisDefinitionStructure> DisDefinitionStructures { get; set; } = null!;
        public virtual DbSet<DisDisplay> DisDisplays { get; set; } = null!;
        public virtual DbSet<DisPayReward> DisPayRewards { get; set; } = null!;
        public virtual DbSet<DisPayRewardDetail> DisPayRewardDetails { get; set; } = null!;
        public virtual DbSet<DisScopeDsa> DisScopeDsas { get; set; } = null!;
        public virtual DbSet<DisScopeTerritory> DisScopeTerritorys { get; set; } = null!;
        public virtual DbSet<DisSettlement> DisSettlements { get; set; } = null!;
        public virtual DbSet<DisSettlementDetail> DisSettlementDetails { get; set; } = null!;
        public virtual DbSet<DisWeightGetExtraRewardsDetail> DisWeightGetExtraRewardsDetails { get; set; } = null!;
        public virtual DbSet<DistCache> DistCaches { get; set; } = null!;
        public virtual DbSet<Distributor> Distributors { get; set; } = null!;
        public virtual DbSet<DistributorContact> DistributorContacts { get; set; } = null!;
        public virtual DbSet<DistributorContract> DistributorContracts { get; set; } = null!;
        public virtual DbSet<DistributorHierarchy> DistributorHierarchies { get; set; } = null!;
        public virtual DbSet<DistributorHierarchyMapping> DistributorHierarchyMappings { get; set; } = null!;
        public virtual DbSet<DistributorHistorical> DistributorHistoricals { get; set; } = null!;
        public virtual DbSet<DistributorPriceApplyToOutletAttribute> DistributorPriceApplyToOutletAttributes { get; set; } = null!;
        public virtual DbSet<DistributorPriceItemGroup> DistributorPriceItemGroups { get; set; } = null!;
        public virtual DbSet<DistributorPriceVolume> DistributorPriceVolumes { get; set; } = null!;
        public virtual DbSet<DistributorPriceVolumeLevel> DistributorPriceVolumeLevels { get; set; } = null!;
        public virtual DbSet<DistributorSellingArea> DistributorSellingAreas { get; set; } = null!;
        public virtual DbSet<DistributorShipto> DistributorShiptos { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DropSizeRefResult> DropSizeRefResults { get; set; } = null!;
        public virtual DbSet<DsaDelivery> DsaDeliveries { get; set; } = null!;
        public virtual DbSet<DsaDistributorSellingArea> DsaDistributorSellingAreas { get; set; } = null!;
        public virtual DbSet<DsaGeographicalMapping> DsaGeographicalMappings { get; set; } = null!;
        public virtual DbSet<DsaSalesTeamAssignment> DsaSalesTeamAssignments { get; set; } = null!;
        public virtual DbSet<DsadistributorShipTo> DsadistributorShipTos { get; set; } = null!;
        public virtual DbSet<Dsageographical> Dsageographicals { get; set; } = null!;
        public virtual DbSet<DynamicFieldConfigure> DynamicFieldConfigures { get; set; } = null!;
        public virtual DbSet<EcoLocalization> EcoLocalizations { get; set; } = null!;
        public virtual DbSet<EmailType> EmailTypes { get; set; } = null!;
        public virtual DbSet<Feature> Features { get; set; } = null!;
        public virtual DbSet<GeographicalMapping> GeographicalMappings { get; set; } = null!;
        public virtual DbSet<GeographicalMaster> GeographicalMasters { get; set; } = null!;
        public virtual DbSet<GeographicalStructure> GeographicalStructures { get; set; } = null!;
        public virtual DbSet<InvAdjustmentDetail> InvAdjustmentDetails { get; set; } = null!;
        public virtual DbSet<InvAdjustmentHeader> InvAdjustmentHeaders { get; set; } = null!;
        public virtual DbSet<InvAllocationDetail> InvAllocationDetails { get; set; } = null!;
        public virtual DbSet<InvInventoryTransaction> InvInventoryTransactions { get; set; } = null!;
        public virtual DbSet<InvLotAvailable> InvLotAvailables { get; set; } = null!;
        public virtual DbSet<InvReason> InvReasons { get; set; } = null!;
        public virtual DbSet<InvSellInLotByDate> InvSellInLotByDates { get; set; } = null!;
        public virtual DbSet<InvSellOutLotByDate> InvSellOutLotByDates { get; set; } = null!;
        public virtual DbSet<InvWhTransferDetail> InvWhTransferDetails { get; set; } = null!;
        public virtual DbSet<InvWhTransferHeader> InvWhTransferHeaders { get; set; } = null!;
        public virtual DbSet<InvWhTransferToEmployeeHeader> InvWhTransferToEmployeeHeaders { get; set; } = null!;
        public virtual DbSet<InventoryItem> InventoryItems { get; set; } = null!;
        public virtual DbSet<InventoryKit> InventoryKits { get; set; } = null!;
        public virtual DbSet<InventoryResult> InventoryResults { get; set; } = null!;
        public virtual DbSet<ItemAttribute> ItemAttributes { get; set; } = null!;
        public virtual DbSet<ItemGroup> ItemGroups { get; set; } = null!;
        public virtual DbSet<ItemHierarchyMapping> ItemHierarchyMappings { get; set; } = null!;
        public virtual DbSet<ItemHierarchyMappingCompetitor> ItemHierarchyMappingCompetitors { get; set; } = null!;
        public virtual DbSet<ItemManufacture> ItemManufactures { get; set; } = null!;
        public virtual DbSet<ItemSetting> ItemSettings { get; set; } = null!;
        public virtual DbSet<ItemsCompetitor> ItemsCompetitors { get; set; } = null!;
        public virtual DbSet<ItemsFile> ItemsFiles { get; set; } = null!;
        public virtual DbSet<ItemsUomconversion> ItemsUomconversions { get; set; } = null!;
        public virtual DbSet<JobTitle> JobTitles { get; set; } = null!;
        public virtual DbSet<JobTitleRole> JobTitleRoles { get; set; } = null!;
        public virtual DbSet<Kit> Kits { get; set; } = null!;
        public virtual DbSet<KitInventoryItemConversion> KitInventoryItemConversions { get; set; } = null!;
        public virtual DbSet<KitUomConversion> KitUomConversions { get; set; } = null!;
        public virtual DbSet<Kpi> Kpis { get; set; } = null!;
        public virtual DbSet<KpiResult> KpiResults { get; set; } = null!;
        public virtual DbSet<KpiTargetComplete> KpiTargetCompletes { get; set; } = null!;
        public virtual DbSet<KpisForObjectRef> KpisForObjectRefs { get; set; } = null!;
        public virtual DbSet<KpisObject> KpisObjects { get; set; } = null!;
        public virtual DbSet<KpisSiref> KpisSirefs { get; set; } = null!;
        public virtual DbSet<KpisTarget> KpisTargets { get; set; } = null!;
        public virtual DbSet<KpisTargetForObject> KpisTargetForObjects { get; set; } = null!;
        public virtual DbSet<KpisTargetFrequency> KpisTargetFrequencies { get; set; } = null!;
        public virtual DbSet<KpisTargetGroupByKpisRepeat> KpisTargetGroupByKpisRepeats { get; set; } = null!;
        public virtual DbSet<KpisTargetProductList> KpisTargetProductLists { get; set; } = null!;
        public virtual DbSet<KpisTargetProductListItemCode> KpisTargetProductListItemCodes { get; set; } = null!;
        public virtual DbSet<KpisTargetProductListKpi> KpisTargetProductListKpis { get; set; } = null!;
        public virtual DbSet<KpiseasonCoefficient> KpiseasonCoefficients { get; set; } = null!;
        public virtual DbSet<Kpisetting> Kpisettings { get; set; } = null!;
        public virtual DbSet<KpivisitFrequency> KpivisitFrequencies { get; set; } = null!;
        public virtual DbSet<KsApplicapleAssignment> KsApplicapleAssignments { get; set; } = null!;
        public virtual DbSet<KsCampaign> KsCampaigns { get; set; } = null!;
        public virtual DbSet<KsResource> KsResources { get; set; } = null!;
        public virtual DbSet<KsRespondentInfor> KsRespondentInfors { get; set; } = null!;
        public virtual DbSet<KsScopeAssignment> KsScopeAssignments { get; set; } = null!;
        public virtual DbSet<KsSurvey> KsSurveys { get; set; } = null!;
        public virtual DbSet<KsSurveyAnswer> KsSurveyAnswers { get; set; } = null!;
        public virtual DbSet<KsSurveyQuestion> KsSurveyQuestions { get; set; } = null!;
        public virtual DbSet<KsSurveyResult> KsSurveyResults { get; set; } = null!;
        public virtual DbSet<KsSurveyorResource> KsSurveyorResources { get; set; } = null!;
        public virtual DbSet<Localization> Localizations { get; set; } = null!;
        public virtual DbSet<LocalizationsBackup> LocalizationsBackups { get; set; } = null!;
        public virtual DbSet<LppcRefResult> LppcRefResults { get; set; } = null!;
        public virtual DbSet<Manufacture> Manufactures { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MobileFeaturesPermission> MobileFeaturesPermissions { get; set; } = null!;
        public virtual DbSet<MobileUser> MobileUsers { get; set; } = null!;
        public virtual DbSet<MobileUserApplication> MobileUserApplications { get; set; } = null!;
        public virtual DbSet<MobileUserDevice> MobileUserDevices { get; set; } = null!;
        public virtual DbSet<MobileUserEmployee> MobileUserEmployees { get; set; } = null!;
        public virtual DbSet<MobileUserInfo> MobileUserInfos { get; set; } = null!;
        public virtual DbSet<MobileUserPrinciple> MobileUserPrinciples { get; set; } = null!;
        public virtual DbSet<MobileUserPrinciplesHistory> MobileUserPrinciplesHistories { get; set; } = null!;
        public virtual DbSet<MobileUserSetting> MobileUserSettings { get; set; } = null!;
        public virtual DbSet<MobileUsersLocked> MobileUsersLockeds { get; set; } = null!;
        public virtual DbSet<MobileVisitStep> MobileVisitSteps { get; set; } = null!;
        public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; } = null!;
        public virtual DbSet<Package> Packages { get; set; } = null!;
        public virtual DbSet<PaginationConfig> PaginationConfigs { get; set; } = null!;
        public virtual DbSet<ParameterWithSiref> ParameterWithSirefs { get; set; } = null!;
        public virtual DbSet<ParameterWithSitype> ParameterWithSitypes { get; set; } = null!;
        public virtual DbSet<PcrefResult> PcrefResults { get; set; } = null!;
        public virtual DbSet<PhoneType> PhoneTypes { get; set; } = null!;
        public virtual DbSet<PoAllocationSetting> PoAllocationSettings { get; set; } = null!;
        public virtual DbSet<PoAllocationSettingItemGroup> PoAllocationSettingItemGroups { get; set; } = null!;
        public virtual DbSet<PoAverageDailySale> PoAverageDailySales { get; set; } = null!;
        public virtual DbSet<PoDeliveryLeadTime> PoDeliveryLeadTimes { get; set; } = null!;
        public virtual DbSet<PoGrpodetailItem> PoGrpodetailItems { get; set; } = null!;
        public virtual DbSet<PoGrpoheader> PoGrpoheaders { get; set; } = null!;
        public virtual DbSet<PoOrderDetail> PoOrderDetails { get; set; } = null!;
        public virtual DbSet<PoOrderHeader> PoOrderHeaders { get; set; } = null!;
        public virtual DbSet<PoPoconfirmDetailItem> PoPoconfirmDetailItems { get; set; } = null!;
        public virtual DbSet<PoPoconfirmHeader> PoPoconfirmHeaders { get; set; } = null!;
        public virtual DbSet<PoPurchaseScheduleDetail> PoPurchaseScheduleDetails { get; set; } = null!;
        public virtual DbSet<PoReturnDetailItem> PoReturnDetailItems { get; set; } = null!;
        public virtual DbSet<PoReturnHeader> PoReturnHeaders { get; set; } = null!;
        public virtual DbSet<PoRpoparameter> PoRpoparameters { get; set; } = null!;
        public virtual DbSet<PoStockKeepingDay> PoStockKeepingDays { get; set; } = null!;
        public virtual DbSet<PoStockKeepingDayItemHierarchy> PoStockKeepingDayItemHierarchies { get; set; } = null!;
        public virtual DbSet<Policy> Policies { get; set; } = null!;
        public virtual DbSet<PolicyAccessReport> PolicyAccessReports { get; set; } = null!;
        public virtual DbSet<PolicyApplyFor> PolicyApplyFors { get; set; } = null!;
        public virtual DbSet<PolicyGeneralInformation> PolicyGeneralInformations { get; set; } = null!;
        public virtual DbSet<PolicyResource> PolicyResources { get; set; } = null!;
        public virtual DbSet<PolicyTerritoryLevel> PolicyTerritoryLevels { get; set; } = null!;
        public virtual DbSet<PriceDefinitionDistributor> PriceDefinitionDistributors { get; set; } = null!;
        public virtual DbSet<PriceList> PriceLists { get; set; } = null!;
        public virtual DbSet<PriceListDistributeSellingArea> PriceListDistributeSellingAreas { get; set; } = null!;
        public virtual DbSet<PriceListItemGroup> PriceListItemGroups { get; set; } = null!;
        public virtual DbSet<PriceListOutletAttributeValue> PriceListOutletAttributeValues { get; set; } = null!;
        public virtual DbSet<PriceListSalesTerritoryLevel> PriceListSalesTerritoryLevels { get; set; } = null!;
        public virtual DbSet<PriceListType> PriceListTypes { get; set; } = null!;
        public virtual DbSet<PriceListTypeAttributeList> PriceListTypeAttributeLists { get; set; } = null!;
        public virtual DbSet<PriceSetting> PriceSettings { get; set; } = null!;
        public virtual DbSet<PriceSettingAuditLog> PriceSettingAuditLogs { get; set; } = null!;
        public virtual DbSet<PrimarySic> PrimarySics { get; set; } = null!;
        public virtual DbSet<PrimarySicExcludeHierarchyDetail> PrimarySicExcludeHierarchyDetails { get; set; } = null!;
        public virtual DbSet<PrimarySicExcludeItemGroupDetail> PrimarySicExcludeItemGroupDetails { get; set; } = null!;
        public virtual DbSet<PrimarySicIncludeDetail> PrimarySicIncludeDetails { get; set; } = null!;
        public virtual DbSet<Principal> Principals { get; set; } = null!;
        public virtual DbSet<PrincipalEmpContract> PrincipalEmpContracts { get; set; } = null!;
        public virtual DbSet<PrincipalProfile> PrincipalProfiles { get; set; } = null!;
        public virtual DbSet<PrincipalPullDataQueue> PrincipalPullDataQueues { get; set; } = null!;
        public virtual DbSet<PrincipalSetting> PrincipalSettings { get; set; } = null!;
        public virtual DbSet<PrincipalWarehouse> PrincipalWarehouses { get; set; } = null!;
        public virtual DbSet<PrincipalWarehouseLocation> PrincipalWarehouseLocations { get; set; } = null!;
        public virtual DbSet<PrincipalWinzardSetup> PrincipalWinzardSetups { get; set; } = null!;
        public virtual DbSet<PrincipleEmployee> PrincipleEmployees { get; set; } = null!;
        public virtual DbSet<PriorityPriceListType> PriorityPriceListTypes { get; set; } = null!;
        public virtual DbSet<ProductList> ProductLists { get; set; } = null!;
        public virtual DbSet<ProductListItemCode> ProductListItemCodes { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<PurchaseBasePrice> PurchaseBasePrices { get; set; } = null!;
        public virtual DbSet<PurchasePriceItemGroup> PurchasePriceItemGroups { get; set; } = null!;
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; } = null!;
        public virtual DbSet<RefreshTokenModel> RefreshTokenModels { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<RegistrationQueue> RegistrationQueues { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleClaim> RoleClaims { get; set; } = null!;
        public virtual DbSet<RzBeatPlan> RzBeatPlans { get; set; } = null!;
        public virtual DbSet<RzBeatPlanEmployee> RzBeatPlanEmployees { get; set; } = null!;
        public virtual DbSet<RzBeatPlanShipto> RzBeatPlanShiptos { get; set; } = null!;
        public virtual DbSet<RzLocation> RzLocations { get; set; } = null!;
        public virtual DbSet<RzParameterLevelApply> RzParameterLevelApplies { get; set; } = null!;
        public virtual DbSet<RzParameterSetting> RzParameterSettings { get; set; } = null!;
        public virtual DbSet<RzParameterType> RzParameterTypes { get; set; } = null!;
        public virtual DbSet<RzParameterValue> RzParameterValues { get; set; } = null!;
        public virtual DbSet<RzRouteZoneInfomation> RzRouteZoneInfomations { get; set; } = null!;
        public virtual DbSet<RzRouteZoneParameter> RzRouteZoneParameters { get; set; } = null!;
        public virtual DbSet<RzRouteZoneShipto> RzRouteZoneShiptos { get; set; } = null!;
        public virtual DbSet<RzRouteZoneType> RzRouteZoneTypes { get; set; } = null!;
        public virtual DbSet<RzVisitFrequency> RzVisitFrequencies { get; set; } = null!;
        public virtual DbSet<SaUserWithDistributorShipto> SaUserWithDistributorShiptos { get; set; } = null!;
        public virtual DbSet<SaleCalendar> SaleCalendars { get; set; } = null!;
        public virtual DbSet<SaleCalendarActionHistory> SaleCalendarActionHistories { get; set; } = null!;
        public virtual DbSet<SaleCalendarGenerate> SaleCalendarGenerates { get; set; } = null!;
        public virtual DbSet<SaleCalendarHoliday> SaleCalendarHolidays { get; set; } = null!;
        public virtual DbSet<SaleGroup> SaleGroups { get; set; } = null!;
        public virtual DbSet<SaleProcessDetail> SaleProcessDetails { get; set; } = null!;
        public virtual DbSet<SaleProcessSetting> SaleProcessSettings { get; set; } = null!;
        public virtual DbSet<SalesBasePrice> SalesBasePrices { get; set; } = null!;
        public virtual DbSet<SalesIndicatorRef> SalesIndicatorRefs { get; set; } = null!;
        public virtual DbSet<SalesIndicatorType> SalesIndicatorTypes { get; set; } = null!;
        public virtual DbSet<SalesOganization> SalesOganizations { get; set; } = null!;
        public virtual DbSet<SalesPriceItemGroup> SalesPriceItemGroups { get; set; } = null!;
        public virtual DbSet<SalesPriceItemGroupReference> SalesPriceItemGroupReferences { get; set; } = null!;
        public virtual DbSet<ScAuditlogReconcile> ScAuditlogReconciles { get; set; } = null!;
        public virtual DbSet<ScSalesOrganizationStructure> ScSalesOrganizationStructures { get; set; } = null!;
        public virtual DbSet<ScSalesTeamAssignment> ScSalesTeamAssignments { get; set; } = null!;
        public virtual DbSet<ScTerritoryLevel> ScTerritoryLevels { get; set; } = null!;
        public virtual DbSet<ScTerritoryMapping> ScTerritoryMappings { get; set; } = null!;
        public virtual DbSet<ScTerritoryStructure> ScTerritoryStructures { get; set; } = null!;
        public virtual DbSet<ScTerritoryStructureDetail> ScTerritoryStructureDetails { get; set; } = null!;
        public virtual DbSet<ScTerritoryStructureGeographicalMapping> ScTerritoryStructureGeographicalMappings { get; set; } = null!;
        public virtual DbSet<ScTerritoryValue> ScTerritoryValues { get; set; } = null!;
        public virtual DbSet<ScrefResult> ScrefResults { get; set; } = null!;
        public virtual DbSet<SdoResult> SdoResults { get; set; } = null!;
        public virtual DbSet<Sdoconfig> Sdoconfigs { get; set; } = null!;
        public virtual DbSet<SdoconfigSalesOrder> SdoconfigSalesOrders { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceDetail> ServiceDetails { get; set; } = null!;
        public virtual DbSet<ShiptoContact> ShiptoContacts { get; set; } = null!;
        public virtual DbSet<ShiptoHistorical> ShiptoHistoricals { get; set; } = null!;
        public virtual DbSet<SivRefResult> SivRefResults { get; set; } = null!;
        public virtual DbSet<SkurefResult> SkurefResults { get; set; } = null!;
        public virtual DbSet<SoFirstTimeCustomer> SoFirstTimeCustomers { get; set; } = null!;
        public virtual DbSet<SoOrderInformation> SoOrderInformations { get; set; } = null!;
        public virtual DbSet<SoOrderItem> SoOrderItems { get; set; } = null!;
        public virtual DbSet<SoProProgramCustomer> SoProProgramCustomers { get; set; } = null!;
        public virtual DbSet<SoProProgramCustomerDetailsItem> SoProProgramCustomerDetailsItems { get; set; } = null!;
        public virtual DbSet<SoProProgramCustomerItemsGroup> SoProProgramCustomerItemsGroups { get; set; } = null!;
        public virtual DbSet<SoProProgramCustomersDetail> SoProProgramCustomersDetails { get; set; } = null!;
        public virtual DbSet<SoReason> SoReasons { get; set; } = null!;
        public virtual DbSet<SoSumPickingListDetail> SoSumPickingListDetails { get; set; } = null!;
        public virtual DbSet<SoSumPickingListHeader> SoSumPickingListHeaders { get; set; } = null!;
        public virtual DbSet<SovRefResult> SovRefResults { get; set; } = null!;
        public virtual DbSet<StagingAccessReport> StagingAccessReports { get; set; } = null!;
        public virtual DbSet<StagingSyncDataHistory> StagingSyncDataHistories { get; set; } = null!;
        public virtual DbSet<StagingSyncDataType> StagingSyncDataTypes { get; set; } = null!;
        public virtual DbSet<StagingSyncRefDataType> StagingSyncRefDataTypes { get; set; } = null!;
        public virtual DbSet<Standard> Standards { get; set; } = null!;
        public virtual DbSet<StandardItem> StandardItems { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<SystemLog> SystemLogs { get; set; } = null!;
        public virtual DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public virtual DbSet<TargetKpi> TargetKpis { get; set; } = null!;
        public virtual DbSet<TargetSaleCalendar> TargetSaleCalendars { get; set; } = null!;
        public virtual DbSet<TempBaselineDataBusinessModel> TempBaselineDataBusinessModels { get; set; } = null!;
        public virtual DbSet<TempBaselineDataConditionExclude> TempBaselineDataConditionExcludes { get; set; } = null!;
        public virtual DbSet<TempBaselineDataOrder> TempBaselineDataOrders { get; set; } = null!;
        public virtual DbSet<TempBaselineDataOrderDetail> TempBaselineDataOrderDetails { get; set; } = null!;
        public virtual DbSet<TempBaselineDataPurchaseOrder> TempBaselineDataPurchaseOrders { get; set; } = null!;
        public virtual DbSet<TempBaselineDataPurchaseOrderDetail> TempBaselineDataPurchaseOrderDetails { get; set; } = null!;
        public virtual DbSet<TempBaselineDataVisit> TempBaselineDataVisits { get; set; } = null!;
        public virtual DbSet<TempBaselineDataVisitStepResult> TempBaselineDataVisitStepResults { get; set; } = null!;
        public virtual DbSet<TempBaselineDetailRequestPo> TempBaselineDetailRequestPos { get; set; } = null!;
        public virtual DbSet<TempBaselineHeaderRequestPo> TempBaselineHeaderRequestPos { get; set; } = null!;
        public virtual DbSet<TempBeatPlan> TempBeatPlans { get; set; } = null!;
        public virtual DbSet<TempBeatPlanDetail> TempBeatPlanDetails { get; set; } = null!;
        public virtual DbSet<TempCheckInventoryVisit> TempCheckInventoryVisits { get; set; } = null!;
        public virtual DbSet<TempDisApproveRegistrationCustomer> TempDisApproveRegistrationCustomers { get; set; } = null!;
        public virtual DbSet<TempDisConfirmResultDetail> TempDisConfirmResultDetails { get; set; } = null!;
        public virtual DbSet<TempDisCustomerShiptoNotHafe> TempDisCustomerShiptoNotHaves { get; set; } = null!;
        public virtual DbSet<TempDisCustomerShiptoSaleOrQuantity> TempDisCustomerShiptoSaleOrQuantitys { get; set; } = null!;
        public virtual DbSet<TempDisDisplaySupportTool> TempDisDisplaySupportTools { get; set; } = null!;
        public virtual DbSet<TempDisOrderDetail> TempDisOrderDetails { get; set; } = null!;
        public virtual DbSet<TempDisOrderHeader> TempDisOrderHeaders { get; set; } = null!;
        public virtual DbSet<TempDisPosmForCustomerShipto> TempDisPosmForCustomerShiptos { get; set; } = null!;
        public virtual DbSet<TempEvaluationPhotoVisit> TempEvaluationPhotoVisits { get; set; } = null!;
        public virtual DbSet<TempInventoryItemInfor> TempInventoryItemInfors { get; set; } = null!;
        public virtual DbSet<TempInvreport> TempInvreports { get; set; } = null!;
        public virtual DbSet<TempInvreportLot> TempInvreportLots { get; set; } = null!;
        public virtual DbSet<TempKpidistributor> TempKpidistributors { get; set; } = null!;
        public virtual DbSet<TempKpiemployee> TempKpiemployees { get; set; } = null!;
        public virtual DbSet<TempKpisellIn> TempKpisellIns { get; set; } = null!;
        public virtual DbSet<TempParameterWithSitype> TempParameterWithSitypes { get; set; } = null!;
        public virtual DbSet<TempPoKpi> TempPoKpis { get; set; } = null!;
        public virtual DbSet<TempProgram> TempPrograms { get; set; } = null!;
        public virtual DbSet<TempProgramDetailReward> TempProgramDetailRewards { get; set; } = null!;
        public virtual DbSet<TempProgramDetailsItemsGroup> TempProgramDetailsItemsGroups { get; set; } = null!;
        public virtual DbSet<TempProgramsDetail> TempProgramsDetails { get; set; } = null!;
        public virtual DbSet<TempPromotionOrderRefNumber> TempPromotionOrderRefNumbers { get; set; } = null!;
        public virtual DbSet<TempRoundingRule> TempRoundingRules { get; set; } = null!;
        public virtual DbSet<TempRouteZone> TempRouteZones { get; set; } = null!;
        public virtual DbSet<TempSalesIndicatorType> TempSalesIndicatorTypes { get; set; } = null!;
        public virtual DbSet<TempTpOrderDetail> TempTpOrderDetails { get; set; } = null!;
        public virtual DbSet<TempTpOrderHeader> TempTpOrderHeaders { get; set; } = null!;
        public virtual DbSet<TempVisitStep> TempVisitSteps { get; set; } = null!;
        public virtual DbSet<TempVisitStepsDefaultResult> TempVisitStepsDefaultResults { get; set; } = null!;
        public virtual DbSet<TempVisitStepsReasonResult> TempVisitStepsReasonResults { get; set; } = null!;
        public virtual DbSet<TemporarySic> TemporarySics { get; set; } = null!;
        public virtual DbSet<TemporarySicItemGroupDetail> TemporarySicItemGroupDetails { get; set; } = null!;
        public virtual DbSet<TemporarySicKitDetail> TemporarySicKitDetails { get; set; } = null!;
        public virtual DbSet<TerritoryMapping> TerritoryMappings { get; set; } = null!;
        public virtual DbSet<TerritoryStructure> TerritoryStructures { get; set; } = null!;
        public virtual DbSet<TerritoryStructureDetail> TerritoryStructureDetails { get; set; } = null!;
        public virtual DbSet<TerritoryValue> TerritoryValues { get; set; } = null!;
        public virtual DbSet<TpBudget> TpBudgets { get; set; } = null!;
        public virtual DbSet<TpBudgetAdjustment> TpBudgetAdjustments { get; set; } = null!;
        public virtual DbSet<TpBudgetAllotment> TpBudgetAllotments { get; set; } = null!;
        public virtual DbSet<TpBudgetAllotmentAdjustment> TpBudgetAllotmentAdjustments { get; set; } = null!;
        public virtual DbSet<TpBudgetDefine> TpBudgetDefines { get; set; } = null!;
        public virtual DbSet<TpBudgetUsed> TpBudgetUseds { get; set; } = null!;
        public virtual DbSet<TpDiscount> TpDiscounts { get; set; } = null!;
        public virtual DbSet<TpDiscountObjectCustomerAttributeLevel> TpDiscountObjectCustomerAttributeLevels { get; set; } = null!;
        public virtual DbSet<TpDiscountObjectCustomerAttributeValue> TpDiscountObjectCustomerAttributeValues { get; set; } = null!;
        public virtual DbSet<TpDiscountObjectCustomerShipto> TpDiscountObjectCustomerShiptos { get; set; } = null!;
        public virtual DbSet<TpDiscountScopeDsa> TpDiscountScopeDsas { get; set; } = null!;
        public virtual DbSet<TpDiscountScopeTerritory> TpDiscountScopeTerritorys { get; set; } = null!;
        public virtual DbSet<TpDiscountStructureDetail> TpDiscountStructureDetails { get; set; } = null!;
        public virtual DbSet<TpPromotion> TpPromotions { get; set; } = null!;
        public virtual DbSet<TpPromotionDefinitionProductForGift> TpPromotionDefinitionProductForGifts { get; set; } = null!;
        public virtual DbSet<TpPromotionDefinitionProductForSale> TpPromotionDefinitionProductForSales { get; set; } = null!;
        public virtual DbSet<TpPromotionDefinitionStructure> TpPromotionDefinitionStructures { get; set; } = null!;
        public virtual DbSet<TpPromotionObjectCustomerAttributeLevel> TpPromotionObjectCustomerAttributeLevels { get; set; } = null!;
        public virtual DbSet<TpPromotionObjectCustomerAttributeValue> TpPromotionObjectCustomerAttributeValues { get; set; } = null!;
        public virtual DbSet<TpPromotionObjectCustomerShipto> TpPromotionObjectCustomerShiptos { get; set; } = null!;
        public virtual DbSet<TpPromotionScopeDsa> TpPromotionScopeDsas { get; set; } = null!;
        public virtual DbSet<TpPromotionScopeTerritory> TpPromotionScopeTerritorys { get; set; } = null!;
        public virtual DbSet<TpSettlement> TpSettlements { get; set; } = null!;
        public virtual DbSet<TpSettlementDetail> TpSettlementDetails { get; set; } = null!;
        public virtual DbSet<TpSettlementObject> TpSettlementObjects { get; set; } = null!;
        public virtual DbSet<TradePromotion> TradePromotions { get; set; } = null!;
        public virtual DbSet<Uom> Uoms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserClaim> UserClaims { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; } = null!;
        public virtual DbSet<UserPolicy> UserPolicies { get; set; } = null!;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<Vat> Vats { get; set; } = null!;
        public virtual DbSet<Version> Versions { get; set; } = null!;
        public virtual DbSet<VisitList> VisitLists { get; set; } = null!;
        public virtual DbSet<VisitProcessDetail> VisitProcessDetails { get; set; } = null!;
        public virtual DbSet<VisitProcessSetting> VisitProcessSettings { get; set; } = null!;
        public virtual DbSet<VisitStep> VisitSteps { get; set; } = null!;
        public virtual DbSet<VpoRefResult> VpoRefResults { get; set; } = null!;
        public virtual DbSet<VvrefResult> VvrefResults { get; set; } = null!;
        public virtual DbSet<Ward> Wards { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WebNotiMessagese> WebNotiMessageses { get; set; } = null!;
        public virtual DbSet<WinzardFeature> WinzardFeatures { get; set; } = null!;
        public virtual DbSet<WinzardSetting> WinzardSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendar> WorkingCalendars { get; set; } = null!;
        public virtual DbSet<WorkingCalendarApproval> WorkingCalendarApprovals { get; set; } = null!;
        public virtual DbSet<WorkingCalendarApproveSetting> WorkingCalendarApproveSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarCustomer> WorkingCalendarCustomers { get; set; } = null!;
        public virtual DbSet<WorkingCalendarFreeSetupSetting> WorkingCalendarFreeSetupSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarJobtitleSetting> WorkingCalendarJobtitleSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarOpenWork> WorkingCalendarOpenWorks { get; set; } = null!;
        public virtual DbSet<WorkingCalendarOpenWorkDetail> WorkingCalendarOpenWorkDetails { get; set; } = null!;
        public virtual DbSet<WorkingCalendarRulesSetting> WorkingCalendarRulesSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarSessionSetting> WorkingCalendarSessionSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarShiftSetting> WorkingCalendarShiftSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarTask> WorkingCalendarTasks { get; set; } = null!;
        public virtual DbSet<WorkingCalendarTaskApplySetting> WorkingCalendarTaskApplySettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarTaskSetting> WorkingCalendarTaskSettings { get; set; } = null!;
        public virtual DbSet<WorkingCalendarTypeSetting> WorkingCalendarTypeSettings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=103.98.160.114;Port=9092;Database=onesuat_system;User Id=postgresrdos;Password=RDOSGolive2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("tablefunc")
                .HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<AdjustItemGroupPrice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustPricesCode).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(255);

                entity.Property(e => e.PriceType).HasMaxLength(25);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UoMitemGroup)
                    .HasMaxLength(255)
                    .HasColumnName("UoMItemGroup");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<AdjustPriceListUoMitemGroup>(entity =>
            {
                entity.ToTable("AdjustPriceListUoMItemGroups");

                entity.HasIndex(e => e.AdjustItemGroupPriceId, "IX_AdjustPriceListUoMItemGroups_AdjustItemGroupPriceId");

                entity.HasIndex(e => e.PriceListId, "IX_AdjustPriceListUoMItemGroups_PriceListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpirationTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemGroupCode).HasMaxLength(255);

                entity.Property(e => e.ItemGroupDescription).HasMaxLength(255);

                entity.Property(e => e.PriceListEffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PriceListExpirationTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UoMitemGroup)
                    .HasMaxLength(255)
                    .HasColumnName("UoMItemGroup");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.AdjustItemGroupPrice)
                    .WithMany(p => p.AdjustPriceListUoMitemGroups)
                    .HasForeignKey(d => d.AdjustItemGroupPriceId)
                    .HasConstraintName("FK_AdjustPriceListUoMItemGroups_AdjustItemGroupPrices_AdjustIt~");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.AdjustPriceListUoMitemGroups)
                    .HasForeignKey(d => d.PriceListId);
            });

            modelBuilder.Entity<ApiMapping>(entity =>
            {
                entity.ToTable("ApiMapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AndroidPackageName).HasMaxLength(100);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.IosbundleId)
                    .HasMaxLength(100)
                    .HasColumnName("IOSBundleId");

                entity.Property(e => e.SecretId).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationInviteCode>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AcitveLink).HasMaxLength(255);

                entity.Property(e => e.ActiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.AppName).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.ExpiredDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InviteCode).HasMaxLength(10);

                entity.Property(e => e.MessageDetail).HasMaxLength(1000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationLanguagePack>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AppVersion).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExcelFileName).HasMaxLength(255);

                entity.Property(e => e.FileVersion).HasMaxLength(20);

                entity.Property(e => e.IosversionId).HasColumnName("IOsversionId");

                entity.Property(e => e.JsonFileName).HasMaxLength(255);

                entity.Property(e => e.LanguageCode).HasMaxLength(20);

                entity.Property(e => e.LanguageName).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationLocalization>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.ExcelFileName).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileVersion).HasMaxLength(20);

                entity.Property(e => e.JsonFileName).HasMaxLength(255);

                entity.Property(e => e.JsonFileRepoId).HasColumnType("character varying");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp(6) without time zone");
            });

            modelBuilder.Entity<ApplicationLocalizationHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExcelFileName).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileVersion).HasMaxLength(20);

                entity.Property(e => e.HistoryDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.JsonFileName).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationNotiDeviceToken>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppName).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeviceToken).HasMaxLength(255);

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .HasColumnName("OS");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationNotiMessage>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DataId).HasMaxLength(100);

                entity.Property(e => e.DataJson).HasMaxLength(4000);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeliveryStatus).HasMaxLength(20);

                entity.Property(e => e.Purpose).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UrgentNotiId).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'::uuid");
            });

            modelBuilder.Entity<ApplicationNotiUrgent>(entity =>
            {
                entity.ToTable("ApplicationNotiUrgent");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DataId).HasMaxLength(100);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Priority).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SyncCode).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationOtpcode>(entity =>
            {
                entity.ToTable("ApplicationOTPCodes");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.AppName).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Otpcode)
                    .HasMaxLength(8)
                    .HasColumnName("OTPCode");

                entity.Property(e => e.Purpose).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationService>(entity =>
            {
                entity.HasIndex(e => e.ApplicationId, "IX_ApplicationServices_ApplicationId");

                entity.HasIndex(e => e.EcoServiceId, "IX_ApplicationServices_EcoServiceId");

                entity.HasIndex(e => e.EcoVersionId, "IX_ApplicationServices_EcoVersionId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationServices)
                    .HasForeignKey(d => d.ApplicationId);

                entity.HasOne(d => d.EcoService)
                    .WithMany(p => p.ApplicationServices)
                    .HasForeignKey(d => d.EcoServiceId);

                entity.HasOne(d => d.EcoVersion)
                    .WithMany(p => p.ApplicationServices)
                    .HasForeignKey(d => d.EcoVersionId);
            });

            modelBuilder.Entity<ApplicationThemesConfigure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ComponentName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ElementName).HasMaxLength(50);

                entity.Property(e => e.ElementType).HasMaxLength(50);

                entity.Property(e => e.ElementValue).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationThemesElement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ComponentName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ElementName).HasMaxLength(50);

                entity.Property(e => e.ElementType).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationThemesSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationThemesSuggestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationUserMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationVersion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AppBuildFile).HasMaxLength(255);

                entity.Property(e => e.AppName).HasMaxLength(20);

                entity.Property(e => e.AppVersion).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.HostType).HasMaxLength(10);

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .HasColumnName("OS");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ApplicationVersionPrinciple>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AppVersion).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.PrincipleCode).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp(6) without time zone");
            });

            modelBuilder.Entity<AsoRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.PcinvoiceValue).HasColumnName("PCInvoiceValue");

                entity.Property(e => e.PcnoofSku).HasColumnName("PCNoofSKU");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.Sku).HasColumnName("SKU");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FeatureCode).HasMaxLength(100);

                entity.Property(e => e.Fields).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<AutoKpisTarget>(entity =>
            {
                entity.ToTable("AutoKPIsTargets");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");
            });

            modelBuilder.Entity<AutoKpisTargetAchievementsCurrentYear>(entity =>
            {
                entity.ToTable("AutoKPIsTargetAchievementsCurrentYears");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aso).HasColumnName("ASO");

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.Lppc).HasColumnName("LPPC");

                entity.Property(e => e.Lppcvalue).HasColumnName("LPPCValue");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.Vpo).HasColumnName("VPO");
            });

            modelBuilder.Entity<AutoKpisTargetAchievementsCurrentYearValue>(entity =>
            {
                entity.ToTable("AutoKPIsTargetAchievementsCurrentYearValues");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aso).HasColumnName("ASO");

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.Lppc).HasColumnName("LPPC");

                entity.Property(e => e.Lppcvalue).HasColumnName("LPPCValue");

                entity.Property(e => e.Pc).HasColumnName("PC");

                entity.Property(e => e.Vpo).HasColumnName("VPO");
            });

            modelBuilder.Entity<AutoKpisTargetBusinessModel>(entity =>
            {
                entity.ToTable("AutoKPIsTargetBusinessModels");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.BaseAso).HasColumnName("BaseASO");

                entity.Property(e => e.BaseLppc).HasColumnName("BaseLPPC");

                entity.Property(e => e.BaseLppcvalue).HasColumnName("BaseLPPCValue");

                entity.Property(e => e.BasePc).HasColumnName("BasePC");

                entity.Property(e => e.BaseVpo).HasColumnName("BaseVPO");

                entity.Property(e => e.NewTargetAso).HasColumnName("NewTargetASO");

                entity.Property(e => e.NewTargetLppc).HasColumnName("NewTargetLPPC");

                entity.Property(e => e.NewTargetLppcvalue).HasColumnName("NewTargetLPPCValue");

                entity.Property(e => e.NewTargetPc).HasColumnName("NewTargetPC");

                entity.Property(e => e.NewTargetVpo).HasColumnName("NewTargetVPO");

                entity.Property(e => e.TargetAso).HasColumnName("TargetASO");

                entity.Property(e => e.TargetLppc).HasColumnName("TargetLPPC");

                entity.Property(e => e.TargetLppcvalue).HasColumnName("TargetLPPCValue");

                entity.Property(e => e.TargetPc).HasColumnName("TargetPC");

                entity.Property(e => e.TargetVpo).HasColumnName("TargetVPO");
            });

            modelBuilder.Entity<AutoKpisTargetBusinessModelValue>(entity =>
            {
                entity.ToTable("AutoKPIsTargetBusinessModelValues");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.BaseAso).HasColumnName("BaseASO");

                entity.Property(e => e.BaseLppc).HasColumnName("BaseLPPC");

                entity.Property(e => e.BaseLppcvalue).HasColumnName("BaseLPPCValue");

                entity.Property(e => e.BasePc).HasColumnName("BasePC");

                entity.Property(e => e.BaseVpo).HasColumnName("BaseVPO");

                entity.Property(e => e.CommitedTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Level).HasDefaultValueSql("0");

                entity.Property(e => e.NewTargetAso).HasColumnName("NewTargetASO");

                entity.Property(e => e.NewTargetLppc).HasColumnName("NewTargetLPPC");

                entity.Property(e => e.NewTargetLppcvalue).HasColumnName("NewTargetLPPCValue");

                entity.Property(e => e.NewTargetPc).HasColumnName("NewTargetPC");

                entity.Property(e => e.NewTargetVpo).HasColumnName("NewTargetVPO");

                entity.Property(e => e.TargetAso).HasColumnName("TargetASO");

                entity.Property(e => e.TargetLppc).HasColumnName("TargetLPPC");

                entity.Property(e => e.TargetLppcvalue).HasColumnName("TargetLPPCValue");

                entity.Property(e => e.TargetPc).HasColumnName("TargetPC");

                entity.Property(e => e.TargetVpo).HasColumnName("TargetVPO");

                entity.Property(e => e.Year).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AutoKpisTargetContributionBySic>(entity =>
            {
                entity.ToTable("AutoKPIsTargetContributionBySICs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.Sic).HasColumnName("SIC");
            });

            modelBuilder.Entity<AutoKpisTargetContributionBySicValue>(entity =>
            {
                entity.ToTable("AutoKPIsTargetContributionBySicValues");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");

                entity.Property(e => e.Sic).HasColumnName("SIC");
            });

            modelBuilder.Entity<AutoKpisTargetDevelopment>(entity =>
            {
                entity.ToTable("AutoKPIsTargetDevelopments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetCode).HasColumnName("AutoKPIsTargetCode");
            });

            modelBuilder.Entity<AutoKpisTargetDevelopmentDetail>(entity =>
            {
                entity.ToTable("AutoKPIsTargetDevelopmentDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoKpisTargetDevelopmentId).HasColumnName("AutoKPIsTargetDevelopmentId");
            });

            modelBuilder.Entity<BlAuditLog>(entity =>
            {
                entity.ToTable("BL_AuditLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FinishTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ProcessCode).HasMaxLength(50);

                entity.Property(e => e.RefNumber).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);
            });

            modelBuilder.Entity<BlBlprocess>(entity =>
            {
                entity.ToTable("BL_BLProcess");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsSequentialProcessing)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LinkApi)
                    .HasMaxLength(255)
                    .HasColumnName("LinkAPI");

                entity.Property(e => e.ProcessCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlBlsettingEmail>(entity =>
            {
                entity.ToTable("BL_BLSettingEmails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.Cc).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.From).HasMaxLength(25);

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.To).HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlBlsettingInformation>(entity =>
            {
                entity.ToTable("BL_BLSettingInformations");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.ProcessOffCount)
                    .HasColumnName("ProcessOffCount ")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProcessPendingTime).HasMaxLength(50);

                entity.Property(e => e.ProcessTime).HasMaxLength(50);

                entity.Property(e => e.SettingRef).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlBlsettingProcess>(entity =>
            {
                entity.ToTable("BL_BLSettingProcess");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ProcessCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlBlsettingProcessPending>(entity =>
            {
                entity.ToTable("BL_BLSettingProcessPendings");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.FromStatus).HasMaxLength(25);

                entity.Property(e => e.ToStatus).HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlBlsettingTransactionStatus>(entity =>
            {
                entity.ToTable("BL_BLSettingTransactionStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlCloseStock>(entity =>
            {
                entity.ToTable("BL_CloseStocks");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.ClosePurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("ClosePurchaseUOM");

                entity.Property(e => e.CloseQuantityBaseUom)
                    .HasMaxLength(255)
                    .HasColumnName("CloseQuantityBaseUOM");

                entity.Property(e => e.CloseSalesUom)
                    .HasMaxLength(100)
                    .HasColumnName("CloseSalesUOM");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(100)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.ItemGroupDesc).HasMaxLength(255);

                entity.Property(e => e.ItemGroupId).HasMaxLength(100);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.LocationId).HasMaxLength(100);

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseId).HasMaxLength(100);

                entity.Property(e => e.WareHouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlConfirmPerformance>(entity =>
            {
                entity.ToTable("BL_ConfirmPerformances");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalendarEndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CalendarStartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ConfirmByUser).HasMaxLength(50);

                entity.Property(e => e.ConfirmDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ConfirmRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FileType).HasMaxLength(100);

                entity.Property(e => e.FromDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalePeriod).HasMaxLength(100);

                entity.Property(e => e.SalesOrgCode).HasMaxLength(50);

                entity.Property(e => e.SalesOrgDescription).HasMaxLength(80);

                entity.Property(e => e.ToDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlConfirmPerformanceDetail>(entity =>
            {
                entity.ToTable("BL_ConfirmPerformanceDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConfirmRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValueCode).HasMaxLength(50);

                entity.Property(e => e.ValueDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<BlConfirmPerformanceRawSo>(entity =>
            {
                entity.ToTable("BL_ConfirmPerformanceRawSos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConfirmRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlCurrentCusPerDailySkubuyedDetail>(entity =>
            {
                entity.ToTable("BL_CurrentCusPerDailySKUBuyedDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CusShiptoAttributeDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeId).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeName).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueId).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistyBillToId).HasMaxLength(100);

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RouteZoneType).HasMaxLength(100);

                entity.Property(e => e.RouteZonelocation).HasMaxLength(255);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Sicdesc)
                    .HasMaxLength(255)
                    .HasColumnName("SICDesc");

                entity.Property(e => e.Sicid)
                    .HasMaxLength(100)
                    .HasColumnName("SICId");

                entity.Property(e => e.Sidesc)
                    .HasMaxLength(255)
                    .HasColumnName("SIDesc");

                entity.Property(e => e.Siid)
                    .HasMaxLength(100)
                    .HasColumnName("SIId");

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlCurrentCustomerPerformanceDaily>(entity =>
            {
                entity.ToTable("BL_CurrentCustomerPerformanceDailys");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CusShiptoAttributeDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeId).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeName).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueId).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistyBillToId).HasMaxLength(100);

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RouteZoneType).HasMaxLength(100);

                entity.Property(e => e.RouteZonelocation).HasMaxLength(255);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Sicdesc)
                    .HasMaxLength(255)
                    .HasColumnName("SICDesc");

                entity.Property(e => e.Sicid)
                    .HasMaxLength(100)
                    .HasColumnName("SICId");

                entity.Property(e => e.Sidesc)
                    .HasMaxLength(255)
                    .HasColumnName("SIDesc");

                entity.Property(e => e.Siid)
                    .HasMaxLength(100)
                    .HasColumnName("SIId");

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlCusPerDailySkubuyedDetail>(entity =>
            {
                entity.ToTable("BL_CusPerDailySKUBuyedDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CusShiptoAttributeDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeId).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeName).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueId).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistyBillToId).HasMaxLength(100);

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RouteZoneType).HasMaxLength(100);

                entity.Property(e => e.RouteZonelocation).HasMaxLength(255);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Sicdesc)
                    .HasMaxLength(255)
                    .HasColumnName("SICDesc");

                entity.Property(e => e.Sicid)
                    .HasMaxLength(100)
                    .HasColumnName("SICId");

                entity.Property(e => e.Sidesc)
                    .HasMaxLength(255)
                    .HasColumnName("SIDesc");

                entity.Property(e => e.Siid)
                    .HasMaxLength(100)
                    .HasColumnName("SIId");

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlCustomerPerformanceDaily>(entity =>
            {
                entity.ToTable("BL_CustomerPerformanceDailys");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CusShiptoAttributeDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeId).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeName).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueId).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistyBillToId).HasMaxLength(100);

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RouteZoneType).HasMaxLength(100);

                entity.Property(e => e.RouteZonelocation).HasMaxLength(255);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Sicdesc)
                    .HasMaxLength(255)
                    .HasColumnName("SICDesc");

                entity.Property(e => e.Sicid)
                    .HasMaxLength(100)
                    .HasColumnName("SICId");

                entity.Property(e => e.Sidesc)
                    .HasMaxLength(255)
                    .HasColumnName("SIDesc");

                entity.Property(e => e.Siid)
                    .HasMaxLength(100)
                    .HasColumnName("SIId");

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlFreeProcess>(entity =>
            {
                entity.ToTable("BL_FreeProcess");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.LinkApi)
                    .HasMaxLength(255)
                    .HasColumnName("LinkAPI");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlHistory>(entity =>
            {
                entity.ToTable("BL_Histories");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndTimeDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RefNumber).HasMaxLength(255);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Scope).HasMaxLength(50);

                entity.Property(e => e.StartTimeDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Type).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlIssueQty>(entity =>
            {
                entity.ToTable("BL_IssueQtys");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaseLineType).HasMaxLength(50);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(100)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.ItemGroupDesc).HasMaxLength(255);

                entity.Property(e => e.ItemGroupId).HasMaxLength(100);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.LocationId).HasMaxLength(100);

                entity.Property(e => e.Month).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OutBaseUom)
                    .HasMaxLength(255)
                    .HasColumnName("OutBaseUOM");

                entity.Property(e => e.OutPurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("OutPurchaseUOM");

                entity.Property(e => e.OutQuantityType).HasMaxLength(50);

                entity.Property(e => e.OutQuantityTypeDesc).HasMaxLength(255);

                entity.Property(e => e.OutQuantityTypeValue).HasMaxLength(255);

                entity.Property(e => e.OutSalesUom)
                    .HasMaxLength(100)
                    .HasColumnName("OutSalesUOM");

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseId).HasMaxLength(100);

                entity.Property(e => e.WareHouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlNormOfBussinessModel>(entity =>
            {
                entity.ToTable("BL_NormOfBussinessModels");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BusinessModelDesc).HasMaxLength(255);

                entity.Property(e => e.BusinessModelId).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.Sidesc)
                    .HasMaxLength(255)
                    .HasColumnName("SIDesc");

                entity.Property(e => e.Siid)
                    .HasMaxLength(100)
                    .HasColumnName("SIId");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<BlOutletAccumulate>(entity =>
            {
                entity.ToTable("BL_OutletAccumulates");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccuByProdActualUom)
                    .HasMaxLength(255)
                    .HasColumnName("AccuByProdActualUOM");

                entity.Property(e => e.AccuByProdTargetUom)
                    .HasMaxLength(255)
                    .HasColumnName("AccuByProdTargetUOM");

                entity.Property(e => e.AccuProductDesc).HasMaxLength(255);

                entity.Property(e => e.AccuProductId).HasMaxLength(100);

                entity.Property(e => e.AccuWeighProductDesc).HasMaxLength(255);

                entity.Property(e => e.AccuWeighProductId).HasMaxLength(100);

                entity.Property(e => e.AccuWeightByProgActualUom)
                    .HasMaxLength(255)
                    .HasColumnName("AccuWeightByProgActualUOM");

                entity.Property(e => e.AccuWeightByProgTargetUom)
                    .HasMaxLength(255)
                    .HasColumnName("AccuWeightByProgTargetUOM");

                entity.Property(e => e.AccuWeightType).HasMaxLength(100);

                entity.Property(e => e.AccumulateType).HasMaxLength(100);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.FrequencyType).HasMaxLength(100);

                entity.Property(e => e.FrequnecyValue).HasMaxLength(255);

                entity.Property(e => e.ProductType).HasMaxLength(100);

                entity.Property(e => e.TmkprogramDesc)
                    .HasMaxLength(255)
                    .HasColumnName("TMKProgramDesc");

                entity.Property(e => e.TmkprogramId)
                    .HasMaxLength(100)
                    .HasColumnName("TMKProgramId");

                entity.Property(e => e.TmkprogramLevelDesc)
                    .HasMaxLength(255)
                    .HasColumnName("TMKProgramLevelDesc");

                entity.Property(e => e.TmkprogramLevelId)
                    .HasMaxLength(100)
                    .HasColumnName("TMKProgramLevelId");

                entity.Property(e => e.TmkprogramType)
                    .HasMaxLength(100)
                    .HasColumnName("TMKProgramType");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<BlPnM>(entity =>
            {
                entity.ToTable("BL_PnM");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerId).HasMaxLength(255);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.SalesPeriod).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValueType).HasMaxLength(255);
            });

            modelBuilder.Entity<BlRawPo>(entity =>
            {
                entity.ToTable("BL_RawPOs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.Channels).HasMaxLength(255);

                entity.Property(e => e.ConfirmedBaseUom)
                    .HasMaxLength(50)
                    .HasColumnName("ConfirmedBaseUOM");

                entity.Property(e => e.ConfirmedUom)
                    .HasMaxLength(50)
                    .HasColumnName("ConfirmedUOM");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountSchemeId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(50);

                entity.Property(e => e.DistributorName).HasMaxLength(250);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShiptoId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(50)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.Erpid)
                    .HasMaxLength(50)
                    .HasColumnName("ERPId");

                entity.Property(e => e.ExpectReDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Grpodate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("GRPODate");

                entity.Property(e => e.Grponumber)
                    .HasMaxLength(50)
                    .HasColumnName("GRPONumber");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(250);

                entity.Property(e => e.InventoryReportName).HasMaxLength(50);

                entity.Property(e => e.InventoryShortName).HasMaxLength(50);

                entity.Property(e => e.ItemGroupId).HasMaxLength(50);

                entity.Property(e => e.ItemId).HasMaxLength(50);

                entity.Property(e => e.OrderBaseUom)
                    .HasMaxLength(50)
                    .HasColumnName("OrderBaseUOM");

                entity.Property(e => e.OrderUom)
                    .HasMaxLength(50)
                    .HasColumnName("OrderUOM");

                entity.Property(e => e.PoPrincipalNumber).HasMaxLength(50);

                entity.Property(e => e.PoconfirmDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("POConfirmDate");

                entity.Property(e => e.PoconfirmDescription)
                    .HasMaxLength(250)
                    .HasColumnName("POConfirmDescription");

                entity.Property(e => e.PoconfirmNumber)
                    .HasMaxLength(50)
                    .HasColumnName("POConfirmNumber");

                entity.Property(e => e.Podescription)
                    .HasMaxLength(250)
                    .HasColumnName("PODescription");

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.PrincipalRefNumber).HasMaxLength(50);

                entity.Property(e => e.PrincipalWareHouseId).HasMaxLength(100);

                entity.Property(e => e.PromotionFullName).HasMaxLength(255);

                entity.Property(e => e.PromotionId).HasMaxLength(50);

                entity.Property(e => e.PromotionScheme).HasMaxLength(255);

                entity.Property(e => e.PromotionShortName).HasMaxLength(255);

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiptBaseUom)
                    .HasMaxLength(50)
                    .HasColumnName("ReceiptBaseUOM");

                entity.Property(e => e.ReceiptUom)
                    .HasMaxLength(50)
                    .HasColumnName("ReceiptUOM");

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SicId).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubChanels).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatId).HasMaxLength(50);
            });

            modelBuilder.Entity<BlRawSo>(entity =>
            {
                entity.ToTable("BL_RawSOs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaManagerEmpName).HasMaxLength(255);

                entity.Property(e => e.AreaManagerId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaseUnitDesc).HasMaxLength(255);

                entity.Property(e => e.BaseUnitId).HasMaxLength(100);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchManagerEmpName).HasMaxLength(255);

                entity.Property(e => e.BranchManagerId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CancelDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CompletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CusShiptoAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeId1).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId10).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId2).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId3).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId4).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId5).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId6).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId7).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId8).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeId9).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeName1).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName10).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName2).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName3).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName4).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName5).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName6).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName7).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName8).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeName9).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.CusShiptoAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.CustomerAddress).HasMaxLength(255);

                entity.Property(e => e.CustomerCitysDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerCitysId).HasMaxLength(100);

                entity.Property(e => e.CustomerCitysShortName).HasMaxLength(255);

                entity.Property(e => e.CustomerCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerCountrysId).HasMaxLength(100);

                entity.Property(e => e.CustomerCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.CustomerDeptNo).HasMaxLength(255);

                entity.Property(e => e.CustomerDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerDistrictsId).HasMaxLength(100);

                entity.Property(e => e.CustomerDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasMaxLength(100);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerPhone).HasMaxLength(255);

                entity.Property(e => e.CustomerProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerProvincesId).HasMaxLength(100);

                entity.Property(e => e.CustomerProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoCityId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoCountryDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoCountryId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoDeptNo).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoDistrictDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoDistrictId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoLattitue).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoLongtiue).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoProvinceDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoProvinceId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoStateDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoStateId).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoStreet).HasMaxLength(100);

                entity.Property(e => e.CustomerShiptoWardDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerShiptoWardId).HasMaxLength(100);

                entity.Property(e => e.CustomerStatesDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerStatesId).HasMaxLength(100);

                entity.Property(e => e.CustomerStatesShortName).HasMaxLength(255);

                entity.Property(e => e.CustomerStreet).HasMaxLength(255);

                entity.Property(e => e.CustomerWardsDesc).HasMaxLength(255);

                entity.Property(e => e.CustomerWardsId).HasMaxLength(100);

                entity.Property(e => e.CustomerWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DiscountFullName).HasMaxLength(255);

                entity.Property(e => e.DiscountFullShortName).HasMaxLength(255);

                entity.Property(e => e.DiscountId).HasMaxLength(100);

                entity.Property(e => e.DiscountScheme).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistyBillToId).HasMaxLength(100);

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.DsamanagerEmpName)
                    .HasMaxLength(255)
                    .HasColumnName("DSAManagerEmpName");

                entity.Property(e => e.DsamanagerId)
                    .HasMaxLength(100)
                    .HasColumnName("DSAManagerId");

                entity.Property(e => e.Erpid)
                    .HasMaxLength(100)
                    .HasColumnName("ERPId");

                entity.Property(e => e.ExpectDeliveryNote).HasMaxLength(255);

                entity.Property(e => e.ExpectShippedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryId).HasMaxLength(100);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.IsKit).HasColumnName("IsKIT");

                entity.Property(e => e.ItemGroupDesc).HasMaxLength(255);

                entity.Property(e => e.ItemGroupId).HasMaxLength(100);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.KitKey).HasMaxLength(255);

                entity.Property(e => e.Kitdescription)
                    .HasMaxLength(255)
                    .HasColumnName("KITDescription");

                entity.Property(e => e.Kitid)
                    .HasMaxLength(100)
                    .HasColumnName("KITId");

                entity.Property(e => e.KitshortName)
                    .HasMaxLength(255)
                    .HasColumnName("KITShortName");

                entity.Property(e => e.LastedDeliveryNotePrintDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LocationDesc).HasMaxLength(255);

                entity.Property(e => e.LocationId).HasMaxLength(100);

                entity.Property(e => e.MenuType).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.NsdmanagerEmpName)
                    .HasMaxLength(255)
                    .HasColumnName("NSDManagerEmpName");

                entity.Property(e => e.NsdmanagerId)
                    .HasMaxLength(100)
                    .HasColumnName("NSDManagerId");

                entity.Property(e => e.OrdSkus).HasColumnName("OrdSKUs");

                entity.Property(e => e.OrderDescription).HasMaxLength(255);

                entity.Property(e => e.OrderRefNumber).HasMaxLength(50);

                entity.Property(e => e.OrderType).HasMaxLength(100);

                entity.Property(e => e.OrigOrdSkus).HasColumnName("OrigOrdSKUs");

                entity.Property(e => e.PrincipalDesc).HasMaxLength(255);

                entity.Property(e => e.PrincipalId).HasMaxLength(100);

                entity.Property(e => e.ProgramCustomersDetailId).HasMaxLength(100);

                entity.Property(e => e.ProgramCustomersFullName).HasMaxLength(255);

                entity.Property(e => e.ProgramCustomersShortName).HasMaxLength(255);

                entity.Property(e => e.PromotionFullName).HasMaxLength(255);

                entity.Property(e => e.PromotionId).HasMaxLength(100);

                entity.Property(e => e.PromotionScheme).HasMaxLength(255);

                entity.Property(e => e.PromotionShortName).HasMaxLength(255);

                entity.Property(e => e.PurchaseUnitDesc).HasMaxLength(255);

                entity.Property(e => e.PurchaseUnitId).HasMaxLength(100);

                entity.Property(e => e.ReasonDesc).HasMaxLength(255);

                entity.Property(e => e.ReasonId).HasMaxLength(100);

                entity.Property(e => e.RecordPerformanceUpdateBy).HasMaxLength(255);

                entity.Property(e => e.RecordPerformanceUpdateDateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ReferenceRefNbr).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionManagerEmpName).HasMaxLength(255);

                entity.Property(e => e.RegionManagerId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.ReturnNbr).HasMaxLength(100);

                entity.Property(e => e.RewardDescription).HasMaxLength(255);

                entity.Property(e => e.RewardId).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RouteZoneType).HasMaxLength(100);

                entity.Property(e => e.RouteZonelocation).HasMaxLength(100);

                entity.Property(e => e.RzsuppervisorEmpName)
                    .HasMaxLength(255)
                    .HasColumnName("RZSuppervisorEmpName");

                entity.Property(e => e.RzsuppervisorId)
                    .HasMaxLength(100)
                    .HasColumnName("RZSuppervisorId");

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriodId).HasMaxLength(50);

                entity.Property(e => e.SalesRepEmpName).HasMaxLength(255);

                entity.Property(e => e.SalesRepId).HasMaxLength(100);

                entity.Property(e => e.SalesUnitDesc).HasMaxLength(255);

                entity.Property(e => e.SalesUnitId).HasMaxLength(100);

                entity.Property(e => e.ShippedSkus).HasColumnName("Shipped_SKUs");

                entity.Property(e => e.Sicdesc)
                    .HasMaxLength(255)
                    .HasColumnName("SICDesc");

                entity.Property(e => e.Sicid)
                    .HasMaxLength(100)
                    .HasColumnName("SICId");

                entity.Property(e => e.SocreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("SOCreatedBy");

                entity.Property(e => e.SoownerId)
                    .HasMaxLength(100)
                    .HasColumnName("SOOwnerId");

                entity.Property(e => e.Sosource)
                    .HasMaxLength(100)
                    .HasColumnName("SOSource");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaManagerEmpName).HasMaxLength(255);

                entity.Property(e => e.SubAreaManagerId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionManagerEmpName).HasMaxLength(255);

                entity.Property(e => e.SubRegionManagerId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.TotalVat).HasColumnName("TotalVAT");

                entity.Property(e => e.TradePromotionType).HasMaxLength(100);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Uom)
                    .HasMaxLength(100)
                    .HasColumnName("UOM");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatid)
                    .HasMaxLength(100)
                    .HasColumnName("VATId");

                entity.Property(e => e.Vatvalue).HasColumnName("VATValue");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitId).HasMaxLength(255);

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlReceiptQty>(entity =>
            {
                entity.ToTable("BL_ReceiptQtys");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaseLineType).HasMaxLength(50);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BaselineSettingRef).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToLattitue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToLongtiue).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(100)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.InBaseUom)
                    .HasMaxLength(255)
                    .HasColumnName("InBaseUOM");

                entity.Property(e => e.InPurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("InPurchaseUOM");

                entity.Property(e => e.InQuantityType).HasMaxLength(50);

                entity.Property(e => e.InQuantityTypeDesc).HasMaxLength(255);

                entity.Property(e => e.InQuantityTypeValue).HasMaxLength(255);

                entity.Property(e => e.InSalesUom)
                    .HasMaxLength(100)
                    .HasColumnName("InSalesUOM");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.ItemGroupDesc).HasMaxLength(255);

                entity.Property(e => e.ItemGroupId).HasMaxLength(100);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.LocationId).HasMaxLength(100);

                entity.Property(e => e.Month).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.SalesPeriod).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseId).HasMaxLength(100);

                entity.Property(e => e.WareHouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlRunningSale>(entity =>
            {
                entity.ToTable("BL_RunningSales");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.BaselineDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.Chanels).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShiptoId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(100)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.Erpid)
                    .HasMaxLength(100)
                    .HasColumnName("ERPId");

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.PrincipalDesc).HasMaxLength(255);

                entity.Property(e => e.PrincipalId).HasMaxLength(100);

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RunningSalesBaseUom)
                    .HasMaxLength(255)
                    .HasColumnName("RunningSalesBaseUOM");

                entity.Property(e => e.RunningSalesPurchaseUom)
                    .HasMaxLength(255)
                    .HasColumnName("RunningSalesPurchaseUOM");

                entity.Property(e => e.RunningSalesSalesUom)
                    .HasMaxLength(255)
                    .HasColumnName("RunningSalesSalesUOM");

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubChanels).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlSafetyStockAssessment>(entity =>
            {
                entity.ToTable("BL_SafetyStockAssessments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.AssessmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BranchId).HasMaxLength(100);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.Chanels).HasMaxLength(255);

                entity.Property(e => e.CloseQuantityBaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("CloseQuantityBaseUOM");

                entity.Property(e => e.CloseQuantityByBaseUom).HasColumnName("CloseQuantityByBaseUOM");

                entity.Property(e => e.CloseQuantityByPurchaseUom).HasColumnName("CloseQuantityByPurchaseUOM");

                entity.Property(e => e.CloseQuantityPurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("CloseQuantityPurchaseUOM");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(100);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCitysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCitysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToCountrysId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToCountrysShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDeptNo).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToDistrictsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToDistrictsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToFullName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToProvincesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToProvincesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorShipToWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorShipToWardsShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorShiptoId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorStatesId).HasMaxLength(100);

                entity.Property(e => e.DistributorStatesShortName).HasMaxLength(255);

                entity.Property(e => e.DistributorStreet).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsDesc).HasMaxLength(255);

                entity.Property(e => e.DistributorWardsId).HasMaxLength(100);

                entity.Property(e => e.DistributorWardsShortName).HasMaxLength(255);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(100)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Dsadesc)
                    .HasMaxLength(255)
                    .HasColumnName("DSADesc");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(100)
                    .HasColumnName("DSAId");

                entity.Property(e => e.Erpid)
                    .HasMaxLength(100)
                    .HasColumnName("ERPId");

                entity.Property(e => e.InventoryAttributeDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeId9).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeName1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeName9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc1).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc10).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc2).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc3).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc4).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc5).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc6).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc7).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc8).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueDesc9).HasMaxLength(255);

                entity.Property(e => e.InventoryAttributeValueId1).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId10).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId2).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId3).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId4).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId5).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId6).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId7).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId8).HasMaxLength(100);

                entity.Property(e => e.InventoryAttributeValueId9).HasMaxLength(100);

                entity.Property(e => e.InventoryDescription).HasMaxLength(255);

                entity.Property(e => e.InventoryReportName).HasMaxLength(255);

                entity.Property(e => e.InventoryShortName).HasMaxLength(255);

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.PrincipalDesc).HasMaxLength(255);

                entity.Property(e => e.PrincipalId).HasMaxLength(100);

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(100);

                entity.Property(e => e.RegionId).HasMaxLength(100);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RouteZoneDesc).HasMaxLength(255);

                entity.Property(e => e.RouteZoneId).HasMaxLength(100);

                entity.Property(e => e.RunningSalesBaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("RunningSalesBaseUOM");

                entity.Property(e => e.RunningSalesPurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("RunningSalesPurchaseUOM");

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(100)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SskdayBaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("SSKDayBaseUOM");

                entity.Property(e => e.SskdayPurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("SSKDayPurchaseUOM");

                entity.Property(e => e.SskdayQtyByBaseUom).HasColumnName("SSKDayQtyByBaseUOM");

                entity.Property(e => e.SskdayQtyByPruchaseUom).HasColumnName("SSKDayQtyByPruchaseUOM");

                entity.Property(e => e.SubAreaId).HasMaxLength(100);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubChanels).HasMaxLength(255);

                entity.Property(e => e.SubRegionId).HasMaxLength(100);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WarehouseId).HasMaxLength(100);

                entity.Property(e => e.WarehouseName).HasMaxLength(255);
            });

            modelBuilder.Entity<BlSalesIndicator>(entity =>
            {
                entity.ToTable("BL_SalesIndicators");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Siid)
                    .HasMaxLength(50)
                    .HasColumnName("SIID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CityCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CleanDataConfigure>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Operation).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Competitor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompetitorCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ConditionstoExcludeSc>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.Hobbies).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(11);
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ContainerName).HasMaxLength(256);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IpAddress).HasMaxLength(36);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CronJobSchedule>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.NextFireTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PreviousFireTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CustomerAdjustment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentId).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CustomerAdjustmentDataType>(entity =>
            {
                entity.ToTable("CustomerAdjustmentDataType");

                entity.HasIndex(e => e.CustomerAdjustmentId, "IX_CustomerAdjustmentDataType_CustomerAdjustmentId");

                entity.HasIndex(e => e.DataTypeDefinitionId, "IX_CustomerAdjustmentDataType_DataTypeDefinitionId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAdjustment)
                    .WithMany(p => p.CustomerAdjustmentDataTypes)
                    .HasForeignKey(d => d.CustomerAdjustmentId)
                    .HasConstraintName("FK_CustomerAdjustmentDataType_CustomerAdjustments_CustomerAdju~");

                entity.HasOne(d => d.DataTypeDefinition)
                    .WithMany(p => p.CustomerAdjustmentDataTypes)
                    .HasForeignKey(d => d.DataTypeDefinitionId)
                    .HasConstraintName("FK_CustomerAdjustmentDataType_DataTypeDefinition_DataTypeDefin~");
            });

            modelBuilder.Entity<CustomerAdjustmentShipto>(entity =>
            {
                entity.ToTable("CustomerAdjustmentShipto");

                entity.HasIndex(e => e.CustomerAdjustmentId, "IX_CustomerAdjustmentShipto_CustomerAdjustmentId");

                entity.HasIndex(e => e.CustomerShiptoId, "IX_CustomerAdjustmentShipto_CustomerShiptoId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SaleMan).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAdjustment)
                    .WithMany(p => p.CustomerAdjustmentShiptos)
                    .HasForeignKey(d => d.CustomerAdjustmentId)
                    .HasConstraintName("FK_CustomerAdjustmentShipto_CustomerAdjustments_CustomerAdjust~");

                entity.HasOne(d => d.CustomerShipto)
                    .WithMany(p => p.CustomerAdjustmentShiptos)
                    .HasForeignKey(d => d.CustomerShiptoId);
            });

            modelBuilder.Entity<CustomerApplyToValue>(entity =>
            {
                entity.HasIndex(e => e.CustomerAdjustmentId, "IX_CustomerApplyToValues_CustomerAdjustmentId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAdjustment)
                    .WithMany(p => p.CustomerApplyToValues)
                    .HasForeignKey(d => d.CustomerAdjustmentId)
                    .HasConstraintName("FK_CustomerApplyToValues_CustomerAdjustments_CustomerAdjustmen~");
            });

            modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                entity.HasIndex(e => e.CustomerSettingId, "IX_CustomerAttributes_CustomerSettingId");

                entity.HasIndex(e => e.ParentCustomerAttributeId, "IX_CustomerAttributes_ParentCustomerAttributeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeMaster).HasMaxLength(30);

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerSetting)
                    .WithMany(p => p.CustomerAttributes)
                    .HasForeignKey(d => d.CustomerSettingId);

                entity.HasOne(d => d.ParentCustomerAttribute)
                    .WithMany(p => p.InverseParentCustomerAttribute)
                    .HasForeignKey(d => d.ParentCustomerAttributeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomerAttributes_CustomerAttributes_ParentCustomerAttribu~");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.HasIndex(e => e.CustomerInfomationId, "IX_CustomerContacts_CustomerInfomationId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContactCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayName).HasMaxLength(300);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(300);

                entity.Property(e => e.Hobbies).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerInfomation)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerInfomationId);
            });

            modelBuilder.Entity<CustomerContactEmail>(entity =>
            {
                entity.HasIndex(e => e.CustomerContactId, "IX_CustomerContactEmails_CustomerContactId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerContact)
                    .WithMany(p => p.CustomerContactEmails)
                    .HasForeignKey(d => d.CustomerContactId);
            });

            modelBuilder.Entity<CustomerContactPhone>(entity =>
            {
                entity.HasIndex(e => e.CustomerContactId, "IX_CustomerContactPhones_CustomerContactId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerContact)
                    .WithMany(p => p.CustomerContactPhones)
                    .HasForeignKey(d => d.CustomerContactId);
            });

            modelBuilder.Entity<CustomerContract>(entity =>
            {
                entity.HasIndex(e => e.CustomerId, "IX_CustomerContracts_CustomerId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContractEffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ContractEndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ContractId).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContracts)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerDmsAttribute>(entity =>
            {
                entity.ToTable("CustomerDmsAttribute");

                entity.HasIndex(e => e.CustomerShiptoId, "IX_CustomerDmsAttribute_CustomerShiptoId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerDmsAttributes)
                    .HasForeignKey(d => d.CustomerAttributeId);

                entity.HasOne(d => d.CustomerShipto)
                    .WithMany(p => p.CustomerDmsAttributes)
                    .HasForeignKey(d => d.CustomerShiptoId);
            });

            modelBuilder.Entity<CustomerHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.NodeId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CustomerHierarchyMapping>(entity =>
            {
                entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerHierarchyMappings_CustomerAttributeId");

                entity.HasIndex(e => e.CustomerHierarchyId, "IX_CustomerHierarchyMappings_CustomerHierarchyId");

                entity.HasIndex(e => e.CustomerSettingHierarchyId, "IX_CustomerHierarchyMappings_CustomerSettingHierarchyId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerHierarchyMappings)
                    .HasForeignKey(d => d.CustomerAttributeId)
                    .HasConstraintName("FK_CustomerHierarchyMappings_CustomerAttributes_CustomerAttrib~");

                entity.HasOne(d => d.CustomerHierarchy)
                    .WithMany(p => p.CustomerHierarchyMappings)
                    .HasForeignKey(d => d.CustomerHierarchyId)
                    .HasConstraintName("FK_CustomerHierarchyMappings_CustomerHierarchies_CustomerHiera~");

                entity.HasOne(d => d.CustomerSettingHierarchy)
                    .WithMany(p => p.CustomerHierarchyMappings)
                    .HasForeignKey(d => d.CustomerSettingHierarchyId)
                    .HasConstraintName("FK_CustomerHierarchyMappings_CustomerSettingHierarchies_Custom~");
            });

            modelBuilder.Entity<CustomerInformation>(entity =>
            {
                entity.HasIndex(e => e.CustomerCode, "IX_CustomerInformations_CustomerCode")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BankAccount).HasMaxLength(80);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.BankNumber).HasMaxLength(20);

                entity.Property(e => e.BusinessAddress).HasMaxLength(255);

                entity.Property(e => e.CodeAtDistributor).HasMaxLength(10);

                entity.Property(e => e.CodeAtVendor).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(11);

                entity.Property(e => e.ErpCode).HasMaxLength(10);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(300);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LegalInformation).HasMaxLength(255);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CustomerSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeId)
                    .HasMaxLength(5)
                    .HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName).HasMaxLength(30);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<CustomerSettingHierarchy>(entity =>
            {
                entity.HasIndex(e => e.CustomerSettingId, "IX_CustomerSettingHierarchies_CustomerSettingId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerSetting)
                    .WithMany(p => p.CustomerSettingHierarchies)
                    .HasForeignKey(d => d.CustomerSettingId)
                    .HasConstraintName("FK_CustomerSettingHierarchies_CustomerSettings_CustomerSetting~");
            });

            modelBuilder.Entity<CustomerShipto>(entity =>
            {
                entity.HasIndex(e => e.CustomerInfomationId, "IX_CustomerShiptos_CustomerInfomationId");

                entity.HasIndex(e => new { e.ShiptoCode, e.CustomerInfomationId }, "IX_CustomerShiptos_ShiptoCode_CustomerInfomationId")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShiptoCode).HasMaxLength(4);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerInfomation)
                    .WithMany(p => p.CustomerShiptos)
                    .HasForeignKey(d => d.CustomerInfomationId);
            });

            modelBuilder.Entity<CustomerShiptoContact>(entity =>
            {
                entity.HasIndex(e => e.CustomerContactId, "IX_CustomerShiptoContacts_CustomerContactId");

                entity.HasIndex(e => e.CustomerShiptoId, "IX_CustomerShiptoContacts_CustomerShiptoId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerContact)
                    .WithMany(p => p.CustomerShiptoContacts)
                    .HasForeignKey(d => d.CustomerContactId);

                entity.HasOne(d => d.CustomerShipto)
                    .WithMany(p => p.CustomerShiptoContacts)
                    .HasForeignKey(d => d.CustomerShiptoId);
            });

            modelBuilder.Entity<DataLog>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FieldName).HasMaxLength(256);

                entity.Property(e => e.NewValue).HasMaxLength(256);

                entity.Property(e => e.ObjectId).HasMaxLength(36);

                entity.Property(e => e.ObjectName).HasMaxLength(150);

                entity.Property(e => e.OldValue).HasMaxLength(256);
            });

            modelBuilder.Entity<DataProtectionKey>(entity =>
            {
                entity.HasIndex(e => e.FriendlyName, "DataProtectionKeys_FriendlyName_key")
                    .IsUnique();
            });

            modelBuilder.Entity<DataTypeDefinition>(entity =>
            {
                entity.ToTable("DataTypeDefinition");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisApproveRegistrationCustomer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdditionalRegistrationDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);
            });

            modelBuilder.Entity<DisApproveRegistrationCustomerDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.CustomerShipToCode).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevel).HasMaxLength(10);

                entity.Property(e => e.RejectDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RejectFileExt).HasMaxLength(50);

                entity.Property(e => e.RejectFileName).HasMaxLength(255);

                entity.Property(e => e.RejectFilePath).HasMaxLength(1000);

                entity.Property(e => e.RejectFolderType).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<DisBudget>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.AdjustmentsAccount).HasMaxLength(100);

                entity.Property(e => e.AdjustmentsFileExt).HasMaxLength(50);

                entity.Property(e => e.AdjustmentsFileName).HasMaxLength(255);

                entity.Property(e => e.AdjustmentsFilePath).HasMaxLength(1000);

                entity.Property(e => e.AdjustmentsFolderType).HasMaxLength(50);

                entity.Property(e => e.AdjustmentsReason).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisBudgetForCusAttribute>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerLevel).HasMaxLength(10);

                entity.Property(e => e.CustomerValue).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.ScopeValue).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisBudgetForScopeDsa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.ScopeValue).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisBudgetForScopeTerritory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.ScopeValue).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisBudgetUsed>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DsacodeCode).HasColumnName("DSACodeCode");
            });

            modelBuilder.Entity<DisConfirmResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.SalesCalendarCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisConfirmResultDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.DisConfirmResultCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisCriteriaEvaluatePictureDisplay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CriteriaDescription).HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisCustomerAttributeLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisCustomerAttributeValue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.CustomerAttributerValue).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisCustomerShipto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.TotalSalePointWithPosm).HasColumnName("TotalSalePointWithPOSM");

                entity.Property(e => e.TotalSalePointWithoutPosm).HasColumnName("TotalSalePointWithoutPOSM");

                entity.Property(e => e.TypeSalePoint).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisCustomerShiptoDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(200);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.InventoryItemCode).HasMaxLength(10);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.RouteZoneCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrgCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisDefinitionCriteriaEvaluate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CriteriaCode).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisDefinitionGuideImage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.ImageFileExt).HasMaxLength(50);

                entity.Property(e => e.ImageFolderType).HasMaxLength(50);

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.ImagePath).HasMaxLength(1000);

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisDefinitionProductTypeDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.Packing).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.ProductType).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisDefinitionStructure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BonusGiftProductType).HasMaxLength(10);

                entity.Property(e => e.Conditon).HasMaxLength(2);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.ImagesRegisterFileExt).HasMaxLength(50);

                entity.Property(e => e.ImagesRegisterFolderType).HasMaxLength(50);

                entity.Property(e => e.ImagesRegisterName).HasMaxLength(200);

                entity.Property(e => e.ImagesRegisterPath).HasMaxLength(1000);

                entity.Property(e => e.IsImagesOk).HasColumnName("IsImagesOK");

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.LevelName).HasMaxLength(255);

                entity.Property(e => e.PercentImagesOk).HasColumnName("PercentImagesOK");

                entity.Property(e => e.ProductTypeForDisplay).HasMaxLength(10);

                entity.Property(e => e.RewardProductType).HasMaxLength(10);

                entity.Property(e => e.SalesOutputProductType).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UseWeightsType).HasMaxLength(10);
            });

            modelBuilder.Entity<DisDisplay>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplicableObjectType).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileExtReasonCloseProgram).HasMaxLength(50);

                entity.Property(e => e.FileNameReasonCloseProgram).HasMaxLength(200);

                entity.Property(e => e.FilePathReasonCloseProgram).HasMaxLength(1000);

                entity.Property(e => e.FolderTypeReasonCloseProgram).HasMaxLength(50);

                entity.Property(e => e.FrequencyDisplay).HasMaxLength(10);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Image1FileExt).HasMaxLength(50);

                entity.Property(e => e.Image1FolderType).HasMaxLength(50);

                entity.Property(e => e.Image1Name).HasMaxLength(200);

                entity.Property(e => e.Image1Path).HasMaxLength(1000);

                entity.Property(e => e.Image2FileExt).HasMaxLength(50);

                entity.Property(e => e.Image2FolderType).HasMaxLength(50);

                entity.Property(e => e.Image2Name).HasMaxLength(200);

                entity.Property(e => e.Image2Path).HasMaxLength(1000);

                entity.Property(e => e.Image3FileExt).HasMaxLength(50);

                entity.Property(e => e.Image3FolderType).HasMaxLength(50);

                entity.Property(e => e.Image3Name).HasMaxLength(200);

                entity.Property(e => e.Image3Path).HasMaxLength(1000);

                entity.Property(e => e.Image4FileExt).HasMaxLength(50);

                entity.Property(e => e.Image4FolderType).HasMaxLength(50);

                entity.Property(e => e.Image4Name).HasMaxLength(200);

                entity.Property(e => e.Image4Path).HasMaxLength(1000);

                entity.Property(e => e.ImplementationEndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ImplementationStartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ProgramCloseDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ReasonCloseProgram).HasMaxLength(200);

                entity.Property(e => e.RegistrationEndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RegistrationStartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.ScopeSaleTerritoryLevel).HasMaxLength(200);

                entity.Property(e => e.ScopeType).HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.SicCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TerritoryStructureCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisPayReward>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.ConfirmResultDisplayCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisPayRewardDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CustomerShiptoCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DisPayRewardCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DisplayLevelCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.PackingCode).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.ProductType).HasMaxLength(10);

                entity.Property(e => e.RewardType).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisScopeDsa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ScopeDsaValue).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisScopeTerritory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SaleTerritoryLevel)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SalesTerritoryValue).HasMaxLength(10);

                entity.Property(e => e.TerritoryStructureCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisSettlement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.EndDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RewardPeriodCode).HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisSettlementDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerId).HasMaxLength(10);

                entity.Property(e => e.DisSettlementCode).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevel).HasMaxLength(10);

                entity.Property(e => e.DistributorCode).HasMaxLength(10);

                entity.Property(e => e.OrdDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PackageCode).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.ShiptoId).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DisWeightGetExtraRewardsDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.Packing).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WeightCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<DistCache>(entity =>
            {
                entity.ToTable("DistCache");
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttentionEmailValue).HasMaxLength(80);

                entity.Property(e => e.AttentionFirstName).HasMaxLength(10);

                entity.Property(e => e.AttentionFullName).HasMaxLength(200);

                entity.Property(e => e.AttentionLastName).HasMaxLength(40);

                entity.Property(e => e.AttentionMiddleName).HasMaxLength(10);

                entity.Property(e => e.AttentionPhoneValue).HasMaxLength(11);

                entity.Property(e => e.BankAccount).HasMaxLength(80);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.BankNumber).HasMaxLength(20);

                entity.Property(e => e.BusinessAddressDept).HasMaxLength(100);

                entity.Property(e => e.BusinessAddressStreet).HasMaxLength(1000);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DateTimeImport).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Dmscode)
                    .HasMaxLength(10)
                    .HasColumnName("DMSCode");

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.Fax).HasMaxLength(12);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NumberOfAccountingNp).HasColumnName("NumberOfAccountingNP");

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.PrincipalLinkedCode).HasMaxLength(10);

                entity.Property(e => e.TaxCode).HasMaxLength(14);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidFrom)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Website).HasMaxLength(80);
            });

            modelBuilder.Entity<DistributorContact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContactCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DepartmentNumber).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.FirstName).HasMaxLength(10);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Hobbies).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.Street).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.DistributorContacts)
                    .HasForeignKey(d => d.DistributorId);
            });

            modelBuilder.Entity<DistributorContract>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BilltoCode).HasMaxLength(10);

                entity.Property(e => e.ContractCode).HasMaxLength(10);

                entity.Property(e => e.ContractDescription).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileExt).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FilePath).HasMaxLength(1000);

                entity.Property(e => e.FolderType).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.DistributorContracts)
                    .HasForeignKey(d => d.DistributorId);
            });

            modelBuilder.Entity<DistributorHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.NodeId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DistributorHierarchyMapping>(entity =>
            {
                entity.HasIndex(e => e.CustomerAttributeId, "IX_DistributorHierarchyMappings_CustomerAttributeId");

                entity.HasIndex(e => e.CustomerSettingHierarchyId, "IX_DistributorHierarchyMappings_CustomerSettingHierarchyId");

                entity.HasIndex(e => e.DistributorHierarchyId, "IX_DistributorHierarchyMappings_DistributorHierarchyId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.DistributorHierarchyMappings)
                    .HasForeignKey(d => d.CustomerAttributeId)
                    .HasConstraintName("FK_DistributorHierarchyMappings_CustomerAttributes_CustomerAtt~");

                entity.HasOne(d => d.CustomerSettingHierarchy)
                    .WithMany(p => p.DistributorHierarchyMappings)
                    .HasForeignKey(d => d.CustomerSettingHierarchyId)
                    .HasConstraintName("FK_DistributorHierarchyMappings_CustomerSettingHierarchies_Cus~");

                entity.HasOne(d => d.DistributorHierarchy)
                    .WithMany(p => p.DistributorHierarchyMappings)
                    .HasForeignKey(d => d.DistributorHierarchyId)
                    .HasConstraintName("FK_DistributorHierarchyMappings_DistributorHierarchies_Distrib~");
            });

            modelBuilder.Entity<DistributorHistorical>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BilltoCodeonErp).HasColumnName("BilltoCodeonERP");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.DistributorHistoricals)
                    .HasForeignKey(d => d.DistributorId);

                entity.HasOne(d => d.DistributorShipto)
                    .WithMany(p => p.DistributorHistoricals)
                    .HasForeignKey(d => d.DistributorShiptoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DistributorHistoricals_DistributorShiptos_DistributorShipto~");
            });

            modelBuilder.Entity<DistributorPriceApplyToOutletAttribute>(entity =>
            {
                entity.HasIndex(e => e.DistributorPriceVolumeId, "IX_DistributorPriceApplyToOutletAttributes_DistributorPriceVol~");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.DistributorPriceVolume)
                    .WithMany(p => p.DistributorPriceApplyToOutletAttributes)
                    .HasForeignKey(d => d.DistributorPriceVolumeId)
                    .HasConstraintName("FK_DistributorPriceApplyToOutletAttributes_DistributorPriceVol~");
            });

            modelBuilder.Entity<DistributorPriceItemGroup>(entity =>
            {
                entity.HasIndex(e => e.DistributorPriceVolumeId, "IX_DistributorPriceItemGroups_DistributorPriceVolumeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.DistributorPriceVolume)
                    .WithMany(p => p.DistributorPriceItemGroups)
                    .HasForeignKey(d => d.DistributorPriceVolumeId)
                    .HasConstraintName("FK_DistributorPriceItemGroups_DistributorPriceVolumes_Distribu~");
            });

            modelBuilder.Entity<DistributorPriceVolume>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpirationTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DistributorPriceVolumeLevel>(entity =>
            {
                entity.HasIndex(e => e.DistributorPriceVolumeId, "IX_DistributorPriceVolumeLevels_DistributorPriceVolumeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.DistributorPriceVolume)
                    .WithMany(p => p.DistributorPriceVolumeLevels)
                    .HasForeignKey(d => d.DistributorPriceVolumeId)
                    .HasConstraintName("FK_DistributorPriceVolumeLevels_DistributorPriceVolumes_Distri~");
            });

            modelBuilder.Entity<DistributorSellingArea>(entity =>
            {
                entity.HasIndex(e => e.TerritoryMappingId, "IX_DistributorSellingAreas_TerritoryMappingId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.TerritoryMapping)
                    .WithMany(p => p.DistributorSellingAreas)
                    .HasForeignKey(d => d.TerritoryMappingId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DistributorShipto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DepartmentNumber).HasMaxLength(100);

                entity.Property(e => e.FileExt).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FilePath).HasMaxLength(1000);

                entity.Property(e => e.FolderType).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.ShiptoCode).HasMaxLength(4);

                entity.Property(e => e.ShiptoCodeOnErp)
                    .HasMaxLength(14)
                    .HasColumnName("ShiptoCodeOnERP");

                entity.Property(e => e.ShiptoName).HasMaxLength(80);

                entity.Property(e => e.Street).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.DistributorShiptos)
                    .HasForeignKey(d => d.DistributorId);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.DistrictCode).HasMaxLength(10);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DropSizeRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.RecognizedDateForPsov).HasColumnName("RecognizedDateForPSOV");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.SovinvoiceValue).HasColumnName("SOVInvoiceValue");

                entity.Property(e => e.SovnoofSku).HasColumnName("SOVNoofSKU");
            });

            modelBuilder.Entity<DsaDelivery>(entity =>
            {
                entity.ToTable("DSA_Deliveries");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DsaDistributorSellingArea>(entity =>
            {
                entity.ToTable("DSA_DistributorSellingAreas");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SostructureCode).HasColumnName("SOStructureCode");

                entity.Property(e => e.TypeDsa).HasColumnName("TypeDSA");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DsaGeographicalMapping>(entity =>
            {
                entity.ToTable("DSA_GeographicalMapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DsaSalesTeamAssignment>(entity =>
            {
                entity.ToTable("DSA_SalesTeamAssignments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsSicbase).HasColumnName("IsSICBase");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DsadistributorShipTo>(entity =>
            {
                entity.ToTable("DSADistributorShipTos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Dsageographical>(entity =>
            {
                entity.ToTable("DSAGeographicals");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<DynamicFieldConfigure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::text");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<EcoLocalization>(entity =>
            {
                entity.ToTable("EcoLocalization");

                entity.Property(e => e.Comment).HasMaxLength(512);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileName).HasMaxLength(128);

                entity.Property(e => e.LocaleId).HasMaxLength(10);

                entity.Property(e => e.PrincipalCode).HasMaxLength(5);

                entity.Property(e => e.ResourceId).HasMaxLength(1024);

                entity.Property(e => e.ResourceSet).HasMaxLength(512);

                entity.Property(e => e.Type).HasMaxLength(512);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.IsRdos).HasColumnName("IsRDOS");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(256);

                entity.Property(e => e.ServiceUrl).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<GeographicalMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<GeographicalMaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(4);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<GeographicalStructure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<InvAdjustmentDetail>(entity =>
            {
                entity.ToTable("INV_AdjustmentDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentNumber).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.Dsacode)
                    .HasMaxLength(50)
                    .HasColumnName("DSACode");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TransactionType).HasMaxLength(250);

                entity.Property(e => e.Uom).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvAdjustmentHeader>(entity =>
            {
                entity.ToTable("INV_AdjustmentHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdjustmentNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.SalesPeriod).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<InvAllocationDetail>(entity =>
            {
                entity.ToTable("INV_AllocationDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Attribute1).HasMaxLength(50);

                entity.Property(e => e.Attribute10).HasMaxLength(50);

                entity.Property(e => e.Attribute2).HasMaxLength(50);

                entity.Property(e => e.Attribute3).HasMaxLength(50);

                entity.Property(e => e.Attribute4).HasMaxLength(50);

                entity.Property(e => e.Attribute5).HasMaxLength(50);

                entity.Property(e => e.Attribute6).HasMaxLength(50);

                entity.Property(e => e.Attribute7).HasMaxLength(50);

                entity.Property(e => e.Attribute8).HasMaxLength(50);

                entity.Property(e => e.Attribute9).HasMaxLength(50);

                entity.Property(e => e.BaseUom).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.Dsacode)
                    .HasMaxLength(50)
                    .HasColumnName("DSACode");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Lsnumber).HasColumnName("LSNumber");

                entity.Property(e => e.ReportName).HasMaxLength(250);

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvInventoryTransaction>(entity =>
            {
                entity.ToTable("INV_InventoryTransactions");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.OrderCode).HasMaxLength(50);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.ReasonDescription).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TransactionType).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvLotAvailable>(entity =>
            {
                entity.ToTable("INV_LotAvailables");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.ItemKeyLot).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Lot).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvReason>(entity =>
            {
                entity.ToTable("INV_Reasons");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<InvSellInLotByDate>(entity =>
            {
                entity.ToTable("INV_SellInLotByDates");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemKeyLot).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Lot).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvSellOutLotByDate>(entity =>
            {
                entity.ToTable("INV_SellOutLotByDates");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.ItemKeyLotIn).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Lot).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvWhTransferDetail>(entity =>
            {
                entity.ToTable("INV_WhTransferDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.Dsacode)
                    .HasMaxLength(50)
                    .HasColumnName("DSACode");

                entity.Property(e => e.EmployeeTransferCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TransactionType).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);

                entity.Property(e => e.WhTransferCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InvWhTransferHeader>(entity =>
            {
                entity.ToTable("INV_WhTransferHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.FromWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.SalesPeriod).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.ToWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TransferCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<InvWhTransferToEmployeeHeader>(entity =>
            {
                entity.ToTable("INV_WhTransferToEmployeeHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.Emplocation)
                    .HasMaxLength(250)
                    .HasColumnName("EMPLocation");

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.SalesPeriod).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransferCode).HasMaxLength(50);

                entity.Property(e => e.TransferDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasMaxLength(1000);

                entity.Property(e => e.AvatarFileExt).HasMaxLength(50);

                entity.Property(e => e.AvatarFolderType).HasMaxLength(50);

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.DistribiutorCode).HasMaxLength(10);

                entity.Property(e => e.Erpcode)
                    .HasMaxLength(10)
                    .HasColumnName("ERPCode");

                entity.Property(e => e.GroupId).HasMaxLength(20);

                entity.Property(e => e.InventoryItemId).HasMaxLength(10);

                entity.Property(e => e.ItemType).HasMaxLength(10);

                entity.Property(e => e.Lsnumber).HasColumnName("LSNumber");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.ReportName).HasMaxLength(40);

                entity.Property(e => e.ShortName).HasMaxLength(30);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<InventoryKit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InventoryItemId).HasMaxLength(10);

                entity.Property(e => e.KitDescription).HasMaxLength(80);

                entity.Property(e => e.NonStockItem).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(30);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.StockItem).HasMaxLength(100);

                entity.Property(e => e.Uom).HasMaxLength(100);
            });

            modelBuilder.Entity<InventoryResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.OrderDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemAttribute>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemAttributeCode).HasMaxLength(2);

                entity.Property(e => e.ItemAttributeMaster).HasMaxLength(4);

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntilDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasMaxLength(1000);

                entity.Property(e => e.AvatarFileExt).HasMaxLength(50);

                entity.Property(e => e.AvatarFolderType).HasMaxLength(50);

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(16);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemHierarchyMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.HierarchyAttribute1).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute10).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute2).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute3).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute4).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute5).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute6).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute7).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute8).HasMaxLength(4);

                entity.Property(e => e.HierarchyAttribute9).HasMaxLength(4);

                entity.Property(e => e.NodeId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemHierarchyMappingCompetitor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemManufacture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ManufactureId).HasColumnName("ManufactureID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttributeId).HasMaxLength(4);

                entity.Property(e => e.AttributeName).HasMaxLength(30);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemsCompetitor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompetitorId).HasColumnName("CompetitorID");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemsFile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileCreatedDateStr).HasDefaultValueSql("''::text");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.FolderType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ItemsUomconversion>(entity =>
            {
                entity.ToTable("ItemsUOMConversions");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dm).HasColumnName("DM");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DefaultUserRole).HasMaxLength(50);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<JobTitleRole>(entity =>
            {
                entity.HasIndex(e => e.JobTitleId, "IX_JobTitleRoles_JobTitleId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TitleRole).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.JobTitleRoles)
                    .HasForeignKey(d => d.JobTitleId);
            });

            modelBuilder.Entity<Kit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avatar).HasMaxLength(1000);

                entity.Property(e => e.AvatarFileExt).HasMaxLength(50);

                entity.Property(e => e.AvatarFolderType).HasMaxLength(50);

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.ItemKitId).HasMaxLength(10);

                entity.Property(e => e.Lsnumber).HasColumnName("LSNumber");

                entity.Property(e => e.ShortName).HasMaxLength(30);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<KitInventoryItemConversion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InventoryItemId)
                    .HasMaxLength(10)
                    .HasColumnName("InventoryItemID");

                entity.Property(e => e.InventoryItemIddb).HasColumnName("InventoryItemIDDb");

                entity.Property(e => e.KitId).HasColumnName("KitID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<KitUomConversion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dm).HasColumnName("DM");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.KitId).HasColumnName("KitID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Kpi>(entity =>
            {
                entity.ToTable("KPIs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCalType).HasColumnName("KPIsCalType");

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");

                entity.Property(e => e.KpisDescription).HasColumnName("KPIsDescription");
            });

            modelBuilder.Entity<KpiResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");
            });

            modelBuilder.Entity<KpiTargetComplete>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<KpisForObjectRef>(entity =>
            {
                entity.ToTable("KPIsForObjectRefs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExpirationDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FromDay).HasColumnType("timestamp without time zone");

                entity.Property(e => e.KpisObjectCode).HasColumnName("KPIsObjectCode");

                entity.Property(e => e.KpisObjectDescription).HasColumnName("KPIsObjectDescription");
            });

            modelBuilder.Entity<KpisObject>(entity =>
            {
                entity.ToTable("KPIsObjects");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");

                entity.Property(e => e.KpisObjectCode).HasColumnName("KPIsObjectCode");
            });

            modelBuilder.Entity<KpisSiref>(entity =>
            {
                entity.ToTable("KPIsSirefs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");
            });

            modelBuilder.Entity<KpisTarget>(entity =>
            {
                entity.ToTable("KPIsTargets");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");

                entity.Property(e => e.KpisTargetType).HasColumnName("KPIsTargetType");
            });

            modelBuilder.Entity<KpisTargetForObject>(entity =>
            {
                entity.ToTable("KPIsTargetForObjects");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");

                entity.Property(e => e.KpisTargetValue).HasColumnName("KPIsTargetValue");

                entity.Property(e => e.KpisTargetValueOriginal).HasColumnName("KPIsTargetValueOriginal");

                entity.Property(e => e.PicsalesTerritory).HasColumnName("PICSalesTerritory");

                entity.Property(e => e.Sic).HasColumnName("SIC");
            });

            modelBuilder.Entity<KpisTargetFrequency>(entity =>
            {
                entity.ToTable("KPIsTargetFrequencies");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FromDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");

                entity.Property(e => e.ToDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<KpisTargetGroupByKpisRepeat>(entity =>
            {
                entity.ToTable("KPIsTargetGroupByKPIsRepeats");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");

                entity.Property(e => e.KpisDisplayType).HasColumnName("KPIsDisplayType");

                entity.Property(e => e.KpisRepeatTargetValue).HasColumnName("KPIsRepeatTargetValue");

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");

                entity.Property(e => e.KpisType).HasColumnName("KPIsType");

                entity.Property(e => e.PicsalesTerritory).HasColumnName("PICSalesTerritory");

                entity.Property(e => e.Sic).HasColumnName("SIC");
            });

            modelBuilder.Entity<KpisTargetProductList>(entity =>
            {
                entity.ToTable("KPIsTargetProductLists");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");
            });

            modelBuilder.Entity<KpisTargetProductListItemCode>(entity =>
            {
                entity.ToTable("KPIsTargetProductListItemCodes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");
            });

            modelBuilder.Entity<KpisTargetProductListKpi>(entity =>
            {
                entity.ToTable("KPIsTargetProductListKpis");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KpisCode).HasColumnName("KPIsCode");

                entity.Property(e => e.KpisTargetCode).HasColumnName("KPIsTargetCode");
            });

            modelBuilder.Entity<KpiseasonCoefficient>(entity =>
            {
                entity.ToTable("KPISeasonCoefficients");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.KpisettingId).HasColumnName("KPISettingId");

                entity.Property(e => e.PeriodCode).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Kpisetting>(entity =>
            {
                entity.ToTable("KPISetting");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BasedValue).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PicsaleTerritory)
                    .HasMaxLength(50)
                    .HasColumnName("PICSaleTerritory");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<KpivisitFrequency>(entity =>
            {
                entity.ToTable("KPIVisitFrequency");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.BusinessModel).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.KpisettingId).HasColumnName("KPISettingId");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<KsApplicapleAssignment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AttCode).HasMaxLength(40);

                entity.Property(e => e.AttId).HasMaxLength(40);

                entity.Property(e => e.CampainCode).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.CustomerCode).HasMaxLength(40);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(40);

                entity.Property(e => e.DistributorCode).HasMaxLength(40);

                entity.Property(e => e.DistributorShiptoCode).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsCampaign>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplicableObjects).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.EndDate).HasPrecision(6);

                entity.Property(e => e.EndEvaluationDate).HasPrecision(6);

                entity.Property(e => e.EvaluationFrequency).HasMaxLength(20);

                entity.Property(e => e.EvaluationType).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PeopleSurvey).HasMaxLength(20);

                entity.Property(e => e.ScopeType).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasPrecision(6);

                entity.Property(e => e.StartEvaluationDate).HasPrecision(6);

                entity.Property(e => e.SurveyCode).HasMaxLength(40);

                entity.Property(e => e.SurveyMethod).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.ResourceId).HasMaxLength(40);

                entity.Property(e => e.ResourceType).HasMaxLength(20);

                entity.Property(e => e.SyncCode).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsRespondentInfor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CampainCode).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.RespondentInfoKey).HasMaxLength(100);

                entity.Property(e => e.RespondentInfoValue).HasMaxLength(255);

                entity.Property(e => e.SurveyResultCode).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsScopeAssignment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CampainCode).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.GeoCode).HasMaxLength(40);

                entity.Property(e => e.TerritoryCode).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsSurvey>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsSurveyAnswer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.QuestionId).HasMaxLength(40);

                entity.Property(e => e.RelatedQuestionId).HasMaxLength(40);

                entity.Property(e => e.UpdateBy).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsSurveyQuestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.DependentType).HasMaxLength(20);

                entity.Property(e => e.QuestionType).HasMaxLength(20);

                entity.Property(e => e.SurveyId).HasMaxLength(40);

                entity.Property(e => e.UpdateBy).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasPrecision(6);
            });

            modelBuilder.Entity<KsSurveyResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CampainCode).HasMaxLength(40);

                entity.Property(e => e.CampainEndDate).HasPrecision(6);

                entity.Property(e => e.CampainEndEvaluationDate).HasPrecision(6);

                entity.Property(e => e.CampainEvaluationFrequency).HasMaxLength(20);

                entity.Property(e => e.CampainEvaluationType).HasMaxLength(20);

                entity.Property(e => e.CampainName).HasMaxLength(200);

                entity.Property(e => e.CampainPeopleSurvey).HasMaxLength(20);

                entity.Property(e => e.CampainRequiredValue).HasMaxLength(20);

                entity.Property(e => e.CampainStartDate).HasPrecision(6);

                entity.Property(e => e.CampainStartEvaluationDate).HasPrecision(6);

                entity.Property(e => e.CampainSurveyMethod).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.QuestionDependentType).HasMaxLength(20);

                entity.Property(e => e.QuestionType).HasMaxLength(20);

                entity.Property(e => e.SurveyCode).HasMaxLength(40);

                entity.Property(e => e.SurveyResultCode).HasMaxLength(40);

                entity.Property(e => e.SurveyResultIndex).HasMaxLength(50);

                entity.Property(e => e.SurveyorCode).HasMaxLength(40);

                entity.Property(e => e.SurveyorJobTitleCode).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);

                entity.Property(e => e.VisitId).HasMaxLength(40);
            });

            modelBuilder.Entity<KsSurveyorResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CampainCode).HasMaxLength(40);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.EmployeeCode).HasMaxLength(40);

                entity.Property(e => e.JobTitleCode).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<Localization>(entity =>
            {
                entity.ToTable("localizations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Binfile).HasColumnName("binfile");

                entity.Property(e => e.Comment)
                    .HasMaxLength(512)
                    .HasColumnName("comment");

                entity.Property(e => e.Filename)
                    .HasMaxLength(128)
                    .HasColumnName("filename");

                entity.Property(e => e.Localeid)
                    .HasMaxLength(10)
                    .HasColumnName("localeid");

                entity.Property(e => e.Resourceid)
                    .HasMaxLength(1024)
                    .HasColumnName("resourceid");

                entity.Property(e => e.Resourceset)
                    .HasMaxLength(512)
                    .HasColumnName("resourceset");

                entity.Property(e => e.Textfile).HasColumnName("textfile");

                entity.Property(e => e.Type)
                    .HasMaxLength(512)
                    .HasColumnName("type");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.Valuetype).HasColumnName("valuetype");
            });

            modelBuilder.Entity<LocalizationsBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("localizations_backup");

                entity.Property(e => e.Binfile).HasColumnName("binfile");

                entity.Property(e => e.Comment)
                    .HasMaxLength(512)
                    .HasColumnName("comment");

                entity.Property(e => e.Filename)
                    .HasMaxLength(128)
                    .HasColumnName("filename");

                entity.Property(e => e.Localeid)
                    .HasMaxLength(10)
                    .HasColumnName("localeid");

                entity.Property(e => e.Pk)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pk");

                entity.Property(e => e.Resourceid)
                    .HasMaxLength(1024)
                    .HasColumnName("resourceid");

                entity.Property(e => e.Resourceset)
                    .HasMaxLength(512)
                    .HasColumnName("resourceset");

                entity.Property(e => e.Textfile).HasColumnName("textfile");

                entity.Property(e => e.Type)
                    .HasMaxLength(512)
                    .HasColumnName("type");

                entity.Property(e => e.Updated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("updated")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.Valuetype)
                    .HasColumnName("valuetype")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<LppcRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.LppcnoofSku).HasColumnName("LPPCNoofSKU");

                entity.Property(e => e.LppcorderorInvoiceValue).HasColumnName("LPPCOrderorInvoiceValue");

                entity.Property(e => e.RecognizedDateForPc).HasColumnName("RecognizedDateForPC");

                entity.Property(e => e.ScnoofSku).HasColumnName("SCNoofSKU");

                entity.Property(e => e.ScorderValue).HasColumnName("SCOrderValue");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Manufacture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirtName).HasMaxLength(10);

                entity.Property(e => e.FullName).HasMaxLength(120);

                entity.Property(e => e.GpslocationLat)
                    .HasMaxLength(25)
                    .HasColumnName("GPSLocationLat");

                entity.Property(e => e.GpslocationLng)
                    .HasMaxLength(25)
                    .HasColumnName("GPSLocationLng");

                entity.Property(e => e.LastName).HasMaxLength(10);

                entity.Property(e => e.LegalInformation).HasMaxLength(60);

                entity.Property(e => e.ManufactureCode).HasMaxLength(10);

                entity.Property(e => e.ManufactureName).HasMaxLength(60);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(60);

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TaxCode).HasMaxLength(13);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasIndex(e => e.FeatureId, "IX_Menus_FeatureId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Icon).HasMaxLength(30);

                entity.Property(e => e.Is1Sprincipal).HasColumnName("Is1SPrincipal");

                entity.Property(e => e.IsRdos).HasColumnName("IsRDOS");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MobileFeaturesPermission>(entity =>
            {
                entity.ToTable("MobileFeaturesPermission");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Permission).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUser>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PhoneCountryCode).HasMaxLength(8);

                entity.Property(e => e.PhoneCountryIso)
                    .HasMaxLength(5)
                    .HasColumnName("PhoneCountryISO");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<MobileUserApplication>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserDevice>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppVersion).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeviceId).HasMaxLength(255);

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.EffectDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.LoginTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .HasColumnName("OS")
                    .HasComment(" IMEI hay Serieral của thiết bị");

                entity.Property(e => e.Osversion)
                    .HasMaxLength(10)
                    .HasColumnName("OSVersion");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserEmployee>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserInfo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AvatarFileName).HasMaxLength(255);

                entity.Property(e => e.Birthday).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(2);

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserPrinciple>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserPrinciplesHistory>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUserSetting>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Language).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileUsersLocked>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<MobileVisitStep>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Purpose).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Body).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Purpose).HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PaginationConfig>(entity =>
            {
                entity.HasIndex(e => e.FeatureId, "IX_PaginationConfigs_FeatureId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.PaginationConfigs)
                    .HasForeignKey(d => d.FeatureId);
            });

            modelBuilder.Entity<ParameterWithSiref>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PcconditionsNoofSku).HasColumnName("PcconditionsNoofSKU");

                entity.Property(e => e.RecognizedDateforSov).HasColumnName("RecognizedDateforSOV");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ParameterWithSitype>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PcconditionsNoofSku).HasColumnName("PcconditionsNoofSKU");

                entity.Property(e => e.RecognizedDateforSov).HasColumnName("RecognizedDateforSOV");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PcrefResult>(entity =>
            {
                entity.ToTable("PCRefResults");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.PcinvoiceValue).HasColumnName("PCInvoiceValue");

                entity.Property(e => e.PcnoofSku).HasColumnName("PCNoofSKU");

                entity.Property(e => e.RecognizedDateForPc).HasColumnName("RecognizedDateForPC");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoowerCode).HasColumnName("SOOwerCode");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoAllocationSetting>(entity =>
            {
                entity.ToTable("PO_AllocationSettings");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AllocationSettingNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoAllocationSettingItemGroup>(entity =>
            {
                entity.ToTable("PO_AllocationSettingItemGroups");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AllocationSettingNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoAverageDailySale>(entity =>
            {
                entity.ToTable("PO_AverageDailySales");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoDeliveryLeadTime>(entity =>
            {
                entity.ToTable("PO_DeliveryLeadTimes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.GeoMaster).HasMaxLength(50);

                entity.Property(e => e.MasterValue).HasMaxLength(50);

                entity.Property(e => e.SalesOrgId).HasMaxLength(50);

                entity.Property(e => e.TerritoryLevelValue).HasMaxLength(50);

                entity.Property(e => e.TerritoryValueKey).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoGrpodetailItem>(entity =>
            {
                entity.ToTable("PO_GRPODetailItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Atrribute1).HasMaxLength(50);

                entity.Property(e => e.Atrribute10).HasMaxLength(50);

                entity.Property(e => e.Atrribute2).HasMaxLength(50);

                entity.Property(e => e.Atrribute3).HasMaxLength(50);

                entity.Property(e => e.Atrribute4).HasMaxLength(50);

                entity.Property(e => e.Atrribute5).HasMaxLength(50);

                entity.Property(e => e.Atrribute6).HasMaxLength(50);

                entity.Property(e => e.Atrribute7).HasMaxLength(50);

                entity.Property(e => e.Atrribute8).HasMaxLength(50);

                entity.Property(e => e.Atrribute9).HasMaxLength(50);

                entity.Property(e => e.BaseUom).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountSchemeId).HasMaxLength(50);

                entity.Property(e => e.ErpCode).HasMaxLength(50);

                entity.Property(e => e.Grponumber)
                    .HasMaxLength(50)
                    .HasColumnName("GRPONumber");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.ItemReportName).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatCode).HasMaxLength(50);

                entity.Property(e => e.WareHouse).HasMaxLength(50);

                entity.Property(e => e.WareHouseDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<PoGrpoheader>(entity =>
            {
                entity.ToTable("PO_GRPOHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoCode).HasMaxLength(50);

                entity.Property(e => e.Grpodate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("GRPODate");

                entity.Property(e => e.Grponumber)
                    .HasMaxLength(50)
                    .HasColumnName("GRPONumber");

                entity.Property(e => e.PrincipalRefNumber).HasMaxLength(50);

                entity.Property(e => e.PrincipalWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderConfirmNumber).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoOrderDetail>(entity =>
            {
                entity.ToTable("PO_OrderDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaseUom).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatCode).HasMaxLength(50);
            });

            modelBuilder.Entity<PoOrderHeader>(entity =>
            {
                entity.ToTable("PO_OrderHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoDescription).HasMaxLength(250);

                entity.Property(e => e.ExpectReDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PoDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PrincipalWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoPoconfirmDetailItem>(entity =>
            {
                entity.ToTable("PO_POConfirmDetailItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Atrribute1).HasMaxLength(50);

                entity.Property(e => e.Atrribute10).HasMaxLength(50);

                entity.Property(e => e.Atrribute2).HasMaxLength(50);

                entity.Property(e => e.Atrribute3).HasMaxLength(50);

                entity.Property(e => e.Atrribute4).HasMaxLength(50);

                entity.Property(e => e.Atrribute5).HasMaxLength(50);

                entity.Property(e => e.Atrribute6).HasMaxLength(50);

                entity.Property(e => e.Atrribute7).HasMaxLength(50);

                entity.Property(e => e.Atrribute8).HasMaxLength(50);

                entity.Property(e => e.Atrribute9).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountSchemeId).HasMaxLength(50);

                entity.Property(e => e.ErpCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderConfirmNumber).HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatCode).HasMaxLength(50);
            });

            modelBuilder.Entity<PoPoconfirmHeader>(entity =>
            {
                entity.ToTable("PO_POConfirmHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoDescription).HasMaxLength(250);

                entity.Property(e => e.ExpectReDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PoPrincipalNumber).HasMaxLength(50);

                entity.Property(e => e.PrincipalWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderConfirmNumber).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoPurchaseScheduleDetail>(entity =>
            {
                entity.ToTable("PO_PurchaseScheduleDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.SaleOrgCode).HasMaxLength(50);

                entity.Property(e => e.TerritoryValueKey).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoReturnDetailItem>(entity =>
            {
                entity.ToTable("PO_ReturnDetailItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.PurchaseReturnNumber).HasMaxLength(50);

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatCode).HasMaxLength(50);

                entity.Property(e => e.WareHouse).HasMaxLength(50);

                entity.Property(e => e.WareHouseDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<PoReturnHeader>(entity =>
            {
                entity.ToTable("PO_ReturnHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.Grponumber)
                    .HasMaxLength(50)
                    .HasColumnName("GRPONumber");

                entity.Property(e => e.PrincipalWareHouseCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseReturnNumber).HasMaxLength(50);

                entity.Property(e => e.ReturnReason).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoRpoparameter>(entity =>
            {
                entity.ToTable("PO_RPOParameters");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IncludedPoshipping).HasColumnName("IncludedPOShipping");

                entity.Property(e => e.IncludedPotransit).HasColumnName("IncludedPOTransit");

                entity.Property(e => e.RoundingRule).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoStockKeepingDay>(entity =>
            {
                entity.ToTable("PO_StockKeepingDays");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemHierachyLevel).HasMaxLength(50);

                entity.Property(e => e.SaleOrgId).HasMaxLength(50);

                entity.Property(e => e.SalesTerritoryLevel).HasMaxLength(50);

                entity.Property(e => e.StockKeepingDayNumber).HasMaxLength(50);

                entity.Property(e => e.TerritoryLevelValue).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PoStockKeepingDayItemHierarchy>(entity =>
            {
                entity.ToTable("PO_StockKeepingDayItemHierarchies");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemHierarchyValue).HasMaxLength(50);

                entity.Property(e => e.StockKeepingDayNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Key).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PolicyAccessReport>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccessedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.AccessedUser).HasMaxLength(10);

                entity.Property(e => e.AccessedUserName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.PolicyCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PolicyApplyFor>(entity =>
            {
                entity.ToTable("PolicyApplyFor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.JobTitleCode).HasMaxLength(10);

                entity.Property(e => e.JobTitleDefaultName).HasMaxLength(255);

                entity.Property(e => e.JobTitleName).HasMaxLength(255);

                entity.Property(e => e.PolicyCode).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<PolicyGeneralInformation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplicableTo).HasMaxLength(10);

                entity.Property(e => e.ApplyTo).HasMaxLength(20);

                entity.Property(e => e.AvatarFileFormat).HasMaxLength(255);

                entity.Property(e => e.PolicyCode).HasMaxLength(10);

                entity.Property(e => e.PolicyName).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<PolicyResource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FileFormat).HasMaxLength(255);

                entity.Property(e => e.PolicyCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PolicyTerritoryLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PolicyCode).HasMaxLength(10);

                entity.Property(e => e.SalesOrgCode).HasMaxLength(100);

                entity.Property(e => e.TerritoryLevel).HasMaxLength(10);

                entity.Property(e => e.TerritoryLevelSource).HasMaxLength(20);

                entity.Property(e => e.TerritoryValue).HasMaxLength(20);

                entity.Property(e => e.TerritoryValueName).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PriceDefinitionDistributor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.EffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpirationTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.HasIndex(e => e.PriceListTypeId, "IX_PriceLists_PriceListTypeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpirationTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ObjectApply).HasMaxLength(255);

                entity.Property(e => e.PriceListCode).HasMaxLength(50);

                entity.Property(e => e.PriceListTypeCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceListType)
                    .WithMany(p => p.PriceLists)
                    .HasForeignKey(d => d.PriceListTypeId);
            });

            modelBuilder.Entity<PriceListDistributeSellingArea>(entity =>
            {
                entity.HasIndex(e => e.PriceListId, "IX_PriceListDistributeSellingAreas_PriceListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SellingAreaCode).HasMaxLength(50);

                entity.Property(e => e.SellingAreaDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PriceListDistributeSellingAreas)
                    .HasForeignKey(d => d.PriceListId);
            });

            modelBuilder.Entity<PriceListItemGroup>(entity =>
            {
                entity.HasIndex(e => e.PriceListId, "IX_PriceListItemGroups_PriceListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.UoM).HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PriceListItemGroups)
                    .HasForeignKey(d => d.PriceListId);
            });

            modelBuilder.Entity<PriceListOutletAttributeValue>(entity =>
            {
                entity.HasIndex(e => e.PriceListId, "IX_PriceListOutletAttributeValues_PriceListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OutletAttributeLevelCode).HasMaxLength(50);

                entity.Property(e => e.OutletAttributeValue).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PriceListOutletAttributeValues)
                    .HasForeignKey(d => d.PriceListId);
            });

            modelBuilder.Entity<PriceListSalesTerritoryLevel>(entity =>
            {
                entity.HasIndex(e => e.PriceListId, "IX_PriceListSalesTerritoryLevels_PriceListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalesTerritoryLevelCode).HasMaxLength(50);

                entity.Property(e => e.SalesTerritoryLevelDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PriceListSalesTerritoryLevels)
                    .HasForeignKey(d => d.PriceListId);
            });

            modelBuilder.Entity<PriceListType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BasePriceCode).HasMaxLength(25);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PriceListTypeCode).HasMaxLength(12);

                entity.Property(e => e.PriceType).HasMaxLength(20);

                entity.Property(e => e.SaleTerritoryLevel).HasMaxLength(255);

                entity.Property(e => e.SaleTerritoryLevelDescription).HasMaxLength(255);

                entity.Property(e => e.SalesTerritoryCode).HasMaxLength(255);

                entity.Property(e => e.SalesTerritoryDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PriceListTypeAttributeList>(entity =>
            {
                entity.HasIndex(e => e.PriceListTypeId, "IX_PriceListTypeAttributeLists_PriceListTypeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceListType)
                    .WithMany(p => p.PriceListTypeAttributeLists)
                    .HasForeignKey(d => d.PriceListTypeId);
            });

            modelBuilder.Entity<PriceSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PriceSettingAuditLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrimarySic>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrimarySicExcludeHierarchyDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PrimarySic)
                    .WithMany(p => p.PrimarySicExcludeHierarchyDetails)
                    .HasForeignKey(d => d.PrimarySicId);
            });

            modelBuilder.Entity<PrimarySicExcludeItemGroupDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PrimarySic)
                    .WithMany(p => p.PrimarySicExcludeItemGroupDetails)
                    .HasForeignKey(d => d.PrimarySicId);
            });

            modelBuilder.Entity<PrimarySicIncludeDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.HierarchyValue)
                    .WithMany(p => p.PrimarySicIncludeDetails)
                    .HasForeignKey(d => d.HierarchyValueId);

                entity.HasOne(d => d.PrimarySic)
                    .WithMany(p => p.PrimarySicIncludeDetails)
                    .HasForeignKey(d => d.PrimarySicId);
            });

            modelBuilder.Entity<Principal>(entity =>
            {
                entity.HasIndex(e => e.PackageId, "IX_Principals_PackageId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.ApproveBy).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.InitializationStatus).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SecretKey).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Web).HasMaxLength(200);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Principals)
                    .HasForeignKey(d => d.PackageId);
            });

            modelBuilder.Entity<PrincipalEmpContract>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId, "IX_PrincipalEmpContracts_EmployeeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContractType).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeCode).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FilePath).HasMaxLength(255);

                entity.Property(e => e.JobTitle).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PrincipalEmpContracts)
                    .HasForeignKey(d => d.EmployeeId);
            });

            modelBuilder.Entity<PrincipalProfile>(entity =>
            {
                entity.ToTable("PrincipalProfile");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AddressCity).HasMaxLength(100);

                entity.Property(e => e.AddressCountry).HasMaxLength(50);

                entity.Property(e => e.AddressDeparmentNo).HasMaxLength(100);

                entity.Property(e => e.AddressDistrict).HasMaxLength(100);

                entity.Property(e => e.AddressProvince).HasMaxLength(100);

                entity.Property(e => e.AddressRegion).HasMaxLength(100);

                entity.Property(e => e.AddressState).HasMaxLength(100);

                entity.Property(e => e.AddressStreet).HasMaxLength(100);

                entity.Property(e => e.AddressWard).HasMaxLength(100);

                entity.Property(e => e.AttentionEmail).HasMaxLength(100);

                entity.Property(e => e.AttentionEmailType).HasMaxLength(255);

                entity.Property(e => e.AttentionFirstName).HasMaxLength(50);

                entity.Property(e => e.AttentionFullName).HasMaxLength(255);

                entity.Property(e => e.AttentionLastName).HasMaxLength(50);

                entity.Property(e => e.AttentionMiddleName).HasMaxLength(50);

                entity.Property(e => e.AttentionPhoneNumber).HasMaxLength(12);

                entity.Property(e => e.AttentionPhoneType).HasMaxLength(255);

                entity.Property(e => e.AttentionPosition).HasMaxLength(50);

                entity.Property(e => e.AttentionTitle).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(100);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.BankNumber).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ContractEmail).HasMaxLength(100);

                entity.Property(e => e.ContractEmailType).HasMaxLength(255);

                entity.Property(e => e.ContractFirstName).HasMaxLength(50);

                entity.Property(e => e.ContractLastName).HasMaxLength(50);

                entity.Property(e => e.ContractMiddleName).HasMaxLength(50);

                entity.Property(e => e.ContractPhoneNumber).HasMaxLength(12);

                entity.Property(e => e.ContractPhoneType).HasMaxLength(255);

                entity.Property(e => e.ContractPosition).HasMaxLength(50);

                entity.Property(e => e.ContractTitle).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasMaxLength(255);

                entity.Property(e => e.Longitude).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.TaxNumber).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<PrincipalPullDataQueue>(entity =>
            {
                entity.ToTable("PrincipalPullDataQueue");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.ExcuteDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Owner).HasMaxLength(255);

                entity.Property(e => e.OwnerId).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrincipalSetting>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrincipalWarehouse>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AddressCity).HasMaxLength(100);

                entity.Property(e => e.AddressCountry).HasMaxLength(50);

                entity.Property(e => e.AddressDeparmentNo).HasMaxLength(100);

                entity.Property(e => e.AddressDistrict).HasMaxLength(100);

                entity.Property(e => e.AddressProvince).HasMaxLength(100);

                entity.Property(e => e.AddressRegion).HasMaxLength(100);

                entity.Property(e => e.AddressState).HasMaxLength(100);

                entity.Property(e => e.AddressStreet).HasMaxLength(100);

                entity.Property(e => e.AddressWard).HasMaxLength(100);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Decscription).HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Latitude).HasMaxLength(255);

                entity.Property(e => e.LinkedCode).HasMaxLength(20);

                entity.Property(e => e.Longitude).HasMaxLength(255);

                entity.Property(e => e.ManagerDob)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("ManagerDOB");

                entity.Property(e => e.ManagerEmail).HasMaxLength(100);

                entity.Property(e => e.ManagerEmailType).HasMaxLength(20);

                entity.Property(e => e.ManagerFirstName).HasMaxLength(50);

                entity.Property(e => e.ManagerFullName).HasMaxLength(255);

                entity.Property(e => e.ManagerGender).HasMaxLength(20);

                entity.Property(e => e.ManagerLastName).HasMaxLength(50);

                entity.Property(e => e.ManagerMiddleName).HasMaxLength(50);

                entity.Property(e => e.ManagerNote).HasMaxLength(255);

                entity.Property(e => e.ManagerPhoneNumber).HasMaxLength(30);

                entity.Property(e => e.ManagerPhoneType).HasMaxLength(20);

                entity.Property(e => e.ManagerTitle).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrincipalWarehouseLocation>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Decscription).HasMaxLength(255);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrincipalWinzardSetup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LastestActionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PrincipleEmployee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.AccountPassword).HasMaxLength(255);

                entity.Property(e => e.AccountStatus).HasMaxLength(50);

                entity.Property(e => e.AddressCity).HasMaxLength(100);

                entity.Property(e => e.AddressCountry).HasMaxLength(50);

                entity.Property(e => e.AddressDeparmentNo).HasMaxLength(100);

                entity.Property(e => e.AddressDistrict).HasMaxLength(100);

                entity.Property(e => e.AddressProvince).HasMaxLength(100);

                entity.Property(e => e.AddressRegion).HasMaxLength(100);

                entity.Property(e => e.AddressState).HasMaxLength(100);

                entity.Property(e => e.AddressStreet).HasMaxLength(100);

                entity.Property(e => e.AddressWard).HasMaxLength(100);

                entity.Property(e => e.AvartarFilePath).HasMaxLength(255);

                entity.Property(e => e.BankAccountName).HasMaxLength(100);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(100);

                entity.Property(e => e.BankBranch).HasMaxLength(255);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DateOfBirth).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmailType).HasMaxLength(255);

                entity.Property(e => e.EmployeeCode).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Idcard).HasMaxLength(12);

                entity.Property(e => e.Idcard2).HasMaxLength(12);

                entity.Property(e => e.InsuranceId).HasMaxLength(100);

                entity.Property(e => e.JobTitle).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MainPhoneNumber).HasMaxLength(12);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.PrincipalEmpCode).HasMaxLength(100);

                entity.Property(e => e.SoStructure).HasMaxLength(100);

                entity.Property(e => e.StartWorkingDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(100);

                entity.Property(e => e.TerminateDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Territory).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(20);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PriorityPriceListType>(entity =>
            {
                entity.HasIndex(e => e.PriceListTypeId, "IX_PriorityPriceListTypes_PriceListTypeId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PriceListType)
                    .WithMany(p => p.PriorityPriceListTypes)
                    .HasForeignKey(d => d.PriceListTypeId);
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ProductListItemCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ProvinceCode).HasMaxLength(10);

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PurchaseBasePrice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContractType).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.PriceType).HasMaxLength(20);

                entity.Property(e => e.PurchasePriceCode).HasMaxLength(12);

                entity.Property(e => e.SalesTerritoryCode).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<PurchasePriceItemGroup>(entity =>
            {
                entity.HasIndex(e => e.PurchaseBasePriceId, "IX_PurchasePriceItemGroups_PurchaseBasePriceId");

                entity.HasIndex(e => e.SalesPriceItemGroupReferenceId, "IX_PurchasePriceItemGroups_SalesPriceItemGroupReferenceId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(255);

                entity.Property(e => e.LastEffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.NewEffectiveTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Uom).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PurchaseBasePrice)
                    .WithMany(p => p.PurchasePriceItemGroups)
                    .HasForeignKey(d => d.PurchaseBasePriceId)
                    .HasConstraintName("FK_PurchasePriceItemGroups_PurchaseBasePrices_PurchaseBasePric~");

                entity.HasOne(d => d.SalesPriceItemGroupReference)
                    .WithMany(p => p.PurchasePriceItemGroups)
                    .HasForeignKey(d => d.SalesPriceItemGroupReferenceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PurchasePriceItemGroups_SalesPriceItemGroupReferences_Sales~");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppVersion).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpiredDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .HasColumnName("OS");

                entity.Property(e => e.RefreshToken1)
                    .HasMaxLength(255)
                    .HasColumnName("RefreshToken");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RefreshTokenModel>(entity =>
            {
                entity.ToTable("RefreshTokenModel");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AppName).HasMaxLength(20);

                entity.Property(e => e.AppVersion).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpiredDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Os)
                    .HasMaxLength(10)
                    .HasColumnName("OS");

                entity.Property(e => e.RefreshToken).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RegistrationQueue>(entity =>
            {
                entity.HasKey(e => e.QueueNumber);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.DisplayName).HasMaxLength(36);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<RzBeatPlan>(entity =>
            {
                entity.ToTable("RZ_BeatPlans");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzBeatPlanEmployee>(entity =>
            {
                entity.ToTable("RZ_BeatPlanEmployees");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzBeatPlanShipto>(entity =>
            {
                entity.ToTable("RZ_BeatPlanShiptos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzLocation>(entity =>
            {
                entity.ToTable("RZ_Locations");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzParameterLevelApply>(entity =>
            {
                entity.ToTable("RZ_ParameterLevelApplies");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExpirationDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzParameterSetting>(entity =>
            {
                entity.ToTable("RZ_ParameterSettings");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzParameterType>(entity =>
            {
                entity.ToTable("RZ_ParameterTypes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzParameterValue>(entity =>
            {
                entity.ToTable("RZ_ParameterValues");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<RzRouteZoneInfomation>(entity =>
            {
                entity.ToTable("RZ_RouteZoneInfomations");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CurrentSupervisorEffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CurrentSupervisorValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PreviousSupervisorEffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PreviousSupervisorValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.TempSiccode).HasColumnName("TempSICCode");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzRouteZoneParameter>(entity =>
            {
                entity.ToTable("RZ_RouteZoneParameters");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzRouteZoneShipto>(entity =>
            {
                entity.ToTable("RZ_RouteZoneShiptos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzRouteZoneType>(entity =>
            {
                entity.ToTable("RZ_RouteZoneTypes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<RzVisitFrequency>(entity =>
            {
                entity.ToTable("RZ_VisitFrequency");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SaUserWithDistributorShipto>(entity =>
            {
                entity.ToTable("SA_UserWithDistributorShiptos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedBy).HasMaxLength(256);

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(20);

                entity.Property(e => e.DistributorShiptoCode).HasMaxLength(20);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCode).HasMaxLength(36);
            });

            modelBuilder.Entity<SaleCalendar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LastDayOfFirstWeek).HasColumnType("timestamp without time zone");

                entity.Property(e => e.QuarterStructure).HasMaxLength(20);

                entity.Property(e => e.ReleasedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SaleCalendarActionHistory>(entity =>
            {
                entity.ToTable("SaleCalendarActionHistory");

                entity.HasIndex(e => e.SaleCalendarId, "IX_SaleCalendarActionHistory_SaleCalendarId");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.ActionName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SaleCalendar)
                    .WithMany(p => p.SaleCalendarActionHistories)
                    .HasForeignKey(d => d.SaleCalendarId);
            });

            modelBuilder.Entity<SaleCalendarGenerate>(entity =>
            {
                entity.HasIndex(e => e.SaleCalendarId, "IX_SaleCalendarGenerates_SaleCalendarId");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SaleCalendar)
                    .WithMany(p => p.SaleCalendarGenerates)
                    .HasForeignKey(d => d.SaleCalendarId);
            });

            modelBuilder.Entity<SaleCalendarHoliday>(entity =>
            {
                entity.HasIndex(e => e.SaleCalendarId, "IX_SaleCalendarHolidays_SaleCalendarId");

                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.HolidayDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SaleCalendar)
                    .WithMany(p => p.SaleCalendarHolidays)
                    .HasForeignKey(d => d.SaleCalendarId);
            });

            modelBuilder.Entity<SaleGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SaleProcessDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.SettingsRefNo).HasMaxLength(50);

                entity.Property(e => e.StepCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<SaleProcessSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EffectiveDate).HasPrecision(6);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.ShopFormat).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StepCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);

                entity.Property(e => e.ValidUntil).HasPrecision(6);
            });

            modelBuilder.Entity<SalesBasePrice>(entity =>
            {
                entity.HasIndex(e => e.PurchaseBasePriceId, "IX_SalesBasePrices_PurchaseBasePriceId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EffectiveTimeFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveTimeTo).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PriceType).HasMaxLength(20);

                entity.Property(e => e.PurchaseBasePriceCode).HasMaxLength(12);

                entity.Property(e => e.SalesPriceCode).HasMaxLength(12);

                entity.Property(e => e.SalesTerritoryCode).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.PurchaseBasePrice)
                    .WithMany(p => p.SalesBasePrices)
                    .HasForeignKey(d => d.PurchaseBasePriceId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SalesIndicatorRef>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LevelSitype).HasColumnName("LevelSIType");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SalesIndicatorType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SalesOganization>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TerritoryStructureCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SalesPriceItemGroup>(entity =>
            {
                entity.HasIndex(e => e.SalesBasePriceId, "IX_SalesPriceItemGroups_SalesBasePriceId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(255);

                entity.Property(e => e.Uom).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SalesBasePrice)
                    .WithMany(p => p.SalesPriceItemGroups)
                    .HasForeignKey(d => d.SalesBasePriceId);
            });

            modelBuilder.Entity<SalesPriceItemGroupReference>(entity =>
            {
                entity.HasIndex(e => e.SalesBasePriceId, "IX_SalesPriceItemGroupReferences_SalesBasePriceId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.SalesBasePrice)
                    .WithMany(p => p.SalesPriceItemGroupReferences)
                    .HasForeignKey(d => d.SalesBasePriceId)
                    .HasConstraintName("FK_SalesPriceItemGroupReferences_SalesBasePrices_SalesBasePric~");
            });

            modelBuilder.Entity<ScAuditlogReconcile>(entity =>
            {
                entity.ToTable("SC_AuditlogReconciles");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LastedReconcile).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScSalesOrganizationStructure>(entity =>
            {
                entity.ToTable("SC_SalesOrganizationStructures");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsSpecificSic).HasColumnName("IsSpecificSIC");

                entity.Property(e => e.Sic).HasColumnName("SIC");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScSalesTeamAssignment>(entity =>
            {
                entity.ToTable("SC_SalesTeamAssignments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsSicbase).HasColumnName("IsSICBase");

                entity.Property(e => e.SostructureCode).HasColumnName("SOStructureCode");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryLevel>(entity =>
            {
                entity.ToTable("SC_TerritoryLevels");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryMapping>(entity =>
            {
                entity.ToTable("SC_TerritoryMappings");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryStructure>(entity =>
            {
                entity.ToTable("SC_TerritoryStructures");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryStructureDetail>(entity =>
            {
                entity.ToTable("SC_TerritoryStructureDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryStructureGeographicalMapping>(entity =>
            {
                entity.ToTable("SC_TerritoryStructureGeographicalMappings");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScTerritoryValue>(entity =>
            {
                entity.ToTable("SC_TerritoryValues");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(4);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<ScrefResult>(entity =>
            {
                entity.ToTable("SCRefResults");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoowerCode).HasColumnName("SOOwerCode");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SdoResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.SdopercentConverage).HasColumnName("SDOPercentConverage");

                entity.Property(e => e.SdopercentGrow).HasColumnName("SDOPercentGrow");

                entity.Property(e => e.Sdoresult1).HasColumnName("SDOResult");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Sdoconfig>(entity =>
            {
                entity.ToTable("SDOConfigs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.InactiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.IsMainProductGainSdocoverage).HasColumnName("IsMainProductGainSDOCoverage");

                entity.Property(e => e.IsMainProductGainSdogrowth).HasColumnName("IsMainProductGainSDOGrowth");

                entity.Property(e => e.IsMaintainSdo).HasColumnName("IsMaintainSDO");

                entity.Property(e => e.MinimumNumberSdo).HasColumnName("MinimumNumberSDO");

                entity.Property(e => e.NumberSdotoDo).HasColumnName("NumberSDOToDo");

                entity.Property(e => e.ProductGainSdocoverageType).HasColumnName("ProductGainSDOCoverageType");

                entity.Property(e => e.ProductGainSdocoverageValue).HasColumnName("ProductGainSDOCoverageValue");

                entity.Property(e => e.ProductGainSdogrowthType).HasColumnName("ProductGainSDOGrowthType");

                entity.Property(e => e.ProductGainSdogrowthValue).HasColumnName("ProductGainSDOGrowthValue");

                entity.Property(e => e.Sdocode).HasColumnName("SDOCode");

                entity.Property(e => e.Sdodescription).HasColumnName("SDODescription");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SdoconfigSalesOrder>(entity =>
            {
                entity.ToTable("SDOConfigSalesOrders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SalesUoMcode).HasColumnName("SalesUoMCode");

                entity.Property(e => e.Sdocode).HasColumnName("SDOCode");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apikind).HasColumnName("APIKind");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Ecrurl)
                    .HasMaxLength(256)
                    .HasColumnName("ECRURL");

                entity.Property(e => e.Ecrversion)
                    .HasMaxLength(10)
                    .HasColumnName("ECRVersion");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Url)
                    .HasMaxLength(350)
                    .HasColumnName("URL");

                entity.Property(e => e.Versions).HasMaxLength(350);
            });

            modelBuilder.Entity<ServiceDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Url)
                    .HasMaxLength(350)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<ShiptoContact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ShiptoContacts)
                    .HasForeignKey(d => d.ContactId);

                entity.HasOne(d => d.Shipto)
                    .WithMany(p => p.ShiptoContacts)
                    .HasForeignKey(d => d.ShiptoId);
            });

            modelBuilder.Entity<ShiptoHistorical>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShiptoCodeonErp).HasColumnName("ShiptoCodeonERP");

                entity.Property(e => e.ValidDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SivRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.PcinvoiceValue).HasColumnName("PCInvoiceValue");

                entity.Property(e => e.PcnoofSku).HasColumnName("PCNoofSKU");

                entity.Property(e => e.RecognizedDateForPc).HasColumnName("RecognizedDateForPC");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoowerCode).HasColumnName("SOOwerCode");
            });

            modelBuilder.Entity<SkurefResult>(entity =>
            {
                entity.ToTable("SKURefResults");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoowerCode).HasColumnName("SOOwerCode");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SoFirstTimeCustomer>(entity =>
            {
                entity.ToTable("SO_FirstTimeCustomers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.DeptNo).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistributorShiptoId)
                    .HasMaxLength(250)
                    .HasColumnName("DistributorShiptoID");

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.PhoneNumber).HasMaxLength(250);

                entity.Property(e => e.StreetLine).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SoOrderInformation>(entity =>
            {
                entity.ToTable("SO_OrderInformations");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasMaxLength(50);

                entity.Property(e => e.AreaManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("Area_Manager_ID");

                entity.Property(e => e.BranchId).HasMaxLength(50);

                entity.Property(e => e.BranchManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Manager_ID");

                entity.Property(e => e.CancelDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CancelNumber).HasMaxLength(250);

                entity.Property(e => e.CompleteDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerAddress).HasMaxLength(250);

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(250);

                entity.Property(e => e.CustomerPhone).HasMaxLength(250);

                entity.Property(e => e.CustomerShiptoId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerShiptoID");

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(250);

                entity.Property(e => e.DeliveredDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountId)
                    .HasMaxLength(50)
                    .HasColumnName("DiscountID");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistyBilltoId)
                    .HasMaxLength(50)
                    .HasColumnName("Disty_billtoID");

                entity.Property(e => e.DsaManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("DSA_Manager_ID");

                entity.Property(e => e.Dsaid)
                    .HasMaxLength(50)
                    .HasColumnName("DSAID");

                entity.Property(e => e.ExpectDeliveryNote).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExpectShippedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ExternalOrdNbr)
                    .HasMaxLength(50)
                    .HasColumnName("External_OrdNBR");

                entity.Property(e => e.IsReturn).HasColumnName("isReturn");

                entity.Property(e => e.LastedDeliveryNotePrintDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.MenuType).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.NsdId)
                    .HasMaxLength(50)
                    .HasColumnName("NSD_ID");

                entity.Property(e => e.OrdAmt).HasColumnName("Ord_Amt");

                entity.Property(e => e.OrdDiscAmt).HasColumnName("Ord_Disc_Amt");

                entity.Property(e => e.OrdExtendAmt).HasColumnName("Ord_Extend_Amt");

                entity.Property(e => e.OrdQty).HasColumnName("Ord_Qty");

                entity.Property(e => e.OrdSkus).HasColumnName("Ord_SKUs");

                entity.Property(e => e.OrderDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderDescription).HasMaxLength(250);

                entity.Property(e => e.OrderRefNumber).HasMaxLength(50);

                entity.Property(e => e.OrderType).HasMaxLength(50);

                entity.Property(e => e.OrdlineDiscAmt).HasColumnName("Ordline_Disc_Amt");

                entity.Property(e => e.OrigOrdAmt).HasColumnName("Orig_Ord_Amt");

                entity.Property(e => e.OrigOrdDiscAmt).HasColumnName("Orig_Ord_Disc_Amt");

                entity.Property(e => e.OrigOrdExtendAmt).HasColumnName("Orig_Ord_Extend_Amt");

                entity.Property(e => e.OrigOrdQty).HasColumnName("Orig_Ord_Qty");

                entity.Property(e => e.OrigOrdSkus).HasColumnName("Orig_Ord_SKUs");

                entity.Property(e => e.OrigOrdlineDiscAmt).HasColumnName("Orig_Ordline_Disc_Amt");

                entity.Property(e => e.OrigPromotionQty).HasColumnName("Orig_Promotion_Qty");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(50)
                    .HasColumnName("Owner_ID");

                entity.Property(e => e.PeriodId)
                    .HasMaxLength(50)
                    .HasColumnName("PeriodID");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(50)
                    .HasColumnName("PrincipalID");

                entity.Property(e => e.PromotionAmt).HasColumnName("Promotion_Amt");

                entity.Property(e => e.PromotionQty).HasColumnName("Promotion_Qty");

                entity.Property(e => e.PromotionRefNumber).HasMaxLength(50);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.ReferenceRefNbr).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasMaxLength(50);

                entity.Property(e => e.RegionManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("Region_Manager_ID");

                entity.Property(e => e.RouteZoneId)
                    .HasMaxLength(50)
                    .HasColumnName("RouteZoneID");

                entity.Property(e => e.RouteZoneType)
                    .HasMaxLength(50)
                    .HasColumnName("RouteZOneType");

                entity.Property(e => e.RouteZonelocation).HasMaxLength(50);

                entity.Property(e => e.RzSuppervisorId)
                    .HasMaxLength(50)
                    .HasColumnName("RZ_Suppervisor_ID");

                entity.Property(e => e.SalesOrgId)
                    .HasMaxLength(50)
                    .HasColumnName("SalesOrgID");

                entity.Property(e => e.SalesRepId)
                    .HasMaxLength(50)
                    .HasColumnName("SalesRepID");

                entity.Property(e => e.ShipDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShippedAmt).HasColumnName("Shipped_Amt");

                entity.Property(e => e.ShippedDiscAmt).HasColumnName("Shipped_Disc_Amt");

                entity.Property(e => e.ShippedExtendAmt).HasColumnName("Shipped_Extend_Amt");

                entity.Property(e => e.ShippedLineDiscAmt).HasColumnName("Shipped_line_Disc_Amt");

                entity.Property(e => e.ShippedPromotionAmt).HasColumnName("Shipped_Promotion_Amt");

                entity.Property(e => e.ShippedPromotionQty).HasColumnName("Shipped_Promotion_Qty");

                entity.Property(e => e.ShippedQty).HasColumnName("Shipped_Qty");

                entity.Property(e => e.ShippedSkus).HasColumnName("Shipped_SKUs");

                entity.Property(e => e.ShiptoAttribute1)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute1");

                entity.Property(e => e.ShiptoAttribute10)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute10");

                entity.Property(e => e.ShiptoAttribute2)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute2");

                entity.Property(e => e.ShiptoAttribute3)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute3");

                entity.Property(e => e.ShiptoAttribute4)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute4");

                entity.Property(e => e.ShiptoAttribute5)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute5");

                entity.Property(e => e.ShiptoAttribute6)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute6");

                entity.Property(e => e.ShiptoAttribute7)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute7");

                entity.Property(e => e.ShiptoAttribute8)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute8");

                entity.Property(e => e.ShiptoAttribute9)
                    .HasMaxLength(50)
                    .HasColumnName("Shipto_Attribute9");

                entity.Property(e => e.SicId)
                    .HasMaxLength(50)
                    .HasColumnName("SIC_ID");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SubAreaId).HasMaxLength(50);

                entity.Property(e => e.SubAreaManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Area_Manager_ID");

                entity.Property(e => e.SubRegionId).HasMaxLength(50);

                entity.Property(e => e.SubRegionManagerId)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Region_Manager_ID");

                entity.Property(e => e.TerritoryStrId)
                    .HasMaxLength(50)
                    .HasColumnName("TerritoryStrID");

                entity.Property(e => e.TerritoryValueKey).HasMaxLength(50);

                entity.Property(e => e.TotalVat).HasColumnName("TotalVAT");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitId)
                    .HasMaxLength(50)
                    .HasColumnName("VisitID");

                entity.Property(e => e.WareHouseId)
                    .HasMaxLength(50)
                    .HasColumnName("WareHouseID");
            });

            modelBuilder.Entity<SoOrderItem>(entity =>
            {
                entity.ToTable("SO_OrderItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaseUnitCode).HasMaxLength(50);

                entity.Property(e => e.BaseUomCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountDealId)
                    .HasMaxLength(50)
                    .HasColumnName("DiscountDealID");

                entity.Property(e => e.DiscountId)
                    .HasMaxLength(50)
                    .HasColumnName("DiscountID");

                entity.Property(e => e.DiscountSchemeId)
                    .HasMaxLength(50)
                    .HasColumnName("DiscountSchemeID");

                entity.Property(e => e.DiscountType).HasMaxLength(250);

                entity.Property(e => e.InventoryAttibute1).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute10).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute2).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute3).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute4).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute5).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute6).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute7).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute8).HasMaxLength(50);

                entity.Property(e => e.InventoryAttibute9).HasMaxLength(50);

                entity.Property(e => e.InventoryId)
                    .HasMaxLength(50)
                    .HasColumnName("InventoryID");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.ItemShortName).HasMaxLength(250);

                entity.Property(e => e.KitKey).HasMaxLength(50);

                entity.Property(e => e.LocationId)
                    .HasMaxLength(50)
                    .HasColumnName("LocationID");

                entity.Property(e => e.OrdLineAmt).HasColumnName("Ord_Line_Amt");

                entity.Property(e => e.OrdLineDiscAmt).HasColumnName("Ord_line_Disc_Amt");

                entity.Property(e => e.OrdLineExtendAmt).HasColumnName("Ord_Line_Extend_Amt");

                entity.Property(e => e.OrderRefNumber).HasMaxLength(50);

                entity.Property(e => e.OrigOrdLineAmt).HasColumnName("Orig_Ord_Line_Amt");

                entity.Property(e => e.OrigOrdLineDiscAmt).HasColumnName("Orig_Ord_line_Disc_Amt");

                entity.Property(e => e.OrigOrdLineExtendAmt).HasColumnName("Orig_Ord_Line_Extend_Amt");

                entity.Property(e => e.ProgramCustomersDetailCode).HasMaxLength(250);

                entity.Property(e => e.PromotionCode).HasMaxLength(250);

                entity.Property(e => e.PromotionDescription).HasMaxLength(250);

                entity.Property(e => e.PromotionType).HasMaxLength(250);

                entity.Property(e => e.PurchaseUnitCode).HasMaxLength(50);

                entity.Property(e => e.RewardDescription).HasMaxLength(250);

                entity.Property(e => e.SalesUnitCode).HasMaxLength(50);

                entity.Property(e => e.ShippedLineAmt).HasColumnName("Shipped_Line_Amt");

                entity.Property(e => e.ShippedLineDiscAmt).HasColumnName("Shipped_line_Disc_Amt");

                entity.Property(e => e.ShippedLineExtendAmt).HasColumnName("Shipped_Line_Extend_Amt");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .HasColumnName("UOM");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(50)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<SoProProgramCustomer>(entity =>
            {
                entity.ToTable("SO_PRO_ProgramCustomers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(250);

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.ProgramCode).HasMaxLength(250);

                entity.Property(e => e.ProgramCustomersKey).HasMaxLength(250);

                entity.Property(e => e.ProgramsDescription).HasMaxLength(250);

                entity.Property(e => e.ProgramsItemScope).HasMaxLength(250);

                entity.Property(e => e.ProgramsType).HasMaxLength(250);

                entity.Property(e => e.PromotionRefNumber).HasMaxLength(250);

                entity.Property(e => e.ShiptoAttribute1).HasColumnName("Shipto_Attribute1");

                entity.Property(e => e.ShiptoAttribute10).HasColumnName("Shipto_Attribute10");

                entity.Property(e => e.ShiptoAttribute2).HasColumnName("Shipto_Attribute2");

                entity.Property(e => e.ShiptoAttribute3).HasColumnName("Shipto_Attribute3");

                entity.Property(e => e.ShiptoAttribute4).HasColumnName("Shipto_Attribute4");

                entity.Property(e => e.ShiptoAttribute5).HasColumnName("Shipto_Attribute5");

                entity.Property(e => e.ShiptoAttribute6).HasColumnName("Shipto_Attribute6");

                entity.Property(e => e.ShiptoAttribute7).HasColumnName("Shipto_Attribute7");

                entity.Property(e => e.ShiptoAttribute8).HasColumnName("Shipto_Attribute8");

                entity.Property(e => e.ShiptoAttribute9).HasColumnName("Shipto_Attribute9");

                entity.Property(e => e.ShiptoCode).HasMaxLength(250);

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SoProProgramCustomerDetailsItem>(entity =>
            {
                entity.ToTable("SO_PRO_ProgramCustomerDetailsItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DiscountLineCode).HasMaxLength(250);

                entity.Property(e => e.InventoryId).HasMaxLength(250);

                entity.Property(e => e.ItemCode).HasMaxLength(250);

                entity.Property(e => e.ItemDescription).HasMaxLength(250);

                entity.Property(e => e.ItemShortName).HasMaxLength(250);

                entity.Property(e => e.ProgramCustomerItemsGroupCode).HasMaxLength(250);

                entity.Property(e => e.ProgramCustomersDetailCode).HasMaxLength(250);

                entity.Property(e => e.PromotionCode).HasMaxLength(250);

                entity.Property(e => e.PromotionRefNumber).HasMaxLength(250);

                entity.Property(e => e.PromotionType).HasMaxLength(250);

                entity.Property(e => e.Uomcode)
                    .HasMaxLength(250)
                    .HasColumnName("UOMCode");

                entity.Property(e => e.VatId).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'::uuid");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(250)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<SoProProgramCustomerItemsGroup>(entity =>
            {
                entity.ToTable("SO_PRO_ProgramCustomerItemsGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.InventoryItemCode).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(250);

                entity.Property(e => e.ItemHierarchyValueForSale).HasMaxLength(250);

                entity.Property(e => e.ProductTypeForSale)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'02'::character varying");

                entity.Property(e => e.ProgramCustomerItemsGroupCode).HasMaxLength(250);

                entity.Property(e => e.ProgramCustomersDetailCode).HasMaxLength(250);

                entity.Property(e => e.PromotionRefNumber).HasMaxLength(250);

                entity.Property(e => e.Uomcode)
                    .HasMaxLength(250)
                    .HasColumnName("UOMCode");
            });

            modelBuilder.Entity<SoProProgramCustomersDetail>(entity =>
            {
                entity.ToTable("SO_PRO_ProgramCustomersDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DetailDescription).HasMaxLength(250);

                entity.Property(e => e.DetailLevel).HasMaxLength(250);

                entity.Property(e => e.DetailType).HasMaxLength(250);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemHierarchyLevelForGift).HasMaxLength(50);

                entity.Property(e => e.ItemHierarchyLevelForSale).HasMaxLength(50);

                entity.Property(e => e.ProductTypeForGift).HasColumnType("character varying");

                entity.Property(e => e.ProductTypeForSale).HasMaxLength(2);

                entity.Property(e => e.ProgramCustomersDetailCode).HasMaxLength(250);

                entity.Property(e => e.ProgramCustomersKey).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailsKey).HasMaxLength(250);

                entity.Property(e => e.ProgramsBuyType).HasMaxLength(250);

                entity.Property(e => e.ProgramsGivingType).HasMaxLength(250);

                entity.Property(e => e.PromotionRefNumber).HasMaxLength(250);

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SoReason>(entity =>
            {
                entity.ToTable("SO_Reasons");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ReasonCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<SoSumPickingListDetail>(entity =>
            {
                entity.ToTable("SO_SumPickingListDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrderRefNumber).HasMaxLength(50);

                entity.Property(e => e.SumPickingRefNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SoSumPickingListHeader>(entity =>
            {
                entity.ToTable("SO_SumPickingListHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DriverCode).HasMaxLength(50);

                entity.Property(e => e.LastedPrintDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.NumberPlates).HasMaxLength(250);

                entity.Property(e => e.Status).HasMaxLength(250);

                entity.Property(e => e.SumPickingRefNumber).HasMaxLength(50);

                entity.Property(e => e.TotalWeight).HasMaxLength(250);

                entity.Property(e => e.TransactionDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vehicle).HasMaxLength(250);

                entity.Property(e => e.VehicleLoad).HasMaxLength(250);

                entity.Property(e => e.WareHouseId)
                    .HasMaxLength(50)
                    .HasColumnName("WareHouseID");
            });

            modelBuilder.Entity<SovRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.RecognizedDateForPsov).HasColumnName("RecognizedDateForPSOV");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.SovinvoiceValue).HasColumnName("SOVInvoiceValue");

                entity.Property(e => e.SovnoofSku).HasColumnName("SOVNoofSKU");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<StagingAccessReport>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccessedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.AccessedUserCode).HasMaxLength(255);

                entity.Property(e => e.AccessedUserName).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DataType).HasMaxLength(255);

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.SyncCode).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<StagingSyncDataHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RunAllDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.StartDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TimeRunAdhoc).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<StagingSyncDataType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.RequestType).HasMaxLength(30);
            });

            modelBuilder.Entity<StagingSyncRefDataType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataType).HasMaxLength(100);
            });

            modelBuilder.Entity<Standard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<StandardItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.StateCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<SystemLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LogTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ObjectName).HasMaxLength(256);
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp(6) without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Description).HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SettingKey).HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SettingType).HasDefaultValueSql("''::character varying");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp(6) without time zone");
            });

            modelBuilder.Entity<TargetKpi>(entity =>
            {
                entity.ToTable("TargetKpi");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EmployeeCode).HasMaxLength(20);

                entity.Property(e => e.KpiFrequencyId).HasMaxLength(10);

                entity.Property(e => e.KpiType).HasMaxLength(100);

                entity.Property(e => e.KpiUom).HasMaxLength(20);

                entity.Property(e => e.KpiUpdatedDataTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalesindicatorCode).HasMaxLength(10);

                entity.Property(e => e.SyncCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TargetSaleCalendar>(entity =>
            {
                entity.ToTable("TargetSaleCalendar");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Date).HasColumnType("timestamp without time zone");

                entity.Property(e => e.QuaterlyId).HasMaxLength(10);

                entity.Property(e => e.SalesperiodId).HasMaxLength(10);

                entity.Property(e => e.SyncCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WeekId).HasMaxLength(10);
            });

            modelBuilder.Entity<TempBaselineDataBusinessModel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempBaselineDataConditionExclude>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempBaselineDataOrder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompleteDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.DsamanagerCode).HasColumnName("DSAManagerCode");

                entity.Property(e => e.Nsdcode).HasColumnName("NSDCode");

                entity.Property(e => e.OrderDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RzsuppervisorCode).HasColumnName("RZSuppervisorCode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoownerCode).HasColumnName("SOOwnerCode");

                entity.Property(e => e.SoshippedAmt).HasColumnName("SOShippedAmt");

                entity.Property(e => e.SoshippedExtendAmt).HasColumnName("SOShippedExtendAmt");

                entity.Property(e => e.VisitDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");
            });

            modelBuilder.Entity<TempBaselineDataOrderDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.OrdLineAmt).HasColumnName("Ord_Line_Amt");

                entity.Property(e => e.OrigOrdLineAmt).HasColumnName("Orig_Ord_Line_Amt");
            });

            modelBuilder.Entity<TempBaselineDataPurchaseOrder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompleteDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.DsamanagerCode).HasColumnName("DSAManagerCode");

                entity.Property(e => e.Grpodate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("GRPODate");

                entity.Property(e => e.Grponumber).HasColumnName("GRPONumber");

                entity.Property(e => e.Nsdcode).HasColumnName("NSDCode");

                entity.Property(e => e.OrderDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RzsuppervisorCode).HasColumnName("RZSuppervisorCode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.SocreateBy).HasColumnName("SOCreateBy");

                entity.Property(e => e.SoownerCode).HasColumnName("SOOwnerCode");

                entity.Property(e => e.SoshippedAmt).HasColumnName("SOShippedAmt");

                entity.Property(e => e.SoshippedExtendAmt).HasColumnName("SOShippedExtendAmt");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempBaselineDataPurchaseOrderDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Grponumber).HasColumnName("GRPONumber");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<TempBaselineDataVisit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.DsamanagerCode).HasColumnName("DSAManagerCode");

                entity.Property(e => e.Nsdcode).HasColumnName("NSDCode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempBaselineDataVisitStepResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempBaselineDetailRequestPo>(entity =>
            {
                entity.ToTable("TempBaselineDetailRequestPOs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Grpocode).HasColumnName("GRPOCode");

                entity.Property(e => e.Rpocode).HasColumnName("RPOCode");

                entity.Property(e => e.Skucode).HasColumnName("SKUCode");
            });

            modelBuilder.Entity<TempBaselineHeaderRequestPo>(entity =>
            {
                entity.ToTable("TempBaselineHeaderRequestPOs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Grpocode).HasColumnName("GRPOCode");

                entity.Property(e => e.Rpocode).HasColumnName("RPOCode");
            });

            modelBuilder.Entity<TempBeatPlan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempBeatPlanDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempCheckInventoryVisit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InventoryDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempDisApproveRegistrationCustomer>(entity =>
            {
                entity.ToTable("Temp_DisApproveRegistrationCustomers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);
            });

            modelBuilder.Entity<TempDisConfirmResultDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress).HasMaxLength(1000);

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.DisplayCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelCode).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelName).HasMaxLength(200);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.IsCheckSalesOutput).HasComment("Trường này không cần");

                entity.Property(e => e.NumberHasEvaluate).HasComment("Trường này không cần");

                entity.Property(e => e.NumberMustRating).HasComment("Trường này không cần");

                entity.Property(e => e.NumberPassed).HasComment("Trường này không cần");

                entity.Property(e => e.OutputPass).HasComment("Trường này không cần");

                entity.Property(e => e.OutputRegistered).HasComment("Trường này không cần");

                entity.Property(e => e.PeriodCode).HasMaxLength(10);

                entity.Property(e => e.SalesPass).HasComment("Trường này không cần");

                entity.Property(e => e.SalesRegistered).HasComment("Trường này không cần");

                entity.Property(e => e.VisitDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.VisitId)
                    .HasColumnName("VisitID")
                    .HasDefaultValueSql("''::text");
            });

            modelBuilder.Entity<TempDisCustomerShiptoNotHafe>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(200);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.InventoryItemCode).HasMaxLength(10);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.RouteZoneCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempDisCustomerShiptoSaleOrQuantity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(200);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.RouteZoneCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrgCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempDisDisplaySupportTool>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<TempDisOrderDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiscountId).HasMaxLength(10);

                entity.Property(e => e.DiscountName).HasMaxLength(200);

                entity.Property(e => e.DiscountSchemeId).HasMaxLength(10);

                entity.Property(e => e.DiscountType).HasMaxLength(10);

                entity.Property(e => e.DisplayLevel).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelName).HasMaxLength(200);

                entity.Property(e => e.InventoryId).HasMaxLength(10);

                entity.Property(e => e.InventoryName).HasMaxLength(200);

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PromotionLevel).HasMaxLength(10);

                entity.Property(e => e.RewardPeriodCode).HasMaxLength(10);

                entity.Property(e => e.RewardPeriodName).HasMaxLength(200);

                entity.Property(e => e.Tmktype)
                    .HasMaxLength(10)
                    .HasColumnName("TMKType");

                entity.Property(e => e.Uom).HasMaxLength(10);

                entity.Property(e => e.UomName).HasMaxLength(200);
            });

            modelBuilder.Entity<TempDisOrderHeader>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.AreaManagerCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.BranchManagerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerAttribute0).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute1).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute2).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute3).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute4).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute5).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute6).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute7).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute8).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute9).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.DiscountName).HasMaxLength(255);

                entity.Property(e => e.DisplayLevel).HasMaxLength(10);

                entity.Property(e => e.DisplayLevelName).HasMaxLength(10);

                entity.Property(e => e.DistyBilltoCode).HasMaxLength(10);

                entity.Property(e => e.DistyBilltoName).HasMaxLength(255);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.NsdCode).HasMaxLength(10);

                entity.Property(e => e.OrdDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PeriodCode).HasMaxLength(10);

                entity.Property(e => e.PrincipalId).HasMaxLength(10);

                entity.Property(e => e.RecallOrderCode).HasMaxLength(10);

                entity.Property(e => e.ReferenceLink).HasMaxLength(255);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.RegionManagerCode).HasMaxLength(10);

                entity.Property(e => e.RouteZoneId).HasMaxLength(10);

                entity.Property(e => e.RouteZoneName).HasMaxLength(255);

                entity.Property(e => e.RzSuppervisorCode).HasMaxLength(10);

                entity.Property(e => e.SalesOrgCode).HasMaxLength(10);

                entity.Property(e => e.SalesRepCode).HasMaxLength(10);

                entity.Property(e => e.ShiptoId).HasMaxLength(10);

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SicCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaManagerCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionManagerCode).HasMaxLength(10);

                entity.Property(e => e.Tmktype)
                    .HasMaxLength(10)
                    .HasColumnName("TMKType");
            });

            modelBuilder.Entity<TempDisPosmForCustomerShipto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoName).HasMaxLength(200);

                entity.Property(e => e.DsaCode).HasMaxLength(10);

                entity.Property(e => e.PosmCode).HasMaxLength(10);

                entity.Property(e => e.RegionCode).HasMaxLength(10);

                entity.Property(e => e.RouteZoneCode).HasMaxLength(10);

                entity.Property(e => e.SubAreaCode).HasMaxLength(10);

                entity.Property(e => e.SubRegionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempEvaluationPhotoVisit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InventoryDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempInventoryItemInfor>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");
            });

            modelBuilder.Entity<TempInvreport>(entity =>
            {
                entity.ToTable("Temp_INVReports");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.ReportDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TempInvreportLot>(entity =>
            {
                entity.ToTable("Temp_INVReportLots");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemKey).HasMaxLength(50);

                entity.Property(e => e.LocationCode).HasMaxLength(50);

                entity.Property(e => e.Lot).HasMaxLength(50);

                entity.Property(e => e.ReportDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Uom).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WareHouseCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TempKpidistributor>(entity =>
            {
                entity.ToTable("Temp_KPIDistributors");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsatarget).HasColumnName("DSATarget");

                entity.Property(e => e.Kpicode).HasColumnName("KPICode");

                entity.Property(e => e.SuggestKpi).HasColumnName("SuggestKPI");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempKpiemployee>(entity =>
            {
                entity.ToTable("Temp_KPIEmployees");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsatarget).HasColumnName("DSATarget");

                entity.Property(e => e.Kpicode).HasColumnName("KPICode");

                entity.Property(e => e.SuggestKpi).HasColumnName("SuggestKPI");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempKpisellIn>(entity =>
            {
                entity.ToTable("Temp_KPISellIns");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.SalesPeriodCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempParameterWithSitype>(entity =>
            {
                entity.ToTable("Temp_ParameterWithSitypes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PcconditionsNoofSku).HasColumnName("PcconditionsNoofSKU");

                entity.Property(e => e.RecognizedDateforSov).HasColumnName("RecognizedDateforSOV");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempPoKpi>(entity =>
            {
                entity.ToTable("Temp_PoKPIs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DistributorCode).HasMaxLength(50);

                entity.Property(e => e.DistributorName).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(50);

                entity.Property(e => e.ItemGroupDescription).HasMaxLength(250);

                entity.Property(e => e.ItemGroupId).HasMaxLength(50);

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempProgram>(entity =>
            {
                entity.ToTable("Temp_Programs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BuyType).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.GivingType).HasMaxLength(250);

                entity.Property(e => e.ItemScope).HasMaxLength(250);

                entity.Property(e => e.ProgramCode).HasMaxLength(250);

                entity.Property(e => e.ProgramsType).HasMaxLength(250);
            });

            modelBuilder.Entity<TempProgramDetailReward>(entity =>
            {
                entity.ToTable("Temp_ProgramDetailReward");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ItemCode).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailRewardCode).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailsKey).HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Uomcode)
                    .HasMaxLength(250)
                    .HasColumnName("UOMCode");
            });

            modelBuilder.Entity<TempProgramDetailsItemsGroup>(entity =>
            {
                entity.ToTable("Temp_ProgramDetailsItemsGroup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailsItemsGroupKey).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailsKey).HasMaxLength(250);

                entity.Property(e => e.Uomcode)
                    .HasMaxLength(250)
                    .HasColumnName("UOMCode");
            });

            modelBuilder.Entity<TempProgramsDetail>(entity =>
            {
                entity.ToTable("Temp_ProgramsDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Level).HasMaxLength(250);

                entity.Property(e => e.ProgramDetailsKey).HasMaxLength(250);

                entity.Property(e => e.ProgramsCode).HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(250);
            });

            modelBuilder.Entity<TempPromotionOrderRefNumber>(entity =>
            {
                entity.ToTable("Temp_PromotionOrderRefNumber");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.RefNumber).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempRoundingRule>(entity =>
            {
                entity.ToTable("Temp_RoundingRules");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempRouteZone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Dsaid).HasColumnName("DSAId");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempSalesIndicatorType>(entity =>
            {
                entity.ToTable("Temp_SalesIndicatorTypes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EndTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LevelSitype).HasColumnName("LevelSIType");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TempTpOrderDetail>(entity =>
            {
                entity.ToTable("Temp_TpOrderDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiscountId)
                    .HasMaxLength(10)
                    .HasColumnName("DiscountID");

                entity.Property(e => e.DiscountName).HasMaxLength(255);

                entity.Property(e => e.DiscountSchemeId)
                    .HasMaxLength(10)
                    .HasColumnName("DiscountSchemeID");

                entity.Property(e => e.DiscountType).HasMaxLength(10);

                entity.Property(e => e.InventoryId)
                    .HasMaxLength(10)
                    .HasColumnName("InventoryID");

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PromotionLevel).HasMaxLength(10);

                entity.Property(e => e.PromotionLevelName).HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasMaxLength(100)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(255)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TempTpOrderHeader>(entity =>
            {
                entity.ToTable("Temp_TpOrderHeaders");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(10)
                    .HasColumnName("Area_Code");

                entity.Property(e => e.AreaManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("Area_Manager_Code");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .HasColumnName("Branch_Code");

                entity.Property(e => e.BranchManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("Branch_Manager_Code");

                entity.Property(e => e.CustomerAttribute0).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute1).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute2).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute3).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute4).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute5).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute6).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute7).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute8).HasMaxLength(100);

                entity.Property(e => e.CustomerAttribute9).HasMaxLength(100);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.DistyBilltoCode)
                    .HasMaxLength(10)
                    .HasColumnName("Disty_BilltoCode");

                entity.Property(e => e.DistyBilltoName).HasColumnName("Disty_BilltoName");

                entity.Property(e => e.DsaCode)
                    .HasMaxLength(10)
                    .HasColumnName("DSA_Code");

                entity.Property(e => e.DsaManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("DSA_Manager_Code");

                entity.Property(e => e.NsdCode)
                    .HasMaxLength(10)
                    .HasColumnName("NSD_Code");

                entity.Property(e => e.OrdDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PeriodCode).HasMaxLength(10);

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(10)
                    .HasColumnName("PrincipalID");

                entity.Property(e => e.RecallOrderCode).HasMaxLength(10);

                entity.Property(e => e.ReferenceLink).HasMaxLength(255);

                entity.Property(e => e.RegionCode)
                    .HasMaxLength(10)
                    .HasColumnName("Region_Code");

                entity.Property(e => e.RegionManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("Region_Manager_Code");

                entity.Property(e => e.RouteZoneId)
                    .HasMaxLength(10)
                    .HasColumnName("RouteZoneID");

                entity.Property(e => e.RouteZoneName).HasMaxLength(255);

                entity.Property(e => e.RzSuppervisorCode)
                    .HasMaxLength(10)
                    .HasColumnName("RZ_Suppervisor_Code");

                entity.Property(e => e.SalesOrgCode)
                    .HasMaxLength(10)
                    .HasColumnName("SalesOrg_Code");

                entity.Property(e => e.SalesRepCode).HasMaxLength(10);

                entity.Property(e => e.ShiptoId)
                    .HasMaxLength(10)
                    .HasColumnName("ShiptoID");

                entity.Property(e => e.ShiptoName).HasMaxLength(255);

                entity.Property(e => e.SicCode)
                    .HasMaxLength(10)
                    .HasColumnName("SIC_Code");

                entity.Property(e => e.SoShippedDiscAmt).HasColumnName("SO_Shipped_Disc_Amt");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.SubAreaCode)
                    .HasMaxLength(10)
                    .HasColumnName("SubArea_Code");

                entity.Property(e => e.SubAreaManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("Sub_Area_Manager_Code");

                entity.Property(e => e.SubRegionCode)
                    .HasMaxLength(10)
                    .HasColumnName("SubRegion_Code");

                entity.Property(e => e.SubRegionManagerCode)
                    .HasMaxLength(10)
                    .HasColumnName("Sub_Region_Manager_Code");
            });

            modelBuilder.Entity<TempVisitStep>(entity =>
            {
                entity.ToTable("Temp_VisitSteps");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempVisitStepsDefaultResult>(entity =>
            {
                entity.ToTable("Temp_VisitStepsDefaultResults");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempVisitStepsReasonResult>(entity =>
            {
                entity.ToTable("Temp_VisitStepsReasonResults");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TemporarySic>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TemporarySicItemGroupDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.TemporarySic)
                    .WithMany(p => p.TemporarySicItemGroupDetails)
                    .HasForeignKey(d => d.TemporarySicId);
            });

            modelBuilder.Entity<TemporarySicKitDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.TemporarySic)
                    .WithMany(p => p.TemporarySicKitDetails)
                    .HasForeignKey(d => d.TemporarySicId);
            });

            modelBuilder.Entity<TerritoryMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.TerritoryStructureCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TerritoryStructure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.UntilDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TerritoryStructureDetail>(entity =>
            {
                entity.HasIndex(e => e.TerritoryStructureId, "IX_TerritoryStructureDetails_TerritoryStructureId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Source).HasMaxLength(20);

                entity.Property(e => e.TerritoryStructureCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.HasOne(d => d.TerritoryStructure)
                    .WithMany(p => p.TerritoryStructureDetails)
                    .HasForeignKey(d => d.TerritoryStructureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TerritoryStructureDetails_TerritoryStructures_TerritoryStru~");
            });

            modelBuilder.Entity<TerritoryValue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.Source).HasMaxLength(20);

                entity.Property(e => e.UntilDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudget>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetAllocationForm).HasMaxLength(100);

                entity.Property(e => e.BudgetAllocationLevel).HasMaxLength(10);

                entity.Property(e => e.BudgetType).HasMaxLength(10);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudgetAdjustment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Account).HasMaxLength(100);

                entity.Property(e => e.AdjustmentDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.BudgetCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudgetAllotment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.SalesTerritoryValueCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudgetAllotmentAdjustment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudgetDefine>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ItemHierarchyLevel).HasMaxLength(100);

                entity.Property(e => e.ItemHierarchyValue).HasMaxLength(100);

                entity.Property(e => e.PackSize).HasMaxLength(100);

                entity.Property(e => e.PromotionProductCode).HasMaxLength(10);

                entity.Property(e => e.PromotionProductType).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpBudgetUsed>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetCode).HasMaxLength(10);

                entity.Property(e => e.BudgetType).HasMaxLength(10);

                entity.Property(e => e.DsacodeCode).HasColumnName("DSACodeCode");
            });

            modelBuilder.Entity<TpDiscount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountFrequency).HasMaxLength(10);

                entity.Property(e => e.EffectiveDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.Scheme).HasMaxLength(255);

                entity.Property(e => e.ScopeType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.SicCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpDiscountObjectCustomerAttributeLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.DiscountCode).HasMaxLength(10);
            });

            modelBuilder.Entity<TpDiscountObjectCustomerAttributeValue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.CustomerAttributerValue).HasMaxLength(10);

                entity.Property(e => e.DiscountCode).HasMaxLength(10);
            });

            modelBuilder.Entity<TpDiscountObjectCustomerShipto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.DiscountCode).HasMaxLength(10);
            });

            modelBuilder.Entity<TpDiscountScopeDsa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.ScopeDsaValue).HasMaxLength(10);
            });

            modelBuilder.Entity<TpDiscountScopeTerritory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.SalesTerritoryValue).HasMaxLength(10);

                entity.Property(e => e.ScopeSaleTerritoryLevel).HasMaxLength(10);
            });

            modelBuilder.Entity<TpDiscountStructureDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.NameDiscountLevel).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplicableObjectType).HasMaxLength(10);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.FrequencyPromotion).HasMaxLength(10);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.PromotionType).HasMaxLength(10);

                entity.Property(e => e.SaleOrg).HasMaxLength(10);

                entity.Property(e => e.Scheme).HasMaxLength(255);

                entity.Property(e => e.ScopeType).HasMaxLength(10);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.SicCode).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionDefinitionProductForGift>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.Packing).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionDefinitionProductForSale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.Packing).HasMaxLength(10);

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionDefinitionStructure>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BudgetForDonation).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LevelCode).HasMaxLength(10);

                entity.Property(e => e.LevelName).HasMaxLength(255);

                entity.Property(e => e.ProductTypeForGift).HasMaxLength(10);

                entity.Property(e => e.ProductTypeForSale).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionObjectCustomerAttributeLevel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionObjectCustomerAttributeValue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerAttributerLevel).HasMaxLength(10);

                entity.Property(e => e.CustomerAttributerValue).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionObjectCustomerShipto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerCode).HasMaxLength(10);

                entity.Property(e => e.CustomerShiptoCode).HasMaxLength(10);

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionScopeDsa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ScopeDsaValue).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpPromotionScopeTerritory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PromotionCode).HasMaxLength(10);

                entity.Property(e => e.SaleOrg)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.SalesTerritoryValue).HasMaxLength(10);

                entity.Property(e => e.ScopeSaleTerritoryLevel)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpSettlement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ProgramType).HasDefaultValueSql("''::text");

                entity.Property(e => e.SettlementDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.TotalAmount).HasDefaultValueSql("0.0");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpSettlementDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DistributorCode).HasMaxLength(10);

                entity.Property(e => e.OrdDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.OrdNbr).HasMaxLength(10);

                entity.Property(e => e.PromotionDiscountCode).HasMaxLength(10);

                entity.Property(e => e.SettlementCode).HasMaxLength(10);

                entity.Property(e => e.ShiptoId).HasColumnName("ShiptoID");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TpSettlementObject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.PromotionDiscountCode).HasMaxLength(10);

                entity.Property(e => e.SettlementCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<TradePromotion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDateBefore).HasColumnType("timestamp without time zone");

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntilBefore).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Uom>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UomId).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastLogin).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastUpdatedUtc)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("LastUpdatedUTC")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UserCode).HasMaxLength(36);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("UserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_UserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLoginLog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Agent).HasMaxLength(250);

                entity.Property(e => e.Ip)
                    .HasMaxLength(30)
                    .HasColumnName("IP");

                entity.Property(e => e.LoginDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.LogoutDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Message).HasMaxLength(250);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<UserPolicy>(entity =>
            {
                entity.ToTable("UserPolicy");

                entity.HasIndex(e => e.PolicyId, "IX_UserPolicy_PolicyId");

                entity.HasIndex(e => e.UserId, "IX_UserPolicy_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.UserPolicies)
                    .HasForeignKey(d => d.PolicyId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPolicies)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(36);
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.VatId).HasMaxLength(5);
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(150);
            });

            modelBuilder.Entity<VisitList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VisitList");

                entity.Property(e => e.AllowStartDistance).HasMaxLength(50);

                entity.Property(e => e.AreaAssigmentId).HasMaxLength(50);

                entity.Property(e => e.AreaAssigmentName).HasMaxLength(255);

                entity.Property(e => e.AreaAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(255);

                entity.Property(e => e.Areaid).HasMaxLength(50);

                entity.Property(e => e.BranchAssigmentId).HasMaxLength(50);

                entity.Property(e => e.BranchAssigmentName).HasMaxLength(255);

                entity.Property(e => e.BranchAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.CusAttCode1).HasMaxLength(50);

                entity.Property(e => e.CusAttCode10).HasMaxLength(50);

                entity.Property(e => e.CusAttCode2).HasMaxLength(50);

                entity.Property(e => e.CusAttCode3).HasMaxLength(50);

                entity.Property(e => e.CusAttCode4).HasMaxLength(50);

                entity.Property(e => e.CusAttCode5).HasMaxLength(50);

                entity.Property(e => e.CusAttCode6).HasMaxLength(50);

                entity.Property(e => e.CusAttCode7).HasMaxLength(50);

                entity.Property(e => e.CusAttCode8).HasMaxLength(50);

                entity.Property(e => e.CusAttCode9).HasMaxLength(50);

                entity.Property(e => e.CusAttCodeName1).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName10).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName2).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName3).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName4).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName5).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName6).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName7).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName8).HasMaxLength(255);

                entity.Property(e => e.CusAttCodeName9).HasMaxLength(255);

                entity.Property(e => e.CusAttId1).HasMaxLength(50);

                entity.Property(e => e.CusAttId10).HasMaxLength(50);

                entity.Property(e => e.CusAttId2).HasMaxLength(50);

                entity.Property(e => e.CusAttId3).HasMaxLength(50);

                entity.Property(e => e.CusAttId4).HasMaxLength(50);

                entity.Property(e => e.CusAttId5).HasMaxLength(50);

                entity.Property(e => e.CusAttId6).HasMaxLength(50);

                entity.Property(e => e.CusAttId7).HasMaxLength(50);

                entity.Property(e => e.CusAttId8).HasMaxLength(50);

                entity.Property(e => e.CusAttId9).HasMaxLength(50);

                entity.Property(e => e.CusAttName1).HasMaxLength(255);

                entity.Property(e => e.CusAttName10).HasMaxLength(255);

                entity.Property(e => e.CusAttName2).HasMaxLength(255);

                entity.Property(e => e.CusAttName3).HasMaxLength(255);

                entity.Property(e => e.CusAttName4).HasMaxLength(255);

                entity.Property(e => e.CusAttName5).HasMaxLength(255);

                entity.Property(e => e.CusAttName6).HasMaxLength(255);

                entity.Property(e => e.CusAttName7).HasMaxLength(255);

                entity.Property(e => e.CusAttName8).HasMaxLength(255);

                entity.Property(e => e.CusAttName9).HasMaxLength(255);

                entity.Property(e => e.CusShiptoAddress).HasMaxLength(255);

                entity.Property(e => e.CusShiptoId).HasMaxLength(50);

                entity.Property(e => e.CusShiptoName).HasMaxLength(255);

                entity.Property(e => e.CusShiptoPhone).HasMaxLength(20);

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.DeviceImei).HasMaxLength(255);

                entity.Property(e => e.DeviceName).HasMaxLength(255);

                entity.Property(e => e.DisShiptoId).HasMaxLength(50);

                entity.Property(e => e.DisShiptoName).HasMaxLength(255);

                entity.Property(e => e.DistributorId).HasMaxLength(50);

                entity.Property(e => e.DistributorName).HasMaxLength(255);

                entity.Property(e => e.DsaAssigmentId).HasMaxLength(50);

                entity.Property(e => e.DsaAssigmentName).HasMaxLength(255);

                entity.Property(e => e.DsaAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.DsaId).HasMaxLength(50);

                entity.Property(e => e.DsaName).HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.EndTime).HasMaxLength(20);

                entity.Property(e => e.InvalidEndDistanceSelfie).HasMaxLength(100);

                entity.Property(e => e.InvalidStartDistanceSelfie).HasMaxLength(100);

                entity.Property(e => e.NationAssigmentId).HasMaxLength(50);

                entity.Property(e => e.NationAssigmentName).HasMaxLength(255);

                entity.Property(e => e.NationAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.NationId).HasMaxLength(50);

                entity.Property(e => e.NationName).HasMaxLength(255);

                entity.Property(e => e.NetworkCarrier).HasMaxLength(50);

                entity.Property(e => e.OutletProfileImage).HasMaxLength(100);

                entity.Property(e => e.ParameterRefId).HasMaxLength(50);

                entity.Property(e => e.ReasonCode).HasMaxLength(100);

                entity.Property(e => e.ReasonDesc).HasMaxLength(255);

                entity.Property(e => e.RegionAssigmentId).HasMaxLength(50);

                entity.Property(e => e.RegionAssigmentName).HasMaxLength(255);

                entity.Property(e => e.RegionAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasMaxLength(50);

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.RegisteredMerchanImage).HasMaxLength(100);

                entity.Property(e => e.RzId).HasMaxLength(50);

                entity.Property(e => e.RzName).HasMaxLength(255);

                entity.Property(e => e.RzSuppervisorId).HasMaxLength(100);

                entity.Property(e => e.RzSuppervisorName).HasMaxLength(255);

                entity.Property(e => e.RzType).HasMaxLength(50);

                entity.Property(e => e.SalesOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SalesOrgId).HasMaxLength(100);

                entity.Property(e => e.ShopClosedImage).HasMaxLength(100);

                entity.Property(e => e.SicId).HasMaxLength(50);

                entity.Property(e => e.SicName).HasMaxLength(255);

                entity.Property(e => e.SimSignalStatus).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasMaxLength(20);

                entity.Property(e => e.SubAreaAssigmentId).HasMaxLength(50);

                entity.Property(e => e.SubAreaAssigmentName).HasMaxLength(255);

                entity.Property(e => e.SubAreaAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.SubAreaId).HasMaxLength(50);

                entity.Property(e => e.SubAreaName).HasMaxLength(255);

                entity.Property(e => e.SubRegionAssigmentId).HasMaxLength(50);

                entity.Property(e => e.SubRegionAssigmentName).HasMaxLength(255);

                entity.Property(e => e.SubRegionAssigmentRole).HasMaxLength(50);

                entity.Property(e => e.SubRegionId).HasMaxLength(50);

                entity.Property(e => e.SubRegionName).HasMaxLength(255);

                entity.Property(e => e.TaskCode).HasMaxLength(50);

                entity.Property(e => e.TaskCodeDesc).HasMaxLength(255);

                entity.Property(e => e.TaskDesc).HasMaxLength(50);

                entity.Property(e => e.TaskId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.VisitCreatedById).HasMaxLength(50);

                entity.Property(e => e.VisitCreatedByJobTitle).HasMaxLength(50);

                entity.Property(e => e.VisitDate).HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.VisitId).HasMaxLength(100);

                entity.Property(e => e.VisitOwnedById).HasMaxLength(50);

                entity.Property(e => e.VisitOwnedByJobTitle).HasMaxLength(50);

                entity.Property(e => e.VisitStatus).HasMaxLength(50);

                entity.Property(e => e.VisitType).HasMaxLength(50);
            });

            modelBuilder.Entity<VisitProcessDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.SettingsRefNo).HasMaxLength(50);

                entity.Property(e => e.StepCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);
            });

            modelBuilder.Entity<VisitProcessSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EffectiveDate).HasPrecision(6);

                entity.Property(e => e.Objectives).HasMaxLength(100);

                entity.Property(e => e.Purpose).HasMaxLength(20);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasPrecision(6);

                entity.Property(e => e.ValidUntil).HasPrecision(6);

                entity.Property(e => e.VisitType).HasMaxLength(50);
            });

            modelBuilder.Entity<VisitStep>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<VpoRefResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.SovinvoiceValue).HasColumnName("SOVInvoiceValue");

                entity.Property(e => e.SovnoofSku).HasColumnName("SOVNoofSKU");
            });

            modelBuilder.Entity<VvrefResult>(entity =>
            {
                entity.ToTable("VVRefResults");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CalculatorTime).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Dsacode).HasColumnName("DSACode");

                entity.Property(e => e.Siccode).HasColumnName("SICCode");

                entity.Property(e => e.Sicode).HasColumnName("SICode");

                entity.Property(e => e.Sitype).HasColumnName("SIType");

                entity.Property(e => e.VisitDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.EffectiveDateFrom).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ShortName).HasMaxLength(40);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.ValidUntil).HasColumnType("timestamp without time zone");

                entity.Property(e => e.WardCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<WebNotiMessagese>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<WinzardFeature>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DetailFormPath).HasMaxLength(255);

                entity.Property(e => e.FeatureCode).HasMaxLength(100);

                entity.Property(e => e.FeatureName).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.ListFormPath).HasMaxLength(255);

                entity.Property(e => e.NewFormPath).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<WinzardSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");

                entity.Property(e => e.DisplayText).HasMaxLength(255);

                entity.Property(e => e.RoutePath).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<WorkingCalendar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.ApprovedByName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.JobtitileDescription).HasMaxLength(255);

                entity.Property(e => e.JobtitleCode).HasMaxLength(50);

                entity.Property(e => e.PeriodId).HasMaxLength(50);

                entity.Property(e => e.RejectReason).HasMaxLength(255);

                entity.Property(e => e.RequestReason).HasMaxLength(255);

                entity.Property(e => e.RequestStatus).HasMaxLength(255);

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.SaleOrgCode).HasMaxLength(50);

                entity.Property(e => e.SaleOrgDesc).HasMaxLength(255);

                entity.Property(e => e.SicCode).HasMaxLength(50);

                entity.Property(e => e.SicDescription).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarApproval>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.JobtitleCode).HasMaxLength(50);

                entity.Property(e => e.JobtitleName).HasMaxLength(255);

                entity.Property(e => e.Reason).HasMaxLength(255);

                entity.Property(e => e.RequestType).HasMaxLength(50);

                entity.Property(e => e.StatusCode).HasMaxLength(50);

                entity.Property(e => e.StatusDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarApproveSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.JobTitleCode).HasMaxLength(10);

                entity.Property(e => e.JobTitleName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarCustomer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomerAttribute).HasMaxLength(255);

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.ShiptoFullAddress).HasMaxLength(255);

                entity.Property(e => e.ShiptoId).HasMaxLength(50);

                entity.Property(e => e.TaskId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarFreeSetupSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarJobtitleSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.JobTitleCode).HasMaxLength(10);

                entity.Property(e => e.JobTitleName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarTypeCode).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarTypeValue).HasMaxLength(255);
            });

            modelBuilder.Entity<WorkingCalendarOpenWork>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.RefNumber).HasMaxLength(50);

                entity.Property(e => e.StatusCode).HasMaxLength(255);

                entity.Property(e => e.StatusDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarOpenWorkDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.JobtitileCode).HasMaxLength(50);

                entity.Property(e => e.JobtitileName).HasMaxLength(50);

                entity.Property(e => e.OpenWorkRefNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarRulesSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarSessionSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Session).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarShiftSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ShiftCode).HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarTask>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomerType).HasMaxLength(255);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(255);

                entity.Property(e => e.Session).HasMaxLength(50);

                entity.Property(e => e.ShiftCode).HasMaxLength(50);

                entity.Property(e => e.ShiftName).HasMaxLength(255);

                entity.Property(e => e.TaskCode).HasMaxLength(50);

                entity.Property(e => e.TaskId).HasMaxLength(50);

                entity.Property(e => e.TaskName).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarCode).HasMaxLength(50);

                entity.Property(e => e.WorkingCalendarType).HasMaxLength(50);

                entity.Property(e => e.WorkingType).HasMaxLength(255);

                entity.Property(e => e.WorkingWithObject).HasMaxLength(255);
            });

            modelBuilder.Entity<WorkingCalendarTaskApplySetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.JobtitileCode).HasMaxLength(50);

                entity.Property(e => e.JobtitleName).HasMaxLength(255);

                entity.Property(e => e.TaskCode).HasMaxLength(50);

                entity.Property(e => e.TaskDescription).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarTaskSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.TaskCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WorkingType).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkingCalendarTypeSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
