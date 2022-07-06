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
                
        
        public static GnrAlarmDet Map(AddGnrAlarmDetCommand inputItem)
        {
            var entity = new GnrAlarmDet() {
                  
  
		AlarmDetId = inputItem.AlarmDetId,  
  
		ADAlarmTypeRef = inputItem.ADAlarmTypeRef,  
  
		ADFieldName = inputItem.ADFieldName,  
  
		ADFieldTitle = inputItem.ADFieldTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrAlarmDet Map(GnrAlarmDet entity ,EditGnrAlarmDetCommand inputItem)
        {
              
  
		entity.AlarmDetId = inputItem.AlarmDetId;  
  
		entity.ADAlarmTypeRef = inputItem.ADAlarmTypeRef;  
  
		entity.ADFieldName = inputItem.ADFieldName;  
  
		entity.ADFieldTitle = inputItem.ADFieldTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrAlarmDetDto Map(GnrAlarmDet inputItem)
        {
            var dto = new GnrAlarmDetDto()
            {
                  
  
		AlarmDetId = inputItem.AlarmDetId,  
  
		ADAlarmTypeRef = inputItem.ADAlarmTypeRef,  
  
		ADFieldName = inputItem.ADFieldName,  
  
		ADFieldTitle = inputItem.ADFieldTitle, 
            };
            return dto;
        }

        public static List<GnrAlarmDetDto> Map(ICollection<GnrAlarmDet> entities)
        {
            var dtos = new List<GnrAlarmDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrAlarmDetDto()
                {
                      
  
		AlarmDetId = inputItem.AlarmDetId,  
  
		ADAlarmTypeRef = inputItem.ADAlarmTypeRef,  
  
		ADFieldName = inputItem.ADFieldName,  
  
		ADFieldTitle = inputItem.ADFieldTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrAlarmTypes Map(AddGnrAlarmTypesCommand inputItem)
        {
            var entity = new GnrAlarmTypes() {
                  
  
		AlarmTypeId = inputItem.AlarmTypeId,  
  
		ATDescr = inputItem.ATDescr,  
  
		ATSysRef = inputItem.ATSysRef,  
  
		ATQuery = inputItem.ATQuery, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrAlarmTypes Map(GnrAlarmTypes entity ,EditGnrAlarmTypesCommand inputItem)
        {
              
  
		entity.AlarmTypeId = inputItem.AlarmTypeId;  
  
		entity.ATDescr = inputItem.ATDescr;  
  
		entity.ATSysRef = inputItem.ATSysRef;  
  
		entity.ATQuery = inputItem.ATQuery; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrAlarmTypesDto Map(GnrAlarmTypes inputItem)
        {
            var dto = new GnrAlarmTypesDto()
            {
                  
  
		AlarmTypeId = inputItem.AlarmTypeId,  
  
		ATDescr = inputItem.ATDescr,  
  
		ATSysRef = inputItem.ATSysRef,  
  
		ATQuery = inputItem.ATQuery, 
            };
            return dto;
        }

        public static List<GnrAlarmTypesDto> Map(ICollection<GnrAlarmTypes> entities)
        {
            var dtos = new List<GnrAlarmTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrAlarmTypesDto()
                {
                      
  
		AlarmTypeId = inputItem.AlarmTypeId,  
  
		ATDescr = inputItem.ATDescr,  
  
		ATSysRef = inputItem.ATSysRef,  
  
		ATQuery = inputItem.ATQuery, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrAutoText Map(AddGnrAutoTextCommand inputItem)
        {
            var entity = new GnrAutoText() {
                  
  
		GnrAutoTextId = inputItem.GnrAutoTextId,  
  
		GATFormRef = inputItem.GATFormRef,  
  
		GATObjName = inputItem.GATObjName,  
  
		GATText = inputItem.GATText, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrAutoText Map(GnrAutoText entity ,EditGnrAutoTextCommand inputItem)
        {
              
  
		entity.GnrAutoTextId = inputItem.GnrAutoTextId;  
  
		entity.GATFormRef = inputItem.GATFormRef;  
  
		entity.GATObjName = inputItem.GATObjName;  
  
		entity.GATText = inputItem.GATText; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrAutoTextDto Map(GnrAutoText inputItem)
        {
            var dto = new GnrAutoTextDto()
            {
                  
  
		GnrAutoTextId = inputItem.GnrAutoTextId,  
  
		GATFormRef = inputItem.GATFormRef,  
  
		GATObjName = inputItem.GATObjName,  
  
		GATText = inputItem.GATText, 
            };
            return dto;
        }

        public static List<GnrAutoTextDto> Map(ICollection<GnrAutoText> entities)
        {
            var dtos = new List<GnrAutoTextDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrAutoTextDto()
                {
                      
  
		GnrAutoTextId = inputItem.GnrAutoTextId,  
  
		GATFormRef = inputItem.GATFormRef,  
  
		GATObjName = inputItem.GATObjName,  
  
		GATText = inputItem.GATText, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrDashboards Map(AddGnrDashboardsCommand inputItem)
        {
            var entity = new GnrDashboards() {
                  
  
		GnrDashboardID = inputItem.GnrDashboardID,  
  
		GDTitle = inputItem.GDTitle,  
  
		GDQuery = inputItem.GDQuery,  
  
		GDFillter = inputItem.GDFillter,  
  
		GDProp1 = inputItem.GDProp1,  
  
		GDProp2 = inputItem.GDProp2,  
  
		GDProp3 = inputItem.GDProp3,  
  
		GDLayout1 = inputItem.GDLayout1,  
  
		GDLayout2 = inputItem.GDLayout2,  
  
		GDLayout3 = inputItem.GDLayout3,  
  
		GDLayout4 = inputItem.GDLayout4, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrDashboards Map(GnrDashboards entity ,EditGnrDashboardsCommand inputItem)
        {
              
  
		entity.GnrDashboardID = inputItem.GnrDashboardID;  
  
		entity.GDTitle = inputItem.GDTitle;  
  
		entity.GDQuery = inputItem.GDQuery;  
  
		entity.GDFillter = inputItem.GDFillter;  
  
		entity.GDProp1 = inputItem.GDProp1;  
  
		entity.GDProp2 = inputItem.GDProp2;  
  
		entity.GDProp3 = inputItem.GDProp3;  
  
		entity.GDLayout1 = inputItem.GDLayout1;  
  
		entity.GDLayout2 = inputItem.GDLayout2;  
  
		entity.GDLayout3 = inputItem.GDLayout3;  
  
		entity.GDLayout4 = inputItem.GDLayout4; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrDashboardsDto Map(GnrDashboards inputItem)
        {
            var dto = new GnrDashboardsDto()
            {
                  
  
		GnrDashboardID = inputItem.GnrDashboardID,  
  
		GDTitle = inputItem.GDTitle,  
  
		GDQuery = inputItem.GDQuery,  
  
		GDFillter = inputItem.GDFillter,  
  
		GDProp1 = inputItem.GDProp1,  
  
		GDProp2 = inputItem.GDProp2,  
  
		GDProp3 = inputItem.GDProp3,  
  
		GDLayout1 = inputItem.GDLayout1,  
  
		GDLayout2 = inputItem.GDLayout2,  
  
		GDLayout3 = inputItem.GDLayout3,  
  
		GDLayout4 = inputItem.GDLayout4, 
            };
            return dto;
        }

        public static List<GnrDashboardsDto> Map(ICollection<GnrDashboards> entities)
        {
            var dtos = new List<GnrDashboardsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrDashboardsDto()
                {
                      
  
		GnrDashboardID = inputItem.GnrDashboardID,  
  
		GDTitle = inputItem.GDTitle,  
  
		GDQuery = inputItem.GDQuery,  
  
		GDFillter = inputItem.GDFillter,  
  
		GDProp1 = inputItem.GDProp1,  
  
		GDProp2 = inputItem.GDProp2,  
  
		GDProp3 = inputItem.GDProp3,  
  
		GDLayout1 = inputItem.GDLayout1,  
  
		GDLayout2 = inputItem.GDLayout2,  
  
		GDLayout3 = inputItem.GDLayout3,  
  
		GDLayout4 = inputItem.GDLayout4, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrDashFields Map(AddGnrDashFieldsCommand inputItem)
        {
            var entity = new GnrDashFields() {
                  
  
		GDFHdrRef = inputItem.GDFHdrRef,  
  
		GDFName = inputItem.GDFName,  
  
		GDFFormula = inputItem.GDFFormula, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrDashFields Map(GnrDashFields entity ,EditGnrDashFieldsCommand inputItem)
        {
              
  
		entity.GDFHdrRef = inputItem.GDFHdrRef;  
  
		entity.GDFName = inputItem.GDFName;  
  
		entity.GDFFormula = inputItem.GDFFormula; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrDashFieldsDto Map(GnrDashFields inputItem)
        {
            var dto = new GnrDashFieldsDto()
            {
                  
  
		GDFHdrRef = inputItem.GDFHdrRef,  
  
		GDFName = inputItem.GDFName,  
  
		GDFFormula = inputItem.GDFFormula, 
            };
            return dto;
        }

        public static List<GnrDashFieldsDto> Map(ICollection<GnrDashFields> entities)
        {
            var dtos = new List<GnrDashFieldsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrDashFieldsDto()
                {
                      
  
		GDFHdrRef = inputItem.GDFHdrRef,  
  
		GDFName = inputItem.GDFName,  
  
		GDFFormula = inputItem.GDFFormula, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrFormFlow Map(AddGnrFormFlowCommand inputItem)
        {
            var entity = new GnrFormFlow() {
                  
  
		GnrFormFlowId = inputItem.GnrFormFlowId,  
  
		GFFTitle = inputItem.GFFTitle,  
  
		GFFName = inputItem.GFFName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrFormFlow Map(GnrFormFlow entity ,EditGnrFormFlowCommand inputItem)
        {
              
  
		entity.GnrFormFlowId = inputItem.GnrFormFlowId;  
  
		entity.GFFTitle = inputItem.GFFTitle;  
  
		entity.GFFName = inputItem.GFFName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrFormFlowDto Map(GnrFormFlow inputItem)
        {
            var dto = new GnrFormFlowDto()
            {
                  
  
		GnrFormFlowId = inputItem.GnrFormFlowId,  
  
		GFFTitle = inputItem.GFFTitle,  
  
		GFFName = inputItem.GFFName, 
            };
            return dto;
        }

        public static List<GnrFormFlowDto> Map(ICollection<GnrFormFlow> entities)
        {
            var dtos = new List<GnrFormFlowDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrFormFlowDto()
                {
                      
  
		GnrFormFlowId = inputItem.GnrFormFlowId,  
  
		GFFTitle = inputItem.GFFTitle,  
  
		GFFName = inputItem.GFFName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrFormRepRels Map(AddGnrFormRepRelsCommand inputItem)
        {
            var entity = new GnrFormRepRels() {
                  
  
		FormRepRelId = inputItem.FormRepRelId,  
  
		FRRFormId = inputItem.FRRFormId,  
  
		FRRepRef = inputItem.FRRepRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrFormRepRels Map(GnrFormRepRels entity ,EditGnrFormRepRelsCommand inputItem)
        {
              
  
		entity.FormRepRelId = inputItem.FormRepRelId;  
  
		entity.FRRFormId = inputItem.FRRFormId;  
  
		entity.FRRepRef = inputItem.FRRepRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrFormRepRelsDto Map(GnrFormRepRels inputItem)
        {
            var dto = new GnrFormRepRelsDto()
            {
                  
  
		FormRepRelId = inputItem.FormRepRelId,  
  
		FRRFormId = inputItem.FRRFormId,  
  
		FRRepRef = inputItem.FRRepRef, 
            };
            return dto;
        }

        public static List<GnrFormRepRelsDto> Map(ICollection<GnrFormRepRels> entities)
        {
            var dtos = new List<GnrFormRepRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrFormRepRelsDto()
                {
                      
  
		FormRepRelId = inputItem.FormRepRelId,  
  
		FRRFormId = inputItem.FRRFormId,  
  
		FRRepRef = inputItem.FRRepRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrFormSetting Map(AddGnrFormSettingCommand inputItem)
        {
            var entity = new GnrFormSetting() {
                  
  
		GFSFormRef = inputItem.GFSFormRef,  
  
		GFSType = inputItem.GFSType,  
  
		GFSValue = inputItem.GFSValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrFormSetting Map(GnrFormSetting entity ,EditGnrFormSettingCommand inputItem)
        {
              
  
		entity.GFSFormRef = inputItem.GFSFormRef;  
  
		entity.GFSType = inputItem.GFSType;  
  
		entity.GFSValue = inputItem.GFSValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrFormSettingDto Map(GnrFormSetting inputItem)
        {
            var dto = new GnrFormSettingDto()
            {
                  
  
		GFSFormRef = inputItem.GFSFormRef,  
  
		GFSType = inputItem.GFSType,  
  
		GFSValue = inputItem.GFSValue, 
            };
            return dto;
        }

        public static List<GnrFormSettingDto> Map(ICollection<GnrFormSetting> entities)
        {
            var dtos = new List<GnrFormSettingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrFormSettingDto()
                {
                      
  
		GFSFormRef = inputItem.GFSFormRef,  
  
		GFSType = inputItem.GFSType,  
  
		GFSValue = inputItem.GFSValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrLimitExcept Map(AddGnrLimitExceptCommand inputItem)
        {
            var entity = new GnrLimitExcept() {
                  
  
		GnrLimitExceptId = inputItem.GnrLimitExceptId,  
  
		GLEGroupRef = inputItem.GLEGroupRef,  
  
		GLEUserRef = inputItem.GLEUserRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrLimitExcept Map(GnrLimitExcept entity ,EditGnrLimitExceptCommand inputItem)
        {
              
  
		entity.GnrLimitExceptId = inputItem.GnrLimitExceptId;  
  
		entity.GLEGroupRef = inputItem.GLEGroupRef;  
  
		entity.GLEUserRef = inputItem.GLEUserRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrLimitExceptDto Map(GnrLimitExcept inputItem)
        {
            var dto = new GnrLimitExceptDto()
            {
                  
  
		GnrLimitExceptId = inputItem.GnrLimitExceptId,  
  
		GLEGroupRef = inputItem.GLEGroupRef,  
  
		GLEUserRef = inputItem.GLEUserRef, 
            };
            return dto;
        }

        public static List<GnrLimitExceptDto> Map(ICollection<GnrLimitExcept> entities)
        {
            var dtos = new List<GnrLimitExceptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrLimitExceptDto()
                {
                      
  
		GnrLimitExceptId = inputItem.GnrLimitExceptId,  
  
		GLEGroupRef = inputItem.GLEGroupRef,  
  
		GLEUserRef = inputItem.GLEUserRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrLimitGroup Map(AddGnrLimitGroupCommand inputItem)
        {
            var entity = new GnrLimitGroup() {
                  
  
		GnrLimitGroupId = inputItem.GnrLimitGroupId,  
  
		GLGTitle = inputItem.GLGTitle,  
  
		GLGName = inputItem.GLGName,  
  
		GLGSit = inputItem.GLGSit,  
  
		GLGObjView = inputItem.GLGObjView,  
  
		GLGObjIdCol = inputItem.GLGObjIdCol,  
  
		GLGObjTitleCol = inputItem.GLGObjTitleCol,  
  
		GLGObjTitle = inputItem.GLGObjTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrLimitGroup Map(GnrLimitGroup entity ,EditGnrLimitGroupCommand inputItem)
        {
              
  
		entity.GnrLimitGroupId = inputItem.GnrLimitGroupId;  
  
		entity.GLGTitle = inputItem.GLGTitle;  
  
		entity.GLGName = inputItem.GLGName;  
  
		entity.GLGSit = inputItem.GLGSit;  
  
		entity.GLGObjView = inputItem.GLGObjView;  
  
		entity.GLGObjIdCol = inputItem.GLGObjIdCol;  
  
		entity.GLGObjTitleCol = inputItem.GLGObjTitleCol;  
  
		entity.GLGObjTitle = inputItem.GLGObjTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrLimitGroupDto Map(GnrLimitGroup inputItem)
        {
            var dto = new GnrLimitGroupDto()
            {
                  
  
		GnrLimitGroupId = inputItem.GnrLimitGroupId,  
  
		GLGTitle = inputItem.GLGTitle,  
  
		GLGName = inputItem.GLGName,  
  
		GLGSit = inputItem.GLGSit,  
  
		GLGObjView = inputItem.GLGObjView,  
  
		GLGObjIdCol = inputItem.GLGObjIdCol,  
  
		GLGObjTitleCol = inputItem.GLGObjTitleCol,  
  
		GLGObjTitle = inputItem.GLGObjTitle, 
            };
            return dto;
        }

        public static List<GnrLimitGroupDto> Map(ICollection<GnrLimitGroup> entities)
        {
            var dtos = new List<GnrLimitGroupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrLimitGroupDto()
                {
                      
  
		GnrLimitGroupId = inputItem.GnrLimitGroupId,  
  
		GLGTitle = inputItem.GLGTitle,  
  
		GLGName = inputItem.GLGName,  
  
		GLGSit = inputItem.GLGSit,  
  
		GLGObjView = inputItem.GLGObjView,  
  
		GLGObjIdCol = inputItem.GLGObjIdCol,  
  
		GLGObjTitleCol = inputItem.GLGObjTitleCol,  
  
		GLGObjTitle = inputItem.GLGObjTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrLimitUser Map(AddGnrLimitUserCommand inputItem)
        {
            var entity = new GnrLimitUser() {
                  
  
		GnrLimitUserId = inputItem.GnrLimitUserId,  
  
		GLUGroupRef = inputItem.GLUGroupRef,  
  
		GLUUserRef = inputItem.GLUUserRef,  
  
		GLUObjRef = inputItem.GLUObjRef,  
  
		GLUAccess = inputItem.GLUAccess, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrLimitUser Map(GnrLimitUser entity ,EditGnrLimitUserCommand inputItem)
        {
              
  
		entity.GnrLimitUserId = inputItem.GnrLimitUserId;  
  
		entity.GLUGroupRef = inputItem.GLUGroupRef;  
  
		entity.GLUUserRef = inputItem.GLUUserRef;  
  
		entity.GLUObjRef = inputItem.GLUObjRef;  
  
		entity.GLUAccess = inputItem.GLUAccess; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrLimitUserDto Map(GnrLimitUser inputItem)
        {
            var dto = new GnrLimitUserDto()
            {
                  
  
		GnrLimitUserId = inputItem.GnrLimitUserId,  
  
		GLUGroupRef = inputItem.GLUGroupRef,  
  
		GLUUserRef = inputItem.GLUUserRef,  
  
		GLUObjRef = inputItem.GLUObjRef,  
  
		GLUAccess = inputItem.GLUAccess, 
            };
            return dto;
        }

        public static List<GnrLimitUserDto> Map(ICollection<GnrLimitUser> entities)
        {
            var dtos = new List<GnrLimitUserDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrLimitUserDto()
                {
                      
  
		GnrLimitUserId = inputItem.GnrLimitUserId,  
  
		GLUGroupRef = inputItem.GLUGroupRef,  
  
		GLUUserRef = inputItem.GLUUserRef,  
  
		GLUObjRef = inputItem.GLUObjRef,  
  
		GLUAccess = inputItem.GLUAccess, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrNumVchCfgDet Map(AddGnrNumVchCfgDetCommand inputItem)
        {
            var entity = new GnrNumVchCfgDet() {
                  
  
		GNVCHdrRef = inputItem.GNVCHdrRef,  
  
		GNVCVchTyp = inputItem.GNVCVchTyp, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrNumVchCfgDet Map(GnrNumVchCfgDet entity ,EditGnrNumVchCfgDetCommand inputItem)
        {
              
  
		entity.GNVCHdrRef = inputItem.GNVCHdrRef;  
  
		entity.GNVCVchTyp = inputItem.GNVCVchTyp; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrNumVchCfgDetDto Map(GnrNumVchCfgDet inputItem)
        {
            var dto = new GnrNumVchCfgDetDto()
            {
                  
  
		GNVCHdrRef = inputItem.GNVCHdrRef,  
  
		GNVCVchTyp = inputItem.GNVCVchTyp, 
            };
            return dto;
        }

        public static List<GnrNumVchCfgDetDto> Map(ICollection<GnrNumVchCfgDet> entities)
        {
            var dtos = new List<GnrNumVchCfgDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrNumVchCfgDetDto()
                {
                      
  
		GNVCHdrRef = inputItem.GNVCHdrRef,  
  
		GNVCVchTyp = inputItem.GNVCVchTyp, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrNumVchConfig Map(AddGnrNumVchConfigCommand inputItem)
        {
            var entity = new GnrNumVchConfig() {
                  
  
		GnrNumVchConfigId = inputItem.GnrNumVchConfigId,  
  
		GNVCTitle = inputItem.GNVCTitle,  
  
		GNVCSysRef = inputItem.GNVCSysRef,  
  
		GNVCPrdRef = inputItem.GNVCPrdRef,  
  
		GNVCStartNum = inputItem.GNVCStartNum,  
  
		GNVCIdent = inputItem.GNVCIdent,  
  
		GNVCMethod = inputItem.GNVCMethod,  
  
		GNVCRelField = inputItem.GNVCRelField,  
  
		GNVCDateCtrl = inputItem.GNVCDateCtrl, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrNumVchConfig Map(GnrNumVchConfig entity ,EditGnrNumVchConfigCommand inputItem)
        {
              
  
		entity.GnrNumVchConfigId = inputItem.GnrNumVchConfigId;  
  
		entity.GNVCTitle = inputItem.GNVCTitle;  
  
		entity.GNVCSysRef = inputItem.GNVCSysRef;  
  
		entity.GNVCPrdRef = inputItem.GNVCPrdRef;  
  
		entity.GNVCStartNum = inputItem.GNVCStartNum;  
  
		entity.GNVCIdent = inputItem.GNVCIdent;  
  
		entity.GNVCMethod = inputItem.GNVCMethod;  
  
		entity.GNVCRelField = inputItem.GNVCRelField;  
  
		entity.GNVCDateCtrl = inputItem.GNVCDateCtrl; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrNumVchConfigDto Map(GnrNumVchConfig inputItem)
        {
            var dto = new GnrNumVchConfigDto()
            {
                  
  
		GnrNumVchConfigId = inputItem.GnrNumVchConfigId,  
  
		GNVCTitle = inputItem.GNVCTitle,  
  
		GNVCSysRef = inputItem.GNVCSysRef,  
  
		GNVCPrdRef = inputItem.GNVCPrdRef,  
  
		GNVCStartNum = inputItem.GNVCStartNum,  
  
		GNVCIdent = inputItem.GNVCIdent,  
  
		GNVCMethod = inputItem.GNVCMethod,  
  
		GNVCRelField = inputItem.GNVCRelField,  
  
		GNVCDateCtrl = inputItem.GNVCDateCtrl, 
            };
            return dto;
        }

        public static List<GnrNumVchConfigDto> Map(ICollection<GnrNumVchConfig> entities)
        {
            var dtos = new List<GnrNumVchConfigDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrNumVchConfigDto()
                {
                      
  
		GnrNumVchConfigId = inputItem.GnrNumVchConfigId,  
  
		GNVCTitle = inputItem.GNVCTitle,  
  
		GNVCSysRef = inputItem.GNVCSysRef,  
  
		GNVCPrdRef = inputItem.GNVCPrdRef,  
  
		GNVCStartNum = inputItem.GNVCStartNum,  
  
		GNVCIdent = inputItem.GNVCIdent,  
  
		GNVCMethod = inputItem.GNVCMethod,  
  
		GNVCRelField = inputItem.GNVCRelField,  
  
		GNVCDateCtrl = inputItem.GNVCDateCtrl, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcess Map(AddGnrProcessCommand inputItem)
        {
            var entity = new GnrProcess() {
                  
  
		GnrProcessId = inputItem.GnrProcessId,  
  
		GPTitle = inputItem.GPTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcess Map(GnrProcess entity ,EditGnrProcessCommand inputItem)
        {
              
  
		entity.GnrProcessId = inputItem.GnrProcessId;  
  
		entity.GPTitle = inputItem.GPTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDto Map(GnrProcess inputItem)
        {
            var dto = new GnrProcessDto()
            {
                  
  
		GnrProcessId = inputItem.GnrProcessId,  
  
		GPTitle = inputItem.GPTitle, 
            };
            return dto;
        }

        public static List<GnrProcessDto> Map(ICollection<GnrProcess> entities)
        {
            var dtos = new List<GnrProcessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDto()
                {
                      
  
		GnrProcessId = inputItem.GnrProcessId,  
  
		GPTitle = inputItem.GPTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDet Map(AddGnrProcessDetCommand inputItem)
        {
            var entity = new GnrProcessDet() {
                  
  
		GnrProcessDetId = inputItem.GnrProcessDetId,  
  
		GPDProccessRef = inputItem.GPDProccessRef,  
  
		GPDTitle = inputItem.GPDTitle,  
  
		GPDStep = inputItem.GPDStep,  
  
		GPDType = inputItem.GPDType,  
  
		GPDRefId = inputItem.GPDRefId,  
  
		GPDRefData = inputItem.GPDRefData,  
  
		GPDDecField = inputItem.GPDDecField,  
  
		GPDRelStep = inputItem.GPDRelStep, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDet Map(GnrProcessDet entity ,EditGnrProcessDetCommand inputItem)
        {
              
  
		entity.GnrProcessDetId = inputItem.GnrProcessDetId;  
  
		entity.GPDProccessRef = inputItem.GPDProccessRef;  
  
		entity.GPDTitle = inputItem.GPDTitle;  
  
		entity.GPDStep = inputItem.GPDStep;  
  
		entity.GPDType = inputItem.GPDType;  
  
		entity.GPDRefId = inputItem.GPDRefId;  
  
		entity.GPDRefData = inputItem.GPDRefData;  
  
		entity.GPDDecField = inputItem.GPDDecField;  
  
		entity.GPDRelStep = inputItem.GPDRelStep; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetDto Map(GnrProcessDet inputItem)
        {
            var dto = new GnrProcessDetDto()
            {
                  
  
		GnrProcessDetId = inputItem.GnrProcessDetId,  
  
		GPDProccessRef = inputItem.GPDProccessRef,  
  
		GPDTitle = inputItem.GPDTitle,  
  
		GPDStep = inputItem.GPDStep,  
  
		GPDType = inputItem.GPDType,  
  
		GPDRefId = inputItem.GPDRefId,  
  
		GPDRefData = inputItem.GPDRefData,  
  
		GPDDecField = inputItem.GPDDecField,  
  
		GPDRelStep = inputItem.GPDRelStep, 
            };
            return dto;
        }

        public static List<GnrProcessDetDto> Map(ICollection<GnrProcessDet> entities)
        {
            var dtos = new List<GnrProcessDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetDto()
                {
                      
  
		GnrProcessDetId = inputItem.GnrProcessDetId,  
  
		GPDProccessRef = inputItem.GPDProccessRef,  
  
		GPDTitle = inputItem.GPDTitle,  
  
		GPDStep = inputItem.GPDStep,  
  
		GPDType = inputItem.GPDType,  
  
		GPDRefId = inputItem.GPDRefId,  
  
		GPDRefData = inputItem.GPDRefData,  
  
		GPDDecField = inputItem.GPDDecField,  
  
		GPDRelStep = inputItem.GPDRelStep, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDetArch Map(AddGnrProcessDetArchCommand inputItem)
        {
            var entity = new GnrProcessDetArch() {
                  
  
		GPDAHdrRef = inputItem.GPDAHdrRef,  
  
		GPDAArchRef = inputItem.GPDAArchRef,  
  
		GPDAForce = inputItem.GPDAForce, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDetArch Map(GnrProcessDetArch entity ,EditGnrProcessDetArchCommand inputItem)
        {
              
  
		entity.GPDAHdrRef = inputItem.GPDAHdrRef;  
  
		entity.GPDAArchRef = inputItem.GPDAArchRef;  
  
		entity.GPDAForce = inputItem.GPDAForce; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetArchDto Map(GnrProcessDetArch inputItem)
        {
            var dto = new GnrProcessDetArchDto()
            {
                  
  
		GPDAHdrRef = inputItem.GPDAHdrRef,  
  
		GPDAArchRef = inputItem.GPDAArchRef,  
  
		GPDAForce = inputItem.GPDAForce, 
            };
            return dto;
        }

        public static List<GnrProcessDetArchDto> Map(ICollection<GnrProcessDetArch> entities)
        {
            var dtos = new List<GnrProcessDetArchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetArchDto()
                {
                      
  
		GPDAHdrRef = inputItem.GPDAHdrRef,  
  
		GPDAArchRef = inputItem.GPDAArchRef,  
  
		GPDAForce = inputItem.GPDAForce, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDetObj Map(AddGnrProcessDetObjCommand inputItem)
        {
            var entity = new GnrProcessDetObj() {
                  
  
		GPDOHdrRef = inputItem.GPDOHdrRef,  
  
		GPDOItmRef = inputItem.GPDOItmRef,  
  
		GPDOVal = inputItem.GPDOVal,  
  
		GPDOCond = inputItem.GPDOCond, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDetObj Map(GnrProcessDetObj entity ,EditGnrProcessDetObjCommand inputItem)
        {
              
  
		entity.GPDOHdrRef = inputItem.GPDOHdrRef;  
  
		entity.GPDOItmRef = inputItem.GPDOItmRef;  
  
		entity.GPDOVal = inputItem.GPDOVal;  
  
		entity.GPDOCond = inputItem.GPDOCond; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetObjDto Map(GnrProcessDetObj inputItem)
        {
            var dto = new GnrProcessDetObjDto()
            {
                  
  
		GPDOHdrRef = inputItem.GPDOHdrRef,  
  
		GPDOItmRef = inputItem.GPDOItmRef,  
  
		GPDOVal = inputItem.GPDOVal,  
  
		GPDOCond = inputItem.GPDOCond, 
            };
            return dto;
        }

        public static List<GnrProcessDetObjDto> Map(ICollection<GnrProcessDetObj> entities)
        {
            var dtos = new List<GnrProcessDetObjDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetObjDto()
                {
                      
  
		GPDOHdrRef = inputItem.GPDOHdrRef,  
  
		GPDOItmRef = inputItem.GPDOItmRef,  
  
		GPDOVal = inputItem.GPDOVal,  
  
		GPDOCond = inputItem.GPDOCond, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDetTrans Map(AddGnrProcessDetTransCommand inputItem)
        {
            var entity = new GnrProcessDetTrans() {
                  
  
		GnrProcessDetTransId = inputItem.GnrProcessDetTransId,  
  
		GPDTItemRef = inputItem.GPDTItemRef,  
  
		GPDTProcRef = inputItem.GPDTProcRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDetTrans Map(GnrProcessDetTrans entity ,EditGnrProcessDetTransCommand inputItem)
        {
              
  
		entity.GnrProcessDetTransId = inputItem.GnrProcessDetTransId;  
  
		entity.GPDTItemRef = inputItem.GPDTItemRef;  
  
		entity.GPDTProcRef = inputItem.GPDTProcRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetTransDto Map(GnrProcessDetTrans inputItem)
        {
            var dto = new GnrProcessDetTransDto()
            {
                  
  
		GnrProcessDetTransId = inputItem.GnrProcessDetTransId,  
  
		GPDTItemRef = inputItem.GPDTItemRef,  
  
		GPDTProcRef = inputItem.GPDTProcRef, 
            };
            return dto;
        }

        public static List<GnrProcessDetTransDto> Map(ICollection<GnrProcessDetTrans> entities)
        {
            var dtos = new List<GnrProcessDetTransDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetTransDto()
                {
                      
  
		GnrProcessDetTransId = inputItem.GnrProcessDetTransId,  
  
		GPDTItemRef = inputItem.GPDTItemRef,  
  
		GPDTProcRef = inputItem.GPDTProcRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDetUsers Map(AddGnrProcessDetUsersCommand inputItem)
        {
            var entity = new GnrProcessDetUsers() {
                  
  
		GPDUHdrRef = inputItem.GPDUHdrRef,  
  
		GPDUUsrRef = inputItem.GPDUUsrRef,  
  
		GPDUInd = inputItem.GPDUInd,  
  
		GPDUAnsDur = inputItem.GPDUAnsDur,  
  
		GPDUPersuitUser = inputItem.GPDUPersuitUser, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDetUsers Map(GnrProcessDetUsers entity ,EditGnrProcessDetUsersCommand inputItem)
        {
              
  
		entity.GPDUHdrRef = inputItem.GPDUHdrRef;  
  
		entity.GPDUUsrRef = inputItem.GPDUUsrRef;  
  
		entity.GPDUInd = inputItem.GPDUInd;  
  
		entity.GPDUAnsDur = inputItem.GPDUAnsDur;  
  
		entity.GPDUPersuitUser = inputItem.GPDUPersuitUser; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetUsersDto Map(GnrProcessDetUsers inputItem)
        {
            var dto = new GnrProcessDetUsersDto()
            {
                  
  
		GPDUHdrRef = inputItem.GPDUHdrRef,  
  
		GPDUUsrRef = inputItem.GPDUUsrRef,  
  
		GPDUInd = inputItem.GPDUInd,  
  
		GPDUAnsDur = inputItem.GPDUAnsDur,  
  
		GPDUPersuitUser = inputItem.GPDUPersuitUser, 
            };
            return dto;
        }

        public static List<GnrProcessDetUsersDto> Map(ICollection<GnrProcessDetUsers> entities)
        {
            var dtos = new List<GnrProcessDetUsersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetUsersDto()
                {
                      
  
		GPDUHdrRef = inputItem.GPDUHdrRef,  
  
		GPDUUsrRef = inputItem.GPDUUsrRef,  
  
		GPDUInd = inputItem.GPDUInd,  
  
		GPDUAnsDur = inputItem.GPDUAnsDur,  
  
		GPDUPersuitUser = inputItem.GPDUPersuitUser, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrProcessDetVals Map(AddGnrProcessDetValsCommand inputItem)
        {
            var entity = new GnrProcessDetVals() {
                  
  
		GPDVHdrRef = inputItem.GPDVHdrRef,  
  
		GPDVItmRef = inputItem.GPDVItmRef,  
  
		GPDVVal = inputItem.GPDVVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrProcessDetVals Map(GnrProcessDetVals entity ,EditGnrProcessDetValsCommand inputItem)
        {
              
  
		entity.GPDVHdrRef = inputItem.GPDVHdrRef;  
  
		entity.GPDVItmRef = inputItem.GPDVItmRef;  
  
		entity.GPDVVal = inputItem.GPDVVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrProcessDetValsDto Map(GnrProcessDetVals inputItem)
        {
            var dto = new GnrProcessDetValsDto()
            {
                  
  
		GPDVHdrRef = inputItem.GPDVHdrRef,  
  
		GPDVItmRef = inputItem.GPDVItmRef,  
  
		GPDVVal = inputItem.GPDVVal, 
            };
            return dto;
        }

        public static List<GnrProcessDetValsDto> Map(ICollection<GnrProcessDetVals> entities)
        {
            var dtos = new List<GnrProcessDetValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrProcessDetValsDto()
                {
                      
  
		GPDVHdrRef = inputItem.GPDVHdrRef,  
  
		GPDVItmRef = inputItem.GPDVItmRef,  
  
		GPDVVal = inputItem.GPDVVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRef2FormLinkExp Map(AddGnrRef2FormLinkExpCommand inputItem)
        {
            var entity = new GnrRef2FormLinkExp() {
                  
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRExItmId = inputItem.LRExItmId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRef2FormLinkExp Map(GnrRef2FormLinkExp entity ,EditGnrRef2FormLinkExpCommand inputItem)
        {
              
  
		entity.LinkRefHdrRef = inputItem.LinkRefHdrRef;  
  
		entity.LRExItmId = inputItem.LRExItmId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRef2FormLinkExpDto Map(GnrRef2FormLinkExp inputItem)
        {
            var dto = new GnrRef2FormLinkExpDto()
            {
                  
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRExItmId = inputItem.LRExItmId, 
            };
            return dto;
        }

        public static List<GnrRef2FormLinkExpDto> Map(ICollection<GnrRef2FormLinkExp> entities)
        {
            var dtos = new List<GnrRef2FormLinkExpDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRef2FormLinkExpDto()
                {
                      
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRExItmId = inputItem.LRExItmId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRef2FormLinkHdr Map(AddGnrRef2FormLinkHdrCommand inputItem)
        {
            var entity = new GnrRef2FormLinkHdr() {
                  
  
		LinkRefHdrId = inputItem.LinkRefHdrId,  
  
		LRHTitle = inputItem.LRHTitle,  
  
		LRHSysFormRef = inputItem.LRHSysFormRef,  
  
		LRHRefFormRef = inputItem.LRHRefFormRef,  
  
		LRHVchType = inputItem.LRHVchType,  
  
		LRHRefQryCond = inputItem.LRHRefQryCond, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRef2FormLinkHdr Map(GnrRef2FormLinkHdr entity ,EditGnrRef2FormLinkHdrCommand inputItem)
        {
              
  
		entity.LinkRefHdrId = inputItem.LinkRefHdrId;  
  
		entity.LRHTitle = inputItem.LRHTitle;  
  
		entity.LRHSysFormRef = inputItem.LRHSysFormRef;  
  
		entity.LRHRefFormRef = inputItem.LRHRefFormRef;  
  
		entity.LRHVchType = inputItem.LRHVchType;  
  
		entity.LRHRefQryCond = inputItem.LRHRefQryCond; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRef2FormLinkHdrDto Map(GnrRef2FormLinkHdr inputItem)
        {
            var dto = new GnrRef2FormLinkHdrDto()
            {
                  
  
		LinkRefHdrId = inputItem.LinkRefHdrId,  
  
		LRHTitle = inputItem.LRHTitle,  
  
		LRHSysFormRef = inputItem.LRHSysFormRef,  
  
		LRHRefFormRef = inputItem.LRHRefFormRef,  
  
		LRHVchType = inputItem.LRHVchType,  
  
		LRHRefQryCond = inputItem.LRHRefQryCond, 
            };
            return dto;
        }

        public static List<GnrRef2FormLinkHdrDto> Map(ICollection<GnrRef2FormLinkHdr> entities)
        {
            var dtos = new List<GnrRef2FormLinkHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRef2FormLinkHdrDto()
                {
                      
  
		LinkRefHdrId = inputItem.LinkRefHdrId,  
  
		LRHTitle = inputItem.LRHTitle,  
  
		LRHSysFormRef = inputItem.LRHSysFormRef,  
  
		LRHRefFormRef = inputItem.LRHRefFormRef,  
  
		LRHVchType = inputItem.LRHVchType,  
  
		LRHRefQryCond = inputItem.LRHRefQryCond, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRef2FormLinksItm Map(AddGnrRef2FormLinksItmCommand inputItem)
        {
            var entity = new GnrRef2FormLinksItm() {
                  
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRSysFormObjRef = inputItem.LRSysFormObjRef,  
  
		LRFieldName = inputItem.LRFieldName,  
  
		LRForceBaseVal = inputItem.LRForceBaseVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRef2FormLinksItm Map(GnrRef2FormLinksItm entity ,EditGnrRef2FormLinksItmCommand inputItem)
        {
              
  
		entity.LinkRefHdrRef = inputItem.LinkRefHdrRef;  
  
		entity.LRSysFormObjRef = inputItem.LRSysFormObjRef;  
  
		entity.LRFieldName = inputItem.LRFieldName;  
  
		entity.LRForceBaseVal = inputItem.LRForceBaseVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRef2FormLinksItmDto Map(GnrRef2FormLinksItm inputItem)
        {
            var dto = new GnrRef2FormLinksItmDto()
            {
                  
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRSysFormObjRef = inputItem.LRSysFormObjRef,  
  
		LRFieldName = inputItem.LRFieldName,  
  
		LRForceBaseVal = inputItem.LRForceBaseVal, 
            };
            return dto;
        }

        public static List<GnrRef2FormLinksItmDto> Map(ICollection<GnrRef2FormLinksItm> entities)
        {
            var dtos = new List<GnrRef2FormLinksItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRef2FormLinksItmDto()
                {
                      
  
		LinkRefHdrRef = inputItem.LinkRefHdrRef,  
  
		LRSysFormObjRef = inputItem.LRSysFormObjRef,  
  
		LRFieldName = inputItem.LRFieldName,  
  
		LRForceBaseVal = inputItem.LRForceBaseVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRefFormsList Map(AddGnrRefFormsListCommand inputItem)
        {
            var entity = new GnrRefFormsList() {
                  
  
		RefVchId = inputItem.RefVchId,  
  
		RVTitle = inputItem.RVTitle,  
  
		RVHdrViewName = inputItem.RVHdrViewName,  
  
		RVItmViewName = inputItem.RVItmViewName,  
  
		RVHdrIdField = inputItem.RVHdrIdField,  
  
		RVItmIdField = inputItem.RVItmIdField,  
  
		RVLinkStr = inputItem.RVLinkStr,  
  
		RVTitleCol = inputItem.RVTitleCol,  
  
		RVSystem = inputItem.RVSystem,  
  
		RVBaseSys = inputItem.RVBaseSys, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRefFormsList Map(GnrRefFormsList entity ,EditGnrRefFormsListCommand inputItem)
        {
              
  
		entity.RefVchId = inputItem.RefVchId;  
  
		entity.RVTitle = inputItem.RVTitle;  
  
		entity.RVHdrViewName = inputItem.RVHdrViewName;  
  
		entity.RVItmViewName = inputItem.RVItmViewName;  
  
		entity.RVHdrIdField = inputItem.RVHdrIdField;  
  
		entity.RVItmIdField = inputItem.RVItmIdField;  
  
		entity.RVLinkStr = inputItem.RVLinkStr;  
  
		entity.RVTitleCol = inputItem.RVTitleCol;  
  
		entity.RVSystem = inputItem.RVSystem;  
  
		entity.RVBaseSys = inputItem.RVBaseSys; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRefFormsListDto Map(GnrRefFormsList inputItem)
        {
            var dto = new GnrRefFormsListDto()
            {
                  
  
		RefVchId = inputItem.RefVchId,  
  
		RVTitle = inputItem.RVTitle,  
  
		RVHdrViewName = inputItem.RVHdrViewName,  
  
		RVItmViewName = inputItem.RVItmViewName,  
  
		RVHdrIdField = inputItem.RVHdrIdField,  
  
		RVItmIdField = inputItem.RVItmIdField,  
  
		RVLinkStr = inputItem.RVLinkStr,  
  
		RVTitleCol = inputItem.RVTitleCol,  
  
		RVSystem = inputItem.RVSystem,  
  
		RVBaseSys = inputItem.RVBaseSys, 
            };
            return dto;
        }

        public static List<GnrRefFormsListDto> Map(ICollection<GnrRefFormsList> entities)
        {
            var dtos = new List<GnrRefFormsListDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRefFormsListDto()
                {
                      
  
		RefVchId = inputItem.RefVchId,  
  
		RVTitle = inputItem.RVTitle,  
  
		RVHdrViewName = inputItem.RVHdrViewName,  
  
		RVItmViewName = inputItem.RVItmViewName,  
  
		RVHdrIdField = inputItem.RVHdrIdField,  
  
		RVItmIdField = inputItem.RVItmIdField,  
  
		RVLinkStr = inputItem.RVLinkStr,  
  
		RVTitleCol = inputItem.RVTitleCol,  
  
		RVSystem = inputItem.RVSystem,  
  
		RVBaseSys = inputItem.RVBaseSys, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRefFormsListDet Map(AddGnrRefFormsListDetCommand inputItem)
        {
            var entity = new GnrRefFormsListDet() {
                  
  
		RFLDHdrRef = inputItem.RFLDHdrRef,  
  
		RFLDFieldName = inputItem.RFLDFieldName,  
  
		RFLDTitle = inputItem.RFLDTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRefFormsListDet Map(GnrRefFormsListDet entity ,EditGnrRefFormsListDetCommand inputItem)
        {
              
  
		entity.RFLDHdrRef = inputItem.RFLDHdrRef;  
  
		entity.RFLDFieldName = inputItem.RFLDFieldName;  
  
		entity.RFLDTitle = inputItem.RFLDTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRefFormsListDetDto Map(GnrRefFormsListDet inputItem)
        {
            var dto = new GnrRefFormsListDetDto()
            {
                  
  
		RFLDHdrRef = inputItem.RFLDHdrRef,  
  
		RFLDFieldName = inputItem.RFLDFieldName,  
  
		RFLDTitle = inputItem.RFLDTitle, 
            };
            return dto;
        }

        public static List<GnrRefFormsListDetDto> Map(ICollection<GnrRefFormsListDet> entities)
        {
            var dtos = new List<GnrRefFormsListDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRefFormsListDetDto()
                {
                      
  
		RFLDHdrRef = inputItem.RFLDHdrRef,  
  
		RFLDFieldName = inputItem.RFLDFieldName,  
  
		RFLDTitle = inputItem.RFLDTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrReports Map(AddGnrReportsCommand inputItem)
        {
            var entity = new GnrReports() {
                  
  
		RptId = inputItem.RptId,  
  
		RptGroupRef = inputItem.RptGroupRef,  
  
		RptTitle = inputItem.RptTitle,  
  
		RptQuery = inputItem.RptQuery,  
  
		RptFile = inputItem.RptFile,  
  
		RptDef = inputItem.RptDef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrReports Map(GnrReports entity ,EditGnrReportsCommand inputItem)
        {
              
  
		entity.RptId = inputItem.RptId;  
  
		entity.RptGroupRef = inputItem.RptGroupRef;  
  
		entity.RptTitle = inputItem.RptTitle;  
  
		entity.RptQuery = inputItem.RptQuery;  
  
		entity.RptFile = inputItem.RptFile;  
  
		entity.RptDef = inputItem.RptDef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrReportsDto Map(GnrReports inputItem)
        {
            var dto = new GnrReportsDto()
            {
                  
  
		RptId = inputItem.RptId,  
  
		RptGroupRef = inputItem.RptGroupRef,  
  
		RptTitle = inputItem.RptTitle,  
  
		RptQuery = inputItem.RptQuery,  
  
		RptFile = inputItem.RptFile,  
  
		RptDef = inputItem.RptDef, 
            };
            return dto;
        }

        public static List<GnrReportsDto> Map(ICollection<GnrReports> entities)
        {
            var dtos = new List<GnrReportsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrReportsDto()
                {
                      
  
		RptId = inputItem.RptId,  
  
		RptGroupRef = inputItem.RptGroupRef,  
  
		RptTitle = inputItem.RptTitle,  
  
		RptQuery = inputItem.RptQuery,  
  
		RptFile = inputItem.RptFile,  
  
		RptDef = inputItem.RptDef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrRptGroups Map(AddGnrRptGroupsCommand inputItem)
        {
            var entity = new GnrRptGroups() {
                  
  
		RptGroupId = inputItem.RptGroupId,  
  
		RptGroupTitle = inputItem.RptGroupTitle,  
  
		RptSysRef = inputItem.RptSysRef,  
  
		RGParentRef = inputItem.RGParentRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrRptGroups Map(GnrRptGroups entity ,EditGnrRptGroupsCommand inputItem)
        {
              
  
		entity.RptGroupId = inputItem.RptGroupId;  
  
		entity.RptGroupTitle = inputItem.RptGroupTitle;  
  
		entity.RptSysRef = inputItem.RptSysRef;  
  
		entity.RGParentRef = inputItem.RGParentRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrRptGroupsDto Map(GnrRptGroups inputItem)
        {
            var dto = new GnrRptGroupsDto()
            {
                  
  
		RptGroupId = inputItem.RptGroupId,  
  
		RptGroupTitle = inputItem.RptGroupTitle,  
  
		RptSysRef = inputItem.RptSysRef,  
  
		RGParentRef = inputItem.RGParentRef, 
            };
            return dto;
        }

        public static List<GnrRptGroupsDto> Map(ICollection<GnrRptGroups> entities)
        {
            var dtos = new List<GnrRptGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrRptGroupsDto()
                {
                      
  
		RptGroupId = inputItem.RptGroupId,  
  
		RptGroupTitle = inputItem.RptGroupTitle,  
  
		RptSysRef = inputItem.RptSysRef,  
  
		RGParentRef = inputItem.RGParentRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysFormObjects Map(AddGnrSysFormObjectsCommand inputItem)
        {
            var entity = new GnrSysFormObjects() {
                  
  
		SysFormObjId = inputItem.SysFormObjId,  
  
		SysFormRef = inputItem.SysFormRef,  
  
		SFOName = inputItem.SFOName,  
  
		SFOTitle = inputItem.SFOTitle,  
  
		SFType = inputItem.SFType,  
  
		SFIsMainField = inputItem.SFIsMainField,  
  
		SFOFldName = inputItem.SFOFldName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysFormObjects Map(GnrSysFormObjects entity ,EditGnrSysFormObjectsCommand inputItem)
        {
              
  
		entity.SysFormObjId = inputItem.SysFormObjId;  
  
		entity.SysFormRef = inputItem.SysFormRef;  
  
		entity.SFOName = inputItem.SFOName;  
  
		entity.SFOTitle = inputItem.SFOTitle;  
  
		entity.SFType = inputItem.SFType;  
  
		entity.SFIsMainField = inputItem.SFIsMainField;  
  
		entity.SFOFldName = inputItem.SFOFldName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysFormObjectsDto Map(GnrSysFormObjects inputItem)
        {
            var dto = new GnrSysFormObjectsDto()
            {
                  
  
		SysFormObjId = inputItem.SysFormObjId,  
  
		SysFormRef = inputItem.SysFormRef,  
  
		SFOName = inputItem.SFOName,  
  
		SFOTitle = inputItem.SFOTitle,  
  
		SFType = inputItem.SFType,  
  
		SFIsMainField = inputItem.SFIsMainField,  
  
		SFOFldName = inputItem.SFOFldName, 
            };
            return dto;
        }

        public static List<GnrSysFormObjectsDto> Map(ICollection<GnrSysFormObjects> entities)
        {
            var dtos = new List<GnrSysFormObjectsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysFormObjectsDto()
                {
                      
  
		SysFormObjId = inputItem.SysFormObjId,  
  
		SysFormRef = inputItem.SysFormRef,  
  
		SFOName = inputItem.SFOName,  
  
		SFOTitle = inputItem.SFOTitle,  
  
		SFType = inputItem.SFType,  
  
		SFIsMainField = inputItem.SFIsMainField,  
  
		SFOFldName = inputItem.SFOFldName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysForms Map(AddGnrSysFormsCommand inputItem)
        {
            var entity = new GnrSysForms() {
                  
  
		SystemFormID = inputItem.SystemFormID,  
  
		SFName = inputItem.SFName,  
  
		SFSystemRef = inputItem.SFSystemRef,  
  
		SFTitle = inputItem.SFTitle,  
  
		SFTableName = inputItem.SFTableName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysForms Map(GnrSysForms entity ,EditGnrSysFormsCommand inputItem)
        {
              
  
		entity.SystemFormID = inputItem.SystemFormID;  
  
		entity.SFName = inputItem.SFName;  
  
		entity.SFSystemRef = inputItem.SFSystemRef;  
  
		entity.SFTitle = inputItem.SFTitle;  
  
		entity.SFTableName = inputItem.SFTableName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysFormsDto Map(GnrSysForms inputItem)
        {
            var dto = new GnrSysFormsDto()
            {
                  
  
		SystemFormID = inputItem.SystemFormID,  
  
		SFName = inputItem.SFName,  
  
		SFSystemRef = inputItem.SFSystemRef,  
  
		SFTitle = inputItem.SFTitle,  
  
		SFTableName = inputItem.SFTableName, 
            };
            return dto;
        }

        public static List<GnrSysFormsDto> Map(ICollection<GnrSysForms> entities)
        {
            var dtos = new List<GnrSysFormsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysFormsDto()
                {
                      
  
		SystemFormID = inputItem.SystemFormID,  
  
		SFName = inputItem.SFName,  
  
		SFSystemRef = inputItem.SFSystemRef,  
  
		SFTitle = inputItem.SFTitle,  
  
		SFTableName = inputItem.SFTableName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysLogs Map(AddGnrSysLogsCommand inputItem)
        {
            var entity = new GnrSysLogs() {
                  
  
		AsmLogId = inputItem.AsmLogId,  
  
		LogTableName = inputItem.LogTableName,  
  
		LogOprType = inputItem.LogOprType,  
  
		LogParentId = inputItem.LogParentId,  
  
		LogUserRef = inputItem.LogUserRef,  
  
		LogDate = inputItem.LogDate,  
  
		LogDescr = inputItem.LogDescr,  
  
		UserDescr = inputItem.UserDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysLogs Map(GnrSysLogs entity ,EditGnrSysLogsCommand inputItem)
        {
              
  
		entity.AsmLogId = inputItem.AsmLogId;  
  
		entity.LogTableName = inputItem.LogTableName;  
  
		entity.LogOprType = inputItem.LogOprType;  
  
		entity.LogParentId = inputItem.LogParentId;  
  
		entity.LogUserRef = inputItem.LogUserRef;  
  
		entity.LogDate = inputItem.LogDate;  
  
		entity.LogDescr = inputItem.LogDescr;  
  
		entity.UserDescr = inputItem.UserDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysLogsDto Map(GnrSysLogs inputItem)
        {
            var dto = new GnrSysLogsDto()
            {
                  
  
		AsmLogId = inputItem.AsmLogId,  
  
		LogTableName = inputItem.LogTableName,  
  
		LogOprType = inputItem.LogOprType,  
  
		LogParentId = inputItem.LogParentId,  
  
		LogUserRef = inputItem.LogUserRef,  
  
		LogDate = inputItem.LogDate,  
  
		LogDescr = inputItem.LogDescr,  
  
		UserDescr = inputItem.UserDescr, 
            };
            return dto;
        }

        public static List<GnrSysLogsDto> Map(ICollection<GnrSysLogs> entities)
        {
            var dtos = new List<GnrSysLogsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysLogsDto()
                {
                      
  
		AsmLogId = inputItem.AsmLogId,  
  
		LogTableName = inputItem.LogTableName,  
  
		LogOprType = inputItem.LogOprType,  
  
		LogParentId = inputItem.LogParentId,  
  
		LogUserRef = inputItem.LogUserRef,  
  
		LogDate = inputItem.LogDate,  
  
		LogDescr = inputItem.LogDescr,  
  
		UserDescr = inputItem.UserDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysMsg Map(AddGnrSysMsgCommand inputItem)
        {
            var entity = new GnrSysMsg() {
                  
  
		GnrSysMsgId = inputItem.GnrSysMsgId,  
  
		GSMTitle = inputItem.GSMTitle,  
  
		GSMDescr = inputItem.GSMDescr,  
  
		GSMSDate = inputItem.GSMSDate,  
  
		GSMEDate = inputItem.GSMEDate,  
  
		GSMType = inputItem.GSMType,  
  
		GSMCreator = inputItem.GSMCreator, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysMsg Map(GnrSysMsg entity ,EditGnrSysMsgCommand inputItem)
        {
              
  
		entity.GnrSysMsgId = inputItem.GnrSysMsgId;  
  
		entity.GSMTitle = inputItem.GSMTitle;  
  
		entity.GSMDescr = inputItem.GSMDescr;  
  
		entity.GSMSDate = inputItem.GSMSDate;  
  
		entity.GSMEDate = inputItem.GSMEDate;  
  
		entity.GSMType = inputItem.GSMType;  
  
		entity.GSMCreator = inputItem.GSMCreator; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysMsgDto Map(GnrSysMsg inputItem)
        {
            var dto = new GnrSysMsgDto()
            {
                  
  
		GnrSysMsgId = inputItem.GnrSysMsgId,  
  
		GSMTitle = inputItem.GSMTitle,  
  
		GSMDescr = inputItem.GSMDescr,  
  
		GSMSDate = inputItem.GSMSDate,  
  
		GSMEDate = inputItem.GSMEDate,  
  
		GSMType = inputItem.GSMType,  
  
		GSMCreator = inputItem.GSMCreator, 
            };
            return dto;
        }

        public static List<GnrSysMsgDto> Map(ICollection<GnrSysMsg> entities)
        {
            var dtos = new List<GnrSysMsgDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysMsgDto()
                {
                      
  
		GnrSysMsgId = inputItem.GnrSysMsgId,  
  
		GSMTitle = inputItem.GSMTitle,  
  
		GSMDescr = inputItem.GSMDescr,  
  
		GSMSDate = inputItem.GSMSDate,  
  
		GSMEDate = inputItem.GSMEDate,  
  
		GSMType = inputItem.GSMType,  
  
		GSMCreator = inputItem.GSMCreator, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysMsgDet Map(AddGnrSysMsgDetCommand inputItem)
        {
            var entity = new GnrSysMsgDet() {
                  
  
		GSMDHdrRef = inputItem.GSMDHdrRef,  
  
		GSMDUserRef = inputItem.GSMDUserRef,  
  
		GSMDSit = inputItem.GSMDSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysMsgDet Map(GnrSysMsgDet entity ,EditGnrSysMsgDetCommand inputItem)
        {
              
  
		entity.GSMDHdrRef = inputItem.GSMDHdrRef;  
  
		entity.GSMDUserRef = inputItem.GSMDUserRef;  
  
		entity.GSMDSit = inputItem.GSMDSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysMsgDetDto Map(GnrSysMsgDet inputItem)
        {
            var dto = new GnrSysMsgDetDto()
            {
                  
  
		GSMDHdrRef = inputItem.GSMDHdrRef,  
  
		GSMDUserRef = inputItem.GSMDUserRef,  
  
		GSMDSit = inputItem.GSMDSit, 
            };
            return dto;
        }

        public static List<GnrSysMsgDetDto> Map(ICollection<GnrSysMsgDet> entities)
        {
            var dtos = new List<GnrSysMsgDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysMsgDetDto()
                {
                      
  
		GSMDHdrRef = inputItem.GSMDHdrRef,  
  
		GSMDUserRef = inputItem.GSMDUserRef,  
  
		GSMDSit = inputItem.GSMDSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysQryFields Map(AddGnrSysQryFieldsCommand inputItem)
        {
            var entity = new GnrSysQryFields() {
                  
  
		GSFQryRef = inputItem.GSFQryRef,  
  
		GSFTitle = inputItem.GSFTitle,  
  
		GSFName = inputItem.GSFName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysQryFields Map(GnrSysQryFields entity ,EditGnrSysQryFieldsCommand inputItem)
        {
              
  
		entity.GSFQryRef = inputItem.GSFQryRef;  
  
		entity.GSFTitle = inputItem.GSFTitle;  
  
		entity.GSFName = inputItem.GSFName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysQryFieldsDto Map(GnrSysQryFields inputItem)
        {
            var dto = new GnrSysQryFieldsDto()
            {
                  
  
		GSFQryRef = inputItem.GSFQryRef,  
  
		GSFTitle = inputItem.GSFTitle,  
  
		GSFName = inputItem.GSFName, 
            };
            return dto;
        }

        public static List<GnrSysQryFieldsDto> Map(ICollection<GnrSysQryFields> entities)
        {
            var dtos = new List<GnrSysQryFieldsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysQryFieldsDto()
                {
                      
  
		GSFQryRef = inputItem.GSFQryRef,  
  
		GSFTitle = inputItem.GSFTitle,  
  
		GSFName = inputItem.GSFName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysQuerys Map(AddGnrSysQuerysCommand inputItem)
        {
            var entity = new GnrSysQuerys() {
                  
  
		GnrSysQryId = inputItem.GnrSysQryId,  
  
		GSQTitle = inputItem.GSQTitle,  
  
		GSQView = inputItem.GSQView,  
  
		GSQSysRef = inputItem.GSQSysRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysQuerys Map(GnrSysQuerys entity ,EditGnrSysQuerysCommand inputItem)
        {
              
  
		entity.GnrSysQryId = inputItem.GnrSysQryId;  
  
		entity.GSQTitle = inputItem.GSQTitle;  
  
		entity.GSQView = inputItem.GSQView;  
  
		entity.GSQSysRef = inputItem.GSQSysRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysQuerysDto Map(GnrSysQuerys inputItem)
        {
            var dto = new GnrSysQuerysDto()
            {
                  
  
		GnrSysQryId = inputItem.GnrSysQryId,  
  
		GSQTitle = inputItem.GSQTitle,  
  
		GSQView = inputItem.GSQView,  
  
		GSQSysRef = inputItem.GSQSysRef, 
            };
            return dto;
        }

        public static List<GnrSysQuerysDto> Map(ICollection<GnrSysQuerys> entities)
        {
            var dtos = new List<GnrSysQuerysDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysQuerysDto()
                {
                      
  
		GnrSysQryId = inputItem.GnrSysQryId,  
  
		GSQTitle = inputItem.GSQTitle,  
  
		GSQView = inputItem.GSQView,  
  
		GSQSysRef = inputItem.GSQSysRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrSysTables Map(AddGnrSysTablesCommand inputItem)
        {
            var entity = new GnrSysTables() {
                  
  
		GnrSysTableId = inputItem.GnrSysTableId,  
  
		GSTName = inputItem.GSTName,  
  
		GSTTitle = inputItem.GSTTitle,  
  
		GSTParent = inputItem.GSTParent,  
  
		GSTKeyName = inputItem.GSTKeyName,  
  
		GSTRelKeyName = inputItem.GSTRelKeyName,  
  
		GSTSystem = inputItem.GSTSystem,  
  
		GSTQuery = inputItem.GSTQuery, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrSysTables Map(GnrSysTables entity ,EditGnrSysTablesCommand inputItem)
        {
              
  
		entity.GnrSysTableId = inputItem.GnrSysTableId;  
  
		entity.GSTName = inputItem.GSTName;  
  
		entity.GSTTitle = inputItem.GSTTitle;  
  
		entity.GSTParent = inputItem.GSTParent;  
  
		entity.GSTKeyName = inputItem.GSTKeyName;  
  
		entity.GSTRelKeyName = inputItem.GSTRelKeyName;  
  
		entity.GSTSystem = inputItem.GSTSystem;  
  
		entity.GSTQuery = inputItem.GSTQuery; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrSysTablesDto Map(GnrSysTables inputItem)
        {
            var dto = new GnrSysTablesDto()
            {
                  
  
		GnrSysTableId = inputItem.GnrSysTableId,  
  
		GSTName = inputItem.GSTName,  
  
		GSTTitle = inputItem.GSTTitle,  
  
		GSTParent = inputItem.GSTParent,  
  
		GSTKeyName = inputItem.GSTKeyName,  
  
		GSTRelKeyName = inputItem.GSTRelKeyName,  
  
		GSTSystem = inputItem.GSTSystem,  
  
		GSTQuery = inputItem.GSTQuery, 
            };
            return dto;
        }

        public static List<GnrSysTablesDto> Map(ICollection<GnrSysTables> entities)
        {
            var dtos = new List<GnrSysTablesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrSysTablesDto()
                {
                      
  
		GnrSysTableId = inputItem.GnrSysTableId,  
  
		GSTName = inputItem.GSTName,  
  
		GSTTitle = inputItem.GSTTitle,  
  
		GSTParent = inputItem.GSTParent,  
  
		GSTKeyName = inputItem.GSTKeyName,  
  
		GSTRelKeyName = inputItem.GSTRelKeyName,  
  
		GSTSystem = inputItem.GSTSystem,  
  
		GSTQuery = inputItem.GSTQuery, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrTableRelation Map(AddGnrTableRelationCommand inputItem)
        {
            var entity = new GnrTableRelation() {
                  
  
		GnrTableRelationId = inputItem.GnrTableRelationId,  
  
		RelationName = inputItem.RelationName,  
  
		RelationTitle = inputItem.RelationTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrTableRelation Map(GnrTableRelation entity ,EditGnrTableRelationCommand inputItem)
        {
              
  
		entity.GnrTableRelationId = inputItem.GnrTableRelationId;  
  
		entity.RelationName = inputItem.RelationName;  
  
		entity.RelationTitle = inputItem.RelationTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrTableRelationDto Map(GnrTableRelation inputItem)
        {
            var dto = new GnrTableRelationDto()
            {
                  
  
		GnrTableRelationId = inputItem.GnrTableRelationId,  
  
		RelationName = inputItem.RelationName,  
  
		RelationTitle = inputItem.RelationTitle, 
            };
            return dto;
        }

        public static List<GnrTableRelationDto> Map(ICollection<GnrTableRelation> entities)
        {
            var dtos = new List<GnrTableRelationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrTableRelationDto()
                {
                      
  
		GnrTableRelationId = inputItem.GnrTableRelationId,  
  
		RelationName = inputItem.RelationName,  
  
		RelationTitle = inputItem.RelationTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrTablesDet Map(AddGnrTablesDetCommand inputItem)
        {
            var entity = new GnrTablesDet() {
                  
  
		TableRef = inputItem.TableRef,  
  
		ColName = inputItem.ColName,  
  
		ColTitle = inputItem.ColTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrTablesDet Map(GnrTablesDet entity ,EditGnrTablesDetCommand inputItem)
        {
              
  
		entity.TableRef = inputItem.TableRef;  
  
		entity.ColName = inputItem.ColName;  
  
		entity.ColTitle = inputItem.ColTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrTablesDetDto Map(GnrTablesDet inputItem)
        {
            var dto = new GnrTablesDetDto()
            {
                  
  
		TableRef = inputItem.TableRef,  
  
		ColName = inputItem.ColName,  
  
		ColTitle = inputItem.ColTitle, 
            };
            return dto;
        }

        public static List<GnrTablesDetDto> Map(ICollection<GnrTablesDet> entities)
        {
            var dtos = new List<GnrTablesDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrTablesDetDto()
                {
                      
  
		TableRef = inputItem.TableRef,  
  
		ColName = inputItem.ColName,  
  
		ColTitle = inputItem.ColTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrTablesInf Map(AddGnrTablesInfCommand inputItem)
        {
            var entity = new GnrTablesInf() {
                  
  
		GnrTabesInfId = inputItem.GnrTabesInfId,  
  
		TableName = inputItem.TableName,  
  
		Title = inputItem.Title, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrTablesInf Map(GnrTablesInf entity ,EditGnrTablesInfCommand inputItem)
        {
              
  
		entity.GnrTabesInfId = inputItem.GnrTabesInfId;  
  
		entity.TableName = inputItem.TableName;  
  
		entity.Title = inputItem.Title; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrTablesInfDto Map(GnrTablesInf inputItem)
        {
            var dto = new GnrTablesInfDto()
            {
                  
  
		GnrTabesInfId = inputItem.GnrTabesInfId,  
  
		TableName = inputItem.TableName,  
  
		Title = inputItem.Title, 
            };
            return dto;
        }

        public static List<GnrTablesInfDto> Map(ICollection<GnrTablesInf> entities)
        {
            var dtos = new List<GnrTablesInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrTablesInfDto()
                {
                      
  
		GnrTabesInfId = inputItem.GnrTabesInfId,  
  
		TableName = inputItem.TableName,  
  
		Title = inputItem.Title, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrTools Map(AddGnrToolsCommand inputItem)
        {
            var entity = new GnrTools() {
                  
  
		GnrToolsId = inputItem.GnrToolsId,  
  
		GTTitle = inputItem.GTTitle,  
  
		GTSysRef = inputItem.GTSysRef,  
  
		GTListQry = inputItem.GTListQry,  
  
		GTOprQry = inputItem.GTOprQry, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrTools Map(GnrTools entity ,EditGnrToolsCommand inputItem)
        {
              
  
		entity.GnrToolsId = inputItem.GnrToolsId;  
  
		entity.GTTitle = inputItem.GTTitle;  
  
		entity.GTSysRef = inputItem.GTSysRef;  
  
		entity.GTListQry = inputItem.GTListQry;  
  
		entity.GTOprQry = inputItem.GTOprQry; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrToolsDto Map(GnrTools inputItem)
        {
            var dto = new GnrToolsDto()
            {
                  
  
		GnrToolsId = inputItem.GnrToolsId,  
  
		GTTitle = inputItem.GTTitle,  
  
		GTSysRef = inputItem.GTSysRef,  
  
		GTListQry = inputItem.GTListQry,  
  
		GTOprQry = inputItem.GTOprQry, 
            };
            return dto;
        }

        public static List<GnrToolsDto> Map(ICollection<GnrTools> entities)
        {
            var dtos = new List<GnrToolsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrToolsDto()
                {
                      
  
		GnrToolsId = inputItem.GnrToolsId,  
  
		GTTitle = inputItem.GTTitle,  
  
		GTSysRef = inputItem.GTSysRef,  
  
		GTListQry = inputItem.GTListQry,  
  
		GTOprQry = inputItem.GTOprQry, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUFCtgry Map(AddGnrUFCtgryCommand inputItem)
        {
            var entity = new GnrUFCtgry() {
                  
  
		GnrUFCtgryId = inputItem.GnrUFCtgryId,  
  
		GUFCParent = inputItem.GUFCParent,  
  
		GUFTitle = inputItem.GUFTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUFCtgry Map(GnrUFCtgry entity ,EditGnrUFCtgryCommand inputItem)
        {
              
  
		entity.GnrUFCtgryId = inputItem.GnrUFCtgryId;  
  
		entity.GUFCParent = inputItem.GUFCParent;  
  
		entity.GUFTitle = inputItem.GUFTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUFCtgryDto Map(GnrUFCtgry inputItem)
        {
            var dto = new GnrUFCtgryDto()
            {
                  
  
		GnrUFCtgryId = inputItem.GnrUFCtgryId,  
  
		GUFCParent = inputItem.GUFCParent,  
  
		GUFTitle = inputItem.GUFTitle, 
            };
            return dto;
        }

        public static List<GnrUFCtgryDto> Map(ICollection<GnrUFCtgry> entities)
        {
            var dtos = new List<GnrUFCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUFCtgryDto()
                {
                      
  
		GnrUFCtgryId = inputItem.GnrUFCtgryId,  
  
		GUFCParent = inputItem.GUFCParent,  
  
		GUFTitle = inputItem.GUFTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserAlarms Map(AddGnrUserAlarmsCommand inputItem)
        {
            var entity = new GnrUserAlarms() {
                  
  
		UserAlarmId = inputItem.UserAlarmId,  
  
		UAType = inputItem.UAType,  
  
		UAUserRef = inputItem.UAUserRef,  
  
		UAStartDur = inputItem.UAStartDur,  
  
		UARepeatDur = inputItem.UARepeatDur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserAlarms Map(GnrUserAlarms entity ,EditGnrUserAlarmsCommand inputItem)
        {
              
  
		entity.UserAlarmId = inputItem.UserAlarmId;  
  
		entity.UAType = inputItem.UAType;  
  
		entity.UAUserRef = inputItem.UAUserRef;  
  
		entity.UAStartDur = inputItem.UAStartDur;  
  
		entity.UARepeatDur = inputItem.UARepeatDur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserAlarmsDto Map(GnrUserAlarms inputItem)
        {
            var dto = new GnrUserAlarmsDto()
            {
                  
  
		UserAlarmId = inputItem.UserAlarmId,  
  
		UAType = inputItem.UAType,  
  
		UAUserRef = inputItem.UAUserRef,  
  
		UAStartDur = inputItem.UAStartDur,  
  
		UARepeatDur = inputItem.UARepeatDur, 
            };
            return dto;
        }

        public static List<GnrUserAlarmsDto> Map(ICollection<GnrUserAlarms> entities)
        {
            var dtos = new List<GnrUserAlarmsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserAlarmsDto()
                {
                      
  
		UserAlarmId = inputItem.UserAlarmId,  
  
		UAType = inputItem.UAType,  
  
		UAUserRef = inputItem.UAUserRef,  
  
		UAStartDur = inputItem.UAStartDur,  
  
		UARepeatDur = inputItem.UARepeatDur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserField Map(AddGnrUserFieldCommand inputItem)
        {
            var entity = new GnrUserField() {
                  
  
		GnrUserFieldId = inputItem.GnrUserFieldId,  
  
		GUFdFormRef = inputItem.GUFdFormRef,  
  
		GUFdGroupRef = inputItem.GUFdGroupRef,  
  
		GUFdTitle = inputItem.GUFdTitle,  
  
		GUFdName = inputItem.GUFdName,  
  
		GUFdType = inputItem.GUFdType,  
  
		GUFdShDir = inputItem.GUFdShDir,  
  
		GUFdShPrv = inputItem.GUFdShPrv,  
  
		GUFdSize = inputItem.GUFdSize,  
  
		GUFdShInList = inputItem.GUFdShInList,  
  
		GUFdForce = inputItem.GUFdForce,  
  
		GUFdEditAble = inputItem.GUFdEditAble,  
  
		GUFdIsCalcField = inputItem.GUFdIsCalcField,  
  
		GUFdValids = inputItem.GUFdValids,  
  
		GUFdRefrence = inputItem.GUFdRefrence,  
  
		GUOrder = inputItem.GUOrder,  
  
		GUFdCalcStr = inputItem.GUFdCalcStr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserField Map(GnrUserField entity ,EditGnrUserFieldCommand inputItem)
        {
              
  
		entity.GnrUserFieldId = inputItem.GnrUserFieldId;  
  
		entity.GUFdFormRef = inputItem.GUFdFormRef;  
  
		entity.GUFdGroupRef = inputItem.GUFdGroupRef;  
  
		entity.GUFdTitle = inputItem.GUFdTitle;  
  
		entity.GUFdName = inputItem.GUFdName;  
  
		entity.GUFdType = inputItem.GUFdType;  
  
		entity.GUFdShDir = inputItem.GUFdShDir;  
  
		entity.GUFdShPrv = inputItem.GUFdShPrv;  
  
		entity.GUFdSize = inputItem.GUFdSize;  
  
		entity.GUFdShInList = inputItem.GUFdShInList;  
  
		entity.GUFdForce = inputItem.GUFdForce;  
  
		entity.GUFdEditAble = inputItem.GUFdEditAble;  
  
		entity.GUFdIsCalcField = inputItem.GUFdIsCalcField;  
  
		entity.GUFdValids = inputItem.GUFdValids;  
  
		entity.GUFdRefrence = inputItem.GUFdRefrence;  
  
		entity.GUOrder = inputItem.GUOrder;  
  
		entity.GUFdCalcStr = inputItem.GUFdCalcStr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserFieldDto Map(GnrUserField inputItem)
        {
            var dto = new GnrUserFieldDto()
            {
                  
  
		GnrUserFieldId = inputItem.GnrUserFieldId,  
  
		GUFdFormRef = inputItem.GUFdFormRef,  
  
		GUFdGroupRef = inputItem.GUFdGroupRef,  
  
		GUFdTitle = inputItem.GUFdTitle,  
  
		GUFdName = inputItem.GUFdName,  
  
		GUFdType = inputItem.GUFdType,  
  
		GUFdShDir = inputItem.GUFdShDir,  
  
		GUFdShPrv = inputItem.GUFdShPrv,  
  
		GUFdSize = inputItem.GUFdSize,  
  
		GUFdShInList = inputItem.GUFdShInList,  
  
		GUFdForce = inputItem.GUFdForce,  
  
		GUFdEditAble = inputItem.GUFdEditAble,  
  
		GUFdIsCalcField = inputItem.GUFdIsCalcField,  
  
		GUFdValids = inputItem.GUFdValids,  
  
		GUFdRefrence = inputItem.GUFdRefrence,  
  
		GUOrder = inputItem.GUOrder,  
  
		GUFdCalcStr = inputItem.GUFdCalcStr, 
            };
            return dto;
        }

        public static List<GnrUserFieldDto> Map(ICollection<GnrUserField> entities)
        {
            var dtos = new List<GnrUserFieldDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserFieldDto()
                {
                      
  
		GnrUserFieldId = inputItem.GnrUserFieldId,  
  
		GUFdFormRef = inputItem.GUFdFormRef,  
  
		GUFdGroupRef = inputItem.GUFdGroupRef,  
  
		GUFdTitle = inputItem.GUFdTitle,  
  
		GUFdName = inputItem.GUFdName,  
  
		GUFdType = inputItem.GUFdType,  
  
		GUFdShDir = inputItem.GUFdShDir,  
  
		GUFdShPrv = inputItem.GUFdShPrv,  
  
		GUFdSize = inputItem.GUFdSize,  
  
		GUFdShInList = inputItem.GUFdShInList,  
  
		GUFdForce = inputItem.GUFdForce,  
  
		GUFdEditAble = inputItem.GUFdEditAble,  
  
		GUFdIsCalcField = inputItem.GUFdIsCalcField,  
  
		GUFdValids = inputItem.GUFdValids,  
  
		GUFdRefrence = inputItem.GUFdRefrence,  
  
		GUOrder = inputItem.GUOrder,  
  
		GUFdCalcStr = inputItem.GUFdCalcStr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserFormDesign Map(AddGnrUserFormDesignCommand inputItem)
        {
            var entity = new GnrUserFormDesign() {
                  
  
		GUFDFormRef = inputItem.GUFDFormRef,  
  
		GUFDFieldRef = inputItem.GUFDFieldRef,  
  
		GUFDPropRef = inputItem.GUFDPropRef,  
  
		GUFDValue = inputItem.GUFDValue,  
  
		GUFDFieldParent = inputItem.GUFDFieldParent, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserFormDesign Map(GnrUserFormDesign entity ,EditGnrUserFormDesignCommand inputItem)
        {
              
  
		entity.GUFDFormRef = inputItem.GUFDFormRef;  
  
		entity.GUFDFieldRef = inputItem.GUFDFieldRef;  
  
		entity.GUFDPropRef = inputItem.GUFDPropRef;  
  
		entity.GUFDValue = inputItem.GUFDValue;  
  
		entity.GUFDFieldParent = inputItem.GUFDFieldParent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserFormDesignDto Map(GnrUserFormDesign inputItem)
        {
            var dto = new GnrUserFormDesignDto()
            {
                  
  
		GUFDFormRef = inputItem.GUFDFormRef,  
  
		GUFDFieldRef = inputItem.GUFDFieldRef,  
  
		GUFDPropRef = inputItem.GUFDPropRef,  
  
		GUFDValue = inputItem.GUFDValue,  
  
		GUFDFieldParent = inputItem.GUFDFieldParent, 
            };
            return dto;
        }

        public static List<GnrUserFormDesignDto> Map(ICollection<GnrUserFormDesign> entities)
        {
            var dtos = new List<GnrUserFormDesignDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserFormDesignDto()
                {
                      
  
		GUFDFormRef = inputItem.GUFDFormRef,  
  
		GUFDFieldRef = inputItem.GUFDFieldRef,  
  
		GUFDPropRef = inputItem.GUFDPropRef,  
  
		GUFDValue = inputItem.GUFDValue,  
  
		GUFDFieldParent = inputItem.GUFDFieldParent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserFormOprs Map(AddGnrUserFormOprsCommand inputItem)
        {
            var entity = new GnrUserFormOprs() {
                  
  
		GUFOItmType = inputItem.GUFOItmType,  
  
		GUFOItmId = inputItem.GUFOItmId,  
  
		GUFOCmd = inputItem.GUFOCmd, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserFormOprs Map(GnrUserFormOprs entity ,EditGnrUserFormOprsCommand inputItem)
        {
              
  
		entity.GUFOItmType = inputItem.GUFOItmType;  
  
		entity.GUFOItmId = inputItem.GUFOItmId;  
  
		entity.GUFOCmd = inputItem.GUFOCmd; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserFormOprsDto Map(GnrUserFormOprs inputItem)
        {
            var dto = new GnrUserFormOprsDto()
            {
                  
  
		GUFOItmType = inputItem.GUFOItmType,  
  
		GUFOItmId = inputItem.GUFOItmId,  
  
		GUFOCmd = inputItem.GUFOCmd, 
            };
            return dto;
        }

        public static List<GnrUserFormOprsDto> Map(ICollection<GnrUserFormOprs> entities)
        {
            var dtos = new List<GnrUserFormOprsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserFormOprsDto()
                {
                      
  
		GUFOItmType = inputItem.GUFOItmType,  
  
		GUFOItmId = inputItem.GUFOItmId,  
  
		GUFOCmd = inputItem.GUFOCmd, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserForms Map(AddGnrUserFormsCommand inputItem)
        {
            var entity = new GnrUserForms() {
                  
  
		GnrUsrFrmId = inputItem.GnrUsrFrmId,  
  
		GUFTitle = inputItem.GUFTitle,  
  
		GUFTableName = inputItem.GUFTableName,  
  
		GUFLink = inputItem.GUFLink,  
  
		GUFDesField = inputItem.GUFDesField,  
  
		GUFFormId = inputItem.GUFFormId,  
  
		GUFCtgryRef = inputItem.GUFCtgryRef,  
  
		GUFFormRelType = inputItem.GUFFormRelType,  
  
		GUFFormType = inputItem.GUFFormType,  
  
		GUFAutoRefresh = inputItem.GUFAutoRefresh,  
  
		GUFNoList = inputItem.GUFNoList, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserForms Map(GnrUserForms entity ,EditGnrUserFormsCommand inputItem)
        {
              
  
		entity.GnrUsrFrmId = inputItem.GnrUsrFrmId;  
  
		entity.GUFTitle = inputItem.GUFTitle;  
  
		entity.GUFTableName = inputItem.GUFTableName;  
  
		entity.GUFLink = inputItem.GUFLink;  
  
		entity.GUFDesField = inputItem.GUFDesField;  
  
		entity.GUFFormId = inputItem.GUFFormId;  
  
		entity.GUFCtgryRef = inputItem.GUFCtgryRef;  
  
		entity.GUFFormRelType = inputItem.GUFFormRelType;  
  
		entity.GUFFormType = inputItem.GUFFormType;  
  
		entity.GUFAutoRefresh = inputItem.GUFAutoRefresh;  
  
		entity.GUFNoList = inputItem.GUFNoList; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserFormsDto Map(GnrUserForms inputItem)
        {
            var dto = new GnrUserFormsDto()
            {
                  
  
		GnrUsrFrmId = inputItem.GnrUsrFrmId,  
  
		GUFTitle = inputItem.GUFTitle,  
  
		GUFTableName = inputItem.GUFTableName,  
  
		GUFLink = inputItem.GUFLink,  
  
		GUFDesField = inputItem.GUFDesField,  
  
		GUFFormId = inputItem.GUFFormId,  
  
		GUFCtgryRef = inputItem.GUFCtgryRef,  
  
		GUFFormRelType = inputItem.GUFFormRelType,  
  
		GUFFormType = inputItem.GUFFormType,  
  
		GUFAutoRefresh = inputItem.GUFAutoRefresh,  
  
		GUFNoList = inputItem.GUFNoList, 
            };
            return dto;
        }

        public static List<GnrUserFormsDto> Map(ICollection<GnrUserForms> entities)
        {
            var dtos = new List<GnrUserFormsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserFormsDto()
                {
                      
  
		GnrUsrFrmId = inputItem.GnrUsrFrmId,  
  
		GUFTitle = inputItem.GUFTitle,  
  
		GUFTableName = inputItem.GUFTableName,  
  
		GUFLink = inputItem.GUFLink,  
  
		GUFDesField = inputItem.GUFDesField,  
  
		GUFFormId = inputItem.GUFFormId,  
  
		GUFCtgryRef = inputItem.GUFCtgryRef,  
  
		GUFFormRelType = inputItem.GUFFormRelType,  
  
		GUFFormType = inputItem.GUFFormType,  
  
		GUFAutoRefresh = inputItem.GUFAutoRefresh,  
  
		GUFNoList = inputItem.GUFNoList, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserLabels Map(AddGnrUserLabelsCommand inputItem)
        {
            var entity = new GnrUserLabels() {
                  
  
		GnrUserLabelId = inputItem.GnrUserLabelId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULTitle = inputItem.GULTitle,  
  
		GULParent = inputItem.GULParent, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserLabels Map(GnrUserLabels entity ,EditGnrUserLabelsCommand inputItem)
        {
              
  
		entity.GnrUserLabelId = inputItem.GnrUserLabelId;  
  
		entity.GULUserRef = inputItem.GULUserRef;  
  
		entity.GULTitle = inputItem.GULTitle;  
  
		entity.GULParent = inputItem.GULParent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserLabelsDto Map(GnrUserLabels inputItem)
        {
            var dto = new GnrUserLabelsDto()
            {
                  
  
		GnrUserLabelId = inputItem.GnrUserLabelId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULTitle = inputItem.GULTitle,  
  
		GULParent = inputItem.GULParent, 
            };
            return dto;
        }

        public static List<GnrUserLabelsDto> Map(ICollection<GnrUserLabels> entities)
        {
            var dtos = new List<GnrUserLabelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserLabelsDto()
                {
                      
  
		GnrUserLabelId = inputItem.GnrUserLabelId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULTitle = inputItem.GULTitle,  
  
		GULParent = inputItem.GULParent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserLog Map(AddGnrUserLogCommand inputItem)
        {
            var entity = new GnrUserLog() {
                  
  
		GnrUserLogId = inputItem.GnrUserLogId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULCompName = inputItem.GULCompName,  
  
		GULSDate = inputItem.GULSDate,  
  
		GULEDate = inputItem.GULEDate,  
  
		GULType = inputItem.GULType,  
  
		GULDescr = inputItem.GULDescr,  
  
		GULSPID = inputItem.GULSPID, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserLog Map(GnrUserLog entity ,EditGnrUserLogCommand inputItem)
        {
              
  
		entity.GnrUserLogId = inputItem.GnrUserLogId;  
  
		entity.GULUserRef = inputItem.GULUserRef;  
  
		entity.GULCompName = inputItem.GULCompName;  
  
		entity.GULSDate = inputItem.GULSDate;  
  
		entity.GULEDate = inputItem.GULEDate;  
  
		entity.GULType = inputItem.GULType;  
  
		entity.GULDescr = inputItem.GULDescr;  
  
		entity.GULSPID = inputItem.GULSPID; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserLogDto Map(GnrUserLog inputItem)
        {
            var dto = new GnrUserLogDto()
            {
                  
  
		GnrUserLogId = inputItem.GnrUserLogId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULCompName = inputItem.GULCompName,  
  
		GULSDate = inputItem.GULSDate,  
  
		GULEDate = inputItem.GULEDate,  
  
		GULType = inputItem.GULType,  
  
		GULDescr = inputItem.GULDescr,  
  
		GULSPID = inputItem.GULSPID, 
            };
            return dto;
        }

        public static List<GnrUserLogDto> Map(ICollection<GnrUserLog> entities)
        {
            var dtos = new List<GnrUserLogDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserLogDto()
                {
                      
  
		GnrUserLogId = inputItem.GnrUserLogId,  
  
		GULUserRef = inputItem.GULUserRef,  
  
		GULCompName = inputItem.GULCompName,  
  
		GULSDate = inputItem.GULSDate,  
  
		GULEDate = inputItem.GULEDate,  
  
		GULType = inputItem.GULType,  
  
		GULDescr = inputItem.GULDescr,  
  
		GULSPID = inputItem.GULSPID, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserMsg Map(AddGnrUserMsgCommand inputItem)
        {
            var entity = new GnrUserMsg() {
                  
  
		GnrUserMsgId = inputItem.GnrUserMsgId,  
  
		GUMFromUser = inputItem.GUMFromUser,  
  
		GUMToUser = inputItem.GUMToUser,  
  
		GUMMsg = inputItem.GUMMsg,  
  
		GUMSit = inputItem.GUMSit,  
  
		GUMAlarmRef = inputItem.GUMAlarmRef,  
  
		GUMDate = inputItem.GUMDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserMsg Map(GnrUserMsg entity ,EditGnrUserMsgCommand inputItem)
        {
              
  
		entity.GnrUserMsgId = inputItem.GnrUserMsgId;  
  
		entity.GUMFromUser = inputItem.GUMFromUser;  
  
		entity.GUMToUser = inputItem.GUMToUser;  
  
		entity.GUMMsg = inputItem.GUMMsg;  
  
		entity.GUMSit = inputItem.GUMSit;  
  
		entity.GUMAlarmRef = inputItem.GUMAlarmRef;  
  
		entity.GUMDate = inputItem.GUMDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserMsgDto Map(GnrUserMsg inputItem)
        {
            var dto = new GnrUserMsgDto()
            {
                  
  
		GnrUserMsgId = inputItem.GnrUserMsgId,  
  
		GUMFromUser = inputItem.GUMFromUser,  
  
		GUMToUser = inputItem.GUMToUser,  
  
		GUMMsg = inputItem.GUMMsg,  
  
		GUMSit = inputItem.GUMSit,  
  
		GUMAlarmRef = inputItem.GUMAlarmRef,  
  
		GUMDate = inputItem.GUMDate, 
            };
            return dto;
        }

        public static List<GnrUserMsgDto> Map(ICollection<GnrUserMsg> entities)
        {
            var dtos = new List<GnrUserMsgDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserMsgDto()
                {
                      
  
		GnrUserMsgId = inputItem.GnrUserMsgId,  
  
		GUMFromUser = inputItem.GUMFromUser,  
  
		GUMToUser = inputItem.GUMToUser,  
  
		GUMMsg = inputItem.GUMMsg,  
  
		GUMSit = inputItem.GUMSit,  
  
		GUMAlarmRef = inputItem.GUMAlarmRef,  
  
		GUMDate = inputItem.GUMDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserRefList Map(AddGnrUserRefListCommand inputItem)
        {
            var entity = new GnrUserRefList() {
                  
  
		GnrUserRefListId = inputItem.GnrUserRefListId,  
  
		GURLTitle = inputItem.GURLTitle,  
  
		GURLViewName = inputItem.GURLViewName,  
  
		GURLIdFieldName = inputItem.GURLIdFieldName,  
  
		GURLDesFieldName = inputItem.GURLDesFieldName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserRefList Map(GnrUserRefList entity ,EditGnrUserRefListCommand inputItem)
        {
              
  
		entity.GnrUserRefListId = inputItem.GnrUserRefListId;  
  
		entity.GURLTitle = inputItem.GURLTitle;  
  
		entity.GURLViewName = inputItem.GURLViewName;  
  
		entity.GURLIdFieldName = inputItem.GURLIdFieldName;  
  
		entity.GURLDesFieldName = inputItem.GURLDesFieldName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserRefListDto Map(GnrUserRefList inputItem)
        {
            var dto = new GnrUserRefListDto()
            {
                  
  
		GnrUserRefListId = inputItem.GnrUserRefListId,  
  
		GURLTitle = inputItem.GURLTitle,  
  
		GURLViewName = inputItem.GURLViewName,  
  
		GURLIdFieldName = inputItem.GURLIdFieldName,  
  
		GURLDesFieldName = inputItem.GURLDesFieldName, 
            };
            return dto;
        }

        public static List<GnrUserRefListDto> Map(ICollection<GnrUserRefList> entities)
        {
            var dtos = new List<GnrUserRefListDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserRefListDto()
                {
                      
  
		GnrUserRefListId = inputItem.GnrUserRefListId,  
  
		GURLTitle = inputItem.GURLTitle,  
  
		GURLViewName = inputItem.GURLViewName,  
  
		GURLIdFieldName = inputItem.GURLIdFieldName,  
  
		GURLDesFieldName = inputItem.GURLDesFieldName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserRefListDet Map(AddGnrUserRefListDetCommand inputItem)
        {
            var entity = new GnrUserRefListDet() {
                  
  
		GURLListRef = inputItem.GURLListRef,  
  
		GURLFieldName = inputItem.GURLFieldName,  
  
		GURLFieldTitle = inputItem.GURLFieldTitle,  
  
		GURLShowOnForm = inputItem.GURLShowOnForm,  
  
		GURLSize = inputItem.GURLSize, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserRefListDet Map(GnrUserRefListDet entity ,EditGnrUserRefListDetCommand inputItem)
        {
              
  
		entity.GURLListRef = inputItem.GURLListRef;  
  
		entity.GURLFieldName = inputItem.GURLFieldName;  
  
		entity.GURLFieldTitle = inputItem.GURLFieldTitle;  
  
		entity.GURLShowOnForm = inputItem.GURLShowOnForm;  
  
		entity.GURLSize = inputItem.GURLSize; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserRefListDetDto Map(GnrUserRefListDet inputItem)
        {
            var dto = new GnrUserRefListDetDto()
            {
                  
  
		GURLListRef = inputItem.GURLListRef,  
  
		GURLFieldName = inputItem.GURLFieldName,  
  
		GURLFieldTitle = inputItem.GURLFieldTitle,  
  
		GURLShowOnForm = inputItem.GURLShowOnForm,  
  
		GURLSize = inputItem.GURLSize, 
            };
            return dto;
        }

        public static List<GnrUserRefListDetDto> Map(ICollection<GnrUserRefListDet> entities)
        {
            var dtos = new List<GnrUserRefListDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserRefListDetDto()
                {
                      
  
		GURLListRef = inputItem.GURLListRef,  
  
		GURLFieldName = inputItem.GURLFieldName,  
  
		GURLFieldTitle = inputItem.GURLFieldTitle,  
  
		GURLShowOnForm = inputItem.GURLShowOnForm,  
  
		GURLSize = inputItem.GURLSize, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserRole Map(AddGnrUserRoleCommand inputItem)
        {
            var entity = new GnrUserRole() {
                  
  
		GURUserRef = inputItem.GURUserRef,  
  
		GURRoleRef = inputItem.GURRoleRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserRole Map(GnrUserRole entity ,EditGnrUserRoleCommand inputItem)
        {
              
  
		entity.GURUserRef = inputItem.GURUserRef;  
  
		entity.GURRoleRef = inputItem.GURRoleRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserRoleDto Map(GnrUserRole inputItem)
        {
            var dto = new GnrUserRoleDto()
            {
                  
  
		GURUserRef = inputItem.GURUserRef,  
  
		GURRoleRef = inputItem.GURRoleRef, 
            };
            return dto;
        }

        public static List<GnrUserRoleDto> Map(ICollection<GnrUserRole> entities)
        {
            var dtos = new List<GnrUserRoleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserRoleDto()
                {
                      
  
		GURUserRef = inputItem.GURUserRef,  
  
		GURRoleRef = inputItem.GURRoleRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrUserStorage Map(AddGnrUserStorageCommand inputItem)
        {
            var entity = new GnrUserStorage() {
                  
  
		GUSFormRef = inputItem.GUSFormRef,  
  
		GUSUserRef = inputItem.GUSUserRef,  
  
		GUSType = inputItem.GUSType,  
  
		GUSValue = inputItem.GUSValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrUserStorage Map(GnrUserStorage entity ,EditGnrUserStorageCommand inputItem)
        {
              
  
		entity.GUSFormRef = inputItem.GUSFormRef;  
  
		entity.GUSUserRef = inputItem.GUSUserRef;  
  
		entity.GUSType = inputItem.GUSType;  
  
		entity.GUSValue = inputItem.GUSValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrUserStorageDto Map(GnrUserStorage inputItem)
        {
            var dto = new GnrUserStorageDto()
            {
                  
  
		GUSFormRef = inputItem.GUSFormRef,  
  
		GUSUserRef = inputItem.GUSUserRef,  
  
		GUSType = inputItem.GUSType,  
  
		GUSValue = inputItem.GUSValue, 
            };
            return dto;
        }

        public static List<GnrUserStorageDto> Map(ICollection<GnrUserStorage> entities)
        {
            var dtos = new List<GnrUserStorageDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrUserStorageDto()
                {
                      
  
		GUSFormRef = inputItem.GUSFormRef,  
  
		GUSUserRef = inputItem.GUSUserRef,  
  
		GUSType = inputItem.GUSType,  
  
		GUSValue = inputItem.GUSValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GnrValidData Map(AddGnrValidDataCommand inputItem)
        {
            var entity = new GnrValidData() {
                  
  
		GnrValidDataId = inputItem.GnrValidDataId,  
  
		GVDUserRef = inputItem.GVDUserRef,  
  
		GVDSysRef = inputItem.GVDSysRef,  
  
		GVDConfirmer = inputItem.GVDConfirmer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GnrValidData Map(GnrValidData entity ,EditGnrValidDataCommand inputItem)
        {
              
  
		entity.GnrValidDataId = inputItem.GnrValidDataId;  
  
		entity.GVDUserRef = inputItem.GVDUserRef;  
  
		entity.GVDSysRef = inputItem.GVDSysRef;  
  
		entity.GVDConfirmer = inputItem.GVDConfirmer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GnrValidDataDto Map(GnrValidData inputItem)
        {
            var dto = new GnrValidDataDto()
            {
                  
  
		GnrValidDataId = inputItem.GnrValidDataId,  
  
		GVDUserRef = inputItem.GVDUserRef,  
  
		GVDSysRef = inputItem.GVDSysRef,  
  
		GVDConfirmer = inputItem.GVDConfirmer, 
            };
            return dto;
        }

        public static List<GnrValidDataDto> Map(ICollection<GnrValidData> entities)
        {
            var dtos = new List<GnrValidDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GnrValidDataDto()
                {
                      
  
		GnrValidDataId = inputItem.GnrValidDataId,  
  
		GVDUserRef = inputItem.GVDUserRef,  
  
		GVDSysRef = inputItem.GVDSysRef,  
  
		GVDConfirmer = inputItem.GVDConfirmer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
