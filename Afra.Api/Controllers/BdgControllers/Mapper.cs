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
                
        
        public static BdgAssets Map(AddBdgAssetsCommand inputItem)
        {
            var entity = new BdgAssets() {
                  
  
		BdgAssetsId = inputItem.BdgAssetsId,  
  
		BAType = inputItem.BAType,  
  
		BATitle = inputItem.BATitle,  
  
		BAGrpRef = inputItem.BAGrpRef,  
  
		BAStartDate = inputItem.BAStartDate,  
  
		BAUseDate = inputItem.BAUseDate,  
  
		BAFirstDepr = inputItem.BAFirstDepr,  
  
		BAQty = inputItem.BAQty,  
  
		BAPrice = inputItem.BAPrice,  
  
		BAMethod = inputItem.BAMethod,  
  
		BARatio = inputItem.BARatio,  
  
		BAPeriodRef = inputItem.BAPeriodRef,  
  
		BASLCode = inputItem.BASLCode,  
  
		BACost = inputItem.BACost,  
  
		BACurRef = inputItem.BACurRef,  
  
		BABaseType = inputItem.BABaseType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgAssets Map(BdgAssets entity ,EditBdgAssetsCommand inputItem)
        {
              
  
		entity.BdgAssetsId = inputItem.BdgAssetsId;  
  
		entity.BAType = inputItem.BAType;  
  
		entity.BATitle = inputItem.BATitle;  
  
		entity.BAGrpRef = inputItem.BAGrpRef;  
  
		entity.BAStartDate = inputItem.BAStartDate;  
  
		entity.BAUseDate = inputItem.BAUseDate;  
  
		entity.BAFirstDepr = inputItem.BAFirstDepr;  
  
		entity.BAQty = inputItem.BAQty;  
  
		entity.BAPrice = inputItem.BAPrice;  
  
		entity.BAMethod = inputItem.BAMethod;  
  
		entity.BARatio = inputItem.BARatio;  
  
		entity.BAPeriodRef = inputItem.BAPeriodRef;  
  
		entity.BASLCode = inputItem.BASLCode;  
  
		entity.BACost = inputItem.BACost;  
  
		entity.BACurRef = inputItem.BACurRef;  
  
		entity.BABaseType = inputItem.BABaseType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgAssetsDto Map(BdgAssets inputItem)
        {
            var dto = new BdgAssetsDto()
            {
                  
  
		BdgAssetsId = inputItem.BdgAssetsId,  
  
		BAType = inputItem.BAType,  
  
		BATitle = inputItem.BATitle,  
  
		BAGrpRef = inputItem.BAGrpRef,  
  
		BAStartDate = inputItem.BAStartDate,  
  
		BAUseDate = inputItem.BAUseDate,  
  
		BAFirstDepr = inputItem.BAFirstDepr,  
  
		BAQty = inputItem.BAQty,  
  
		BAPrice = inputItem.BAPrice,  
  
		BAMethod = inputItem.BAMethod,  
  
		BARatio = inputItem.BARatio,  
  
		BAPeriodRef = inputItem.BAPeriodRef,  
  
		BASLCode = inputItem.BASLCode,  
  
		BACost = inputItem.BACost,  
  
		BACurRef = inputItem.BACurRef,  
  
		BABaseType = inputItem.BABaseType, 
            };
            return dto;
        }

        public static List<BdgAssetsDto> Map(ICollection<BdgAssets> entities)
        {
            var dtos = new List<BdgAssetsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgAssetsDto()
                {
                      
  
		BdgAssetsId = inputItem.BdgAssetsId,  
  
		BAType = inputItem.BAType,  
  
		BATitle = inputItem.BATitle,  
  
		BAGrpRef = inputItem.BAGrpRef,  
  
		BAStartDate = inputItem.BAStartDate,  
  
		BAUseDate = inputItem.BAUseDate,  
  
		BAFirstDepr = inputItem.BAFirstDepr,  
  
		BAQty = inputItem.BAQty,  
  
		BAPrice = inputItem.BAPrice,  
  
		BAMethod = inputItem.BAMethod,  
  
		BARatio = inputItem.BARatio,  
  
		BAPeriodRef = inputItem.BAPeriodRef,  
  
		BASLCode = inputItem.BASLCode,  
  
		BACost = inputItem.BACost,  
  
		BACurRef = inputItem.BACurRef,  
  
		BABaseType = inputItem.BABaseType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgAssetsDet Map(AddBdgAssetsDetCommand inputItem)
        {
            var entity = new BdgAssetsDet() {
                  
  
		BADParentRef = inputItem.BADParentRef,  
  
		BADMonth = inputItem.BADMonth,  
  
		BADAstCost = inputItem.BADAstCost,  
  
		BADDepr = inputItem.BADDepr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgAssetsDet Map(BdgAssetsDet entity ,EditBdgAssetsDetCommand inputItem)
        {
              
  
		entity.BADParentRef = inputItem.BADParentRef;  
  
		entity.BADMonth = inputItem.BADMonth;  
  
		entity.BADAstCost = inputItem.BADAstCost;  
  
		entity.BADDepr = inputItem.BADDepr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgAssetsDetDto Map(BdgAssetsDet inputItem)
        {
            var dto = new BdgAssetsDetDto()
            {
                  
  
		BADParentRef = inputItem.BADParentRef,  
  
		BADMonth = inputItem.BADMonth,  
  
		BADAstCost = inputItem.BADAstCost,  
  
		BADDepr = inputItem.BADDepr, 
            };
            return dto;
        }

        public static List<BdgAssetsDetDto> Map(ICollection<BdgAssetsDet> entities)
        {
            var dtos = new List<BdgAssetsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgAssetsDetDto()
                {
                      
  
		BADParentRef = inputItem.BADParentRef,  
  
		BADMonth = inputItem.BADMonth,  
  
		BADAstCost = inputItem.BADAstCost,  
  
		BADDepr = inputItem.BADDepr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgBalanceVal Map(AddBdgBalanceValCommand inputItem)
        {
            var entity = new BdgBalanceVal() {
                  
  
		BdgBalanceValId = inputItem.BdgBalanceValId,  
  
		BBVType = inputItem.BBVType,  
  
		BBVSLRef = inputItem.BBVSLRef,  
  
		BBVDLRef = inputItem.BBVDLRef,  
  
		BBVDL5Ref = inputItem.BBVDL5Ref,  
  
		BBVDL6Ref = inputItem.BBVDL6Ref,  
  
		BBVDL7Ref = inputItem.BBVDL7Ref,  
  
		BBVAmount = inputItem.BBVAmount,  
  
		BBVPeriodRef = inputItem.BBVPeriodRef,  
  
		BBVCurRef = inputItem.BBVCurRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgBalanceVal Map(BdgBalanceVal entity ,EditBdgBalanceValCommand inputItem)
        {
              
  
		entity.BdgBalanceValId = inputItem.BdgBalanceValId;  
  
		entity.BBVType = inputItem.BBVType;  
  
		entity.BBVSLRef = inputItem.BBVSLRef;  
  
		entity.BBVDLRef = inputItem.BBVDLRef;  
  
		entity.BBVDL5Ref = inputItem.BBVDL5Ref;  
  
		entity.BBVDL6Ref = inputItem.BBVDL6Ref;  
  
		entity.BBVDL7Ref = inputItem.BBVDL7Ref;  
  
		entity.BBVAmount = inputItem.BBVAmount;  
  
		entity.BBVPeriodRef = inputItem.BBVPeriodRef;  
  
		entity.BBVCurRef = inputItem.BBVCurRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgBalanceValDto Map(BdgBalanceVal inputItem)
        {
            var dto = new BdgBalanceValDto()
            {
                  
  
		BdgBalanceValId = inputItem.BdgBalanceValId,  
  
		BBVType = inputItem.BBVType,  
  
		BBVSLRef = inputItem.BBVSLRef,  
  
		BBVDLRef = inputItem.BBVDLRef,  
  
		BBVDL5Ref = inputItem.BBVDL5Ref,  
  
		BBVDL6Ref = inputItem.BBVDL6Ref,  
  
		BBVDL7Ref = inputItem.BBVDL7Ref,  
  
		BBVAmount = inputItem.BBVAmount,  
  
		BBVPeriodRef = inputItem.BBVPeriodRef,  
  
		BBVCurRef = inputItem.BBVCurRef, 
            };
            return dto;
        }

        public static List<BdgBalanceValDto> Map(ICollection<BdgBalanceVal> entities)
        {
            var dtos = new List<BdgBalanceValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgBalanceValDto()
                {
                      
  
		BdgBalanceValId = inputItem.BdgBalanceValId,  
  
		BBVType = inputItem.BBVType,  
  
		BBVSLRef = inputItem.BBVSLRef,  
  
		BBVDLRef = inputItem.BBVDLRef,  
  
		BBVDL5Ref = inputItem.BBVDL5Ref,  
  
		BBVDL6Ref = inputItem.BBVDL6Ref,  
  
		BBVDL7Ref = inputItem.BBVDL7Ref,  
  
		BBVAmount = inputItem.BBVAmount,  
  
		BBVPeriodRef = inputItem.BBVPeriodRef,  
  
		BBVCurRef = inputItem.BBVCurRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgBalanceValsDet Map(AddBdgBalanceValsDetCommand inputItem)
        {
            var entity = new BdgBalanceValsDet() {
                  
  
		BBVDParentRef = inputItem.BBVDParentRef,  
  
		BBVDMonth = inputItem.BBVDMonth,  
  
		BBVDVal = inputItem.BBVDVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgBalanceValsDet Map(BdgBalanceValsDet entity ,EditBdgBalanceValsDetCommand inputItem)
        {
              
  
		entity.BBVDParentRef = inputItem.BBVDParentRef;  
  
		entity.BBVDMonth = inputItem.BBVDMonth;  
  
		entity.BBVDVal = inputItem.BBVDVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgBalanceValsDetDto Map(BdgBalanceValsDet inputItem)
        {
            var dto = new BdgBalanceValsDetDto()
            {
                  
  
		BBVDParentRef = inputItem.BBVDParentRef,  
  
		BBVDMonth = inputItem.BBVDMonth,  
  
		BBVDVal = inputItem.BBVDVal, 
            };
            return dto;
        }

        public static List<BdgBalanceValsDetDto> Map(ICollection<BdgBalanceValsDet> entities)
        {
            var dtos = new List<BdgBalanceValsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgBalanceValsDetDto()
                {
                      
  
		BBVDParentRef = inputItem.BBVDParentRef,  
  
		BBVDMonth = inputItem.BBVDMonth,  
  
		BBVDVal = inputItem.BBVDVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgContAcc Map(AddBdgContAccCommand inputItem)
        {
            var entity = new BdgContAcc() {
                  
  
		BdgContAccId = inputItem.BdgContAccId,  
  
		BCAContRef = inputItem.BCAContRef,  
  
		BCASLCode = inputItem.BCASLCode,  
  
		BCAAmount = inputItem.BCAAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgContAcc Map(BdgContAcc entity ,EditBdgContAccCommand inputItem)
        {
              
  
		entity.BdgContAccId = inputItem.BdgContAccId;  
  
		entity.BCAContRef = inputItem.BCAContRef;  
  
		entity.BCASLCode = inputItem.BCASLCode;  
  
		entity.BCAAmount = inputItem.BCAAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgContAccDto Map(BdgContAcc inputItem)
        {
            var dto = new BdgContAccDto()
            {
                  
  
		BdgContAccId = inputItem.BdgContAccId,  
  
		BCAContRef = inputItem.BCAContRef,  
  
		BCASLCode = inputItem.BCASLCode,  
  
		BCAAmount = inputItem.BCAAmount, 
            };
            return dto;
        }

        public static List<BdgContAccDto> Map(ICollection<BdgContAcc> entities)
        {
            var dtos = new List<BdgContAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgContAccDto()
                {
                      
  
		BdgContAccId = inputItem.BdgContAccId,  
  
		BCAContRef = inputItem.BCAContRef,  
  
		BCASLCode = inputItem.BCASLCode,  
  
		BCAAmount = inputItem.BCAAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgContAccDet Map(AddBdgContAccDetCommand inputItem)
        {
            var entity = new BdgContAccDet() {
                  
  
		BCADParentRef = inputItem.BCADParentRef,  
  
		BCADMonth = inputItem.BCADMonth,  
  
		BCADAmount = inputItem.BCADAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgContAccDet Map(BdgContAccDet entity ,EditBdgContAccDetCommand inputItem)
        {
              
  
		entity.BCADParentRef = inputItem.BCADParentRef;  
  
		entity.BCADMonth = inputItem.BCADMonth;  
  
		entity.BCADAmount = inputItem.BCADAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgContAccDetDto Map(BdgContAccDet inputItem)
        {
            var dto = new BdgContAccDetDto()
            {
                  
  
		BCADParentRef = inputItem.BCADParentRef,  
  
		BCADMonth = inputItem.BCADMonth,  
  
		BCADAmount = inputItem.BCADAmount, 
            };
            return dto;
        }

        public static List<BdgContAccDetDto> Map(ICollection<BdgContAccDet> entities)
        {
            var dtos = new List<BdgContAccDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgContAccDetDto()
                {
                      
  
		BCADParentRef = inputItem.BCADParentRef,  
  
		BCADMonth = inputItem.BCADMonth,  
  
		BCADAmount = inputItem.BCADAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgConts Map(AddBdgContsCommand inputItem)
        {
            var entity = new BdgConts() {
                  
  
		BdgContsId = inputItem.BdgContsId,  
  
		BCNum = inputItem.BCNum,  
  
		BCDate = inputItem.BCDate,  
  
		BCDescr = inputItem.BCDescr,  
  
		BCAmount = inputItem.BCAmount,  
  
		BCPeriodRef = inputItem.BCPeriodRef,  
  
		BCCurRef = inputItem.BCCurRef,  
  
		BCMainSLRef = inputItem.BCMainSLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgConts Map(BdgConts entity ,EditBdgContsCommand inputItem)
        {
              
  
		entity.BdgContsId = inputItem.BdgContsId;  
  
		entity.BCNum = inputItem.BCNum;  
  
		entity.BCDate = inputItem.BCDate;  
  
		entity.BCDescr = inputItem.BCDescr;  
  
		entity.BCAmount = inputItem.BCAmount;  
  
		entity.BCPeriodRef = inputItem.BCPeriodRef;  
  
		entity.BCCurRef = inputItem.BCCurRef;  
  
		entity.BCMainSLRef = inputItem.BCMainSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgContsDto Map(BdgConts inputItem)
        {
            var dto = new BdgContsDto()
            {
                  
  
		BdgContsId = inputItem.BdgContsId,  
  
		BCNum = inputItem.BCNum,  
  
		BCDate = inputItem.BCDate,  
  
		BCDescr = inputItem.BCDescr,  
  
		BCAmount = inputItem.BCAmount,  
  
		BCPeriodRef = inputItem.BCPeriodRef,  
  
		BCCurRef = inputItem.BCCurRef,  
  
		BCMainSLRef = inputItem.BCMainSLRef, 
            };
            return dto;
        }

        public static List<BdgContsDto> Map(ICollection<BdgConts> entities)
        {
            var dtos = new List<BdgContsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgContsDto()
                {
                      
  
		BdgContsId = inputItem.BdgContsId,  
  
		BCNum = inputItem.BCNum,  
  
		BCDate = inputItem.BCDate,  
  
		BCDescr = inputItem.BCDescr,  
  
		BCAmount = inputItem.BCAmount,  
  
		BCPeriodRef = inputItem.BCPeriodRef,  
  
		BCCurRef = inputItem.BCCurRef,  
  
		BCMainSLRef = inputItem.BCMainSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgCostAllocDet Map(AddBdgCostAllocDetCommand inputItem)
        {
            var entity = new BdgCostAllocDet() {
                  
  
		BCADHdrRef = inputItem.BCADHdrRef,  
  
		BCADCostCntrRef = inputItem.BCADCostCntrRef,  
  
		BCADAllocQty = inputItem.BCADAllocQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgCostAllocDet Map(BdgCostAllocDet entity ,EditBdgCostAllocDetCommand inputItem)
        {
              
  
		entity.BCADHdrRef = inputItem.BCADHdrRef;  
  
		entity.BCADCostCntrRef = inputItem.BCADCostCntrRef;  
  
		entity.BCADAllocQty = inputItem.BCADAllocQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgCostAllocDetDto Map(BdgCostAllocDet inputItem)
        {
            var dto = new BdgCostAllocDetDto()
            {
                  
  
		BCADHdrRef = inputItem.BCADHdrRef,  
  
		BCADCostCntrRef = inputItem.BCADCostCntrRef,  
  
		BCADAllocQty = inputItem.BCADAllocQty, 
            };
            return dto;
        }

        public static List<BdgCostAllocDetDto> Map(ICollection<BdgCostAllocDet> entities)
        {
            var dtos = new List<BdgCostAllocDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgCostAllocDetDto()
                {
                      
  
		BCADHdrRef = inputItem.BCADHdrRef,  
  
		BCADCostCntrRef = inputItem.BCADCostCntrRef,  
  
		BCADAllocQty = inputItem.BCADAllocQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgCostCntrAlloc Map(AddBdgCostCntrAllocCommand inputItem)
        {
            var entity = new BdgCostCntrAlloc() {
                  
  
		BdgCostCntAllocId = inputItem.BdgCostCntAllocId,  
  
		BCnACostCntRef = inputItem.BCnACostCntRef,  
  
		BCnAElmntRef = inputItem.BCnAElmntRef,  
  
		BCnARoleRef = inputItem.BCnARoleRef,  
  
		BCnAPeriodId = inputItem.BCnAPeriodId,  
  
		BCnAPrc = inputItem.BCnAPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgCostCntrAlloc Map(BdgCostCntrAlloc entity ,EditBdgCostCntrAllocCommand inputItem)
        {
              
  
		entity.BdgCostCntAllocId = inputItem.BdgCostCntAllocId;  
  
		entity.BCnACostCntRef = inputItem.BCnACostCntRef;  
  
		entity.BCnAElmntRef = inputItem.BCnAElmntRef;  
  
		entity.BCnARoleRef = inputItem.BCnARoleRef;  
  
		entity.BCnAPeriodId = inputItem.BCnAPeriodId;  
  
		entity.BCnAPrc = inputItem.BCnAPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgCostCntrAllocDto Map(BdgCostCntrAlloc inputItem)
        {
            var dto = new BdgCostCntrAllocDto()
            {
                  
  
		BdgCostCntAllocId = inputItem.BdgCostCntAllocId,  
  
		BCnACostCntRef = inputItem.BCnACostCntRef,  
  
		BCnAElmntRef = inputItem.BCnAElmntRef,  
  
		BCnARoleRef = inputItem.BCnARoleRef,  
  
		BCnAPeriodId = inputItem.BCnAPeriodId,  
  
		BCnAPrc = inputItem.BCnAPrc, 
            };
            return dto;
        }

        public static List<BdgCostCntrAllocDto> Map(ICollection<BdgCostCntrAlloc> entities)
        {
            var dtos = new List<BdgCostCntrAllocDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgCostCntrAllocDto()
                {
                      
  
		BdgCostCntAllocId = inputItem.BdgCostCntAllocId,  
  
		BCnACostCntRef = inputItem.BCnACostCntRef,  
  
		BCnAElmntRef = inputItem.BCnAElmntRef,  
  
		BCnARoleRef = inputItem.BCnARoleRef,  
  
		BCnAPeriodId = inputItem.BCnAPeriodId,  
  
		BCnAPrc = inputItem.BCnAPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgCostCntrRoleVals Map(AddBdgCostCntrRoleValsCommand inputItem)
        {
            var entity = new BdgCostCntrRoleVals() {
                  
  
		BCnRVRoleRef = inputItem.BCnRVRoleRef,  
  
		BCnRVCostCntRef = inputItem.BCnRVCostCntRef,  
  
		BCnRVPeriodId = inputItem.BCnRVPeriodId,  
  
		BCnRVAmount = inputItem.BCnRVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgCostCntrRoleVals Map(BdgCostCntrRoleVals entity ,EditBdgCostCntrRoleValsCommand inputItem)
        {
              
  
		entity.BCnRVRoleRef = inputItem.BCnRVRoleRef;  
  
		entity.BCnRVCostCntRef = inputItem.BCnRVCostCntRef;  
  
		entity.BCnRVPeriodId = inputItem.BCnRVPeriodId;  
  
		entity.BCnRVAmount = inputItem.BCnRVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgCostCntrRoleValsDto Map(BdgCostCntrRoleVals inputItem)
        {
            var dto = new BdgCostCntrRoleValsDto()
            {
                  
  
		BCnRVRoleRef = inputItem.BCnRVRoleRef,  
  
		BCnRVCostCntRef = inputItem.BCnRVCostCntRef,  
  
		BCnRVPeriodId = inputItem.BCnRVPeriodId,  
  
		BCnRVAmount = inputItem.BCnRVAmount, 
            };
            return dto;
        }

        public static List<BdgCostCntrRoleValsDto> Map(ICollection<BdgCostCntrRoleVals> entities)
        {
            var dtos = new List<BdgCostCntrRoleValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgCostCntrRoleValsDto()
                {
                      
  
		BCnRVRoleRef = inputItem.BCnRVRoleRef,  
  
		BCnRVCostCntRef = inputItem.BCnRVCostCntRef,  
  
		BCnRVPeriodId = inputItem.BCnRVPeriodId,  
  
		BCnRVAmount = inputItem.BCnRVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgCurExchange Map(AddBdgCurExchangeCommand inputItem)
        {
            var entity = new BdgCurExchange() {
                  
  
		BdgCurExchangeId = inputItem.BdgCurExchangeId,  
  
		BCEDate = inputItem.BCEDate,  
  
		BCECurRef = inputItem.BCECurRef,  
  
		BCERate = inputItem.BCERate,  
  
		BCEPeriodRef = inputItem.BCEPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgCurExchange Map(BdgCurExchange entity ,EditBdgCurExchangeCommand inputItem)
        {
              
  
		entity.BdgCurExchangeId = inputItem.BdgCurExchangeId;  
  
		entity.BCEDate = inputItem.BCEDate;  
  
		entity.BCECurRef = inputItem.BCECurRef;  
  
		entity.BCERate = inputItem.BCERate;  
  
		entity.BCEPeriodRef = inputItem.BCEPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgCurExchangeDto Map(BdgCurExchange inputItem)
        {
            var dto = new BdgCurExchangeDto()
            {
                  
  
		BdgCurExchangeId = inputItem.BdgCurExchangeId,  
  
		BCEDate = inputItem.BCEDate,  
  
		BCECurRef = inputItem.BCECurRef,  
  
		BCERate = inputItem.BCERate,  
  
		BCEPeriodRef = inputItem.BCEPeriodRef, 
            };
            return dto;
        }

        public static List<BdgCurExchangeDto> Map(ICollection<BdgCurExchange> entities)
        {
            var dtos = new List<BdgCurExchangeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgCurExchangeDto()
                {
                      
  
		BdgCurExchangeId = inputItem.BdgCurExchangeId,  
  
		BCEDate = inputItem.BCEDate,  
  
		BCECurRef = inputItem.BCECurRef,  
  
		BCERate = inputItem.BCERate,  
  
		BCEPeriodRef = inputItem.BCEPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgElements Map(AddBdgElementsCommand inputItem)
        {
            var entity = new BdgElements() {
                  
  
		BdgElmntId = inputItem.BdgElmntId,  
  
		BESLRef = inputItem.BESLRef,  
  
		BERole = inputItem.BERole,  
  
		BEType = inputItem.BEType,  
  
		BEWarPoint = inputItem.BEWarPoint,  
  
		BEWarNotOk = inputItem.BEWarNotOk, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgElements Map(BdgElements entity ,EditBdgElementsCommand inputItem)
        {
              
  
		entity.BdgElmntId = inputItem.BdgElmntId;  
  
		entity.BESLRef = inputItem.BESLRef;  
  
		entity.BERole = inputItem.BERole;  
  
		entity.BEType = inputItem.BEType;  
  
		entity.BEWarPoint = inputItem.BEWarPoint;  
  
		entity.BEWarNotOk = inputItem.BEWarNotOk; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgElementsDto Map(BdgElements inputItem)
        {
            var dto = new BdgElementsDto()
            {
                  
  
		BdgElmntId = inputItem.BdgElmntId,  
  
		BESLRef = inputItem.BESLRef,  
  
		BERole = inputItem.BERole,  
  
		BEType = inputItem.BEType,  
  
		BEWarPoint = inputItem.BEWarPoint,  
  
		BEWarNotOk = inputItem.BEWarNotOk, 
            };
            return dto;
        }

        public static List<BdgElementsDto> Map(ICollection<BdgElements> entities)
        {
            var dtos = new List<BdgElementsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgElementsDto()
                {
                      
  
		BdgElmntId = inputItem.BdgElmntId,  
  
		BESLRef = inputItem.BESLRef,  
  
		BERole = inputItem.BERole,  
  
		BEType = inputItem.BEType,  
  
		BEWarPoint = inputItem.BEWarPoint,  
  
		BEWarNotOk = inputItem.BEWarNotOk, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgElmntRoles Map(AddBdgElmntRolesCommand inputItem)
        {
            var entity = new BdgElmntRoles() {
                  
  
		BdgElmntRoleId = inputItem.BdgElmntRoleId,  
  
		BERTitle = inputItem.BERTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgElmntRoles Map(BdgElmntRoles entity ,EditBdgElmntRolesCommand inputItem)
        {
              
  
		entity.BdgElmntRoleId = inputItem.BdgElmntRoleId;  
  
		entity.BERTitle = inputItem.BERTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgElmntRolesDto Map(BdgElmntRoles inputItem)
        {
            var dto = new BdgElmntRolesDto()
            {
                  
  
		BdgElmntRoleId = inputItem.BdgElmntRoleId,  
  
		BERTitle = inputItem.BERTitle, 
            };
            return dto;
        }

        public static List<BdgElmntRolesDto> Map(ICollection<BdgElmntRoles> entities)
        {
            var dtos = new List<BdgElmntRolesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgElmntRolesDto()
                {
                      
  
		BdgElmntRoleId = inputItem.BdgElmntRoleId,  
  
		BERTitle = inputItem.BERTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgElmntVal Map(AddBdgElmntValCommand inputItem)
        {
            var entity = new BdgElmntVal() {
                  
  
		BdgElmntValId = inputItem.BdgElmntValId,  
  
		BEVElmntRef = inputItem.BEVElmntRef,  
  
		BEVDLRef = inputItem.BEVDLRef,  
  
		BEVDL5Ref = inputItem.BEVDL5Ref,  
  
		BEVDL6Ref = inputItem.BEVDL6Ref,  
  
		BEVDL7Ref = inputItem.BEVDL7Ref,  
  
		BEVPartRef = inputItem.BEVPartRef,  
  
		BEVFacType = inputItem.BEVFacType,  
  
		BEVQty = inputItem.BEVQty,  
  
		BEVAmount = inputItem.BEVAmount,  
  
		BTPeriodRef = inputItem.BTPeriodRef,  
  
		BEVPeriodRef = inputItem.BEVPeriodRef,  
  
		BEVCurRef = inputItem.BEVCurRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgElmntVal Map(BdgElmntVal entity ,EditBdgElmntValCommand inputItem)
        {
              
  
		entity.BdgElmntValId = inputItem.BdgElmntValId;  
  
		entity.BEVElmntRef = inputItem.BEVElmntRef;  
  
		entity.BEVDLRef = inputItem.BEVDLRef;  
  
		entity.BEVDL5Ref = inputItem.BEVDL5Ref;  
  
		entity.BEVDL6Ref = inputItem.BEVDL6Ref;  
  
		entity.BEVDL7Ref = inputItem.BEVDL7Ref;  
  
		entity.BEVPartRef = inputItem.BEVPartRef;  
  
		entity.BEVFacType = inputItem.BEVFacType;  
  
		entity.BEVQty = inputItem.BEVQty;  
  
		entity.BEVAmount = inputItem.BEVAmount;  
  
		entity.BTPeriodRef = inputItem.BTPeriodRef;  
  
		entity.BEVPeriodRef = inputItem.BEVPeriodRef;  
  
		entity.BEVCurRef = inputItem.BEVCurRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgElmntValDto Map(BdgElmntVal inputItem)
        {
            var dto = new BdgElmntValDto()
            {
                  
  
		BdgElmntValId = inputItem.BdgElmntValId,  
  
		BEVElmntRef = inputItem.BEVElmntRef,  
  
		BEVDLRef = inputItem.BEVDLRef,  
  
		BEVDL5Ref = inputItem.BEVDL5Ref,  
  
		BEVDL6Ref = inputItem.BEVDL6Ref,  
  
		BEVDL7Ref = inputItem.BEVDL7Ref,  
  
		BEVPartRef = inputItem.BEVPartRef,  
  
		BEVFacType = inputItem.BEVFacType,  
  
		BEVQty = inputItem.BEVQty,  
  
		BEVAmount = inputItem.BEVAmount,  
  
		BTPeriodRef = inputItem.BTPeriodRef,  
  
		BEVPeriodRef = inputItem.BEVPeriodRef,  
  
		BEVCurRef = inputItem.BEVCurRef, 
            };
            return dto;
        }

        public static List<BdgElmntValDto> Map(ICollection<BdgElmntVal> entities)
        {
            var dtos = new List<BdgElmntValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgElmntValDto()
                {
                      
  
		BdgElmntValId = inputItem.BdgElmntValId,  
  
		BEVElmntRef = inputItem.BEVElmntRef,  
  
		BEVDLRef = inputItem.BEVDLRef,  
  
		BEVDL5Ref = inputItem.BEVDL5Ref,  
  
		BEVDL6Ref = inputItem.BEVDL6Ref,  
  
		BEVDL7Ref = inputItem.BEVDL7Ref,  
  
		BEVPartRef = inputItem.BEVPartRef,  
  
		BEVFacType = inputItem.BEVFacType,  
  
		BEVQty = inputItem.BEVQty,  
  
		BEVAmount = inputItem.BEVAmount,  
  
		BTPeriodRef = inputItem.BTPeriodRef,  
  
		BEVPeriodRef = inputItem.BEVPeriodRef,  
  
		BEVCurRef = inputItem.BEVCurRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgElmntValsDet Map(AddBdgElmntValsDetCommand inputItem)
        {
            var entity = new BdgElmntValsDet() {
                  
  
		BEVDParentRef = inputItem.BEVDParentRef,  
  
		PEVDMonth = inputItem.PEVDMonth,  
  
		PEVDVal = inputItem.PEVDVal,  
  
		BEVDMonth = inputItem.BEVDMonth,  
  
		BEVDVal = inputItem.BEVDVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgElmntValsDet Map(BdgElmntValsDet entity ,EditBdgElmntValsDetCommand inputItem)
        {
              
  
		entity.BEVDParentRef = inputItem.BEVDParentRef;  
  
		entity.PEVDMonth = inputItem.PEVDMonth;  
  
		entity.PEVDVal = inputItem.PEVDVal;  
  
		entity.BEVDMonth = inputItem.BEVDMonth;  
  
		entity.BEVDVal = inputItem.BEVDVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgElmntValsDetDto Map(BdgElmntValsDet inputItem)
        {
            var dto = new BdgElmntValsDetDto()
            {
                  
  
		BEVDParentRef = inputItem.BEVDParentRef,  
  
		PEVDMonth = inputItem.PEVDMonth,  
  
		PEVDVal = inputItem.PEVDVal,  
  
		BEVDMonth = inputItem.BEVDMonth,  
  
		BEVDVal = inputItem.BEVDVal, 
            };
            return dto;
        }

        public static List<BdgElmntValsDetDto> Map(ICollection<BdgElmntValsDet> entities)
        {
            var dtos = new List<BdgElmntValsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgElmntValsDetDto()
                {
                      
  
		BEVDParentRef = inputItem.BEVDParentRef,  
  
		PEVDMonth = inputItem.PEVDMonth,  
  
		PEVDVal = inputItem.PEVDVal,  
  
		BEVDMonth = inputItem.BEVDMonth,  
  
		BEVDVal = inputItem.BEVDVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgFinalRep Map(AddBdgFinalRepCommand inputItem)
        {
            var entity = new BdgFinalRep() {
                  
  
		BdgFinalRepId = inputItem.BdgFinalRepId,  
  
		BFRPeriodRef = inputItem.BFRPeriodRef,  
  
		BFRItmId = inputItem.BFRItmId,  
  
		BFRType = inputItem.BFRType,  
  
		BFRTopicRef = inputItem.BFRTopicRef,  
  
		BFRSLCode = inputItem.BFRSLCode,  
  
		BFRDL4 = inputItem.BFRDL4,  
  
		BFRDL5 = inputItem.BFRDL5,  
  
		BFRDL6 = inputItem.BFRDL6,  
  
		BFRDL7 = inputItem.BFRDL7,  
  
		BFRCurTitle = inputItem.BFRCurTitle,  
  
		BFRMonthId = inputItem.BFRMonthId,  
  
		BFRBdgValue = inputItem.BFRBdgValue,  
  
		BFRWorkValue = inputItem.BFRWorkValue,  
  
		BFRRBdgValue = inputItem.BFRRBdgValue,  
  
		BFRRWorkValue = inputItem.BFRRWorkValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgFinalRep Map(BdgFinalRep entity ,EditBdgFinalRepCommand inputItem)
        {
              
  
		entity.BdgFinalRepId = inputItem.BdgFinalRepId;  
  
		entity.BFRPeriodRef = inputItem.BFRPeriodRef;  
  
		entity.BFRItmId = inputItem.BFRItmId;  
  
		entity.BFRType = inputItem.BFRType;  
  
		entity.BFRTopicRef = inputItem.BFRTopicRef;  
  
		entity.BFRSLCode = inputItem.BFRSLCode;  
  
		entity.BFRDL4 = inputItem.BFRDL4;  
  
		entity.BFRDL5 = inputItem.BFRDL5;  
  
		entity.BFRDL6 = inputItem.BFRDL6;  
  
		entity.BFRDL7 = inputItem.BFRDL7;  
  
		entity.BFRCurTitle = inputItem.BFRCurTitle;  
  
		entity.BFRMonthId = inputItem.BFRMonthId;  
  
		entity.BFRBdgValue = inputItem.BFRBdgValue;  
  
		entity.BFRWorkValue = inputItem.BFRWorkValue;  
  
		entity.BFRRBdgValue = inputItem.BFRRBdgValue;  
  
		entity.BFRRWorkValue = inputItem.BFRRWorkValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgFinalRepDto Map(BdgFinalRep inputItem)
        {
            var dto = new BdgFinalRepDto()
            {
                  
  
		BdgFinalRepId = inputItem.BdgFinalRepId,  
  
		BFRPeriodRef = inputItem.BFRPeriodRef,  
  
		BFRItmId = inputItem.BFRItmId,  
  
		BFRType = inputItem.BFRType,  
  
		BFRTopicRef = inputItem.BFRTopicRef,  
  
		BFRSLCode = inputItem.BFRSLCode,  
  
		BFRDL4 = inputItem.BFRDL4,  
  
		BFRDL5 = inputItem.BFRDL5,  
  
		BFRDL6 = inputItem.BFRDL6,  
  
		BFRDL7 = inputItem.BFRDL7,  
  
		BFRCurTitle = inputItem.BFRCurTitle,  
  
		BFRMonthId = inputItem.BFRMonthId,  
  
		BFRBdgValue = inputItem.BFRBdgValue,  
  
		BFRWorkValue = inputItem.BFRWorkValue,  
  
		BFRRBdgValue = inputItem.BFRRBdgValue,  
  
		BFRRWorkValue = inputItem.BFRRWorkValue, 
            };
            return dto;
        }

        public static List<BdgFinalRepDto> Map(ICollection<BdgFinalRep> entities)
        {
            var dtos = new List<BdgFinalRepDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgFinalRepDto()
                {
                      
  
		BdgFinalRepId = inputItem.BdgFinalRepId,  
  
		BFRPeriodRef = inputItem.BFRPeriodRef,  
  
		BFRItmId = inputItem.BFRItmId,  
  
		BFRType = inputItem.BFRType,  
  
		BFRTopicRef = inputItem.BFRTopicRef,  
  
		BFRSLCode = inputItem.BFRSLCode,  
  
		BFRDL4 = inputItem.BFRDL4,  
  
		BFRDL5 = inputItem.BFRDL5,  
  
		BFRDL6 = inputItem.BFRDL6,  
  
		BFRDL7 = inputItem.BFRDL7,  
  
		BFRCurTitle = inputItem.BFRCurTitle,  
  
		BFRMonthId = inputItem.BFRMonthId,  
  
		BFRBdgValue = inputItem.BFRBdgValue,  
  
		BFRWorkValue = inputItem.BFRWorkValue,  
  
		BFRRBdgValue = inputItem.BFRRBdgValue,  
  
		BFRRWorkValue = inputItem.BFRRWorkValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgHrmBase Map(AddBdgHrmBaseCommand inputItem)
        {
            var entity = new BdgHrmBase() {
                  
  
		BdgHrmBaseId = inputItem.BdgHrmBaseId,  
  
		BHBCostCenter = inputItem.BHBCostCenter,  
  
		BHBCurPersCnt = inputItem.BHBCurPersCnt,  
  
		BHBBdgPersCnt = inputItem.BHBBdgPersCnt,  
  
		BHBPeriodRef = inputItem.BHBPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgHrmBase Map(BdgHrmBase entity ,EditBdgHrmBaseCommand inputItem)
        {
              
  
		entity.BdgHrmBaseId = inputItem.BdgHrmBaseId;  
  
		entity.BHBCostCenter = inputItem.BHBCostCenter;  
  
		entity.BHBCurPersCnt = inputItem.BHBCurPersCnt;  
  
		entity.BHBBdgPersCnt = inputItem.BHBBdgPersCnt;  
  
		entity.BHBPeriodRef = inputItem.BHBPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgHrmBaseDto Map(BdgHrmBase inputItem)
        {
            var dto = new BdgHrmBaseDto()
            {
                  
  
		BdgHrmBaseId = inputItem.BdgHrmBaseId,  
  
		BHBCostCenter = inputItem.BHBCostCenter,  
  
		BHBCurPersCnt = inputItem.BHBCurPersCnt,  
  
		BHBBdgPersCnt = inputItem.BHBBdgPersCnt,  
  
		BHBPeriodRef = inputItem.BHBPeriodRef, 
            };
            return dto;
        }

        public static List<BdgHrmBaseDto> Map(ICollection<BdgHrmBase> entities)
        {
            var dtos = new List<BdgHrmBaseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgHrmBaseDto()
                {
                      
  
		BdgHrmBaseId = inputItem.BdgHrmBaseId,  
  
		BHBCostCenter = inputItem.BHBCostCenter,  
  
		BHBCurPersCnt = inputItem.BHBCurPersCnt,  
  
		BHBBdgPersCnt = inputItem.BHBBdgPersCnt,  
  
		BHBPeriodRef = inputItem.BHBPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgHrmVals Map(AddBdgHrmValsCommand inputItem)
        {
            var entity = new BdgHrmVals() {
                  
  
		BdgHrmValsId = inputItem.BdgHrmValsId,  
  
		BHVCostCntrRef = inputItem.BHVCostCntrRef,  
  
		BHVElmntRef = inputItem.BHVElmntRef,  
  
		BHVAmount = inputItem.BHVAmount,  
  
		BHVPeriodRef = inputItem.BHVPeriodRef,  
  
		BHVCurRef = inputItem.BHVCurRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgHrmVals Map(BdgHrmVals entity ,EditBdgHrmValsCommand inputItem)
        {
              
  
		entity.BdgHrmValsId = inputItem.BdgHrmValsId;  
  
		entity.BHVCostCntrRef = inputItem.BHVCostCntrRef;  
  
		entity.BHVElmntRef = inputItem.BHVElmntRef;  
  
		entity.BHVAmount = inputItem.BHVAmount;  
  
		entity.BHVPeriodRef = inputItem.BHVPeriodRef;  
  
		entity.BHVCurRef = inputItem.BHVCurRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgHrmValsDto Map(BdgHrmVals inputItem)
        {
            var dto = new BdgHrmValsDto()
            {
                  
  
		BdgHrmValsId = inputItem.BdgHrmValsId,  
  
		BHVCostCntrRef = inputItem.BHVCostCntrRef,  
  
		BHVElmntRef = inputItem.BHVElmntRef,  
  
		BHVAmount = inputItem.BHVAmount,  
  
		BHVPeriodRef = inputItem.BHVPeriodRef,  
  
		BHVCurRef = inputItem.BHVCurRef, 
            };
            return dto;
        }

        public static List<BdgHrmValsDto> Map(ICollection<BdgHrmVals> entities)
        {
            var dtos = new List<BdgHrmValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgHrmValsDto()
                {
                      
  
		BdgHrmValsId = inputItem.BdgHrmValsId,  
  
		BHVCostCntrRef = inputItem.BHVCostCntrRef,  
  
		BHVElmntRef = inputItem.BHVElmntRef,  
  
		BHVAmount = inputItem.BHVAmount,  
  
		BHVPeriodRef = inputItem.BHVPeriodRef,  
  
		BHVCurRef = inputItem.BHVCurRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgHrmValsDet Map(AddBdgHrmValsDetCommand inputItem)
        {
            var entity = new BdgHrmValsDet() {
                  
  
		BHVDParentRef = inputItem.BHVDParentRef,  
  
		BHVDMonth = inputItem.BHVDMonth,  
  
		BHVDAmount = inputItem.BHVDAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgHrmValsDet Map(BdgHrmValsDet entity ,EditBdgHrmValsDetCommand inputItem)
        {
              
  
		entity.BHVDParentRef = inputItem.BHVDParentRef;  
  
		entity.BHVDMonth = inputItem.BHVDMonth;  
  
		entity.BHVDAmount = inputItem.BHVDAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgHrmValsDetDto Map(BdgHrmValsDet inputItem)
        {
            var dto = new BdgHrmValsDetDto()
            {
                  
  
		BHVDParentRef = inputItem.BHVDParentRef,  
  
		BHVDMonth = inputItem.BHVDMonth,  
  
		BHVDAmount = inputItem.BHVDAmount, 
            };
            return dto;
        }

        public static List<BdgHrmValsDetDto> Map(ICollection<BdgHrmValsDet> entities)
        {
            var dtos = new List<BdgHrmValsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgHrmValsDetDto()
                {
                      
  
		BHVDParentRef = inputItem.BHVDParentRef,  
  
		BHVDMonth = inputItem.BHVDMonth,  
  
		BHVDAmount = inputItem.BHVDAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgHrmValsPers Map(AddBdgHrmValsPersCommand inputItem)
        {
            var entity = new BdgHrmValsPers() {
                  
  
		BdgHrmValsPersId = inputItem.BdgHrmValsPersId,  
  
		BHVPParentRef = inputItem.BHVPParentRef,  
  
		BHVPFullName = inputItem.BHVPFullName,  
  
		BHVPAmount = inputItem.BHVPAmount,  
  
		BHVPCurRef = inputItem.BHVPCurRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgHrmValsPers Map(BdgHrmValsPers entity ,EditBdgHrmValsPersCommand inputItem)
        {
              
  
		entity.BdgHrmValsPersId = inputItem.BdgHrmValsPersId;  
  
		entity.BHVPParentRef = inputItem.BHVPParentRef;  
  
		entity.BHVPFullName = inputItem.BHVPFullName;  
  
		entity.BHVPAmount = inputItem.BHVPAmount;  
  
		entity.BHVPCurRef = inputItem.BHVPCurRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgHrmValsPersDto Map(BdgHrmValsPers inputItem)
        {
            var dto = new BdgHrmValsPersDto()
            {
                  
  
		BdgHrmValsPersId = inputItem.BdgHrmValsPersId,  
  
		BHVPParentRef = inputItem.BHVPParentRef,  
  
		BHVPFullName = inputItem.BHVPFullName,  
  
		BHVPAmount = inputItem.BHVPAmount,  
  
		BHVPCurRef = inputItem.BHVPCurRef, 
            };
            return dto;
        }

        public static List<BdgHrmValsPersDto> Map(ICollection<BdgHrmValsPers> entities)
        {
            var dtos = new List<BdgHrmValsPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgHrmValsPersDto()
                {
                      
  
		BdgHrmValsPersId = inputItem.BdgHrmValsPersId,  
  
		BHVPParentRef = inputItem.BHVPParentRef,  
  
		BHVPFullName = inputItem.BHVPFullName,  
  
		BHVPAmount = inputItem.BHVPAmount,  
  
		BHVPCurRef = inputItem.BHVPCurRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgLevelDet Map(AddBdgLevelDetCommand inputItem)
        {
            var entity = new BdgLevelDet() {
                  
  
		BdgLevelDetId = inputItem.BdgLevelDetId,  
  
		BLDType = inputItem.BLDType,  
  
		BLDParentRef = inputItem.BLDParentRef,  
  
		BLDDLRef = inputItem.BLDDLRef,  
  
		BLDDL5Ref = inputItem.BLDDL5Ref,  
  
		BLDDL6Ref = inputItem.BLDDL6Ref,  
  
		BLDDL7Ref = inputItem.BLDDL7Ref,  
  
		BLDPercent = inputItem.BLDPercent, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgLevelDet Map(BdgLevelDet entity ,EditBdgLevelDetCommand inputItem)
        {
              
  
		entity.BdgLevelDetId = inputItem.BdgLevelDetId;  
  
		entity.BLDType = inputItem.BLDType;  
  
		entity.BLDParentRef = inputItem.BLDParentRef;  
  
		entity.BLDDLRef = inputItem.BLDDLRef;  
  
		entity.BLDDL5Ref = inputItem.BLDDL5Ref;  
  
		entity.BLDDL6Ref = inputItem.BLDDL6Ref;  
  
		entity.BLDDL7Ref = inputItem.BLDDL7Ref;  
  
		entity.BLDPercent = inputItem.BLDPercent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgLevelDetDto Map(BdgLevelDet inputItem)
        {
            var dto = new BdgLevelDetDto()
            {
                  
  
		BdgLevelDetId = inputItem.BdgLevelDetId,  
  
		BLDType = inputItem.BLDType,  
  
		BLDParentRef = inputItem.BLDParentRef,  
  
		BLDDLRef = inputItem.BLDDLRef,  
  
		BLDDL5Ref = inputItem.BLDDL5Ref,  
  
		BLDDL6Ref = inputItem.BLDDL6Ref,  
  
		BLDDL7Ref = inputItem.BLDDL7Ref,  
  
		BLDPercent = inputItem.BLDPercent, 
            };
            return dto;
        }

        public static List<BdgLevelDetDto> Map(ICollection<BdgLevelDet> entities)
        {
            var dtos = new List<BdgLevelDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgLevelDetDto()
                {
                      
  
		BdgLevelDetId = inputItem.BdgLevelDetId,  
  
		BLDType = inputItem.BLDType,  
  
		BLDParentRef = inputItem.BLDParentRef,  
  
		BLDDLRef = inputItem.BLDDLRef,  
  
		BLDDL5Ref = inputItem.BLDDL5Ref,  
  
		BLDDL6Ref = inputItem.BLDDL6Ref,  
  
		BLDDL7Ref = inputItem.BLDDL7Ref,  
  
		BLDPercent = inputItem.BLDPercent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgParts Map(AddBdgPartsCommand inputItem)
        {
            var entity = new BdgParts() {
                  
  
		BdgPartsId = inputItem.BdgPartsId,  
  
		BPType = inputItem.BPType,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPDate = inputItem.BPDate,  
  
		BPQty = inputItem.BPQty,  
  
		BPPrice = inputItem.BPPrice,  
  
		BPCost = inputItem.BPCost,  
  
		BPPeriodRef = inputItem.BPPeriodRef,  
  
		BPSLCode = inputItem.BPSLCode,  
  
		BPSLCode2 = inputItem.BPSLCode2,  
  
		BPCurRef = inputItem.BPCurRef,  
  
		BPInvCtgry = inputItem.BPInvCtgry,  
  
		BPSleCtgry = inputItem.BPSleCtgry, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgParts Map(BdgParts entity ,EditBdgPartsCommand inputItem)
        {
              
  
		entity.BdgPartsId = inputItem.BdgPartsId;  
  
		entity.BPType = inputItem.BPType;  
  
		entity.BPTitle = inputItem.BPTitle;  
  
		entity.BPDate = inputItem.BPDate;  
  
		entity.BPQty = inputItem.BPQty;  
  
		entity.BPPrice = inputItem.BPPrice;  
  
		entity.BPCost = inputItem.BPCost;  
  
		entity.BPPeriodRef = inputItem.BPPeriodRef;  
  
		entity.BPSLCode = inputItem.BPSLCode;  
  
		entity.BPSLCode2 = inputItem.BPSLCode2;  
  
		entity.BPCurRef = inputItem.BPCurRef;  
  
		entity.BPInvCtgry = inputItem.BPInvCtgry;  
  
		entity.BPSleCtgry = inputItem.BPSleCtgry; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgPartsDto Map(BdgParts inputItem)
        {
            var dto = new BdgPartsDto()
            {
                  
  
		BdgPartsId = inputItem.BdgPartsId,  
  
		BPType = inputItem.BPType,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPDate = inputItem.BPDate,  
  
		BPQty = inputItem.BPQty,  
  
		BPPrice = inputItem.BPPrice,  
  
		BPCost = inputItem.BPCost,  
  
		BPPeriodRef = inputItem.BPPeriodRef,  
  
		BPSLCode = inputItem.BPSLCode,  
  
		BPSLCode2 = inputItem.BPSLCode2,  
  
		BPCurRef = inputItem.BPCurRef,  
  
		BPInvCtgry = inputItem.BPInvCtgry,  
  
		BPSleCtgry = inputItem.BPSleCtgry, 
            };
            return dto;
        }

        public static List<BdgPartsDto> Map(ICollection<BdgParts> entities)
        {
            var dtos = new List<BdgPartsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgPartsDto()
                {
                      
  
		BdgPartsId = inputItem.BdgPartsId,  
  
		BPType = inputItem.BPType,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPDate = inputItem.BPDate,  
  
		BPQty = inputItem.BPQty,  
  
		BPPrice = inputItem.BPPrice,  
  
		BPCost = inputItem.BPCost,  
  
		BPPeriodRef = inputItem.BPPeriodRef,  
  
		BPSLCode = inputItem.BPSLCode,  
  
		BPSLCode2 = inputItem.BPSLCode2,  
  
		BPCurRef = inputItem.BPCurRef,  
  
		BPInvCtgry = inputItem.BPInvCtgry,  
  
		BPSleCtgry = inputItem.BPSleCtgry, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgPartsDet Map(AddBdgPartsDetCommand inputItem)
        {
            var entity = new BdgPartsDet() {
                  
  
		BPDParentRef = inputItem.BPDParentRef,  
  
		BPDMonth = inputItem.BPDMonth,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDPrice = inputItem.BPDPrice,  
  
		BPDCost = inputItem.BPDCost, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgPartsDet Map(BdgPartsDet entity ,EditBdgPartsDetCommand inputItem)
        {
              
  
		entity.BPDParentRef = inputItem.BPDParentRef;  
  
		entity.BPDMonth = inputItem.BPDMonth;  
  
		entity.BPDQty = inputItem.BPDQty;  
  
		entity.BPDPrice = inputItem.BPDPrice;  
  
		entity.BPDCost = inputItem.BPDCost; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgPartsDetDto Map(BdgPartsDet inputItem)
        {
            var dto = new BdgPartsDetDto()
            {
                  
  
		BPDParentRef = inputItem.BPDParentRef,  
  
		BPDMonth = inputItem.BPDMonth,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDPrice = inputItem.BPDPrice,  
  
		BPDCost = inputItem.BPDCost, 
            };
            return dto;
        }

        public static List<BdgPartsDetDto> Map(ICollection<BdgPartsDet> entities)
        {
            var dtos = new List<BdgPartsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgPartsDetDto()
                {
                      
  
		BPDParentRef = inputItem.BPDParentRef,  
  
		BPDMonth = inputItem.BPDMonth,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDPrice = inputItem.BPDPrice,  
  
		BPDCost = inputItem.BPDCost, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgPeriods Map(AddBdgPeriodsCommand inputItem)
        {
            var entity = new BdgPeriods() {
                  
  
		BdgPeriodId = inputItem.BdgPeriodId,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPFromDate = inputItem.BPFromDate,  
  
		BPToDate = inputItem.BPToDate,  
  
		BPState = inputItem.BPState,  
  
		BPRepDate = inputItem.BPRepDate,  
  
		BPOpFDate = inputItem.BPOpFDate,  
  
		BPOpTDate = inputItem.BPOpTDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgPeriods Map(BdgPeriods entity ,EditBdgPeriodsCommand inputItem)
        {
              
  
		entity.BdgPeriodId = inputItem.BdgPeriodId;  
  
		entity.BPTitle = inputItem.BPTitle;  
  
		entity.BPFromDate = inputItem.BPFromDate;  
  
		entity.BPToDate = inputItem.BPToDate;  
  
		entity.BPState = inputItem.BPState;  
  
		entity.BPRepDate = inputItem.BPRepDate;  
  
		entity.BPOpFDate = inputItem.BPOpFDate;  
  
		entity.BPOpTDate = inputItem.BPOpTDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgPeriodsDto Map(BdgPeriods inputItem)
        {
            var dto = new BdgPeriodsDto()
            {
                  
  
		BdgPeriodId = inputItem.BdgPeriodId,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPFromDate = inputItem.BPFromDate,  
  
		BPToDate = inputItem.BPToDate,  
  
		BPState = inputItem.BPState,  
  
		BPRepDate = inputItem.BPRepDate,  
  
		BPOpFDate = inputItem.BPOpFDate,  
  
		BPOpTDate = inputItem.BPOpTDate, 
            };
            return dto;
        }

        public static List<BdgPeriodsDto> Map(ICollection<BdgPeriods> entities)
        {
            var dtos = new List<BdgPeriodsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgPeriodsDto()
                {
                      
  
		BdgPeriodId = inputItem.BdgPeriodId,  
  
		BPTitle = inputItem.BPTitle,  
  
		BPFromDate = inputItem.BPFromDate,  
  
		BPToDate = inputItem.BPToDate,  
  
		BPState = inputItem.BPState,  
  
		BPRepDate = inputItem.BPRepDate,  
  
		BPOpFDate = inputItem.BPOpFDate,  
  
		BPOpTDate = inputItem.BPOpTDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProfitDet Map(AddBdgProfitDetCommand inputItem)
        {
            var entity = new BdgProfitDet() {
                  
  
		BdgProfitDetId = inputItem.BdgProfitDetId,  
  
		BPDDLRef = inputItem.BPDDLRef,  
  
		BPDDL5Ref = inputItem.BPDDL5Ref,  
  
		BPDDL6Ref = inputItem.BPDDL6Ref,  
  
		BPDDL7Ref = inputItem.BPDDL7Ref,  
  
		BPDPercent = inputItem.BPDPercent,  
  
		BPDPeriodRef = inputItem.BPDPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProfitDet Map(BdgProfitDet entity ,EditBdgProfitDetCommand inputItem)
        {
              
  
		entity.BdgProfitDetId = inputItem.BdgProfitDetId;  
  
		entity.BPDDLRef = inputItem.BPDDLRef;  
  
		entity.BPDDL5Ref = inputItem.BPDDL5Ref;  
  
		entity.BPDDL6Ref = inputItem.BPDDL6Ref;  
  
		entity.BPDDL7Ref = inputItem.BPDDL7Ref;  
  
		entity.BPDPercent = inputItem.BPDPercent;  
  
		entity.BPDPeriodRef = inputItem.BPDPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProfitDetDto Map(BdgProfitDet inputItem)
        {
            var dto = new BdgProfitDetDto()
            {
                  
  
		BdgProfitDetId = inputItem.BdgProfitDetId,  
  
		BPDDLRef = inputItem.BPDDLRef,  
  
		BPDDL5Ref = inputItem.BPDDL5Ref,  
  
		BPDDL6Ref = inputItem.BPDDL6Ref,  
  
		BPDDL7Ref = inputItem.BPDDL7Ref,  
  
		BPDPercent = inputItem.BPDPercent,  
  
		BPDPeriodRef = inputItem.BPDPeriodRef, 
            };
            return dto;
        }

        public static List<BdgProfitDetDto> Map(ICollection<BdgProfitDet> entities)
        {
            var dtos = new List<BdgProfitDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProfitDetDto()
                {
                      
  
		BdgProfitDetId = inputItem.BdgProfitDetId,  
  
		BPDDLRef = inputItem.BPDDLRef,  
  
		BPDDL5Ref = inputItem.BPDDL5Ref,  
  
		BPDDL6Ref = inputItem.BPDDL6Ref,  
  
		BPDDL7Ref = inputItem.BPDDL7Ref,  
  
		BPDPercent = inputItem.BPDPercent,  
  
		BPDPeriodRef = inputItem.BPDPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjDetInf Map(AddBdgProjDetInfCommand inputItem)
        {
            var entity = new BdgProjDetInf() {
                  
  
		BPDIParentRef = inputItem.BPDIParentRef,  
  
		BPDIMonth = inputItem.BPDIMonth,  
  
		BPDIAmount = inputItem.BPDIAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjDetInf Map(BdgProjDetInf entity ,EditBdgProjDetInfCommand inputItem)
        {
              
  
		entity.BPDIParentRef = inputItem.BPDIParentRef;  
  
		entity.BPDIMonth = inputItem.BPDIMonth;  
  
		entity.BPDIAmount = inputItem.BPDIAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjDetInfDto Map(BdgProjDetInf inputItem)
        {
            var dto = new BdgProjDetInfDto()
            {
                  
  
		BPDIParentRef = inputItem.BPDIParentRef,  
  
		BPDIMonth = inputItem.BPDIMonth,  
  
		BPDIAmount = inputItem.BPDIAmount, 
            };
            return dto;
        }

        public static List<BdgProjDetInfDto> Map(ICollection<BdgProjDetInf> entities)
        {
            var dtos = new List<BdgProjDetInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjDetInfDto()
                {
                      
  
		BPDIParentRef = inputItem.BPDIParentRef,  
  
		BPDIMonth = inputItem.BPDIMonth,  
  
		BPDIAmount = inputItem.BPDIAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjectDet Map(AddBdgProjectDetCommand inputItem)
        {
            var entity = new BdgProjectDet() {
                  
  
		BdgProjectDetId = inputItem.BdgProjectDetId,  
  
		BPDHdrRef = inputItem.BPDHdrRef,  
  
		BPDDescr = inputItem.BPDDescr,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDUnit = inputItem.BPDUnit,  
  
		BPDCurRef = inputItem.BPDCurRef,  
  
		BPDRate = inputItem.BPDRate,  
  
		BPDSLRef = inputItem.BPDSLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjectDet Map(BdgProjectDet entity ,EditBdgProjectDetCommand inputItem)
        {
              
  
		entity.BdgProjectDetId = inputItem.BdgProjectDetId;  
  
		entity.BPDHdrRef = inputItem.BPDHdrRef;  
  
		entity.BPDDescr = inputItem.BPDDescr;  
  
		entity.BPDQty = inputItem.BPDQty;  
  
		entity.BPDUnit = inputItem.BPDUnit;  
  
		entity.BPDCurRef = inputItem.BPDCurRef;  
  
		entity.BPDRate = inputItem.BPDRate;  
  
		entity.BPDSLRef = inputItem.BPDSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjectDetDto Map(BdgProjectDet inputItem)
        {
            var dto = new BdgProjectDetDto()
            {
                  
  
		BdgProjectDetId = inputItem.BdgProjectDetId,  
  
		BPDHdrRef = inputItem.BPDHdrRef,  
  
		BPDDescr = inputItem.BPDDescr,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDUnit = inputItem.BPDUnit,  
  
		BPDCurRef = inputItem.BPDCurRef,  
  
		BPDRate = inputItem.BPDRate,  
  
		BPDSLRef = inputItem.BPDSLRef, 
            };
            return dto;
        }

        public static List<BdgProjectDetDto> Map(ICollection<BdgProjectDet> entities)
        {
            var dtos = new List<BdgProjectDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjectDetDto()
                {
                      
  
		BdgProjectDetId = inputItem.BdgProjectDetId,  
  
		BPDHdrRef = inputItem.BPDHdrRef,  
  
		BPDDescr = inputItem.BPDDescr,  
  
		BPDQty = inputItem.BPDQty,  
  
		BPDUnit = inputItem.BPDUnit,  
  
		BPDCurRef = inputItem.BPDCurRef,  
  
		BPDRate = inputItem.BPDRate,  
  
		BPDSLRef = inputItem.BPDSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjectHrm Map(AddBdgProjectHrmCommand inputItem)
        {
            var entity = new BdgProjectHrm() {
                  
  
		BdgProjectHrmId = inputItem.BdgProjectHrmId,  
  
		BPHHdrRef = inputItem.BPHHdrRef,  
  
		BPHDescr = inputItem.BPHDescr,  
  
		BPHQty = inputItem.BPHQty,  
  
		BPHDay = inputItem.BPHDay,  
  
		BPHCost = inputItem.BPHCost, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjectHrm Map(BdgProjectHrm entity ,EditBdgProjectHrmCommand inputItem)
        {
              
  
		entity.BdgProjectHrmId = inputItem.BdgProjectHrmId;  
  
		entity.BPHHdrRef = inputItem.BPHHdrRef;  
  
		entity.BPHDescr = inputItem.BPHDescr;  
  
		entity.BPHQty = inputItem.BPHQty;  
  
		entity.BPHDay = inputItem.BPHDay;  
  
		entity.BPHCost = inputItem.BPHCost; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjectHrmDto Map(BdgProjectHrm inputItem)
        {
            var dto = new BdgProjectHrmDto()
            {
                  
  
		BdgProjectHrmId = inputItem.BdgProjectHrmId,  
  
		BPHHdrRef = inputItem.BPHHdrRef,  
  
		BPHDescr = inputItem.BPHDescr,  
  
		BPHQty = inputItem.BPHQty,  
  
		BPHDay = inputItem.BPHDay,  
  
		BPHCost = inputItem.BPHCost, 
            };
            return dto;
        }

        public static List<BdgProjectHrmDto> Map(ICollection<BdgProjectHrm> entities)
        {
            var dtos = new List<BdgProjectHrmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjectHrmDto()
                {
                      
  
		BdgProjectHrmId = inputItem.BdgProjectHrmId,  
  
		BPHHdrRef = inputItem.BPHHdrRef,  
  
		BPHDescr = inputItem.BPHDescr,  
  
		BPHQty = inputItem.BPHQty,  
  
		BPHDay = inputItem.BPHDay,  
  
		BPHCost = inputItem.BPHCost, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjects Map(AddBdgProjectsCommand inputItem)
        {
            var entity = new BdgProjects() {
                  
  
		BdgProjectId = inputItem.BdgProjectId,  
  
		BPPrjRef = inputItem.BPPrjRef,  
  
		BPType = inputItem.BPType,  
  
		BPDescr = inputItem.BPDescr,  
  
		BPPeriodRef = inputItem.BPPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjects Map(BdgProjects entity ,EditBdgProjectsCommand inputItem)
        {
              
  
		entity.BdgProjectId = inputItem.BdgProjectId;  
  
		entity.BPPrjRef = inputItem.BPPrjRef;  
  
		entity.BPType = inputItem.BPType;  
  
		entity.BPDescr = inputItem.BPDescr;  
  
		entity.BPPeriodRef = inputItem.BPPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjectsDto Map(BdgProjects inputItem)
        {
            var dto = new BdgProjectsDto()
            {
                  
  
		BdgProjectId = inputItem.BdgProjectId,  
  
		BPPrjRef = inputItem.BPPrjRef,  
  
		BPType = inputItem.BPType,  
  
		BPDescr = inputItem.BPDescr,  
  
		BPPeriodRef = inputItem.BPPeriodRef, 
            };
            return dto;
        }

        public static List<BdgProjectsDto> Map(ICollection<BdgProjects> entities)
        {
            var dtos = new List<BdgProjectsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjectsDto()
                {
                      
  
		BdgProjectId = inputItem.BdgProjectId,  
  
		BPPrjRef = inputItem.BPPrjRef,  
  
		BPType = inputItem.BPType,  
  
		BPDescr = inputItem.BPDescr,  
  
		BPPeriodRef = inputItem.BPPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjElmnt Map(AddBdgProjElmntCommand inputItem)
        {
            var entity = new BdgProjElmnt() {
                  
  
		BdgProjElmntId = inputItem.BdgProjElmntId,  
  
		BPETitle = inputItem.BPETitle,  
  
		BPEGrp = inputItem.BPEGrp,  
  
		BPEParent = inputItem.BPEParent,  
  
		BPEUnit = inputItem.BPEUnit,  
  
		BPECurRef = inputItem.BPECurRef,  
  
		BPERate = inputItem.BPERate,  
  
		BPEPeriodId = inputItem.BPEPeriodId,  
  
		BPESLRef = inputItem.BPESLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjElmnt Map(BdgProjElmnt entity ,EditBdgProjElmntCommand inputItem)
        {
              
  
		entity.BdgProjElmntId = inputItem.BdgProjElmntId;  
  
		entity.BPETitle = inputItem.BPETitle;  
  
		entity.BPEGrp = inputItem.BPEGrp;  
  
		entity.BPEParent = inputItem.BPEParent;  
  
		entity.BPEUnit = inputItem.BPEUnit;  
  
		entity.BPECurRef = inputItem.BPECurRef;  
  
		entity.BPERate = inputItem.BPERate;  
  
		entity.BPEPeriodId = inputItem.BPEPeriodId;  
  
		entity.BPESLRef = inputItem.BPESLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjElmntDto Map(BdgProjElmnt inputItem)
        {
            var dto = new BdgProjElmntDto()
            {
                  
  
		BdgProjElmntId = inputItem.BdgProjElmntId,  
  
		BPETitle = inputItem.BPETitle,  
  
		BPEGrp = inputItem.BPEGrp,  
  
		BPEParent = inputItem.BPEParent,  
  
		BPEUnit = inputItem.BPEUnit,  
  
		BPECurRef = inputItem.BPECurRef,  
  
		BPERate = inputItem.BPERate,  
  
		BPEPeriodId = inputItem.BPEPeriodId,  
  
		BPESLRef = inputItem.BPESLRef, 
            };
            return dto;
        }

        public static List<BdgProjElmntDto> Map(ICollection<BdgProjElmnt> entities)
        {
            var dtos = new List<BdgProjElmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjElmntDto()
                {
                      
  
		BdgProjElmntId = inputItem.BdgProjElmntId,  
  
		BPETitle = inputItem.BPETitle,  
  
		BPEGrp = inputItem.BPEGrp,  
  
		BPEParent = inputItem.BPEParent,  
  
		BPEUnit = inputItem.BPEUnit,  
  
		BPECurRef = inputItem.BPECurRef,  
  
		BPERate = inputItem.BPERate,  
  
		BPEPeriodId = inputItem.BPEPeriodId,  
  
		BPESLRef = inputItem.BPESLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjElmntVals Map(AddBdgProjElmntValsCommand inputItem)
        {
            var entity = new BdgProjElmntVals() {
                  
  
		BdgProjElmntValId = inputItem.BdgProjElmntValId,  
  
		BPEVElmntRef = inputItem.BPEVElmntRef,  
  
		BPEVDLRef = inputItem.BPEVDLRef,  
  
		BPEVDescr = inputItem.BPEVDescr,  
  
		BPEVMonth1 = inputItem.BPEVMonth1,  
  
		BPEVMonth2 = inputItem.BPEVMonth2,  
  
		BPEVMonth3 = inputItem.BPEVMonth3,  
  
		BPEVMonth4 = inputItem.BPEVMonth4,  
  
		BPEVMonth5 = inputItem.BPEVMonth5,  
  
		BPEVMonth6 = inputItem.BPEVMonth6,  
  
		BPEVMonth7 = inputItem.BPEVMonth7,  
  
		BPEVMonth8 = inputItem.BPEVMonth8,  
  
		BPEVMonth9 = inputItem.BPEVMonth9,  
  
		BPEVMonth10 = inputItem.BPEVMonth10,  
  
		BPEVMonth11 = inputItem.BPEVMonth11,  
  
		BPEVMonth12 = inputItem.BPEVMonth12, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjElmntVals Map(BdgProjElmntVals entity ,EditBdgProjElmntValsCommand inputItem)
        {
              
  
		entity.BdgProjElmntValId = inputItem.BdgProjElmntValId;  
  
		entity.BPEVElmntRef = inputItem.BPEVElmntRef;  
  
		entity.BPEVDLRef = inputItem.BPEVDLRef;  
  
		entity.BPEVDescr = inputItem.BPEVDescr;  
  
		entity.BPEVMonth1 = inputItem.BPEVMonth1;  
  
		entity.BPEVMonth2 = inputItem.BPEVMonth2;  
  
		entity.BPEVMonth3 = inputItem.BPEVMonth3;  
  
		entity.BPEVMonth4 = inputItem.BPEVMonth4;  
  
		entity.BPEVMonth5 = inputItem.BPEVMonth5;  
  
		entity.BPEVMonth6 = inputItem.BPEVMonth6;  
  
		entity.BPEVMonth7 = inputItem.BPEVMonth7;  
  
		entity.BPEVMonth8 = inputItem.BPEVMonth8;  
  
		entity.BPEVMonth9 = inputItem.BPEVMonth9;  
  
		entity.BPEVMonth10 = inputItem.BPEVMonth10;  
  
		entity.BPEVMonth11 = inputItem.BPEVMonth11;  
  
		entity.BPEVMonth12 = inputItem.BPEVMonth12; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjElmntValsDto Map(BdgProjElmntVals inputItem)
        {
            var dto = new BdgProjElmntValsDto()
            {
                  
  
		BdgProjElmntValId = inputItem.BdgProjElmntValId,  
  
		BPEVElmntRef = inputItem.BPEVElmntRef,  
  
		BPEVDLRef = inputItem.BPEVDLRef,  
  
		BPEVDescr = inputItem.BPEVDescr,  
  
		BPEVMonth1 = inputItem.BPEVMonth1,  
  
		BPEVMonth2 = inputItem.BPEVMonth2,  
  
		BPEVMonth3 = inputItem.BPEVMonth3,  
  
		BPEVMonth4 = inputItem.BPEVMonth4,  
  
		BPEVMonth5 = inputItem.BPEVMonth5,  
  
		BPEVMonth6 = inputItem.BPEVMonth6,  
  
		BPEVMonth7 = inputItem.BPEVMonth7,  
  
		BPEVMonth8 = inputItem.BPEVMonth8,  
  
		BPEVMonth9 = inputItem.BPEVMonth9,  
  
		BPEVMonth10 = inputItem.BPEVMonth10,  
  
		BPEVMonth11 = inputItem.BPEVMonth11,  
  
		BPEVMonth12 = inputItem.BPEVMonth12, 
            };
            return dto;
        }

        public static List<BdgProjElmntValsDto> Map(ICollection<BdgProjElmntVals> entities)
        {
            var dtos = new List<BdgProjElmntValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjElmntValsDto()
                {
                      
  
		BdgProjElmntValId = inputItem.BdgProjElmntValId,  
  
		BPEVElmntRef = inputItem.BPEVElmntRef,  
  
		BPEVDLRef = inputItem.BPEVDLRef,  
  
		BPEVDescr = inputItem.BPEVDescr,  
  
		BPEVMonth1 = inputItem.BPEVMonth1,  
  
		BPEVMonth2 = inputItem.BPEVMonth2,  
  
		BPEVMonth3 = inputItem.BPEVMonth3,  
  
		BPEVMonth4 = inputItem.BPEVMonth4,  
  
		BPEVMonth5 = inputItem.BPEVMonth5,  
  
		BPEVMonth6 = inputItem.BPEVMonth6,  
  
		BPEVMonth7 = inputItem.BPEVMonth7,  
  
		BPEVMonth8 = inputItem.BPEVMonth8,  
  
		BPEVMonth9 = inputItem.BPEVMonth9,  
  
		BPEVMonth10 = inputItem.BPEVMonth10,  
  
		BPEVMonth11 = inputItem.BPEVMonth11,  
  
		BPEVMonth12 = inputItem.BPEVMonth12, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgProjGroup Map(AddBdgProjGroupCommand inputItem)
        {
            var entity = new BdgProjGroup() {
                  
  
		BdgProjGroupId = inputItem.BdgProjGroupId,  
  
		BPGTitle = inputItem.BPGTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgProjGroup Map(BdgProjGroup entity ,EditBdgProjGroupCommand inputItem)
        {
              
  
		entity.BdgProjGroupId = inputItem.BdgProjGroupId;  
  
		entity.BPGTitle = inputItem.BPGTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgProjGroupDto Map(BdgProjGroup inputItem)
        {
            var dto = new BdgProjGroupDto()
            {
                  
  
		BdgProjGroupId = inputItem.BdgProjGroupId,  
  
		BPGTitle = inputItem.BPGTitle, 
            };
            return dto;
        }

        public static List<BdgProjGroupDto> Map(ICollection<BdgProjGroup> entities)
        {
            var dtos = new List<BdgProjGroupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgProjGroupDto()
                {
                      
  
		BdgProjGroupId = inputItem.BdgProjGroupId,  
  
		BPGTitle = inputItem.BPGTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgShareRep Map(AddBdgShareRepCommand inputItem)
        {
            var entity = new BdgShareRep() {
                  
  
		BdgShareRepId = inputItem.BdgShareRepId,  
  
		BSRPeriodId = inputItem.BSRPeriodId,  
  
		BSRCstLevel = inputItem.BSRCstLevel,  
  
		BSRPutCst = inputItem.BSRPutCst,  
  
		BSRRcvCst = inputItem.BSRRcvCst,  
  
		BSRCostVal = inputItem.BSRCostVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgShareRep Map(BdgShareRep entity ,EditBdgShareRepCommand inputItem)
        {
              
  
		entity.BdgShareRepId = inputItem.BdgShareRepId;  
  
		entity.BSRPeriodId = inputItem.BSRPeriodId;  
  
		entity.BSRCstLevel = inputItem.BSRCstLevel;  
  
		entity.BSRPutCst = inputItem.BSRPutCst;  
  
		entity.BSRRcvCst = inputItem.BSRRcvCst;  
  
		entity.BSRCostVal = inputItem.BSRCostVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgShareRepDto Map(BdgShareRep inputItem)
        {
            var dto = new BdgShareRepDto()
            {
                  
  
		BdgShareRepId = inputItem.BdgShareRepId,  
  
		BSRPeriodId = inputItem.BSRPeriodId,  
  
		BSRCstLevel = inputItem.BSRCstLevel,  
  
		BSRPutCst = inputItem.BSRPutCst,  
  
		BSRRcvCst = inputItem.BSRRcvCst,  
  
		BSRCostVal = inputItem.BSRCostVal, 
            };
            return dto;
        }

        public static List<BdgShareRepDto> Map(ICollection<BdgShareRep> entities)
        {
            var dtos = new List<BdgShareRepDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgShareRepDto()
                {
                      
  
		BdgShareRepId = inputItem.BdgShareRepId,  
  
		BSRPeriodId = inputItem.BSRPeriodId,  
  
		BSRCstLevel = inputItem.BSRCstLevel,  
  
		BSRPutCst = inputItem.BSRPutCst,  
  
		BSRRcvCst = inputItem.BSRRcvCst,  
  
		BSRCostVal = inputItem.BSRCostVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTaxDet Map(AddBdgTaxDetCommand inputItem)
        {
            var entity = new BdgTaxDet() {
                  
  
		BdgTaxDetId = inputItem.BdgTaxDetId,  
  
		BTDType = inputItem.BTDType,  
  
		BTDParentRef = inputItem.BTDParentRef,  
  
		BTDTaxRef = inputItem.BTDTaxRef,  
  
		BTDPriority = inputItem.BTDPriority,  
  
		BTDVal = inputItem.BTDVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTaxDet Map(BdgTaxDet entity ,EditBdgTaxDetCommand inputItem)
        {
              
  
		entity.BdgTaxDetId = inputItem.BdgTaxDetId;  
  
		entity.BTDType = inputItem.BTDType;  
  
		entity.BTDParentRef = inputItem.BTDParentRef;  
  
		entity.BTDTaxRef = inputItem.BTDTaxRef;  
  
		entity.BTDPriority = inputItem.BTDPriority;  
  
		entity.BTDVal = inputItem.BTDVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTaxDetDto Map(BdgTaxDet inputItem)
        {
            var dto = new BdgTaxDetDto()
            {
                  
  
		BdgTaxDetId = inputItem.BdgTaxDetId,  
  
		BTDType = inputItem.BTDType,  
  
		BTDParentRef = inputItem.BTDParentRef,  
  
		BTDTaxRef = inputItem.BTDTaxRef,  
  
		BTDPriority = inputItem.BTDPriority,  
  
		BTDVal = inputItem.BTDVal, 
            };
            return dto;
        }

        public static List<BdgTaxDetDto> Map(ICollection<BdgTaxDet> entities)
        {
            var dtos = new List<BdgTaxDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTaxDetDto()
                {
                      
  
		BdgTaxDetId = inputItem.BdgTaxDetId,  
  
		BTDType = inputItem.BTDType,  
  
		BTDParentRef = inputItem.BTDParentRef,  
  
		BTDTaxRef = inputItem.BTDTaxRef,  
  
		BTDPriority = inputItem.BTDPriority,  
  
		BTDVal = inputItem.BTDVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTaxes Map(AddBdgTaxesCommand inputItem)
        {
            var entity = new BdgTaxes() {
                  
  
		BdgTaxId = inputItem.BdgTaxId,  
  
		BdgTaxName = inputItem.BdgTaxName,  
  
		BTTaxType = inputItem.BTTaxType,  
  
		BTOprType = inputItem.BTOprType,  
  
		BTSLRef = inputItem.BTSLRef,  
  
		BTDL4Code = inputItem.BTDL4Code,  
  
		BTDL5Code = inputItem.BTDL5Code,  
  
		BTDL6Code = inputItem.BTDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTaxes Map(BdgTaxes entity ,EditBdgTaxesCommand inputItem)
        {
              
  
		entity.BdgTaxId = inputItem.BdgTaxId;  
  
		entity.BdgTaxName = inputItem.BdgTaxName;  
  
		entity.BTTaxType = inputItem.BTTaxType;  
  
		entity.BTOprType = inputItem.BTOprType;  
  
		entity.BTSLRef = inputItem.BTSLRef;  
  
		entity.BTDL4Code = inputItem.BTDL4Code;  
  
		entity.BTDL5Code = inputItem.BTDL5Code;  
  
		entity.BTDL6Code = inputItem.BTDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTaxesDto Map(BdgTaxes inputItem)
        {
            var dto = new BdgTaxesDto()
            {
                  
  
		BdgTaxId = inputItem.BdgTaxId,  
  
		BdgTaxName = inputItem.BdgTaxName,  
  
		BTTaxType = inputItem.BTTaxType,  
  
		BTOprType = inputItem.BTOprType,  
  
		BTSLRef = inputItem.BTSLRef,  
  
		BTDL4Code = inputItem.BTDL4Code,  
  
		BTDL5Code = inputItem.BTDL5Code,  
  
		BTDL6Code = inputItem.BTDL6Code, 
            };
            return dto;
        }

        public static List<BdgTaxesDto> Map(ICollection<BdgTaxes> entities)
        {
            var dtos = new List<BdgTaxesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTaxesDto()
                {
                      
  
		BdgTaxId = inputItem.BdgTaxId,  
  
		BdgTaxName = inputItem.BdgTaxName,  
  
		BTTaxType = inputItem.BTTaxType,  
  
		BTOprType = inputItem.BTOprType,  
  
		BTSLRef = inputItem.BTSLRef,  
  
		BTDL4Code = inputItem.BTDL4Code,  
  
		BTDL5Code = inputItem.BTDL5Code,  
  
		BTDL6Code = inputItem.BTDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTaxPrc Map(AddBdgTaxPrcCommand inputItem)
        {
            var entity = new BdgTaxPrc() {
                  
  
		BdgTaxPrcId = inputItem.BdgTaxPrcId,  
  
		BTPElmnt = inputItem.BTPElmnt,  
  
		BTPType = inputItem.BTPType,  
  
		BTPSLRef = inputItem.BTPSLRef,  
  
		BTPDLRef = inputItem.BTPDLRef,  
  
		BTPDL5Ref = inputItem.BTPDL5Ref,  
  
		BTPDL6Ref = inputItem.BTPDL6Ref,  
  
		BTPDL7Ref = inputItem.BTPDL7Ref,  
  
		BTPPercent = inputItem.BTPPercent,  
  
		BTPPeriodRef = inputItem.BTPPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTaxPrc Map(BdgTaxPrc entity ,EditBdgTaxPrcCommand inputItem)
        {
              
  
		entity.BdgTaxPrcId = inputItem.BdgTaxPrcId;  
  
		entity.BTPElmnt = inputItem.BTPElmnt;  
  
		entity.BTPType = inputItem.BTPType;  
  
		entity.BTPSLRef = inputItem.BTPSLRef;  
  
		entity.BTPDLRef = inputItem.BTPDLRef;  
  
		entity.BTPDL5Ref = inputItem.BTPDL5Ref;  
  
		entity.BTPDL6Ref = inputItem.BTPDL6Ref;  
  
		entity.BTPDL7Ref = inputItem.BTPDL7Ref;  
  
		entity.BTPPercent = inputItem.BTPPercent;  
  
		entity.BTPPeriodRef = inputItem.BTPPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTaxPrcDto Map(BdgTaxPrc inputItem)
        {
            var dto = new BdgTaxPrcDto()
            {
                  
  
		BdgTaxPrcId = inputItem.BdgTaxPrcId,  
  
		BTPElmnt = inputItem.BTPElmnt,  
  
		BTPType = inputItem.BTPType,  
  
		BTPSLRef = inputItem.BTPSLRef,  
  
		BTPDLRef = inputItem.BTPDLRef,  
  
		BTPDL5Ref = inputItem.BTPDL5Ref,  
  
		BTPDL6Ref = inputItem.BTPDL6Ref,  
  
		BTPDL7Ref = inputItem.BTPDL7Ref,  
  
		BTPPercent = inputItem.BTPPercent,  
  
		BTPPeriodRef = inputItem.BTPPeriodRef, 
            };
            return dto;
        }

        public static List<BdgTaxPrcDto> Map(ICollection<BdgTaxPrc> entities)
        {
            var dtos = new List<BdgTaxPrcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTaxPrcDto()
                {
                      
  
		BdgTaxPrcId = inputItem.BdgTaxPrcId,  
  
		BTPElmnt = inputItem.BTPElmnt,  
  
		BTPType = inputItem.BTPType,  
  
		BTPSLRef = inputItem.BTPSLRef,  
  
		BTPDLRef = inputItem.BTPDLRef,  
  
		BTPDL5Ref = inputItem.BTPDL5Ref,  
  
		BTPDL6Ref = inputItem.BTPDL6Ref,  
  
		BTPDL7Ref = inputItem.BTPDL7Ref,  
  
		BTPPercent = inputItem.BTPPercent,  
  
		BTPPeriodRef = inputItem.BTPPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTaxPrcCost Map(AddBdgTaxPrcCostCommand inputItem)
        {
            var entity = new BdgTaxPrcCost() {
                  
  
		BTPCItemRef = inputItem.BTPCItemRef,  
  
		BTPCSLCode = inputItem.BTPCSLCode,  
  
		BTPCCalcType = inputItem.BTPCCalcType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTaxPrcCost Map(BdgTaxPrcCost entity ,EditBdgTaxPrcCostCommand inputItem)
        {
              
  
		entity.BTPCItemRef = inputItem.BTPCItemRef;  
  
		entity.BTPCSLCode = inputItem.BTPCSLCode;  
  
		entity.BTPCCalcType = inputItem.BTPCCalcType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTaxPrcCostDto Map(BdgTaxPrcCost inputItem)
        {
            var dto = new BdgTaxPrcCostDto()
            {
                  
  
		BTPCItemRef = inputItem.BTPCItemRef,  
  
		BTPCSLCode = inputItem.BTPCSLCode,  
  
		BTPCCalcType = inputItem.BTPCCalcType, 
            };
            return dto;
        }

        public static List<BdgTaxPrcCostDto> Map(ICollection<BdgTaxPrcCost> entities)
        {
            var dtos = new List<BdgTaxPrcCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTaxPrcCostDto()
                {
                      
  
		BTPCItemRef = inputItem.BTPCItemRef,  
  
		BTPCSLCode = inputItem.BTPCSLCode,  
  
		BTPCCalcType = inputItem.BTPCCalcType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTopics Map(AddBdgTopicsCommand inputItem)
        {
            var entity = new BdgTopics() {
                  
  
		BdgTopicsId = inputItem.BdgTopicsId,  
  
		BTTitle = inputItem.BTTitle,  
  
		BTPriority = inputItem.BTPriority, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTopics Map(BdgTopics entity ,EditBdgTopicsCommand inputItem)
        {
              
  
		entity.BdgTopicsId = inputItem.BdgTopicsId;  
  
		entity.BTTitle = inputItem.BTTitle;  
  
		entity.BTPriority = inputItem.BTPriority; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTopicsDto Map(BdgTopics inputItem)
        {
            var dto = new BdgTopicsDto()
            {
                  
  
		BdgTopicsId = inputItem.BdgTopicsId,  
  
		BTTitle = inputItem.BTTitle,  
  
		BTPriority = inputItem.BTPriority, 
            };
            return dto;
        }

        public static List<BdgTopicsDto> Map(ICollection<BdgTopics> entities)
        {
            var dtos = new List<BdgTopicsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTopicsDto()
                {
                      
  
		BdgTopicsId = inputItem.BdgTopicsId,  
  
		BTTitle = inputItem.BTTitle,  
  
		BTPriority = inputItem.BTPriority, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static BdgTopicsRels Map(AddBdgTopicsRelsCommand inputItem)
        {
            var entity = new BdgTopicsRels() {
                  
  
		BdgTopicsRelsId = inputItem.BdgTopicsRelsId,  
  
		BTRTopicRef = inputItem.BTRTopicRef,  
  
		BTRType = inputItem.BTRType,  
  
		BTRSLRef = inputItem.BTRSLRef,  
  
		BTRDLRef = inputItem.BTRDLRef,  
  
		BTRDL5Ref = inputItem.BTRDL5Ref,  
  
		BTRDL6Ref = inputItem.BTRDL6Ref,  
  
		BTRDL7Ref = inputItem.BTRDL7Ref,  
  
		BTPeriodRef = inputItem.BTPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static BdgTopicsRels Map(BdgTopicsRels entity ,EditBdgTopicsRelsCommand inputItem)
        {
              
  
		entity.BdgTopicsRelsId = inputItem.BdgTopicsRelsId;  
  
		entity.BTRTopicRef = inputItem.BTRTopicRef;  
  
		entity.BTRType = inputItem.BTRType;  
  
		entity.BTRSLRef = inputItem.BTRSLRef;  
  
		entity.BTRDLRef = inputItem.BTRDLRef;  
  
		entity.BTRDL5Ref = inputItem.BTRDL5Ref;  
  
		entity.BTRDL6Ref = inputItem.BTRDL6Ref;  
  
		entity.BTRDL7Ref = inputItem.BTRDL7Ref;  
  
		entity.BTPeriodRef = inputItem.BTPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BdgTopicsRelsDto Map(BdgTopicsRels inputItem)
        {
            var dto = new BdgTopicsRelsDto()
            {
                  
  
		BdgTopicsRelsId = inputItem.BdgTopicsRelsId,  
  
		BTRTopicRef = inputItem.BTRTopicRef,  
  
		BTRType = inputItem.BTRType,  
  
		BTRSLRef = inputItem.BTRSLRef,  
  
		BTRDLRef = inputItem.BTRDLRef,  
  
		BTRDL5Ref = inputItem.BTRDL5Ref,  
  
		BTRDL6Ref = inputItem.BTRDL6Ref,  
  
		BTRDL7Ref = inputItem.BTRDL7Ref,  
  
		BTPeriodRef = inputItem.BTPeriodRef, 
            };
            return dto;
        }

        public static List<BdgTopicsRelsDto> Map(ICollection<BdgTopicsRels> entities)
        {
            var dtos = new List<BdgTopicsRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BdgTopicsRelsDto()
                {
                      
  
		BdgTopicsRelsId = inputItem.BdgTopicsRelsId,  
  
		BTRTopicRef = inputItem.BTRTopicRef,  
  
		BTRType = inputItem.BTRType,  
  
		BTRSLRef = inputItem.BTRSLRef,  
  
		BTRDLRef = inputItem.BTRDLRef,  
  
		BTRDL5Ref = inputItem.BTRDL5Ref,  
  
		BTRDL6Ref = inputItem.BTRDL6Ref,  
  
		BTRDL7Ref = inputItem.BTRDL7Ref,  
  
		BTPeriodRef = inputItem.BTPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
