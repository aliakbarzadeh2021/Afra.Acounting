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
                
        
        public static PartFormula Map(AddPartFormulaCommand inputItem)
        {
            var entity = new PartFormula() {
                  
  
		PartFormulaId = inputItem.PartFormulaId,  
  
		PFProductRef = inputItem.PFProductRef,  
  
		PFType = inputItem.PFType,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFDate = inputItem.PFDate,  
  
		PFCostPeriod = inputItem.PFCostPeriod,  
  
		PFCostCenter = inputItem.PFCostCenter,  
  
		PFStep = inputItem.PFStep,  
  
		PFQty = inputItem.PFQty,  
  
		PFParent = inputItem.PFParent,  
  
		PFHrmTime = inputItem.PFHrmTime,  
  
		PFHrmCnt = inputItem.PFHrmCnt,  
  
		PFCstTime = inputItem.PFCstTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartFormula Map(PartFormula entity ,EditPartFormulaCommand inputItem)
        {
              
  
		entity.PartFormulaId = inputItem.PartFormulaId;  
  
		entity.PFProductRef = inputItem.PFProductRef;  
  
		entity.PFType = inputItem.PFType;  
  
		entity.PFTitle = inputItem.PFTitle;  
  
		entity.PFDate = inputItem.PFDate;  
  
		entity.PFCostPeriod = inputItem.PFCostPeriod;  
  
		entity.PFCostCenter = inputItem.PFCostCenter;  
  
		entity.PFStep = inputItem.PFStep;  
  
		entity.PFQty = inputItem.PFQty;  
  
		entity.PFParent = inputItem.PFParent;  
  
		entity.PFHrmTime = inputItem.PFHrmTime;  
  
		entity.PFHrmCnt = inputItem.PFHrmCnt;  
  
		entity.PFCstTime = inputItem.PFCstTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartFormulaDto Map(PartFormula inputItem)
        {
            var dto = new PartFormulaDto()
            {
                  
  
		PartFormulaId = inputItem.PartFormulaId,  
  
		PFProductRef = inputItem.PFProductRef,  
  
		PFType = inputItem.PFType,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFDate = inputItem.PFDate,  
  
		PFCostPeriod = inputItem.PFCostPeriod,  
  
		PFCostCenter = inputItem.PFCostCenter,  
  
		PFStep = inputItem.PFStep,  
  
		PFQty = inputItem.PFQty,  
  
		PFParent = inputItem.PFParent,  
  
		PFHrmTime = inputItem.PFHrmTime,  
  
		PFHrmCnt = inputItem.PFHrmCnt,  
  
		PFCstTime = inputItem.PFCstTime, 
            };
            return dto;
        }

        public static List<PartFormulaDto> Map(ICollection<PartFormula> entities)
        {
            var dtos = new List<PartFormulaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartFormulaDto()
                {
                      
  
		PartFormulaId = inputItem.PartFormulaId,  
  
		PFProductRef = inputItem.PFProductRef,  
  
		PFType = inputItem.PFType,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFDate = inputItem.PFDate,  
  
		PFCostPeriod = inputItem.PFCostPeriod,  
  
		PFCostCenter = inputItem.PFCostCenter,  
  
		PFStep = inputItem.PFStep,  
  
		PFQty = inputItem.PFQty,  
  
		PFParent = inputItem.PFParent,  
  
		PFHrmTime = inputItem.PFHrmTime,  
  
		PFHrmCnt = inputItem.PFHrmCnt,  
  
		PFCstTime = inputItem.PFCstTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartFormulaDet Map(AddPartFormulaDetCommand inputItem)
        {
            var entity = new PartFormulaDet() {
                  
  
		PartFrmlDetId = inputItem.PartFrmlDetId,  
  
		PFDHdrRef = inputItem.PFDHdrRef,  
  
		PFDPartRef = inputItem.PFDPartRef,  
  
		PFDQtyRatio = inputItem.PFDQtyRatio,  
  
		PFDWast = inputItem.PFDWast, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartFormulaDet Map(PartFormulaDet entity ,EditPartFormulaDetCommand inputItem)
        {
              
  
		entity.PartFrmlDetId = inputItem.PartFrmlDetId;  
  
		entity.PFDHdrRef = inputItem.PFDHdrRef;  
  
		entity.PFDPartRef = inputItem.PFDPartRef;  
  
		entity.PFDQtyRatio = inputItem.PFDQtyRatio;  
  
		entity.PFDWast = inputItem.PFDWast; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartFormulaDetDto Map(PartFormulaDet inputItem)
        {
            var dto = new PartFormulaDetDto()
            {
                  
  
		PartFrmlDetId = inputItem.PartFrmlDetId,  
  
		PFDHdrRef = inputItem.PFDHdrRef,  
  
		PFDPartRef = inputItem.PFDPartRef,  
  
		PFDQtyRatio = inputItem.PFDQtyRatio,  
  
		PFDWast = inputItem.PFDWast, 
            };
            return dto;
        }

        public static List<PartFormulaDetDto> Map(ICollection<PartFormulaDet> entities)
        {
            var dtos = new List<PartFormulaDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartFormulaDetDto()
                {
                      
  
		PartFrmlDetId = inputItem.PartFrmlDetId,  
  
		PFDHdrRef = inputItem.PFDHdrRef,  
  
		PFDPartRef = inputItem.PFDPartRef,  
  
		PFDQtyRatio = inputItem.PFDQtyRatio,  
  
		PFDWast = inputItem.PFDWast, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartFrmlMach Map(AddPartFrmlMachCommand inputItem)
        {
            var entity = new PartFrmlMach() {
                  
  
		PFMFrmlRef = inputItem.PFMFrmlRef,  
  
		PFMMachRef = inputItem.PFMMachRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartFrmlMach Map(PartFrmlMach entity ,EditPartFrmlMachCommand inputItem)
        {
              
  
		entity.PFMFrmlRef = inputItem.PFMFrmlRef;  
  
		entity.PFMMachRef = inputItem.PFMMachRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartFrmlMachDto Map(PartFrmlMach inputItem)
        {
            var dto = new PartFrmlMachDto()
            {
                  
  
		PFMFrmlRef = inputItem.PFMFrmlRef,  
  
		PFMMachRef = inputItem.PFMMachRef, 
            };
            return dto;
        }

        public static List<PartFrmlMachDto> Map(ICollection<PartFrmlMach> entities)
        {
            var dtos = new List<PartFrmlMachDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartFrmlMachDto()
                {
                      
  
		PFMFrmlRef = inputItem.PFMFrmlRef,  
  
		PFMMachRef = inputItem.PFMMachRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PartFrmlOut Map(AddPartFrmlOutCommand inputItem)
        {
            var entity = new PartFrmlOut() {
                  
  
		PFOFrmlRef = inputItem.PFOFrmlRef,  
  
		PFOPartRef = inputItem.PFOPartRef,  
  
		PFOQty = inputItem.PFOQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PartFrmlOut Map(PartFrmlOut entity ,EditPartFrmlOutCommand inputItem)
        {
              
  
		entity.PFOFrmlRef = inputItem.PFOFrmlRef;  
  
		entity.PFOPartRef = inputItem.PFOPartRef;  
  
		entity.PFOQty = inputItem.PFOQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartFrmlOutDto Map(PartFrmlOut inputItem)
        {
            var dto = new PartFrmlOutDto()
            {
                  
  
		PFOFrmlRef = inputItem.PFOFrmlRef,  
  
		PFOPartRef = inputItem.PFOPartRef,  
  
		PFOQty = inputItem.PFOQty, 
            };
            return dto;
        }

        public static List<PartFrmlOutDto> Map(ICollection<PartFrmlOut> entities)
        {
            var dtos = new List<PartFrmlOutDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartFrmlOutDto()
                {
                      
  
		PFOFrmlRef = inputItem.PFOFrmlRef,  
  
		PFOPartRef = inputItem.PFOPartRef,  
  
		PFOQty = inputItem.PFOQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Parts Map(AddPartsCommand inputItem)
        {
            var entity = new Parts() {
                  
  
		PartId = inputItem.PartId,  
  
		PartCode = inputItem.PartCode,  
  
		PartName = inputItem.PartName,  
  
		UnitRef = inputItem.UnitRef,  
  
		InvCtgryRef = inputItem.InvCtgryRef,  
  
		PartECode = inputItem.PartECode,  
  
		PartOInf = inputItem.PartOInf,  
  
		PartType = inputItem.PartType,  
  
		PBarcode = inputItem.PBarcode,  
  
		SleCtgryRef = inputItem.SleCtgryRef,  
  
		PDLRef = inputItem.PDLRef,  
  
		PartSit = inputItem.PartSit,  
  
		ProdType = inputItem.ProdType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Parts Map(Parts entity ,EditPartsCommand inputItem)
        {
              
  
		entity.PartId = inputItem.PartId;  
  
		entity.PartCode = inputItem.PartCode;  
  
		entity.PartName = inputItem.PartName;  
  
		entity.UnitRef = inputItem.UnitRef;  
  
		entity.InvCtgryRef = inputItem.InvCtgryRef;  
  
		entity.PartECode = inputItem.PartECode;  
  
		entity.PartOInf = inputItem.PartOInf;  
  
		entity.PartType = inputItem.PartType;  
  
		entity.PBarcode = inputItem.PBarcode;  
  
		entity.SleCtgryRef = inputItem.SleCtgryRef;  
  
		entity.PDLRef = inputItem.PDLRef;  
  
		entity.PartSit = inputItem.PartSit;  
  
		entity.ProdType = inputItem.ProdType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PartsDto Map(Parts inputItem)
        {
            var dto = new PartsDto()
            {
                  
  
		PartId = inputItem.PartId,  
  
		PartCode = inputItem.PartCode,  
  
		PartName = inputItem.PartName,  
  
		UnitRef = inputItem.UnitRef,  
  
		InvCtgryRef = inputItem.InvCtgryRef,  
  
		PartECode = inputItem.PartECode,  
  
		PartOInf = inputItem.PartOInf,  
  
		PartType = inputItem.PartType,  
  
		PBarcode = inputItem.PBarcode,  
  
		SleCtgryRef = inputItem.SleCtgryRef,  
  
		PDLRef = inputItem.PDLRef,  
  
		PartSit = inputItem.PartSit,  
  
		ProdType = inputItem.ProdType, 
            };
            return dto;
        }

        public static List<PartsDto> Map(ICollection<Parts> entities)
        {
            var dtos = new List<PartsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PartsDto()
                {
                      
  
		PartId = inputItem.PartId,  
  
		PartCode = inputItem.PartCode,  
  
		PartName = inputItem.PartName,  
  
		UnitRef = inputItem.UnitRef,  
  
		InvCtgryRef = inputItem.InvCtgryRef,  
  
		PartECode = inputItem.PartECode,  
  
		PartOInf = inputItem.PartOInf,  
  
		PartType = inputItem.PartType,  
  
		PBarcode = inputItem.PBarcode,  
  
		SleCtgryRef = inputItem.SleCtgryRef,  
  
		PDLRef = inputItem.PDLRef,  
  
		PartSit = inputItem.PartSit,  
  
		ProdType = inputItem.ProdType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PmiReqPart Map(AddPmiReqPartCommand inputItem)
        {
            var entity = new PmiReqPart() {
                  
  
		PMIReqPartId = inputItem.PMIReqPartId,  
  
		PRPPrjRef = inputItem.PRPPrjRef,  
  
		PRPPartRef = inputItem.PRPPartRef,  
  
		PRPDate = inputItem.PRPDate,  
  
		PRPQty = inputItem.PRPQty,  
  
		PRPCreator = inputItem.PRPCreator, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PmiReqPart Map(PmiReqPart entity ,EditPmiReqPartCommand inputItem)
        {
              
  
		entity.PMIReqPartId = inputItem.PMIReqPartId;  
  
		entity.PRPPrjRef = inputItem.PRPPrjRef;  
  
		entity.PRPPartRef = inputItem.PRPPartRef;  
  
		entity.PRPDate = inputItem.PRPDate;  
  
		entity.PRPQty = inputItem.PRPQty;  
  
		entity.PRPCreator = inputItem.PRPCreator; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PmiReqPartDto Map(PmiReqPart inputItem)
        {
            var dto = new PmiReqPartDto()
            {
                  
  
		PMIReqPartId = inputItem.PMIReqPartId,  
  
		PRPPrjRef = inputItem.PRPPrjRef,  
  
		PRPPartRef = inputItem.PRPPartRef,  
  
		PRPDate = inputItem.PRPDate,  
  
		PRPQty = inputItem.PRPQty,  
  
		PRPCreator = inputItem.PRPCreator, 
            };
            return dto;
        }

        public static List<PmiReqPartDto> Map(ICollection<PmiReqPart> entities)
        {
            var dtos = new List<PmiReqPartDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PmiReqPartDto()
                {
                      
  
		PMIReqPartId = inputItem.PMIReqPartId,  
  
		PRPPrjRef = inputItem.PRPPrjRef,  
  
		PRPPartRef = inputItem.PRPPartRef,  
  
		PRPDate = inputItem.PRPDate,  
  
		PRPQty = inputItem.PRPQty,  
  
		PRPCreator = inputItem.PRPCreator, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
