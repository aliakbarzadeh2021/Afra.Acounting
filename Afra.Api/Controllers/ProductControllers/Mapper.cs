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
                
        
        public static PrdCalender Map(AddPrdCalenderCommand inputItem)
        {
            var entity = new PrdCalender() {
                  
  
		PrdCalenderId = inputItem.PrdCalenderId,  
  
		PCDate = inputItem.PCDate,  
  
		PCDayType = inputItem.PCDayType,  
  
		PCPrdSTime = inputItem.PCPrdSTime,  
  
		PCPrdETime = inputItem.PCPrdETime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdCalender Map(PrdCalender entity ,EditPrdCalenderCommand inputItem)
        {
              
  
		entity.PrdCalenderId = inputItem.PrdCalenderId;  
  
		entity.PCDate = inputItem.PCDate;  
  
		entity.PCDayType = inputItem.PCDayType;  
  
		entity.PCPrdSTime = inputItem.PCPrdSTime;  
  
		entity.PCPrdETime = inputItem.PCPrdETime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdCalenderDto Map(PrdCalender inputItem)
        {
            var dto = new PrdCalenderDto()
            {
                  
  
		PrdCalenderId = inputItem.PrdCalenderId,  
  
		PCDate = inputItem.PCDate,  
  
		PCDayType = inputItem.PCDayType,  
  
		PCPrdSTime = inputItem.PCPrdSTime,  
  
		PCPrdETime = inputItem.PCPrdETime, 
            };
            return dto;
        }

        public static List<PrdCalenderDto> Map(ICollection<PrdCalender> entities)
        {
            var dtos = new List<PrdCalenderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdCalenderDto()
                {
                      
  
		PrdCalenderId = inputItem.PrdCalenderId,  
  
		PCDate = inputItem.PCDate,  
  
		PCDayType = inputItem.PCDayType,  
  
		PCPrdSTime = inputItem.PCPrdSTime,  
  
		PCPrdETime = inputItem.PCPrdETime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdConsumHdr Map(AddPrdConsumHdrCommand inputItem)
        {
            var entity = new PrdConsumHdr() {
                  
  
		PrdConsumHdrId = inputItem.PrdConsumHdrId,  
  
		PCHNum = inputItem.PCHNum,  
  
		PCHLocalNum = inputItem.PCHLocalNum,  
  
		PCHDate = inputItem.PCHDate,  
  
		PCHDescr = inputItem.PCHDescr,  
  
		PCHProgRef = inputItem.PCHProgRef,  
  
		PCHDLRef = inputItem.PCHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCHState = inputItem.PCHState,  
  
		PCHYear = inputItem.PCHYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdConsumHdr Map(PrdConsumHdr entity ,EditPrdConsumHdrCommand inputItem)
        {
              
  
		entity.PrdConsumHdrId = inputItem.PrdConsumHdrId;  
  
		entity.PCHNum = inputItem.PCHNum;  
  
		entity.PCHLocalNum = inputItem.PCHLocalNum;  
  
		entity.PCHDate = inputItem.PCHDate;  
  
		entity.PCHDescr = inputItem.PCHDescr;  
  
		entity.PCHProgRef = inputItem.PCHProgRef;  
  
		entity.PCHDLRef = inputItem.PCHDLRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PCHState = inputItem.PCHState;  
  
		entity.PCHYear = inputItem.PCHYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdConsumHdrDto Map(PrdConsumHdr inputItem)
        {
            var dto = new PrdConsumHdrDto()
            {
                  
  
		PrdConsumHdrId = inputItem.PrdConsumHdrId,  
  
		PCHNum = inputItem.PCHNum,  
  
		PCHLocalNum = inputItem.PCHLocalNum,  
  
		PCHDate = inputItem.PCHDate,  
  
		PCHDescr = inputItem.PCHDescr,  
  
		PCHProgRef = inputItem.PCHProgRef,  
  
		PCHDLRef = inputItem.PCHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCHState = inputItem.PCHState,  
  
		PCHYear = inputItem.PCHYear, 
            };
            return dto;
        }

        public static List<PrdConsumHdrDto> Map(ICollection<PrdConsumHdr> entities)
        {
            var dtos = new List<PrdConsumHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdConsumHdrDto()
                {
                      
  
		PrdConsumHdrId = inputItem.PrdConsumHdrId,  
  
		PCHNum = inputItem.PCHNum,  
  
		PCHLocalNum = inputItem.PCHLocalNum,  
  
		PCHDate = inputItem.PCHDate,  
  
		PCHDescr = inputItem.PCHDescr,  
  
		PCHProgRef = inputItem.PCHProgRef,  
  
		PCHDLRef = inputItem.PCHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCHState = inputItem.PCHState,  
  
		PCHYear = inputItem.PCHYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdConsumItm Map(AddPrdConsumItmCommand inputItem)
        {
            var entity = new PrdConsumItm() {
                  
  
		PrdConsumItmId = inputItem.PrdConsumItmId,  
  
		PrdConsumHdrRef = inputItem.PrdConsumHdrRef,  
  
		PCISeq = inputItem.PCISeq,  
  
		PCIPartRef = inputItem.PCIPartRef,  
  
		PCIUnitRef = inputItem.PCIUnitRef,  
  
		PCIQty = inputItem.PCIQty,  
  
		PCIDescr = inputItem.PCIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdConsumItm Map(PrdConsumItm entity ,EditPrdConsumItmCommand inputItem)
        {
              
  
		entity.PrdConsumItmId = inputItem.PrdConsumItmId;  
  
		entity.PrdConsumHdrRef = inputItem.PrdConsumHdrRef;  
  
		entity.PCISeq = inputItem.PCISeq;  
  
		entity.PCIPartRef = inputItem.PCIPartRef;  
  
		entity.PCIUnitRef = inputItem.PCIUnitRef;  
  
		entity.PCIQty = inputItem.PCIQty;  
  
		entity.PCIDescr = inputItem.PCIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdConsumItmDto Map(PrdConsumItm inputItem)
        {
            var dto = new PrdConsumItmDto()
            {
                  
  
		PrdConsumItmId = inputItem.PrdConsumItmId,  
  
		PrdConsumHdrRef = inputItem.PrdConsumHdrRef,  
  
		PCISeq = inputItem.PCISeq,  
  
		PCIPartRef = inputItem.PCIPartRef,  
  
		PCIUnitRef = inputItem.PCIUnitRef,  
  
		PCIQty = inputItem.PCIQty,  
  
		PCIDescr = inputItem.PCIDescr, 
            };
            return dto;
        }

        public static List<PrdConsumItmDto> Map(ICollection<PrdConsumItm> entities)
        {
            var dtos = new List<PrdConsumItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdConsumItmDto()
                {
                      
  
		PrdConsumItmId = inputItem.PrdConsumItmId,  
  
		PrdConsumHdrRef = inputItem.PrdConsumHdrRef,  
  
		PCISeq = inputItem.PCISeq,  
  
		PCIPartRef = inputItem.PCIPartRef,  
  
		PCIUnitRef = inputItem.PCIUnitRef,  
  
		PCIQty = inputItem.PCIQty,  
  
		PCIDescr = inputItem.PCIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdFixInf Map(AddPrdFixInfCommand inputItem)
        {
            var entity = new PrdFixInf() {
                  
  
		PrdFixInfID = inputItem.PrdFixInfID,  
  
		PFIProdVchType = inputItem.PFIProdVchType,  
  
		PFIExpnsVchType = inputItem.PFIExpnsVchType,  
  
		PFIMatStkRef = inputItem.PFIMatStkRef,  
  
		PFIPrdStkRef = inputItem.PFIPrdStkRef,  
  
		PFISemiStkRef = inputItem.PFISemiStkRef,  
  
		PFIBaseVchType = inputItem.PFIBaseVchType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdFixInf Map(PrdFixInf entity ,EditPrdFixInfCommand inputItem)
        {
              
  
		entity.PrdFixInfID = inputItem.PrdFixInfID;  
  
		entity.PFIProdVchType = inputItem.PFIProdVchType;  
  
		entity.PFIExpnsVchType = inputItem.PFIExpnsVchType;  
  
		entity.PFIMatStkRef = inputItem.PFIMatStkRef;  
  
		entity.PFIPrdStkRef = inputItem.PFIPrdStkRef;  
  
		entity.PFISemiStkRef = inputItem.PFISemiStkRef;  
  
		entity.PFIBaseVchType = inputItem.PFIBaseVchType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdFixInfDto Map(PrdFixInf inputItem)
        {
            var dto = new PrdFixInfDto()
            {
                  
  
		PrdFixInfID = inputItem.PrdFixInfID,  
  
		PFIProdVchType = inputItem.PFIProdVchType,  
  
		PFIExpnsVchType = inputItem.PFIExpnsVchType,  
  
		PFIMatStkRef = inputItem.PFIMatStkRef,  
  
		PFIPrdStkRef = inputItem.PFIPrdStkRef,  
  
		PFISemiStkRef = inputItem.PFISemiStkRef,  
  
		PFIBaseVchType = inputItem.PFIBaseVchType, 
            };
            return dto;
        }

        public static List<PrdFixInfDto> Map(ICollection<PrdFixInf> entities)
        {
            var dtos = new List<PrdFixInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdFixInfDto()
                {
                      
  
		PrdFixInfID = inputItem.PrdFixInfID,  
  
		PFIProdVchType = inputItem.PFIProdVchType,  
  
		PFIExpnsVchType = inputItem.PFIExpnsVchType,  
  
		PFIMatStkRef = inputItem.PFIMatStkRef,  
  
		PFIPrdStkRef = inputItem.PFIPrdStkRef,  
  
		PFISemiStkRef = inputItem.PFISemiStkRef,  
  
		PFIBaseVchType = inputItem.PFIBaseVchType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdFixStop Map(AddPrdFixStopCommand inputItem)
        {
            var entity = new PrdFixStop() {
                  
  
		PrdFixStopId = inputItem.PrdFixStopId,  
  
		PFSFTime = inputItem.PFSFTime,  
  
		PFSTTime = inputItem.PFSTTime,  
  
		PFSDescr = inputItem.PFSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdFixStop Map(PrdFixStop entity ,EditPrdFixStopCommand inputItem)
        {
              
  
		entity.PrdFixStopId = inputItem.PrdFixStopId;  
  
		entity.PFSFTime = inputItem.PFSFTime;  
  
		entity.PFSTTime = inputItem.PFSTTime;  
  
		entity.PFSDescr = inputItem.PFSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdFixStopDto Map(PrdFixStop inputItem)
        {
            var dto = new PrdFixStopDto()
            {
                  
  
		PrdFixStopId = inputItem.PrdFixStopId,  
  
		PFSFTime = inputItem.PFSFTime,  
  
		PFSTTime = inputItem.PFSTTime,  
  
		PFSDescr = inputItem.PFSDescr, 
            };
            return dto;
        }

        public static List<PrdFixStopDto> Map(ICollection<PrdFixStop> entities)
        {
            var dtos = new List<PrdFixStopDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdFixStopDto()
                {
                      
  
		PrdFixStopId = inputItem.PrdFixStopId,  
  
		PFSFTime = inputItem.PFSFTime,  
  
		PFSTTime = inputItem.PFSTTime,  
  
		PFSDescr = inputItem.PFSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdMachine Map(AddPrdMachineCommand inputItem)
        {
            var entity = new PrdMachine() {
                  
  
		PrdMachineId = inputItem.PrdMachineId,  
  
		PMTitle = inputItem.PMTitle,  
  
		PMWorkStRef = inputItem.PMWorkStRef,  
  
		PMStartTime = inputItem.PMStartTime,  
  
		PMDurHour = inputItem.PMDurHour, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdMachine Map(PrdMachine entity ,EditPrdMachineCommand inputItem)
        {
              
  
		entity.PrdMachineId = inputItem.PrdMachineId;  
  
		entity.PMTitle = inputItem.PMTitle;  
  
		entity.PMWorkStRef = inputItem.PMWorkStRef;  
  
		entity.PMStartTime = inputItem.PMStartTime;  
  
		entity.PMDurHour = inputItem.PMDurHour; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdMachineDto Map(PrdMachine inputItem)
        {
            var dto = new PrdMachineDto()
            {
                  
  
		PrdMachineId = inputItem.PrdMachineId,  
  
		PMTitle = inputItem.PMTitle,  
  
		PMWorkStRef = inputItem.PMWorkStRef,  
  
		PMStartTime = inputItem.PMStartTime,  
  
		PMDurHour = inputItem.PMDurHour, 
            };
            return dto;
        }

        public static List<PrdMachineDto> Map(ICollection<PrdMachine> entities)
        {
            var dtos = new List<PrdMachineDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdMachineDto()
                {
                      
  
		PrdMachineId = inputItem.PrdMachineId,  
  
		PMTitle = inputItem.PMTitle,  
  
		PMWorkStRef = inputItem.PMWorkStRef,  
  
		PMStartTime = inputItem.PMStartTime,  
  
		PMDurHour = inputItem.PMDurHour, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdMacro Map(AddPrdMacroCommand inputItem)
        {
            var entity = new PrdMacro() {
                  
  
		PMProdRef = inputItem.PMProdRef,  
  
		PMSDate = inputItem.PMSDate,  
  
		PMEDate = inputItem.PMEDate,  
  
		PMDur = inputItem.PMDur,  
  
		PMQty = inputItem.PMQty,  
  
		PMYear = inputItem.PMYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdMacro Map(PrdMacro entity ,EditPrdMacroCommand inputItem)
        {
              
  
		entity.PMProdRef = inputItem.PMProdRef;  
  
		entity.PMSDate = inputItem.PMSDate;  
  
		entity.PMEDate = inputItem.PMEDate;  
  
		entity.PMDur = inputItem.PMDur;  
  
		entity.PMQty = inputItem.PMQty;  
  
		entity.PMYear = inputItem.PMYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdMacroDto Map(PrdMacro inputItem)
        {
            var dto = new PrdMacroDto()
            {
                  
  
		PMProdRef = inputItem.PMProdRef,  
  
		PMSDate = inputItem.PMSDate,  
  
		PMEDate = inputItem.PMEDate,  
  
		PMDur = inputItem.PMDur,  
  
		PMQty = inputItem.PMQty,  
  
		PMYear = inputItem.PMYear, 
            };
            return dto;
        }

        public static List<PrdMacroDto> Map(ICollection<PrdMacro> entities)
        {
            var dtos = new List<PrdMacroDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdMacroDto()
                {
                      
  
		PMProdRef = inputItem.PMProdRef,  
  
		PMSDate = inputItem.PMSDate,  
  
		PMEDate = inputItem.PMEDate,  
  
		PMDur = inputItem.PMDur,  
  
		PMQty = inputItem.PMQty,  
  
		PMYear = inputItem.PMYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdMatPkg Map(AddPrdMatPkgCommand inputItem)
        {
            var entity = new PrdMatPkg() {
                  
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPPkgQty = inputItem.PMPPkgQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdMatPkg Map(PrdMatPkg entity ,EditPrdMatPkgCommand inputItem)
        {
              
  
		entity.PMPMatRef = inputItem.PMPMatRef;  
  
		entity.PMPPkgQty = inputItem.PMPPkgQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdMatPkgDto Map(PrdMatPkg inputItem)
        {
            var dto = new PrdMatPkgDto()
            {
                  
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPPkgQty = inputItem.PMPPkgQty, 
            };
            return dto;
        }

        public static List<PrdMatPkgDto> Map(ICollection<PrdMatPkg> entities)
        {
            var dtos = new List<PrdMatPkgDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdMatPkgDto()
                {
                      
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPPkgQty = inputItem.PMPPkgQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdMatPlan Map(AddPrdMatPlanCommand inputItem)
        {
            var entity = new PrdMatPlan() {
                  
  
		PrdMatPlanId = inputItem.PrdMatPlanId,  
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPFixTime = inputItem.PMPFixTime,  
  
		PMPVarTime = inputItem.PMPVarTime,  
  
		PMPPlanType = inputItem.PMPPlanType,  
  
		PMPPlanQty = inputItem.PMPPlanQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdMatPlan Map(PrdMatPlan entity ,EditPrdMatPlanCommand inputItem)
        {
              
  
		entity.PrdMatPlanId = inputItem.PrdMatPlanId;  
  
		entity.PMPMatRef = inputItem.PMPMatRef;  
  
		entity.PMPFixTime = inputItem.PMPFixTime;  
  
		entity.PMPVarTime = inputItem.PMPVarTime;  
  
		entity.PMPPlanType = inputItem.PMPPlanType;  
  
		entity.PMPPlanQty = inputItem.PMPPlanQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdMatPlanDto Map(PrdMatPlan inputItem)
        {
            var dto = new PrdMatPlanDto()
            {
                  
  
		PrdMatPlanId = inputItem.PrdMatPlanId,  
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPFixTime = inputItem.PMPFixTime,  
  
		PMPVarTime = inputItem.PMPVarTime,  
  
		PMPPlanType = inputItem.PMPPlanType,  
  
		PMPPlanQty = inputItem.PMPPlanQty, 
            };
            return dto;
        }

        public static List<PrdMatPlanDto> Map(ICollection<PrdMatPlan> entities)
        {
            var dtos = new List<PrdMatPlanDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdMatPlanDto()
                {
                      
  
		PrdMatPlanId = inputItem.PrdMatPlanId,  
  
		PMPMatRef = inputItem.PMPMatRef,  
  
		PMPFixTime = inputItem.PMPFixTime,  
  
		PMPVarTime = inputItem.PMPVarTime,  
  
		PMPPlanType = inputItem.PMPPlanType,  
  
		PMPPlanQty = inputItem.PMPPlanQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOperation Map(AddPrdOperationCommand inputItem)
        {
            var entity = new PrdOperation() {
                  
  
		PrdOperationId = inputItem.PrdOperationId,  
  
		PONum = inputItem.PONum,  
  
		PODate = inputItem.PODate,  
  
		POStationRef = inputItem.POStationRef,  
  
		PODescr = inputItem.PODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POState = inputItem.POState,  
  
		POYear = inputItem.POYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOperation Map(PrdOperation entity ,EditPrdOperationCommand inputItem)
        {
              
  
		entity.PrdOperationId = inputItem.PrdOperationId;  
  
		entity.PONum = inputItem.PONum;  
  
		entity.PODate = inputItem.PODate;  
  
		entity.POStationRef = inputItem.POStationRef;  
  
		entity.PODescr = inputItem.PODescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.POState = inputItem.POState;  
  
		entity.POYear = inputItem.POYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOperationDto Map(PrdOperation inputItem)
        {
            var dto = new PrdOperationDto()
            {
                  
  
		PrdOperationId = inputItem.PrdOperationId,  
  
		PONum = inputItem.PONum,  
  
		PODate = inputItem.PODate,  
  
		POStationRef = inputItem.POStationRef,  
  
		PODescr = inputItem.PODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POState = inputItem.POState,  
  
		POYear = inputItem.POYear, 
            };
            return dto;
        }

        public static List<PrdOperationDto> Map(ICollection<PrdOperation> entities)
        {
            var dtos = new List<PrdOperationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOperationDto()
                {
                      
  
		PrdOperationId = inputItem.PrdOperationId,  
  
		PONum = inputItem.PONum,  
  
		PODate = inputItem.PODate,  
  
		POStationRef = inputItem.POStationRef,  
  
		PODescr = inputItem.PODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POState = inputItem.POState,  
  
		POYear = inputItem.POYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOprDet Map(AddPrdOprDetCommand inputItem)
        {
            var entity = new PrdOprDet() {
                  
  
		PrdOprDetId = inputItem.PrdOprDetId,  
  
		PrdOperationRef = inputItem.PrdOperationRef,  
  
		PODSeq = inputItem.PODSeq,  
  
		PODSchRef = inputItem.PODSchRef,  
  
		PODRSTime = inputItem.PODRSTime,  
  
		PODRETime = inputItem.PODRETime,  
  
		PODProdQty = inputItem.PODProdQty,  
  
		PODWastQty = inputItem.PODWastQty,  
  
		PODUnQty = inputItem.PODUnQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOprDet Map(PrdOprDet entity ,EditPrdOprDetCommand inputItem)
        {
              
  
		entity.PrdOprDetId = inputItem.PrdOprDetId;  
  
		entity.PrdOperationRef = inputItem.PrdOperationRef;  
  
		entity.PODSeq = inputItem.PODSeq;  
  
		entity.PODSchRef = inputItem.PODSchRef;  
  
		entity.PODRSTime = inputItem.PODRSTime;  
  
		entity.PODRETime = inputItem.PODRETime;  
  
		entity.PODProdQty = inputItem.PODProdQty;  
  
		entity.PODWastQty = inputItem.PODWastQty;  
  
		entity.PODUnQty = inputItem.PODUnQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOprDetDto Map(PrdOprDet inputItem)
        {
            var dto = new PrdOprDetDto()
            {
                  
  
		PrdOprDetId = inputItem.PrdOprDetId,  
  
		PrdOperationRef = inputItem.PrdOperationRef,  
  
		PODSeq = inputItem.PODSeq,  
  
		PODSchRef = inputItem.PODSchRef,  
  
		PODRSTime = inputItem.PODRSTime,  
  
		PODRETime = inputItem.PODRETime,  
  
		PODProdQty = inputItem.PODProdQty,  
  
		PODWastQty = inputItem.PODWastQty,  
  
		PODUnQty = inputItem.PODUnQty, 
            };
            return dto;
        }

        public static List<PrdOprDetDto> Map(ICollection<PrdOprDet> entities)
        {
            var dtos = new List<PrdOprDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOprDetDto()
                {
                      
  
		PrdOprDetId = inputItem.PrdOprDetId,  
  
		PrdOperationRef = inputItem.PrdOperationRef,  
  
		PODSeq = inputItem.PODSeq,  
  
		PODSchRef = inputItem.PODSchRef,  
  
		PODRSTime = inputItem.PODRSTime,  
  
		PODRETime = inputItem.PODRETime,  
  
		PODProdQty = inputItem.PODProdQty,  
  
		PODWastQty = inputItem.PODWastQty,  
  
		PODUnQty = inputItem.PODUnQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOprDetInf Map(AddPrdOprDetInfCommand inputItem)
        {
            var entity = new PrdOprDetInf() {
                  
  
		PODIItmRef = inputItem.PODIItmRef,  
  
		PODIType = inputItem.PODIType,  
  
		PODITitle = inputItem.PODITitle,  
  
		PODIDescr = inputItem.PODIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOprDetInf Map(PrdOprDetInf entity ,EditPrdOprDetInfCommand inputItem)
        {
              
  
		entity.PODIItmRef = inputItem.PODIItmRef;  
  
		entity.PODIType = inputItem.PODIType;  
  
		entity.PODITitle = inputItem.PODITitle;  
  
		entity.PODIDescr = inputItem.PODIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOprDetInfDto Map(PrdOprDetInf inputItem)
        {
            var dto = new PrdOprDetInfDto()
            {
                  
  
		PODIItmRef = inputItem.PODIItmRef,  
  
		PODIType = inputItem.PODIType,  
  
		PODITitle = inputItem.PODITitle,  
  
		PODIDescr = inputItem.PODIDescr, 
            };
            return dto;
        }

        public static List<PrdOprDetInfDto> Map(ICollection<PrdOprDetInf> entities)
        {
            var dtos = new List<PrdOprDetInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOprDetInfDto()
                {
                      
  
		PODIItmRef = inputItem.PODIItmRef,  
  
		PODIType = inputItem.PODIType,  
  
		PODITitle = inputItem.PODITitle,  
  
		PODIDescr = inputItem.PODIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOprDetPers Map(AddPrdOprDetPersCommand inputItem)
        {
            var entity = new PrdOprDetPers() {
                  
  
		PODPItmRef = inputItem.PODPItmRef,  
  
		PODPPersRef = inputItem.PODPPersRef,  
  
		PODPShiftRef = inputItem.PODPShiftRef,  
  
		PODPTime = inputItem.PODPTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOprDetPers Map(PrdOprDetPers entity ,EditPrdOprDetPersCommand inputItem)
        {
              
  
		entity.PODPItmRef = inputItem.PODPItmRef;  
  
		entity.PODPPersRef = inputItem.PODPPersRef;  
  
		entity.PODPShiftRef = inputItem.PODPShiftRef;  
  
		entity.PODPTime = inputItem.PODPTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOprDetPersDto Map(PrdOprDetPers inputItem)
        {
            var dto = new PrdOprDetPersDto()
            {
                  
  
		PODPItmRef = inputItem.PODPItmRef,  
  
		PODPPersRef = inputItem.PODPPersRef,  
  
		PODPShiftRef = inputItem.PODPShiftRef,  
  
		PODPTime = inputItem.PODPTime, 
            };
            return dto;
        }

        public static List<PrdOprDetPersDto> Map(ICollection<PrdOprDetPers> entities)
        {
            var dtos = new List<PrdOprDetPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOprDetPersDto()
                {
                      
  
		PODPItmRef = inputItem.PODPItmRef,  
  
		PODPPersRef = inputItem.PODPPersRef,  
  
		PODPShiftRef = inputItem.PODPShiftRef,  
  
		PODPTime = inputItem.PODPTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOrdHdr Map(AddPrdOrdHdrCommand inputItem)
        {
            var entity = new PrdOrdHdr() {
                  
  
		PrdOrdHdrId = inputItem.PrdOrdHdrId,  
  
		POHNum = inputItem.POHNum,  
  
		POHLocalNum = inputItem.POHLocalNum,  
  
		POHType = inputItem.POHType,  
  
		POHDate = inputItem.POHDate,  
  
		POHDLRef = inputItem.POHDLRef,  
  
		POHDescr = inputItem.POHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POHState = inputItem.POHState,  
  
		POHYear = inputItem.POHYear,  
  
		POHRefID = inputItem.POHRefID,  
  
		POHRefType = inputItem.POHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOrdHdr Map(PrdOrdHdr entity ,EditPrdOrdHdrCommand inputItem)
        {
              
  
		entity.PrdOrdHdrId = inputItem.PrdOrdHdrId;  
  
		entity.POHNum = inputItem.POHNum;  
  
		entity.POHLocalNum = inputItem.POHLocalNum;  
  
		entity.POHType = inputItem.POHType;  
  
		entity.POHDate = inputItem.POHDate;  
  
		entity.POHDLRef = inputItem.POHDLRef;  
  
		entity.POHDescr = inputItem.POHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.POHState = inputItem.POHState;  
  
		entity.POHYear = inputItem.POHYear;  
  
		entity.POHRefID = inputItem.POHRefID;  
  
		entity.POHRefType = inputItem.POHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOrdHdrDto Map(PrdOrdHdr inputItem)
        {
            var dto = new PrdOrdHdrDto()
            {
                  
  
		PrdOrdHdrId = inputItem.PrdOrdHdrId,  
  
		POHNum = inputItem.POHNum,  
  
		POHLocalNum = inputItem.POHLocalNum,  
  
		POHType = inputItem.POHType,  
  
		POHDate = inputItem.POHDate,  
  
		POHDLRef = inputItem.POHDLRef,  
  
		POHDescr = inputItem.POHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POHState = inputItem.POHState,  
  
		POHYear = inputItem.POHYear,  
  
		POHRefID = inputItem.POHRefID,  
  
		POHRefType = inputItem.POHRefType, 
            };
            return dto;
        }

        public static List<PrdOrdHdrDto> Map(ICollection<PrdOrdHdr> entities)
        {
            var dtos = new List<PrdOrdHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOrdHdrDto()
                {
                      
  
		PrdOrdHdrId = inputItem.PrdOrdHdrId,  
  
		POHNum = inputItem.POHNum,  
  
		POHLocalNum = inputItem.POHLocalNum,  
  
		POHType = inputItem.POHType,  
  
		POHDate = inputItem.POHDate,  
  
		POHDLRef = inputItem.POHDLRef,  
  
		POHDescr = inputItem.POHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		POHState = inputItem.POHState,  
  
		POHYear = inputItem.POHYear,  
  
		POHRefID = inputItem.POHRefID,  
  
		POHRefType = inputItem.POHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOrdItm Map(AddPrdOrdItmCommand inputItem)
        {
            var entity = new PrdOrdItm() {
                  
  
		PrdOrdItmId = inputItem.PrdOrdItmId,  
  
		POISeq = inputItem.POISeq,  
  
		PrdOrdHdrRef = inputItem.PrdOrdHdrRef,  
  
		POIPartRef = inputItem.POIPartRef,  
  
		POIUnitRef = inputItem.POIUnitRef,  
  
		POIOthQty = inputItem.POIOthQty,  
  
		POIMainQty = inputItem.POIMainQty,  
  
		POIDescr = inputItem.POIDescr,  
  
		POINeedDate = inputItem.POINeedDate,  
  
		POIStatus = inputItem.POIStatus,  
  
		POIRefID = inputItem.POIRefID,  
  
		POIRefType = inputItem.POIRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOrdItm Map(PrdOrdItm entity ,EditPrdOrdItmCommand inputItem)
        {
              
  
		entity.PrdOrdItmId = inputItem.PrdOrdItmId;  
  
		entity.POISeq = inputItem.POISeq;  
  
		entity.PrdOrdHdrRef = inputItem.PrdOrdHdrRef;  
  
		entity.POIPartRef = inputItem.POIPartRef;  
  
		entity.POIUnitRef = inputItem.POIUnitRef;  
  
		entity.POIOthQty = inputItem.POIOthQty;  
  
		entity.POIMainQty = inputItem.POIMainQty;  
  
		entity.POIDescr = inputItem.POIDescr;  
  
		entity.POINeedDate = inputItem.POINeedDate;  
  
		entity.POIStatus = inputItem.POIStatus;  
  
		entity.POIRefID = inputItem.POIRefID;  
  
		entity.POIRefType = inputItem.POIRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOrdItmDto Map(PrdOrdItm inputItem)
        {
            var dto = new PrdOrdItmDto()
            {
                  
  
		PrdOrdItmId = inputItem.PrdOrdItmId,  
  
		POISeq = inputItem.POISeq,  
  
		PrdOrdHdrRef = inputItem.PrdOrdHdrRef,  
  
		POIPartRef = inputItem.POIPartRef,  
  
		POIUnitRef = inputItem.POIUnitRef,  
  
		POIOthQty = inputItem.POIOthQty,  
  
		POIMainQty = inputItem.POIMainQty,  
  
		POIDescr = inputItem.POIDescr,  
  
		POINeedDate = inputItem.POINeedDate,  
  
		POIStatus = inputItem.POIStatus,  
  
		POIRefID = inputItem.POIRefID,  
  
		POIRefType = inputItem.POIRefType, 
            };
            return dto;
        }

        public static List<PrdOrdItmDto> Map(ICollection<PrdOrdItm> entities)
        {
            var dtos = new List<PrdOrdItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOrdItmDto()
                {
                      
  
		PrdOrdItmId = inputItem.PrdOrdItmId,  
  
		POISeq = inputItem.POISeq,  
  
		PrdOrdHdrRef = inputItem.PrdOrdHdrRef,  
  
		POIPartRef = inputItem.POIPartRef,  
  
		POIUnitRef = inputItem.POIUnitRef,  
  
		POIOthQty = inputItem.POIOthQty,  
  
		POIMainQty = inputItem.POIMainQty,  
  
		POIDescr = inputItem.POIDescr,  
  
		POINeedDate = inputItem.POINeedDate,  
  
		POIStatus = inputItem.POIStatus,  
  
		POIRefID = inputItem.POIRefID,  
  
		POIRefType = inputItem.POIRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdOrdSched Map(AddPrdOrdSchedCommand inputItem)
        {
            var entity = new PrdOrdSched() {
                  
  
		PrdOrdSchedId = inputItem.PrdOrdSchedId,  
  
		POSItmRef = inputItem.POSItmRef,  
  
		POSPartRef = inputItem.POSPartRef,  
  
		POSFrmlRef = inputItem.POSFrmlRef,  
  
		POSVDStart = inputItem.POSVDStart,  
  
		POSVTStart = inputItem.POSVTStart,  
  
		POSState = inputItem.POSState,  
  
		POSPriority = inputItem.POSPriority,  
  
		POSMashRef = inputItem.POSMashRef,  
  
		POSWStation = inputItem.POSWStation, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdOrdSched Map(PrdOrdSched entity ,EditPrdOrdSchedCommand inputItem)
        {
              
  
		entity.PrdOrdSchedId = inputItem.PrdOrdSchedId;  
  
		entity.POSItmRef = inputItem.POSItmRef;  
  
		entity.POSPartRef = inputItem.POSPartRef;  
  
		entity.POSFrmlRef = inputItem.POSFrmlRef;  
  
		entity.POSVDStart = inputItem.POSVDStart;  
  
		entity.POSVTStart = inputItem.POSVTStart;  
  
		entity.POSState = inputItem.POSState;  
  
		entity.POSPriority = inputItem.POSPriority;  
  
		entity.POSMashRef = inputItem.POSMashRef;  
  
		entity.POSWStation = inputItem.POSWStation; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdOrdSchedDto Map(PrdOrdSched inputItem)
        {
            var dto = new PrdOrdSchedDto()
            {
                  
  
		PrdOrdSchedId = inputItem.PrdOrdSchedId,  
  
		POSItmRef = inputItem.POSItmRef,  
  
		POSPartRef = inputItem.POSPartRef,  
  
		POSFrmlRef = inputItem.POSFrmlRef,  
  
		POSVDStart = inputItem.POSVDStart,  
  
		POSVTStart = inputItem.POSVTStart,  
  
		POSState = inputItem.POSState,  
  
		POSPriority = inputItem.POSPriority,  
  
		POSMashRef = inputItem.POSMashRef,  
  
		POSWStation = inputItem.POSWStation, 
            };
            return dto;
        }

        public static List<PrdOrdSchedDto> Map(ICollection<PrdOrdSched> entities)
        {
            var dtos = new List<PrdOrdSchedDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdOrdSchedDto()
                {
                      
  
		PrdOrdSchedId = inputItem.PrdOrdSchedId,  
  
		POSItmRef = inputItem.POSItmRef,  
  
		POSPartRef = inputItem.POSPartRef,  
  
		POSFrmlRef = inputItem.POSFrmlRef,  
  
		POSVDStart = inputItem.POSVDStart,  
  
		POSVTStart = inputItem.POSVTStart,  
  
		POSState = inputItem.POSState,  
  
		POSPriority = inputItem.POSPriority,  
  
		POSMashRef = inputItem.POSMashRef,  
  
		POSWStation = inputItem.POSWStation, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdPers Map(AddPrdPersCommand inputItem)
        {
            var entity = new PrdPers() {
                  
  
		PrdPersId = inputItem.PrdPersId,  
  
		PPPersRef = inputItem.PPPersRef,  
  
		PPAlowProg = inputItem.PPAlowProg, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdPers Map(PrdPers entity ,EditPrdPersCommand inputItem)
        {
              
  
		entity.PrdPersId = inputItem.PrdPersId;  
  
		entity.PPPersRef = inputItem.PPPersRef;  
  
		entity.PPAlowProg = inputItem.PPAlowProg; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdPersDto Map(PrdPers inputItem)
        {
            var dto = new PrdPersDto()
            {
                  
  
		PrdPersId = inputItem.PrdPersId,  
  
		PPPersRef = inputItem.PPPersRef,  
  
		PPAlowProg = inputItem.PPAlowProg, 
            };
            return dto;
        }

        public static List<PrdPersDto> Map(ICollection<PrdPers> entities)
        {
            var dtos = new List<PrdPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdPersDto()
                {
                      
  
		PrdPersId = inputItem.PrdPersId,  
  
		PPPersRef = inputItem.PPPersRef,  
  
		PPAlowProg = inputItem.PPAlowProg, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdPersWorkSt Map(AddPrdPersWorkStCommand inputItem)
        {
            var entity = new PrdPersWorkSt() {
                  
  
		PPWPersRef = inputItem.PPWPersRef,  
  
		PPWWorkStRef = inputItem.PPWWorkStRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdPersWorkSt Map(PrdPersWorkSt entity ,EditPrdPersWorkStCommand inputItem)
        {
              
  
		entity.PPWPersRef = inputItem.PPWPersRef;  
  
		entity.PPWWorkStRef = inputItem.PPWWorkStRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdPersWorkStDto Map(PrdPersWorkSt inputItem)
        {
            var dto = new PrdPersWorkStDto()
            {
                  
  
		PPWPersRef = inputItem.PPWPersRef,  
  
		PPWWorkStRef = inputItem.PPWWorkStRef, 
            };
            return dto;
        }

        public static List<PrdPersWorkStDto> Map(ICollection<PrdPersWorkSt> entities)
        {
            var dtos = new List<PrdPersWorkStDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdPersWorkStDto()
                {
                      
  
		PPWPersRef = inputItem.PPWPersRef,  
  
		PPWWorkStRef = inputItem.PPWWorkStRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdPOrdHdr Map(AddPrdPOrdHdrCommand inputItem)
        {
            var entity = new PrdPOrdHdr() {
                  
  
		PrdPOrdHdrId = inputItem.PrdPOrdHdrId,  
  
		PPOHNum = inputItem.PPOHNum,  
  
		PPOHDate = inputItem.PPOHDate,  
  
		PPOHDescr = inputItem.PPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PPOHState = inputItem.PPOHState,  
  
		PPOHYear = inputItem.PPOHYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdPOrdHdr Map(PrdPOrdHdr entity ,EditPrdPOrdHdrCommand inputItem)
        {
              
  
		entity.PrdPOrdHdrId = inputItem.PrdPOrdHdrId;  
  
		entity.PPOHNum = inputItem.PPOHNum;  
  
		entity.PPOHDate = inputItem.PPOHDate;  
  
		entity.PPOHDescr = inputItem.PPOHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PPOHState = inputItem.PPOHState;  
  
		entity.PPOHYear = inputItem.PPOHYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdPOrdHdrDto Map(PrdPOrdHdr inputItem)
        {
            var dto = new PrdPOrdHdrDto()
            {
                  
  
		PrdPOrdHdrId = inputItem.PrdPOrdHdrId,  
  
		PPOHNum = inputItem.PPOHNum,  
  
		PPOHDate = inputItem.PPOHDate,  
  
		PPOHDescr = inputItem.PPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PPOHState = inputItem.PPOHState,  
  
		PPOHYear = inputItem.PPOHYear, 
            };
            return dto;
        }

        public static List<PrdPOrdHdrDto> Map(ICollection<PrdPOrdHdr> entities)
        {
            var dtos = new List<PrdPOrdHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdPOrdHdrDto()
                {
                      
  
		PrdPOrdHdrId = inputItem.PrdPOrdHdrId,  
  
		PPOHNum = inputItem.PPOHNum,  
  
		PPOHDate = inputItem.PPOHDate,  
  
		PPOHDescr = inputItem.PPOHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PPOHState = inputItem.PPOHState,  
  
		PPOHYear = inputItem.PPOHYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdPOrdItm Map(AddPrdPOrdItmCommand inputItem)
        {
            var entity = new PrdPOrdItm() {
                  
  
		PrdPOrdItmId = inputItem.PrdPOrdItmId,  
  
		PPOISeq = inputItem.PPOISeq,  
  
		PrdPOrdHdrRef = inputItem.PrdPOrdHdrRef,  
  
		PPOIOrdRef = inputItem.PPOIOrdRef,  
  
		PPOIOthQty = inputItem.PPOIOthQty,  
  
		PPOIMainQty = inputItem.PPOIMainQty,  
  
		PPOIFormulRef = inputItem.PPOIFormulRef,  
  
		PPOIConsumAll = inputItem.PPOIConsumAll,  
  
		PPOIDescr = inputItem.PPOIDescr,  
  
		PPOIStatus = inputItem.PPOIStatus, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdPOrdItm Map(PrdPOrdItm entity ,EditPrdPOrdItmCommand inputItem)
        {
              
  
		entity.PrdPOrdItmId = inputItem.PrdPOrdItmId;  
  
		entity.PPOISeq = inputItem.PPOISeq;  
  
		entity.PrdPOrdHdrRef = inputItem.PrdPOrdHdrRef;  
  
		entity.PPOIOrdRef = inputItem.PPOIOrdRef;  
  
		entity.PPOIOthQty = inputItem.PPOIOthQty;  
  
		entity.PPOIMainQty = inputItem.PPOIMainQty;  
  
		entity.PPOIFormulRef = inputItem.PPOIFormulRef;  
  
		entity.PPOIConsumAll = inputItem.PPOIConsumAll;  
  
		entity.PPOIDescr = inputItem.PPOIDescr;  
  
		entity.PPOIStatus = inputItem.PPOIStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdPOrdItmDto Map(PrdPOrdItm inputItem)
        {
            var dto = new PrdPOrdItmDto()
            {
                  
  
		PrdPOrdItmId = inputItem.PrdPOrdItmId,  
  
		PPOISeq = inputItem.PPOISeq,  
  
		PrdPOrdHdrRef = inputItem.PrdPOrdHdrRef,  
  
		PPOIOrdRef = inputItem.PPOIOrdRef,  
  
		PPOIOthQty = inputItem.PPOIOthQty,  
  
		PPOIMainQty = inputItem.PPOIMainQty,  
  
		PPOIFormulRef = inputItem.PPOIFormulRef,  
  
		PPOIConsumAll = inputItem.PPOIConsumAll,  
  
		PPOIDescr = inputItem.PPOIDescr,  
  
		PPOIStatus = inputItem.PPOIStatus, 
            };
            return dto;
        }

        public static List<PrdPOrdItmDto> Map(ICollection<PrdPOrdItm> entities)
        {
            var dtos = new List<PrdPOrdItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdPOrdItmDto()
                {
                      
  
		PrdPOrdItmId = inputItem.PrdPOrdItmId,  
  
		PPOISeq = inputItem.PPOISeq,  
  
		PrdPOrdHdrRef = inputItem.PrdPOrdHdrRef,  
  
		PPOIOrdRef = inputItem.PPOIOrdRef,  
  
		PPOIOthQty = inputItem.PPOIOthQty,  
  
		PPOIMainQty = inputItem.PPOIMainQty,  
  
		PPOIFormulRef = inputItem.PPOIFormulRef,  
  
		PPOIConsumAll = inputItem.PPOIConsumAll,  
  
		PPOIDescr = inputItem.PPOIDescr,  
  
		PPOIStatus = inputItem.PPOIStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdPOrdItmDet Map(AddPrdPOrdItmDetCommand inputItem)
        {
            var entity = new PrdPOrdItmDet() {
                  
  
		PPOIDItmRef = inputItem.PPOIDItmRef,  
  
		PPOIDPartRef = inputItem.PPOIDPartRef,  
  
		PPOIDFrmlRef = inputItem.PPOIDFrmlRef,  
  
		PPOIDLev = inputItem.PPOIDLev,  
  
		PPOIDQty = inputItem.PPOIDQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdPOrdItmDet Map(PrdPOrdItmDet entity ,EditPrdPOrdItmDetCommand inputItem)
        {
              
  
		entity.PPOIDItmRef = inputItem.PPOIDItmRef;  
  
		entity.PPOIDPartRef = inputItem.PPOIDPartRef;  
  
		entity.PPOIDFrmlRef = inputItem.PPOIDFrmlRef;  
  
		entity.PPOIDLev = inputItem.PPOIDLev;  
  
		entity.PPOIDQty = inputItem.PPOIDQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdPOrdItmDetDto Map(PrdPOrdItmDet inputItem)
        {
            var dto = new PrdPOrdItmDetDto()
            {
                  
  
		PPOIDItmRef = inputItem.PPOIDItmRef,  
  
		PPOIDPartRef = inputItem.PPOIDPartRef,  
  
		PPOIDFrmlRef = inputItem.PPOIDFrmlRef,  
  
		PPOIDLev = inputItem.PPOIDLev,  
  
		PPOIDQty = inputItem.PPOIDQty, 
            };
            return dto;
        }

        public static List<PrdPOrdItmDetDto> Map(ICollection<PrdPOrdItmDet> entities)
        {
            var dtos = new List<PrdPOrdItmDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdPOrdItmDetDto()
                {
                      
  
		PPOIDItmRef = inputItem.PPOIDItmRef,  
  
		PPOIDPartRef = inputItem.PPOIDPartRef,  
  
		PPOIDFrmlRef = inputItem.PPOIDFrmlRef,  
  
		PPOIDLev = inputItem.PPOIDLev,  
  
		PPOIDQty = inputItem.PPOIDQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdSchStop Map(AddPrdSchStopCommand inputItem)
        {
            var entity = new PrdSchStop() {
                  
  
		PrdSchStopId = inputItem.PrdSchStopId,  
  
		PSSFDate = inputItem.PSSFDate,  
  
		PSSTDate = inputItem.PSSTDate,  
  
		PSSDescr = inputItem.PSSDescr,  
  
		PSSYear = inputItem.PSSYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdSchStop Map(PrdSchStop entity ,EditPrdSchStopCommand inputItem)
        {
              
  
		entity.PrdSchStopId = inputItem.PrdSchStopId;  
  
		entity.PSSFDate = inputItem.PSSFDate;  
  
		entity.PSSTDate = inputItem.PSSTDate;  
  
		entity.PSSDescr = inputItem.PSSDescr;  
  
		entity.PSSYear = inputItem.PSSYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdSchStopDto Map(PrdSchStop inputItem)
        {
            var dto = new PrdSchStopDto()
            {
                  
  
		PrdSchStopId = inputItem.PrdSchStopId,  
  
		PSSFDate = inputItem.PSSFDate,  
  
		PSSTDate = inputItem.PSSTDate,  
  
		PSSDescr = inputItem.PSSDescr,  
  
		PSSYear = inputItem.PSSYear, 
            };
            return dto;
        }

        public static List<PrdSchStopDto> Map(ICollection<PrdSchStop> entities)
        {
            var dtos = new List<PrdSchStopDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdSchStopDto()
                {
                      
  
		PrdSchStopId = inputItem.PrdSchStopId,  
  
		PSSFDate = inputItem.PSSFDate,  
  
		PSSTDate = inputItem.PSSTDate,  
  
		PSSDescr = inputItem.PSSDescr,  
  
		PSSYear = inputItem.PSSYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdSendHdr Map(AddPrdSendHdrCommand inputItem)
        {
            var entity = new PrdSendHdr() {
                  
  
		PrdSendHdrId = inputItem.PrdSendHdrId,  
  
		PSHNum = inputItem.PSHNum,  
  
		PSHLocalNum = inputItem.PSHLocalNum,  
  
		PSHKind = inputItem.PSHKind,  
  
		PSHType = inputItem.PSHType,  
  
		PSHDate = inputItem.PSHDate,  
  
		PSHSendRef = inputItem.PSHSendRef,  
  
		PSHRespRef = inputItem.PSHRespRef,  
  
		PSHDescr = inputItem.PSHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PSHState = inputItem.PSHState,  
  
		PSHYear = inputItem.PSHYear, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdSendHdr Map(PrdSendHdr entity ,EditPrdSendHdrCommand inputItem)
        {
              
  
		entity.PrdSendHdrId = inputItem.PrdSendHdrId;  
  
		entity.PSHNum = inputItem.PSHNum;  
  
		entity.PSHLocalNum = inputItem.PSHLocalNum;  
  
		entity.PSHKind = inputItem.PSHKind;  
  
		entity.PSHType = inputItem.PSHType;  
  
		entity.PSHDate = inputItem.PSHDate;  
  
		entity.PSHSendRef = inputItem.PSHSendRef;  
  
		entity.PSHRespRef = inputItem.PSHRespRef;  
  
		entity.PSHDescr = inputItem.PSHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PSHState = inputItem.PSHState;  
  
		entity.PSHYear = inputItem.PSHYear; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdSendHdrDto Map(PrdSendHdr inputItem)
        {
            var dto = new PrdSendHdrDto()
            {
                  
  
		PrdSendHdrId = inputItem.PrdSendHdrId,  
  
		PSHNum = inputItem.PSHNum,  
  
		PSHLocalNum = inputItem.PSHLocalNum,  
  
		PSHKind = inputItem.PSHKind,  
  
		PSHType = inputItem.PSHType,  
  
		PSHDate = inputItem.PSHDate,  
  
		PSHSendRef = inputItem.PSHSendRef,  
  
		PSHRespRef = inputItem.PSHRespRef,  
  
		PSHDescr = inputItem.PSHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PSHState = inputItem.PSHState,  
  
		PSHYear = inputItem.PSHYear, 
            };
            return dto;
        }

        public static List<PrdSendHdrDto> Map(ICollection<PrdSendHdr> entities)
        {
            var dtos = new List<PrdSendHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdSendHdrDto()
                {
                      
  
		PrdSendHdrId = inputItem.PrdSendHdrId,  
  
		PSHNum = inputItem.PSHNum,  
  
		PSHLocalNum = inputItem.PSHLocalNum,  
  
		PSHKind = inputItem.PSHKind,  
  
		PSHType = inputItem.PSHType,  
  
		PSHDate = inputItem.PSHDate,  
  
		PSHSendRef = inputItem.PSHSendRef,  
  
		PSHRespRef = inputItem.PSHRespRef,  
  
		PSHDescr = inputItem.PSHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PSHState = inputItem.PSHState,  
  
		PSHYear = inputItem.PSHYear, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdSendItm Map(AddPrdSendItmCommand inputItem)
        {
            var entity = new PrdSendItm() {
                  
  
		PrdSendItmId = inputItem.PrdSendItmId,  
  
		PSISeq = inputItem.PSISeq,  
  
		PrdSendHdrRef = inputItem.PrdSendHdrRef,  
  
		PSIOprRef = inputItem.PSIOprRef,  
  
		PSIMainQty = inputItem.PSIMainQty,  
  
		PSIDescr = inputItem.PSIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdSendItm Map(PrdSendItm entity ,EditPrdSendItmCommand inputItem)
        {
              
  
		entity.PrdSendItmId = inputItem.PrdSendItmId;  
  
		entity.PSISeq = inputItem.PSISeq;  
  
		entity.PrdSendHdrRef = inputItem.PrdSendHdrRef;  
  
		entity.PSIOprRef = inputItem.PSIOprRef;  
  
		entity.PSIMainQty = inputItem.PSIMainQty;  
  
		entity.PSIDescr = inputItem.PSIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdSendItmDto Map(PrdSendItm inputItem)
        {
            var dto = new PrdSendItmDto()
            {
                  
  
		PrdSendItmId = inputItem.PrdSendItmId,  
  
		PSISeq = inputItem.PSISeq,  
  
		PrdSendHdrRef = inputItem.PrdSendHdrRef,  
  
		PSIOprRef = inputItem.PSIOprRef,  
  
		PSIMainQty = inputItem.PSIMainQty,  
  
		PSIDescr = inputItem.PSIDescr, 
            };
            return dto;
        }

        public static List<PrdSendItmDto> Map(ICollection<PrdSendItm> entities)
        {
            var dtos = new List<PrdSendItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdSendItmDto()
                {
                      
  
		PrdSendItmId = inputItem.PrdSendItmId,  
  
		PSISeq = inputItem.PSISeq,  
  
		PrdSendHdrRef = inputItem.PrdSendHdrRef,  
  
		PSIOprRef = inputItem.PSIOprRef,  
  
		PSIMainQty = inputItem.PSIMainQty,  
  
		PSIDescr = inputItem.PSIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdShifts Map(AddPrdShiftsCommand inputItem)
        {
            var entity = new PrdShifts() {
                  
  
		PrdShiftId = inputItem.PrdShiftId,  
  
		PSTitle = inputItem.PSTitle,  
  
		PSStTime = inputItem.PSStTime,  
  
		PSEnTime = inputItem.PSEnTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdShifts Map(PrdShifts entity ,EditPrdShiftsCommand inputItem)
        {
              
  
		entity.PrdShiftId = inputItem.PrdShiftId;  
  
		entity.PSTitle = inputItem.PSTitle;  
  
		entity.PSStTime = inputItem.PSStTime;  
  
		entity.PSEnTime = inputItem.PSEnTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdShiftsDto Map(PrdShifts inputItem)
        {
            var dto = new PrdShiftsDto()
            {
                  
  
		PrdShiftId = inputItem.PrdShiftId,  
  
		PSTitle = inputItem.PSTitle,  
  
		PSStTime = inputItem.PSStTime,  
  
		PSEnTime = inputItem.PSEnTime, 
            };
            return dto;
        }

        public static List<PrdShiftsDto> Map(ICollection<PrdShifts> entities)
        {
            var dtos = new List<PrdShiftsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdShiftsDto()
                {
                      
  
		PrdShiftId = inputItem.PrdShiftId,  
  
		PSTitle = inputItem.PSTitle,  
  
		PSStTime = inputItem.PSStTime,  
  
		PSEnTime = inputItem.PSEnTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdStop Map(AddPrdStopCommand inputItem)
        {
            var entity = new PrdStop() {
                  
  
		PrdStopId = inputItem.PrdStopId,  
  
		PSNum = inputItem.PSNum,  
  
		PSDate = inputItem.PSDate,  
  
		PSDescr = inputItem.PSDescr,  
  
		PSYear = inputItem.PSYear,  
  
		PSState = inputItem.PSState,  
  
		Creator = inputItem.Creator, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdStop Map(PrdStop entity ,EditPrdStopCommand inputItem)
        {
              
  
		entity.PrdStopId = inputItem.PrdStopId;  
  
		entity.PSNum = inputItem.PSNum;  
  
		entity.PSDate = inputItem.PSDate;  
  
		entity.PSDescr = inputItem.PSDescr;  
  
		entity.PSYear = inputItem.PSYear;  
  
		entity.PSState = inputItem.PSState;  
  
		entity.Creator = inputItem.Creator; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdStopDto Map(PrdStop inputItem)
        {
            var dto = new PrdStopDto()
            {
                  
  
		PrdStopId = inputItem.PrdStopId,  
  
		PSNum = inputItem.PSNum,  
  
		PSDate = inputItem.PSDate,  
  
		PSDescr = inputItem.PSDescr,  
  
		PSYear = inputItem.PSYear,  
  
		PSState = inputItem.PSState,  
  
		Creator = inputItem.Creator, 
            };
            return dto;
        }

        public static List<PrdStopDto> Map(ICollection<PrdStop> entities)
        {
            var dtos = new List<PrdStopDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdStopDto()
                {
                      
  
		PrdStopId = inputItem.PrdStopId,  
  
		PSNum = inputItem.PSNum,  
  
		PSDate = inputItem.PSDate,  
  
		PSDescr = inputItem.PSDescr,  
  
		PSYear = inputItem.PSYear,  
  
		PSState = inputItem.PSState,  
  
		Creator = inputItem.Creator, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdStopItm Map(AddPrdStopItmCommand inputItem)
        {
            var entity = new PrdStopItm() {
                  
  
		PrdStopItmId = inputItem.PrdStopItmId,  
  
		PrdStopRef = inputItem.PrdStopRef,  
  
		PSISeq = inputItem.PSISeq,  
  
		PSIWStation = inputItem.PSIWStation,  
  
		PSIMashRef = inputItem.PSIMashRef,  
  
		PSIFTime = inputItem.PSIFTime,  
  
		PSITTime = inputItem.PSITTime,  
  
		PSIDescr = inputItem.PSIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdStopItm Map(PrdStopItm entity ,EditPrdStopItmCommand inputItem)
        {
              
  
		entity.PrdStopItmId = inputItem.PrdStopItmId;  
  
		entity.PrdStopRef = inputItem.PrdStopRef;  
  
		entity.PSISeq = inputItem.PSISeq;  
  
		entity.PSIWStation = inputItem.PSIWStation;  
  
		entity.PSIMashRef = inputItem.PSIMashRef;  
  
		entity.PSIFTime = inputItem.PSIFTime;  
  
		entity.PSITTime = inputItem.PSITTime;  
  
		entity.PSIDescr = inputItem.PSIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdStopItmDto Map(PrdStopItm inputItem)
        {
            var dto = new PrdStopItmDto()
            {
                  
  
		PrdStopItmId = inputItem.PrdStopItmId,  
  
		PrdStopRef = inputItem.PrdStopRef,  
  
		PSISeq = inputItem.PSISeq,  
  
		PSIWStation = inputItem.PSIWStation,  
  
		PSIMashRef = inputItem.PSIMashRef,  
  
		PSIFTime = inputItem.PSIFTime,  
  
		PSITTime = inputItem.PSITTime,  
  
		PSIDescr = inputItem.PSIDescr, 
            };
            return dto;
        }

        public static List<PrdStopItmDto> Map(ICollection<PrdStopItm> entities)
        {
            var dtos = new List<PrdStopItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdStopItmDto()
                {
                      
  
		PrdStopItmId = inputItem.PrdStopItmId,  
  
		PrdStopRef = inputItem.PrdStopRef,  
  
		PSISeq = inputItem.PSISeq,  
  
		PSIWStation = inputItem.PSIWStation,  
  
		PSIMashRef = inputItem.PSIMashRef,  
  
		PSIFTime = inputItem.PSIFTime,  
  
		PSITTime = inputItem.PSITTime,  
  
		PSIDescr = inputItem.PSIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdVchHdr Map(AddPrdVchHdrCommand inputItem)
        {
            var entity = new PrdVchHdr() {
                  
  
		PrdVchHdrId = inputItem.PrdVchHdrId,  
  
		PVHNum = inputItem.PVHNum,  
  
		PVHLocalNum = inputItem.PVHLocalNum,  
  
		PVHDate = inputItem.PVHDate,  
  
		PVHDescr = inputItem.PVHDescr,  
  
		PVHType = inputItem.PVHType,  
  
		PVHStockRef = inputItem.PVHStockRef,  
  
		PVHVchState = inputItem.PVHVchState,  
  
		PVHDLRef = inputItem.PVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PVHState = inputItem.PVHState,  
  
		PAccPrdRef = inputItem.PAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdVchHdr Map(PrdVchHdr entity ,EditPrdVchHdrCommand inputItem)
        {
              
  
		entity.PrdVchHdrId = inputItem.PrdVchHdrId;  
  
		entity.PVHNum = inputItem.PVHNum;  
  
		entity.PVHLocalNum = inputItem.PVHLocalNum;  
  
		entity.PVHDate = inputItem.PVHDate;  
  
		entity.PVHDescr = inputItem.PVHDescr;  
  
		entity.PVHType = inputItem.PVHType;  
  
		entity.PVHStockRef = inputItem.PVHStockRef;  
  
		entity.PVHVchState = inputItem.PVHVchState;  
  
		entity.PVHDLRef = inputItem.PVHDLRef;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PVHState = inputItem.PVHState;  
  
		entity.PAccPrdRef = inputItem.PAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdVchHdrDto Map(PrdVchHdr inputItem)
        {
            var dto = new PrdVchHdrDto()
            {
                  
  
		PrdVchHdrId = inputItem.PrdVchHdrId,  
  
		PVHNum = inputItem.PVHNum,  
  
		PVHLocalNum = inputItem.PVHLocalNum,  
  
		PVHDate = inputItem.PVHDate,  
  
		PVHDescr = inputItem.PVHDescr,  
  
		PVHType = inputItem.PVHType,  
  
		PVHStockRef = inputItem.PVHStockRef,  
  
		PVHVchState = inputItem.PVHVchState,  
  
		PVHDLRef = inputItem.PVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PVHState = inputItem.PVHState,  
  
		PAccPrdRef = inputItem.PAccPrdRef, 
            };
            return dto;
        }

        public static List<PrdVchHdrDto> Map(ICollection<PrdVchHdr> entities)
        {
            var dtos = new List<PrdVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdVchHdrDto()
                {
                      
  
		PrdVchHdrId = inputItem.PrdVchHdrId,  
  
		PVHNum = inputItem.PVHNum,  
  
		PVHLocalNum = inputItem.PVHLocalNum,  
  
		PVHDate = inputItem.PVHDate,  
  
		PVHDescr = inputItem.PVHDescr,  
  
		PVHType = inputItem.PVHType,  
  
		PVHStockRef = inputItem.PVHStockRef,  
  
		PVHVchState = inputItem.PVHVchState,  
  
		PVHDLRef = inputItem.PVHDLRef,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PVHState = inputItem.PVHState,  
  
		PAccPrdRef = inputItem.PAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdVchInvDet Map(AddPrdVchInvDetCommand inputItem)
        {
            var entity = new PrdVchInvDet() {
                  
  
		PVIDHdrRef = inputItem.PVIDHdrRef,  
  
		PVIDInvHdrId = inputItem.PVIDInvHdrId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdVchInvDet Map(PrdVchInvDet entity ,EditPrdVchInvDetCommand inputItem)
        {
              
  
		entity.PVIDHdrRef = inputItem.PVIDHdrRef;  
  
		entity.PVIDInvHdrId = inputItem.PVIDInvHdrId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdVchInvDetDto Map(PrdVchInvDet inputItem)
        {
            var dto = new PrdVchInvDetDto()
            {
                  
  
		PVIDHdrRef = inputItem.PVIDHdrRef,  
  
		PVIDInvHdrId = inputItem.PVIDInvHdrId, 
            };
            return dto;
        }

        public static List<PrdVchInvDetDto> Map(ICollection<PrdVchInvDet> entities)
        {
            var dtos = new List<PrdVchInvDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdVchInvDetDto()
                {
                      
  
		PVIDHdrRef = inputItem.PVIDHdrRef,  
  
		PVIDInvHdrId = inputItem.PVIDInvHdrId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PrdVchItm Map(AddPrdVchItmCommand inputItem)
        {
            var entity = new PrdVchItm() {
                  
  
		PrdVchItmId = inputItem.PrdVchItmId,  
  
		PrdVchHdrRef = inputItem.PrdVchHdrRef,  
  
		PVISeq = inputItem.PVISeq,  
  
		PVICostCenterRef = inputItem.PVICostCenterRef,  
  
		PVIPartRef = inputItem.PVIPartRef,  
  
		PVIUnitRef = inputItem.PVIUnitRef,  
  
		PVIFormulRef = inputItem.PVIFormulRef,  
  
		PVIQty = inputItem.PVIQty,  
  
		PVIDescr = inputItem.PVIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PrdVchItm Map(PrdVchItm entity ,EditPrdVchItmCommand inputItem)
        {
              
  
		entity.PrdVchItmId = inputItem.PrdVchItmId;  
  
		entity.PrdVchHdrRef = inputItem.PrdVchHdrRef;  
  
		entity.PVISeq = inputItem.PVISeq;  
  
		entity.PVICostCenterRef = inputItem.PVICostCenterRef;  
  
		entity.PVIPartRef = inputItem.PVIPartRef;  
  
		entity.PVIUnitRef = inputItem.PVIUnitRef;  
  
		entity.PVIFormulRef = inputItem.PVIFormulRef;  
  
		entity.PVIQty = inputItem.PVIQty;  
  
		entity.PVIDescr = inputItem.PVIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PrdVchItmDto Map(PrdVchItm inputItem)
        {
            var dto = new PrdVchItmDto()
            {
                  
  
		PrdVchItmId = inputItem.PrdVchItmId,  
  
		PrdVchHdrRef = inputItem.PrdVchHdrRef,  
  
		PVISeq = inputItem.PVISeq,  
  
		PVICostCenterRef = inputItem.PVICostCenterRef,  
  
		PVIPartRef = inputItem.PVIPartRef,  
  
		PVIUnitRef = inputItem.PVIUnitRef,  
  
		PVIFormulRef = inputItem.PVIFormulRef,  
  
		PVIQty = inputItem.PVIQty,  
  
		PVIDescr = inputItem.PVIDescr, 
            };
            return dto;
        }

        public static List<PrdVchItmDto> Map(ICollection<PrdVchItm> entities)
        {
            var dtos = new List<PrdVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PrdVchItmDto()
                {
                      
  
		PrdVchItmId = inputItem.PrdVchItmId,  
  
		PrdVchHdrRef = inputItem.PrdVchHdrRef,  
  
		PVISeq = inputItem.PVISeq,  
  
		PVICostCenterRef = inputItem.PVICostCenterRef,  
  
		PVIPartRef = inputItem.PVIPartRef,  
  
		PVIUnitRef = inputItem.PVIUnitRef,  
  
		PVIFormulRef = inputItem.PVIFormulRef,  
  
		PVIQty = inputItem.PVIQty,  
  
		PVIDescr = inputItem.PVIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Projects Map(AddProjectsCommand inputItem)
        {
            var entity = new Projects() {
                  
  
		ProjectId = inputItem.ProjectId,  
  
		PrjCode = inputItem.PrjCode,  
  
		PrjName = inputItem.PrjName,  
  
		PrjDLRef = inputItem.PrjDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Projects Map(Projects entity ,EditProjectsCommand inputItem)
        {
              
  
		entity.ProjectId = inputItem.ProjectId;  
  
		entity.PrjCode = inputItem.PrjCode;  
  
		entity.PrjName = inputItem.PrjName;  
  
		entity.PrjDLRef = inputItem.PrjDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProjectsDto Map(Projects inputItem)
        {
            var dto = new ProjectsDto()
            {
                  
  
		ProjectId = inputItem.ProjectId,  
  
		PrjCode = inputItem.PrjCode,  
  
		PrjName = inputItem.PrjName,  
  
		PrjDLRef = inputItem.PrjDLRef, 
            };
            return dto;
        }

        public static List<ProjectsDto> Map(ICollection<Projects> entities)
        {
            var dtos = new List<ProjectsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProjectsDto()
                {
                      
  
		ProjectId = inputItem.ProjectId,  
  
		PrjCode = inputItem.PrjCode,  
  
		PrjName = inputItem.PrjName,  
  
		PrjDLRef = inputItem.PrjDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
