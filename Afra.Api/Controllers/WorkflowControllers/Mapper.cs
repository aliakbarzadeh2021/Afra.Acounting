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
                
        
        public static WorkFlows Map(AddWorkFlowsCommand inputItem)
        {
            var entity = new WorkFlows() {
                  
  
		WorkFlowId = inputItem.WorkFlowId,  
  
		WFTitle = inputItem.WFTitle,  
  
		WFType = inputItem.WFType,  
  
		WFState = inputItem.WFState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WorkFlows Map(WorkFlows entity ,EditWorkFlowsCommand inputItem)
        {
              
  
		entity.WorkFlowId = inputItem.WorkFlowId;  
  
		entity.WFTitle = inputItem.WFTitle;  
  
		entity.WFType = inputItem.WFType;  
  
		entity.WFState = inputItem.WFState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkFlowsDto Map(WorkFlows inputItem)
        {
            var dto = new WorkFlowsDto()
            {
                  
  
		WorkFlowId = inputItem.WorkFlowId,  
  
		WFTitle = inputItem.WFTitle,  
  
		WFType = inputItem.WFType,  
  
		WFState = inputItem.WFState, 
            };
            return dto;
        }

        public static List<WorkFlowsDto> Map(ICollection<WorkFlows> entities)
        {
            var dtos = new List<WorkFlowsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkFlowsDto()
                {
                      
  
		WorkFlowId = inputItem.WorkFlowId,  
  
		WFTitle = inputItem.WFTitle,  
  
		WFType = inputItem.WFType,  
  
		WFState = inputItem.WFState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WorkFlowsForm Map(AddWorkFlowsFormCommand inputItem)
        {
            var entity = new WorkFlowsForm() {
                  
  
		WFFFlowRef = inputItem.WFFFlowRef,  
  
		WFFFormRef = inputItem.WFFFormRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WorkFlowsForm Map(WorkFlowsForm entity ,EditWorkFlowsFormCommand inputItem)
        {
              
  
		entity.WFFFlowRef = inputItem.WFFFlowRef;  
  
		entity.WFFFormRef = inputItem.WFFFormRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkFlowsFormDto Map(WorkFlowsForm inputItem)
        {
            var dto = new WorkFlowsFormDto()
            {
                  
  
		WFFFlowRef = inputItem.WFFFlowRef,  
  
		WFFFormRef = inputItem.WFFFormRef, 
            };
            return dto;
        }

        public static List<WorkFlowsFormDto> Map(ICollection<WorkFlowsForm> entities)
        {
            var dtos = new List<WorkFlowsFormDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkFlowsFormDto()
                {
                      
  
		WFFFlowRef = inputItem.WFFFlowRef,  
  
		WFFFormRef = inputItem.WFFFormRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WorkFlowSteps Map(AddWorkFlowStepsCommand inputItem)
        {
            var entity = new WorkFlowSteps() {
                  
  
		WorkFlowStepId = inputItem.WorkFlowStepId,  
  
		WorkFlowRef = inputItem.WorkFlowRef,  
  
		WFSInd = inputItem.WFSInd,  
  
		WFSTitle = inputItem.WFSTitle,  
  
		WFSUserRef = inputItem.WFSUserRef,  
  
		WFWithoutSign = inputItem.WFWithoutSign,  
  
		WFStepRef = inputItem.WFStepRef,  
  
		WFIsReturn = inputItem.WFIsReturn,  
  
		WFParentStep = inputItem.WFParentStep,  
  
		WFOprType = inputItem.WFOprType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WorkFlowSteps Map(WorkFlowSteps entity ,EditWorkFlowStepsCommand inputItem)
        {
              
  
		entity.WorkFlowStepId = inputItem.WorkFlowStepId;  
  
		entity.WorkFlowRef = inputItem.WorkFlowRef;  
  
		entity.WFSInd = inputItem.WFSInd;  
  
		entity.WFSTitle = inputItem.WFSTitle;  
  
		entity.WFSUserRef = inputItem.WFSUserRef;  
  
		entity.WFWithoutSign = inputItem.WFWithoutSign;  
  
		entity.WFStepRef = inputItem.WFStepRef;  
  
		entity.WFIsReturn = inputItem.WFIsReturn;  
  
		entity.WFParentStep = inputItem.WFParentStep;  
  
		entity.WFOprType = inputItem.WFOprType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkFlowStepsDto Map(WorkFlowSteps inputItem)
        {
            var dto = new WorkFlowStepsDto()
            {
                  
  
		WorkFlowStepId = inputItem.WorkFlowStepId,  
  
		WorkFlowRef = inputItem.WorkFlowRef,  
  
		WFSInd = inputItem.WFSInd,  
  
		WFSTitle = inputItem.WFSTitle,  
  
		WFSUserRef = inputItem.WFSUserRef,  
  
		WFWithoutSign = inputItem.WFWithoutSign,  
  
		WFStepRef = inputItem.WFStepRef,  
  
		WFIsReturn = inputItem.WFIsReturn,  
  
		WFParentStep = inputItem.WFParentStep,  
  
		WFOprType = inputItem.WFOprType, 
            };
            return dto;
        }

        public static List<WorkFlowStepsDto> Map(ICollection<WorkFlowSteps> entities)
        {
            var dtos = new List<WorkFlowStepsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkFlowStepsDto()
                {
                      
  
		WorkFlowStepId = inputItem.WorkFlowStepId,  
  
		WorkFlowRef = inputItem.WorkFlowRef,  
  
		WFSInd = inputItem.WFSInd,  
  
		WFSTitle = inputItem.WFSTitle,  
  
		WFSUserRef = inputItem.WFSUserRef,  
  
		WFWithoutSign = inputItem.WFWithoutSign,  
  
		WFStepRef = inputItem.WFStepRef,  
  
		WFIsReturn = inputItem.WFIsReturn,  
  
		WFParentStep = inputItem.WFParentStep,  
  
		WFOprType = inputItem.WFOprType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WorkStation Map(AddWorkStationCommand inputItem)
        {
            var entity = new WorkStation() {
                  
  
		WorkStationId = inputItem.WorkStationId,  
  
		WCostCenterRef = inputItem.WCostCenterRef,  
  
		WTitle = inputItem.WTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WorkStation Map(WorkStation entity ,EditWorkStationCommand inputItem)
        {
              
  
		entity.WorkStationId = inputItem.WorkStationId;  
  
		entity.WCostCenterRef = inputItem.WCostCenterRef;  
  
		entity.WTitle = inputItem.WTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkStationDto Map(WorkStation inputItem)
        {
            var dto = new WorkStationDto()
            {
                  
  
		WorkStationId = inputItem.WorkStationId,  
  
		WCostCenterRef = inputItem.WCostCenterRef,  
  
		WTitle = inputItem.WTitle, 
            };
            return dto;
        }

        public static List<WorkStationDto> Map(ICollection<WorkStation> entities)
        {
            var dtos = new List<WorkStationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkStationDto()
                {
                      
  
		WorkStationId = inputItem.WorkStationId,  
  
		WCostCenterRef = inputItem.WCostCenterRef,  
  
		WTitle = inputItem.WTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
