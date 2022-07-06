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
                
        
        public static CntAccRels Map(AddCntAccRelsCommand inputItem)
        {
            var entity = new CntAccRels() {
                  
  
		CntAccRelId = inputItem.CntAccRelId,  
  
		CntAccVchTypeRef = inputItem.CntAccVchTypeRef,  
  
		CARFieldRef = inputItem.CARFieldRef,  
  
		CARBalanceType = inputItem.CARBalanceType,  
  
		CARSLRef = inputItem.CARSLRef,  
  
		CARDLType = inputItem.CARDLType,  
  
		CARDLCode = inputItem.CARDLCode,  
  
		CARDLFiveType = inputItem.CARDLFiveType,  
  
		CARDLFiveCode = inputItem.CARDLFiveCode,  
  
		CARDLSixType = inputItem.CARDLSixType,  
  
		CARDLSixCode = inputItem.CARDLSixCode,  
  
		CARDescr = inputItem.CARDescr,  
  
		CARPriovity = inputItem.CARPriovity,  
  
		CARGroup = inputItem.CARGroup,  
  
		CARCurType = inputItem.CARCurType,  
  
		CARSLType = inputItem.CARSLType,  
  
		CARIsMain = inputItem.CARIsMain, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAccRels Map(CntAccRels entity ,EditCntAccRelsCommand inputItem)
        {
              
  
		entity.CntAccRelId = inputItem.CntAccRelId;  
  
		entity.CntAccVchTypeRef = inputItem.CntAccVchTypeRef;  
  
		entity.CARFieldRef = inputItem.CARFieldRef;  
  
		entity.CARBalanceType = inputItem.CARBalanceType;  
  
		entity.CARSLRef = inputItem.CARSLRef;  
  
		entity.CARDLType = inputItem.CARDLType;  
  
		entity.CARDLCode = inputItem.CARDLCode;  
  
		entity.CARDLFiveType = inputItem.CARDLFiveType;  
  
		entity.CARDLFiveCode = inputItem.CARDLFiveCode;  
  
		entity.CARDLSixType = inputItem.CARDLSixType;  
  
		entity.CARDLSixCode = inputItem.CARDLSixCode;  
  
		entity.CARDescr = inputItem.CARDescr;  
  
		entity.CARPriovity = inputItem.CARPriovity;  
  
		entity.CARGroup = inputItem.CARGroup;  
  
		entity.CARCurType = inputItem.CARCurType;  
  
		entity.CARSLType = inputItem.CARSLType;  
  
		entity.CARIsMain = inputItem.CARIsMain; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAccRelsDto Map(CntAccRels inputItem)
        {
            var dto = new CntAccRelsDto()
            {
                  
  
		CntAccRelId = inputItem.CntAccRelId,  
  
		CntAccVchTypeRef = inputItem.CntAccVchTypeRef,  
  
		CARFieldRef = inputItem.CARFieldRef,  
  
		CARBalanceType = inputItem.CARBalanceType,  
  
		CARSLRef = inputItem.CARSLRef,  
  
		CARDLType = inputItem.CARDLType,  
  
		CARDLCode = inputItem.CARDLCode,  
  
		CARDLFiveType = inputItem.CARDLFiveType,  
  
		CARDLFiveCode = inputItem.CARDLFiveCode,  
  
		CARDLSixType = inputItem.CARDLSixType,  
  
		CARDLSixCode = inputItem.CARDLSixCode,  
  
		CARDescr = inputItem.CARDescr,  
  
		CARPriovity = inputItem.CARPriovity,  
  
		CARGroup = inputItem.CARGroup,  
  
		CARCurType = inputItem.CARCurType,  
  
		CARSLType = inputItem.CARSLType,  
  
		CARIsMain = inputItem.CARIsMain, 
            };
            return dto;
        }

        public static List<CntAccRelsDto> Map(ICollection<CntAccRels> entities)
        {
            var dtos = new List<CntAccRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAccRelsDto()
                {
                      
  
		CntAccRelId = inputItem.CntAccRelId,  
  
		CntAccVchTypeRef = inputItem.CntAccVchTypeRef,  
  
		CARFieldRef = inputItem.CARFieldRef,  
  
		CARBalanceType = inputItem.CARBalanceType,  
  
		CARSLRef = inputItem.CARSLRef,  
  
		CARDLType = inputItem.CARDLType,  
  
		CARDLCode = inputItem.CARDLCode,  
  
		CARDLFiveType = inputItem.CARDLFiveType,  
  
		CARDLFiveCode = inputItem.CARDLFiveCode,  
  
		CARDLSixType = inputItem.CARDLSixType,  
  
		CARDLSixCode = inputItem.CARDLSixCode,  
  
		CARDescr = inputItem.CARDescr,  
  
		CARPriovity = inputItem.CARPriovity,  
  
		CARGroup = inputItem.CARGroup,  
  
		CARCurType = inputItem.CARCurType,  
  
		CARSLType = inputItem.CARSLType,  
  
		CARIsMain = inputItem.CARIsMain, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntAccVchTypes Map(AddCntAccVchTypesCommand inputItem)
        {
            var entity = new CntAccVchTypes() {
                  
  
		CntAccVchTypeId = inputItem.CntAccVchTypeId,  
  
		CAVTTitle = inputItem.CAVTTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAccVchTypes Map(CntAccVchTypes entity ,EditCntAccVchTypesCommand inputItem)
        {
              
  
		entity.CntAccVchTypeId = inputItem.CntAccVchTypeId;  
  
		entity.CAVTTitle = inputItem.CAVTTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAccVchTypesDto Map(CntAccVchTypes inputItem)
        {
            var dto = new CntAccVchTypesDto()
            {
                  
  
		CntAccVchTypeId = inputItem.CntAccVchTypeId,  
  
		CAVTTitle = inputItem.CAVTTitle, 
            };
            return dto;
        }

        public static List<CntAccVchTypesDto> Map(ICollection<CntAccVchTypes> entities)
        {
            var dtos = new List<CntAccVchTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAccVchTypesDto()
                {
                      
  
		CntAccVchTypeId = inputItem.CntAccVchTypeId,  
  
		CAVTTitle = inputItem.CAVTTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntAcquitInfs Map(AddCntAcquitInfsCommand inputItem)
        {
            var entity = new CntAcquitInfs() {
                  
  
		CntAcquitInfId = inputItem.CntAcquitInfId,  
  
		CAIContRef = inputItem.CAIContRef,  
  
		CAIType = inputItem.CAIType,  
  
		CAIDate = inputItem.CAIDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAcquitInfs Map(CntAcquitInfs entity ,EditCntAcquitInfsCommand inputItem)
        {
              
  
		entity.CntAcquitInfId = inputItem.CntAcquitInfId;  
  
		entity.CAIContRef = inputItem.CAIContRef;  
  
		entity.CAIType = inputItem.CAIType;  
  
		entity.CAIDate = inputItem.CAIDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAcquitInfsDto Map(CntAcquitInfs inputItem)
        {
            var dto = new CntAcquitInfsDto()
            {
                  
  
		CntAcquitInfId = inputItem.CntAcquitInfId,  
  
		CAIContRef = inputItem.CAIContRef,  
  
		CAIType = inputItem.CAIType,  
  
		CAIDate = inputItem.CAIDate, 
            };
            return dto;
        }

        public static List<CntAcquitInfsDto> Map(ICollection<CntAcquitInfs> entities)
        {
            var dtos = new List<CntAcquitInfsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAcquitInfsDto()
                {
                      
  
		CntAcquitInfId = inputItem.CntAcquitInfId,  
  
		CAIContRef = inputItem.CAIContRef,  
  
		CAIType = inputItem.CAIType,  
  
		CAIDate = inputItem.CAIDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntAgreement Map(AddCntAgreementCommand inputItem)
        {
            var entity = new CntAgreement() {
                  
  
		CntAgrmntId = inputItem.CntAgrmntId,  
  
		CAgNum = inputItem.CAgNum,  
  
		CAgDate = inputItem.CAgDate,  
  
		CAgDescr = inputItem.CAgDescr,  
  
		CAgMasterRef = inputItem.CAgMasterRef,  
  
		CAgAmntSit = inputItem.CAgAmntSit,  
  
		CAgAmount = inputItem.CAgAmount,  
  
		CAgDur = inputItem.CAgDur,  
  
		CAgRatio = inputItem.CAgRatio,  
  
		CAgAccPrdRef = inputItem.CAgAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAgreement Map(CntAgreement entity ,EditCntAgreementCommand inputItem)
        {
              
  
		entity.CntAgrmntId = inputItem.CntAgrmntId;  
  
		entity.CAgNum = inputItem.CAgNum;  
  
		entity.CAgDate = inputItem.CAgDate;  
  
		entity.CAgDescr = inputItem.CAgDescr;  
  
		entity.CAgMasterRef = inputItem.CAgMasterRef;  
  
		entity.CAgAmntSit = inputItem.CAgAmntSit;  
  
		entity.CAgAmount = inputItem.CAgAmount;  
  
		entity.CAgDur = inputItem.CAgDur;  
  
		entity.CAgRatio = inputItem.CAgRatio;  
  
		entity.CAgAccPrdRef = inputItem.CAgAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAgreementDto Map(CntAgreement inputItem)
        {
            var dto = new CntAgreementDto()
            {
                  
  
		CntAgrmntId = inputItem.CntAgrmntId,  
  
		CAgNum = inputItem.CAgNum,  
  
		CAgDate = inputItem.CAgDate,  
  
		CAgDescr = inputItem.CAgDescr,  
  
		CAgMasterRef = inputItem.CAgMasterRef,  
  
		CAgAmntSit = inputItem.CAgAmntSit,  
  
		CAgAmount = inputItem.CAgAmount,  
  
		CAgDur = inputItem.CAgDur,  
  
		CAgRatio = inputItem.CAgRatio,  
  
		CAgAccPrdRef = inputItem.CAgAccPrdRef, 
            };
            return dto;
        }

        public static List<CntAgreementDto> Map(ICollection<CntAgreement> entities)
        {
            var dtos = new List<CntAgreementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAgreementDto()
                {
                      
  
		CntAgrmntId = inputItem.CntAgrmntId,  
  
		CAgNum = inputItem.CAgNum,  
  
		CAgDate = inputItem.CAgDate,  
  
		CAgDescr = inputItem.CAgDescr,  
  
		CAgMasterRef = inputItem.CAgMasterRef,  
  
		CAgAmntSit = inputItem.CAgAmntSit,  
  
		CAgAmount = inputItem.CAgAmount,  
  
		CAgDur = inputItem.CAgDur,  
  
		CAgRatio = inputItem.CAgRatio,  
  
		CAgAccPrdRef = inputItem.CAgAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntAmntCurInf Map(AddCntAmntCurInfCommand inputItem)
        {
            var entity = new CntAmntCurInf() {
                  
  
		CntAmntCurInfId = inputItem.CntAmntCurInfId,  
  
		CACIBaseType = inputItem.CACIBaseType,  
  
		CACIBaseRef = inputItem.CACIBaseRef,  
  
		CACICurRef = inputItem.CACICurRef,  
  
		CACIAmount = inputItem.CACIAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAmntCurInf Map(CntAmntCurInf entity ,EditCntAmntCurInfCommand inputItem)
        {
              
  
		entity.CntAmntCurInfId = inputItem.CntAmntCurInfId;  
  
		entity.CACIBaseType = inputItem.CACIBaseType;  
  
		entity.CACIBaseRef = inputItem.CACIBaseRef;  
  
		entity.CACICurRef = inputItem.CACICurRef;  
  
		entity.CACIAmount = inputItem.CACIAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAmntCurInfDto Map(CntAmntCurInf inputItem)
        {
            var dto = new CntAmntCurInfDto()
            {
                  
  
		CntAmntCurInfId = inputItem.CntAmntCurInfId,  
  
		CACIBaseType = inputItem.CACIBaseType,  
  
		CACIBaseRef = inputItem.CACIBaseRef,  
  
		CACICurRef = inputItem.CACICurRef,  
  
		CACIAmount = inputItem.CACIAmount, 
            };
            return dto;
        }

        public static List<CntAmntCurInfDto> Map(ICollection<CntAmntCurInf> entities)
        {
            var dtos = new List<CntAmntCurInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAmntCurInfDto()
                {
                      
  
		CntAmntCurInfId = inputItem.CntAmntCurInfId,  
  
		CACIBaseType = inputItem.CACIBaseType,  
  
		CACIBaseRef = inputItem.CACIBaseRef,  
  
		CACICurRef = inputItem.CACICurRef,  
  
		CACIAmount = inputItem.CACIAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntAmntTypes Map(AddCntAmntTypesCommand inputItem)
        {
            var entity = new CntAmntTypes() {
                  
  
		CntAmntTypeId = inputItem.CntAmntTypeId,  
  
		CATTitle = inputItem.CATTitle,  
  
		CATFormula = inputItem.CATFormula, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntAmntTypes Map(CntAmntTypes entity ,EditCntAmntTypesCommand inputItem)
        {
              
  
		entity.CntAmntTypeId = inputItem.CntAmntTypeId;  
  
		entity.CATTitle = inputItem.CATTitle;  
  
		entity.CATFormula = inputItem.CATFormula; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntAmntTypesDto Map(CntAmntTypes inputItem)
        {
            var dto = new CntAmntTypesDto()
            {
                  
  
		CntAmntTypeId = inputItem.CntAmntTypeId,  
  
		CATTitle = inputItem.CATTitle,  
  
		CATFormula = inputItem.CATFormula, 
            };
            return dto;
        }

        public static List<CntAmntTypesDto> Map(ICollection<CntAmntTypes> entities)
        {
            var dtos = new List<CntAmntTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntAmntTypesDto()
                {
                      
  
		CntAmntTypeId = inputItem.CntAmntTypeId,  
  
		CATTitle = inputItem.CATTitle,  
  
		CATFormula = inputItem.CATFormula, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntCMthdFlds Map(AddCntCMthdFldsCommand inputItem)
        {
            var entity = new CntCMthdFlds() {
                  
  
		CntCMthdFldId = inputItem.CntCMthdFldId,  
  
		CCMFldRef = inputItem.CCMFldRef,  
  
		CCMFDescr = inputItem.CCMFDescr,  
  
		CCMFormula = inputItem.CCMFormula,  
  
		CCMFormulDescr = inputItem.CCMFormulDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntCMthdFlds Map(CntCMthdFlds entity ,EditCntCMthdFldsCommand inputItem)
        {
              
  
		entity.CntCMthdFldId = inputItem.CntCMthdFldId;  
  
		entity.CCMFldRef = inputItem.CCMFldRef;  
  
		entity.CCMFDescr = inputItem.CCMFDescr;  
  
		entity.CCMFormula = inputItem.CCMFormula;  
  
		entity.CCMFormulDescr = inputItem.CCMFormulDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntCMthdFldsDto Map(CntCMthdFlds inputItem)
        {
            var dto = new CntCMthdFldsDto()
            {
                  
  
		CntCMthdFldId = inputItem.CntCMthdFldId,  
  
		CCMFldRef = inputItem.CCMFldRef,  
  
		CCMFDescr = inputItem.CCMFDescr,  
  
		CCMFormula = inputItem.CCMFormula,  
  
		CCMFormulDescr = inputItem.CCMFormulDescr, 
            };
            return dto;
        }

        public static List<CntCMthdFldsDto> Map(ICollection<CntCMthdFlds> entities)
        {
            var dtos = new List<CntCMthdFldsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntCMthdFldsDto()
                {
                      
  
		CntCMthdFldId = inputItem.CntCMthdFldId,  
  
		CCMFldRef = inputItem.CCMFldRef,  
  
		CCMFDescr = inputItem.CCMFDescr,  
  
		CCMFormula = inputItem.CCMFormula,  
  
		CCMFormulDescr = inputItem.CCMFormulDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContAgrVals Map(AddCntContAgrValsCommand inputItem)
        {
            var entity = new CntContAgrVals() {
                  
  
		CntContAgValId = inputItem.CntContAgValId,  
  
		CCAVFldRef = inputItem.CCAVFldRef,  
  
		CCAVBaseItm = inputItem.CCAVBaseItm,  
  
		CCAVAmount = inputItem.CCAVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContAgrVals Map(CntContAgrVals entity ,EditCntContAgrValsCommand inputItem)
        {
              
  
		entity.CntContAgValId = inputItem.CntContAgValId;  
  
		entity.CCAVFldRef = inputItem.CCAVFldRef;  
  
		entity.CCAVBaseItm = inputItem.CCAVBaseItm;  
  
		entity.CCAVAmount = inputItem.CCAVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContAgrValsDto Map(CntContAgrVals inputItem)
        {
            var dto = new CntContAgrValsDto()
            {
                  
  
		CntContAgValId = inputItem.CntContAgValId,  
  
		CCAVFldRef = inputItem.CCAVFldRef,  
  
		CCAVBaseItm = inputItem.CCAVBaseItm,  
  
		CCAVAmount = inputItem.CCAVAmount, 
            };
            return dto;
        }

        public static List<CntContAgrValsDto> Map(ICollection<CntContAgrVals> entities)
        {
            var dtos = new List<CntContAgrValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContAgrValsDto()
                {
                      
  
		CntContAgValId = inputItem.CntContAgValId,  
  
		CCAVFldRef = inputItem.CCAVFldRef,  
  
		CCAVBaseItm = inputItem.CCAVBaseItm,  
  
		CCAVAmount = inputItem.CCAVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContAmntChng Map(AddCntContAmntChngCommand inputItem)
        {
            var entity = new CntContAmntChng() {
                  
  
		CntContAmntChngId = inputItem.CntContAmntChngId,  
  
		CCACContRef = inputItem.CCACContRef,  
  
		CCACType = inputItem.CCACType,  
  
		CCACDate = inputItem.CCACDate,  
  
		CCACDescr = inputItem.CCACDescr,  
  
		CCACVal = inputItem.CCACVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContAmntChng Map(CntContAmntChng entity ,EditCntContAmntChngCommand inputItem)
        {
              
  
		entity.CntContAmntChngId = inputItem.CntContAmntChngId;  
  
		entity.CCACContRef = inputItem.CCACContRef;  
  
		entity.CCACType = inputItem.CCACType;  
  
		entity.CCACDate = inputItem.CCACDate;  
  
		entity.CCACDescr = inputItem.CCACDescr;  
  
		entity.CCACVal = inputItem.CCACVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContAmntChngDto Map(CntContAmntChng inputItem)
        {
            var dto = new CntContAmntChngDto()
            {
                  
  
		CntContAmntChngId = inputItem.CntContAmntChngId,  
  
		CCACContRef = inputItem.CCACContRef,  
  
		CCACType = inputItem.CCACType,  
  
		CCACDate = inputItem.CCACDate,  
  
		CCACDescr = inputItem.CCACDescr,  
  
		CCACVal = inputItem.CCACVal, 
            };
            return dto;
        }

        public static List<CntContAmntChngDto> Map(ICollection<CntContAmntChng> entities)
        {
            var dtos = new List<CntContAmntChngDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContAmntChngDto()
                {
                      
  
		CntContAmntChngId = inputItem.CntContAmntChngId,  
  
		CCACContRef = inputItem.CCACContRef,  
  
		CCACType = inputItem.CCACType,  
  
		CCACDate = inputItem.CCACDate,  
  
		CCACDescr = inputItem.CCACDescr,  
  
		CCACVal = inputItem.CCACVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContDet Map(AddCntContDetCommand inputItem)
        {
            var entity = new CntContDet() {
                  
  
		CntContDetId = inputItem.CntContDetId,  
  
		CCDContRef = inputItem.CCDContRef,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDCostCenter = inputItem.CCDCostCenter,  
  
		CCDUnit = inputItem.CCDUnit,  
  
		CCDDur = inputItem.CCDDur,  
  
		CCDQty = inputItem.CCDQty,  
  
		CCDRate = inputItem.CCDRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContDet Map(CntContDet entity ,EditCntContDetCommand inputItem)
        {
              
  
		entity.CntContDetId = inputItem.CntContDetId;  
  
		entity.CCDContRef = inputItem.CCDContRef;  
  
		entity.CCDItmRef = inputItem.CCDItmRef;  
  
		entity.CCDCostCenter = inputItem.CCDCostCenter;  
  
		entity.CCDUnit = inputItem.CCDUnit;  
  
		entity.CCDDur = inputItem.CCDDur;  
  
		entity.CCDQty = inputItem.CCDQty;  
  
		entity.CCDRate = inputItem.CCDRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContDetDto Map(CntContDet inputItem)
        {
            var dto = new CntContDetDto()
            {
                  
  
		CntContDetId = inputItem.CntContDetId,  
  
		CCDContRef = inputItem.CCDContRef,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDCostCenter = inputItem.CCDCostCenter,  
  
		CCDUnit = inputItem.CCDUnit,  
  
		CCDDur = inputItem.CCDDur,  
  
		CCDQty = inputItem.CCDQty,  
  
		CCDRate = inputItem.CCDRate, 
            };
            return dto;
        }

        public static List<CntContDetDto> Map(ICollection<CntContDet> entities)
        {
            var dtos = new List<CntContDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContDetDto()
                {
                      
  
		CntContDetId = inputItem.CntContDetId,  
  
		CCDContRef = inputItem.CCDContRef,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDCostCenter = inputItem.CCDCostCenter,  
  
		CCDUnit = inputItem.CCDUnit,  
  
		CCDDur = inputItem.CCDDur,  
  
		CCDQty = inputItem.CCDQty,  
  
		CCDRate = inputItem.CCDRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContElmnt Map(AddCntContElmntCommand inputItem)
        {
            var entity = new CntContElmnt() {
                  
  
		CntContElmntId = inputItem.CntContElmntId,  
  
		CCEContRef = inputItem.CCEContRef,  
  
		CCEFldRef = inputItem.CCEFldRef,  
  
		CCEAmount = inputItem.CCEAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContElmnt Map(CntContElmnt entity ,EditCntContElmntCommand inputItem)
        {
              
  
		entity.CntContElmntId = inputItem.CntContElmntId;  
  
		entity.CCEContRef = inputItem.CCEContRef;  
  
		entity.CCEFldRef = inputItem.CCEFldRef;  
  
		entity.CCEAmount = inputItem.CCEAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContElmntDto Map(CntContElmnt inputItem)
        {
            var dto = new CntContElmntDto()
            {
                  
  
		CntContElmntId = inputItem.CntContElmntId,  
  
		CCEContRef = inputItem.CCEContRef,  
  
		CCEFldRef = inputItem.CCEFldRef,  
  
		CCEAmount = inputItem.CCEAmount, 
            };
            return dto;
        }

        public static List<CntContElmntDto> Map(ICollection<CntContElmnt> entities)
        {
            var dtos = new List<CntContElmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContElmntDto()
                {
                      
  
		CntContElmntId = inputItem.CntContElmntId,  
  
		CCEContRef = inputItem.CCEContRef,  
  
		CCEFldRef = inputItem.CCEFldRef,  
  
		CCEAmount = inputItem.CCEAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContractors Map(AddCntContractorsCommand inputItem)
        {
            var entity = new CntContractors() {
                  
  
		CntContrId = inputItem.CntContrId,  
  
		CCCrsRef = inputItem.CCCrsRef,  
  
		CCActType = inputItem.CCActType,  
  
		CCFileNo = inputItem.CCFileNo,  
  
		CCPersiutNo = inputItem.CCPersiutNo,  
  
		CCDirectorName = inputItem.CCDirectorName,  
  
		CCRespName = inputItem.CCRespName,  
  
		CCBankInf = inputItem.CCBankInf,  
  
		CCAccountNo = inputItem.CCAccountNo,  
  
		CCECode = inputItem.CCECode,  
  
		CCDutyDate = inputItem.CCDutyDate,  
  
		CCDutyNum = inputItem.CCDutyNum,  
  
		CCSLRef = inputItem.CCSLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContractors Map(CntContractors entity ,EditCntContractorsCommand inputItem)
        {
              
  
		entity.CntContrId = inputItem.CntContrId;  
  
		entity.CCCrsRef = inputItem.CCCrsRef;  
  
		entity.CCActType = inputItem.CCActType;  
  
		entity.CCFileNo = inputItem.CCFileNo;  
  
		entity.CCPersiutNo = inputItem.CCPersiutNo;  
  
		entity.CCDirectorName = inputItem.CCDirectorName;  
  
		entity.CCRespName = inputItem.CCRespName;  
  
		entity.CCBankInf = inputItem.CCBankInf;  
  
		entity.CCAccountNo = inputItem.CCAccountNo;  
  
		entity.CCECode = inputItem.CCECode;  
  
		entity.CCDutyDate = inputItem.CCDutyDate;  
  
		entity.CCDutyNum = inputItem.CCDutyNum;  
  
		entity.CCSLRef = inputItem.CCSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContractorsDto Map(CntContractors inputItem)
        {
            var dto = new CntContractorsDto()
            {
                  
  
		CntContrId = inputItem.CntContrId,  
  
		CCCrsRef = inputItem.CCCrsRef,  
  
		CCActType = inputItem.CCActType,  
  
		CCFileNo = inputItem.CCFileNo,  
  
		CCPersiutNo = inputItem.CCPersiutNo,  
  
		CCDirectorName = inputItem.CCDirectorName,  
  
		CCRespName = inputItem.CCRespName,  
  
		CCBankInf = inputItem.CCBankInf,  
  
		CCAccountNo = inputItem.CCAccountNo,  
  
		CCECode = inputItem.CCECode,  
  
		CCDutyDate = inputItem.CCDutyDate,  
  
		CCDutyNum = inputItem.CCDutyNum,  
  
		CCSLRef = inputItem.CCSLRef, 
            };
            return dto;
        }

        public static List<CntContractorsDto> Map(ICollection<CntContractors> entities)
        {
            var dtos = new List<CntContractorsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContractorsDto()
                {
                      
  
		CntContrId = inputItem.CntContrId,  
  
		CCCrsRef = inputItem.CCCrsRef,  
  
		CCActType = inputItem.CCActType,  
  
		CCFileNo = inputItem.CCFileNo,  
  
		CCPersiutNo = inputItem.CCPersiutNo,  
  
		CCDirectorName = inputItem.CCDirectorName,  
  
		CCRespName = inputItem.CCRespName,  
  
		CCBankInf = inputItem.CCBankInf,  
  
		CCAccountNo = inputItem.CCAccountNo,  
  
		CCECode = inputItem.CCECode,  
  
		CCDutyDate = inputItem.CCDutyDate,  
  
		CCDutyNum = inputItem.CCDutyNum,  
  
		CCSLRef = inputItem.CCSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContracts Map(AddCntContractsCommand inputItem)
        {
            var entity = new CntContracts() {
                  
  
		CntContId = inputItem.CntContId,  
  
		CContNum = inputItem.CContNum,  
  
		CContDate = inputItem.CContDate,  
  
		CContAmount = inputItem.CContAmount,  
  
		CCSubjRef = inputItem.CCSubjRef,  
  
		CContDescr = inputItem.CContDescr,  
  
		CContTavRef = inputItem.CContTavRef,  
  
		CContContractorRef = inputItem.CContContractorRef,  
  
		CContDur = inputItem.CContDur,  
  
		CContHaveInq = inputItem.CContHaveInq,  
  
		CContHavePolicy = inputItem.CContHavePolicy,  
  
		CContPolicyAmnt = inputItem.CContPolicyAmnt,  
  
		CContCashAmnt = inputItem.CContCashAmnt,  
  
		CContGoodJobPrc = inputItem.CContGoodJobPrc,  
  
		CContSupervisor = inputItem.CContSupervisor,  
  
		CContHaveInc = inputItem.CContHaveInc,  
  
		CContHaveBalance = inputItem.CContHaveBalance,  
  
		CContSit = inputItem.CContSit,  
  
		CContDLRef = inputItem.CContDLRef,  
  
		CCAccPrdRef = inputItem.CCAccPrdRef,  
  
		CCInsuComp = inputItem.CCInsuComp,  
  
		CCGeoRef = inputItem.CCGeoRef,  
  
		CCTaxBranch = inputItem.CCTaxBranch,  
  
		CContEDate = inputItem.CContEDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContracts Map(CntContracts entity ,EditCntContractsCommand inputItem)
        {
              
  
		entity.CntContId = inputItem.CntContId;  
  
		entity.CContNum = inputItem.CContNum;  
  
		entity.CContDate = inputItem.CContDate;  
  
		entity.CContAmount = inputItem.CContAmount;  
  
		entity.CCSubjRef = inputItem.CCSubjRef;  
  
		entity.CContDescr = inputItem.CContDescr;  
  
		entity.CContTavRef = inputItem.CContTavRef;  
  
		entity.CContContractorRef = inputItem.CContContractorRef;  
  
		entity.CContDur = inputItem.CContDur;  
  
		entity.CContHaveInq = inputItem.CContHaveInq;  
  
		entity.CContHavePolicy = inputItem.CContHavePolicy;  
  
		entity.CContPolicyAmnt = inputItem.CContPolicyAmnt;  
  
		entity.CContCashAmnt = inputItem.CContCashAmnt;  
  
		entity.CContGoodJobPrc = inputItem.CContGoodJobPrc;  
  
		entity.CContSupervisor = inputItem.CContSupervisor;  
  
		entity.CContHaveInc = inputItem.CContHaveInc;  
  
		entity.CContHaveBalance = inputItem.CContHaveBalance;  
  
		entity.CContSit = inputItem.CContSit;  
  
		entity.CContDLRef = inputItem.CContDLRef;  
  
		entity.CCAccPrdRef = inputItem.CCAccPrdRef;  
  
		entity.CCInsuComp = inputItem.CCInsuComp;  
  
		entity.CCGeoRef = inputItem.CCGeoRef;  
  
		entity.CCTaxBranch = inputItem.CCTaxBranch;  
  
		entity.CContEDate = inputItem.CContEDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContractsDto Map(CntContracts inputItem)
        {
            var dto = new CntContractsDto()
            {
                  
  
		CntContId = inputItem.CntContId,  
  
		CContNum = inputItem.CContNum,  
  
		CContDate = inputItem.CContDate,  
  
		CContAmount = inputItem.CContAmount,  
  
		CCSubjRef = inputItem.CCSubjRef,  
  
		CContDescr = inputItem.CContDescr,  
  
		CContTavRef = inputItem.CContTavRef,  
  
		CContContractorRef = inputItem.CContContractorRef,  
  
		CContDur = inputItem.CContDur,  
  
		CContHaveInq = inputItem.CContHaveInq,  
  
		CContHavePolicy = inputItem.CContHavePolicy,  
  
		CContPolicyAmnt = inputItem.CContPolicyAmnt,  
  
		CContCashAmnt = inputItem.CContCashAmnt,  
  
		CContGoodJobPrc = inputItem.CContGoodJobPrc,  
  
		CContSupervisor = inputItem.CContSupervisor,  
  
		CContHaveInc = inputItem.CContHaveInc,  
  
		CContHaveBalance = inputItem.CContHaveBalance,  
  
		CContSit = inputItem.CContSit,  
  
		CContDLRef = inputItem.CContDLRef,  
  
		CCAccPrdRef = inputItem.CCAccPrdRef,  
  
		CCInsuComp = inputItem.CCInsuComp,  
  
		CCGeoRef = inputItem.CCGeoRef,  
  
		CCTaxBranch = inputItem.CCTaxBranch,  
  
		CContEDate = inputItem.CContEDate, 
            };
            return dto;
        }

        public static List<CntContractsDto> Map(ICollection<CntContracts> entities)
        {
            var dtos = new List<CntContractsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContractsDto()
                {
                      
  
		CntContId = inputItem.CntContId,  
  
		CContNum = inputItem.CContNum,  
  
		CContDate = inputItem.CContDate,  
  
		CContAmount = inputItem.CContAmount,  
  
		CCSubjRef = inputItem.CCSubjRef,  
  
		CContDescr = inputItem.CContDescr,  
  
		CContTavRef = inputItem.CContTavRef,  
  
		CContContractorRef = inputItem.CContContractorRef,  
  
		CContDur = inputItem.CContDur,  
  
		CContHaveInq = inputItem.CContHaveInq,  
  
		CContHavePolicy = inputItem.CContHavePolicy,  
  
		CContPolicyAmnt = inputItem.CContPolicyAmnt,  
  
		CContCashAmnt = inputItem.CContCashAmnt,  
  
		CContGoodJobPrc = inputItem.CContGoodJobPrc,  
  
		CContSupervisor = inputItem.CContSupervisor,  
  
		CContHaveInc = inputItem.CContHaveInc,  
  
		CContHaveBalance = inputItem.CContHaveBalance,  
  
		CContSit = inputItem.CContSit,  
  
		CContDLRef = inputItem.CContDLRef,  
  
		CCAccPrdRef = inputItem.CCAccPrdRef,  
  
		CCInsuComp = inputItem.CCInsuComp,  
  
		CCGeoRef = inputItem.CCGeoRef,  
  
		CCTaxBranch = inputItem.CCTaxBranch,  
  
		CContEDate = inputItem.CContEDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContRatio Map(AddCntContRatioCommand inputItem)
        {
            var entity = new CntContRatio() {
                  
  
		CntContRatioId = inputItem.CntContRatioId,  
  
		CCRContRef = inputItem.CCRContRef,  
  
		CCRDate = inputItem.CCRDate,  
  
		CCRRatio = inputItem.CCRRatio, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContRatio Map(CntContRatio entity ,EditCntContRatioCommand inputItem)
        {
              
  
		entity.CntContRatioId = inputItem.CntContRatioId;  
  
		entity.CCRContRef = inputItem.CCRContRef;  
  
		entity.CCRDate = inputItem.CCRDate;  
  
		entity.CCRRatio = inputItem.CCRRatio; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContRatioDto Map(CntContRatio inputItem)
        {
            var dto = new CntContRatioDto()
            {
                  
  
		CntContRatioId = inputItem.CntContRatioId,  
  
		CCRContRef = inputItem.CCRContRef,  
  
		CCRDate = inputItem.CCRDate,  
  
		CCRRatio = inputItem.CCRRatio, 
            };
            return dto;
        }

        public static List<CntContRatioDto> Map(ICollection<CntContRatio> entities)
        {
            var dtos = new List<CntContRatioDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContRatioDto()
                {
                      
  
		CntContRatioId = inputItem.CntContRatioId,  
  
		CCRContRef = inputItem.CCRContRef,  
  
		CCRDate = inputItem.CCRDate,  
  
		CCRRatio = inputItem.CCRRatio, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContrLimit Map(AddCntContrLimitCommand inputItem)
        {
            var entity = new CntContrLimit() {
                  
  
		CntContrLimitId = inputItem.CntContrLimitId,  
  
		CCLContrRef = inputItem.CCLContrRef,  
  
		CCLState = inputItem.CCLState,  
  
		CCLDate = inputItem.CCLDate,  
  
		CCLDescr = inputItem.CCLDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContrLimit Map(CntContrLimit entity ,EditCntContrLimitCommand inputItem)
        {
              
  
		entity.CntContrLimitId = inputItem.CntContrLimitId;  
  
		entity.CCLContrRef = inputItem.CCLContrRef;  
  
		entity.CCLState = inputItem.CCLState;  
  
		entity.CCLDate = inputItem.CCLDate;  
  
		entity.CCLDescr = inputItem.CCLDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContrLimitDto Map(CntContrLimit inputItem)
        {
            var dto = new CntContrLimitDto()
            {
                  
  
		CntContrLimitId = inputItem.CntContrLimitId,  
  
		CCLContrRef = inputItem.CCLContrRef,  
  
		CCLState = inputItem.CCLState,  
  
		CCLDate = inputItem.CCLDate,  
  
		CCLDescr = inputItem.CCLDescr, 
            };
            return dto;
        }

        public static List<CntContrLimitDto> Map(ICollection<CntContrLimit> entities)
        {
            var dtos = new List<CntContrLimitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContrLimitDto()
                {
                      
  
		CntContrLimitId = inputItem.CntContrLimitId,  
  
		CCLContrRef = inputItem.CCLContrRef,  
  
		CCLState = inputItem.CCLState,  
  
		CCLDate = inputItem.CCLDate,  
  
		CCLDescr = inputItem.CCLDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntContText Map(AddCntContTextCommand inputItem)
        {
            var entity = new CntContText() {
                  
  
		CntContTextId = inputItem.CntContTextId,  
  
		CCTContRef = inputItem.CCTContRef,  
  
		CCTRefId = inputItem.CCTRefId,  
  
		CCTDescr = inputItem.CCTDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntContText Map(CntContText entity ,EditCntContTextCommand inputItem)
        {
              
  
		entity.CntContTextId = inputItem.CntContTextId;  
  
		entity.CCTContRef = inputItem.CCTContRef;  
  
		entity.CCTRefId = inputItem.CCTRefId;  
  
		entity.CCTDescr = inputItem.CCTDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntContTextDto Map(CntContText inputItem)
        {
            var dto = new CntContTextDto()
            {
                  
  
		CntContTextId = inputItem.CntContTextId,  
  
		CCTContRef = inputItem.CCTContRef,  
  
		CCTRefId = inputItem.CCTRefId,  
  
		CCTDescr = inputItem.CCTDescr, 
            };
            return dto;
        }

        public static List<CntContTextDto> Map(ICollection<CntContText> entities)
        {
            var dtos = new List<CntContTextDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntContTextDto()
                {
                      
  
		CntContTextId = inputItem.CntContTextId,  
  
		CCTContRef = inputItem.CCTContRef,  
  
		CCTRefId = inputItem.CCTRefId,  
  
		CCTDescr = inputItem.CCTDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntCrsDocument Map(AddCntCrsDocumentCommand inputItem)
        {
            var entity = new CntCrsDocument() {
                  
  
		CntCrsDocumentId = inputItem.CntCrsDocumentId,  
  
		CCDDocType = inputItem.CCDDocType,  
  
		CCDDocDate = inputItem.CCDDocDate,  
  
		CCDBaseType = inputItem.CCDBaseType,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDNumber = inputItem.CCDNumber,  
  
		CCDDescr = inputItem.CCDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntCrsDocument Map(CntCrsDocument entity ,EditCntCrsDocumentCommand inputItem)
        {
              
  
		entity.CntCrsDocumentId = inputItem.CntCrsDocumentId;  
  
		entity.CCDDocType = inputItem.CCDDocType;  
  
		entity.CCDDocDate = inputItem.CCDDocDate;  
  
		entity.CCDBaseType = inputItem.CCDBaseType;  
  
		entity.CCDItmRef = inputItem.CCDItmRef;  
  
		entity.CCDNumber = inputItem.CCDNumber;  
  
		entity.CCDDescr = inputItem.CCDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntCrsDocumentDto Map(CntCrsDocument inputItem)
        {
            var dto = new CntCrsDocumentDto()
            {
                  
  
		CntCrsDocumentId = inputItem.CntCrsDocumentId,  
  
		CCDDocType = inputItem.CCDDocType,  
  
		CCDDocDate = inputItem.CCDDocDate,  
  
		CCDBaseType = inputItem.CCDBaseType,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDNumber = inputItem.CCDNumber,  
  
		CCDDescr = inputItem.CCDDescr, 
            };
            return dto;
        }

        public static List<CntCrsDocumentDto> Map(ICollection<CntCrsDocument> entities)
        {
            var dtos = new List<CntCrsDocumentDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntCrsDocumentDto()
                {
                      
  
		CntCrsDocumentId = inputItem.CntCrsDocumentId,  
  
		CCDDocType = inputItem.CCDDocType,  
  
		CCDDocDate = inputItem.CCDDocDate,  
  
		CCDBaseType = inputItem.CCDBaseType,  
  
		CCDItmRef = inputItem.CCDItmRef,  
  
		CCDNumber = inputItem.CCDNumber,  
  
		CCDDescr = inputItem.CCDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntDeliveryInf Map(AddCntDeliveryInfCommand inputItem)
        {
            var entity = new CntDeliveryInf() {
                  
  
		CntDeliveryInfId = inputItem.CntDeliveryInfId,  
  
		CDIContRef = inputItem.CDIContRef,  
  
		CDIType = inputItem.CDIType,  
  
		CDIDate = inputItem.CDIDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntDeliveryInf Map(CntDeliveryInf entity ,EditCntDeliveryInfCommand inputItem)
        {
              
  
		entity.CntDeliveryInfId = inputItem.CntDeliveryInfId;  
  
		entity.CDIContRef = inputItem.CDIContRef;  
  
		entity.CDIType = inputItem.CDIType;  
  
		entity.CDIDate = inputItem.CDIDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntDeliveryInfDto Map(CntDeliveryInf inputItem)
        {
            var dto = new CntDeliveryInfDto()
            {
                  
  
		CntDeliveryInfId = inputItem.CntDeliveryInfId,  
  
		CDIContRef = inputItem.CDIContRef,  
  
		CDIType = inputItem.CDIType,  
  
		CDIDate = inputItem.CDIDate, 
            };
            return dto;
        }

        public static List<CntDeliveryInfDto> Map(ICollection<CntDeliveryInf> entities)
        {
            var dtos = new List<CntDeliveryInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntDeliveryInfDto()
                {
                      
  
		CntDeliveryInfId = inputItem.CntDeliveryInfId,  
  
		CDIContRef = inputItem.CDIContRef,  
  
		CDIType = inputItem.CDIType,  
  
		CDIDate = inputItem.CDIDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAccntRels Map(AddCntExpAccntRelsCommand inputItem)
        {
            var entity = new CntExpAccntRels() {
                  
  
		CExRMastExpAcnRef = inputItem.CExRMastExpAcnRef,  
  
		CExRDetExpAcnRef = inputItem.CExRDetExpAcnRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAccntRels Map(CntExpAccntRels entity ,EditCntExpAccntRelsCommand inputItem)
        {
              
  
		entity.CExRMastExpAcnRef = inputItem.CExRMastExpAcnRef;  
  
		entity.CExRDetExpAcnRef = inputItem.CExRDetExpAcnRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAccntRelsDto Map(CntExpAccntRels inputItem)
        {
            var dto = new CntExpAccntRelsDto()
            {
                  
  
		CExRMastExpAcnRef = inputItem.CExRMastExpAcnRef,  
  
		CExRDetExpAcnRef = inputItem.CExRDetExpAcnRef, 
            };
            return dto;
        }

        public static List<CntExpAccntRelsDto> Map(ICollection<CntExpAccntRels> entities)
        {
            var dtos = new List<CntExpAccntRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAccntRelsDto()
                {
                      
  
		CExRMastExpAcnRef = inputItem.CExRMastExpAcnRef,  
  
		CExRDetExpAcnRef = inputItem.CExRDetExpAcnRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAcntCostCntr Map(AddCntExpAcntCostCntrCommand inputItem)
        {
            var entity = new CntExpAcntCostCntr() {
                  
  
		CntExpAcntCostCntrId = inputItem.CntExpAcntCostCntrId,  
  
		CEACExpAcntRef = inputItem.CEACExpAcntRef,  
  
		CEACCostRef = inputItem.CEACCostRef,  
  
		CEACAmount = inputItem.CEACAmount,  
  
		CEACCurVal = inputItem.CEACCurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAcntCostCntr Map(CntExpAcntCostCntr entity ,EditCntExpAcntCostCntrCommand inputItem)
        {
              
  
		entity.CntExpAcntCostCntrId = inputItem.CntExpAcntCostCntrId;  
  
		entity.CEACExpAcntRef = inputItem.CEACExpAcntRef;  
  
		entity.CEACCostRef = inputItem.CEACCostRef;  
  
		entity.CEACAmount = inputItem.CEACAmount;  
  
		entity.CEACCurVal = inputItem.CEACCurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAcntCostCntrDto Map(CntExpAcntCostCntr inputItem)
        {
            var dto = new CntExpAcntCostCntrDto()
            {
                  
  
		CntExpAcntCostCntrId = inputItem.CntExpAcntCostCntrId,  
  
		CEACExpAcntRef = inputItem.CEACExpAcntRef,  
  
		CEACCostRef = inputItem.CEACCostRef,  
  
		CEACAmount = inputItem.CEACAmount,  
  
		CEACCurVal = inputItem.CEACCurVal, 
            };
            return dto;
        }

        public static List<CntExpAcntCostCntrDto> Map(ICollection<CntExpAcntCostCntr> entities)
        {
            var dtos = new List<CntExpAcntCostCntrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAcntCostCntrDto()
                {
                      
  
		CntExpAcntCostCntrId = inputItem.CntExpAcntCostCntrId,  
  
		CEACExpAcntRef = inputItem.CEACExpAcntRef,  
  
		CEACCostRef = inputItem.CEACCostRef,  
  
		CEACAmount = inputItem.CEACAmount,  
  
		CEACCurVal = inputItem.CEACCurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAcntData Map(AddCntExpAcntDataCommand inputItem)
        {
            var entity = new CntExpAcntData() {
                  
  
		CntExpAcntDataId = inputItem.CntExpAcntDataId,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADFldRef = inputItem.CEADFldRef,  
  
		CEADAmount = inputItem.CEADAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAcntData Map(CntExpAcntData entity ,EditCntExpAcntDataCommand inputItem)
        {
              
  
		entity.CntExpAcntDataId = inputItem.CntExpAcntDataId;  
  
		entity.CEADExpAcntRef = inputItem.CEADExpAcntRef;  
  
		entity.CEADFldRef = inputItem.CEADFldRef;  
  
		entity.CEADAmount = inputItem.CEADAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAcntDataDto Map(CntExpAcntData inputItem)
        {
            var dto = new CntExpAcntDataDto()
            {
                  
  
		CntExpAcntDataId = inputItem.CntExpAcntDataId,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADFldRef = inputItem.CEADFldRef,  
  
		CEADAmount = inputItem.CEADAmount, 
            };
            return dto;
        }

        public static List<CntExpAcntDataDto> Map(ICollection<CntExpAcntData> entities)
        {
            var dtos = new List<CntExpAcntDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAcntDataDto()
                {
                      
  
		CntExpAcntDataId = inputItem.CntExpAcntDataId,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADFldRef = inputItem.CEADFldRef,  
  
		CEADAmount = inputItem.CEADAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAcntDet Map(AddCntExpAcntDetCommand inputItem)
        {
            var entity = new CntExpAcntDet() {
                  
  
		CntExpAcntDetId = inputItem.CntExpAcntDetId,  
  
		CEADItemRef = inputItem.CEADItemRef,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADQty = inputItem.CEADQty,  
  
		CEADDur = inputItem.CEADDur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAcntDet Map(CntExpAcntDet entity ,EditCntExpAcntDetCommand inputItem)
        {
              
  
		entity.CntExpAcntDetId = inputItem.CntExpAcntDetId;  
  
		entity.CEADItemRef = inputItem.CEADItemRef;  
  
		entity.CEADExpAcntRef = inputItem.CEADExpAcntRef;  
  
		entity.CEADQty = inputItem.CEADQty;  
  
		entity.CEADDur = inputItem.CEADDur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAcntDetDto Map(CntExpAcntDet inputItem)
        {
            var dto = new CntExpAcntDetDto()
            {
                  
  
		CntExpAcntDetId = inputItem.CntExpAcntDetId,  
  
		CEADItemRef = inputItem.CEADItemRef,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADQty = inputItem.CEADQty,  
  
		CEADDur = inputItem.CEADDur, 
            };
            return dto;
        }

        public static List<CntExpAcntDetDto> Map(ICollection<CntExpAcntDet> entities)
        {
            var dtos = new List<CntExpAcntDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAcntDetDto()
                {
                      
  
		CntExpAcntDetId = inputItem.CntExpAcntDetId,  
  
		CEADItemRef = inputItem.CEADItemRef,  
  
		CEADExpAcntRef = inputItem.CEADExpAcntRef,  
  
		CEADQty = inputItem.CEADQty,  
  
		CEADDur = inputItem.CEADDur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAcntFlds Map(AddCntExpAcntFldsCommand inputItem)
        {
            var entity = new CntExpAcntFlds() {
                  
  
		CntExpAcnFldId = inputItem.CntExpAcnFldId,  
  
		CEAFTitle = inputItem.CEAFTitle,  
  
		CEAType = inputItem.CEAType,  
  
		CEAPrvty = inputItem.CEAPrvty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAcntFlds Map(CntExpAcntFlds entity ,EditCntExpAcntFldsCommand inputItem)
        {
              
  
		entity.CntExpAcnFldId = inputItem.CntExpAcnFldId;  
  
		entity.CEAFTitle = inputItem.CEAFTitle;  
  
		entity.CEAType = inputItem.CEAType;  
  
		entity.CEAPrvty = inputItem.CEAPrvty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAcntFldsDto Map(CntExpAcntFlds inputItem)
        {
            var dto = new CntExpAcntFldsDto()
            {
                  
  
		CntExpAcnFldId = inputItem.CntExpAcnFldId,  
  
		CEAFTitle = inputItem.CEAFTitle,  
  
		CEAType = inputItem.CEAType,  
  
		CEAPrvty = inputItem.CEAPrvty, 
            };
            return dto;
        }

        public static List<CntExpAcntFldsDto> Map(ICollection<CntExpAcntFlds> entities)
        {
            var dtos = new List<CntExpAcntFldsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAcntFldsDto()
                {
                      
  
		CntExpAcnFldId = inputItem.CntExpAcnFldId,  
  
		CEAFTitle = inputItem.CEAFTitle,  
  
		CEAType = inputItem.CEAType,  
  
		CEAPrvty = inputItem.CEAPrvty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpAcntVals Map(AddCntExpAcntValsCommand inputItem)
        {
            var entity = new CntExpAcntVals() {
                  
  
		CntExpAcntValId = inputItem.CntExpAcntValId,  
  
		CEAVFldRef = inputItem.CEAVFldRef,  
  
		CEAVExpAcntRef = inputItem.CEAVExpAcntRef,  
  
		CEAVAmount = inputItem.CEAVAmount,  
  
		CEAVFormulRef = inputItem.CEAVFormulRef,  
  
		CEAVCurVal = inputItem.CEAVCurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpAcntVals Map(CntExpAcntVals entity ,EditCntExpAcntValsCommand inputItem)
        {
              
  
		entity.CntExpAcntValId = inputItem.CntExpAcntValId;  
  
		entity.CEAVFldRef = inputItem.CEAVFldRef;  
  
		entity.CEAVExpAcntRef = inputItem.CEAVExpAcntRef;  
  
		entity.CEAVAmount = inputItem.CEAVAmount;  
  
		entity.CEAVFormulRef = inputItem.CEAVFormulRef;  
  
		entity.CEAVCurVal = inputItem.CEAVCurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpAcntValsDto Map(CntExpAcntVals inputItem)
        {
            var dto = new CntExpAcntValsDto()
            {
                  
  
		CntExpAcntValId = inputItem.CntExpAcntValId,  
  
		CEAVFldRef = inputItem.CEAVFldRef,  
  
		CEAVExpAcntRef = inputItem.CEAVExpAcntRef,  
  
		CEAVAmount = inputItem.CEAVAmount,  
  
		CEAVFormulRef = inputItem.CEAVFormulRef,  
  
		CEAVCurVal = inputItem.CEAVCurVal, 
            };
            return dto;
        }

        public static List<CntExpAcntValsDto> Map(ICollection<CntExpAcntVals> entities)
        {
            var dtos = new List<CntExpAcntValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpAcntValsDto()
                {
                      
  
		CntExpAcntValId = inputItem.CntExpAcntValId,  
  
		CEAVFldRef = inputItem.CEAVFldRef,  
  
		CEAVExpAcntRef = inputItem.CEAVExpAcntRef,  
  
		CEAVAmount = inputItem.CEAVAmount,  
  
		CEAVFormulRef = inputItem.CEAVFormulRef,  
  
		CEAVCurVal = inputItem.CEAVCurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpFldElmnts Map(AddCntExpFldElmntsCommand inputItem)
        {
            var entity = new CntExpFldElmnts() {
                  
  
		CntExpFldElmntId = inputItem.CntExpFldElmntId,  
  
		CEFEFldRef = inputItem.CEFEFldRef,  
  
		CEFEValue = inputItem.CEFEValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpFldElmnts Map(CntExpFldElmnts entity ,EditCntExpFldElmntsCommand inputItem)
        {
              
  
		entity.CntExpFldElmntId = inputItem.CntExpFldElmntId;  
  
		entity.CEFEFldRef = inputItem.CEFEFldRef;  
  
		entity.CEFEValue = inputItem.CEFEValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpFldElmntsDto Map(CntExpFldElmnts inputItem)
        {
            var dto = new CntExpFldElmntsDto()
            {
                  
  
		CntExpFldElmntId = inputItem.CntExpFldElmntId,  
  
		CEFEFldRef = inputItem.CEFEFldRef,  
  
		CEFEValue = inputItem.CEFEValue, 
            };
            return dto;
        }

        public static List<CntExpFldElmntsDto> Map(ICollection<CntExpFldElmnts> entities)
        {
            var dtos = new List<CntExpFldElmntsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpFldElmntsDto()
                {
                      
  
		CntExpFldElmntId = inputItem.CntExpFldElmntId,  
  
		CEFEFldRef = inputItem.CEFEFldRef,  
  
		CEFEValue = inputItem.CEFEValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExpnsAccnts Map(AddCntExpnsAccntsCommand inputItem)
        {
            var entity = new CntExpnsAccnts() {
                  
  
		CntExpAccId = inputItem.CntExpAccId,  
  
		CEANum = inputItem.CEANum,  
  
		CEADate = inputItem.CEADate,  
  
		CEAType = inputItem.CEAType,  
  
		CEADescr = inputItem.CEADescr,  
  
		CEAContrRef = inputItem.CEAContrRef,  
  
		CEAAllAmnt = inputItem.CEAAllAmnt,  
  
		CEAAmount = inputItem.CEAAmount,  
  
		CEAAmntType = inputItem.CEAAmntType,  
  
		CEAIsSum = inputItem.CEAIsSum,  
  
		CEAAccPrdRef = inputItem.CEAAccPrdRef,  
  
		CEAState = inputItem.CEAState,  
  
		CEAThisAmnt = inputItem.CEAThisAmnt,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CEACurRef = inputItem.CEACurRef,  
  
		CEACurRate = inputItem.CEACurRate,  
  
		CEACurAmnt = inputItem.CEACurAmnt,  
  
		CEALocNum = inputItem.CEALocNum,  
  
		CEAContractorRef = inputItem.CEAContractorRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExpnsAccnts Map(CntExpnsAccnts entity ,EditCntExpnsAccntsCommand inputItem)
        {
              
  
		entity.CntExpAccId = inputItem.CntExpAccId;  
  
		entity.CEANum = inputItem.CEANum;  
  
		entity.CEADate = inputItem.CEADate;  
  
		entity.CEAType = inputItem.CEAType;  
  
		entity.CEADescr = inputItem.CEADescr;  
  
		entity.CEAContrRef = inputItem.CEAContrRef;  
  
		entity.CEAAllAmnt = inputItem.CEAAllAmnt;  
  
		entity.CEAAmount = inputItem.CEAAmount;  
  
		entity.CEAAmntType = inputItem.CEAAmntType;  
  
		entity.CEAIsSum = inputItem.CEAIsSum;  
  
		entity.CEAAccPrdRef = inputItem.CEAAccPrdRef;  
  
		entity.CEAState = inputItem.CEAState;  
  
		entity.CEAThisAmnt = inputItem.CEAThisAmnt;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CEACurRef = inputItem.CEACurRef;  
  
		entity.CEACurRate = inputItem.CEACurRate;  
  
		entity.CEACurAmnt = inputItem.CEACurAmnt;  
  
		entity.CEALocNum = inputItem.CEALocNum;  
  
		entity.CEAContractorRef = inputItem.CEAContractorRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExpnsAccntsDto Map(CntExpnsAccnts inputItem)
        {
            var dto = new CntExpnsAccntsDto()
            {
                  
  
		CntExpAccId = inputItem.CntExpAccId,  
  
		CEANum = inputItem.CEANum,  
  
		CEADate = inputItem.CEADate,  
  
		CEAType = inputItem.CEAType,  
  
		CEADescr = inputItem.CEADescr,  
  
		CEAContrRef = inputItem.CEAContrRef,  
  
		CEAAllAmnt = inputItem.CEAAllAmnt,  
  
		CEAAmount = inputItem.CEAAmount,  
  
		CEAAmntType = inputItem.CEAAmntType,  
  
		CEAIsSum = inputItem.CEAIsSum,  
  
		CEAAccPrdRef = inputItem.CEAAccPrdRef,  
  
		CEAState = inputItem.CEAState,  
  
		CEAThisAmnt = inputItem.CEAThisAmnt,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CEACurRef = inputItem.CEACurRef,  
  
		CEACurRate = inputItem.CEACurRate,  
  
		CEACurAmnt = inputItem.CEACurAmnt,  
  
		CEALocNum = inputItem.CEALocNum,  
  
		CEAContractorRef = inputItem.CEAContractorRef, 
            };
            return dto;
        }

        public static List<CntExpnsAccntsDto> Map(ICollection<CntExpnsAccnts> entities)
        {
            var dtos = new List<CntExpnsAccntsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExpnsAccntsDto()
                {
                      
  
		CntExpAccId = inputItem.CntExpAccId,  
  
		CEANum = inputItem.CEANum,  
  
		CEADate = inputItem.CEADate,  
  
		CEAType = inputItem.CEAType,  
  
		CEADescr = inputItem.CEADescr,  
  
		CEAContrRef = inputItem.CEAContrRef,  
  
		CEAAllAmnt = inputItem.CEAAllAmnt,  
  
		CEAAmount = inputItem.CEAAmount,  
  
		CEAAmntType = inputItem.CEAAmntType,  
  
		CEAIsSum = inputItem.CEAIsSum,  
  
		CEAAccPrdRef = inputItem.CEAAccPrdRef,  
  
		CEAState = inputItem.CEAState,  
  
		CEAThisAmnt = inputItem.CEAThisAmnt,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CEACurRef = inputItem.CEACurRef,  
  
		CEACurRate = inputItem.CEACurRate,  
  
		CEACurAmnt = inputItem.CEACurAmnt,  
  
		CEALocNum = inputItem.CEALocNum,  
  
		CEAContractorRef = inputItem.CEAContractorRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntExtendInf Map(AddCntExtendInfCommand inputItem)
        {
            var entity = new CntExtendInf() {
                  
  
		CntExtendInfId = inputItem.CntExtendInfId,  
  
		CEIBaseItm = inputItem.CEIBaseItm,  
  
		CEIBaseType = inputItem.CEIBaseType,  
  
		CEIFromDate = inputItem.CEIFromDate,  
  
		CEIDur = inputItem.CEIDur,  
  
		CEIAmnt = inputItem.CEIAmnt,  
  
		CEIExtType = inputItem.CEIExtType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntExtendInf Map(CntExtendInf entity ,EditCntExtendInfCommand inputItem)
        {
              
  
		entity.CntExtendInfId = inputItem.CntExtendInfId;  
  
		entity.CEIBaseItm = inputItem.CEIBaseItm;  
  
		entity.CEIBaseType = inputItem.CEIBaseType;  
  
		entity.CEIFromDate = inputItem.CEIFromDate;  
  
		entity.CEIDur = inputItem.CEIDur;  
  
		entity.CEIAmnt = inputItem.CEIAmnt;  
  
		entity.CEIExtType = inputItem.CEIExtType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntExtendInfDto Map(CntExtendInf inputItem)
        {
            var dto = new CntExtendInfDto()
            {
                  
  
		CntExtendInfId = inputItem.CntExtendInfId,  
  
		CEIBaseItm = inputItem.CEIBaseItm,  
  
		CEIBaseType = inputItem.CEIBaseType,  
  
		CEIFromDate = inputItem.CEIFromDate,  
  
		CEIDur = inputItem.CEIDur,  
  
		CEIAmnt = inputItem.CEIAmnt,  
  
		CEIExtType = inputItem.CEIExtType, 
            };
            return dto;
        }

        public static List<CntExtendInfDto> Map(ICollection<CntExtendInf> entities)
        {
            var dtos = new List<CntExtendInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntExtendInfDto()
                {
                      
  
		CntExtendInfId = inputItem.CntExtendInfId,  
  
		CEIBaseItm = inputItem.CEIBaseItm,  
  
		CEIBaseType = inputItem.CEIBaseType,  
  
		CEIFromDate = inputItem.CEIFromDate,  
  
		CEIDur = inputItem.CEIDur,  
  
		CEIAmnt = inputItem.CEIAmnt,  
  
		CEIExtType = inputItem.CEIExtType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntFormFields Map(AddCntFormFieldsCommand inputItem)
        {
            var entity = new CntFormFields() {
                  
  
		CntFormFieldsId = inputItem.CntFormFieldsId,  
  
		CFFType = inputItem.CFFType,  
  
		CFFTitle = inputItem.CFFTitle,  
  
		CFFCalcPr = inputItem.CFFCalcPr,  
  
		CFFFieldOpr = inputItem.CFFFieldOpr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntFormFields Map(CntFormFields entity ,EditCntFormFieldsCommand inputItem)
        {
              
  
		entity.CntFormFieldsId = inputItem.CntFormFieldsId;  
  
		entity.CFFType = inputItem.CFFType;  
  
		entity.CFFTitle = inputItem.CFFTitle;  
  
		entity.CFFCalcPr = inputItem.CFFCalcPr;  
  
		entity.CFFFieldOpr = inputItem.CFFFieldOpr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntFormFieldsDto Map(CntFormFields inputItem)
        {
            var dto = new CntFormFieldsDto()
            {
                  
  
		CntFormFieldsId = inputItem.CntFormFieldsId,  
  
		CFFType = inputItem.CFFType,  
  
		CFFTitle = inputItem.CFFTitle,  
  
		CFFCalcPr = inputItem.CFFCalcPr,  
  
		CFFFieldOpr = inputItem.CFFFieldOpr, 
            };
            return dto;
        }

        public static List<CntFormFieldsDto> Map(ICollection<CntFormFields> entities)
        {
            var dtos = new List<CntFormFieldsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntFormFieldsDto()
                {
                      
  
		CntFormFieldsId = inputItem.CntFormFieldsId,  
  
		CFFType = inputItem.CFFType,  
  
		CFFTitle = inputItem.CFFTitle,  
  
		CFFCalcPr = inputItem.CFFCalcPr,  
  
		CFFFieldOpr = inputItem.CFFFieldOpr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntFormVals Map(AddCntFormValsCommand inputItem)
        {
            var entity = new CntFormVals() {
                  
  
		CntFormValsId = inputItem.CntFormValsId,  
  
		CFVType = inputItem.CFVType,  
  
		CFVBaseId = inputItem.CFVBaseId,  
  
		CFVFieldRef = inputItem.CFVFieldRef,  
  
		CFVAmount = inputItem.CFVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntFormVals Map(CntFormVals entity ,EditCntFormValsCommand inputItem)
        {
              
  
		entity.CntFormValsId = inputItem.CntFormValsId;  
  
		entity.CFVType = inputItem.CFVType;  
  
		entity.CFVBaseId = inputItem.CFVBaseId;  
  
		entity.CFVFieldRef = inputItem.CFVFieldRef;  
  
		entity.CFVAmount = inputItem.CFVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntFormValsDto Map(CntFormVals inputItem)
        {
            var dto = new CntFormValsDto()
            {
                  
  
		CntFormValsId = inputItem.CntFormValsId,  
  
		CFVType = inputItem.CFVType,  
  
		CFVBaseId = inputItem.CFVBaseId,  
  
		CFVFieldRef = inputItem.CFVFieldRef,  
  
		CFVAmount = inputItem.CFVAmount, 
            };
            return dto;
        }

        public static List<CntFormValsDto> Map(ICollection<CntFormVals> entities)
        {
            var dtos = new List<CntFormValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntFormValsDto()
                {
                      
  
		CntFormValsId = inputItem.CntFormValsId,  
  
		CFVType = inputItem.CFVType,  
  
		CFVBaseId = inputItem.CFVBaseId,  
  
		CFVFieldRef = inputItem.CFVFieldRef,  
  
		CFVAmount = inputItem.CFVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntGaurantInf Map(AddCntGaurantInfCommand inputItem)
        {
            var entity = new CntGaurantInf() {
                  
  
		CntGaurantInfId = inputItem.CntGaurantInfId,  
  
		CGIBaseItm = inputItem.CGIBaseItm,  
  
		CGIBaseType = inputItem.CGIBaseType,  
  
		CGIFromDate = inputItem.CGIFromDate,  
  
		CGIDur = inputItem.CGIDur,  
  
		CGIDescr = inputItem.CGIDescr,  
  
		CGIAmount = inputItem.CGIAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntGaurantInf Map(CntGaurantInf entity ,EditCntGaurantInfCommand inputItem)
        {
              
  
		entity.CntGaurantInfId = inputItem.CntGaurantInfId;  
  
		entity.CGIBaseItm = inputItem.CGIBaseItm;  
  
		entity.CGIBaseType = inputItem.CGIBaseType;  
  
		entity.CGIFromDate = inputItem.CGIFromDate;  
  
		entity.CGIDur = inputItem.CGIDur;  
  
		entity.CGIDescr = inputItem.CGIDescr;  
  
		entity.CGIAmount = inputItem.CGIAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntGaurantInfDto Map(CntGaurantInf inputItem)
        {
            var dto = new CntGaurantInfDto()
            {
                  
  
		CntGaurantInfId = inputItem.CntGaurantInfId,  
  
		CGIBaseItm = inputItem.CGIBaseItm,  
  
		CGIBaseType = inputItem.CGIBaseType,  
  
		CGIFromDate = inputItem.CGIFromDate,  
  
		CGIDur = inputItem.CGIDur,  
  
		CGIDescr = inputItem.CGIDescr,  
  
		CGIAmount = inputItem.CGIAmount, 
            };
            return dto;
        }

        public static List<CntGaurantInfDto> Map(ICollection<CntGaurantInf> entities)
        {
            var dtos = new List<CntGaurantInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntGaurantInfDto()
                {
                      
  
		CntGaurantInfId = inputItem.CntGaurantInfId,  
  
		CGIBaseItm = inputItem.CGIBaseItm,  
  
		CGIBaseType = inputItem.CGIBaseType,  
  
		CGIFromDate = inputItem.CGIFromDate,  
  
		CGIDur = inputItem.CGIDur,  
  
		CGIDescr = inputItem.CGIDescr,  
  
		CGIAmount = inputItem.CGIAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntGnrText Map(AddCntGnrTextCommand inputItem)
        {
            var entity = new CntGnrText() {
                  
  
		CntGnrTextId = inputItem.CntGnrTextId,  
  
		CGTType = inputItem.CGTType,  
  
		CGTContain = inputItem.CGTContain, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntGnrText Map(CntGnrText entity ,EditCntGnrTextCommand inputItem)
        {
              
  
		entity.CntGnrTextId = inputItem.CntGnrTextId;  
  
		entity.CGTType = inputItem.CGTType;  
  
		entity.CGTContain = inputItem.CGTContain; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntGnrTextDto Map(CntGnrText inputItem)
        {
            var dto = new CntGnrTextDto()
            {
                  
  
		CntGnrTextId = inputItem.CntGnrTextId,  
  
		CGTType = inputItem.CGTType,  
  
		CGTContain = inputItem.CGTContain, 
            };
            return dto;
        }

        public static List<CntGnrTextDto> Map(ICollection<CntGnrText> entities)
        {
            var dtos = new List<CntGnrTextDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntGnrTextDto()
                {
                      
  
		CntGnrTextId = inputItem.CntGnrTextId,  
  
		CGTType = inputItem.CGTType,  
  
		CGTContain = inputItem.CGTContain, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntInvoiceDet Map(AddCntInvoiceDetCommand inputItem)
        {
            var entity = new CntInvoiceDet() {
                  
  
		CntInvoiceDetId = inputItem.CntInvoiceDetId,  
  
		CIDType = inputItem.CIDType,  
  
		CIDRelRef = inputItem.CIDRelRef,  
  
		CIDExpAcntRef = inputItem.CIDExpAcntRef,  
  
		CIDLabel = inputItem.CIDLabel,  
  
		CIDRatio = inputItem.CIDRatio,  
  
		CIDCalc = inputItem.CIDCalc,  
  
		CIDPay = inputItem.CIDPay,  
  
		CIDHaveRet = inputItem.CIDHaveRet,  
  
		CIDExpVal = inputItem.CIDExpVal,  
  
		CIDHdrRef = inputItem.CIDHdrRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntInvoiceDet Map(CntInvoiceDet entity ,EditCntInvoiceDetCommand inputItem)
        {
              
  
		entity.CntInvoiceDetId = inputItem.CntInvoiceDetId;  
  
		entity.CIDType = inputItem.CIDType;  
  
		entity.CIDRelRef = inputItem.CIDRelRef;  
  
		entity.CIDExpAcntRef = inputItem.CIDExpAcntRef;  
  
		entity.CIDLabel = inputItem.CIDLabel;  
  
		entity.CIDRatio = inputItem.CIDRatio;  
  
		entity.CIDCalc = inputItem.CIDCalc;  
  
		entity.CIDPay = inputItem.CIDPay;  
  
		entity.CIDHaveRet = inputItem.CIDHaveRet;  
  
		entity.CIDExpVal = inputItem.CIDExpVal;  
  
		entity.CIDHdrRef = inputItem.CIDHdrRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntInvoiceDetDto Map(CntInvoiceDet inputItem)
        {
            var dto = new CntInvoiceDetDto()
            {
                  
  
		CntInvoiceDetId = inputItem.CntInvoiceDetId,  
  
		CIDType = inputItem.CIDType,  
  
		CIDRelRef = inputItem.CIDRelRef,  
  
		CIDExpAcntRef = inputItem.CIDExpAcntRef,  
  
		CIDLabel = inputItem.CIDLabel,  
  
		CIDRatio = inputItem.CIDRatio,  
  
		CIDCalc = inputItem.CIDCalc,  
  
		CIDPay = inputItem.CIDPay,  
  
		CIDHaveRet = inputItem.CIDHaveRet,  
  
		CIDExpVal = inputItem.CIDExpVal,  
  
		CIDHdrRef = inputItem.CIDHdrRef, 
            };
            return dto;
        }

        public static List<CntInvoiceDetDto> Map(ICollection<CntInvoiceDet> entities)
        {
            var dtos = new List<CntInvoiceDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntInvoiceDetDto()
                {
                      
  
		CntInvoiceDetId = inputItem.CntInvoiceDetId,  
  
		CIDType = inputItem.CIDType,  
  
		CIDRelRef = inputItem.CIDRelRef,  
  
		CIDExpAcntRef = inputItem.CIDExpAcntRef,  
  
		CIDLabel = inputItem.CIDLabel,  
  
		CIDRatio = inputItem.CIDRatio,  
  
		CIDCalc = inputItem.CIDCalc,  
  
		CIDPay = inputItem.CIDPay,  
  
		CIDHaveRet = inputItem.CIDHaveRet,  
  
		CIDExpVal = inputItem.CIDExpVal,  
  
		CIDHdrRef = inputItem.CIDHdrRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntInvoiceHdr Map(AddCntInvoiceHdrCommand inputItem)
        {
            var entity = new CntInvoiceHdr() {
                  
  
		CntInvoiceHdrId = inputItem.CntInvoiceHdrId,  
  
		CIHType = inputItem.CIHType,  
  
		CIHExpAcntRef = inputItem.CIHExpAcntRef,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHCreator = inputItem.CIHCreator,  
  
		CIHDescr = inputItem.CIHDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntInvoiceHdr Map(CntInvoiceHdr entity ,EditCntInvoiceHdrCommand inputItem)
        {
              
  
		entity.CntInvoiceHdrId = inputItem.CntInvoiceHdrId;  
  
		entity.CIHType = inputItem.CIHType;  
  
		entity.CIHExpAcntRef = inputItem.CIHExpAcntRef;  
  
		entity.CIHDate = inputItem.CIHDate;  
  
		entity.CIHNum = inputItem.CIHNum;  
  
		entity.CIHCreator = inputItem.CIHCreator;  
  
		entity.CIHDescr = inputItem.CIHDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntInvoiceHdrDto Map(CntInvoiceHdr inputItem)
        {
            var dto = new CntInvoiceHdrDto()
            {
                  
  
		CntInvoiceHdrId = inputItem.CntInvoiceHdrId,  
  
		CIHType = inputItem.CIHType,  
  
		CIHExpAcntRef = inputItem.CIHExpAcntRef,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHCreator = inputItem.CIHCreator,  
  
		CIHDescr = inputItem.CIHDescr, 
            };
            return dto;
        }

        public static List<CntInvoiceHdrDto> Map(ICollection<CntInvoiceHdr> entities)
        {
            var dtos = new List<CntInvoiceHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntInvoiceHdrDto()
                {
                      
  
		CntInvoiceHdrId = inputItem.CntInvoiceHdrId,  
  
		CIHType = inputItem.CIHType,  
  
		CIHExpAcntRef = inputItem.CIHExpAcntRef,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHCreator = inputItem.CIHCreator,  
  
		CIHDescr = inputItem.CIHDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntInvoiceNotes Map(AddCntInvoiceNotesCommand inputItem)
        {
            var entity = new CntInvoiceNotes() {
                  
  
		CntInvoiceNoteId = inputItem.CntInvoiceNoteId,  
  
		CINTitle = inputItem.CINTitle,  
  
		CINFormul = inputItem.CINFormul, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntInvoiceNotes Map(CntInvoiceNotes entity ,EditCntInvoiceNotesCommand inputItem)
        {
              
  
		entity.CntInvoiceNoteId = inputItem.CntInvoiceNoteId;  
  
		entity.CINTitle = inputItem.CINTitle;  
  
		entity.CINFormul = inputItem.CINFormul; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntInvoiceNotesDto Map(CntInvoiceNotes inputItem)
        {
            var dto = new CntInvoiceNotesDto()
            {
                  
  
		CntInvoiceNoteId = inputItem.CntInvoiceNoteId,  
  
		CINTitle = inputItem.CINTitle,  
  
		CINFormul = inputItem.CINFormul, 
            };
            return dto;
        }

        public static List<CntInvoiceNotesDto> Map(ICollection<CntInvoiceNotes> entities)
        {
            var dtos = new List<CntInvoiceNotesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntInvoiceNotesDto()
                {
                      
  
		CntInvoiceNoteId = inputItem.CntInvoiceNoteId,  
  
		CINTitle = inputItem.CINTitle,  
  
		CINFormul = inputItem.CINFormul, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntInvoiceRels Map(AddCntInvoiceRelsCommand inputItem)
        {
            var entity = new CntInvoiceRels() {
                  
  
		CntInvoiceRelId = inputItem.CntInvoiceRelId,  
  
		CIRLabel = inputItem.CIRLabel,  
  
		CIRRatioField = inputItem.CIRRatioField,  
  
		CIRCalcField = inputItem.CIRCalcField,  
  
		CIRPayField = inputItem.CIRPayField,  
  
		CIRPayAccCode = inputItem.CIRPayAccCode,  
  
		CIRHaveRet = inputItem.CIRHaveRet,  
  
		CIRPriovity = inputItem.CIRPriovity,  
  
		CIROprType = inputItem.CIROprType,  
  
		CIRRetCtrl = inputItem.CIRRetCtrl,  
  
		CIRRetCtrl2 = inputItem.CIRRetCtrl2,  
  
		CIRCheckDate = inputItem.CIRCheckDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntInvoiceRels Map(CntInvoiceRels entity ,EditCntInvoiceRelsCommand inputItem)
        {
              
  
		entity.CntInvoiceRelId = inputItem.CntInvoiceRelId;  
  
		entity.CIRLabel = inputItem.CIRLabel;  
  
		entity.CIRRatioField = inputItem.CIRRatioField;  
  
		entity.CIRCalcField = inputItem.CIRCalcField;  
  
		entity.CIRPayField = inputItem.CIRPayField;  
  
		entity.CIRPayAccCode = inputItem.CIRPayAccCode;  
  
		entity.CIRHaveRet = inputItem.CIRHaveRet;  
  
		entity.CIRPriovity = inputItem.CIRPriovity;  
  
		entity.CIROprType = inputItem.CIROprType;  
  
		entity.CIRRetCtrl = inputItem.CIRRetCtrl;  
  
		entity.CIRRetCtrl2 = inputItem.CIRRetCtrl2;  
  
		entity.CIRCheckDate = inputItem.CIRCheckDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntInvoiceRelsDto Map(CntInvoiceRels inputItem)
        {
            var dto = new CntInvoiceRelsDto()
            {
                  
  
		CntInvoiceRelId = inputItem.CntInvoiceRelId,  
  
		CIRLabel = inputItem.CIRLabel,  
  
		CIRRatioField = inputItem.CIRRatioField,  
  
		CIRCalcField = inputItem.CIRCalcField,  
  
		CIRPayField = inputItem.CIRPayField,  
  
		CIRPayAccCode = inputItem.CIRPayAccCode,  
  
		CIRHaveRet = inputItem.CIRHaveRet,  
  
		CIRPriovity = inputItem.CIRPriovity,  
  
		CIROprType = inputItem.CIROprType,  
  
		CIRRetCtrl = inputItem.CIRRetCtrl,  
  
		CIRRetCtrl2 = inputItem.CIRRetCtrl2,  
  
		CIRCheckDate = inputItem.CIRCheckDate, 
            };
            return dto;
        }

        public static List<CntInvoiceRelsDto> Map(ICollection<CntInvoiceRels> entities)
        {
            var dtos = new List<CntInvoiceRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntInvoiceRelsDto()
                {
                      
  
		CntInvoiceRelId = inputItem.CntInvoiceRelId,  
  
		CIRLabel = inputItem.CIRLabel,  
  
		CIRRatioField = inputItem.CIRRatioField,  
  
		CIRCalcField = inputItem.CIRCalcField,  
  
		CIRPayField = inputItem.CIRPayField,  
  
		CIRPayAccCode = inputItem.CIRPayAccCode,  
  
		CIRHaveRet = inputItem.CIRHaveRet,  
  
		CIRPriovity = inputItem.CIRPriovity,  
  
		CIROprType = inputItem.CIROprType,  
  
		CIRRetCtrl = inputItem.CIRRetCtrl,  
  
		CIRRetCtrl2 = inputItem.CIRRetCtrl2,  
  
		CIRCheckDate = inputItem.CIRCheckDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntMasterFactData Map(AddCntMasterFactDataCommand inputItem)
        {
            var entity = new CntMasterFactData() {
                  
  
		CntMasterFactDataID = inputItem.CntMasterFactDataID,  
  
		CMFDFactRef = inputItem.CMFDFactRef,  
  
		CMFDFldRef = inputItem.CMFDFldRef,  
  
		CMFDAmount = inputItem.CMFDAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntMasterFactData Map(CntMasterFactData entity ,EditCntMasterFactDataCommand inputItem)
        {
              
  
		entity.CntMasterFactDataID = inputItem.CntMasterFactDataID;  
  
		entity.CMFDFactRef = inputItem.CMFDFactRef;  
  
		entity.CMFDFldRef = inputItem.CMFDFldRef;  
  
		entity.CMFDAmount = inputItem.CMFDAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntMasterFactDataDto Map(CntMasterFactData inputItem)
        {
            var dto = new CntMasterFactDataDto()
            {
                  
  
		CntMasterFactDataID = inputItem.CntMasterFactDataID,  
  
		CMFDFactRef = inputItem.CMFDFactRef,  
  
		CMFDFldRef = inputItem.CMFDFldRef,  
  
		CMFDAmount = inputItem.CMFDAmount, 
            };
            return dto;
        }

        public static List<CntMasterFactDataDto> Map(ICollection<CntMasterFactData> entities)
        {
            var dtos = new List<CntMasterFactDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntMasterFactDataDto()
                {
                      
  
		CntMasterFactDataID = inputItem.CntMasterFactDataID,  
  
		CMFDFactRef = inputItem.CMFDFactRef,  
  
		CMFDFldRef = inputItem.CMFDFldRef,  
  
		CMFDAmount = inputItem.CMFDAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntMasterFactor Map(AddCntMasterFactorCommand inputItem)
        {
            var entity = new CntMasterFactor() {
                  
  
		CntMasterFactorId = inputItem.CntMasterFactorId,  
  
		CMFSerial = inputItem.CMFSerial,  
  
		CMFNum = inputItem.CMFNum,  
  
		CMFDate = inputItem.CMFDate,  
  
		CMFContRef = inputItem.CMFContRef,  
  
		CMFAmount = inputItem.CMFAmount,  
  
		CMFDescr = inputItem.CMFDescr,  
  
		CMFPrdRef = inputItem.CMFPrdRef,  
  
		CMFState = inputItem.CMFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntMasterFactor Map(CntMasterFactor entity ,EditCntMasterFactorCommand inputItem)
        {
              
  
		entity.CntMasterFactorId = inputItem.CntMasterFactorId;  
  
		entity.CMFSerial = inputItem.CMFSerial;  
  
		entity.CMFNum = inputItem.CMFNum;  
  
		entity.CMFDate = inputItem.CMFDate;  
  
		entity.CMFContRef = inputItem.CMFContRef;  
  
		entity.CMFAmount = inputItem.CMFAmount;  
  
		entity.CMFDescr = inputItem.CMFDescr;  
  
		entity.CMFPrdRef = inputItem.CMFPrdRef;  
  
		entity.CMFState = inputItem.CMFState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntMasterFactorDto Map(CntMasterFactor inputItem)
        {
            var dto = new CntMasterFactorDto()
            {
                  
  
		CntMasterFactorId = inputItem.CntMasterFactorId,  
  
		CMFSerial = inputItem.CMFSerial,  
  
		CMFNum = inputItem.CMFNum,  
  
		CMFDate = inputItem.CMFDate,  
  
		CMFContRef = inputItem.CMFContRef,  
  
		CMFAmount = inputItem.CMFAmount,  
  
		CMFDescr = inputItem.CMFDescr,  
  
		CMFPrdRef = inputItem.CMFPrdRef,  
  
		CMFState = inputItem.CMFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<CntMasterFactorDto> Map(ICollection<CntMasterFactor> entities)
        {
            var dtos = new List<CntMasterFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntMasterFactorDto()
                {
                      
  
		CntMasterFactorId = inputItem.CntMasterFactorId,  
  
		CMFSerial = inputItem.CMFSerial,  
  
		CMFNum = inputItem.CMFNum,  
  
		CMFDate = inputItem.CMFDate,  
  
		CMFContRef = inputItem.CMFContRef,  
  
		CMFAmount = inputItem.CMFAmount,  
  
		CMFDescr = inputItem.CMFDescr,  
  
		CMFPrdRef = inputItem.CMFPrdRef,  
  
		CMFState = inputItem.CMFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntMasterFactVal Map(AddCntMasterFactValCommand inputItem)
        {
            var entity = new CntMasterFactVal() {
                  
  
		CntMastFactValsId = inputItem.CntMastFactValsId,  
  
		CMFVFldRef = inputItem.CMFVFldRef,  
  
		CMFVFactRef = inputItem.CMFVFactRef,  
  
		CMFVAmount = inputItem.CMFVAmount,  
  
		CMFVFormulRef = inputItem.CMFVFormulRef,  
  
		CMFVCurVal = inputItem.CMFVCurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntMasterFactVal Map(CntMasterFactVal entity ,EditCntMasterFactValCommand inputItem)
        {
              
  
		entity.CntMastFactValsId = inputItem.CntMastFactValsId;  
  
		entity.CMFVFldRef = inputItem.CMFVFldRef;  
  
		entity.CMFVFactRef = inputItem.CMFVFactRef;  
  
		entity.CMFVAmount = inputItem.CMFVAmount;  
  
		entity.CMFVFormulRef = inputItem.CMFVFormulRef;  
  
		entity.CMFVCurVal = inputItem.CMFVCurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntMasterFactValDto Map(CntMasterFactVal inputItem)
        {
            var dto = new CntMasterFactValDto()
            {
                  
  
		CntMastFactValsId = inputItem.CntMastFactValsId,  
  
		CMFVFldRef = inputItem.CMFVFldRef,  
  
		CMFVFactRef = inputItem.CMFVFactRef,  
  
		CMFVAmount = inputItem.CMFVAmount,  
  
		CMFVFormulRef = inputItem.CMFVFormulRef,  
  
		CMFVCurVal = inputItem.CMFVCurVal, 
            };
            return dto;
        }

        public static List<CntMasterFactValDto> Map(ICollection<CntMasterFactVal> entities)
        {
            var dtos = new List<CntMasterFactValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntMasterFactValDto()
                {
                      
  
		CntMastFactValsId = inputItem.CntMastFactValsId,  
  
		CMFVFldRef = inputItem.CMFVFldRef,  
  
		CMFVFactRef = inputItem.CMFVFactRef,  
  
		CMFVAmount = inputItem.CMFVAmount,  
  
		CMFVFormulRef = inputItem.CMFVFormulRef,  
  
		CMFVCurVal = inputItem.CMFVCurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntMasters Map(AddCntMastersCommand inputItem)
        {
            var entity = new CntMasters() {
                  
  
		CntMasterId = inputItem.CntMasterId,  
  
		CMCrsRef = inputItem.CMCrsRef,  
  
		CMSLRef = inputItem.CMSLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntMasters Map(CntMasters entity ,EditCntMastersCommand inputItem)
        {
              
  
		entity.CntMasterId = inputItem.CntMasterId;  
  
		entity.CMCrsRef = inputItem.CMCrsRef;  
  
		entity.CMSLRef = inputItem.CMSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntMastersDto Map(CntMasters inputItem)
        {
            var dto = new CntMastersDto()
            {
                  
  
		CntMasterId = inputItem.CntMasterId,  
  
		CMCrsRef = inputItem.CMCrsRef,  
  
		CMSLRef = inputItem.CMSLRef, 
            };
            return dto;
        }

        public static List<CntMastersDto> Map(ICollection<CntMasters> entities)
        {
            var dtos = new List<CntMastersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntMastersDto()
                {
                      
  
		CntMasterId = inputItem.CntMasterId,  
  
		CMCrsRef = inputItem.CMCrsRef,  
  
		CMSLRef = inputItem.CMSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntSrvItems Map(AddCntSrvItemsCommand inputItem)
        {
            var entity = new CntSrvItems() {
                  
  
		CntSrvItemId = inputItem.CntSrvItemId,  
  
		CSITitle = inputItem.CSITitle,  
  
		CSISLRef = inputItem.CSISLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntSrvItems Map(CntSrvItems entity ,EditCntSrvItemsCommand inputItem)
        {
              
  
		entity.CntSrvItemId = inputItem.CntSrvItemId;  
  
		entity.CSITitle = inputItem.CSITitle;  
  
		entity.CSISLRef = inputItem.CSISLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntSrvItemsDto Map(CntSrvItems inputItem)
        {
            var dto = new CntSrvItemsDto()
            {
                  
  
		CntSrvItemId = inputItem.CntSrvItemId,  
  
		CSITitle = inputItem.CSITitle,  
  
		CSISLRef = inputItem.CSISLRef, 
            };
            return dto;
        }

        public static List<CntSrvItemsDto> Map(ICollection<CntSrvItems> entities)
        {
            var dtos = new List<CntSrvItemsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntSrvItemsDto()
                {
                      
  
		CntSrvItemId = inputItem.CntSrvItemId,  
  
		CSITitle = inputItem.CSITitle,  
  
		CSISLRef = inputItem.CSISLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntSrvPrcHdr Map(AddCntSrvPrcHdrCommand inputItem)
        {
            var entity = new CntSrvPrcHdr() {
                  
  
		CntSrvPrcHdrID = inputItem.CntSrvPrcHdrID,  
  
		CSPHNum = inputItem.CSPHNum,  
  
		CSPHLocalNum = inputItem.CSPHLocalNum,  
  
		CSPHDate = inputItem.CSPHDate,  
  
		CSPHDescr = inputItem.CSPHDescr,  
  
		CSPHHaveEff = inputItem.CSPHHaveEff,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSPHState = inputItem.CSPHState,  
  
		CSPAccPrdRef = inputItem.CSPAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntSrvPrcHdr Map(CntSrvPrcHdr entity ,EditCntSrvPrcHdrCommand inputItem)
        {
              
  
		entity.CntSrvPrcHdrID = inputItem.CntSrvPrcHdrID;  
  
		entity.CSPHNum = inputItem.CSPHNum;  
  
		entity.CSPHLocalNum = inputItem.CSPHLocalNum;  
  
		entity.CSPHDate = inputItem.CSPHDate;  
  
		entity.CSPHDescr = inputItem.CSPHDescr;  
  
		entity.CSPHHaveEff = inputItem.CSPHHaveEff;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CSPHState = inputItem.CSPHState;  
  
		entity.CSPAccPrdRef = inputItem.CSPAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntSrvPrcHdrDto Map(CntSrvPrcHdr inputItem)
        {
            var dto = new CntSrvPrcHdrDto()
            {
                  
  
		CntSrvPrcHdrID = inputItem.CntSrvPrcHdrID,  
  
		CSPHNum = inputItem.CSPHNum,  
  
		CSPHLocalNum = inputItem.CSPHLocalNum,  
  
		CSPHDate = inputItem.CSPHDate,  
  
		CSPHDescr = inputItem.CSPHDescr,  
  
		CSPHHaveEff = inputItem.CSPHHaveEff,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSPHState = inputItem.CSPHState,  
  
		CSPAccPrdRef = inputItem.CSPAccPrdRef, 
            };
            return dto;
        }

        public static List<CntSrvPrcHdrDto> Map(ICollection<CntSrvPrcHdr> entities)
        {
            var dtos = new List<CntSrvPrcHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntSrvPrcHdrDto()
                {
                      
  
		CntSrvPrcHdrID = inputItem.CntSrvPrcHdrID,  
  
		CSPHNum = inputItem.CSPHNum,  
  
		CSPHLocalNum = inputItem.CSPHLocalNum,  
  
		CSPHDate = inputItem.CSPHDate,  
  
		CSPHDescr = inputItem.CSPHDescr,  
  
		CSPHHaveEff = inputItem.CSPHHaveEff,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSPHState = inputItem.CSPHState,  
  
		CSPAccPrdRef = inputItem.CSPAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CntSrvPrcItm Map(AddCntSrvPrcItmCommand inputItem)
        {
            var entity = new CntSrvPrcItm() {
                  
  
		CntSrvPrcItmId = inputItem.CntSrvPrcItmId,  
  
		CntSrvPrcHdrRef = inputItem.CntSrvPrcHdrRef,  
  
		CSPISeq = inputItem.CSPISeq,  
  
		CSPIItemRef = inputItem.CSPIItemRef,  
  
		CSPIUnitRef = inputItem.CSPIUnitRef,  
  
		CSPIMinQty = inputItem.CSPIMinQty,  
  
		CSPIMaxQty = inputItem.CSPIMaxQty,  
  
		CSPIUnitSrvPrc = inputItem.CSPIUnitSrvPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CntSrvPrcItm Map(CntSrvPrcItm entity ,EditCntSrvPrcItmCommand inputItem)
        {
              
  
		entity.CntSrvPrcItmId = inputItem.CntSrvPrcItmId;  
  
		entity.CntSrvPrcHdrRef = inputItem.CntSrvPrcHdrRef;  
  
		entity.CSPISeq = inputItem.CSPISeq;  
  
		entity.CSPIItemRef = inputItem.CSPIItemRef;  
  
		entity.CSPIUnitRef = inputItem.CSPIUnitRef;  
  
		entity.CSPIMinQty = inputItem.CSPIMinQty;  
  
		entity.CSPIMaxQty = inputItem.CSPIMaxQty;  
  
		entity.CSPIUnitSrvPrc = inputItem.CSPIUnitSrvPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CntSrvPrcItmDto Map(CntSrvPrcItm inputItem)
        {
            var dto = new CntSrvPrcItmDto()
            {
                  
  
		CntSrvPrcItmId = inputItem.CntSrvPrcItmId,  
  
		CntSrvPrcHdrRef = inputItem.CntSrvPrcHdrRef,  
  
		CSPISeq = inputItem.CSPISeq,  
  
		CSPIItemRef = inputItem.CSPIItemRef,  
  
		CSPIUnitRef = inputItem.CSPIUnitRef,  
  
		CSPIMinQty = inputItem.CSPIMinQty,  
  
		CSPIMaxQty = inputItem.CSPIMaxQty,  
  
		CSPIUnitSrvPrc = inputItem.CSPIUnitSrvPrc, 
            };
            return dto;
        }

        public static List<CntSrvPrcItmDto> Map(ICollection<CntSrvPrcItm> entities)
        {
            var dtos = new List<CntSrvPrcItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CntSrvPrcItmDto()
                {
                      
  
		CntSrvPrcItmId = inputItem.CntSrvPrcItmId,  
  
		CntSrvPrcHdrRef = inputItem.CntSrvPrcHdrRef,  
  
		CSPISeq = inputItem.CSPISeq,  
  
		CSPIItemRef = inputItem.CSPIItemRef,  
  
		CSPIUnitRef = inputItem.CSPIUnitRef,  
  
		CSPIMinQty = inputItem.CSPIMinQty,  
  
		CSPIMaxQty = inputItem.CSPIMaxQty,  
  
		CSPIUnitSrvPrc = inputItem.CSPIUnitSrvPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
