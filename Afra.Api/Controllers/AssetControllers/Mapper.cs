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
                
        
        public static Assets Map(AddAssetsCommand inputItem)
        {
            var entity = new Assets() {
                  
  
		AstId = inputItem.AstId,  
  
		AstPlatNo = inputItem.AstPlatNo,  
  
		AstTitle = inputItem.AstTitle,  
  
		AstCreateDate = inputItem.AstCreateDate,  
  
		AstUseDate = inputItem.AstUseDate,  
  
		AstDocRef = inputItem.AstDocRef,  
  
		AstSLRef = inputItem.AstSLRef,  
  
		AstDLRef = inputItem.AstDLRef,  
  
		AstDLFive = inputItem.AstDLFive,  
  
		AstDLSix = inputItem.AstDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Assets Map(Assets entity ,EditAssetsCommand inputItem)
        {
              
  
		entity.AstId = inputItem.AstId;  
  
		entity.AstPlatNo = inputItem.AstPlatNo;  
  
		entity.AstTitle = inputItem.AstTitle;  
  
		entity.AstCreateDate = inputItem.AstCreateDate;  
  
		entity.AstUseDate = inputItem.AstUseDate;  
  
		entity.AstDocRef = inputItem.AstDocRef;  
  
		entity.AstSLRef = inputItem.AstSLRef;  
  
		entity.AstDLRef = inputItem.AstDLRef;  
  
		entity.AstDLFive = inputItem.AstDLFive;  
  
		entity.AstDLSix = inputItem.AstDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AssetsDto Map(Assets inputItem)
        {
            var dto = new AssetsDto()
            {
                  
  
		AstId = inputItem.AstId,  
  
		AstPlatNo = inputItem.AstPlatNo,  
  
		AstTitle = inputItem.AstTitle,  
  
		AstCreateDate = inputItem.AstCreateDate,  
  
		AstUseDate = inputItem.AstUseDate,  
  
		AstDocRef = inputItem.AstDocRef,  
  
		AstSLRef = inputItem.AstSLRef,  
  
		AstDLRef = inputItem.AstDLRef,  
  
		AstDLFive = inputItem.AstDLFive,  
  
		AstDLSix = inputItem.AstDLSix, 
            };
            return dto;
        }

        public static List<AssetsDto> Map(ICollection<Assets> entities)
        {
            var dtos = new List<AssetsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AssetsDto()
                {
                      
  
		AstId = inputItem.AstId,  
  
		AstPlatNo = inputItem.AstPlatNo,  
  
		AstTitle = inputItem.AstTitle,  
  
		AstCreateDate = inputItem.AstCreateDate,  
  
		AstUseDate = inputItem.AstUseDate,  
  
		AstDocRef = inputItem.AstDocRef,  
  
		AstSLRef = inputItem.AstSLRef,  
  
		AstDLRef = inputItem.AstDLRef,  
  
		AstDLFive = inputItem.AstDLFive,  
  
		AstDLSix = inputItem.AstDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetCost Map(AddAstAssetCostCommand inputItem)
        {
            var entity = new AstAssetCost() {
                  
  
		AstAssetCstId = inputItem.AstAssetCstId,  
  
		AstDocCostRef = inputItem.AstDocCostRef,  
  
		AACAstRef = inputItem.AACAstRef,  
  
		AACCstType = inputItem.AACCstType,  
  
		AACDate = inputItem.AACDate,  
  
		AACCost = inputItem.AACCost,  
  
		AACAstInfRef = inputItem.AACAstInfRef,  
  
		AACSLRef = inputItem.AACSLRef,  
  
		AACDLRef = inputItem.AACDLRef,  
  
		AACDLFive = inputItem.AACDLFive,  
  
		AACDLSix = inputItem.AACDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetCost Map(AstAssetCost entity ,EditAstAssetCostCommand inputItem)
        {
              
  
		entity.AstAssetCstId = inputItem.AstAssetCstId;  
  
		entity.AstDocCostRef = inputItem.AstDocCostRef;  
  
		entity.AACAstRef = inputItem.AACAstRef;  
  
		entity.AACCstType = inputItem.AACCstType;  
  
		entity.AACDate = inputItem.AACDate;  
  
		entity.AACCost = inputItem.AACCost;  
  
		entity.AACAstInfRef = inputItem.AACAstInfRef;  
  
		entity.AACSLRef = inputItem.AACSLRef;  
  
		entity.AACDLRef = inputItem.AACDLRef;  
  
		entity.AACDLFive = inputItem.AACDLFive;  
  
		entity.AACDLSix = inputItem.AACDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetCostDto Map(AstAssetCost inputItem)
        {
            var dto = new AstAssetCostDto()
            {
                  
  
		AstAssetCstId = inputItem.AstAssetCstId,  
  
		AstDocCostRef = inputItem.AstDocCostRef,  
  
		AACAstRef = inputItem.AACAstRef,  
  
		AACCstType = inputItem.AACCstType,  
  
		AACDate = inputItem.AACDate,  
  
		AACCost = inputItem.AACCost,  
  
		AACAstInfRef = inputItem.AACAstInfRef,  
  
		AACSLRef = inputItem.AACSLRef,  
  
		AACDLRef = inputItem.AACDLRef,  
  
		AACDLFive = inputItem.AACDLFive,  
  
		AACDLSix = inputItem.AACDLSix, 
            };
            return dto;
        }

        public static List<AstAssetCostDto> Map(ICollection<AstAssetCost> entities)
        {
            var dtos = new List<AstAssetCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetCostDto()
                {
                      
  
		AstAssetCstId = inputItem.AstAssetCstId,  
  
		AstDocCostRef = inputItem.AstDocCostRef,  
  
		AACAstRef = inputItem.AACAstRef,  
  
		AACCstType = inputItem.AACCstType,  
  
		AACDate = inputItem.AACDate,  
  
		AACCost = inputItem.AACCost,  
  
		AACAstInfRef = inputItem.AACAstInfRef,  
  
		AACSLRef = inputItem.AACSLRef,  
  
		AACDLRef = inputItem.AACDLRef,  
  
		AACDLFive = inputItem.AACDLFive,  
  
		AACDLSix = inputItem.AACDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetCtgry Map(AddAstAssetCtgryCommand inputItem)
        {
            var entity = new AstAssetCtgry() {
                  
  
		AstAssetCtgryId = inputItem.AstAssetCtgryId,  
  
		AACCode = inputItem.AACCode,  
  
		AACName = inputItem.AACName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetCtgry Map(AstAssetCtgry entity ,EditAstAssetCtgryCommand inputItem)
        {
              
  
		entity.AstAssetCtgryId = inputItem.AstAssetCtgryId;  
  
		entity.AACCode = inputItem.AACCode;  
  
		entity.AACName = inputItem.AACName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetCtgryDto Map(AstAssetCtgry inputItem)
        {
            var dto = new AstAssetCtgryDto()
            {
                  
  
		AstAssetCtgryId = inputItem.AstAssetCtgryId,  
  
		AACCode = inputItem.AACCode,  
  
		AACName = inputItem.AACName, 
            };
            return dto;
        }

        public static List<AstAssetCtgryDto> Map(ICollection<AstAssetCtgry> entities)
        {
            var dtos = new List<AstAssetCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetCtgryDto()
                {
                      
  
		AstAssetCtgryId = inputItem.AstAssetCtgryId,  
  
		AACCode = inputItem.AACCode,  
  
		AACName = inputItem.AACName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetDepr Map(AddAstAssetDeprCommand inputItem)
        {
            var entity = new AstAssetDepr() {
                  
  
		AstAssetDeprId = inputItem.AstAssetDeprId,  
  
		AADAstRef = inputItem.AADAstRef,  
  
		AADDeprType = inputItem.AADDeprType,  
  
		AADYear = inputItem.AADYear,  
  
		AADMonth = inputItem.AADMonth,  
  
		AADAstInfRef = inputItem.AADAstInfRef,  
  
		AADAmount = inputItem.AADAmount,  
  
		AADCstAmount = inputItem.AADCstAmount,  
  
		AADAccPrdRef = inputItem.AADAccPrdRef,  
  
		AADDeprVchRef = inputItem.AADDeprVchRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetDepr Map(AstAssetDepr entity ,EditAstAssetDeprCommand inputItem)
        {
              
  
		entity.AstAssetDeprId = inputItem.AstAssetDeprId;  
  
		entity.AADAstRef = inputItem.AADAstRef;  
  
		entity.AADDeprType = inputItem.AADDeprType;  
  
		entity.AADYear = inputItem.AADYear;  
  
		entity.AADMonth = inputItem.AADMonth;  
  
		entity.AADAstInfRef = inputItem.AADAstInfRef;  
  
		entity.AADAmount = inputItem.AADAmount;  
  
		entity.AADCstAmount = inputItem.AADCstAmount;  
  
		entity.AADAccPrdRef = inputItem.AADAccPrdRef;  
  
		entity.AADDeprVchRef = inputItem.AADDeprVchRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetDeprDto Map(AstAssetDepr inputItem)
        {
            var dto = new AstAssetDeprDto()
            {
                  
  
		AstAssetDeprId = inputItem.AstAssetDeprId,  
  
		AADAstRef = inputItem.AADAstRef,  
  
		AADDeprType = inputItem.AADDeprType,  
  
		AADYear = inputItem.AADYear,  
  
		AADMonth = inputItem.AADMonth,  
  
		AADAstInfRef = inputItem.AADAstInfRef,  
  
		AADAmount = inputItem.AADAmount,  
  
		AADCstAmount = inputItem.AADCstAmount,  
  
		AADAccPrdRef = inputItem.AADAccPrdRef,  
  
		AADDeprVchRef = inputItem.AADDeprVchRef, 
            };
            return dto;
        }

        public static List<AstAssetDeprDto> Map(ICollection<AstAssetDepr> entities)
        {
            var dtos = new List<AstAssetDeprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetDeprDto()
                {
                      
  
		AstAssetDeprId = inputItem.AstAssetDeprId,  
  
		AADAstRef = inputItem.AADAstRef,  
  
		AADDeprType = inputItem.AADDeprType,  
  
		AADYear = inputItem.AADYear,  
  
		AADMonth = inputItem.AADMonth,  
  
		AADAstInfRef = inputItem.AADAstInfRef,  
  
		AADAmount = inputItem.AADAmount,  
  
		AADCstAmount = inputItem.AADCstAmount,  
  
		AADAccPrdRef = inputItem.AADAccPrdRef,  
  
		AADDeprVchRef = inputItem.AADDeprVchRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetGrp Map(AddAstAssetGrpCommand inputItem)
        {
            var entity = new AstAssetGrp() {
                  
  
		AstAssetGrpId = inputItem.AstAssetGrpId,  
  
		AAGParent = inputItem.AAGParent,  
  
		AAGCode = inputItem.AAGCode,  
  
		AAGTitle = inputItem.AAGTitle,  
  
		AstCtgryRef = inputItem.AstCtgryRef,  
  
		AAGMethod = inputItem.AAGMethod,  
  
		AAGRatio = inputItem.AAGRatio,  
  
		AAGMainRoot = inputItem.AAGMainRoot,  
  
		AAGSLRef = inputItem.AAGSLRef,  
  
		AAGDL4Type = inputItem.AAGDL4Type,  
  
		AAGDL4Code = inputItem.AAGDL4Code,  
  
		AAGDL5Type = inputItem.AAGDL5Type,  
  
		AAGDL5Code = inputItem.AAGDL5Code,  
  
		AAGDL6Type = inputItem.AAGDL6Type,  
  
		AAGDL6Code = inputItem.AAGDL6Code,  
  
		AAGAccumDeprSLRef = inputItem.AAGAccumDeprSLRef,  
  
		AAGAccumDeprDL4Type = inputItem.AAGAccumDeprDL4Type,  
  
		AAGAccumDeprDL4Code = inputItem.AAGAccumDeprDL4Code,  
  
		AAGAccumDeprDL5Type = inputItem.AAGAccumDeprDL5Type,  
  
		AAGAccumDeprDL5Code = inputItem.AAGAccumDeprDL5Code,  
  
		AAGAccumDeprDL6Type = inputItem.AAGAccumDeprDL6Type,  
  
		AAGAccumDeprDL6Code = inputItem.AAGAccumDeprDL6Code,  
  
		AAGDeprSLRef = inputItem.AAGDeprSLRef,  
  
		AAGDeprDL4Type = inputItem.AAGDeprDL4Type,  
  
		AAGDeprDL4Code = inputItem.AAGDeprDL4Code,  
  
		AAGDeprDL5Type = inputItem.AAGDeprDL5Type,  
  
		AAGDeprDL5Code = inputItem.AAGDeprDL5Code,  
  
		AAGDeprDL6Type = inputItem.AAGDeprDL6Type,  
  
		AAGDeprDL6Code = inputItem.AAGDeprDL6Code,  
  
		AAGCstSLRef = inputItem.AAGCstSLRef,  
  
		AAGCstDL4Type = inputItem.AAGCstDL4Type,  
  
		AAGCstDL4Code = inputItem.AAGCstDL4Code,  
  
		AAGCstDL5Type = inputItem.AAGCstDL5Type,  
  
		AAGCstDL5Code = inputItem.AAGCstDL5Code,  
  
		AAGCstDL6Type = inputItem.AAGCstDL6Type,  
  
		AAGCstDL6Code = inputItem.AAGCstDL6Code, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetGrp Map(AstAssetGrp entity ,EditAstAssetGrpCommand inputItem)
        {
              
  
		entity.AstAssetGrpId = inputItem.AstAssetGrpId;  
  
		entity.AAGParent = inputItem.AAGParent;  
  
		entity.AAGCode = inputItem.AAGCode;  
  
		entity.AAGTitle = inputItem.AAGTitle;  
  
		entity.AstCtgryRef = inputItem.AstCtgryRef;  
  
		entity.AAGMethod = inputItem.AAGMethod;  
  
		entity.AAGRatio = inputItem.AAGRatio;  
  
		entity.AAGMainRoot = inputItem.AAGMainRoot;  
  
		entity.AAGSLRef = inputItem.AAGSLRef;  
  
		entity.AAGDL4Type = inputItem.AAGDL4Type;  
  
		entity.AAGDL4Code = inputItem.AAGDL4Code;  
  
		entity.AAGDL5Type = inputItem.AAGDL5Type;  
  
		entity.AAGDL5Code = inputItem.AAGDL5Code;  
  
		entity.AAGDL6Type = inputItem.AAGDL6Type;  
  
		entity.AAGDL6Code = inputItem.AAGDL6Code;  
  
		entity.AAGAccumDeprSLRef = inputItem.AAGAccumDeprSLRef;  
  
		entity.AAGAccumDeprDL4Type = inputItem.AAGAccumDeprDL4Type;  
  
		entity.AAGAccumDeprDL4Code = inputItem.AAGAccumDeprDL4Code;  
  
		entity.AAGAccumDeprDL5Type = inputItem.AAGAccumDeprDL5Type;  
  
		entity.AAGAccumDeprDL5Code = inputItem.AAGAccumDeprDL5Code;  
  
		entity.AAGAccumDeprDL6Type = inputItem.AAGAccumDeprDL6Type;  
  
		entity.AAGAccumDeprDL6Code = inputItem.AAGAccumDeprDL6Code;  
  
		entity.AAGDeprSLRef = inputItem.AAGDeprSLRef;  
  
		entity.AAGDeprDL4Type = inputItem.AAGDeprDL4Type;  
  
		entity.AAGDeprDL4Code = inputItem.AAGDeprDL4Code;  
  
		entity.AAGDeprDL5Type = inputItem.AAGDeprDL5Type;  
  
		entity.AAGDeprDL5Code = inputItem.AAGDeprDL5Code;  
  
		entity.AAGDeprDL6Type = inputItem.AAGDeprDL6Type;  
  
		entity.AAGDeprDL6Code = inputItem.AAGDeprDL6Code;  
  
		entity.AAGCstSLRef = inputItem.AAGCstSLRef;  
  
		entity.AAGCstDL4Type = inputItem.AAGCstDL4Type;  
  
		entity.AAGCstDL4Code = inputItem.AAGCstDL4Code;  
  
		entity.AAGCstDL5Type = inputItem.AAGCstDL5Type;  
  
		entity.AAGCstDL5Code = inputItem.AAGCstDL5Code;  
  
		entity.AAGCstDL6Type = inputItem.AAGCstDL6Type;  
  
		entity.AAGCstDL6Code = inputItem.AAGCstDL6Code; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetGrpDto Map(AstAssetGrp inputItem)
        {
            var dto = new AstAssetGrpDto()
            {
                  
  
		AstAssetGrpId = inputItem.AstAssetGrpId,  
  
		AAGParent = inputItem.AAGParent,  
  
		AAGCode = inputItem.AAGCode,  
  
		AAGTitle = inputItem.AAGTitle,  
  
		AstCtgryRef = inputItem.AstCtgryRef,  
  
		AAGMethod = inputItem.AAGMethod,  
  
		AAGRatio = inputItem.AAGRatio,  
  
		AAGMainRoot = inputItem.AAGMainRoot,  
  
		AAGSLRef = inputItem.AAGSLRef,  
  
		AAGDL4Type = inputItem.AAGDL4Type,  
  
		AAGDL4Code = inputItem.AAGDL4Code,  
  
		AAGDL5Type = inputItem.AAGDL5Type,  
  
		AAGDL5Code = inputItem.AAGDL5Code,  
  
		AAGDL6Type = inputItem.AAGDL6Type,  
  
		AAGDL6Code = inputItem.AAGDL6Code,  
  
		AAGAccumDeprSLRef = inputItem.AAGAccumDeprSLRef,  
  
		AAGAccumDeprDL4Type = inputItem.AAGAccumDeprDL4Type,  
  
		AAGAccumDeprDL4Code = inputItem.AAGAccumDeprDL4Code,  
  
		AAGAccumDeprDL5Type = inputItem.AAGAccumDeprDL5Type,  
  
		AAGAccumDeprDL5Code = inputItem.AAGAccumDeprDL5Code,  
  
		AAGAccumDeprDL6Type = inputItem.AAGAccumDeprDL6Type,  
  
		AAGAccumDeprDL6Code = inputItem.AAGAccumDeprDL6Code,  
  
		AAGDeprSLRef = inputItem.AAGDeprSLRef,  
  
		AAGDeprDL4Type = inputItem.AAGDeprDL4Type,  
  
		AAGDeprDL4Code = inputItem.AAGDeprDL4Code,  
  
		AAGDeprDL5Type = inputItem.AAGDeprDL5Type,  
  
		AAGDeprDL5Code = inputItem.AAGDeprDL5Code,  
  
		AAGDeprDL6Type = inputItem.AAGDeprDL6Type,  
  
		AAGDeprDL6Code = inputItem.AAGDeprDL6Code,  
  
		AAGCstSLRef = inputItem.AAGCstSLRef,  
  
		AAGCstDL4Type = inputItem.AAGCstDL4Type,  
  
		AAGCstDL4Code = inputItem.AAGCstDL4Code,  
  
		AAGCstDL5Type = inputItem.AAGCstDL5Type,  
  
		AAGCstDL5Code = inputItem.AAGCstDL5Code,  
  
		AAGCstDL6Type = inputItem.AAGCstDL6Type,  
  
		AAGCstDL6Code = inputItem.AAGCstDL6Code, 
            };
            return dto;
        }

        public static List<AstAssetGrpDto> Map(ICollection<AstAssetGrp> entities)
        {
            var dtos = new List<AstAssetGrpDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetGrpDto()
                {
                      
  
		AstAssetGrpId = inputItem.AstAssetGrpId,  
  
		AAGParent = inputItem.AAGParent,  
  
		AAGCode = inputItem.AAGCode,  
  
		AAGTitle = inputItem.AAGTitle,  
  
		AstCtgryRef = inputItem.AstCtgryRef,  
  
		AAGMethod = inputItem.AAGMethod,  
  
		AAGRatio = inputItem.AAGRatio,  
  
		AAGMainRoot = inputItem.AAGMainRoot,  
  
		AAGSLRef = inputItem.AAGSLRef,  
  
		AAGDL4Type = inputItem.AAGDL4Type,  
  
		AAGDL4Code = inputItem.AAGDL4Code,  
  
		AAGDL5Type = inputItem.AAGDL5Type,  
  
		AAGDL5Code = inputItem.AAGDL5Code,  
  
		AAGDL6Type = inputItem.AAGDL6Type,  
  
		AAGDL6Code = inputItem.AAGDL6Code,  
  
		AAGAccumDeprSLRef = inputItem.AAGAccumDeprSLRef,  
  
		AAGAccumDeprDL4Type = inputItem.AAGAccumDeprDL4Type,  
  
		AAGAccumDeprDL4Code = inputItem.AAGAccumDeprDL4Code,  
  
		AAGAccumDeprDL5Type = inputItem.AAGAccumDeprDL5Type,  
  
		AAGAccumDeprDL5Code = inputItem.AAGAccumDeprDL5Code,  
  
		AAGAccumDeprDL6Type = inputItem.AAGAccumDeprDL6Type,  
  
		AAGAccumDeprDL6Code = inputItem.AAGAccumDeprDL6Code,  
  
		AAGDeprSLRef = inputItem.AAGDeprSLRef,  
  
		AAGDeprDL4Type = inputItem.AAGDeprDL4Type,  
  
		AAGDeprDL4Code = inputItem.AAGDeprDL4Code,  
  
		AAGDeprDL5Type = inputItem.AAGDeprDL5Type,  
  
		AAGDeprDL5Code = inputItem.AAGDeprDL5Code,  
  
		AAGDeprDL6Type = inputItem.AAGDeprDL6Type,  
  
		AAGDeprDL6Code = inputItem.AAGDeprDL6Code,  
  
		AAGCstSLRef = inputItem.AAGCstSLRef,  
  
		AAGCstDL4Type = inputItem.AAGCstDL4Type,  
  
		AAGCstDL4Code = inputItem.AAGCstDL4Code,  
  
		AAGCstDL5Type = inputItem.AAGCstDL5Type,  
  
		AAGCstDL5Code = inputItem.AAGCstDL5Code,  
  
		AAGCstDL6Type = inputItem.AAGCstDL6Type,  
  
		AAGCstDL6Code = inputItem.AAGCstDL6Code, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetInf Map(AddAstAssetInfCommand inputItem)
        {
            var entity = new AstAssetInf() {
                  
  
		AstAssetInfId = inputItem.AstAssetInfId,  
  
		AstDocTransRef = inputItem.AstDocTransRef,  
  
		AAIAstRef = inputItem.AAIAstRef,  
  
		AAIType = inputItem.AAIType,  
  
		AAIDate = inputItem.AAIDate,  
  
		AAIGrpRef = inputItem.AAIGrpRef,  
  
		AAIPitchRef = inputItem.AAIPitchRef,  
  
		AAIMenRef = inputItem.AAIMenRef,  
  
		AAICstRef = inputItem.AAICstRef,  
  
		AAIAstState = inputItem.AAIAstState,  
  
		AAIResponse = inputItem.AAIResponse, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetInf Map(AstAssetInf entity ,EditAstAssetInfCommand inputItem)
        {
              
  
		entity.AstAssetInfId = inputItem.AstAssetInfId;  
  
		entity.AstDocTransRef = inputItem.AstDocTransRef;  
  
		entity.AAIAstRef = inputItem.AAIAstRef;  
  
		entity.AAIType = inputItem.AAIType;  
  
		entity.AAIDate = inputItem.AAIDate;  
  
		entity.AAIGrpRef = inputItem.AAIGrpRef;  
  
		entity.AAIPitchRef = inputItem.AAIPitchRef;  
  
		entity.AAIMenRef = inputItem.AAIMenRef;  
  
		entity.AAICstRef = inputItem.AAICstRef;  
  
		entity.AAIAstState = inputItem.AAIAstState;  
  
		entity.AAIResponse = inputItem.AAIResponse; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetInfDto Map(AstAssetInf inputItem)
        {
            var dto = new AstAssetInfDto()
            {
                  
  
		AstAssetInfId = inputItem.AstAssetInfId,  
  
		AstDocTransRef = inputItem.AstDocTransRef,  
  
		AAIAstRef = inputItem.AAIAstRef,  
  
		AAIType = inputItem.AAIType,  
  
		AAIDate = inputItem.AAIDate,  
  
		AAIGrpRef = inputItem.AAIGrpRef,  
  
		AAIPitchRef = inputItem.AAIPitchRef,  
  
		AAIMenRef = inputItem.AAIMenRef,  
  
		AAICstRef = inputItem.AAICstRef,  
  
		AAIAstState = inputItem.AAIAstState,  
  
		AAIResponse = inputItem.AAIResponse, 
            };
            return dto;
        }

        public static List<AstAssetInfDto> Map(ICollection<AstAssetInf> entities)
        {
            var dtos = new List<AstAssetInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetInfDto()
                {
                      
  
		AstAssetInfId = inputItem.AstAssetInfId,  
  
		AstDocTransRef = inputItem.AstDocTransRef,  
  
		AAIAstRef = inputItem.AAIAstRef,  
  
		AAIType = inputItem.AAIType,  
  
		AAIDate = inputItem.AAIDate,  
  
		AAIGrpRef = inputItem.AAIGrpRef,  
  
		AAIPitchRef = inputItem.AAIPitchRef,  
  
		AAIMenRef = inputItem.AAIMenRef,  
  
		AAICstRef = inputItem.AAICstRef,  
  
		AAIAstState = inputItem.AAIAstState,  
  
		AAIResponse = inputItem.AAIResponse, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetRate Map(AddAstAssetRateCommand inputItem)
        {
            var entity = new AstAssetRate() {
                  
  
		AstAssetRateId = inputItem.AstAssetRateId,  
  
		AARAstRef = inputItem.AARAstRef,  
  
		AARType = inputItem.AARType,  
  
		AARDepType = inputItem.AARDepType,  
  
		AARDate = inputItem.AARDate,  
  
		AARRatio = inputItem.AARRatio,  
  
		AstDocRatioRef = inputItem.AstDocRatioRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetRate Map(AstAssetRate entity ,EditAstAssetRateCommand inputItem)
        {
              
  
		entity.AstAssetRateId = inputItem.AstAssetRateId;  
  
		entity.AARAstRef = inputItem.AARAstRef;  
  
		entity.AARType = inputItem.AARType;  
  
		entity.AARDepType = inputItem.AARDepType;  
  
		entity.AARDate = inputItem.AARDate;  
  
		entity.AARRatio = inputItem.AARRatio;  
  
		entity.AstDocRatioRef = inputItem.AstDocRatioRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetRateDto Map(AstAssetRate inputItem)
        {
            var dto = new AstAssetRateDto()
            {
                  
  
		AstAssetRateId = inputItem.AstAssetRateId,  
  
		AARAstRef = inputItem.AARAstRef,  
  
		AARType = inputItem.AARType,  
  
		AARDepType = inputItem.AARDepType,  
  
		AARDate = inputItem.AARDate,  
  
		AARRatio = inputItem.AARRatio,  
  
		AstDocRatioRef = inputItem.AstDocRatioRef, 
            };
            return dto;
        }

        public static List<AstAssetRateDto> Map(ICollection<AstAssetRate> entities)
        {
            var dtos = new List<AstAssetRateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetRateDto()
                {
                      
  
		AstAssetRateId = inputItem.AstAssetRateId,  
  
		AARAstRef = inputItem.AARAstRef,  
  
		AARType = inputItem.AARType,  
  
		AARDepType = inputItem.AARDepType,  
  
		AARDate = inputItem.AARDate,  
  
		AARRatio = inputItem.AARRatio,  
  
		AstDocRatioRef = inputItem.AstDocRatioRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstAssetSale Map(AddAstAssetSaleCommand inputItem)
        {
            var entity = new AstAssetSale() {
                  
  
		AASAstRef = inputItem.AASAstRef,  
  
		AASCost = inputItem.AASCost,  
  
		AASAstCstRef = inputItem.AASAstCstRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstAssetSale Map(AstAssetSale entity ,EditAstAssetSaleCommand inputItem)
        {
              
  
		entity.AASAstRef = inputItem.AASAstRef;  
  
		entity.AASCost = inputItem.AASCost;  
  
		entity.AASAstCstRef = inputItem.AASAstCstRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstAssetSaleDto Map(AstAssetSale inputItem)
        {
            var dto = new AstAssetSaleDto()
            {
                  
  
		AASAstRef = inputItem.AASAstRef,  
  
		AASCost = inputItem.AASCost,  
  
		AASAstCstRef = inputItem.AASAstCstRef, 
            };
            return dto;
        }

        public static List<AstAssetSaleDto> Map(ICollection<AstAssetSale> entities)
        {
            var dtos = new List<AstAssetSaleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstAssetSaleDto()
                {
                      
  
		AASAstRef = inputItem.AASAstRef,  
  
		AASCost = inputItem.AASCost,  
  
		AASAstCstRef = inputItem.AASAstCstRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstCostDet Map(AddAstCostDetCommand inputItem)
        {
            var entity = new AstCostDet() {
                  
  
		AstCostDetID = inputItem.AstCostDetID,  
  
		ACDType = inputItem.ACDType,  
  
		ACDItmRef = inputItem.ACDItmRef,  
  
		ACDInstall = inputItem.ACDInstall,  
  
		ACDOther = inputItem.ACDOther,  
  
		ACDTax = inputItem.ACDTax,  
  
		ACDDuty = inputItem.ACDDuty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstCostDet Map(AstCostDet entity ,EditAstCostDetCommand inputItem)
        {
              
  
		entity.AstCostDetID = inputItem.AstCostDetID;  
  
		entity.ACDType = inputItem.ACDType;  
  
		entity.ACDItmRef = inputItem.ACDItmRef;  
  
		entity.ACDInstall = inputItem.ACDInstall;  
  
		entity.ACDOther = inputItem.ACDOther;  
  
		entity.ACDTax = inputItem.ACDTax;  
  
		entity.ACDDuty = inputItem.ACDDuty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstCostDetDto Map(AstCostDet inputItem)
        {
            var dto = new AstCostDetDto()
            {
                  
  
		AstCostDetID = inputItem.AstCostDetID,  
  
		ACDType = inputItem.ACDType,  
  
		ACDItmRef = inputItem.ACDItmRef,  
  
		ACDInstall = inputItem.ACDInstall,  
  
		ACDOther = inputItem.ACDOther,  
  
		ACDTax = inputItem.ACDTax,  
  
		ACDDuty = inputItem.ACDDuty, 
            };
            return dto;
        }

        public static List<AstCostDetDto> Map(ICollection<AstCostDet> entities)
        {
            var dtos = new List<AstCostDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstCostDetDto()
                {
                      
  
		AstCostDetID = inputItem.AstCostDetID,  
  
		ACDType = inputItem.ACDType,  
  
		ACDItmRef = inputItem.ACDItmRef,  
  
		ACDInstall = inputItem.ACDInstall,  
  
		ACDOther = inputItem.ACDOther,  
  
		ACDTax = inputItem.ACDTax,  
  
		ACDDuty = inputItem.ACDDuty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstCostDocs Map(AddAstCostDocsCommand inputItem)
        {
            var entity = new AstCostDocs() {
                  
  
		AstCstDocId = inputItem.AstCstDocId,  
  
		AsDCType = inputItem.AsDCType,  
  
		AsDCDate = inputItem.AsDCDate,  
  
		AsDCNum = inputItem.AsDCNum,  
  
		AsDCLocalNum = inputItem.AsDCLocalNum,  
  
		AsDCDescr = inputItem.AsDCDescr,  
  
		AsDCState = inputItem.AsDCState,  
  
		AsDCAccPrdRef = inputItem.AsDCAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstCostDocs Map(AstCostDocs entity ,EditAstCostDocsCommand inputItem)
        {
              
  
		entity.AstCstDocId = inputItem.AstCstDocId;  
  
		entity.AsDCType = inputItem.AsDCType;  
  
		entity.AsDCDate = inputItem.AsDCDate;  
  
		entity.AsDCNum = inputItem.AsDCNum;  
  
		entity.AsDCLocalNum = inputItem.AsDCLocalNum;  
  
		entity.AsDCDescr = inputItem.AsDCDescr;  
  
		entity.AsDCState = inputItem.AsDCState;  
  
		entity.AsDCAccPrdRef = inputItem.AsDCAccPrdRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstCostDocsDto Map(AstCostDocs inputItem)
        {
            var dto = new AstCostDocsDto()
            {
                  
  
		AstCstDocId = inputItem.AstCstDocId,  
  
		AsDCType = inputItem.AsDCType,  
  
		AsDCDate = inputItem.AsDCDate,  
  
		AsDCNum = inputItem.AsDCNum,  
  
		AsDCLocalNum = inputItem.AsDCLocalNum,  
  
		AsDCDescr = inputItem.AsDCDescr,  
  
		AsDCState = inputItem.AsDCState,  
  
		AsDCAccPrdRef = inputItem.AsDCAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<AstCostDocsDto> Map(ICollection<AstCostDocs> entities)
        {
            var dtos = new List<AstCostDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstCostDocsDto()
                {
                      
  
		AstCstDocId = inputItem.AstCstDocId,  
  
		AsDCType = inputItem.AsDCType,  
  
		AsDCDate = inputItem.AsDCDate,  
  
		AsDCNum = inputItem.AsDCNum,  
  
		AsDCLocalNum = inputItem.AsDCLocalNum,  
  
		AsDCDescr = inputItem.AsDCDescr,  
  
		AsDCState = inputItem.AsDCState,  
  
		AsDCAccPrdRef = inputItem.AsDCAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstDeprVch Map(AddAstDeprVchCommand inputItem)
        {
            var entity = new AstDeprVch() {
                  
  
		AstDeprVchId = inputItem.AstDeprVchId,  
  
		ADVFromMonth = inputItem.ADVFromMonth,  
  
		ADVToMonth = inputItem.ADVToMonth,  
  
		ADVYear = inputItem.ADVYear,  
  
		ADVDescr = inputItem.ADVDescr,  
  
		ADVPrdRef = inputItem.ADVPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstDeprVch Map(AstDeprVch entity ,EditAstDeprVchCommand inputItem)
        {
              
  
		entity.AstDeprVchId = inputItem.AstDeprVchId;  
  
		entity.ADVFromMonth = inputItem.ADVFromMonth;  
  
		entity.ADVToMonth = inputItem.ADVToMonth;  
  
		entity.ADVYear = inputItem.ADVYear;  
  
		entity.ADVDescr = inputItem.ADVDescr;  
  
		entity.ADVPrdRef = inputItem.ADVPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstDeprVchDto Map(AstDeprVch inputItem)
        {
            var dto = new AstDeprVchDto()
            {
                  
  
		AstDeprVchId = inputItem.AstDeprVchId,  
  
		ADVFromMonth = inputItem.ADVFromMonth,  
  
		ADVToMonth = inputItem.ADVToMonth,  
  
		ADVYear = inputItem.ADVYear,  
  
		ADVDescr = inputItem.ADVDescr,  
  
		ADVPrdRef = inputItem.ADVPrdRef, 
            };
            return dto;
        }

        public static List<AstDeprVchDto> Map(ICollection<AstDeprVch> entities)
        {
            var dtos = new List<AstDeprVchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstDeprVchDto()
                {
                      
  
		AstDeprVchId = inputItem.AstDeprVchId,  
  
		ADVFromMonth = inputItem.ADVFromMonth,  
  
		ADVToMonth = inputItem.ADVToMonth,  
  
		ADVYear = inputItem.ADVYear,  
  
		ADVDescr = inputItem.ADVDescr,  
  
		ADVPrdRef = inputItem.ADVPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstDocs Map(AddAstDocsCommand inputItem)
        {
            var entity = new AstDocs() {
                  
  
		AstDocId = inputItem.AstDocId,  
  
		AsDType = inputItem.AsDType,  
  
		AsDDate = inputItem.AsDDate,  
  
		AsDNum = inputItem.AsDNum,  
  
		AsDLocalNum = inputItem.AsDLocalNum,  
  
		AsDGrpRef = inputItem.AsDGrpRef,  
  
		AsDPitchRef = inputItem.AsDPitchRef,  
  
		AsDMenRef = inputItem.AsDMenRef,  
  
		AsDCostCenter = inputItem.AsDCostCenter,  
  
		AsDAccPrdRef = inputItem.AsDAccPrdRef,  
  
		AsDDescr = inputItem.AsDDescr,  
  
		AsDState = inputItem.AsDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstDocs Map(AstDocs entity ,EditAstDocsCommand inputItem)
        {
              
  
		entity.AstDocId = inputItem.AstDocId;  
  
		entity.AsDType = inputItem.AsDType;  
  
		entity.AsDDate = inputItem.AsDDate;  
  
		entity.AsDNum = inputItem.AsDNum;  
  
		entity.AsDLocalNum = inputItem.AsDLocalNum;  
  
		entity.AsDGrpRef = inputItem.AsDGrpRef;  
  
		entity.AsDPitchRef = inputItem.AsDPitchRef;  
  
		entity.AsDMenRef = inputItem.AsDMenRef;  
  
		entity.AsDCostCenter = inputItem.AsDCostCenter;  
  
		entity.AsDAccPrdRef = inputItem.AsDAccPrdRef;  
  
		entity.AsDDescr = inputItem.AsDDescr;  
  
		entity.AsDState = inputItem.AsDState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstDocsDto Map(AstDocs inputItem)
        {
            var dto = new AstDocsDto()
            {
                  
  
		AstDocId = inputItem.AstDocId,  
  
		AsDType = inputItem.AsDType,  
  
		AsDDate = inputItem.AsDDate,  
  
		AsDNum = inputItem.AsDNum,  
  
		AsDLocalNum = inputItem.AsDLocalNum,  
  
		AsDGrpRef = inputItem.AsDGrpRef,  
  
		AsDPitchRef = inputItem.AsDPitchRef,  
  
		AsDMenRef = inputItem.AsDMenRef,  
  
		AsDCostCenter = inputItem.AsDCostCenter,  
  
		AsDAccPrdRef = inputItem.AsDAccPrdRef,  
  
		AsDDescr = inputItem.AsDDescr,  
  
		AsDState = inputItem.AsDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<AstDocsDto> Map(ICollection<AstDocs> entities)
        {
            var dtos = new List<AstDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstDocsDto()
                {
                      
  
		AstDocId = inputItem.AstDocId,  
  
		AsDType = inputItem.AsDType,  
  
		AsDDate = inputItem.AsDDate,  
  
		AsDNum = inputItem.AsDNum,  
  
		AsDLocalNum = inputItem.AsDLocalNum,  
  
		AsDGrpRef = inputItem.AsDGrpRef,  
  
		AsDPitchRef = inputItem.AsDPitchRef,  
  
		AsDMenRef = inputItem.AsDMenRef,  
  
		AsDCostCenter = inputItem.AsDCostCenter,  
  
		AsDAccPrdRef = inputItem.AsDAccPrdRef,  
  
		AsDDescr = inputItem.AsDDescr,  
  
		AsDState = inputItem.AsDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstMens Map(AddAstMensCommand inputItem)
        {
            var entity = new AstMens() {
                  
  
		AstMenId = inputItem.AstMenId,  
  
		AMCrsRef = inputItem.AMCrsRef,  
  
		AMIDate = inputItem.AMIDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstMens Map(AstMens entity ,EditAstMensCommand inputItem)
        {
              
  
		entity.AstMenId = inputItem.AstMenId;  
  
		entity.AMCrsRef = inputItem.AMCrsRef;  
  
		entity.AMIDate = inputItem.AMIDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstMensDto Map(AstMens inputItem)
        {
            var dto = new AstMensDto()
            {
                  
  
		AstMenId = inputItem.AstMenId,  
  
		AMCrsRef = inputItem.AMCrsRef,  
  
		AMIDate = inputItem.AMIDate, 
            };
            return dto;
        }

        public static List<AstMensDto> Map(ICollection<AstMens> entities)
        {
            var dtos = new List<AstMensDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstMensDto()
                {
                      
  
		AstMenId = inputItem.AstMenId,  
  
		AMCrsRef = inputItem.AMCrsRef,  
  
		AMIDate = inputItem.AMIDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstPitchs Map(AddAstPitchsCommand inputItem)
        {
            var entity = new AstPitchs() {
                  
  
		AstPitchId = inputItem.AstPitchId,  
  
		AstPitchParent = inputItem.AstPitchParent,  
  
		AstPitchCode = inputItem.AstPitchCode,  
  
		AstPitchTitle = inputItem.AstPitchTitle,  
  
		APMainRoot = inputItem.APMainRoot, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstPitchs Map(AstPitchs entity ,EditAstPitchsCommand inputItem)
        {
              
  
		entity.AstPitchId = inputItem.AstPitchId;  
  
		entity.AstPitchParent = inputItem.AstPitchParent;  
  
		entity.AstPitchCode = inputItem.AstPitchCode;  
  
		entity.AstPitchTitle = inputItem.AstPitchTitle;  
  
		entity.APMainRoot = inputItem.APMainRoot; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstPitchsDto Map(AstPitchs inputItem)
        {
            var dto = new AstPitchsDto()
            {
                  
  
		AstPitchId = inputItem.AstPitchId,  
  
		AstPitchParent = inputItem.AstPitchParent,  
  
		AstPitchCode = inputItem.AstPitchCode,  
  
		AstPitchTitle = inputItem.AstPitchTitle,  
  
		APMainRoot = inputItem.APMainRoot, 
            };
            return dto;
        }

        public static List<AstPitchsDto> Map(ICollection<AstPitchs> entities)
        {
            var dtos = new List<AstPitchsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstPitchsDto()
                {
                      
  
		AstPitchId = inputItem.AstPitchId,  
  
		AstPitchParent = inputItem.AstPitchParent,  
  
		AstPitchCode = inputItem.AstPitchCode,  
  
		AstPitchTitle = inputItem.AstPitchTitle,  
  
		APMainRoot = inputItem.APMainRoot, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstRatioDocs Map(AddAstRatioDocsCommand inputItem)
        {
            var entity = new AstRatioDocs() {
                  
  
		AstRatioDocId = inputItem.AstRatioDocId,  
  
		AsDRType = inputItem.AsDRType,  
  
		AsDRDate = inputItem.AsDRDate,  
  
		AsDRNum = inputItem.AsDRNum,  
  
		AsDRLocalNum = inputItem.AsDRLocalNum,  
  
		AsDRDepType = inputItem.AsDRDepType,  
  
		AsDRRatio = inputItem.AsDRRatio,  
  
		AsDRDescr = inputItem.AsDRDescr,  
  
		AsDRState = inputItem.AsDRState,  
  
		AsDRAccPrdRef = inputItem.AsDRAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstRatioDocs Map(AstRatioDocs entity ,EditAstRatioDocsCommand inputItem)
        {
              
  
		entity.AstRatioDocId = inputItem.AstRatioDocId;  
  
		entity.AsDRType = inputItem.AsDRType;  
  
		entity.AsDRDate = inputItem.AsDRDate;  
  
		entity.AsDRNum = inputItem.AsDRNum;  
  
		entity.AsDRLocalNum = inputItem.AsDRLocalNum;  
  
		entity.AsDRDepType = inputItem.AsDRDepType;  
  
		entity.AsDRRatio = inputItem.AsDRRatio;  
  
		entity.AsDRDescr = inputItem.AsDRDescr;  
  
		entity.AsDRState = inputItem.AsDRState;  
  
		entity.AsDRAccPrdRef = inputItem.AsDRAccPrdRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstRatioDocsDto Map(AstRatioDocs inputItem)
        {
            var dto = new AstRatioDocsDto()
            {
                  
  
		AstRatioDocId = inputItem.AstRatioDocId,  
  
		AsDRType = inputItem.AsDRType,  
  
		AsDRDate = inputItem.AsDRDate,  
  
		AsDRNum = inputItem.AsDRNum,  
  
		AsDRLocalNum = inputItem.AsDRLocalNum,  
  
		AsDRDepType = inputItem.AsDRDepType,  
  
		AsDRRatio = inputItem.AsDRRatio,  
  
		AsDRDescr = inputItem.AsDRDescr,  
  
		AsDRState = inputItem.AsDRState,  
  
		AsDRAccPrdRef = inputItem.AsDRAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<AstRatioDocsDto> Map(ICollection<AstRatioDocs> entities)
        {
            var dtos = new List<AstRatioDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstRatioDocsDto()
                {
                      
  
		AstRatioDocId = inputItem.AstRatioDocId,  
  
		AsDRType = inputItem.AsDRType,  
  
		AsDRDate = inputItem.AsDRDate,  
  
		AsDRNum = inputItem.AsDRNum,  
  
		AsDRLocalNum = inputItem.AsDRLocalNum,  
  
		AsDRDepType = inputItem.AsDRDepType,  
  
		AsDRRatio = inputItem.AsDRRatio,  
  
		AsDRDescr = inputItem.AsDRDescr,  
  
		AsDRState = inputItem.AsDRState,  
  
		AsDRAccPrdRef = inputItem.AsDRAccPrdRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static AstTransDocs Map(AddAstTransDocsCommand inputItem)
        {
            var entity = new AstTransDocs() {
                  
  
		AstTrnDocId = inputItem.AstTrnDocId,  
  
		AsDTType = inputItem.AsDTType,  
  
		AsDTDate = inputItem.AsDTDate,  
  
		AsDTNum = inputItem.AsDTNum,  
  
		AsDTLocalNum = inputItem.AsDTLocalNum,  
  
		AsDTGrpRef = inputItem.AsDTGrpRef,  
  
		AsDTPitchRef = inputItem.AsDTPitchRef,  
  
		AsDTMenRef = inputItem.AsDTMenRef,  
  
		AsDTCostCenter = inputItem.AsDTCostCenter,  
  
		AsDTAccPrdRef = inputItem.AsDTAccPrdRef,  
  
		AsDTDescr = inputItem.AsDTDescr,  
  
		AsDTState = inputItem.AsDTState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AstTransDocs Map(AstTransDocs entity ,EditAstTransDocsCommand inputItem)
        {
              
  
		entity.AstTrnDocId = inputItem.AstTrnDocId;  
  
		entity.AsDTType = inputItem.AsDTType;  
  
		entity.AsDTDate = inputItem.AsDTDate;  
  
		entity.AsDTNum = inputItem.AsDTNum;  
  
		entity.AsDTLocalNum = inputItem.AsDTLocalNum;  
  
		entity.AsDTGrpRef = inputItem.AsDTGrpRef;  
  
		entity.AsDTPitchRef = inputItem.AsDTPitchRef;  
  
		entity.AsDTMenRef = inputItem.AsDTMenRef;  
  
		entity.AsDTCostCenter = inputItem.AsDTCostCenter;  
  
		entity.AsDTAccPrdRef = inputItem.AsDTAccPrdRef;  
  
		entity.AsDTDescr = inputItem.AsDTDescr;  
  
		entity.AsDTState = inputItem.AsDTState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AstTransDocsDto Map(AstTransDocs inputItem)
        {
            var dto = new AstTransDocsDto()
            {
                  
  
		AstTrnDocId = inputItem.AstTrnDocId,  
  
		AsDTType = inputItem.AsDTType,  
  
		AsDTDate = inputItem.AsDTDate,  
  
		AsDTNum = inputItem.AsDTNum,  
  
		AsDTLocalNum = inputItem.AsDTLocalNum,  
  
		AsDTGrpRef = inputItem.AsDTGrpRef,  
  
		AsDTPitchRef = inputItem.AsDTPitchRef,  
  
		AsDTMenRef = inputItem.AsDTMenRef,  
  
		AsDTCostCenter = inputItem.AsDTCostCenter,  
  
		AsDTAccPrdRef = inputItem.AsDTAccPrdRef,  
  
		AsDTDescr = inputItem.AsDTDescr,  
  
		AsDTState = inputItem.AsDTState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<AstTransDocsDto> Map(ICollection<AstTransDocs> entities)
        {
            var dtos = new List<AstTransDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AstTransDocsDto()
                {
                      
  
		AstTrnDocId = inputItem.AstTrnDocId,  
  
		AsDTType = inputItem.AsDTType,  
  
		AsDTDate = inputItem.AsDTDate,  
  
		AsDTNum = inputItem.AsDTNum,  
  
		AsDTLocalNum = inputItem.AsDTLocalNum,  
  
		AsDTGrpRef = inputItem.AsDTGrpRef,  
  
		AsDTPitchRef = inputItem.AsDTPitchRef,  
  
		AsDTMenRef = inputItem.AsDTMenRef,  
  
		AsDTCostCenter = inputItem.AsDTCostCenter,  
  
		AsDTAccPrdRef = inputItem.AsDTAccPrdRef,  
  
		AsDTDescr = inputItem.AsDTDescr,  
  
		AsDTState = inputItem.AsDTState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
