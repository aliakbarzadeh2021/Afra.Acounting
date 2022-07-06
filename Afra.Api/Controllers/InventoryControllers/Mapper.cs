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
                
        
        public static InvFormHdr Map(AddInvFormHdrCommand inputItem)
        {
            var entity = new InvFormHdr() {
                  
  
		InvFormHdrId = inputItem.InvFormHdrId,  
  
		IFHNum = inputItem.IFHNum,  
  
		IFHLocalNum = inputItem.IFHLocalNum,  
  
		IFHDate = inputItem.IFHDate,  
  
		IFHDescr = inputItem.IFHDescr,  
  
		IFHType = inputItem.IFHType,  
  
		IFHDLRef = inputItem.IFHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IFHState = inputItem.IFHState,  
  
		IFAccPrdRef = inputItem.IFAccPrdRef,  
  
		IFHRefID = inputItem.IFHRefID,  
  
		IFHRefType = inputItem.IFHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvFormHdr Map(InvFormHdr entity ,EditInvFormHdrCommand inputItem)
        {
              
  
		entity.InvFormHdrId = inputItem.InvFormHdrId;  
  
		entity.IFHNum = inputItem.IFHNum;  
  
		entity.IFHLocalNum = inputItem.IFHLocalNum;  
  
		entity.IFHDate = inputItem.IFHDate;  
  
		entity.IFHDescr = inputItem.IFHDescr;  
  
		entity.IFHType = inputItem.IFHType;  
  
		entity.IFHDLRef = inputItem.IFHDLRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.IFHState = inputItem.IFHState;  
  
		entity.IFAccPrdRef = inputItem.IFAccPrdRef;  
  
		entity.IFHRefID = inputItem.IFHRefID;  
  
		entity.IFHRefType = inputItem.IFHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvFormHdrDto Map(InvFormHdr inputItem)
        {
            var dto = new InvFormHdrDto()
            {
                  
  
		InvFormHdrId = inputItem.InvFormHdrId,  
  
		IFHNum = inputItem.IFHNum,  
  
		IFHLocalNum = inputItem.IFHLocalNum,  
  
		IFHDate = inputItem.IFHDate,  
  
		IFHDescr = inputItem.IFHDescr,  
  
		IFHType = inputItem.IFHType,  
  
		IFHDLRef = inputItem.IFHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IFHState = inputItem.IFHState,  
  
		IFAccPrdRef = inputItem.IFAccPrdRef,  
  
		IFHRefID = inputItem.IFHRefID,  
  
		IFHRefType = inputItem.IFHRefType, 
            };
            return dto;
        }

        public static List<InvFormHdrDto> Map(ICollection<InvFormHdr> entities)
        {
            var dtos = new List<InvFormHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvFormHdrDto()
                {
                      
  
		InvFormHdrId = inputItem.InvFormHdrId,  
  
		IFHNum = inputItem.IFHNum,  
  
		IFHLocalNum = inputItem.IFHLocalNum,  
  
		IFHDate = inputItem.IFHDate,  
  
		IFHDescr = inputItem.IFHDescr,  
  
		IFHType = inputItem.IFHType,  
  
		IFHDLRef = inputItem.IFHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IFHState = inputItem.IFHState,  
  
		IFAccPrdRef = inputItem.IFAccPrdRef,  
  
		IFHRefID = inputItem.IFHRefID,  
  
		IFHRefType = inputItem.IFHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvFormItm Map(AddInvFormItmCommand inputItem)
        {
            var entity = new InvFormItm() {
                  
  
		InvFormItmId = inputItem.InvFormItmId,  
  
		InvFormHdrRef = inputItem.InvFormHdrRef,  
  
		IFISeq = inputItem.IFISeq,  
  
		IFIPartRef = inputItem.IFIPartRef,  
  
		IFIUnitRef = inputItem.IFIUnitRef,  
  
		IFIQty = inputItem.IFIQty,  
  
		IFIDescr = inputItem.IFIDescr,  
  
		IFIRefID = inputItem.IFIRefID,  
  
		IFIRefType = inputItem.IFIRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvFormItm Map(InvFormItm entity ,EditInvFormItmCommand inputItem)
        {
              
  
		entity.InvFormItmId = inputItem.InvFormItmId;  
  
		entity.InvFormHdrRef = inputItem.InvFormHdrRef;  
  
		entity.IFISeq = inputItem.IFISeq;  
  
		entity.IFIPartRef = inputItem.IFIPartRef;  
  
		entity.IFIUnitRef = inputItem.IFIUnitRef;  
  
		entity.IFIQty = inputItem.IFIQty;  
  
		entity.IFIDescr = inputItem.IFIDescr;  
  
		entity.IFIRefID = inputItem.IFIRefID;  
  
		entity.IFIRefType = inputItem.IFIRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvFormItmDto Map(InvFormItm inputItem)
        {
            var dto = new InvFormItmDto()
            {
                  
  
		InvFormItmId = inputItem.InvFormItmId,  
  
		InvFormHdrRef = inputItem.InvFormHdrRef,  
  
		IFISeq = inputItem.IFISeq,  
  
		IFIPartRef = inputItem.IFIPartRef,  
  
		IFIUnitRef = inputItem.IFIUnitRef,  
  
		IFIQty = inputItem.IFIQty,  
  
		IFIDescr = inputItem.IFIDescr,  
  
		IFIRefID = inputItem.IFIRefID,  
  
		IFIRefType = inputItem.IFIRefType, 
            };
            return dto;
        }

        public static List<InvFormItmDto> Map(ICollection<InvFormItm> entities)
        {
            var dtos = new List<InvFormItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvFormItmDto()
                {
                      
  
		InvFormItmId = inputItem.InvFormItmId,  
  
		InvFormHdrRef = inputItem.InvFormHdrRef,  
  
		IFISeq = inputItem.IFISeq,  
  
		IFIPartRef = inputItem.IFIPartRef,  
  
		IFIUnitRef = inputItem.IFIUnitRef,  
  
		IFIQty = inputItem.IFIQty,  
  
		IFIDescr = inputItem.IFIDescr,  
  
		IFIRefID = inputItem.IFIRefID,  
  
		IFIRefType = inputItem.IFIRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvFormTypes Map(AddInvFormTypesCommand inputItem)
        {
            var entity = new InvFormTypes() {
                  
  
		InvFormTypeID = inputItem.InvFormTypeID,  
  
		IFTTitle = inputItem.IFTTitle,  
  
		IFDLType = inputItem.IFDLType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvFormTypes Map(InvFormTypes entity ,EditInvFormTypesCommand inputItem)
        {
              
  
		entity.InvFormTypeID = inputItem.InvFormTypeID;  
  
		entity.IFTTitle = inputItem.IFTTitle;  
  
		entity.IFDLType = inputItem.IFDLType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvFormTypesDto Map(InvFormTypes inputItem)
        {
            var dto = new InvFormTypesDto()
            {
                  
  
		InvFormTypeID = inputItem.InvFormTypeID,  
  
		IFTTitle = inputItem.IFTTitle,  
  
		IFDLType = inputItem.IFDLType, 
            };
            return dto;
        }

        public static List<InvFormTypesDto> Map(ICollection<InvFormTypes> entities)
        {
            var dtos = new List<InvFormTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvFormTypesDto()
                {
                      
  
		InvFormTypeID = inputItem.InvFormTypeID,  
  
		IFTTitle = inputItem.IFTTitle,  
  
		IFDLType = inputItem.IFDLType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvItmRateDet Map(AddInvItmRateDetCommand inputItem)
        {
            var entity = new InvItmRateDet() {
                  
  
		InvItmRateDetId = inputItem.InvItmRateDetId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IIRDDisCount = inputItem.IIRDDisCount,  
  
		IIRDPrePay = inputItem.IIRDPrePay,  
  
		IIRDTrans = inputItem.IIRDTrans,  
  
		IIRDOther = inputItem.IIRDOther,  
  
		IIRDTax = inputItem.IIRDTax,  
  
		IIRDDuty = inputItem.IIRDDuty,  
  
		IIRDTransDL = inputItem.IIRDTransDL,  
  
		IIRDOtherDL = inputItem.IIRDOtherDL, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvItmRateDet Map(InvItmRateDet entity ,EditInvItmRateDetCommand inputItem)
        {
              
  
		entity.InvItmRateDetId = inputItem.InvItmRateDetId;  
  
		entity.InvVchItmRef = inputItem.InvVchItmRef;  
  
		entity.IIRDDisCount = inputItem.IIRDDisCount;  
  
		entity.IIRDPrePay = inputItem.IIRDPrePay;  
  
		entity.IIRDTrans = inputItem.IIRDTrans;  
  
		entity.IIRDOther = inputItem.IIRDOther;  
  
		entity.IIRDTax = inputItem.IIRDTax;  
  
		entity.IIRDDuty = inputItem.IIRDDuty;  
  
		entity.IIRDTransDL = inputItem.IIRDTransDL;  
  
		entity.IIRDOtherDL = inputItem.IIRDOtherDL; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvItmRateDetDto Map(InvItmRateDet inputItem)
        {
            var dto = new InvItmRateDetDto()
            {
                  
  
		InvItmRateDetId = inputItem.InvItmRateDetId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IIRDDisCount = inputItem.IIRDDisCount,  
  
		IIRDPrePay = inputItem.IIRDPrePay,  
  
		IIRDTrans = inputItem.IIRDTrans,  
  
		IIRDOther = inputItem.IIRDOther,  
  
		IIRDTax = inputItem.IIRDTax,  
  
		IIRDDuty = inputItem.IIRDDuty,  
  
		IIRDTransDL = inputItem.IIRDTransDL,  
  
		IIRDOtherDL = inputItem.IIRDOtherDL, 
            };
            return dto;
        }

        public static List<InvItmRateDetDto> Map(ICollection<InvItmRateDet> entities)
        {
            var dtos = new List<InvItmRateDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvItmRateDetDto()
                {
                      
  
		InvItmRateDetId = inputItem.InvItmRateDetId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IIRDDisCount = inputItem.IIRDDisCount,  
  
		IIRDPrePay = inputItem.IIRDPrePay,  
  
		IIRDTrans = inputItem.IIRDTrans,  
  
		IIRDOther = inputItem.IIRDOther,  
  
		IIRDTax = inputItem.IIRDTax,  
  
		IIRDDuty = inputItem.IIRDDuty,  
  
		IIRDTransDL = inputItem.IIRDTransDL,  
  
		IIRDOtherDL = inputItem.IIRDOtherDL, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartCmrInf Map(AddInvPartCmrInfCommand inputItem)
        {
            var entity = new InvPartCmrInf() {
                  
  
		InvPartCmrInfId = inputItem.InvPartCmrInfId,  
  
		IPCIStockRef = inputItem.IPCIStockRef,  
  
		IPCIPartRef = inputItem.IPCIPartRef,  
  
		IPCIMinQty = inputItem.IPCIMinQty,  
  
		IPCIMaxQty = inputItem.IPCIMaxQty,  
  
		IPCIOrderLimit = inputItem.IPCIOrderLimit,  
  
		IPCIOrderQty = inputItem.IPCIOrderQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartCmrInf Map(InvPartCmrInf entity ,EditInvPartCmrInfCommand inputItem)
        {
              
  
		entity.InvPartCmrInfId = inputItem.InvPartCmrInfId;  
  
		entity.IPCIStockRef = inputItem.IPCIStockRef;  
  
		entity.IPCIPartRef = inputItem.IPCIPartRef;  
  
		entity.IPCIMinQty = inputItem.IPCIMinQty;  
  
		entity.IPCIMaxQty = inputItem.IPCIMaxQty;  
  
		entity.IPCIOrderLimit = inputItem.IPCIOrderLimit;  
  
		entity.IPCIOrderQty = inputItem.IPCIOrderQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartCmrInfDto Map(InvPartCmrInf inputItem)
        {
            var dto = new InvPartCmrInfDto()
            {
                  
  
		InvPartCmrInfId = inputItem.InvPartCmrInfId,  
  
		IPCIStockRef = inputItem.IPCIStockRef,  
  
		IPCIPartRef = inputItem.IPCIPartRef,  
  
		IPCIMinQty = inputItem.IPCIMinQty,  
  
		IPCIMaxQty = inputItem.IPCIMaxQty,  
  
		IPCIOrderLimit = inputItem.IPCIOrderLimit,  
  
		IPCIOrderQty = inputItem.IPCIOrderQty, 
            };
            return dto;
        }

        public static List<InvPartCmrInfDto> Map(ICollection<InvPartCmrInf> entities)
        {
            var dtos = new List<InvPartCmrInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartCmrInfDto()
                {
                      
  
		InvPartCmrInfId = inputItem.InvPartCmrInfId,  
  
		IPCIStockRef = inputItem.IPCIStockRef,  
  
		IPCIPartRef = inputItem.IPCIPartRef,  
  
		IPCIMinQty = inputItem.IPCIMinQty,  
  
		IPCIMaxQty = inputItem.IPCIMaxQty,  
  
		IPCIOrderLimit = inputItem.IPCIOrderLimit,  
  
		IPCIOrderQty = inputItem.IPCIOrderQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartCtgry Map(AddInvPartCtgryCommand inputItem)
        {
            var entity = new InvPartCtgry() {
                  
  
		InvPartCtgryId = inputItem.InvPartCtgryId,  
  
		IPCCode = inputItem.IPCCode,  
  
		IPCName = inputItem.IPCName,  
  
		IPCPricingType = inputItem.IPCPricingType,  
  
		IPCSLRef = inputItem.IPCSLRef,  
  
		IPCDL4Type = inputItem.IPCDL4Type,  
  
		IPCDL4Code = inputItem.IPCDL4Code,  
  
		IPCDL5Type = inputItem.IPCDL5Type,  
  
		IPCDL5Code = inputItem.IPCDL5Code,  
  
		IPCDL6Type = inputItem.IPCDL6Type,  
  
		IPCDL6Code = inputItem.IPCDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartCtgry Map(InvPartCtgry entity ,EditInvPartCtgryCommand inputItem)
        {
              
  
		entity.InvPartCtgryId = inputItem.InvPartCtgryId;  
  
		entity.IPCCode = inputItem.IPCCode;  
  
		entity.IPCName = inputItem.IPCName;  
  
		entity.IPCPricingType = inputItem.IPCPricingType;  
  
		entity.IPCSLRef = inputItem.IPCSLRef;  
  
		entity.IPCDL4Type = inputItem.IPCDL4Type;  
  
		entity.IPCDL4Code = inputItem.IPCDL4Code;  
  
		entity.IPCDL5Type = inputItem.IPCDL5Type;  
  
		entity.IPCDL5Code = inputItem.IPCDL5Code;  
  
		entity.IPCDL6Type = inputItem.IPCDL6Type;  
  
		entity.IPCDL6Code = inputItem.IPCDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartCtgryDto Map(InvPartCtgry inputItem)
        {
            var dto = new InvPartCtgryDto()
            {
                  
  
		InvPartCtgryId = inputItem.InvPartCtgryId,  
  
		IPCCode = inputItem.IPCCode,  
  
		IPCName = inputItem.IPCName,  
  
		IPCPricingType = inputItem.IPCPricingType,  
  
		IPCSLRef = inputItem.IPCSLRef,  
  
		IPCDL4Type = inputItem.IPCDL4Type,  
  
		IPCDL4Code = inputItem.IPCDL4Code,  
  
		IPCDL5Type = inputItem.IPCDL5Type,  
  
		IPCDL5Code = inputItem.IPCDL5Code,  
  
		IPCDL6Type = inputItem.IPCDL6Type,  
  
		IPCDL6Code = inputItem.IPCDL6Code, 
            };
            return dto;
        }

        public static List<InvPartCtgryDto> Map(ICollection<InvPartCtgry> entities)
        {
            var dtos = new List<InvPartCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartCtgryDto()
                {
                      
  
		InvPartCtgryId = inputItem.InvPartCtgryId,  
  
		IPCCode = inputItem.IPCCode,  
  
		IPCName = inputItem.IPCName,  
  
		IPCPricingType = inputItem.IPCPricingType,  
  
		IPCSLRef = inputItem.IPCSLRef,  
  
		IPCDL4Type = inputItem.IPCDL4Type,  
  
		IPCDL4Code = inputItem.IPCDL4Code,  
  
		IPCDL5Type = inputItem.IPCDL5Type,  
  
		IPCDL5Code = inputItem.IPCDL5Code,  
  
		IPCDL6Type = inputItem.IPCDL6Type,  
  
		IPCDL6Code = inputItem.IPCDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartCtgryAcc Map(AddInvPartCtgryAccCommand inputItem)
        {
            var entity = new InvPartCtgryAcc() {
                  
  
		InvPartCtgryAccId = inputItem.InvPartCtgryAccId,  
  
		IPCACtgryRef = inputItem.IPCACtgryRef,  
  
		IPCAType = inputItem.IPCAType,  
  
		IPCASLRef = inputItem.IPCASLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartCtgryAcc Map(InvPartCtgryAcc entity ,EditInvPartCtgryAccCommand inputItem)
        {
              
  
		entity.InvPartCtgryAccId = inputItem.InvPartCtgryAccId;  
  
		entity.IPCACtgryRef = inputItem.IPCACtgryRef;  
  
		entity.IPCAType = inputItem.IPCAType;  
  
		entity.IPCASLRef = inputItem.IPCASLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartCtgryAccDto Map(InvPartCtgryAcc inputItem)
        {
            var dto = new InvPartCtgryAccDto()
            {
                  
  
		InvPartCtgryAccId = inputItem.InvPartCtgryAccId,  
  
		IPCACtgryRef = inputItem.IPCACtgryRef,  
  
		IPCAType = inputItem.IPCAType,  
  
		IPCASLRef = inputItem.IPCASLRef, 
            };
            return dto;
        }

        public static List<InvPartCtgryAccDto> Map(ICollection<InvPartCtgryAcc> entities)
        {
            var dtos = new List<InvPartCtgryAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartCtgryAccDto()
                {
                      
  
		InvPartCtgryAccId = inputItem.InvPartCtgryAccId,  
  
		IPCACtgryRef = inputItem.IPCACtgryRef,  
  
		IPCAType = inputItem.IPCAType,  
  
		IPCASLRef = inputItem.IPCASLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartDLInf Map(AddInvPartDLInfCommand inputItem)
        {
            var entity = new InvPartDLInf() {
                  
  
		InvPartDLInfId = inputItem.InvPartDLInfId,  
  
		IPDIPartRef = inputItem.IPDIPartRef,  
  
		IPDIDate = inputItem.IPDIDate,  
  
		IPDISupplier = inputItem.IPDISupplier,  
  
		IPDISupIsLimit = inputItem.IPDISupIsLimit,  
  
		IPDIConsumer = inputItem.IPDIConsumer,  
  
		IPDIConsIsLimit = inputItem.IPDIConsIsLimit,  
  
		IPDIBuyPrice = inputItem.IPDIBuyPrice, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartDLInf Map(InvPartDLInf entity ,EditInvPartDLInfCommand inputItem)
        {
              
  
		entity.InvPartDLInfId = inputItem.InvPartDLInfId;  
  
		entity.IPDIPartRef = inputItem.IPDIPartRef;  
  
		entity.IPDIDate = inputItem.IPDIDate;  
  
		entity.IPDISupplier = inputItem.IPDISupplier;  
  
		entity.IPDISupIsLimit = inputItem.IPDISupIsLimit;  
  
		entity.IPDIConsumer = inputItem.IPDIConsumer;  
  
		entity.IPDIConsIsLimit = inputItem.IPDIConsIsLimit;  
  
		entity.IPDIBuyPrice = inputItem.IPDIBuyPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartDLInfDto Map(InvPartDLInf inputItem)
        {
            var dto = new InvPartDLInfDto()
            {
                  
  
		InvPartDLInfId = inputItem.InvPartDLInfId,  
  
		IPDIPartRef = inputItem.IPDIPartRef,  
  
		IPDIDate = inputItem.IPDIDate,  
  
		IPDISupplier = inputItem.IPDISupplier,  
  
		IPDISupIsLimit = inputItem.IPDISupIsLimit,  
  
		IPDIConsumer = inputItem.IPDIConsumer,  
  
		IPDIConsIsLimit = inputItem.IPDIConsIsLimit,  
  
		IPDIBuyPrice = inputItem.IPDIBuyPrice, 
            };
            return dto;
        }

        public static List<InvPartDLInfDto> Map(ICollection<InvPartDLInf> entities)
        {
            var dtos = new List<InvPartDLInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartDLInfDto()
                {
                      
  
		InvPartDLInfId = inputItem.InvPartDLInfId,  
  
		IPDIPartRef = inputItem.IPDIPartRef,  
  
		IPDIDate = inputItem.IPDIDate,  
  
		IPDISupplier = inputItem.IPDISupplier,  
  
		IPDISupIsLimit = inputItem.IPDISupIsLimit,  
  
		IPDIConsumer = inputItem.IPDIConsumer,  
  
		IPDIConsIsLimit = inputItem.IPDIConsIsLimit,  
  
		IPDIBuyPrice = inputItem.IPDIBuyPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartGroups Map(AddInvPartGroupsCommand inputItem)
        {
            var entity = new InvPartGroups() {
                  
  
		InvPartGroupsId = inputItem.InvPartGroupsId,  
  
		IPGParent = inputItem.IPGParent,  
  
		IPGCode = inputItem.IPGCode,  
  
		IPGTitle = inputItem.IPGTitle,  
  
		IPGDLRef = inputItem.IPGDLRef,  
  
		IPGMainRoot = inputItem.IPGMainRoot, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartGroups Map(InvPartGroups entity ,EditInvPartGroupsCommand inputItem)
        {
              
  
		entity.InvPartGroupsId = inputItem.InvPartGroupsId;  
  
		entity.IPGParent = inputItem.IPGParent;  
  
		entity.IPGCode = inputItem.IPGCode;  
  
		entity.IPGTitle = inputItem.IPGTitle;  
  
		entity.IPGDLRef = inputItem.IPGDLRef;  
  
		entity.IPGMainRoot = inputItem.IPGMainRoot; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartGroupsDto Map(InvPartGroups inputItem)
        {
            var dto = new InvPartGroupsDto()
            {
                  
  
		InvPartGroupsId = inputItem.InvPartGroupsId,  
  
		IPGParent = inputItem.IPGParent,  
  
		IPGCode = inputItem.IPGCode,  
  
		IPGTitle = inputItem.IPGTitle,  
  
		IPGDLRef = inputItem.IPGDLRef,  
  
		IPGMainRoot = inputItem.IPGMainRoot, 
            };
            return dto;
        }

        public static List<InvPartGroupsDto> Map(ICollection<InvPartGroups> entities)
        {
            var dtos = new List<InvPartGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartGroupsDto()
                {
                      
  
		InvPartGroupsId = inputItem.InvPartGroupsId,  
  
		IPGParent = inputItem.IPGParent,  
  
		IPGCode = inputItem.IPGCode,  
  
		IPGTitle = inputItem.IPGTitle,  
  
		IPGDLRef = inputItem.IPGDLRef,  
  
		IPGMainRoot = inputItem.IPGMainRoot, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartGrpRel Map(AddInvPartGrpRelCommand inputItem)
        {
            var entity = new InvPartGrpRel() {
                  
  
		IGRGrpRef = inputItem.IGRGrpRef,  
  
		IGRPartRef = inputItem.IGRPartRef,  
  
		IGRActive = inputItem.IGRActive, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartGrpRel Map(InvPartGrpRel entity ,EditInvPartGrpRelCommand inputItem)
        {
              
  
		entity.IGRGrpRef = inputItem.IGRGrpRef;  
  
		entity.IGRPartRef = inputItem.IGRPartRef;  
  
		entity.IGRActive = inputItem.IGRActive; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartGrpRelDto Map(InvPartGrpRel inputItem)
        {
            var dto = new InvPartGrpRelDto()
            {
                  
  
		IGRGrpRef = inputItem.IGRGrpRef,  
  
		IGRPartRef = inputItem.IGRPartRef,  
  
		IGRActive = inputItem.IGRActive, 
            };
            return dto;
        }

        public static List<InvPartGrpRelDto> Map(ICollection<InvPartGrpRel> entities)
        {
            var dtos = new List<InvPartGrpRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartGrpRelDto()
                {
                      
  
		IGRGrpRef = inputItem.IGRGrpRef,  
  
		IGRPartRef = inputItem.IGRPartRef,  
  
		IGRActive = inputItem.IGRActive, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartParams Map(AddInvPartParamsCommand inputItem)
        {
            var entity = new InvPartParams() {
                  
  
		InvPartParamId = inputItem.InvPartParamId,  
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IPPParamRef = inputItem.IPPParamRef,  
  
		IPPVal = inputItem.IPPVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartParams Map(InvPartParams entity ,EditInvPartParamsCommand inputItem)
        {
              
  
		entity.InvPartParamId = inputItem.InvPartParamId;  
  
		entity.IPPPartRef = inputItem.IPPPartRef;  
  
		entity.IPPParamRef = inputItem.IPPParamRef;  
  
		entity.IPPVal = inputItem.IPPVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartParamsDto Map(InvPartParams inputItem)
        {
            var dto = new InvPartParamsDto()
            {
                  
  
		InvPartParamId = inputItem.InvPartParamId,  
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IPPParamRef = inputItem.IPPParamRef,  
  
		IPPVal = inputItem.IPPVal, 
            };
            return dto;
        }

        public static List<InvPartParamsDto> Map(ICollection<InvPartParams> entities)
        {
            var dtos = new List<InvPartParamsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartParamsDto()
                {
                      
  
		InvPartParamId = inputItem.InvPartParamId,  
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IPPParamRef = inputItem.IPPParamRef,  
  
		IPPVal = inputItem.IPPVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartPrice Map(AddInvPartPriceCommand inputItem)
        {
            var entity = new InvPartPrice() {
                  
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IIPAccPrdRef = inputItem.IIPAccPrdRef,  
  
		IPPRatio = inputItem.IPPRatio,  
  
		IPPType = inputItem.IPPType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartPrice Map(InvPartPrice entity ,EditInvPartPriceCommand inputItem)
        {
              
  
		entity.IPPPartRef = inputItem.IPPPartRef;  
  
		entity.IIPAccPrdRef = inputItem.IIPAccPrdRef;  
  
		entity.IPPRatio = inputItem.IPPRatio;  
  
		entity.IPPType = inputItem.IPPType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartPriceDto Map(InvPartPrice inputItem)
        {
            var dto = new InvPartPriceDto()
            {
                  
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IIPAccPrdRef = inputItem.IIPAccPrdRef,  
  
		IPPRatio = inputItem.IPPRatio,  
  
		IPPType = inputItem.IPPType, 
            };
            return dto;
        }

        public static List<InvPartPriceDto> Map(ICollection<InvPartPrice> entities)
        {
            var dtos = new List<InvPartPriceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartPriceDto()
                {
                      
  
		IPPPartRef = inputItem.IPPPartRef,  
  
		IIPAccPrdRef = inputItem.IIPAccPrdRef,  
  
		IPPRatio = inputItem.IPPRatio,  
  
		IPPType = inputItem.IPPType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartSimilar Map(AddInvPartSimilarCommand inputItem)
        {
            var entity = new InvPartSimilar() {
                  
  
		InvPartSimilarId = inputItem.InvPartSimilarId,  
  
		IPSMainPartRef = inputItem.IPSMainPartRef,  
  
		IPSSimiPartRef = inputItem.IPSSimiPartRef,  
  
		IPSOrder = inputItem.IPSOrder,  
  
		IPSRatio = inputItem.IPSRatio, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartSimilar Map(InvPartSimilar entity ,EditInvPartSimilarCommand inputItem)
        {
              
  
		entity.InvPartSimilarId = inputItem.InvPartSimilarId;  
  
		entity.IPSMainPartRef = inputItem.IPSMainPartRef;  
  
		entity.IPSSimiPartRef = inputItem.IPSSimiPartRef;  
  
		entity.IPSOrder = inputItem.IPSOrder;  
  
		entity.IPSRatio = inputItem.IPSRatio; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartSimilarDto Map(InvPartSimilar inputItem)
        {
            var dto = new InvPartSimilarDto()
            {
                  
  
		InvPartSimilarId = inputItem.InvPartSimilarId,  
  
		IPSMainPartRef = inputItem.IPSMainPartRef,  
  
		IPSSimiPartRef = inputItem.IPSSimiPartRef,  
  
		IPSOrder = inputItem.IPSOrder,  
  
		IPSRatio = inputItem.IPSRatio, 
            };
            return dto;
        }

        public static List<InvPartSimilarDto> Map(ICollection<InvPartSimilar> entities)
        {
            var dtos = new List<InvPartSimilarDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartSimilarDto()
                {
                      
  
		InvPartSimilarId = inputItem.InvPartSimilarId,  
  
		IPSMainPartRef = inputItem.IPSMainPartRef,  
  
		IPSSimiPartRef = inputItem.IPSSimiPartRef,  
  
		IPSOrder = inputItem.IPSOrder,  
  
		IPSRatio = inputItem.IPSRatio, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartStkPitchRel Map(AddInvPartStkPitchRelCommand inputItem)
        {
            var entity = new InvPartStkPitchRel() {
                  
  
		PPRPitchRef = inputItem.PPRPitchRef,  
  
		PPRPartRef = inputItem.PPRPartRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartStkPitchRel Map(InvPartStkPitchRel entity ,EditInvPartStkPitchRelCommand inputItem)
        {
              
  
		entity.PPRPitchRef = inputItem.PPRPitchRef;  
  
		entity.PPRPartRef = inputItem.PPRPartRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartStkPitchRelDto Map(InvPartStkPitchRel inputItem)
        {
            var dto = new InvPartStkPitchRelDto()
            {
                  
  
		PPRPitchRef = inputItem.PPRPitchRef,  
  
		PPRPartRef = inputItem.PPRPartRef, 
            };
            return dto;
        }

        public static List<InvPartStkPitchRelDto> Map(ICollection<InvPartStkPitchRel> entities)
        {
            var dtos = new List<InvPartStkPitchRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartStkPitchRelDto()
                {
                      
  
		PPRPitchRef = inputItem.PPRPitchRef,  
  
		PPRPartRef = inputItem.PPRPartRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartStockRel Map(AddInvPartStockRelCommand inputItem)
        {
            var entity = new InvPartStockRel() {
                  
  
		PSRPartRef = inputItem.PSRPartRef,  
  
		PSRStockRef = inputItem.PSRStockRef,  
  
		PSRActive = inputItem.PSRActive, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartStockRel Map(InvPartStockRel entity ,EditInvPartStockRelCommand inputItem)
        {
              
  
		entity.PSRPartRef = inputItem.PSRPartRef;  
  
		entity.PSRStockRef = inputItem.PSRStockRef;  
  
		entity.PSRActive = inputItem.PSRActive; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartStockRelDto Map(InvPartStockRel inputItem)
        {
            var dto = new InvPartStockRelDto()
            {
                  
  
		PSRPartRef = inputItem.PSRPartRef,  
  
		PSRStockRef = inputItem.PSRStockRef,  
  
		PSRActive = inputItem.PSRActive, 
            };
            return dto;
        }

        public static List<InvPartStockRelDto> Map(ICollection<InvPartStockRel> entities)
        {
            var dtos = new List<InvPartStockRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartStockRelDto()
                {
                      
  
		PSRPartRef = inputItem.PSRPartRef,  
  
		PSRStockRef = inputItem.PSRStockRef,  
  
		PSRActive = inputItem.PSRActive, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvPartUnits Map(AddInvPartUnitsCommand inputItem)
        {
            var entity = new InvPartUnits() {
                  
  
		PUPartRef = inputItem.PUPartRef,  
  
		PUUnitRef = inputItem.PUUnitRef,  
  
		PURatio = inputItem.PURatio,  
  
		PUCanChange = inputItem.PUCanChange,  
  
		PUIsDef = inputItem.PUIsDef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvPartUnits Map(InvPartUnits entity ,EditInvPartUnitsCommand inputItem)
        {
              
  
		entity.PUPartRef = inputItem.PUPartRef;  
  
		entity.PUUnitRef = inputItem.PUUnitRef;  
  
		entity.PURatio = inputItem.PURatio;  
  
		entity.PUCanChange = inputItem.PUCanChange;  
  
		entity.PUIsDef = inputItem.PUIsDef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvPartUnitsDto Map(InvPartUnits inputItem)
        {
            var dto = new InvPartUnitsDto()
            {
                  
  
		PUPartRef = inputItem.PUPartRef,  
  
		PUUnitRef = inputItem.PUUnitRef,  
  
		PURatio = inputItem.PURatio,  
  
		PUCanChange = inputItem.PUCanChange,  
  
		PUIsDef = inputItem.PUIsDef, 
            };
            return dto;
        }

        public static List<InvPartUnitsDto> Map(ICollection<InvPartUnits> entities)
        {
            var dtos = new List<InvPartUnitsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvPartUnitsDto()
                {
                      
  
		PUPartRef = inputItem.PUPartRef,  
  
		PUUnitRef = inputItem.PUUnitRef,  
  
		PURatio = inputItem.PURatio,  
  
		PUCanChange = inputItem.PUCanChange,  
  
		PUIsDef = inputItem.PUIsDef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvQtPartRels Map(AddInvQtPartRelsCommand inputItem)
        {
            var entity = new InvQtPartRels() {
                  
  
		InvQtPartRef = inputItem.InvQtPartRef,  
  
		InvQtCtrlRef = inputItem.InvQtCtrlRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvQtPartRels Map(InvQtPartRels entity ,EditInvQtPartRelsCommand inputItem)
        {
              
  
		entity.InvQtPartRef = inputItem.InvQtPartRef;  
  
		entity.InvQtCtrlRef = inputItem.InvQtCtrlRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvQtPartRelsDto Map(InvQtPartRels inputItem)
        {
            var dto = new InvQtPartRelsDto()
            {
                  
  
		InvQtPartRef = inputItem.InvQtPartRef,  
  
		InvQtCtrlRef = inputItem.InvQtCtrlRef, 
            };
            return dto;
        }

        public static List<InvQtPartRelsDto> Map(ICollection<InvQtPartRels> entities)
        {
            var dtos = new List<InvQtPartRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvQtPartRelsDto()
                {
                      
  
		InvQtPartRef = inputItem.InvQtPartRef,  
  
		InvQtCtrlRef = inputItem.InvQtCtrlRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvQtyCtrls Map(AddInvQtyCtrlsCommand inputItem)
        {
            var entity = new InvQtyCtrls() {
                  
  
		InvQtyCtrlId = inputItem.InvQtyCtrlId,  
  
		IQCTitle = inputItem.IQCTitle,  
  
		IQCBaseType = inputItem.IQCBaseType,  
  
		IQCValType = inputItem.IQCValType,  
  
		ICQValRole = inputItem.ICQValRole, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvQtyCtrls Map(InvQtyCtrls entity ,EditInvQtyCtrlsCommand inputItem)
        {
              
  
		entity.InvQtyCtrlId = inputItem.InvQtyCtrlId;  
  
		entity.IQCTitle = inputItem.IQCTitle;  
  
		entity.IQCBaseType = inputItem.IQCBaseType;  
  
		entity.IQCValType = inputItem.IQCValType;  
  
		entity.ICQValRole = inputItem.ICQValRole; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvQtyCtrlsDto Map(InvQtyCtrls inputItem)
        {
            var dto = new InvQtyCtrlsDto()
            {
                  
  
		InvQtyCtrlId = inputItem.InvQtyCtrlId,  
  
		IQCTitle = inputItem.IQCTitle,  
  
		IQCBaseType = inputItem.IQCBaseType,  
  
		IQCValType = inputItem.IQCValType,  
  
		ICQValRole = inputItem.ICQValRole, 
            };
            return dto;
        }

        public static List<InvQtyCtrlsDto> Map(ICollection<InvQtyCtrls> entities)
        {
            var dtos = new List<InvQtyCtrlsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvQtyCtrlsDto()
                {
                      
  
		InvQtyCtrlId = inputItem.InvQtyCtrlId,  
  
		IQCTitle = inputItem.IQCTitle,  
  
		IQCBaseType = inputItem.IQCBaseType,  
  
		IQCValType = inputItem.IQCValType,  
  
		ICQValRole = inputItem.ICQValRole, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStckPeriod Map(AddInvStckPeriodCommand inputItem)
        {
            var entity = new InvStckPeriod() {
                  
  
		InvStckPeriodID = inputItem.InvStckPeriodID,  
  
		ISPTitle = inputItem.ISPTitle,  
  
		ISPDate = inputItem.ISPDate,  
  
		ISPSCount = inputItem.ISPSCount,  
  
		ISPCnt1MinQty = inputItem.ISPCnt1MinQty,  
  
		ISPCnt1MinAmount = inputItem.ISPCnt1MinAmount,  
  
		ISPCnt1MinVch = inputItem.ISPCnt1MinVch,  
  
		ISPList1Cond = inputItem.ISPList1Cond,  
  
		ISPList2Cond = inputItem.ISPList2Cond,  
  
		ISPList3Cond = inputItem.ISPList3Cond,  
  
		ISPAccPrdRef = inputItem.ISPAccPrdRef,  
  
		ISPIncVchRef = inputItem.ISPIncVchRef,  
  
		ISPDecVchRef = inputItem.ISPDecVchRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStckPeriod Map(InvStckPeriod entity ,EditInvStckPeriodCommand inputItem)
        {
              
  
		entity.InvStckPeriodID = inputItem.InvStckPeriodID;  
  
		entity.ISPTitle = inputItem.ISPTitle;  
  
		entity.ISPDate = inputItem.ISPDate;  
  
		entity.ISPSCount = inputItem.ISPSCount;  
  
		entity.ISPCnt1MinQty = inputItem.ISPCnt1MinQty;  
  
		entity.ISPCnt1MinAmount = inputItem.ISPCnt1MinAmount;  
  
		entity.ISPCnt1MinVch = inputItem.ISPCnt1MinVch;  
  
		entity.ISPList1Cond = inputItem.ISPList1Cond;  
  
		entity.ISPList2Cond = inputItem.ISPList2Cond;  
  
		entity.ISPList3Cond = inputItem.ISPList3Cond;  
  
		entity.ISPAccPrdRef = inputItem.ISPAccPrdRef;  
  
		entity.ISPIncVchRef = inputItem.ISPIncVchRef;  
  
		entity.ISPDecVchRef = inputItem.ISPDecVchRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStckPeriodDto Map(InvStckPeriod inputItem)
        {
            var dto = new InvStckPeriodDto()
            {
                  
  
		InvStckPeriodID = inputItem.InvStckPeriodID,  
  
		ISPTitle = inputItem.ISPTitle,  
  
		ISPDate = inputItem.ISPDate,  
  
		ISPSCount = inputItem.ISPSCount,  
  
		ISPCnt1MinQty = inputItem.ISPCnt1MinQty,  
  
		ISPCnt1MinAmount = inputItem.ISPCnt1MinAmount,  
  
		ISPCnt1MinVch = inputItem.ISPCnt1MinVch,  
  
		ISPList1Cond = inputItem.ISPList1Cond,  
  
		ISPList2Cond = inputItem.ISPList2Cond,  
  
		ISPList3Cond = inputItem.ISPList3Cond,  
  
		ISPAccPrdRef = inputItem.ISPAccPrdRef,  
  
		ISPIncVchRef = inputItem.ISPIncVchRef,  
  
		ISPDecVchRef = inputItem.ISPDecVchRef, 
            };
            return dto;
        }

        public static List<InvStckPeriodDto> Map(ICollection<InvStckPeriod> entities)
        {
            var dtos = new List<InvStckPeriodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStckPeriodDto()
                {
                      
  
		InvStckPeriodID = inputItem.InvStckPeriodID,  
  
		ISPTitle = inputItem.ISPTitle,  
  
		ISPDate = inputItem.ISPDate,  
  
		ISPSCount = inputItem.ISPSCount,  
  
		ISPCnt1MinQty = inputItem.ISPCnt1MinQty,  
  
		ISPCnt1MinAmount = inputItem.ISPCnt1MinAmount,  
  
		ISPCnt1MinVch = inputItem.ISPCnt1MinVch,  
  
		ISPList1Cond = inputItem.ISPList1Cond,  
  
		ISPList2Cond = inputItem.ISPList2Cond,  
  
		ISPList3Cond = inputItem.ISPList3Cond,  
  
		ISPAccPrdRef = inputItem.ISPAccPrdRef,  
  
		ISPIncVchRef = inputItem.ISPIncVchRef,  
  
		ISPDecVchRef = inputItem.ISPDecVchRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStckPeriodRels Map(AddInvStckPeriodRelsCommand inputItem)
        {
            var entity = new InvStckPeriodRels() {
                  
  
		SRStckPeriodRef = inputItem.SRStckPeriodRef,  
  
		SRStockRef = inputItem.SRStockRef,  
  
		Active = inputItem.Active, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStckPeriodRels Map(InvStckPeriodRels entity ,EditInvStckPeriodRelsCommand inputItem)
        {
              
  
		entity.SRStckPeriodRef = inputItem.SRStckPeriodRef;  
  
		entity.SRStockRef = inputItem.SRStockRef;  
  
		entity.Active = inputItem.Active; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStckPeriodRelsDto Map(InvStckPeriodRels inputItem)
        {
            var dto = new InvStckPeriodRelsDto()
            {
                  
  
		SRStckPeriodRef = inputItem.SRStckPeriodRef,  
  
		SRStockRef = inputItem.SRStockRef,  
  
		Active = inputItem.Active, 
            };
            return dto;
        }

        public static List<InvStckPeriodRelsDto> Map(ICollection<InvStckPeriodRels> entities)
        {
            var dtos = new List<InvStckPeriodRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStckPeriodRelsDto()
                {
                      
  
		SRStckPeriodRef = inputItem.SRStckPeriodRef,  
  
		SRStockRef = inputItem.SRStockRef,  
  
		Active = inputItem.Active, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStckTag Map(AddInvStckTagCommand inputItem)
        {
            var entity = new InvStckTag() {
                  
  
		InvStckTagId = inputItem.InvStckTagId,  
  
		ISTTagNo = inputItem.ISTTagNo,  
  
		ISTStckPeriodRef = inputItem.ISTStckPeriodRef,  
  
		ISTStockRef = inputItem.ISTStockRef,  
  
		ISTPartRef = inputItem.ISTPartRef,  
  
		ISTTagCnt1 = inputItem.ISTTagCnt1,  
  
		ISTTagCnt2 = inputItem.ISTTagCnt2,  
  
		ISTTagCnt3 = inputItem.ISTTagCnt3,  
  
		ISTInvVchItmRef = inputItem.ISTInvVchItmRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStckTag Map(InvStckTag entity ,EditInvStckTagCommand inputItem)
        {
              
  
		entity.InvStckTagId = inputItem.InvStckTagId;  
  
		entity.ISTTagNo = inputItem.ISTTagNo;  
  
		entity.ISTStckPeriodRef = inputItem.ISTStckPeriodRef;  
  
		entity.ISTStockRef = inputItem.ISTStockRef;  
  
		entity.ISTPartRef = inputItem.ISTPartRef;  
  
		entity.ISTTagCnt1 = inputItem.ISTTagCnt1;  
  
		entity.ISTTagCnt2 = inputItem.ISTTagCnt2;  
  
		entity.ISTTagCnt3 = inputItem.ISTTagCnt3;  
  
		entity.ISTInvVchItmRef = inputItem.ISTInvVchItmRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStckTagDto Map(InvStckTag inputItem)
        {
            var dto = new InvStckTagDto()
            {
                  
  
		InvStckTagId = inputItem.InvStckTagId,  
  
		ISTTagNo = inputItem.ISTTagNo,  
  
		ISTStckPeriodRef = inputItem.ISTStckPeriodRef,  
  
		ISTStockRef = inputItem.ISTStockRef,  
  
		ISTPartRef = inputItem.ISTPartRef,  
  
		ISTTagCnt1 = inputItem.ISTTagCnt1,  
  
		ISTTagCnt2 = inputItem.ISTTagCnt2,  
  
		ISTTagCnt3 = inputItem.ISTTagCnt3,  
  
		ISTInvVchItmRef = inputItem.ISTInvVchItmRef, 
            };
            return dto;
        }

        public static List<InvStckTagDto> Map(ICollection<InvStckTag> entities)
        {
            var dtos = new List<InvStckTagDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStckTagDto()
                {
                      
  
		InvStckTagId = inputItem.InvStckTagId,  
  
		ISTTagNo = inputItem.ISTTagNo,  
  
		ISTStckPeriodRef = inputItem.ISTStckPeriodRef,  
  
		ISTStockRef = inputItem.ISTStockRef,  
  
		ISTPartRef = inputItem.ISTPartRef,  
  
		ISTTagCnt1 = inputItem.ISTTagCnt1,  
  
		ISTTagCnt2 = inputItem.ISTTagCnt2,  
  
		ISTTagCnt3 = inputItem.ISTTagCnt3,  
  
		ISTInvVchItmRef = inputItem.ISTInvVchItmRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStkPitchs Map(AddInvStkPitchsCommand inputItem)
        {
            var entity = new InvStkPitchs() {
                  
  
		InvStkPitchId = inputItem.InvStkPitchId,  
  
		ISPParent = inputItem.ISPParent,  
  
		ISPCode = inputItem.ISPCode,  
  
		ISPTitle = inputItem.ISPTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStkPitchs Map(InvStkPitchs entity ,EditInvStkPitchsCommand inputItem)
        {
              
  
		entity.InvStkPitchId = inputItem.InvStkPitchId;  
  
		entity.ISPParent = inputItem.ISPParent;  
  
		entity.ISPCode = inputItem.ISPCode;  
  
		entity.ISPTitle = inputItem.ISPTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStkPitchsDto Map(InvStkPitchs inputItem)
        {
            var dto = new InvStkPitchsDto()
            {
                  
  
		InvStkPitchId = inputItem.InvStkPitchId,  
  
		ISPParent = inputItem.ISPParent,  
  
		ISPCode = inputItem.ISPCode,  
  
		ISPTitle = inputItem.ISPTitle, 
            };
            return dto;
        }

        public static List<InvStkPitchsDto> Map(ICollection<InvStkPitchs> entities)
        {
            var dtos = new List<InvStkPitchsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStkPitchsDto()
                {
                      
  
		InvStkPitchId = inputItem.InvStkPitchId,  
  
		ISPParent = inputItem.ISPParent,  
  
		ISPCode = inputItem.ISPCode,  
  
		ISPTitle = inputItem.ISPTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStock Map(AddInvStockCommand inputItem)
        {
            var entity = new InvStock() {
                  
  
		StockId = inputItem.StockId,  
  
		StockCode = inputItem.StockCode,  
  
		StockName = inputItem.StockName,  
  
		StckType = inputItem.StckType,  
  
		StckSLRef = inputItem.StckSLRef,  
  
		StckDL4Type = inputItem.StckDL4Type,  
  
		StckDL4Code = inputItem.StckDL4Code,  
  
		StckDL5Type = inputItem.StckDL5Type,  
  
		StckDL5Code = inputItem.StckDL5Code,  
  
		StckDL6Type = inputItem.StckDL6Type,  
  
		StckDL6Code = inputItem.StckDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStock Map(InvStock entity ,EditInvStockCommand inputItem)
        {
              
  
		entity.StockId = inputItem.StockId;  
  
		entity.StockCode = inputItem.StockCode;  
  
		entity.StockName = inputItem.StockName;  
  
		entity.StckType = inputItem.StckType;  
  
		entity.StckSLRef = inputItem.StckSLRef;  
  
		entity.StckDL4Type = inputItem.StckDL4Type;  
  
		entity.StckDL4Code = inputItem.StckDL4Code;  
  
		entity.StckDL5Type = inputItem.StckDL5Type;  
  
		entity.StckDL5Code = inputItem.StckDL5Code;  
  
		entity.StckDL6Type = inputItem.StckDL6Type;  
  
		entity.StckDL6Code = inputItem.StckDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStockDto Map(InvStock inputItem)
        {
            var dto = new InvStockDto()
            {
                  
  
		StockId = inputItem.StockId,  
  
		StockCode = inputItem.StockCode,  
  
		StockName = inputItem.StockName,  
  
		StckType = inputItem.StckType,  
  
		StckSLRef = inputItem.StckSLRef,  
  
		StckDL4Type = inputItem.StckDL4Type,  
  
		StckDL4Code = inputItem.StckDL4Code,  
  
		StckDL5Type = inputItem.StckDL5Type,  
  
		StckDL5Code = inputItem.StckDL5Code,  
  
		StckDL6Type = inputItem.StckDL6Type,  
  
		StckDL6Code = inputItem.StckDL6Code, 
            };
            return dto;
        }

        public static List<InvStockDto> Map(ICollection<InvStock> entities)
        {
            var dtos = new List<InvStockDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStockDto()
                {
                      
  
		StockId = inputItem.StockId,  
  
		StockCode = inputItem.StockCode,  
  
		StockName = inputItem.StockName,  
  
		StckType = inputItem.StckType,  
  
		StckSLRef = inputItem.StckSLRef,  
  
		StckDL4Type = inputItem.StckDL4Type,  
  
		StckDL4Code = inputItem.StckDL4Code,  
  
		StckDL5Type = inputItem.StckDL5Type,  
  
		StckDL5Code = inputItem.StckDL5Code,  
  
		StckDL6Type = inputItem.StckDL6Type,  
  
		StckDL6Code = inputItem.StckDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvStockUser Map(AddInvStockUserCommand inputItem)
        {
            var entity = new InvStockUser() {
                  
  
		InvStockUserId = inputItem.InvStockUserId,  
  
		ISUStockRef = inputItem.ISUStockRef,  
  
		ISUUserRef = inputItem.ISUUserRef,  
  
		ISURight = inputItem.ISURight, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvStockUser Map(InvStockUser entity ,EditInvStockUserCommand inputItem)
        {
              
  
		entity.InvStockUserId = inputItem.InvStockUserId;  
  
		entity.ISUStockRef = inputItem.ISUStockRef;  
  
		entity.ISUUserRef = inputItem.ISUUserRef;  
  
		entity.ISURight = inputItem.ISURight; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvStockUserDto Map(InvStockUser inputItem)
        {
            var dto = new InvStockUserDto()
            {
                  
  
		InvStockUserId = inputItem.InvStockUserId,  
  
		ISUStockRef = inputItem.ISUStockRef,  
  
		ISUUserRef = inputItem.ISUUserRef,  
  
		ISURight = inputItem.ISURight, 
            };
            return dto;
        }

        public static List<InvStockUserDto> Map(ICollection<InvStockUser> entities)
        {
            var dtos = new List<InvStockUserDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvStockUserDto()
                {
                      
  
		InvStockUserId = inputItem.InvStockUserId,  
  
		ISUStockRef = inputItem.ISUStockRef,  
  
		ISUUserRef = inputItem.ISUUserRef,  
  
		ISURight = inputItem.ISURight, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchDefAcc Map(AddInvVchDefAccCommand inputItem)
        {
            var entity = new InvVchDefAcc() {
                  
  
		InvVchDefAccId = inputItem.InvVchDefAccId,  
  
		IVDAAccPrd = inputItem.IVDAAccPrd,  
  
		IVDAVchType = inputItem.IVDAVchType,  
  
		IVDAPartRef = inputItem.IVDAPartRef,  
  
		IVDADLRef = inputItem.IVDADLRef,  
  
		IVDASLRef = inputItem.IVDASLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchDefAcc Map(InvVchDefAcc entity ,EditInvVchDefAccCommand inputItem)
        {
              
  
		entity.InvVchDefAccId = inputItem.InvVchDefAccId;  
  
		entity.IVDAAccPrd = inputItem.IVDAAccPrd;  
  
		entity.IVDAVchType = inputItem.IVDAVchType;  
  
		entity.IVDAPartRef = inputItem.IVDAPartRef;  
  
		entity.IVDADLRef = inputItem.IVDADLRef;  
  
		entity.IVDASLRef = inputItem.IVDASLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchDefAccDto Map(InvVchDefAcc inputItem)
        {
            var dto = new InvVchDefAccDto()
            {
                  
  
		InvVchDefAccId = inputItem.InvVchDefAccId,  
  
		IVDAAccPrd = inputItem.IVDAAccPrd,  
  
		IVDAVchType = inputItem.IVDAVchType,  
  
		IVDAPartRef = inputItem.IVDAPartRef,  
  
		IVDADLRef = inputItem.IVDADLRef,  
  
		IVDASLRef = inputItem.IVDASLRef, 
            };
            return dto;
        }

        public static List<InvVchDefAccDto> Map(ICollection<InvVchDefAcc> entities)
        {
            var dtos = new List<InvVchDefAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchDefAccDto()
                {
                      
  
		InvVchDefAccId = inputItem.InvVchDefAccId,  
  
		IVDAAccPrd = inputItem.IVDAAccPrd,  
  
		IVDAVchType = inputItem.IVDAVchType,  
  
		IVDAPartRef = inputItem.IVDAPartRef,  
  
		IVDADLRef = inputItem.IVDADLRef,  
  
		IVDASLRef = inputItem.IVDASLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchHdr Map(AddInvVchHdrCommand inputItem)
        {
            var entity = new InvVchHdr() {
                  
  
		InvVchHdrId = inputItem.InvVchHdrId,  
  
		IVHNum = inputItem.IVHNum,  
  
		IVHLocalNum = inputItem.IVHLocalNum,  
  
		IVHDate = inputItem.IVHDate,  
  
		IVHDescr = inputItem.IVHDescr,  
  
		IVHStockRef = inputItem.IVHStockRef,  
  
		IVHOpStkRef = inputItem.IVHOpStkRef,  
  
		IVHVchType = inputItem.IVHVchType,  
  
		IVHSLRef = inputItem.IVHSLRef,  
  
		IVHDLRef = inputItem.IVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IVHState = inputItem.IVHState,  
  
		IAccPrdRef = inputItem.IAccPrdRef,  
  
		IVHRefID = inputItem.IVHRefID,  
  
		IVHRefType = inputItem.IVHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchHdr Map(InvVchHdr entity ,EditInvVchHdrCommand inputItem)
        {
              
  
		entity.InvVchHdrId = inputItem.InvVchHdrId;  
  
		entity.IVHNum = inputItem.IVHNum;  
  
		entity.IVHLocalNum = inputItem.IVHLocalNum;  
  
		entity.IVHDate = inputItem.IVHDate;  
  
		entity.IVHDescr = inputItem.IVHDescr;  
  
		entity.IVHStockRef = inputItem.IVHStockRef;  
  
		entity.IVHOpStkRef = inputItem.IVHOpStkRef;  
  
		entity.IVHVchType = inputItem.IVHVchType;  
  
		entity.IVHSLRef = inputItem.IVHSLRef;  
  
		entity.IVHDLRef = inputItem.IVHDLRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.IVHState = inputItem.IVHState;  
  
		entity.IAccPrdRef = inputItem.IAccPrdRef;  
  
		entity.IVHRefID = inputItem.IVHRefID;  
  
		entity.IVHRefType = inputItem.IVHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchHdrDto Map(InvVchHdr inputItem)
        {
            var dto = new InvVchHdrDto()
            {
                  
  
		InvVchHdrId = inputItem.InvVchHdrId,  
  
		IVHNum = inputItem.IVHNum,  
  
		IVHLocalNum = inputItem.IVHLocalNum,  
  
		IVHDate = inputItem.IVHDate,  
  
		IVHDescr = inputItem.IVHDescr,  
  
		IVHStockRef = inputItem.IVHStockRef,  
  
		IVHOpStkRef = inputItem.IVHOpStkRef,  
  
		IVHVchType = inputItem.IVHVchType,  
  
		IVHSLRef = inputItem.IVHSLRef,  
  
		IVHDLRef = inputItem.IVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IVHState = inputItem.IVHState,  
  
		IAccPrdRef = inputItem.IAccPrdRef,  
  
		IVHRefID = inputItem.IVHRefID,  
  
		IVHRefType = inputItem.IVHRefType, 
            };
            return dto;
        }

        public static List<InvVchHdrDto> Map(ICollection<InvVchHdr> entities)
        {
            var dtos = new List<InvVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchHdrDto()
                {
                      
  
		InvVchHdrId = inputItem.InvVchHdrId,  
  
		IVHNum = inputItem.IVHNum,  
  
		IVHLocalNum = inputItem.IVHLocalNum,  
  
		IVHDate = inputItem.IVHDate,  
  
		IVHDescr = inputItem.IVHDescr,  
  
		IVHStockRef = inputItem.IVHStockRef,  
  
		IVHOpStkRef = inputItem.IVHOpStkRef,  
  
		IVHVchType = inputItem.IVHVchType,  
  
		IVHSLRef = inputItem.IVHSLRef,  
  
		IVHDLRef = inputItem.IVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		IVHState = inputItem.IVHState,  
  
		IAccPrdRef = inputItem.IAccPrdRef,  
  
		IVHRefID = inputItem.IVHRefID,  
  
		IVHRefType = inputItem.IVHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchItm Map(AddInvVchItmCommand inputItem)
        {
            var entity = new InvVchItm() {
                  
  
		InvVchItmId = inputItem.InvVchItmId,  
  
		InvVchHdrRef = inputItem.InvVchHdrRef,  
  
		IVISeq = inputItem.IVISeq,  
  
		IVIPartRef = inputItem.IVIPartRef,  
  
		IVIUnitRef = inputItem.IVIUnitRef,  
  
		IVIMainQty = inputItem.IVIMainQty,  
  
		IVIOthQty = inputItem.IVIOthQty,  
  
		IVIDescr = inputItem.IVIDescr,  
  
		IVIDLRef = inputItem.IVIDLRef,  
  
		IVISLRef = inputItem.IVISLRef,  
  
		IVIRefID = inputItem.IVIRefID,  
  
		IVIRefType = inputItem.IVIRefType,  
  
		IVIFormulRef = inputItem.IVIFormulRef,  
  
		IVIDL5Ref = inputItem.IVIDL5Ref,  
  
		IVIDL6Ref = inputItem.IVIDL6Ref, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchItm Map(InvVchItm entity ,EditInvVchItmCommand inputItem)
        {
              
  
		entity.InvVchItmId = inputItem.InvVchItmId;  
  
		entity.InvVchHdrRef = inputItem.InvVchHdrRef;  
  
		entity.IVISeq = inputItem.IVISeq;  
  
		entity.IVIPartRef = inputItem.IVIPartRef;  
  
		entity.IVIUnitRef = inputItem.IVIUnitRef;  
  
		entity.IVIMainQty = inputItem.IVIMainQty;  
  
		entity.IVIOthQty = inputItem.IVIOthQty;  
  
		entity.IVIDescr = inputItem.IVIDescr;  
  
		entity.IVIDLRef = inputItem.IVIDLRef;  
  
		entity.IVISLRef = inputItem.IVISLRef;  
  
		entity.IVIRefID = inputItem.IVIRefID;  
  
		entity.IVIRefType = inputItem.IVIRefType;  
  
		entity.IVIFormulRef = inputItem.IVIFormulRef;  
  
		entity.IVIDL5Ref = inputItem.IVIDL5Ref;  
  
		entity.IVIDL6Ref = inputItem.IVIDL6Ref; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchItmDto Map(InvVchItm inputItem)
        {
            var dto = new InvVchItmDto()
            {
                  
  
		InvVchItmId = inputItem.InvVchItmId,  
  
		InvVchHdrRef = inputItem.InvVchHdrRef,  
  
		IVISeq = inputItem.IVISeq,  
  
		IVIPartRef = inputItem.IVIPartRef,  
  
		IVIUnitRef = inputItem.IVIUnitRef,  
  
		IVIMainQty = inputItem.IVIMainQty,  
  
		IVIOthQty = inputItem.IVIOthQty,  
  
		IVIDescr = inputItem.IVIDescr,  
  
		IVIDLRef = inputItem.IVIDLRef,  
  
		IVISLRef = inputItem.IVISLRef,  
  
		IVIRefID = inputItem.IVIRefID,  
  
		IVIRefType = inputItem.IVIRefType,  
  
		IVIFormulRef = inputItem.IVIFormulRef,  
  
		IVIDL5Ref = inputItem.IVIDL5Ref,  
  
		IVIDL6Ref = inputItem.IVIDL6Ref, 
            };
            return dto;
        }

        public static List<InvVchItmDto> Map(ICollection<InvVchItm> entities)
        {
            var dtos = new List<InvVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchItmDto()
                {
                      
  
		InvVchItmId = inputItem.InvVchItmId,  
  
		InvVchHdrRef = inputItem.InvVchHdrRef,  
  
		IVISeq = inputItem.IVISeq,  
  
		IVIPartRef = inputItem.IVIPartRef,  
  
		IVIUnitRef = inputItem.IVIUnitRef,  
  
		IVIMainQty = inputItem.IVIMainQty,  
  
		IVIOthQty = inputItem.IVIOthQty,  
  
		IVIDescr = inputItem.IVIDescr,  
  
		IVIDLRef = inputItem.IVIDLRef,  
  
		IVISLRef = inputItem.IVISLRef,  
  
		IVIRefID = inputItem.IVIRefID,  
  
		IVIRefType = inputItem.IVIRefType,  
  
		IVIFormulRef = inputItem.IVIFormulRef,  
  
		IVIDL5Ref = inputItem.IVIDL5Ref,  
  
		IVIDL6Ref = inputItem.IVIDL6Ref, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchItmRate Map(AddInvVchItmRateCommand inputItem)
        {
            var entity = new InvVchItmRate() {
                  
  
		InvItmRateId = inputItem.InvItmRateId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVRType = inputItem.IVRType,  
  
		IVRDescr = inputItem.IVRDescr,  
  
		IVRMainAmount = inputItem.IVRMainAmount,  
  
		IVRDate = inputItem.IVRDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchItmRate Map(InvVchItmRate entity ,EditInvVchItmRateCommand inputItem)
        {
              
  
		entity.InvItmRateId = inputItem.InvItmRateId;  
  
		entity.InvVchItmRef = inputItem.InvVchItmRef;  
  
		entity.IVRType = inputItem.IVRType;  
  
		entity.IVRDescr = inputItem.IVRDescr;  
  
		entity.IVRMainAmount = inputItem.IVRMainAmount;  
  
		entity.IVRDate = inputItem.IVRDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchItmRateDto Map(InvVchItmRate inputItem)
        {
            var dto = new InvVchItmRateDto()
            {
                  
  
		InvItmRateId = inputItem.InvItmRateId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVRType = inputItem.IVRType,  
  
		IVRDescr = inputItem.IVRDescr,  
  
		IVRMainAmount = inputItem.IVRMainAmount,  
  
		IVRDate = inputItem.IVRDate, 
            };
            return dto;
        }

        public static List<InvVchItmRateDto> Map(ICollection<InvVchItmRate> entities)
        {
            var dtos = new List<InvVchItmRateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchItmRateDto()
                {
                      
  
		InvItmRateId = inputItem.InvItmRateId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVRType = inputItem.IVRType,  
  
		IVRDescr = inputItem.IVRDescr,  
  
		IVRMainAmount = inputItem.IVRMainAmount,  
  
		IVRDate = inputItem.IVRDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchQtyVal Map(AddInvVchQtyValCommand inputItem)
        {
            var entity = new InvVchQtyVal() {
                  
  
		InvVchQtyValId = inputItem.InvVchQtyValId,  
  
		IVQVchItmRef = inputItem.IVQVchItmRef,  
  
		IVQPrjRef = inputItem.IVQPrjRef,  
  
		IVQDLRef = inputItem.IVQDLRef,  
  
		IVQProductRef = inputItem.IVQProductRef,  
  
		IVQOthVal = inputItem.IVQOthVal,  
  
		IVQOthDate = inputItem.IVQOthDate,  
  
		IVQQty = inputItem.IVQQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchQtyVal Map(InvVchQtyVal entity ,EditInvVchQtyValCommand inputItem)
        {
              
  
		entity.InvVchQtyValId = inputItem.InvVchQtyValId;  
  
		entity.IVQVchItmRef = inputItem.IVQVchItmRef;  
  
		entity.IVQPrjRef = inputItem.IVQPrjRef;  
  
		entity.IVQDLRef = inputItem.IVQDLRef;  
  
		entity.IVQProductRef = inputItem.IVQProductRef;  
  
		entity.IVQOthVal = inputItem.IVQOthVal;  
  
		entity.IVQOthDate = inputItem.IVQOthDate;  
  
		entity.IVQQty = inputItem.IVQQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchQtyValDto Map(InvVchQtyVal inputItem)
        {
            var dto = new InvVchQtyValDto()
            {
                  
  
		InvVchQtyValId = inputItem.InvVchQtyValId,  
  
		IVQVchItmRef = inputItem.IVQVchItmRef,  
  
		IVQPrjRef = inputItem.IVQPrjRef,  
  
		IVQDLRef = inputItem.IVQDLRef,  
  
		IVQProductRef = inputItem.IVQProductRef,  
  
		IVQOthVal = inputItem.IVQOthVal,  
  
		IVQOthDate = inputItem.IVQOthDate,  
  
		IVQQty = inputItem.IVQQty, 
            };
            return dto;
        }

        public static List<InvVchQtyValDto> Map(ICollection<InvVchQtyVal> entities)
        {
            var dtos = new List<InvVchQtyValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchQtyValDto()
                {
                      
  
		InvVchQtyValId = inputItem.InvVchQtyValId,  
  
		IVQVchItmRef = inputItem.IVQVchItmRef,  
  
		IVQPrjRef = inputItem.IVQPrjRef,  
  
		IVQDLRef = inputItem.IVQDLRef,  
  
		IVQProductRef = inputItem.IVQProductRef,  
  
		IVQOthVal = inputItem.IVQOthVal,  
  
		IVQOthDate = inputItem.IVQOthDate,  
  
		IVQQty = inputItem.IVQQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchTrans Map(AddInvVchTransCommand inputItem)
        {
            var entity = new InvVchTrans() {
                  
  
		InvVchTransId = inputItem.InvVchTransId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVTNum = inputItem.IVTNum,  
  
		IVTDater = inputItem.IVTDater,  
  
		IVTQty = inputItem.IVTQty,  
  
		IVTDriver = inputItem.IVTDriver,  
  
		IVTCarNo = inputItem.IVTCarNo,  
  
		IVTDescr = inputItem.IVTDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchTrans Map(InvVchTrans entity ,EditInvVchTransCommand inputItem)
        {
              
  
		entity.InvVchTransId = inputItem.InvVchTransId;  
  
		entity.InvVchItmRef = inputItem.InvVchItmRef;  
  
		entity.IVTNum = inputItem.IVTNum;  
  
		entity.IVTDater = inputItem.IVTDater;  
  
		entity.IVTQty = inputItem.IVTQty;  
  
		entity.IVTDriver = inputItem.IVTDriver;  
  
		entity.IVTCarNo = inputItem.IVTCarNo;  
  
		entity.IVTDescr = inputItem.IVTDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchTransDto Map(InvVchTrans inputItem)
        {
            var dto = new InvVchTransDto()
            {
                  
  
		InvVchTransId = inputItem.InvVchTransId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVTNum = inputItem.IVTNum,  
  
		IVTDater = inputItem.IVTDater,  
  
		IVTQty = inputItem.IVTQty,  
  
		IVTDriver = inputItem.IVTDriver,  
  
		IVTCarNo = inputItem.IVTCarNo,  
  
		IVTDescr = inputItem.IVTDescr, 
            };
            return dto;
        }

        public static List<InvVchTransDto> Map(ICollection<InvVchTrans> entities)
        {
            var dtos = new List<InvVchTransDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchTransDto()
                {
                      
  
		InvVchTransId = inputItem.InvVchTransId,  
  
		InvVchItmRef = inputItem.InvVchItmRef,  
  
		IVTNum = inputItem.IVTNum,  
  
		IVTDater = inputItem.IVTDater,  
  
		IVTQty = inputItem.IVTQty,  
  
		IVTDriver = inputItem.IVTDriver,  
  
		IVTCarNo = inputItem.IVTCarNo,  
  
		IVTDescr = inputItem.IVTDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvVchTypes Map(AddInvVchTypesCommand inputItem)
        {
            var entity = new InvVchTypes() {
                  
  
		InvVchTypeId = inputItem.InvVchTypeId,  
  
		IVTDescr = inputItem.IVTDescr,  
  
		IVTDLType = inputItem.IVTDLType,  
  
		IVTPricingType = inputItem.IVTPricingType,  
  
		IVTOpsAutoVch = inputItem.IVTOpsAutoVch,  
  
		IVTOAVStockRef = inputItem.IVTOAVStockRef,  
  
		IVTOAVDLRef = inputItem.IVTOAVDLRef,  
  
		IVTPartLimit = inputItem.IVTPartLimit,  
  
		IVTBaseLimit = inputItem.IVTBaseLimit,  
  
		IVTShopRel = inputItem.IVTShopRel, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvVchTypes Map(InvVchTypes entity ,EditInvVchTypesCommand inputItem)
        {
              
  
		entity.InvVchTypeId = inputItem.InvVchTypeId;  
  
		entity.IVTDescr = inputItem.IVTDescr;  
  
		entity.IVTDLType = inputItem.IVTDLType;  
  
		entity.IVTPricingType = inputItem.IVTPricingType;  
  
		entity.IVTOpsAutoVch = inputItem.IVTOpsAutoVch;  
  
		entity.IVTOAVStockRef = inputItem.IVTOAVStockRef;  
  
		entity.IVTOAVDLRef = inputItem.IVTOAVDLRef;  
  
		entity.IVTPartLimit = inputItem.IVTPartLimit;  
  
		entity.IVTBaseLimit = inputItem.IVTBaseLimit;  
  
		entity.IVTShopRel = inputItem.IVTShopRel; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvVchTypesDto Map(InvVchTypes inputItem)
        {
            var dto = new InvVchTypesDto()
            {
                  
  
		InvVchTypeId = inputItem.InvVchTypeId,  
  
		IVTDescr = inputItem.IVTDescr,  
  
		IVTDLType = inputItem.IVTDLType,  
  
		IVTPricingType = inputItem.IVTPricingType,  
  
		IVTOpsAutoVch = inputItem.IVTOpsAutoVch,  
  
		IVTOAVStockRef = inputItem.IVTOAVStockRef,  
  
		IVTOAVDLRef = inputItem.IVTOAVDLRef,  
  
		IVTPartLimit = inputItem.IVTPartLimit,  
  
		IVTBaseLimit = inputItem.IVTBaseLimit,  
  
		IVTShopRel = inputItem.IVTShopRel, 
            };
            return dto;
        }

        public static List<InvVchTypesDto> Map(ICollection<InvVchTypes> entities)
        {
            var dtos = new List<InvVchTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvVchTypesDto()
                {
                      
  
		InvVchTypeId = inputItem.InvVchTypeId,  
  
		IVTDescr = inputItem.IVTDescr,  
  
		IVTDLType = inputItem.IVTDLType,  
  
		IVTPricingType = inputItem.IVTPricingType,  
  
		IVTOpsAutoVch = inputItem.IVTOpsAutoVch,  
  
		IVTOAVStockRef = inputItem.IVTOAVStockRef,  
  
		IVTOAVDLRef = inputItem.IVTOAVDLRef,  
  
		IVTPartLimit = inputItem.IVTPartLimit,  
  
		IVTBaseLimit = inputItem.IVTBaseLimit,  
  
		IVTShopRel = inputItem.IVTShopRel, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
