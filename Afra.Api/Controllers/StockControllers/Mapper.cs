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
                
        
        public static StkPeriods Map(AddStkPeriodsCommand inputItem)
        {
            var entity = new StkPeriods() {
                  
  
		StkPeriodId = inputItem.StkPeriodId,  
  
		SPTitle = inputItem.SPTitle,  
  
		SPFromDate = inputItem.SPFromDate,  
  
		SPToDate = inputItem.SPToDate,  
  
		SPState = inputItem.SPState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StkPeriods Map(StkPeriods entity ,EditStkPeriodsCommand inputItem)
        {
              
  
		entity.StkPeriodId = inputItem.StkPeriodId;  
  
		entity.SPTitle = inputItem.SPTitle;  
  
		entity.SPFromDate = inputItem.SPFromDate;  
  
		entity.SPToDate = inputItem.SPToDate;  
  
		entity.SPState = inputItem.SPState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StkPeriodsDto Map(StkPeriods inputItem)
        {
            var dto = new StkPeriodsDto()
            {
                  
  
		StkPeriodId = inputItem.StkPeriodId,  
  
		SPTitle = inputItem.SPTitle,  
  
		SPFromDate = inputItem.SPFromDate,  
  
		SPToDate = inputItem.SPToDate,  
  
		SPState = inputItem.SPState, 
            };
            return dto;
        }

        public static List<StkPeriodsDto> Map(ICollection<StkPeriods> entities)
        {
            var dtos = new List<StkPeriodsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StkPeriodsDto()
                {
                      
  
		StkPeriodId = inputItem.StkPeriodId,  
  
		SPTitle = inputItem.SPTitle,  
  
		SPFromDate = inputItem.SPFromDate,  
  
		SPToDate = inputItem.SPToDate,  
  
		SPState = inputItem.SPState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StkStockDocs Map(AddStkStockDocsCommand inputItem)
        {
            var entity = new StkStockDocs() {
                  
  
		StkStockDocId = inputItem.StkStockDocId,  
  
		SSDStockerRef = inputItem.SSDStockerRef,  
  
		SSDType = inputItem.SSDType,  
  
		SSDNum = inputItem.SSDNum,  
  
		SSDQty = inputItem.SSDQty,  
  
		SSDState = inputItem.SSDState,  
  
		SSDPeriodRef = inputItem.SSDPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StkStockDocs Map(StkStockDocs entity ,EditStkStockDocsCommand inputItem)
        {
              
  
		entity.StkStockDocId = inputItem.StkStockDocId;  
  
		entity.SSDStockerRef = inputItem.SSDStockerRef;  
  
		entity.SSDType = inputItem.SSDType;  
  
		entity.SSDNum = inputItem.SSDNum;  
  
		entity.SSDQty = inputItem.SSDQty;  
  
		entity.SSDState = inputItem.SSDState;  
  
		entity.SSDPeriodRef = inputItem.SSDPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StkStockDocsDto Map(StkStockDocs inputItem)
        {
            var dto = new StkStockDocsDto()
            {
                  
  
		StkStockDocId = inputItem.StkStockDocId,  
  
		SSDStockerRef = inputItem.SSDStockerRef,  
  
		SSDType = inputItem.SSDType,  
  
		SSDNum = inputItem.SSDNum,  
  
		SSDQty = inputItem.SSDQty,  
  
		SSDState = inputItem.SSDState,  
  
		SSDPeriodRef = inputItem.SSDPeriodRef, 
            };
            return dto;
        }

        public static List<StkStockDocsDto> Map(ICollection<StkStockDocs> entities)
        {
            var dtos = new List<StkStockDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StkStockDocsDto()
                {
                      
  
		StkStockDocId = inputItem.StkStockDocId,  
  
		SSDStockerRef = inputItem.SSDStockerRef,  
  
		SSDType = inputItem.SSDType,  
  
		SSDNum = inputItem.SSDNum,  
  
		SSDQty = inputItem.SSDQty,  
  
		SSDState = inputItem.SSDState,  
  
		SSDPeriodRef = inputItem.SSDPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StkStockerInit Map(AddStkStockerInitCommand inputItem)
        {
            var entity = new StkStockerInit() {
                  
  
		SSIPeriodRef = inputItem.SSIPeriodRef,  
  
		SSIStockerRef = inputItem.SSIStockerRef,  
  
		SSIQty = inputItem.SSIQty,  
  
		SSIDebit = inputItem.SSIDebit,  
  
		SSICredit = inputItem.SSICredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StkStockerInit Map(StkStockerInit entity ,EditStkStockerInitCommand inputItem)
        {
              
  
		entity.SSIPeriodRef = inputItem.SSIPeriodRef;  
  
		entity.SSIStockerRef = inputItem.SSIStockerRef;  
  
		entity.SSIQty = inputItem.SSIQty;  
  
		entity.SSIDebit = inputItem.SSIDebit;  
  
		entity.SSICredit = inputItem.SSICredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StkStockerInitDto Map(StkStockerInit inputItem)
        {
            var dto = new StkStockerInitDto()
            {
                  
  
		SSIPeriodRef = inputItem.SSIPeriodRef,  
  
		SSIStockerRef = inputItem.SSIStockerRef,  
  
		SSIQty = inputItem.SSIQty,  
  
		SSIDebit = inputItem.SSIDebit,  
  
		SSICredit = inputItem.SSICredit, 
            };
            return dto;
        }

        public static List<StkStockerInitDto> Map(ICollection<StkStockerInit> entities)
        {
            var dtos = new List<StkStockerInitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StkStockerInitDto()
                {
                      
  
		SSIPeriodRef = inputItem.SSIPeriodRef,  
  
		SSIStockerRef = inputItem.SSIStockerRef,  
  
		SSIQty = inputItem.SSIQty,  
  
		SSIDebit = inputItem.SSIDebit,  
  
		SSICredit = inputItem.SSICredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StkStockers Map(AddStkStockersCommand inputItem)
        {
            var entity = new StkStockers() {
                  
  
		StkStockerId = inputItem.StkStockerId,  
  
		SSCrspndRef = inputItem.SSCrspndRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSFatherName = inputItem.SSFatherName,  
  
		SSCertNo = inputItem.SSCertNo,  
  
		SSBirthDate = inputItem.SSBirthDate,  
  
		SSBirthLocRef = inputItem.SSBirthLocRef,  
  
		SSIssuedIDLoc = inputItem.SSIssuedIDLoc,  
  
		SSIssueDate = inputItem.SSIssueDate,  
  
		SSNatCode = inputItem.SSNatCode,  
  
		SSAcnNo = inputItem.SSAcnNo,  
  
		SSBourceCode = inputItem.SSBourceCode,  
  
		SSAddress = inputItem.SSAddress,  
  
		SSRespName = inputItem.SSRespName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StkStockers Map(StkStockers entity ,EditStkStockersCommand inputItem)
        {
              
  
		entity.StkStockerId = inputItem.StkStockerId;  
  
		entity.SSCrspndRef = inputItem.SSCrspndRef;  
  
		entity.SSCode = inputItem.SSCode;  
  
		entity.SSFatherName = inputItem.SSFatherName;  
  
		entity.SSCertNo = inputItem.SSCertNo;  
  
		entity.SSBirthDate = inputItem.SSBirthDate;  
  
		entity.SSBirthLocRef = inputItem.SSBirthLocRef;  
  
		entity.SSIssuedIDLoc = inputItem.SSIssuedIDLoc;  
  
		entity.SSIssueDate = inputItem.SSIssueDate;  
  
		entity.SSNatCode = inputItem.SSNatCode;  
  
		entity.SSAcnNo = inputItem.SSAcnNo;  
  
		entity.SSBourceCode = inputItem.SSBourceCode;  
  
		entity.SSAddress = inputItem.SSAddress;  
  
		entity.SSRespName = inputItem.SSRespName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StkStockersDto Map(StkStockers inputItem)
        {
            var dto = new StkStockersDto()
            {
                  
  
		StkStockerId = inputItem.StkStockerId,  
  
		SSCrspndRef = inputItem.SSCrspndRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSFatherName = inputItem.SSFatherName,  
  
		SSCertNo = inputItem.SSCertNo,  
  
		SSBirthDate = inputItem.SSBirthDate,  
  
		SSBirthLocRef = inputItem.SSBirthLocRef,  
  
		SSIssuedIDLoc = inputItem.SSIssuedIDLoc,  
  
		SSIssueDate = inputItem.SSIssueDate,  
  
		SSNatCode = inputItem.SSNatCode,  
  
		SSAcnNo = inputItem.SSAcnNo,  
  
		SSBourceCode = inputItem.SSBourceCode,  
  
		SSAddress = inputItem.SSAddress,  
  
		SSRespName = inputItem.SSRespName, 
            };
            return dto;
        }

        public static List<StkStockersDto> Map(ICollection<StkStockers> entities)
        {
            var dtos = new List<StkStockersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StkStockersDto()
                {
                      
  
		StkStockerId = inputItem.StkStockerId,  
  
		SSCrspndRef = inputItem.SSCrspndRef,  
  
		SSCode = inputItem.SSCode,  
  
		SSFatherName = inputItem.SSFatherName,  
  
		SSCertNo = inputItem.SSCertNo,  
  
		SSBirthDate = inputItem.SSBirthDate,  
  
		SSBirthLocRef = inputItem.SSBirthLocRef,  
  
		SSIssuedIDLoc = inputItem.SSIssuedIDLoc,  
  
		SSIssueDate = inputItem.SSIssueDate,  
  
		SSNatCode = inputItem.SSNatCode,  
  
		SSAcnNo = inputItem.SSAcnNo,  
  
		SSBourceCode = inputItem.SSBourceCode,  
  
		SSAddress = inputItem.SSAddress,  
  
		SSRespName = inputItem.SSRespName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StkStockTrans Map(AddStkStockTransCommand inputItem)
        {
            var entity = new StkStockTrans() {
                  
  
		StkStockTranId = inputItem.StkStockTranId,  
  
		SSTNum = inputItem.SSTNum,  
  
		SSTDate = inputItem.SSTDate,  
  
		SSTType = inputItem.SSTType,  
  
		SSTSStockerRef = inputItem.SSTSStockerRef,  
  
		SSTRStockerRef = inputItem.SSTRStockerRef,  
  
		SSTQty = inputItem.SSTQty,  
  
		SSTRate = inputItem.SSTRate,  
  
		SSTPeriodRef = inputItem.SSTPeriodRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StkStockTrans Map(StkStockTrans entity ,EditStkStockTransCommand inputItem)
        {
              
  
		entity.StkStockTranId = inputItem.StkStockTranId;  
  
		entity.SSTNum = inputItem.SSTNum;  
  
		entity.SSTDate = inputItem.SSTDate;  
  
		entity.SSTType = inputItem.SSTType;  
  
		entity.SSTSStockerRef = inputItem.SSTSStockerRef;  
  
		entity.SSTRStockerRef = inputItem.SSTRStockerRef;  
  
		entity.SSTQty = inputItem.SSTQty;  
  
		entity.SSTRate = inputItem.SSTRate;  
  
		entity.SSTPeriodRef = inputItem.SSTPeriodRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StkStockTransDto Map(StkStockTrans inputItem)
        {
            var dto = new StkStockTransDto()
            {
                  
  
		StkStockTranId = inputItem.StkStockTranId,  
  
		SSTNum = inputItem.SSTNum,  
  
		SSTDate = inputItem.SSTDate,  
  
		SSTType = inputItem.SSTType,  
  
		SSTSStockerRef = inputItem.SSTSStockerRef,  
  
		SSTRStockerRef = inputItem.SSTRStockerRef,  
  
		SSTQty = inputItem.SSTQty,  
  
		SSTRate = inputItem.SSTRate,  
  
		SSTPeriodRef = inputItem.SSTPeriodRef, 
            };
            return dto;
        }

        public static List<StkStockTransDto> Map(ICollection<StkStockTrans> entities)
        {
            var dtos = new List<StkStockTransDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StkStockTransDto()
                {
                      
  
		StkStockTranId = inputItem.StkStockTranId,  
  
		SSTNum = inputItem.SSTNum,  
  
		SSTDate = inputItem.SSTDate,  
  
		SSTType = inputItem.SSTType,  
  
		SSTSStockerRef = inputItem.SSTSStockerRef,  
  
		SSTRStockerRef = inputItem.SSTRStockerRef,  
  
		SSTQty = inputItem.SSTQty,  
  
		SSTRate = inputItem.SSTRate,  
  
		SSTPeriodRef = inputItem.SSTPeriodRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
