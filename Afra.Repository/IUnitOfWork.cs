using Afra.Repository.Repositories;
using System;
using System.Threading.Tasks;

namespace Afra.Repository
{
    public interface IUnitOfWork : IDisposable
    {
         

IWorkFlowsRepository WorkFlowsRepository { get; } 

IWorkFlowsFormRepository WorkFlowsFormRepository { get; } 

IWorkFlowStepsRepository WorkFlowStepsRepository { get; } 

IWorkStationRepository WorkStationRepository { get; } 

IWebDocsRepository WebDocsRepository { get; } 

IWebImagesRepository WebImagesRepository { get; } 

IWebLoginsRepository WebLoginsRepository { get; } 

IWebMessagesRepository WebMessagesRepository { get; } 

IUsrBuyServiceRepository UsrBuyServiceRepository { get; } 

IUsrBuyServiceDetRepository UsrBuyServiceDetRepository { get; } 

IUsrCashRepository UsrCashRepository { get; } 

IUsrCashDetRepository UsrCashDetRepository { get; } 

IUsrContInfRepository UsrContInfRepository { get; } 

IUsrCrsOthInfRepository UsrCrsOthInfRepository { get; } 

IUsrExhibitionRqstRepository UsrExhibitionRqstRepository { get; } 

IUsrMissionDetRepository UsrMissionDetRepository { get; } 

IUsrNewsCheckRqstRepository UsrNewsCheckRqstRepository { get; } 

IUsrPersHrmRelsRepository UsrPersHrmRelsRepository { get; } 

IUsrPersHrmRelsApplRepository UsrPersHrmRelsApplRepository { get; } 

IUsrPersHrmRelsConsRepository UsrPersHrmRelsConsRepository { get; } 

IUsrPersHrmRelsDocRepository UsrPersHrmRelsDocRepository { get; } 

IUsrPersHrmRelsKigrRepository UsrPersHrmRelsKigrRepository { get; } 

IUsrPersHrmRelsRehabRepository UsrPersHrmRelsRehabRepository { get; } 

IUsrProdCostRepository UsrProdCostRepository { get; } 

IUsrProdExtRepository UsrProdExtRepository { get; } 

IUsrProdRcvRepository UsrProdRcvRepository { get; } 

IUsrProdResRepository UsrProdResRepository { get; } 

IUsrProdVchRepository UsrProdVchRepository { get; } 

IUsrProdWastRepository UsrProdWastRepository { get; } 

IUsrRqstVacRepository UsrRqstVacRepository { get; } 

IUsrTest1Repository UsrTest1Repository { get; } 

IUsrTestFormRepository UsrTestFormRepository { get; } 

IUsrTestGridRepository UsrTestGridRepository { get; } 

IUsrTrsRqstBankInfRepository UsrTrsRqstBankInfRepository { get; } 

IUsrvchBaseInfoRepository UsrvchBaseInfoRepository { get; } 

IUserAccessRepository UserAccessRepository { get; } 

IUserAlternativeRepository UserAlternativeRepository { get; } 

IUserArchiveRepository UserArchiveRepository { get; } 

IUserArchTypeRepository UserArchTypeRepository { get; } 

IUserPlaningRepository UserPlaningRepository { get; } 

IUserPlaningDetRepository UserPlaningDetRepository { get; } 

IUserPlaningDetInfRepository UserPlaningDetInfRepository { get; } 

IUserProcessRepository UserProcessRepository { get; } 

IUserProcessStpRepository UserProcessStpRepository { get; } 

IUserRepAccessRepository UserRepAccessRepository { get; } 

IUsersRepository UsersRepository { get; } 

IUserSignRightRepository UserSignRightRepository { get; } 

IUsersRelsRepository UsersRelsRepository { get; } 

IUsGroupAccessRepository UsGroupAccessRepository { get; } 

IUsGroupRepAccessRepository UsGroupRepAccessRepository { get; } 

IUsGroupsRepository UsGroupsRepository { get; } 

ITrsAccOprRepository TrsAccOprRepository { get; } 

ITrsBankAccountsRepository TrsBankAccountsRepository { get; } 

ITrsBankBillRepository TrsBankBillRepository { get; } 

ITrsBankBillDetRepository TrsBankBillDetRepository { get; } 

ITrsBankBranchsRepository TrsBankBranchsRepository { get; } 

ITrsBankChqsRepository TrsBankChqsRepository { get; } 

ITrsBankChqsDetRepository TrsBankChqsDetRepository { get; } 

ITrsBankReconcileRepository TrsBankReconcileRepository { get; } 

ITrsBankReconcileDetRepository TrsBankReconcileDetRepository { get; } 

ITrsBanksRepository TrsBanksRepository { get; } 

ITrsCalcFormulaRepository TrsCalcFormulaRepository { get; } 

ITrsCashsRepository TrsCashsRepository { get; } 

ITrsChqFmtRepository TrsChqFmtRepository { get; } 

ITrsCostFactorsRepository TrsCostFactorsRepository { get; } 

ITrsCreditTblRepository TrsCreditTblRepository { get; } 

ITrsCreditTblDetRepository TrsCreditTblDetRepository { get; } 

ITrsDepositRepository TrsDepositRepository { get; } 

ITrsDepositCalcRepository TrsDepositCalcRepository { get; } 

ITrsDepositDetRepository TrsDepositDetRepository { get; } 

ITrsFacCrdTblRepository TrsFacCrdTblRepository { get; } 

ITrsFacCrdTblDetRepository TrsFacCrdTblDetRepository { get; } 

ITrsFacilitiesRepository TrsFacilitiesRepository { get; } 

ITrsFacilitiesDetRepository TrsFacilitiesDetRepository { get; } 

ITrsFacilitiesGuaRepository TrsFacilitiesGuaRepository { get; } 

ITrsFacilitiesSecRepository TrsFacilitiesSecRepository { get; } 

ITrsFacManCreditRepository TrsFacManCreditRepository { get; } 

ITrsFacTypeInfRepository TrsFacTypeInfRepository { get; } 

ITrsFacYearShareRepository TrsFacYearShareRepository { get; } 

ITrsFContractRepository TrsFContractRepository { get; } 

ITrsFContractDetRepository TrsFContractDetRepository { get; } 

ITrsFixAccRepository TrsFixAccRepository { get; } 

ITrsFixAccDetRepository TrsFixAccDetRepository { get; } 

ITrsFundBillHdrRepository TrsFundBillHdrRepository { get; } 

ITrsFundBillItmRepository TrsFundBillItmRepository { get; } 

ITrsFundItmDetRepository TrsFundItmDetRepository { get; } 

ITrsFundOprRepository TrsFundOprRepository { get; } 

ITrsFundsRepository TrsFundsRepository { get; } 

ITrsGContractRepository TrsGContractRepository { get; } 

ITrsGContractChngRepository TrsGContractChngRepository { get; } 

ITrsGuaranteeRepository TrsGuaranteeRepository { get; } 

ITrsGuaranteeGuaRepository TrsGuaranteeGuaRepository { get; } 

ITrsGuaranteeOprRepository TrsGuaranteeOprRepository { get; } 

ITrsGuaranteeSecRepository TrsGuaranteeSecRepository { get; } 

ITrsGuaYearShareRepository TrsGuaYearShareRepository { get; } 

ITrsManCreditRepository TrsManCreditRepository { get; } 

ITrsPayBoredItmRepository TrsPayBoredItmRepository { get; } 

ITrsPayBoredOprRepository TrsPayBoredOprRepository { get; } 

ITrsPayChqItmRepository TrsPayChqItmRepository { get; } 

ITrsPayChqOprRepository TrsPayChqOprRepository { get; } 

ITrsPayHistoryRepository TrsPayHistoryRepository { get; } 

ITrsRcvBoredItmRepository TrsRcvBoredItmRepository { get; } 

ITrsRcvBoredOprRepository TrsRcvBoredOprRepository { get; } 

ITrsRcvChqItmRepository TrsRcvChqItmRepository { get; } 

ITrsRcvChqOprRepository TrsRcvChqOprRepository { get; } 

ITrsRcvHistoryRepository TrsRcvHistoryRepository { get; } 

ITrsRqstHdrRepository TrsRqstHdrRepository { get; } 

ITrsRqstItmRepository TrsRqstItmRepository { get; } 

ITrsSourceUseRepository TrsSourceUseRepository { get; } 

ITrsSourceUseRelsRepository TrsSourceUseRelsRepository { get; } 

ITrsVchHdrRepository TrsVchHdrRepository { get; } 

ITrsVchItmRepository TrsVchItmRepository { get; } 

ITrsVchItmBaseRepository TrsVchItmBaseRepository { get; } 

ITrsVchItmRelRepository TrsVchItmRelRepository { get; } 

ITrsVchSrcUseRepository TrsVchSrcUseRepository { get; } 

IStkPeriodsRepository StkPeriodsRepository { get; } 

IStkStockDocsRepository StkStockDocsRepository { get; } 

IStkStockerInitRepository StkStockerInitRepository { get; } 

IStkStockersRepository StkStockersRepository { get; } 

IStkStockTransRepository StkStockTransRepository { get; } 

ISMSMethodRepository SMSMethodRepository { get; } 

ISMSOperateRepository SMSOperateRepository { get; } 

ISMSOperateDetRepository SMSOperateDetRepository { get; } 

ISMSSettingRepository SMSSettingRepository { get; } 

IShopGiftCardRepository ShopGiftCardRepository { get; } 

IShopGiftPartRepository ShopGiftPartRepository { get; } 

IShopPartPriceRepository ShopPartPriceRepository { get; } 

IShopsRepository ShopsRepository { get; } 

IShopTaxValsRepository ShopTaxValsRepository { get; } 

ISleAftSrvRepository SleAftSrvRepository { get; } 

ISleBranchsRepository SleBranchsRepository { get; } 

ISleBrokerCalcRepository SleBrokerCalcRepository { get; } 

ISleBrokersRepository SleBrokersRepository { get; } 

ISleBrokerSalaryRepository SleBrokerSalaryRepository { get; } 

ISleBrokerSalaryMthdRepository SleBrokerSalaryMthdRepository { get; } 

ISleBrokerSalaryRelsRepository SleBrokerSalaryRelsRepository { get; } 

ISleBrokerSalaryTaxRepository SleBrokerSalaryTaxRepository { get; } 

ISleChngVchHdrRepository SleChngVchHdrRepository { get; } 

ISleChngVchItmRepository SleChngVchItmRepository { get; } 

ISleChngVchTaxRepository SleChngVchTaxRepository { get; } 

ISleCstmrBrokersRepository SleCstmrBrokersRepository { get; } 

ISleCstmrGroupsRepository SleCstmrGroupsRepository { get; } 

ISleCstmrLimitRepository SleCstmrLimitRepository { get; } 

ISleCstmrsRepository SleCstmrsRepository { get; } 

ISleCtgryRepository SleCtgryRepository { get; } 

ISleCtgryAccRepository SleCtgryAccRepository { get; } 

ISleDebCreHdrRepository SleDebCreHdrRepository { get; } 

ISleDebCreItmRepository SleDebCreItmRepository { get; } 

ISleFixAccRepository SleFixAccRepository { get; } 

ISleGuaDocsRepository SleGuaDocsRepository { get; } 

ISleGuaranteeRepository SleGuaranteeRepository { get; } 

ISleLimitsRepository SleLimitsRepository { get; } 

ISlePlacesRepository SlePlacesRepository { get; } 

ISlePriceHdrRepository SlePriceHdrRepository { get; } 

ISlePriceItmRepository SlePriceItmRepository { get; } 

ISleServicesRepository SleServicesRepository { get; } 

ISleSrvGroupsRepository SleSrvGroupsRepository { get; } 

ISleSrvHdrRepository SleSrvHdrRepository { get; } 

ISleSrvItmRepository SleSrvItmRepository { get; } 

ISleSrvPrcHdrRepository SleSrvPrcHdrRepository { get; } 

ISleSrvPrcItmRepository SleSrvPrcItmRepository { get; } 

ISleSrvTaxRepository SleSrvTaxRepository { get; } 

ISleTaxDefValRepository SleTaxDefValRepository { get; } 

ISleTaxesRepository SleTaxesRepository { get; } 

ISleTypesRepository SleTypesRepository { get; } 

ISleVchHdrRepository SleVchHdrRepository { get; } 

ISleVchItmRepository SleVchItmRepository { get; } 

ISleVchQtyValRepository SleVchQtyValRepository { get; } 

ISleVchTaxRepository SleVchTaxRepository { get; } 

ISleVchTypesRepository SleVchTypesRepository { get; } 

IQcsBasesRepository QcsBasesRepository { get; } 

IQcsDocsRepository QcsDocsRepository { get; } 

IQcsMenLabsRepository QcsMenLabsRepository { get; } 

IQcsMensRepository QcsMensRepository { get; } 

IQcsRequestRepository QcsRequestRepository { get; } 

IQcsTestDetRepository QcsTestDetRepository { get; } 

IQcsTestDocsRepository QcsTestDocsRepository { get; } 

IQcsTestsRepository QcsTestsRepository { get; } 

IQcsVchHdrRepository QcsVchHdrRepository { get; } 

IQcsVchItmRepository QcsVchItmRepository { get; } 

IPrdCalenderRepository PrdCalenderRepository { get; } 

IPrdConsumHdrRepository PrdConsumHdrRepository { get; } 

IPrdConsumItmRepository PrdConsumItmRepository { get; } 

IPrdFixInfRepository PrdFixInfRepository { get; } 

IPrdFixStopRepository PrdFixStopRepository { get; } 

IPrdMachineRepository PrdMachineRepository { get; } 

IPrdMacroRepository PrdMacroRepository { get; } 

IPrdMatPkgRepository PrdMatPkgRepository { get; } 

IPrdMatPlanRepository PrdMatPlanRepository { get; } 

IPrdOperationRepository PrdOperationRepository { get; } 

IPrdOprDetRepository PrdOprDetRepository { get; } 

IPrdOprDetInfRepository PrdOprDetInfRepository { get; } 

IPrdOprDetPersRepository PrdOprDetPersRepository { get; } 

IPrdOrdHdrRepository PrdOrdHdrRepository { get; } 

IPrdOrdItmRepository PrdOrdItmRepository { get; } 

IPrdOrdSchedRepository PrdOrdSchedRepository { get; } 

IPrdPersRepository PrdPersRepository { get; } 

IPrdPersWorkStRepository PrdPersWorkStRepository { get; } 

IPrdPOrdHdrRepository PrdPOrdHdrRepository { get; } 

IPrdPOrdItmRepository PrdPOrdItmRepository { get; } 

IPrdPOrdItmDetRepository PrdPOrdItmDetRepository { get; } 

IPrdSchStopRepository PrdSchStopRepository { get; } 

IPrdSendHdrRepository PrdSendHdrRepository { get; } 

IPrdSendItmRepository PrdSendItmRepository { get; } 

IPrdShiftsRepository PrdShiftsRepository { get; } 

IPrdStopRepository PrdStopRepository { get; } 

IPrdStopItmRepository PrdStopItmRepository { get; } 

IPrdVchHdrRepository PrdVchHdrRepository { get; } 

IPrdVchInvDetRepository PrdVchInvDetRepository { get; } 

IPrdVchItmRepository PrdVchItmRepository { get; } 

IProjectsRepository ProjectsRepository { get; } 

IPayAccVchRepository PayAccVchRepository { get; } 

IPayAccVchDetRepository PayAccVchDetRepository { get; } 

IPayBdgBaseRepository PayBdgBaseRepository { get; } 

IPayBdgStateRepository PayBdgStateRepository { get; } 

IPayBdgValsRepository PayBdgValsRepository { get; } 

IPayBuyBaseRepository PayBuyBaseRepository { get; } 

IPayBuyCalcRepository PayBuyCalcRepository { get; } 

IPayCalcBaseRepository PayCalcBaseRepository { get; } 

IPayCalcCtrlRepository PayCalcCtrlRepository { get; } 

IPayCalcCtrlDetRepository PayCalcCtrlDetRepository { get; } 

IPayCalcStateRepository PayCalcStateRepository { get; } 

IPayCalcValsRepository PayCalcValsRepository { get; } 

IPayCompBranchsRepository PayCompBranchsRepository { get; } 

IPayCompsRepository PayCompsRepository { get; } 

IPayCtrlRepository PayCtrlRepository { get; } 

IPayElmntRelsRepository PayElmntRelsRepository { get; } 

IPayExpDetRepository PayExpDetRepository { get; } 

IPayExportFilesRepository PayExportFilesRepository { get; } 

IPayFishRepository PayFishRepository { get; } 

IPayFishElmntRepository PayFishElmntRepository { get; } 

IPayFixElmntRepository PayFixElmntRepository { get; } 

IPayFixElmntValRepository PayFixElmntValRepository { get; } 

IPayGrpLoanRepository PayGrpLoanRepository { get; } 

IPayGrpLoanPersRepository PayGrpLoanPersRepository { get; } 

IPayGrpValStatRepository PayGrpValStatRepository { get; } 

IPayGrpValStatAmntRepository PayGrpValStatAmntRepository { get; } 

IPayGrpValStatPersRepository PayGrpValStatPersRepository { get; } 

IPayImpDetRepository PayImpDetRepository { get; } 

IPayImportFilesRepository PayImportFilesRepository { get; } 

IPayLoanHistoryRepository PayLoanHistoryRepository { get; } 

IPayLoanPaymentRepository PayLoanPaymentRepository { get; } 

IPayLoanRcvRepository PayLoanRcvRepository { get; } 

IPayLoanTypesRepository PayLoanTypesRepository { get; } 

IPayMonthlyMthdRepository PayMonthlyMthdRepository { get; } 

IPayMonthlyValsRepository PayMonthlyValsRepository { get; } 

IPayPersEndRepository PayPersEndRepository { get; } 

IPayRepListsRepository PayRepListsRepository { get; } 

IPaySystemsRepository PaySystemsRepository { get; } 

IPayTaxCompsRepository PayTaxCompsRepository { get; } 

IPayTaxDetRepository PayTaxDetRepository { get; } 

IPayTaxTableRepository PayTaxTableRepository { get; } 

IPayUserFieldRepository PayUserFieldRepository { get; } 

IPayUserFunsRepository PayUserFunsRepository { get; } 

IPayVacMonthlyRepository PayVacMonthlyRepository { get; } 

IPayVacRemainRepository PayVacRemainRepository { get; } 

IPayValStatAmntRepository PayValStatAmntRepository { get; } 

IPayValStatsRepository PayValStatsRepository { get; } 

IPayVchDetRepository PayVchDetRepository { get; } 

IPayVchDetInfsRepository PayVchDetInfsRepository { get; } 

IPayVchTypeRepository PayVchTypeRepository { get; } 

IPayWorkLimitRepository PayWorkLimitRepository { get; } 

IPartFormulaRepository PartFormulaRepository { get; } 

IPartFormulaDetRepository PartFormulaDetRepository { get; } 

IPartFrmlMachRepository PartFrmlMachRepository { get; } 

IPartFrmlOutRepository PartFrmlOutRepository { get; } 

IPartsRepository PartsRepository { get; } 

IPmiReqPartRepository PmiReqPartRepository { get; } 

IOtoAttachRepository OtoAttachRepository { get; } 

IOtoBaseTypesRepository OtoBaseTypesRepository { get; } 

IOtoBaseTypeValsRepository OtoBaseTypeValsRepository { get; } 

IOtoCtgryRepository OtoCtgryRepository { get; } 

IOtoFilesRepository OtoFilesRepository { get; } 

IOtoFlowRepository OtoFlowRepository { get; } 

IOtoFlowCrsRepository OtoFlowCrsRepository { get; } 

IOtoFlowRightRepository OtoFlowRightRepository { get; } 

IOtoIndicatorRepository OtoIndicatorRepository { get; } 

IOtoLettersRepository OtoLettersRepository { get; } 

IOtoLttrDocRepository OtoLttrDocRepository { get; } 

IOtoLttrLabelsRepository OtoLttrLabelsRepository { get; } 

IOtoLttrLinksRepository OtoLttrLinksRepository { get; } 

IOtoLttrPropsRepository OtoLttrPropsRepository { get; } 

IOtoQuickNoteRepository OtoQuickNoteRepository { get; } 

IOtoSysLttrRepository OtoSysLttrRepository { get; } 

IOtoTemplatesRepository OtoTemplatesRepository { get; } 

IOtoTransScriptRepository OtoTransScriptRepository { get; } 

IOtoUserRightRepository OtoUserRightRepository { get; } 

IInvFormHdrRepository InvFormHdrRepository { get; } 

IInvFormItmRepository InvFormItmRepository { get; } 

IInvFormTypesRepository InvFormTypesRepository { get; } 

IInvItmRateDetRepository InvItmRateDetRepository { get; } 

IInvPartCmrInfRepository InvPartCmrInfRepository { get; } 

IInvPartCtgryRepository InvPartCtgryRepository { get; } 

IInvPartCtgryAccRepository InvPartCtgryAccRepository { get; } 

IInvPartDLInfRepository InvPartDLInfRepository { get; } 

IInvPartGroupsRepository InvPartGroupsRepository { get; } 

IInvPartGrpRelRepository InvPartGrpRelRepository { get; } 

IInvPartParamsRepository InvPartParamsRepository { get; } 

IInvPartPriceRepository InvPartPriceRepository { get; } 

IInvPartSimilarRepository InvPartSimilarRepository { get; } 

IInvPartStkPitchRelRepository InvPartStkPitchRelRepository { get; } 

IInvPartStockRelRepository InvPartStockRelRepository { get; } 

IInvPartUnitsRepository InvPartUnitsRepository { get; } 

IInvQtPartRelsRepository InvQtPartRelsRepository { get; } 

IInvQtyCtrlsRepository InvQtyCtrlsRepository { get; } 

IInvStckPeriodRepository InvStckPeriodRepository { get; } 

IInvStckPeriodRelsRepository InvStckPeriodRelsRepository { get; } 

IInvStckTagRepository InvStckTagRepository { get; } 

IInvStkPitchsRepository InvStkPitchsRepository { get; } 

IInvStockRepository InvStockRepository { get; } 

IInvStockUserRepository InvStockUserRepository { get; } 

IInvVchDefAccRepository InvVchDefAccRepository { get; } 

IInvVchHdrRepository InvVchHdrRepository { get; } 

IInvVchItmRepository InvVchItmRepository { get; } 

IInvVchItmRateRepository InvVchItmRateRepository { get; } 

IInvVchQtyValRepository InvVchQtyValRepository { get; } 

IInvVchTransRepository InvVchTransRepository { get; } 

IInvVchTypesRepository InvVchTypesRepository { get; } 

IHrmAimElmntsRepository HrmAimElmntsRepository { get; } 

IHrmAimFormDetRepository HrmAimFormDetRepository { get; } 

IHrmAimFormsRepository HrmAimFormsRepository { get; } 

IHrmAimPeriodRepository HrmAimPeriodRepository { get; } 

IHrmAimPeriodDetRepository HrmAimPeriodDetRepository { get; } 

IHrmBaseAmountsRepository HrmBaseAmountsRepository { get; } 

IHrmBasesRepository HrmBasesRepository { get; } 

IHrmCalendarsRepository HrmCalendarsRepository { get; } 

IHrmCalenderDetRepository HrmCalenderDetRepository { get; } 

IHrmDeptRepository HrmDeptRepository { get; } 

IHrmDeptJobRelRepository HrmDeptJobRelRepository { get; } 

IHrmEmpStatAmntRepository HrmEmpStatAmntRepository { get; } 

IHrmEmpStatueRepository HrmEmpStatueRepository { get; } 

IHrmEmpTypesRepository HrmEmpTypesRepository { get; } 

IHrmGroupsRepository HrmGroupsRepository { get; } 

IHrmGrpCompAsignRepository HrmGrpCompAsignRepository { get; } 

IHrmGrpParamStatRepository HrmGrpParamStatRepository { get; } 

IHrmGrpParamStatAmntRepository HrmGrpParamStatAmntRepository { get; } 

IHrmGrpParamStatPersRepository HrmGrpParamStatPersRepository { get; } 

IHrmGrpStatAmntsRepository HrmGrpStatAmntsRepository { get; } 

IHrmGrpStatPersRepository HrmGrpStatPersRepository { get; } 

IHrmGrpStatusRepository HrmGrpStatusRepository { get; } 

IHrmIncDecVacRepository HrmIncDecVacRepository { get; } 

IHrmIncDecWorkRepository HrmIncDecWorkRepository { get; } 

IHrmJobCondRepository HrmJobCondRepository { get; } 

IHrmJobsRepository HrmJobsRepository { get; } 

IHrmMissionsRepository HrmMissionsRepository { get; } 

IHrmNumberingRepository HrmNumberingRepository { get; } 

IHrmOvrTimePermRepository HrmOvrTimePermRepository { get; } 

IHrmParamStatAmntRepository HrmParamStatAmntRepository { get; } 

IHrmParamStatsRepository HrmParamStatsRepository { get; } 

IHrmPersAccountRepository HrmPersAccountRepository { get; } 

IHrmPersCompAsignRepository HrmPersCompAsignRepository { get; } 

IHrmPersEduRepository HrmPersEduRepository { get; } 

IHrmPersExpRepository HrmPersExpRepository { get; } 

IHrmPersFghRepository HrmPersFghRepository { get; } 

IHrmPersLangRepository HrmPersLangRepository { get; } 

IHrmPersMrgRepository HrmPersMrgRepository { get; } 

IHrmPersonnelsRepository HrmPersonnelsRepository { get; } 

IHrmPersParamRepository HrmPersParamRepository { get; } 

IHrmPersRltdRepository HrmPersRltdRepository { get; } 

IHrmPersSldrRepository HrmPersSldrRepository { get; } 

IHrmPrsntStatRepository HrmPrsntStatRepository { get; } 

IHrmRqstMissionRepository HrmRqstMissionRepository { get; } 

IHrmRqstVacRepository HrmRqstVacRepository { get; } 

IHrmStatElmntMthdRepository HrmStatElmntMthdRepository { get; } 

IHrmStatMthdDetRepository HrmStatMthdDetRepository { get; } 

IHrmStatTypesRepository HrmStatTypesRepository { get; } 

IHrmTablesRepository HrmTablesRepository { get; } 

IHrmTablesDetRepository HrmTablesDetRepository { get; } 

IHrmTimeSheetRepository HrmTimeSheetRepository { get; } 

IHrmVacancyRepository HrmVacancyRepository { get; } 

IHrmVacMthodsRepository HrmVacMthodsRepository { get; } 

IHrmWorkGroupsRepository HrmWorkGroupsRepository { get; } 

IHrmWorkGroupsInfRepository HrmWorkGroupsInfRepository { get; } 

IHrmWorkLocRepository HrmWorkLocRepository { get; } 

IGnrAlarmDetRepository GnrAlarmDetRepository { get; } 

IGnrAlarmTypesRepository GnrAlarmTypesRepository { get; } 

IGnrAutoTextRepository GnrAutoTextRepository { get; } 

IGnrDashboardsRepository GnrDashboardsRepository { get; } 

IGnrDashFieldsRepository GnrDashFieldsRepository { get; } 

IGnrFormFlowRepository GnrFormFlowRepository { get; } 

IGnrFormRepRelsRepository GnrFormRepRelsRepository { get; } 

IGnrFormSettingRepository GnrFormSettingRepository { get; } 

IGnrLimitExceptRepository GnrLimitExceptRepository { get; } 

IGnrLimitGroupRepository GnrLimitGroupRepository { get; } 

IGnrLimitUserRepository GnrLimitUserRepository { get; } 

IGnrNumVchCfgDetRepository GnrNumVchCfgDetRepository { get; } 

IGnrNumVchConfigRepository GnrNumVchConfigRepository { get; } 

IGnrProcessRepository GnrProcessRepository { get; } 

IGnrProcessDetRepository GnrProcessDetRepository { get; } 

IGnrProcessDetArchRepository GnrProcessDetArchRepository { get; } 

IGnrProcessDetObjRepository GnrProcessDetObjRepository { get; } 

IGnrProcessDetTransRepository GnrProcessDetTransRepository { get; } 

IGnrProcessDetUsersRepository GnrProcessDetUsersRepository { get; } 

IGnrProcessDetValsRepository GnrProcessDetValsRepository { get; } 

IGnrRef2FormLinkExpRepository GnrRef2FormLinkExpRepository { get; } 

IGnrRef2FormLinkHdrRepository GnrRef2FormLinkHdrRepository { get; } 

IGnrRef2FormLinksItmRepository GnrRef2FormLinksItmRepository { get; } 

IGnrRefFormsListRepository GnrRefFormsListRepository { get; } 

IGnrRefFormsListDetRepository GnrRefFormsListDetRepository { get; } 

IGnrReportsRepository GnrReportsRepository { get; } 

IGnrRptGroupsRepository GnrRptGroupsRepository { get; } 

IGnrSysFormObjectsRepository GnrSysFormObjectsRepository { get; } 

IGnrSysFormsRepository GnrSysFormsRepository { get; } 

IGnrSysLogsRepository GnrSysLogsRepository { get; } 

IGnrSysMsgRepository GnrSysMsgRepository { get; } 

IGnrSysMsgDetRepository GnrSysMsgDetRepository { get; } 

IGnrSysQryFieldsRepository GnrSysQryFieldsRepository { get; } 

IGnrSysQuerysRepository GnrSysQuerysRepository { get; } 

IGnrSysTablesRepository GnrSysTablesRepository { get; } 

IGnrTableRelationRepository GnrTableRelationRepository { get; } 

IGnrTablesDetRepository GnrTablesDetRepository { get; } 

IGnrTablesInfRepository GnrTablesInfRepository { get; } 

IGnrToolsRepository GnrToolsRepository { get; } 

IGnrUFCtgryRepository GnrUFCtgryRepository { get; } 

IGnrUserAlarmsRepository GnrUserAlarmsRepository { get; } 

IGnrUserFieldRepository GnrUserFieldRepository { get; } 

IGnrUserFormDesignRepository GnrUserFormDesignRepository { get; } 

IGnrUserFormOprsRepository GnrUserFormOprsRepository { get; } 

IGnrUserFormsRepository GnrUserFormsRepository { get; } 

IGnrUserLabelsRepository GnrUserLabelsRepository { get; } 

IGnrUserLogRepository GnrUserLogRepository { get; } 

IGnrUserMsgRepository GnrUserMsgRepository { get; } 

IGnrUserRefListRepository GnrUserRefListRepository { get; } 

IGnrUserRefListDetRepository GnrUserRefListDetRepository { get; } 

IGnrUserRoleRepository GnrUserRoleRepository { get; } 

IGnrUserStorageRepository GnrUserStorageRepository { get; } 

IGnrValidDataRepository GnrValidDataRepository { get; } 

IGeoPosRepository GeoPosRepository { get; } 

IAddressRepository AddressRepository { get; } 

ICrspndsRepository CrspndsRepository { get; } 

ILookupsRepository LookupsRepository { get; } 

ISettingsRepository SettingsRepository { get; } 

IsysdiagramsRepository sysdiagramsRepository { get; } 

ITablesLastIdRepository TablesLastIdRepository { get; } 

ITaxDutyInfRepository TaxDutyInfRepository { get; } 

IUnitsRepository UnitsRepository { get; } 

IElementRolesRepository ElementRolesRepository { get; } 

IElementsRepository ElementsRepository { get; } 

IElmntMethodRepository ElmntMethodRepository { get; } 

IElmntMethodRolesRepository ElmntMethodRolesRepository { get; } 

ICurExChangeRepository CurExChangeRepository { get; } 

ICurrencyRepository CurrencyRepository { get; } 

ICostCentersRepository CostCentersRepository { get; } 

ICstAccDataRepository CstAccDataRepository { get; } 

ICstAccRelInfRepository CstAccRelInfRepository { get; } 

ICstCostAllocDetRepository CstCostAllocDetRepository { get; } 

ICstCostCntrAllocRepository CstCostCntrAllocRepository { get; } 

ICstCostCntrAllocSValsRepository CstCostCntrAllocSValsRepository { get; } 

ICstCostCntrAllocValsRepository CstCostCntrAllocValsRepository { get; } 

ICstCostCntrElmntRoleRepository CstCostCntrElmntRoleRepository { get; } 

ICstCostCntrElmntValsRepository CstCostCntrElmntValsRepository { get; } 

ICstCostCntrFillRepository CstCostCntrFillRepository { get; } 

ICstCostCntrRoleValsRepository CstCostCntrRoleValsRepository { get; } 

ICstElementsRepository CstElementsRepository { get; } 

ICstElmntRolesRepository CstElmntRolesRepository { get; } 

ICstMatDurQtyRepository CstMatDurQtyRepository { get; } 

ICstMatQtyRepository CstMatQtyRepository { get; } 

ICstMatStdInfRepository CstMatStdInfRepository { get; } 

ICstMatWastRepository CstMatWastRepository { get; } 

ICstPeriodsRepository CstPeriodsRepository { get; } 

ICstProdDurQtyRepository CstProdDurQtyRepository { get; } 

ICstProduceInfRepository CstProduceInfRepository { get; } 

ICstProductPackageRepository CstProductPackageRepository { get; } 

ICstProductPackDetRepository CstProductPackDetRepository { get; } 

ICstProductVchRepository CstProductVchRepository { get; } 

ICstRealCalcRepository CstRealCalcRepository { get; } 

ICstStdAccDataRepository CstStdAccDataRepository { get; } 

ICstStdCalcRepository CstStdCalcRepository { get; } 

ICntAccRelsRepository CntAccRelsRepository { get; } 

ICntAccVchTypesRepository CntAccVchTypesRepository { get; } 

ICntAcquitInfsRepository CntAcquitInfsRepository { get; } 

ICntAgreementRepository CntAgreementRepository { get; } 

ICntAmntCurInfRepository CntAmntCurInfRepository { get; } 

ICntAmntTypesRepository CntAmntTypesRepository { get; } 

ICntCMthdFldsRepository CntCMthdFldsRepository { get; } 

ICntContAgrValsRepository CntContAgrValsRepository { get; } 

ICntContAmntChngRepository CntContAmntChngRepository { get; } 

ICntContDetRepository CntContDetRepository { get; } 

ICntContElmntRepository CntContElmntRepository { get; } 

ICntContractorsRepository CntContractorsRepository { get; } 

ICntContractsRepository CntContractsRepository { get; } 

ICntContRatioRepository CntContRatioRepository { get; } 

ICntContrLimitRepository CntContrLimitRepository { get; } 

ICntContTextRepository CntContTextRepository { get; } 

ICntCrsDocumentRepository CntCrsDocumentRepository { get; } 

ICntDeliveryInfRepository CntDeliveryInfRepository { get; } 

ICntExpAccntRelsRepository CntExpAccntRelsRepository { get; } 

ICntExpAcntCostCntrRepository CntExpAcntCostCntrRepository { get; } 

ICntExpAcntDataRepository CntExpAcntDataRepository { get; } 

ICntExpAcntDetRepository CntExpAcntDetRepository { get; } 

ICntExpAcntFldsRepository CntExpAcntFldsRepository { get; } 

ICntExpAcntValsRepository CntExpAcntValsRepository { get; } 

ICntExpFldElmntsRepository CntExpFldElmntsRepository { get; } 

ICntExpnsAccntsRepository CntExpnsAccntsRepository { get; } 

ICntExtendInfRepository CntExtendInfRepository { get; } 

ICntFormFieldsRepository CntFormFieldsRepository { get; } 

ICntFormValsRepository CntFormValsRepository { get; } 

ICntGaurantInfRepository CntGaurantInfRepository { get; } 

ICntGnrTextRepository CntGnrTextRepository { get; } 

ICntInvoiceDetRepository CntInvoiceDetRepository { get; } 

ICntInvoiceHdrRepository CntInvoiceHdrRepository { get; } 

ICntInvoiceNotesRepository CntInvoiceNotesRepository { get; } 

ICntInvoiceRelsRepository CntInvoiceRelsRepository { get; } 

ICntMasterFactDataRepository CntMasterFactDataRepository { get; } 

ICntMasterFactorRepository CntMasterFactorRepository { get; } 

ICntMasterFactValRepository CntMasterFactValRepository { get; } 

ICntMastersRepository CntMastersRepository { get; } 

ICntSrvItemsRepository CntSrvItemsRepository { get; } 

ICntSrvPrcHdrRepository CntSrvPrcHdrRepository { get; } 

ICntSrvPrcItmRepository CntSrvPrcItmRepository { get; } 

ICmrContHdrRepository CmrContHdrRepository { get; } 

ICmrContItmRepository CmrContItmRepository { get; } 

ICmrFactHdrRepository CmrFactHdrRepository { get; } 

ICmrFactItmRepository CmrFactItmRepository { get; } 

ICmrInsuranceRepository CmrInsuranceRepository { get; } 

ICmrInvoiceCostRepository CmrInvoiceCostRepository { get; } 

ICmrInvoiceHdrRepository CmrInvoiceHdrRepository { get; } 

ICmrInvoiceItmRepository CmrInvoiceItmRepository { get; } 

ICmrLCRepository CmrLCRepository { get; } 

ICmrLCDetRepository CmrLCDetRepository { get; } 

ICmrOrdHdrRepository CmrOrdHdrRepository { get; } 

ICmrOrdItmRepository CmrOrdItmRepository { get; } 

ICmrOrdSellerRepository CmrOrdSellerRepository { get; } 

ICmrPersRepository CmrPersRepository { get; } 

ICmrPOrderHdrRepository CmrPOrderHdrRepository { get; } 

ICmrPOrderItmRepository CmrPOrderItmRepository { get; } 

ICmrPreFactHdrRepository CmrPreFactHdrRepository { get; } 

ICmrPreFactItmRepository CmrPreFactItmRepository { get; } 

ICmrRegisterRepository CmrRegisterRepository { get; } 

ICmrReleaseCostRepository CmrReleaseCostRepository { get; } 

ICmrReleaseHdrRepository CmrReleaseHdrRepository { get; } 

ICmrReleaseItmRepository CmrReleaseItmRepository { get; } 

ICmrReleaseStockRepository CmrReleaseStockRepository { get; } 

ICmrRqstHdrRepository CmrRqstHdrRepository { get; } 

ICmrRqstItmRepository CmrRqstItmRepository { get; } 

ICmrSellerGrpRepository CmrSellerGrpRepository { get; } 

ICmrSellersRepository CmrSellersRepository { get; } 

ICmrSendHdrRepository CmrSendHdrRepository { get; } 

ICmrSendItmRepository CmrSendItmRepository { get; } 

ICmrServicesRepository CmrServicesRepository { get; } 

ICmrTransportRepository CmrTransportRepository { get; } 

ICmrTransportDetRepository CmrTransportDetRepository { get; } 

IBdgAssetsRepository BdgAssetsRepository { get; } 

IBdgAssetsDetRepository BdgAssetsDetRepository { get; } 

IBdgBalanceValRepository BdgBalanceValRepository { get; } 

IBdgBalanceValsDetRepository BdgBalanceValsDetRepository { get; } 

IBdgContAccRepository BdgContAccRepository { get; } 

IBdgContAccDetRepository BdgContAccDetRepository { get; } 

IBdgContsRepository BdgContsRepository { get; } 

IBdgCostAllocDetRepository BdgCostAllocDetRepository { get; } 

IBdgCostCntrAllocRepository BdgCostCntrAllocRepository { get; } 

IBdgCostCntrRoleValsRepository BdgCostCntrRoleValsRepository { get; } 

IBdgCurExchangeRepository BdgCurExchangeRepository { get; } 

IBdgElementsRepository BdgElementsRepository { get; } 

IBdgElmntRolesRepository BdgElmntRolesRepository { get; } 

IBdgElmntValRepository BdgElmntValRepository { get; } 

IBdgElmntValsDetRepository BdgElmntValsDetRepository { get; } 

IBdgFinalRepRepository BdgFinalRepRepository { get; } 

IBdgHrmBaseRepository BdgHrmBaseRepository { get; } 

IBdgHrmValsRepository BdgHrmValsRepository { get; } 

IBdgHrmValsDetRepository BdgHrmValsDetRepository { get; } 

IBdgHrmValsPersRepository BdgHrmValsPersRepository { get; } 

IBdgLevelDetRepository BdgLevelDetRepository { get; } 

IBdgPartsRepository BdgPartsRepository { get; } 

IBdgPartsDetRepository BdgPartsDetRepository { get; } 

IBdgPeriodsRepository BdgPeriodsRepository { get; } 

IBdgProfitDetRepository BdgProfitDetRepository { get; } 

IBdgProjDetInfRepository BdgProjDetInfRepository { get; } 

IBdgProjectDetRepository BdgProjectDetRepository { get; } 

IBdgProjectHrmRepository BdgProjectHrmRepository { get; } 

IBdgProjectsRepository BdgProjectsRepository { get; } 

IBdgProjElmntRepository BdgProjElmntRepository { get; } 

IBdgProjElmntValsRepository BdgProjElmntValsRepository { get; } 

IBdgProjGroupRepository BdgProjGroupRepository { get; } 

IBdgShareRepRepository BdgShareRepRepository { get; } 

IBdgTaxDetRepository BdgTaxDetRepository { get; } 

IBdgTaxesRepository BdgTaxesRepository { get; } 

IBdgTaxPrcRepository BdgTaxPrcRepository { get; } 

IBdgTaxPrcCostRepository BdgTaxPrcCostRepository { get; } 

IBdgTopicsRepository BdgTopicsRepository { get; } 

IBdgTopicsRelsRepository BdgTopicsRelsRepository { get; } 

IAssetsRepository AssetsRepository { get; } 

IAstAssetCostRepository AstAssetCostRepository { get; } 

IAstAssetCtgryRepository AstAssetCtgryRepository { get; } 

IAstAssetDeprRepository AstAssetDeprRepository { get; } 

IAstAssetGrpRepository AstAssetGrpRepository { get; } 

IAstAssetInfRepository AstAssetInfRepository { get; } 

IAstAssetRateRepository AstAssetRateRepository { get; } 

IAstAssetSaleRepository AstAssetSaleRepository { get; } 

IAstCostDetRepository AstCostDetRepository { get; } 

IAstCostDocsRepository AstCostDocsRepository { get; } 

IAstDeprVchRepository AstDeprVchRepository { get; } 

IAstDocsRepository AstDocsRepository { get; } 

IAstMensRepository AstMensRepository { get; } 

IAstPitchsRepository AstPitchsRepository { get; } 

IAstRatioDocsRepository AstRatioDocsRepository { get; } 

IAstTransDocsRepository AstTransDocsRepository { get; } 

IArchGroupsRepository ArchGroupsRepository { get; } 

IArchiveRepository ArchiveRepository { get; } 

IArchTypesRepository ArchTypesRepository { get; } 

IAccAnalyseRepository AccAnalyseRepository { get; } 

IAccCloseHdrRepository AccCloseHdrRepository { get; } 

IAccCloseItmRepository AccCloseItmRepository { get; } 

IAccDLRepository AccDLRepository { get; } 

IAccDLCtgryRepository AccDLCtgryRepository { get; } 

IAccDLCtgryRelRepository AccDLCtgryRelRepository { get; } 

IAccGLRepository AccGLRepository { get; } 

IAccGLVchHdrRepository AccGLVchHdrRepository { get; } 

IAccGLVchItmRepository AccGLVchItmRepository { get; } 

IAccGroupsRepository AccGroupsRepository { get; } 

IAccNoteHdrRepository AccNoteHdrRepository { get; } 

IAccNoteItmRepository AccNoteItmRepository { get; } 

IAccPeriodRepository AccPeriodRepository { get; } 

IAccPLRepository AccPLRepository { get; } 

IAccSLRepository AccSLRepository { get; } 

IAccSLDLRelRepository AccSLDLRelRepository { get; } 

IAccSLStdDescRepository AccSLStdDescRepository { get; } 

IAccTransVchRepository AccTransVchRepository { get; } 

IAccVchDescrRepository AccVchDescrRepository { get; } 

IAccVchHdrRepository AccVchHdrRepository { get; } 

IAccVchItmRepository AccVchItmRepository { get; } 

IAccVchKindDescrRepository AccVchKindDescrRepository { get; } 

IAccVchRelsRepository AccVchRelsRepository { get; } 

IAccVchTypesRepository AccVchTypesRepository { get; } 

        Task<int> CommitAsync();
        int Commit();
    }
}
