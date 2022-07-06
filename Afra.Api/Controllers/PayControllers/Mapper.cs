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
                
        
        public static PayAccVch Map(AddPayAccVchCommand inputItem)
        {
            var entity = new PayAccVch() {
                  
  
		PayAccVchId = inputItem.PayAccVchId,  
  
		PAVTypeRef = inputItem.PAVTypeRef,  
  
		PAVYear = inputItem.PAVYear,  
  
		PAVMonth = inputItem.PAVMonth,  
  
		PAVPrdRef = inputItem.PAVPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayAccVch Map(PayAccVch entity ,EditPayAccVchCommand inputItem)
        {
              
  
		entity.PayAccVchId = inputItem.PayAccVchId;  
  
		entity.PAVTypeRef = inputItem.PAVTypeRef;  
  
		entity.PAVYear = inputItem.PAVYear;  
  
		entity.PAVMonth = inputItem.PAVMonth;  
  
		entity.PAVPrdRef = inputItem.PAVPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayAccVchDto Map(PayAccVch inputItem)
        {
            var dto = new PayAccVchDto()
            {
                  
  
		PayAccVchId = inputItem.PayAccVchId,  
  
		PAVTypeRef = inputItem.PAVTypeRef,  
  
		PAVYear = inputItem.PAVYear,  
  
		PAVMonth = inputItem.PAVMonth,  
  
		PAVPrdRef = inputItem.PAVPrdRef, 
            };
            return dto;
        }

        public static List<PayAccVchDto> Map(ICollection<PayAccVch> entities)
        {
            var dtos = new List<PayAccVchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayAccVchDto()
                {
                      
  
		PayAccVchId = inputItem.PayAccVchId,  
  
		PAVTypeRef = inputItem.PAVTypeRef,  
  
		PAVYear = inputItem.PAVYear,  
  
		PAVMonth = inputItem.PAVMonth,  
  
		PAVPrdRef = inputItem.PAVPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayAccVchDet Map(AddPayAccVchDetCommand inputItem)
        {
            var entity = new PayAccVchDet() {
                  
  
		PayAccVchRef = inputItem.PayAccVchRef,  
  
		PAVDPersRef = inputItem.PAVDPersRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayAccVchDet Map(PayAccVchDet entity ,EditPayAccVchDetCommand inputItem)
        {
              
  
		entity.PayAccVchRef = inputItem.PayAccVchRef;  
  
		entity.PAVDPersRef = inputItem.PAVDPersRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayAccVchDetDto Map(PayAccVchDet inputItem)
        {
            var dto = new PayAccVchDetDto()
            {
                  
  
		PayAccVchRef = inputItem.PayAccVchRef,  
  
		PAVDPersRef = inputItem.PAVDPersRef, 
            };
            return dto;
        }

        public static List<PayAccVchDetDto> Map(ICollection<PayAccVchDet> entities)
        {
            var dtos = new List<PayAccVchDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayAccVchDetDto()
                {
                      
  
		PayAccVchRef = inputItem.PayAccVchRef,  
  
		PAVDPersRef = inputItem.PAVDPersRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayBdgBase Map(AddPayBdgBaseCommand inputItem)
        {
            var entity = new PayBdgBase() {
                  
  
		PayBdgBaseId = inputItem.PayBdgBaseId,  
  
		PBBType = inputItem.PBBType,  
  
		PBBElmntRef = inputItem.PBBElmntRef,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBEmpRef = inputItem.PBBEmpRef,  
  
		PBBCostCntrRef = inputItem.PBBCostCntrRef,  
  
		PBBWLocRef = inputItem.PBBWLocRef,  
  
		PBBJobRef = inputItem.PBBJobRef,  
  
		PBBDLCode2 = inputItem.PBBDLCode2,  
  
		PBBDLCode3 = inputItem.PBBDLCode3,  
  
		PBBVal = inputItem.PBBVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayBdgBase Map(PayBdgBase entity ,EditPayBdgBaseCommand inputItem)
        {
              
  
		entity.PayBdgBaseId = inputItem.PayBdgBaseId;  
  
		entity.PBBType = inputItem.PBBType;  
  
		entity.PBBElmntRef = inputItem.PBBElmntRef;  
  
		entity.PBBPersRef = inputItem.PBBPersRef;  
  
		entity.PBBEmpRef = inputItem.PBBEmpRef;  
  
		entity.PBBCostCntrRef = inputItem.PBBCostCntrRef;  
  
		entity.PBBWLocRef = inputItem.PBBWLocRef;  
  
		entity.PBBJobRef = inputItem.PBBJobRef;  
  
		entity.PBBDLCode2 = inputItem.PBBDLCode2;  
  
		entity.PBBDLCode3 = inputItem.PBBDLCode3;  
  
		entity.PBBVal = inputItem.PBBVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayBdgBaseDto Map(PayBdgBase inputItem)
        {
            var dto = new PayBdgBaseDto()
            {
                  
  
		PayBdgBaseId = inputItem.PayBdgBaseId,  
  
		PBBType = inputItem.PBBType,  
  
		PBBElmntRef = inputItem.PBBElmntRef,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBEmpRef = inputItem.PBBEmpRef,  
  
		PBBCostCntrRef = inputItem.PBBCostCntrRef,  
  
		PBBWLocRef = inputItem.PBBWLocRef,  
  
		PBBJobRef = inputItem.PBBJobRef,  
  
		PBBDLCode2 = inputItem.PBBDLCode2,  
  
		PBBDLCode3 = inputItem.PBBDLCode3,  
  
		PBBVal = inputItem.PBBVal, 
            };
            return dto;
        }

        public static List<PayBdgBaseDto> Map(ICollection<PayBdgBase> entities)
        {
            var dtos = new List<PayBdgBaseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayBdgBaseDto()
                {
                      
  
		PayBdgBaseId = inputItem.PayBdgBaseId,  
  
		PBBType = inputItem.PBBType,  
  
		PBBElmntRef = inputItem.PBBElmntRef,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBEmpRef = inputItem.PBBEmpRef,  
  
		PBBCostCntrRef = inputItem.PBBCostCntrRef,  
  
		PBBWLocRef = inputItem.PBBWLocRef,  
  
		PBBJobRef = inputItem.PBBJobRef,  
  
		PBBDLCode2 = inputItem.PBBDLCode2,  
  
		PBBDLCode3 = inputItem.PBBDLCode3,  
  
		PBBVal = inputItem.PBBVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayBdgState Map(AddPayBdgStateCommand inputItem)
        {
            var entity = new PayBdgState() {
                  
  
		PayBdgStateId = inputItem.PayBdgStateId,  
  
		PBSPersRef = inputItem.PBSPersRef,  
  
		PBSYearNum = inputItem.PBSYearNum,  
  
		PBSMonthNum = inputItem.PBSMonthNum,  
  
		PBSCalcType = inputItem.PBSCalcType,  
  
		PBSYearMonth = inputItem.PBSYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayBdgState Map(PayBdgState entity ,EditPayBdgStateCommand inputItem)
        {
              
  
		entity.PayBdgStateId = inputItem.PayBdgStateId;  
  
		entity.PBSPersRef = inputItem.PBSPersRef;  
  
		entity.PBSYearNum = inputItem.PBSYearNum;  
  
		entity.PBSMonthNum = inputItem.PBSMonthNum;  
  
		entity.PBSCalcType = inputItem.PBSCalcType;  
  
		entity.PBSYearMonth = inputItem.PBSYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayBdgStateDto Map(PayBdgState inputItem)
        {
            var dto = new PayBdgStateDto()
            {
                  
  
		PayBdgStateId = inputItem.PayBdgStateId,  
  
		PBSPersRef = inputItem.PBSPersRef,  
  
		PBSYearNum = inputItem.PBSYearNum,  
  
		PBSMonthNum = inputItem.PBSMonthNum,  
  
		PBSCalcType = inputItem.PBSCalcType,  
  
		PBSYearMonth = inputItem.PBSYearMonth, 
            };
            return dto;
        }

        public static List<PayBdgStateDto> Map(ICollection<PayBdgState> entities)
        {
            var dtos = new List<PayBdgStateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayBdgStateDto()
                {
                      
  
		PayBdgStateId = inputItem.PayBdgStateId,  
  
		PBSPersRef = inputItem.PBSPersRef,  
  
		PBSYearNum = inputItem.PBSYearNum,  
  
		PBSMonthNum = inputItem.PBSMonthNum,  
  
		PBSCalcType = inputItem.PBSCalcType,  
  
		PBSYearMonth = inputItem.PBSYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayBdgVals Map(AddPayBdgValsCommand inputItem)
        {
            var entity = new PayBdgVals() {
                  
  
		PayBdgValId = inputItem.PayBdgValId,  
  
		PBVPersRef = inputItem.PBVPersRef,  
  
		PBVElmntRef = inputItem.PBVElmntRef,  
  
		PBVIssueYear = inputItem.PBVIssueYear,  
  
		PBVIssueMonth = inputItem.PBVIssueMonth,  
  
		PBVEffectYear = inputItem.PBVEffectYear,  
  
		PBVEffectMonth = inputItem.PBVEffectMonth,  
  
		PBVAmount = inputItem.PBVAmount,  
  
		PBVIYearMonth = inputItem.PBVIYearMonth,  
  
		PBVEYearMonth = inputItem.PBVEYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayBdgVals Map(PayBdgVals entity ,EditPayBdgValsCommand inputItem)
        {
              
  
		entity.PayBdgValId = inputItem.PayBdgValId;  
  
		entity.PBVPersRef = inputItem.PBVPersRef;  
  
		entity.PBVElmntRef = inputItem.PBVElmntRef;  
  
		entity.PBVIssueYear = inputItem.PBVIssueYear;  
  
		entity.PBVIssueMonth = inputItem.PBVIssueMonth;  
  
		entity.PBVEffectYear = inputItem.PBVEffectYear;  
  
		entity.PBVEffectMonth = inputItem.PBVEffectMonth;  
  
		entity.PBVAmount = inputItem.PBVAmount;  
  
		entity.PBVIYearMonth = inputItem.PBVIYearMonth;  
  
		entity.PBVEYearMonth = inputItem.PBVEYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayBdgValsDto Map(PayBdgVals inputItem)
        {
            var dto = new PayBdgValsDto()
            {
                  
  
		PayBdgValId = inputItem.PayBdgValId,  
  
		PBVPersRef = inputItem.PBVPersRef,  
  
		PBVElmntRef = inputItem.PBVElmntRef,  
  
		PBVIssueYear = inputItem.PBVIssueYear,  
  
		PBVIssueMonth = inputItem.PBVIssueMonth,  
  
		PBVEffectYear = inputItem.PBVEffectYear,  
  
		PBVEffectMonth = inputItem.PBVEffectMonth,  
  
		PBVAmount = inputItem.PBVAmount,  
  
		PBVIYearMonth = inputItem.PBVIYearMonth,  
  
		PBVEYearMonth = inputItem.PBVEYearMonth, 
            };
            return dto;
        }

        public static List<PayBdgValsDto> Map(ICollection<PayBdgVals> entities)
        {
            var dtos = new List<PayBdgValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayBdgValsDto()
                {
                      
  
		PayBdgValId = inputItem.PayBdgValId,  
  
		PBVPersRef = inputItem.PBVPersRef,  
  
		PBVElmntRef = inputItem.PBVElmntRef,  
  
		PBVIssueYear = inputItem.PBVIssueYear,  
  
		PBVIssueMonth = inputItem.PBVIssueMonth,  
  
		PBVEffectYear = inputItem.PBVEffectYear,  
  
		PBVEffectMonth = inputItem.PBVEffectMonth,  
  
		PBVAmount = inputItem.PBVAmount,  
  
		PBVIYearMonth = inputItem.PBVIYearMonth,  
  
		PBVEYearMonth = inputItem.PBVEYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayBuyBase Map(AddPayBuyBaseCommand inputItem)
        {
            var entity = new PayBuyBase() {
                  
  
		PayBuyBaseId = inputItem.PayBuyBaseId,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBYearNum = inputItem.PBBYearNum,  
  
		PBBMonthNum = inputItem.PBBMonthNum,  
  
		PBBInstDate = inputItem.PBBInstDate,  
  
		PBBFirstWorkDay = inputItem.PBBFirstWorkDay,  
  
		PBBFirstAllDay = inputItem.PBBFirstAllDay,  
  
		PBBFirstWorkLess = inputItem.PBBFirstWorkLess,  
  
		PBBFirstBuyVal = inputItem.PBBFirstBuyVal,  
  
		PBBYearMonth = inputItem.PBBYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayBuyBase Map(PayBuyBase entity ,EditPayBuyBaseCommand inputItem)
        {
              
  
		entity.PayBuyBaseId = inputItem.PayBuyBaseId;  
  
		entity.PBBPersRef = inputItem.PBBPersRef;  
  
		entity.PBBYearNum = inputItem.PBBYearNum;  
  
		entity.PBBMonthNum = inputItem.PBBMonthNum;  
  
		entity.PBBInstDate = inputItem.PBBInstDate;  
  
		entity.PBBFirstWorkDay = inputItem.PBBFirstWorkDay;  
  
		entity.PBBFirstAllDay = inputItem.PBBFirstAllDay;  
  
		entity.PBBFirstWorkLess = inputItem.PBBFirstWorkLess;  
  
		entity.PBBFirstBuyVal = inputItem.PBBFirstBuyVal;  
  
		entity.PBBYearMonth = inputItem.PBBYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayBuyBaseDto Map(PayBuyBase inputItem)
        {
            var dto = new PayBuyBaseDto()
            {
                  
  
		PayBuyBaseId = inputItem.PayBuyBaseId,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBYearNum = inputItem.PBBYearNum,  
  
		PBBMonthNum = inputItem.PBBMonthNum,  
  
		PBBInstDate = inputItem.PBBInstDate,  
  
		PBBFirstWorkDay = inputItem.PBBFirstWorkDay,  
  
		PBBFirstAllDay = inputItem.PBBFirstAllDay,  
  
		PBBFirstWorkLess = inputItem.PBBFirstWorkLess,  
  
		PBBFirstBuyVal = inputItem.PBBFirstBuyVal,  
  
		PBBYearMonth = inputItem.PBBYearMonth, 
            };
            return dto;
        }

        public static List<PayBuyBaseDto> Map(ICollection<PayBuyBase> entities)
        {
            var dtos = new List<PayBuyBaseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayBuyBaseDto()
                {
                      
  
		PayBuyBaseId = inputItem.PayBuyBaseId,  
  
		PBBPersRef = inputItem.PBBPersRef,  
  
		PBBYearNum = inputItem.PBBYearNum,  
  
		PBBMonthNum = inputItem.PBBMonthNum,  
  
		PBBInstDate = inputItem.PBBInstDate,  
  
		PBBFirstWorkDay = inputItem.PBBFirstWorkDay,  
  
		PBBFirstAllDay = inputItem.PBBFirstAllDay,  
  
		PBBFirstWorkLess = inputItem.PBBFirstWorkLess,  
  
		PBBFirstBuyVal = inputItem.PBBFirstBuyVal,  
  
		PBBYearMonth = inputItem.PBBYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayBuyCalc Map(AddPayBuyCalcCommand inputItem)
        {
            var entity = new PayBuyCalc() {
                  
  
		PayBuyCalcId = inputItem.PayBuyCalcId,  
  
		PBCPersRef = inputItem.PBCPersRef,  
  
		PBCBaseVal = inputItem.PBCBaseVal,  
  
		PBCDays = inputItem.PBCDays, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayBuyCalc Map(PayBuyCalc entity ,EditPayBuyCalcCommand inputItem)
        {
              
  
		entity.PayBuyCalcId = inputItem.PayBuyCalcId;  
  
		entity.PBCPersRef = inputItem.PBCPersRef;  
  
		entity.PBCBaseVal = inputItem.PBCBaseVal;  
  
		entity.PBCDays = inputItem.PBCDays; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayBuyCalcDto Map(PayBuyCalc inputItem)
        {
            var dto = new PayBuyCalcDto()
            {
                  
  
		PayBuyCalcId = inputItem.PayBuyCalcId,  
  
		PBCPersRef = inputItem.PBCPersRef,  
  
		PBCBaseVal = inputItem.PBCBaseVal,  
  
		PBCDays = inputItem.PBCDays, 
            };
            return dto;
        }

        public static List<PayBuyCalcDto> Map(ICollection<PayBuyCalc> entities)
        {
            var dtos = new List<PayBuyCalcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayBuyCalcDto()
                {
                      
  
		PayBuyCalcId = inputItem.PayBuyCalcId,  
  
		PBCPersRef = inputItem.PBCPersRef,  
  
		PBCBaseVal = inputItem.PBCBaseVal,  
  
		PBCDays = inputItem.PBCDays, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCalcBase Map(AddPayCalcBaseCommand inputItem)
        {
            var entity = new PayCalcBase() {
                  
  
		PayCalcBaseId = inputItem.PayCalcBaseId,  
  
		PCBType = inputItem.PCBType,  
  
		PCBPersRef = inputItem.PCBPersRef,  
  
		PCBElmntRef = inputItem.PCBElmntRef,  
  
		PCBYearNum = inputItem.PCBYearNum,  
  
		PCBMonthNum = inputItem.PCBMonthNum,  
  
		PCBVal = inputItem.PCBVal,  
  
		PCBYearMonth = inputItem.PCBYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCalcBase Map(PayCalcBase entity ,EditPayCalcBaseCommand inputItem)
        {
              
  
		entity.PayCalcBaseId = inputItem.PayCalcBaseId;  
  
		entity.PCBType = inputItem.PCBType;  
  
		entity.PCBPersRef = inputItem.PCBPersRef;  
  
		entity.PCBElmntRef = inputItem.PCBElmntRef;  
  
		entity.PCBYearNum = inputItem.PCBYearNum;  
  
		entity.PCBMonthNum = inputItem.PCBMonthNum;  
  
		entity.PCBVal = inputItem.PCBVal;  
  
		entity.PCBYearMonth = inputItem.PCBYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCalcBaseDto Map(PayCalcBase inputItem)
        {
            var dto = new PayCalcBaseDto()
            {
                  
  
		PayCalcBaseId = inputItem.PayCalcBaseId,  
  
		PCBType = inputItem.PCBType,  
  
		PCBPersRef = inputItem.PCBPersRef,  
  
		PCBElmntRef = inputItem.PCBElmntRef,  
  
		PCBYearNum = inputItem.PCBYearNum,  
  
		PCBMonthNum = inputItem.PCBMonthNum,  
  
		PCBVal = inputItem.PCBVal,  
  
		PCBYearMonth = inputItem.PCBYearMonth, 
            };
            return dto;
        }

        public static List<PayCalcBaseDto> Map(ICollection<PayCalcBase> entities)
        {
            var dtos = new List<PayCalcBaseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCalcBaseDto()
                {
                      
  
		PayCalcBaseId = inputItem.PayCalcBaseId,  
  
		PCBType = inputItem.PCBType,  
  
		PCBPersRef = inputItem.PCBPersRef,  
  
		PCBElmntRef = inputItem.PCBElmntRef,  
  
		PCBYearNum = inputItem.PCBYearNum,  
  
		PCBMonthNum = inputItem.PCBMonthNum,  
  
		PCBVal = inputItem.PCBVal,  
  
		PCBYearMonth = inputItem.PCBYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCalcCtrl Map(AddPayCalcCtrlCommand inputItem)
        {
            var entity = new PayCalcCtrl() {
                  
  
		PayCalcCtrlId = inputItem.PayCalcCtrlId,  
  
		PCCYearNum = inputItem.PCCYearNum,  
  
		PCCMonthNum = inputItem.PCCMonthNum,  
  
		PCCType = inputItem.PCCType,  
  
		PCCUserRef = inputItem.PCCUserRef,  
  
		PCCSit = inputItem.PCCSit,  
  
		PCCTitle = inputItem.PCCTitle,  
  
		PCCKind = inputItem.PCCKind,  
  
		PCCDefQry = inputItem.PCCDefQry, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCalcCtrl Map(PayCalcCtrl entity ,EditPayCalcCtrlCommand inputItem)
        {
              
  
		entity.PayCalcCtrlId = inputItem.PayCalcCtrlId;  
  
		entity.PCCYearNum = inputItem.PCCYearNum;  
  
		entity.PCCMonthNum = inputItem.PCCMonthNum;  
  
		entity.PCCType = inputItem.PCCType;  
  
		entity.PCCUserRef = inputItem.PCCUserRef;  
  
		entity.PCCSit = inputItem.PCCSit;  
  
		entity.PCCTitle = inputItem.PCCTitle;  
  
		entity.PCCKind = inputItem.PCCKind;  
  
		entity.PCCDefQry = inputItem.PCCDefQry; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCalcCtrlDto Map(PayCalcCtrl inputItem)
        {
            var dto = new PayCalcCtrlDto()
            {
                  
  
		PayCalcCtrlId = inputItem.PayCalcCtrlId,  
  
		PCCYearNum = inputItem.PCCYearNum,  
  
		PCCMonthNum = inputItem.PCCMonthNum,  
  
		PCCType = inputItem.PCCType,  
  
		PCCUserRef = inputItem.PCCUserRef,  
  
		PCCSit = inputItem.PCCSit,  
  
		PCCTitle = inputItem.PCCTitle,  
  
		PCCKind = inputItem.PCCKind,  
  
		PCCDefQry = inputItem.PCCDefQry, 
            };
            return dto;
        }

        public static List<PayCalcCtrlDto> Map(ICollection<PayCalcCtrl> entities)
        {
            var dtos = new List<PayCalcCtrlDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCalcCtrlDto()
                {
                      
  
		PayCalcCtrlId = inputItem.PayCalcCtrlId,  
  
		PCCYearNum = inputItem.PCCYearNum,  
  
		PCCMonthNum = inputItem.PCCMonthNum,  
  
		PCCType = inputItem.PCCType,  
  
		PCCUserRef = inputItem.PCCUserRef,  
  
		PCCSit = inputItem.PCCSit,  
  
		PCCTitle = inputItem.PCCTitle,  
  
		PCCKind = inputItem.PCCKind,  
  
		PCCDefQry = inputItem.PCCDefQry, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCalcCtrlDet Map(AddPayCalcCtrlDetCommand inputItem)
        {
            var entity = new PayCalcCtrlDet() {
                  
  
		PCCDCtrlRef = inputItem.PCCDCtrlRef,  
  
		PCCDYearNum = inputItem.PCCDYearNum,  
  
		PCCDMonthNum = inputItem.PCCDMonthNum,  
  
		PCCDPersRef = inputItem.PCCDPersRef,  
  
		PCCDUserRef = inputItem.PCCDUserRef,  
  
		PCCDSit = inputItem.PCCDSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCalcCtrlDet Map(PayCalcCtrlDet entity ,EditPayCalcCtrlDetCommand inputItem)
        {
              
  
		entity.PCCDCtrlRef = inputItem.PCCDCtrlRef;  
  
		entity.PCCDYearNum = inputItem.PCCDYearNum;  
  
		entity.PCCDMonthNum = inputItem.PCCDMonthNum;  
  
		entity.PCCDPersRef = inputItem.PCCDPersRef;  
  
		entity.PCCDUserRef = inputItem.PCCDUserRef;  
  
		entity.PCCDSit = inputItem.PCCDSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCalcCtrlDetDto Map(PayCalcCtrlDet inputItem)
        {
            var dto = new PayCalcCtrlDetDto()
            {
                  
  
		PCCDCtrlRef = inputItem.PCCDCtrlRef,  
  
		PCCDYearNum = inputItem.PCCDYearNum,  
  
		PCCDMonthNum = inputItem.PCCDMonthNum,  
  
		PCCDPersRef = inputItem.PCCDPersRef,  
  
		PCCDUserRef = inputItem.PCCDUserRef,  
  
		PCCDSit = inputItem.PCCDSit, 
            };
            return dto;
        }

        public static List<PayCalcCtrlDetDto> Map(ICollection<PayCalcCtrlDet> entities)
        {
            var dtos = new List<PayCalcCtrlDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCalcCtrlDetDto()
                {
                      
  
		PCCDCtrlRef = inputItem.PCCDCtrlRef,  
  
		PCCDYearNum = inputItem.PCCDYearNum,  
  
		PCCDMonthNum = inputItem.PCCDMonthNum,  
  
		PCCDPersRef = inputItem.PCCDPersRef,  
  
		PCCDUserRef = inputItem.PCCDUserRef,  
  
		PCCDSit = inputItem.PCCDSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCalcState Map(AddPayCalcStateCommand inputItem)
        {
            var entity = new PayCalcState() {
                  
  
		PayCalcStateId = inputItem.PayCalcStateId,  
  
		PCSPersRef = inputItem.PCSPersRef,  
  
		PCSYearNum = inputItem.PCSYearNum,  
  
		PCSMonthNum = inputItem.PCSMonthNum,  
  
		PCSCalcType = inputItem.PCSCalcType,  
  
		PCSYearMonth = inputItem.PCSYearMonth,  
  
		PCSUserRef = inputItem.PCSUserRef,  
  
		PCSOrgType = inputItem.PCSOrgType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCalcState Map(PayCalcState entity ,EditPayCalcStateCommand inputItem)
        {
              
  
		entity.PayCalcStateId = inputItem.PayCalcStateId;  
  
		entity.PCSPersRef = inputItem.PCSPersRef;  
  
		entity.PCSYearNum = inputItem.PCSYearNum;  
  
		entity.PCSMonthNum = inputItem.PCSMonthNum;  
  
		entity.PCSCalcType = inputItem.PCSCalcType;  
  
		entity.PCSYearMonth = inputItem.PCSYearMonth;  
  
		entity.PCSUserRef = inputItem.PCSUserRef;  
  
		entity.PCSOrgType = inputItem.PCSOrgType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCalcStateDto Map(PayCalcState inputItem)
        {
            var dto = new PayCalcStateDto()
            {
                  
  
		PayCalcStateId = inputItem.PayCalcStateId,  
  
		PCSPersRef = inputItem.PCSPersRef,  
  
		PCSYearNum = inputItem.PCSYearNum,  
  
		PCSMonthNum = inputItem.PCSMonthNum,  
  
		PCSCalcType = inputItem.PCSCalcType,  
  
		PCSYearMonth = inputItem.PCSYearMonth,  
  
		PCSUserRef = inputItem.PCSUserRef,  
  
		PCSOrgType = inputItem.PCSOrgType, 
            };
            return dto;
        }

        public static List<PayCalcStateDto> Map(ICollection<PayCalcState> entities)
        {
            var dtos = new List<PayCalcStateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCalcStateDto()
                {
                      
  
		PayCalcStateId = inputItem.PayCalcStateId,  
  
		PCSPersRef = inputItem.PCSPersRef,  
  
		PCSYearNum = inputItem.PCSYearNum,  
  
		PCSMonthNum = inputItem.PCSMonthNum,  
  
		PCSCalcType = inputItem.PCSCalcType,  
  
		PCSYearMonth = inputItem.PCSYearMonth,  
  
		PCSUserRef = inputItem.PCSUserRef,  
  
		PCSOrgType = inputItem.PCSOrgType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCalcVals Map(AddPayCalcValsCommand inputItem)
        {
            var entity = new PayCalcVals() {
                  
  
		PayCalcValId = inputItem.PayCalcValId,  
  
		PCVPersRef = inputItem.PCVPersRef,  
  
		PCVElmntRef = inputItem.PCVElmntRef,  
  
		PCVIssueYear = inputItem.PCVIssueYear,  
  
		PCVIssueMonth = inputItem.PCVIssueMonth,  
  
		PCVEffectYear = inputItem.PCVEffectYear,  
  
		PCVEffectMonth = inputItem.PCVEffectMonth,  
  
		PCVAmount = inputItem.PCVAmount,  
  
		PCVIYearMonth = inputItem.PCVIYearMonth,  
  
		PCVEYearMonth = inputItem.PCVEYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCalcVals Map(PayCalcVals entity ,EditPayCalcValsCommand inputItem)
        {
              
  
		entity.PayCalcValId = inputItem.PayCalcValId;  
  
		entity.PCVPersRef = inputItem.PCVPersRef;  
  
		entity.PCVElmntRef = inputItem.PCVElmntRef;  
  
		entity.PCVIssueYear = inputItem.PCVIssueYear;  
  
		entity.PCVIssueMonth = inputItem.PCVIssueMonth;  
  
		entity.PCVEffectYear = inputItem.PCVEffectYear;  
  
		entity.PCVEffectMonth = inputItem.PCVEffectMonth;  
  
		entity.PCVAmount = inputItem.PCVAmount;  
  
		entity.PCVIYearMonth = inputItem.PCVIYearMonth;  
  
		entity.PCVEYearMonth = inputItem.PCVEYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCalcValsDto Map(PayCalcVals inputItem)
        {
            var dto = new PayCalcValsDto()
            {
                  
  
		PayCalcValId = inputItem.PayCalcValId,  
  
		PCVPersRef = inputItem.PCVPersRef,  
  
		PCVElmntRef = inputItem.PCVElmntRef,  
  
		PCVIssueYear = inputItem.PCVIssueYear,  
  
		PCVIssueMonth = inputItem.PCVIssueMonth,  
  
		PCVEffectYear = inputItem.PCVEffectYear,  
  
		PCVEffectMonth = inputItem.PCVEffectMonth,  
  
		PCVAmount = inputItem.PCVAmount,  
  
		PCVIYearMonth = inputItem.PCVIYearMonth,  
  
		PCVEYearMonth = inputItem.PCVEYearMonth, 
            };
            return dto;
        }

        public static List<PayCalcValsDto> Map(ICollection<PayCalcVals> entities)
        {
            var dtos = new List<PayCalcValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCalcValsDto()
                {
                      
  
		PayCalcValId = inputItem.PayCalcValId,  
  
		PCVPersRef = inputItem.PCVPersRef,  
  
		PCVElmntRef = inputItem.PCVElmntRef,  
  
		PCVIssueYear = inputItem.PCVIssueYear,  
  
		PCVIssueMonth = inputItem.PCVIssueMonth,  
  
		PCVEffectYear = inputItem.PCVEffectYear,  
  
		PCVEffectMonth = inputItem.PCVEffectMonth,  
  
		PCVAmount = inputItem.PCVAmount,  
  
		PCVIYearMonth = inputItem.PCVIYearMonth,  
  
		PCVEYearMonth = inputItem.PCVEYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCompBranchs Map(AddPayCompBranchsCommand inputItem)
        {
            var entity = new PayCompBranchs() {
                  
  
		PayCompBranchId = inputItem.PayCompBranchId,  
  
		PCBCompRef = inputItem.PCBCompRef,  
  
		PCBCrspndRef = inputItem.PCBCrspndRef,  
  
		PCBCompID = inputItem.PCBCompID,  
  
		PCBIsMain = inputItem.PCBIsMain,  
  
		PCBContNum = inputItem.PCBContNum, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCompBranchs Map(PayCompBranchs entity ,EditPayCompBranchsCommand inputItem)
        {
              
  
		entity.PayCompBranchId = inputItem.PayCompBranchId;  
  
		entity.PCBCompRef = inputItem.PCBCompRef;  
  
		entity.PCBCrspndRef = inputItem.PCBCrspndRef;  
  
		entity.PCBCompID = inputItem.PCBCompID;  
  
		entity.PCBIsMain = inputItem.PCBIsMain;  
  
		entity.PCBContNum = inputItem.PCBContNum; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCompBranchsDto Map(PayCompBranchs inputItem)
        {
            var dto = new PayCompBranchsDto()
            {
                  
  
		PayCompBranchId = inputItem.PayCompBranchId,  
  
		PCBCompRef = inputItem.PCBCompRef,  
  
		PCBCrspndRef = inputItem.PCBCrspndRef,  
  
		PCBCompID = inputItem.PCBCompID,  
  
		PCBIsMain = inputItem.PCBIsMain,  
  
		PCBContNum = inputItem.PCBContNum, 
            };
            return dto;
        }

        public static List<PayCompBranchsDto> Map(ICollection<PayCompBranchs> entities)
        {
            var dtos = new List<PayCompBranchsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCompBranchsDto()
                {
                      
  
		PayCompBranchId = inputItem.PayCompBranchId,  
  
		PCBCompRef = inputItem.PCBCompRef,  
  
		PCBCrspndRef = inputItem.PCBCrspndRef,  
  
		PCBCompID = inputItem.PCBCompID,  
  
		PCBIsMain = inputItem.PCBIsMain,  
  
		PCBContNum = inputItem.PCBContNum, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayComps Map(AddPayCompsCommand inputItem)
        {
            var entity = new PayComps() {
                  
  
		PayCompID = inputItem.PayCompID,  
  
		PayCompName = inputItem.PayCompName,  
  
		PayCompType = inputItem.PayCompType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayComps Map(PayComps entity ,EditPayCompsCommand inputItem)
        {
              
  
		entity.PayCompID = inputItem.PayCompID;  
  
		entity.PayCompName = inputItem.PayCompName;  
  
		entity.PayCompType = inputItem.PayCompType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCompsDto Map(PayComps inputItem)
        {
            var dto = new PayCompsDto()
            {
                  
  
		PayCompID = inputItem.PayCompID,  
  
		PayCompName = inputItem.PayCompName,  
  
		PayCompType = inputItem.PayCompType, 
            };
            return dto;
        }

        public static List<PayCompsDto> Map(ICollection<PayComps> entities)
        {
            var dtos = new List<PayCompsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCompsDto()
                {
                      
  
		PayCompID = inputItem.PayCompID,  
  
		PayCompName = inputItem.PayCompName,  
  
		PayCompType = inputItem.PayCompType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayCtrl Map(AddPayCtrlCommand inputItem)
        {
            var entity = new PayCtrl() {
                  
  
		PayCtrlId = inputItem.PayCtrlId,  
  
		PCtYear = inputItem.PCtYear,  
  
		PCtMonth = inputItem.PCtMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayCtrl Map(PayCtrl entity ,EditPayCtrlCommand inputItem)
        {
              
  
		entity.PayCtrlId = inputItem.PayCtrlId;  
  
		entity.PCtYear = inputItem.PCtYear;  
  
		entity.PCtMonth = inputItem.PCtMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayCtrlDto Map(PayCtrl inputItem)
        {
            var dto = new PayCtrlDto()
            {
                  
  
		PayCtrlId = inputItem.PayCtrlId,  
  
		PCtYear = inputItem.PCtYear,  
  
		PCtMonth = inputItem.PCtMonth, 
            };
            return dto;
        }

        public static List<PayCtrlDto> Map(ICollection<PayCtrl> entities)
        {
            var dtos = new List<PayCtrlDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayCtrlDto()
                {
                      
  
		PayCtrlId = inputItem.PayCtrlId,  
  
		PCtYear = inputItem.PCtYear,  
  
		PCtMonth = inputItem.PCtMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayElmntRels Map(AddPayElmntRelsCommand inputItem)
        {
            var entity = new PayElmntRels() {
                  
  
		PayElmntRelId = inputItem.PayElmntRelId,  
  
		PERType = inputItem.PERType,  
  
		PERName = inputItem.PERName,  
  
		PERElmntRef = inputItem.PERElmntRef,  
  
		PERRole = inputItem.PERRole, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayElmntRels Map(PayElmntRels entity ,EditPayElmntRelsCommand inputItem)
        {
              
  
		entity.PayElmntRelId = inputItem.PayElmntRelId;  
  
		entity.PERType = inputItem.PERType;  
  
		entity.PERName = inputItem.PERName;  
  
		entity.PERElmntRef = inputItem.PERElmntRef;  
  
		entity.PERRole = inputItem.PERRole; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayElmntRelsDto Map(PayElmntRels inputItem)
        {
            var dto = new PayElmntRelsDto()
            {
                  
  
		PayElmntRelId = inputItem.PayElmntRelId,  
  
		PERType = inputItem.PERType,  
  
		PERName = inputItem.PERName,  
  
		PERElmntRef = inputItem.PERElmntRef,  
  
		PERRole = inputItem.PERRole, 
            };
            return dto;
        }

        public static List<PayElmntRelsDto> Map(ICollection<PayElmntRels> entities)
        {
            var dtos = new List<PayElmntRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayElmntRelsDto()
                {
                      
  
		PayElmntRelId = inputItem.PayElmntRelId,  
  
		PERType = inputItem.PERType,  
  
		PERName = inputItem.PERName,  
  
		PERElmntRef = inputItem.PERElmntRef,  
  
		PERRole = inputItem.PERRole, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayExpDet Map(AddPayExpDetCommand inputItem)
        {
            var entity = new PayExpDet() {
                  
  
		PayExpDetId = inputItem.PayExpDetId,  
  
		PayExpFileRef = inputItem.PayExpFileRef,  
  
		PEDSeq = inputItem.PEDSeq,  
  
		PEDLoc = inputItem.PEDLoc,  
  
		PEDFieldRef = inputItem.PEDFieldRef,  
  
		PEDName = inputItem.PEDName,  
  
		PEDTitle = inputItem.PEDTitle,  
  
		PEDFldType = inputItem.PEDFldType,  
  
		PEDSize = inputItem.PEDSize,  
  
		PEDDefVal = inputItem.PEDDefVal,  
  
		PEDFill = inputItem.PEDFill, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayExpDet Map(PayExpDet entity ,EditPayExpDetCommand inputItem)
        {
              
  
		entity.PayExpDetId = inputItem.PayExpDetId;  
  
		entity.PayExpFileRef = inputItem.PayExpFileRef;  
  
		entity.PEDSeq = inputItem.PEDSeq;  
  
		entity.PEDLoc = inputItem.PEDLoc;  
  
		entity.PEDFieldRef = inputItem.PEDFieldRef;  
  
		entity.PEDName = inputItem.PEDName;  
  
		entity.PEDTitle = inputItem.PEDTitle;  
  
		entity.PEDFldType = inputItem.PEDFldType;  
  
		entity.PEDSize = inputItem.PEDSize;  
  
		entity.PEDDefVal = inputItem.PEDDefVal;  
  
		entity.PEDFill = inputItem.PEDFill; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayExpDetDto Map(PayExpDet inputItem)
        {
            var dto = new PayExpDetDto()
            {
                  
  
		PayExpDetId = inputItem.PayExpDetId,  
  
		PayExpFileRef = inputItem.PayExpFileRef,  
  
		PEDSeq = inputItem.PEDSeq,  
  
		PEDLoc = inputItem.PEDLoc,  
  
		PEDFieldRef = inputItem.PEDFieldRef,  
  
		PEDName = inputItem.PEDName,  
  
		PEDTitle = inputItem.PEDTitle,  
  
		PEDFldType = inputItem.PEDFldType,  
  
		PEDSize = inputItem.PEDSize,  
  
		PEDDefVal = inputItem.PEDDefVal,  
  
		PEDFill = inputItem.PEDFill, 
            };
            return dto;
        }

        public static List<PayExpDetDto> Map(ICollection<PayExpDet> entities)
        {
            var dtos = new List<PayExpDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayExpDetDto()
                {
                      
  
		PayExpDetId = inputItem.PayExpDetId,  
  
		PayExpFileRef = inputItem.PayExpFileRef,  
  
		PEDSeq = inputItem.PEDSeq,  
  
		PEDLoc = inputItem.PEDLoc,  
  
		PEDFieldRef = inputItem.PEDFieldRef,  
  
		PEDName = inputItem.PEDName,  
  
		PEDTitle = inputItem.PEDTitle,  
  
		PEDFldType = inputItem.PEDFldType,  
  
		PEDSize = inputItem.PEDSize,  
  
		PEDDefVal = inputItem.PEDDefVal,  
  
		PEDFill = inputItem.PEDFill, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayExportFiles Map(AddPayExportFilesCommand inputItem)
        {
            var entity = new PayExportFiles() {
                  
  
		PayExpFileId = inputItem.PayExpFileId,  
  
		PEFTitle = inputItem.PEFTitle,  
  
		PEFName = inputItem.PEFName,  
  
		PEFDelimt = inputItem.PEFDelimt,  
  
		PEFFixName = inputItem.PEFFixName,  
  
		PEFDefPath = inputItem.PEFDefPath,  
  
		PEFBankRef = inputItem.PEFBankRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayExportFiles Map(PayExportFiles entity ,EditPayExportFilesCommand inputItem)
        {
              
  
		entity.PayExpFileId = inputItem.PayExpFileId;  
  
		entity.PEFTitle = inputItem.PEFTitle;  
  
		entity.PEFName = inputItem.PEFName;  
  
		entity.PEFDelimt = inputItem.PEFDelimt;  
  
		entity.PEFFixName = inputItem.PEFFixName;  
  
		entity.PEFDefPath = inputItem.PEFDefPath;  
  
		entity.PEFBankRef = inputItem.PEFBankRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayExportFilesDto Map(PayExportFiles inputItem)
        {
            var dto = new PayExportFilesDto()
            {
                  
  
		PayExpFileId = inputItem.PayExpFileId,  
  
		PEFTitle = inputItem.PEFTitle,  
  
		PEFName = inputItem.PEFName,  
  
		PEFDelimt = inputItem.PEFDelimt,  
  
		PEFFixName = inputItem.PEFFixName,  
  
		PEFDefPath = inputItem.PEFDefPath,  
  
		PEFBankRef = inputItem.PEFBankRef, 
            };
            return dto;
        }

        public static List<PayExportFilesDto> Map(ICollection<PayExportFiles> entities)
        {
            var dtos = new List<PayExportFilesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayExportFilesDto()
                {
                      
  
		PayExpFileId = inputItem.PayExpFileId,  
  
		PEFTitle = inputItem.PEFTitle,  
  
		PEFName = inputItem.PEFName,  
  
		PEFDelimt = inputItem.PEFDelimt,  
  
		PEFFixName = inputItem.PEFFixName,  
  
		PEFDefPath = inputItem.PEFDefPath,  
  
		PEFBankRef = inputItem.PEFBankRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayFish Map(AddPayFishCommand inputItem)
        {
            var entity = new PayFish() {
                  
  
		PayFishId = inputItem.PayFishId,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFFileName = inputItem.PFFileName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayFish Map(PayFish entity ,EditPayFishCommand inputItem)
        {
              
  
		entity.PayFishId = inputItem.PayFishId;  
  
		entity.PFTitle = inputItem.PFTitle;  
  
		entity.PFFileName = inputItem.PFFileName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayFishDto Map(PayFish inputItem)
        {
            var dto = new PayFishDto()
            {
                  
  
		PayFishId = inputItem.PayFishId,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFFileName = inputItem.PFFileName, 
            };
            return dto;
        }

        public static List<PayFishDto> Map(ICollection<PayFish> entities)
        {
            var dtos = new List<PayFishDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayFishDto()
                {
                      
  
		PayFishId = inputItem.PayFishId,  
  
		PFTitle = inputItem.PFTitle,  
  
		PFFileName = inputItem.PFFileName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayFishElmnt Map(AddPayFishElmntCommand inputItem)
        {
            var entity = new PayFishElmnt() {
                  
  
		PFEHdrRef = inputItem.PFEHdrRef,  
  
		PFEElmntRef = inputItem.PFEElmntRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayFishElmnt Map(PayFishElmnt entity ,EditPayFishElmntCommand inputItem)
        {
              
  
		entity.PFEHdrRef = inputItem.PFEHdrRef;  
  
		entity.PFEElmntRef = inputItem.PFEElmntRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayFishElmntDto Map(PayFishElmnt inputItem)
        {
            var dto = new PayFishElmntDto()
            {
                  
  
		PFEHdrRef = inputItem.PFEHdrRef,  
  
		PFEElmntRef = inputItem.PFEElmntRef, 
            };
            return dto;
        }

        public static List<PayFishElmntDto> Map(ICollection<PayFishElmnt> entities)
        {
            var dtos = new List<PayFishElmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayFishElmntDto()
                {
                      
  
		PFEHdrRef = inputItem.PFEHdrRef,  
  
		PFEElmntRef = inputItem.PFEElmntRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayFixElmnt Map(AddPayFixElmntCommand inputItem)
        {
            var entity = new PayFixElmnt() {
                  
  
		PayFixElmntId = inputItem.PayFixElmntId,  
  
		PFETitle = inputItem.PFETitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayFixElmnt Map(PayFixElmnt entity ,EditPayFixElmntCommand inputItem)
        {
              
  
		entity.PayFixElmntId = inputItem.PayFixElmntId;  
  
		entity.PFETitle = inputItem.PFETitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayFixElmntDto Map(PayFixElmnt inputItem)
        {
            var dto = new PayFixElmntDto()
            {
                  
  
		PayFixElmntId = inputItem.PayFixElmntId,  
  
		PFETitle = inputItem.PFETitle, 
            };
            return dto;
        }

        public static List<PayFixElmntDto> Map(ICollection<PayFixElmnt> entities)
        {
            var dtos = new List<PayFixElmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayFixElmntDto()
                {
                      
  
		PayFixElmntId = inputItem.PayFixElmntId,  
  
		PFETitle = inputItem.PFETitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayFixElmntVal Map(AddPayFixElmntValCommand inputItem)
        {
            var entity = new PayFixElmntVal() {
                  
  
		PayFixElmntValId = inputItem.PayFixElmntValId,  
  
		PFEVElmntRef = inputItem.PFEVElmntRef,  
  
		PFEVYear = inputItem.PFEVYear,  
  
		PFEVMonth = inputItem.PFEVMonth,  
  
		PFEVAmount = inputItem.PFEVAmount,  
  
		PFEVYearMonth = inputItem.PFEVYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayFixElmntVal Map(PayFixElmntVal entity ,EditPayFixElmntValCommand inputItem)
        {
              
  
		entity.PayFixElmntValId = inputItem.PayFixElmntValId;  
  
		entity.PFEVElmntRef = inputItem.PFEVElmntRef;  
  
		entity.PFEVYear = inputItem.PFEVYear;  
  
		entity.PFEVMonth = inputItem.PFEVMonth;  
  
		entity.PFEVAmount = inputItem.PFEVAmount;  
  
		entity.PFEVYearMonth = inputItem.PFEVYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayFixElmntValDto Map(PayFixElmntVal inputItem)
        {
            var dto = new PayFixElmntValDto()
            {
                  
  
		PayFixElmntValId = inputItem.PayFixElmntValId,  
  
		PFEVElmntRef = inputItem.PFEVElmntRef,  
  
		PFEVYear = inputItem.PFEVYear,  
  
		PFEVMonth = inputItem.PFEVMonth,  
  
		PFEVAmount = inputItem.PFEVAmount,  
  
		PFEVYearMonth = inputItem.PFEVYearMonth, 
            };
            return dto;
        }

        public static List<PayFixElmntValDto> Map(ICollection<PayFixElmntVal> entities)
        {
            var dtos = new List<PayFixElmntValDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayFixElmntValDto()
                {
                      
  
		PayFixElmntValId = inputItem.PayFixElmntValId,  
  
		PFEVElmntRef = inputItem.PFEVElmntRef,  
  
		PFEVYear = inputItem.PFEVYear,  
  
		PFEVMonth = inputItem.PFEVMonth,  
  
		PFEVAmount = inputItem.PFEVAmount,  
  
		PFEVYearMonth = inputItem.PFEVYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayGrpLoan Map(AddPayGrpLoanCommand inputItem)
        {
            var entity = new PayGrpLoan() {
                  
  
		PayGrpLoanId = inputItem.PayGrpLoanId,  
  
		PGLLoanRef = inputItem.PGLLoanRef,  
  
		PGLRcvDate = inputItem.PGLRcvDate,  
  
		PGLBeginYear = inputItem.PGLBeginYear,  
  
		PGLBeginMonth = inputItem.PGLBeginMonth,  
  
		PGLAmount = inputItem.PGLAmount,  
  
		PGLCalcAmnt = inputItem.PGLCalcAmnt,  
  
		PGLMonthVal = inputItem.PGLMonthVal,  
  
		PGLMonthCnt = inputItem.PGLMonthCnt,  
  
		PGLDiffVal = inputItem.PGLDiffVal,  
  
		PGLDValPayType = inputItem.PGLDValPayType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayGrpLoan Map(PayGrpLoan entity ,EditPayGrpLoanCommand inputItem)
        {
              
  
		entity.PayGrpLoanId = inputItem.PayGrpLoanId;  
  
		entity.PGLLoanRef = inputItem.PGLLoanRef;  
  
		entity.PGLRcvDate = inputItem.PGLRcvDate;  
  
		entity.PGLBeginYear = inputItem.PGLBeginYear;  
  
		entity.PGLBeginMonth = inputItem.PGLBeginMonth;  
  
		entity.PGLAmount = inputItem.PGLAmount;  
  
		entity.PGLCalcAmnt = inputItem.PGLCalcAmnt;  
  
		entity.PGLMonthVal = inputItem.PGLMonthVal;  
  
		entity.PGLMonthCnt = inputItem.PGLMonthCnt;  
  
		entity.PGLDiffVal = inputItem.PGLDiffVal;  
  
		entity.PGLDValPayType = inputItem.PGLDValPayType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayGrpLoanDto Map(PayGrpLoan inputItem)
        {
            var dto = new PayGrpLoanDto()
            {
                  
  
		PayGrpLoanId = inputItem.PayGrpLoanId,  
  
		PGLLoanRef = inputItem.PGLLoanRef,  
  
		PGLRcvDate = inputItem.PGLRcvDate,  
  
		PGLBeginYear = inputItem.PGLBeginYear,  
  
		PGLBeginMonth = inputItem.PGLBeginMonth,  
  
		PGLAmount = inputItem.PGLAmount,  
  
		PGLCalcAmnt = inputItem.PGLCalcAmnt,  
  
		PGLMonthVal = inputItem.PGLMonthVal,  
  
		PGLMonthCnt = inputItem.PGLMonthCnt,  
  
		PGLDiffVal = inputItem.PGLDiffVal,  
  
		PGLDValPayType = inputItem.PGLDValPayType, 
            };
            return dto;
        }

        public static List<PayGrpLoanDto> Map(ICollection<PayGrpLoan> entities)
        {
            var dtos = new List<PayGrpLoanDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayGrpLoanDto()
                {
                      
  
		PayGrpLoanId = inputItem.PayGrpLoanId,  
  
		PGLLoanRef = inputItem.PGLLoanRef,  
  
		PGLRcvDate = inputItem.PGLRcvDate,  
  
		PGLBeginYear = inputItem.PGLBeginYear,  
  
		PGLBeginMonth = inputItem.PGLBeginMonth,  
  
		PGLAmount = inputItem.PGLAmount,  
  
		PGLCalcAmnt = inputItem.PGLCalcAmnt,  
  
		PGLMonthVal = inputItem.PGLMonthVal,  
  
		PGLMonthCnt = inputItem.PGLMonthCnt,  
  
		PGLDiffVal = inputItem.PGLDiffVal,  
  
		PGLDValPayType = inputItem.PGLDValPayType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayGrpLoanPers Map(AddPayGrpLoanPersCommand inputItem)
        {
            var entity = new PayGrpLoanPers() {
                  
  
		PGLHdrRef = inputItem.PGLHdrRef,  
  
		PGLPersRef = inputItem.PGLPersRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayGrpLoanPers Map(PayGrpLoanPers entity ,EditPayGrpLoanPersCommand inputItem)
        {
              
  
		entity.PGLHdrRef = inputItem.PGLHdrRef;  
  
		entity.PGLPersRef = inputItem.PGLPersRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayGrpLoanPersDto Map(PayGrpLoanPers inputItem)
        {
            var dto = new PayGrpLoanPersDto()
            {
                  
  
		PGLHdrRef = inputItem.PGLHdrRef,  
  
		PGLPersRef = inputItem.PGLPersRef, 
            };
            return dto;
        }

        public static List<PayGrpLoanPersDto> Map(ICollection<PayGrpLoanPers> entities)
        {
            var dtos = new List<PayGrpLoanPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayGrpLoanPersDto()
                {
                      
  
		PGLHdrRef = inputItem.PGLHdrRef,  
  
		PGLPersRef = inputItem.PGLPersRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayGrpValStat Map(AddPayGrpValStatCommand inputItem)
        {
            var entity = new PayGrpValStat() {
                  
  
		PayGrpValStatId = inputItem.PayGrpValStatId,  
  
		PGVSNum = inputItem.PGVSNum,  
  
		PGVSIssueDate = inputItem.PGVSIssueDate,  
  
		PGVSEffectDate = inputItem.PGVSEffectDate,  
  
		PGVSDescr = inputItem.PGVSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayGrpValStat Map(PayGrpValStat entity ,EditPayGrpValStatCommand inputItem)
        {
              
  
		entity.PayGrpValStatId = inputItem.PayGrpValStatId;  
  
		entity.PGVSNum = inputItem.PGVSNum;  
  
		entity.PGVSIssueDate = inputItem.PGVSIssueDate;  
  
		entity.PGVSEffectDate = inputItem.PGVSEffectDate;  
  
		entity.PGVSDescr = inputItem.PGVSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayGrpValStatDto Map(PayGrpValStat inputItem)
        {
            var dto = new PayGrpValStatDto()
            {
                  
  
		PayGrpValStatId = inputItem.PayGrpValStatId,  
  
		PGVSNum = inputItem.PGVSNum,  
  
		PGVSIssueDate = inputItem.PGVSIssueDate,  
  
		PGVSEffectDate = inputItem.PGVSEffectDate,  
  
		PGVSDescr = inputItem.PGVSDescr, 
            };
            return dto;
        }

        public static List<PayGrpValStatDto> Map(ICollection<PayGrpValStat> entities)
        {
            var dtos = new List<PayGrpValStatDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayGrpValStatDto()
                {
                      
  
		PayGrpValStatId = inputItem.PayGrpValStatId,  
  
		PGVSNum = inputItem.PGVSNum,  
  
		PGVSIssueDate = inputItem.PGVSIssueDate,  
  
		PGVSEffectDate = inputItem.PGVSEffectDate,  
  
		PGVSDescr = inputItem.PGVSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayGrpValStatAmnt Map(AddPayGrpValStatAmntCommand inputItem)
        {
            var entity = new PayGrpValStatAmnt() {
                  
  
		PGVSElmntRef = inputItem.PGVSElmntRef,  
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSAmount = inputItem.PGVSAmount,  
  
		PGVSSit = inputItem.PGVSSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayGrpValStatAmnt Map(PayGrpValStatAmnt entity ,EditPayGrpValStatAmntCommand inputItem)
        {
              
  
		entity.PGVSElmntRef = inputItem.PGVSElmntRef;  
  
		entity.PGVSStatRef = inputItem.PGVSStatRef;  
  
		entity.PGVSAmount = inputItem.PGVSAmount;  
  
		entity.PGVSSit = inputItem.PGVSSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayGrpValStatAmntDto Map(PayGrpValStatAmnt inputItem)
        {
            var dto = new PayGrpValStatAmntDto()
            {
                  
  
		PGVSElmntRef = inputItem.PGVSElmntRef,  
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSAmount = inputItem.PGVSAmount,  
  
		PGVSSit = inputItem.PGVSSit, 
            };
            return dto;
        }

        public static List<PayGrpValStatAmntDto> Map(ICollection<PayGrpValStatAmnt> entities)
        {
            var dtos = new List<PayGrpValStatAmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayGrpValStatAmntDto()
                {
                      
  
		PGVSElmntRef = inputItem.PGVSElmntRef,  
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSAmount = inputItem.PGVSAmount,  
  
		PGVSSit = inputItem.PGVSSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayGrpValStatPers Map(AddPayGrpValStatPersCommand inputItem)
        {
            var entity = new PayGrpValStatPers() {
                  
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSPersRef = inputItem.PGVSPersRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayGrpValStatPers Map(PayGrpValStatPers entity ,EditPayGrpValStatPersCommand inputItem)
        {
              
  
		entity.PGVSStatRef = inputItem.PGVSStatRef;  
  
		entity.PGVSPersRef = inputItem.PGVSPersRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayGrpValStatPersDto Map(PayGrpValStatPers inputItem)
        {
            var dto = new PayGrpValStatPersDto()
            {
                  
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSPersRef = inputItem.PGVSPersRef, 
            };
            return dto;
        }

        public static List<PayGrpValStatPersDto> Map(ICollection<PayGrpValStatPers> entities)
        {
            var dtos = new List<PayGrpValStatPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayGrpValStatPersDto()
                {
                      
  
		PGVSStatRef = inputItem.PGVSStatRef,  
  
		PGVSPersRef = inputItem.PGVSPersRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayImpDet Map(AddPayImpDetCommand inputItem)
        {
            var entity = new PayImpDet() {
                  
  
		PayImpDetId = inputItem.PayImpDetId,  
  
		PayImpFileRef = inputItem.PayImpFileRef,  
  
		PIFElmntRef = inputItem.PIFElmntRef,  
  
		PIFFieldName = inputItem.PIFFieldName,  
  
		PIFStartInd = inputItem.PIFStartInd,  
  
		PIFDayFldName = inputItem.PIFDayFldName,  
  
		PIFDayStart = inputItem.PIFDayStart,  
  
		PIFDayCnt = inputItem.PIFDayCnt,  
  
		PIFHourFldName = inputItem.PIFHourFldName,  
  
		PIFHourStart = inputItem.PIFHourStart,  
  
		PIFHourCnt = inputItem.PIFHourCnt,  
  
		PIFMinFldName = inputItem.PIFMinFldName,  
  
		PIFMinStart = inputItem.PIFMinStart,  
  
		PIFMinCnt = inputItem.PIFMinCnt,  
  
		PIFAmntFldName = inputItem.PIFAmntFldName,  
  
		PIFAmntStart = inputItem.PIFAmntStart,  
  
		PIFAmntCnt = inputItem.PIFAmntCnt,  
  
		PIFVacRef = inputItem.PIFVacRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayImpDet Map(PayImpDet entity ,EditPayImpDetCommand inputItem)
        {
              
  
		entity.PayImpDetId = inputItem.PayImpDetId;  
  
		entity.PayImpFileRef = inputItem.PayImpFileRef;  
  
		entity.PIFElmntRef = inputItem.PIFElmntRef;  
  
		entity.PIFFieldName = inputItem.PIFFieldName;  
  
		entity.PIFStartInd = inputItem.PIFStartInd;  
  
		entity.PIFDayFldName = inputItem.PIFDayFldName;  
  
		entity.PIFDayStart = inputItem.PIFDayStart;  
  
		entity.PIFDayCnt = inputItem.PIFDayCnt;  
  
		entity.PIFHourFldName = inputItem.PIFHourFldName;  
  
		entity.PIFHourStart = inputItem.PIFHourStart;  
  
		entity.PIFHourCnt = inputItem.PIFHourCnt;  
  
		entity.PIFMinFldName = inputItem.PIFMinFldName;  
  
		entity.PIFMinStart = inputItem.PIFMinStart;  
  
		entity.PIFMinCnt = inputItem.PIFMinCnt;  
  
		entity.PIFAmntFldName = inputItem.PIFAmntFldName;  
  
		entity.PIFAmntStart = inputItem.PIFAmntStart;  
  
		entity.PIFAmntCnt = inputItem.PIFAmntCnt;  
  
		entity.PIFVacRef = inputItem.PIFVacRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayImpDetDto Map(PayImpDet inputItem)
        {
            var dto = new PayImpDetDto()
            {
                  
  
		PayImpDetId = inputItem.PayImpDetId,  
  
		PayImpFileRef = inputItem.PayImpFileRef,  
  
		PIFElmntRef = inputItem.PIFElmntRef,  
  
		PIFFieldName = inputItem.PIFFieldName,  
  
		PIFStartInd = inputItem.PIFStartInd,  
  
		PIFDayFldName = inputItem.PIFDayFldName,  
  
		PIFDayStart = inputItem.PIFDayStart,  
  
		PIFDayCnt = inputItem.PIFDayCnt,  
  
		PIFHourFldName = inputItem.PIFHourFldName,  
  
		PIFHourStart = inputItem.PIFHourStart,  
  
		PIFHourCnt = inputItem.PIFHourCnt,  
  
		PIFMinFldName = inputItem.PIFMinFldName,  
  
		PIFMinStart = inputItem.PIFMinStart,  
  
		PIFMinCnt = inputItem.PIFMinCnt,  
  
		PIFAmntFldName = inputItem.PIFAmntFldName,  
  
		PIFAmntStart = inputItem.PIFAmntStart,  
  
		PIFAmntCnt = inputItem.PIFAmntCnt,  
  
		PIFVacRef = inputItem.PIFVacRef, 
            };
            return dto;
        }

        public static List<PayImpDetDto> Map(ICollection<PayImpDet> entities)
        {
            var dtos = new List<PayImpDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayImpDetDto()
                {
                      
  
		PayImpDetId = inputItem.PayImpDetId,  
  
		PayImpFileRef = inputItem.PayImpFileRef,  
  
		PIFElmntRef = inputItem.PIFElmntRef,  
  
		PIFFieldName = inputItem.PIFFieldName,  
  
		PIFStartInd = inputItem.PIFStartInd,  
  
		PIFDayFldName = inputItem.PIFDayFldName,  
  
		PIFDayStart = inputItem.PIFDayStart,  
  
		PIFDayCnt = inputItem.PIFDayCnt,  
  
		PIFHourFldName = inputItem.PIFHourFldName,  
  
		PIFHourStart = inputItem.PIFHourStart,  
  
		PIFHourCnt = inputItem.PIFHourCnt,  
  
		PIFMinFldName = inputItem.PIFMinFldName,  
  
		PIFMinStart = inputItem.PIFMinStart,  
  
		PIFMinCnt = inputItem.PIFMinCnt,  
  
		PIFAmntFldName = inputItem.PIFAmntFldName,  
  
		PIFAmntStart = inputItem.PIFAmntStart,  
  
		PIFAmntCnt = inputItem.PIFAmntCnt,  
  
		PIFVacRef = inputItem.PIFVacRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayImportFiles Map(AddPayImportFilesCommand inputItem)
        {
            var entity = new PayImportFiles() {
                  
  
		PayImpFileId = inputItem.PayImpFileId,  
  
		PIFTitle = inputItem.PIFTitle,  
  
		PIFFormat = inputItem.PIFFormat,  
  
		PIFPCFldName = inputItem.PIFPCFldName,  
  
		PIFPCStart = inputItem.PIFPCStart,  
  
		PIFPCCnt = inputItem.PIFPCCnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayImportFiles Map(PayImportFiles entity ,EditPayImportFilesCommand inputItem)
        {
              
  
		entity.PayImpFileId = inputItem.PayImpFileId;  
  
		entity.PIFTitle = inputItem.PIFTitle;  
  
		entity.PIFFormat = inputItem.PIFFormat;  
  
		entity.PIFPCFldName = inputItem.PIFPCFldName;  
  
		entity.PIFPCStart = inputItem.PIFPCStart;  
  
		entity.PIFPCCnt = inputItem.PIFPCCnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayImportFilesDto Map(PayImportFiles inputItem)
        {
            var dto = new PayImportFilesDto()
            {
                  
  
		PayImpFileId = inputItem.PayImpFileId,  
  
		PIFTitle = inputItem.PIFTitle,  
  
		PIFFormat = inputItem.PIFFormat,  
  
		PIFPCFldName = inputItem.PIFPCFldName,  
  
		PIFPCStart = inputItem.PIFPCStart,  
  
		PIFPCCnt = inputItem.PIFPCCnt, 
            };
            return dto;
        }

        public static List<PayImportFilesDto> Map(ICollection<PayImportFiles> entities)
        {
            var dtos = new List<PayImportFilesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayImportFilesDto()
                {
                      
  
		PayImpFileId = inputItem.PayImpFileId,  
  
		PIFTitle = inputItem.PIFTitle,  
  
		PIFFormat = inputItem.PIFFormat,  
  
		PIFPCFldName = inputItem.PIFPCFldName,  
  
		PIFPCStart = inputItem.PIFPCStart,  
  
		PIFPCCnt = inputItem.PIFPCCnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayLoanHistory Map(AddPayLoanHistoryCommand inputItem)
        {
            var entity = new PayLoanHistory() {
                  
  
		PayLoanHostoryId = inputItem.PayLoanHostoryId,  
  
		PLHLoanRef = inputItem.PLHLoanRef,  
  
		PLHState = inputItem.PLHState,  
  
		PLHIYearMonth = inputItem.PLHIYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayLoanHistory Map(PayLoanHistory entity ,EditPayLoanHistoryCommand inputItem)
        {
              
  
		entity.PayLoanHostoryId = inputItem.PayLoanHostoryId;  
  
		entity.PLHLoanRef = inputItem.PLHLoanRef;  
  
		entity.PLHState = inputItem.PLHState;  
  
		entity.PLHIYearMonth = inputItem.PLHIYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayLoanHistoryDto Map(PayLoanHistory inputItem)
        {
            var dto = new PayLoanHistoryDto()
            {
                  
  
		PayLoanHostoryId = inputItem.PayLoanHostoryId,  
  
		PLHLoanRef = inputItem.PLHLoanRef,  
  
		PLHState = inputItem.PLHState,  
  
		PLHIYearMonth = inputItem.PLHIYearMonth, 
            };
            return dto;
        }

        public static List<PayLoanHistoryDto> Map(ICollection<PayLoanHistory> entities)
        {
            var dtos = new List<PayLoanHistoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayLoanHistoryDto()
                {
                      
  
		PayLoanHostoryId = inputItem.PayLoanHostoryId,  
  
		PLHLoanRef = inputItem.PLHLoanRef,  
  
		PLHState = inputItem.PLHState,  
  
		PLHIYearMonth = inputItem.PLHIYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayLoanPayment Map(AddPayLoanPaymentCommand inputItem)
        {
            var entity = new PayLoanPayment() {
                  
  
		PayLoanPaymentId = inputItem.PayLoanPaymentId,  
  
		PLPLoanRef = inputItem.PLPLoanRef,  
  
		PLPYearNum = inputItem.PLPYearNum,  
  
		PLPMonthNum = inputItem.PLPMonthNum,  
  
		PLPAmount = inputItem.PLPAmount,  
  
		PLPYearMonth = inputItem.PLPYearMonth,  
  
		PLPType = inputItem.PLPType,  
  
		PLPDescr = inputItem.PLPDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayLoanPayment Map(PayLoanPayment entity ,EditPayLoanPaymentCommand inputItem)
        {
              
  
		entity.PayLoanPaymentId = inputItem.PayLoanPaymentId;  
  
		entity.PLPLoanRef = inputItem.PLPLoanRef;  
  
		entity.PLPYearNum = inputItem.PLPYearNum;  
  
		entity.PLPMonthNum = inputItem.PLPMonthNum;  
  
		entity.PLPAmount = inputItem.PLPAmount;  
  
		entity.PLPYearMonth = inputItem.PLPYearMonth;  
  
		entity.PLPType = inputItem.PLPType;  
  
		entity.PLPDescr = inputItem.PLPDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayLoanPaymentDto Map(PayLoanPayment inputItem)
        {
            var dto = new PayLoanPaymentDto()
            {
                  
  
		PayLoanPaymentId = inputItem.PayLoanPaymentId,  
  
		PLPLoanRef = inputItem.PLPLoanRef,  
  
		PLPYearNum = inputItem.PLPYearNum,  
  
		PLPMonthNum = inputItem.PLPMonthNum,  
  
		PLPAmount = inputItem.PLPAmount,  
  
		PLPYearMonth = inputItem.PLPYearMonth,  
  
		PLPType = inputItem.PLPType,  
  
		PLPDescr = inputItem.PLPDescr, 
            };
            return dto;
        }

        public static List<PayLoanPaymentDto> Map(ICollection<PayLoanPayment> entities)
        {
            var dtos = new List<PayLoanPaymentDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayLoanPaymentDto()
                {
                      
  
		PayLoanPaymentId = inputItem.PayLoanPaymentId,  
  
		PLPLoanRef = inputItem.PLPLoanRef,  
  
		PLPYearNum = inputItem.PLPYearNum,  
  
		PLPMonthNum = inputItem.PLPMonthNum,  
  
		PLPAmount = inputItem.PLPAmount,  
  
		PLPYearMonth = inputItem.PLPYearMonth,  
  
		PLPType = inputItem.PLPType,  
  
		PLPDescr = inputItem.PLPDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayLoanRcv Map(AddPayLoanRcvCommand inputItem)
        {
            var entity = new PayLoanRcv() {
                  
  
		PayLoanRcvId = inputItem.PayLoanRcvId,  
  
		PLRLoanRef = inputItem.PLRLoanRef,  
  
		PLRPersRef = inputItem.PLRPersRef,  
  
		PLRRcvDate = inputItem.PLRRcvDate,  
  
		PLRBeginYear = inputItem.PLRBeginYear,  
  
		PLRBeginMonth = inputItem.PLRBeginMonth,  
  
		PLRAmount = inputItem.PLRAmount,  
  
		PLRCalcAmnt = inputItem.PLRCalcAmnt,  
  
		PLRMonthVal = inputItem.PLRMonthVal,  
  
		PLRMonthCnt = inputItem.PLRMonthCnt,  
  
		PLRDiffVal = inputItem.PLRDiffVal,  
  
		PLRDValPayType = inputItem.PLRDValPayType,  
  
		PLRGrpRef = inputItem.PLRGrpRef,  
  
		PLRIYearMonth = inputItem.PLRIYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayLoanRcv Map(PayLoanRcv entity ,EditPayLoanRcvCommand inputItem)
        {
              
  
		entity.PayLoanRcvId = inputItem.PayLoanRcvId;  
  
		entity.PLRLoanRef = inputItem.PLRLoanRef;  
  
		entity.PLRPersRef = inputItem.PLRPersRef;  
  
		entity.PLRRcvDate = inputItem.PLRRcvDate;  
  
		entity.PLRBeginYear = inputItem.PLRBeginYear;  
  
		entity.PLRBeginMonth = inputItem.PLRBeginMonth;  
  
		entity.PLRAmount = inputItem.PLRAmount;  
  
		entity.PLRCalcAmnt = inputItem.PLRCalcAmnt;  
  
		entity.PLRMonthVal = inputItem.PLRMonthVal;  
  
		entity.PLRMonthCnt = inputItem.PLRMonthCnt;  
  
		entity.PLRDiffVal = inputItem.PLRDiffVal;  
  
		entity.PLRDValPayType = inputItem.PLRDValPayType;  
  
		entity.PLRGrpRef = inputItem.PLRGrpRef;  
  
		entity.PLRIYearMonth = inputItem.PLRIYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayLoanRcvDto Map(PayLoanRcv inputItem)
        {
            var dto = new PayLoanRcvDto()
            {
                  
  
		PayLoanRcvId = inputItem.PayLoanRcvId,  
  
		PLRLoanRef = inputItem.PLRLoanRef,  
  
		PLRPersRef = inputItem.PLRPersRef,  
  
		PLRRcvDate = inputItem.PLRRcvDate,  
  
		PLRBeginYear = inputItem.PLRBeginYear,  
  
		PLRBeginMonth = inputItem.PLRBeginMonth,  
  
		PLRAmount = inputItem.PLRAmount,  
  
		PLRCalcAmnt = inputItem.PLRCalcAmnt,  
  
		PLRMonthVal = inputItem.PLRMonthVal,  
  
		PLRMonthCnt = inputItem.PLRMonthCnt,  
  
		PLRDiffVal = inputItem.PLRDiffVal,  
  
		PLRDValPayType = inputItem.PLRDValPayType,  
  
		PLRGrpRef = inputItem.PLRGrpRef,  
  
		PLRIYearMonth = inputItem.PLRIYearMonth, 
            };
            return dto;
        }

        public static List<PayLoanRcvDto> Map(ICollection<PayLoanRcv> entities)
        {
            var dtos = new List<PayLoanRcvDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayLoanRcvDto()
                {
                      
  
		PayLoanRcvId = inputItem.PayLoanRcvId,  
  
		PLRLoanRef = inputItem.PLRLoanRef,  
  
		PLRPersRef = inputItem.PLRPersRef,  
  
		PLRRcvDate = inputItem.PLRRcvDate,  
  
		PLRBeginYear = inputItem.PLRBeginYear,  
  
		PLRBeginMonth = inputItem.PLRBeginMonth,  
  
		PLRAmount = inputItem.PLRAmount,  
  
		PLRCalcAmnt = inputItem.PLRCalcAmnt,  
  
		PLRMonthVal = inputItem.PLRMonthVal,  
  
		PLRMonthCnt = inputItem.PLRMonthCnt,  
  
		PLRDiffVal = inputItem.PLRDiffVal,  
  
		PLRDValPayType = inputItem.PLRDValPayType,  
  
		PLRGrpRef = inputItem.PLRGrpRef,  
  
		PLRIYearMonth = inputItem.PLRIYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayLoanTypes Map(AddPayLoanTypesCommand inputItem)
        {
            var entity = new PayLoanTypes() {
                  
  
		PayLoanId = inputItem.PayLoanId,  
  
		PLnTitle = inputItem.PLnTitle,  
  
		PLnElmntRef = inputItem.PLnElmntRef,  
  
		PLnMaxAmnt = inputItem.PLnMaxAmnt,  
  
		PLnDLRef = inputItem.PLnDLRef,  
  
		PLnActive = inputItem.PLnActive, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayLoanTypes Map(PayLoanTypes entity ,EditPayLoanTypesCommand inputItem)
        {
              
  
		entity.PayLoanId = inputItem.PayLoanId;  
  
		entity.PLnTitle = inputItem.PLnTitle;  
  
		entity.PLnElmntRef = inputItem.PLnElmntRef;  
  
		entity.PLnMaxAmnt = inputItem.PLnMaxAmnt;  
  
		entity.PLnDLRef = inputItem.PLnDLRef;  
  
		entity.PLnActive = inputItem.PLnActive; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayLoanTypesDto Map(PayLoanTypes inputItem)
        {
            var dto = new PayLoanTypesDto()
            {
                  
  
		PayLoanId = inputItem.PayLoanId,  
  
		PLnTitle = inputItem.PLnTitle,  
  
		PLnElmntRef = inputItem.PLnElmntRef,  
  
		PLnMaxAmnt = inputItem.PLnMaxAmnt,  
  
		PLnDLRef = inputItem.PLnDLRef,  
  
		PLnActive = inputItem.PLnActive, 
            };
            return dto;
        }

        public static List<PayLoanTypesDto> Map(ICollection<PayLoanTypes> entities)
        {
            var dtos = new List<PayLoanTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayLoanTypesDto()
                {
                      
  
		PayLoanId = inputItem.PayLoanId,  
  
		PLnTitle = inputItem.PLnTitle,  
  
		PLnElmntRef = inputItem.PLnElmntRef,  
  
		PLnMaxAmnt = inputItem.PLnMaxAmnt,  
  
		PLnDLRef = inputItem.PLnDLRef,  
  
		PLnActive = inputItem.PLnActive, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayMonthlyMthd Map(AddPayMonthlyMthdCommand inputItem)
        {
            var entity = new PayMonthlyMthd() {
                  
  
		PayMonthlyMthdId = inputItem.PayMonthlyMthdId,  
  
		PMMTitle = inputItem.PMMTitle,  
  
		PMMType = inputItem.PMMType,  
  
		PMMVals = inputItem.PMMVals, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayMonthlyMthd Map(PayMonthlyMthd entity ,EditPayMonthlyMthdCommand inputItem)
        {
              
  
		entity.PayMonthlyMthdId = inputItem.PayMonthlyMthdId;  
  
		entity.PMMTitle = inputItem.PMMTitle;  
  
		entity.PMMType = inputItem.PMMType;  
  
		entity.PMMVals = inputItem.PMMVals; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayMonthlyMthdDto Map(PayMonthlyMthd inputItem)
        {
            var dto = new PayMonthlyMthdDto()
            {
                  
  
		PayMonthlyMthdId = inputItem.PayMonthlyMthdId,  
  
		PMMTitle = inputItem.PMMTitle,  
  
		PMMType = inputItem.PMMType,  
  
		PMMVals = inputItem.PMMVals, 
            };
            return dto;
        }

        public static List<PayMonthlyMthdDto> Map(ICollection<PayMonthlyMthd> entities)
        {
            var dtos = new List<PayMonthlyMthdDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayMonthlyMthdDto()
                {
                      
  
		PayMonthlyMthdId = inputItem.PayMonthlyMthdId,  
  
		PMMTitle = inputItem.PMMTitle,  
  
		PMMType = inputItem.PMMType,  
  
		PMMVals = inputItem.PMMVals, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayMonthlyVals Map(AddPayMonthlyValsCommand inputItem)
        {
            var entity = new PayMonthlyVals() {
                  
  
		PayMonthlyValId = inputItem.PayMonthlyValId,  
  
		PMVPersRef = inputItem.PMVPersRef,  
  
		PMVElmntRef = inputItem.PMVElmntRef,  
  
		PMVIssueYear = inputItem.PMVIssueYear,  
  
		PMVIssueMonth = inputItem.PMVIssueMonth,  
  
		PMVEffectYear = inputItem.PMVEffectYear,  
  
		PMVEffectMonth = inputItem.PMVEffectMonth,  
  
		PMVDayAmnt = inputItem.PMVDayAmnt,  
  
		PMVHourAmnt = inputItem.PMVHourAmnt,  
  
		PMVMinuteAmnt = inputItem.PMVMinuteAmnt,  
  
		PMVAmount = inputItem.PMVAmount,  
  
		PMVIYearMonth = inputItem.PMVIYearMonth,  
  
		PMVEYearMonth = inputItem.PMVEYearMonth,  
  
		PMVCreator = inputItem.PMVCreator,  
  
		PMVSit = inputItem.PMVSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayMonthlyVals Map(PayMonthlyVals entity ,EditPayMonthlyValsCommand inputItem)
        {
              
  
		entity.PayMonthlyValId = inputItem.PayMonthlyValId;  
  
		entity.PMVPersRef = inputItem.PMVPersRef;  
  
		entity.PMVElmntRef = inputItem.PMVElmntRef;  
  
		entity.PMVIssueYear = inputItem.PMVIssueYear;  
  
		entity.PMVIssueMonth = inputItem.PMVIssueMonth;  
  
		entity.PMVEffectYear = inputItem.PMVEffectYear;  
  
		entity.PMVEffectMonth = inputItem.PMVEffectMonth;  
  
		entity.PMVDayAmnt = inputItem.PMVDayAmnt;  
  
		entity.PMVHourAmnt = inputItem.PMVHourAmnt;  
  
		entity.PMVMinuteAmnt = inputItem.PMVMinuteAmnt;  
  
		entity.PMVAmount = inputItem.PMVAmount;  
  
		entity.PMVIYearMonth = inputItem.PMVIYearMonth;  
  
		entity.PMVEYearMonth = inputItem.PMVEYearMonth;  
  
		entity.PMVCreator = inputItem.PMVCreator;  
  
		entity.PMVSit = inputItem.PMVSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayMonthlyValsDto Map(PayMonthlyVals inputItem)
        {
            var dto = new PayMonthlyValsDto()
            {
                  
  
		PayMonthlyValId = inputItem.PayMonthlyValId,  
  
		PMVPersRef = inputItem.PMVPersRef,  
  
		PMVElmntRef = inputItem.PMVElmntRef,  
  
		PMVIssueYear = inputItem.PMVIssueYear,  
  
		PMVIssueMonth = inputItem.PMVIssueMonth,  
  
		PMVEffectYear = inputItem.PMVEffectYear,  
  
		PMVEffectMonth = inputItem.PMVEffectMonth,  
  
		PMVDayAmnt = inputItem.PMVDayAmnt,  
  
		PMVHourAmnt = inputItem.PMVHourAmnt,  
  
		PMVMinuteAmnt = inputItem.PMVMinuteAmnt,  
  
		PMVAmount = inputItem.PMVAmount,  
  
		PMVIYearMonth = inputItem.PMVIYearMonth,  
  
		PMVEYearMonth = inputItem.PMVEYearMonth,  
  
		PMVCreator = inputItem.PMVCreator,  
  
		PMVSit = inputItem.PMVSit, 
            };
            return dto;
        }

        public static List<PayMonthlyValsDto> Map(ICollection<PayMonthlyVals> entities)
        {
            var dtos = new List<PayMonthlyValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayMonthlyValsDto()
                {
                      
  
		PayMonthlyValId = inputItem.PayMonthlyValId,  
  
		PMVPersRef = inputItem.PMVPersRef,  
  
		PMVElmntRef = inputItem.PMVElmntRef,  
  
		PMVIssueYear = inputItem.PMVIssueYear,  
  
		PMVIssueMonth = inputItem.PMVIssueMonth,  
  
		PMVEffectYear = inputItem.PMVEffectYear,  
  
		PMVEffectMonth = inputItem.PMVEffectMonth,  
  
		PMVDayAmnt = inputItem.PMVDayAmnt,  
  
		PMVHourAmnt = inputItem.PMVHourAmnt,  
  
		PMVMinuteAmnt = inputItem.PMVMinuteAmnt,  
  
		PMVAmount = inputItem.PMVAmount,  
  
		PMVIYearMonth = inputItem.PMVIYearMonth,  
  
		PMVEYearMonth = inputItem.PMVEYearMonth,  
  
		PMVCreator = inputItem.PMVCreator,  
  
		PMVSit = inputItem.PMVSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayPersEnd Map(AddPayPersEndCommand inputItem)
        {
            var entity = new PayPersEnd() {
                  
  
		PayPersEndId = inputItem.PayPersEndId,  
  
		PPEYearNum = inputItem.PPEYearNum,  
  
		PPEMonthNum = inputItem.PPEMonthNum,  
  
		PPEPersRef = inputItem.PPEPersRef,  
  
		PPEElmntRef = inputItem.PPEElmntRef,  
  
		PPETitle = inputItem.PPETitle,  
  
		PPEBase = inputItem.PPEBase,  
  
		PPEVal = inputItem.PPEVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayPersEnd Map(PayPersEnd entity ,EditPayPersEndCommand inputItem)
        {
              
  
		entity.PayPersEndId = inputItem.PayPersEndId;  
  
		entity.PPEYearNum = inputItem.PPEYearNum;  
  
		entity.PPEMonthNum = inputItem.PPEMonthNum;  
  
		entity.PPEPersRef = inputItem.PPEPersRef;  
  
		entity.PPEElmntRef = inputItem.PPEElmntRef;  
  
		entity.PPETitle = inputItem.PPETitle;  
  
		entity.PPEBase = inputItem.PPEBase;  
  
		entity.PPEVal = inputItem.PPEVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayPersEndDto Map(PayPersEnd inputItem)
        {
            var dto = new PayPersEndDto()
            {
                  
  
		PayPersEndId = inputItem.PayPersEndId,  
  
		PPEYearNum = inputItem.PPEYearNum,  
  
		PPEMonthNum = inputItem.PPEMonthNum,  
  
		PPEPersRef = inputItem.PPEPersRef,  
  
		PPEElmntRef = inputItem.PPEElmntRef,  
  
		PPETitle = inputItem.PPETitle,  
  
		PPEBase = inputItem.PPEBase,  
  
		PPEVal = inputItem.PPEVal, 
            };
            return dto;
        }

        public static List<PayPersEndDto> Map(ICollection<PayPersEnd> entities)
        {
            var dtos = new List<PayPersEndDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayPersEndDto()
                {
                      
  
		PayPersEndId = inputItem.PayPersEndId,  
  
		PPEYearNum = inputItem.PPEYearNum,  
  
		PPEMonthNum = inputItem.PPEMonthNum,  
  
		PPEPersRef = inputItem.PPEPersRef,  
  
		PPEElmntRef = inputItem.PPEElmntRef,  
  
		PPETitle = inputItem.PPETitle,  
  
		PPEBase = inputItem.PPEBase,  
  
		PPEVal = inputItem.PPEVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayRepLists Map(AddPayRepListsCommand inputItem)
        {
            var entity = new PayRepLists() {
                  
  
		PayRepListId = inputItem.PayRepListId,  
  
		PRLTitle = inputItem.PRLTitle,  
  
		PRLFileName = inputItem.PRLFileName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayRepLists Map(PayRepLists entity ,EditPayRepListsCommand inputItem)
        {
              
  
		entity.PayRepListId = inputItem.PayRepListId;  
  
		entity.PRLTitle = inputItem.PRLTitle;  
  
		entity.PRLFileName = inputItem.PRLFileName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayRepListsDto Map(PayRepLists inputItem)
        {
            var dto = new PayRepListsDto()
            {
                  
  
		PayRepListId = inputItem.PayRepListId,  
  
		PRLTitle = inputItem.PRLTitle,  
  
		PRLFileName = inputItem.PRLFileName, 
            };
            return dto;
        }

        public static List<PayRepListsDto> Map(ICollection<PayRepLists> entities)
        {
            var dtos = new List<PayRepListsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayRepListsDto()
                {
                      
  
		PayRepListId = inputItem.PayRepListId,  
  
		PRLTitle = inputItem.PRLTitle,  
  
		PRLFileName = inputItem.PRLFileName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaySystems Map(AddPaySystemsCommand inputItem)
        {
            var entity = new PaySystems() {
                  
  
		PaySystemId = inputItem.PaySystemId,  
  
		PSTitle = inputItem.PSTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaySystems Map(PaySystems entity ,EditPaySystemsCommand inputItem)
        {
              
  
		entity.PaySystemId = inputItem.PaySystemId;  
  
		entity.PSTitle = inputItem.PSTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaySystemsDto Map(PaySystems inputItem)
        {
            var dto = new PaySystemsDto()
            {
                  
  
		PaySystemId = inputItem.PaySystemId,  
  
		PSTitle = inputItem.PSTitle, 
            };
            return dto;
        }

        public static List<PaySystemsDto> Map(ICollection<PaySystems> entities)
        {
            var dtos = new List<PaySystemsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaySystemsDto()
                {
                      
  
		PaySystemId = inputItem.PaySystemId,  
  
		PSTitle = inputItem.PSTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayTaxComps Map(AddPayTaxCompsCommand inputItem)
        {
            var entity = new PayTaxComps() {
                  
  
		PayTaxCompId = inputItem.PayTaxCompId,  
  
		PTCCompRef = inputItem.PTCCompRef,  
  
		PTCCompType = inputItem.PTCCompType,  
  
		PTCCompKind = inputItem.PTCCompKind,  
  
		PTCBrnName = inputItem.PTCBrnName,  
  
		PTCPhone = inputItem.PTCPhone,  
  
		PTCCode = inputItem.PTCCode,  
  
		PTCBrId = inputItem.PTCBrId,  
  
		PTCFName1 = inputItem.PTCFName1,  
  
		PTCLName1 = inputItem.PTCLName1,  
  
		PTCNatCode1 = inputItem.PTCNatCode1,  
  
		PTCPost1 = inputItem.PTCPost1,  
  
		PTCFName2 = inputItem.PTCFName2,  
  
		PTCLName2 = inputItem.PTCLName2,  
  
		PTCNatCode2 = inputItem.PTCNatCode2,  
  
		PTCPost2 = inputItem.PTCPost2, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayTaxComps Map(PayTaxComps entity ,EditPayTaxCompsCommand inputItem)
        {
              
  
		entity.PayTaxCompId = inputItem.PayTaxCompId;  
  
		entity.PTCCompRef = inputItem.PTCCompRef;  
  
		entity.PTCCompType = inputItem.PTCCompType;  
  
		entity.PTCCompKind = inputItem.PTCCompKind;  
  
		entity.PTCBrnName = inputItem.PTCBrnName;  
  
		entity.PTCPhone = inputItem.PTCPhone;  
  
		entity.PTCCode = inputItem.PTCCode;  
  
		entity.PTCBrId = inputItem.PTCBrId;  
  
		entity.PTCFName1 = inputItem.PTCFName1;  
  
		entity.PTCLName1 = inputItem.PTCLName1;  
  
		entity.PTCNatCode1 = inputItem.PTCNatCode1;  
  
		entity.PTCPost1 = inputItem.PTCPost1;  
  
		entity.PTCFName2 = inputItem.PTCFName2;  
  
		entity.PTCLName2 = inputItem.PTCLName2;  
  
		entity.PTCNatCode2 = inputItem.PTCNatCode2;  
  
		entity.PTCPost2 = inputItem.PTCPost2; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayTaxCompsDto Map(PayTaxComps inputItem)
        {
            var dto = new PayTaxCompsDto()
            {
                  
  
		PayTaxCompId = inputItem.PayTaxCompId,  
  
		PTCCompRef = inputItem.PTCCompRef,  
  
		PTCCompType = inputItem.PTCCompType,  
  
		PTCCompKind = inputItem.PTCCompKind,  
  
		PTCBrnName = inputItem.PTCBrnName,  
  
		PTCPhone = inputItem.PTCPhone,  
  
		PTCCode = inputItem.PTCCode,  
  
		PTCBrId = inputItem.PTCBrId,  
  
		PTCFName1 = inputItem.PTCFName1,  
  
		PTCLName1 = inputItem.PTCLName1,  
  
		PTCNatCode1 = inputItem.PTCNatCode1,  
  
		PTCPost1 = inputItem.PTCPost1,  
  
		PTCFName2 = inputItem.PTCFName2,  
  
		PTCLName2 = inputItem.PTCLName2,  
  
		PTCNatCode2 = inputItem.PTCNatCode2,  
  
		PTCPost2 = inputItem.PTCPost2, 
            };
            return dto;
        }

        public static List<PayTaxCompsDto> Map(ICollection<PayTaxComps> entities)
        {
            var dtos = new List<PayTaxCompsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayTaxCompsDto()
                {
                      
  
		PayTaxCompId = inputItem.PayTaxCompId,  
  
		PTCCompRef = inputItem.PTCCompRef,  
  
		PTCCompType = inputItem.PTCCompType,  
  
		PTCCompKind = inputItem.PTCCompKind,  
  
		PTCBrnName = inputItem.PTCBrnName,  
  
		PTCPhone = inputItem.PTCPhone,  
  
		PTCCode = inputItem.PTCCode,  
  
		PTCBrId = inputItem.PTCBrId,  
  
		PTCFName1 = inputItem.PTCFName1,  
  
		PTCLName1 = inputItem.PTCLName1,  
  
		PTCNatCode1 = inputItem.PTCNatCode1,  
  
		PTCPost1 = inputItem.PTCPost1,  
  
		PTCFName2 = inputItem.PTCFName2,  
  
		PTCLName2 = inputItem.PTCLName2,  
  
		PTCNatCode2 = inputItem.PTCNatCode2,  
  
		PTCPost2 = inputItem.PTCPost2, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayTaxDet Map(AddPayTaxDetCommand inputItem)
        {
            var entity = new PayTaxDet() {
                  
  
		PayTaxTblDetId = inputItem.PayTaxTblDetId,  
  
		PTTDTableRef = inputItem.PTTDTableRef,  
  
		PTTDFromVal = inputItem.PTTDFromVal,  
  
		PTTDToVal = inputItem.PTTDToVal,  
  
		PTTDValPrc = inputItem.PTTDValPrc,  
  
		PTTDTax = inputItem.PTTDTax, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayTaxDet Map(PayTaxDet entity ,EditPayTaxDetCommand inputItem)
        {
              
  
		entity.PayTaxTblDetId = inputItem.PayTaxTblDetId;  
  
		entity.PTTDTableRef = inputItem.PTTDTableRef;  
  
		entity.PTTDFromVal = inputItem.PTTDFromVal;  
  
		entity.PTTDToVal = inputItem.PTTDToVal;  
  
		entity.PTTDValPrc = inputItem.PTTDValPrc;  
  
		entity.PTTDTax = inputItem.PTTDTax; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayTaxDetDto Map(PayTaxDet inputItem)
        {
            var dto = new PayTaxDetDto()
            {
                  
  
		PayTaxTblDetId = inputItem.PayTaxTblDetId,  
  
		PTTDTableRef = inputItem.PTTDTableRef,  
  
		PTTDFromVal = inputItem.PTTDFromVal,  
  
		PTTDToVal = inputItem.PTTDToVal,  
  
		PTTDValPrc = inputItem.PTTDValPrc,  
  
		PTTDTax = inputItem.PTTDTax, 
            };
            return dto;
        }

        public static List<PayTaxDetDto> Map(ICollection<PayTaxDet> entities)
        {
            var dtos = new List<PayTaxDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayTaxDetDto()
                {
                      
  
		PayTaxTblDetId = inputItem.PayTaxTblDetId,  
  
		PTTDTableRef = inputItem.PTTDTableRef,  
  
		PTTDFromVal = inputItem.PTTDFromVal,  
  
		PTTDToVal = inputItem.PTTDToVal,  
  
		PTTDValPrc = inputItem.PTTDValPrc,  
  
		PTTDTax = inputItem.PTTDTax, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayTaxTable Map(AddPayTaxTableCommand inputItem)
        {
            var entity = new PayTaxTable() {
                  
  
		PayTaxTblId = inputItem.PayTaxTblId,  
  
		PTTTitle = inputItem.PTTTitle,  
  
		PTTIssueYear = inputItem.PTTIssueYear,  
  
		PTTIssueMonth = inputItem.PTTIssueMonth,  
  
		PTTGrpType = inputItem.PTTGrpType,  
  
		PTTIYearMonth = inputItem.PTTIYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayTaxTable Map(PayTaxTable entity ,EditPayTaxTableCommand inputItem)
        {
              
  
		entity.PayTaxTblId = inputItem.PayTaxTblId;  
  
		entity.PTTTitle = inputItem.PTTTitle;  
  
		entity.PTTIssueYear = inputItem.PTTIssueYear;  
  
		entity.PTTIssueMonth = inputItem.PTTIssueMonth;  
  
		entity.PTTGrpType = inputItem.PTTGrpType;  
  
		entity.PTTIYearMonth = inputItem.PTTIYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayTaxTableDto Map(PayTaxTable inputItem)
        {
            var dto = new PayTaxTableDto()
            {
                  
  
		PayTaxTblId = inputItem.PayTaxTblId,  
  
		PTTTitle = inputItem.PTTTitle,  
  
		PTTIssueYear = inputItem.PTTIssueYear,  
  
		PTTIssueMonth = inputItem.PTTIssueMonth,  
  
		PTTGrpType = inputItem.PTTGrpType,  
  
		PTTIYearMonth = inputItem.PTTIYearMonth, 
            };
            return dto;
        }

        public static List<PayTaxTableDto> Map(ICollection<PayTaxTable> entities)
        {
            var dtos = new List<PayTaxTableDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayTaxTableDto()
                {
                      
  
		PayTaxTblId = inputItem.PayTaxTblId,  
  
		PTTTitle = inputItem.PTTTitle,  
  
		PTTIssueYear = inputItem.PTTIssueYear,  
  
		PTTIssueMonth = inputItem.PTTIssueMonth,  
  
		PTTGrpType = inputItem.PTTGrpType,  
  
		PTTIYearMonth = inputItem.PTTIYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayUserField Map(AddPayUserFieldCommand inputItem)
        {
            var entity = new PayUserField() {
                  
  
		PayUserFieldId = inputItem.PayUserFieldId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFForumula = inputItem.PUFForumula, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayUserField Map(PayUserField entity ,EditPayUserFieldCommand inputItem)
        {
              
  
		entity.PayUserFieldId = inputItem.PayUserFieldId;  
  
		entity.PUFTitle = inputItem.PUFTitle;  
  
		entity.PUFForumula = inputItem.PUFForumula; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayUserFieldDto Map(PayUserField inputItem)
        {
            var dto = new PayUserFieldDto()
            {
                  
  
		PayUserFieldId = inputItem.PayUserFieldId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFForumula = inputItem.PUFForumula, 
            };
            return dto;
        }

        public static List<PayUserFieldDto> Map(ICollection<PayUserField> entities)
        {
            var dtos = new List<PayUserFieldDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayUserFieldDto()
                {
                      
  
		PayUserFieldId = inputItem.PayUserFieldId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFForumula = inputItem.PUFForumula, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayUserFuns Map(AddPayUserFunsCommand inputItem)
        {
            var entity = new PayUserFuns() {
                  
  
		PayUserFuncId = inputItem.PayUserFuncId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFName = inputItem.PUFName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayUserFuns Map(PayUserFuns entity ,EditPayUserFunsCommand inputItem)
        {
              
  
		entity.PayUserFuncId = inputItem.PayUserFuncId;  
  
		entity.PUFTitle = inputItem.PUFTitle;  
  
		entity.PUFName = inputItem.PUFName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayUserFunsDto Map(PayUserFuns inputItem)
        {
            var dto = new PayUserFunsDto()
            {
                  
  
		PayUserFuncId = inputItem.PayUserFuncId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFName = inputItem.PUFName, 
            };
            return dto;
        }

        public static List<PayUserFunsDto> Map(ICollection<PayUserFuns> entities)
        {
            var dtos = new List<PayUserFunsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayUserFunsDto()
                {
                      
  
		PayUserFuncId = inputItem.PayUserFuncId,  
  
		PUFTitle = inputItem.PUFTitle,  
  
		PUFName = inputItem.PUFName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayVacMonthly Map(AddPayVacMonthlyCommand inputItem)
        {
            var entity = new PayVacMonthly() {
                  
  
		PayVacMonthlyId = inputItem.PayVacMonthlyId,  
  
		PVMPersRef = inputItem.PVMPersRef,  
  
		PVMVacRef = inputItem.PVMVacRef,  
  
		PVMIssueYear = inputItem.PVMIssueYear,  
  
		PVMIssueMonth = inputItem.PVMIssueMonth,  
  
		PVMEffectYear = inputItem.PVMEffectYear,  
  
		PVMEffectMonth = inputItem.PVMEffectMonth,  
  
		PVMDay = inputItem.PVMDay,  
  
		PVMHour = inputItem.PVMHour,  
  
		PVMMinute = inputItem.PVMMinute,  
  
		PVMIYearMonth = inputItem.PVMIYearMonth,  
  
		PVMEYearMonth = inputItem.PVMEYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayVacMonthly Map(PayVacMonthly entity ,EditPayVacMonthlyCommand inputItem)
        {
              
  
		entity.PayVacMonthlyId = inputItem.PayVacMonthlyId;  
  
		entity.PVMPersRef = inputItem.PVMPersRef;  
  
		entity.PVMVacRef = inputItem.PVMVacRef;  
  
		entity.PVMIssueYear = inputItem.PVMIssueYear;  
  
		entity.PVMIssueMonth = inputItem.PVMIssueMonth;  
  
		entity.PVMEffectYear = inputItem.PVMEffectYear;  
  
		entity.PVMEffectMonth = inputItem.PVMEffectMonth;  
  
		entity.PVMDay = inputItem.PVMDay;  
  
		entity.PVMHour = inputItem.PVMHour;  
  
		entity.PVMMinute = inputItem.PVMMinute;  
  
		entity.PVMIYearMonth = inputItem.PVMIYearMonth;  
  
		entity.PVMEYearMonth = inputItem.PVMEYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayVacMonthlyDto Map(PayVacMonthly inputItem)
        {
            var dto = new PayVacMonthlyDto()
            {
                  
  
		PayVacMonthlyId = inputItem.PayVacMonthlyId,  
  
		PVMPersRef = inputItem.PVMPersRef,  
  
		PVMVacRef = inputItem.PVMVacRef,  
  
		PVMIssueYear = inputItem.PVMIssueYear,  
  
		PVMIssueMonth = inputItem.PVMIssueMonth,  
  
		PVMEffectYear = inputItem.PVMEffectYear,  
  
		PVMEffectMonth = inputItem.PVMEffectMonth,  
  
		PVMDay = inputItem.PVMDay,  
  
		PVMHour = inputItem.PVMHour,  
  
		PVMMinute = inputItem.PVMMinute,  
  
		PVMIYearMonth = inputItem.PVMIYearMonth,  
  
		PVMEYearMonth = inputItem.PVMEYearMonth, 
            };
            return dto;
        }

        public static List<PayVacMonthlyDto> Map(ICollection<PayVacMonthly> entities)
        {
            var dtos = new List<PayVacMonthlyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayVacMonthlyDto()
                {
                      
  
		PayVacMonthlyId = inputItem.PayVacMonthlyId,  
  
		PVMPersRef = inputItem.PVMPersRef,  
  
		PVMVacRef = inputItem.PVMVacRef,  
  
		PVMIssueYear = inputItem.PVMIssueYear,  
  
		PVMIssueMonth = inputItem.PVMIssueMonth,  
  
		PVMEffectYear = inputItem.PVMEffectYear,  
  
		PVMEffectMonth = inputItem.PVMEffectMonth,  
  
		PVMDay = inputItem.PVMDay,  
  
		PVMHour = inputItem.PVMHour,  
  
		PVMMinute = inputItem.PVMMinute,  
  
		PVMIYearMonth = inputItem.PVMIYearMonth,  
  
		PVMEYearMonth = inputItem.PVMEYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayVacRemain Map(AddPayVacRemainCommand inputItem)
        {
            var entity = new PayVacRemain() {
                  
  
		PayVacRemainId = inputItem.PayVacRemainId,  
  
		PVRPersRef = inputItem.PVRPersRef,  
  
		PVRVacRef = inputItem.PVRVacRef,  
  
		PVRYear = inputItem.PVRYear,  
  
		PVRMonth = inputItem.PVRMonth,  
  
		PVRDay = inputItem.PVRDay,  
  
		PVRHour = inputItem.PVRHour,  
  
		PVRMinute = inputItem.PVRMinute,  
  
		PVRYearMonth = inputItem.PVRYearMonth, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayVacRemain Map(PayVacRemain entity ,EditPayVacRemainCommand inputItem)
        {
              
  
		entity.PayVacRemainId = inputItem.PayVacRemainId;  
  
		entity.PVRPersRef = inputItem.PVRPersRef;  
  
		entity.PVRVacRef = inputItem.PVRVacRef;  
  
		entity.PVRYear = inputItem.PVRYear;  
  
		entity.PVRMonth = inputItem.PVRMonth;  
  
		entity.PVRDay = inputItem.PVRDay;  
  
		entity.PVRHour = inputItem.PVRHour;  
  
		entity.PVRMinute = inputItem.PVRMinute;  
  
		entity.PVRYearMonth = inputItem.PVRYearMonth; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayVacRemainDto Map(PayVacRemain inputItem)
        {
            var dto = new PayVacRemainDto()
            {
                  
  
		PayVacRemainId = inputItem.PayVacRemainId,  
  
		PVRPersRef = inputItem.PVRPersRef,  
  
		PVRVacRef = inputItem.PVRVacRef,  
  
		PVRYear = inputItem.PVRYear,  
  
		PVRMonth = inputItem.PVRMonth,  
  
		PVRDay = inputItem.PVRDay,  
  
		PVRHour = inputItem.PVRHour,  
  
		PVRMinute = inputItem.PVRMinute,  
  
		PVRYearMonth = inputItem.PVRYearMonth, 
            };
            return dto;
        }

        public static List<PayVacRemainDto> Map(ICollection<PayVacRemain> entities)
        {
            var dtos = new List<PayVacRemainDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayVacRemainDto()
                {
                      
  
		PayVacRemainId = inputItem.PayVacRemainId,  
  
		PVRPersRef = inputItem.PVRPersRef,  
  
		PVRVacRef = inputItem.PVRVacRef,  
  
		PVRYear = inputItem.PVRYear,  
  
		PVRMonth = inputItem.PVRMonth,  
  
		PVRDay = inputItem.PVRDay,  
  
		PVRHour = inputItem.PVRHour,  
  
		PVRMinute = inputItem.PVRMinute,  
  
		PVRYearMonth = inputItem.PVRYearMonth, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayValStatAmnt Map(AddPayValStatAmntCommand inputItem)
        {
            var entity = new PayValStatAmnt() {
                  
  
		PVSAStatRef = inputItem.PVSAStatRef,  
  
		PVSAElmntRef = inputItem.PVSAElmntRef,  
  
		PVSAAmount = inputItem.PVSAAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayValStatAmnt Map(PayValStatAmnt entity ,EditPayValStatAmntCommand inputItem)
        {
              
  
		entity.PVSAStatRef = inputItem.PVSAStatRef;  
  
		entity.PVSAElmntRef = inputItem.PVSAElmntRef;  
  
		entity.PVSAAmount = inputItem.PVSAAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayValStatAmntDto Map(PayValStatAmnt inputItem)
        {
            var dto = new PayValStatAmntDto()
            {
                  
  
		PVSAStatRef = inputItem.PVSAStatRef,  
  
		PVSAElmntRef = inputItem.PVSAElmntRef,  
  
		PVSAAmount = inputItem.PVSAAmount, 
            };
            return dto;
        }

        public static List<PayValStatAmntDto> Map(ICollection<PayValStatAmnt> entities)
        {
            var dtos = new List<PayValStatAmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayValStatAmntDto()
                {
                      
  
		PVSAStatRef = inputItem.PVSAStatRef,  
  
		PVSAElmntRef = inputItem.PVSAElmntRef,  
  
		PVSAAmount = inputItem.PVSAAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayValStats Map(AddPayValStatsCommand inputItem)
        {
            var entity = new PayValStats() {
                  
  
		PayValStatId = inputItem.PayValStatId,  
  
		PVSPersRef = inputItem.PVSPersRef,  
  
		PVSIssueDate = inputItem.PVSIssueDate,  
  
		PVSEffectDate = inputItem.PVSEffectDate,  
  
		PVSDescr = inputItem.PVSDescr,  
  
		PVSGrpStatRef = inputItem.PVSGrpStatRef,  
  
		PVSIYrMonth = inputItem.PVSIYrMonth,  
  
		PVSEYrMonth = inputItem.PVSEYrMonth,  
  
		PVSLastChange = inputItem.PVSLastChange,  
  
		PVSCreator = inputItem.PVSCreator,  
  
		PVSSit = inputItem.PVSSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayValStats Map(PayValStats entity ,EditPayValStatsCommand inputItem)
        {
              
  
		entity.PayValStatId = inputItem.PayValStatId;  
  
		entity.PVSPersRef = inputItem.PVSPersRef;  
  
		entity.PVSIssueDate = inputItem.PVSIssueDate;  
  
		entity.PVSEffectDate = inputItem.PVSEffectDate;  
  
		entity.PVSDescr = inputItem.PVSDescr;  
  
		entity.PVSGrpStatRef = inputItem.PVSGrpStatRef;  
  
		entity.PVSIYrMonth = inputItem.PVSIYrMonth;  
  
		entity.PVSEYrMonth = inputItem.PVSEYrMonth;  
  
		entity.PVSLastChange = inputItem.PVSLastChange;  
  
		entity.PVSCreator = inputItem.PVSCreator;  
  
		entity.PVSSit = inputItem.PVSSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayValStatsDto Map(PayValStats inputItem)
        {
            var dto = new PayValStatsDto()
            {
                  
  
		PayValStatId = inputItem.PayValStatId,  
  
		PVSPersRef = inputItem.PVSPersRef,  
  
		PVSIssueDate = inputItem.PVSIssueDate,  
  
		PVSEffectDate = inputItem.PVSEffectDate,  
  
		PVSDescr = inputItem.PVSDescr,  
  
		PVSGrpStatRef = inputItem.PVSGrpStatRef,  
  
		PVSIYrMonth = inputItem.PVSIYrMonth,  
  
		PVSEYrMonth = inputItem.PVSEYrMonth,  
  
		PVSLastChange = inputItem.PVSLastChange,  
  
		PVSCreator = inputItem.PVSCreator,  
  
		PVSSit = inputItem.PVSSit, 
            };
            return dto;
        }

        public static List<PayValStatsDto> Map(ICollection<PayValStats> entities)
        {
            var dtos = new List<PayValStatsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayValStatsDto()
                {
                      
  
		PayValStatId = inputItem.PayValStatId,  
  
		PVSPersRef = inputItem.PVSPersRef,  
  
		PVSIssueDate = inputItem.PVSIssueDate,  
  
		PVSEffectDate = inputItem.PVSEffectDate,  
  
		PVSDescr = inputItem.PVSDescr,  
  
		PVSGrpStatRef = inputItem.PVSGrpStatRef,  
  
		PVSIYrMonth = inputItem.PVSIYrMonth,  
  
		PVSEYrMonth = inputItem.PVSEYrMonth,  
  
		PVSLastChange = inputItem.PVSLastChange,  
  
		PVSCreator = inputItem.PVSCreator,  
  
		PVSSit = inputItem.PVSSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayVchDet Map(AddPayVchDetCommand inputItem)
        {
            var entity = new PayVchDet() {
                  
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchTypeRef = inputItem.PayVchTypeRef,  
  
		PVDDescr = inputItem.PVDDescr,  
  
		PVDElmntRef = inputItem.PVDElmntRef,  
  
		PVDSLRef = inputItem.PVDSLRef,  
  
		PVDBalance = inputItem.PVDBalance,  
  
		PVDKind = inputItem.PVDKind,  
  
		PVDDLFour = inputItem.PVDDLFour,  
  
		PVDDLFive = inputItem.PVDDLFive,  
  
		PVDDLSix = inputItem.PVDDLSix,  
  
		PVDDL4Code = inputItem.PVDDL4Code,  
  
		PVDDL5Code = inputItem.PVDDL5Code,  
  
		PVDDL6Code = inputItem.PVDDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayVchDet Map(PayVchDet entity ,EditPayVchDetCommand inputItem)
        {
              
  
		entity.PayVchDetId = inputItem.PayVchDetId;  
  
		entity.PayVchTypeRef = inputItem.PayVchTypeRef;  
  
		entity.PVDDescr = inputItem.PVDDescr;  
  
		entity.PVDElmntRef = inputItem.PVDElmntRef;  
  
		entity.PVDSLRef = inputItem.PVDSLRef;  
  
		entity.PVDBalance = inputItem.PVDBalance;  
  
		entity.PVDKind = inputItem.PVDKind;  
  
		entity.PVDDLFour = inputItem.PVDDLFour;  
  
		entity.PVDDLFive = inputItem.PVDDLFive;  
  
		entity.PVDDLSix = inputItem.PVDDLSix;  
  
		entity.PVDDL4Code = inputItem.PVDDL4Code;  
  
		entity.PVDDL5Code = inputItem.PVDDL5Code;  
  
		entity.PVDDL6Code = inputItem.PVDDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayVchDetDto Map(PayVchDet inputItem)
        {
            var dto = new PayVchDetDto()
            {
                  
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchTypeRef = inputItem.PayVchTypeRef,  
  
		PVDDescr = inputItem.PVDDescr,  
  
		PVDElmntRef = inputItem.PVDElmntRef,  
  
		PVDSLRef = inputItem.PVDSLRef,  
  
		PVDBalance = inputItem.PVDBalance,  
  
		PVDKind = inputItem.PVDKind,  
  
		PVDDLFour = inputItem.PVDDLFour,  
  
		PVDDLFive = inputItem.PVDDLFive,  
  
		PVDDLSix = inputItem.PVDDLSix,  
  
		PVDDL4Code = inputItem.PVDDL4Code,  
  
		PVDDL5Code = inputItem.PVDDL5Code,  
  
		PVDDL6Code = inputItem.PVDDL6Code, 
            };
            return dto;
        }

        public static List<PayVchDetDto> Map(ICollection<PayVchDet> entities)
        {
            var dtos = new List<PayVchDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayVchDetDto()
                {
                      
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchTypeRef = inputItem.PayVchTypeRef,  
  
		PVDDescr = inputItem.PVDDescr,  
  
		PVDElmntRef = inputItem.PVDElmntRef,  
  
		PVDSLRef = inputItem.PVDSLRef,  
  
		PVDBalance = inputItem.PVDBalance,  
  
		PVDKind = inputItem.PVDKind,  
  
		PVDDLFour = inputItem.PVDDLFour,  
  
		PVDDLFive = inputItem.PVDDLFive,  
  
		PVDDLSix = inputItem.PVDDLSix,  
  
		PVDDL4Code = inputItem.PVDDL4Code,  
  
		PVDDL5Code = inputItem.PVDDL5Code,  
  
		PVDDL6Code = inputItem.PVDDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayVchDetInfs Map(AddPayVchDetInfsCommand inputItem)
        {
            var entity = new PayVchDetInfs() {
                  
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchDetRef = inputItem.PayVchDetRef,  
  
		PVDEmpRef = inputItem.PVDEmpRef,  
  
		PVDCostCntrRef = inputItem.PVDCostCntrRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayVchDetInfs Map(PayVchDetInfs entity ,EditPayVchDetInfsCommand inputItem)
        {
              
  
		entity.PayVchDetId = inputItem.PayVchDetId;  
  
		entity.PayVchDetRef = inputItem.PayVchDetRef;  
  
		entity.PVDEmpRef = inputItem.PVDEmpRef;  
  
		entity.PVDCostCntrRef = inputItem.PVDCostCntrRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayVchDetInfsDto Map(PayVchDetInfs inputItem)
        {
            var dto = new PayVchDetInfsDto()
            {
                  
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchDetRef = inputItem.PayVchDetRef,  
  
		PVDEmpRef = inputItem.PVDEmpRef,  
  
		PVDCostCntrRef = inputItem.PVDCostCntrRef, 
            };
            return dto;
        }

        public static List<PayVchDetInfsDto> Map(ICollection<PayVchDetInfs> entities)
        {
            var dtos = new List<PayVchDetInfsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayVchDetInfsDto()
                {
                      
  
		PayVchDetId = inputItem.PayVchDetId,  
  
		PayVchDetRef = inputItem.PayVchDetRef,  
  
		PVDEmpRef = inputItem.PVDEmpRef,  
  
		PVDCostCntrRef = inputItem.PVDCostCntrRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayVchType Map(AddPayVchTypeCommand inputItem)
        {
            var entity = new PayVchType() {
                  
  
		PayVchTypeId = inputItem.PayVchTypeId,  
  
		PVTTitle = inputItem.PVTTitle,  
  
		PVTType = inputItem.PVTType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayVchType Map(PayVchType entity ,EditPayVchTypeCommand inputItem)
        {
              
  
		entity.PayVchTypeId = inputItem.PayVchTypeId;  
  
		entity.PVTTitle = inputItem.PVTTitle;  
  
		entity.PVTType = inputItem.PVTType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayVchTypeDto Map(PayVchType inputItem)
        {
            var dto = new PayVchTypeDto()
            {
                  
  
		PayVchTypeId = inputItem.PayVchTypeId,  
  
		PVTTitle = inputItem.PVTTitle,  
  
		PVTType = inputItem.PVTType, 
            };
            return dto;
        }

        public static List<PayVchTypeDto> Map(ICollection<PayVchType> entities)
        {
            var dtos = new List<PayVchTypeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayVchTypeDto()
                {
                      
  
		PayVchTypeId = inputItem.PayVchTypeId,  
  
		PVTTitle = inputItem.PVTTitle,  
  
		PVTType = inputItem.PVTType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayWorkLimit Map(AddPayWorkLimitCommand inputItem)
        {
            var entity = new PayWorkLimit() {
                  
  
		PWLEmpRef = inputItem.PWLEmpRef,  
  
		PWLGrpRef = inputItem.PWLGrpRef,  
  
		PWLElmntRef = inputItem.PWLElmntRef,  
  
		PWLYearNum = inputItem.PWLYearNum,  
  
		PWLMonthNum = inputItem.PWLMonthNum,  
  
		PWLDay = inputItem.PWLDay,  
  
		PWLHour = inputItem.PWLHour,  
  
		PWLMinute = inputItem.PWLMinute, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayWorkLimit Map(PayWorkLimit entity ,EditPayWorkLimitCommand inputItem)
        {
              
  
		entity.PWLEmpRef = inputItem.PWLEmpRef;  
  
		entity.PWLGrpRef = inputItem.PWLGrpRef;  
  
		entity.PWLElmntRef = inputItem.PWLElmntRef;  
  
		entity.PWLYearNum = inputItem.PWLYearNum;  
  
		entity.PWLMonthNum = inputItem.PWLMonthNum;  
  
		entity.PWLDay = inputItem.PWLDay;  
  
		entity.PWLHour = inputItem.PWLHour;  
  
		entity.PWLMinute = inputItem.PWLMinute; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayWorkLimitDto Map(PayWorkLimit inputItem)
        {
            var dto = new PayWorkLimitDto()
            {
                  
  
		PWLEmpRef = inputItem.PWLEmpRef,  
  
		PWLGrpRef = inputItem.PWLGrpRef,  
  
		PWLElmntRef = inputItem.PWLElmntRef,  
  
		PWLYearNum = inputItem.PWLYearNum,  
  
		PWLMonthNum = inputItem.PWLMonthNum,  
  
		PWLDay = inputItem.PWLDay,  
  
		PWLHour = inputItem.PWLHour,  
  
		PWLMinute = inputItem.PWLMinute, 
            };
            return dto;
        }

        public static List<PayWorkLimitDto> Map(ICollection<PayWorkLimit> entities)
        {
            var dtos = new List<PayWorkLimitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayWorkLimitDto()
                {
                      
  
		PWLEmpRef = inputItem.PWLEmpRef,  
  
		PWLGrpRef = inputItem.PWLGrpRef,  
  
		PWLElmntRef = inputItem.PWLElmntRef,  
  
		PWLYearNum = inputItem.PWLYearNum,  
  
		PWLMonthNum = inputItem.PWLMonthNum,  
  
		PWLDay = inputItem.PWLDay,  
  
		PWLHour = inputItem.PWLHour,  
  
		PWLMinute = inputItem.PWLMinute, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
