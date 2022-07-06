using Afra.Repository.Implimentation.Implementation;
using Afra.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afra.Repository.Implimentation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

         


        private WorkFlowsRepository _WorkFlowsRepository;
        
        public IWorkFlowsRepository WorkFlowsRepository => _WorkFlowsRepository = _WorkFlowsRepository ?? new WorkFlowsRepository(_context);
 


        private WorkFlowsFormRepository _WorkFlowsFormRepository;
        
        public IWorkFlowsFormRepository WorkFlowsFormRepository => _WorkFlowsFormRepository = _WorkFlowsFormRepository ?? new WorkFlowsFormRepository(_context);
 


        private WorkFlowStepsRepository _WorkFlowStepsRepository;
        
        public IWorkFlowStepsRepository WorkFlowStepsRepository => _WorkFlowStepsRepository = _WorkFlowStepsRepository ?? new WorkFlowStepsRepository(_context);
 


        private WorkStationRepository _WorkStationRepository;
        
        public IWorkStationRepository WorkStationRepository => _WorkStationRepository = _WorkStationRepository ?? new WorkStationRepository(_context);
 


        private WebDocsRepository _WebDocsRepository;
        
        public IWebDocsRepository WebDocsRepository => _WebDocsRepository = _WebDocsRepository ?? new WebDocsRepository(_context);
 


        private WebImagesRepository _WebImagesRepository;
        
        public IWebImagesRepository WebImagesRepository => _WebImagesRepository = _WebImagesRepository ?? new WebImagesRepository(_context);
 


        private WebLoginsRepository _WebLoginsRepository;
        
        public IWebLoginsRepository WebLoginsRepository => _WebLoginsRepository = _WebLoginsRepository ?? new WebLoginsRepository(_context);
 


        private WebMessagesRepository _WebMessagesRepository;
        
        public IWebMessagesRepository WebMessagesRepository => _WebMessagesRepository = _WebMessagesRepository ?? new WebMessagesRepository(_context);
 


        private UsrBuyServiceRepository _UsrBuyServiceRepository;
        
        public IUsrBuyServiceRepository UsrBuyServiceRepository => _UsrBuyServiceRepository = _UsrBuyServiceRepository ?? new UsrBuyServiceRepository(_context);
 


        private UsrBuyServiceDetRepository _UsrBuyServiceDetRepository;
        
        public IUsrBuyServiceDetRepository UsrBuyServiceDetRepository => _UsrBuyServiceDetRepository = _UsrBuyServiceDetRepository ?? new UsrBuyServiceDetRepository(_context);
 


        private UsrCashRepository _UsrCashRepository;
        
        public IUsrCashRepository UsrCashRepository => _UsrCashRepository = _UsrCashRepository ?? new UsrCashRepository(_context);
 


        private UsrCashDetRepository _UsrCashDetRepository;
        
        public IUsrCashDetRepository UsrCashDetRepository => _UsrCashDetRepository = _UsrCashDetRepository ?? new UsrCashDetRepository(_context);
 


        private UsrContInfRepository _UsrContInfRepository;
        
        public IUsrContInfRepository UsrContInfRepository => _UsrContInfRepository = _UsrContInfRepository ?? new UsrContInfRepository(_context);
 


        private UsrCrsOthInfRepository _UsrCrsOthInfRepository;
        
        public IUsrCrsOthInfRepository UsrCrsOthInfRepository => _UsrCrsOthInfRepository = _UsrCrsOthInfRepository ?? new UsrCrsOthInfRepository(_context);
 


        private UsrExhibitionRqstRepository _UsrExhibitionRqstRepository;
        
        public IUsrExhibitionRqstRepository UsrExhibitionRqstRepository => _UsrExhibitionRqstRepository = _UsrExhibitionRqstRepository ?? new UsrExhibitionRqstRepository(_context);
 


        private UsrMissionDetRepository _UsrMissionDetRepository;
        
        public IUsrMissionDetRepository UsrMissionDetRepository => _UsrMissionDetRepository = _UsrMissionDetRepository ?? new UsrMissionDetRepository(_context);
 


        private UsrNewsCheckRqstRepository _UsrNewsCheckRqstRepository;
        
        public IUsrNewsCheckRqstRepository UsrNewsCheckRqstRepository => _UsrNewsCheckRqstRepository = _UsrNewsCheckRqstRepository ?? new UsrNewsCheckRqstRepository(_context);
 


        private UsrPersHrmRelsRepository _UsrPersHrmRelsRepository;
        
        public IUsrPersHrmRelsRepository UsrPersHrmRelsRepository => _UsrPersHrmRelsRepository = _UsrPersHrmRelsRepository ?? new UsrPersHrmRelsRepository(_context);
 


        private UsrPersHrmRelsApplRepository _UsrPersHrmRelsApplRepository;
        
        public IUsrPersHrmRelsApplRepository UsrPersHrmRelsApplRepository => _UsrPersHrmRelsApplRepository = _UsrPersHrmRelsApplRepository ?? new UsrPersHrmRelsApplRepository(_context);
 


        private UsrPersHrmRelsConsRepository _UsrPersHrmRelsConsRepository;
        
        public IUsrPersHrmRelsConsRepository UsrPersHrmRelsConsRepository => _UsrPersHrmRelsConsRepository = _UsrPersHrmRelsConsRepository ?? new UsrPersHrmRelsConsRepository(_context);
 


        private UsrPersHrmRelsDocRepository _UsrPersHrmRelsDocRepository;
        
        public IUsrPersHrmRelsDocRepository UsrPersHrmRelsDocRepository => _UsrPersHrmRelsDocRepository = _UsrPersHrmRelsDocRepository ?? new UsrPersHrmRelsDocRepository(_context);
 


        private UsrPersHrmRelsKigrRepository _UsrPersHrmRelsKigrRepository;
        
        public IUsrPersHrmRelsKigrRepository UsrPersHrmRelsKigrRepository => _UsrPersHrmRelsKigrRepository = _UsrPersHrmRelsKigrRepository ?? new UsrPersHrmRelsKigrRepository(_context);
 


        private UsrPersHrmRelsRehabRepository _UsrPersHrmRelsRehabRepository;
        
        public IUsrPersHrmRelsRehabRepository UsrPersHrmRelsRehabRepository => _UsrPersHrmRelsRehabRepository = _UsrPersHrmRelsRehabRepository ?? new UsrPersHrmRelsRehabRepository(_context);
 


        private UsrProdCostRepository _UsrProdCostRepository;
        
        public IUsrProdCostRepository UsrProdCostRepository => _UsrProdCostRepository = _UsrProdCostRepository ?? new UsrProdCostRepository(_context);
 


        private UsrProdExtRepository _UsrProdExtRepository;
        
        public IUsrProdExtRepository UsrProdExtRepository => _UsrProdExtRepository = _UsrProdExtRepository ?? new UsrProdExtRepository(_context);
 


        private UsrProdRcvRepository _UsrProdRcvRepository;
        
        public IUsrProdRcvRepository UsrProdRcvRepository => _UsrProdRcvRepository = _UsrProdRcvRepository ?? new UsrProdRcvRepository(_context);
 


        private UsrProdResRepository _UsrProdResRepository;
        
        public IUsrProdResRepository UsrProdResRepository => _UsrProdResRepository = _UsrProdResRepository ?? new UsrProdResRepository(_context);
 


        private UsrProdVchRepository _UsrProdVchRepository;
        
        public IUsrProdVchRepository UsrProdVchRepository => _UsrProdVchRepository = _UsrProdVchRepository ?? new UsrProdVchRepository(_context);
 


        private UsrProdWastRepository _UsrProdWastRepository;
        
        public IUsrProdWastRepository UsrProdWastRepository => _UsrProdWastRepository = _UsrProdWastRepository ?? new UsrProdWastRepository(_context);
 


        private UsrRqstVacRepository _UsrRqstVacRepository;
        
        public IUsrRqstVacRepository UsrRqstVacRepository => _UsrRqstVacRepository = _UsrRqstVacRepository ?? new UsrRqstVacRepository(_context);
 


        private UsrTest1Repository _UsrTest1Repository;
        
        public IUsrTest1Repository UsrTest1Repository => _UsrTest1Repository = _UsrTest1Repository ?? new UsrTest1Repository(_context);
 


        private UsrTestFormRepository _UsrTestFormRepository;
        
        public IUsrTestFormRepository UsrTestFormRepository => _UsrTestFormRepository = _UsrTestFormRepository ?? new UsrTestFormRepository(_context);
 


        private UsrTestGridRepository _UsrTestGridRepository;
        
        public IUsrTestGridRepository UsrTestGridRepository => _UsrTestGridRepository = _UsrTestGridRepository ?? new UsrTestGridRepository(_context);
 


        private UsrTrsRqstBankInfRepository _UsrTrsRqstBankInfRepository;
        
        public IUsrTrsRqstBankInfRepository UsrTrsRqstBankInfRepository => _UsrTrsRqstBankInfRepository = _UsrTrsRqstBankInfRepository ?? new UsrTrsRqstBankInfRepository(_context);
 


        private UsrvchBaseInfoRepository _UsrvchBaseInfoRepository;
        
        public IUsrvchBaseInfoRepository UsrvchBaseInfoRepository => _UsrvchBaseInfoRepository = _UsrvchBaseInfoRepository ?? new UsrvchBaseInfoRepository(_context);
 


        private UserAccessRepository _UserAccessRepository;
        
        public IUserAccessRepository UserAccessRepository => _UserAccessRepository = _UserAccessRepository ?? new UserAccessRepository(_context);
 


        private UserAlternativeRepository _UserAlternativeRepository;
        
        public IUserAlternativeRepository UserAlternativeRepository => _UserAlternativeRepository = _UserAlternativeRepository ?? new UserAlternativeRepository(_context);
 


        private UserArchiveRepository _UserArchiveRepository;
        
        public IUserArchiveRepository UserArchiveRepository => _UserArchiveRepository = _UserArchiveRepository ?? new UserArchiveRepository(_context);
 


        private UserArchTypeRepository _UserArchTypeRepository;
        
        public IUserArchTypeRepository UserArchTypeRepository => _UserArchTypeRepository = _UserArchTypeRepository ?? new UserArchTypeRepository(_context);
 


        private UserPlaningRepository _UserPlaningRepository;
        
        public IUserPlaningRepository UserPlaningRepository => _UserPlaningRepository = _UserPlaningRepository ?? new UserPlaningRepository(_context);
 


        private UserPlaningDetRepository _UserPlaningDetRepository;
        
        public IUserPlaningDetRepository UserPlaningDetRepository => _UserPlaningDetRepository = _UserPlaningDetRepository ?? new UserPlaningDetRepository(_context);
 


        private UserPlaningDetInfRepository _UserPlaningDetInfRepository;
        
        public IUserPlaningDetInfRepository UserPlaningDetInfRepository => _UserPlaningDetInfRepository = _UserPlaningDetInfRepository ?? new UserPlaningDetInfRepository(_context);
 


        private UserProcessRepository _UserProcessRepository;
        
        public IUserProcessRepository UserProcessRepository => _UserProcessRepository = _UserProcessRepository ?? new UserProcessRepository(_context);
 


        private UserProcessStpRepository _UserProcessStpRepository;
        
        public IUserProcessStpRepository UserProcessStpRepository => _UserProcessStpRepository = _UserProcessStpRepository ?? new UserProcessStpRepository(_context);
 


        private UserRepAccessRepository _UserRepAccessRepository;
        
        public IUserRepAccessRepository UserRepAccessRepository => _UserRepAccessRepository = _UserRepAccessRepository ?? new UserRepAccessRepository(_context);
 


        private UsersRepository _UsersRepository;
        
        public IUsersRepository UsersRepository => _UsersRepository = _UsersRepository ?? new UsersRepository(_context);
 


        private UserSignRightRepository _UserSignRightRepository;
        
        public IUserSignRightRepository UserSignRightRepository => _UserSignRightRepository = _UserSignRightRepository ?? new UserSignRightRepository(_context);
 


        private UsersRelsRepository _UsersRelsRepository;
        
        public IUsersRelsRepository UsersRelsRepository => _UsersRelsRepository = _UsersRelsRepository ?? new UsersRelsRepository(_context);
 


        private UsGroupAccessRepository _UsGroupAccessRepository;
        
        public IUsGroupAccessRepository UsGroupAccessRepository => _UsGroupAccessRepository = _UsGroupAccessRepository ?? new UsGroupAccessRepository(_context);
 


        private UsGroupRepAccessRepository _UsGroupRepAccessRepository;
        
        public IUsGroupRepAccessRepository UsGroupRepAccessRepository => _UsGroupRepAccessRepository = _UsGroupRepAccessRepository ?? new UsGroupRepAccessRepository(_context);
 


        private UsGroupsRepository _UsGroupsRepository;
        
        public IUsGroupsRepository UsGroupsRepository => _UsGroupsRepository = _UsGroupsRepository ?? new UsGroupsRepository(_context);
 


        private TrsAccOprRepository _TrsAccOprRepository;
        
        public ITrsAccOprRepository TrsAccOprRepository => _TrsAccOprRepository = _TrsAccOprRepository ?? new TrsAccOprRepository(_context);
 


        private TrsBankAccountsRepository _TrsBankAccountsRepository;
        
        public ITrsBankAccountsRepository TrsBankAccountsRepository => _TrsBankAccountsRepository = _TrsBankAccountsRepository ?? new TrsBankAccountsRepository(_context);
 


        private TrsBankBillRepository _TrsBankBillRepository;
        
        public ITrsBankBillRepository TrsBankBillRepository => _TrsBankBillRepository = _TrsBankBillRepository ?? new TrsBankBillRepository(_context);
 


        private TrsBankBillDetRepository _TrsBankBillDetRepository;
        
        public ITrsBankBillDetRepository TrsBankBillDetRepository => _TrsBankBillDetRepository = _TrsBankBillDetRepository ?? new TrsBankBillDetRepository(_context);
 


        private TrsBankBranchsRepository _TrsBankBranchsRepository;
        
        public ITrsBankBranchsRepository TrsBankBranchsRepository => _TrsBankBranchsRepository = _TrsBankBranchsRepository ?? new TrsBankBranchsRepository(_context);
 


        private TrsBankChqsRepository _TrsBankChqsRepository;
        
        public ITrsBankChqsRepository TrsBankChqsRepository => _TrsBankChqsRepository = _TrsBankChqsRepository ?? new TrsBankChqsRepository(_context);
 


        private TrsBankChqsDetRepository _TrsBankChqsDetRepository;
        
        public ITrsBankChqsDetRepository TrsBankChqsDetRepository => _TrsBankChqsDetRepository = _TrsBankChqsDetRepository ?? new TrsBankChqsDetRepository(_context);
 


        private TrsBankReconcileRepository _TrsBankReconcileRepository;
        
        public ITrsBankReconcileRepository TrsBankReconcileRepository => _TrsBankReconcileRepository = _TrsBankReconcileRepository ?? new TrsBankReconcileRepository(_context);
 


        private TrsBankReconcileDetRepository _TrsBankReconcileDetRepository;
        
        public ITrsBankReconcileDetRepository TrsBankReconcileDetRepository => _TrsBankReconcileDetRepository = _TrsBankReconcileDetRepository ?? new TrsBankReconcileDetRepository(_context);
 


        private TrsBanksRepository _TrsBanksRepository;
        
        public ITrsBanksRepository TrsBanksRepository => _TrsBanksRepository = _TrsBanksRepository ?? new TrsBanksRepository(_context);
 


        private TrsCalcFormulaRepository _TrsCalcFormulaRepository;
        
        public ITrsCalcFormulaRepository TrsCalcFormulaRepository => _TrsCalcFormulaRepository = _TrsCalcFormulaRepository ?? new TrsCalcFormulaRepository(_context);
 


        private TrsCashsRepository _TrsCashsRepository;
        
        public ITrsCashsRepository TrsCashsRepository => _TrsCashsRepository = _TrsCashsRepository ?? new TrsCashsRepository(_context);
 


        private TrsChqFmtRepository _TrsChqFmtRepository;
        
        public ITrsChqFmtRepository TrsChqFmtRepository => _TrsChqFmtRepository = _TrsChqFmtRepository ?? new TrsChqFmtRepository(_context);
 


        private TrsCostFactorsRepository _TrsCostFactorsRepository;
        
        public ITrsCostFactorsRepository TrsCostFactorsRepository => _TrsCostFactorsRepository = _TrsCostFactorsRepository ?? new TrsCostFactorsRepository(_context);
 


        private TrsCreditTblRepository _TrsCreditTblRepository;
        
        public ITrsCreditTblRepository TrsCreditTblRepository => _TrsCreditTblRepository = _TrsCreditTblRepository ?? new TrsCreditTblRepository(_context);
 


        private TrsCreditTblDetRepository _TrsCreditTblDetRepository;
        
        public ITrsCreditTblDetRepository TrsCreditTblDetRepository => _TrsCreditTblDetRepository = _TrsCreditTblDetRepository ?? new TrsCreditTblDetRepository(_context);
 


        private TrsDepositRepository _TrsDepositRepository;
        
        public ITrsDepositRepository TrsDepositRepository => _TrsDepositRepository = _TrsDepositRepository ?? new TrsDepositRepository(_context);
 


        private TrsDepositCalcRepository _TrsDepositCalcRepository;
        
        public ITrsDepositCalcRepository TrsDepositCalcRepository => _TrsDepositCalcRepository = _TrsDepositCalcRepository ?? new TrsDepositCalcRepository(_context);
 


        private TrsDepositDetRepository _TrsDepositDetRepository;
        
        public ITrsDepositDetRepository TrsDepositDetRepository => _TrsDepositDetRepository = _TrsDepositDetRepository ?? new TrsDepositDetRepository(_context);
 


        private TrsFacCrdTblRepository _TrsFacCrdTblRepository;
        
        public ITrsFacCrdTblRepository TrsFacCrdTblRepository => _TrsFacCrdTblRepository = _TrsFacCrdTblRepository ?? new TrsFacCrdTblRepository(_context);
 


        private TrsFacCrdTblDetRepository _TrsFacCrdTblDetRepository;
        
        public ITrsFacCrdTblDetRepository TrsFacCrdTblDetRepository => _TrsFacCrdTblDetRepository = _TrsFacCrdTblDetRepository ?? new TrsFacCrdTblDetRepository(_context);
 


        private TrsFacilitiesRepository _TrsFacilitiesRepository;
        
        public ITrsFacilitiesRepository TrsFacilitiesRepository => _TrsFacilitiesRepository = _TrsFacilitiesRepository ?? new TrsFacilitiesRepository(_context);
 


        private TrsFacilitiesDetRepository _TrsFacilitiesDetRepository;
        
        public ITrsFacilitiesDetRepository TrsFacilitiesDetRepository => _TrsFacilitiesDetRepository = _TrsFacilitiesDetRepository ?? new TrsFacilitiesDetRepository(_context);
 


        private TrsFacilitiesGuaRepository _TrsFacilitiesGuaRepository;
        
        public ITrsFacilitiesGuaRepository TrsFacilitiesGuaRepository => _TrsFacilitiesGuaRepository = _TrsFacilitiesGuaRepository ?? new TrsFacilitiesGuaRepository(_context);
 


        private TrsFacilitiesSecRepository _TrsFacilitiesSecRepository;
        
        public ITrsFacilitiesSecRepository TrsFacilitiesSecRepository => _TrsFacilitiesSecRepository = _TrsFacilitiesSecRepository ?? new TrsFacilitiesSecRepository(_context);
 


        private TrsFacManCreditRepository _TrsFacManCreditRepository;
        
        public ITrsFacManCreditRepository TrsFacManCreditRepository => _TrsFacManCreditRepository = _TrsFacManCreditRepository ?? new TrsFacManCreditRepository(_context);
 


        private TrsFacTypeInfRepository _TrsFacTypeInfRepository;
        
        public ITrsFacTypeInfRepository TrsFacTypeInfRepository => _TrsFacTypeInfRepository = _TrsFacTypeInfRepository ?? new TrsFacTypeInfRepository(_context);
 


        private TrsFacYearShareRepository _TrsFacYearShareRepository;
        
        public ITrsFacYearShareRepository TrsFacYearShareRepository => _TrsFacYearShareRepository = _TrsFacYearShareRepository ?? new TrsFacYearShareRepository(_context);
 


        private TrsFContractRepository _TrsFContractRepository;
        
        public ITrsFContractRepository TrsFContractRepository => _TrsFContractRepository = _TrsFContractRepository ?? new TrsFContractRepository(_context);
 


        private TrsFContractDetRepository _TrsFContractDetRepository;
        
        public ITrsFContractDetRepository TrsFContractDetRepository => _TrsFContractDetRepository = _TrsFContractDetRepository ?? new TrsFContractDetRepository(_context);
 


        private TrsFixAccRepository _TrsFixAccRepository;
        
        public ITrsFixAccRepository TrsFixAccRepository => _TrsFixAccRepository = _TrsFixAccRepository ?? new TrsFixAccRepository(_context);
 


        private TrsFixAccDetRepository _TrsFixAccDetRepository;
        
        public ITrsFixAccDetRepository TrsFixAccDetRepository => _TrsFixAccDetRepository = _TrsFixAccDetRepository ?? new TrsFixAccDetRepository(_context);
 


        private TrsFundBillHdrRepository _TrsFundBillHdrRepository;
        
        public ITrsFundBillHdrRepository TrsFundBillHdrRepository => _TrsFundBillHdrRepository = _TrsFundBillHdrRepository ?? new TrsFundBillHdrRepository(_context);
 


        private TrsFundBillItmRepository _TrsFundBillItmRepository;
        
        public ITrsFundBillItmRepository TrsFundBillItmRepository => _TrsFundBillItmRepository = _TrsFundBillItmRepository ?? new TrsFundBillItmRepository(_context);
 


        private TrsFundItmDetRepository _TrsFundItmDetRepository;
        
        public ITrsFundItmDetRepository TrsFundItmDetRepository => _TrsFundItmDetRepository = _TrsFundItmDetRepository ?? new TrsFundItmDetRepository(_context);
 


        private TrsFundOprRepository _TrsFundOprRepository;
        
        public ITrsFundOprRepository TrsFundOprRepository => _TrsFundOprRepository = _TrsFundOprRepository ?? new TrsFundOprRepository(_context);
 


        private TrsFundsRepository _TrsFundsRepository;
        
        public ITrsFundsRepository TrsFundsRepository => _TrsFundsRepository = _TrsFundsRepository ?? new TrsFundsRepository(_context);
 


        private TrsGContractRepository _TrsGContractRepository;
        
        public ITrsGContractRepository TrsGContractRepository => _TrsGContractRepository = _TrsGContractRepository ?? new TrsGContractRepository(_context);
 


        private TrsGContractChngRepository _TrsGContractChngRepository;
        
        public ITrsGContractChngRepository TrsGContractChngRepository => _TrsGContractChngRepository = _TrsGContractChngRepository ?? new TrsGContractChngRepository(_context);
 


        private TrsGuaranteeRepository _TrsGuaranteeRepository;
        
        public ITrsGuaranteeRepository TrsGuaranteeRepository => _TrsGuaranteeRepository = _TrsGuaranteeRepository ?? new TrsGuaranteeRepository(_context);
 


        private TrsGuaranteeGuaRepository _TrsGuaranteeGuaRepository;
        
        public ITrsGuaranteeGuaRepository TrsGuaranteeGuaRepository => _TrsGuaranteeGuaRepository = _TrsGuaranteeGuaRepository ?? new TrsGuaranteeGuaRepository(_context);
 


        private TrsGuaranteeOprRepository _TrsGuaranteeOprRepository;
        
        public ITrsGuaranteeOprRepository TrsGuaranteeOprRepository => _TrsGuaranteeOprRepository = _TrsGuaranteeOprRepository ?? new TrsGuaranteeOprRepository(_context);
 


        private TrsGuaranteeSecRepository _TrsGuaranteeSecRepository;
        
        public ITrsGuaranteeSecRepository TrsGuaranteeSecRepository => _TrsGuaranteeSecRepository = _TrsGuaranteeSecRepository ?? new TrsGuaranteeSecRepository(_context);
 


        private TrsGuaYearShareRepository _TrsGuaYearShareRepository;
        
        public ITrsGuaYearShareRepository TrsGuaYearShareRepository => _TrsGuaYearShareRepository = _TrsGuaYearShareRepository ?? new TrsGuaYearShareRepository(_context);
 


        private TrsManCreditRepository _TrsManCreditRepository;
        
        public ITrsManCreditRepository TrsManCreditRepository => _TrsManCreditRepository = _TrsManCreditRepository ?? new TrsManCreditRepository(_context);
 


        private TrsPayBoredItmRepository _TrsPayBoredItmRepository;
        
        public ITrsPayBoredItmRepository TrsPayBoredItmRepository => _TrsPayBoredItmRepository = _TrsPayBoredItmRepository ?? new TrsPayBoredItmRepository(_context);
 


        private TrsPayBoredOprRepository _TrsPayBoredOprRepository;
        
        public ITrsPayBoredOprRepository TrsPayBoredOprRepository => _TrsPayBoredOprRepository = _TrsPayBoredOprRepository ?? new TrsPayBoredOprRepository(_context);
 


        private TrsPayChqItmRepository _TrsPayChqItmRepository;
        
        public ITrsPayChqItmRepository TrsPayChqItmRepository => _TrsPayChqItmRepository = _TrsPayChqItmRepository ?? new TrsPayChqItmRepository(_context);
 


        private TrsPayChqOprRepository _TrsPayChqOprRepository;
        
        public ITrsPayChqOprRepository TrsPayChqOprRepository => _TrsPayChqOprRepository = _TrsPayChqOprRepository ?? new TrsPayChqOprRepository(_context);
 


        private TrsPayHistoryRepository _TrsPayHistoryRepository;
        
        public ITrsPayHistoryRepository TrsPayHistoryRepository => _TrsPayHistoryRepository = _TrsPayHistoryRepository ?? new TrsPayHistoryRepository(_context);
 


        private TrsRcvBoredItmRepository _TrsRcvBoredItmRepository;
        
        public ITrsRcvBoredItmRepository TrsRcvBoredItmRepository => _TrsRcvBoredItmRepository = _TrsRcvBoredItmRepository ?? new TrsRcvBoredItmRepository(_context);
 


        private TrsRcvBoredOprRepository _TrsRcvBoredOprRepository;
        
        public ITrsRcvBoredOprRepository TrsRcvBoredOprRepository => _TrsRcvBoredOprRepository = _TrsRcvBoredOprRepository ?? new TrsRcvBoredOprRepository(_context);
 


        private TrsRcvChqItmRepository _TrsRcvChqItmRepository;
        
        public ITrsRcvChqItmRepository TrsRcvChqItmRepository => _TrsRcvChqItmRepository = _TrsRcvChqItmRepository ?? new TrsRcvChqItmRepository(_context);
 


        private TrsRcvChqOprRepository _TrsRcvChqOprRepository;
        
        public ITrsRcvChqOprRepository TrsRcvChqOprRepository => _TrsRcvChqOprRepository = _TrsRcvChqOprRepository ?? new TrsRcvChqOprRepository(_context);
 


        private TrsRcvHistoryRepository _TrsRcvHistoryRepository;
        
        public ITrsRcvHistoryRepository TrsRcvHistoryRepository => _TrsRcvHistoryRepository = _TrsRcvHistoryRepository ?? new TrsRcvHistoryRepository(_context);
 


        private TrsRqstHdrRepository _TrsRqstHdrRepository;
        
        public ITrsRqstHdrRepository TrsRqstHdrRepository => _TrsRqstHdrRepository = _TrsRqstHdrRepository ?? new TrsRqstHdrRepository(_context);
 


        private TrsRqstItmRepository _TrsRqstItmRepository;
        
        public ITrsRqstItmRepository TrsRqstItmRepository => _TrsRqstItmRepository = _TrsRqstItmRepository ?? new TrsRqstItmRepository(_context);
 


        private TrsSourceUseRepository _TrsSourceUseRepository;
        
        public ITrsSourceUseRepository TrsSourceUseRepository => _TrsSourceUseRepository = _TrsSourceUseRepository ?? new TrsSourceUseRepository(_context);
 


        private TrsSourceUseRelsRepository _TrsSourceUseRelsRepository;
        
        public ITrsSourceUseRelsRepository TrsSourceUseRelsRepository => _TrsSourceUseRelsRepository = _TrsSourceUseRelsRepository ?? new TrsSourceUseRelsRepository(_context);
 


        private TrsVchHdrRepository _TrsVchHdrRepository;
        
        public ITrsVchHdrRepository TrsVchHdrRepository => _TrsVchHdrRepository = _TrsVchHdrRepository ?? new TrsVchHdrRepository(_context);
 


        private TrsVchItmRepository _TrsVchItmRepository;
        
        public ITrsVchItmRepository TrsVchItmRepository => _TrsVchItmRepository = _TrsVchItmRepository ?? new TrsVchItmRepository(_context);
 


        private TrsVchItmBaseRepository _TrsVchItmBaseRepository;
        
        public ITrsVchItmBaseRepository TrsVchItmBaseRepository => _TrsVchItmBaseRepository = _TrsVchItmBaseRepository ?? new TrsVchItmBaseRepository(_context);
 


        private TrsVchItmRelRepository _TrsVchItmRelRepository;
        
        public ITrsVchItmRelRepository TrsVchItmRelRepository => _TrsVchItmRelRepository = _TrsVchItmRelRepository ?? new TrsVchItmRelRepository(_context);
 


        private TrsVchSrcUseRepository _TrsVchSrcUseRepository;
        
        public ITrsVchSrcUseRepository TrsVchSrcUseRepository => _TrsVchSrcUseRepository = _TrsVchSrcUseRepository ?? new TrsVchSrcUseRepository(_context);
 


        private StkPeriodsRepository _StkPeriodsRepository;
        
        public IStkPeriodsRepository StkPeriodsRepository => _StkPeriodsRepository = _StkPeriodsRepository ?? new StkPeriodsRepository(_context);
 


        private StkStockDocsRepository _StkStockDocsRepository;
        
        public IStkStockDocsRepository StkStockDocsRepository => _StkStockDocsRepository = _StkStockDocsRepository ?? new StkStockDocsRepository(_context);
 


        private StkStockerInitRepository _StkStockerInitRepository;
        
        public IStkStockerInitRepository StkStockerInitRepository => _StkStockerInitRepository = _StkStockerInitRepository ?? new StkStockerInitRepository(_context);
 


        private StkStockersRepository _StkStockersRepository;
        
        public IStkStockersRepository StkStockersRepository => _StkStockersRepository = _StkStockersRepository ?? new StkStockersRepository(_context);
 


        private StkStockTransRepository _StkStockTransRepository;
        
        public IStkStockTransRepository StkStockTransRepository => _StkStockTransRepository = _StkStockTransRepository ?? new StkStockTransRepository(_context);
 


        private SMSMethodRepository _SMSMethodRepository;
        
        public ISMSMethodRepository SMSMethodRepository => _SMSMethodRepository = _SMSMethodRepository ?? new SMSMethodRepository(_context);
 


        private SMSOperateRepository _SMSOperateRepository;
        
        public ISMSOperateRepository SMSOperateRepository => _SMSOperateRepository = _SMSOperateRepository ?? new SMSOperateRepository(_context);
 


        private SMSOperateDetRepository _SMSOperateDetRepository;
        
        public ISMSOperateDetRepository SMSOperateDetRepository => _SMSOperateDetRepository = _SMSOperateDetRepository ?? new SMSOperateDetRepository(_context);
 


        private SMSSettingRepository _SMSSettingRepository;
        
        public ISMSSettingRepository SMSSettingRepository => _SMSSettingRepository = _SMSSettingRepository ?? new SMSSettingRepository(_context);
 


        private ShopGiftCardRepository _ShopGiftCardRepository;
        
        public IShopGiftCardRepository ShopGiftCardRepository => _ShopGiftCardRepository = _ShopGiftCardRepository ?? new ShopGiftCardRepository(_context);
 


        private ShopGiftPartRepository _ShopGiftPartRepository;
        
        public IShopGiftPartRepository ShopGiftPartRepository => _ShopGiftPartRepository = _ShopGiftPartRepository ?? new ShopGiftPartRepository(_context);
 


        private ShopPartPriceRepository _ShopPartPriceRepository;
        
        public IShopPartPriceRepository ShopPartPriceRepository => _ShopPartPriceRepository = _ShopPartPriceRepository ?? new ShopPartPriceRepository(_context);
 


        private ShopsRepository _ShopsRepository;
        
        public IShopsRepository ShopsRepository => _ShopsRepository = _ShopsRepository ?? new ShopsRepository(_context);
 


        private ShopTaxValsRepository _ShopTaxValsRepository;
        
        public IShopTaxValsRepository ShopTaxValsRepository => _ShopTaxValsRepository = _ShopTaxValsRepository ?? new ShopTaxValsRepository(_context);
 


        private SleAftSrvRepository _SleAftSrvRepository;
        
        public ISleAftSrvRepository SleAftSrvRepository => _SleAftSrvRepository = _SleAftSrvRepository ?? new SleAftSrvRepository(_context);
 


        private SleBranchsRepository _SleBranchsRepository;
        
        public ISleBranchsRepository SleBranchsRepository => _SleBranchsRepository = _SleBranchsRepository ?? new SleBranchsRepository(_context);
 


        private SleBrokerCalcRepository _SleBrokerCalcRepository;
        
        public ISleBrokerCalcRepository SleBrokerCalcRepository => _SleBrokerCalcRepository = _SleBrokerCalcRepository ?? new SleBrokerCalcRepository(_context);
 


        private SleBrokersRepository _SleBrokersRepository;
        
        public ISleBrokersRepository SleBrokersRepository => _SleBrokersRepository = _SleBrokersRepository ?? new SleBrokersRepository(_context);
 


        private SleBrokerSalaryRepository _SleBrokerSalaryRepository;
        
        public ISleBrokerSalaryRepository SleBrokerSalaryRepository => _SleBrokerSalaryRepository = _SleBrokerSalaryRepository ?? new SleBrokerSalaryRepository(_context);
 


        private SleBrokerSalaryMthdRepository _SleBrokerSalaryMthdRepository;
        
        public ISleBrokerSalaryMthdRepository SleBrokerSalaryMthdRepository => _SleBrokerSalaryMthdRepository = _SleBrokerSalaryMthdRepository ?? new SleBrokerSalaryMthdRepository(_context);
 


        private SleBrokerSalaryRelsRepository _SleBrokerSalaryRelsRepository;
        
        public ISleBrokerSalaryRelsRepository SleBrokerSalaryRelsRepository => _SleBrokerSalaryRelsRepository = _SleBrokerSalaryRelsRepository ?? new SleBrokerSalaryRelsRepository(_context);
 


        private SleBrokerSalaryTaxRepository _SleBrokerSalaryTaxRepository;
        
        public ISleBrokerSalaryTaxRepository SleBrokerSalaryTaxRepository => _SleBrokerSalaryTaxRepository = _SleBrokerSalaryTaxRepository ?? new SleBrokerSalaryTaxRepository(_context);
 


        private SleChngVchHdrRepository _SleChngVchHdrRepository;
        
        public ISleChngVchHdrRepository SleChngVchHdrRepository => _SleChngVchHdrRepository = _SleChngVchHdrRepository ?? new SleChngVchHdrRepository(_context);
 


        private SleChngVchItmRepository _SleChngVchItmRepository;
        
        public ISleChngVchItmRepository SleChngVchItmRepository => _SleChngVchItmRepository = _SleChngVchItmRepository ?? new SleChngVchItmRepository(_context);
 


        private SleChngVchTaxRepository _SleChngVchTaxRepository;
        
        public ISleChngVchTaxRepository SleChngVchTaxRepository => _SleChngVchTaxRepository = _SleChngVchTaxRepository ?? new SleChngVchTaxRepository(_context);
 


        private SleCstmrBrokersRepository _SleCstmrBrokersRepository;
        
        public ISleCstmrBrokersRepository SleCstmrBrokersRepository => _SleCstmrBrokersRepository = _SleCstmrBrokersRepository ?? new SleCstmrBrokersRepository(_context);
 


        private SleCstmrGroupsRepository _SleCstmrGroupsRepository;
        
        public ISleCstmrGroupsRepository SleCstmrGroupsRepository => _SleCstmrGroupsRepository = _SleCstmrGroupsRepository ?? new SleCstmrGroupsRepository(_context);
 


        private SleCstmrLimitRepository _SleCstmrLimitRepository;
        
        public ISleCstmrLimitRepository SleCstmrLimitRepository => _SleCstmrLimitRepository = _SleCstmrLimitRepository ?? new SleCstmrLimitRepository(_context);
 


        private SleCstmrsRepository _SleCstmrsRepository;
        
        public ISleCstmrsRepository SleCstmrsRepository => _SleCstmrsRepository = _SleCstmrsRepository ?? new SleCstmrsRepository(_context);
 


        private SleCtgryRepository _SleCtgryRepository;
        
        public ISleCtgryRepository SleCtgryRepository => _SleCtgryRepository = _SleCtgryRepository ?? new SleCtgryRepository(_context);
 


        private SleCtgryAccRepository _SleCtgryAccRepository;
        
        public ISleCtgryAccRepository SleCtgryAccRepository => _SleCtgryAccRepository = _SleCtgryAccRepository ?? new SleCtgryAccRepository(_context);
 


        private SleDebCreHdrRepository _SleDebCreHdrRepository;
        
        public ISleDebCreHdrRepository SleDebCreHdrRepository => _SleDebCreHdrRepository = _SleDebCreHdrRepository ?? new SleDebCreHdrRepository(_context);
 


        private SleDebCreItmRepository _SleDebCreItmRepository;
        
        public ISleDebCreItmRepository SleDebCreItmRepository => _SleDebCreItmRepository = _SleDebCreItmRepository ?? new SleDebCreItmRepository(_context);
 


        private SleFixAccRepository _SleFixAccRepository;
        
        public ISleFixAccRepository SleFixAccRepository => _SleFixAccRepository = _SleFixAccRepository ?? new SleFixAccRepository(_context);
 


        private SleGuaDocsRepository _SleGuaDocsRepository;
        
        public ISleGuaDocsRepository SleGuaDocsRepository => _SleGuaDocsRepository = _SleGuaDocsRepository ?? new SleGuaDocsRepository(_context);
 


        private SleGuaranteeRepository _SleGuaranteeRepository;
        
        public ISleGuaranteeRepository SleGuaranteeRepository => _SleGuaranteeRepository = _SleGuaranteeRepository ?? new SleGuaranteeRepository(_context);
 


        private SleLimitsRepository _SleLimitsRepository;
        
        public ISleLimitsRepository SleLimitsRepository => _SleLimitsRepository = _SleLimitsRepository ?? new SleLimitsRepository(_context);
 


        private SlePlacesRepository _SlePlacesRepository;
        
        public ISlePlacesRepository SlePlacesRepository => _SlePlacesRepository = _SlePlacesRepository ?? new SlePlacesRepository(_context);
 


        private SlePriceHdrRepository _SlePriceHdrRepository;
        
        public ISlePriceHdrRepository SlePriceHdrRepository => _SlePriceHdrRepository = _SlePriceHdrRepository ?? new SlePriceHdrRepository(_context);
 


        private SlePriceItmRepository _SlePriceItmRepository;
        
        public ISlePriceItmRepository SlePriceItmRepository => _SlePriceItmRepository = _SlePriceItmRepository ?? new SlePriceItmRepository(_context);
 


        private SleServicesRepository _SleServicesRepository;
        
        public ISleServicesRepository SleServicesRepository => _SleServicesRepository = _SleServicesRepository ?? new SleServicesRepository(_context);
 


        private SleSrvGroupsRepository _SleSrvGroupsRepository;
        
        public ISleSrvGroupsRepository SleSrvGroupsRepository => _SleSrvGroupsRepository = _SleSrvGroupsRepository ?? new SleSrvGroupsRepository(_context);
 


        private SleSrvHdrRepository _SleSrvHdrRepository;
        
        public ISleSrvHdrRepository SleSrvHdrRepository => _SleSrvHdrRepository = _SleSrvHdrRepository ?? new SleSrvHdrRepository(_context);
 


        private SleSrvItmRepository _SleSrvItmRepository;
        
        public ISleSrvItmRepository SleSrvItmRepository => _SleSrvItmRepository = _SleSrvItmRepository ?? new SleSrvItmRepository(_context);
 


        private SleSrvPrcHdrRepository _SleSrvPrcHdrRepository;
        
        public ISleSrvPrcHdrRepository SleSrvPrcHdrRepository => _SleSrvPrcHdrRepository = _SleSrvPrcHdrRepository ?? new SleSrvPrcHdrRepository(_context);
 


        private SleSrvPrcItmRepository _SleSrvPrcItmRepository;
        
        public ISleSrvPrcItmRepository SleSrvPrcItmRepository => _SleSrvPrcItmRepository = _SleSrvPrcItmRepository ?? new SleSrvPrcItmRepository(_context);
 


        private SleSrvTaxRepository _SleSrvTaxRepository;
        
        public ISleSrvTaxRepository SleSrvTaxRepository => _SleSrvTaxRepository = _SleSrvTaxRepository ?? new SleSrvTaxRepository(_context);
 


        private SleTaxDefValRepository _SleTaxDefValRepository;
        
        public ISleTaxDefValRepository SleTaxDefValRepository => _SleTaxDefValRepository = _SleTaxDefValRepository ?? new SleTaxDefValRepository(_context);
 


        private SleTaxesRepository _SleTaxesRepository;
        
        public ISleTaxesRepository SleTaxesRepository => _SleTaxesRepository = _SleTaxesRepository ?? new SleTaxesRepository(_context);
 


        private SleTypesRepository _SleTypesRepository;
        
        public ISleTypesRepository SleTypesRepository => _SleTypesRepository = _SleTypesRepository ?? new SleTypesRepository(_context);
 


        private SleVchHdrRepository _SleVchHdrRepository;
        
        public ISleVchHdrRepository SleVchHdrRepository => _SleVchHdrRepository = _SleVchHdrRepository ?? new SleVchHdrRepository(_context);
 


        private SleVchItmRepository _SleVchItmRepository;
        
        public ISleVchItmRepository SleVchItmRepository => _SleVchItmRepository = _SleVchItmRepository ?? new SleVchItmRepository(_context);
 


        private SleVchQtyValRepository _SleVchQtyValRepository;
        
        public ISleVchQtyValRepository SleVchQtyValRepository => _SleVchQtyValRepository = _SleVchQtyValRepository ?? new SleVchQtyValRepository(_context);
 


        private SleVchTaxRepository _SleVchTaxRepository;
        
        public ISleVchTaxRepository SleVchTaxRepository => _SleVchTaxRepository = _SleVchTaxRepository ?? new SleVchTaxRepository(_context);
 


        private SleVchTypesRepository _SleVchTypesRepository;
        
        public ISleVchTypesRepository SleVchTypesRepository => _SleVchTypesRepository = _SleVchTypesRepository ?? new SleVchTypesRepository(_context);
 


        private QcsBasesRepository _QcsBasesRepository;
        
        public IQcsBasesRepository QcsBasesRepository => _QcsBasesRepository = _QcsBasesRepository ?? new QcsBasesRepository(_context);
 


        private QcsDocsRepository _QcsDocsRepository;
        
        public IQcsDocsRepository QcsDocsRepository => _QcsDocsRepository = _QcsDocsRepository ?? new QcsDocsRepository(_context);
 


        private QcsMenLabsRepository _QcsMenLabsRepository;
        
        public IQcsMenLabsRepository QcsMenLabsRepository => _QcsMenLabsRepository = _QcsMenLabsRepository ?? new QcsMenLabsRepository(_context);
 


        private QcsMensRepository _QcsMensRepository;
        
        public IQcsMensRepository QcsMensRepository => _QcsMensRepository = _QcsMensRepository ?? new QcsMensRepository(_context);
 


        private QcsRequestRepository _QcsRequestRepository;
        
        public IQcsRequestRepository QcsRequestRepository => _QcsRequestRepository = _QcsRequestRepository ?? new QcsRequestRepository(_context);
 


        private QcsTestDetRepository _QcsTestDetRepository;
        
        public IQcsTestDetRepository QcsTestDetRepository => _QcsTestDetRepository = _QcsTestDetRepository ?? new QcsTestDetRepository(_context);
 


        private QcsTestDocsRepository _QcsTestDocsRepository;
        
        public IQcsTestDocsRepository QcsTestDocsRepository => _QcsTestDocsRepository = _QcsTestDocsRepository ?? new QcsTestDocsRepository(_context);
 


        private QcsTestsRepository _QcsTestsRepository;
        
        public IQcsTestsRepository QcsTestsRepository => _QcsTestsRepository = _QcsTestsRepository ?? new QcsTestsRepository(_context);
 


        private QcsVchHdrRepository _QcsVchHdrRepository;
        
        public IQcsVchHdrRepository QcsVchHdrRepository => _QcsVchHdrRepository = _QcsVchHdrRepository ?? new QcsVchHdrRepository(_context);
 


        private QcsVchItmRepository _QcsVchItmRepository;
        
        public IQcsVchItmRepository QcsVchItmRepository => _QcsVchItmRepository = _QcsVchItmRepository ?? new QcsVchItmRepository(_context);
 


        private PrdCalenderRepository _PrdCalenderRepository;
        
        public IPrdCalenderRepository PrdCalenderRepository => _PrdCalenderRepository = _PrdCalenderRepository ?? new PrdCalenderRepository(_context);
 


        private PrdConsumHdrRepository _PrdConsumHdrRepository;
        
        public IPrdConsumHdrRepository PrdConsumHdrRepository => _PrdConsumHdrRepository = _PrdConsumHdrRepository ?? new PrdConsumHdrRepository(_context);
 


        private PrdConsumItmRepository _PrdConsumItmRepository;
        
        public IPrdConsumItmRepository PrdConsumItmRepository => _PrdConsumItmRepository = _PrdConsumItmRepository ?? new PrdConsumItmRepository(_context);
 


        private PrdFixInfRepository _PrdFixInfRepository;
        
        public IPrdFixInfRepository PrdFixInfRepository => _PrdFixInfRepository = _PrdFixInfRepository ?? new PrdFixInfRepository(_context);
 


        private PrdFixStopRepository _PrdFixStopRepository;
        
        public IPrdFixStopRepository PrdFixStopRepository => _PrdFixStopRepository = _PrdFixStopRepository ?? new PrdFixStopRepository(_context);
 


        private PrdMachineRepository _PrdMachineRepository;
        
        public IPrdMachineRepository PrdMachineRepository => _PrdMachineRepository = _PrdMachineRepository ?? new PrdMachineRepository(_context);
 


        private PrdMacroRepository _PrdMacroRepository;
        
        public IPrdMacroRepository PrdMacroRepository => _PrdMacroRepository = _PrdMacroRepository ?? new PrdMacroRepository(_context);
 


        private PrdMatPkgRepository _PrdMatPkgRepository;
        
        public IPrdMatPkgRepository PrdMatPkgRepository => _PrdMatPkgRepository = _PrdMatPkgRepository ?? new PrdMatPkgRepository(_context);
 


        private PrdMatPlanRepository _PrdMatPlanRepository;
        
        public IPrdMatPlanRepository PrdMatPlanRepository => _PrdMatPlanRepository = _PrdMatPlanRepository ?? new PrdMatPlanRepository(_context);
 


        private PrdOperationRepository _PrdOperationRepository;
        
        public IPrdOperationRepository PrdOperationRepository => _PrdOperationRepository = _PrdOperationRepository ?? new PrdOperationRepository(_context);
 


        private PrdOprDetRepository _PrdOprDetRepository;
        
        public IPrdOprDetRepository PrdOprDetRepository => _PrdOprDetRepository = _PrdOprDetRepository ?? new PrdOprDetRepository(_context);
 


        private PrdOprDetInfRepository _PrdOprDetInfRepository;
        
        public IPrdOprDetInfRepository PrdOprDetInfRepository => _PrdOprDetInfRepository = _PrdOprDetInfRepository ?? new PrdOprDetInfRepository(_context);
 


        private PrdOprDetPersRepository _PrdOprDetPersRepository;
        
        public IPrdOprDetPersRepository PrdOprDetPersRepository => _PrdOprDetPersRepository = _PrdOprDetPersRepository ?? new PrdOprDetPersRepository(_context);
 


        private PrdOrdHdrRepository _PrdOrdHdrRepository;
        
        public IPrdOrdHdrRepository PrdOrdHdrRepository => _PrdOrdHdrRepository = _PrdOrdHdrRepository ?? new PrdOrdHdrRepository(_context);
 


        private PrdOrdItmRepository _PrdOrdItmRepository;
        
        public IPrdOrdItmRepository PrdOrdItmRepository => _PrdOrdItmRepository = _PrdOrdItmRepository ?? new PrdOrdItmRepository(_context);
 


        private PrdOrdSchedRepository _PrdOrdSchedRepository;
        
        public IPrdOrdSchedRepository PrdOrdSchedRepository => _PrdOrdSchedRepository = _PrdOrdSchedRepository ?? new PrdOrdSchedRepository(_context);
 


        private PrdPersRepository _PrdPersRepository;
        
        public IPrdPersRepository PrdPersRepository => _PrdPersRepository = _PrdPersRepository ?? new PrdPersRepository(_context);
 


        private PrdPersWorkStRepository _PrdPersWorkStRepository;
        
        public IPrdPersWorkStRepository PrdPersWorkStRepository => _PrdPersWorkStRepository = _PrdPersWorkStRepository ?? new PrdPersWorkStRepository(_context);
 


        private PrdPOrdHdrRepository _PrdPOrdHdrRepository;
        
        public IPrdPOrdHdrRepository PrdPOrdHdrRepository => _PrdPOrdHdrRepository = _PrdPOrdHdrRepository ?? new PrdPOrdHdrRepository(_context);
 


        private PrdPOrdItmRepository _PrdPOrdItmRepository;
        
        public IPrdPOrdItmRepository PrdPOrdItmRepository => _PrdPOrdItmRepository = _PrdPOrdItmRepository ?? new PrdPOrdItmRepository(_context);
 


        private PrdPOrdItmDetRepository _PrdPOrdItmDetRepository;
        
        public IPrdPOrdItmDetRepository PrdPOrdItmDetRepository => _PrdPOrdItmDetRepository = _PrdPOrdItmDetRepository ?? new PrdPOrdItmDetRepository(_context);
 


        private PrdSchStopRepository _PrdSchStopRepository;
        
        public IPrdSchStopRepository PrdSchStopRepository => _PrdSchStopRepository = _PrdSchStopRepository ?? new PrdSchStopRepository(_context);
 


        private PrdSendHdrRepository _PrdSendHdrRepository;
        
        public IPrdSendHdrRepository PrdSendHdrRepository => _PrdSendHdrRepository = _PrdSendHdrRepository ?? new PrdSendHdrRepository(_context);
 


        private PrdSendItmRepository _PrdSendItmRepository;
        
        public IPrdSendItmRepository PrdSendItmRepository => _PrdSendItmRepository = _PrdSendItmRepository ?? new PrdSendItmRepository(_context);
 


        private PrdShiftsRepository _PrdShiftsRepository;
        
        public IPrdShiftsRepository PrdShiftsRepository => _PrdShiftsRepository = _PrdShiftsRepository ?? new PrdShiftsRepository(_context);
 


        private PrdStopRepository _PrdStopRepository;
        
        public IPrdStopRepository PrdStopRepository => _PrdStopRepository = _PrdStopRepository ?? new PrdStopRepository(_context);
 


        private PrdStopItmRepository _PrdStopItmRepository;
        
        public IPrdStopItmRepository PrdStopItmRepository => _PrdStopItmRepository = _PrdStopItmRepository ?? new PrdStopItmRepository(_context);
 


        private PrdVchHdrRepository _PrdVchHdrRepository;
        
        public IPrdVchHdrRepository PrdVchHdrRepository => _PrdVchHdrRepository = _PrdVchHdrRepository ?? new PrdVchHdrRepository(_context);
 


        private PrdVchInvDetRepository _PrdVchInvDetRepository;
        
        public IPrdVchInvDetRepository PrdVchInvDetRepository => _PrdVchInvDetRepository = _PrdVchInvDetRepository ?? new PrdVchInvDetRepository(_context);
 


        private PrdVchItmRepository _PrdVchItmRepository;
        
        public IPrdVchItmRepository PrdVchItmRepository => _PrdVchItmRepository = _PrdVchItmRepository ?? new PrdVchItmRepository(_context);
 


        private ProjectsRepository _ProjectsRepository;
        
        public IProjectsRepository ProjectsRepository => _ProjectsRepository = _ProjectsRepository ?? new ProjectsRepository(_context);
 


        private PayAccVchRepository _PayAccVchRepository;
        
        public IPayAccVchRepository PayAccVchRepository => _PayAccVchRepository = _PayAccVchRepository ?? new PayAccVchRepository(_context);
 


        private PayAccVchDetRepository _PayAccVchDetRepository;
        
        public IPayAccVchDetRepository PayAccVchDetRepository => _PayAccVchDetRepository = _PayAccVchDetRepository ?? new PayAccVchDetRepository(_context);
 


        private PayBdgBaseRepository _PayBdgBaseRepository;
        
        public IPayBdgBaseRepository PayBdgBaseRepository => _PayBdgBaseRepository = _PayBdgBaseRepository ?? new PayBdgBaseRepository(_context);
 


        private PayBdgStateRepository _PayBdgStateRepository;
        
        public IPayBdgStateRepository PayBdgStateRepository => _PayBdgStateRepository = _PayBdgStateRepository ?? new PayBdgStateRepository(_context);
 


        private PayBdgValsRepository _PayBdgValsRepository;
        
        public IPayBdgValsRepository PayBdgValsRepository => _PayBdgValsRepository = _PayBdgValsRepository ?? new PayBdgValsRepository(_context);
 


        private PayBuyBaseRepository _PayBuyBaseRepository;
        
        public IPayBuyBaseRepository PayBuyBaseRepository => _PayBuyBaseRepository = _PayBuyBaseRepository ?? new PayBuyBaseRepository(_context);
 


        private PayBuyCalcRepository _PayBuyCalcRepository;
        
        public IPayBuyCalcRepository PayBuyCalcRepository => _PayBuyCalcRepository = _PayBuyCalcRepository ?? new PayBuyCalcRepository(_context);
 


        private PayCalcBaseRepository _PayCalcBaseRepository;
        
        public IPayCalcBaseRepository PayCalcBaseRepository => _PayCalcBaseRepository = _PayCalcBaseRepository ?? new PayCalcBaseRepository(_context);
 


        private PayCalcCtrlRepository _PayCalcCtrlRepository;
        
        public IPayCalcCtrlRepository PayCalcCtrlRepository => _PayCalcCtrlRepository = _PayCalcCtrlRepository ?? new PayCalcCtrlRepository(_context);
 


        private PayCalcCtrlDetRepository _PayCalcCtrlDetRepository;
        
        public IPayCalcCtrlDetRepository PayCalcCtrlDetRepository => _PayCalcCtrlDetRepository = _PayCalcCtrlDetRepository ?? new PayCalcCtrlDetRepository(_context);
 


        private PayCalcStateRepository _PayCalcStateRepository;
        
        public IPayCalcStateRepository PayCalcStateRepository => _PayCalcStateRepository = _PayCalcStateRepository ?? new PayCalcStateRepository(_context);
 


        private PayCalcValsRepository _PayCalcValsRepository;
        
        public IPayCalcValsRepository PayCalcValsRepository => _PayCalcValsRepository = _PayCalcValsRepository ?? new PayCalcValsRepository(_context);
 


        private PayCompBranchsRepository _PayCompBranchsRepository;
        
        public IPayCompBranchsRepository PayCompBranchsRepository => _PayCompBranchsRepository = _PayCompBranchsRepository ?? new PayCompBranchsRepository(_context);
 


        private PayCompsRepository _PayCompsRepository;
        
        public IPayCompsRepository PayCompsRepository => _PayCompsRepository = _PayCompsRepository ?? new PayCompsRepository(_context);
 


        private PayCtrlRepository _PayCtrlRepository;
        
        public IPayCtrlRepository PayCtrlRepository => _PayCtrlRepository = _PayCtrlRepository ?? new PayCtrlRepository(_context);
 


        private PayElmntRelsRepository _PayElmntRelsRepository;
        
        public IPayElmntRelsRepository PayElmntRelsRepository => _PayElmntRelsRepository = _PayElmntRelsRepository ?? new PayElmntRelsRepository(_context);
 


        private PayExpDetRepository _PayExpDetRepository;
        
        public IPayExpDetRepository PayExpDetRepository => _PayExpDetRepository = _PayExpDetRepository ?? new PayExpDetRepository(_context);
 


        private PayExportFilesRepository _PayExportFilesRepository;
        
        public IPayExportFilesRepository PayExportFilesRepository => _PayExportFilesRepository = _PayExportFilesRepository ?? new PayExportFilesRepository(_context);
 


        private PayFishRepository _PayFishRepository;
        
        public IPayFishRepository PayFishRepository => _PayFishRepository = _PayFishRepository ?? new PayFishRepository(_context);
 


        private PayFishElmntRepository _PayFishElmntRepository;
        
        public IPayFishElmntRepository PayFishElmntRepository => _PayFishElmntRepository = _PayFishElmntRepository ?? new PayFishElmntRepository(_context);
 


        private PayFixElmntRepository _PayFixElmntRepository;
        
        public IPayFixElmntRepository PayFixElmntRepository => _PayFixElmntRepository = _PayFixElmntRepository ?? new PayFixElmntRepository(_context);
 


        private PayFixElmntValRepository _PayFixElmntValRepository;
        
        public IPayFixElmntValRepository PayFixElmntValRepository => _PayFixElmntValRepository = _PayFixElmntValRepository ?? new PayFixElmntValRepository(_context);
 


        private PayGrpLoanRepository _PayGrpLoanRepository;
        
        public IPayGrpLoanRepository PayGrpLoanRepository => _PayGrpLoanRepository = _PayGrpLoanRepository ?? new PayGrpLoanRepository(_context);
 


        private PayGrpLoanPersRepository _PayGrpLoanPersRepository;
        
        public IPayGrpLoanPersRepository PayGrpLoanPersRepository => _PayGrpLoanPersRepository = _PayGrpLoanPersRepository ?? new PayGrpLoanPersRepository(_context);
 


        private PayGrpValStatRepository _PayGrpValStatRepository;
        
        public IPayGrpValStatRepository PayGrpValStatRepository => _PayGrpValStatRepository = _PayGrpValStatRepository ?? new PayGrpValStatRepository(_context);
 


        private PayGrpValStatAmntRepository _PayGrpValStatAmntRepository;
        
        public IPayGrpValStatAmntRepository PayGrpValStatAmntRepository => _PayGrpValStatAmntRepository = _PayGrpValStatAmntRepository ?? new PayGrpValStatAmntRepository(_context);
 


        private PayGrpValStatPersRepository _PayGrpValStatPersRepository;
        
        public IPayGrpValStatPersRepository PayGrpValStatPersRepository => _PayGrpValStatPersRepository = _PayGrpValStatPersRepository ?? new PayGrpValStatPersRepository(_context);
 


        private PayImpDetRepository _PayImpDetRepository;
        
        public IPayImpDetRepository PayImpDetRepository => _PayImpDetRepository = _PayImpDetRepository ?? new PayImpDetRepository(_context);
 


        private PayImportFilesRepository _PayImportFilesRepository;
        
        public IPayImportFilesRepository PayImportFilesRepository => _PayImportFilesRepository = _PayImportFilesRepository ?? new PayImportFilesRepository(_context);
 


        private PayLoanHistoryRepository _PayLoanHistoryRepository;
        
        public IPayLoanHistoryRepository PayLoanHistoryRepository => _PayLoanHistoryRepository = _PayLoanHistoryRepository ?? new PayLoanHistoryRepository(_context);
 


        private PayLoanPaymentRepository _PayLoanPaymentRepository;
        
        public IPayLoanPaymentRepository PayLoanPaymentRepository => _PayLoanPaymentRepository = _PayLoanPaymentRepository ?? new PayLoanPaymentRepository(_context);
 


        private PayLoanRcvRepository _PayLoanRcvRepository;
        
        public IPayLoanRcvRepository PayLoanRcvRepository => _PayLoanRcvRepository = _PayLoanRcvRepository ?? new PayLoanRcvRepository(_context);
 


        private PayLoanTypesRepository _PayLoanTypesRepository;
        
        public IPayLoanTypesRepository PayLoanTypesRepository => _PayLoanTypesRepository = _PayLoanTypesRepository ?? new PayLoanTypesRepository(_context);
 


        private PayMonthlyMthdRepository _PayMonthlyMthdRepository;
        
        public IPayMonthlyMthdRepository PayMonthlyMthdRepository => _PayMonthlyMthdRepository = _PayMonthlyMthdRepository ?? new PayMonthlyMthdRepository(_context);
 


        private PayMonthlyValsRepository _PayMonthlyValsRepository;
        
        public IPayMonthlyValsRepository PayMonthlyValsRepository => _PayMonthlyValsRepository = _PayMonthlyValsRepository ?? new PayMonthlyValsRepository(_context);
 


        private PayPersEndRepository _PayPersEndRepository;
        
        public IPayPersEndRepository PayPersEndRepository => _PayPersEndRepository = _PayPersEndRepository ?? new PayPersEndRepository(_context);
 


        private PayRepListsRepository _PayRepListsRepository;
        
        public IPayRepListsRepository PayRepListsRepository => _PayRepListsRepository = _PayRepListsRepository ?? new PayRepListsRepository(_context);
 


        private PaySystemsRepository _PaySystemsRepository;
        
        public IPaySystemsRepository PaySystemsRepository => _PaySystemsRepository = _PaySystemsRepository ?? new PaySystemsRepository(_context);
 


        private PayTaxCompsRepository _PayTaxCompsRepository;
        
        public IPayTaxCompsRepository PayTaxCompsRepository => _PayTaxCompsRepository = _PayTaxCompsRepository ?? new PayTaxCompsRepository(_context);
 


        private PayTaxDetRepository _PayTaxDetRepository;
        
        public IPayTaxDetRepository PayTaxDetRepository => _PayTaxDetRepository = _PayTaxDetRepository ?? new PayTaxDetRepository(_context);
 


        private PayTaxTableRepository _PayTaxTableRepository;
        
        public IPayTaxTableRepository PayTaxTableRepository => _PayTaxTableRepository = _PayTaxTableRepository ?? new PayTaxTableRepository(_context);
 


        private PayUserFieldRepository _PayUserFieldRepository;
        
        public IPayUserFieldRepository PayUserFieldRepository => _PayUserFieldRepository = _PayUserFieldRepository ?? new PayUserFieldRepository(_context);
 


        private PayUserFunsRepository _PayUserFunsRepository;
        
        public IPayUserFunsRepository PayUserFunsRepository => _PayUserFunsRepository = _PayUserFunsRepository ?? new PayUserFunsRepository(_context);
 


        private PayVacMonthlyRepository _PayVacMonthlyRepository;
        
        public IPayVacMonthlyRepository PayVacMonthlyRepository => _PayVacMonthlyRepository = _PayVacMonthlyRepository ?? new PayVacMonthlyRepository(_context);
 


        private PayVacRemainRepository _PayVacRemainRepository;
        
        public IPayVacRemainRepository PayVacRemainRepository => _PayVacRemainRepository = _PayVacRemainRepository ?? new PayVacRemainRepository(_context);
 


        private PayValStatAmntRepository _PayValStatAmntRepository;
        
        public IPayValStatAmntRepository PayValStatAmntRepository => _PayValStatAmntRepository = _PayValStatAmntRepository ?? new PayValStatAmntRepository(_context);
 


        private PayValStatsRepository _PayValStatsRepository;
        
        public IPayValStatsRepository PayValStatsRepository => _PayValStatsRepository = _PayValStatsRepository ?? new PayValStatsRepository(_context);
 


        private PayVchDetRepository _PayVchDetRepository;
        
        public IPayVchDetRepository PayVchDetRepository => _PayVchDetRepository = _PayVchDetRepository ?? new PayVchDetRepository(_context);
 


        private PayVchDetInfsRepository _PayVchDetInfsRepository;
        
        public IPayVchDetInfsRepository PayVchDetInfsRepository => _PayVchDetInfsRepository = _PayVchDetInfsRepository ?? new PayVchDetInfsRepository(_context);
 


        private PayVchTypeRepository _PayVchTypeRepository;
        
        public IPayVchTypeRepository PayVchTypeRepository => _PayVchTypeRepository = _PayVchTypeRepository ?? new PayVchTypeRepository(_context);
 


        private PayWorkLimitRepository _PayWorkLimitRepository;
        
        public IPayWorkLimitRepository PayWorkLimitRepository => _PayWorkLimitRepository = _PayWorkLimitRepository ?? new PayWorkLimitRepository(_context);
 


        private PartFormulaRepository _PartFormulaRepository;
        
        public IPartFormulaRepository PartFormulaRepository => _PartFormulaRepository = _PartFormulaRepository ?? new PartFormulaRepository(_context);
 


        private PartFormulaDetRepository _PartFormulaDetRepository;
        
        public IPartFormulaDetRepository PartFormulaDetRepository => _PartFormulaDetRepository = _PartFormulaDetRepository ?? new PartFormulaDetRepository(_context);
 


        private PartFrmlMachRepository _PartFrmlMachRepository;
        
        public IPartFrmlMachRepository PartFrmlMachRepository => _PartFrmlMachRepository = _PartFrmlMachRepository ?? new PartFrmlMachRepository(_context);
 


        private PartFrmlOutRepository _PartFrmlOutRepository;
        
        public IPartFrmlOutRepository PartFrmlOutRepository => _PartFrmlOutRepository = _PartFrmlOutRepository ?? new PartFrmlOutRepository(_context);
 


        private PartsRepository _PartsRepository;
        
        public IPartsRepository PartsRepository => _PartsRepository = _PartsRepository ?? new PartsRepository(_context);
 


        private PmiReqPartRepository _PmiReqPartRepository;
        
        public IPmiReqPartRepository PmiReqPartRepository => _PmiReqPartRepository = _PmiReqPartRepository ?? new PmiReqPartRepository(_context);
 


        private OtoAttachRepository _OtoAttachRepository;
        
        public IOtoAttachRepository OtoAttachRepository => _OtoAttachRepository = _OtoAttachRepository ?? new OtoAttachRepository(_context);
 


        private OtoBaseTypesRepository _OtoBaseTypesRepository;
        
        public IOtoBaseTypesRepository OtoBaseTypesRepository => _OtoBaseTypesRepository = _OtoBaseTypesRepository ?? new OtoBaseTypesRepository(_context);
 


        private OtoBaseTypeValsRepository _OtoBaseTypeValsRepository;
        
        public IOtoBaseTypeValsRepository OtoBaseTypeValsRepository => _OtoBaseTypeValsRepository = _OtoBaseTypeValsRepository ?? new OtoBaseTypeValsRepository(_context);
 


        private OtoCtgryRepository _OtoCtgryRepository;
        
        public IOtoCtgryRepository OtoCtgryRepository => _OtoCtgryRepository = _OtoCtgryRepository ?? new OtoCtgryRepository(_context);
 


        private OtoFilesRepository _OtoFilesRepository;
        
        public IOtoFilesRepository OtoFilesRepository => _OtoFilesRepository = _OtoFilesRepository ?? new OtoFilesRepository(_context);
 


        private OtoFlowRepository _OtoFlowRepository;
        
        public IOtoFlowRepository OtoFlowRepository => _OtoFlowRepository = _OtoFlowRepository ?? new OtoFlowRepository(_context);
 


        private OtoFlowCrsRepository _OtoFlowCrsRepository;
        
        public IOtoFlowCrsRepository OtoFlowCrsRepository => _OtoFlowCrsRepository = _OtoFlowCrsRepository ?? new OtoFlowCrsRepository(_context);
 


        private OtoFlowRightRepository _OtoFlowRightRepository;
        
        public IOtoFlowRightRepository OtoFlowRightRepository => _OtoFlowRightRepository = _OtoFlowRightRepository ?? new OtoFlowRightRepository(_context);
 


        private OtoIndicatorRepository _OtoIndicatorRepository;
        
        public IOtoIndicatorRepository OtoIndicatorRepository => _OtoIndicatorRepository = _OtoIndicatorRepository ?? new OtoIndicatorRepository(_context);
 


        private OtoLettersRepository _OtoLettersRepository;
        
        public IOtoLettersRepository OtoLettersRepository => _OtoLettersRepository = _OtoLettersRepository ?? new OtoLettersRepository(_context);
 


        private OtoLttrDocRepository _OtoLttrDocRepository;
        
        public IOtoLttrDocRepository OtoLttrDocRepository => _OtoLttrDocRepository = _OtoLttrDocRepository ?? new OtoLttrDocRepository(_context);
 


        private OtoLttrLabelsRepository _OtoLttrLabelsRepository;
        
        public IOtoLttrLabelsRepository OtoLttrLabelsRepository => _OtoLttrLabelsRepository = _OtoLttrLabelsRepository ?? new OtoLttrLabelsRepository(_context);
 


        private OtoLttrLinksRepository _OtoLttrLinksRepository;
        
        public IOtoLttrLinksRepository OtoLttrLinksRepository => _OtoLttrLinksRepository = _OtoLttrLinksRepository ?? new OtoLttrLinksRepository(_context);
 


        private OtoLttrPropsRepository _OtoLttrPropsRepository;
        
        public IOtoLttrPropsRepository OtoLttrPropsRepository => _OtoLttrPropsRepository = _OtoLttrPropsRepository ?? new OtoLttrPropsRepository(_context);
 


        private OtoQuickNoteRepository _OtoQuickNoteRepository;
        
        public IOtoQuickNoteRepository OtoQuickNoteRepository => _OtoQuickNoteRepository = _OtoQuickNoteRepository ?? new OtoQuickNoteRepository(_context);
 


        private OtoSysLttrRepository _OtoSysLttrRepository;
        
        public IOtoSysLttrRepository OtoSysLttrRepository => _OtoSysLttrRepository = _OtoSysLttrRepository ?? new OtoSysLttrRepository(_context);
 


        private OtoTemplatesRepository _OtoTemplatesRepository;
        
        public IOtoTemplatesRepository OtoTemplatesRepository => _OtoTemplatesRepository = _OtoTemplatesRepository ?? new OtoTemplatesRepository(_context);
 


        private OtoTransScriptRepository _OtoTransScriptRepository;
        
        public IOtoTransScriptRepository OtoTransScriptRepository => _OtoTransScriptRepository = _OtoTransScriptRepository ?? new OtoTransScriptRepository(_context);
 


        private OtoUserRightRepository _OtoUserRightRepository;
        
        public IOtoUserRightRepository OtoUserRightRepository => _OtoUserRightRepository = _OtoUserRightRepository ?? new OtoUserRightRepository(_context);
 


        private InvFormHdrRepository _InvFormHdrRepository;
        
        public IInvFormHdrRepository InvFormHdrRepository => _InvFormHdrRepository = _InvFormHdrRepository ?? new InvFormHdrRepository(_context);
 


        private InvFormItmRepository _InvFormItmRepository;
        
        public IInvFormItmRepository InvFormItmRepository => _InvFormItmRepository = _InvFormItmRepository ?? new InvFormItmRepository(_context);
 


        private InvFormTypesRepository _InvFormTypesRepository;
        
        public IInvFormTypesRepository InvFormTypesRepository => _InvFormTypesRepository = _InvFormTypesRepository ?? new InvFormTypesRepository(_context);
 


        private InvItmRateDetRepository _InvItmRateDetRepository;
        
        public IInvItmRateDetRepository InvItmRateDetRepository => _InvItmRateDetRepository = _InvItmRateDetRepository ?? new InvItmRateDetRepository(_context);
 


        private InvPartCmrInfRepository _InvPartCmrInfRepository;
        
        public IInvPartCmrInfRepository InvPartCmrInfRepository => _InvPartCmrInfRepository = _InvPartCmrInfRepository ?? new InvPartCmrInfRepository(_context);
 


        private InvPartCtgryRepository _InvPartCtgryRepository;
        
        public IInvPartCtgryRepository InvPartCtgryRepository => _InvPartCtgryRepository = _InvPartCtgryRepository ?? new InvPartCtgryRepository(_context);
 


        private InvPartCtgryAccRepository _InvPartCtgryAccRepository;
        
        public IInvPartCtgryAccRepository InvPartCtgryAccRepository => _InvPartCtgryAccRepository = _InvPartCtgryAccRepository ?? new InvPartCtgryAccRepository(_context);
 


        private InvPartDLInfRepository _InvPartDLInfRepository;
        
        public IInvPartDLInfRepository InvPartDLInfRepository => _InvPartDLInfRepository = _InvPartDLInfRepository ?? new InvPartDLInfRepository(_context);
 


        private InvPartGroupsRepository _InvPartGroupsRepository;
        
        public IInvPartGroupsRepository InvPartGroupsRepository => _InvPartGroupsRepository = _InvPartGroupsRepository ?? new InvPartGroupsRepository(_context);
 


        private InvPartGrpRelRepository _InvPartGrpRelRepository;
        
        public IInvPartGrpRelRepository InvPartGrpRelRepository => _InvPartGrpRelRepository = _InvPartGrpRelRepository ?? new InvPartGrpRelRepository(_context);
 


        private InvPartParamsRepository _InvPartParamsRepository;
        
        public IInvPartParamsRepository InvPartParamsRepository => _InvPartParamsRepository = _InvPartParamsRepository ?? new InvPartParamsRepository(_context);
 


        private InvPartPriceRepository _InvPartPriceRepository;
        
        public IInvPartPriceRepository InvPartPriceRepository => _InvPartPriceRepository = _InvPartPriceRepository ?? new InvPartPriceRepository(_context);
 


        private InvPartSimilarRepository _InvPartSimilarRepository;
        
        public IInvPartSimilarRepository InvPartSimilarRepository => _InvPartSimilarRepository = _InvPartSimilarRepository ?? new InvPartSimilarRepository(_context);
 


        private InvPartStkPitchRelRepository _InvPartStkPitchRelRepository;
        
        public IInvPartStkPitchRelRepository InvPartStkPitchRelRepository => _InvPartStkPitchRelRepository = _InvPartStkPitchRelRepository ?? new InvPartStkPitchRelRepository(_context);
 


        private InvPartStockRelRepository _InvPartStockRelRepository;
        
        public IInvPartStockRelRepository InvPartStockRelRepository => _InvPartStockRelRepository = _InvPartStockRelRepository ?? new InvPartStockRelRepository(_context);
 


        private InvPartUnitsRepository _InvPartUnitsRepository;
        
        public IInvPartUnitsRepository InvPartUnitsRepository => _InvPartUnitsRepository = _InvPartUnitsRepository ?? new InvPartUnitsRepository(_context);
 


        private InvQtPartRelsRepository _InvQtPartRelsRepository;
        
        public IInvQtPartRelsRepository InvQtPartRelsRepository => _InvQtPartRelsRepository = _InvQtPartRelsRepository ?? new InvQtPartRelsRepository(_context);
 


        private InvQtyCtrlsRepository _InvQtyCtrlsRepository;
        
        public IInvQtyCtrlsRepository InvQtyCtrlsRepository => _InvQtyCtrlsRepository = _InvQtyCtrlsRepository ?? new InvQtyCtrlsRepository(_context);
 


        private InvStckPeriodRepository _InvStckPeriodRepository;
        
        public IInvStckPeriodRepository InvStckPeriodRepository => _InvStckPeriodRepository = _InvStckPeriodRepository ?? new InvStckPeriodRepository(_context);
 


        private InvStckPeriodRelsRepository _InvStckPeriodRelsRepository;
        
        public IInvStckPeriodRelsRepository InvStckPeriodRelsRepository => _InvStckPeriodRelsRepository = _InvStckPeriodRelsRepository ?? new InvStckPeriodRelsRepository(_context);
 


        private InvStckTagRepository _InvStckTagRepository;
        
        public IInvStckTagRepository InvStckTagRepository => _InvStckTagRepository = _InvStckTagRepository ?? new InvStckTagRepository(_context);
 


        private InvStkPitchsRepository _InvStkPitchsRepository;
        
        public IInvStkPitchsRepository InvStkPitchsRepository => _InvStkPitchsRepository = _InvStkPitchsRepository ?? new InvStkPitchsRepository(_context);
 


        private InvStockRepository _InvStockRepository;
        
        public IInvStockRepository InvStockRepository => _InvStockRepository = _InvStockRepository ?? new InvStockRepository(_context);
 


        private InvStockUserRepository _InvStockUserRepository;
        
        public IInvStockUserRepository InvStockUserRepository => _InvStockUserRepository = _InvStockUserRepository ?? new InvStockUserRepository(_context);
 


        private InvVchDefAccRepository _InvVchDefAccRepository;
        
        public IInvVchDefAccRepository InvVchDefAccRepository => _InvVchDefAccRepository = _InvVchDefAccRepository ?? new InvVchDefAccRepository(_context);
 


        private InvVchHdrRepository _InvVchHdrRepository;
        
        public IInvVchHdrRepository InvVchHdrRepository => _InvVchHdrRepository = _InvVchHdrRepository ?? new InvVchHdrRepository(_context);
 


        private InvVchItmRepository _InvVchItmRepository;
        
        public IInvVchItmRepository InvVchItmRepository => _InvVchItmRepository = _InvVchItmRepository ?? new InvVchItmRepository(_context);
 


        private InvVchItmRateRepository _InvVchItmRateRepository;
        
        public IInvVchItmRateRepository InvVchItmRateRepository => _InvVchItmRateRepository = _InvVchItmRateRepository ?? new InvVchItmRateRepository(_context);
 


        private InvVchQtyValRepository _InvVchQtyValRepository;
        
        public IInvVchQtyValRepository InvVchQtyValRepository => _InvVchQtyValRepository = _InvVchQtyValRepository ?? new InvVchQtyValRepository(_context);
 


        private InvVchTransRepository _InvVchTransRepository;
        
        public IInvVchTransRepository InvVchTransRepository => _InvVchTransRepository = _InvVchTransRepository ?? new InvVchTransRepository(_context);
 


        private InvVchTypesRepository _InvVchTypesRepository;
        
        public IInvVchTypesRepository InvVchTypesRepository => _InvVchTypesRepository = _InvVchTypesRepository ?? new InvVchTypesRepository(_context);
 


        private HrmAimElmntsRepository _HrmAimElmntsRepository;
        
        public IHrmAimElmntsRepository HrmAimElmntsRepository => _HrmAimElmntsRepository = _HrmAimElmntsRepository ?? new HrmAimElmntsRepository(_context);
 


        private HrmAimFormDetRepository _HrmAimFormDetRepository;
        
        public IHrmAimFormDetRepository HrmAimFormDetRepository => _HrmAimFormDetRepository = _HrmAimFormDetRepository ?? new HrmAimFormDetRepository(_context);
 


        private HrmAimFormsRepository _HrmAimFormsRepository;
        
        public IHrmAimFormsRepository HrmAimFormsRepository => _HrmAimFormsRepository = _HrmAimFormsRepository ?? new HrmAimFormsRepository(_context);
 


        private HrmAimPeriodRepository _HrmAimPeriodRepository;
        
        public IHrmAimPeriodRepository HrmAimPeriodRepository => _HrmAimPeriodRepository = _HrmAimPeriodRepository ?? new HrmAimPeriodRepository(_context);
 


        private HrmAimPeriodDetRepository _HrmAimPeriodDetRepository;
        
        public IHrmAimPeriodDetRepository HrmAimPeriodDetRepository => _HrmAimPeriodDetRepository = _HrmAimPeriodDetRepository ?? new HrmAimPeriodDetRepository(_context);
 


        private HrmBaseAmountsRepository _HrmBaseAmountsRepository;
        
        public IHrmBaseAmountsRepository HrmBaseAmountsRepository => _HrmBaseAmountsRepository = _HrmBaseAmountsRepository ?? new HrmBaseAmountsRepository(_context);
 


        private HrmBasesRepository _HrmBasesRepository;
        
        public IHrmBasesRepository HrmBasesRepository => _HrmBasesRepository = _HrmBasesRepository ?? new HrmBasesRepository(_context);
 


        private HrmCalendarsRepository _HrmCalendarsRepository;
        
        public IHrmCalendarsRepository HrmCalendarsRepository => _HrmCalendarsRepository = _HrmCalendarsRepository ?? new HrmCalendarsRepository(_context);
 


        private HrmCalenderDetRepository _HrmCalenderDetRepository;
        
        public IHrmCalenderDetRepository HrmCalenderDetRepository => _HrmCalenderDetRepository = _HrmCalenderDetRepository ?? new HrmCalenderDetRepository(_context);
 


        private HrmDeptRepository _HrmDeptRepository;
        
        public IHrmDeptRepository HrmDeptRepository => _HrmDeptRepository = _HrmDeptRepository ?? new HrmDeptRepository(_context);
 


        private HrmDeptJobRelRepository _HrmDeptJobRelRepository;
        
        public IHrmDeptJobRelRepository HrmDeptJobRelRepository => _HrmDeptJobRelRepository = _HrmDeptJobRelRepository ?? new HrmDeptJobRelRepository(_context);
 


        private HrmEmpStatAmntRepository _HrmEmpStatAmntRepository;
        
        public IHrmEmpStatAmntRepository HrmEmpStatAmntRepository => _HrmEmpStatAmntRepository = _HrmEmpStatAmntRepository ?? new HrmEmpStatAmntRepository(_context);
 


        private HrmEmpStatueRepository _HrmEmpStatueRepository;
        
        public IHrmEmpStatueRepository HrmEmpStatueRepository => _HrmEmpStatueRepository = _HrmEmpStatueRepository ?? new HrmEmpStatueRepository(_context);
 


        private HrmEmpTypesRepository _HrmEmpTypesRepository;
        
        public IHrmEmpTypesRepository HrmEmpTypesRepository => _HrmEmpTypesRepository = _HrmEmpTypesRepository ?? new HrmEmpTypesRepository(_context);
 


        private HrmGroupsRepository _HrmGroupsRepository;
        
        public IHrmGroupsRepository HrmGroupsRepository => _HrmGroupsRepository = _HrmGroupsRepository ?? new HrmGroupsRepository(_context);
 


        private HrmGrpCompAsignRepository _HrmGrpCompAsignRepository;
        
        public IHrmGrpCompAsignRepository HrmGrpCompAsignRepository => _HrmGrpCompAsignRepository = _HrmGrpCompAsignRepository ?? new HrmGrpCompAsignRepository(_context);
 


        private HrmGrpParamStatRepository _HrmGrpParamStatRepository;
        
        public IHrmGrpParamStatRepository HrmGrpParamStatRepository => _HrmGrpParamStatRepository = _HrmGrpParamStatRepository ?? new HrmGrpParamStatRepository(_context);
 


        private HrmGrpParamStatAmntRepository _HrmGrpParamStatAmntRepository;
        
        public IHrmGrpParamStatAmntRepository HrmGrpParamStatAmntRepository => _HrmGrpParamStatAmntRepository = _HrmGrpParamStatAmntRepository ?? new HrmGrpParamStatAmntRepository(_context);
 


        private HrmGrpParamStatPersRepository _HrmGrpParamStatPersRepository;
        
        public IHrmGrpParamStatPersRepository HrmGrpParamStatPersRepository => _HrmGrpParamStatPersRepository = _HrmGrpParamStatPersRepository ?? new HrmGrpParamStatPersRepository(_context);
 


        private HrmGrpStatAmntsRepository _HrmGrpStatAmntsRepository;
        
        public IHrmGrpStatAmntsRepository HrmGrpStatAmntsRepository => _HrmGrpStatAmntsRepository = _HrmGrpStatAmntsRepository ?? new HrmGrpStatAmntsRepository(_context);
 


        private HrmGrpStatPersRepository _HrmGrpStatPersRepository;
        
        public IHrmGrpStatPersRepository HrmGrpStatPersRepository => _HrmGrpStatPersRepository = _HrmGrpStatPersRepository ?? new HrmGrpStatPersRepository(_context);
 


        private HrmGrpStatusRepository _HrmGrpStatusRepository;
        
        public IHrmGrpStatusRepository HrmGrpStatusRepository => _HrmGrpStatusRepository = _HrmGrpStatusRepository ?? new HrmGrpStatusRepository(_context);
 


        private HrmIncDecVacRepository _HrmIncDecVacRepository;
        
        public IHrmIncDecVacRepository HrmIncDecVacRepository => _HrmIncDecVacRepository = _HrmIncDecVacRepository ?? new HrmIncDecVacRepository(_context);
 


        private HrmIncDecWorkRepository _HrmIncDecWorkRepository;
        
        public IHrmIncDecWorkRepository HrmIncDecWorkRepository => _HrmIncDecWorkRepository = _HrmIncDecWorkRepository ?? new HrmIncDecWorkRepository(_context);
 


        private HrmJobCondRepository _HrmJobCondRepository;
        
        public IHrmJobCondRepository HrmJobCondRepository => _HrmJobCondRepository = _HrmJobCondRepository ?? new HrmJobCondRepository(_context);
 


        private HrmJobsRepository _HrmJobsRepository;
        
        public IHrmJobsRepository HrmJobsRepository => _HrmJobsRepository = _HrmJobsRepository ?? new HrmJobsRepository(_context);
 


        private HrmMissionsRepository _HrmMissionsRepository;
        
        public IHrmMissionsRepository HrmMissionsRepository => _HrmMissionsRepository = _HrmMissionsRepository ?? new HrmMissionsRepository(_context);
 


        private HrmNumberingRepository _HrmNumberingRepository;
        
        public IHrmNumberingRepository HrmNumberingRepository => _HrmNumberingRepository = _HrmNumberingRepository ?? new HrmNumberingRepository(_context);
 


        private HrmOvrTimePermRepository _HrmOvrTimePermRepository;
        
        public IHrmOvrTimePermRepository HrmOvrTimePermRepository => _HrmOvrTimePermRepository = _HrmOvrTimePermRepository ?? new HrmOvrTimePermRepository(_context);
 


        private HrmParamStatAmntRepository _HrmParamStatAmntRepository;
        
        public IHrmParamStatAmntRepository HrmParamStatAmntRepository => _HrmParamStatAmntRepository = _HrmParamStatAmntRepository ?? new HrmParamStatAmntRepository(_context);
 


        private HrmParamStatsRepository _HrmParamStatsRepository;
        
        public IHrmParamStatsRepository HrmParamStatsRepository => _HrmParamStatsRepository = _HrmParamStatsRepository ?? new HrmParamStatsRepository(_context);
 


        private HrmPersAccountRepository _HrmPersAccountRepository;
        
        public IHrmPersAccountRepository HrmPersAccountRepository => _HrmPersAccountRepository = _HrmPersAccountRepository ?? new HrmPersAccountRepository(_context);
 


        private HrmPersCompAsignRepository _HrmPersCompAsignRepository;
        
        public IHrmPersCompAsignRepository HrmPersCompAsignRepository => _HrmPersCompAsignRepository = _HrmPersCompAsignRepository ?? new HrmPersCompAsignRepository(_context);
 


        private HrmPersEduRepository _HrmPersEduRepository;
        
        public IHrmPersEduRepository HrmPersEduRepository => _HrmPersEduRepository = _HrmPersEduRepository ?? new HrmPersEduRepository(_context);
 


        private HrmPersExpRepository _HrmPersExpRepository;
        
        public IHrmPersExpRepository HrmPersExpRepository => _HrmPersExpRepository = _HrmPersExpRepository ?? new HrmPersExpRepository(_context);
 


        private HrmPersFghRepository _HrmPersFghRepository;
        
        public IHrmPersFghRepository HrmPersFghRepository => _HrmPersFghRepository = _HrmPersFghRepository ?? new HrmPersFghRepository(_context);
 


        private HrmPersLangRepository _HrmPersLangRepository;
        
        public IHrmPersLangRepository HrmPersLangRepository => _HrmPersLangRepository = _HrmPersLangRepository ?? new HrmPersLangRepository(_context);
 


        private HrmPersMrgRepository _HrmPersMrgRepository;
        
        public IHrmPersMrgRepository HrmPersMrgRepository => _HrmPersMrgRepository = _HrmPersMrgRepository ?? new HrmPersMrgRepository(_context);
 


        private HrmPersonnelsRepository _HrmPersonnelsRepository;
        
        public IHrmPersonnelsRepository HrmPersonnelsRepository => _HrmPersonnelsRepository = _HrmPersonnelsRepository ?? new HrmPersonnelsRepository(_context);
 


        private HrmPersParamRepository _HrmPersParamRepository;
        
        public IHrmPersParamRepository HrmPersParamRepository => _HrmPersParamRepository = _HrmPersParamRepository ?? new HrmPersParamRepository(_context);
 


        private HrmPersRltdRepository _HrmPersRltdRepository;
        
        public IHrmPersRltdRepository HrmPersRltdRepository => _HrmPersRltdRepository = _HrmPersRltdRepository ?? new HrmPersRltdRepository(_context);
 


        private HrmPersSldrRepository _HrmPersSldrRepository;
        
        public IHrmPersSldrRepository HrmPersSldrRepository => _HrmPersSldrRepository = _HrmPersSldrRepository ?? new HrmPersSldrRepository(_context);
 


        private HrmPrsntStatRepository _HrmPrsntStatRepository;
        
        public IHrmPrsntStatRepository HrmPrsntStatRepository => _HrmPrsntStatRepository = _HrmPrsntStatRepository ?? new HrmPrsntStatRepository(_context);
 


        private HrmRqstMissionRepository _HrmRqstMissionRepository;
        
        public IHrmRqstMissionRepository HrmRqstMissionRepository => _HrmRqstMissionRepository = _HrmRqstMissionRepository ?? new HrmRqstMissionRepository(_context);
 


        private HrmRqstVacRepository _HrmRqstVacRepository;
        
        public IHrmRqstVacRepository HrmRqstVacRepository => _HrmRqstVacRepository = _HrmRqstVacRepository ?? new HrmRqstVacRepository(_context);
 


        private HrmStatElmntMthdRepository _HrmStatElmntMthdRepository;
        
        public IHrmStatElmntMthdRepository HrmStatElmntMthdRepository => _HrmStatElmntMthdRepository = _HrmStatElmntMthdRepository ?? new HrmStatElmntMthdRepository(_context);
 


        private HrmStatMthdDetRepository _HrmStatMthdDetRepository;
        
        public IHrmStatMthdDetRepository HrmStatMthdDetRepository => _HrmStatMthdDetRepository = _HrmStatMthdDetRepository ?? new HrmStatMthdDetRepository(_context);
 


        private HrmStatTypesRepository _HrmStatTypesRepository;
        
        public IHrmStatTypesRepository HrmStatTypesRepository => _HrmStatTypesRepository = _HrmStatTypesRepository ?? new HrmStatTypesRepository(_context);
 


        private HrmTablesRepository _HrmTablesRepository;
        
        public IHrmTablesRepository HrmTablesRepository => _HrmTablesRepository = _HrmTablesRepository ?? new HrmTablesRepository(_context);
 


        private HrmTablesDetRepository _HrmTablesDetRepository;
        
        public IHrmTablesDetRepository HrmTablesDetRepository => _HrmTablesDetRepository = _HrmTablesDetRepository ?? new HrmTablesDetRepository(_context);
 


        private HrmTimeSheetRepository _HrmTimeSheetRepository;
        
        public IHrmTimeSheetRepository HrmTimeSheetRepository => _HrmTimeSheetRepository = _HrmTimeSheetRepository ?? new HrmTimeSheetRepository(_context);
 


        private HrmVacancyRepository _HrmVacancyRepository;
        
        public IHrmVacancyRepository HrmVacancyRepository => _HrmVacancyRepository = _HrmVacancyRepository ?? new HrmVacancyRepository(_context);
 


        private HrmVacMthodsRepository _HrmVacMthodsRepository;
        
        public IHrmVacMthodsRepository HrmVacMthodsRepository => _HrmVacMthodsRepository = _HrmVacMthodsRepository ?? new HrmVacMthodsRepository(_context);
 


        private HrmWorkGroupsRepository _HrmWorkGroupsRepository;
        
        public IHrmWorkGroupsRepository HrmWorkGroupsRepository => _HrmWorkGroupsRepository = _HrmWorkGroupsRepository ?? new HrmWorkGroupsRepository(_context);
 


        private HrmWorkGroupsInfRepository _HrmWorkGroupsInfRepository;
        
        public IHrmWorkGroupsInfRepository HrmWorkGroupsInfRepository => _HrmWorkGroupsInfRepository = _HrmWorkGroupsInfRepository ?? new HrmWorkGroupsInfRepository(_context);
 


        private HrmWorkLocRepository _HrmWorkLocRepository;
        
        public IHrmWorkLocRepository HrmWorkLocRepository => _HrmWorkLocRepository = _HrmWorkLocRepository ?? new HrmWorkLocRepository(_context);
 


        private GnrAlarmDetRepository _GnrAlarmDetRepository;
        
        public IGnrAlarmDetRepository GnrAlarmDetRepository => _GnrAlarmDetRepository = _GnrAlarmDetRepository ?? new GnrAlarmDetRepository(_context);
 


        private GnrAlarmTypesRepository _GnrAlarmTypesRepository;
        
        public IGnrAlarmTypesRepository GnrAlarmTypesRepository => _GnrAlarmTypesRepository = _GnrAlarmTypesRepository ?? new GnrAlarmTypesRepository(_context);
 


        private GnrAutoTextRepository _GnrAutoTextRepository;
        
        public IGnrAutoTextRepository GnrAutoTextRepository => _GnrAutoTextRepository = _GnrAutoTextRepository ?? new GnrAutoTextRepository(_context);
 


        private GnrDashboardsRepository _GnrDashboardsRepository;
        
        public IGnrDashboardsRepository GnrDashboardsRepository => _GnrDashboardsRepository = _GnrDashboardsRepository ?? new GnrDashboardsRepository(_context);
 


        private GnrDashFieldsRepository _GnrDashFieldsRepository;
        
        public IGnrDashFieldsRepository GnrDashFieldsRepository => _GnrDashFieldsRepository = _GnrDashFieldsRepository ?? new GnrDashFieldsRepository(_context);
 


        private GnrFormFlowRepository _GnrFormFlowRepository;
        
        public IGnrFormFlowRepository GnrFormFlowRepository => _GnrFormFlowRepository = _GnrFormFlowRepository ?? new GnrFormFlowRepository(_context);
 


        private GnrFormRepRelsRepository _GnrFormRepRelsRepository;
        
        public IGnrFormRepRelsRepository GnrFormRepRelsRepository => _GnrFormRepRelsRepository = _GnrFormRepRelsRepository ?? new GnrFormRepRelsRepository(_context);
 


        private GnrFormSettingRepository _GnrFormSettingRepository;
        
        public IGnrFormSettingRepository GnrFormSettingRepository => _GnrFormSettingRepository = _GnrFormSettingRepository ?? new GnrFormSettingRepository(_context);
 


        private GnrLimitExceptRepository _GnrLimitExceptRepository;
        
        public IGnrLimitExceptRepository GnrLimitExceptRepository => _GnrLimitExceptRepository = _GnrLimitExceptRepository ?? new GnrLimitExceptRepository(_context);
 


        private GnrLimitGroupRepository _GnrLimitGroupRepository;
        
        public IGnrLimitGroupRepository GnrLimitGroupRepository => _GnrLimitGroupRepository = _GnrLimitGroupRepository ?? new GnrLimitGroupRepository(_context);
 


        private GnrLimitUserRepository _GnrLimitUserRepository;
        
        public IGnrLimitUserRepository GnrLimitUserRepository => _GnrLimitUserRepository = _GnrLimitUserRepository ?? new GnrLimitUserRepository(_context);
 


        private GnrNumVchCfgDetRepository _GnrNumVchCfgDetRepository;
        
        public IGnrNumVchCfgDetRepository GnrNumVchCfgDetRepository => _GnrNumVchCfgDetRepository = _GnrNumVchCfgDetRepository ?? new GnrNumVchCfgDetRepository(_context);
 


        private GnrNumVchConfigRepository _GnrNumVchConfigRepository;
        
        public IGnrNumVchConfigRepository GnrNumVchConfigRepository => _GnrNumVchConfigRepository = _GnrNumVchConfigRepository ?? new GnrNumVchConfigRepository(_context);
 


        private GnrProcessRepository _GnrProcessRepository;
        
        public IGnrProcessRepository GnrProcessRepository => _GnrProcessRepository = _GnrProcessRepository ?? new GnrProcessRepository(_context);
 


        private GnrProcessDetRepository _GnrProcessDetRepository;
        
        public IGnrProcessDetRepository GnrProcessDetRepository => _GnrProcessDetRepository = _GnrProcessDetRepository ?? new GnrProcessDetRepository(_context);
 


        private GnrProcessDetArchRepository _GnrProcessDetArchRepository;
        
        public IGnrProcessDetArchRepository GnrProcessDetArchRepository => _GnrProcessDetArchRepository = _GnrProcessDetArchRepository ?? new GnrProcessDetArchRepository(_context);
 


        private GnrProcessDetObjRepository _GnrProcessDetObjRepository;
        
        public IGnrProcessDetObjRepository GnrProcessDetObjRepository => _GnrProcessDetObjRepository = _GnrProcessDetObjRepository ?? new GnrProcessDetObjRepository(_context);
 


        private GnrProcessDetTransRepository _GnrProcessDetTransRepository;
        
        public IGnrProcessDetTransRepository GnrProcessDetTransRepository => _GnrProcessDetTransRepository = _GnrProcessDetTransRepository ?? new GnrProcessDetTransRepository(_context);
 


        private GnrProcessDetUsersRepository _GnrProcessDetUsersRepository;
        
        public IGnrProcessDetUsersRepository GnrProcessDetUsersRepository => _GnrProcessDetUsersRepository = _GnrProcessDetUsersRepository ?? new GnrProcessDetUsersRepository(_context);
 


        private GnrProcessDetValsRepository _GnrProcessDetValsRepository;
        
        public IGnrProcessDetValsRepository GnrProcessDetValsRepository => _GnrProcessDetValsRepository = _GnrProcessDetValsRepository ?? new GnrProcessDetValsRepository(_context);
 


        private GnrRef2FormLinkExpRepository _GnrRef2FormLinkExpRepository;
        
        public IGnrRef2FormLinkExpRepository GnrRef2FormLinkExpRepository => _GnrRef2FormLinkExpRepository = _GnrRef2FormLinkExpRepository ?? new GnrRef2FormLinkExpRepository(_context);
 


        private GnrRef2FormLinkHdrRepository _GnrRef2FormLinkHdrRepository;
        
        public IGnrRef2FormLinkHdrRepository GnrRef2FormLinkHdrRepository => _GnrRef2FormLinkHdrRepository = _GnrRef2FormLinkHdrRepository ?? new GnrRef2FormLinkHdrRepository(_context);
 


        private GnrRef2FormLinksItmRepository _GnrRef2FormLinksItmRepository;
        
        public IGnrRef2FormLinksItmRepository GnrRef2FormLinksItmRepository => _GnrRef2FormLinksItmRepository = _GnrRef2FormLinksItmRepository ?? new GnrRef2FormLinksItmRepository(_context);
 


        private GnrRefFormsListRepository _GnrRefFormsListRepository;
        
        public IGnrRefFormsListRepository GnrRefFormsListRepository => _GnrRefFormsListRepository = _GnrRefFormsListRepository ?? new GnrRefFormsListRepository(_context);
 


        private GnrRefFormsListDetRepository _GnrRefFormsListDetRepository;
        
        public IGnrRefFormsListDetRepository GnrRefFormsListDetRepository => _GnrRefFormsListDetRepository = _GnrRefFormsListDetRepository ?? new GnrRefFormsListDetRepository(_context);
 


        private GnrReportsRepository _GnrReportsRepository;
        
        public IGnrReportsRepository GnrReportsRepository => _GnrReportsRepository = _GnrReportsRepository ?? new GnrReportsRepository(_context);
 


        private GnrRptGroupsRepository _GnrRptGroupsRepository;
        
        public IGnrRptGroupsRepository GnrRptGroupsRepository => _GnrRptGroupsRepository = _GnrRptGroupsRepository ?? new GnrRptGroupsRepository(_context);
 


        private GnrSysFormObjectsRepository _GnrSysFormObjectsRepository;
        
        public IGnrSysFormObjectsRepository GnrSysFormObjectsRepository => _GnrSysFormObjectsRepository = _GnrSysFormObjectsRepository ?? new GnrSysFormObjectsRepository(_context);
 


        private GnrSysFormsRepository _GnrSysFormsRepository;
        
        public IGnrSysFormsRepository GnrSysFormsRepository => _GnrSysFormsRepository = _GnrSysFormsRepository ?? new GnrSysFormsRepository(_context);
 


        private GnrSysLogsRepository _GnrSysLogsRepository;
        
        public IGnrSysLogsRepository GnrSysLogsRepository => _GnrSysLogsRepository = _GnrSysLogsRepository ?? new GnrSysLogsRepository(_context);
 


        private GnrSysMsgRepository _GnrSysMsgRepository;
        
        public IGnrSysMsgRepository GnrSysMsgRepository => _GnrSysMsgRepository = _GnrSysMsgRepository ?? new GnrSysMsgRepository(_context);
 


        private GnrSysMsgDetRepository _GnrSysMsgDetRepository;
        
        public IGnrSysMsgDetRepository GnrSysMsgDetRepository => _GnrSysMsgDetRepository = _GnrSysMsgDetRepository ?? new GnrSysMsgDetRepository(_context);
 


        private GnrSysQryFieldsRepository _GnrSysQryFieldsRepository;
        
        public IGnrSysQryFieldsRepository GnrSysQryFieldsRepository => _GnrSysQryFieldsRepository = _GnrSysQryFieldsRepository ?? new GnrSysQryFieldsRepository(_context);
 


        private GnrSysQuerysRepository _GnrSysQuerysRepository;
        
        public IGnrSysQuerysRepository GnrSysQuerysRepository => _GnrSysQuerysRepository = _GnrSysQuerysRepository ?? new GnrSysQuerysRepository(_context);
 


        private GnrSysTablesRepository _GnrSysTablesRepository;
        
        public IGnrSysTablesRepository GnrSysTablesRepository => _GnrSysTablesRepository = _GnrSysTablesRepository ?? new GnrSysTablesRepository(_context);
 


        private GnrTableRelationRepository _GnrTableRelationRepository;
        
        public IGnrTableRelationRepository GnrTableRelationRepository => _GnrTableRelationRepository = _GnrTableRelationRepository ?? new GnrTableRelationRepository(_context);
 


        private GnrTablesDetRepository _GnrTablesDetRepository;
        
        public IGnrTablesDetRepository GnrTablesDetRepository => _GnrTablesDetRepository = _GnrTablesDetRepository ?? new GnrTablesDetRepository(_context);
 


        private GnrTablesInfRepository _GnrTablesInfRepository;
        
        public IGnrTablesInfRepository GnrTablesInfRepository => _GnrTablesInfRepository = _GnrTablesInfRepository ?? new GnrTablesInfRepository(_context);
 


        private GnrToolsRepository _GnrToolsRepository;
        
        public IGnrToolsRepository GnrToolsRepository => _GnrToolsRepository = _GnrToolsRepository ?? new GnrToolsRepository(_context);
 


        private GnrUFCtgryRepository _GnrUFCtgryRepository;
        
        public IGnrUFCtgryRepository GnrUFCtgryRepository => _GnrUFCtgryRepository = _GnrUFCtgryRepository ?? new GnrUFCtgryRepository(_context);
 


        private GnrUserAlarmsRepository _GnrUserAlarmsRepository;
        
        public IGnrUserAlarmsRepository GnrUserAlarmsRepository => _GnrUserAlarmsRepository = _GnrUserAlarmsRepository ?? new GnrUserAlarmsRepository(_context);
 


        private GnrUserFieldRepository _GnrUserFieldRepository;
        
        public IGnrUserFieldRepository GnrUserFieldRepository => _GnrUserFieldRepository = _GnrUserFieldRepository ?? new GnrUserFieldRepository(_context);
 


        private GnrUserFormDesignRepository _GnrUserFormDesignRepository;
        
        public IGnrUserFormDesignRepository GnrUserFormDesignRepository => _GnrUserFormDesignRepository = _GnrUserFormDesignRepository ?? new GnrUserFormDesignRepository(_context);
 


        private GnrUserFormOprsRepository _GnrUserFormOprsRepository;
        
        public IGnrUserFormOprsRepository GnrUserFormOprsRepository => _GnrUserFormOprsRepository = _GnrUserFormOprsRepository ?? new GnrUserFormOprsRepository(_context);
 


        private GnrUserFormsRepository _GnrUserFormsRepository;
        
        public IGnrUserFormsRepository GnrUserFormsRepository => _GnrUserFormsRepository = _GnrUserFormsRepository ?? new GnrUserFormsRepository(_context);
 


        private GnrUserLabelsRepository _GnrUserLabelsRepository;
        
        public IGnrUserLabelsRepository GnrUserLabelsRepository => _GnrUserLabelsRepository = _GnrUserLabelsRepository ?? new GnrUserLabelsRepository(_context);
 


        private GnrUserLogRepository _GnrUserLogRepository;
        
        public IGnrUserLogRepository GnrUserLogRepository => _GnrUserLogRepository = _GnrUserLogRepository ?? new GnrUserLogRepository(_context);
 


        private GnrUserMsgRepository _GnrUserMsgRepository;
        
        public IGnrUserMsgRepository GnrUserMsgRepository => _GnrUserMsgRepository = _GnrUserMsgRepository ?? new GnrUserMsgRepository(_context);
 


        private GnrUserRefListRepository _GnrUserRefListRepository;
        
        public IGnrUserRefListRepository GnrUserRefListRepository => _GnrUserRefListRepository = _GnrUserRefListRepository ?? new GnrUserRefListRepository(_context);
 


        private GnrUserRefListDetRepository _GnrUserRefListDetRepository;
        
        public IGnrUserRefListDetRepository GnrUserRefListDetRepository => _GnrUserRefListDetRepository = _GnrUserRefListDetRepository ?? new GnrUserRefListDetRepository(_context);
 


        private GnrUserRoleRepository _GnrUserRoleRepository;
        
        public IGnrUserRoleRepository GnrUserRoleRepository => _GnrUserRoleRepository = _GnrUserRoleRepository ?? new GnrUserRoleRepository(_context);
 


        private GnrUserStorageRepository _GnrUserStorageRepository;
        
        public IGnrUserStorageRepository GnrUserStorageRepository => _GnrUserStorageRepository = _GnrUserStorageRepository ?? new GnrUserStorageRepository(_context);
 


        private GnrValidDataRepository _GnrValidDataRepository;
        
        public IGnrValidDataRepository GnrValidDataRepository => _GnrValidDataRepository = _GnrValidDataRepository ?? new GnrValidDataRepository(_context);
 


        private GeoPosRepository _GeoPosRepository;
        
        public IGeoPosRepository GeoPosRepository => _GeoPosRepository = _GeoPosRepository ?? new GeoPosRepository(_context);
 


        private AddressRepository _AddressRepository;
        
        public IAddressRepository AddressRepository => _AddressRepository = _AddressRepository ?? new AddressRepository(_context);
 


        private CrspndsRepository _CrspndsRepository;
        
        public ICrspndsRepository CrspndsRepository => _CrspndsRepository = _CrspndsRepository ?? new CrspndsRepository(_context);
 


        private LookupsRepository _LookupsRepository;
        
        public ILookupsRepository LookupsRepository => _LookupsRepository = _LookupsRepository ?? new LookupsRepository(_context);
 


        private SettingsRepository _SettingsRepository;
        
        public ISettingsRepository SettingsRepository => _SettingsRepository = _SettingsRepository ?? new SettingsRepository(_context);
 


        private sysdiagramsRepository _sysdiagramsRepository;
        
        public IsysdiagramsRepository sysdiagramsRepository => _sysdiagramsRepository = _sysdiagramsRepository ?? new sysdiagramsRepository(_context);
 


        private TablesLastIdRepository _TablesLastIdRepository;
        
        public ITablesLastIdRepository TablesLastIdRepository => _TablesLastIdRepository = _TablesLastIdRepository ?? new TablesLastIdRepository(_context);
 


        private TaxDutyInfRepository _TaxDutyInfRepository;
        
        public ITaxDutyInfRepository TaxDutyInfRepository => _TaxDutyInfRepository = _TaxDutyInfRepository ?? new TaxDutyInfRepository(_context);
 


        private UnitsRepository _UnitsRepository;
        
        public IUnitsRepository UnitsRepository => _UnitsRepository = _UnitsRepository ?? new UnitsRepository(_context);
 


        private ElementRolesRepository _ElementRolesRepository;
        
        public IElementRolesRepository ElementRolesRepository => _ElementRolesRepository = _ElementRolesRepository ?? new ElementRolesRepository(_context);
 


        private ElementsRepository _ElementsRepository;
        
        public IElementsRepository ElementsRepository => _ElementsRepository = _ElementsRepository ?? new ElementsRepository(_context);
 


        private ElmntMethodRepository _ElmntMethodRepository;
        
        public IElmntMethodRepository ElmntMethodRepository => _ElmntMethodRepository = _ElmntMethodRepository ?? new ElmntMethodRepository(_context);
 


        private ElmntMethodRolesRepository _ElmntMethodRolesRepository;
        
        public IElmntMethodRolesRepository ElmntMethodRolesRepository => _ElmntMethodRolesRepository = _ElmntMethodRolesRepository ?? new ElmntMethodRolesRepository(_context);
 


        private CurExChangeRepository _CurExChangeRepository;
        
        public ICurExChangeRepository CurExChangeRepository => _CurExChangeRepository = _CurExChangeRepository ?? new CurExChangeRepository(_context);
 


        private CurrencyRepository _CurrencyRepository;
        
        public ICurrencyRepository CurrencyRepository => _CurrencyRepository = _CurrencyRepository ?? new CurrencyRepository(_context);
 


        private CostCentersRepository _CostCentersRepository;
        
        public ICostCentersRepository CostCentersRepository => _CostCentersRepository = _CostCentersRepository ?? new CostCentersRepository(_context);
 


        private CstAccDataRepository _CstAccDataRepository;
        
        public ICstAccDataRepository CstAccDataRepository => _CstAccDataRepository = _CstAccDataRepository ?? new CstAccDataRepository(_context);
 


        private CstAccRelInfRepository _CstAccRelInfRepository;
        
        public ICstAccRelInfRepository CstAccRelInfRepository => _CstAccRelInfRepository = _CstAccRelInfRepository ?? new CstAccRelInfRepository(_context);
 


        private CstCostAllocDetRepository _CstCostAllocDetRepository;
        
        public ICstCostAllocDetRepository CstCostAllocDetRepository => _CstCostAllocDetRepository = _CstCostAllocDetRepository ?? new CstCostAllocDetRepository(_context);
 


        private CstCostCntrAllocRepository _CstCostCntrAllocRepository;
        
        public ICstCostCntrAllocRepository CstCostCntrAllocRepository => _CstCostCntrAllocRepository = _CstCostCntrAllocRepository ?? new CstCostCntrAllocRepository(_context);
 


        private CstCostCntrAllocSValsRepository _CstCostCntrAllocSValsRepository;
        
        public ICstCostCntrAllocSValsRepository CstCostCntrAllocSValsRepository => _CstCostCntrAllocSValsRepository = _CstCostCntrAllocSValsRepository ?? new CstCostCntrAllocSValsRepository(_context);
 


        private CstCostCntrAllocValsRepository _CstCostCntrAllocValsRepository;
        
        public ICstCostCntrAllocValsRepository CstCostCntrAllocValsRepository => _CstCostCntrAllocValsRepository = _CstCostCntrAllocValsRepository ?? new CstCostCntrAllocValsRepository(_context);
 


        private CstCostCntrElmntRoleRepository _CstCostCntrElmntRoleRepository;
        
        public ICstCostCntrElmntRoleRepository CstCostCntrElmntRoleRepository => _CstCostCntrElmntRoleRepository = _CstCostCntrElmntRoleRepository ?? new CstCostCntrElmntRoleRepository(_context);
 


        private CstCostCntrElmntValsRepository _CstCostCntrElmntValsRepository;
        
        public ICstCostCntrElmntValsRepository CstCostCntrElmntValsRepository => _CstCostCntrElmntValsRepository = _CstCostCntrElmntValsRepository ?? new CstCostCntrElmntValsRepository(_context);
 


        private CstCostCntrFillRepository _CstCostCntrFillRepository;
        
        public ICstCostCntrFillRepository CstCostCntrFillRepository => _CstCostCntrFillRepository = _CstCostCntrFillRepository ?? new CstCostCntrFillRepository(_context);
 


        private CstCostCntrRoleValsRepository _CstCostCntrRoleValsRepository;
        
        public ICstCostCntrRoleValsRepository CstCostCntrRoleValsRepository => _CstCostCntrRoleValsRepository = _CstCostCntrRoleValsRepository ?? new CstCostCntrRoleValsRepository(_context);
 


        private CstElementsRepository _CstElementsRepository;
        
        public ICstElementsRepository CstElementsRepository => _CstElementsRepository = _CstElementsRepository ?? new CstElementsRepository(_context);
 


        private CstElmntRolesRepository _CstElmntRolesRepository;
        
        public ICstElmntRolesRepository CstElmntRolesRepository => _CstElmntRolesRepository = _CstElmntRolesRepository ?? new CstElmntRolesRepository(_context);
 


        private CstMatDurQtyRepository _CstMatDurQtyRepository;
        
        public ICstMatDurQtyRepository CstMatDurQtyRepository => _CstMatDurQtyRepository = _CstMatDurQtyRepository ?? new CstMatDurQtyRepository(_context);
 


        private CstMatQtyRepository _CstMatQtyRepository;
        
        public ICstMatQtyRepository CstMatQtyRepository => _CstMatQtyRepository = _CstMatQtyRepository ?? new CstMatQtyRepository(_context);
 


        private CstMatStdInfRepository _CstMatStdInfRepository;
        
        public ICstMatStdInfRepository CstMatStdInfRepository => _CstMatStdInfRepository = _CstMatStdInfRepository ?? new CstMatStdInfRepository(_context);
 


        private CstMatWastRepository _CstMatWastRepository;
        
        public ICstMatWastRepository CstMatWastRepository => _CstMatWastRepository = _CstMatWastRepository ?? new CstMatWastRepository(_context);
 


        private CstPeriodsRepository _CstPeriodsRepository;
        
        public ICstPeriodsRepository CstPeriodsRepository => _CstPeriodsRepository = _CstPeriodsRepository ?? new CstPeriodsRepository(_context);
 


        private CstProdDurQtyRepository _CstProdDurQtyRepository;
        
        public ICstProdDurQtyRepository CstProdDurQtyRepository => _CstProdDurQtyRepository = _CstProdDurQtyRepository ?? new CstProdDurQtyRepository(_context);
 


        private CstProduceInfRepository _CstProduceInfRepository;
        
        public ICstProduceInfRepository CstProduceInfRepository => _CstProduceInfRepository = _CstProduceInfRepository ?? new CstProduceInfRepository(_context);
 


        private CstProductPackageRepository _CstProductPackageRepository;
        
        public ICstProductPackageRepository CstProductPackageRepository => _CstProductPackageRepository = _CstProductPackageRepository ?? new CstProductPackageRepository(_context);
 


        private CstProductPackDetRepository _CstProductPackDetRepository;
        
        public ICstProductPackDetRepository CstProductPackDetRepository => _CstProductPackDetRepository = _CstProductPackDetRepository ?? new CstProductPackDetRepository(_context);
 


        private CstProductVchRepository _CstProductVchRepository;
        
        public ICstProductVchRepository CstProductVchRepository => _CstProductVchRepository = _CstProductVchRepository ?? new CstProductVchRepository(_context);
 


        private CstRealCalcRepository _CstRealCalcRepository;
        
        public ICstRealCalcRepository CstRealCalcRepository => _CstRealCalcRepository = _CstRealCalcRepository ?? new CstRealCalcRepository(_context);
 


        private CstStdAccDataRepository _CstStdAccDataRepository;
        
        public ICstStdAccDataRepository CstStdAccDataRepository => _CstStdAccDataRepository = _CstStdAccDataRepository ?? new CstStdAccDataRepository(_context);
 


        private CstStdCalcRepository _CstStdCalcRepository;
        
        public ICstStdCalcRepository CstStdCalcRepository => _CstStdCalcRepository = _CstStdCalcRepository ?? new CstStdCalcRepository(_context);
 


        private CntAccRelsRepository _CntAccRelsRepository;
        
        public ICntAccRelsRepository CntAccRelsRepository => _CntAccRelsRepository = _CntAccRelsRepository ?? new CntAccRelsRepository(_context);
 


        private CntAccVchTypesRepository _CntAccVchTypesRepository;
        
        public ICntAccVchTypesRepository CntAccVchTypesRepository => _CntAccVchTypesRepository = _CntAccVchTypesRepository ?? new CntAccVchTypesRepository(_context);
 


        private CntAcquitInfsRepository _CntAcquitInfsRepository;
        
        public ICntAcquitInfsRepository CntAcquitInfsRepository => _CntAcquitInfsRepository = _CntAcquitInfsRepository ?? new CntAcquitInfsRepository(_context);
 


        private CntAgreementRepository _CntAgreementRepository;
        
        public ICntAgreementRepository CntAgreementRepository => _CntAgreementRepository = _CntAgreementRepository ?? new CntAgreementRepository(_context);
 


        private CntAmntCurInfRepository _CntAmntCurInfRepository;
        
        public ICntAmntCurInfRepository CntAmntCurInfRepository => _CntAmntCurInfRepository = _CntAmntCurInfRepository ?? new CntAmntCurInfRepository(_context);
 


        private CntAmntTypesRepository _CntAmntTypesRepository;
        
        public ICntAmntTypesRepository CntAmntTypesRepository => _CntAmntTypesRepository = _CntAmntTypesRepository ?? new CntAmntTypesRepository(_context);
 


        private CntCMthdFldsRepository _CntCMthdFldsRepository;
        
        public ICntCMthdFldsRepository CntCMthdFldsRepository => _CntCMthdFldsRepository = _CntCMthdFldsRepository ?? new CntCMthdFldsRepository(_context);
 


        private CntContAgrValsRepository _CntContAgrValsRepository;
        
        public ICntContAgrValsRepository CntContAgrValsRepository => _CntContAgrValsRepository = _CntContAgrValsRepository ?? new CntContAgrValsRepository(_context);
 


        private CntContAmntChngRepository _CntContAmntChngRepository;
        
        public ICntContAmntChngRepository CntContAmntChngRepository => _CntContAmntChngRepository = _CntContAmntChngRepository ?? new CntContAmntChngRepository(_context);
 


        private CntContDetRepository _CntContDetRepository;
        
        public ICntContDetRepository CntContDetRepository => _CntContDetRepository = _CntContDetRepository ?? new CntContDetRepository(_context);
 


        private CntContElmntRepository _CntContElmntRepository;
        
        public ICntContElmntRepository CntContElmntRepository => _CntContElmntRepository = _CntContElmntRepository ?? new CntContElmntRepository(_context);
 


        private CntContractorsRepository _CntContractorsRepository;
        
        public ICntContractorsRepository CntContractorsRepository => _CntContractorsRepository = _CntContractorsRepository ?? new CntContractorsRepository(_context);
 


        private CntContractsRepository _CntContractsRepository;
        
        public ICntContractsRepository CntContractsRepository => _CntContractsRepository = _CntContractsRepository ?? new CntContractsRepository(_context);
 


        private CntContRatioRepository _CntContRatioRepository;
        
        public ICntContRatioRepository CntContRatioRepository => _CntContRatioRepository = _CntContRatioRepository ?? new CntContRatioRepository(_context);
 


        private CntContrLimitRepository _CntContrLimitRepository;
        
        public ICntContrLimitRepository CntContrLimitRepository => _CntContrLimitRepository = _CntContrLimitRepository ?? new CntContrLimitRepository(_context);
 


        private CntContTextRepository _CntContTextRepository;
        
        public ICntContTextRepository CntContTextRepository => _CntContTextRepository = _CntContTextRepository ?? new CntContTextRepository(_context);
 


        private CntCrsDocumentRepository _CntCrsDocumentRepository;
        
        public ICntCrsDocumentRepository CntCrsDocumentRepository => _CntCrsDocumentRepository = _CntCrsDocumentRepository ?? new CntCrsDocumentRepository(_context);
 


        private CntDeliveryInfRepository _CntDeliveryInfRepository;
        
        public ICntDeliveryInfRepository CntDeliveryInfRepository => _CntDeliveryInfRepository = _CntDeliveryInfRepository ?? new CntDeliveryInfRepository(_context);
 


        private CntExpAccntRelsRepository _CntExpAccntRelsRepository;
        
        public ICntExpAccntRelsRepository CntExpAccntRelsRepository => _CntExpAccntRelsRepository = _CntExpAccntRelsRepository ?? new CntExpAccntRelsRepository(_context);
 


        private CntExpAcntCostCntrRepository _CntExpAcntCostCntrRepository;
        
        public ICntExpAcntCostCntrRepository CntExpAcntCostCntrRepository => _CntExpAcntCostCntrRepository = _CntExpAcntCostCntrRepository ?? new CntExpAcntCostCntrRepository(_context);
 


        private CntExpAcntDataRepository _CntExpAcntDataRepository;
        
        public ICntExpAcntDataRepository CntExpAcntDataRepository => _CntExpAcntDataRepository = _CntExpAcntDataRepository ?? new CntExpAcntDataRepository(_context);
 


        private CntExpAcntDetRepository _CntExpAcntDetRepository;
        
        public ICntExpAcntDetRepository CntExpAcntDetRepository => _CntExpAcntDetRepository = _CntExpAcntDetRepository ?? new CntExpAcntDetRepository(_context);
 


        private CntExpAcntFldsRepository _CntExpAcntFldsRepository;
        
        public ICntExpAcntFldsRepository CntExpAcntFldsRepository => _CntExpAcntFldsRepository = _CntExpAcntFldsRepository ?? new CntExpAcntFldsRepository(_context);
 


        private CntExpAcntValsRepository _CntExpAcntValsRepository;
        
        public ICntExpAcntValsRepository CntExpAcntValsRepository => _CntExpAcntValsRepository = _CntExpAcntValsRepository ?? new CntExpAcntValsRepository(_context);
 


        private CntExpFldElmntsRepository _CntExpFldElmntsRepository;
        
        public ICntExpFldElmntsRepository CntExpFldElmntsRepository => _CntExpFldElmntsRepository = _CntExpFldElmntsRepository ?? new CntExpFldElmntsRepository(_context);
 


        private CntExpnsAccntsRepository _CntExpnsAccntsRepository;
        
        public ICntExpnsAccntsRepository CntExpnsAccntsRepository => _CntExpnsAccntsRepository = _CntExpnsAccntsRepository ?? new CntExpnsAccntsRepository(_context);
 


        private CntExtendInfRepository _CntExtendInfRepository;
        
        public ICntExtendInfRepository CntExtendInfRepository => _CntExtendInfRepository = _CntExtendInfRepository ?? new CntExtendInfRepository(_context);
 


        private CntFormFieldsRepository _CntFormFieldsRepository;
        
        public ICntFormFieldsRepository CntFormFieldsRepository => _CntFormFieldsRepository = _CntFormFieldsRepository ?? new CntFormFieldsRepository(_context);
 


        private CntFormValsRepository _CntFormValsRepository;
        
        public ICntFormValsRepository CntFormValsRepository => _CntFormValsRepository = _CntFormValsRepository ?? new CntFormValsRepository(_context);
 


        private CntGaurantInfRepository _CntGaurantInfRepository;
        
        public ICntGaurantInfRepository CntGaurantInfRepository => _CntGaurantInfRepository = _CntGaurantInfRepository ?? new CntGaurantInfRepository(_context);
 


        private CntGnrTextRepository _CntGnrTextRepository;
        
        public ICntGnrTextRepository CntGnrTextRepository => _CntGnrTextRepository = _CntGnrTextRepository ?? new CntGnrTextRepository(_context);
 


        private CntInvoiceDetRepository _CntInvoiceDetRepository;
        
        public ICntInvoiceDetRepository CntInvoiceDetRepository => _CntInvoiceDetRepository = _CntInvoiceDetRepository ?? new CntInvoiceDetRepository(_context);
 


        private CntInvoiceHdrRepository _CntInvoiceHdrRepository;
        
        public ICntInvoiceHdrRepository CntInvoiceHdrRepository => _CntInvoiceHdrRepository = _CntInvoiceHdrRepository ?? new CntInvoiceHdrRepository(_context);
 


        private CntInvoiceNotesRepository _CntInvoiceNotesRepository;
        
        public ICntInvoiceNotesRepository CntInvoiceNotesRepository => _CntInvoiceNotesRepository = _CntInvoiceNotesRepository ?? new CntInvoiceNotesRepository(_context);
 


        private CntInvoiceRelsRepository _CntInvoiceRelsRepository;
        
        public ICntInvoiceRelsRepository CntInvoiceRelsRepository => _CntInvoiceRelsRepository = _CntInvoiceRelsRepository ?? new CntInvoiceRelsRepository(_context);
 


        private CntMasterFactDataRepository _CntMasterFactDataRepository;
        
        public ICntMasterFactDataRepository CntMasterFactDataRepository => _CntMasterFactDataRepository = _CntMasterFactDataRepository ?? new CntMasterFactDataRepository(_context);
 


        private CntMasterFactorRepository _CntMasterFactorRepository;
        
        public ICntMasterFactorRepository CntMasterFactorRepository => _CntMasterFactorRepository = _CntMasterFactorRepository ?? new CntMasterFactorRepository(_context);
 


        private CntMasterFactValRepository _CntMasterFactValRepository;
        
        public ICntMasterFactValRepository CntMasterFactValRepository => _CntMasterFactValRepository = _CntMasterFactValRepository ?? new CntMasterFactValRepository(_context);
 


        private CntMastersRepository _CntMastersRepository;
        
        public ICntMastersRepository CntMastersRepository => _CntMastersRepository = _CntMastersRepository ?? new CntMastersRepository(_context);
 


        private CntSrvItemsRepository _CntSrvItemsRepository;
        
        public ICntSrvItemsRepository CntSrvItemsRepository => _CntSrvItemsRepository = _CntSrvItemsRepository ?? new CntSrvItemsRepository(_context);
 


        private CntSrvPrcHdrRepository _CntSrvPrcHdrRepository;
        
        public ICntSrvPrcHdrRepository CntSrvPrcHdrRepository => _CntSrvPrcHdrRepository = _CntSrvPrcHdrRepository ?? new CntSrvPrcHdrRepository(_context);
 


        private CntSrvPrcItmRepository _CntSrvPrcItmRepository;
        
        public ICntSrvPrcItmRepository CntSrvPrcItmRepository => _CntSrvPrcItmRepository = _CntSrvPrcItmRepository ?? new CntSrvPrcItmRepository(_context);
 


        private CmrContHdrRepository _CmrContHdrRepository;
        
        public ICmrContHdrRepository CmrContHdrRepository => _CmrContHdrRepository = _CmrContHdrRepository ?? new CmrContHdrRepository(_context);
 


        private CmrContItmRepository _CmrContItmRepository;
        
        public ICmrContItmRepository CmrContItmRepository => _CmrContItmRepository = _CmrContItmRepository ?? new CmrContItmRepository(_context);
 


        private CmrFactHdrRepository _CmrFactHdrRepository;
        
        public ICmrFactHdrRepository CmrFactHdrRepository => _CmrFactHdrRepository = _CmrFactHdrRepository ?? new CmrFactHdrRepository(_context);
 


        private CmrFactItmRepository _CmrFactItmRepository;
        
        public ICmrFactItmRepository CmrFactItmRepository => _CmrFactItmRepository = _CmrFactItmRepository ?? new CmrFactItmRepository(_context);
 


        private CmrInsuranceRepository _CmrInsuranceRepository;
        
        public ICmrInsuranceRepository CmrInsuranceRepository => _CmrInsuranceRepository = _CmrInsuranceRepository ?? new CmrInsuranceRepository(_context);
 


        private CmrInvoiceCostRepository _CmrInvoiceCostRepository;
        
        public ICmrInvoiceCostRepository CmrInvoiceCostRepository => _CmrInvoiceCostRepository = _CmrInvoiceCostRepository ?? new CmrInvoiceCostRepository(_context);
 


        private CmrInvoiceHdrRepository _CmrInvoiceHdrRepository;
        
        public ICmrInvoiceHdrRepository CmrInvoiceHdrRepository => _CmrInvoiceHdrRepository = _CmrInvoiceHdrRepository ?? new CmrInvoiceHdrRepository(_context);
 


        private CmrInvoiceItmRepository _CmrInvoiceItmRepository;
        
        public ICmrInvoiceItmRepository CmrInvoiceItmRepository => _CmrInvoiceItmRepository = _CmrInvoiceItmRepository ?? new CmrInvoiceItmRepository(_context);
 


        private CmrLCRepository _CmrLCRepository;
        
        public ICmrLCRepository CmrLCRepository => _CmrLCRepository = _CmrLCRepository ?? new CmrLCRepository(_context);
 


        private CmrLCDetRepository _CmrLCDetRepository;
        
        public ICmrLCDetRepository CmrLCDetRepository => _CmrLCDetRepository = _CmrLCDetRepository ?? new CmrLCDetRepository(_context);
 


        private CmrOrdHdrRepository _CmrOrdHdrRepository;
        
        public ICmrOrdHdrRepository CmrOrdHdrRepository => _CmrOrdHdrRepository = _CmrOrdHdrRepository ?? new CmrOrdHdrRepository(_context);
 


        private CmrOrdItmRepository _CmrOrdItmRepository;
        
        public ICmrOrdItmRepository CmrOrdItmRepository => _CmrOrdItmRepository = _CmrOrdItmRepository ?? new CmrOrdItmRepository(_context);
 


        private CmrOrdSellerRepository _CmrOrdSellerRepository;
        
        public ICmrOrdSellerRepository CmrOrdSellerRepository => _CmrOrdSellerRepository = _CmrOrdSellerRepository ?? new CmrOrdSellerRepository(_context);
 


        private CmrPersRepository _CmrPersRepository;
        
        public ICmrPersRepository CmrPersRepository => _CmrPersRepository = _CmrPersRepository ?? new CmrPersRepository(_context);
 


        private CmrPOrderHdrRepository _CmrPOrderHdrRepository;
        
        public ICmrPOrderHdrRepository CmrPOrderHdrRepository => _CmrPOrderHdrRepository = _CmrPOrderHdrRepository ?? new CmrPOrderHdrRepository(_context);
 


        private CmrPOrderItmRepository _CmrPOrderItmRepository;
        
        public ICmrPOrderItmRepository CmrPOrderItmRepository => _CmrPOrderItmRepository = _CmrPOrderItmRepository ?? new CmrPOrderItmRepository(_context);
 


        private CmrPreFactHdrRepository _CmrPreFactHdrRepository;
        
        public ICmrPreFactHdrRepository CmrPreFactHdrRepository => _CmrPreFactHdrRepository = _CmrPreFactHdrRepository ?? new CmrPreFactHdrRepository(_context);
 


        private CmrPreFactItmRepository _CmrPreFactItmRepository;
        
        public ICmrPreFactItmRepository CmrPreFactItmRepository => _CmrPreFactItmRepository = _CmrPreFactItmRepository ?? new CmrPreFactItmRepository(_context);
 


        private CmrRegisterRepository _CmrRegisterRepository;
        
        public ICmrRegisterRepository CmrRegisterRepository => _CmrRegisterRepository = _CmrRegisterRepository ?? new CmrRegisterRepository(_context);
 


        private CmrReleaseCostRepository _CmrReleaseCostRepository;
        
        public ICmrReleaseCostRepository CmrReleaseCostRepository => _CmrReleaseCostRepository = _CmrReleaseCostRepository ?? new CmrReleaseCostRepository(_context);
 


        private CmrReleaseHdrRepository _CmrReleaseHdrRepository;
        
        public ICmrReleaseHdrRepository CmrReleaseHdrRepository => _CmrReleaseHdrRepository = _CmrReleaseHdrRepository ?? new CmrReleaseHdrRepository(_context);
 


        private CmrReleaseItmRepository _CmrReleaseItmRepository;
        
        public ICmrReleaseItmRepository CmrReleaseItmRepository => _CmrReleaseItmRepository = _CmrReleaseItmRepository ?? new CmrReleaseItmRepository(_context);
 


        private CmrReleaseStockRepository _CmrReleaseStockRepository;
        
        public ICmrReleaseStockRepository CmrReleaseStockRepository => _CmrReleaseStockRepository = _CmrReleaseStockRepository ?? new CmrReleaseStockRepository(_context);
 


        private CmrRqstHdrRepository _CmrRqstHdrRepository;
        
        public ICmrRqstHdrRepository CmrRqstHdrRepository => _CmrRqstHdrRepository = _CmrRqstHdrRepository ?? new CmrRqstHdrRepository(_context);
 


        private CmrRqstItmRepository _CmrRqstItmRepository;
        
        public ICmrRqstItmRepository CmrRqstItmRepository => _CmrRqstItmRepository = _CmrRqstItmRepository ?? new CmrRqstItmRepository(_context);
 


        private CmrSellerGrpRepository _CmrSellerGrpRepository;
        
        public ICmrSellerGrpRepository CmrSellerGrpRepository => _CmrSellerGrpRepository = _CmrSellerGrpRepository ?? new CmrSellerGrpRepository(_context);
 


        private CmrSellersRepository _CmrSellersRepository;
        
        public ICmrSellersRepository CmrSellersRepository => _CmrSellersRepository = _CmrSellersRepository ?? new CmrSellersRepository(_context);
 


        private CmrSendHdrRepository _CmrSendHdrRepository;
        
        public ICmrSendHdrRepository CmrSendHdrRepository => _CmrSendHdrRepository = _CmrSendHdrRepository ?? new CmrSendHdrRepository(_context);
 


        private CmrSendItmRepository _CmrSendItmRepository;
        
        public ICmrSendItmRepository CmrSendItmRepository => _CmrSendItmRepository = _CmrSendItmRepository ?? new CmrSendItmRepository(_context);
 


        private CmrServicesRepository _CmrServicesRepository;
        
        public ICmrServicesRepository CmrServicesRepository => _CmrServicesRepository = _CmrServicesRepository ?? new CmrServicesRepository(_context);
 


        private CmrTransportRepository _CmrTransportRepository;
        
        public ICmrTransportRepository CmrTransportRepository => _CmrTransportRepository = _CmrTransportRepository ?? new CmrTransportRepository(_context);
 


        private CmrTransportDetRepository _CmrTransportDetRepository;
        
        public ICmrTransportDetRepository CmrTransportDetRepository => _CmrTransportDetRepository = _CmrTransportDetRepository ?? new CmrTransportDetRepository(_context);
 


        private BdgAssetsRepository _BdgAssetsRepository;
        
        public IBdgAssetsRepository BdgAssetsRepository => _BdgAssetsRepository = _BdgAssetsRepository ?? new BdgAssetsRepository(_context);
 


        private BdgAssetsDetRepository _BdgAssetsDetRepository;
        
        public IBdgAssetsDetRepository BdgAssetsDetRepository => _BdgAssetsDetRepository = _BdgAssetsDetRepository ?? new BdgAssetsDetRepository(_context);
 


        private BdgBalanceValRepository _BdgBalanceValRepository;
        
        public IBdgBalanceValRepository BdgBalanceValRepository => _BdgBalanceValRepository = _BdgBalanceValRepository ?? new BdgBalanceValRepository(_context);
 


        private BdgBalanceValsDetRepository _BdgBalanceValsDetRepository;
        
        public IBdgBalanceValsDetRepository BdgBalanceValsDetRepository => _BdgBalanceValsDetRepository = _BdgBalanceValsDetRepository ?? new BdgBalanceValsDetRepository(_context);
 


        private BdgContAccRepository _BdgContAccRepository;
        
        public IBdgContAccRepository BdgContAccRepository => _BdgContAccRepository = _BdgContAccRepository ?? new BdgContAccRepository(_context);
 


        private BdgContAccDetRepository _BdgContAccDetRepository;
        
        public IBdgContAccDetRepository BdgContAccDetRepository => _BdgContAccDetRepository = _BdgContAccDetRepository ?? new BdgContAccDetRepository(_context);
 


        private BdgContsRepository _BdgContsRepository;
        
        public IBdgContsRepository BdgContsRepository => _BdgContsRepository = _BdgContsRepository ?? new BdgContsRepository(_context);
 


        private BdgCostAllocDetRepository _BdgCostAllocDetRepository;
        
        public IBdgCostAllocDetRepository BdgCostAllocDetRepository => _BdgCostAllocDetRepository = _BdgCostAllocDetRepository ?? new BdgCostAllocDetRepository(_context);
 


        private BdgCostCntrAllocRepository _BdgCostCntrAllocRepository;
        
        public IBdgCostCntrAllocRepository BdgCostCntrAllocRepository => _BdgCostCntrAllocRepository = _BdgCostCntrAllocRepository ?? new BdgCostCntrAllocRepository(_context);
 


        private BdgCostCntrRoleValsRepository _BdgCostCntrRoleValsRepository;
        
        public IBdgCostCntrRoleValsRepository BdgCostCntrRoleValsRepository => _BdgCostCntrRoleValsRepository = _BdgCostCntrRoleValsRepository ?? new BdgCostCntrRoleValsRepository(_context);
 


        private BdgCurExchangeRepository _BdgCurExchangeRepository;
        
        public IBdgCurExchangeRepository BdgCurExchangeRepository => _BdgCurExchangeRepository = _BdgCurExchangeRepository ?? new BdgCurExchangeRepository(_context);
 


        private BdgElementsRepository _BdgElementsRepository;
        
        public IBdgElementsRepository BdgElementsRepository => _BdgElementsRepository = _BdgElementsRepository ?? new BdgElementsRepository(_context);
 


        private BdgElmntRolesRepository _BdgElmntRolesRepository;
        
        public IBdgElmntRolesRepository BdgElmntRolesRepository => _BdgElmntRolesRepository = _BdgElmntRolesRepository ?? new BdgElmntRolesRepository(_context);
 


        private BdgElmntValRepository _BdgElmntValRepository;
        
        public IBdgElmntValRepository BdgElmntValRepository => _BdgElmntValRepository = _BdgElmntValRepository ?? new BdgElmntValRepository(_context);
 


        private BdgElmntValsDetRepository _BdgElmntValsDetRepository;
        
        public IBdgElmntValsDetRepository BdgElmntValsDetRepository => _BdgElmntValsDetRepository = _BdgElmntValsDetRepository ?? new BdgElmntValsDetRepository(_context);
 


        private BdgFinalRepRepository _BdgFinalRepRepository;
        
        public IBdgFinalRepRepository BdgFinalRepRepository => _BdgFinalRepRepository = _BdgFinalRepRepository ?? new BdgFinalRepRepository(_context);
 


        private BdgHrmBaseRepository _BdgHrmBaseRepository;
        
        public IBdgHrmBaseRepository BdgHrmBaseRepository => _BdgHrmBaseRepository = _BdgHrmBaseRepository ?? new BdgHrmBaseRepository(_context);
 


        private BdgHrmValsRepository _BdgHrmValsRepository;
        
        public IBdgHrmValsRepository BdgHrmValsRepository => _BdgHrmValsRepository = _BdgHrmValsRepository ?? new BdgHrmValsRepository(_context);
 


        private BdgHrmValsDetRepository _BdgHrmValsDetRepository;
        
        public IBdgHrmValsDetRepository BdgHrmValsDetRepository => _BdgHrmValsDetRepository = _BdgHrmValsDetRepository ?? new BdgHrmValsDetRepository(_context);
 


        private BdgHrmValsPersRepository _BdgHrmValsPersRepository;
        
        public IBdgHrmValsPersRepository BdgHrmValsPersRepository => _BdgHrmValsPersRepository = _BdgHrmValsPersRepository ?? new BdgHrmValsPersRepository(_context);
 


        private BdgLevelDetRepository _BdgLevelDetRepository;
        
        public IBdgLevelDetRepository BdgLevelDetRepository => _BdgLevelDetRepository = _BdgLevelDetRepository ?? new BdgLevelDetRepository(_context);
 


        private BdgPartsRepository _BdgPartsRepository;
        
        public IBdgPartsRepository BdgPartsRepository => _BdgPartsRepository = _BdgPartsRepository ?? new BdgPartsRepository(_context);
 


        private BdgPartsDetRepository _BdgPartsDetRepository;
        
        public IBdgPartsDetRepository BdgPartsDetRepository => _BdgPartsDetRepository = _BdgPartsDetRepository ?? new BdgPartsDetRepository(_context);
 


        private BdgPeriodsRepository _BdgPeriodsRepository;
        
        public IBdgPeriodsRepository BdgPeriodsRepository => _BdgPeriodsRepository = _BdgPeriodsRepository ?? new BdgPeriodsRepository(_context);
 


        private BdgProfitDetRepository _BdgProfitDetRepository;
        
        public IBdgProfitDetRepository BdgProfitDetRepository => _BdgProfitDetRepository = _BdgProfitDetRepository ?? new BdgProfitDetRepository(_context);
 


        private BdgProjDetInfRepository _BdgProjDetInfRepository;
        
        public IBdgProjDetInfRepository BdgProjDetInfRepository => _BdgProjDetInfRepository = _BdgProjDetInfRepository ?? new BdgProjDetInfRepository(_context);
 


        private BdgProjectDetRepository _BdgProjectDetRepository;
        
        public IBdgProjectDetRepository BdgProjectDetRepository => _BdgProjectDetRepository = _BdgProjectDetRepository ?? new BdgProjectDetRepository(_context);
 


        private BdgProjectHrmRepository _BdgProjectHrmRepository;
        
        public IBdgProjectHrmRepository BdgProjectHrmRepository => _BdgProjectHrmRepository = _BdgProjectHrmRepository ?? new BdgProjectHrmRepository(_context);
 


        private BdgProjectsRepository _BdgProjectsRepository;
        
        public IBdgProjectsRepository BdgProjectsRepository => _BdgProjectsRepository = _BdgProjectsRepository ?? new BdgProjectsRepository(_context);
 


        private BdgProjElmntRepository _BdgProjElmntRepository;
        
        public IBdgProjElmntRepository BdgProjElmntRepository => _BdgProjElmntRepository = _BdgProjElmntRepository ?? new BdgProjElmntRepository(_context);
 


        private BdgProjElmntValsRepository _BdgProjElmntValsRepository;
        
        public IBdgProjElmntValsRepository BdgProjElmntValsRepository => _BdgProjElmntValsRepository = _BdgProjElmntValsRepository ?? new BdgProjElmntValsRepository(_context);
 


        private BdgProjGroupRepository _BdgProjGroupRepository;
        
        public IBdgProjGroupRepository BdgProjGroupRepository => _BdgProjGroupRepository = _BdgProjGroupRepository ?? new BdgProjGroupRepository(_context);
 


        private BdgShareRepRepository _BdgShareRepRepository;
        
        public IBdgShareRepRepository BdgShareRepRepository => _BdgShareRepRepository = _BdgShareRepRepository ?? new BdgShareRepRepository(_context);
 


        private BdgTaxDetRepository _BdgTaxDetRepository;
        
        public IBdgTaxDetRepository BdgTaxDetRepository => _BdgTaxDetRepository = _BdgTaxDetRepository ?? new BdgTaxDetRepository(_context);
 


        private BdgTaxesRepository _BdgTaxesRepository;
        
        public IBdgTaxesRepository BdgTaxesRepository => _BdgTaxesRepository = _BdgTaxesRepository ?? new BdgTaxesRepository(_context);
 


        private BdgTaxPrcRepository _BdgTaxPrcRepository;
        
        public IBdgTaxPrcRepository BdgTaxPrcRepository => _BdgTaxPrcRepository = _BdgTaxPrcRepository ?? new BdgTaxPrcRepository(_context);
 


        private BdgTaxPrcCostRepository _BdgTaxPrcCostRepository;
        
        public IBdgTaxPrcCostRepository BdgTaxPrcCostRepository => _BdgTaxPrcCostRepository = _BdgTaxPrcCostRepository ?? new BdgTaxPrcCostRepository(_context);
 


        private BdgTopicsRepository _BdgTopicsRepository;
        
        public IBdgTopicsRepository BdgTopicsRepository => _BdgTopicsRepository = _BdgTopicsRepository ?? new BdgTopicsRepository(_context);
 


        private BdgTopicsRelsRepository _BdgTopicsRelsRepository;
        
        public IBdgTopicsRelsRepository BdgTopicsRelsRepository => _BdgTopicsRelsRepository = _BdgTopicsRelsRepository ?? new BdgTopicsRelsRepository(_context);
 


        private AssetsRepository _AssetsRepository;
        
        public IAssetsRepository AssetsRepository => _AssetsRepository = _AssetsRepository ?? new AssetsRepository(_context);
 


        private AstAssetCostRepository _AstAssetCostRepository;
        
        public IAstAssetCostRepository AstAssetCostRepository => _AstAssetCostRepository = _AstAssetCostRepository ?? new AstAssetCostRepository(_context);
 


        private AstAssetCtgryRepository _AstAssetCtgryRepository;
        
        public IAstAssetCtgryRepository AstAssetCtgryRepository => _AstAssetCtgryRepository = _AstAssetCtgryRepository ?? new AstAssetCtgryRepository(_context);
 


        private AstAssetDeprRepository _AstAssetDeprRepository;
        
        public IAstAssetDeprRepository AstAssetDeprRepository => _AstAssetDeprRepository = _AstAssetDeprRepository ?? new AstAssetDeprRepository(_context);
 


        private AstAssetGrpRepository _AstAssetGrpRepository;
        
        public IAstAssetGrpRepository AstAssetGrpRepository => _AstAssetGrpRepository = _AstAssetGrpRepository ?? new AstAssetGrpRepository(_context);
 


        private AstAssetInfRepository _AstAssetInfRepository;
        
        public IAstAssetInfRepository AstAssetInfRepository => _AstAssetInfRepository = _AstAssetInfRepository ?? new AstAssetInfRepository(_context);
 


        private AstAssetRateRepository _AstAssetRateRepository;
        
        public IAstAssetRateRepository AstAssetRateRepository => _AstAssetRateRepository = _AstAssetRateRepository ?? new AstAssetRateRepository(_context);
 


        private AstAssetSaleRepository _AstAssetSaleRepository;
        
        public IAstAssetSaleRepository AstAssetSaleRepository => _AstAssetSaleRepository = _AstAssetSaleRepository ?? new AstAssetSaleRepository(_context);
 


        private AstCostDetRepository _AstCostDetRepository;
        
        public IAstCostDetRepository AstCostDetRepository => _AstCostDetRepository = _AstCostDetRepository ?? new AstCostDetRepository(_context);
 


        private AstCostDocsRepository _AstCostDocsRepository;
        
        public IAstCostDocsRepository AstCostDocsRepository => _AstCostDocsRepository = _AstCostDocsRepository ?? new AstCostDocsRepository(_context);
 


        private AstDeprVchRepository _AstDeprVchRepository;
        
        public IAstDeprVchRepository AstDeprVchRepository => _AstDeprVchRepository = _AstDeprVchRepository ?? new AstDeprVchRepository(_context);
 


        private AstDocsRepository _AstDocsRepository;
        
        public IAstDocsRepository AstDocsRepository => _AstDocsRepository = _AstDocsRepository ?? new AstDocsRepository(_context);
 


        private AstMensRepository _AstMensRepository;
        
        public IAstMensRepository AstMensRepository => _AstMensRepository = _AstMensRepository ?? new AstMensRepository(_context);
 


        private AstPitchsRepository _AstPitchsRepository;
        
        public IAstPitchsRepository AstPitchsRepository => _AstPitchsRepository = _AstPitchsRepository ?? new AstPitchsRepository(_context);
 


        private AstRatioDocsRepository _AstRatioDocsRepository;
        
        public IAstRatioDocsRepository AstRatioDocsRepository => _AstRatioDocsRepository = _AstRatioDocsRepository ?? new AstRatioDocsRepository(_context);
 


        private AstTransDocsRepository _AstTransDocsRepository;
        
        public IAstTransDocsRepository AstTransDocsRepository => _AstTransDocsRepository = _AstTransDocsRepository ?? new AstTransDocsRepository(_context);
 


        private ArchGroupsRepository _ArchGroupsRepository;
        
        public IArchGroupsRepository ArchGroupsRepository => _ArchGroupsRepository = _ArchGroupsRepository ?? new ArchGroupsRepository(_context);
 


        private ArchiveRepository _ArchiveRepository;
        
        public IArchiveRepository ArchiveRepository => _ArchiveRepository = _ArchiveRepository ?? new ArchiveRepository(_context);
 


        private ArchTypesRepository _ArchTypesRepository;
        
        public IArchTypesRepository ArchTypesRepository => _ArchTypesRepository = _ArchTypesRepository ?? new ArchTypesRepository(_context);
 


        private AccAnalyseRepository _AccAnalyseRepository;
        
        public IAccAnalyseRepository AccAnalyseRepository => _AccAnalyseRepository = _AccAnalyseRepository ?? new AccAnalyseRepository(_context);
 


        private AccCloseHdrRepository _AccCloseHdrRepository;
        
        public IAccCloseHdrRepository AccCloseHdrRepository => _AccCloseHdrRepository = _AccCloseHdrRepository ?? new AccCloseHdrRepository(_context);
 


        private AccCloseItmRepository _AccCloseItmRepository;
        
        public IAccCloseItmRepository AccCloseItmRepository => _AccCloseItmRepository = _AccCloseItmRepository ?? new AccCloseItmRepository(_context);
 


        private AccDLRepository _AccDLRepository;
        
        public IAccDLRepository AccDLRepository => _AccDLRepository = _AccDLRepository ?? new AccDLRepository(_context);
 


        private AccDLCtgryRepository _AccDLCtgryRepository;
        
        public IAccDLCtgryRepository AccDLCtgryRepository => _AccDLCtgryRepository = _AccDLCtgryRepository ?? new AccDLCtgryRepository(_context);
 


        private AccDLCtgryRelRepository _AccDLCtgryRelRepository;
        
        public IAccDLCtgryRelRepository AccDLCtgryRelRepository => _AccDLCtgryRelRepository = _AccDLCtgryRelRepository ?? new AccDLCtgryRelRepository(_context);
 


        private AccGLRepository _AccGLRepository;
        
        public IAccGLRepository AccGLRepository => _AccGLRepository = _AccGLRepository ?? new AccGLRepository(_context);
 


        private AccGLVchHdrRepository _AccGLVchHdrRepository;
        
        public IAccGLVchHdrRepository AccGLVchHdrRepository => _AccGLVchHdrRepository = _AccGLVchHdrRepository ?? new AccGLVchHdrRepository(_context);
 


        private AccGLVchItmRepository _AccGLVchItmRepository;
        
        public IAccGLVchItmRepository AccGLVchItmRepository => _AccGLVchItmRepository = _AccGLVchItmRepository ?? new AccGLVchItmRepository(_context);
 


        private AccGroupsRepository _AccGroupsRepository;
        
        public IAccGroupsRepository AccGroupsRepository => _AccGroupsRepository = _AccGroupsRepository ?? new AccGroupsRepository(_context);
 


        private AccNoteHdrRepository _AccNoteHdrRepository;
        
        public IAccNoteHdrRepository AccNoteHdrRepository => _AccNoteHdrRepository = _AccNoteHdrRepository ?? new AccNoteHdrRepository(_context);
 


        private AccNoteItmRepository _AccNoteItmRepository;
        
        public IAccNoteItmRepository AccNoteItmRepository => _AccNoteItmRepository = _AccNoteItmRepository ?? new AccNoteItmRepository(_context);
 


        private AccPeriodRepository _AccPeriodRepository;
        
        public IAccPeriodRepository AccPeriodRepository => _AccPeriodRepository = _AccPeriodRepository ?? new AccPeriodRepository(_context);
 


        private AccPLRepository _AccPLRepository;
        
        public IAccPLRepository AccPLRepository => _AccPLRepository = _AccPLRepository ?? new AccPLRepository(_context);
 


        private AccSLRepository _AccSLRepository;
        
        public IAccSLRepository AccSLRepository => _AccSLRepository = _AccSLRepository ?? new AccSLRepository(_context);
 


        private AccSLDLRelRepository _AccSLDLRelRepository;
        
        public IAccSLDLRelRepository AccSLDLRelRepository => _AccSLDLRelRepository = _AccSLDLRelRepository ?? new AccSLDLRelRepository(_context);
 


        private AccSLStdDescRepository _AccSLStdDescRepository;
        
        public IAccSLStdDescRepository AccSLStdDescRepository => _AccSLStdDescRepository = _AccSLStdDescRepository ?? new AccSLStdDescRepository(_context);
 


        private AccTransVchRepository _AccTransVchRepository;
        
        public IAccTransVchRepository AccTransVchRepository => _AccTransVchRepository = _AccTransVchRepository ?? new AccTransVchRepository(_context);
 


        private AccVchDescrRepository _AccVchDescrRepository;
        
        public IAccVchDescrRepository AccVchDescrRepository => _AccVchDescrRepository = _AccVchDescrRepository ?? new AccVchDescrRepository(_context);
 


        private AccVchHdrRepository _AccVchHdrRepository;
        
        public IAccVchHdrRepository AccVchHdrRepository => _AccVchHdrRepository = _AccVchHdrRepository ?? new AccVchHdrRepository(_context);
 


        private AccVchItmRepository _AccVchItmRepository;
        
        public IAccVchItmRepository AccVchItmRepository => _AccVchItmRepository = _AccVchItmRepository ?? new AccVchItmRepository(_context);
 


        private AccVchKindDescrRepository _AccVchKindDescrRepository;
        
        public IAccVchKindDescrRepository AccVchKindDescrRepository => _AccVchKindDescrRepository = _AccVchKindDescrRepository ?? new AccVchKindDescrRepository(_context);
 


        private AccVchRelsRepository _AccVchRelsRepository;
        
        public IAccVchRelsRepository AccVchRelsRepository => _AccVchRelsRepository = _AccVchRelsRepository ?? new AccVchRelsRepository(_context);
 


        private AccVchTypesRepository _AccVchTypesRepository;
        
        public IAccVchTypesRepository AccVchTypesRepository => _AccVchTypesRepository = _AccVchTypesRepository ?? new AccVchTypesRepository(_context);
 

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
