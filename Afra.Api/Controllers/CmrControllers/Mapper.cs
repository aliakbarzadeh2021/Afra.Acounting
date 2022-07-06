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
                
        
        public static CmrContHdr Map(AddCmrContHdrCommand inputItem)
        {
            var entity = new CmrContHdr() {
                  
  
		CmrContHdrId = inputItem.CmrContHdrId,  
  
		CCHNum = inputItem.CCHNum,  
  
		CCHDate = inputItem.CCHDate,  
  
		CCHSellerRef = inputItem.CCHSellerRef,  
  
		CCHDescr = inputItem.CCHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CCHState = inputItem.CCHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CCHRefID = inputItem.CCHRefID,  
  
		CCHRefType = inputItem.CCHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrContHdr Map(CmrContHdr entity ,EditCmrContHdrCommand inputItem)
        {
              
  
		entity.CmrContHdrId = inputItem.CmrContHdrId;  
  
		entity.CCHNum = inputItem.CCHNum;  
  
		entity.CCHDate = inputItem.CCHDate;  
  
		entity.CCHSellerRef = inputItem.CCHSellerRef;  
  
		entity.CCHDescr = inputItem.CCHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CCHState = inputItem.CCHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CCHRefID = inputItem.CCHRefID;  
  
		entity.CCHRefType = inputItem.CCHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrContHdrDto Map(CmrContHdr inputItem)
        {
            var dto = new CmrContHdrDto()
            {
                  
  
		CmrContHdrId = inputItem.CmrContHdrId,  
  
		CCHNum = inputItem.CCHNum,  
  
		CCHDate = inputItem.CCHDate,  
  
		CCHSellerRef = inputItem.CCHSellerRef,  
  
		CCHDescr = inputItem.CCHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CCHState = inputItem.CCHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CCHRefID = inputItem.CCHRefID,  
  
		CCHRefType = inputItem.CCHRefType, 
            };
            return dto;
        }

        public static List<CmrContHdrDto> Map(ICollection<CmrContHdr> entities)
        {
            var dtos = new List<CmrContHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrContHdrDto()
                {
                      
  
		CmrContHdrId = inputItem.CmrContHdrId,  
  
		CCHNum = inputItem.CCHNum,  
  
		CCHDate = inputItem.CCHDate,  
  
		CCHSellerRef = inputItem.CCHSellerRef,  
  
		CCHDescr = inputItem.CCHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CCHState = inputItem.CCHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CCHRefID = inputItem.CCHRefID,  
  
		CCHRefType = inputItem.CCHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrContItm Map(AddCmrContItmCommand inputItem)
        {
            var entity = new CmrContItm() {
                  
  
		CmrContItmId = inputItem.CmrContItmId,  
  
		CCISeq = inputItem.CCISeq,  
  
		CmrContHdrRef = inputItem.CmrContHdrRef,  
  
		CCIPartRef = inputItem.CCIPartRef,  
  
		CCIUnitRef = inputItem.CCIUnitRef,  
  
		CCIMainQty = inputItem.CCIMainQty,  
  
		CCIRate = inputItem.CCIRate,  
  
		CCIDescr = inputItem.CCIDescr,  
  
		CCIStatus = inputItem.CCIStatus,  
  
		CCIRefType = inputItem.CCIRefType,  
  
		CCIRefId = inputItem.CCIRefId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrContItm Map(CmrContItm entity ,EditCmrContItmCommand inputItem)
        {
              
  
		entity.CmrContItmId = inputItem.CmrContItmId;  
  
		entity.CCISeq = inputItem.CCISeq;  
  
		entity.CmrContHdrRef = inputItem.CmrContHdrRef;  
  
		entity.CCIPartRef = inputItem.CCIPartRef;  
  
		entity.CCIUnitRef = inputItem.CCIUnitRef;  
  
		entity.CCIMainQty = inputItem.CCIMainQty;  
  
		entity.CCIRate = inputItem.CCIRate;  
  
		entity.CCIDescr = inputItem.CCIDescr;  
  
		entity.CCIStatus = inputItem.CCIStatus;  
  
		entity.CCIRefType = inputItem.CCIRefType;  
  
		entity.CCIRefId = inputItem.CCIRefId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrContItmDto Map(CmrContItm inputItem)
        {
            var dto = new CmrContItmDto()
            {
                  
  
		CmrContItmId = inputItem.CmrContItmId,  
  
		CCISeq = inputItem.CCISeq,  
  
		CmrContHdrRef = inputItem.CmrContHdrRef,  
  
		CCIPartRef = inputItem.CCIPartRef,  
  
		CCIUnitRef = inputItem.CCIUnitRef,  
  
		CCIMainQty = inputItem.CCIMainQty,  
  
		CCIRate = inputItem.CCIRate,  
  
		CCIDescr = inputItem.CCIDescr,  
  
		CCIStatus = inputItem.CCIStatus,  
  
		CCIRefType = inputItem.CCIRefType,  
  
		CCIRefId = inputItem.CCIRefId, 
            };
            return dto;
        }

        public static List<CmrContItmDto> Map(ICollection<CmrContItm> entities)
        {
            var dtos = new List<CmrContItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrContItmDto()
                {
                      
  
		CmrContItmId = inputItem.CmrContItmId,  
  
		CCISeq = inputItem.CCISeq,  
  
		CmrContHdrRef = inputItem.CmrContHdrRef,  
  
		CCIPartRef = inputItem.CCIPartRef,  
  
		CCIUnitRef = inputItem.CCIUnitRef,  
  
		CCIMainQty = inputItem.CCIMainQty,  
  
		CCIRate = inputItem.CCIRate,  
  
		CCIDescr = inputItem.CCIDescr,  
  
		CCIStatus = inputItem.CCIStatus,  
  
		CCIRefType = inputItem.CCIRefType,  
  
		CCIRefId = inputItem.CCIRefId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrFactHdr Map(AddCmrFactHdrCommand inputItem)
        {
            var entity = new CmrFactHdr() {
                  
  
		CmrFactHdrId = inputItem.CmrFactHdrId,  
  
		CFHNum = inputItem.CFHNum,  
  
		CFHLocalNum = inputItem.CFHLocalNum,  
  
		CFHPOrdRef = inputItem.CFHPOrdRef,  
  
		CFHDate = inputItem.CFHDate,  
  
		CFHDescr = inputItem.CFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CFHState = inputItem.CFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CFHSellerRef = inputItem.CFHSellerRef,  
  
		CFHCurRef = inputItem.CFHCurRef,  
  
		CFHCurRate = inputItem.CFHCurRate,  
  
		CFHTransType = inputItem.CFHTransType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrFactHdr Map(CmrFactHdr entity ,EditCmrFactHdrCommand inputItem)
        {
              
  
		entity.CmrFactHdrId = inputItem.CmrFactHdrId;  
  
		entity.CFHNum = inputItem.CFHNum;  
  
		entity.CFHLocalNum = inputItem.CFHLocalNum;  
  
		entity.CFHPOrdRef = inputItem.CFHPOrdRef;  
  
		entity.CFHDate = inputItem.CFHDate;  
  
		entity.CFHDescr = inputItem.CFHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CFHState = inputItem.CFHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CFHSellerRef = inputItem.CFHSellerRef;  
  
		entity.CFHCurRef = inputItem.CFHCurRef;  
  
		entity.CFHCurRate = inputItem.CFHCurRate;  
  
		entity.CFHTransType = inputItem.CFHTransType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrFactHdrDto Map(CmrFactHdr inputItem)
        {
            var dto = new CmrFactHdrDto()
            {
                  
  
		CmrFactHdrId = inputItem.CmrFactHdrId,  
  
		CFHNum = inputItem.CFHNum,  
  
		CFHLocalNum = inputItem.CFHLocalNum,  
  
		CFHPOrdRef = inputItem.CFHPOrdRef,  
  
		CFHDate = inputItem.CFHDate,  
  
		CFHDescr = inputItem.CFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CFHState = inputItem.CFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CFHSellerRef = inputItem.CFHSellerRef,  
  
		CFHCurRef = inputItem.CFHCurRef,  
  
		CFHCurRate = inputItem.CFHCurRate,  
  
		CFHTransType = inputItem.CFHTransType, 
            };
            return dto;
        }

        public static List<CmrFactHdrDto> Map(ICollection<CmrFactHdr> entities)
        {
            var dtos = new List<CmrFactHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrFactHdrDto()
                {
                      
  
		CmrFactHdrId = inputItem.CmrFactHdrId,  
  
		CFHNum = inputItem.CFHNum,  
  
		CFHLocalNum = inputItem.CFHLocalNum,  
  
		CFHPOrdRef = inputItem.CFHPOrdRef,  
  
		CFHDate = inputItem.CFHDate,  
  
		CFHDescr = inputItem.CFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CFHState = inputItem.CFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CFHSellerRef = inputItem.CFHSellerRef,  
  
		CFHCurRef = inputItem.CFHCurRef,  
  
		CFHCurRate = inputItem.CFHCurRate,  
  
		CFHTransType = inputItem.CFHTransType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrFactItm Map(AddCmrFactItmCommand inputItem)
        {
            var entity = new CmrFactItm() {
                  
  
		CmrFactItmId = inputItem.CmrFactItmId,  
  
		CFISeq = inputItem.CFISeq,  
  
		CmrFactHdrRef = inputItem.CmrFactHdrRef,  
  
		CFIItmType = inputItem.CFIItmType,  
  
		CFIItmRef = inputItem.CFIItmRef,  
  
		CFIOthQty = inputItem.CFIOthQty,  
  
		CFIMainQty = inputItem.CFIMainQty,  
  
		CFIAmount = inputItem.CFIAmount,  
  
		CFIIncAmnt = inputItem.CFIIncAmnt,  
  
		CFIDecAmnt = inputItem.CFIDecAmnt,  
  
		CFIDescr = inputItem.CFIDescr,  
  
		CFIStatus = inputItem.CFIStatus, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrFactItm Map(CmrFactItm entity ,EditCmrFactItmCommand inputItem)
        {
              
  
		entity.CmrFactItmId = inputItem.CmrFactItmId;  
  
		entity.CFISeq = inputItem.CFISeq;  
  
		entity.CmrFactHdrRef = inputItem.CmrFactHdrRef;  
  
		entity.CFIItmType = inputItem.CFIItmType;  
  
		entity.CFIItmRef = inputItem.CFIItmRef;  
  
		entity.CFIOthQty = inputItem.CFIOthQty;  
  
		entity.CFIMainQty = inputItem.CFIMainQty;  
  
		entity.CFIAmount = inputItem.CFIAmount;  
  
		entity.CFIIncAmnt = inputItem.CFIIncAmnt;  
  
		entity.CFIDecAmnt = inputItem.CFIDecAmnt;  
  
		entity.CFIDescr = inputItem.CFIDescr;  
  
		entity.CFIStatus = inputItem.CFIStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrFactItmDto Map(CmrFactItm inputItem)
        {
            var dto = new CmrFactItmDto()
            {
                  
  
		CmrFactItmId = inputItem.CmrFactItmId,  
  
		CFISeq = inputItem.CFISeq,  
  
		CmrFactHdrRef = inputItem.CmrFactHdrRef,  
  
		CFIItmType = inputItem.CFIItmType,  
  
		CFIItmRef = inputItem.CFIItmRef,  
  
		CFIOthQty = inputItem.CFIOthQty,  
  
		CFIMainQty = inputItem.CFIMainQty,  
  
		CFIAmount = inputItem.CFIAmount,  
  
		CFIIncAmnt = inputItem.CFIIncAmnt,  
  
		CFIDecAmnt = inputItem.CFIDecAmnt,  
  
		CFIDescr = inputItem.CFIDescr,  
  
		CFIStatus = inputItem.CFIStatus, 
            };
            return dto;
        }

        public static List<CmrFactItmDto> Map(ICollection<CmrFactItm> entities)
        {
            var dtos = new List<CmrFactItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrFactItmDto()
                {
                      
  
		CmrFactItmId = inputItem.CmrFactItmId,  
  
		CFISeq = inputItem.CFISeq,  
  
		CmrFactHdrRef = inputItem.CmrFactHdrRef,  
  
		CFIItmType = inputItem.CFIItmType,  
  
		CFIItmRef = inputItem.CFIItmRef,  
  
		CFIOthQty = inputItem.CFIOthQty,  
  
		CFIMainQty = inputItem.CFIMainQty,  
  
		CFIAmount = inputItem.CFIAmount,  
  
		CFIIncAmnt = inputItem.CFIIncAmnt,  
  
		CFIDecAmnt = inputItem.CFIDecAmnt,  
  
		CFIDescr = inputItem.CFIDescr,  
  
		CFIStatus = inputItem.CFIStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrInsurance Map(AddCmrInsuranceCommand inputItem)
        {
            var entity = new CmrInsurance() {
                  
  
		CmrInsuranceId = inputItem.CmrInsuranceId,  
  
		CINum = inputItem.CINum,  
  
		CIFactRef = inputItem.CIFactRef,  
  
		CICompRef = inputItem.CICompRef,  
  
		CIDate = inputItem.CIDate,  
  
		CIRegDate = inputItem.CIRegDate,  
  
		CIEndDate = inputItem.CIEndDate,  
  
		CIType = inputItem.CIType,  
  
		CIFromLoc = inputItem.CIFromLoc,  
  
		CIToLoc = inputItem.CIToLoc,  
  
		CITransType = inputItem.CITransType,  
  
		CICoverage = inputItem.CICoverage,  
  
		CICoverDescr = inputItem.CICoverDescr,  
  
		CIAllAmnt = inputItem.CIAllAmnt,  
  
		CIInsuAmnt = inputItem.CIInsuAmnt,  
  
		CICurRef = inputItem.CICurRef,  
  
		CICurRate = inputItem.CICurRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrInsurance Map(CmrInsurance entity ,EditCmrInsuranceCommand inputItem)
        {
              
  
		entity.CmrInsuranceId = inputItem.CmrInsuranceId;  
  
		entity.CINum = inputItem.CINum;  
  
		entity.CIFactRef = inputItem.CIFactRef;  
  
		entity.CICompRef = inputItem.CICompRef;  
  
		entity.CIDate = inputItem.CIDate;  
  
		entity.CIRegDate = inputItem.CIRegDate;  
  
		entity.CIEndDate = inputItem.CIEndDate;  
  
		entity.CIType = inputItem.CIType;  
  
		entity.CIFromLoc = inputItem.CIFromLoc;  
  
		entity.CIToLoc = inputItem.CIToLoc;  
  
		entity.CITransType = inputItem.CITransType;  
  
		entity.CICoverage = inputItem.CICoverage;  
  
		entity.CICoverDescr = inputItem.CICoverDescr;  
  
		entity.CIAllAmnt = inputItem.CIAllAmnt;  
  
		entity.CIInsuAmnt = inputItem.CIInsuAmnt;  
  
		entity.CICurRef = inputItem.CICurRef;  
  
		entity.CICurRate = inputItem.CICurRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrInsuranceDto Map(CmrInsurance inputItem)
        {
            var dto = new CmrInsuranceDto()
            {
                  
  
		CmrInsuranceId = inputItem.CmrInsuranceId,  
  
		CINum = inputItem.CINum,  
  
		CIFactRef = inputItem.CIFactRef,  
  
		CICompRef = inputItem.CICompRef,  
  
		CIDate = inputItem.CIDate,  
  
		CIRegDate = inputItem.CIRegDate,  
  
		CIEndDate = inputItem.CIEndDate,  
  
		CIType = inputItem.CIType,  
  
		CIFromLoc = inputItem.CIFromLoc,  
  
		CIToLoc = inputItem.CIToLoc,  
  
		CITransType = inputItem.CITransType,  
  
		CICoverage = inputItem.CICoverage,  
  
		CICoverDescr = inputItem.CICoverDescr,  
  
		CIAllAmnt = inputItem.CIAllAmnt,  
  
		CIInsuAmnt = inputItem.CIInsuAmnt,  
  
		CICurRef = inputItem.CICurRef,  
  
		CICurRate = inputItem.CICurRate, 
            };
            return dto;
        }

        public static List<CmrInsuranceDto> Map(ICollection<CmrInsurance> entities)
        {
            var dtos = new List<CmrInsuranceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrInsuranceDto()
                {
                      
  
		CmrInsuranceId = inputItem.CmrInsuranceId,  
  
		CINum = inputItem.CINum,  
  
		CIFactRef = inputItem.CIFactRef,  
  
		CICompRef = inputItem.CICompRef,  
  
		CIDate = inputItem.CIDate,  
  
		CIRegDate = inputItem.CIRegDate,  
  
		CIEndDate = inputItem.CIEndDate,  
  
		CIType = inputItem.CIType,  
  
		CIFromLoc = inputItem.CIFromLoc,  
  
		CIToLoc = inputItem.CIToLoc,  
  
		CITransType = inputItem.CITransType,  
  
		CICoverage = inputItem.CICoverage,  
  
		CICoverDescr = inputItem.CICoverDescr,  
  
		CIAllAmnt = inputItem.CIAllAmnt,  
  
		CIInsuAmnt = inputItem.CIInsuAmnt,  
  
		CICurRef = inputItem.CICurRef,  
  
		CICurRate = inputItem.CICurRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrInvoiceCost Map(AddCmrInvoiceCostCommand inputItem)
        {
            var entity = new CmrInvoiceCost() {
                  
  
		CmrInvoiceCostId = inputItem.CmrInvoiceCostId,  
  
		CICItmRef = inputItem.CICItmRef,  
  
		CICDescr = inputItem.CICDescr,  
  
		CICAmount = inputItem.CICAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrInvoiceCost Map(CmrInvoiceCost entity ,EditCmrInvoiceCostCommand inputItem)
        {
              
  
		entity.CmrInvoiceCostId = inputItem.CmrInvoiceCostId;  
  
		entity.CICItmRef = inputItem.CICItmRef;  
  
		entity.CICDescr = inputItem.CICDescr;  
  
		entity.CICAmount = inputItem.CICAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrInvoiceCostDto Map(CmrInvoiceCost inputItem)
        {
            var dto = new CmrInvoiceCostDto()
            {
                  
  
		CmrInvoiceCostId = inputItem.CmrInvoiceCostId,  
  
		CICItmRef = inputItem.CICItmRef,  
  
		CICDescr = inputItem.CICDescr,  
  
		CICAmount = inputItem.CICAmount, 
            };
            return dto;
        }

        public static List<CmrInvoiceCostDto> Map(ICollection<CmrInvoiceCost> entities)
        {
            var dtos = new List<CmrInvoiceCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrInvoiceCostDto()
                {
                      
  
		CmrInvoiceCostId = inputItem.CmrInvoiceCostId,  
  
		CICItmRef = inputItem.CICItmRef,  
  
		CICDescr = inputItem.CICDescr,  
  
		CICAmount = inputItem.CICAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrInvoiceHdr Map(AddCmrInvoiceHdrCommand inputItem)
        {
            var entity = new CmrInvoiceHdr() {
                  
  
		CmrInvoiceHdrId = inputItem.CmrInvoiceHdrId,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHLocalNum = inputItem.CIHLocalNum,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHDescr = inputItem.CIHDescr,  
  
		CIHSellerRef = inputItem.CIHSellerRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CIHState = inputItem.CIHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CIHRefID = inputItem.CIHRefID,  
  
		CIHRefType = inputItem.CIHRefType,  
  
		CIHCurRef = inputItem.CIHCurRef,  
  
		CIHCurRate = inputItem.CIHCurRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrInvoiceHdr Map(CmrInvoiceHdr entity ,EditCmrInvoiceHdrCommand inputItem)
        {
              
  
		entity.CmrInvoiceHdrId = inputItem.CmrInvoiceHdrId;  
  
		entity.CIHNum = inputItem.CIHNum;  
  
		entity.CIHLocalNum = inputItem.CIHLocalNum;  
  
		entity.CIHDate = inputItem.CIHDate;  
  
		entity.CIHDescr = inputItem.CIHDescr;  
  
		entity.CIHSellerRef = inputItem.CIHSellerRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CIHState = inputItem.CIHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CIHRefID = inputItem.CIHRefID;  
  
		entity.CIHRefType = inputItem.CIHRefType;  
  
		entity.CIHCurRef = inputItem.CIHCurRef;  
  
		entity.CIHCurRate = inputItem.CIHCurRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrInvoiceHdrDto Map(CmrInvoiceHdr inputItem)
        {
            var dto = new CmrInvoiceHdrDto()
            {
                  
  
		CmrInvoiceHdrId = inputItem.CmrInvoiceHdrId,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHLocalNum = inputItem.CIHLocalNum,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHDescr = inputItem.CIHDescr,  
  
		CIHSellerRef = inputItem.CIHSellerRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CIHState = inputItem.CIHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CIHRefID = inputItem.CIHRefID,  
  
		CIHRefType = inputItem.CIHRefType,  
  
		CIHCurRef = inputItem.CIHCurRef,  
  
		CIHCurRate = inputItem.CIHCurRate, 
            };
            return dto;
        }

        public static List<CmrInvoiceHdrDto> Map(ICollection<CmrInvoiceHdr> entities)
        {
            var dtos = new List<CmrInvoiceHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrInvoiceHdrDto()
                {
                      
  
		CmrInvoiceHdrId = inputItem.CmrInvoiceHdrId,  
  
		CIHNum = inputItem.CIHNum,  
  
		CIHLocalNum = inputItem.CIHLocalNum,  
  
		CIHDate = inputItem.CIHDate,  
  
		CIHDescr = inputItem.CIHDescr,  
  
		CIHSellerRef = inputItem.CIHSellerRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CIHState = inputItem.CIHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CIHRefID = inputItem.CIHRefID,  
  
		CIHRefType = inputItem.CIHRefType,  
  
		CIHCurRef = inputItem.CIHCurRef,  
  
		CIHCurRate = inputItem.CIHCurRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrInvoiceItm Map(AddCmrInvoiceItmCommand inputItem)
        {
            var entity = new CmrInvoiceItm() {
                  
  
		CmrInvoiceItmId = inputItem.CmrInvoiceItmId,  
  
		CIISeq = inputItem.CIISeq,  
  
		CmrInvoiceHdrRef = inputItem.CmrInvoiceHdrRef,  
  
		CIIOthQty = inputItem.CIIOthQty,  
  
		CIIMainQty = inputItem.CIIMainQty,  
  
		CIIDescr = inputItem.CIIDescr,  
  
		CIIStatus = inputItem.CIIStatus,  
  
		CIIRefID = inputItem.CIIRefID,  
  
		CIIRefType = inputItem.CIIRefType,  
  
		CIIBaseType = inputItem.CIIBaseType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrInvoiceItm Map(CmrInvoiceItm entity ,EditCmrInvoiceItmCommand inputItem)
        {
              
  
		entity.CmrInvoiceItmId = inputItem.CmrInvoiceItmId;  
  
		entity.CIISeq = inputItem.CIISeq;  
  
		entity.CmrInvoiceHdrRef = inputItem.CmrInvoiceHdrRef;  
  
		entity.CIIOthQty = inputItem.CIIOthQty;  
  
		entity.CIIMainQty = inputItem.CIIMainQty;  
  
		entity.CIIDescr = inputItem.CIIDescr;  
  
		entity.CIIStatus = inputItem.CIIStatus;  
  
		entity.CIIRefID = inputItem.CIIRefID;  
  
		entity.CIIRefType = inputItem.CIIRefType;  
  
		entity.CIIBaseType = inputItem.CIIBaseType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrInvoiceItmDto Map(CmrInvoiceItm inputItem)
        {
            var dto = new CmrInvoiceItmDto()
            {
                  
  
		CmrInvoiceItmId = inputItem.CmrInvoiceItmId,  
  
		CIISeq = inputItem.CIISeq,  
  
		CmrInvoiceHdrRef = inputItem.CmrInvoiceHdrRef,  
  
		CIIOthQty = inputItem.CIIOthQty,  
  
		CIIMainQty = inputItem.CIIMainQty,  
  
		CIIDescr = inputItem.CIIDescr,  
  
		CIIStatus = inputItem.CIIStatus,  
  
		CIIRefID = inputItem.CIIRefID,  
  
		CIIRefType = inputItem.CIIRefType,  
  
		CIIBaseType = inputItem.CIIBaseType, 
            };
            return dto;
        }

        public static List<CmrInvoiceItmDto> Map(ICollection<CmrInvoiceItm> entities)
        {
            var dtos = new List<CmrInvoiceItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrInvoiceItmDto()
                {
                      
  
		CmrInvoiceItmId = inputItem.CmrInvoiceItmId,  
  
		CIISeq = inputItem.CIISeq,  
  
		CmrInvoiceHdrRef = inputItem.CmrInvoiceHdrRef,  
  
		CIIOthQty = inputItem.CIIOthQty,  
  
		CIIMainQty = inputItem.CIIMainQty,  
  
		CIIDescr = inputItem.CIIDescr,  
  
		CIIStatus = inputItem.CIIStatus,  
  
		CIIRefID = inputItem.CIIRefID,  
  
		CIIRefType = inputItem.CIIRefType,  
  
		CIIBaseType = inputItem.CIIBaseType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrLC Map(AddCmrLCCommand inputItem)
        {
            var entity = new CmrLC() {
                  
  
		CmrLCId = inputItem.CmrLCId,  
  
		CLNum = inputItem.CLNum,  
  
		CLMainBank = inputItem.CLMainBank,  
  
		CLFactRef = inputItem.CLFactRef,  
  
		CLDate = inputItem.CLDate,  
  
		CLIssDate = inputItem.CLIssDate,  
  
		CLAdvDate = inputItem.CLAdvDate,  
  
		CLDescr = inputItem.CLDescr,  
  
		CLBrkBank = inputItem.CLBrkBank,  
  
		CLBankPrePay = inputItem.CLBankPrePay,  
  
		CLTransAmnt = inputItem.CLTransAmnt,  
  
		CLTransLDate = inputItem.CLTransLDate,  
  
		CLAmount = inputItem.CLAmount,  
  
		CLCurRef = inputItem.CLCurRef,  
  
		CLCurRate = inputItem.CLCurRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrLC Map(CmrLC entity ,EditCmrLCCommand inputItem)
        {
              
  
		entity.CmrLCId = inputItem.CmrLCId;  
  
		entity.CLNum = inputItem.CLNum;  
  
		entity.CLMainBank = inputItem.CLMainBank;  
  
		entity.CLFactRef = inputItem.CLFactRef;  
  
		entity.CLDate = inputItem.CLDate;  
  
		entity.CLIssDate = inputItem.CLIssDate;  
  
		entity.CLAdvDate = inputItem.CLAdvDate;  
  
		entity.CLDescr = inputItem.CLDescr;  
  
		entity.CLBrkBank = inputItem.CLBrkBank;  
  
		entity.CLBankPrePay = inputItem.CLBankPrePay;  
  
		entity.CLTransAmnt = inputItem.CLTransAmnt;  
  
		entity.CLTransLDate = inputItem.CLTransLDate;  
  
		entity.CLAmount = inputItem.CLAmount;  
  
		entity.CLCurRef = inputItem.CLCurRef;  
  
		entity.CLCurRate = inputItem.CLCurRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrLCDto Map(CmrLC inputItem)
        {
            var dto = new CmrLCDto()
            {
                  
  
		CmrLCId = inputItem.CmrLCId,  
  
		CLNum = inputItem.CLNum,  
  
		CLMainBank = inputItem.CLMainBank,  
  
		CLFactRef = inputItem.CLFactRef,  
  
		CLDate = inputItem.CLDate,  
  
		CLIssDate = inputItem.CLIssDate,  
  
		CLAdvDate = inputItem.CLAdvDate,  
  
		CLDescr = inputItem.CLDescr,  
  
		CLBrkBank = inputItem.CLBrkBank,  
  
		CLBankPrePay = inputItem.CLBankPrePay,  
  
		CLTransAmnt = inputItem.CLTransAmnt,  
  
		CLTransLDate = inputItem.CLTransLDate,  
  
		CLAmount = inputItem.CLAmount,  
  
		CLCurRef = inputItem.CLCurRef,  
  
		CLCurRate = inputItem.CLCurRate, 
            };
            return dto;
        }

        public static List<CmrLCDto> Map(ICollection<CmrLC> entities)
        {
            var dtos = new List<CmrLCDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrLCDto()
                {
                      
  
		CmrLCId = inputItem.CmrLCId,  
  
		CLNum = inputItem.CLNum,  
  
		CLMainBank = inputItem.CLMainBank,  
  
		CLFactRef = inputItem.CLFactRef,  
  
		CLDate = inputItem.CLDate,  
  
		CLIssDate = inputItem.CLIssDate,  
  
		CLAdvDate = inputItem.CLAdvDate,  
  
		CLDescr = inputItem.CLDescr,  
  
		CLBrkBank = inputItem.CLBrkBank,  
  
		CLBankPrePay = inputItem.CLBankPrePay,  
  
		CLTransAmnt = inputItem.CLTransAmnt,  
  
		CLTransLDate = inputItem.CLTransLDate,  
  
		CLAmount = inputItem.CLAmount,  
  
		CLCurRef = inputItem.CLCurRef,  
  
		CLCurRate = inputItem.CLCurRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrLCDet Map(AddCmrLCDetCommand inputItem)
        {
            var entity = new CmrLCDet() {
                  
  
		CmrLCDetId = inputItem.CmrLCDetId,  
  
		CmrLCRef = inputItem.CmrLCRef,  
  
		CLDDescr = inputItem.CLDDescr,  
  
		CLDAmount = inputItem.CLDAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrLCDet Map(CmrLCDet entity ,EditCmrLCDetCommand inputItem)
        {
              
  
		entity.CmrLCDetId = inputItem.CmrLCDetId;  
  
		entity.CmrLCRef = inputItem.CmrLCRef;  
  
		entity.CLDDescr = inputItem.CLDDescr;  
  
		entity.CLDAmount = inputItem.CLDAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrLCDetDto Map(CmrLCDet inputItem)
        {
            var dto = new CmrLCDetDto()
            {
                  
  
		CmrLCDetId = inputItem.CmrLCDetId,  
  
		CmrLCRef = inputItem.CmrLCRef,  
  
		CLDDescr = inputItem.CLDDescr,  
  
		CLDAmount = inputItem.CLDAmount, 
            };
            return dto;
        }

        public static List<CmrLCDetDto> Map(ICollection<CmrLCDet> entities)
        {
            var dtos = new List<CmrLCDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrLCDetDto()
                {
                      
  
		CmrLCDetId = inputItem.CmrLCDetId,  
  
		CmrLCRef = inputItem.CmrLCRef,  
  
		CLDDescr = inputItem.CLDDescr,  
  
		CLDAmount = inputItem.CLDAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrOrdHdr Map(AddCmrOrdHdrCommand inputItem)
        {
            var entity = new CmrOrdHdr() {
                  
  
		CmrOrdHdrId = inputItem.CmrOrdHdrId,  
  
		COHNum = inputItem.COHNum,  
  
		COHLocalNum = inputItem.COHLocalNum,  
  
		COHDate = inputItem.COHDate,  
  
		COHDescr = inputItem.COHDescr,  
  
		COHBuyType = inputItem.COHBuyType,  
  
		COHPersRef = inputItem.COHPersRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		COHState = inputItem.COHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrOrdHdr Map(CmrOrdHdr entity ,EditCmrOrdHdrCommand inputItem)
        {
              
  
		entity.CmrOrdHdrId = inputItem.CmrOrdHdrId;  
  
		entity.COHNum = inputItem.COHNum;  
  
		entity.COHLocalNum = inputItem.COHLocalNum;  
  
		entity.COHDate = inputItem.COHDate;  
  
		entity.COHDescr = inputItem.COHDescr;  
  
		entity.COHBuyType = inputItem.COHBuyType;  
  
		entity.COHPersRef = inputItem.COHPersRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.COHState = inputItem.COHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrOrdHdrDto Map(CmrOrdHdr inputItem)
        {
            var dto = new CmrOrdHdrDto()
            {
                  
  
		CmrOrdHdrId = inputItem.CmrOrdHdrId,  
  
		COHNum = inputItem.COHNum,  
  
		COHLocalNum = inputItem.COHLocalNum,  
  
		COHDate = inputItem.COHDate,  
  
		COHDescr = inputItem.COHDescr,  
  
		COHBuyType = inputItem.COHBuyType,  
  
		COHPersRef = inputItem.COHPersRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		COHState = inputItem.COHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
            };
            return dto;
        }

        public static List<CmrOrdHdrDto> Map(ICollection<CmrOrdHdr> entities)
        {
            var dtos = new List<CmrOrdHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrOrdHdrDto()
                {
                      
  
		CmrOrdHdrId = inputItem.CmrOrdHdrId,  
  
		COHNum = inputItem.COHNum,  
  
		COHLocalNum = inputItem.COHLocalNum,  
  
		COHDate = inputItem.COHDate,  
  
		COHDescr = inputItem.COHDescr,  
  
		COHBuyType = inputItem.COHBuyType,  
  
		COHPersRef = inputItem.COHPersRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		COHState = inputItem.COHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrOrdItm Map(AddCmrOrdItmCommand inputItem)
        {
            var entity = new CmrOrdItm() {
                  
  
		CmrOrdItmId = inputItem.CmrOrdItmId,  
  
		COISeq = inputItem.COISeq,  
  
		CmrOrdHdrRef = inputItem.CmrOrdHdrRef,  
  
		COIRqstRef = inputItem.COIRqstRef,  
  
		COIOthQty = inputItem.COIOthQty,  
  
		COIMainQty = inputItem.COIMainQty,  
  
		COIAmount = inputItem.COIAmount,  
  
		COIDescr = inputItem.COIDescr,  
  
		COIStatus = inputItem.COIStatus, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrOrdItm Map(CmrOrdItm entity ,EditCmrOrdItmCommand inputItem)
        {
              
  
		entity.CmrOrdItmId = inputItem.CmrOrdItmId;  
  
		entity.COISeq = inputItem.COISeq;  
  
		entity.CmrOrdHdrRef = inputItem.CmrOrdHdrRef;  
  
		entity.COIRqstRef = inputItem.COIRqstRef;  
  
		entity.COIOthQty = inputItem.COIOthQty;  
  
		entity.COIMainQty = inputItem.COIMainQty;  
  
		entity.COIAmount = inputItem.COIAmount;  
  
		entity.COIDescr = inputItem.COIDescr;  
  
		entity.COIStatus = inputItem.COIStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrOrdItmDto Map(CmrOrdItm inputItem)
        {
            var dto = new CmrOrdItmDto()
            {
                  
  
		CmrOrdItmId = inputItem.CmrOrdItmId,  
  
		COISeq = inputItem.COISeq,  
  
		CmrOrdHdrRef = inputItem.CmrOrdHdrRef,  
  
		COIRqstRef = inputItem.COIRqstRef,  
  
		COIOthQty = inputItem.COIOthQty,  
  
		COIMainQty = inputItem.COIMainQty,  
  
		COIAmount = inputItem.COIAmount,  
  
		COIDescr = inputItem.COIDescr,  
  
		COIStatus = inputItem.COIStatus, 
            };
            return dto;
        }

        public static List<CmrOrdItmDto> Map(ICollection<CmrOrdItm> entities)
        {
            var dtos = new List<CmrOrdItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrOrdItmDto()
                {
                      
  
		CmrOrdItmId = inputItem.CmrOrdItmId,  
  
		COISeq = inputItem.COISeq,  
  
		CmrOrdHdrRef = inputItem.CmrOrdHdrRef,  
  
		COIRqstRef = inputItem.COIRqstRef,  
  
		COIOthQty = inputItem.COIOthQty,  
  
		COIMainQty = inputItem.COIMainQty,  
  
		COIAmount = inputItem.COIAmount,  
  
		COIDescr = inputItem.COIDescr,  
  
		COIStatus = inputItem.COIStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrOrdSeller Map(AddCmrOrdSellerCommand inputItem)
        {
            var entity = new CmrOrdSeller() {
                  
  
		COSSellerRef = inputItem.COSSellerRef,  
  
		COSHdrRef = inputItem.COSHdrRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrOrdSeller Map(CmrOrdSeller entity ,EditCmrOrdSellerCommand inputItem)
        {
              
  
		entity.COSSellerRef = inputItem.COSSellerRef;  
  
		entity.COSHdrRef = inputItem.COSHdrRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrOrdSellerDto Map(CmrOrdSeller inputItem)
        {
            var dto = new CmrOrdSellerDto()
            {
                  
  
		COSSellerRef = inputItem.COSSellerRef,  
  
		COSHdrRef = inputItem.COSHdrRef, 
            };
            return dto;
        }

        public static List<CmrOrdSellerDto> Map(ICollection<CmrOrdSeller> entities)
        {
            var dtos = new List<CmrOrdSellerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrOrdSellerDto()
                {
                      
  
		COSSellerRef = inputItem.COSSellerRef,  
  
		COSHdrRef = inputItem.COSHdrRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrPers Map(AddCmrPersCommand inputItem)
        {
            var entity = new CmrPers() {
                  
  
		CmrPersId = inputItem.CmrPersId,  
  
		CPCrspndRef = inputItem.CPCrspndRef,  
  
		CPType = inputItem.CPType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrPers Map(CmrPers entity ,EditCmrPersCommand inputItem)
        {
              
  
		entity.CmrPersId = inputItem.CmrPersId;  
  
		entity.CPCrspndRef = inputItem.CPCrspndRef;  
  
		entity.CPType = inputItem.CPType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrPersDto Map(CmrPers inputItem)
        {
            var dto = new CmrPersDto()
            {
                  
  
		CmrPersId = inputItem.CmrPersId,  
  
		CPCrspndRef = inputItem.CPCrspndRef,  
  
		CPType = inputItem.CPType, 
            };
            return dto;
        }

        public static List<CmrPersDto> Map(ICollection<CmrPers> entities)
        {
            var dtos = new List<CmrPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrPersDto()
                {
                      
  
		CmrPersId = inputItem.CmrPersId,  
  
		CPCrspndRef = inputItem.CPCrspndRef,  
  
		CPType = inputItem.CPType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrPOrderHdr Map(AddCmrPOrderHdrCommand inputItem)
        {
            var entity = new CmrPOrderHdr() {
                  
  
		CmrPOrderHdrId = inputItem.CmrPOrderHdrId,  
  
		CPOHNum = inputItem.CPOHNum,  
  
		CPOHLocalNum = inputItem.CPOHLocalNum,  
  
		CPOHPreFactRef = inputItem.CPOHPreFactRef,  
  
		CPOHDate = inputItem.CPOHDate,  
  
		CPOHDescr = inputItem.CPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPOHState = inputItem.CPOHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CPOHCurRef = inputItem.CPOHCurRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrPOrderHdr Map(CmrPOrderHdr entity ,EditCmrPOrderHdrCommand inputItem)
        {
              
  
		entity.CmrPOrderHdrId = inputItem.CmrPOrderHdrId;  
  
		entity.CPOHNum = inputItem.CPOHNum;  
  
		entity.CPOHLocalNum = inputItem.CPOHLocalNum;  
  
		entity.CPOHPreFactRef = inputItem.CPOHPreFactRef;  
  
		entity.CPOHDate = inputItem.CPOHDate;  
  
		entity.CPOHDescr = inputItem.CPOHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CPOHState = inputItem.CPOHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CPOHCurRef = inputItem.CPOHCurRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrPOrderHdrDto Map(CmrPOrderHdr inputItem)
        {
            var dto = new CmrPOrderHdrDto()
            {
                  
  
		CmrPOrderHdrId = inputItem.CmrPOrderHdrId,  
  
		CPOHNum = inputItem.CPOHNum,  
  
		CPOHLocalNum = inputItem.CPOHLocalNum,  
  
		CPOHPreFactRef = inputItem.CPOHPreFactRef,  
  
		CPOHDate = inputItem.CPOHDate,  
  
		CPOHDescr = inputItem.CPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPOHState = inputItem.CPOHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CPOHCurRef = inputItem.CPOHCurRef, 
            };
            return dto;
        }

        public static List<CmrPOrderHdrDto> Map(ICollection<CmrPOrderHdr> entities)
        {
            var dtos = new List<CmrPOrderHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrPOrderHdrDto()
                {
                      
  
		CmrPOrderHdrId = inputItem.CmrPOrderHdrId,  
  
		CPOHNum = inputItem.CPOHNum,  
  
		CPOHLocalNum = inputItem.CPOHLocalNum,  
  
		CPOHPreFactRef = inputItem.CPOHPreFactRef,  
  
		CPOHDate = inputItem.CPOHDate,  
  
		CPOHDescr = inputItem.CPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPOHState = inputItem.CPOHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CPOHCurRef = inputItem.CPOHCurRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrPOrderItm Map(AddCmrPOrderItmCommand inputItem)
        {
            var entity = new CmrPOrderItm() {
                  
  
		CmrPOrderItmId = inputItem.CmrPOrderItmId,  
  
		CPOISeq = inputItem.CPOISeq,  
  
		CmrPOrderHdrRef = inputItem.CmrPOrderHdrRef,  
  
		CPOIItmType = inputItem.CPOIItmType,  
  
		CPOIItmRef = inputItem.CPOIItmRef,  
  
		CPOIOthQty = inputItem.CPOIOthQty,  
  
		CPOIMainQty = inputItem.CPOIMainQty,  
  
		CPOIDescr = inputItem.CPOIDescr,  
  
		CPOIStatus = inputItem.CPOIStatus, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrPOrderItm Map(CmrPOrderItm entity ,EditCmrPOrderItmCommand inputItem)
        {
              
  
		entity.CmrPOrderItmId = inputItem.CmrPOrderItmId;  
  
		entity.CPOISeq = inputItem.CPOISeq;  
  
		entity.CmrPOrderHdrRef = inputItem.CmrPOrderHdrRef;  
  
		entity.CPOIItmType = inputItem.CPOIItmType;  
  
		entity.CPOIItmRef = inputItem.CPOIItmRef;  
  
		entity.CPOIOthQty = inputItem.CPOIOthQty;  
  
		entity.CPOIMainQty = inputItem.CPOIMainQty;  
  
		entity.CPOIDescr = inputItem.CPOIDescr;  
  
		entity.CPOIStatus = inputItem.CPOIStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrPOrderItmDto Map(CmrPOrderItm inputItem)
        {
            var dto = new CmrPOrderItmDto()
            {
                  
  
		CmrPOrderItmId = inputItem.CmrPOrderItmId,  
  
		CPOISeq = inputItem.CPOISeq,  
  
		CmrPOrderHdrRef = inputItem.CmrPOrderHdrRef,  
  
		CPOIItmType = inputItem.CPOIItmType,  
  
		CPOIItmRef = inputItem.CPOIItmRef,  
  
		CPOIOthQty = inputItem.CPOIOthQty,  
  
		CPOIMainQty = inputItem.CPOIMainQty,  
  
		CPOIDescr = inputItem.CPOIDescr,  
  
		CPOIStatus = inputItem.CPOIStatus, 
            };
            return dto;
        }

        public static List<CmrPOrderItmDto> Map(ICollection<CmrPOrderItm> entities)
        {
            var dtos = new List<CmrPOrderItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrPOrderItmDto()
                {
                      
  
		CmrPOrderItmId = inputItem.CmrPOrderItmId,  
  
		CPOISeq = inputItem.CPOISeq,  
  
		CmrPOrderHdrRef = inputItem.CmrPOrderHdrRef,  
  
		CPOIItmType = inputItem.CPOIItmType,  
  
		CPOIItmRef = inputItem.CPOIItmRef,  
  
		CPOIOthQty = inputItem.CPOIOthQty,  
  
		CPOIMainQty = inputItem.CPOIMainQty,  
  
		CPOIDescr = inputItem.CPOIDescr,  
  
		CPOIStatus = inputItem.CPOIStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrPreFactHdr Map(AddCmrPreFactHdrCommand inputItem)
        {
            var entity = new CmrPreFactHdr() {
                  
  
		CmrPreFactHdrId = inputItem.CmrPreFactHdrId,  
  
		CPFHNum = inputItem.CPFHNum,  
  
		CPFHLocalNum = inputItem.CPFHLocalNum,  
  
		CPFHSellerRef = inputItem.CPFHSellerRef,  
  
		CPFHDate = inputItem.CPFHDate,  
  
		CPFHOrdRef = inputItem.CPFHOrdRef,  
  
		CPFHCurRef = inputItem.CPFHCurRef,  
  
		CPFHCurRate = inputItem.CPFHCurRate,  
  
		CPFHDescr = inputItem.CPFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPFHState = inputItem.CPFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrPreFactHdr Map(CmrPreFactHdr entity ,EditCmrPreFactHdrCommand inputItem)
        {
              
  
		entity.CmrPreFactHdrId = inputItem.CmrPreFactHdrId;  
  
		entity.CPFHNum = inputItem.CPFHNum;  
  
		entity.CPFHLocalNum = inputItem.CPFHLocalNum;  
  
		entity.CPFHSellerRef = inputItem.CPFHSellerRef;  
  
		entity.CPFHDate = inputItem.CPFHDate;  
  
		entity.CPFHOrdRef = inputItem.CPFHOrdRef;  
  
		entity.CPFHCurRef = inputItem.CPFHCurRef;  
  
		entity.CPFHCurRate = inputItem.CPFHCurRate;  
  
		entity.CPFHDescr = inputItem.CPFHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CPFHState = inputItem.CPFHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrPreFactHdrDto Map(CmrPreFactHdr inputItem)
        {
            var dto = new CmrPreFactHdrDto()
            {
                  
  
		CmrPreFactHdrId = inputItem.CmrPreFactHdrId,  
  
		CPFHNum = inputItem.CPFHNum,  
  
		CPFHLocalNum = inputItem.CPFHLocalNum,  
  
		CPFHSellerRef = inputItem.CPFHSellerRef,  
  
		CPFHDate = inputItem.CPFHDate,  
  
		CPFHOrdRef = inputItem.CPFHOrdRef,  
  
		CPFHCurRef = inputItem.CPFHCurRef,  
  
		CPFHCurRate = inputItem.CPFHCurRate,  
  
		CPFHDescr = inputItem.CPFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPFHState = inputItem.CPFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
            };
            return dto;
        }

        public static List<CmrPreFactHdrDto> Map(ICollection<CmrPreFactHdr> entities)
        {
            var dtos = new List<CmrPreFactHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrPreFactHdrDto()
                {
                      
  
		CmrPreFactHdrId = inputItem.CmrPreFactHdrId,  
  
		CPFHNum = inputItem.CPFHNum,  
  
		CPFHLocalNum = inputItem.CPFHLocalNum,  
  
		CPFHSellerRef = inputItem.CPFHSellerRef,  
  
		CPFHDate = inputItem.CPFHDate,  
  
		CPFHOrdRef = inputItem.CPFHOrdRef,  
  
		CPFHCurRef = inputItem.CPFHCurRef,  
  
		CPFHCurRate = inputItem.CPFHCurRate,  
  
		CPFHDescr = inputItem.CPFHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CPFHState = inputItem.CPFHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrPreFactItm Map(AddCmrPreFactItmCommand inputItem)
        {
            var entity = new CmrPreFactItm() {
                  
  
		CmrPreFactItmId = inputItem.CmrPreFactItmId,  
  
		CPFISeq = inputItem.CPFISeq,  
  
		CmrPreFactHdrRef = inputItem.CmrPreFactHdrRef,  
  
		CPFIOrdRef = inputItem.CPFIOrdRef,  
  
		CPFIOthQty = inputItem.CPFIOthQty,  
  
		CPFIMainQty = inputItem.CPFIMainQty,  
  
		CPFIAmount = inputItem.CPFIAmount,  
  
		CPFIIncAmnt = inputItem.CPFIIncAmnt,  
  
		CPFIDecAmnt = inputItem.CPFIDecAmnt,  
  
		CPFIDescr = inputItem.CPFIDescr,  
  
		CPFIStatus = inputItem.CPFIStatus, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrPreFactItm Map(CmrPreFactItm entity ,EditCmrPreFactItmCommand inputItem)
        {
              
  
		entity.CmrPreFactItmId = inputItem.CmrPreFactItmId;  
  
		entity.CPFISeq = inputItem.CPFISeq;  
  
		entity.CmrPreFactHdrRef = inputItem.CmrPreFactHdrRef;  
  
		entity.CPFIOrdRef = inputItem.CPFIOrdRef;  
  
		entity.CPFIOthQty = inputItem.CPFIOthQty;  
  
		entity.CPFIMainQty = inputItem.CPFIMainQty;  
  
		entity.CPFIAmount = inputItem.CPFIAmount;  
  
		entity.CPFIIncAmnt = inputItem.CPFIIncAmnt;  
  
		entity.CPFIDecAmnt = inputItem.CPFIDecAmnt;  
  
		entity.CPFIDescr = inputItem.CPFIDescr;  
  
		entity.CPFIStatus = inputItem.CPFIStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrPreFactItmDto Map(CmrPreFactItm inputItem)
        {
            var dto = new CmrPreFactItmDto()
            {
                  
  
		CmrPreFactItmId = inputItem.CmrPreFactItmId,  
  
		CPFISeq = inputItem.CPFISeq,  
  
		CmrPreFactHdrRef = inputItem.CmrPreFactHdrRef,  
  
		CPFIOrdRef = inputItem.CPFIOrdRef,  
  
		CPFIOthQty = inputItem.CPFIOthQty,  
  
		CPFIMainQty = inputItem.CPFIMainQty,  
  
		CPFIAmount = inputItem.CPFIAmount,  
  
		CPFIIncAmnt = inputItem.CPFIIncAmnt,  
  
		CPFIDecAmnt = inputItem.CPFIDecAmnt,  
  
		CPFIDescr = inputItem.CPFIDescr,  
  
		CPFIStatus = inputItem.CPFIStatus, 
            };
            return dto;
        }

        public static List<CmrPreFactItmDto> Map(ICollection<CmrPreFactItm> entities)
        {
            var dtos = new List<CmrPreFactItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrPreFactItmDto()
                {
                      
  
		CmrPreFactItmId = inputItem.CmrPreFactItmId,  
  
		CPFISeq = inputItem.CPFISeq,  
  
		CmrPreFactHdrRef = inputItem.CmrPreFactHdrRef,  
  
		CPFIOrdRef = inputItem.CPFIOrdRef,  
  
		CPFIOthQty = inputItem.CPFIOthQty,  
  
		CPFIMainQty = inputItem.CPFIMainQty,  
  
		CPFIAmount = inputItem.CPFIAmount,  
  
		CPFIIncAmnt = inputItem.CPFIIncAmnt,  
  
		CPFIDecAmnt = inputItem.CPFIDecAmnt,  
  
		CPFIDescr = inputItem.CPFIDescr,  
  
		CPFIStatus = inputItem.CPFIStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrRegister Map(AddCmrRegisterCommand inputItem)
        {
            var entity = new CmrRegister() {
                  
  
		CmrRegisterId = inputItem.CmrRegisterId,  
  
		CRNum = inputItem.CRNum,  
  
		CRFactRef = inputItem.CRFactRef,  
  
		CRDate = inputItem.CRDate,  
  
		CRCharge = inputItem.CRCharge,  
  
		CRBaseLoc = inputItem.CRBaseLoc,  
  
		CRTransLoc = inputItem.CRTransLoc,  
  
		CREntBorder = inputItem.CREntBorder,  
  
		CRCustoms = inputItem.CRCustoms,  
  
		CRCanQtyTrans = inputItem.CRCanQtyTrans,  
  
		CRTransQty = inputItem.CRTransQty,  
  
		CRTransType = inputItem.CRTransType,  
  
		CRDeliveryDay = inputItem.CRDeliveryDay, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrRegister Map(CmrRegister entity ,EditCmrRegisterCommand inputItem)
        {
              
  
		entity.CmrRegisterId = inputItem.CmrRegisterId;  
  
		entity.CRNum = inputItem.CRNum;  
  
		entity.CRFactRef = inputItem.CRFactRef;  
  
		entity.CRDate = inputItem.CRDate;  
  
		entity.CRCharge = inputItem.CRCharge;  
  
		entity.CRBaseLoc = inputItem.CRBaseLoc;  
  
		entity.CRTransLoc = inputItem.CRTransLoc;  
  
		entity.CREntBorder = inputItem.CREntBorder;  
  
		entity.CRCustoms = inputItem.CRCustoms;  
  
		entity.CRCanQtyTrans = inputItem.CRCanQtyTrans;  
  
		entity.CRTransQty = inputItem.CRTransQty;  
  
		entity.CRTransType = inputItem.CRTransType;  
  
		entity.CRDeliveryDay = inputItem.CRDeliveryDay; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrRegisterDto Map(CmrRegister inputItem)
        {
            var dto = new CmrRegisterDto()
            {
                  
  
		CmrRegisterId = inputItem.CmrRegisterId,  
  
		CRNum = inputItem.CRNum,  
  
		CRFactRef = inputItem.CRFactRef,  
  
		CRDate = inputItem.CRDate,  
  
		CRCharge = inputItem.CRCharge,  
  
		CRBaseLoc = inputItem.CRBaseLoc,  
  
		CRTransLoc = inputItem.CRTransLoc,  
  
		CREntBorder = inputItem.CREntBorder,  
  
		CRCustoms = inputItem.CRCustoms,  
  
		CRCanQtyTrans = inputItem.CRCanQtyTrans,  
  
		CRTransQty = inputItem.CRTransQty,  
  
		CRTransType = inputItem.CRTransType,  
  
		CRDeliveryDay = inputItem.CRDeliveryDay, 
            };
            return dto;
        }

        public static List<CmrRegisterDto> Map(ICollection<CmrRegister> entities)
        {
            var dtos = new List<CmrRegisterDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrRegisterDto()
                {
                      
  
		CmrRegisterId = inputItem.CmrRegisterId,  
  
		CRNum = inputItem.CRNum,  
  
		CRFactRef = inputItem.CRFactRef,  
  
		CRDate = inputItem.CRDate,  
  
		CRCharge = inputItem.CRCharge,  
  
		CRBaseLoc = inputItem.CRBaseLoc,  
  
		CRTransLoc = inputItem.CRTransLoc,  
  
		CREntBorder = inputItem.CREntBorder,  
  
		CRCustoms = inputItem.CRCustoms,  
  
		CRCanQtyTrans = inputItem.CRCanQtyTrans,  
  
		CRTransQty = inputItem.CRTransQty,  
  
		CRTransType = inputItem.CRTransType,  
  
		CRDeliveryDay = inputItem.CRDeliveryDay, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrReleaseCost Map(AddCmrReleaseCostCommand inputItem)
        {
            var entity = new CmrReleaseCost() {
                  
  
		CmrReleaseCostId = inputItem.CmrReleaseCostId,  
  
		CRCItmRef = inputItem.CRCItmRef,  
  
		CRCDescr = inputItem.CRCDescr,  
  
		CRCAmount = inputItem.CRCAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrReleaseCost Map(CmrReleaseCost entity ,EditCmrReleaseCostCommand inputItem)
        {
              
  
		entity.CmrReleaseCostId = inputItem.CmrReleaseCostId;  
  
		entity.CRCItmRef = inputItem.CRCItmRef;  
  
		entity.CRCDescr = inputItem.CRCDescr;  
  
		entity.CRCAmount = inputItem.CRCAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrReleaseCostDto Map(CmrReleaseCost inputItem)
        {
            var dto = new CmrReleaseCostDto()
            {
                  
  
		CmrReleaseCostId = inputItem.CmrReleaseCostId,  
  
		CRCItmRef = inputItem.CRCItmRef,  
  
		CRCDescr = inputItem.CRCDescr,  
  
		CRCAmount = inputItem.CRCAmount, 
            };
            return dto;
        }

        public static List<CmrReleaseCostDto> Map(ICollection<CmrReleaseCost> entities)
        {
            var dtos = new List<CmrReleaseCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrReleaseCostDto()
                {
                      
  
		CmrReleaseCostId = inputItem.CmrReleaseCostId,  
  
		CRCItmRef = inputItem.CRCItmRef,  
  
		CRCDescr = inputItem.CRCDescr,  
  
		CRCAmount = inputItem.CRCAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrReleaseHdr Map(AddCmrReleaseHdrCommand inputItem)
        {
            var entity = new CmrReleaseHdr() {
                  
  
		CmrReleaseHdrId = inputItem.CmrReleaseHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHCrsRef = inputItem.CRHCrsRef,  
  
		CRHDlvrRef = inputItem.CRHDlvrRef,  
  
		CRHEnCustoms = inputItem.CRHEnCustoms,  
  
		CRHRLCustoms = inputItem.CRHRLCustoms,  
  
		CRHAmount = inputItem.CRHAmount,  
  
		CRHGreenInf = inputItem.CRHGreenInf,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrReleaseHdr Map(CmrReleaseHdr entity ,EditCmrReleaseHdrCommand inputItem)
        {
              
  
		entity.CmrReleaseHdrId = inputItem.CmrReleaseHdrId;  
  
		entity.CRHNum = inputItem.CRHNum;  
  
		entity.CRHLocalNum = inputItem.CRHLocalNum;  
  
		entity.CRHDate = inputItem.CRHDate;  
  
		entity.CRHCrsRef = inputItem.CRHCrsRef;  
  
		entity.CRHDlvrRef = inputItem.CRHDlvrRef;  
  
		entity.CRHEnCustoms = inputItem.CRHEnCustoms;  
  
		entity.CRHRLCustoms = inputItem.CRHRLCustoms;  
  
		entity.CRHAmount = inputItem.CRHAmount;  
  
		entity.CRHGreenInf = inputItem.CRHGreenInf;  
  
		entity.CRHDescr = inputItem.CRHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CRHState = inputItem.CRHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CRHRefID = inputItem.CRHRefID;  
  
		entity.CRHRefType = inputItem.CRHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrReleaseHdrDto Map(CmrReleaseHdr inputItem)
        {
            var dto = new CmrReleaseHdrDto()
            {
                  
  
		CmrReleaseHdrId = inputItem.CmrReleaseHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHCrsRef = inputItem.CRHCrsRef,  
  
		CRHDlvrRef = inputItem.CRHDlvrRef,  
  
		CRHEnCustoms = inputItem.CRHEnCustoms,  
  
		CRHRLCustoms = inputItem.CRHRLCustoms,  
  
		CRHAmount = inputItem.CRHAmount,  
  
		CRHGreenInf = inputItem.CRHGreenInf,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
            };
            return dto;
        }

        public static List<CmrReleaseHdrDto> Map(ICollection<CmrReleaseHdr> entities)
        {
            var dtos = new List<CmrReleaseHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrReleaseHdrDto()
                {
                      
  
		CmrReleaseHdrId = inputItem.CmrReleaseHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHCrsRef = inputItem.CRHCrsRef,  
  
		CRHDlvrRef = inputItem.CRHDlvrRef,  
  
		CRHEnCustoms = inputItem.CRHEnCustoms,  
  
		CRHRLCustoms = inputItem.CRHRLCustoms,  
  
		CRHAmount = inputItem.CRHAmount,  
  
		CRHGreenInf = inputItem.CRHGreenInf,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrReleaseItm Map(AddCmrReleaseItmCommand inputItem)
        {
            var entity = new CmrReleaseItm() {
                  
  
		CmrReleaseItmId = inputItem.CmrReleaseItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrReleaseHdrRef = inputItem.CmrReleaseHdrRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRITariffCode = inputItem.CRITariffCode,  
  
		CRITariffAmnt = inputItem.CRITariffAmnt,  
  
		CRITaxAmnt = inputItem.CRITaxAmnt,  
  
		CRIDutyAmnt = inputItem.CRIDutyAmnt,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType,  
  
		CRIBaseType = inputItem.CRIBaseType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrReleaseItm Map(CmrReleaseItm entity ,EditCmrReleaseItmCommand inputItem)
        {
              
  
		entity.CmrReleaseItmId = inputItem.CmrReleaseItmId;  
  
		entity.CRISeq = inputItem.CRISeq;  
  
		entity.CmrReleaseHdrRef = inputItem.CmrReleaseHdrRef;  
  
		entity.CRIOthQty = inputItem.CRIOthQty;  
  
		entity.CRIMainQty = inputItem.CRIMainQty;  
  
		entity.CRITariffCode = inputItem.CRITariffCode;  
  
		entity.CRITariffAmnt = inputItem.CRITariffAmnt;  
  
		entity.CRITaxAmnt = inputItem.CRITaxAmnt;  
  
		entity.CRIDutyAmnt = inputItem.CRIDutyAmnt;  
  
		entity.CRIDescr = inputItem.CRIDescr;  
  
		entity.CRIStatus = inputItem.CRIStatus;  
  
		entity.CRIRefID = inputItem.CRIRefID;  
  
		entity.CRIRefType = inputItem.CRIRefType;  
  
		entity.CRIBaseType = inputItem.CRIBaseType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrReleaseItmDto Map(CmrReleaseItm inputItem)
        {
            var dto = new CmrReleaseItmDto()
            {
                  
  
		CmrReleaseItmId = inputItem.CmrReleaseItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrReleaseHdrRef = inputItem.CmrReleaseHdrRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRITariffCode = inputItem.CRITariffCode,  
  
		CRITariffAmnt = inputItem.CRITariffAmnt,  
  
		CRITaxAmnt = inputItem.CRITaxAmnt,  
  
		CRIDutyAmnt = inputItem.CRIDutyAmnt,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType,  
  
		CRIBaseType = inputItem.CRIBaseType, 
            };
            return dto;
        }

        public static List<CmrReleaseItmDto> Map(ICollection<CmrReleaseItm> entities)
        {
            var dtos = new List<CmrReleaseItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrReleaseItmDto()
                {
                      
  
		CmrReleaseItmId = inputItem.CmrReleaseItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrReleaseHdrRef = inputItem.CmrReleaseHdrRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRITariffCode = inputItem.CRITariffCode,  
  
		CRITariffAmnt = inputItem.CRITariffAmnt,  
  
		CRITaxAmnt = inputItem.CRITaxAmnt,  
  
		CRIDutyAmnt = inputItem.CRIDutyAmnt,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType,  
  
		CRIBaseType = inputItem.CRIBaseType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrReleaseStock Map(AddCmrReleaseStockCommand inputItem)
        {
            var entity = new CmrReleaseStock() {
                  
  
		CmrReleaseStockId = inputItem.CmrReleaseStockId,  
  
		CRSItmRef = inputItem.CRSItmRef,  
  
		CRSNum = inputItem.CRSNum,  
  
		CRSDate = inputItem.CRSDate,  
  
		CRSDescr = inputItem.CRSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrReleaseStock Map(CmrReleaseStock entity ,EditCmrReleaseStockCommand inputItem)
        {
              
  
		entity.CmrReleaseStockId = inputItem.CmrReleaseStockId;  
  
		entity.CRSItmRef = inputItem.CRSItmRef;  
  
		entity.CRSNum = inputItem.CRSNum;  
  
		entity.CRSDate = inputItem.CRSDate;  
  
		entity.CRSDescr = inputItem.CRSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrReleaseStockDto Map(CmrReleaseStock inputItem)
        {
            var dto = new CmrReleaseStockDto()
            {
                  
  
		CmrReleaseStockId = inputItem.CmrReleaseStockId,  
  
		CRSItmRef = inputItem.CRSItmRef,  
  
		CRSNum = inputItem.CRSNum,  
  
		CRSDate = inputItem.CRSDate,  
  
		CRSDescr = inputItem.CRSDescr, 
            };
            return dto;
        }

        public static List<CmrReleaseStockDto> Map(ICollection<CmrReleaseStock> entities)
        {
            var dtos = new List<CmrReleaseStockDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrReleaseStockDto()
                {
                      
  
		CmrReleaseStockId = inputItem.CmrReleaseStockId,  
  
		CRSItmRef = inputItem.CRSItmRef,  
  
		CRSNum = inputItem.CRSNum,  
  
		CRSDate = inputItem.CRSDate,  
  
		CRSDescr = inputItem.CRSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrRqstHdr Map(AddCmrRqstHdrCommand inputItem)
        {
            var entity = new CmrRqstHdr() {
                  
  
		CmrRqstHdrId = inputItem.CmrRqstHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHType = inputItem.CRHType,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHDLRef = inputItem.CRHDLRef,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrRqstHdr Map(CmrRqstHdr entity ,EditCmrRqstHdrCommand inputItem)
        {
              
  
		entity.CmrRqstHdrId = inputItem.CmrRqstHdrId;  
  
		entity.CRHNum = inputItem.CRHNum;  
  
		entity.CRHLocalNum = inputItem.CRHLocalNum;  
  
		entity.CRHType = inputItem.CRHType;  
  
		entity.CRHDate = inputItem.CRHDate;  
  
		entity.CRHDLRef = inputItem.CRHDLRef;  
  
		entity.CRHDescr = inputItem.CRHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CRHState = inputItem.CRHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CRHRefID = inputItem.CRHRefID;  
  
		entity.CRHRefType = inputItem.CRHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrRqstHdrDto Map(CmrRqstHdr inputItem)
        {
            var dto = new CmrRqstHdrDto()
            {
                  
  
		CmrRqstHdrId = inputItem.CmrRqstHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHType = inputItem.CRHType,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHDLRef = inputItem.CRHDLRef,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
            };
            return dto;
        }

        public static List<CmrRqstHdrDto> Map(ICollection<CmrRqstHdr> entities)
        {
            var dtos = new List<CmrRqstHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrRqstHdrDto()
                {
                      
  
		CmrRqstHdrId = inputItem.CmrRqstHdrId,  
  
		CRHNum = inputItem.CRHNum,  
  
		CRHLocalNum = inputItem.CRHLocalNum,  
  
		CRHType = inputItem.CRHType,  
  
		CRHDate = inputItem.CRHDate,  
  
		CRHDLRef = inputItem.CRHDLRef,  
  
		CRHDescr = inputItem.CRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CRHState = inputItem.CRHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CRHRefID = inputItem.CRHRefID,  
  
		CRHRefType = inputItem.CRHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrRqstItm Map(AddCmrRqstItmCommand inputItem)
        {
            var entity = new CmrRqstItm() {
                  
  
		CmrRqstItmId = inputItem.CmrRqstItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrRqstHdrRef = inputItem.CmrRqstHdrRef,  
  
		CRIServiceRef = inputItem.CRIServiceRef,  
  
		CRIPartRef = inputItem.CRIPartRef,  
  
		CRIUnitRef = inputItem.CRIUnitRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRIOfferSeller = inputItem.CRIOfferSeller,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRINeedDate = inputItem.CRINeedDate,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrRqstItm Map(CmrRqstItm entity ,EditCmrRqstItmCommand inputItem)
        {
              
  
		entity.CmrRqstItmId = inputItem.CmrRqstItmId;  
  
		entity.CRISeq = inputItem.CRISeq;  
  
		entity.CmrRqstHdrRef = inputItem.CmrRqstHdrRef;  
  
		entity.CRIServiceRef = inputItem.CRIServiceRef;  
  
		entity.CRIPartRef = inputItem.CRIPartRef;  
  
		entity.CRIUnitRef = inputItem.CRIUnitRef;  
  
		entity.CRIOthQty = inputItem.CRIOthQty;  
  
		entity.CRIMainQty = inputItem.CRIMainQty;  
  
		entity.CRIOfferSeller = inputItem.CRIOfferSeller;  
  
		entity.CRIDescr = inputItem.CRIDescr;  
  
		entity.CRINeedDate = inputItem.CRINeedDate;  
  
		entity.CRIStatus = inputItem.CRIStatus;  
  
		entity.CRIRefID = inputItem.CRIRefID;  
  
		entity.CRIRefType = inputItem.CRIRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrRqstItmDto Map(CmrRqstItm inputItem)
        {
            var dto = new CmrRqstItmDto()
            {
                  
  
		CmrRqstItmId = inputItem.CmrRqstItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrRqstHdrRef = inputItem.CmrRqstHdrRef,  
  
		CRIServiceRef = inputItem.CRIServiceRef,  
  
		CRIPartRef = inputItem.CRIPartRef,  
  
		CRIUnitRef = inputItem.CRIUnitRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRIOfferSeller = inputItem.CRIOfferSeller,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRINeedDate = inputItem.CRINeedDate,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType, 
            };
            return dto;
        }

        public static List<CmrRqstItmDto> Map(ICollection<CmrRqstItm> entities)
        {
            var dtos = new List<CmrRqstItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrRqstItmDto()
                {
                      
  
		CmrRqstItmId = inputItem.CmrRqstItmId,  
  
		CRISeq = inputItem.CRISeq,  
  
		CmrRqstHdrRef = inputItem.CmrRqstHdrRef,  
  
		CRIServiceRef = inputItem.CRIServiceRef,  
  
		CRIPartRef = inputItem.CRIPartRef,  
  
		CRIUnitRef = inputItem.CRIUnitRef,  
  
		CRIOthQty = inputItem.CRIOthQty,  
  
		CRIMainQty = inputItem.CRIMainQty,  
  
		CRIOfferSeller = inputItem.CRIOfferSeller,  
  
		CRIDescr = inputItem.CRIDescr,  
  
		CRINeedDate = inputItem.CRINeedDate,  
  
		CRIStatus = inputItem.CRIStatus,  
  
		CRIRefID = inputItem.CRIRefID,  
  
		CRIRefType = inputItem.CRIRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrSellerGrp Map(AddCmrSellerGrpCommand inputItem)
        {
            var entity = new CmrSellerGrp() {
                  
  
		CmrSellerGrpId = inputItem.CmrSellerGrpId,  
  
		CSGTitle = inputItem.CSGTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrSellerGrp Map(CmrSellerGrp entity ,EditCmrSellerGrpCommand inputItem)
        {
              
  
		entity.CmrSellerGrpId = inputItem.CmrSellerGrpId;  
  
		entity.CSGTitle = inputItem.CSGTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrSellerGrpDto Map(CmrSellerGrp inputItem)
        {
            var dto = new CmrSellerGrpDto()
            {
                  
  
		CmrSellerGrpId = inputItem.CmrSellerGrpId,  
  
		CSGTitle = inputItem.CSGTitle, 
            };
            return dto;
        }

        public static List<CmrSellerGrpDto> Map(ICollection<CmrSellerGrp> entities)
        {
            var dtos = new List<CmrSellerGrpDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrSellerGrpDto()
                {
                      
  
		CmrSellerGrpId = inputItem.CmrSellerGrpId,  
  
		CSGTitle = inputItem.CSGTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrSellers Map(AddCmrSellersCommand inputItem)
        {
            var entity = new CmrSellers() {
                  
  
		CmrSellerId = inputItem.CmrSellerId,  
  
		CSCrspndRef = inputItem.CSCrspndRef,  
  
		CSType = inputItem.CSType,  
  
		CSActive = inputItem.CSActive,  
  
		CSGroupRef = inputItem.CSGroupRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrSellers Map(CmrSellers entity ,EditCmrSellersCommand inputItem)
        {
              
  
		entity.CmrSellerId = inputItem.CmrSellerId;  
  
		entity.CSCrspndRef = inputItem.CSCrspndRef;  
  
		entity.CSType = inputItem.CSType;  
  
		entity.CSActive = inputItem.CSActive;  
  
		entity.CSGroupRef = inputItem.CSGroupRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrSellersDto Map(CmrSellers inputItem)
        {
            var dto = new CmrSellersDto()
            {
                  
  
		CmrSellerId = inputItem.CmrSellerId,  
  
		CSCrspndRef = inputItem.CSCrspndRef,  
  
		CSType = inputItem.CSType,  
  
		CSActive = inputItem.CSActive,  
  
		CSGroupRef = inputItem.CSGroupRef, 
            };
            return dto;
        }

        public static List<CmrSellersDto> Map(ICollection<CmrSellers> entities)
        {
            var dtos = new List<CmrSellersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrSellersDto()
                {
                      
  
		CmrSellerId = inputItem.CmrSellerId,  
  
		CSCrspndRef = inputItem.CSCrspndRef,  
  
		CSType = inputItem.CSType,  
  
		CSActive = inputItem.CSActive,  
  
		CSGroupRef = inputItem.CSGroupRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrSendHdr Map(AddCmrSendHdrCommand inputItem)
        {
            var entity = new CmrSendHdr() {
                  
  
		CmrSendHdrId = inputItem.CmrSendHdrId,  
  
		CSHNum = inputItem.CSHNum,  
  
		CSHLocalNum = inputItem.CSHLocalNum,  
  
		CSHDate = inputItem.CSHDate,  
  
		CSHDescr = inputItem.CSHDescr,  
  
		CSHDlvrRef = inputItem.CSHDlvrRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSHState = inputItem.CSHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CSHRefID = inputItem.CSHRefID,  
  
		CSHRefType = inputItem.CSHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrSendHdr Map(CmrSendHdr entity ,EditCmrSendHdrCommand inputItem)
        {
              
  
		entity.CmrSendHdrId = inputItem.CmrSendHdrId;  
  
		entity.CSHNum = inputItem.CSHNum;  
  
		entity.CSHLocalNum = inputItem.CSHLocalNum;  
  
		entity.CSHDate = inputItem.CSHDate;  
  
		entity.CSHDescr = inputItem.CSHDescr;  
  
		entity.CSHDlvrRef = inputItem.CSHDlvrRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.CSHState = inputItem.CSHState;  
  
		entity.CAccPrdRef = inputItem.CAccPrdRef;  
  
		entity.CSHRefID = inputItem.CSHRefID;  
  
		entity.CSHRefType = inputItem.CSHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrSendHdrDto Map(CmrSendHdr inputItem)
        {
            var dto = new CmrSendHdrDto()
            {
                  
  
		CmrSendHdrId = inputItem.CmrSendHdrId,  
  
		CSHNum = inputItem.CSHNum,  
  
		CSHLocalNum = inputItem.CSHLocalNum,  
  
		CSHDate = inputItem.CSHDate,  
  
		CSHDescr = inputItem.CSHDescr,  
  
		CSHDlvrRef = inputItem.CSHDlvrRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSHState = inputItem.CSHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CSHRefID = inputItem.CSHRefID,  
  
		CSHRefType = inputItem.CSHRefType, 
            };
            return dto;
        }

        public static List<CmrSendHdrDto> Map(ICollection<CmrSendHdr> entities)
        {
            var dtos = new List<CmrSendHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrSendHdrDto()
                {
                      
  
		CmrSendHdrId = inputItem.CmrSendHdrId,  
  
		CSHNum = inputItem.CSHNum,  
  
		CSHLocalNum = inputItem.CSHLocalNum,  
  
		CSHDate = inputItem.CSHDate,  
  
		CSHDescr = inputItem.CSHDescr,  
  
		CSHDlvrRef = inputItem.CSHDlvrRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		CSHState = inputItem.CSHState,  
  
		CAccPrdRef = inputItem.CAccPrdRef,  
  
		CSHRefID = inputItem.CSHRefID,  
  
		CSHRefType = inputItem.CSHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrSendItm Map(AddCmrSendItmCommand inputItem)
        {
            var entity = new CmrSendItm() {
                  
  
		CmrSendItmId = inputItem.CmrSendItmId,  
  
		CSISeq = inputItem.CSISeq,  
  
		CmrSendHdrRef = inputItem.CmrSendHdrRef,  
  
		CSIOthQty = inputItem.CSIOthQty,  
  
		CSIMainQty = inputItem.CSIMainQty,  
  
		CSIDescr = inputItem.CSIDescr,  
  
		CSIStatus = inputItem.CSIStatus,  
  
		CSIRefID = inputItem.CSIRefID,  
  
		CSIRefType = inputItem.CSIRefType,  
  
		CSIBaseType = inputItem.CSIBaseType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrSendItm Map(CmrSendItm entity ,EditCmrSendItmCommand inputItem)
        {
              
  
		entity.CmrSendItmId = inputItem.CmrSendItmId;  
  
		entity.CSISeq = inputItem.CSISeq;  
  
		entity.CmrSendHdrRef = inputItem.CmrSendHdrRef;  
  
		entity.CSIOthQty = inputItem.CSIOthQty;  
  
		entity.CSIMainQty = inputItem.CSIMainQty;  
  
		entity.CSIDescr = inputItem.CSIDescr;  
  
		entity.CSIStatus = inputItem.CSIStatus;  
  
		entity.CSIRefID = inputItem.CSIRefID;  
  
		entity.CSIRefType = inputItem.CSIRefType;  
  
		entity.CSIBaseType = inputItem.CSIBaseType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrSendItmDto Map(CmrSendItm inputItem)
        {
            var dto = new CmrSendItmDto()
            {
                  
  
		CmrSendItmId = inputItem.CmrSendItmId,  
  
		CSISeq = inputItem.CSISeq,  
  
		CmrSendHdrRef = inputItem.CmrSendHdrRef,  
  
		CSIOthQty = inputItem.CSIOthQty,  
  
		CSIMainQty = inputItem.CSIMainQty,  
  
		CSIDescr = inputItem.CSIDescr,  
  
		CSIStatus = inputItem.CSIStatus,  
  
		CSIRefID = inputItem.CSIRefID,  
  
		CSIRefType = inputItem.CSIRefType,  
  
		CSIBaseType = inputItem.CSIBaseType, 
            };
            return dto;
        }

        public static List<CmrSendItmDto> Map(ICollection<CmrSendItm> entities)
        {
            var dtos = new List<CmrSendItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrSendItmDto()
                {
                      
  
		CmrSendItmId = inputItem.CmrSendItmId,  
  
		CSISeq = inputItem.CSISeq,  
  
		CmrSendHdrRef = inputItem.CmrSendHdrRef,  
  
		CSIOthQty = inputItem.CSIOthQty,  
  
		CSIMainQty = inputItem.CSIMainQty,  
  
		CSIDescr = inputItem.CSIDescr,  
  
		CSIStatus = inputItem.CSIStatus,  
  
		CSIRefID = inputItem.CSIRefID,  
  
		CSIRefType = inputItem.CSIRefType,  
  
		CSIBaseType = inputItem.CSIBaseType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrServices Map(AddCmrServicesCommand inputItem)
        {
            var entity = new CmrServices() {
                  
  
		CmrServicesId = inputItem.CmrServicesId,  
  
		CSCode = inputItem.CSCode,  
  
		CSTitle = inputItem.CSTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrServices Map(CmrServices entity ,EditCmrServicesCommand inputItem)
        {
              
  
		entity.CmrServicesId = inputItem.CmrServicesId;  
  
		entity.CSCode = inputItem.CSCode;  
  
		entity.CSTitle = inputItem.CSTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrServicesDto Map(CmrServices inputItem)
        {
            var dto = new CmrServicesDto()
            {
                  
  
		CmrServicesId = inputItem.CmrServicesId,  
  
		CSCode = inputItem.CSCode,  
  
		CSTitle = inputItem.CSTitle, 
            };
            return dto;
        }

        public static List<CmrServicesDto> Map(ICollection<CmrServices> entities)
        {
            var dtos = new List<CmrServicesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrServicesDto()
                {
                      
  
		CmrServicesId = inputItem.CmrServicesId,  
  
		CSCode = inputItem.CSCode,  
  
		CSTitle = inputItem.CSTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrTransport Map(AddCmrTransportCommand inputItem)
        {
            var entity = new CmrTransport() {
                  
  
		CmrTransportId = inputItem.CmrTransportId,  
  
		CTNum = inputItem.CTNum,  
  
		CTInvoiceRef = inputItem.CTInvoiceRef,  
  
		CTCompRef = inputItem.CTCompRef,  
  
		CTDate = inputItem.CTDate,  
  
		CTIssDate = inputItem.CTIssDate,  
  
		CTStartDate = inputItem.CTStartDate,  
  
		CTTransType = inputItem.CTTransType,  
  
		CTFromLoc = inputItem.CTFromLoc,  
  
		CTToLoc = inputItem.CTToLoc,  
  
		CTAmount = inputItem.CTAmount,  
  
		CTCurRef = inputItem.CTCurRef,  
  
		CTCurRate = inputItem.CTCurRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrTransport Map(CmrTransport entity ,EditCmrTransportCommand inputItem)
        {
              
  
		entity.CmrTransportId = inputItem.CmrTransportId;  
  
		entity.CTNum = inputItem.CTNum;  
  
		entity.CTInvoiceRef = inputItem.CTInvoiceRef;  
  
		entity.CTCompRef = inputItem.CTCompRef;  
  
		entity.CTDate = inputItem.CTDate;  
  
		entity.CTIssDate = inputItem.CTIssDate;  
  
		entity.CTStartDate = inputItem.CTStartDate;  
  
		entity.CTTransType = inputItem.CTTransType;  
  
		entity.CTFromLoc = inputItem.CTFromLoc;  
  
		entity.CTToLoc = inputItem.CTToLoc;  
  
		entity.CTAmount = inputItem.CTAmount;  
  
		entity.CTCurRef = inputItem.CTCurRef;  
  
		entity.CTCurRate = inputItem.CTCurRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrTransportDto Map(CmrTransport inputItem)
        {
            var dto = new CmrTransportDto()
            {
                  
  
		CmrTransportId = inputItem.CmrTransportId,  
  
		CTNum = inputItem.CTNum,  
  
		CTInvoiceRef = inputItem.CTInvoiceRef,  
  
		CTCompRef = inputItem.CTCompRef,  
  
		CTDate = inputItem.CTDate,  
  
		CTIssDate = inputItem.CTIssDate,  
  
		CTStartDate = inputItem.CTStartDate,  
  
		CTTransType = inputItem.CTTransType,  
  
		CTFromLoc = inputItem.CTFromLoc,  
  
		CTToLoc = inputItem.CTToLoc,  
  
		CTAmount = inputItem.CTAmount,  
  
		CTCurRef = inputItem.CTCurRef,  
  
		CTCurRate = inputItem.CTCurRate, 
            };
            return dto;
        }

        public static List<CmrTransportDto> Map(ICollection<CmrTransport> entities)
        {
            var dtos = new List<CmrTransportDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrTransportDto()
                {
                      
  
		CmrTransportId = inputItem.CmrTransportId,  
  
		CTNum = inputItem.CTNum,  
  
		CTInvoiceRef = inputItem.CTInvoiceRef,  
  
		CTCompRef = inputItem.CTCompRef,  
  
		CTDate = inputItem.CTDate,  
  
		CTIssDate = inputItem.CTIssDate,  
  
		CTStartDate = inputItem.CTStartDate,  
  
		CTTransType = inputItem.CTTransType,  
  
		CTFromLoc = inputItem.CTFromLoc,  
  
		CTToLoc = inputItem.CTToLoc,  
  
		CTAmount = inputItem.CTAmount,  
  
		CTCurRef = inputItem.CTCurRef,  
  
		CTCurRate = inputItem.CTCurRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CmrTransportDet Map(AddCmrTransportDetCommand inputItem)
        {
            var entity = new CmrTransportDet() {
                  
  
		CmrTransportDetId = inputItem.CmrTransportDetId,  
  
		CTDItmRef = inputItem.CTDItmRef,  
  
		CTDType = inputItem.CTDType,  
  
		CTDQty = inputItem.CTDQty,  
  
		CTDGross = inputItem.CTDGross,  
  
		CTDUnitRef = inputItem.CTDUnitRef,  
  
		CTDVolume = inputItem.CTDVolume,  
  
		CTDVolUnitRef = inputItem.CTDVolUnitRef,  
  
		CTDDescr = inputItem.CTDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CmrTransportDet Map(CmrTransportDet entity ,EditCmrTransportDetCommand inputItem)
        {
              
  
		entity.CmrTransportDetId = inputItem.CmrTransportDetId;  
  
		entity.CTDItmRef = inputItem.CTDItmRef;  
  
		entity.CTDType = inputItem.CTDType;  
  
		entity.CTDQty = inputItem.CTDQty;  
  
		entity.CTDGross = inputItem.CTDGross;  
  
		entity.CTDUnitRef = inputItem.CTDUnitRef;  
  
		entity.CTDVolume = inputItem.CTDVolume;  
  
		entity.CTDVolUnitRef = inputItem.CTDVolUnitRef;  
  
		entity.CTDDescr = inputItem.CTDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CmrTransportDetDto Map(CmrTransportDet inputItem)
        {
            var dto = new CmrTransportDetDto()
            {
                  
  
		CmrTransportDetId = inputItem.CmrTransportDetId,  
  
		CTDItmRef = inputItem.CTDItmRef,  
  
		CTDType = inputItem.CTDType,  
  
		CTDQty = inputItem.CTDQty,  
  
		CTDGross = inputItem.CTDGross,  
  
		CTDUnitRef = inputItem.CTDUnitRef,  
  
		CTDVolume = inputItem.CTDVolume,  
  
		CTDVolUnitRef = inputItem.CTDVolUnitRef,  
  
		CTDDescr = inputItem.CTDDescr, 
            };
            return dto;
        }

        public static List<CmrTransportDetDto> Map(ICollection<CmrTransportDet> entities)
        {
            var dtos = new List<CmrTransportDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CmrTransportDetDto()
                {
                      
  
		CmrTransportDetId = inputItem.CmrTransportDetId,  
  
		CTDItmRef = inputItem.CTDItmRef,  
  
		CTDType = inputItem.CTDType,  
  
		CTDQty = inputItem.CTDQty,  
  
		CTDGross = inputItem.CTDGross,  
  
		CTDUnitRef = inputItem.CTDUnitRef,  
  
		CTDVolume = inputItem.CTDVolume,  
  
		CTDVolUnitRef = inputItem.CTDVolUnitRef,  
  
		CTDDescr = inputItem.CTDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
