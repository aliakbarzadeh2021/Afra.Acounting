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
                
        
        public static OtoAttach Map(AddOtoAttachCommand inputItem)
        {
            var entity = new OtoAttach() {
                  
  
		OtoAttachId = inputItem.OtoAttachId,  
  
		OARefType = inputItem.OARefType,  
  
		OARefId = inputItem.OARefId,  
  
		OAType = inputItem.OAType,  
  
		OABaseId = inputItem.OABaseId,  
  
		OADescr = inputItem.OADescr,  
  
		OAFileContent = inputItem.OAFileContent,  
  
		OAFileExt = inputItem.OAFileExt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoAttach Map(OtoAttach entity ,EditOtoAttachCommand inputItem)
        {
              
  
		entity.OtoAttachId = inputItem.OtoAttachId;  
  
		entity.OARefType = inputItem.OARefType;  
  
		entity.OARefId = inputItem.OARefId;  
  
		entity.OAType = inputItem.OAType;  
  
		entity.OABaseId = inputItem.OABaseId;  
  
		entity.OADescr = inputItem.OADescr;  
  
		entity.OAFileContent = inputItem.OAFileContent;  
  
		entity.OAFileExt = inputItem.OAFileExt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoAttachDto Map(OtoAttach inputItem)
        {
            var dto = new OtoAttachDto()
            {
                  
  
		OtoAttachId = inputItem.OtoAttachId,  
  
		OARefType = inputItem.OARefType,  
  
		OARefId = inputItem.OARefId,  
  
		OAType = inputItem.OAType,  
  
		OABaseId = inputItem.OABaseId,  
  
		OADescr = inputItem.OADescr,  
  
		OAFileContent = inputItem.OAFileContent,  
  
		OAFileExt = inputItem.OAFileExt, 
            };
            return dto;
        }

        public static List<OtoAttachDto> Map(ICollection<OtoAttach> entities)
        {
            var dtos = new List<OtoAttachDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoAttachDto()
                {
                      
  
		OtoAttachId = inputItem.OtoAttachId,  
  
		OARefType = inputItem.OARefType,  
  
		OARefId = inputItem.OARefId,  
  
		OAType = inputItem.OAType,  
  
		OABaseId = inputItem.OABaseId,  
  
		OADescr = inputItem.OADescr,  
  
		OAFileContent = inputItem.OAFileContent,  
  
		OAFileExt = inputItem.OAFileExt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoBaseTypes Map(AddOtoBaseTypesCommand inputItem)
        {
            var entity = new OtoBaseTypes() {
                  
  
		OtoBaseTypeId = inputItem.OtoBaseTypeId,  
  
		OBTTitle = inputItem.OBTTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoBaseTypes Map(OtoBaseTypes entity ,EditOtoBaseTypesCommand inputItem)
        {
              
  
		entity.OtoBaseTypeId = inputItem.OtoBaseTypeId;  
  
		entity.OBTTitle = inputItem.OBTTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoBaseTypesDto Map(OtoBaseTypes inputItem)
        {
            var dto = new OtoBaseTypesDto()
            {
                  
  
		OtoBaseTypeId = inputItem.OtoBaseTypeId,  
  
		OBTTitle = inputItem.OBTTitle, 
            };
            return dto;
        }

        public static List<OtoBaseTypesDto> Map(ICollection<OtoBaseTypes> entities)
        {
            var dtos = new List<OtoBaseTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoBaseTypesDto()
                {
                      
  
		OtoBaseTypeId = inputItem.OtoBaseTypeId,  
  
		OBTTitle = inputItem.OBTTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoBaseTypeVals Map(AddOtoBaseTypeValsCommand inputItem)
        {
            var entity = new OtoBaseTypeVals() {
                  
  
		OtoBaseTypeValsId = inputItem.OtoBaseTypeValsId,  
  
		OtoBaseTypeRef = inputItem.OtoBaseTypeRef,  
  
		OBTValue = inputItem.OBTValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoBaseTypeVals Map(OtoBaseTypeVals entity ,EditOtoBaseTypeValsCommand inputItem)
        {
              
  
		entity.OtoBaseTypeValsId = inputItem.OtoBaseTypeValsId;  
  
		entity.OtoBaseTypeRef = inputItem.OtoBaseTypeRef;  
  
		entity.OBTValue = inputItem.OBTValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoBaseTypeValsDto Map(OtoBaseTypeVals inputItem)
        {
            var dto = new OtoBaseTypeValsDto()
            {
                  
  
		OtoBaseTypeValsId = inputItem.OtoBaseTypeValsId,  
  
		OtoBaseTypeRef = inputItem.OtoBaseTypeRef,  
  
		OBTValue = inputItem.OBTValue, 
            };
            return dto;
        }

        public static List<OtoBaseTypeValsDto> Map(ICollection<OtoBaseTypeVals> entities)
        {
            var dtos = new List<OtoBaseTypeValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoBaseTypeValsDto()
                {
                      
  
		OtoBaseTypeValsId = inputItem.OtoBaseTypeValsId,  
  
		OtoBaseTypeRef = inputItem.OtoBaseTypeRef,  
  
		OBTValue = inputItem.OBTValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoCtgry Map(AddOtoCtgryCommand inputItem)
        {
            var entity = new OtoCtgry() {
                  
  
		OtoCtgryId = inputItem.OtoCtgryId,  
  
		OCParent = inputItem.OCParent,  
  
		OCTitle = inputItem.OCTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoCtgry Map(OtoCtgry entity ,EditOtoCtgryCommand inputItem)
        {
              
  
		entity.OtoCtgryId = inputItem.OtoCtgryId;  
  
		entity.OCParent = inputItem.OCParent;  
  
		entity.OCTitle = inputItem.OCTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoCtgryDto Map(OtoCtgry inputItem)
        {
            var dto = new OtoCtgryDto()
            {
                  
  
		OtoCtgryId = inputItem.OtoCtgryId,  
  
		OCParent = inputItem.OCParent,  
  
		OCTitle = inputItem.OCTitle, 
            };
            return dto;
        }

        public static List<OtoCtgryDto> Map(ICollection<OtoCtgry> entities)
        {
            var dtos = new List<OtoCtgryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoCtgryDto()
                {
                      
  
		OtoCtgryId = inputItem.OtoCtgryId,  
  
		OCParent = inputItem.OCParent,  
  
		OCTitle = inputItem.OCTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoFiles Map(AddOtoFilesCommand inputItem)
        {
            var entity = new OtoFiles() {
                  
  
		OtoFilesId = inputItem.OtoFilesId,  
  
		OFParent = inputItem.OFParent,  
  
		OFTitle = inputItem.OFTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoFiles Map(OtoFiles entity ,EditOtoFilesCommand inputItem)
        {
              
  
		entity.OtoFilesId = inputItem.OtoFilesId;  
  
		entity.OFParent = inputItem.OFParent;  
  
		entity.OFTitle = inputItem.OFTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoFilesDto Map(OtoFiles inputItem)
        {
            var dto = new OtoFilesDto()
            {
                  
  
		OtoFilesId = inputItem.OtoFilesId,  
  
		OFParent = inputItem.OFParent,  
  
		OFTitle = inputItem.OFTitle, 
            };
            return dto;
        }

        public static List<OtoFilesDto> Map(ICollection<OtoFiles> entities)
        {
            var dtos = new List<OtoFilesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoFilesDto()
                {
                      
  
		OtoFilesId = inputItem.OtoFilesId,  
  
		OFParent = inputItem.OFParent,  
  
		OFTitle = inputItem.OFTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoFlow Map(AddOtoFlowCommand inputItem)
        {
            var entity = new OtoFlow() {
                  
  
		OtoFlowId = inputItem.OtoFlowId,  
  
		OFRefType = inputItem.OFRefType,  
  
		OFRefId = inputItem.OFRefId,  
  
		OFFormRef = inputItem.OFFormRef,  
  
		OFSndDate = inputItem.OFSndDate,  
  
		OFRcvDate = inputItem.OFRcvDate,  
  
		OFEndDate = inputItem.OFEndDate,  
  
		OFFromUser = inputItem.OFFromUser,  
  
		OFToUser = inputItem.OFToUser,  
  
		OFSendDescr = inputItem.OFSendDescr,  
  
		OFRcvDescr = inputItem.OFRcvDescr,  
  
		OFEnded = inputItem.OFEnded,  
  
		WorkFlowStepRef = inputItem.WorkFlowStepRef,  
  
		OFKind = inputItem.OFKind,  
  
		OFUrgency = inputItem.OFUrgency,  
  
		OFFollowDate = inputItem.OFFollowDate,  
  
		OFFollowDur = inputItem.OFFollowDur,  
  
		OFIsLast = inputItem.OFIsLast,  
  
		OFFileRef = inputItem.OFFileRef,  
  
		OFWithAlarm = inputItem.OFWithAlarm, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoFlow Map(OtoFlow entity ,EditOtoFlowCommand inputItem)
        {
              
  
		entity.OtoFlowId = inputItem.OtoFlowId;  
  
		entity.OFRefType = inputItem.OFRefType;  
  
		entity.OFRefId = inputItem.OFRefId;  
  
		entity.OFFormRef = inputItem.OFFormRef;  
  
		entity.OFSndDate = inputItem.OFSndDate;  
  
		entity.OFRcvDate = inputItem.OFRcvDate;  
  
		entity.OFEndDate = inputItem.OFEndDate;  
  
		entity.OFFromUser = inputItem.OFFromUser;  
  
		entity.OFToUser = inputItem.OFToUser;  
  
		entity.OFSendDescr = inputItem.OFSendDescr;  
  
		entity.OFRcvDescr = inputItem.OFRcvDescr;  
  
		entity.OFEnded = inputItem.OFEnded;  
  
		entity.WorkFlowStepRef = inputItem.WorkFlowStepRef;  
  
		entity.OFKind = inputItem.OFKind;  
  
		entity.OFUrgency = inputItem.OFUrgency;  
  
		entity.OFFollowDate = inputItem.OFFollowDate;  
  
		entity.OFFollowDur = inputItem.OFFollowDur;  
  
		entity.OFIsLast = inputItem.OFIsLast;  
  
		entity.OFFileRef = inputItem.OFFileRef;  
  
		entity.OFWithAlarm = inputItem.OFWithAlarm; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoFlowDto Map(OtoFlow inputItem)
        {
            var dto = new OtoFlowDto()
            {
                  
  
		OtoFlowId = inputItem.OtoFlowId,  
  
		OFRefType = inputItem.OFRefType,  
  
		OFRefId = inputItem.OFRefId,  
  
		OFFormRef = inputItem.OFFormRef,  
  
		OFSndDate = inputItem.OFSndDate,  
  
		OFRcvDate = inputItem.OFRcvDate,  
  
		OFEndDate = inputItem.OFEndDate,  
  
		OFFromUser = inputItem.OFFromUser,  
  
		OFToUser = inputItem.OFToUser,  
  
		OFSendDescr = inputItem.OFSendDescr,  
  
		OFRcvDescr = inputItem.OFRcvDescr,  
  
		OFEnded = inputItem.OFEnded,  
  
		WorkFlowStepRef = inputItem.WorkFlowStepRef,  
  
		OFKind = inputItem.OFKind,  
  
		OFUrgency = inputItem.OFUrgency,  
  
		OFFollowDate = inputItem.OFFollowDate,  
  
		OFFollowDur = inputItem.OFFollowDur,  
  
		OFIsLast = inputItem.OFIsLast,  
  
		OFFileRef = inputItem.OFFileRef,  
  
		OFWithAlarm = inputItem.OFWithAlarm, 
            };
            return dto;
        }

        public static List<OtoFlowDto> Map(ICollection<OtoFlow> entities)
        {
            var dtos = new List<OtoFlowDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoFlowDto()
                {
                      
  
		OtoFlowId = inputItem.OtoFlowId,  
  
		OFRefType = inputItem.OFRefType,  
  
		OFRefId = inputItem.OFRefId,  
  
		OFFormRef = inputItem.OFFormRef,  
  
		OFSndDate = inputItem.OFSndDate,  
  
		OFRcvDate = inputItem.OFRcvDate,  
  
		OFEndDate = inputItem.OFEndDate,  
  
		OFFromUser = inputItem.OFFromUser,  
  
		OFToUser = inputItem.OFToUser,  
  
		OFSendDescr = inputItem.OFSendDescr,  
  
		OFRcvDescr = inputItem.OFRcvDescr,  
  
		OFEnded = inputItem.OFEnded,  
  
		WorkFlowStepRef = inputItem.WorkFlowStepRef,  
  
		OFKind = inputItem.OFKind,  
  
		OFUrgency = inputItem.OFUrgency,  
  
		OFFollowDate = inputItem.OFFollowDate,  
  
		OFFollowDur = inputItem.OFFollowDur,  
  
		OFIsLast = inputItem.OFIsLast,  
  
		OFFileRef = inputItem.OFFileRef,  
  
		OFWithAlarm = inputItem.OFWithAlarm, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoFlowCrs Map(AddOtoFlowCrsCommand inputItem)
        {
            var entity = new OtoFlowCrs() {
                  
  
		OtoFlowRef = inputItem.OtoFlowRef,  
  
		OFCUserRef = inputItem.OFCUserRef,  
  
		OFCRcvDate = inputItem.OFCRcvDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoFlowCrs Map(OtoFlowCrs entity ,EditOtoFlowCrsCommand inputItem)
        {
              
  
		entity.OtoFlowRef = inputItem.OtoFlowRef;  
  
		entity.OFCUserRef = inputItem.OFCUserRef;  
  
		entity.OFCRcvDate = inputItem.OFCRcvDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoFlowCrsDto Map(OtoFlowCrs inputItem)
        {
            var dto = new OtoFlowCrsDto()
            {
                  
  
		OtoFlowRef = inputItem.OtoFlowRef,  
  
		OFCUserRef = inputItem.OFCUserRef,  
  
		OFCRcvDate = inputItem.OFCRcvDate, 
            };
            return dto;
        }

        public static List<OtoFlowCrsDto> Map(ICollection<OtoFlowCrs> entities)
        {
            var dtos = new List<OtoFlowCrsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoFlowCrsDto()
                {
                      
  
		OtoFlowRef = inputItem.OtoFlowRef,  
  
		OFCUserRef = inputItem.OFCUserRef,  
  
		OFCRcvDate = inputItem.OFCRcvDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoFlowRight Map(AddOtoFlowRightCommand inputItem)
        {
            var entity = new OtoFlowRight() {
                  
  
		OtoFlowRightId = inputItem.OtoFlowRightId,  
  
		OFRUserRef = inputItem.OFRUserRef,  
  
		OFRToUser = inputItem.OFRToUser,  
  
		OFRRight = inputItem.OFRRight, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoFlowRight Map(OtoFlowRight entity ,EditOtoFlowRightCommand inputItem)
        {
              
  
		entity.OtoFlowRightId = inputItem.OtoFlowRightId;  
  
		entity.OFRUserRef = inputItem.OFRUserRef;  
  
		entity.OFRToUser = inputItem.OFRToUser;  
  
		entity.OFRRight = inputItem.OFRRight; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoFlowRightDto Map(OtoFlowRight inputItem)
        {
            var dto = new OtoFlowRightDto()
            {
                  
  
		OtoFlowRightId = inputItem.OtoFlowRightId,  
  
		OFRUserRef = inputItem.OFRUserRef,  
  
		OFRToUser = inputItem.OFRToUser,  
  
		OFRRight = inputItem.OFRRight, 
            };
            return dto;
        }

        public static List<OtoFlowRightDto> Map(ICollection<OtoFlowRight> entities)
        {
            var dtos = new List<OtoFlowRightDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoFlowRightDto()
                {
                      
  
		OtoFlowRightId = inputItem.OtoFlowRightId,  
  
		OFRUserRef = inputItem.OFRUserRef,  
  
		OFRToUser = inputItem.OFRToUser,  
  
		OFRRight = inputItem.OFRRight, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoIndicator Map(AddOtoIndicatorCommand inputItem)
        {
            var entity = new OtoIndicator() {
                  
  
		OtoIndicatorId = inputItem.OtoIndicatorId,  
  
		OIDescr = inputItem.OIDescr,  
  
		OIStartNo = inputItem.OIStartNo,  
  
		OISeed = inputItem.OISeed,  
  
		OIPattern = inputItem.OIPattern,  
  
		OIStartDate = inputItem.OIStartDate,  
  
		OIEndDate = inputItem.OIEndDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoIndicator Map(OtoIndicator entity ,EditOtoIndicatorCommand inputItem)
        {
              
  
		entity.OtoIndicatorId = inputItem.OtoIndicatorId;  
  
		entity.OIDescr = inputItem.OIDescr;  
  
		entity.OIStartNo = inputItem.OIStartNo;  
  
		entity.OISeed = inputItem.OISeed;  
  
		entity.OIPattern = inputItem.OIPattern;  
  
		entity.OIStartDate = inputItem.OIStartDate;  
  
		entity.OIEndDate = inputItem.OIEndDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoIndicatorDto Map(OtoIndicator inputItem)
        {
            var dto = new OtoIndicatorDto()
            {
                  
  
		OtoIndicatorId = inputItem.OtoIndicatorId,  
  
		OIDescr = inputItem.OIDescr,  
  
		OIStartNo = inputItem.OIStartNo,  
  
		OISeed = inputItem.OISeed,  
  
		OIPattern = inputItem.OIPattern,  
  
		OIStartDate = inputItem.OIStartDate,  
  
		OIEndDate = inputItem.OIEndDate, 
            };
            return dto;
        }

        public static List<OtoIndicatorDto> Map(ICollection<OtoIndicator> entities)
        {
            var dtos = new List<OtoIndicatorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoIndicatorDto()
                {
                      
  
		OtoIndicatorId = inputItem.OtoIndicatorId,  
  
		OIDescr = inputItem.OIDescr,  
  
		OIStartNo = inputItem.OIStartNo,  
  
		OISeed = inputItem.OISeed,  
  
		OIPattern = inputItem.OIPattern,  
  
		OIStartDate = inputItem.OIStartDate,  
  
		OIEndDate = inputItem.OIEndDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoLetters Map(AddOtoLettersCommand inputItem)
        {
            var entity = new OtoLetters() {
                  
  
		OtoLettersId = inputItem.OtoLettersId,  
  
		OLType = inputItem.OLType,  
  
		OLCompRef = inputItem.OLCompRef,  
  
		OLCrsRef = inputItem.OLCrsRef,  
  
		OLOthCrsName = inputItem.OLOthCrsName,  
  
		OLIndRef = inputItem.OLIndRef,  
  
		OLIndNo = inputItem.OLIndNo,  
  
		OLSubject = inputItem.OLSubject,  
  
		OLDescr = inputItem.OLDescr,  
  
		OLCreateDate = inputItem.OLCreateDate,  
  
		OLNumber = inputItem.OLNumber,  
  
		OLDate = inputItem.OLDate,  
  
		OLRcptNo = inputItem.OLRcptNo,  
  
		OLRcptDate = inputItem.OLRcptDate,  
  
		OLUserRef = inputItem.OLUserRef,  
  
		OLFileRef = inputItem.OLFileRef,  
  
		OLCtgry = inputItem.OLCtgry,  
  
		OLState = inputItem.OLState,  
  
		OLSignInf = inputItem.OLSignInf,  
  
		OLConfirmer = inputItem.OLConfirmer,  
  
		OLApprover = inputItem.OLApprover, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoLetters Map(OtoLetters entity ,EditOtoLettersCommand inputItem)
        {
              
  
		entity.OtoLettersId = inputItem.OtoLettersId;  
  
		entity.OLType = inputItem.OLType;  
  
		entity.OLCompRef = inputItem.OLCompRef;  
  
		entity.OLCrsRef = inputItem.OLCrsRef;  
  
		entity.OLOthCrsName = inputItem.OLOthCrsName;  
  
		entity.OLIndRef = inputItem.OLIndRef;  
  
		entity.OLIndNo = inputItem.OLIndNo;  
  
		entity.OLSubject = inputItem.OLSubject;  
  
		entity.OLDescr = inputItem.OLDescr;  
  
		entity.OLCreateDate = inputItem.OLCreateDate;  
  
		entity.OLNumber = inputItem.OLNumber;  
  
		entity.OLDate = inputItem.OLDate;  
  
		entity.OLRcptNo = inputItem.OLRcptNo;  
  
		entity.OLRcptDate = inputItem.OLRcptDate;  
  
		entity.OLUserRef = inputItem.OLUserRef;  
  
		entity.OLFileRef = inputItem.OLFileRef;  
  
		entity.OLCtgry = inputItem.OLCtgry;  
  
		entity.OLState = inputItem.OLState;  
  
		entity.OLSignInf = inputItem.OLSignInf;  
  
		entity.OLConfirmer = inputItem.OLConfirmer;  
  
		entity.OLApprover = inputItem.OLApprover; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoLettersDto Map(OtoLetters inputItem)
        {
            var dto = new OtoLettersDto()
            {
                  
  
		OtoLettersId = inputItem.OtoLettersId,  
  
		OLType = inputItem.OLType,  
  
		OLCompRef = inputItem.OLCompRef,  
  
		OLCrsRef = inputItem.OLCrsRef,  
  
		OLOthCrsName = inputItem.OLOthCrsName,  
  
		OLIndRef = inputItem.OLIndRef,  
  
		OLIndNo = inputItem.OLIndNo,  
  
		OLSubject = inputItem.OLSubject,  
  
		OLDescr = inputItem.OLDescr,  
  
		OLCreateDate = inputItem.OLCreateDate,  
  
		OLNumber = inputItem.OLNumber,  
  
		OLDate = inputItem.OLDate,  
  
		OLRcptNo = inputItem.OLRcptNo,  
  
		OLRcptDate = inputItem.OLRcptDate,  
  
		OLUserRef = inputItem.OLUserRef,  
  
		OLFileRef = inputItem.OLFileRef,  
  
		OLCtgry = inputItem.OLCtgry,  
  
		OLState = inputItem.OLState,  
  
		OLSignInf = inputItem.OLSignInf,  
  
		OLConfirmer = inputItem.OLConfirmer,  
  
		OLApprover = inputItem.OLApprover, 
            };
            return dto;
        }

        public static List<OtoLettersDto> Map(ICollection<OtoLetters> entities)
        {
            var dtos = new List<OtoLettersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoLettersDto()
                {
                      
  
		OtoLettersId = inputItem.OtoLettersId,  
  
		OLType = inputItem.OLType,  
  
		OLCompRef = inputItem.OLCompRef,  
  
		OLCrsRef = inputItem.OLCrsRef,  
  
		OLOthCrsName = inputItem.OLOthCrsName,  
  
		OLIndRef = inputItem.OLIndRef,  
  
		OLIndNo = inputItem.OLIndNo,  
  
		OLSubject = inputItem.OLSubject,  
  
		OLDescr = inputItem.OLDescr,  
  
		OLCreateDate = inputItem.OLCreateDate,  
  
		OLNumber = inputItem.OLNumber,  
  
		OLDate = inputItem.OLDate,  
  
		OLRcptNo = inputItem.OLRcptNo,  
  
		OLRcptDate = inputItem.OLRcptDate,  
  
		OLUserRef = inputItem.OLUserRef,  
  
		OLFileRef = inputItem.OLFileRef,  
  
		OLCtgry = inputItem.OLCtgry,  
  
		OLState = inputItem.OLState,  
  
		OLSignInf = inputItem.OLSignInf,  
  
		OLConfirmer = inputItem.OLConfirmer,  
  
		OLApprover = inputItem.OLApprover, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoLttrDoc Map(AddOtoLttrDocCommand inputItem)
        {
            var entity = new OtoLttrDoc() {
                  
  
		OtoLttrDocId = inputItem.OtoLttrDocId,  
  
		OLDLttrRef = inputItem.OLDLttrRef,  
  
		OLDDocType = inputItem.OLDDocType,  
  
		OLDContent = inputItem.OLDContent,  
  
		OLDExt = inputItem.OLDExt,  
  
		OLDTemplate = inputItem.OLDTemplate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoLttrDoc Map(OtoLttrDoc entity ,EditOtoLttrDocCommand inputItem)
        {
              
  
		entity.OtoLttrDocId = inputItem.OtoLttrDocId;  
  
		entity.OLDLttrRef = inputItem.OLDLttrRef;  
  
		entity.OLDDocType = inputItem.OLDDocType;  
  
		entity.OLDContent = inputItem.OLDContent;  
  
		entity.OLDExt = inputItem.OLDExt;  
  
		entity.OLDTemplate = inputItem.OLDTemplate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoLttrDocDto Map(OtoLttrDoc inputItem)
        {
            var dto = new OtoLttrDocDto()
            {
                  
  
		OtoLttrDocId = inputItem.OtoLttrDocId,  
  
		OLDLttrRef = inputItem.OLDLttrRef,  
  
		OLDDocType = inputItem.OLDDocType,  
  
		OLDContent = inputItem.OLDContent,  
  
		OLDExt = inputItem.OLDExt,  
  
		OLDTemplate = inputItem.OLDTemplate, 
            };
            return dto;
        }

        public static List<OtoLttrDocDto> Map(ICollection<OtoLttrDoc> entities)
        {
            var dtos = new List<OtoLttrDocDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoLttrDocDto()
                {
                      
  
		OtoLttrDocId = inputItem.OtoLttrDocId,  
  
		OLDLttrRef = inputItem.OLDLttrRef,  
  
		OLDDocType = inputItem.OLDDocType,  
  
		OLDContent = inputItem.OLDContent,  
  
		OLDExt = inputItem.OLDExt,  
  
		OLDTemplate = inputItem.OLDTemplate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoLttrLabels Map(AddOtoLttrLabelsCommand inputItem)
        {
            var entity = new OtoLttrLabels() {
                  
  
		OLLRefType = inputItem.OLLRefType,  
  
		OLLRefId = inputItem.OLLRefId,  
  
		OLLabelRef = inputItem.OLLabelRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoLttrLabels Map(OtoLttrLabels entity ,EditOtoLttrLabelsCommand inputItem)
        {
              
  
		entity.OLLRefType = inputItem.OLLRefType;  
  
		entity.OLLRefId = inputItem.OLLRefId;  
  
		entity.OLLabelRef = inputItem.OLLabelRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoLttrLabelsDto Map(OtoLttrLabels inputItem)
        {
            var dto = new OtoLttrLabelsDto()
            {
                  
  
		OLLRefType = inputItem.OLLRefType,  
  
		OLLRefId = inputItem.OLLRefId,  
  
		OLLabelRef = inputItem.OLLabelRef, 
            };
            return dto;
        }

        public static List<OtoLttrLabelsDto> Map(ICollection<OtoLttrLabels> entities)
        {
            var dtos = new List<OtoLttrLabelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoLttrLabelsDto()
                {
                      
  
		OLLRefType = inputItem.OLLRefType,  
  
		OLLRefId = inputItem.OLLRefId,  
  
		OLLabelRef = inputItem.OLLabelRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoLttrLinks Map(AddOtoLttrLinksCommand inputItem)
        {
            var entity = new OtoLttrLinks() {
                  
  
		OtoLttrLinksId = inputItem.OtoLttrLinksId,  
  
		OLLBaseLttr = inputItem.OLLBaseLttr,  
  
		OLLRelLttr = inputItem.OLLRelLttr,  
  
		OLLType = inputItem.OLLType,  
  
		OLLDescr = inputItem.OLLDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoLttrLinks Map(OtoLttrLinks entity ,EditOtoLttrLinksCommand inputItem)
        {
              
  
		entity.OtoLttrLinksId = inputItem.OtoLttrLinksId;  
  
		entity.OLLBaseLttr = inputItem.OLLBaseLttr;  
  
		entity.OLLRelLttr = inputItem.OLLRelLttr;  
  
		entity.OLLType = inputItem.OLLType;  
  
		entity.OLLDescr = inputItem.OLLDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoLttrLinksDto Map(OtoLttrLinks inputItem)
        {
            var dto = new OtoLttrLinksDto()
            {
                  
  
		OtoLttrLinksId = inputItem.OtoLttrLinksId,  
  
		OLLBaseLttr = inputItem.OLLBaseLttr,  
  
		OLLRelLttr = inputItem.OLLRelLttr,  
  
		OLLType = inputItem.OLLType,  
  
		OLLDescr = inputItem.OLLDescr, 
            };
            return dto;
        }

        public static List<OtoLttrLinksDto> Map(ICollection<OtoLttrLinks> entities)
        {
            var dtos = new List<OtoLttrLinksDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoLttrLinksDto()
                {
                      
  
		OtoLttrLinksId = inputItem.OtoLttrLinksId,  
  
		OLLBaseLttr = inputItem.OLLBaseLttr,  
  
		OLLRelLttr = inputItem.OLLRelLttr,  
  
		OLLType = inputItem.OLLType,  
  
		OLLDescr = inputItem.OLLDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoLttrProps Map(AddOtoLttrPropsCommand inputItem)
        {
            var entity = new OtoLttrProps() {
                  
  
		OLPLttrRef = inputItem.OLPLttrRef,  
  
		OLPPropVal = inputItem.OLPPropVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoLttrProps Map(OtoLttrProps entity ,EditOtoLttrPropsCommand inputItem)
        {
              
  
		entity.OLPLttrRef = inputItem.OLPLttrRef;  
  
		entity.OLPPropVal = inputItem.OLPPropVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoLttrPropsDto Map(OtoLttrProps inputItem)
        {
            var dto = new OtoLttrPropsDto()
            {
                  
  
		OLPLttrRef = inputItem.OLPLttrRef,  
  
		OLPPropVal = inputItem.OLPPropVal, 
            };
            return dto;
        }

        public static List<OtoLttrPropsDto> Map(ICollection<OtoLttrProps> entities)
        {
            var dtos = new List<OtoLttrPropsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoLttrPropsDto()
                {
                      
  
		OLPLttrRef = inputItem.OLPLttrRef,  
  
		OLPPropVal = inputItem.OLPPropVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoQuickNote Map(AddOtoQuickNoteCommand inputItem)
        {
            var entity = new OtoQuickNote() {
                  
  
		OtoQuickNoteId = inputItem.OtoQuickNoteId,  
  
		OQNTitle = inputItem.OQNTitle,  
  
		OQNText = inputItem.OQNText, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoQuickNote Map(OtoQuickNote entity ,EditOtoQuickNoteCommand inputItem)
        {
              
  
		entity.OtoQuickNoteId = inputItem.OtoQuickNoteId;  
  
		entity.OQNTitle = inputItem.OQNTitle;  
  
		entity.OQNText = inputItem.OQNText; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoQuickNoteDto Map(OtoQuickNote inputItem)
        {
            var dto = new OtoQuickNoteDto()
            {
                  
  
		OtoQuickNoteId = inputItem.OtoQuickNoteId,  
  
		OQNTitle = inputItem.OQNTitle,  
  
		OQNText = inputItem.OQNText, 
            };
            return dto;
        }

        public static List<OtoQuickNoteDto> Map(ICollection<OtoQuickNote> entities)
        {
            var dtos = new List<OtoQuickNoteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoQuickNoteDto()
                {
                      
  
		OtoQuickNoteId = inputItem.OtoQuickNoteId,  
  
		OQNTitle = inputItem.OQNTitle,  
  
		OQNText = inputItem.OQNText, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoSysLttr Map(AddOtoSysLttrCommand inputItem)
        {
            var entity = new OtoSysLttr() {
                  
  
		OtoSysLtrId = inputItem.OtoSysLtrId,  
  
		OSLUserRef = inputItem.OSLUserRef,  
  
		OSLCreateDate = inputItem.OSLCreateDate,  
  
		OSLType = inputItem.OSLType,  
  
		OSLRefId = inputItem.OSLRefId,  
  
		OSLFileObj = inputItem.OSLFileObj,  
  
		OSLSignInf = inputItem.OSLSignInf,  
  
		OSLOthInf = inputItem.OSLOthInf, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoSysLttr Map(OtoSysLttr entity ,EditOtoSysLttrCommand inputItem)
        {
              
  
		entity.OtoSysLtrId = inputItem.OtoSysLtrId;  
  
		entity.OSLUserRef = inputItem.OSLUserRef;  
  
		entity.OSLCreateDate = inputItem.OSLCreateDate;  
  
		entity.OSLType = inputItem.OSLType;  
  
		entity.OSLRefId = inputItem.OSLRefId;  
  
		entity.OSLFileObj = inputItem.OSLFileObj;  
  
		entity.OSLSignInf = inputItem.OSLSignInf;  
  
		entity.OSLOthInf = inputItem.OSLOthInf; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoSysLttrDto Map(OtoSysLttr inputItem)
        {
            var dto = new OtoSysLttrDto()
            {
                  
  
		OtoSysLtrId = inputItem.OtoSysLtrId,  
  
		OSLUserRef = inputItem.OSLUserRef,  
  
		OSLCreateDate = inputItem.OSLCreateDate,  
  
		OSLType = inputItem.OSLType,  
  
		OSLRefId = inputItem.OSLRefId,  
  
		OSLFileObj = inputItem.OSLFileObj,  
  
		OSLSignInf = inputItem.OSLSignInf,  
  
		OSLOthInf = inputItem.OSLOthInf, 
            };
            return dto;
        }

        public static List<OtoSysLttrDto> Map(ICollection<OtoSysLttr> entities)
        {
            var dtos = new List<OtoSysLttrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoSysLttrDto()
                {
                      
  
		OtoSysLtrId = inputItem.OtoSysLtrId,  
  
		OSLUserRef = inputItem.OSLUserRef,  
  
		OSLCreateDate = inputItem.OSLCreateDate,  
  
		OSLType = inputItem.OSLType,  
  
		OSLRefId = inputItem.OSLRefId,  
  
		OSLFileObj = inputItem.OSLFileObj,  
  
		OSLSignInf = inputItem.OSLSignInf,  
  
		OSLOthInf = inputItem.OSLOthInf, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoTemplates Map(AddOtoTemplatesCommand inputItem)
        {
            var entity = new OtoTemplates() {
                  
  
		OtoTemplateId = inputItem.OtoTemplateId,  
  
		OTTitle = inputItem.OTTitle,  
  
		OTDocType = inputItem.OTDocType,  
  
		OTContent = inputItem.OTContent, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoTemplates Map(OtoTemplates entity ,EditOtoTemplatesCommand inputItem)
        {
              
  
		entity.OtoTemplateId = inputItem.OtoTemplateId;  
  
		entity.OTTitle = inputItem.OTTitle;  
  
		entity.OTDocType = inputItem.OTDocType;  
  
		entity.OTContent = inputItem.OTContent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoTemplatesDto Map(OtoTemplates inputItem)
        {
            var dto = new OtoTemplatesDto()
            {
                  
  
		OtoTemplateId = inputItem.OtoTemplateId,  
  
		OTTitle = inputItem.OTTitle,  
  
		OTDocType = inputItem.OTDocType,  
  
		OTContent = inputItem.OTContent, 
            };
            return dto;
        }

        public static List<OtoTemplatesDto> Map(ICollection<OtoTemplates> entities)
        {
            var dtos = new List<OtoTemplatesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoTemplatesDto()
                {
                      
  
		OtoTemplateId = inputItem.OtoTemplateId,  
  
		OTTitle = inputItem.OTTitle,  
  
		OTDocType = inputItem.OTDocType,  
  
		OTContent = inputItem.OTContent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoTransScript Map(AddOtoTransScriptCommand inputItem)
        {
            var entity = new OtoTransScript() {
                  
  
		OtoTransScriptId = inputItem.OtoTransScriptId,  
  
		OTSUserRef = inputItem.OTSUserRef,  
  
		OTSOrder = inputItem.OTSOrder,  
  
		OTSDescr = inputItem.OTSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoTransScript Map(OtoTransScript entity ,EditOtoTransScriptCommand inputItem)
        {
              
  
		entity.OtoTransScriptId = inputItem.OtoTransScriptId;  
  
		entity.OTSUserRef = inputItem.OTSUserRef;  
  
		entity.OTSOrder = inputItem.OTSOrder;  
  
		entity.OTSDescr = inputItem.OTSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoTransScriptDto Map(OtoTransScript inputItem)
        {
            var dto = new OtoTransScriptDto()
            {
                  
  
		OtoTransScriptId = inputItem.OtoTransScriptId,  
  
		OTSUserRef = inputItem.OTSUserRef,  
  
		OTSOrder = inputItem.OTSOrder,  
  
		OTSDescr = inputItem.OTSDescr, 
            };
            return dto;
        }

        public static List<OtoTransScriptDto> Map(ICollection<OtoTransScript> entities)
        {
            var dtos = new List<OtoTransScriptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoTransScriptDto()
                {
                      
  
		OtoTransScriptId = inputItem.OtoTransScriptId,  
  
		OTSUserRef = inputItem.OTSUserRef,  
  
		OTSOrder = inputItem.OTSOrder,  
  
		OTSDescr = inputItem.OTSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OtoUserRight Map(AddOtoUserRightCommand inputItem)
        {
            var entity = new OtoUserRight() {
                  
  
		OtoUserRightId = inputItem.OtoUserRightId,  
  
		OURUserRef = inputItem.OURUserRef,  
  
		OURRelType = inputItem.OURRelType,  
  
		OURRelId = inputItem.OURRelId,  
  
		OURObjType = inputItem.OURObjType,  
  
		OURAccess = inputItem.OURAccess, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OtoUserRight Map(OtoUserRight entity ,EditOtoUserRightCommand inputItem)
        {
              
  
		entity.OtoUserRightId = inputItem.OtoUserRightId;  
  
		entity.OURUserRef = inputItem.OURUserRef;  
  
		entity.OURRelType = inputItem.OURRelType;  
  
		entity.OURRelId = inputItem.OURRelId;  
  
		entity.OURObjType = inputItem.OURObjType;  
  
		entity.OURAccess = inputItem.OURAccess; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OtoUserRightDto Map(OtoUserRight inputItem)
        {
            var dto = new OtoUserRightDto()
            {
                  
  
		OtoUserRightId = inputItem.OtoUserRightId,  
  
		OURUserRef = inputItem.OURUserRef,  
  
		OURRelType = inputItem.OURRelType,  
  
		OURRelId = inputItem.OURRelId,  
  
		OURObjType = inputItem.OURObjType,  
  
		OURAccess = inputItem.OURAccess, 
            };
            return dto;
        }

        public static List<OtoUserRightDto> Map(ICollection<OtoUserRight> entities)
        {
            var dtos = new List<OtoUserRightDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OtoUserRightDto()
                {
                      
  
		OtoUserRightId = inputItem.OtoUserRightId,  
  
		OURUserRef = inputItem.OURUserRef,  
  
		OURRelType = inputItem.OURRelType,  
  
		OURRelId = inputItem.OURRelId,  
  
		OURObjType = inputItem.OURObjType,  
  
		OURAccess = inputItem.OURAccess, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
