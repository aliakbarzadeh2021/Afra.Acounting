using Afra.Domain.Entities;
using Afra.Message.Commands;
using Afra.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afra.Api.Controllers
{
    public partial class Mapper
    {
                
        
        public static SleAftSrv Map(AddSleAftSrvCommand inputItem)
        {
            var entity = new SleAftSrv() {
                  
  
		SleAftSrvId = inputItem.SleAftSrvId,  
  
		SASNum = inputItem.SASNum,  
  
		SASDate = inputItem.SASDate,  
  
		SASCstmrRef = inputItem.SASCstmrRef,  
  
		SASResp = inputItem.SASResp,  
  
		SASPartRef = inputItem.SASPartRef,  
  
		SASQty = inputItem.SASQty,  
  
		SASDescr = inputItem.SASDescr,  
  
		SASGuaRef = inputItem.SASGuaRef,  
  
		SASPrdRef = inputItem.SASPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleAftSrv Map(SleAftSrv entity ,EditSleAftSrvCommand inputItem)
        {
              
  
		entity.SleAftSrvId = inputItem.SleAftSrvId;  
  
		entity.SASNum = inputItem.SASNum;  
  
		entity.SASDate = inputItem.SASDate;  
  
		entity.SASCstmrRef = inputItem.SASCstmrRef;  
  
		entity.SASResp = inputItem.SASResp;  
  
		entity.SASPartRef = inputItem.SASPartRef;  
  
		entity.SASQty = inputItem.SASQty;  
  
		entity.SASDescr = inputItem.SASDescr;  
  
		entity.SASGuaRef = inputItem.SASGuaRef;  
  
		entity.SASPrdRef = inputItem.SASPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleAftSrvDto Map(SleAftSrv inputItem)
        {
            var dto = new SleAftSrvDto()
            {
                  
  
		SleAftSrvId = inputItem.SleAftSrvId,  
  
		SASNum = inputItem.SASNum,  
  
		SASDate = inputItem.SASDate,  
  
		SASCstmrRef = inputItem.SASCstmrRef,  
  
		SASResp = inputItem.SASResp,  
  
		SASPartRef = inputItem.SASPartRef,  
  
		SASQty = inputItem.SASQty,  
  
		SASDescr = inputItem.SASDescr,  
  
		SASGuaRef = inputItem.SASGuaRef,  
  
		SASPrdRef = inputItem.SASPrdRef, 
            };
            return dto;
        }

        public static List<SleAftSrvDto> Map(ICollection<SleAftSrv> entities)
        {
            var dtos = new List<SleAftSrvDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleAftSrvDto()
                {
                      
  
		SleAftSrvId = inputItem.SleAftSrvId,  
  
		SASNum = inputItem.SASNum,  
  
		SASDate = inputItem.SASDate,  
  
		SASCstmrRef = inputItem.SASCstmrRef,  
  
		SASResp = inputItem.SASResp,  
  
		SASPartRef = inputItem.SASPartRef,  
  
		SASQty = inputItem.SASQty,  
  
		SASDescr = inputItem.SASDescr,  
  
		SASGuaRef = inputItem.SASGuaRef,  
  
		SASPrdRef = inputItem.SASPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBranchs Map(AddSleBranchsCommand inputItem)
        {
            var entity = new SleBranchs() {
                  
  
		SleBranchId = inputItem.SleBranchId,  
  
		SleBranchCode = inputItem.SleBranchCode,  
  
		SleBranchName = inputItem.SleBranchName,  
  
		SleBranchDLRef = inputItem.SleBranchDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBranchs Map(SleBranchs entity ,EditSleBranchsCommand inputItem)
        {
              
  
		entity.SleBranchId = inputItem.SleBranchId;  
  
		entity.SleBranchCode = inputItem.SleBranchCode;  
  
		entity.SleBranchName = inputItem.SleBranchName;  
  
		entity.SleBranchDLRef = inputItem.SleBranchDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBranchsDto Map(SleBranchs inputItem)
        {
            var dto = new SleBranchsDto()
            {
                  
  
		SleBranchId = inputItem.SleBranchId,  
  
		SleBranchCode = inputItem.SleBranchCode,  
  
		SleBranchName = inputItem.SleBranchName,  
  
		SleBranchDLRef = inputItem.SleBranchDLRef, 
            };
            return dto;
        }

        public static List<SleBranchsDto> Map(ICollection<SleBranchs> entities)
        {
            var dtos = new List<SleBranchsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBranchsDto()
                {
                      
  
		SleBranchId = inputItem.SleBranchId,  
  
		SleBranchCode = inputItem.SleBranchCode,  
  
		SleBranchName = inputItem.SleBranchName,  
  
		SleBranchDLRef = inputItem.SleBranchDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokerCalc Map(AddSleBrokerCalcCommand inputItem)
        {
            var entity = new SleBrokerCalc() {
                  
  
		SleBrokerCalcId = inputItem.SleBrokerCalcId,  
  
		SBCSalaryRef = inputItem.SBCSalaryRef,  
  
		SBCBrokerRef = inputItem.SBCBrokerRef,  
  
		SBCFDate = inputItem.SBCFDate,  
  
		SBCEDate = inputItem.SBCEDate,  
  
		SBCBaseAmnt = inputItem.SBCBaseAmnt,  
  
		SBCAmount = inputItem.SBCAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokerCalc Map(SleBrokerCalc entity ,EditSleBrokerCalcCommand inputItem)
        {
              
  
		entity.SleBrokerCalcId = inputItem.SleBrokerCalcId;  
  
		entity.SBCSalaryRef = inputItem.SBCSalaryRef;  
  
		entity.SBCBrokerRef = inputItem.SBCBrokerRef;  
  
		entity.SBCFDate = inputItem.SBCFDate;  
  
		entity.SBCEDate = inputItem.SBCEDate;  
  
		entity.SBCBaseAmnt = inputItem.SBCBaseAmnt;  
  
		entity.SBCAmount = inputItem.SBCAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokerCalcDto Map(SleBrokerCalc inputItem)
        {
            var dto = new SleBrokerCalcDto()
            {
                  
  
		SleBrokerCalcId = inputItem.SleBrokerCalcId,  
  
		SBCSalaryRef = inputItem.SBCSalaryRef,  
  
		SBCBrokerRef = inputItem.SBCBrokerRef,  
  
		SBCFDate = inputItem.SBCFDate,  
  
		SBCEDate = inputItem.SBCEDate,  
  
		SBCBaseAmnt = inputItem.SBCBaseAmnt,  
  
		SBCAmount = inputItem.SBCAmount, 
            };
            return dto;
        }

        public static List<SleBrokerCalcDto> Map(ICollection<SleBrokerCalc> entities)
        {
            var dtos = new List<SleBrokerCalcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokerCalcDto()
                {
                      
  
		SleBrokerCalcId = inputItem.SleBrokerCalcId,  
  
		SBCSalaryRef = inputItem.SBCSalaryRef,  
  
		SBCBrokerRef = inputItem.SBCBrokerRef,  
  
		SBCFDate = inputItem.SBCFDate,  
  
		SBCEDate = inputItem.SBCEDate,  
  
		SBCBaseAmnt = inputItem.SBCBaseAmnt,  
  
		SBCAmount = inputItem.SBCAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokers Map(AddSleBrokersCommand inputItem)
        {
            var entity = new SleBrokers() {
                  
  
		SleBrokerId = inputItem.SleBrokerId,  
  
		SBCrspndRef = inputItem.SBCrspndRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokers Map(SleBrokers entity ,EditSleBrokersCommand inputItem)
        {
              
  
		entity.SleBrokerId = inputItem.SleBrokerId;  
  
		entity.SBCrspndRef = inputItem.SBCrspndRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokersDto Map(SleBrokers inputItem)
        {
            var dto = new SleBrokersDto()
            {
                  
  
		SleBrokerId = inputItem.SleBrokerId,  
  
		SBCrspndRef = inputItem.SBCrspndRef, 
            };
            return dto;
        }

        public static List<SleBrokersDto> Map(ICollection<SleBrokers> entities)
        {
            var dtos = new List<SleBrokersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokersDto()
                {
                      
  
		SleBrokerId = inputItem.SleBrokerId,  
  
		SBCrspndRef = inputItem.SBCrspndRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokerSalary Map(AddSleBrokerSalaryCommand inputItem)
        {
            var entity = new SleBrokerSalary() {
                  
  
		SleBrokerSalaryId = inputItem.SleBrokerSalaryId,  
  
		SBSTitle = inputItem.SBSTitle,  
  
		SBSFDate = inputItem.SBSFDate,  
  
		SBSTDate = inputItem.SBSTDate,  
  
		SBSBaseMthd = inputItem.SBSBaseMthd,  
  
		SBSOprType = inputItem.SBSOprType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokerSalary Map(SleBrokerSalary entity ,EditSleBrokerSalaryCommand inputItem)
        {
              
  
		entity.SleBrokerSalaryId = inputItem.SleBrokerSalaryId;  
  
		entity.SBSTitle = inputItem.SBSTitle;  
  
		entity.SBSFDate = inputItem.SBSFDate;  
  
		entity.SBSTDate = inputItem.SBSTDate;  
  
		entity.SBSBaseMthd = inputItem.SBSBaseMthd;  
  
		entity.SBSOprType = inputItem.SBSOprType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokerSalaryDto Map(SleBrokerSalary inputItem)
        {
            var dto = new SleBrokerSalaryDto()
            {
                  
  
		SleBrokerSalaryId = inputItem.SleBrokerSalaryId,  
  
		SBSTitle = inputItem.SBSTitle,  
  
		SBSFDate = inputItem.SBSFDate,  
  
		SBSTDate = inputItem.SBSTDate,  
  
		SBSBaseMthd = inputItem.SBSBaseMthd,  
  
		SBSOprType = inputItem.SBSOprType, 
            };
            return dto;
        }

        public static List<SleBrokerSalaryDto> Map(ICollection<SleBrokerSalary> entities)
        {
            var dtos = new List<SleBrokerSalaryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokerSalaryDto()
                {
                      
  
		SleBrokerSalaryId = inputItem.SleBrokerSalaryId,  
  
		SBSTitle = inputItem.SBSTitle,  
  
		SBSFDate = inputItem.SBSFDate,  
  
		SBSTDate = inputItem.SBSTDate,  
  
		SBSBaseMthd = inputItem.SBSBaseMthd,  
  
		SBSOprType = inputItem.SBSOprType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokerSalaryMthd Map(AddSleBrokerSalaryMthdCommand inputItem)
        {
            var entity = new SleBrokerSalaryMthd() {
                  
  
		SleBrokerSalaryMthdId = inputItem.SleBrokerSalaryMthdId,  
  
		SleBrokerSalaryRef = inputItem.SleBrokerSalaryRef,  
  
		SBSMCstmrGrpRef = inputItem.SBSMCstmrGrpRef,  
  
		SBSMCstmrRef = inputItem.SBSMCstmrRef,  
  
		SBSMPartGrpRef = inputItem.SBSMPartGrpRef,  
  
		SBSMPartRef = inputItem.SBSMPartRef,  
  
		SBSMPlaceRef = inputItem.SBSMPlaceRef,  
  
		SBSMSaleType = inputItem.SBSMSaleType,  
  
		SBSMFVal = inputItem.SBSMFVal,  
  
		SBSMTVal = inputItem.SBSMTVal,  
  
		SBSMValue = inputItem.SBSMValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokerSalaryMthd Map(SleBrokerSalaryMthd entity ,EditSleBrokerSalaryMthdCommand inputItem)
        {
              
  
		entity.SleBrokerSalaryMthdId = inputItem.SleBrokerSalaryMthdId;  
  
		entity.SleBrokerSalaryRef = inputItem.SleBrokerSalaryRef;  
  
		entity.SBSMCstmrGrpRef = inputItem.SBSMCstmrGrpRef;  
  
		entity.SBSMCstmrRef = inputItem.SBSMCstmrRef;  
  
		entity.SBSMPartGrpRef = inputItem.SBSMPartGrpRef;  
  
		entity.SBSMPartRef = inputItem.SBSMPartRef;  
  
		entity.SBSMPlaceRef = inputItem.SBSMPlaceRef;  
  
		entity.SBSMSaleType = inputItem.SBSMSaleType;  
  
		entity.SBSMFVal = inputItem.SBSMFVal;  
  
		entity.SBSMTVal = inputItem.SBSMTVal;  
  
		entity.SBSMValue = inputItem.SBSMValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokerSalaryMthdDto Map(SleBrokerSalaryMthd inputItem)
        {
            var dto = new SleBrokerSalaryMthdDto()
            {
                  
  
		SleBrokerSalaryMthdId = inputItem.SleBrokerSalaryMthdId,  
  
		SleBrokerSalaryRef = inputItem.SleBrokerSalaryRef,  
  
		SBSMCstmrGrpRef = inputItem.SBSMCstmrGrpRef,  
  
		SBSMCstmrRef = inputItem.SBSMCstmrRef,  
  
		SBSMPartGrpRef = inputItem.SBSMPartGrpRef,  
  
		SBSMPartRef = inputItem.SBSMPartRef,  
  
		SBSMPlaceRef = inputItem.SBSMPlaceRef,  
  
		SBSMSaleType = inputItem.SBSMSaleType,  
  
		SBSMFVal = inputItem.SBSMFVal,  
  
		SBSMTVal = inputItem.SBSMTVal,  
  
		SBSMValue = inputItem.SBSMValue, 
            };
            return dto;
        }

        public static List<SleBrokerSalaryMthdDto> Map(ICollection<SleBrokerSalaryMthd> entities)
        {
            var dtos = new List<SleBrokerSalaryMthdDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokerSalaryMthdDto()
                {
                      
  
		SleBrokerSalaryMthdId = inputItem.SleBrokerSalaryMthdId,  
  
		SleBrokerSalaryRef = inputItem.SleBrokerSalaryRef,  
  
		SBSMCstmrGrpRef = inputItem.SBSMCstmrGrpRef,  
  
		SBSMCstmrRef = inputItem.SBSMCstmrRef,  
  
		SBSMPartGrpRef = inputItem.SBSMPartGrpRef,  
  
		SBSMPartRef = inputItem.SBSMPartRef,  
  
		SBSMPlaceRef = inputItem.SBSMPlaceRef,  
  
		SBSMSaleType = inputItem.SBSMSaleType,  
  
		SBSMFVal = inputItem.SBSMFVal,  
  
		SBSMTVal = inputItem.SBSMTVal,  
  
		SBSMValue = inputItem.SBSMValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokerSalaryRels Map(AddSleBrokerSalaryRelsCommand inputItem)
        {
            var entity = new SleBrokerSalaryRels() {
                  
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSBrokerRef = inputItem.SBSBrokerRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokerSalaryRels Map(SleBrokerSalaryRels entity ,EditSleBrokerSalaryRelsCommand inputItem)
        {
              
  
		entity.SBSHdrRef = inputItem.SBSHdrRef;  
  
		entity.SBSBrokerRef = inputItem.SBSBrokerRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokerSalaryRelsDto Map(SleBrokerSalaryRels inputItem)
        {
            var dto = new SleBrokerSalaryRelsDto()
            {
                  
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSBrokerRef = inputItem.SBSBrokerRef, 
            };
            return dto;
        }

        public static List<SleBrokerSalaryRelsDto> Map(ICollection<SleBrokerSalaryRels> entities)
        {
            var dtos = new List<SleBrokerSalaryRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokerSalaryRelsDto()
                {
                      
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSBrokerRef = inputItem.SBSBrokerRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleBrokerSalaryTax Map(AddSleBrokerSalaryTaxCommand inputItem)
        {
            var entity = new SleBrokerSalaryTax() {
                  
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSTaxRef = inputItem.SBSTaxRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleBrokerSalaryTax Map(SleBrokerSalaryTax entity ,EditSleBrokerSalaryTaxCommand inputItem)
        {
              
  
		entity.SBSHdrRef = inputItem.SBSHdrRef;  
  
		entity.SBSTaxRef = inputItem.SBSTaxRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleBrokerSalaryTaxDto Map(SleBrokerSalaryTax inputItem)
        {
            var dto = new SleBrokerSalaryTaxDto()
            {
                  
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSTaxRef = inputItem.SBSTaxRef, 
            };
            return dto;
        }

        public static List<SleBrokerSalaryTaxDto> Map(ICollection<SleBrokerSalaryTax> entities)
        {
            var dtos = new List<SleBrokerSalaryTaxDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleBrokerSalaryTaxDto()
                {
                      
  
		SBSHdrRef = inputItem.SBSHdrRef,  
  
		SBSTaxRef = inputItem.SBSTaxRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleChngVchHdr Map(AddSleChngVchHdrCommand inputItem)
        {
            var entity = new SleChngVchHdr() {
                  
  
		SleChngVchHdrID = inputItem.SleChngVchHdrID,  
  
		SCVHNum = inputItem.SCVHNum,  
  
		SCVHLocalNum = inputItem.SCVHLocalNum,  
  
		SCVHDate = inputItem.SCVHDate,  
  
		SCVHDescr = inputItem.SCVHDescr,  
  
		SCVHVchType = inputItem.SCVHVchType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SCVHState = inputItem.SCVHState,  
  
		SCVAccPrdRef = inputItem.SCVAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleChngVchHdr Map(SleChngVchHdr entity ,EditSleChngVchHdrCommand inputItem)
        {
              
  
		entity.SleChngVchHdrID = inputItem.SleChngVchHdrID;  
  
		entity.SCVHNum = inputItem.SCVHNum;  
  
		entity.SCVHLocalNum = inputItem.SCVHLocalNum;  
  
		entity.SCVHDate = inputItem.SCVHDate;  
  
		entity.SCVHDescr = inputItem.SCVHDescr;  
  
		entity.SCVHVchType = inputItem.SCVHVchType;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SCVHState = inputItem.SCVHState;  
  
		entity.SCVAccPrdRef = inputItem.SCVAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleChngVchHdrDto Map(SleChngVchHdr inputItem)
        {
            var dto = new SleChngVchHdrDto()
            {
                  
  
		SleChngVchHdrID = inputItem.SleChngVchHdrID,  
  
		SCVHNum = inputItem.SCVHNum,  
  
		SCVHLocalNum = inputItem.SCVHLocalNum,  
  
		SCVHDate = inputItem.SCVHDate,  
  
		SCVHDescr = inputItem.SCVHDescr,  
  
		SCVHVchType = inputItem.SCVHVchType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SCVHState = inputItem.SCVHState,  
  
		SCVAccPrdRef = inputItem.SCVAccPrdRef, 
            };
            return dto;
        }

        public static List<SleChngVchHdrDto> Map(ICollection<SleChngVchHdr> entities)
        {
            var dtos = new List<SleChngVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleChngVchHdrDto()
                {
                      
  
		SleChngVchHdrID = inputItem.SleChngVchHdrID,  
  
		SCVHNum = inputItem.SCVHNum,  
  
		SCVHLocalNum = inputItem.SCVHLocalNum,  
  
		SCVHDate = inputItem.SCVHDate,  
  
		SCVHDescr = inputItem.SCVHDescr,  
  
		SCVHVchType = inputItem.SCVHVchType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SCVHState = inputItem.SCVHState,  
  
		SCVAccPrdRef = inputItem.SCVAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleChngVchItm Map(AddSleChngVchItmCommand inputItem)
        {
            var entity = new SleChngVchItm() {
                  
  
		SleChngVchItmId = inputItem.SleChngVchItmId,  
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SCVISeq = inputItem.SCVISeq,  
  
		SCVIItmRef = inputItem.SCVIItmRef,  
  
		SCVIOldQty = inputItem.SCVIOldQty,  
  
		SCVIOldPrice = inputItem.SCVIOldPrice,  
  
		SCVINewQty = inputItem.SCVINewQty,  
  
		SCVINewPrice = inputItem.SCVINewPrice,  
  
		SCVIAmount = inputItem.SCVIAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleChngVchItm Map(SleChngVchItm entity ,EditSleChngVchItmCommand inputItem)
        {
              
  
		entity.SleChngVchItmId = inputItem.SleChngVchItmId;  
  
		entity.SleChngVchHdrRef = inputItem.SleChngVchHdrRef;  
  
		entity.SCVISeq = inputItem.SCVISeq;  
  
		entity.SCVIItmRef = inputItem.SCVIItmRef;  
  
		entity.SCVIOldQty = inputItem.SCVIOldQty;  
  
		entity.SCVIOldPrice = inputItem.SCVIOldPrice;  
  
		entity.SCVINewQty = inputItem.SCVINewQty;  
  
		entity.SCVINewPrice = inputItem.SCVINewPrice;  
  
		entity.SCVIAmount = inputItem.SCVIAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleChngVchItmDto Map(SleChngVchItm inputItem)
        {
            var dto = new SleChngVchItmDto()
            {
                  
  
		SleChngVchItmId = inputItem.SleChngVchItmId,  
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SCVISeq = inputItem.SCVISeq,  
  
		SCVIItmRef = inputItem.SCVIItmRef,  
  
		SCVIOldQty = inputItem.SCVIOldQty,  
  
		SCVIOldPrice = inputItem.SCVIOldPrice,  
  
		SCVINewQty = inputItem.SCVINewQty,  
  
		SCVINewPrice = inputItem.SCVINewPrice,  
  
		SCVIAmount = inputItem.SCVIAmount, 
            };
            return dto;
        }

        public static List<SleChngVchItmDto> Map(ICollection<SleChngVchItm> entities)
        {
            var dtos = new List<SleChngVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleChngVchItmDto()
                {
                      
  
		SleChngVchItmId = inputItem.SleChngVchItmId,  
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SCVISeq = inputItem.SCVISeq,  
  
		SCVIItmRef = inputItem.SCVIItmRef,  
  
		SCVIOldQty = inputItem.SCVIOldQty,  
  
		SCVIOldPrice = inputItem.SCVIOldPrice,  
  
		SCVINewQty = inputItem.SCVINewQty,  
  
		SCVINewPrice = inputItem.SCVINewPrice,  
  
		SCVIAmount = inputItem.SCVIAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleChngVchTax Map(AddSleChngVchTaxCommand inputItem)
        {
            var entity = new SleChngVchTax() {
                  
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SleChngVchItmRef = inputItem.SleChngVchItmRef,  
  
		SCVTTaxRef = inputItem.SCVTTaxRef,  
  
		SCVTTaxAmount = inputItem.SCVTTaxAmount,  
  
		SCVTAmount = inputItem.SCVTAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleChngVchTax Map(SleChngVchTax entity ,EditSleChngVchTaxCommand inputItem)
        {
              
  
		entity.SleChngVchHdrRef = inputItem.SleChngVchHdrRef;  
  
		entity.SleChngVchItmRef = inputItem.SleChngVchItmRef;  
  
		entity.SCVTTaxRef = inputItem.SCVTTaxRef;  
  
		entity.SCVTTaxAmount = inputItem.SCVTTaxAmount;  
  
		entity.SCVTAmount = inputItem.SCVTAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleChngVchTaxDto Map(SleChngVchTax inputItem)
        {
            var dto = new SleChngVchTaxDto()
            {
                  
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SleChngVchItmRef = inputItem.SleChngVchItmRef,  
  
		SCVTTaxRef = inputItem.SCVTTaxRef,  
  
		SCVTTaxAmount = inputItem.SCVTTaxAmount,  
  
		SCVTAmount = inputItem.SCVTAmount, 
            };
            return dto;
        }

        public static List<SleChngVchTaxDto> Map(ICollection<SleChngVchTax> entities)
        {
            var dtos = new List<SleChngVchTaxDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleChngVchTaxDto()
                {
                      
  
		SleChngVchHdrRef = inputItem.SleChngVchHdrRef,  
  
		SleChngVchItmRef = inputItem.SleChngVchItmRef,  
  
		SCVTTaxRef = inputItem.SCVTTaxRef,  
  
		SCVTTaxAmount = inputItem.SCVTTaxAmount,  
  
		SCVTAmount = inputItem.SCVTAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCstmrBrokers Map(AddSleCstmrBrokersCommand inputItem)
        {
            var entity = new SleCstmrBrokers() {
                  
  
		SleCstmrRef = inputItem.SleCstmrRef,  
  
		SleBrokerRef = inputItem.SleBrokerRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCstmrBrokers Map(SleCstmrBrokers entity ,EditSleCstmrBrokersCommand inputItem)
        {
              
  
		entity.SleCstmrRef = inputItem.SleCstmrRef;  
  
		entity.SleBrokerRef = inputItem.SleBrokerRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCstmrBrokersDto Map(SleCstmrBrokers inputItem)
        {
            var dto = new SleCstmrBrokersDto()
            {
                  
  
		SleCstmrRef = inputItem.SleCstmrRef,  
  
		SleBrokerRef = inputItem.SleBrokerRef, 
            };
            return dto;
        }

        public static List<SleCstmrBrokersDto> Map(ICollection<SleCstmrBrokers> entities)
        {
            var dtos = new List<SleCstmrBrokersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCstmrBrokersDto()
                {
                      
  
		SleCstmrRef = inputItem.SleCstmrRef,  
  
		SleBrokerRef = inputItem.SleBrokerRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCstmrGroups Map(AddSleCstmrGroupsCommand inputItem)
        {
            var entity = new SleCstmrGroups() {
                  
  
		SleCstmrGroupId = inputItem.SleCstmrGroupId,  
  
		SCGParent = inputItem.SCGParent,  
  
		SCGTitle = inputItem.SCGTitle,  
  
		SCGDLRef = inputItem.SCGDLRef,  
  
		SCGMainRoot = inputItem.SCGMainRoot, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCstmrGroups Map(SleCstmrGroups entity ,EditSleCstmrGroupsCommand inputItem)
        {
              
  
		entity.SleCstmrGroupId = inputItem.SleCstmrGroupId;  
  
		entity.SCGParent = inputItem.SCGParent;  
  
		entity.SCGTitle = inputItem.SCGTitle;  
  
		entity.SCGDLRef = inputItem.SCGDLRef;  
  
		entity.SCGMainRoot = inputItem.SCGMainRoot; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCstmrGroupsDto Map(SleCstmrGroups inputItem)
        {
            var dto = new SleCstmrGroupsDto()
            {
                  
  
		SleCstmrGroupId = inputItem.SleCstmrGroupId,  
  
		SCGParent = inputItem.SCGParent,  
  
		SCGTitle = inputItem.SCGTitle,  
  
		SCGDLRef = inputItem.SCGDLRef,  
  
		SCGMainRoot = inputItem.SCGMainRoot, 
            };
            return dto;
        }

        public static List<SleCstmrGroupsDto> Map(ICollection<SleCstmrGroups> entities)
        {
            var dtos = new List<SleCstmrGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCstmrGroupsDto()
                {
                      
  
		SleCstmrGroupId = inputItem.SleCstmrGroupId,  
  
		SCGParent = inputItem.SCGParent,  
  
		SCGTitle = inputItem.SCGTitle,  
  
		SCGDLRef = inputItem.SCGDLRef,  
  
		SCGMainRoot = inputItem.SCGMainRoot, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCstmrLimit Map(AddSleCstmrLimitCommand inputItem)
        {
            var entity = new SleCstmrLimit() {
                  
  
		SleCstmrLimitId = inputItem.SleCstmrLimitId,  
  
		SCLCstmrRef = inputItem.SCLCstmrRef,  
  
		SCLDate = inputItem.SCLDate,  
  
		SCLAmount = inputItem.SCLAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCstmrLimit Map(SleCstmrLimit entity ,EditSleCstmrLimitCommand inputItem)
        {
              
  
		entity.SleCstmrLimitId = inputItem.SleCstmrLimitId;  
  
		entity.SCLCstmrRef = inputItem.SCLCstmrRef;  
  
		entity.SCLDate = inputItem.SCLDate;  
  
		entity.SCLAmount = inputItem.SCLAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCstmrLimitDto Map(SleCstmrLimit inputItem)
        {
            var dto = new SleCstmrLimitDto()
            {
                  
  
		SleCstmrLimitId = inputItem.SleCstmrLimitId,  
  
		SCLCstmrRef = inputItem.SCLCstmrRef,  
  
		SCLDate = inputItem.SCLDate,  
  
		SCLAmount = inputItem.SCLAmount, 
            };
            return dto;
        }

        public static List<SleCstmrLimitDto> Map(ICollection<SleCstmrLimit> entities)
        {
            var dtos = new List<SleCstmrLimitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCstmrLimitDto()
                {
                      
  
		SleCstmrLimitId = inputItem.SleCstmrLimitId,  
  
		SCLCstmrRef = inputItem.SCLCstmrRef,  
  
		SCLDate = inputItem.SCLDate,  
  
		SCLAmount = inputItem.SCLAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCstmrs Map(AddSleCstmrsCommand inputItem)
        {
            var entity = new SleCstmrs() {
                  
  
		SleCstmrId = inputItem.SleCstmrId,  
  
		SleCstmrCode = inputItem.SleCstmrCode,  
  
		SCGroupRef = inputItem.SCGroupRef,  
  
		SCCrspndRef = inputItem.SCCrspndRef,  
  
		SCSaleType = inputItem.SCSaleType,  
  
		SCLimitType = inputItem.SCLimitType,  
  
		SCType = inputItem.SCType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCstmrs Map(SleCstmrs entity ,EditSleCstmrsCommand inputItem)
        {
              
  
		entity.SleCstmrId = inputItem.SleCstmrId;  
  
		entity.SleCstmrCode = inputItem.SleCstmrCode;  
  
		entity.SCGroupRef = inputItem.SCGroupRef;  
  
		entity.SCCrspndRef = inputItem.SCCrspndRef;  
  
		entity.SCSaleType = inputItem.SCSaleType;  
  
		entity.SCLimitType = inputItem.SCLimitType;  
  
		entity.SCType = inputItem.SCType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCstmrsDto Map(SleCstmrs inputItem)
        {
            var dto = new SleCstmrsDto()
            {
                  
  
		SleCstmrId = inputItem.SleCstmrId,  
  
		SleCstmrCode = inputItem.SleCstmrCode,  
  
		SCGroupRef = inputItem.SCGroupRef,  
  
		SCCrspndRef = inputItem.SCCrspndRef,  
  
		SCSaleType = inputItem.SCSaleType,  
  
		SCLimitType = inputItem.SCLimitType,  
  
		SCType = inputItem.SCType, 
            };
            return dto;
        }

        public static List<SleCstmrsDto> Map(ICollection<SleCstmrs> entities)
        {
            var dtos = new List<SleCstmrsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCstmrsDto()
                {
                      
  
		SleCstmrId = inputItem.SleCstmrId,  
  
		SleCstmrCode = inputItem.SleCstmrCode,  
  
		SCGroupRef = inputItem.SCGroupRef,  
  
		SCCrspndRef = inputItem.SCCrspndRef,  
  
		SCSaleType = inputItem.SCSaleType,  
  
		SCLimitType = inputItem.SCLimitType,  
  
		SCType = inputItem.SCType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCtgry Map(AddSleCtgryCommand inputItem)
        {
            var entity = new SleCtgry() {
                  
  
		SleCtgryId = inputItem.SleCtgryId,  
  
		SCTitle = inputItem.SCTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCtgry Map(SleCtgry entity ,EditSleCtgryCommand inputItem)
        {
              
  
		entity.SleCtgryId = inputItem.SleCtgryId;  
  
		entity.SCTitle = inputItem.SCTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCtgryDto Map(SleCtgry inputItem)
        {
            var dto = new SleCtgryDto()
            {
                  
  
		SleCtgryId = inputItem.SleCtgryId,  
  
		SCTitle = inputItem.SCTitle, 
            };
            return dto;
        }

        public static List<SleCtgryDto> Map(ICollection<SleCtgry> entities)
        {
            var dtos = new List<SleCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCtgryDto()
                {
                      
  
		SleCtgryId = inputItem.SleCtgryId,  
  
		SCTitle = inputItem.SCTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleCtgryAcc Map(AddSleCtgryAccCommand inputItem)
        {
            var entity = new SleCtgryAcc() {
                  
  
		SCACtgryRef = inputItem.SCACtgryRef,  
  
		SCAVchType = inputItem.SCAVchType,  
  
		SCASLRef = inputItem.SCASLRef,  
  
		SCADL4Type = inputItem.SCADL4Type,  
  
		SCADL5Type = inputItem.SCADL5Type,  
  
		SCADL6Type = inputItem.SCADL6Type, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleCtgryAcc Map(SleCtgryAcc entity ,EditSleCtgryAccCommand inputItem)
        {
              
  
		entity.SCACtgryRef = inputItem.SCACtgryRef;  
  
		entity.SCAVchType = inputItem.SCAVchType;  
  
		entity.SCASLRef = inputItem.SCASLRef;  
  
		entity.SCADL4Type = inputItem.SCADL4Type;  
  
		entity.SCADL5Type = inputItem.SCADL5Type;  
  
		entity.SCADL6Type = inputItem.SCADL6Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleCtgryAccDto Map(SleCtgryAcc inputItem)
        {
            var dto = new SleCtgryAccDto()
            {
                  
  
		SCACtgryRef = inputItem.SCACtgryRef,  
  
		SCAVchType = inputItem.SCAVchType,  
  
		SCASLRef = inputItem.SCASLRef,  
  
		SCADL4Type = inputItem.SCADL4Type,  
  
		SCADL5Type = inputItem.SCADL5Type,  
  
		SCADL6Type = inputItem.SCADL6Type, 
            };
            return dto;
        }

        public static List<SleCtgryAccDto> Map(ICollection<SleCtgryAcc> entities)
        {
            var dtos = new List<SleCtgryAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleCtgryAccDto()
                {
                      
  
		SCACtgryRef = inputItem.SCACtgryRef,  
  
		SCAVchType = inputItem.SCAVchType,  
  
		SCASLRef = inputItem.SCASLRef,  
  
		SCADL4Type = inputItem.SCADL4Type,  
  
		SCADL5Type = inputItem.SCADL5Type,  
  
		SCADL6Type = inputItem.SCADL6Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleDebCreHdr Map(AddSleDebCreHdrCommand inputItem)
        {
            var entity = new SleDebCreHdr() {
                  
  
		SleDebCreHdrId = inputItem.SleDebCreHdrId,  
  
		SDCHBranchRef = inputItem.SDCHBranchRef,  
  
		SDCHType = inputItem.SDCHType,  
  
		SDCHNum = inputItem.SDCHNum,  
  
		SDCHLocalNum = inputItem.SDCHLocalNum,  
  
		SDCHDate = inputItem.SDCHDate,  
  
		SDCHDescr = inputItem.SDCHDescr,  
  
		SDCHAccPrd = inputItem.SDCHAccPrd,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SDCHState = inputItem.SDCHState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleDebCreHdr Map(SleDebCreHdr entity ,EditSleDebCreHdrCommand inputItem)
        {
              
  
		entity.SleDebCreHdrId = inputItem.SleDebCreHdrId;  
  
		entity.SDCHBranchRef = inputItem.SDCHBranchRef;  
  
		entity.SDCHType = inputItem.SDCHType;  
  
		entity.SDCHNum = inputItem.SDCHNum;  
  
		entity.SDCHLocalNum = inputItem.SDCHLocalNum;  
  
		entity.SDCHDate = inputItem.SDCHDate;  
  
		entity.SDCHDescr = inputItem.SDCHDescr;  
  
		entity.SDCHAccPrd = inputItem.SDCHAccPrd;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SDCHState = inputItem.SDCHState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleDebCreHdrDto Map(SleDebCreHdr inputItem)
        {
            var dto = new SleDebCreHdrDto()
            {
                  
  
		SleDebCreHdrId = inputItem.SleDebCreHdrId,  
  
		SDCHBranchRef = inputItem.SDCHBranchRef,  
  
		SDCHType = inputItem.SDCHType,  
  
		SDCHNum = inputItem.SDCHNum,  
  
		SDCHLocalNum = inputItem.SDCHLocalNum,  
  
		SDCHDate = inputItem.SDCHDate,  
  
		SDCHDescr = inputItem.SDCHDescr,  
  
		SDCHAccPrd = inputItem.SDCHAccPrd,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SDCHState = inputItem.SDCHState, 
            };
            return dto;
        }

        public static List<SleDebCreHdrDto> Map(ICollection<SleDebCreHdr> entities)
        {
            var dtos = new List<SleDebCreHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleDebCreHdrDto()
                {
                      
  
		SleDebCreHdrId = inputItem.SleDebCreHdrId,  
  
		SDCHBranchRef = inputItem.SDCHBranchRef,  
  
		SDCHType = inputItem.SDCHType,  
  
		SDCHNum = inputItem.SDCHNum,  
  
		SDCHLocalNum = inputItem.SDCHLocalNum,  
  
		SDCHDate = inputItem.SDCHDate,  
  
		SDCHDescr = inputItem.SDCHDescr,  
  
		SDCHAccPrd = inputItem.SDCHAccPrd,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SDCHState = inputItem.SDCHState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleDebCreItm Map(AddSleDebCreItmCommand inputItem)
        {
            var entity = new SleDebCreItm() {
                  
  
		SleDebCreItmId = inputItem.SleDebCreItmId,  
  
		SleDebCreHdrRef = inputItem.SleDebCreHdrRef,  
  
		SDCISeq = inputItem.SDCISeq,  
  
		SDCIRole = inputItem.SDCIRole,  
  
		SDCIDebSL = inputItem.SDCIDebSL,  
  
		SDCIDebDL = inputItem.SDCIDebDL,  
  
		SDCIDebDL5 = inputItem.SDCIDebDL5,  
  
		SDCIDebDL6 = inputItem.SDCIDebDL6,  
  
		SDCICreSL = inputItem.SDCICreSL,  
  
		SDCICreDL = inputItem.SDCICreDL,  
  
		SDCICreDL5 = inputItem.SDCICreDL5,  
  
		SDCICreDL6 = inputItem.SDCICreDL6,  
  
		SDCIAmount = inputItem.SDCIAmount,  
  
		SDCIDescr = inputItem.SDCIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleDebCreItm Map(SleDebCreItm entity ,EditSleDebCreItmCommand inputItem)
        {
              
  
		entity.SleDebCreItmId = inputItem.SleDebCreItmId;  
  
		entity.SleDebCreHdrRef = inputItem.SleDebCreHdrRef;  
  
		entity.SDCISeq = inputItem.SDCISeq;  
  
		entity.SDCIRole = inputItem.SDCIRole;  
  
		entity.SDCIDebSL = inputItem.SDCIDebSL;  
  
		entity.SDCIDebDL = inputItem.SDCIDebDL;  
  
		entity.SDCIDebDL5 = inputItem.SDCIDebDL5;  
  
		entity.SDCIDebDL6 = inputItem.SDCIDebDL6;  
  
		entity.SDCICreSL = inputItem.SDCICreSL;  
  
		entity.SDCICreDL = inputItem.SDCICreDL;  
  
		entity.SDCICreDL5 = inputItem.SDCICreDL5;  
  
		entity.SDCICreDL6 = inputItem.SDCICreDL6;  
  
		entity.SDCIAmount = inputItem.SDCIAmount;  
  
		entity.SDCIDescr = inputItem.SDCIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleDebCreItmDto Map(SleDebCreItm inputItem)
        {
            var dto = new SleDebCreItmDto()
            {
                  
  
		SleDebCreItmId = inputItem.SleDebCreItmId,  
  
		SleDebCreHdrRef = inputItem.SleDebCreHdrRef,  
  
		SDCISeq = inputItem.SDCISeq,  
  
		SDCIRole = inputItem.SDCIRole,  
  
		SDCIDebSL = inputItem.SDCIDebSL,  
  
		SDCIDebDL = inputItem.SDCIDebDL,  
  
		SDCIDebDL5 = inputItem.SDCIDebDL5,  
  
		SDCIDebDL6 = inputItem.SDCIDebDL6,  
  
		SDCICreSL = inputItem.SDCICreSL,  
  
		SDCICreDL = inputItem.SDCICreDL,  
  
		SDCICreDL5 = inputItem.SDCICreDL5,  
  
		SDCICreDL6 = inputItem.SDCICreDL6,  
  
		SDCIAmount = inputItem.SDCIAmount,  
  
		SDCIDescr = inputItem.SDCIDescr, 
            };
            return dto;
        }

        public static List<SleDebCreItmDto> Map(ICollection<SleDebCreItm> entities)
        {
            var dtos = new List<SleDebCreItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleDebCreItmDto()
                {
                      
  
		SleDebCreItmId = inputItem.SleDebCreItmId,  
  
		SleDebCreHdrRef = inputItem.SleDebCreHdrRef,  
  
		SDCISeq = inputItem.SDCISeq,  
  
		SDCIRole = inputItem.SDCIRole,  
  
		SDCIDebSL = inputItem.SDCIDebSL,  
  
		SDCIDebDL = inputItem.SDCIDebDL,  
  
		SDCIDebDL5 = inputItem.SDCIDebDL5,  
  
		SDCIDebDL6 = inputItem.SDCIDebDL6,  
  
		SDCICreSL = inputItem.SDCICreSL,  
  
		SDCICreDL = inputItem.SDCICreDL,  
  
		SDCICreDL5 = inputItem.SDCICreDL5,  
  
		SDCICreDL6 = inputItem.SDCICreDL6,  
  
		SDCIAmount = inputItem.SDCIAmount,  
  
		SDCIDescr = inputItem.SDCIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleFixAcc Map(AddSleFixAccCommand inputItem)
        {
            var entity = new SleFixAcc() {
                  
  
		SFAGroupRef = inputItem.SFAGroupRef,  
  
		SFACstmrRcv = inputItem.SFACstmrRcv,  
  
		SFACstmrPay = inputItem.SFACstmrPay,  
  
		SFACstmrPre = inputItem.SFACstmrPre,  
  
		SFADL4Type = inputItem.SFADL4Type,  
  
		SFADL5Type = inputItem.SFADL5Type,  
  
		SFADL6Type = inputItem.SFADL6Type, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleFixAcc Map(SleFixAcc entity ,EditSleFixAccCommand inputItem)
        {
              
  
		entity.SFAGroupRef = inputItem.SFAGroupRef;  
  
		entity.SFACstmrRcv = inputItem.SFACstmrRcv;  
  
		entity.SFACstmrPay = inputItem.SFACstmrPay;  
  
		entity.SFACstmrPre = inputItem.SFACstmrPre;  
  
		entity.SFADL4Type = inputItem.SFADL4Type;  
  
		entity.SFADL5Type = inputItem.SFADL5Type;  
  
		entity.SFADL6Type = inputItem.SFADL6Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleFixAccDto Map(SleFixAcc inputItem)
        {
            var dto = new SleFixAccDto()
            {
                  
  
		SFAGroupRef = inputItem.SFAGroupRef,  
  
		SFACstmrRcv = inputItem.SFACstmrRcv,  
  
		SFACstmrPay = inputItem.SFACstmrPay,  
  
		SFACstmrPre = inputItem.SFACstmrPre,  
  
		SFADL4Type = inputItem.SFADL4Type,  
  
		SFADL5Type = inputItem.SFADL5Type,  
  
		SFADL6Type = inputItem.SFADL6Type, 
            };
            return dto;
        }

        public static List<SleFixAccDto> Map(ICollection<SleFixAcc> entities)
        {
            var dtos = new List<SleFixAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleFixAccDto()
                {
                      
  
		SFAGroupRef = inputItem.SFAGroupRef,  
  
		SFACstmrRcv = inputItem.SFACstmrRcv,  
  
		SFACstmrPay = inputItem.SFACstmrPay,  
  
		SFACstmrPre = inputItem.SFACstmrPre,  
  
		SFADL4Type = inputItem.SFADL4Type,  
  
		SFADL5Type = inputItem.SFADL5Type,  
  
		SFADL6Type = inputItem.SFADL6Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleGuaDocs Map(AddSleGuaDocsCommand inputItem)
        {
            var entity = new SleGuaDocs() {
                  
  
		SleGuaDocId = inputItem.SleGuaDocId,  
  
		SGDNum = inputItem.SGDNum,  
  
		SGDFactRef = inputItem.SGDFactRef,  
  
		SGDStDate = inputItem.SGDStDate,  
  
		SGDEnDate = inputItem.SGDEnDate,  
  
		SGDDescr = inputItem.SGDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleGuaDocs Map(SleGuaDocs entity ,EditSleGuaDocsCommand inputItem)
        {
              
  
		entity.SleGuaDocId = inputItem.SleGuaDocId;  
  
		entity.SGDNum = inputItem.SGDNum;  
  
		entity.SGDFactRef = inputItem.SGDFactRef;  
  
		entity.SGDStDate = inputItem.SGDStDate;  
  
		entity.SGDEnDate = inputItem.SGDEnDate;  
  
		entity.SGDDescr = inputItem.SGDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleGuaDocsDto Map(SleGuaDocs inputItem)
        {
            var dto = new SleGuaDocsDto()
            {
                  
  
		SleGuaDocId = inputItem.SleGuaDocId,  
  
		SGDNum = inputItem.SGDNum,  
  
		SGDFactRef = inputItem.SGDFactRef,  
  
		SGDStDate = inputItem.SGDStDate,  
  
		SGDEnDate = inputItem.SGDEnDate,  
  
		SGDDescr = inputItem.SGDDescr, 
            };
            return dto;
        }

        public static List<SleGuaDocsDto> Map(ICollection<SleGuaDocs> entities)
        {
            var dtos = new List<SleGuaDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleGuaDocsDto()
                {
                      
  
		SleGuaDocId = inputItem.SleGuaDocId,  
  
		SGDNum = inputItem.SGDNum,  
  
		SGDFactRef = inputItem.SGDFactRef,  
  
		SGDStDate = inputItem.SGDStDate,  
  
		SGDEnDate = inputItem.SGDEnDate,  
  
		SGDDescr = inputItem.SGDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleGuarantee Map(AddSleGuaranteeCommand inputItem)
        {
            var entity = new SleGuarantee() {
                  
  
		SleGuaranteeId = inputItem.SleGuaranteeId,  
  
		SGTitle = inputItem.SGTitle,  
  
		SGSLRef = inputItem.SGSLRef,  
  
		SGDL4Type = inputItem.SGDL4Type,  
  
		SGDL5Type = inputItem.SGDL5Type,  
  
		SGDL6Type = inputItem.SGDL6Type, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleGuarantee Map(SleGuarantee entity ,EditSleGuaranteeCommand inputItem)
        {
              
  
		entity.SleGuaranteeId = inputItem.SleGuaranteeId;  
  
		entity.SGTitle = inputItem.SGTitle;  
  
		entity.SGSLRef = inputItem.SGSLRef;  
  
		entity.SGDL4Type = inputItem.SGDL4Type;  
  
		entity.SGDL5Type = inputItem.SGDL5Type;  
  
		entity.SGDL6Type = inputItem.SGDL6Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleGuaranteeDto Map(SleGuarantee inputItem)
        {
            var dto = new SleGuaranteeDto()
            {
                  
  
		SleGuaranteeId = inputItem.SleGuaranteeId,  
  
		SGTitle = inputItem.SGTitle,  
  
		SGSLRef = inputItem.SGSLRef,  
  
		SGDL4Type = inputItem.SGDL4Type,  
  
		SGDL5Type = inputItem.SGDL5Type,  
  
		SGDL6Type = inputItem.SGDL6Type, 
            };
            return dto;
        }

        public static List<SleGuaranteeDto> Map(ICollection<SleGuarantee> entities)
        {
            var dtos = new List<SleGuaranteeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleGuaranteeDto()
                {
                      
  
		SleGuaranteeId = inputItem.SleGuaranteeId,  
  
		SGTitle = inputItem.SGTitle,  
  
		SGSLRef = inputItem.SGSLRef,  
  
		SGDL4Type = inputItem.SGDL4Type,  
  
		SGDL5Type = inputItem.SGDL5Type,  
  
		SGDL6Type = inputItem.SGDL6Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleLimits Map(AddSleLimitsCommand inputItem)
        {
            var entity = new SleLimits() {
                  
  
		SleLimitId = inputItem.SleLimitId,  
  
		SLDate = inputItem.SLDate,  
  
		SLType = inputItem.SLType,  
  
		SLBranchRef = inputItem.SLBranchRef,  
  
		SLCstmrGrpRef = inputItem.SLCstmrGrpRef,  
  
		SLCstmrRef = inputItem.SLCstmrRef,  
  
		SLPartGrpRef = inputItem.SLPartGrpRef,  
  
		SLPartRef = inputItem.SLPartRef,  
  
		SLPlaceRef = inputItem.SLPlaceRef,  
  
		SLSaleType = inputItem.SLSaleType,  
  
		SLMaxQty = inputItem.SLMaxQty,  
  
		SLMaxAmount = inputItem.SLMaxAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleLimits Map(SleLimits entity ,EditSleLimitsCommand inputItem)
        {
              
  
		entity.SleLimitId = inputItem.SleLimitId;  
  
		entity.SLDate = inputItem.SLDate;  
  
		entity.SLType = inputItem.SLType;  
  
		entity.SLBranchRef = inputItem.SLBranchRef;  
  
		entity.SLCstmrGrpRef = inputItem.SLCstmrGrpRef;  
  
		entity.SLCstmrRef = inputItem.SLCstmrRef;  
  
		entity.SLPartGrpRef = inputItem.SLPartGrpRef;  
  
		entity.SLPartRef = inputItem.SLPartRef;  
  
		entity.SLPlaceRef = inputItem.SLPlaceRef;  
  
		entity.SLSaleType = inputItem.SLSaleType;  
  
		entity.SLMaxQty = inputItem.SLMaxQty;  
  
		entity.SLMaxAmount = inputItem.SLMaxAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleLimitsDto Map(SleLimits inputItem)
        {
            var dto = new SleLimitsDto()
            {
                  
  
		SleLimitId = inputItem.SleLimitId,  
  
		SLDate = inputItem.SLDate,  
  
		SLType = inputItem.SLType,  
  
		SLBranchRef = inputItem.SLBranchRef,  
  
		SLCstmrGrpRef = inputItem.SLCstmrGrpRef,  
  
		SLCstmrRef = inputItem.SLCstmrRef,  
  
		SLPartGrpRef = inputItem.SLPartGrpRef,  
  
		SLPartRef = inputItem.SLPartRef,  
  
		SLPlaceRef = inputItem.SLPlaceRef,  
  
		SLSaleType = inputItem.SLSaleType,  
  
		SLMaxQty = inputItem.SLMaxQty,  
  
		SLMaxAmount = inputItem.SLMaxAmount, 
            };
            return dto;
        }

        public static List<SleLimitsDto> Map(ICollection<SleLimits> entities)
        {
            var dtos = new List<SleLimitsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleLimitsDto()
                {
                      
  
		SleLimitId = inputItem.SleLimitId,  
  
		SLDate = inputItem.SLDate,  
  
		SLType = inputItem.SLType,  
  
		SLBranchRef = inputItem.SLBranchRef,  
  
		SLCstmrGrpRef = inputItem.SLCstmrGrpRef,  
  
		SLCstmrRef = inputItem.SLCstmrRef,  
  
		SLPartGrpRef = inputItem.SLPartGrpRef,  
  
		SLPartRef = inputItem.SLPartRef,  
  
		SLPlaceRef = inputItem.SLPlaceRef,  
  
		SLSaleType = inputItem.SLSaleType,  
  
		SLMaxQty = inputItem.SLMaxQty,  
  
		SLMaxAmount = inputItem.SLMaxAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SlePlaces Map(AddSlePlacesCommand inputItem)
        {
            var entity = new SlePlaces() {
                  
  
		SalePlaceId = inputItem.SalePlaceId,  
  
		SalePlaceName = inputItem.SalePlaceName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SlePlaces Map(SlePlaces entity ,EditSlePlacesCommand inputItem)
        {
              
  
		entity.SalePlaceId = inputItem.SalePlaceId;  
  
		entity.SalePlaceName = inputItem.SalePlaceName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SlePlacesDto Map(SlePlaces inputItem)
        {
            var dto = new SlePlacesDto()
            {
                  
  
		SalePlaceId = inputItem.SalePlaceId,  
  
		SalePlaceName = inputItem.SalePlaceName, 
            };
            return dto;
        }

        public static List<SlePlacesDto> Map(ICollection<SlePlaces> entities)
        {
            var dtos = new List<SlePlacesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SlePlacesDto()
                {
                      
  
		SalePlaceId = inputItem.SalePlaceId,  
  
		SalePlaceName = inputItem.SalePlaceName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SlePriceHdr Map(AddSlePriceHdrCommand inputItem)
        {
            var entity = new SlePriceHdr() {
                  
  
		SlePriceHdrID = inputItem.SlePriceHdrID,  
  
		SPHNum = inputItem.SPHNum,  
  
		SPHLocalNum = inputItem.SPHLocalNum,  
  
		SPHDate = inputItem.SPHDate,  
  
		SPHDescr = inputItem.SPHDescr,  
  
		SPHBranchRef = inputItem.SPHBranchRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SPHState = inputItem.SPHState,  
  
		SPAccPrdRef = inputItem.SPAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SlePriceHdr Map(SlePriceHdr entity ,EditSlePriceHdrCommand inputItem)
        {
              
  
		entity.SlePriceHdrID = inputItem.SlePriceHdrID;  
  
		entity.SPHNum = inputItem.SPHNum;  
  
		entity.SPHLocalNum = inputItem.SPHLocalNum;  
  
		entity.SPHDate = inputItem.SPHDate;  
  
		entity.SPHDescr = inputItem.SPHDescr;  
  
		entity.SPHBranchRef = inputItem.SPHBranchRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SPHState = inputItem.SPHState;  
  
		entity.SPAccPrdRef = inputItem.SPAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SlePriceHdrDto Map(SlePriceHdr inputItem)
        {
            var dto = new SlePriceHdrDto()
            {
                  
  
		SlePriceHdrID = inputItem.SlePriceHdrID,  
  
		SPHNum = inputItem.SPHNum,  
  
		SPHLocalNum = inputItem.SPHLocalNum,  
  
		SPHDate = inputItem.SPHDate,  
  
		SPHDescr = inputItem.SPHDescr,  
  
		SPHBranchRef = inputItem.SPHBranchRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SPHState = inputItem.SPHState,  
  
		SPAccPrdRef = inputItem.SPAccPrdRef, 
            };
            return dto;
        }

        public static List<SlePriceHdrDto> Map(ICollection<SlePriceHdr> entities)
        {
            var dtos = new List<SlePriceHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SlePriceHdrDto()
                {
                      
  
		SlePriceHdrID = inputItem.SlePriceHdrID,  
  
		SPHNum = inputItem.SPHNum,  
  
		SPHLocalNum = inputItem.SPHLocalNum,  
  
		SPHDate = inputItem.SPHDate,  
  
		SPHDescr = inputItem.SPHDescr,  
  
		SPHBranchRef = inputItem.SPHBranchRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SPHState = inputItem.SPHState,  
  
		SPAccPrdRef = inputItem.SPAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SlePriceItm Map(AddSlePriceItmCommand inputItem)
        {
            var entity = new SlePriceItm() {
                  
  
		SlePriceItmId = inputItem.SlePriceItmId,  
  
		SlePriceHdrRef = inputItem.SlePriceHdrRef,  
  
		SPISeq = inputItem.SPISeq,  
  
		SPICstmrGrpRef = inputItem.SPICstmrGrpRef,  
  
		SPIPartRef = inputItem.SPIPartRef,  
  
		SPIUnitRef = inputItem.SPIUnitRef,  
  
		SPIMinQty = inputItem.SPIMinQty,  
  
		SPIMaxQty = inputItem.SPIMaxQty,  
  
		SPIUnitPrice = inputItem.SPIUnitPrice,  
  
		SPIPriceSit = inputItem.SPIPriceSit,  
  
		SPIPartGrpRef = inputItem.SPIPartGrpRef,  
  
		SPIPlaceRef = inputItem.SPIPlaceRef,  
  
		SPISaleType = inputItem.SPISaleType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SlePriceItm Map(SlePriceItm entity ,EditSlePriceItmCommand inputItem)
        {
              
  
		entity.SlePriceItmId = inputItem.SlePriceItmId;  
  
		entity.SlePriceHdrRef = inputItem.SlePriceHdrRef;  
  
		entity.SPISeq = inputItem.SPISeq;  
  
		entity.SPICstmrGrpRef = inputItem.SPICstmrGrpRef;  
  
		entity.SPIPartRef = inputItem.SPIPartRef;  
  
		entity.SPIUnitRef = inputItem.SPIUnitRef;  
  
		entity.SPIMinQty = inputItem.SPIMinQty;  
  
		entity.SPIMaxQty = inputItem.SPIMaxQty;  
  
		entity.SPIUnitPrice = inputItem.SPIUnitPrice;  
  
		entity.SPIPriceSit = inputItem.SPIPriceSit;  
  
		entity.SPIPartGrpRef = inputItem.SPIPartGrpRef;  
  
		entity.SPIPlaceRef = inputItem.SPIPlaceRef;  
  
		entity.SPISaleType = inputItem.SPISaleType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SlePriceItmDto Map(SlePriceItm inputItem)
        {
            var dto = new SlePriceItmDto()
            {
                  
  
		SlePriceItmId = inputItem.SlePriceItmId,  
  
		SlePriceHdrRef = inputItem.SlePriceHdrRef,  
  
		SPISeq = inputItem.SPISeq,  
  
		SPICstmrGrpRef = inputItem.SPICstmrGrpRef,  
  
		SPIPartRef = inputItem.SPIPartRef,  
  
		SPIUnitRef = inputItem.SPIUnitRef,  
  
		SPIMinQty = inputItem.SPIMinQty,  
  
		SPIMaxQty = inputItem.SPIMaxQty,  
  
		SPIUnitPrice = inputItem.SPIUnitPrice,  
  
		SPIPriceSit = inputItem.SPIPriceSit,  
  
		SPIPartGrpRef = inputItem.SPIPartGrpRef,  
  
		SPIPlaceRef = inputItem.SPIPlaceRef,  
  
		SPISaleType = inputItem.SPISaleType, 
            };
            return dto;
        }

        public static List<SlePriceItmDto> Map(ICollection<SlePriceItm> entities)
        {
            var dtos = new List<SlePriceItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SlePriceItmDto()
                {
                      
  
		SlePriceItmId = inputItem.SlePriceItmId,  
  
		SlePriceHdrRef = inputItem.SlePriceHdrRef,  
  
		SPISeq = inputItem.SPISeq,  
  
		SPICstmrGrpRef = inputItem.SPICstmrGrpRef,  
  
		SPIPartRef = inputItem.SPIPartRef,  
  
		SPIUnitRef = inputItem.SPIUnitRef,  
  
		SPIMinQty = inputItem.SPIMinQty,  
  
		SPIMaxQty = inputItem.SPIMaxQty,  
  
		SPIUnitPrice = inputItem.SPIUnitPrice,  
  
		SPIPriceSit = inputItem.SPIPriceSit,  
  
		SPIPartGrpRef = inputItem.SPIPartGrpRef,  
  
		SPIPlaceRef = inputItem.SPIPlaceRef,  
  
		SPISaleType = inputItem.SPISaleType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleServices Map(AddSleServicesCommand inputItem)
        {
            var entity = new SleServices() {
                  
  
		SleServicesID = inputItem.SleServicesID,  
  
		SSTitle = inputItem.SSTitle,  
  
		SSUnitRef = inputItem.SSUnitRef,  
  
		SSSLRef = inputItem.SSSLRef,  
  
		SSDLRef = inputItem.SSDLRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSGrpRef = inputItem.SSGrpRef,  
  
		SCDL4Type = inputItem.SCDL4Type,  
  
		SCDL5Type = inputItem.SCDL5Type,  
  
		SCDL6Type = inputItem.SCDL6Type, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleServices Map(SleServices entity ,EditSleServicesCommand inputItem)
        {
              
  
		entity.SleServicesID = inputItem.SleServicesID;  
  
		entity.SSTitle = inputItem.SSTitle;  
  
		entity.SSUnitRef = inputItem.SSUnitRef;  
  
		entity.SSSLRef = inputItem.SSSLRef;  
  
		entity.SSDLRef = inputItem.SSDLRef;  
  
		entity.SSCode = inputItem.SSCode;  
  
		entity.SSGrpRef = inputItem.SSGrpRef;  
  
		entity.SCDL4Type = inputItem.SCDL4Type;  
  
		entity.SCDL5Type = inputItem.SCDL5Type;  
  
		entity.SCDL6Type = inputItem.SCDL6Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleServicesDto Map(SleServices inputItem)
        {
            var dto = new SleServicesDto()
            {
                  
  
		SleServicesID = inputItem.SleServicesID,  
  
		SSTitle = inputItem.SSTitle,  
  
		SSUnitRef = inputItem.SSUnitRef,  
  
		SSSLRef = inputItem.SSSLRef,  
  
		SSDLRef = inputItem.SSDLRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSGrpRef = inputItem.SSGrpRef,  
  
		SCDL4Type = inputItem.SCDL4Type,  
  
		SCDL5Type = inputItem.SCDL5Type,  
  
		SCDL6Type = inputItem.SCDL6Type, 
            };
            return dto;
        }

        public static List<SleServicesDto> Map(ICollection<SleServices> entities)
        {
            var dtos = new List<SleServicesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleServicesDto()
                {
                      
  
		SleServicesID = inputItem.SleServicesID,  
  
		SSTitle = inputItem.SSTitle,  
  
		SSUnitRef = inputItem.SSUnitRef,  
  
		SSSLRef = inputItem.SSSLRef,  
  
		SSDLRef = inputItem.SSDLRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSGrpRef = inputItem.SSGrpRef,  
  
		SCDL4Type = inputItem.SCDL4Type,  
  
		SCDL5Type = inputItem.SCDL5Type,  
  
		SCDL6Type = inputItem.SCDL6Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvGroups Map(AddSleSrvGroupsCommand inputItem)
        {
            var entity = new SleSrvGroups() {
                  
  
		SleSrvGroupsId = inputItem.SleSrvGroupsId,  
  
		SSGParent = inputItem.SSGParent,  
  
		SSGCode = inputItem.SSGCode,  
  
		SSGTitle = inputItem.SSGTitle,  
  
		SSGDLRef = inputItem.SSGDLRef,  
  
		SSGMainRoot = inputItem.SSGMainRoot, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvGroups Map(SleSrvGroups entity ,EditSleSrvGroupsCommand inputItem)
        {
              
  
		entity.SleSrvGroupsId = inputItem.SleSrvGroupsId;  
  
		entity.SSGParent = inputItem.SSGParent;  
  
		entity.SSGCode = inputItem.SSGCode;  
  
		entity.SSGTitle = inputItem.SSGTitle;  
  
		entity.SSGDLRef = inputItem.SSGDLRef;  
  
		entity.SSGMainRoot = inputItem.SSGMainRoot; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvGroupsDto Map(SleSrvGroups inputItem)
        {
            var dto = new SleSrvGroupsDto()
            {
                  
  
		SleSrvGroupsId = inputItem.SleSrvGroupsId,  
  
		SSGParent = inputItem.SSGParent,  
  
		SSGCode = inputItem.SSGCode,  
  
		SSGTitle = inputItem.SSGTitle,  
  
		SSGDLRef = inputItem.SSGDLRef,  
  
		SSGMainRoot = inputItem.SSGMainRoot, 
            };
            return dto;
        }

        public static List<SleSrvGroupsDto> Map(ICollection<SleSrvGroups> entities)
        {
            var dtos = new List<SleSrvGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvGroupsDto()
                {
                      
  
		SleSrvGroupsId = inputItem.SleSrvGroupsId,  
  
		SSGParent = inputItem.SSGParent,  
  
		SSGCode = inputItem.SSGCode,  
  
		SSGTitle = inputItem.SSGTitle,  
  
		SSGDLRef = inputItem.SSGDLRef,  
  
		SSGMainRoot = inputItem.SSGMainRoot, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvHdr Map(AddSleSrvHdrCommand inputItem)
        {
            var entity = new SleSrvHdr() {
                  
  
		SleSrvHdrID = inputItem.SleSrvHdrID,  
  
		SSHNum = inputItem.SSHNum,  
  
		SSHLocalNum = inputItem.SSHLocalNum,  
  
		SSHDate = inputItem.SSHDate,  
  
		SSHDescr = inputItem.SSHDescr,  
  
		SSHBranchRef = inputItem.SSHBranchRef,  
  
		SSHPlaceRef = inputItem.SSHPlaceRef,  
  
		SSHCstmrRef = inputItem.SSHCstmrRef,  
  
		SSHBrokerRef = inputItem.SSHBrokerRef,  
  
		SSHSaleType = inputItem.SSHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSHState = inputItem.SSHState,  
  
		SrAccPrdRef = inputItem.SrAccPrdRef,  
  
		SSHCurRef = inputItem.SSHCurRef,  
  
		SSHCurRate = inputItem.SSHCurRate,  
  
		SSHCstmrECode = inputItem.SSHCstmrECode,  
  
		SSHCstmrNatCode = inputItem.SSHCstmrNatCode,  
  
		SSHCstmrRegNo = inputItem.SSHCstmrRegNo,  
  
		SSHCstmrName = inputItem.SSHCstmrName,  
  
		SSHCstmrTel = inputItem.SSHCstmrTel,  
  
		SSHCstmrAddr = inputItem.SSHCstmrAddr,  
  
		SSHCstmrPostCode = inputItem.SSHCstmrPostCode,  
  
		SSHRefId = inputItem.SSHRefId,  
  
		SSHRefType = inputItem.SSHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvHdr Map(SleSrvHdr entity ,EditSleSrvHdrCommand inputItem)
        {
              
  
		entity.SleSrvHdrID = inputItem.SleSrvHdrID;  
  
		entity.SSHNum = inputItem.SSHNum;  
  
		entity.SSHLocalNum = inputItem.SSHLocalNum;  
  
		entity.SSHDate = inputItem.SSHDate;  
  
		entity.SSHDescr = inputItem.SSHDescr;  
  
		entity.SSHBranchRef = inputItem.SSHBranchRef;  
  
		entity.SSHPlaceRef = inputItem.SSHPlaceRef;  
  
		entity.SSHCstmrRef = inputItem.SSHCstmrRef;  
  
		entity.SSHBrokerRef = inputItem.SSHBrokerRef;  
  
		entity.SSHSaleType = inputItem.SSHSaleType;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SSHState = inputItem.SSHState;  
  
		entity.SrAccPrdRef = inputItem.SrAccPrdRef;  
  
		entity.SSHCurRef = inputItem.SSHCurRef;  
  
		entity.SSHCurRate = inputItem.SSHCurRate;  
  
		entity.SSHCstmrECode = inputItem.SSHCstmrECode;  
  
		entity.SSHCstmrNatCode = inputItem.SSHCstmrNatCode;  
  
		entity.SSHCstmrRegNo = inputItem.SSHCstmrRegNo;  
  
		entity.SSHCstmrName = inputItem.SSHCstmrName;  
  
		entity.SSHCstmrTel = inputItem.SSHCstmrTel;  
  
		entity.SSHCstmrAddr = inputItem.SSHCstmrAddr;  
  
		entity.SSHCstmrPostCode = inputItem.SSHCstmrPostCode;  
  
		entity.SSHRefId = inputItem.SSHRefId;  
  
		entity.SSHRefType = inputItem.SSHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvHdrDto Map(SleSrvHdr inputItem)
        {
            var dto = new SleSrvHdrDto()
            {
                  
  
		SleSrvHdrID = inputItem.SleSrvHdrID,  
  
		SSHNum = inputItem.SSHNum,  
  
		SSHLocalNum = inputItem.SSHLocalNum,  
  
		SSHDate = inputItem.SSHDate,  
  
		SSHDescr = inputItem.SSHDescr,  
  
		SSHBranchRef = inputItem.SSHBranchRef,  
  
		SSHPlaceRef = inputItem.SSHPlaceRef,  
  
		SSHCstmrRef = inputItem.SSHCstmrRef,  
  
		SSHBrokerRef = inputItem.SSHBrokerRef,  
  
		SSHSaleType = inputItem.SSHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSHState = inputItem.SSHState,  
  
		SrAccPrdRef = inputItem.SrAccPrdRef,  
  
		SSHCurRef = inputItem.SSHCurRef,  
  
		SSHCurRate = inputItem.SSHCurRate,  
  
		SSHCstmrECode = inputItem.SSHCstmrECode,  
  
		SSHCstmrNatCode = inputItem.SSHCstmrNatCode,  
  
		SSHCstmrRegNo = inputItem.SSHCstmrRegNo,  
  
		SSHCstmrName = inputItem.SSHCstmrName,  
  
		SSHCstmrTel = inputItem.SSHCstmrTel,  
  
		SSHCstmrAddr = inputItem.SSHCstmrAddr,  
  
		SSHCstmrPostCode = inputItem.SSHCstmrPostCode,  
  
		SSHRefId = inputItem.SSHRefId,  
  
		SSHRefType = inputItem.SSHRefType, 
            };
            return dto;
        }

        public static List<SleSrvHdrDto> Map(ICollection<SleSrvHdr> entities)
        {
            var dtos = new List<SleSrvHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvHdrDto()
                {
                      
  
		SleSrvHdrID = inputItem.SleSrvHdrID,  
  
		SSHNum = inputItem.SSHNum,  
  
		SSHLocalNum = inputItem.SSHLocalNum,  
  
		SSHDate = inputItem.SSHDate,  
  
		SSHDescr = inputItem.SSHDescr,  
  
		SSHBranchRef = inputItem.SSHBranchRef,  
  
		SSHPlaceRef = inputItem.SSHPlaceRef,  
  
		SSHCstmrRef = inputItem.SSHCstmrRef,  
  
		SSHBrokerRef = inputItem.SSHBrokerRef,  
  
		SSHSaleType = inputItem.SSHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSHState = inputItem.SSHState,  
  
		SrAccPrdRef = inputItem.SrAccPrdRef,  
  
		SSHCurRef = inputItem.SSHCurRef,  
  
		SSHCurRate = inputItem.SSHCurRate,  
  
		SSHCstmrECode = inputItem.SSHCstmrECode,  
  
		SSHCstmrNatCode = inputItem.SSHCstmrNatCode,  
  
		SSHCstmrRegNo = inputItem.SSHCstmrRegNo,  
  
		SSHCstmrName = inputItem.SSHCstmrName,  
  
		SSHCstmrTel = inputItem.SSHCstmrTel,  
  
		SSHCstmrAddr = inputItem.SSHCstmrAddr,  
  
		SSHCstmrPostCode = inputItem.SSHCstmrPostCode,  
  
		SSHRefId = inputItem.SSHRefId,  
  
		SSHRefType = inputItem.SSHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvItm Map(AddSleSrvItmCommand inputItem)
        {
            var entity = new SleSrvItm() {
                  
  
		SleSrvItmId = inputItem.SleSrvItmId,  
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SSISeq = inputItem.SSISeq,  
  
		SSIServiceRef = inputItem.SSIServiceRef,  
  
		SSIUnitRef = inputItem.SSIUnitRef,  
  
		SSIMainQty = inputItem.SSIMainQty,  
  
		SSIAmount = inputItem.SSIAmount,  
  
		SSIDescr = inputItem.SSIDescr,  
  
		SSICurVal = inputItem.SSICurVal,  
  
		SSIRefId = inputItem.SSIRefId,  
  
		SSIRefType = inputItem.SSIRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvItm Map(SleSrvItm entity ,EditSleSrvItmCommand inputItem)
        {
              
  
		entity.SleSrvItmId = inputItem.SleSrvItmId;  
  
		entity.SleSrvHdrRef = inputItem.SleSrvHdrRef;  
  
		entity.SSISeq = inputItem.SSISeq;  
  
		entity.SSIServiceRef = inputItem.SSIServiceRef;  
  
		entity.SSIUnitRef = inputItem.SSIUnitRef;  
  
		entity.SSIMainQty = inputItem.SSIMainQty;  
  
		entity.SSIAmount = inputItem.SSIAmount;  
  
		entity.SSIDescr = inputItem.SSIDescr;  
  
		entity.SSICurVal = inputItem.SSICurVal;  
  
		entity.SSIRefId = inputItem.SSIRefId;  
  
		entity.SSIRefType = inputItem.SSIRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvItmDto Map(SleSrvItm inputItem)
        {
            var dto = new SleSrvItmDto()
            {
                  
  
		SleSrvItmId = inputItem.SleSrvItmId,  
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SSISeq = inputItem.SSISeq,  
  
		SSIServiceRef = inputItem.SSIServiceRef,  
  
		SSIUnitRef = inputItem.SSIUnitRef,  
  
		SSIMainQty = inputItem.SSIMainQty,  
  
		SSIAmount = inputItem.SSIAmount,  
  
		SSIDescr = inputItem.SSIDescr,  
  
		SSICurVal = inputItem.SSICurVal,  
  
		SSIRefId = inputItem.SSIRefId,  
  
		SSIRefType = inputItem.SSIRefType, 
            };
            return dto;
        }

        public static List<SleSrvItmDto> Map(ICollection<SleSrvItm> entities)
        {
            var dtos = new List<SleSrvItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvItmDto()
                {
                      
  
		SleSrvItmId = inputItem.SleSrvItmId,  
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SSISeq = inputItem.SSISeq,  
  
		SSIServiceRef = inputItem.SSIServiceRef,  
  
		SSIUnitRef = inputItem.SSIUnitRef,  
  
		SSIMainQty = inputItem.SSIMainQty,  
  
		SSIAmount = inputItem.SSIAmount,  
  
		SSIDescr = inputItem.SSIDescr,  
  
		SSICurVal = inputItem.SSICurVal,  
  
		SSIRefId = inputItem.SSIRefId,  
  
		SSIRefType = inputItem.SSIRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvPrcHdr Map(AddSleSrvPrcHdrCommand inputItem)
        {
            var entity = new SleSrvPrcHdr() {
                  
  
		SleSrvPrcHdrID = inputItem.SleSrvPrcHdrID,  
  
		SSPHBranchRef = inputItem.SSPHBranchRef,  
  
		SSPHNum = inputItem.SSPHNum,  
  
		SSPHLocalNum = inputItem.SSPHLocalNum,  
  
		SSPHDate = inputItem.SSPHDate,  
  
		SSPHDescr = inputItem.SSPHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSPHState = inputItem.SSPHState,  
  
		SSPAccPrdRef = inputItem.SSPAccPrdRef,  
  
		SSPHCurRef = inputItem.SSPHCurRef,  
  
		SSPHCurRate = inputItem.SSPHCurRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvPrcHdr Map(SleSrvPrcHdr entity ,EditSleSrvPrcHdrCommand inputItem)
        {
              
  
		entity.SleSrvPrcHdrID = inputItem.SleSrvPrcHdrID;  
  
		entity.SSPHBranchRef = inputItem.SSPHBranchRef;  
  
		entity.SSPHNum = inputItem.SSPHNum;  
  
		entity.SSPHLocalNum = inputItem.SSPHLocalNum;  
  
		entity.SSPHDate = inputItem.SSPHDate;  
  
		entity.SSPHDescr = inputItem.SSPHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SSPHState = inputItem.SSPHState;  
  
		entity.SSPAccPrdRef = inputItem.SSPAccPrdRef;  
  
		entity.SSPHCurRef = inputItem.SSPHCurRef;  
  
		entity.SSPHCurRate = inputItem.SSPHCurRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvPrcHdrDto Map(SleSrvPrcHdr inputItem)
        {
            var dto = new SleSrvPrcHdrDto()
            {
                  
  
		SleSrvPrcHdrID = inputItem.SleSrvPrcHdrID,  
  
		SSPHBranchRef = inputItem.SSPHBranchRef,  
  
		SSPHNum = inputItem.SSPHNum,  
  
		SSPHLocalNum = inputItem.SSPHLocalNum,  
  
		SSPHDate = inputItem.SSPHDate,  
  
		SSPHDescr = inputItem.SSPHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSPHState = inputItem.SSPHState,  
  
		SSPAccPrdRef = inputItem.SSPAccPrdRef,  
  
		SSPHCurRef = inputItem.SSPHCurRef,  
  
		SSPHCurRate = inputItem.SSPHCurRate, 
            };
            return dto;
        }

        public static List<SleSrvPrcHdrDto> Map(ICollection<SleSrvPrcHdr> entities)
        {
            var dtos = new List<SleSrvPrcHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvPrcHdrDto()
                {
                      
  
		SleSrvPrcHdrID = inputItem.SleSrvPrcHdrID,  
  
		SSPHBranchRef = inputItem.SSPHBranchRef,  
  
		SSPHNum = inputItem.SSPHNum,  
  
		SSPHLocalNum = inputItem.SSPHLocalNum,  
  
		SSPHDate = inputItem.SSPHDate,  
  
		SSPHDescr = inputItem.SSPHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SSPHState = inputItem.SSPHState,  
  
		SSPAccPrdRef = inputItem.SSPAccPrdRef,  
  
		SSPHCurRef = inputItem.SSPHCurRef,  
  
		SSPHCurRate = inputItem.SSPHCurRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvPrcItm Map(AddSleSrvPrcItmCommand inputItem)
        {
            var entity = new SleSrvPrcItm() {
                  
  
		SleSrvPrcItmId = inputItem.SleSrvPrcItmId,  
  
		SleSrvPrcHdrRef = inputItem.SleSrvPrcHdrRef,  
  
		SSPISeq = inputItem.SSPISeq,  
  
		SSPIItemRef = inputItem.SSPIItemRef,  
  
		SSPIUnitRef = inputItem.SSPIUnitRef,  
  
		SSPIMinQty = inputItem.SSPIMinQty,  
  
		SSPIMaxQty = inputItem.SSPIMaxQty,  
  
		SSPIUnitSrvPrc = inputItem.SSPIUnitSrvPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvPrcItm Map(SleSrvPrcItm entity ,EditSleSrvPrcItmCommand inputItem)
        {
              
  
		entity.SleSrvPrcItmId = inputItem.SleSrvPrcItmId;  
  
		entity.SleSrvPrcHdrRef = inputItem.SleSrvPrcHdrRef;  
  
		entity.SSPISeq = inputItem.SSPISeq;  
  
		entity.SSPIItemRef = inputItem.SSPIItemRef;  
  
		entity.SSPIUnitRef = inputItem.SSPIUnitRef;  
  
		entity.SSPIMinQty = inputItem.SSPIMinQty;  
  
		entity.SSPIMaxQty = inputItem.SSPIMaxQty;  
  
		entity.SSPIUnitSrvPrc = inputItem.SSPIUnitSrvPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvPrcItmDto Map(SleSrvPrcItm inputItem)
        {
            var dto = new SleSrvPrcItmDto()
            {
                  
  
		SleSrvPrcItmId = inputItem.SleSrvPrcItmId,  
  
		SleSrvPrcHdrRef = inputItem.SleSrvPrcHdrRef,  
  
		SSPISeq = inputItem.SSPISeq,  
  
		SSPIItemRef = inputItem.SSPIItemRef,  
  
		SSPIUnitRef = inputItem.SSPIUnitRef,  
  
		SSPIMinQty = inputItem.SSPIMinQty,  
  
		SSPIMaxQty = inputItem.SSPIMaxQty,  
  
		SSPIUnitSrvPrc = inputItem.SSPIUnitSrvPrc, 
            };
            return dto;
        }

        public static List<SleSrvPrcItmDto> Map(ICollection<SleSrvPrcItm> entities)
        {
            var dtos = new List<SleSrvPrcItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvPrcItmDto()
                {
                      
  
		SleSrvPrcItmId = inputItem.SleSrvPrcItmId,  
  
		SleSrvPrcHdrRef = inputItem.SleSrvPrcHdrRef,  
  
		SSPISeq = inputItem.SSPISeq,  
  
		SSPIItemRef = inputItem.SSPIItemRef,  
  
		SSPIUnitRef = inputItem.SSPIUnitRef,  
  
		SSPIMinQty = inputItem.SSPIMinQty,  
  
		SSPIMaxQty = inputItem.SSPIMaxQty,  
  
		SSPIUnitSrvPrc = inputItem.SSPIUnitSrvPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleSrvTax Map(AddSleSrvTaxCommand inputItem)
        {
            var entity = new SleSrvTax() {
                  
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SleSrvItmRef = inputItem.SleSrvItmRef,  
  
		SSTTaxRef = inputItem.SSTTaxRef,  
  
		SSTTaxAmount = inputItem.SSTTaxAmount,  
  
		SSTAmount = inputItem.SSTAmount,  
  
		SSTCurVal = inputItem.SSTCurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleSrvTax Map(SleSrvTax entity ,EditSleSrvTaxCommand inputItem)
        {
              
  
		entity.SleSrvHdrRef = inputItem.SleSrvHdrRef;  
  
		entity.SleSrvItmRef = inputItem.SleSrvItmRef;  
  
		entity.SSTTaxRef = inputItem.SSTTaxRef;  
  
		entity.SSTTaxAmount = inputItem.SSTTaxAmount;  
  
		entity.SSTAmount = inputItem.SSTAmount;  
  
		entity.SSTCurVal = inputItem.SSTCurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleSrvTaxDto Map(SleSrvTax inputItem)
        {
            var dto = new SleSrvTaxDto()
            {
                  
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SleSrvItmRef = inputItem.SleSrvItmRef,  
  
		SSTTaxRef = inputItem.SSTTaxRef,  
  
		SSTTaxAmount = inputItem.SSTTaxAmount,  
  
		SSTAmount = inputItem.SSTAmount,  
  
		SSTCurVal = inputItem.SSTCurVal, 
            };
            return dto;
        }

        public static List<SleSrvTaxDto> Map(ICollection<SleSrvTax> entities)
        {
            var dtos = new List<SleSrvTaxDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleSrvTaxDto()
                {
                      
  
		SleSrvHdrRef = inputItem.SleSrvHdrRef,  
  
		SleSrvItmRef = inputItem.SleSrvItmRef,  
  
		SSTTaxRef = inputItem.SSTTaxRef,  
  
		SSTTaxAmount = inputItem.SSTTaxAmount,  
  
		SSTAmount = inputItem.SSTAmount,  
  
		SSTCurVal = inputItem.SSTCurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleTaxDefVal Map(AddSleTaxDefValCommand inputItem)
        {
            var entity = new SleTaxDefVal() {
                  
  
		SleTaxDefValId = inputItem.SleTaxDefValId,  
  
		STDVTaxRef = inputItem.STDVTaxRef,  
  
		STDVBranchRef = inputItem.STDVBranchRef,  
  
		STDVCstmrRef = inputItem.STDVCstmrRef,  
  
		STDVPartRef = inputItem.STDVPartRef,  
  
		STDVPartGrpRef = inputItem.STDVPartGrpRef,  
  
		STDVPlaceRef = inputItem.STDVPlaceRef,  
  
		STDVSaleType = inputItem.STDVSaleType,  
  
		STDVDate = inputItem.STDVDate,  
  
		STDVAmount = inputItem.STDVAmount,  
  
		STDVFQty = inputItem.STDVFQty,  
  
		STDVEQty = inputItem.STDVEQty,  
  
		STDVFAmnt = inputItem.STDVFAmnt,  
  
		STDVEAmnt = inputItem.STDVEAmnt,  
  
		STDVDur = inputItem.STDVDur,  
  
		STDVCstmrGrpRef = inputItem.STDVCstmrGrpRef,  
  
		STDVCalcMethod = inputItem.STDVCalcMethod,  
  
		STDVCalcType = inputItem.STDVCalcType,  
  
		STDVFDate = inputItem.STDVFDate,  
  
		STDVEDate = inputItem.STDVEDate,  
  
		STDVRangeAll = inputItem.STDVRangeAll,  
  
		STDVType = inputItem.STDVType,  
  
		STDVServiceRef = inputItem.STDVServiceRef,  
  
		STDVSrvGrpRef = inputItem.STDVSrvGrpRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleTaxDefVal Map(SleTaxDefVal entity ,EditSleTaxDefValCommand inputItem)
        {
              
  
		entity.SleTaxDefValId = inputItem.SleTaxDefValId;  
  
		entity.STDVTaxRef = inputItem.STDVTaxRef;  
  
		entity.STDVBranchRef = inputItem.STDVBranchRef;  
  
		entity.STDVCstmrRef = inputItem.STDVCstmrRef;  
  
		entity.STDVPartRef = inputItem.STDVPartRef;  
  
		entity.STDVPartGrpRef = inputItem.STDVPartGrpRef;  
  
		entity.STDVPlaceRef = inputItem.STDVPlaceRef;  
  
		entity.STDVSaleType = inputItem.STDVSaleType;  
  
		entity.STDVDate = inputItem.STDVDate;  
  
		entity.STDVAmount = inputItem.STDVAmount;  
  
		entity.STDVFQty = inputItem.STDVFQty;  
  
		entity.STDVEQty = inputItem.STDVEQty;  
  
		entity.STDVFAmnt = inputItem.STDVFAmnt;  
  
		entity.STDVEAmnt = inputItem.STDVEAmnt;  
  
		entity.STDVDur = inputItem.STDVDur;  
  
		entity.STDVCstmrGrpRef = inputItem.STDVCstmrGrpRef;  
  
		entity.STDVCalcMethod = inputItem.STDVCalcMethod;  
  
		entity.STDVCalcType = inputItem.STDVCalcType;  
  
		entity.STDVFDate = inputItem.STDVFDate;  
  
		entity.STDVEDate = inputItem.STDVEDate;  
  
		entity.STDVRangeAll = inputItem.STDVRangeAll;  
  
		entity.STDVType = inputItem.STDVType;  
  
		entity.STDVServiceRef = inputItem.STDVServiceRef;  
  
		entity.STDVSrvGrpRef = inputItem.STDVSrvGrpRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleTaxDefValDto Map(SleTaxDefVal inputItem)
        {
            var dto = new SleTaxDefValDto()
            {
                  
  
		SleTaxDefValId = inputItem.SleTaxDefValId,  
  
		STDVTaxRef = inputItem.STDVTaxRef,  
  
		STDVBranchRef = inputItem.STDVBranchRef,  
  
		STDVCstmrRef = inputItem.STDVCstmrRef,  
  
		STDVPartRef = inputItem.STDVPartRef,  
  
		STDVPartGrpRef = inputItem.STDVPartGrpRef,  
  
		STDVPlaceRef = inputItem.STDVPlaceRef,  
  
		STDVSaleType = inputItem.STDVSaleType,  
  
		STDVDate = inputItem.STDVDate,  
  
		STDVAmount = inputItem.STDVAmount,  
  
		STDVFQty = inputItem.STDVFQty,  
  
		STDVEQty = inputItem.STDVEQty,  
  
		STDVFAmnt = inputItem.STDVFAmnt,  
  
		STDVEAmnt = inputItem.STDVEAmnt,  
  
		STDVDur = inputItem.STDVDur,  
  
		STDVCstmrGrpRef = inputItem.STDVCstmrGrpRef,  
  
		STDVCalcMethod = inputItem.STDVCalcMethod,  
  
		STDVCalcType = inputItem.STDVCalcType,  
  
		STDVFDate = inputItem.STDVFDate,  
  
		STDVEDate = inputItem.STDVEDate,  
  
		STDVRangeAll = inputItem.STDVRangeAll,  
  
		STDVType = inputItem.STDVType,  
  
		STDVServiceRef = inputItem.STDVServiceRef,  
  
		STDVSrvGrpRef = inputItem.STDVSrvGrpRef, 
            };
            return dto;
        }

        public static List<SleTaxDefValDto> Map(ICollection<SleTaxDefVal> entities)
        {
            var dtos = new List<SleTaxDefValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleTaxDefValDto()
                {
                      
  
		SleTaxDefValId = inputItem.SleTaxDefValId,  
  
		STDVTaxRef = inputItem.STDVTaxRef,  
  
		STDVBranchRef = inputItem.STDVBranchRef,  
  
		STDVCstmrRef = inputItem.STDVCstmrRef,  
  
		STDVPartRef = inputItem.STDVPartRef,  
  
		STDVPartGrpRef = inputItem.STDVPartGrpRef,  
  
		STDVPlaceRef = inputItem.STDVPlaceRef,  
  
		STDVSaleType = inputItem.STDVSaleType,  
  
		STDVDate = inputItem.STDVDate,  
  
		STDVAmount = inputItem.STDVAmount,  
  
		STDVFQty = inputItem.STDVFQty,  
  
		STDVEQty = inputItem.STDVEQty,  
  
		STDVFAmnt = inputItem.STDVFAmnt,  
  
		STDVEAmnt = inputItem.STDVEAmnt,  
  
		STDVDur = inputItem.STDVDur,  
  
		STDVCstmrGrpRef = inputItem.STDVCstmrGrpRef,  
  
		STDVCalcMethod = inputItem.STDVCalcMethod,  
  
		STDVCalcType = inputItem.STDVCalcType,  
  
		STDVFDate = inputItem.STDVFDate,  
  
		STDVEDate = inputItem.STDVEDate,  
  
		STDVRangeAll = inputItem.STDVRangeAll,  
  
		STDVType = inputItem.STDVType,  
  
		STDVServiceRef = inputItem.STDVServiceRef,  
  
		STDVSrvGrpRef = inputItem.STDVSrvGrpRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleTaxes Map(AddSleTaxesCommand inputItem)
        {
            var entity = new SleTaxes() {
                  
  
		SleTaxId = inputItem.SleTaxId,  
  
		SleTaxName = inputItem.SleTaxName,  
  
		STTaxType = inputItem.STTaxType,  
  
		STCalcType = inputItem.STCalcType,  
  
		STOprType = inputItem.STOprType,  
  
		STPriority = inputItem.STPriority,  
  
		STPrintPrv = inputItem.STPrintPrv,  
  
		STForce = inputItem.STForce,  
  
		STValType = inputItem.STValType,  
  
		STPrionType = inputItem.STPrionType,  
  
		STMethodType = inputItem.STMethodType,  
  
		STSLRef = inputItem.STSLRef,  
  
		STDL4Type = inputItem.STDL4Type,  
  
		STDL4Code = inputItem.STDL4Code,  
  
		STDL5Type = inputItem.STDL5Type,  
  
		STDL5Code = inputItem.STDL5Code,  
  
		STDL6Type = inputItem.STDL6Type,  
  
		STDL6Code = inputItem.STDL6Code,  
  
		STEffElmnt = inputItem.STEffElmnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleTaxes Map(SleTaxes entity ,EditSleTaxesCommand inputItem)
        {
              
  
		entity.SleTaxId = inputItem.SleTaxId;  
  
		entity.SleTaxName = inputItem.SleTaxName;  
  
		entity.STTaxType = inputItem.STTaxType;  
  
		entity.STCalcType = inputItem.STCalcType;  
  
		entity.STOprType = inputItem.STOprType;  
  
		entity.STPriority = inputItem.STPriority;  
  
		entity.STPrintPrv = inputItem.STPrintPrv;  
  
		entity.STForce = inputItem.STForce;  
  
		entity.STValType = inputItem.STValType;  
  
		entity.STPrionType = inputItem.STPrionType;  
  
		entity.STMethodType = inputItem.STMethodType;  
  
		entity.STSLRef = inputItem.STSLRef;  
  
		entity.STDL4Type = inputItem.STDL4Type;  
  
		entity.STDL4Code = inputItem.STDL4Code;  
  
		entity.STDL5Type = inputItem.STDL5Type;  
  
		entity.STDL5Code = inputItem.STDL5Code;  
  
		entity.STDL6Type = inputItem.STDL6Type;  
  
		entity.STDL6Code = inputItem.STDL6Code;  
  
		entity.STEffElmnt = inputItem.STEffElmnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleTaxesDto Map(SleTaxes inputItem)
        {
            var dto = new SleTaxesDto()
            {
                  
  
		SleTaxId = inputItem.SleTaxId,  
  
		SleTaxName = inputItem.SleTaxName,  
  
		STTaxType = inputItem.STTaxType,  
  
		STCalcType = inputItem.STCalcType,  
  
		STOprType = inputItem.STOprType,  
  
		STPriority = inputItem.STPriority,  
  
		STPrintPrv = inputItem.STPrintPrv,  
  
		STForce = inputItem.STForce,  
  
		STValType = inputItem.STValType,  
  
		STPrionType = inputItem.STPrionType,  
  
		STMethodType = inputItem.STMethodType,  
  
		STSLRef = inputItem.STSLRef,  
  
		STDL4Type = inputItem.STDL4Type,  
  
		STDL4Code = inputItem.STDL4Code,  
  
		STDL5Type = inputItem.STDL5Type,  
  
		STDL5Code = inputItem.STDL5Code,  
  
		STDL6Type = inputItem.STDL6Type,  
  
		STDL6Code = inputItem.STDL6Code,  
  
		STEffElmnt = inputItem.STEffElmnt, 
            };
            return dto;
        }

        public static List<SleTaxesDto> Map(ICollection<SleTaxes> entities)
        {
            var dtos = new List<SleTaxesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleTaxesDto()
                {
                      
  
		SleTaxId = inputItem.SleTaxId,  
  
		SleTaxName = inputItem.SleTaxName,  
  
		STTaxType = inputItem.STTaxType,  
  
		STCalcType = inputItem.STCalcType,  
  
		STOprType = inputItem.STOprType,  
  
		STPriority = inputItem.STPriority,  
  
		STPrintPrv = inputItem.STPrintPrv,  
  
		STForce = inputItem.STForce,  
  
		STValType = inputItem.STValType,  
  
		STPrionType = inputItem.STPrionType,  
  
		STMethodType = inputItem.STMethodType,  
  
		STSLRef = inputItem.STSLRef,  
  
		STDL4Type = inputItem.STDL4Type,  
  
		STDL4Code = inputItem.STDL4Code,  
  
		STDL5Type = inputItem.STDL5Type,  
  
		STDL5Code = inputItem.STDL5Code,  
  
		STDL6Type = inputItem.STDL6Type,  
  
		STDL6Code = inputItem.STDL6Code,  
  
		STEffElmnt = inputItem.STEffElmnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleTypes Map(AddSleTypesCommand inputItem)
        {
            var entity = new SleTypes() {
                  
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		SaleTypeName = inputItem.SaleTypeName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleTypes Map(SleTypes entity ,EditSleTypesCommand inputItem)
        {
              
  
		entity.SaleTypeId = inputItem.SaleTypeId;  
  
		entity.SaleTypeName = inputItem.SaleTypeName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleTypesDto Map(SleTypes inputItem)
        {
            var dto = new SleTypesDto()
            {
                  
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		SaleTypeName = inputItem.SaleTypeName, 
            };
            return dto;
        }

        public static List<SleTypesDto> Map(ICollection<SleTypes> entities)
        {
            var dtos = new List<SleTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleTypesDto()
                {
                      
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		SaleTypeName = inputItem.SaleTypeName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleVchHdr Map(AddSleVchHdrCommand inputItem)
        {
            var entity = new SleVchHdr() {
                  
  
		SleVchHdrID = inputItem.SleVchHdrID,  
  
		SVHNum = inputItem.SVHNum,  
  
		SVHLocalNum = inputItem.SVHLocalNum,  
  
		SVHDate = inputItem.SVHDate,  
  
		SVHDescr = inputItem.SVHDescr,  
  
		SVHBranchRef = inputItem.SVHBranchRef,  
  
		SVHPlaceRef = inputItem.SVHPlaceRef,  
  
		SVHStockRef = inputItem.SVHStockRef,  
  
		SVHVchType = inputItem.SVHVchType,  
  
		SVHCstmrRef = inputItem.SVHCstmrRef,  
  
		SVHBrokerRef = inputItem.SVHBrokerRef,  
  
		SVHSaleType = inputItem.SVHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SVHState = inputItem.SVHState,  
  
		SAccPrdRef = inputItem.SAccPrdRef,  
  
		SVHRefID = inputItem.SVHRefID,  
  
		SVHRefType = inputItem.SVHRefType,  
  
		SVHCurRef = inputItem.SVHCurRef,  
  
		SVHCurRate = inputItem.SVHCurRate,  
  
		SVHDLRef = inputItem.SVHDLRef,  
  
		SVHCstmrECode = inputItem.SVHCstmrECode,  
  
		SVHCstmrNatCode = inputItem.SVHCstmrNatCode,  
  
		SVHCstmrRegNo = inputItem.SVHCstmrRegNo,  
  
		SVHCstmrName = inputItem.SVHCstmrName,  
  
		SVHCstmrTel = inputItem.SVHCstmrTel,  
  
		SVHCstmrAddr = inputItem.SVHCstmrAddr,  
  
		SVHCstmrPostCode = inputItem.SVHCstmrPostCode, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleVchHdr Map(SleVchHdr entity ,EditSleVchHdrCommand inputItem)
        {
              
  
		entity.SleVchHdrID = inputItem.SleVchHdrID;  
  
		entity.SVHNum = inputItem.SVHNum;  
  
		entity.SVHLocalNum = inputItem.SVHLocalNum;  
  
		entity.SVHDate = inputItem.SVHDate;  
  
		entity.SVHDescr = inputItem.SVHDescr;  
  
		entity.SVHBranchRef = inputItem.SVHBranchRef;  
  
		entity.SVHPlaceRef = inputItem.SVHPlaceRef;  
  
		entity.SVHStockRef = inputItem.SVHStockRef;  
  
		entity.SVHVchType = inputItem.SVHVchType;  
  
		entity.SVHCstmrRef = inputItem.SVHCstmrRef;  
  
		entity.SVHBrokerRef = inputItem.SVHBrokerRef;  
  
		entity.SVHSaleType = inputItem.SVHSaleType;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.SVHState = inputItem.SVHState;  
  
		entity.SAccPrdRef = inputItem.SAccPrdRef;  
  
		entity.SVHRefID = inputItem.SVHRefID;  
  
		entity.SVHRefType = inputItem.SVHRefType;  
  
		entity.SVHCurRef = inputItem.SVHCurRef;  
  
		entity.SVHCurRate = inputItem.SVHCurRate;  
  
		entity.SVHDLRef = inputItem.SVHDLRef;  
  
		entity.SVHCstmrECode = inputItem.SVHCstmrECode;  
  
		entity.SVHCstmrNatCode = inputItem.SVHCstmrNatCode;  
  
		entity.SVHCstmrRegNo = inputItem.SVHCstmrRegNo;  
  
		entity.SVHCstmrName = inputItem.SVHCstmrName;  
  
		entity.SVHCstmrTel = inputItem.SVHCstmrTel;  
  
		entity.SVHCstmrAddr = inputItem.SVHCstmrAddr;  
  
		entity.SVHCstmrPostCode = inputItem.SVHCstmrPostCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleVchHdrDto Map(SleVchHdr inputItem)
        {
            var dto = new SleVchHdrDto()
            {
                  
  
		SleVchHdrID = inputItem.SleVchHdrID,  
  
		SVHNum = inputItem.SVHNum,  
  
		SVHLocalNum = inputItem.SVHLocalNum,  
  
		SVHDate = inputItem.SVHDate,  
  
		SVHDescr = inputItem.SVHDescr,  
  
		SVHBranchRef = inputItem.SVHBranchRef,  
  
		SVHPlaceRef = inputItem.SVHPlaceRef,  
  
		SVHStockRef = inputItem.SVHStockRef,  
  
		SVHVchType = inputItem.SVHVchType,  
  
		SVHCstmrRef = inputItem.SVHCstmrRef,  
  
		SVHBrokerRef = inputItem.SVHBrokerRef,  
  
		SVHSaleType = inputItem.SVHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SVHState = inputItem.SVHState,  
  
		SAccPrdRef = inputItem.SAccPrdRef,  
  
		SVHRefID = inputItem.SVHRefID,  
  
		SVHRefType = inputItem.SVHRefType,  
  
		SVHCurRef = inputItem.SVHCurRef,  
  
		SVHCurRate = inputItem.SVHCurRate,  
  
		SVHDLRef = inputItem.SVHDLRef,  
  
		SVHCstmrECode = inputItem.SVHCstmrECode,  
  
		SVHCstmrNatCode = inputItem.SVHCstmrNatCode,  
  
		SVHCstmrRegNo = inputItem.SVHCstmrRegNo,  
  
		SVHCstmrName = inputItem.SVHCstmrName,  
  
		SVHCstmrTel = inputItem.SVHCstmrTel,  
  
		SVHCstmrAddr = inputItem.SVHCstmrAddr,  
  
		SVHCstmrPostCode = inputItem.SVHCstmrPostCode, 
            };
            return dto;
        }

        public static List<SleVchHdrDto> Map(ICollection<SleVchHdr> entities)
        {
            var dtos = new List<SleVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleVchHdrDto()
                {
                      
  
		SleVchHdrID = inputItem.SleVchHdrID,  
  
		SVHNum = inputItem.SVHNum,  
  
		SVHLocalNum = inputItem.SVHLocalNum,  
  
		SVHDate = inputItem.SVHDate,  
  
		SVHDescr = inputItem.SVHDescr,  
  
		SVHBranchRef = inputItem.SVHBranchRef,  
  
		SVHPlaceRef = inputItem.SVHPlaceRef,  
  
		SVHStockRef = inputItem.SVHStockRef,  
  
		SVHVchType = inputItem.SVHVchType,  
  
		SVHCstmrRef = inputItem.SVHCstmrRef,  
  
		SVHBrokerRef = inputItem.SVHBrokerRef,  
  
		SVHSaleType = inputItem.SVHSaleType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		SVHState = inputItem.SVHState,  
  
		SAccPrdRef = inputItem.SAccPrdRef,  
  
		SVHRefID = inputItem.SVHRefID,  
  
		SVHRefType = inputItem.SVHRefType,  
  
		SVHCurRef = inputItem.SVHCurRef,  
  
		SVHCurRate = inputItem.SVHCurRate,  
  
		SVHDLRef = inputItem.SVHDLRef,  
  
		SVHCstmrECode = inputItem.SVHCstmrECode,  
  
		SVHCstmrNatCode = inputItem.SVHCstmrNatCode,  
  
		SVHCstmrRegNo = inputItem.SVHCstmrRegNo,  
  
		SVHCstmrName = inputItem.SVHCstmrName,  
  
		SVHCstmrTel = inputItem.SVHCstmrTel,  
  
		SVHCstmrAddr = inputItem.SVHCstmrAddr,  
  
		SVHCstmrPostCode = inputItem.SVHCstmrPostCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleVchItm Map(AddSleVchItmCommand inputItem)
        {
            var entity = new SleVchItm() {
                  
  
		SleVchItmId = inputItem.SleVchItmId,  
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SVISeq = inputItem.SVISeq,  
  
		SVIPartRef = inputItem.SVIPartRef,  
  
		SVIUnitRef = inputItem.SVIUnitRef,  
  
		SVIMainQty = inputItem.SVIMainQty,  
  
		SVIOthQty = inputItem.SVIOthQty,  
  
		SVIAmount = inputItem.SVIAmount,  
  
		SVIDescr = inputItem.SVIDescr,  
  
		SVIRefID = inputItem.SVIRefID,  
  
		SVIRefType = inputItem.SVIRefType,  
  
		SVICurVal = inputItem.SVICurVal,  
  
		SVIPriceType = inputItem.SVIPriceType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleVchItm Map(SleVchItm entity ,EditSleVchItmCommand inputItem)
        {
              
  
		entity.SleVchItmId = inputItem.SleVchItmId;  
  
		entity.SleVchHdrRef = inputItem.SleVchHdrRef;  
  
		entity.SVISeq = inputItem.SVISeq;  
  
		entity.SVIPartRef = inputItem.SVIPartRef;  
  
		entity.SVIUnitRef = inputItem.SVIUnitRef;  
  
		entity.SVIMainQty = inputItem.SVIMainQty;  
  
		entity.SVIOthQty = inputItem.SVIOthQty;  
  
		entity.SVIAmount = inputItem.SVIAmount;  
  
		entity.SVIDescr = inputItem.SVIDescr;  
  
		entity.SVIRefID = inputItem.SVIRefID;  
  
		entity.SVIRefType = inputItem.SVIRefType;  
  
		entity.SVICurVal = inputItem.SVICurVal;  
  
		entity.SVIPriceType = inputItem.SVIPriceType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleVchItmDto Map(SleVchItm inputItem)
        {
            var dto = new SleVchItmDto()
            {
                  
  
		SleVchItmId = inputItem.SleVchItmId,  
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SVISeq = inputItem.SVISeq,  
  
		SVIPartRef = inputItem.SVIPartRef,  
  
		SVIUnitRef = inputItem.SVIUnitRef,  
  
		SVIMainQty = inputItem.SVIMainQty,  
  
		SVIOthQty = inputItem.SVIOthQty,  
  
		SVIAmount = inputItem.SVIAmount,  
  
		SVIDescr = inputItem.SVIDescr,  
  
		SVIRefID = inputItem.SVIRefID,  
  
		SVIRefType = inputItem.SVIRefType,  
  
		SVICurVal = inputItem.SVICurVal,  
  
		SVIPriceType = inputItem.SVIPriceType, 
            };
            return dto;
        }

        public static List<SleVchItmDto> Map(ICollection<SleVchItm> entities)
        {
            var dtos = new List<SleVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleVchItmDto()
                {
                      
  
		SleVchItmId = inputItem.SleVchItmId,  
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SVISeq = inputItem.SVISeq,  
  
		SVIPartRef = inputItem.SVIPartRef,  
  
		SVIUnitRef = inputItem.SVIUnitRef,  
  
		SVIMainQty = inputItem.SVIMainQty,  
  
		SVIOthQty = inputItem.SVIOthQty,  
  
		SVIAmount = inputItem.SVIAmount,  
  
		SVIDescr = inputItem.SVIDescr,  
  
		SVIRefID = inputItem.SVIRefID,  
  
		SVIRefType = inputItem.SVIRefType,  
  
		SVICurVal = inputItem.SVICurVal,  
  
		SVIPriceType = inputItem.SVIPriceType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleVchQtyVal Map(AddSleVchQtyValCommand inputItem)
        {
            var entity = new SleVchQtyVal() {
                  
  
		SleVchQtyValId = inputItem.SleVchQtyValId,  
  
		SVQVchItmRef = inputItem.SVQVchItmRef,  
  
		SVQPrjRef = inputItem.SVQPrjRef,  
  
		SVQDLRef = inputItem.SVQDLRef,  
  
		SVQProductRef = inputItem.SVQProductRef,  
  
		SVQOthVal = inputItem.SVQOthVal,  
  
		SVQOthDate = inputItem.SVQOthDate,  
  
		SVQQty = inputItem.SVQQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleVchQtyVal Map(SleVchQtyVal entity ,EditSleVchQtyValCommand inputItem)
        {
              
  
		entity.SleVchQtyValId = inputItem.SleVchQtyValId;  
  
		entity.SVQVchItmRef = inputItem.SVQVchItmRef;  
  
		entity.SVQPrjRef = inputItem.SVQPrjRef;  
  
		entity.SVQDLRef = inputItem.SVQDLRef;  
  
		entity.SVQProductRef = inputItem.SVQProductRef;  
  
		entity.SVQOthVal = inputItem.SVQOthVal;  
  
		entity.SVQOthDate = inputItem.SVQOthDate;  
  
		entity.SVQQty = inputItem.SVQQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleVchQtyValDto Map(SleVchQtyVal inputItem)
        {
            var dto = new SleVchQtyValDto()
            {
                  
  
		SleVchQtyValId = inputItem.SleVchQtyValId,  
  
		SVQVchItmRef = inputItem.SVQVchItmRef,  
  
		SVQPrjRef = inputItem.SVQPrjRef,  
  
		SVQDLRef = inputItem.SVQDLRef,  
  
		SVQProductRef = inputItem.SVQProductRef,  
  
		SVQOthVal = inputItem.SVQOthVal,  
  
		SVQOthDate = inputItem.SVQOthDate,  
  
		SVQQty = inputItem.SVQQty, 
            };
            return dto;
        }

        public static List<SleVchQtyValDto> Map(ICollection<SleVchQtyVal> entities)
        {
            var dtos = new List<SleVchQtyValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleVchQtyValDto()
                {
                      
  
		SleVchQtyValId = inputItem.SleVchQtyValId,  
  
		SVQVchItmRef = inputItem.SVQVchItmRef,  
  
		SVQPrjRef = inputItem.SVQPrjRef,  
  
		SVQDLRef = inputItem.SVQDLRef,  
  
		SVQProductRef = inputItem.SVQProductRef,  
  
		SVQOthVal = inputItem.SVQOthVal,  
  
		SVQOthDate = inputItem.SVQOthDate,  
  
		SVQQty = inputItem.SVQQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleVchTax Map(AddSleVchTaxCommand inputItem)
        {
            var entity = new SleVchTax() {
                  
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SleVchItmRef = inputItem.SleVchItmRef,  
  
		SVTTaxRef = inputItem.SVTTaxRef,  
  
		SVTTaxAmount = inputItem.SVTTaxAmount,  
  
		SVTAmount = inputItem.SVTAmount,  
  
		SVTCurVal = inputItem.SVTCurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleVchTax Map(SleVchTax entity ,EditSleVchTaxCommand inputItem)
        {
              
  
		entity.SleVchHdrRef = inputItem.SleVchHdrRef;  
  
		entity.SleVchItmRef = inputItem.SleVchItmRef;  
  
		entity.SVTTaxRef = inputItem.SVTTaxRef;  
  
		entity.SVTTaxAmount = inputItem.SVTTaxAmount;  
  
		entity.SVTAmount = inputItem.SVTAmount;  
  
		entity.SVTCurVal = inputItem.SVTCurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleVchTaxDto Map(SleVchTax inputItem)
        {
            var dto = new SleVchTaxDto()
            {
                  
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SleVchItmRef = inputItem.SleVchItmRef,  
  
		SVTTaxRef = inputItem.SVTTaxRef,  
  
		SVTTaxAmount = inputItem.SVTTaxAmount,  
  
		SVTAmount = inputItem.SVTAmount,  
  
		SVTCurVal = inputItem.SVTCurVal, 
            };
            return dto;
        }

        public static List<SleVchTaxDto> Map(ICollection<SleVchTax> entities)
        {
            var dtos = new List<SleVchTaxDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleVchTaxDto()
                {
                      
  
		SleVchHdrRef = inputItem.SleVchHdrRef,  
  
		SleVchItmRef = inputItem.SleVchItmRef,  
  
		SVTTaxRef = inputItem.SVTTaxRef,  
  
		SVTTaxAmount = inputItem.SVTTaxAmount,  
  
		SVTAmount = inputItem.SVTAmount,  
  
		SVTCurVal = inputItem.SVTCurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SleVchTypes Map(AddSleVchTypesCommand inputItem)
        {
            var entity = new SleVchTypes() {
                  
  
		SleVchTypeId = inputItem.SleVchTypeId,  
  
		SVTTitle = inputItem.SVTTitle,  
  
		SVTInvVch = inputItem.SVTInvVch,  
  
		SVTBaseLimit = inputItem.SVTBaseLimit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SleVchTypes Map(SleVchTypes entity ,EditSleVchTypesCommand inputItem)
        {
              
  
		entity.SleVchTypeId = inputItem.SleVchTypeId;  
  
		entity.SVTTitle = inputItem.SVTTitle;  
  
		entity.SVTInvVch = inputItem.SVTInvVch;  
  
		entity.SVTBaseLimit = inputItem.SVTBaseLimit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SleVchTypesDto Map(SleVchTypes inputItem)
        {
            var dto = new SleVchTypesDto()
            {
                  
  
		SleVchTypeId = inputItem.SleVchTypeId,  
  
		SVTTitle = inputItem.SVTTitle,  
  
		SVTInvVch = inputItem.SVTInvVch,  
  
		SVTBaseLimit = inputItem.SVTBaseLimit, 
            };
            return dto;
        }

        public static List<SleVchTypesDto> Map(ICollection<SleVchTypes> entities)
        {
            var dtos = new List<SleVchTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SleVchTypesDto()
                {
                      
  
		SleVchTypeId = inputItem.SleVchTypeId,  
  
		SVTTitle = inputItem.SVTTitle,  
  
		SVTInvVch = inputItem.SVTInvVch,  
  
		SVTBaseLimit = inputItem.SVTBaseLimit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
