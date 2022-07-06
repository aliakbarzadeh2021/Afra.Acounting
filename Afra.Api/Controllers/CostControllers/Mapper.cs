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
                
        
        public static CostCenters Map(AddCostCentersCommand inputItem)
        {
            var entity = new CostCenters() {
                  
  
		CostCenterID = inputItem.CostCenterID,  
  
		CstCode = inputItem.CstCode,  
  
		CstName = inputItem.CstName,  
  
		CstDLRef = inputItem.CstDLRef,  
  
		CstType = inputItem.CstType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostCenters Map(CostCenters entity ,EditCostCentersCommand inputItem)
        {
              
  
		entity.CostCenterID = inputItem.CostCenterID;  
  
		entity.CstCode = inputItem.CstCode;  
  
		entity.CstName = inputItem.CstName;  
  
		entity.CstDLRef = inputItem.CstDLRef;  
  
		entity.CstType = inputItem.CstType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostCentersDto Map(CostCenters inputItem)
        {
            var dto = new CostCentersDto()
            {
                  
  
		CostCenterID = inputItem.CostCenterID,  
  
		CstCode = inputItem.CstCode,  
  
		CstName = inputItem.CstName,  
  
		CstDLRef = inputItem.CstDLRef,  
  
		CstType = inputItem.CstType, 
            };
            return dto;
        }

        public static List<CostCentersDto> Map(ICollection<CostCenters> entities)
        {
            var dtos = new List<CostCentersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostCentersDto()
                {
                      
  
		CostCenterID = inputItem.CostCenterID,  
  
		CstCode = inputItem.CstCode,  
  
		CstName = inputItem.CstName,  
  
		CstDLRef = inputItem.CstDLRef,  
  
		CstType = inputItem.CstType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstAccData Map(AddCstAccDataCommand inputItem)
        {
            var entity = new CstAccData() {
                  
  
		CADPeriodRef = inputItem.CADPeriodRef,  
  
		CADSLRef = inputItem.CADSLRef,  
  
		CADDLRef = inputItem.CADDLRef,  
  
		CADDLFive = inputItem.CADDLFive,  
  
		CADDLSix = inputItem.CADDLSix,  
  
		CADDebit = inputItem.CADDebit,  
  
		CADCredit = inputItem.CADCredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstAccData Map(CstAccData entity ,EditCstAccDataCommand inputItem)
        {
              
  
		entity.CADPeriodRef = inputItem.CADPeriodRef;  
  
		entity.CADSLRef = inputItem.CADSLRef;  
  
		entity.CADDLRef = inputItem.CADDLRef;  
  
		entity.CADDLFive = inputItem.CADDLFive;  
  
		entity.CADDLSix = inputItem.CADDLSix;  
  
		entity.CADDebit = inputItem.CADDebit;  
  
		entity.CADCredit = inputItem.CADCredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstAccDataDto Map(CstAccData inputItem)
        {
            var dto = new CstAccDataDto()
            {
                  
  
		CADPeriodRef = inputItem.CADPeriodRef,  
  
		CADSLRef = inputItem.CADSLRef,  
  
		CADDLRef = inputItem.CADDLRef,  
  
		CADDLFive = inputItem.CADDLFive,  
  
		CADDLSix = inputItem.CADDLSix,  
  
		CADDebit = inputItem.CADDebit,  
  
		CADCredit = inputItem.CADCredit, 
            };
            return dto;
        }

        public static List<CstAccDataDto> Map(ICollection<CstAccData> entities)
        {
            var dtos = new List<CstAccDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstAccDataDto()
                {
                      
  
		CADPeriodRef = inputItem.CADPeriodRef,  
  
		CADSLRef = inputItem.CADSLRef,  
  
		CADDLRef = inputItem.CADDLRef,  
  
		CADDLFive = inputItem.CADDLFive,  
  
		CADDLSix = inputItem.CADDLSix,  
  
		CADDebit = inputItem.CADDebit,  
  
		CADCredit = inputItem.CADCredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstAccRelInf Map(AddCstAccRelInfCommand inputItem)
        {
            var entity = new CstAccRelInf() {
                  
  
		CARPeriodId = inputItem.CARPeriodId,  
  
		CARType = inputItem.CARType,  
  
		CARSLCode = inputItem.CARSLCode,  
  
		CARDL4Type = inputItem.CARDL4Type,  
  
		CARDL4Code = inputItem.CARDL4Code,  
  
		CARDL5Type = inputItem.CARDL5Type,  
  
		CARDL5Code = inputItem.CARDL5Code,  
  
		CARDL6Type = inputItem.CARDL6Type,  
  
		CARDL6Code = inputItem.CARDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstAccRelInf Map(CstAccRelInf entity ,EditCstAccRelInfCommand inputItem)
        {
              
  
		entity.CARPeriodId = inputItem.CARPeriodId;  
  
		entity.CARType = inputItem.CARType;  
  
		entity.CARSLCode = inputItem.CARSLCode;  
  
		entity.CARDL4Type = inputItem.CARDL4Type;  
  
		entity.CARDL4Code = inputItem.CARDL4Code;  
  
		entity.CARDL5Type = inputItem.CARDL5Type;  
  
		entity.CARDL5Code = inputItem.CARDL5Code;  
  
		entity.CARDL6Type = inputItem.CARDL6Type;  
  
		entity.CARDL6Code = inputItem.CARDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstAccRelInfDto Map(CstAccRelInf inputItem)
        {
            var dto = new CstAccRelInfDto()
            {
                  
  
		CARPeriodId = inputItem.CARPeriodId,  
  
		CARType = inputItem.CARType,  
  
		CARSLCode = inputItem.CARSLCode,  
  
		CARDL4Type = inputItem.CARDL4Type,  
  
		CARDL4Code = inputItem.CARDL4Code,  
  
		CARDL5Type = inputItem.CARDL5Type,  
  
		CARDL5Code = inputItem.CARDL5Code,  
  
		CARDL6Type = inputItem.CARDL6Type,  
  
		CARDL6Code = inputItem.CARDL6Code, 
            };
            return dto;
        }

        public static List<CstAccRelInfDto> Map(ICollection<CstAccRelInf> entities)
        {
            var dtos = new List<CstAccRelInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstAccRelInfDto()
                {
                      
  
		CARPeriodId = inputItem.CARPeriodId,  
  
		CARType = inputItem.CARType,  
  
		CARSLCode = inputItem.CARSLCode,  
  
		CARDL4Type = inputItem.CARDL4Type,  
  
		CARDL4Code = inputItem.CARDL4Code,  
  
		CARDL5Type = inputItem.CARDL5Type,  
  
		CARDL5Code = inputItem.CARDL5Code,  
  
		CARDL6Type = inputItem.CARDL6Type,  
  
		CARDL6Code = inputItem.CARDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostAllocDet Map(AddCstCostAllocDetCommand inputItem)
        {
            var entity = new CstCostAllocDet() {
                  
  
		CCADHdrRef = inputItem.CCADHdrRef,  
  
		CCADCostCntrRef = inputItem.CCADCostCntrRef,  
  
		CCADAllocQty = inputItem.CCADAllocQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostAllocDet Map(CstCostAllocDet entity ,EditCstCostAllocDetCommand inputItem)
        {
              
  
		entity.CCADHdrRef = inputItem.CCADHdrRef;  
  
		entity.CCADCostCntrRef = inputItem.CCADCostCntrRef;  
  
		entity.CCADAllocQty = inputItem.CCADAllocQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostAllocDetDto Map(CstCostAllocDet inputItem)
        {
            var dto = new CstCostAllocDetDto()
            {
                  
  
		CCADHdrRef = inputItem.CCADHdrRef,  
  
		CCADCostCntrRef = inputItem.CCADCostCntrRef,  
  
		CCADAllocQty = inputItem.CCADAllocQty, 
            };
            return dto;
        }

        public static List<CstCostAllocDetDto> Map(ICollection<CstCostAllocDet> entities)
        {
            var dtos = new List<CstCostAllocDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostAllocDetDto()
                {
                      
  
		CCADHdrRef = inputItem.CCADHdrRef,  
  
		CCADCostCntrRef = inputItem.CCADCostCntrRef,  
  
		CCADAllocQty = inputItem.CCADAllocQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrAlloc Map(AddCstCostCntrAllocCommand inputItem)
        {
            var entity = new CstCostCntrAlloc() {
                  
  
		CstCostCntAllocId = inputItem.CstCostCntAllocId,  
  
		CCnACostCntRef = inputItem.CCnACostCntRef,  
  
		CCnARoleRef = inputItem.CCnARoleRef,  
  
		CCnAPeriodId = inputItem.CCnAPeriodId,  
  
		CCnAPrc = inputItem.CCnAPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrAlloc Map(CstCostCntrAlloc entity ,EditCstCostCntrAllocCommand inputItem)
        {
              
  
		entity.CstCostCntAllocId = inputItem.CstCostCntAllocId;  
  
		entity.CCnACostCntRef = inputItem.CCnACostCntRef;  
  
		entity.CCnARoleRef = inputItem.CCnARoleRef;  
  
		entity.CCnAPeriodId = inputItem.CCnAPeriodId;  
  
		entity.CCnAPrc = inputItem.CCnAPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrAllocDto Map(CstCostCntrAlloc inputItem)
        {
            var dto = new CstCostCntrAllocDto()
            {
                  
  
		CstCostCntAllocId = inputItem.CstCostCntAllocId,  
  
		CCnACostCntRef = inputItem.CCnACostCntRef,  
  
		CCnARoleRef = inputItem.CCnARoleRef,  
  
		CCnAPeriodId = inputItem.CCnAPeriodId,  
  
		CCnAPrc = inputItem.CCnAPrc, 
            };
            return dto;
        }

        public static List<CstCostCntrAllocDto> Map(ICollection<CstCostCntrAlloc> entities)
        {
            var dtos = new List<CstCostCntrAllocDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrAllocDto()
                {
                      
  
		CstCostCntAllocId = inputItem.CstCostCntAllocId,  
  
		CCnACostCntRef = inputItem.CCnACostCntRef,  
  
		CCnARoleRef = inputItem.CCnARoleRef,  
  
		CCnAPeriodId = inputItem.CCnAPeriodId,  
  
		CCnAPrc = inputItem.CCnAPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrAllocSVals Map(AddCstCostCntrAllocSValsCommand inputItem)
        {
            var entity = new CstCostCntrAllocSVals() {
                  
  
		CstCostCntrAllocSValId = inputItem.CstCostCntrAllocSValId,  
  
		CCASVPutCostId = inputItem.CCASVPutCostId,  
  
		CCASVRcvCostId = inputItem.CCASVRcvCostId,  
  
		CCASVSLRef = inputItem.CCASVSLRef,  
  
		CCASVValue = inputItem.CCASVValue,  
  
		CCASVPeriodId = inputItem.CCASVPeriodId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrAllocSVals Map(CstCostCntrAllocSVals entity ,EditCstCostCntrAllocSValsCommand inputItem)
        {
              
  
		entity.CstCostCntrAllocSValId = inputItem.CstCostCntrAllocSValId;  
  
		entity.CCASVPutCostId = inputItem.CCASVPutCostId;  
  
		entity.CCASVRcvCostId = inputItem.CCASVRcvCostId;  
  
		entity.CCASVSLRef = inputItem.CCASVSLRef;  
  
		entity.CCASVValue = inputItem.CCASVValue;  
  
		entity.CCASVPeriodId = inputItem.CCASVPeriodId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrAllocSValsDto Map(CstCostCntrAllocSVals inputItem)
        {
            var dto = new CstCostCntrAllocSValsDto()
            {
                  
  
		CstCostCntrAllocSValId = inputItem.CstCostCntrAllocSValId,  
  
		CCASVPutCostId = inputItem.CCASVPutCostId,  
  
		CCASVRcvCostId = inputItem.CCASVRcvCostId,  
  
		CCASVSLRef = inputItem.CCASVSLRef,  
  
		CCASVValue = inputItem.CCASVValue,  
  
		CCASVPeriodId = inputItem.CCASVPeriodId, 
            };
            return dto;
        }

        public static List<CstCostCntrAllocSValsDto> Map(ICollection<CstCostCntrAllocSVals> entities)
        {
            var dtos = new List<CstCostCntrAllocSValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrAllocSValsDto()
                {
                      
  
		CstCostCntrAllocSValId = inputItem.CstCostCntrAllocSValId,  
  
		CCASVPutCostId = inputItem.CCASVPutCostId,  
  
		CCASVRcvCostId = inputItem.CCASVRcvCostId,  
  
		CCASVSLRef = inputItem.CCASVSLRef,  
  
		CCASVValue = inputItem.CCASVValue,  
  
		CCASVPeriodId = inputItem.CCASVPeriodId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrAllocVals Map(AddCstCostCntrAllocValsCommand inputItem)
        {
            var entity = new CstCostCntrAllocVals() {
                  
  
		CstCostCntrAllocValId = inputItem.CstCostCntrAllocValId,  
  
		CCAVPutCostId = inputItem.CCAVPutCostId,  
  
		CCAVRcvCostId = inputItem.CCAVRcvCostId,  
  
		CCAVSLRef = inputItem.CCAVSLRef,  
  
		CCAVValue = inputItem.CCAVValue,  
  
		CCAVPeriodId = inputItem.CCAVPeriodId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrAllocVals Map(CstCostCntrAllocVals entity ,EditCstCostCntrAllocValsCommand inputItem)
        {
              
  
		entity.CstCostCntrAllocValId = inputItem.CstCostCntrAllocValId;  
  
		entity.CCAVPutCostId = inputItem.CCAVPutCostId;  
  
		entity.CCAVRcvCostId = inputItem.CCAVRcvCostId;  
  
		entity.CCAVSLRef = inputItem.CCAVSLRef;  
  
		entity.CCAVValue = inputItem.CCAVValue;  
  
		entity.CCAVPeriodId = inputItem.CCAVPeriodId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrAllocValsDto Map(CstCostCntrAllocVals inputItem)
        {
            var dto = new CstCostCntrAllocValsDto()
            {
                  
  
		CstCostCntrAllocValId = inputItem.CstCostCntrAllocValId,  
  
		CCAVPutCostId = inputItem.CCAVPutCostId,  
  
		CCAVRcvCostId = inputItem.CCAVRcvCostId,  
  
		CCAVSLRef = inputItem.CCAVSLRef,  
  
		CCAVValue = inputItem.CCAVValue,  
  
		CCAVPeriodId = inputItem.CCAVPeriodId, 
            };
            return dto;
        }

        public static List<CstCostCntrAllocValsDto> Map(ICollection<CstCostCntrAllocVals> entities)
        {
            var dtos = new List<CstCostCntrAllocValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrAllocValsDto()
                {
                      
  
		CstCostCntrAllocValId = inputItem.CstCostCntrAllocValId,  
  
		CCAVPutCostId = inputItem.CCAVPutCostId,  
  
		CCAVRcvCostId = inputItem.CCAVRcvCostId,  
  
		CCAVSLRef = inputItem.CCAVSLRef,  
  
		CCAVValue = inputItem.CCAVValue,  
  
		CCAVPeriodId = inputItem.CCAVPeriodId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrElmntRole Map(AddCstCostCntrElmntRoleCommand inputItem)
        {
            var entity = new CstCostCntrElmntRole() {
                  
  
		CCnERCostCntRef = inputItem.CCnERCostCntRef,  
  
		CCnERElmntRef = inputItem.CCnERElmntRef,  
  
		CCnERRoleRef = inputItem.CCnERRoleRef,  
  
		CCnERPeriodId = inputItem.CCnERPeriodId,  
  
		CCnERFixPrc = inputItem.CCnERFixPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrElmntRole Map(CstCostCntrElmntRole entity ,EditCstCostCntrElmntRoleCommand inputItem)
        {
              
  
		entity.CCnERCostCntRef = inputItem.CCnERCostCntRef;  
  
		entity.CCnERElmntRef = inputItem.CCnERElmntRef;  
  
		entity.CCnERRoleRef = inputItem.CCnERRoleRef;  
  
		entity.CCnERPeriodId = inputItem.CCnERPeriodId;  
  
		entity.CCnERFixPrc = inputItem.CCnERFixPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrElmntRoleDto Map(CstCostCntrElmntRole inputItem)
        {
            var dto = new CstCostCntrElmntRoleDto()
            {
                  
  
		CCnERCostCntRef = inputItem.CCnERCostCntRef,  
  
		CCnERElmntRef = inputItem.CCnERElmntRef,  
  
		CCnERRoleRef = inputItem.CCnERRoleRef,  
  
		CCnERPeriodId = inputItem.CCnERPeriodId,  
  
		CCnERFixPrc = inputItem.CCnERFixPrc, 
            };
            return dto;
        }

        public static List<CstCostCntrElmntRoleDto> Map(ICollection<CstCostCntrElmntRole> entities)
        {
            var dtos = new List<CstCostCntrElmntRoleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrElmntRoleDto()
                {
                      
  
		CCnERCostCntRef = inputItem.CCnERCostCntRef,  
  
		CCnERElmntRef = inputItem.CCnERElmntRef,  
  
		CCnERRoleRef = inputItem.CCnERRoleRef,  
  
		CCnERPeriodId = inputItem.CCnERPeriodId,  
  
		CCnERFixPrc = inputItem.CCnERFixPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrElmntVals Map(AddCstCostCntrElmntValsCommand inputItem)
        {
            var entity = new CstCostCntrElmntVals() {
                  
  
		CCnEVElmntRef = inputItem.CCnEVElmntRef,  
  
		CCnEVCostCntRef = inputItem.CCnEVCostCntRef,  
  
		CCnEVPeriodId = inputItem.CCnEVPeriodId,  
  
		CCnEVAmount = inputItem.CCnEVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrElmntVals Map(CstCostCntrElmntVals entity ,EditCstCostCntrElmntValsCommand inputItem)
        {
              
  
		entity.CCnEVElmntRef = inputItem.CCnEVElmntRef;  
  
		entity.CCnEVCostCntRef = inputItem.CCnEVCostCntRef;  
  
		entity.CCnEVPeriodId = inputItem.CCnEVPeriodId;  
  
		entity.CCnEVAmount = inputItem.CCnEVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrElmntValsDto Map(CstCostCntrElmntVals inputItem)
        {
            var dto = new CstCostCntrElmntValsDto()
            {
                  
  
		CCnEVElmntRef = inputItem.CCnEVElmntRef,  
  
		CCnEVCostCntRef = inputItem.CCnEVCostCntRef,  
  
		CCnEVPeriodId = inputItem.CCnEVPeriodId,  
  
		CCnEVAmount = inputItem.CCnEVAmount, 
            };
            return dto;
        }

        public static List<CstCostCntrElmntValsDto> Map(ICollection<CstCostCntrElmntVals> entities)
        {
            var dtos = new List<CstCostCntrElmntValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrElmntValsDto()
                {
                      
  
		CCnEVElmntRef = inputItem.CCnEVElmntRef,  
  
		CCnEVCostCntRef = inputItem.CCnEVCostCntRef,  
  
		CCnEVPeriodId = inputItem.CCnEVPeriodId,  
  
		CCnEVAmount = inputItem.CCnEVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrFill Map(AddCstCostCntrFillCommand inputItem)
        {
            var entity = new CstCostCntrFill() {
                  
  
		CCnFCostCenter = inputItem.CCnFCostCenter,  
  
		CCnFPeriodId = inputItem.CCnFPeriodId,  
  
		CCnFHrmTime = inputItem.CCnFHrmTime,  
  
		CCnFCstTime = inputItem.CCnFCstTime,  
  
		CCnFPkgHrmTime = inputItem.CCnFPkgHrmTime,  
  
		CCnFPkgCstTime = inputItem.CCnFPkgCstTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrFill Map(CstCostCntrFill entity ,EditCstCostCntrFillCommand inputItem)
        {
              
  
		entity.CCnFCostCenter = inputItem.CCnFCostCenter;  
  
		entity.CCnFPeriodId = inputItem.CCnFPeriodId;  
  
		entity.CCnFHrmTime = inputItem.CCnFHrmTime;  
  
		entity.CCnFCstTime = inputItem.CCnFCstTime;  
  
		entity.CCnFPkgHrmTime = inputItem.CCnFPkgHrmTime;  
  
		entity.CCnFPkgCstTime = inputItem.CCnFPkgCstTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrFillDto Map(CstCostCntrFill inputItem)
        {
            var dto = new CstCostCntrFillDto()
            {
                  
  
		CCnFCostCenter = inputItem.CCnFCostCenter,  
  
		CCnFPeriodId = inputItem.CCnFPeriodId,  
  
		CCnFHrmTime = inputItem.CCnFHrmTime,  
  
		CCnFCstTime = inputItem.CCnFCstTime,  
  
		CCnFPkgHrmTime = inputItem.CCnFPkgHrmTime,  
  
		CCnFPkgCstTime = inputItem.CCnFPkgCstTime, 
            };
            return dto;
        }

        public static List<CstCostCntrFillDto> Map(ICollection<CstCostCntrFill> entities)
        {
            var dtos = new List<CstCostCntrFillDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrFillDto()
                {
                      
  
		CCnFCostCenter = inputItem.CCnFCostCenter,  
  
		CCnFPeriodId = inputItem.CCnFPeriodId,  
  
		CCnFHrmTime = inputItem.CCnFHrmTime,  
  
		CCnFCstTime = inputItem.CCnFCstTime,  
  
		CCnFPkgHrmTime = inputItem.CCnFPkgHrmTime,  
  
		CCnFPkgCstTime = inputItem.CCnFPkgCstTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstCostCntrRoleVals Map(AddCstCostCntrRoleValsCommand inputItem)
        {
            var entity = new CstCostCntrRoleVals() {
                  
  
		CCnRVRoleRef = inputItem.CCnRVRoleRef,  
  
		CCnRVCostCntRef = inputItem.CCnRVCostCntRef,  
  
		CCnRVPeriodId = inputItem.CCnRVPeriodId,  
  
		CCnRVAmount = inputItem.CCnRVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstCostCntrRoleVals Map(CstCostCntrRoleVals entity ,EditCstCostCntrRoleValsCommand inputItem)
        {
              
  
		entity.CCnRVRoleRef = inputItem.CCnRVRoleRef;  
  
		entity.CCnRVCostCntRef = inputItem.CCnRVCostCntRef;  
  
		entity.CCnRVPeriodId = inputItem.CCnRVPeriodId;  
  
		entity.CCnRVAmount = inputItem.CCnRVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstCostCntrRoleValsDto Map(CstCostCntrRoleVals inputItem)
        {
            var dto = new CstCostCntrRoleValsDto()
            {
                  
  
		CCnRVRoleRef = inputItem.CCnRVRoleRef,  
  
		CCnRVCostCntRef = inputItem.CCnRVCostCntRef,  
  
		CCnRVPeriodId = inputItem.CCnRVPeriodId,  
  
		CCnRVAmount = inputItem.CCnRVAmount, 
            };
            return dto;
        }

        public static List<CstCostCntrRoleValsDto> Map(ICollection<CstCostCntrRoleVals> entities)
        {
            var dtos = new List<CstCostCntrRoleValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstCostCntrRoleValsDto()
                {
                      
  
		CCnRVRoleRef = inputItem.CCnRVRoleRef,  
  
		CCnRVCostCntRef = inputItem.CCnRVCostCntRef,  
  
		CCnRVPeriodId = inputItem.CCnRVPeriodId,  
  
		CCnRVAmount = inputItem.CCnRVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstElements Map(AddCstElementsCommand inputItem)
        {
            var entity = new CstElements() {
                  
  
		CstElmntId = inputItem.CstElmntId,  
  
		CESLRef = inputItem.CESLRef,  
  
		CEType = inputItem.CEType,  
  
		CEFixPrc = inputItem.CEFixPrc,  
  
		CEChngPrc = inputItem.CEChngPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstElements Map(CstElements entity ,EditCstElementsCommand inputItem)
        {
              
  
		entity.CstElmntId = inputItem.CstElmntId;  
  
		entity.CESLRef = inputItem.CESLRef;  
  
		entity.CEType = inputItem.CEType;  
  
		entity.CEFixPrc = inputItem.CEFixPrc;  
  
		entity.CEChngPrc = inputItem.CEChngPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstElementsDto Map(CstElements inputItem)
        {
            var dto = new CstElementsDto()
            {
                  
  
		CstElmntId = inputItem.CstElmntId,  
  
		CESLRef = inputItem.CESLRef,  
  
		CEType = inputItem.CEType,  
  
		CEFixPrc = inputItem.CEFixPrc,  
  
		CEChngPrc = inputItem.CEChngPrc, 
            };
            return dto;
        }

        public static List<CstElementsDto> Map(ICollection<CstElements> entities)
        {
            var dtos = new List<CstElementsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstElementsDto()
                {
                      
  
		CstElmntId = inputItem.CstElmntId,  
  
		CESLRef = inputItem.CESLRef,  
  
		CEType = inputItem.CEType,  
  
		CEFixPrc = inputItem.CEFixPrc,  
  
		CEChngPrc = inputItem.CEChngPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstElmntRoles Map(AddCstElmntRolesCommand inputItem)
        {
            var entity = new CstElmntRoles() {
                  
  
		CstElmntRoleId = inputItem.CstElmntRoleId,  
  
		CERTitle = inputItem.CERTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstElmntRoles Map(CstElmntRoles entity ,EditCstElmntRolesCommand inputItem)
        {
              
  
		entity.CstElmntRoleId = inputItem.CstElmntRoleId;  
  
		entity.CERTitle = inputItem.CERTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstElmntRolesDto Map(CstElmntRoles inputItem)
        {
            var dto = new CstElmntRolesDto()
            {
                  
  
		CstElmntRoleId = inputItem.CstElmntRoleId,  
  
		CERTitle = inputItem.CERTitle, 
            };
            return dto;
        }

        public static List<CstElmntRolesDto> Map(ICollection<CstElmntRoles> entities)
        {
            var dtos = new List<CstElmntRolesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstElmntRolesDto()
                {
                      
  
		CstElmntRoleId = inputItem.CstElmntRoleId,  
  
		CERTitle = inputItem.CERTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstMatDurQty Map(AddCstMatDurQtyCommand inputItem)
        {
            var entity = new CstMatDurQty() {
                  
  
		CstMatDurQtyId = inputItem.CstMatDurQtyId,  
  
		CMDQType = inputItem.CMDQType,  
  
		CMDQPartRef = inputItem.CMDQPartRef,  
  
		CMDQCostCntrRef = inputItem.CMDQCostCntrRef,  
  
		CMDQPeriodId = inputItem.CMDQPeriodId,  
  
		CMDQQty = inputItem.CMDQQty,  
  
		CMDQAmount = inputItem.CMDQAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstMatDurQty Map(CstMatDurQty entity ,EditCstMatDurQtyCommand inputItem)
        {
              
  
		entity.CstMatDurQtyId = inputItem.CstMatDurQtyId;  
  
		entity.CMDQType = inputItem.CMDQType;  
  
		entity.CMDQPartRef = inputItem.CMDQPartRef;  
  
		entity.CMDQCostCntrRef = inputItem.CMDQCostCntrRef;  
  
		entity.CMDQPeriodId = inputItem.CMDQPeriodId;  
  
		entity.CMDQQty = inputItem.CMDQQty;  
  
		entity.CMDQAmount = inputItem.CMDQAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstMatDurQtyDto Map(CstMatDurQty inputItem)
        {
            var dto = new CstMatDurQtyDto()
            {
                  
  
		CstMatDurQtyId = inputItem.CstMatDurQtyId,  
  
		CMDQType = inputItem.CMDQType,  
  
		CMDQPartRef = inputItem.CMDQPartRef,  
  
		CMDQCostCntrRef = inputItem.CMDQCostCntrRef,  
  
		CMDQPeriodId = inputItem.CMDQPeriodId,  
  
		CMDQQty = inputItem.CMDQQty,  
  
		CMDQAmount = inputItem.CMDQAmount, 
            };
            return dto;
        }

        public static List<CstMatDurQtyDto> Map(ICollection<CstMatDurQty> entities)
        {
            var dtos = new List<CstMatDurQtyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstMatDurQtyDto()
                {
                      
  
		CstMatDurQtyId = inputItem.CstMatDurQtyId,  
  
		CMDQType = inputItem.CMDQType,  
  
		CMDQPartRef = inputItem.CMDQPartRef,  
  
		CMDQCostCntrRef = inputItem.CMDQCostCntrRef,  
  
		CMDQPeriodId = inputItem.CMDQPeriodId,  
  
		CMDQQty = inputItem.CMDQQty,  
  
		CMDQAmount = inputItem.CMDQAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstMatQty Map(AddCstMatQtyCommand inputItem)
        {
            var entity = new CstMatQty() {
                  
  
		CstMatQtyId = inputItem.CstMatQtyId,  
  
		CMQPeriodId = inputItem.CMQPeriodId,  
  
		CMQCostCntrRef = inputItem.CMQCostCntrRef,  
  
		CMQPartRef = inputItem.CMQPartRef,  
  
		CMQQty = inputItem.CMQQty,  
  
		CMQAmount = inputItem.CMQAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstMatQty Map(CstMatQty entity ,EditCstMatQtyCommand inputItem)
        {
              
  
		entity.CstMatQtyId = inputItem.CstMatQtyId;  
  
		entity.CMQPeriodId = inputItem.CMQPeriodId;  
  
		entity.CMQCostCntrRef = inputItem.CMQCostCntrRef;  
  
		entity.CMQPartRef = inputItem.CMQPartRef;  
  
		entity.CMQQty = inputItem.CMQQty;  
  
		entity.CMQAmount = inputItem.CMQAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstMatQtyDto Map(CstMatQty inputItem)
        {
            var dto = new CstMatQtyDto()
            {
                  
  
		CstMatQtyId = inputItem.CstMatQtyId,  
  
		CMQPeriodId = inputItem.CMQPeriodId,  
  
		CMQCostCntrRef = inputItem.CMQCostCntrRef,  
  
		CMQPartRef = inputItem.CMQPartRef,  
  
		CMQQty = inputItem.CMQQty,  
  
		CMQAmount = inputItem.CMQAmount, 
            };
            return dto;
        }

        public static List<CstMatQtyDto> Map(ICollection<CstMatQty> entities)
        {
            var dtos = new List<CstMatQtyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstMatQtyDto()
                {
                      
  
		CstMatQtyId = inputItem.CstMatQtyId,  
  
		CMQPeriodId = inputItem.CMQPeriodId,  
  
		CMQCostCntrRef = inputItem.CMQCostCntrRef,  
  
		CMQPartRef = inputItem.CMQPartRef,  
  
		CMQQty = inputItem.CMQQty,  
  
		CMQAmount = inputItem.CMQAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstMatStdInf Map(AddCstMatStdInfCommand inputItem)
        {
            var entity = new CstMatStdInf() {
                  
  
		CMSMatRef = inputItem.CMSMatRef,  
  
		CMSAmnt = inputItem.CMSAmnt,  
  
		CMSRatio = inputItem.CMSRatio,  
  
		CMSPeriodId = inputItem.CMSPeriodId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstMatStdInf Map(CstMatStdInf entity ,EditCstMatStdInfCommand inputItem)
        {
              
  
		entity.CMSMatRef = inputItem.CMSMatRef;  
  
		entity.CMSAmnt = inputItem.CMSAmnt;  
  
		entity.CMSRatio = inputItem.CMSRatio;  
  
		entity.CMSPeriodId = inputItem.CMSPeriodId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstMatStdInfDto Map(CstMatStdInf inputItem)
        {
            var dto = new CstMatStdInfDto()
            {
                  
  
		CMSMatRef = inputItem.CMSMatRef,  
  
		CMSAmnt = inputItem.CMSAmnt,  
  
		CMSRatio = inputItem.CMSRatio,  
  
		CMSPeriodId = inputItem.CMSPeriodId, 
            };
            return dto;
        }

        public static List<CstMatStdInfDto> Map(ICollection<CstMatStdInf> entities)
        {
            var dtos = new List<CstMatStdInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstMatStdInfDto()
                {
                      
  
		CMSMatRef = inputItem.CMSMatRef,  
  
		CMSAmnt = inputItem.CMSAmnt,  
  
		CMSRatio = inputItem.CMSRatio,  
  
		CMSPeriodId = inputItem.CMSPeriodId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstMatWast Map(AddCstMatWastCommand inputItem)
        {
            var entity = new CstMatWast() {
                  
  
		CstMatWastId = inputItem.CstMatWastId,  
  
		CMWPeriodId = inputItem.CMWPeriodId,  
  
		CMWDate = inputItem.CMWDate,  
  
		CMWCostCntrRef = inputItem.CMWCostCntrRef,  
  
		CMWPartRef = inputItem.CMWPartRef,  
  
		CMWQty = inputItem.CMWQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstMatWast Map(CstMatWast entity ,EditCstMatWastCommand inputItem)
        {
              
  
		entity.CstMatWastId = inputItem.CstMatWastId;  
  
		entity.CMWPeriodId = inputItem.CMWPeriodId;  
  
		entity.CMWDate = inputItem.CMWDate;  
  
		entity.CMWCostCntrRef = inputItem.CMWCostCntrRef;  
  
		entity.CMWPartRef = inputItem.CMWPartRef;  
  
		entity.CMWQty = inputItem.CMWQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstMatWastDto Map(CstMatWast inputItem)
        {
            var dto = new CstMatWastDto()
            {
                  
  
		CstMatWastId = inputItem.CstMatWastId,  
  
		CMWPeriodId = inputItem.CMWPeriodId,  
  
		CMWDate = inputItem.CMWDate,  
  
		CMWCostCntrRef = inputItem.CMWCostCntrRef,  
  
		CMWPartRef = inputItem.CMWPartRef,  
  
		CMWQty = inputItem.CMWQty, 
            };
            return dto;
        }

        public static List<CstMatWastDto> Map(ICollection<CstMatWast> entities)
        {
            var dtos = new List<CstMatWastDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstMatWastDto()
                {
                      
  
		CstMatWastId = inputItem.CstMatWastId,  
  
		CMWPeriodId = inputItem.CMWPeriodId,  
  
		CMWDate = inputItem.CMWDate,  
  
		CMWCostCntrRef = inputItem.CMWCostCntrRef,  
  
		CMWPartRef = inputItem.CMWPartRef,  
  
		CMWQty = inputItem.CMWQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstPeriods Map(AddCstPeriodsCommand inputItem)
        {
            var entity = new CstPeriods() {
                  
  
		CstPeriodId = inputItem.CstPeriodId,  
  
		CPTitle = inputItem.CPTitle,  
  
		CPFromDate = inputItem.CPFromDate,  
  
		CPToDate = inputItem.CPToDate,  
  
		CPState = inputItem.CPState,  
  
		CPWrkDay = inputItem.CPWrkDay, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstPeriods Map(CstPeriods entity ,EditCstPeriodsCommand inputItem)
        {
              
  
		entity.CstPeriodId = inputItem.CstPeriodId;  
  
		entity.CPTitle = inputItem.CPTitle;  
  
		entity.CPFromDate = inputItem.CPFromDate;  
  
		entity.CPToDate = inputItem.CPToDate;  
  
		entity.CPState = inputItem.CPState;  
  
		entity.CPWrkDay = inputItem.CPWrkDay; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstPeriodsDto Map(CstPeriods inputItem)
        {
            var dto = new CstPeriodsDto()
            {
                  
  
		CstPeriodId = inputItem.CstPeriodId,  
  
		CPTitle = inputItem.CPTitle,  
  
		CPFromDate = inputItem.CPFromDate,  
  
		CPToDate = inputItem.CPToDate,  
  
		CPState = inputItem.CPState,  
  
		CPWrkDay = inputItem.CPWrkDay, 
            };
            return dto;
        }

        public static List<CstPeriodsDto> Map(ICollection<CstPeriods> entities)
        {
            var dtos = new List<CstPeriodsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstPeriodsDto()
                {
                      
  
		CstPeriodId = inputItem.CstPeriodId,  
  
		CPTitle = inputItem.CPTitle,  
  
		CPFromDate = inputItem.CPFromDate,  
  
		CPToDate = inputItem.CPToDate,  
  
		CPState = inputItem.CPState,  
  
		CPWrkDay = inputItem.CPWrkDay, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstProdDurQty Map(AddCstProdDurQtyCommand inputItem)
        {
            var entity = new CstProdDurQty() {
                  
  
		CstProdDurQtyId = inputItem.CstProdDurQtyId,  
  
		CPDQType = inputItem.CPDQType,  
  
		CPDQPartRef = inputItem.CPDQPartRef,  
  
		CPDQPeriodId = inputItem.CPDQPeriodId,  
  
		CPDQQty = inputItem.CPDQQty,  
  
		CPDQFullPrc = inputItem.CPDQFullPrc,  
  
		CPDQHrmAmount = inputItem.CPDQHrmAmount,  
  
		CPDQCostAmount = inputItem.CPDQCostAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstProdDurQty Map(CstProdDurQty entity ,EditCstProdDurQtyCommand inputItem)
        {
              
  
		entity.CstProdDurQtyId = inputItem.CstProdDurQtyId;  
  
		entity.CPDQType = inputItem.CPDQType;  
  
		entity.CPDQPartRef = inputItem.CPDQPartRef;  
  
		entity.CPDQPeriodId = inputItem.CPDQPeriodId;  
  
		entity.CPDQQty = inputItem.CPDQQty;  
  
		entity.CPDQFullPrc = inputItem.CPDQFullPrc;  
  
		entity.CPDQHrmAmount = inputItem.CPDQHrmAmount;  
  
		entity.CPDQCostAmount = inputItem.CPDQCostAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstProdDurQtyDto Map(CstProdDurQty inputItem)
        {
            var dto = new CstProdDurQtyDto()
            {
                  
  
		CstProdDurQtyId = inputItem.CstProdDurQtyId,  
  
		CPDQType = inputItem.CPDQType,  
  
		CPDQPartRef = inputItem.CPDQPartRef,  
  
		CPDQPeriodId = inputItem.CPDQPeriodId,  
  
		CPDQQty = inputItem.CPDQQty,  
  
		CPDQFullPrc = inputItem.CPDQFullPrc,  
  
		CPDQHrmAmount = inputItem.CPDQHrmAmount,  
  
		CPDQCostAmount = inputItem.CPDQCostAmount, 
            };
            return dto;
        }

        public static List<CstProdDurQtyDto> Map(ICollection<CstProdDurQty> entities)
        {
            var dtos = new List<CstProdDurQtyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstProdDurQtyDto()
                {
                      
  
		CstProdDurQtyId = inputItem.CstProdDurQtyId,  
  
		CPDQType = inputItem.CPDQType,  
  
		CPDQPartRef = inputItem.CPDQPartRef,  
  
		CPDQPeriodId = inputItem.CPDQPeriodId,  
  
		CPDQQty = inputItem.CPDQQty,  
  
		CPDQFullPrc = inputItem.CPDQFullPrc,  
  
		CPDQHrmAmount = inputItem.CPDQHrmAmount,  
  
		CPDQCostAmount = inputItem.CPDQCostAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstProduceInf Map(AddCstProduceInfCommand inputItem)
        {
            var entity = new CstProduceInf() {
                  
  
		CstProduceInfId = inputItem.CstProduceInfId,  
  
		CPIProductRef = inputItem.CPIProductRef,  
  
		CPIMaintQty = inputItem.CPIMaintQty,  
  
		CPIProfitPrc = inputItem.CPIProfitPrc,  
  
		CPICostCenter = inputItem.CPICostCenter,  
  
		CPIProdTime = inputItem.CPIProdTime,  
  
		CPIWatePrc = inputItem.CPIWatePrc,  
  
		CPIPeriodId = inputItem.CPIPeriodId,  
  
		CPIAbsorbPrc = inputItem.CPIAbsorbPrc,  
  
		CPIBkgTime = inputItem.CPIBkgTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstProduceInf Map(CstProduceInf entity ,EditCstProduceInfCommand inputItem)
        {
              
  
		entity.CstProduceInfId = inputItem.CstProduceInfId;  
  
		entity.CPIProductRef = inputItem.CPIProductRef;  
  
		entity.CPIMaintQty = inputItem.CPIMaintQty;  
  
		entity.CPIProfitPrc = inputItem.CPIProfitPrc;  
  
		entity.CPICostCenter = inputItem.CPICostCenter;  
  
		entity.CPIProdTime = inputItem.CPIProdTime;  
  
		entity.CPIWatePrc = inputItem.CPIWatePrc;  
  
		entity.CPIPeriodId = inputItem.CPIPeriodId;  
  
		entity.CPIAbsorbPrc = inputItem.CPIAbsorbPrc;  
  
		entity.CPIBkgTime = inputItem.CPIBkgTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstProduceInfDto Map(CstProduceInf inputItem)
        {
            var dto = new CstProduceInfDto()
            {
                  
  
		CstProduceInfId = inputItem.CstProduceInfId,  
  
		CPIProductRef = inputItem.CPIProductRef,  
  
		CPIMaintQty = inputItem.CPIMaintQty,  
  
		CPIProfitPrc = inputItem.CPIProfitPrc,  
  
		CPICostCenter = inputItem.CPICostCenter,  
  
		CPIProdTime = inputItem.CPIProdTime,  
  
		CPIWatePrc = inputItem.CPIWatePrc,  
  
		CPIPeriodId = inputItem.CPIPeriodId,  
  
		CPIAbsorbPrc = inputItem.CPIAbsorbPrc,  
  
		CPIBkgTime = inputItem.CPIBkgTime, 
            };
            return dto;
        }

        public static List<CstProduceInfDto> Map(ICollection<CstProduceInf> entities)
        {
            var dtos = new List<CstProduceInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstProduceInfDto()
                {
                      
  
		CstProduceInfId = inputItem.CstProduceInfId,  
  
		CPIProductRef = inputItem.CPIProductRef,  
  
		CPIMaintQty = inputItem.CPIMaintQty,  
  
		CPIProfitPrc = inputItem.CPIProfitPrc,  
  
		CPICostCenter = inputItem.CPICostCenter,  
  
		CPIProdTime = inputItem.CPIProdTime,  
  
		CPIWatePrc = inputItem.CPIWatePrc,  
  
		CPIPeriodId = inputItem.CPIPeriodId,  
  
		CPIAbsorbPrc = inputItem.CPIAbsorbPrc,  
  
		CPIBkgTime = inputItem.CPIBkgTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstProductPackage Map(AddCstProductPackageCommand inputItem)
        {
            var entity = new CstProductPackage() {
                  
  
		CstProductPackageId = inputItem.CstProductPackageId,  
  
		CPPProductRef = inputItem.CPPProductRef,  
  
		CPPTitle = inputItem.CPPTitle,  
  
		CPPDate = inputItem.CPPDate,  
  
		CPPPeriodId = inputItem.CPPPeriodId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstProductPackage Map(CstProductPackage entity ,EditCstProductPackageCommand inputItem)
        {
              
  
		entity.CstProductPackageId = inputItem.CstProductPackageId;  
  
		entity.CPPProductRef = inputItem.CPPProductRef;  
  
		entity.CPPTitle = inputItem.CPPTitle;  
  
		entity.CPPDate = inputItem.CPPDate;  
  
		entity.CPPPeriodId = inputItem.CPPPeriodId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstProductPackageDto Map(CstProductPackage inputItem)
        {
            var dto = new CstProductPackageDto()
            {
                  
  
		CstProductPackageId = inputItem.CstProductPackageId,  
  
		CPPProductRef = inputItem.CPPProductRef,  
  
		CPPTitle = inputItem.CPPTitle,  
  
		CPPDate = inputItem.CPPDate,  
  
		CPPPeriodId = inputItem.CPPPeriodId, 
            };
            return dto;
        }

        public static List<CstProductPackageDto> Map(ICollection<CstProductPackage> entities)
        {
            var dtos = new List<CstProductPackageDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstProductPackageDto()
                {
                      
  
		CstProductPackageId = inputItem.CstProductPackageId,  
  
		CPPProductRef = inputItem.CPPProductRef,  
  
		CPPTitle = inputItem.CPPTitle,  
  
		CPPDate = inputItem.CPPDate,  
  
		CPPPeriodId = inputItem.CPPPeriodId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstProductPackDet Map(AddCstProductPackDetCommand inputItem)
        {
            var entity = new CstProductPackDet() {
                  
  
		CstProdPackDetId = inputItem.CstProdPackDetId,  
  
		CPPDHdrRef = inputItem.CPPDHdrRef,  
  
		CPPDPartRef = inputItem.CPPDPartRef,  
  
		CPPDQty = inputItem.CPPDQty,  
  
		CPPDWast = inputItem.CPPDWast, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstProductPackDet Map(CstProductPackDet entity ,EditCstProductPackDetCommand inputItem)
        {
              
  
		entity.CstProdPackDetId = inputItem.CstProdPackDetId;  
  
		entity.CPPDHdrRef = inputItem.CPPDHdrRef;  
  
		entity.CPPDPartRef = inputItem.CPPDPartRef;  
  
		entity.CPPDQty = inputItem.CPPDQty;  
  
		entity.CPPDWast = inputItem.CPPDWast; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstProductPackDetDto Map(CstProductPackDet inputItem)
        {
            var dto = new CstProductPackDetDto()
            {
                  
  
		CstProdPackDetId = inputItem.CstProdPackDetId,  
  
		CPPDHdrRef = inputItem.CPPDHdrRef,  
  
		CPPDPartRef = inputItem.CPPDPartRef,  
  
		CPPDQty = inputItem.CPPDQty,  
  
		CPPDWast = inputItem.CPPDWast, 
            };
            return dto;
        }

        public static List<CstProductPackDetDto> Map(ICollection<CstProductPackDet> entities)
        {
            var dtos = new List<CstProductPackDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstProductPackDetDto()
                {
                      
  
		CstProdPackDetId = inputItem.CstProdPackDetId,  
  
		CPPDHdrRef = inputItem.CPPDHdrRef,  
  
		CPPDPartRef = inputItem.CPPDPartRef,  
  
		CPPDQty = inputItem.CPPDQty,  
  
		CPPDWast = inputItem.CPPDWast, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstProductVch Map(AddCstProductVchCommand inputItem)
        {
            var entity = new CstProductVch() {
                  
  
		CstProductVchId = inputItem.CstProductVchId,  
  
		CPVPeriodId = inputItem.CPVPeriodId,  
  
		CPVPartRef = inputItem.CPVPartRef,  
  
		CPVFormulaRef = inputItem.CPVFormulaRef,  
  
		CPVCostCntrRef = inputItem.CPVCostCntrRef,  
  
		CPVNum = inputItem.CPVNum,  
  
		CPVDate = inputItem.CPVDate,  
  
		CPVType = inputItem.CPVType,  
  
		CPVQty = inputItem.CPVQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstProductVch Map(CstProductVch entity ,EditCstProductVchCommand inputItem)
        {
              
  
		entity.CstProductVchId = inputItem.CstProductVchId;  
  
		entity.CPVPeriodId = inputItem.CPVPeriodId;  
  
		entity.CPVPartRef = inputItem.CPVPartRef;  
  
		entity.CPVFormulaRef = inputItem.CPVFormulaRef;  
  
		entity.CPVCostCntrRef = inputItem.CPVCostCntrRef;  
  
		entity.CPVNum = inputItem.CPVNum;  
  
		entity.CPVDate = inputItem.CPVDate;  
  
		entity.CPVType = inputItem.CPVType;  
  
		entity.CPVQty = inputItem.CPVQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstProductVchDto Map(CstProductVch inputItem)
        {
            var dto = new CstProductVchDto()
            {
                  
  
		CstProductVchId = inputItem.CstProductVchId,  
  
		CPVPeriodId = inputItem.CPVPeriodId,  
  
		CPVPartRef = inputItem.CPVPartRef,  
  
		CPVFormulaRef = inputItem.CPVFormulaRef,  
  
		CPVCostCntrRef = inputItem.CPVCostCntrRef,  
  
		CPVNum = inputItem.CPVNum,  
  
		CPVDate = inputItem.CPVDate,  
  
		CPVType = inputItem.CPVType,  
  
		CPVQty = inputItem.CPVQty, 
            };
            return dto;
        }

        public static List<CstProductVchDto> Map(ICollection<CstProductVch> entities)
        {
            var dtos = new List<CstProductVchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstProductVchDto()
                {
                      
  
		CstProductVchId = inputItem.CstProductVchId,  
  
		CPVPeriodId = inputItem.CPVPeriodId,  
  
		CPVPartRef = inputItem.CPVPartRef,  
  
		CPVFormulaRef = inputItem.CPVFormulaRef,  
  
		CPVCostCntrRef = inputItem.CPVCostCntrRef,  
  
		CPVNum = inputItem.CPVNum,  
  
		CPVDate = inputItem.CPVDate,  
  
		CPVType = inputItem.CPVType,  
  
		CPVQty = inputItem.CPVQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstRealCalc Map(AddCstRealCalcCommand inputItem)
        {
            var entity = new CstRealCalc() {
                  
  
		CstRealCalcId = inputItem.CstRealCalcId,  
  
		CRCPeriodId = inputItem.CRCPeriodId,  
  
		CRCProductRef = inputItem.CRCProductRef,  
  
		CRCFormulaRef = inputItem.CRCFormulaRef,  
  
		CRCMatRef = inputItem.CRCMatRef,  
  
		CRCCostCntrRef = inputItem.CRCCostCntrRef,  
  
		CRCQty = inputItem.CRCQty,  
  
		CRCRate = inputItem.CRCRate,  
  
		CRCAmount = inputItem.CRCAmount,  
  
		CRCWast = inputItem.CRCWast,  
  
		CRCSLCode = inputItem.CRCSLCode,  
  
		CRCCostType = inputItem.CRCCostType,  
  
		CRCHrmFix = inputItem.CRCHrmFix,  
  
		CRCHrmChng = inputItem.CRCHrmChng,  
  
		CRCCostFix = inputItem.CRCCostFix,  
  
		CRCCostChng = inputItem.CRCCostChng,  
  
		CRCOthCost = inputItem.CRCOthCost,  
  
		CRCMatType = inputItem.CRCMatType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstRealCalc Map(CstRealCalc entity ,EditCstRealCalcCommand inputItem)
        {
              
  
		entity.CstRealCalcId = inputItem.CstRealCalcId;  
  
		entity.CRCPeriodId = inputItem.CRCPeriodId;  
  
		entity.CRCProductRef = inputItem.CRCProductRef;  
  
		entity.CRCFormulaRef = inputItem.CRCFormulaRef;  
  
		entity.CRCMatRef = inputItem.CRCMatRef;  
  
		entity.CRCCostCntrRef = inputItem.CRCCostCntrRef;  
  
		entity.CRCQty = inputItem.CRCQty;  
  
		entity.CRCRate = inputItem.CRCRate;  
  
		entity.CRCAmount = inputItem.CRCAmount;  
  
		entity.CRCWast = inputItem.CRCWast;  
  
		entity.CRCSLCode = inputItem.CRCSLCode;  
  
		entity.CRCCostType = inputItem.CRCCostType;  
  
		entity.CRCHrmFix = inputItem.CRCHrmFix;  
  
		entity.CRCHrmChng = inputItem.CRCHrmChng;  
  
		entity.CRCCostFix = inputItem.CRCCostFix;  
  
		entity.CRCCostChng = inputItem.CRCCostChng;  
  
		entity.CRCOthCost = inputItem.CRCOthCost;  
  
		entity.CRCMatType = inputItem.CRCMatType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstRealCalcDto Map(CstRealCalc inputItem)
        {
            var dto = new CstRealCalcDto()
            {
                  
  
		CstRealCalcId = inputItem.CstRealCalcId,  
  
		CRCPeriodId = inputItem.CRCPeriodId,  
  
		CRCProductRef = inputItem.CRCProductRef,  
  
		CRCFormulaRef = inputItem.CRCFormulaRef,  
  
		CRCMatRef = inputItem.CRCMatRef,  
  
		CRCCostCntrRef = inputItem.CRCCostCntrRef,  
  
		CRCQty = inputItem.CRCQty,  
  
		CRCRate = inputItem.CRCRate,  
  
		CRCAmount = inputItem.CRCAmount,  
  
		CRCWast = inputItem.CRCWast,  
  
		CRCSLCode = inputItem.CRCSLCode,  
  
		CRCCostType = inputItem.CRCCostType,  
  
		CRCHrmFix = inputItem.CRCHrmFix,  
  
		CRCHrmChng = inputItem.CRCHrmChng,  
  
		CRCCostFix = inputItem.CRCCostFix,  
  
		CRCCostChng = inputItem.CRCCostChng,  
  
		CRCOthCost = inputItem.CRCOthCost,  
  
		CRCMatType = inputItem.CRCMatType, 
            };
            return dto;
        }

        public static List<CstRealCalcDto> Map(ICollection<CstRealCalc> entities)
        {
            var dtos = new List<CstRealCalcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstRealCalcDto()
                {
                      
  
		CstRealCalcId = inputItem.CstRealCalcId,  
  
		CRCPeriodId = inputItem.CRCPeriodId,  
  
		CRCProductRef = inputItem.CRCProductRef,  
  
		CRCFormulaRef = inputItem.CRCFormulaRef,  
  
		CRCMatRef = inputItem.CRCMatRef,  
  
		CRCCostCntrRef = inputItem.CRCCostCntrRef,  
  
		CRCQty = inputItem.CRCQty,  
  
		CRCRate = inputItem.CRCRate,  
  
		CRCAmount = inputItem.CRCAmount,  
  
		CRCWast = inputItem.CRCWast,  
  
		CRCSLCode = inputItem.CRCSLCode,  
  
		CRCCostType = inputItem.CRCCostType,  
  
		CRCHrmFix = inputItem.CRCHrmFix,  
  
		CRCHrmChng = inputItem.CRCHrmChng,  
  
		CRCCostFix = inputItem.CRCCostFix,  
  
		CRCCostChng = inputItem.CRCCostChng,  
  
		CRCOthCost = inputItem.CRCOthCost,  
  
		CRCMatType = inputItem.CRCMatType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstStdAccData Map(AddCstStdAccDataCommand inputItem)
        {
            var entity = new CstStdAccData() {
                  
  
		CSADPeriodRef = inputItem.CSADPeriodRef,  
  
		CSADSLRef = inputItem.CSADSLRef,  
  
		CSADDLRef = inputItem.CSADDLRef,  
  
		CSADDLFive = inputItem.CSADDLFive,  
  
		CSADDLSix = inputItem.CSADDLSix,  
  
		CSADDebit = inputItem.CSADDebit,  
  
		CSADCredit = inputItem.CSADCredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstStdAccData Map(CstStdAccData entity ,EditCstStdAccDataCommand inputItem)
        {
              
  
		entity.CSADPeriodRef = inputItem.CSADPeriodRef;  
  
		entity.CSADSLRef = inputItem.CSADSLRef;  
  
		entity.CSADDLRef = inputItem.CSADDLRef;  
  
		entity.CSADDLFive = inputItem.CSADDLFive;  
  
		entity.CSADDLSix = inputItem.CSADDLSix;  
  
		entity.CSADDebit = inputItem.CSADDebit;  
  
		entity.CSADCredit = inputItem.CSADCredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstStdAccDataDto Map(CstStdAccData inputItem)
        {
            var dto = new CstStdAccDataDto()
            {
                  
  
		CSADPeriodRef = inputItem.CSADPeriodRef,  
  
		CSADSLRef = inputItem.CSADSLRef,  
  
		CSADDLRef = inputItem.CSADDLRef,  
  
		CSADDLFive = inputItem.CSADDLFive,  
  
		CSADDLSix = inputItem.CSADDLSix,  
  
		CSADDebit = inputItem.CSADDebit,  
  
		CSADCredit = inputItem.CSADCredit, 
            };
            return dto;
        }

        public static List<CstStdAccDataDto> Map(ICollection<CstStdAccData> entities)
        {
            var dtos = new List<CstStdAccDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstStdAccDataDto()
                {
                      
  
		CSADPeriodRef = inputItem.CSADPeriodRef,  
  
		CSADSLRef = inputItem.CSADSLRef,  
  
		CSADDLRef = inputItem.CSADDLRef,  
  
		CSADDLFive = inputItem.CSADDLFive,  
  
		CSADDLSix = inputItem.CSADDLSix,  
  
		CSADDebit = inputItem.CSADDebit,  
  
		CSADCredit = inputItem.CSADCredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CstStdCalc Map(AddCstStdCalcCommand inputItem)
        {
            var entity = new CstStdCalc() {
                  
  
		CstStdCalcId = inputItem.CstStdCalcId,  
  
		CSCPeriodId = inputItem.CSCPeriodId,  
  
		CSCProductRef = inputItem.CSCProductRef,  
  
		CSCFormulaRef = inputItem.CSCFormulaRef,  
  
		CSCMatRef = inputItem.CSCMatRef,  
  
		CSCCostCntrRef = inputItem.CSCCostCntrRef,  
  
		CSCQty = inputItem.CSCQty,  
  
		CSCRate = inputItem.CSCRate,  
  
		CSCAmount = inputItem.CSCAmount,  
  
		CSCWast = inputItem.CSCWast,  
  
		CSCSLCode = inputItem.CSCSLCode,  
  
		CSCCostType = inputItem.CSCCostType,  
  
		CSCHrmFix = inputItem.CSCHrmFix,  
  
		CSCHrmChng = inputItem.CSCHrmChng,  
  
		CSCCostFix = inputItem.CSCCostFix,  
  
		CSCCostChng = inputItem.CSCCostChng,  
  
		CSCOthCost = inputItem.CSCOthCost,  
  
		CSCMatType = inputItem.CSCMatType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CstStdCalc Map(CstStdCalc entity ,EditCstStdCalcCommand inputItem)
        {
              
  
		entity.CstStdCalcId = inputItem.CstStdCalcId;  
  
		entity.CSCPeriodId = inputItem.CSCPeriodId;  
  
		entity.CSCProductRef = inputItem.CSCProductRef;  
  
		entity.CSCFormulaRef = inputItem.CSCFormulaRef;  
  
		entity.CSCMatRef = inputItem.CSCMatRef;  
  
		entity.CSCCostCntrRef = inputItem.CSCCostCntrRef;  
  
		entity.CSCQty = inputItem.CSCQty;  
  
		entity.CSCRate = inputItem.CSCRate;  
  
		entity.CSCAmount = inputItem.CSCAmount;  
  
		entity.CSCWast = inputItem.CSCWast;  
  
		entity.CSCSLCode = inputItem.CSCSLCode;  
  
		entity.CSCCostType = inputItem.CSCCostType;  
  
		entity.CSCHrmFix = inputItem.CSCHrmFix;  
  
		entity.CSCHrmChng = inputItem.CSCHrmChng;  
  
		entity.CSCCostFix = inputItem.CSCCostFix;  
  
		entity.CSCCostChng = inputItem.CSCCostChng;  
  
		entity.CSCOthCost = inputItem.CSCOthCost;  
  
		entity.CSCMatType = inputItem.CSCMatType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CstStdCalcDto Map(CstStdCalc inputItem)
        {
            var dto = new CstStdCalcDto()
            {
                  
  
		CstStdCalcId = inputItem.CstStdCalcId,  
  
		CSCPeriodId = inputItem.CSCPeriodId,  
  
		CSCProductRef = inputItem.CSCProductRef,  
  
		CSCFormulaRef = inputItem.CSCFormulaRef,  
  
		CSCMatRef = inputItem.CSCMatRef,  
  
		CSCCostCntrRef = inputItem.CSCCostCntrRef,  
  
		CSCQty = inputItem.CSCQty,  
  
		CSCRate = inputItem.CSCRate,  
  
		CSCAmount = inputItem.CSCAmount,  
  
		CSCWast = inputItem.CSCWast,  
  
		CSCSLCode = inputItem.CSCSLCode,  
  
		CSCCostType = inputItem.CSCCostType,  
  
		CSCHrmFix = inputItem.CSCHrmFix,  
  
		CSCHrmChng = inputItem.CSCHrmChng,  
  
		CSCCostFix = inputItem.CSCCostFix,  
  
		CSCCostChng = inputItem.CSCCostChng,  
  
		CSCOthCost = inputItem.CSCOthCost,  
  
		CSCMatType = inputItem.CSCMatType, 
            };
            return dto;
        }

        public static List<CstStdCalcDto> Map(ICollection<CstStdCalc> entities)
        {
            var dtos = new List<CstStdCalcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CstStdCalcDto()
                {
                      
  
		CstStdCalcId = inputItem.CstStdCalcId,  
  
		CSCPeriodId = inputItem.CSCPeriodId,  
  
		CSCProductRef = inputItem.CSCProductRef,  
  
		CSCFormulaRef = inputItem.CSCFormulaRef,  
  
		CSCMatRef = inputItem.CSCMatRef,  
  
		CSCCostCntrRef = inputItem.CSCCostCntrRef,  
  
		CSCQty = inputItem.CSCQty,  
  
		CSCRate = inputItem.CSCRate,  
  
		CSCAmount = inputItem.CSCAmount,  
  
		CSCWast = inputItem.CSCWast,  
  
		CSCSLCode = inputItem.CSCSLCode,  
  
		CSCCostType = inputItem.CSCCostType,  
  
		CSCHrmFix = inputItem.CSCHrmFix,  
  
		CSCHrmChng = inputItem.CSCHrmChng,  
  
		CSCCostFix = inputItem.CSCCostFix,  
  
		CSCCostChng = inputItem.CSCCostChng,  
  
		CSCOthCost = inputItem.CSCOthCost,  
  
		CSCMatType = inputItem.CSCMatType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
