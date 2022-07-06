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
                
        
        public static AccAnalyse Map(AddAccAnalyseCommand inputItem)
        {
            var entity = new AccAnalyse() {
                  
  
		DebitVchItmRef = inputItem.DebitVchItmRef,  
  
		CreditVchItmRef = inputItem.CreditVchItmRef,  
  
		AccLevel = inputItem.AccLevel,  
  
		State = inputItem.State, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccAnalyse Map(AccAnalyse entity ,EditAccAnalyseCommand inputItem)
        {
              
  
		entity.DebitVchItmRef = inputItem.DebitVchItmRef;  
  
		entity.CreditVchItmRef = inputItem.CreditVchItmRef;  
  
		entity.AccLevel = inputItem.AccLevel;  
  
		entity.State = inputItem.State; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccAnalyseDto Map(AccAnalyse inputItem)
        {
            var dto = new AccAnalyseDto()
            {
                  
  
		DebitVchItmRef = inputItem.DebitVchItmRef,  
  
		CreditVchItmRef = inputItem.CreditVchItmRef,  
  
		AccLevel = inputItem.AccLevel,  
  
		State = inputItem.State, 
            };
            return dto;
        }

        public static List<AccAnalyseDto> Map(ICollection<AccAnalyse> entities)
        {
            var dtos = new List<AccAnalyseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccAnalyseDto()
                {
                      
  
		DebitVchItmRef = inputItem.DebitVchItmRef,  
  
		CreditVchItmRef = inputItem.CreditVchItmRef,  
  
		AccLevel = inputItem.AccLevel,  
  
		State = inputItem.State, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccCloseHdr Map(AddAccCloseHdrCommand inputItem)
        {
            var entity = new AccCloseHdr() {
                  
  
		AccCloseHdrId = inputItem.AccCloseHdrId,  
  
		ACHDescr = inputItem.ACHDescr,  
  
		ACHType = inputItem.ACHType,  
  
		ACHSLRef = inputItem.ACHSLRef,  
  
		ACHDLRef = inputItem.ACHDLRef,  
  
		ACHDLFive = inputItem.ACHDLFive,  
  
		ACHDLSix = inputItem.ACHDLSix,  
  
		ACHAccPrdRef = inputItem.ACHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccCloseHdr Map(AccCloseHdr entity ,EditAccCloseHdrCommand inputItem)
        {
              
  
		entity.AccCloseHdrId = inputItem.AccCloseHdrId;  
  
		entity.ACHDescr = inputItem.ACHDescr;  
  
		entity.ACHType = inputItem.ACHType;  
  
		entity.ACHSLRef = inputItem.ACHSLRef;  
  
		entity.ACHDLRef = inputItem.ACHDLRef;  
  
		entity.ACHDLFive = inputItem.ACHDLFive;  
  
		entity.ACHDLSix = inputItem.ACHDLSix;  
  
		entity.ACHAccPrdRef = inputItem.ACHAccPrdRef;  
  
		entity.AccVchHdrRef = inputItem.AccVchHdrRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccCloseHdrDto Map(AccCloseHdr inputItem)
        {
            var dto = new AccCloseHdrDto()
            {
                  
  
		AccCloseHdrId = inputItem.AccCloseHdrId,  
  
		ACHDescr = inputItem.ACHDescr,  
  
		ACHType = inputItem.ACHType,  
  
		ACHSLRef = inputItem.ACHSLRef,  
  
		ACHDLRef = inputItem.ACHDLRef,  
  
		ACHDLFive = inputItem.ACHDLFive,  
  
		ACHDLSix = inputItem.ACHDLSix,  
  
		ACHAccPrdRef = inputItem.ACHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef, 
            };
            return dto;
        }

        public static List<AccCloseHdrDto> Map(ICollection<AccCloseHdr> entities)
        {
            var dtos = new List<AccCloseHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccCloseHdrDto()
                {
                      
  
		AccCloseHdrId = inputItem.AccCloseHdrId,  
  
		ACHDescr = inputItem.ACHDescr,  
  
		ACHType = inputItem.ACHType,  
  
		ACHSLRef = inputItem.ACHSLRef,  
  
		ACHDLRef = inputItem.ACHDLRef,  
  
		ACHDLFive = inputItem.ACHDLFive,  
  
		ACHDLSix = inputItem.ACHDLSix,  
  
		ACHAccPrdRef = inputItem.ACHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccCloseItm Map(AddAccCloseItmCommand inputItem)
        {
            var entity = new AccCloseItm() {
                  
  
		AccCloseItmId = inputItem.AccCloseItmId,  
  
		AccCloseHdrRef = inputItem.AccCloseHdrRef,  
  
		ACIGLRef = inputItem.ACIGLRef,  
  
		ACISLRef = inputItem.ACISLRef,  
  
		ACIDLRef = inputItem.ACIDLRef,  
  
		ACIDLFive = inputItem.ACIDLFive,  
  
		ACIDLSix = inputItem.ACIDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccCloseItm Map(AccCloseItm entity ,EditAccCloseItmCommand inputItem)
        {
              
  
		entity.AccCloseItmId = inputItem.AccCloseItmId;  
  
		entity.AccCloseHdrRef = inputItem.AccCloseHdrRef;  
  
		entity.ACIGLRef = inputItem.ACIGLRef;  
  
		entity.ACISLRef = inputItem.ACISLRef;  
  
		entity.ACIDLRef = inputItem.ACIDLRef;  
  
		entity.ACIDLFive = inputItem.ACIDLFive;  
  
		entity.ACIDLSix = inputItem.ACIDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccCloseItmDto Map(AccCloseItm inputItem)
        {
            var dto = new AccCloseItmDto()
            {
                  
  
		AccCloseItmId = inputItem.AccCloseItmId,  
  
		AccCloseHdrRef = inputItem.AccCloseHdrRef,  
  
		ACIGLRef = inputItem.ACIGLRef,  
  
		ACISLRef = inputItem.ACISLRef,  
  
		ACIDLRef = inputItem.ACIDLRef,  
  
		ACIDLFive = inputItem.ACIDLFive,  
  
		ACIDLSix = inputItem.ACIDLSix, 
            };
            return dto;
        }

        public static List<AccCloseItmDto> Map(ICollection<AccCloseItm> entities)
        {
            var dtos = new List<AccCloseItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccCloseItmDto()
                {
                      
  
		AccCloseItmId = inputItem.AccCloseItmId,  
  
		AccCloseHdrRef = inputItem.AccCloseHdrRef,  
  
		ACIGLRef = inputItem.ACIGLRef,  
  
		ACISLRef = inputItem.ACISLRef,  
  
		ACIDLRef = inputItem.ACIDLRef,  
  
		ACIDLFive = inputItem.ACIDLFive,  
  
		ACIDLSix = inputItem.ACIDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccDL Map(AddAccDLCommand inputItem)
        {
            var entity = new AccDL() {
                  
  
		dl_Code = inputItem.dl_Code,  
  
		dl_Title = inputItem.dl_Title,  
  
		dl_type = inputItem.dl_type,  
  
		dl_disable = inputItem.dl_disable, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccDL Map(AccDL entity ,EditAccDLCommand inputItem)
        {
              
  
		entity.dl_Code = inputItem.dl_Code;  
  
		entity.dl_Title = inputItem.dl_Title;  
  
		entity.dl_type = inputItem.dl_type;  
  
		entity.dl_disable = inputItem.dl_disable; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccDLDto Map(AccDL inputItem)
        {
            var dto = new AccDLDto()
            {
                  
  
		dl_Code = inputItem.dl_Code,  
  
		dl_Title = inputItem.dl_Title,  
  
		dl_type = inputItem.dl_type,  
  
		dl_disable = inputItem.dl_disable, 
            };
            return dto;
        }

        public static List<AccDLDto> Map(ICollection<AccDL> entities)
        {
            var dtos = new List<AccDLDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccDLDto()
                {
                      
  
		dl_Code = inputItem.dl_Code,  
  
		dl_Title = inputItem.dl_Title,  
  
		dl_type = inputItem.dl_type,  
  
		dl_disable = inputItem.dl_disable, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccDLCtgry Map(AddAccDLCtgryCommand inputItem)
        {
            var entity = new AccDLCtgry() {
                  
  
		AccDLCtgryId = inputItem.AccDLCtgryId,  
  
		ADCParentRef = inputItem.ADCParentRef,  
  
		ADCTitle = inputItem.ADCTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccDLCtgry Map(AccDLCtgry entity ,EditAccDLCtgryCommand inputItem)
        {
              
  
		entity.AccDLCtgryId = inputItem.AccDLCtgryId;  
  
		entity.ADCParentRef = inputItem.ADCParentRef;  
  
		entity.ADCTitle = inputItem.ADCTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccDLCtgryDto Map(AccDLCtgry inputItem)
        {
            var dto = new AccDLCtgryDto()
            {
                  
  
		AccDLCtgryId = inputItem.AccDLCtgryId,  
  
		ADCParentRef = inputItem.ADCParentRef,  
  
		ADCTitle = inputItem.ADCTitle, 
            };
            return dto;
        }

        public static List<AccDLCtgryDto> Map(ICollection<AccDLCtgry> entities)
        {
            var dtos = new List<AccDLCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccDLCtgryDto()
                {
                      
  
		AccDLCtgryId = inputItem.AccDLCtgryId,  
  
		ADCParentRef = inputItem.ADCParentRef,  
  
		ADCTitle = inputItem.ADCTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccDLCtgryRel Map(AddAccDLCtgryRelCommand inputItem)
        {
            var entity = new AccDLCtgryRel() {
                  
  
		ADCRCtgryRef = inputItem.ADCRCtgryRef,  
  
		ADCRDLRef = inputItem.ADCRDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccDLCtgryRel Map(AccDLCtgryRel entity ,EditAccDLCtgryRelCommand inputItem)
        {
              
  
		entity.ADCRCtgryRef = inputItem.ADCRCtgryRef;  
  
		entity.ADCRDLRef = inputItem.ADCRDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccDLCtgryRelDto Map(AccDLCtgryRel inputItem)
        {
            var dto = new AccDLCtgryRelDto()
            {
                  
  
		ADCRCtgryRef = inputItem.ADCRCtgryRef,  
  
		ADCRDLRef = inputItem.ADCRDLRef, 
            };
            return dto;
        }

        public static List<AccDLCtgryRelDto> Map(ICollection<AccDLCtgryRel> entities)
        {
            var dtos = new List<AccDLCtgryRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccDLCtgryRelDto()
                {
                      
  
		ADCRCtgryRef = inputItem.ADCRCtgryRef,  
  
		ADCRDLRef = inputItem.ADCRDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccGL Map(AddAccGLCommand inputItem)
        {
            var entity = new AccGL() {
                  
  
		gl_Code = inputItem.gl_Code,  
  
		PlRef = inputItem.PlRef,  
  
		gl_Title = inputItem.gl_Title,  
  
		gl_BalanceType = inputItem.gl_BalanceType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccGL Map(AccGL entity ,EditAccGLCommand inputItem)
        {
              
  
		entity.gl_Code = inputItem.gl_Code;  
  
		entity.PlRef = inputItem.PlRef;  
  
		entity.gl_Title = inputItem.gl_Title;  
  
		entity.gl_BalanceType = inputItem.gl_BalanceType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccGLDto Map(AccGL inputItem)
        {
            var dto = new AccGLDto()
            {
                  
  
		gl_Code = inputItem.gl_Code,  
  
		PlRef = inputItem.PlRef,  
  
		gl_Title = inputItem.gl_Title,  
  
		gl_BalanceType = inputItem.gl_BalanceType, 
            };
            return dto;
        }

        public static List<AccGLDto> Map(ICollection<AccGL> entities)
        {
            var dtos = new List<AccGLDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccGLDto()
                {
                      
  
		gl_Code = inputItem.gl_Code,  
  
		PlRef = inputItem.PlRef,  
  
		gl_Title = inputItem.gl_Title,  
  
		gl_BalanceType = inputItem.gl_BalanceType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccGLVchHdr Map(AddAccGLVchHdrCommand inputItem)
        {
            var entity = new AccGLVchHdr() {
                  
  
		AccGLVchHdrId = inputItem.AccGLVchHdrId,  
  
		AGVHNum = inputItem.AGVHNum,  
  
		AGVHDate = inputItem.AGVHDate,  
  
		AGVHAccPrdRef = inputItem.AGVHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AGVHFNum = inputItem.AGVHFNum,  
  
		AGVHTNum = inputItem.AGVHTNum, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccGLVchHdr Map(AccGLVchHdr entity ,EditAccGLVchHdrCommand inputItem)
        {
              
  
		entity.AccGLVchHdrId = inputItem.AccGLVchHdrId;  
  
		entity.AGVHNum = inputItem.AGVHNum;  
  
		entity.AGVHDate = inputItem.AGVHDate;  
  
		entity.AGVHAccPrdRef = inputItem.AGVHAccPrdRef;  
  
		entity.AccVchHdrRef = inputItem.AccVchHdrRef;  
  
		entity.AGVHFNum = inputItem.AGVHFNum;  
  
		entity.AGVHTNum = inputItem.AGVHTNum; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccGLVchHdrDto Map(AccGLVchHdr inputItem)
        {
            var dto = new AccGLVchHdrDto()
            {
                  
  
		AccGLVchHdrId = inputItem.AccGLVchHdrId,  
  
		AGVHNum = inputItem.AGVHNum,  
  
		AGVHDate = inputItem.AGVHDate,  
  
		AGVHAccPrdRef = inputItem.AGVHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AGVHFNum = inputItem.AGVHFNum,  
  
		AGVHTNum = inputItem.AGVHTNum, 
            };
            return dto;
        }

        public static List<AccGLVchHdrDto> Map(ICollection<AccGLVchHdr> entities)
        {
            var dtos = new List<AccGLVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccGLVchHdrDto()
                {
                      
  
		AccGLVchHdrId = inputItem.AccGLVchHdrId,  
  
		AGVHNum = inputItem.AGVHNum,  
  
		AGVHDate = inputItem.AGVHDate,  
  
		AGVHAccPrdRef = inputItem.AGVHAccPrdRef,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AGVHFNum = inputItem.AGVHFNum,  
  
		AGVHTNum = inputItem.AGVHTNum, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccGLVchItm Map(AddAccGLVchItmCommand inputItem)
        {
            var entity = new AccGLVchItm() {
                  
  
		AccGLVchItmId = inputItem.AccGLVchItmId,  
  
		AccGLVchHdrRef = inputItem.AccGLVchHdrRef,  
  
		AGVIGLRef = inputItem.AGVIGLRef,  
  
		AGVIDebit = inputItem.AGVIDebit,  
  
		AGVICredit = inputItem.AGVICredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccGLVchItm Map(AccGLVchItm entity ,EditAccGLVchItmCommand inputItem)
        {
              
  
		entity.AccGLVchItmId = inputItem.AccGLVchItmId;  
  
		entity.AccGLVchHdrRef = inputItem.AccGLVchHdrRef;  
  
		entity.AGVIGLRef = inputItem.AGVIGLRef;  
  
		entity.AGVIDebit = inputItem.AGVIDebit;  
  
		entity.AGVICredit = inputItem.AGVICredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccGLVchItmDto Map(AccGLVchItm inputItem)
        {
            var dto = new AccGLVchItmDto()
            {
                  
  
		AccGLVchItmId = inputItem.AccGLVchItmId,  
  
		AccGLVchHdrRef = inputItem.AccGLVchHdrRef,  
  
		AGVIGLRef = inputItem.AGVIGLRef,  
  
		AGVIDebit = inputItem.AGVIDebit,  
  
		AGVICredit = inputItem.AGVICredit, 
            };
            return dto;
        }

        public static List<AccGLVchItmDto> Map(ICollection<AccGLVchItm> entities)
        {
            var dtos = new List<AccGLVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccGLVchItmDto()
                {
                      
  
		AccGLVchItmId = inputItem.AccGLVchItmId,  
  
		AccGLVchHdrRef = inputItem.AccGLVchHdrRef,  
  
		AGVIGLRef = inputItem.AGVIGLRef,  
  
		AGVIDebit = inputItem.AGVIDebit,  
  
		AGVICredit = inputItem.AGVICredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccGroups Map(AddAccGroupsCommand inputItem)
        {
            var entity = new AccGroups() {
                  
  
		AccGroupsId = inputItem.AccGroupsId,  
  
		AGTitle = inputItem.AGTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccGroups Map(AccGroups entity ,EditAccGroupsCommand inputItem)
        {
              
  
		entity.AccGroupsId = inputItem.AccGroupsId;  
  
		entity.AGTitle = inputItem.AGTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccGroupsDto Map(AccGroups inputItem)
        {
            var dto = new AccGroupsDto()
            {
                  
  
		AccGroupsId = inputItem.AccGroupsId,  
  
		AGTitle = inputItem.AGTitle, 
            };
            return dto;
        }

        public static List<AccGroupsDto> Map(ICollection<AccGroups> entities)
        {
            var dtos = new List<AccGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccGroupsDto()
                {
                      
  
		AccGroupsId = inputItem.AccGroupsId,  
  
		AGTitle = inputItem.AGTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccNoteHdr Map(AddAccNoteHdrCommand inputItem)
        {
            var entity = new AccNoteHdr() {
                  
  
		AccNoteHdrId = inputItem.AccNoteHdrId,  
  
		ANHNum = inputItem.ANHNum,  
  
		ANHDate = inputItem.ANHDate,  
  
		ANHDescr = inputItem.ANHDescr,  
  
		ANHDLRef = inputItem.ANHDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccNoteHdr Map(AccNoteHdr entity ,EditAccNoteHdrCommand inputItem)
        {
              
  
		entity.AccNoteHdrId = inputItem.AccNoteHdrId;  
  
		entity.ANHNum = inputItem.ANHNum;  
  
		entity.ANHDate = inputItem.ANHDate;  
  
		entity.ANHDescr = inputItem.ANHDescr;  
  
		entity.ANHDLRef = inputItem.ANHDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccNoteHdrDto Map(AccNoteHdr inputItem)
        {
            var dto = new AccNoteHdrDto()
            {
                  
  
		AccNoteHdrId = inputItem.AccNoteHdrId,  
  
		ANHNum = inputItem.ANHNum,  
  
		ANHDate = inputItem.ANHDate,  
  
		ANHDescr = inputItem.ANHDescr,  
  
		ANHDLRef = inputItem.ANHDLRef, 
            };
            return dto;
        }

        public static List<AccNoteHdrDto> Map(ICollection<AccNoteHdr> entities)
        {
            var dtos = new List<AccNoteHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccNoteHdrDto()
                {
                      
  
		AccNoteHdrId = inputItem.AccNoteHdrId,  
  
		ANHNum = inputItem.ANHNum,  
  
		ANHDate = inputItem.ANHDate,  
  
		ANHDescr = inputItem.ANHDescr,  
  
		ANHDLRef = inputItem.ANHDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccNoteItm Map(AddAccNoteItmCommand inputItem)
        {
            var entity = new AccNoteItm() {
                  
  
		AccNoteItmId = inputItem.AccNoteItmId,  
  
		AccNoteHdrRef = inputItem.AccNoteHdrRef,  
  
		ANISLRef = inputItem.ANISLRef,  
  
		ANIItmDate = inputItem.ANIItmDate,  
  
		ANIDescr = inputItem.ANIDescr,  
  
		ANIDebit = inputItem.ANIDebit,  
  
		ANICredit = inputItem.ANICredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccNoteItm Map(AccNoteItm entity ,EditAccNoteItmCommand inputItem)
        {
              
  
		entity.AccNoteItmId = inputItem.AccNoteItmId;  
  
		entity.AccNoteHdrRef = inputItem.AccNoteHdrRef;  
  
		entity.ANISLRef = inputItem.ANISLRef;  
  
		entity.ANIItmDate = inputItem.ANIItmDate;  
  
		entity.ANIDescr = inputItem.ANIDescr;  
  
		entity.ANIDebit = inputItem.ANIDebit;  
  
		entity.ANICredit = inputItem.ANICredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccNoteItmDto Map(AccNoteItm inputItem)
        {
            var dto = new AccNoteItmDto()
            {
                  
  
		AccNoteItmId = inputItem.AccNoteItmId,  
  
		AccNoteHdrRef = inputItem.AccNoteHdrRef,  
  
		ANISLRef = inputItem.ANISLRef,  
  
		ANIItmDate = inputItem.ANIItmDate,  
  
		ANIDescr = inputItem.ANIDescr,  
  
		ANIDebit = inputItem.ANIDebit,  
  
		ANICredit = inputItem.ANICredit, 
            };
            return dto;
        }

        public static List<AccNoteItmDto> Map(ICollection<AccNoteItm> entities)
        {
            var dtos = new List<AccNoteItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccNoteItmDto()
                {
                      
  
		AccNoteItmId = inputItem.AccNoteItmId,  
  
		AccNoteHdrRef = inputItem.AccNoteHdrRef,  
  
		ANISLRef = inputItem.ANISLRef,  
  
		ANIItmDate = inputItem.ANIItmDate,  
  
		ANIDescr = inputItem.ANIDescr,  
  
		ANIDebit = inputItem.ANIDebit,  
  
		ANICredit = inputItem.ANICredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccPeriod Map(AddAccPeriodCommand inputItem)
        {
            var entity = new AccPeriod() {
                  
  
		PeriodId = inputItem.PeriodId,  
  
		PeriodTitle = inputItem.PeriodTitle,  
  
		p_FromDate = inputItem.p_FromDate,  
  
		p_ToDate = inputItem.p_ToDate,  
  
		p_Year = inputItem.p_Year, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccPeriod Map(AccPeriod entity ,EditAccPeriodCommand inputItem)
        {
              
  
		entity.PeriodId = inputItem.PeriodId;  
  
		entity.PeriodTitle = inputItem.PeriodTitle;  
  
		entity.p_FromDate = inputItem.p_FromDate;  
  
		entity.p_ToDate = inputItem.p_ToDate;  
  
		entity.p_Year = inputItem.p_Year; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccPeriodDto Map(AccPeriod inputItem)
        {
            var dto = new AccPeriodDto()
            {
                  
  
		PeriodId = inputItem.PeriodId,  
  
		PeriodTitle = inputItem.PeriodTitle,  
  
		p_FromDate = inputItem.p_FromDate,  
  
		p_ToDate = inputItem.p_ToDate,  
  
		p_Year = inputItem.p_Year, 
            };
            return dto;
        }

        public static List<AccPeriodDto> Map(ICollection<AccPeriod> entities)
        {
            var dtos = new List<AccPeriodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccPeriodDto()
                {
                      
  
		PeriodId = inputItem.PeriodId,  
  
		PeriodTitle = inputItem.PeriodTitle,  
  
		p_FromDate = inputItem.p_FromDate,  
  
		p_ToDate = inputItem.p_ToDate,  
  
		p_Year = inputItem.p_Year, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccPL Map(AddAccPLCommand inputItem)
        {
            var entity = new AccPL() {
                  
  
		pl_Code = inputItem.pl_Code,  
  
		pl_Title = inputItem.pl_Title,  
  
		pl_Type = inputItem.pl_Type, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccPL Map(AccPL entity ,EditAccPLCommand inputItem)
        {
              
  
		entity.pl_Code = inputItem.pl_Code;  
  
		entity.pl_Title = inputItem.pl_Title;  
  
		entity.pl_Type = inputItem.pl_Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccPLDto Map(AccPL inputItem)
        {
            var dto = new AccPLDto()
            {
                  
  
		pl_Code = inputItem.pl_Code,  
  
		pl_Title = inputItem.pl_Title,  
  
		pl_Type = inputItem.pl_Type, 
            };
            return dto;
        }

        public static List<AccPLDto> Map(ICollection<AccPL> entities)
        {
            var dtos = new List<AccPLDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccPLDto()
                {
                      
  
		pl_Code = inputItem.pl_Code,  
  
		pl_Title = inputItem.pl_Title,  
  
		pl_Type = inputItem.pl_Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccSL Map(AddAccSLCommand inputItem)
        {
            var entity = new AccSL() {
                  
  
		sl_Code = inputItem.sl_Code,  
  
		sl_Title = inputItem.sl_Title,  
  
		GlRef = inputItem.GlRef,  
  
		sl_BalanceType = inputItem.sl_BalanceType,  
  
		sl_HaveQty = inputItem.sl_HaveQty,  
  
		sl_HaveCur = inputItem.sl_HaveCur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccSL Map(AccSL entity ,EditAccSLCommand inputItem)
        {
              
  
		entity.sl_Code = inputItem.sl_Code;  
  
		entity.sl_Title = inputItem.sl_Title;  
  
		entity.GlRef = inputItem.GlRef;  
  
		entity.sl_BalanceType = inputItem.sl_BalanceType;  
  
		entity.sl_HaveQty = inputItem.sl_HaveQty;  
  
		entity.sl_HaveCur = inputItem.sl_HaveCur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccSLDto Map(AccSL inputItem)
        {
            var dto = new AccSLDto()
            {
                  
  
		sl_Code = inputItem.sl_Code,  
  
		sl_Title = inputItem.sl_Title,  
  
		GlRef = inputItem.GlRef,  
  
		sl_BalanceType = inputItem.sl_BalanceType,  
  
		sl_HaveQty = inputItem.sl_HaveQty,  
  
		sl_HaveCur = inputItem.sl_HaveCur, 
            };
            return dto;
        }

        public static List<AccSLDto> Map(ICollection<AccSL> entities)
        {
            var dtos = new List<AccSLDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccSLDto()
                {
                      
  
		sl_Code = inputItem.sl_Code,  
  
		sl_Title = inputItem.sl_Title,  
  
		GlRef = inputItem.GlRef,  
  
		sl_BalanceType = inputItem.sl_BalanceType,  
  
		sl_HaveQty = inputItem.sl_HaveQty,  
  
		sl_HaveCur = inputItem.sl_HaveCur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccSLDLRel Map(AddAccSLDLRelCommand inputItem)
        {
            var entity = new AccSLDLRel() {
                  
  
		rel_SLRef = inputItem.rel_SLRef,  
  
		rel_DlType = inputItem.rel_DlType,  
  
		relType = inputItem.relType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccSLDLRel Map(AccSLDLRel entity ,EditAccSLDLRelCommand inputItem)
        {
              
  
		entity.rel_SLRef = inputItem.rel_SLRef;  
  
		entity.rel_DlType = inputItem.rel_DlType;  
  
		entity.relType = inputItem.relType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccSLDLRelDto Map(AccSLDLRel inputItem)
        {
            var dto = new AccSLDLRelDto()
            {
                  
  
		rel_SLRef = inputItem.rel_SLRef,  
  
		rel_DlType = inputItem.rel_DlType,  
  
		relType = inputItem.relType, 
            };
            return dto;
        }

        public static List<AccSLDLRelDto> Map(ICollection<AccSLDLRel> entities)
        {
            var dtos = new List<AccSLDLRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccSLDLRelDto()
                {
                      
  
		rel_SLRef = inputItem.rel_SLRef,  
  
		rel_DlType = inputItem.rel_DlType,  
  
		relType = inputItem.relType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccSLStdDesc Map(AddAccSLStdDescCommand inputItem)
        {
            var entity = new AccSLStdDesc() {
                  
  
		stdesc_id = inputItem.stdesc_id,  
  
		stdesc_Slref = inputItem.stdesc_Slref,  
  
		stdesc_str = inputItem.stdesc_str, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccSLStdDesc Map(AccSLStdDesc entity ,EditAccSLStdDescCommand inputItem)
        {
              
  
		entity.stdesc_id = inputItem.stdesc_id;  
  
		entity.stdesc_Slref = inputItem.stdesc_Slref;  
  
		entity.stdesc_str = inputItem.stdesc_str; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccSLStdDescDto Map(AccSLStdDesc inputItem)
        {
            var dto = new AccSLStdDescDto()
            {
                  
  
		stdesc_id = inputItem.stdesc_id,  
  
		stdesc_Slref = inputItem.stdesc_Slref,  
  
		stdesc_str = inputItem.stdesc_str, 
            };
            return dto;
        }

        public static List<AccSLStdDescDto> Map(ICollection<AccSLStdDesc> entities)
        {
            var dtos = new List<AccSLStdDescDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccSLStdDescDto()
                {
                      
  
		stdesc_id = inputItem.stdesc_id,  
  
		stdesc_Slref = inputItem.stdesc_Slref,  
  
		stdesc_str = inputItem.stdesc_str, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccTransVch Map(AddAccTransVchCommand inputItem)
        {
            var entity = new AccTransVch() {
                  
  
		ATVSrcName = inputItem.ATVSrcName,  
  
		ATVSrcTempNum = inputItem.ATVSrcTempNum,  
  
		ATVTempNum = inputItem.ATVTempNum,  
  
		ATVYear = inputItem.ATVYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccTransVch Map(AccTransVch entity ,EditAccTransVchCommand inputItem)
        {
              
  
		entity.ATVSrcName = inputItem.ATVSrcName;  
  
		entity.ATVSrcTempNum = inputItem.ATVSrcTempNum;  
  
		entity.ATVTempNum = inputItem.ATVTempNum;  
  
		entity.ATVYear = inputItem.ATVYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccTransVchDto Map(AccTransVch inputItem)
        {
            var dto = new AccTransVchDto()
            {
                  
  
		ATVSrcName = inputItem.ATVSrcName,  
  
		ATVSrcTempNum = inputItem.ATVSrcTempNum,  
  
		ATVTempNum = inputItem.ATVTempNum,  
  
		ATVYear = inputItem.ATVYear, 
            };
            return dto;
        }

        public static List<AccTransVchDto> Map(ICollection<AccTransVch> entities)
        {
            var dtos = new List<AccTransVchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccTransVchDto()
                {
                      
  
		ATVSrcName = inputItem.ATVSrcName,  
  
		ATVSrcTempNum = inputItem.ATVSrcTempNum,  
  
		ATVTempNum = inputItem.ATVTempNum,  
  
		ATVYear = inputItem.ATVYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchDescr Map(AddAccVchDescrCommand inputItem)
        {
            var entity = new AccVchDescr() {
                  
  
		AccVchDescrId = inputItem.AccVchDescrId,  
  
		AVDType = inputItem.AVDType,  
  
		AVDDebitD = inputItem.AVDDebitD,  
  
		AVDCreditD = inputItem.AVDCreditD, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchDescr Map(AccVchDescr entity ,EditAccVchDescrCommand inputItem)
        {
              
  
		entity.AccVchDescrId = inputItem.AccVchDescrId;  
  
		entity.AVDType = inputItem.AVDType;  
  
		entity.AVDDebitD = inputItem.AVDDebitD;  
  
		entity.AVDCreditD = inputItem.AVDCreditD; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchDescrDto Map(AccVchDescr inputItem)
        {
            var dto = new AccVchDescrDto()
            {
                  
  
		AccVchDescrId = inputItem.AccVchDescrId,  
  
		AVDType = inputItem.AVDType,  
  
		AVDDebitD = inputItem.AVDDebitD,  
  
		AVDCreditD = inputItem.AVDCreditD, 
            };
            return dto;
        }

        public static List<AccVchDescrDto> Map(ICollection<AccVchDescr> entities)
        {
            var dtos = new List<AccVchDescrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchDescrDto()
                {
                      
  
		AccVchDescrId = inputItem.AccVchDescrId,  
  
		AVDType = inputItem.AVDType,  
  
		AVDDebitD = inputItem.AVDDebitD,  
  
		AVDCreditD = inputItem.AVDCreditD, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchHdr Map(AddAccVchHdrCommand inputItem)
        {
            var entity = new AccVchHdr() {
                  
  
		AccVchHdrId = inputItem.AccVchHdrId,  
  
		AVHNum = inputItem.AVHNum,  
  
		AVHTempNum = inputItem.AVHTempNum,  
  
		AVHLocalNum = inputItem.AVHLocalNum,  
  
		AVHDate = inputItem.AVHDate,  
  
		AVHDescr = inputItem.AVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		VchState = inputItem.VchState,  
  
		AccPrdRef = inputItem.AccPrdRef,  
  
		AccSysRef = inputItem.AccSysRef,  
  
		VchCtgry = inputItem.VchCtgry,  
  
		AVHGrpRef = inputItem.AVHGrpRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchHdr Map(AccVchHdr entity ,EditAccVchHdrCommand inputItem)
        {
              
  
		entity.AccVchHdrId = inputItem.AccVchHdrId;  
  
		entity.AVHNum = inputItem.AVHNum;  
  
		entity.AVHTempNum = inputItem.AVHTempNum;  
  
		entity.AVHLocalNum = inputItem.AVHLocalNum;  
  
		entity.AVHDate = inputItem.AVHDate;  
  
		entity.AVHDescr = inputItem.AVHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.VchState = inputItem.VchState;  
  
		entity.AccPrdRef = inputItem.AccPrdRef;  
  
		entity.AccSysRef = inputItem.AccSysRef;  
  
		entity.VchCtgry = inputItem.VchCtgry;  
  
		entity.AVHGrpRef = inputItem.AVHGrpRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchHdrDto Map(AccVchHdr inputItem)
        {
            var dto = new AccVchHdrDto()
            {
                  
  
		AccVchHdrId = inputItem.AccVchHdrId,  
  
		AVHNum = inputItem.AVHNum,  
  
		AVHTempNum = inputItem.AVHTempNum,  
  
		AVHLocalNum = inputItem.AVHLocalNum,  
  
		AVHDate = inputItem.AVHDate,  
  
		AVHDescr = inputItem.AVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		VchState = inputItem.VchState,  
  
		AccPrdRef = inputItem.AccPrdRef,  
  
		AccSysRef = inputItem.AccSysRef,  
  
		VchCtgry = inputItem.VchCtgry,  
  
		AVHGrpRef = inputItem.AVHGrpRef, 
            };
            return dto;
        }

        public static List<AccVchHdrDto> Map(ICollection<AccVchHdr> entities)
        {
            var dtos = new List<AccVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchHdrDto()
                {
                      
  
		AccVchHdrId = inputItem.AccVchHdrId,  
  
		AVHNum = inputItem.AVHNum,  
  
		AVHTempNum = inputItem.AVHTempNum,  
  
		AVHLocalNum = inputItem.AVHLocalNum,  
  
		AVHDate = inputItem.AVHDate,  
  
		AVHDescr = inputItem.AVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		VchState = inputItem.VchState,  
  
		AccPrdRef = inputItem.AccPrdRef,  
  
		AccSysRef = inputItem.AccSysRef,  
  
		VchCtgry = inputItem.VchCtgry,  
  
		AVHGrpRef = inputItem.AVHGrpRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchItm Map(AddAccVchItmCommand inputItem)
        {
            var entity = new AccVchItm() {
                  
  
		AccVchItmId = inputItem.AccVchItmId,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AVISeq = inputItem.AVISeq,  
  
		AVIGlRef = inputItem.AVIGlRef,  
  
		AVISLRef = inputItem.AVISLRef,  
  
		AVIDLRef = inputItem.AVIDLRef,  
  
		AVIDL5Ref = inputItem.AVIDL5Ref,  
  
		AVIDL6Ref = inputItem.AVIDL6Ref,  
  
		AVIDL7Ref = inputItem.AVIDL7Ref,  
  
		AVIDescr = inputItem.AVIDescr,  
  
		AVIDebit = inputItem.AVIDebit,  
  
		AVICredit = inputItem.AVICredit,  
  
		AVIRMainPart = inputItem.AVIRMainPart,  
  
		AVIRType = inputItem.AVIRType,  
  
		AVIQty = inputItem.AVIQty,  
  
		AVIDate = inputItem.AVIDate,  
  
		AVICurRef = inputItem.AVICurRef,  
  
		AVICurVal = inputItem.AVICurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchItm Map(AccVchItm entity ,EditAccVchItmCommand inputItem)
        {
              
  
		entity.AccVchItmId = inputItem.AccVchItmId;  
  
		entity.AccVchHdrRef = inputItem.AccVchHdrRef;  
  
		entity.AVISeq = inputItem.AVISeq;  
  
		entity.AVIGlRef = inputItem.AVIGlRef;  
  
		entity.AVISLRef = inputItem.AVISLRef;  
  
		entity.AVIDLRef = inputItem.AVIDLRef;  
  
		entity.AVIDL5Ref = inputItem.AVIDL5Ref;  
  
		entity.AVIDL6Ref = inputItem.AVIDL6Ref;  
  
		entity.AVIDL7Ref = inputItem.AVIDL7Ref;  
  
		entity.AVIDescr = inputItem.AVIDescr;  
  
		entity.AVIDebit = inputItem.AVIDebit;  
  
		entity.AVICredit = inputItem.AVICredit;  
  
		entity.AVIRMainPart = inputItem.AVIRMainPart;  
  
		entity.AVIRType = inputItem.AVIRType;  
  
		entity.AVIQty = inputItem.AVIQty;  
  
		entity.AVIDate = inputItem.AVIDate;  
  
		entity.AVICurRef = inputItem.AVICurRef;  
  
		entity.AVICurVal = inputItem.AVICurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchItmDto Map(AccVchItm inputItem)
        {
            var dto = new AccVchItmDto()
            {
                  
  
		AccVchItmId = inputItem.AccVchItmId,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AVISeq = inputItem.AVISeq,  
  
		AVIGlRef = inputItem.AVIGlRef,  
  
		AVISLRef = inputItem.AVISLRef,  
  
		AVIDLRef = inputItem.AVIDLRef,  
  
		AVIDL5Ref = inputItem.AVIDL5Ref,  
  
		AVIDL6Ref = inputItem.AVIDL6Ref,  
  
		AVIDL7Ref = inputItem.AVIDL7Ref,  
  
		AVIDescr = inputItem.AVIDescr,  
  
		AVIDebit = inputItem.AVIDebit,  
  
		AVICredit = inputItem.AVICredit,  
  
		AVIRMainPart = inputItem.AVIRMainPart,  
  
		AVIRType = inputItem.AVIRType,  
  
		AVIQty = inputItem.AVIQty,  
  
		AVIDate = inputItem.AVIDate,  
  
		AVICurRef = inputItem.AVICurRef,  
  
		AVICurVal = inputItem.AVICurVal, 
            };
            return dto;
        }

        public static List<AccVchItmDto> Map(ICollection<AccVchItm> entities)
        {
            var dtos = new List<AccVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchItmDto()
                {
                      
  
		AccVchItmId = inputItem.AccVchItmId,  
  
		AccVchHdrRef = inputItem.AccVchHdrRef,  
  
		AVISeq = inputItem.AVISeq,  
  
		AVIGlRef = inputItem.AVIGlRef,  
  
		AVISLRef = inputItem.AVISLRef,  
  
		AVIDLRef = inputItem.AVIDLRef,  
  
		AVIDL5Ref = inputItem.AVIDL5Ref,  
  
		AVIDL6Ref = inputItem.AVIDL6Ref,  
  
		AVIDL7Ref = inputItem.AVIDL7Ref,  
  
		AVIDescr = inputItem.AVIDescr,  
  
		AVIDebit = inputItem.AVIDebit,  
  
		AVICredit = inputItem.AVICredit,  
  
		AVIRMainPart = inputItem.AVIRMainPart,  
  
		AVIRType = inputItem.AVIRType,  
  
		AVIQty = inputItem.AVIQty,  
  
		AVIDate = inputItem.AVIDate,  
  
		AVICurRef = inputItem.AVICurRef,  
  
		AVICurVal = inputItem.AVICurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchKindDescr Map(AddAccVchKindDescrCommand inputItem)
        {
            var entity = new AccVchKindDescr() {
                  
  
		AccVchKindDescrId = inputItem.AccVchKindDescrId,  
  
		AVKDSysRef = inputItem.AVKDSysRef,  
  
		AVKDType = inputItem.AVKDType,  
  
		AVKDDebitD = inputItem.AVKDDebitD,  
  
		AVKDCreditD = inputItem.AVKDCreditD, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchKindDescr Map(AccVchKindDescr entity ,EditAccVchKindDescrCommand inputItem)
        {
              
  
		entity.AccVchKindDescrId = inputItem.AccVchKindDescrId;  
  
		entity.AVKDSysRef = inputItem.AVKDSysRef;  
  
		entity.AVKDType = inputItem.AVKDType;  
  
		entity.AVKDDebitD = inputItem.AVKDDebitD;  
  
		entity.AVKDCreditD = inputItem.AVKDCreditD; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchKindDescrDto Map(AccVchKindDescr inputItem)
        {
            var dto = new AccVchKindDescrDto()
            {
                  
  
		AccVchKindDescrId = inputItem.AccVchKindDescrId,  
  
		AVKDSysRef = inputItem.AVKDSysRef,  
  
		AVKDType = inputItem.AVKDType,  
  
		AVKDDebitD = inputItem.AVKDDebitD,  
  
		AVKDCreditD = inputItem.AVKDCreditD, 
            };
            return dto;
        }

        public static List<AccVchKindDescrDto> Map(ICollection<AccVchKindDescr> entities)
        {
            var dtos = new List<AccVchKindDescrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchKindDescrDto()
                {
                      
  
		AccVchKindDescrId = inputItem.AccVchKindDescrId,  
  
		AVKDSysRef = inputItem.AVKDSysRef,  
  
		AVKDType = inputItem.AVKDType,  
  
		AVKDDebitD = inputItem.AVKDDebitD,  
  
		AVKDCreditD = inputItem.AVKDCreditD, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchRels Map(AddAccVchRelsCommand inputItem)
        {
            var entity = new AccVchRels() {
                  
  
		RelAccHdrRef = inputItem.RelAccHdrRef,  
  
		RelBaseItmRef = inputItem.RelBaseItmRef,  
  
		RelBaseType = inputItem.RelBaseType,  
  
		RelAccItmRef = inputItem.RelAccItmRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchRels Map(AccVchRels entity ,EditAccVchRelsCommand inputItem)
        {
              
  
		entity.RelAccHdrRef = inputItem.RelAccHdrRef;  
  
		entity.RelBaseItmRef = inputItem.RelBaseItmRef;  
  
		entity.RelBaseType = inputItem.RelBaseType;  
  
		entity.RelAccItmRef = inputItem.RelAccItmRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchRelsDto Map(AccVchRels inputItem)
        {
            var dto = new AccVchRelsDto()
            {
                  
  
		RelAccHdrRef = inputItem.RelAccHdrRef,  
  
		RelBaseItmRef = inputItem.RelBaseItmRef,  
  
		RelBaseType = inputItem.RelBaseType,  
  
		RelAccItmRef = inputItem.RelAccItmRef, 
            };
            return dto;
        }

        public static List<AccVchRelsDto> Map(ICollection<AccVchRels> entities)
        {
            var dtos = new List<AccVchRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchRelsDto()
                {
                      
  
		RelAccHdrRef = inputItem.RelAccHdrRef,  
  
		RelBaseItmRef = inputItem.RelBaseItmRef,  
  
		RelBaseType = inputItem.RelBaseType,  
  
		RelAccItmRef = inputItem.RelAccItmRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AccVchTypes Map(AddAccVchTypesCommand inputItem)
        {
            var entity = new AccVchTypes() {
                  
  
		VchTypeId = inputItem.VchTypeId,  
  
		VchTypeDescr = inputItem.VchTypeDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AccVchTypes Map(AccVchTypes entity ,EditAccVchTypesCommand inputItem)
        {
              
  
		entity.VchTypeId = inputItem.VchTypeId;  
  
		entity.VchTypeDescr = inputItem.VchTypeDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AccVchTypesDto Map(AccVchTypes inputItem)
        {
            var dto = new AccVchTypesDto()
            {
                  
  
		VchTypeId = inputItem.VchTypeId,  
  
		VchTypeDescr = inputItem.VchTypeDescr, 
            };
            return dto;
        }

        public static List<AccVchTypesDto> Map(ICollection<AccVchTypes> entities)
        {
            var dtos = new List<AccVchTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AccVchTypesDto()
                {
                      
  
		VchTypeId = inputItem.VchTypeId,  
  
		VchTypeDescr = inputItem.VchTypeDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
