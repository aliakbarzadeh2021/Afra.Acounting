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
                
        
        public static SMSMethod Map(AddSMSMethodCommand inputItem)
        {
            var entity = new SMSMethod() {
                  
  
		SMSMethodId = inputItem.SMSMethodId,  
  
		SMSMthdTitle = inputItem.SMSMthdTitle,  
  
		SMSMthdType = inputItem.SMSMthdType,  
  
		SMSMthdSQL = inputItem.SMSMthdSQL,  
  
		SMSMthdText = inputItem.SMSMthdText, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SMSMethod Map(SMSMethod entity ,EditSMSMethodCommand inputItem)
        {
              
  
		entity.SMSMethodId = inputItem.SMSMethodId;  
  
		entity.SMSMthdTitle = inputItem.SMSMthdTitle;  
  
		entity.SMSMthdType = inputItem.SMSMthdType;  
  
		entity.SMSMthdSQL = inputItem.SMSMthdSQL;  
  
		entity.SMSMthdText = inputItem.SMSMthdText; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SMSMethodDto Map(SMSMethod inputItem)
        {
            var dto = new SMSMethodDto()
            {
                  
  
		SMSMethodId = inputItem.SMSMethodId,  
  
		SMSMthdTitle = inputItem.SMSMthdTitle,  
  
		SMSMthdType = inputItem.SMSMthdType,  
  
		SMSMthdSQL = inputItem.SMSMthdSQL,  
  
		SMSMthdText = inputItem.SMSMthdText, 
            };
            return dto;
        }

        public static List<SMSMethodDto> Map(ICollection<SMSMethod> entities)
        {
            var dtos = new List<SMSMethodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SMSMethodDto()
                {
                      
  
		SMSMethodId = inputItem.SMSMethodId,  
  
		SMSMthdTitle = inputItem.SMSMthdTitle,  
  
		SMSMthdType = inputItem.SMSMthdType,  
  
		SMSMthdSQL = inputItem.SMSMthdSQL,  
  
		SMSMthdText = inputItem.SMSMthdText, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SMSOperate Map(AddSMSOperateCommand inputItem)
        {
            var entity = new SMSOperate() {
                  
  
		SMSOperateId = inputItem.SMSOperateId,  
  
		SMSMethodRef = inputItem.SMSMethodRef,  
  
		SMSRole = inputItem.SMSRole,  
  
		SMSDur = inputItem.SMSDur,  
  
		SMSDelay = inputItem.SMSDelay,  
  
		SMSStartDate = inputItem.SMSStartDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SMSOperate Map(SMSOperate entity ,EditSMSOperateCommand inputItem)
        {
              
  
		entity.SMSOperateId = inputItem.SMSOperateId;  
  
		entity.SMSMethodRef = inputItem.SMSMethodRef;  
  
		entity.SMSRole = inputItem.SMSRole;  
  
		entity.SMSDur = inputItem.SMSDur;  
  
		entity.SMSDelay = inputItem.SMSDelay;  
  
		entity.SMSStartDate = inputItem.SMSStartDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SMSOperateDto Map(SMSOperate inputItem)
        {
            var dto = new SMSOperateDto()
            {
                  
  
		SMSOperateId = inputItem.SMSOperateId,  
  
		SMSMethodRef = inputItem.SMSMethodRef,  
  
		SMSRole = inputItem.SMSRole,  
  
		SMSDur = inputItem.SMSDur,  
  
		SMSDelay = inputItem.SMSDelay,  
  
		SMSStartDate = inputItem.SMSStartDate, 
            };
            return dto;
        }

        public static List<SMSOperateDto> Map(ICollection<SMSOperate> entities)
        {
            var dtos = new List<SMSOperateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SMSOperateDto()
                {
                      
  
		SMSOperateId = inputItem.SMSOperateId,  
  
		SMSMethodRef = inputItem.SMSMethodRef,  
  
		SMSRole = inputItem.SMSRole,  
  
		SMSDur = inputItem.SMSDur,  
  
		SMSDelay = inputItem.SMSDelay,  
  
		SMSStartDate = inputItem.SMSStartDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SMSOperateDet Map(AddSMSOperateDetCommand inputItem)
        {
            var entity = new SMSOperateDet() {
                  
  
		SMSOperateDetId = inputItem.SMSOperateDetId,  
  
		SMSOperateDate = inputItem.SMSOperateDate,  
  
		SMSOperateRef = inputItem.SMSOperateRef,  
  
		SODNumber = inputItem.SODNumber,  
  
		SODDeliver = inputItem.SODDeliver,  
  
		SODText = inputItem.SODText,  
  
		SODSendDate = inputItem.SODSendDate,  
  
		SODRcvDate = inputItem.SODRcvDate,  
  
		SODSit = inputItem.SODSit,  
  
		SODRefId = inputItem.SODRefId,  
  
		SODError = inputItem.SODError, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SMSOperateDet Map(SMSOperateDet entity ,EditSMSOperateDetCommand inputItem)
        {
              
  
		entity.SMSOperateDetId = inputItem.SMSOperateDetId;  
  
		entity.SMSOperateDate = inputItem.SMSOperateDate;  
  
		entity.SMSOperateRef = inputItem.SMSOperateRef;  
  
		entity.SODNumber = inputItem.SODNumber;  
  
		entity.SODDeliver = inputItem.SODDeliver;  
  
		entity.SODText = inputItem.SODText;  
  
		entity.SODSendDate = inputItem.SODSendDate;  
  
		entity.SODRcvDate = inputItem.SODRcvDate;  
  
		entity.SODSit = inputItem.SODSit;  
  
		entity.SODRefId = inputItem.SODRefId;  
  
		entity.SODError = inputItem.SODError; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SMSOperateDetDto Map(SMSOperateDet inputItem)
        {
            var dto = new SMSOperateDetDto()
            {
                  
  
		SMSOperateDetId = inputItem.SMSOperateDetId,  
  
		SMSOperateDate = inputItem.SMSOperateDate,  
  
		SMSOperateRef = inputItem.SMSOperateRef,  
  
		SODNumber = inputItem.SODNumber,  
  
		SODDeliver = inputItem.SODDeliver,  
  
		SODText = inputItem.SODText,  
  
		SODSendDate = inputItem.SODSendDate,  
  
		SODRcvDate = inputItem.SODRcvDate,  
  
		SODSit = inputItem.SODSit,  
  
		SODRefId = inputItem.SODRefId,  
  
		SODError = inputItem.SODError, 
            };
            return dto;
        }

        public static List<SMSOperateDetDto> Map(ICollection<SMSOperateDet> entities)
        {
            var dtos = new List<SMSOperateDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SMSOperateDetDto()
                {
                      
  
		SMSOperateDetId = inputItem.SMSOperateDetId,  
  
		SMSOperateDate = inputItem.SMSOperateDate,  
  
		SMSOperateRef = inputItem.SMSOperateRef,  
  
		SODNumber = inputItem.SODNumber,  
  
		SODDeliver = inputItem.SODDeliver,  
  
		SODText = inputItem.SODText,  
  
		SODSendDate = inputItem.SODSendDate,  
  
		SODRcvDate = inputItem.SODRcvDate,  
  
		SODSit = inputItem.SODSit,  
  
		SODRefId = inputItem.SODRefId,  
  
		SODError = inputItem.SODError, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SMSSetting Map(AddSMSSettingCommand inputItem)
        {
            var entity = new SMSSetting() {
                  
  
		SMSSettingID = inputItem.SMSSettingID,  
  
		SMSCompRef = inputItem.SMSCompRef,  
  
		SMSSetUserRef = inputItem.SMSSetUserRef,  
  
		SMSUserName = inputItem.SMSUserName,  
  
		SMSUserPass = inputItem.SMSUserPass,  
  
		SMSLineNo = inputItem.SMSLineNo, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SMSSetting Map(SMSSetting entity ,EditSMSSettingCommand inputItem)
        {
              
  
		entity.SMSSettingID = inputItem.SMSSettingID;  
  
		entity.SMSCompRef = inputItem.SMSCompRef;  
  
		entity.SMSSetUserRef = inputItem.SMSSetUserRef;  
  
		entity.SMSUserName = inputItem.SMSUserName;  
  
		entity.SMSUserPass = inputItem.SMSUserPass;  
  
		entity.SMSLineNo = inputItem.SMSLineNo; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SMSSettingDto Map(SMSSetting inputItem)
        {
            var dto = new SMSSettingDto()
            {
                  
  
		SMSSettingID = inputItem.SMSSettingID,  
  
		SMSCompRef = inputItem.SMSCompRef,  
  
		SMSSetUserRef = inputItem.SMSSetUserRef,  
  
		SMSUserName = inputItem.SMSUserName,  
  
		SMSUserPass = inputItem.SMSUserPass,  
  
		SMSLineNo = inputItem.SMSLineNo, 
            };
            return dto;
        }

        public static List<SMSSettingDto> Map(ICollection<SMSSetting> entities)
        {
            var dtos = new List<SMSSettingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SMSSettingDto()
                {
                      
  
		SMSSettingID = inputItem.SMSSettingID,  
  
		SMSCompRef = inputItem.SMSCompRef,  
  
		SMSSetUserRef = inputItem.SMSSetUserRef,  
  
		SMSUserName = inputItem.SMSUserName,  
  
		SMSUserPass = inputItem.SMSUserPass,  
  
		SMSLineNo = inputItem.SMSLineNo, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
