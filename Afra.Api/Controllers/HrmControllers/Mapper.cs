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
                
        
        public static HrmAimElmnts Map(AddHrmAimElmntsCommand inputItem)
        {
            var entity = new HrmAimElmnts() {
                  
  
		HrmAimElmntId = inputItem.HrmAimElmntId,  
  
		HAETitle = inputItem.HAETitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmAimElmnts Map(HrmAimElmnts entity ,EditHrmAimElmntsCommand inputItem)
        {
              
  
		entity.HrmAimElmntId = inputItem.HrmAimElmntId;  
  
		entity.HAETitle = inputItem.HAETitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmAimElmntsDto Map(HrmAimElmnts inputItem)
        {
            var dto = new HrmAimElmntsDto()
            {
                  
  
		HrmAimElmntId = inputItem.HrmAimElmntId,  
  
		HAETitle = inputItem.HAETitle, 
            };
            return dto;
        }

        public static List<HrmAimElmntsDto> Map(ICollection<HrmAimElmnts> entities)
        {
            var dtos = new List<HrmAimElmntsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmAimElmntsDto()
                {
                      
  
		HrmAimElmntId = inputItem.HrmAimElmntId,  
  
		HAETitle = inputItem.HAETitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmAimFormDet Map(AddHrmAimFormDetCommand inputItem)
        {
            var entity = new HrmAimFormDet() {
                  
  
		HAFDFormRef = inputItem.HAFDFormRef,  
  
		HAFDElmntRef = inputItem.HAFDElmntRef,  
  
		HAFDRatio = inputItem.HAFDRatio, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmAimFormDet Map(HrmAimFormDet entity ,EditHrmAimFormDetCommand inputItem)
        {
              
  
		entity.HAFDFormRef = inputItem.HAFDFormRef;  
  
		entity.HAFDElmntRef = inputItem.HAFDElmntRef;  
  
		entity.HAFDRatio = inputItem.HAFDRatio; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmAimFormDetDto Map(HrmAimFormDet inputItem)
        {
            var dto = new HrmAimFormDetDto()
            {
                  
  
		HAFDFormRef = inputItem.HAFDFormRef,  
  
		HAFDElmntRef = inputItem.HAFDElmntRef,  
  
		HAFDRatio = inputItem.HAFDRatio, 
            };
            return dto;
        }

        public static List<HrmAimFormDetDto> Map(ICollection<HrmAimFormDet> entities)
        {
            var dtos = new List<HrmAimFormDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmAimFormDetDto()
                {
                      
  
		HAFDFormRef = inputItem.HAFDFormRef,  
  
		HAFDElmntRef = inputItem.HAFDElmntRef,  
  
		HAFDRatio = inputItem.HAFDRatio, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmAimForms Map(AddHrmAimFormsCommand inputItem)
        {
            var entity = new HrmAimForms() {
                  
  
		HrmAimFormId = inputItem.HrmAimFormId,  
  
		HAFTitle = inputItem.HAFTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmAimForms Map(HrmAimForms entity ,EditHrmAimFormsCommand inputItem)
        {
              
  
		entity.HrmAimFormId = inputItem.HrmAimFormId;  
  
		entity.HAFTitle = inputItem.HAFTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmAimFormsDto Map(HrmAimForms inputItem)
        {
            var dto = new HrmAimFormsDto()
            {
                  
  
		HrmAimFormId = inputItem.HrmAimFormId,  
  
		HAFTitle = inputItem.HAFTitle, 
            };
            return dto;
        }

        public static List<HrmAimFormsDto> Map(ICollection<HrmAimForms> entities)
        {
            var dtos = new List<HrmAimFormsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmAimFormsDto()
                {
                      
  
		HrmAimFormId = inputItem.HrmAimFormId,  
  
		HAFTitle = inputItem.HAFTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmAimPeriod Map(AddHrmAimPeriodCommand inputItem)
        {
            var entity = new HrmAimPeriod() {
                  
  
		HrmAimPeriodId = inputItem.HrmAimPeriodId,  
  
		HAPTitle = inputItem.HAPTitle,  
  
		HAPDate = inputItem.HAPDate,  
  
		HAPFormRef = inputItem.HAPFormRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmAimPeriod Map(HrmAimPeriod entity ,EditHrmAimPeriodCommand inputItem)
        {
              
  
		entity.HrmAimPeriodId = inputItem.HrmAimPeriodId;  
  
		entity.HAPTitle = inputItem.HAPTitle;  
  
		entity.HAPDate = inputItem.HAPDate;  
  
		entity.HAPFormRef = inputItem.HAPFormRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmAimPeriodDto Map(HrmAimPeriod inputItem)
        {
            var dto = new HrmAimPeriodDto()
            {
                  
  
		HrmAimPeriodId = inputItem.HrmAimPeriodId,  
  
		HAPTitle = inputItem.HAPTitle,  
  
		HAPDate = inputItem.HAPDate,  
  
		HAPFormRef = inputItem.HAPFormRef, 
            };
            return dto;
        }

        public static List<HrmAimPeriodDto> Map(ICollection<HrmAimPeriod> entities)
        {
            var dtos = new List<HrmAimPeriodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmAimPeriodDto()
                {
                      
  
		HrmAimPeriodId = inputItem.HrmAimPeriodId,  
  
		HAPTitle = inputItem.HAPTitle,  
  
		HAPDate = inputItem.HAPDate,  
  
		HAPFormRef = inputItem.HAPFormRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmAimPeriodDet Map(AddHrmAimPeriodDetCommand inputItem)
        {
            var entity = new HrmAimPeriodDet() {
                  
  
		HAPDPeriodRef = inputItem.HAPDPeriodRef,  
  
		HAPDPersRef = inputItem.HAPDPersRef,  
  
		HAPDElmntRef = inputItem.HAPDElmntRef,  
  
		HAPDVal = inputItem.HAPDVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmAimPeriodDet Map(HrmAimPeriodDet entity ,EditHrmAimPeriodDetCommand inputItem)
        {
              
  
		entity.HAPDPeriodRef = inputItem.HAPDPeriodRef;  
  
		entity.HAPDPersRef = inputItem.HAPDPersRef;  
  
		entity.HAPDElmntRef = inputItem.HAPDElmntRef;  
  
		entity.HAPDVal = inputItem.HAPDVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmAimPeriodDetDto Map(HrmAimPeriodDet inputItem)
        {
            var dto = new HrmAimPeriodDetDto()
            {
                  
  
		HAPDPeriodRef = inputItem.HAPDPeriodRef,  
  
		HAPDPersRef = inputItem.HAPDPersRef,  
  
		HAPDElmntRef = inputItem.HAPDElmntRef,  
  
		HAPDVal = inputItem.HAPDVal, 
            };
            return dto;
        }

        public static List<HrmAimPeriodDetDto> Map(ICollection<HrmAimPeriodDet> entities)
        {
            var dtos = new List<HrmAimPeriodDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmAimPeriodDetDto()
                {
                      
  
		HAPDPeriodRef = inputItem.HAPDPeriodRef,  
  
		HAPDPersRef = inputItem.HAPDPersRef,  
  
		HAPDElmntRef = inputItem.HAPDElmntRef,  
  
		HAPDVal = inputItem.HAPDVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmBaseAmounts Map(AddHrmBaseAmountsCommand inputItem)
        {
            var entity = new HrmBaseAmounts() {
                  
  
		HrmBaseAmountsId = inputItem.HrmBaseAmountsId,  
  
		HBAType = inputItem.HBAType,  
  
		HBABaseId = inputItem.HBABaseId,  
  
		HBADate = inputItem.HBADate,  
  
		HBAQty = inputItem.HBAQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmBaseAmounts Map(HrmBaseAmounts entity ,EditHrmBaseAmountsCommand inputItem)
        {
              
  
		entity.HrmBaseAmountsId = inputItem.HrmBaseAmountsId;  
  
		entity.HBAType = inputItem.HBAType;  
  
		entity.HBABaseId = inputItem.HBABaseId;  
  
		entity.HBADate = inputItem.HBADate;  
  
		entity.HBAQty = inputItem.HBAQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmBaseAmountsDto Map(HrmBaseAmounts inputItem)
        {
            var dto = new HrmBaseAmountsDto()
            {
                  
  
		HrmBaseAmountsId = inputItem.HrmBaseAmountsId,  
  
		HBAType = inputItem.HBAType,  
  
		HBABaseId = inputItem.HBABaseId,  
  
		HBADate = inputItem.HBADate,  
  
		HBAQty = inputItem.HBAQty, 
            };
            return dto;
        }

        public static List<HrmBaseAmountsDto> Map(ICollection<HrmBaseAmounts> entities)
        {
            var dtos = new List<HrmBaseAmountsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmBaseAmountsDto()
                {
                      
  
		HrmBaseAmountsId = inputItem.HrmBaseAmountsId,  
  
		HBAType = inputItem.HBAType,  
  
		HBABaseId = inputItem.HBABaseId,  
  
		HBADate = inputItem.HBADate,  
  
		HBAQty = inputItem.HBAQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmBases Map(AddHrmBasesCommand inputItem)
        {
            var entity = new HrmBases() {
                  
  
		HrmBaseId = inputItem.HrmBaseId,  
  
		HrmBaseCode = inputItem.HrmBaseCode,  
  
		HrmBaseTitle = inputItem.HrmBaseTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmBases Map(HrmBases entity ,EditHrmBasesCommand inputItem)
        {
              
  
		entity.HrmBaseId = inputItem.HrmBaseId;  
  
		entity.HrmBaseCode = inputItem.HrmBaseCode;  
  
		entity.HrmBaseTitle = inputItem.HrmBaseTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmBasesDto Map(HrmBases inputItem)
        {
            var dto = new HrmBasesDto()
            {
                  
  
		HrmBaseId = inputItem.HrmBaseId,  
  
		HrmBaseCode = inputItem.HrmBaseCode,  
  
		HrmBaseTitle = inputItem.HrmBaseTitle, 
            };
            return dto;
        }

        public static List<HrmBasesDto> Map(ICollection<HrmBases> entities)
        {
            var dtos = new List<HrmBasesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmBasesDto()
                {
                      
  
		HrmBaseId = inputItem.HrmBaseId,  
  
		HrmBaseCode = inputItem.HrmBaseCode,  
  
		HrmBaseTitle = inputItem.HrmBaseTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmCalendars Map(AddHrmCalendarsCommand inputItem)
        {
            var entity = new HrmCalendars() {
                  
  
		HrmCalendarId = inputItem.HrmCalendarId,  
  
		HCTitle = inputItem.HCTitle,  
  
		HCAccPrdRef = inputItem.HCAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmCalendars Map(HrmCalendars entity ,EditHrmCalendarsCommand inputItem)
        {
              
  
		entity.HrmCalendarId = inputItem.HrmCalendarId;  
  
		entity.HCTitle = inputItem.HCTitle;  
  
		entity.HCAccPrdRef = inputItem.HCAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmCalendarsDto Map(HrmCalendars inputItem)
        {
            var dto = new HrmCalendarsDto()
            {
                  
  
		HrmCalendarId = inputItem.HrmCalendarId,  
  
		HCTitle = inputItem.HCTitle,  
  
		HCAccPrdRef = inputItem.HCAccPrdRef, 
            };
            return dto;
        }

        public static List<HrmCalendarsDto> Map(ICollection<HrmCalendars> entities)
        {
            var dtos = new List<HrmCalendarsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmCalendarsDto()
                {
                      
  
		HrmCalendarId = inputItem.HrmCalendarId,  
  
		HCTitle = inputItem.HCTitle,  
  
		HCAccPrdRef = inputItem.HCAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmCalenderDet Map(AddHrmCalenderDetCommand inputItem)
        {
            var entity = new HrmCalenderDet() {
                  
  
		HCDHdrRef = inputItem.HCDHdrRef,  
  
		HCDDater = inputItem.HCDDater,  
  
		HCDWorkBGDate = inputItem.HCDWorkBGDate,  
  
		HCDWorkBGTime = inputItem.HCDWorkBGTime,  
  
		HCDWorkENDate = inputItem.HCDWorkENDate,  
  
		HCDWorkENTime = inputItem.HCDWorkENTime,  
  
		HCDOvTimeBGDate = inputItem.HCDOvTimeBGDate,  
  
		HCDOvTimeBGTime = inputItem.HCDOvTimeBGTime,  
  
		HCDOvTimeENDate = inputItem.HCDOvTimeENDate,  
  
		HCDOvTimeENTime = inputItem.HCDOvTimeENTime,  
  
		HCDDelayBGDate = inputItem.HCDDelayBGDate,  
  
		HCDDelayBGTime = inputItem.HCDDelayBGTime,  
  
		HCDDelayENDate = inputItem.HCDDelayENDate,  
  
		HCDDelayENTime = inputItem.HCDDelayENTime,  
  
		HCDDaySit = inputItem.HCDDaySit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmCalenderDet Map(HrmCalenderDet entity ,EditHrmCalenderDetCommand inputItem)
        {
              
  
		entity.HCDHdrRef = inputItem.HCDHdrRef;  
  
		entity.HCDDater = inputItem.HCDDater;  
  
		entity.HCDWorkBGDate = inputItem.HCDWorkBGDate;  
  
		entity.HCDWorkBGTime = inputItem.HCDWorkBGTime;  
  
		entity.HCDWorkENDate = inputItem.HCDWorkENDate;  
  
		entity.HCDWorkENTime = inputItem.HCDWorkENTime;  
  
		entity.HCDOvTimeBGDate = inputItem.HCDOvTimeBGDate;  
  
		entity.HCDOvTimeBGTime = inputItem.HCDOvTimeBGTime;  
  
		entity.HCDOvTimeENDate = inputItem.HCDOvTimeENDate;  
  
		entity.HCDOvTimeENTime = inputItem.HCDOvTimeENTime;  
  
		entity.HCDDelayBGDate = inputItem.HCDDelayBGDate;  
  
		entity.HCDDelayBGTime = inputItem.HCDDelayBGTime;  
  
		entity.HCDDelayENDate = inputItem.HCDDelayENDate;  
  
		entity.HCDDelayENTime = inputItem.HCDDelayENTime;  
  
		entity.HCDDaySit = inputItem.HCDDaySit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmCalenderDetDto Map(HrmCalenderDet inputItem)
        {
            var dto = new HrmCalenderDetDto()
            {
                  
  
		HCDHdrRef = inputItem.HCDHdrRef,  
  
		HCDDater = inputItem.HCDDater,  
  
		HCDWorkBGDate = inputItem.HCDWorkBGDate,  
  
		HCDWorkBGTime = inputItem.HCDWorkBGTime,  
  
		HCDWorkENDate = inputItem.HCDWorkENDate,  
  
		HCDWorkENTime = inputItem.HCDWorkENTime,  
  
		HCDOvTimeBGDate = inputItem.HCDOvTimeBGDate,  
  
		HCDOvTimeBGTime = inputItem.HCDOvTimeBGTime,  
  
		HCDOvTimeENDate = inputItem.HCDOvTimeENDate,  
  
		HCDOvTimeENTime = inputItem.HCDOvTimeENTime,  
  
		HCDDelayBGDate = inputItem.HCDDelayBGDate,  
  
		HCDDelayBGTime = inputItem.HCDDelayBGTime,  
  
		HCDDelayENDate = inputItem.HCDDelayENDate,  
  
		HCDDelayENTime = inputItem.HCDDelayENTime,  
  
		HCDDaySit = inputItem.HCDDaySit, 
            };
            return dto;
        }

        public static List<HrmCalenderDetDto> Map(ICollection<HrmCalenderDet> entities)
        {
            var dtos = new List<HrmCalenderDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmCalenderDetDto()
                {
                      
  
		HCDHdrRef = inputItem.HCDHdrRef,  
  
		HCDDater = inputItem.HCDDater,  
  
		HCDWorkBGDate = inputItem.HCDWorkBGDate,  
  
		HCDWorkBGTime = inputItem.HCDWorkBGTime,  
  
		HCDWorkENDate = inputItem.HCDWorkENDate,  
  
		HCDWorkENTime = inputItem.HCDWorkENTime,  
  
		HCDOvTimeBGDate = inputItem.HCDOvTimeBGDate,  
  
		HCDOvTimeBGTime = inputItem.HCDOvTimeBGTime,  
  
		HCDOvTimeENDate = inputItem.HCDOvTimeENDate,  
  
		HCDOvTimeENTime = inputItem.HCDOvTimeENTime,  
  
		HCDDelayBGDate = inputItem.HCDDelayBGDate,  
  
		HCDDelayBGTime = inputItem.HCDDelayBGTime,  
  
		HCDDelayENDate = inputItem.HCDDelayENDate,  
  
		HCDDelayENTime = inputItem.HCDDelayENTime,  
  
		HCDDaySit = inputItem.HCDDaySit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmDept Map(AddHrmDeptCommand inputItem)
        {
            var entity = new HrmDept() {
                  
  
		HrmDeptID = inputItem.HrmDeptID,  
  
		HDParentRef = inputItem.HDParentRef,  
  
		HrmDeptTitle = inputItem.HrmDeptTitle,  
  
		HrmDeptCode = inputItem.HrmDeptCode,  
  
		HrmDeptBaseRef = inputItem.HrmDeptBaseRef,  
  
		HrmDeptCount = inputItem.HrmDeptCount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmDept Map(HrmDept entity ,EditHrmDeptCommand inputItem)
        {
              
  
		entity.HrmDeptID = inputItem.HrmDeptID;  
  
		entity.HDParentRef = inputItem.HDParentRef;  
  
		entity.HrmDeptTitle = inputItem.HrmDeptTitle;  
  
		entity.HrmDeptCode = inputItem.HrmDeptCode;  
  
		entity.HrmDeptBaseRef = inputItem.HrmDeptBaseRef;  
  
		entity.HrmDeptCount = inputItem.HrmDeptCount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmDeptDto Map(HrmDept inputItem)
        {
            var dto = new HrmDeptDto()
            {
                  
  
		HrmDeptID = inputItem.HrmDeptID,  
  
		HDParentRef = inputItem.HDParentRef,  
  
		HrmDeptTitle = inputItem.HrmDeptTitle,  
  
		HrmDeptCode = inputItem.HrmDeptCode,  
  
		HrmDeptBaseRef = inputItem.HrmDeptBaseRef,  
  
		HrmDeptCount = inputItem.HrmDeptCount, 
            };
            return dto;
        }

        public static List<HrmDeptDto> Map(ICollection<HrmDept> entities)
        {
            var dtos = new List<HrmDeptDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmDeptDto()
                {
                      
  
		HrmDeptID = inputItem.HrmDeptID,  
  
		HDParentRef = inputItem.HDParentRef,  
  
		HrmDeptTitle = inputItem.HrmDeptTitle,  
  
		HrmDeptCode = inputItem.HrmDeptCode,  
  
		HrmDeptBaseRef = inputItem.HrmDeptBaseRef,  
  
		HrmDeptCount = inputItem.HrmDeptCount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmDeptJobRel Map(AddHrmDeptJobRelCommand inputItem)
        {
            var entity = new HrmDeptJobRel() {
                  
  
		HDJRDeptRef = inputItem.HDJRDeptRef,  
  
		HDJRJobRef = inputItem.HDJRJobRef,  
  
		HDJRCnt = inputItem.HDJRCnt,  
  
		HDJRDescr = inputItem.HDJRDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmDeptJobRel Map(HrmDeptJobRel entity ,EditHrmDeptJobRelCommand inputItem)
        {
              
  
		entity.HDJRDeptRef = inputItem.HDJRDeptRef;  
  
		entity.HDJRJobRef = inputItem.HDJRJobRef;  
  
		entity.HDJRCnt = inputItem.HDJRCnt;  
  
		entity.HDJRDescr = inputItem.HDJRDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmDeptJobRelDto Map(HrmDeptJobRel inputItem)
        {
            var dto = new HrmDeptJobRelDto()
            {
                  
  
		HDJRDeptRef = inputItem.HDJRDeptRef,  
  
		HDJRJobRef = inputItem.HDJRJobRef,  
  
		HDJRCnt = inputItem.HDJRCnt,  
  
		HDJRDescr = inputItem.HDJRDescr, 
            };
            return dto;
        }

        public static List<HrmDeptJobRelDto> Map(ICollection<HrmDeptJobRel> entities)
        {
            var dtos = new List<HrmDeptJobRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmDeptJobRelDto()
                {
                      
  
		HDJRDeptRef = inputItem.HDJRDeptRef,  
  
		HDJRJobRef = inputItem.HDJRJobRef,  
  
		HDJRCnt = inputItem.HDJRCnt,  
  
		HDJRDescr = inputItem.HDJRDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmEmpStatAmnt Map(AddHrmEmpStatAmntCommand inputItem)
        {
            var entity = new HrmEmpStatAmnt() {
                  
  
		HSAStatueRef = inputItem.HSAStatueRef,  
  
		HSAElmntRef = inputItem.HSAElmntRef,  
  
		HSAAmount = inputItem.HSAAmount,  
  
		HSAEffDate = inputItem.HSAEffDate,  
  
		HSAMthd = inputItem.HSAMthd, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmEmpStatAmnt Map(HrmEmpStatAmnt entity ,EditHrmEmpStatAmntCommand inputItem)
        {
              
  
		entity.HSAStatueRef = inputItem.HSAStatueRef;  
  
		entity.HSAElmntRef = inputItem.HSAElmntRef;  
  
		entity.HSAAmount = inputItem.HSAAmount;  
  
		entity.HSAEffDate = inputItem.HSAEffDate;  
  
		entity.HSAMthd = inputItem.HSAMthd; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmEmpStatAmntDto Map(HrmEmpStatAmnt inputItem)
        {
            var dto = new HrmEmpStatAmntDto()
            {
                  
  
		HSAStatueRef = inputItem.HSAStatueRef,  
  
		HSAElmntRef = inputItem.HSAElmntRef,  
  
		HSAAmount = inputItem.HSAAmount,  
  
		HSAEffDate = inputItem.HSAEffDate,  
  
		HSAMthd = inputItem.HSAMthd, 
            };
            return dto;
        }

        public static List<HrmEmpStatAmntDto> Map(ICollection<HrmEmpStatAmnt> entities)
        {
            var dtos = new List<HrmEmpStatAmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmEmpStatAmntDto()
                {
                      
  
		HSAStatueRef = inputItem.HSAStatueRef,  
  
		HSAElmntRef = inputItem.HSAElmntRef,  
  
		HSAAmount = inputItem.HSAAmount,  
  
		HSAEffDate = inputItem.HSAEffDate,  
  
		HSAMthd = inputItem.HSAMthd, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmEmpStatue Map(AddHrmEmpStatueCommand inputItem)
        {
            var entity = new HrmEmpStatue() {
                  
  
		HrmEmpStatId = inputItem.HrmEmpStatId,  
  
		HESPersRef = inputItem.HESPersRef,  
  
		HESType = inputItem.HESType,  
  
		HESEmpRef = inputItem.HESEmpRef,  
  
		HESIssueDate = inputItem.HESIssueDate,  
  
		HESEffectDate = inputItem.HESEffectDate,  
  
		HESEmpDate = inputItem.HESEmpDate,  
  
		HESCostCenter = inputItem.HESCostCenter,  
  
		HESWorkLoc = inputItem.HESWorkLoc,  
  
		HESDeptRef = inputItem.HESDeptRef,  
  
		HESJobRef = inputItem.HESJobRef,  
  
		HESDescr = inputItem.HESDescr,  
  
		HESTaxTblRef = inputItem.HESTaxTblRef,  
  
		HESGrpStatRef = inputItem.HESGrpStatRef,  
  
		HESIYrMonth = inputItem.HESIYrMonth,  
  
		HESEYrMonth = inputItem.HESEYrMonth,  
  
		HESDLRef2 = inputItem.HESDLRef2,  
  
		HESDLRef3 = inputItem.HESDLRef3,  
  
		HESNumber = inputItem.HESNumber,  
  
		HESFmtRef = inputItem.HESFmtRef,  
  
		HESBaseRef = inputItem.HESBaseRef,  
  
		HESLastChange = inputItem.HESLastChange,  
  
		HESCreator = inputItem.HESCreator,  
  
		HESSit = inputItem.HESSit,  
  
		HESState = inputItem.HESState,  
  
		HESContStart = inputItem.HESContStart,  
  
		HESContEnd = inputItem.HESContEnd,  
  
		HESContNo = inputItem.HESContNo,  
  
		HESContDescr = inputItem.HESContDescr,  
  
		HESDLRef = inputItem.HESDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmEmpStatue Map(HrmEmpStatue entity ,EditHrmEmpStatueCommand inputItem)
        {
              
  
		entity.HrmEmpStatId = inputItem.HrmEmpStatId;  
  
		entity.HESPersRef = inputItem.HESPersRef;  
  
		entity.HESType = inputItem.HESType;  
  
		entity.HESEmpRef = inputItem.HESEmpRef;  
  
		entity.HESIssueDate = inputItem.HESIssueDate;  
  
		entity.HESEffectDate = inputItem.HESEffectDate;  
  
		entity.HESEmpDate = inputItem.HESEmpDate;  
  
		entity.HESCostCenter = inputItem.HESCostCenter;  
  
		entity.HESWorkLoc = inputItem.HESWorkLoc;  
  
		entity.HESDeptRef = inputItem.HESDeptRef;  
  
		entity.HESJobRef = inputItem.HESJobRef;  
  
		entity.HESDescr = inputItem.HESDescr;  
  
		entity.HESTaxTblRef = inputItem.HESTaxTblRef;  
  
		entity.HESGrpStatRef = inputItem.HESGrpStatRef;  
  
		entity.HESIYrMonth = inputItem.HESIYrMonth;  
  
		entity.HESEYrMonth = inputItem.HESEYrMonth;  
  
		entity.HESDLRef2 = inputItem.HESDLRef2;  
  
		entity.HESDLRef3 = inputItem.HESDLRef3;  
  
		entity.HESNumber = inputItem.HESNumber;  
  
		entity.HESFmtRef = inputItem.HESFmtRef;  
  
		entity.HESBaseRef = inputItem.HESBaseRef;  
  
		entity.HESLastChange = inputItem.HESLastChange;  
  
		entity.HESCreator = inputItem.HESCreator;  
  
		entity.HESSit = inputItem.HESSit;  
  
		entity.HESState = inputItem.HESState;  
  
		entity.HESContStart = inputItem.HESContStart;  
  
		entity.HESContEnd = inputItem.HESContEnd;  
  
		entity.HESContNo = inputItem.HESContNo;  
  
		entity.HESContDescr = inputItem.HESContDescr;  
  
		entity.HESDLRef = inputItem.HESDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmEmpStatueDto Map(HrmEmpStatue inputItem)
        {
            var dto = new HrmEmpStatueDto()
            {
                  
  
		HrmEmpStatId = inputItem.HrmEmpStatId,  
  
		HESPersRef = inputItem.HESPersRef,  
  
		HESType = inputItem.HESType,  
  
		HESEmpRef = inputItem.HESEmpRef,  
  
		HESIssueDate = inputItem.HESIssueDate,  
  
		HESEffectDate = inputItem.HESEffectDate,  
  
		HESEmpDate = inputItem.HESEmpDate,  
  
		HESCostCenter = inputItem.HESCostCenter,  
  
		HESWorkLoc = inputItem.HESWorkLoc,  
  
		HESDeptRef = inputItem.HESDeptRef,  
  
		HESJobRef = inputItem.HESJobRef,  
  
		HESDescr = inputItem.HESDescr,  
  
		HESTaxTblRef = inputItem.HESTaxTblRef,  
  
		HESGrpStatRef = inputItem.HESGrpStatRef,  
  
		HESIYrMonth = inputItem.HESIYrMonth,  
  
		HESEYrMonth = inputItem.HESEYrMonth,  
  
		HESDLRef2 = inputItem.HESDLRef2,  
  
		HESDLRef3 = inputItem.HESDLRef3,  
  
		HESNumber = inputItem.HESNumber,  
  
		HESFmtRef = inputItem.HESFmtRef,  
  
		HESBaseRef = inputItem.HESBaseRef,  
  
		HESLastChange = inputItem.HESLastChange,  
  
		HESCreator = inputItem.HESCreator,  
  
		HESSit = inputItem.HESSit,  
  
		HESState = inputItem.HESState,  
  
		HESContStart = inputItem.HESContStart,  
  
		HESContEnd = inputItem.HESContEnd,  
  
		HESContNo = inputItem.HESContNo,  
  
		HESContDescr = inputItem.HESContDescr,  
  
		HESDLRef = inputItem.HESDLRef, 
            };
            return dto;
        }

        public static List<HrmEmpStatueDto> Map(ICollection<HrmEmpStatue> entities)
        {
            var dtos = new List<HrmEmpStatueDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmEmpStatueDto()
                {
                      
  
		HrmEmpStatId = inputItem.HrmEmpStatId,  
  
		HESPersRef = inputItem.HESPersRef,  
  
		HESType = inputItem.HESType,  
  
		HESEmpRef = inputItem.HESEmpRef,  
  
		HESIssueDate = inputItem.HESIssueDate,  
  
		HESEffectDate = inputItem.HESEffectDate,  
  
		HESEmpDate = inputItem.HESEmpDate,  
  
		HESCostCenter = inputItem.HESCostCenter,  
  
		HESWorkLoc = inputItem.HESWorkLoc,  
  
		HESDeptRef = inputItem.HESDeptRef,  
  
		HESJobRef = inputItem.HESJobRef,  
  
		HESDescr = inputItem.HESDescr,  
  
		HESTaxTblRef = inputItem.HESTaxTblRef,  
  
		HESGrpStatRef = inputItem.HESGrpStatRef,  
  
		HESIYrMonth = inputItem.HESIYrMonth,  
  
		HESEYrMonth = inputItem.HESEYrMonth,  
  
		HESDLRef2 = inputItem.HESDLRef2,  
  
		HESDLRef3 = inputItem.HESDLRef3,  
  
		HESNumber = inputItem.HESNumber,  
  
		HESFmtRef = inputItem.HESFmtRef,  
  
		HESBaseRef = inputItem.HESBaseRef,  
  
		HESLastChange = inputItem.HESLastChange,  
  
		HESCreator = inputItem.HESCreator,  
  
		HESSit = inputItem.HESSit,  
  
		HESState = inputItem.HESState,  
  
		HESContStart = inputItem.HESContStart,  
  
		HESContEnd = inputItem.HESContEnd,  
  
		HESContNo = inputItem.HESContNo,  
  
		HESContDescr = inputItem.HESContDescr,  
  
		HESDLRef = inputItem.HESDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmEmpTypes Map(AddHrmEmpTypesCommand inputItem)
        {
            var entity = new HrmEmpTypes() {
                  
  
		EmpTypeId = inputItem.EmpTypeId,  
  
		EmpTypeTitle = inputItem.EmpTypeTitle,  
  
		EmpTypeCode = inputItem.EmpTypeCode, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmEmpTypes Map(HrmEmpTypes entity ,EditHrmEmpTypesCommand inputItem)
        {
              
  
		entity.EmpTypeId = inputItem.EmpTypeId;  
  
		entity.EmpTypeTitle = inputItem.EmpTypeTitle;  
  
		entity.EmpTypeCode = inputItem.EmpTypeCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmEmpTypesDto Map(HrmEmpTypes inputItem)
        {
            var dto = new HrmEmpTypesDto()
            {
                  
  
		EmpTypeId = inputItem.EmpTypeId,  
  
		EmpTypeTitle = inputItem.EmpTypeTitle,  
  
		EmpTypeCode = inputItem.EmpTypeCode, 
            };
            return dto;
        }

        public static List<HrmEmpTypesDto> Map(ICollection<HrmEmpTypes> entities)
        {
            var dtos = new List<HrmEmpTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmEmpTypesDto()
                {
                      
  
		EmpTypeId = inputItem.EmpTypeId,  
  
		EmpTypeTitle = inputItem.EmpTypeTitle,  
  
		EmpTypeCode = inputItem.EmpTypeCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGroups Map(AddHrmGroupsCommand inputItem)
        {
            var entity = new HrmGroups() {
                  
  
		HrmGrpId = inputItem.HrmGrpId,  
  
		HrmGrpCode = inputItem.HrmGrpCode,  
  
		HrmGrpTitle = inputItem.HrmGrpTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGroups Map(HrmGroups entity ,EditHrmGroupsCommand inputItem)
        {
              
  
		entity.HrmGrpId = inputItem.HrmGrpId;  
  
		entity.HrmGrpCode = inputItem.HrmGrpCode;  
  
		entity.HrmGrpTitle = inputItem.HrmGrpTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGroupsDto Map(HrmGroups inputItem)
        {
            var dto = new HrmGroupsDto()
            {
                  
  
		HrmGrpId = inputItem.HrmGrpId,  
  
		HrmGrpCode = inputItem.HrmGrpCode,  
  
		HrmGrpTitle = inputItem.HrmGrpTitle, 
            };
            return dto;
        }

        public static List<HrmGroupsDto> Map(ICollection<HrmGroups> entities)
        {
            var dtos = new List<HrmGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGroupsDto()
                {
                      
  
		HrmGrpId = inputItem.HrmGrpId,  
  
		HrmGrpCode = inputItem.HrmGrpCode,  
  
		HrmGrpTitle = inputItem.HrmGrpTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpCompAsign Map(AddHrmGrpCompAsignCommand inputItem)
        {
            var entity = new HrmGrpCompAsign() {
                  
  
		HrmGrpCompAsgnId = inputItem.HrmGrpCompAsgnId,  
  
		HGCAStatRef = inputItem.HGCAStatRef,  
  
		HGCACompRef = inputItem.HGCACompRef,  
  
		HGCACompBrnRef = inputItem.HGCACompBrnRef,  
  
		HGCAIsRel = inputItem.HGCAIsRel, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpCompAsign Map(HrmGrpCompAsign entity ,EditHrmGrpCompAsignCommand inputItem)
        {
              
  
		entity.HrmGrpCompAsgnId = inputItem.HrmGrpCompAsgnId;  
  
		entity.HGCAStatRef = inputItem.HGCAStatRef;  
  
		entity.HGCACompRef = inputItem.HGCACompRef;  
  
		entity.HGCACompBrnRef = inputItem.HGCACompBrnRef;  
  
		entity.HGCAIsRel = inputItem.HGCAIsRel; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpCompAsignDto Map(HrmGrpCompAsign inputItem)
        {
            var dto = new HrmGrpCompAsignDto()
            {
                  
  
		HrmGrpCompAsgnId = inputItem.HrmGrpCompAsgnId,  
  
		HGCAStatRef = inputItem.HGCAStatRef,  
  
		HGCACompRef = inputItem.HGCACompRef,  
  
		HGCACompBrnRef = inputItem.HGCACompBrnRef,  
  
		HGCAIsRel = inputItem.HGCAIsRel, 
            };
            return dto;
        }

        public static List<HrmGrpCompAsignDto> Map(ICollection<HrmGrpCompAsign> entities)
        {
            var dtos = new List<HrmGrpCompAsignDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpCompAsignDto()
                {
                      
  
		HrmGrpCompAsgnId = inputItem.HrmGrpCompAsgnId,  
  
		HGCAStatRef = inputItem.HGCAStatRef,  
  
		HGCACompRef = inputItem.HGCACompRef,  
  
		HGCACompBrnRef = inputItem.HGCACompBrnRef,  
  
		HGCAIsRel = inputItem.HGCAIsRel, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpParamStat Map(AddHrmGrpParamStatCommand inputItem)
        {
            var entity = new HrmGrpParamStat() {
                  
  
		HrmGrpParamStatId = inputItem.HrmGrpParamStatId,  
  
		HGPSNum = inputItem.HGPSNum,  
  
		HGPSIssueDate = inputItem.HGPSIssueDate,  
  
		HGPSEffectDate = inputItem.HGPSEffectDate,  
  
		HGPSDescr = inputItem.HGPSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpParamStat Map(HrmGrpParamStat entity ,EditHrmGrpParamStatCommand inputItem)
        {
              
  
		entity.HrmGrpParamStatId = inputItem.HrmGrpParamStatId;  
  
		entity.HGPSNum = inputItem.HGPSNum;  
  
		entity.HGPSIssueDate = inputItem.HGPSIssueDate;  
  
		entity.HGPSEffectDate = inputItem.HGPSEffectDate;  
  
		entity.HGPSDescr = inputItem.HGPSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpParamStatDto Map(HrmGrpParamStat inputItem)
        {
            var dto = new HrmGrpParamStatDto()
            {
                  
  
		HrmGrpParamStatId = inputItem.HrmGrpParamStatId,  
  
		HGPSNum = inputItem.HGPSNum,  
  
		HGPSIssueDate = inputItem.HGPSIssueDate,  
  
		HGPSEffectDate = inputItem.HGPSEffectDate,  
  
		HGPSDescr = inputItem.HGPSDescr, 
            };
            return dto;
        }

        public static List<HrmGrpParamStatDto> Map(ICollection<HrmGrpParamStat> entities)
        {
            var dtos = new List<HrmGrpParamStatDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpParamStatDto()
                {
                      
  
		HrmGrpParamStatId = inputItem.HrmGrpParamStatId,  
  
		HGPSNum = inputItem.HGPSNum,  
  
		HGPSIssueDate = inputItem.HGPSIssueDate,  
  
		HGPSEffectDate = inputItem.HGPSEffectDate,  
  
		HGPSDescr = inputItem.HGPSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpParamStatAmnt Map(AddHrmGrpParamStatAmntCommand inputItem)
        {
            var entity = new HrmGrpParamStatAmnt() {
                  
  
		HGPSParamRef = inputItem.HGPSParamRef,  
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSAmount = inputItem.HGPSAmount,  
  
		HGPSSit = inputItem.HGPSSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpParamStatAmnt Map(HrmGrpParamStatAmnt entity ,EditHrmGrpParamStatAmntCommand inputItem)
        {
              
  
		entity.HGPSParamRef = inputItem.HGPSParamRef;  
  
		entity.HGPSStatRef = inputItem.HGPSStatRef;  
  
		entity.HGPSAmount = inputItem.HGPSAmount;  
  
		entity.HGPSSit = inputItem.HGPSSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpParamStatAmntDto Map(HrmGrpParamStatAmnt inputItem)
        {
            var dto = new HrmGrpParamStatAmntDto()
            {
                  
  
		HGPSParamRef = inputItem.HGPSParamRef,  
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSAmount = inputItem.HGPSAmount,  
  
		HGPSSit = inputItem.HGPSSit, 
            };
            return dto;
        }

        public static List<HrmGrpParamStatAmntDto> Map(ICollection<HrmGrpParamStatAmnt> entities)
        {
            var dtos = new List<HrmGrpParamStatAmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpParamStatAmntDto()
                {
                      
  
		HGPSParamRef = inputItem.HGPSParamRef,  
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSAmount = inputItem.HGPSAmount,  
  
		HGPSSit = inputItem.HGPSSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpParamStatPers Map(AddHrmGrpParamStatPersCommand inputItem)
        {
            var entity = new HrmGrpParamStatPers() {
                  
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSPersRef = inputItem.HGPSPersRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpParamStatPers Map(HrmGrpParamStatPers entity ,EditHrmGrpParamStatPersCommand inputItem)
        {
              
  
		entity.HGPSStatRef = inputItem.HGPSStatRef;  
  
		entity.HGPSPersRef = inputItem.HGPSPersRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpParamStatPersDto Map(HrmGrpParamStatPers inputItem)
        {
            var dto = new HrmGrpParamStatPersDto()
            {
                  
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSPersRef = inputItem.HGPSPersRef, 
            };
            return dto;
        }

        public static List<HrmGrpParamStatPersDto> Map(ICollection<HrmGrpParamStatPers> entities)
        {
            var dtos = new List<HrmGrpParamStatPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpParamStatPersDto()
                {
                      
  
		HGPSStatRef = inputItem.HGPSStatRef,  
  
		HGPSPersRef = inputItem.HGPSPersRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpStatAmnts Map(AddHrmGrpStatAmntsCommand inputItem)
        {
            var entity = new HrmGrpStatAmnts() {
                  
  
		HGSEElmntRef = inputItem.HGSEElmntRef,  
  
		HGSEStatRef = inputItem.HGSEStatRef,  
  
		HGSEFormula = inputItem.HGSEFormula,  
  
		HGSEVal = inputItem.HGSEVal,  
  
		HGSEWHRM = inputItem.HGSEWHRM,  
  
		HGSEEffDate = inputItem.HGSEEffDate,  
  
		HGSEMthd = inputItem.HGSEMthd, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpStatAmnts Map(HrmGrpStatAmnts entity ,EditHrmGrpStatAmntsCommand inputItem)
        {
              
  
		entity.HGSEElmntRef = inputItem.HGSEElmntRef;  
  
		entity.HGSEStatRef = inputItem.HGSEStatRef;  
  
		entity.HGSEFormula = inputItem.HGSEFormula;  
  
		entity.HGSEVal = inputItem.HGSEVal;  
  
		entity.HGSEWHRM = inputItem.HGSEWHRM;  
  
		entity.HGSEEffDate = inputItem.HGSEEffDate;  
  
		entity.HGSEMthd = inputItem.HGSEMthd; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpStatAmntsDto Map(HrmGrpStatAmnts inputItem)
        {
            var dto = new HrmGrpStatAmntsDto()
            {
                  
  
		HGSEElmntRef = inputItem.HGSEElmntRef,  
  
		HGSEStatRef = inputItem.HGSEStatRef,  
  
		HGSEFormula = inputItem.HGSEFormula,  
  
		HGSEVal = inputItem.HGSEVal,  
  
		HGSEWHRM = inputItem.HGSEWHRM,  
  
		HGSEEffDate = inputItem.HGSEEffDate,  
  
		HGSEMthd = inputItem.HGSEMthd, 
            };
            return dto;
        }

        public static List<HrmGrpStatAmntsDto> Map(ICollection<HrmGrpStatAmnts> entities)
        {
            var dtos = new List<HrmGrpStatAmntsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpStatAmntsDto()
                {
                      
  
		HGSEElmntRef = inputItem.HGSEElmntRef,  
  
		HGSEStatRef = inputItem.HGSEStatRef,  
  
		HGSEFormula = inputItem.HGSEFormula,  
  
		HGSEVal = inputItem.HGSEVal,  
  
		HGSEWHRM = inputItem.HGSEWHRM,  
  
		HGSEEffDate = inputItem.HGSEEffDate,  
  
		HGSEMthd = inputItem.HGSEMthd, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpStatPers Map(AddHrmGrpStatPersCommand inputItem)
        {
            var entity = new HrmGrpStatPers() {
                  
  
		HGSPStatRef = inputItem.HGSPStatRef,  
  
		HGSPPersRef = inputItem.HGSPPersRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpStatPers Map(HrmGrpStatPers entity ,EditHrmGrpStatPersCommand inputItem)
        {
              
  
		entity.HGSPStatRef = inputItem.HGSPStatRef;  
  
		entity.HGSPPersRef = inputItem.HGSPPersRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpStatPersDto Map(HrmGrpStatPers inputItem)
        {
            var dto = new HrmGrpStatPersDto()
            {
                  
  
		HGSPStatRef = inputItem.HGSPStatRef,  
  
		HGSPPersRef = inputItem.HGSPPersRef, 
            };
            return dto;
        }

        public static List<HrmGrpStatPersDto> Map(ICollection<HrmGrpStatPers> entities)
        {
            var dtos = new List<HrmGrpStatPersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpStatPersDto()
                {
                      
  
		HGSPStatRef = inputItem.HGSPStatRef,  
  
		HGSPPersRef = inputItem.HGSPPersRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmGrpStatus Map(AddHrmGrpStatusCommand inputItem)
        {
            var entity = new HrmGrpStatus() {
                  
  
		HrmGrpStatId = inputItem.HrmGrpStatId,  
  
		HGSType = inputItem.HGSType,  
  
		HGSNum = inputItem.HGSNum,  
  
		HGSIssueDate = inputItem.HGSIssueDate,  
  
		HGSEffectDate = inputItem.HGSEffectDate,  
  
		HGSDescr = inputItem.HGSDescr,  
  
		HGSEmpType = inputItem.HGSEmpType,  
  
		HGSCostCenter = inputItem.HGSCostCenter,  
  
		HGSWorkLoc = inputItem.HGSWorkLoc,  
  
		HGSDeptRef = inputItem.HGSDeptRef,  
  
		HGSJobRef = inputItem.HGSJobRef,  
  
		HGSIYrMonth = inputItem.HGSIYrMonth,  
  
		HGSEYrMonth = inputItem.HGSEYrMonth,  
  
		HGSEmpDate = inputItem.HGSEmpDate,  
  
		HGSDLRef2 = inputItem.HGSDLRef2,  
  
		HGSDLRef3 = inputItem.HGSDLRef3,  
  
		HGSFmtRef = inputItem.HGSFmtRef,  
  
		HGSContStart = inputItem.HGSContStart,  
  
		HGSContEnd = inputItem.HGSContEnd,  
  
		HGSContNo = inputItem.HGSContNo,  
  
		HGSContDescr = inputItem.HGSContDescr,  
  
		HGSTaxType = inputItem.HGSTaxType,  
  
		HGSDLRef = inputItem.HGSDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmGrpStatus Map(HrmGrpStatus entity ,EditHrmGrpStatusCommand inputItem)
        {
              
  
		entity.HrmGrpStatId = inputItem.HrmGrpStatId;  
  
		entity.HGSType = inputItem.HGSType;  
  
		entity.HGSNum = inputItem.HGSNum;  
  
		entity.HGSIssueDate = inputItem.HGSIssueDate;  
  
		entity.HGSEffectDate = inputItem.HGSEffectDate;  
  
		entity.HGSDescr = inputItem.HGSDescr;  
  
		entity.HGSEmpType = inputItem.HGSEmpType;  
  
		entity.HGSCostCenter = inputItem.HGSCostCenter;  
  
		entity.HGSWorkLoc = inputItem.HGSWorkLoc;  
  
		entity.HGSDeptRef = inputItem.HGSDeptRef;  
  
		entity.HGSJobRef = inputItem.HGSJobRef;  
  
		entity.HGSIYrMonth = inputItem.HGSIYrMonth;  
  
		entity.HGSEYrMonth = inputItem.HGSEYrMonth;  
  
		entity.HGSEmpDate = inputItem.HGSEmpDate;  
  
		entity.HGSDLRef2 = inputItem.HGSDLRef2;  
  
		entity.HGSDLRef3 = inputItem.HGSDLRef3;  
  
		entity.HGSFmtRef = inputItem.HGSFmtRef;  
  
		entity.HGSContStart = inputItem.HGSContStart;  
  
		entity.HGSContEnd = inputItem.HGSContEnd;  
  
		entity.HGSContNo = inputItem.HGSContNo;  
  
		entity.HGSContDescr = inputItem.HGSContDescr;  
  
		entity.HGSTaxType = inputItem.HGSTaxType;  
  
		entity.HGSDLRef = inputItem.HGSDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmGrpStatusDto Map(HrmGrpStatus inputItem)
        {
            var dto = new HrmGrpStatusDto()
            {
                  
  
		HrmGrpStatId = inputItem.HrmGrpStatId,  
  
		HGSType = inputItem.HGSType,  
  
		HGSNum = inputItem.HGSNum,  
  
		HGSIssueDate = inputItem.HGSIssueDate,  
  
		HGSEffectDate = inputItem.HGSEffectDate,  
  
		HGSDescr = inputItem.HGSDescr,  
  
		HGSEmpType = inputItem.HGSEmpType,  
  
		HGSCostCenter = inputItem.HGSCostCenter,  
  
		HGSWorkLoc = inputItem.HGSWorkLoc,  
  
		HGSDeptRef = inputItem.HGSDeptRef,  
  
		HGSJobRef = inputItem.HGSJobRef,  
  
		HGSIYrMonth = inputItem.HGSIYrMonth,  
  
		HGSEYrMonth = inputItem.HGSEYrMonth,  
  
		HGSEmpDate = inputItem.HGSEmpDate,  
  
		HGSDLRef2 = inputItem.HGSDLRef2,  
  
		HGSDLRef3 = inputItem.HGSDLRef3,  
  
		HGSFmtRef = inputItem.HGSFmtRef,  
  
		HGSContStart = inputItem.HGSContStart,  
  
		HGSContEnd = inputItem.HGSContEnd,  
  
		HGSContNo = inputItem.HGSContNo,  
  
		HGSContDescr = inputItem.HGSContDescr,  
  
		HGSTaxType = inputItem.HGSTaxType,  
  
		HGSDLRef = inputItem.HGSDLRef, 
            };
            return dto;
        }

        public static List<HrmGrpStatusDto> Map(ICollection<HrmGrpStatus> entities)
        {
            var dtos = new List<HrmGrpStatusDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmGrpStatusDto()
                {
                      
  
		HrmGrpStatId = inputItem.HrmGrpStatId,  
  
		HGSType = inputItem.HGSType,  
  
		HGSNum = inputItem.HGSNum,  
  
		HGSIssueDate = inputItem.HGSIssueDate,  
  
		HGSEffectDate = inputItem.HGSEffectDate,  
  
		HGSDescr = inputItem.HGSDescr,  
  
		HGSEmpType = inputItem.HGSEmpType,  
  
		HGSCostCenter = inputItem.HGSCostCenter,  
  
		HGSWorkLoc = inputItem.HGSWorkLoc,  
  
		HGSDeptRef = inputItem.HGSDeptRef,  
  
		HGSJobRef = inputItem.HGSJobRef,  
  
		HGSIYrMonth = inputItem.HGSIYrMonth,  
  
		HGSEYrMonth = inputItem.HGSEYrMonth,  
  
		HGSEmpDate = inputItem.HGSEmpDate,  
  
		HGSDLRef2 = inputItem.HGSDLRef2,  
  
		HGSDLRef3 = inputItem.HGSDLRef3,  
  
		HGSFmtRef = inputItem.HGSFmtRef,  
  
		HGSContStart = inputItem.HGSContStart,  
  
		HGSContEnd = inputItem.HGSContEnd,  
  
		HGSContNo = inputItem.HGSContNo,  
  
		HGSContDescr = inputItem.HGSContDescr,  
  
		HGSTaxType = inputItem.HGSTaxType,  
  
		HGSDLRef = inputItem.HGSDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmIncDecVac Map(AddHrmIncDecVacCommand inputItem)
        {
            var entity = new HrmIncDecVac() {
                  
  
		HrmIncDecVacId = inputItem.HrmIncDecVacId,  
  
		HIDVNum = inputItem.HIDVNum,  
  
		HIDVDate = inputItem.HIDVDate,  
  
		HIDVPersRef = inputItem.HIDVPersRef,  
  
		HIDVType = inputItem.HIDVType,  
  
		HIDVTime = inputItem.HIDVTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmIncDecVac Map(HrmIncDecVac entity ,EditHrmIncDecVacCommand inputItem)
        {
              
  
		entity.HrmIncDecVacId = inputItem.HrmIncDecVacId;  
  
		entity.HIDVNum = inputItem.HIDVNum;  
  
		entity.HIDVDate = inputItem.HIDVDate;  
  
		entity.HIDVPersRef = inputItem.HIDVPersRef;  
  
		entity.HIDVType = inputItem.HIDVType;  
  
		entity.HIDVTime = inputItem.HIDVTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmIncDecVacDto Map(HrmIncDecVac inputItem)
        {
            var dto = new HrmIncDecVacDto()
            {
                  
  
		HrmIncDecVacId = inputItem.HrmIncDecVacId,  
  
		HIDVNum = inputItem.HIDVNum,  
  
		HIDVDate = inputItem.HIDVDate,  
  
		HIDVPersRef = inputItem.HIDVPersRef,  
  
		HIDVType = inputItem.HIDVType,  
  
		HIDVTime = inputItem.HIDVTime, 
            };
            return dto;
        }

        public static List<HrmIncDecVacDto> Map(ICollection<HrmIncDecVac> entities)
        {
            var dtos = new List<HrmIncDecVacDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmIncDecVacDto()
                {
                      
  
		HrmIncDecVacId = inputItem.HrmIncDecVacId,  
  
		HIDVNum = inputItem.HIDVNum,  
  
		HIDVDate = inputItem.HIDVDate,  
  
		HIDVPersRef = inputItem.HIDVPersRef,  
  
		HIDVType = inputItem.HIDVType,  
  
		HIDVTime = inputItem.HIDVTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmIncDecWork Map(AddHrmIncDecWorkCommand inputItem)
        {
            var entity = new HrmIncDecWork() {
                  
  
		HrmIncDecWorkId = inputItem.HrmIncDecWorkId,  
  
		HIDWNum = inputItem.HIDWNum,  
  
		HIDWDate = inputItem.HIDWDate,  
  
		HIDWPersRef = inputItem.HIDWPersRef,  
  
		HIDWType = inputItem.HIDWType,  
  
		HIDWTime = inputItem.HIDWTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmIncDecWork Map(HrmIncDecWork entity ,EditHrmIncDecWorkCommand inputItem)
        {
              
  
		entity.HrmIncDecWorkId = inputItem.HrmIncDecWorkId;  
  
		entity.HIDWNum = inputItem.HIDWNum;  
  
		entity.HIDWDate = inputItem.HIDWDate;  
  
		entity.HIDWPersRef = inputItem.HIDWPersRef;  
  
		entity.HIDWType = inputItem.HIDWType;  
  
		entity.HIDWTime = inputItem.HIDWTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmIncDecWorkDto Map(HrmIncDecWork inputItem)
        {
            var dto = new HrmIncDecWorkDto()
            {
                  
  
		HrmIncDecWorkId = inputItem.HrmIncDecWorkId,  
  
		HIDWNum = inputItem.HIDWNum,  
  
		HIDWDate = inputItem.HIDWDate,  
  
		HIDWPersRef = inputItem.HIDWPersRef,  
  
		HIDWType = inputItem.HIDWType,  
  
		HIDWTime = inputItem.HIDWTime, 
            };
            return dto;
        }

        public static List<HrmIncDecWorkDto> Map(ICollection<HrmIncDecWork> entities)
        {
            var dtos = new List<HrmIncDecWorkDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmIncDecWorkDto()
                {
                      
  
		HrmIncDecWorkId = inputItem.HrmIncDecWorkId,  
  
		HIDWNum = inputItem.HIDWNum,  
  
		HIDWDate = inputItem.HIDWDate,  
  
		HIDWPersRef = inputItem.HIDWPersRef,  
  
		HIDWType = inputItem.HIDWType,  
  
		HIDWTime = inputItem.HIDWTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmJobCond Map(AddHrmJobCondCommand inputItem)
        {
            var entity = new HrmJobCond() {
                  
  
		HrmJobCondId = inputItem.HrmJobCondId,  
  
		HJCJobRef = inputItem.HJCJobRef,  
  
		HJCDate = inputItem.HJCDate,  
  
		HJCCondStr = inputItem.HJCCondStr,  
  
		HJCCondTitle = inputItem.HJCCondTitle,  
  
		HJCCondSQL = inputItem.HJCCondSQL, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmJobCond Map(HrmJobCond entity ,EditHrmJobCondCommand inputItem)
        {
              
  
		entity.HrmJobCondId = inputItem.HrmJobCondId;  
  
		entity.HJCJobRef = inputItem.HJCJobRef;  
  
		entity.HJCDate = inputItem.HJCDate;  
  
		entity.HJCCondStr = inputItem.HJCCondStr;  
  
		entity.HJCCondTitle = inputItem.HJCCondTitle;  
  
		entity.HJCCondSQL = inputItem.HJCCondSQL; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmJobCondDto Map(HrmJobCond inputItem)
        {
            var dto = new HrmJobCondDto()
            {
                  
  
		HrmJobCondId = inputItem.HrmJobCondId,  
  
		HJCJobRef = inputItem.HJCJobRef,  
  
		HJCDate = inputItem.HJCDate,  
  
		HJCCondStr = inputItem.HJCCondStr,  
  
		HJCCondTitle = inputItem.HJCCondTitle,  
  
		HJCCondSQL = inputItem.HJCCondSQL, 
            };
            return dto;
        }

        public static List<HrmJobCondDto> Map(ICollection<HrmJobCond> entities)
        {
            var dtos = new List<HrmJobCondDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmJobCondDto()
                {
                      
  
		HrmJobCondId = inputItem.HrmJobCondId,  
  
		HJCJobRef = inputItem.HJCJobRef,  
  
		HJCDate = inputItem.HJCDate,  
  
		HJCCondStr = inputItem.HJCCondStr,  
  
		HJCCondTitle = inputItem.HJCCondTitle,  
  
		HJCCondSQL = inputItem.HJCCondSQL, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmJobs Map(AddHrmJobsCommand inputItem)
        {
            var entity = new HrmJobs() {
                  
  
		JobId = inputItem.JobId,  
  
		JobCode = inputItem.JobCode,  
  
		JobTitle = inputItem.JobTitle,  
  
		JPayGrpRef = inputItem.JPayGrpRef,  
  
		JHardJobCode = inputItem.JHardJobCode,  
  
		JobPoint = inputItem.JobPoint,  
  
		JobOthCode = inputItem.JobOthCode, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmJobs Map(HrmJobs entity ,EditHrmJobsCommand inputItem)
        {
              
  
		entity.JobId = inputItem.JobId;  
  
		entity.JobCode = inputItem.JobCode;  
  
		entity.JobTitle = inputItem.JobTitle;  
  
		entity.JPayGrpRef = inputItem.JPayGrpRef;  
  
		entity.JHardJobCode = inputItem.JHardJobCode;  
  
		entity.JobPoint = inputItem.JobPoint;  
  
		entity.JobOthCode = inputItem.JobOthCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmJobsDto Map(HrmJobs inputItem)
        {
            var dto = new HrmJobsDto()
            {
                  
  
		JobId = inputItem.JobId,  
  
		JobCode = inputItem.JobCode,  
  
		JobTitle = inputItem.JobTitle,  
  
		JPayGrpRef = inputItem.JPayGrpRef,  
  
		JHardJobCode = inputItem.JHardJobCode,  
  
		JobPoint = inputItem.JobPoint,  
  
		JobOthCode = inputItem.JobOthCode, 
            };
            return dto;
        }

        public static List<HrmJobsDto> Map(ICollection<HrmJobs> entities)
        {
            var dtos = new List<HrmJobsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmJobsDto()
                {
                      
  
		JobId = inputItem.JobId,  
  
		JobCode = inputItem.JobCode,  
  
		JobTitle = inputItem.JobTitle,  
  
		JPayGrpRef = inputItem.JPayGrpRef,  
  
		JHardJobCode = inputItem.JHardJobCode,  
  
		JobPoint = inputItem.JobPoint,  
  
		JobOthCode = inputItem.JobOthCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmMissions Map(AddHrmMissionsCommand inputItem)
        {
            var entity = new HrmMissions() {
                  
  
		HrmMissionId = inputItem.HrmMissionId,  
  
		HMTitle = inputItem.HMTitle,  
  
		HMType = inputItem.HMType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmMissions Map(HrmMissions entity ,EditHrmMissionsCommand inputItem)
        {
              
  
		entity.HrmMissionId = inputItem.HrmMissionId;  
  
		entity.HMTitle = inputItem.HMTitle;  
  
		entity.HMType = inputItem.HMType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmMissionsDto Map(HrmMissions inputItem)
        {
            var dto = new HrmMissionsDto()
            {
                  
  
		HrmMissionId = inputItem.HrmMissionId,  
  
		HMTitle = inputItem.HMTitle,  
  
		HMType = inputItem.HMType, 
            };
            return dto;
        }

        public static List<HrmMissionsDto> Map(ICollection<HrmMissions> entities)
        {
            var dtos = new List<HrmMissionsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmMissionsDto()
                {
                      
  
		HrmMissionId = inputItem.HrmMissionId,  
  
		HMTitle = inputItem.HMTitle,  
  
		HMType = inputItem.HMType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmNumbering Map(AddHrmNumberingCommand inputItem)
        {
            var entity = new HrmNumbering() {
                  
  
		HrmNumberingId = inputItem.HrmNumberingId,  
  
		HNType = inputItem.HNType,  
  
		HNFormat = inputItem.HNFormat, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmNumbering Map(HrmNumbering entity ,EditHrmNumberingCommand inputItem)
        {
              
  
		entity.HrmNumberingId = inputItem.HrmNumberingId;  
  
		entity.HNType = inputItem.HNType;  
  
		entity.HNFormat = inputItem.HNFormat; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmNumberingDto Map(HrmNumbering inputItem)
        {
            var dto = new HrmNumberingDto()
            {
                  
  
		HrmNumberingId = inputItem.HrmNumberingId,  
  
		HNType = inputItem.HNType,  
  
		HNFormat = inputItem.HNFormat, 
            };
            return dto;
        }

        public static List<HrmNumberingDto> Map(ICollection<HrmNumbering> entities)
        {
            var dtos = new List<HrmNumberingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmNumberingDto()
                {
                      
  
		HrmNumberingId = inputItem.HrmNumberingId,  
  
		HNType = inputItem.HNType,  
  
		HNFormat = inputItem.HNFormat, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmOvrTimePerm Map(AddHrmOvrTimePermCommand inputItem)
        {
            var entity = new HrmOvrTimePerm() {
                  
  
		HrmOvrTimePermId = inputItem.HrmOvrTimePermId,  
  
		HOvPPersRef = inputItem.HOvPPersRef,  
  
		HOvPNum = inputItem.HOvPNum,  
  
		HOvPDate = inputItem.HOvPDate,  
  
		HOvPFromDate = inputItem.HOvPFromDate,  
  
		HOvPFromTime = inputItem.HOvPFromTime,  
  
		HOvPToDate = inputItem.HOvPToDate,  
  
		HOvPToTime = inputItem.HOvPToTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmOvrTimePerm Map(HrmOvrTimePerm entity ,EditHrmOvrTimePermCommand inputItem)
        {
              
  
		entity.HrmOvrTimePermId = inputItem.HrmOvrTimePermId;  
  
		entity.HOvPPersRef = inputItem.HOvPPersRef;  
  
		entity.HOvPNum = inputItem.HOvPNum;  
  
		entity.HOvPDate = inputItem.HOvPDate;  
  
		entity.HOvPFromDate = inputItem.HOvPFromDate;  
  
		entity.HOvPFromTime = inputItem.HOvPFromTime;  
  
		entity.HOvPToDate = inputItem.HOvPToDate;  
  
		entity.HOvPToTime = inputItem.HOvPToTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmOvrTimePermDto Map(HrmOvrTimePerm inputItem)
        {
            var dto = new HrmOvrTimePermDto()
            {
                  
  
		HrmOvrTimePermId = inputItem.HrmOvrTimePermId,  
  
		HOvPPersRef = inputItem.HOvPPersRef,  
  
		HOvPNum = inputItem.HOvPNum,  
  
		HOvPDate = inputItem.HOvPDate,  
  
		HOvPFromDate = inputItem.HOvPFromDate,  
  
		HOvPFromTime = inputItem.HOvPFromTime,  
  
		HOvPToDate = inputItem.HOvPToDate,  
  
		HOvPToTime = inputItem.HOvPToTime, 
            };
            return dto;
        }

        public static List<HrmOvrTimePermDto> Map(ICollection<HrmOvrTimePerm> entities)
        {
            var dtos = new List<HrmOvrTimePermDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmOvrTimePermDto()
                {
                      
  
		HrmOvrTimePermId = inputItem.HrmOvrTimePermId,  
  
		HOvPPersRef = inputItem.HOvPPersRef,  
  
		HOvPNum = inputItem.HOvPNum,  
  
		HOvPDate = inputItem.HOvPDate,  
  
		HOvPFromDate = inputItem.HOvPFromDate,  
  
		HOvPFromTime = inputItem.HOvPFromTime,  
  
		HOvPToDate = inputItem.HOvPToDate,  
  
		HOvPToTime = inputItem.HOvPToTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmParamStatAmnt Map(AddHrmParamStatAmntCommand inputItem)
        {
            var entity = new HrmParamStatAmnt() {
                  
  
		HPSAStatRef = inputItem.HPSAStatRef,  
  
		HPSAParamRef = inputItem.HPSAParamRef,  
  
		HPSAAmount = inputItem.HPSAAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmParamStatAmnt Map(HrmParamStatAmnt entity ,EditHrmParamStatAmntCommand inputItem)
        {
              
  
		entity.HPSAStatRef = inputItem.HPSAStatRef;  
  
		entity.HPSAParamRef = inputItem.HPSAParamRef;  
  
		entity.HPSAAmount = inputItem.HPSAAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmParamStatAmntDto Map(HrmParamStatAmnt inputItem)
        {
            var dto = new HrmParamStatAmntDto()
            {
                  
  
		HPSAStatRef = inputItem.HPSAStatRef,  
  
		HPSAParamRef = inputItem.HPSAParamRef,  
  
		HPSAAmount = inputItem.HPSAAmount, 
            };
            return dto;
        }

        public static List<HrmParamStatAmntDto> Map(ICollection<HrmParamStatAmnt> entities)
        {
            var dtos = new List<HrmParamStatAmntDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmParamStatAmntDto()
                {
                      
  
		HPSAStatRef = inputItem.HPSAStatRef,  
  
		HPSAParamRef = inputItem.HPSAParamRef,  
  
		HPSAAmount = inputItem.HPSAAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmParamStats Map(AddHrmParamStatsCommand inputItem)
        {
            var entity = new HrmParamStats() {
                  
  
		HrmParamStatId = inputItem.HrmParamStatId,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSIssueDate = inputItem.HPSIssueDate,  
  
		HPSEffectDate = inputItem.HPSEffectDate,  
  
		HPSDescr = inputItem.HPSDescr,  
  
		HPSGrpStatRef = inputItem.HPSGrpStatRef,  
  
		HPSIYrMonth = inputItem.HPSIYrMonth,  
  
		HPSEYrMonth = inputItem.HPSEYrMonth,  
  
		HPSLastChange = inputItem.HPSLastChange,  
  
		HPSCreator = inputItem.HPSCreator,  
  
		HPSSit = inputItem.HPSSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmParamStats Map(HrmParamStats entity ,EditHrmParamStatsCommand inputItem)
        {
              
  
		entity.HrmParamStatId = inputItem.HrmParamStatId;  
  
		entity.HPSPersRef = inputItem.HPSPersRef;  
  
		entity.HPSIssueDate = inputItem.HPSIssueDate;  
  
		entity.HPSEffectDate = inputItem.HPSEffectDate;  
  
		entity.HPSDescr = inputItem.HPSDescr;  
  
		entity.HPSGrpStatRef = inputItem.HPSGrpStatRef;  
  
		entity.HPSIYrMonth = inputItem.HPSIYrMonth;  
  
		entity.HPSEYrMonth = inputItem.HPSEYrMonth;  
  
		entity.HPSLastChange = inputItem.HPSLastChange;  
  
		entity.HPSCreator = inputItem.HPSCreator;  
  
		entity.HPSSit = inputItem.HPSSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmParamStatsDto Map(HrmParamStats inputItem)
        {
            var dto = new HrmParamStatsDto()
            {
                  
  
		HrmParamStatId = inputItem.HrmParamStatId,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSIssueDate = inputItem.HPSIssueDate,  
  
		HPSEffectDate = inputItem.HPSEffectDate,  
  
		HPSDescr = inputItem.HPSDescr,  
  
		HPSGrpStatRef = inputItem.HPSGrpStatRef,  
  
		HPSIYrMonth = inputItem.HPSIYrMonth,  
  
		HPSEYrMonth = inputItem.HPSEYrMonth,  
  
		HPSLastChange = inputItem.HPSLastChange,  
  
		HPSCreator = inputItem.HPSCreator,  
  
		HPSSit = inputItem.HPSSit, 
            };
            return dto;
        }

        public static List<HrmParamStatsDto> Map(ICollection<HrmParamStats> entities)
        {
            var dtos = new List<HrmParamStatsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmParamStatsDto()
                {
                      
  
		HrmParamStatId = inputItem.HrmParamStatId,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSIssueDate = inputItem.HPSIssueDate,  
  
		HPSEffectDate = inputItem.HPSEffectDate,  
  
		HPSDescr = inputItem.HPSDescr,  
  
		HPSGrpStatRef = inputItem.HPSGrpStatRef,  
  
		HPSIYrMonth = inputItem.HPSIYrMonth,  
  
		HPSEYrMonth = inputItem.HPSEYrMonth,  
  
		HPSLastChange = inputItem.HPSLastChange,  
  
		HPSCreator = inputItem.HPSCreator,  
  
		HPSSit = inputItem.HPSSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersAccount Map(AddHrmPersAccountCommand inputItem)
        {
            var entity = new HrmPersAccount() {
                  
  
		HrmPersAcntId = inputItem.HrmPersAcntId,  
  
		HPAPersRef = inputItem.HPAPersRef,  
  
		HPABankRef = inputItem.HPABankRef,  
  
		HPADate = inputItem.HPADate,  
  
		HPAElmntRef = inputItem.HPAElmntRef,  
  
		HPANumber = inputItem.HPANumber,  
  
		HPASit = inputItem.HPASit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersAccount Map(HrmPersAccount entity ,EditHrmPersAccountCommand inputItem)
        {
              
  
		entity.HrmPersAcntId = inputItem.HrmPersAcntId;  
  
		entity.HPAPersRef = inputItem.HPAPersRef;  
  
		entity.HPABankRef = inputItem.HPABankRef;  
  
		entity.HPADate = inputItem.HPADate;  
  
		entity.HPAElmntRef = inputItem.HPAElmntRef;  
  
		entity.HPANumber = inputItem.HPANumber;  
  
		entity.HPASit = inputItem.HPASit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersAccountDto Map(HrmPersAccount inputItem)
        {
            var dto = new HrmPersAccountDto()
            {
                  
  
		HrmPersAcntId = inputItem.HrmPersAcntId,  
  
		HPAPersRef = inputItem.HPAPersRef,  
  
		HPABankRef = inputItem.HPABankRef,  
  
		HPADate = inputItem.HPADate,  
  
		HPAElmntRef = inputItem.HPAElmntRef,  
  
		HPANumber = inputItem.HPANumber,  
  
		HPASit = inputItem.HPASit, 
            };
            return dto;
        }

        public static List<HrmPersAccountDto> Map(ICollection<HrmPersAccount> entities)
        {
            var dtos = new List<HrmPersAccountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersAccountDto()
                {
                      
  
		HrmPersAcntId = inputItem.HrmPersAcntId,  
  
		HPAPersRef = inputItem.HPAPersRef,  
  
		HPABankRef = inputItem.HPABankRef,  
  
		HPADate = inputItem.HPADate,  
  
		HPAElmntRef = inputItem.HPAElmntRef,  
  
		HPANumber = inputItem.HPANumber,  
  
		HPASit = inputItem.HPASit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersCompAsign Map(AddHrmPersCompAsignCommand inputItem)
        {
            var entity = new HrmPersCompAsign() {
                  
  
		HrmPersCompAsgnId = inputItem.HrmPersCompAsgnId,  
  
		HPCAEmpStatRef = inputItem.HPCAEmpStatRef,  
  
		HPCACompRef = inputItem.HPCACompRef,  
  
		HPCACompBrnRef = inputItem.HPCACompBrnRef,  
  
		HPCAIsRel = inputItem.HPCAIsRel,  
  
		HPCAPersId = inputItem.HPCAPersId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersCompAsign Map(HrmPersCompAsign entity ,EditHrmPersCompAsignCommand inputItem)
        {
              
  
		entity.HrmPersCompAsgnId = inputItem.HrmPersCompAsgnId;  
  
		entity.HPCAEmpStatRef = inputItem.HPCAEmpStatRef;  
  
		entity.HPCACompRef = inputItem.HPCACompRef;  
  
		entity.HPCACompBrnRef = inputItem.HPCACompBrnRef;  
  
		entity.HPCAIsRel = inputItem.HPCAIsRel;  
  
		entity.HPCAPersId = inputItem.HPCAPersId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersCompAsignDto Map(HrmPersCompAsign inputItem)
        {
            var dto = new HrmPersCompAsignDto()
            {
                  
  
		HrmPersCompAsgnId = inputItem.HrmPersCompAsgnId,  
  
		HPCAEmpStatRef = inputItem.HPCAEmpStatRef,  
  
		HPCACompRef = inputItem.HPCACompRef,  
  
		HPCACompBrnRef = inputItem.HPCACompBrnRef,  
  
		HPCAIsRel = inputItem.HPCAIsRel,  
  
		HPCAPersId = inputItem.HPCAPersId, 
            };
            return dto;
        }

        public static List<HrmPersCompAsignDto> Map(ICollection<HrmPersCompAsign> entities)
        {
            var dtos = new List<HrmPersCompAsignDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersCompAsignDto()
                {
                      
  
		HrmPersCompAsgnId = inputItem.HrmPersCompAsgnId,  
  
		HPCAEmpStatRef = inputItem.HPCAEmpStatRef,  
  
		HPCACompRef = inputItem.HPCACompRef,  
  
		HPCACompBrnRef = inputItem.HPCACompBrnRef,  
  
		HPCAIsRel = inputItem.HPCAIsRel,  
  
		HPCAPersId = inputItem.HPCAPersId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersEdu Map(AddHrmPersEduCommand inputItem)
        {
            var entity = new HrmPersEdu() {
                  
  
		PersEduId = inputItem.PersEduId,  
  
		PEdPersRef = inputItem.PEdPersRef,  
  
		PersEduDeg = inputItem.PersEduDeg,  
  
		PersEduDate = inputItem.PersEduDate,  
  
		PersEduField = inputItem.PersEduField,  
  
		PersEduUnv = inputItem.PersEduUnv,  
  
		PersEduAvg = inputItem.PersEduAvg,  
  
		PersEduTrend = inputItem.PersEduTrend, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersEdu Map(HrmPersEdu entity ,EditHrmPersEduCommand inputItem)
        {
              
  
		entity.PersEduId = inputItem.PersEduId;  
  
		entity.PEdPersRef = inputItem.PEdPersRef;  
  
		entity.PersEduDeg = inputItem.PersEduDeg;  
  
		entity.PersEduDate = inputItem.PersEduDate;  
  
		entity.PersEduField = inputItem.PersEduField;  
  
		entity.PersEduUnv = inputItem.PersEduUnv;  
  
		entity.PersEduAvg = inputItem.PersEduAvg;  
  
		entity.PersEduTrend = inputItem.PersEduTrend; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersEduDto Map(HrmPersEdu inputItem)
        {
            var dto = new HrmPersEduDto()
            {
                  
  
		PersEduId = inputItem.PersEduId,  
  
		PEdPersRef = inputItem.PEdPersRef,  
  
		PersEduDeg = inputItem.PersEduDeg,  
  
		PersEduDate = inputItem.PersEduDate,  
  
		PersEduField = inputItem.PersEduField,  
  
		PersEduUnv = inputItem.PersEduUnv,  
  
		PersEduAvg = inputItem.PersEduAvg,  
  
		PersEduTrend = inputItem.PersEduTrend, 
            };
            return dto;
        }

        public static List<HrmPersEduDto> Map(ICollection<HrmPersEdu> entities)
        {
            var dtos = new List<HrmPersEduDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersEduDto()
                {
                      
  
		PersEduId = inputItem.PersEduId,  
  
		PEdPersRef = inputItem.PEdPersRef,  
  
		PersEduDeg = inputItem.PersEduDeg,  
  
		PersEduDate = inputItem.PersEduDate,  
  
		PersEduField = inputItem.PersEduField,  
  
		PersEduUnv = inputItem.PersEduUnv,  
  
		PersEduAvg = inputItem.PersEduAvg,  
  
		PersEduTrend = inputItem.PersEduTrend, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersExp Map(AddHrmPersExpCommand inputItem)
        {
            var entity = new HrmPersExp() {
                  
  
		PersExpId = inputItem.PersExpId,  
  
		PersExpPersRef = inputItem.PersExpPersRef,  
  
		PersExpFDate = inputItem.PersExpFDate,  
  
		PersExpTDate = inputItem.PersExpTDate,  
  
		PersExpExType = inputItem.PersExpExType,  
  
		PersExpCompName = inputItem.PersExpCompName,  
  
		PersExpInsuDays = inputItem.PersExpInsuDays, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersExp Map(HrmPersExp entity ,EditHrmPersExpCommand inputItem)
        {
              
  
		entity.PersExpId = inputItem.PersExpId;  
  
		entity.PersExpPersRef = inputItem.PersExpPersRef;  
  
		entity.PersExpFDate = inputItem.PersExpFDate;  
  
		entity.PersExpTDate = inputItem.PersExpTDate;  
  
		entity.PersExpExType = inputItem.PersExpExType;  
  
		entity.PersExpCompName = inputItem.PersExpCompName;  
  
		entity.PersExpInsuDays = inputItem.PersExpInsuDays; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersExpDto Map(HrmPersExp inputItem)
        {
            var dto = new HrmPersExpDto()
            {
                  
  
		PersExpId = inputItem.PersExpId,  
  
		PersExpPersRef = inputItem.PersExpPersRef,  
  
		PersExpFDate = inputItem.PersExpFDate,  
  
		PersExpTDate = inputItem.PersExpTDate,  
  
		PersExpExType = inputItem.PersExpExType,  
  
		PersExpCompName = inputItem.PersExpCompName,  
  
		PersExpInsuDays = inputItem.PersExpInsuDays, 
            };
            return dto;
        }

        public static List<HrmPersExpDto> Map(ICollection<HrmPersExp> entities)
        {
            var dtos = new List<HrmPersExpDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersExpDto()
                {
                      
  
		PersExpId = inputItem.PersExpId,  
  
		PersExpPersRef = inputItem.PersExpPersRef,  
  
		PersExpFDate = inputItem.PersExpFDate,  
  
		PersExpTDate = inputItem.PersExpTDate,  
  
		PersExpExType = inputItem.PersExpExType,  
  
		PersExpCompName = inputItem.PersExpCompName,  
  
		PersExpInsuDays = inputItem.PersExpInsuDays, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersFgh Map(AddHrmPersFghCommand inputItem)
        {
            var entity = new HrmPersFgh() {
                  
  
		PersFghId = inputItem.PersFghId,  
  
		PersFghPersRef = inputItem.PersFghPersRef,  
  
		PersFghDate = inputItem.PersFghDate,  
  
		PersFghType = inputItem.PersFghType,  
  
		PersFghDay = inputItem.PersFghDay,  
  
		PersFghDescr = inputItem.PersFghDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersFgh Map(HrmPersFgh entity ,EditHrmPersFghCommand inputItem)
        {
              
  
		entity.PersFghId = inputItem.PersFghId;  
  
		entity.PersFghPersRef = inputItem.PersFghPersRef;  
  
		entity.PersFghDate = inputItem.PersFghDate;  
  
		entity.PersFghType = inputItem.PersFghType;  
  
		entity.PersFghDay = inputItem.PersFghDay;  
  
		entity.PersFghDescr = inputItem.PersFghDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersFghDto Map(HrmPersFgh inputItem)
        {
            var dto = new HrmPersFghDto()
            {
                  
  
		PersFghId = inputItem.PersFghId,  
  
		PersFghPersRef = inputItem.PersFghPersRef,  
  
		PersFghDate = inputItem.PersFghDate,  
  
		PersFghType = inputItem.PersFghType,  
  
		PersFghDay = inputItem.PersFghDay,  
  
		PersFghDescr = inputItem.PersFghDescr, 
            };
            return dto;
        }

        public static List<HrmPersFghDto> Map(ICollection<HrmPersFgh> entities)
        {
            var dtos = new List<HrmPersFghDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersFghDto()
                {
                      
  
		PersFghId = inputItem.PersFghId,  
  
		PersFghPersRef = inputItem.PersFghPersRef,  
  
		PersFghDate = inputItem.PersFghDate,  
  
		PersFghType = inputItem.PersFghType,  
  
		PersFghDay = inputItem.PersFghDay,  
  
		PersFghDescr = inputItem.PersFghDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersLang Map(AddHrmPersLangCommand inputItem)
        {
            var entity = new HrmPersLang() {
                  
  
		PersLangId = inputItem.PersLangId,  
  
		PersLangPersRef = inputItem.PersLangPersRef,  
  
		PersLangDate = inputItem.PersLangDate,  
  
		PersLangRef = inputItem.PersLangRef,  
  
		PersLangDegName = inputItem.PersLangDegName,  
  
		PersLangRead = inputItem.PersLangRead,  
  
		PersLangWrite = inputItem.PersLangWrite,  
  
		PersLangTalk = inputItem.PersLangTalk, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersLang Map(HrmPersLang entity ,EditHrmPersLangCommand inputItem)
        {
              
  
		entity.PersLangId = inputItem.PersLangId;  
  
		entity.PersLangPersRef = inputItem.PersLangPersRef;  
  
		entity.PersLangDate = inputItem.PersLangDate;  
  
		entity.PersLangRef = inputItem.PersLangRef;  
  
		entity.PersLangDegName = inputItem.PersLangDegName;  
  
		entity.PersLangRead = inputItem.PersLangRead;  
  
		entity.PersLangWrite = inputItem.PersLangWrite;  
  
		entity.PersLangTalk = inputItem.PersLangTalk; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersLangDto Map(HrmPersLang inputItem)
        {
            var dto = new HrmPersLangDto()
            {
                  
  
		PersLangId = inputItem.PersLangId,  
  
		PersLangPersRef = inputItem.PersLangPersRef,  
  
		PersLangDate = inputItem.PersLangDate,  
  
		PersLangRef = inputItem.PersLangRef,  
  
		PersLangDegName = inputItem.PersLangDegName,  
  
		PersLangRead = inputItem.PersLangRead,  
  
		PersLangWrite = inputItem.PersLangWrite,  
  
		PersLangTalk = inputItem.PersLangTalk, 
            };
            return dto;
        }

        public static List<HrmPersLangDto> Map(ICollection<HrmPersLang> entities)
        {
            var dtos = new List<HrmPersLangDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersLangDto()
                {
                      
  
		PersLangId = inputItem.PersLangId,  
  
		PersLangPersRef = inputItem.PersLangPersRef,  
  
		PersLangDate = inputItem.PersLangDate,  
  
		PersLangRef = inputItem.PersLangRef,  
  
		PersLangDegName = inputItem.PersLangDegName,  
  
		PersLangRead = inputItem.PersLangRead,  
  
		PersLangWrite = inputItem.PersLangWrite,  
  
		PersLangTalk = inputItem.PersLangTalk, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersMrg Map(AddHrmPersMrgCommand inputItem)
        {
            var entity = new HrmPersMrg() {
                  
  
		PersMrgId = inputItem.PersMrgId,  
  
		PMgPersRef = inputItem.PMgPersRef,  
  
		PersMrgSit = inputItem.PersMrgSit,  
  
		PersMrgDate = inputItem.PersMrgDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersMrg Map(HrmPersMrg entity ,EditHrmPersMrgCommand inputItem)
        {
              
  
		entity.PersMrgId = inputItem.PersMrgId;  
  
		entity.PMgPersRef = inputItem.PMgPersRef;  
  
		entity.PersMrgSit = inputItem.PersMrgSit;  
  
		entity.PersMrgDate = inputItem.PersMrgDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersMrgDto Map(HrmPersMrg inputItem)
        {
            var dto = new HrmPersMrgDto()
            {
                  
  
		PersMrgId = inputItem.PersMrgId,  
  
		PMgPersRef = inputItem.PMgPersRef,  
  
		PersMrgSit = inputItem.PersMrgSit,  
  
		PersMrgDate = inputItem.PersMrgDate, 
            };
            return dto;
        }

        public static List<HrmPersMrgDto> Map(ICollection<HrmPersMrg> entities)
        {
            var dtos = new List<HrmPersMrgDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersMrgDto()
                {
                      
  
		PersMrgId = inputItem.PersMrgId,  
  
		PMgPersRef = inputItem.PMgPersRef,  
  
		PersMrgSit = inputItem.PersMrgSit,  
  
		PersMrgDate = inputItem.PersMrgDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersonnels Map(AddHrmPersonnelsCommand inputItem)
        {
            var entity = new HrmPersonnels() {
                  
  
		HrmPersID = inputItem.HrmPersID,  
  
		HPrsCrspndRef = inputItem.HPrsCrspndRef,  
  
		HrmPersCode = inputItem.HrmPersCode,  
  
		HPrsFatherName = inputItem.HPrsFatherName,  
  
		HPrsCertNo = inputItem.HPrsCertNo,  
  
		HPrsBirthDate = inputItem.HPrsBirthDate,  
  
		HPrsBirthLocRef = inputItem.HPrsBirthLocRef,  
  
		HPrsSex = inputItem.HPrsSex,  
  
		HPrsIssuedIDLoc = inputItem.HPrsIssuedIDLoc,  
  
		HPrsIssueDate = inputItem.HPrsIssueDate,  
  
		HPrsBloodGroup = inputItem.HPrsBloodGroup,  
  
		HPrsCertSerial = inputItem.HPrsCertSerial,  
  
		HPrsNatCode = inputItem.HPrsNatCode,  
  
		HPrsNat = inputItem.HPrsNat,  
  
		HPrsWebPass = inputItem.HPrsWebPass,  
  
		HPrsFmtRef = inputItem.HPrsFmtRef,  
  
		HPrsPic = inputItem.HPrsPic,  
  
		HPrsSign = inputItem.HPrsSign,  
  
		HPrsWebSit = inputItem.HPrsWebSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersonnels Map(HrmPersonnels entity ,EditHrmPersonnelsCommand inputItem)
        {
              
  
		entity.HrmPersID = inputItem.HrmPersID;  
  
		entity.HPrsCrspndRef = inputItem.HPrsCrspndRef;  
  
		entity.HrmPersCode = inputItem.HrmPersCode;  
  
		entity.HPrsFatherName = inputItem.HPrsFatherName;  
  
		entity.HPrsCertNo = inputItem.HPrsCertNo;  
  
		entity.HPrsBirthDate = inputItem.HPrsBirthDate;  
  
		entity.HPrsBirthLocRef = inputItem.HPrsBirthLocRef;  
  
		entity.HPrsSex = inputItem.HPrsSex;  
  
		entity.HPrsIssuedIDLoc = inputItem.HPrsIssuedIDLoc;  
  
		entity.HPrsIssueDate = inputItem.HPrsIssueDate;  
  
		entity.HPrsBloodGroup = inputItem.HPrsBloodGroup;  
  
		entity.HPrsCertSerial = inputItem.HPrsCertSerial;  
  
		entity.HPrsNatCode = inputItem.HPrsNatCode;  
  
		entity.HPrsNat = inputItem.HPrsNat;  
  
		entity.HPrsWebPass = inputItem.HPrsWebPass;  
  
		entity.HPrsFmtRef = inputItem.HPrsFmtRef;  
  
		entity.HPrsPic = inputItem.HPrsPic;  
  
		entity.HPrsSign = inputItem.HPrsSign;  
  
		entity.HPrsWebSit = inputItem.HPrsWebSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersonnelsDto Map(HrmPersonnels inputItem)
        {
            var dto = new HrmPersonnelsDto()
            {
                  
  
		HrmPersID = inputItem.HrmPersID,  
  
		HPrsCrspndRef = inputItem.HPrsCrspndRef,  
  
		HrmPersCode = inputItem.HrmPersCode,  
  
		HPrsFatherName = inputItem.HPrsFatherName,  
  
		HPrsCertNo = inputItem.HPrsCertNo,  
  
		HPrsBirthDate = inputItem.HPrsBirthDate,  
  
		HPrsBirthLocRef = inputItem.HPrsBirthLocRef,  
  
		HPrsSex = inputItem.HPrsSex,  
  
		HPrsIssuedIDLoc = inputItem.HPrsIssuedIDLoc,  
  
		HPrsIssueDate = inputItem.HPrsIssueDate,  
  
		HPrsBloodGroup = inputItem.HPrsBloodGroup,  
  
		HPrsCertSerial = inputItem.HPrsCertSerial,  
  
		HPrsNatCode = inputItem.HPrsNatCode,  
  
		HPrsNat = inputItem.HPrsNat,  
  
		HPrsWebPass = inputItem.HPrsWebPass,  
  
		HPrsFmtRef = inputItem.HPrsFmtRef,  
  
		HPrsPic = inputItem.HPrsPic,  
  
		HPrsSign = inputItem.HPrsSign,  
  
		HPrsWebSit = inputItem.HPrsWebSit, 
            };
            return dto;
        }

        public static List<HrmPersonnelsDto> Map(ICollection<HrmPersonnels> entities)
        {
            var dtos = new List<HrmPersonnelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersonnelsDto()
                {
                      
  
		HrmPersID = inputItem.HrmPersID,  
  
		HPrsCrspndRef = inputItem.HPrsCrspndRef,  
  
		HrmPersCode = inputItem.HrmPersCode,  
  
		HPrsFatherName = inputItem.HPrsFatherName,  
  
		HPrsCertNo = inputItem.HPrsCertNo,  
  
		HPrsBirthDate = inputItem.HPrsBirthDate,  
  
		HPrsBirthLocRef = inputItem.HPrsBirthLocRef,  
  
		HPrsSex = inputItem.HPrsSex,  
  
		HPrsIssuedIDLoc = inputItem.HPrsIssuedIDLoc,  
  
		HPrsIssueDate = inputItem.HPrsIssueDate,  
  
		HPrsBloodGroup = inputItem.HPrsBloodGroup,  
  
		HPrsCertSerial = inputItem.HPrsCertSerial,  
  
		HPrsNatCode = inputItem.HPrsNatCode,  
  
		HPrsNat = inputItem.HPrsNat,  
  
		HPrsWebPass = inputItem.HPrsWebPass,  
  
		HPrsFmtRef = inputItem.HPrsFmtRef,  
  
		HPrsPic = inputItem.HPrsPic,  
  
		HPrsSign = inputItem.HPrsSign,  
  
		HPrsWebSit = inputItem.HPrsWebSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersParam Map(AddHrmPersParamCommand inputItem)
        {
            var entity = new HrmPersParam() {
                  
  
		HrmPersParamId = inputItem.HrmPersParamId,  
  
		HPPTitle = inputItem.HPPTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersParam Map(HrmPersParam entity ,EditHrmPersParamCommand inputItem)
        {
              
  
		entity.HrmPersParamId = inputItem.HrmPersParamId;  
  
		entity.HPPTitle = inputItem.HPPTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersParamDto Map(HrmPersParam inputItem)
        {
            var dto = new HrmPersParamDto()
            {
                  
  
		HrmPersParamId = inputItem.HrmPersParamId,  
  
		HPPTitle = inputItem.HPPTitle, 
            };
            return dto;
        }

        public static List<HrmPersParamDto> Map(ICollection<HrmPersParam> entities)
        {
            var dtos = new List<HrmPersParamDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersParamDto()
                {
                      
  
		HrmPersParamId = inputItem.HrmPersParamId,  
  
		HPPTitle = inputItem.HPPTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersRltd Map(AddHrmPersRltdCommand inputItem)
        {
            var entity = new HrmPersRltd() {
                  
  
		PersRltdId = inputItem.PersRltdId,  
  
		PersRltdPersRef = inputItem.PersRltdPersRef,  
  
		PersRltdBDate = inputItem.PersRltdBDate,  
  
		PersRltdFullName = inputItem.PersRltdFullName,  
  
		PersRltdType = inputItem.PersRltdType,  
  
		PersRltdHaveInsu = inputItem.PersRltdHaveInsu, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersRltd Map(HrmPersRltd entity ,EditHrmPersRltdCommand inputItem)
        {
              
  
		entity.PersRltdId = inputItem.PersRltdId;  
  
		entity.PersRltdPersRef = inputItem.PersRltdPersRef;  
  
		entity.PersRltdBDate = inputItem.PersRltdBDate;  
  
		entity.PersRltdFullName = inputItem.PersRltdFullName;  
  
		entity.PersRltdType = inputItem.PersRltdType;  
  
		entity.PersRltdHaveInsu = inputItem.PersRltdHaveInsu; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersRltdDto Map(HrmPersRltd inputItem)
        {
            var dto = new HrmPersRltdDto()
            {
                  
  
		PersRltdId = inputItem.PersRltdId,  
  
		PersRltdPersRef = inputItem.PersRltdPersRef,  
  
		PersRltdBDate = inputItem.PersRltdBDate,  
  
		PersRltdFullName = inputItem.PersRltdFullName,  
  
		PersRltdType = inputItem.PersRltdType,  
  
		PersRltdHaveInsu = inputItem.PersRltdHaveInsu, 
            };
            return dto;
        }

        public static List<HrmPersRltdDto> Map(ICollection<HrmPersRltd> entities)
        {
            var dtos = new List<HrmPersRltdDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersRltdDto()
                {
                      
  
		PersRltdId = inputItem.PersRltdId,  
  
		PersRltdPersRef = inputItem.PersRltdPersRef,  
  
		PersRltdBDate = inputItem.PersRltdBDate,  
  
		PersRltdFullName = inputItem.PersRltdFullName,  
  
		PersRltdType = inputItem.PersRltdType,  
  
		PersRltdHaveInsu = inputItem.PersRltdHaveInsu, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPersSldr Map(AddHrmPersSldrCommand inputItem)
        {
            var entity = new HrmPersSldr() {
                  
  
		PersSoldrId = inputItem.PersSoldrId,  
  
		PersSoldrPersRef = inputItem.PersSoldrPersRef,  
  
		PersSoldrDate = inputItem.PersSoldrDate,  
  
		PersSoldrSit = inputItem.PersSoldrSit,  
  
		PersSoldrDescr = inputItem.PersSoldrDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPersSldr Map(HrmPersSldr entity ,EditHrmPersSldrCommand inputItem)
        {
              
  
		entity.PersSoldrId = inputItem.PersSoldrId;  
  
		entity.PersSoldrPersRef = inputItem.PersSoldrPersRef;  
  
		entity.PersSoldrDate = inputItem.PersSoldrDate;  
  
		entity.PersSoldrSit = inputItem.PersSoldrSit;  
  
		entity.PersSoldrDescr = inputItem.PersSoldrDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPersSldrDto Map(HrmPersSldr inputItem)
        {
            var dto = new HrmPersSldrDto()
            {
                  
  
		PersSoldrId = inputItem.PersSoldrId,  
  
		PersSoldrPersRef = inputItem.PersSoldrPersRef,  
  
		PersSoldrDate = inputItem.PersSoldrDate,  
  
		PersSoldrSit = inputItem.PersSoldrSit,  
  
		PersSoldrDescr = inputItem.PersSoldrDescr, 
            };
            return dto;
        }

        public static List<HrmPersSldrDto> Map(ICollection<HrmPersSldr> entities)
        {
            var dtos = new List<HrmPersSldrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPersSldrDto()
                {
                      
  
		PersSoldrId = inputItem.PersSoldrId,  
  
		PersSoldrPersRef = inputItem.PersSoldrPersRef,  
  
		PersSoldrDate = inputItem.PersSoldrDate,  
  
		PersSoldrSit = inputItem.PersSoldrSit,  
  
		PersSoldrDescr = inputItem.PersSoldrDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmPrsntStat Map(AddHrmPrsntStatCommand inputItem)
        {
            var entity = new HrmPrsntStat() {
                  
  
		HrmPrsntStatId = inputItem.HrmPrsntStatId,  
  
		HPSType = inputItem.HPSType,  
  
		HPSNum = inputItem.HPSNum,  
  
		HPSDate = inputItem.HPSDate,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSFromDate = inputItem.HPSFromDate,  
  
		HPSToDate = inputItem.HPSToDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmPrsntStat Map(HrmPrsntStat entity ,EditHrmPrsntStatCommand inputItem)
        {
              
  
		entity.HrmPrsntStatId = inputItem.HrmPrsntStatId;  
  
		entity.HPSType = inputItem.HPSType;  
  
		entity.HPSNum = inputItem.HPSNum;  
  
		entity.HPSDate = inputItem.HPSDate;  
  
		entity.HPSPersRef = inputItem.HPSPersRef;  
  
		entity.HPSFromDate = inputItem.HPSFromDate;  
  
		entity.HPSToDate = inputItem.HPSToDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmPrsntStatDto Map(HrmPrsntStat inputItem)
        {
            var dto = new HrmPrsntStatDto()
            {
                  
  
		HrmPrsntStatId = inputItem.HrmPrsntStatId,  
  
		HPSType = inputItem.HPSType,  
  
		HPSNum = inputItem.HPSNum,  
  
		HPSDate = inputItem.HPSDate,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSFromDate = inputItem.HPSFromDate,  
  
		HPSToDate = inputItem.HPSToDate, 
            };
            return dto;
        }

        public static List<HrmPrsntStatDto> Map(ICollection<HrmPrsntStat> entities)
        {
            var dtos = new List<HrmPrsntStatDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmPrsntStatDto()
                {
                      
  
		HrmPrsntStatId = inputItem.HrmPrsntStatId,  
  
		HPSType = inputItem.HPSType,  
  
		HPSNum = inputItem.HPSNum,  
  
		HPSDate = inputItem.HPSDate,  
  
		HPSPersRef = inputItem.HPSPersRef,  
  
		HPSFromDate = inputItem.HPSFromDate,  
  
		HPSToDate = inputItem.HPSToDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmRqstMission Map(AddHrmRqstMissionCommand inputItem)
        {
            var entity = new HrmRqstMission() {
                  
  
		HrmRqstMissionId = inputItem.HrmRqstMissionId,  
  
		HRMMissionRef = inputItem.HRMMissionRef,  
  
		HRMNum = inputItem.HRMNum,  
  
		HRMDate = inputItem.HRMDate,  
  
		HRMPersRef = inputItem.HRMPersRef,  
  
		HRMType = inputItem.HRMType,  
  
		HRMFromDate = inputItem.HRMFromDate,  
  
		HRMFromTime = inputItem.HRMFromTime,  
  
		HRMToDate = inputItem.HRMToDate,  
  
		HRMToTime = inputItem.HRMToTime,  
  
		HRMCityRef = inputItem.HRMCityRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmRqstMission Map(HrmRqstMission entity ,EditHrmRqstMissionCommand inputItem)
        {
              
  
		entity.HrmRqstMissionId = inputItem.HrmRqstMissionId;  
  
		entity.HRMMissionRef = inputItem.HRMMissionRef;  
  
		entity.HRMNum = inputItem.HRMNum;  
  
		entity.HRMDate = inputItem.HRMDate;  
  
		entity.HRMPersRef = inputItem.HRMPersRef;  
  
		entity.HRMType = inputItem.HRMType;  
  
		entity.HRMFromDate = inputItem.HRMFromDate;  
  
		entity.HRMFromTime = inputItem.HRMFromTime;  
  
		entity.HRMToDate = inputItem.HRMToDate;  
  
		entity.HRMToTime = inputItem.HRMToTime;  
  
		entity.HRMCityRef = inputItem.HRMCityRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmRqstMissionDto Map(HrmRqstMission inputItem)
        {
            var dto = new HrmRqstMissionDto()
            {
                  
  
		HrmRqstMissionId = inputItem.HrmRqstMissionId,  
  
		HRMMissionRef = inputItem.HRMMissionRef,  
  
		HRMNum = inputItem.HRMNum,  
  
		HRMDate = inputItem.HRMDate,  
  
		HRMPersRef = inputItem.HRMPersRef,  
  
		HRMType = inputItem.HRMType,  
  
		HRMFromDate = inputItem.HRMFromDate,  
  
		HRMFromTime = inputItem.HRMFromTime,  
  
		HRMToDate = inputItem.HRMToDate,  
  
		HRMToTime = inputItem.HRMToTime,  
  
		HRMCityRef = inputItem.HRMCityRef, 
            };
            return dto;
        }

        public static List<HrmRqstMissionDto> Map(ICollection<HrmRqstMission> entities)
        {
            var dtos = new List<HrmRqstMissionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmRqstMissionDto()
                {
                      
  
		HrmRqstMissionId = inputItem.HrmRqstMissionId,  
  
		HRMMissionRef = inputItem.HRMMissionRef,  
  
		HRMNum = inputItem.HRMNum,  
  
		HRMDate = inputItem.HRMDate,  
  
		HRMPersRef = inputItem.HRMPersRef,  
  
		HRMType = inputItem.HRMType,  
  
		HRMFromDate = inputItem.HRMFromDate,  
  
		HRMFromTime = inputItem.HRMFromTime,  
  
		HRMToDate = inputItem.HRMToDate,  
  
		HRMToTime = inputItem.HRMToTime,  
  
		HRMCityRef = inputItem.HRMCityRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmRqstVac Map(AddHrmRqstVacCommand inputItem)
        {
            var entity = new HrmRqstVac() {
                  
  
		HrmRqstVacId = inputItem.HrmRqstVacId,  
  
		HRVVacRef = inputItem.HRVVacRef,  
  
		HRVNum = inputItem.HRVNum,  
  
		HRVDate = inputItem.HRVDate,  
  
		HRVPersRef = inputItem.HRVPersRef,  
  
		HRVType = inputItem.HRVType,  
  
		HRVFromDate = inputItem.HRVFromDate,  
  
		HRVFromTime = inputItem.HRVFromTime,  
  
		HRVToDate = inputItem.HRVToDate,  
  
		HRVToTime = inputItem.HRVToTime, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmRqstVac Map(HrmRqstVac entity ,EditHrmRqstVacCommand inputItem)
        {
              
  
		entity.HrmRqstVacId = inputItem.HrmRqstVacId;  
  
		entity.HRVVacRef = inputItem.HRVVacRef;  
  
		entity.HRVNum = inputItem.HRVNum;  
  
		entity.HRVDate = inputItem.HRVDate;  
  
		entity.HRVPersRef = inputItem.HRVPersRef;  
  
		entity.HRVType = inputItem.HRVType;  
  
		entity.HRVFromDate = inputItem.HRVFromDate;  
  
		entity.HRVFromTime = inputItem.HRVFromTime;  
  
		entity.HRVToDate = inputItem.HRVToDate;  
  
		entity.HRVToTime = inputItem.HRVToTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmRqstVacDto Map(HrmRqstVac inputItem)
        {
            var dto = new HrmRqstVacDto()
            {
                  
  
		HrmRqstVacId = inputItem.HrmRqstVacId,  
  
		HRVVacRef = inputItem.HRVVacRef,  
  
		HRVNum = inputItem.HRVNum,  
  
		HRVDate = inputItem.HRVDate,  
  
		HRVPersRef = inputItem.HRVPersRef,  
  
		HRVType = inputItem.HRVType,  
  
		HRVFromDate = inputItem.HRVFromDate,  
  
		HRVFromTime = inputItem.HRVFromTime,  
  
		HRVToDate = inputItem.HRVToDate,  
  
		HRVToTime = inputItem.HRVToTime, 
            };
            return dto;
        }

        public static List<HrmRqstVacDto> Map(ICollection<HrmRqstVac> entities)
        {
            var dtos = new List<HrmRqstVacDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmRqstVacDto()
                {
                      
  
		HrmRqstVacId = inputItem.HrmRqstVacId,  
  
		HRVVacRef = inputItem.HRVVacRef,  
  
		HRVNum = inputItem.HRVNum,  
  
		HRVDate = inputItem.HRVDate,  
  
		HRVPersRef = inputItem.HRVPersRef,  
  
		HRVType = inputItem.HRVType,  
  
		HRVFromDate = inputItem.HRVFromDate,  
  
		HRVFromTime = inputItem.HRVFromTime,  
  
		HRVToDate = inputItem.HRVToDate,  
  
		HRVToTime = inputItem.HRVToTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmStatElmntMthd Map(AddHrmStatElmntMthdCommand inputItem)
        {
            var entity = new HrmStatElmntMthd() {
                  
  
		HrmStatElmntMthdId = inputItem.HrmStatElmntMthdId,  
  
		HSEMElmntRef = inputItem.HSEMElmntRef,  
  
		HSEMEmpRef = inputItem.HSEMEmpRef,  
  
		HSEMIYear = inputItem.HSEMIYear,  
  
		HSEMIMonth = inputItem.HSEMIMonth,  
  
		HSEMEYear = inputItem.HSEMEYear,  
  
		HSEMEMonth = inputItem.HSEMEMonth,  
  
		HSEMIYearMonth = inputItem.HSEMIYearMonth,  
  
		HSEMEYearMonth = inputItem.HSEMEYearMonth,  
  
		HSEMAct = inputItem.HSEMAct,  
  
		HSEMFormula = inputItem.HSEMFormula, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmStatElmntMthd Map(HrmStatElmntMthd entity ,EditHrmStatElmntMthdCommand inputItem)
        {
              
  
		entity.HrmStatElmntMthdId = inputItem.HrmStatElmntMthdId;  
  
		entity.HSEMElmntRef = inputItem.HSEMElmntRef;  
  
		entity.HSEMEmpRef = inputItem.HSEMEmpRef;  
  
		entity.HSEMIYear = inputItem.HSEMIYear;  
  
		entity.HSEMIMonth = inputItem.HSEMIMonth;  
  
		entity.HSEMEYear = inputItem.HSEMEYear;  
  
		entity.HSEMEMonth = inputItem.HSEMEMonth;  
  
		entity.HSEMIYearMonth = inputItem.HSEMIYearMonth;  
  
		entity.HSEMEYearMonth = inputItem.HSEMEYearMonth;  
  
		entity.HSEMAct = inputItem.HSEMAct;  
  
		entity.HSEMFormula = inputItem.HSEMFormula; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmStatElmntMthdDto Map(HrmStatElmntMthd inputItem)
        {
            var dto = new HrmStatElmntMthdDto()
            {
                  
  
		HrmStatElmntMthdId = inputItem.HrmStatElmntMthdId,  
  
		HSEMElmntRef = inputItem.HSEMElmntRef,  
  
		HSEMEmpRef = inputItem.HSEMEmpRef,  
  
		HSEMIYear = inputItem.HSEMIYear,  
  
		HSEMIMonth = inputItem.HSEMIMonth,  
  
		HSEMEYear = inputItem.HSEMEYear,  
  
		HSEMEMonth = inputItem.HSEMEMonth,  
  
		HSEMIYearMonth = inputItem.HSEMIYearMonth,  
  
		HSEMEYearMonth = inputItem.HSEMEYearMonth,  
  
		HSEMAct = inputItem.HSEMAct,  
  
		HSEMFormula = inputItem.HSEMFormula, 
            };
            return dto;
        }

        public static List<HrmStatElmntMthdDto> Map(ICollection<HrmStatElmntMthd> entities)
        {
            var dtos = new List<HrmStatElmntMthdDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmStatElmntMthdDto()
                {
                      
  
		HrmStatElmntMthdId = inputItem.HrmStatElmntMthdId,  
  
		HSEMElmntRef = inputItem.HSEMElmntRef,  
  
		HSEMEmpRef = inputItem.HSEMEmpRef,  
  
		HSEMIYear = inputItem.HSEMIYear,  
  
		HSEMIMonth = inputItem.HSEMIMonth,  
  
		HSEMEYear = inputItem.HSEMEYear,  
  
		HSEMEMonth = inputItem.HSEMEMonth,  
  
		HSEMIYearMonth = inputItem.HSEMIYearMonth,  
  
		HSEMEYearMonth = inputItem.HSEMEYearMonth,  
  
		HSEMAct = inputItem.HSEMAct,  
  
		HSEMFormula = inputItem.HSEMFormula, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmStatMthdDet Map(AddHrmStatMthdDetCommand inputItem)
        {
            var entity = new HrmStatMthdDet() {
                  
  
		HrmStatMthdDetId = inputItem.HrmStatMthdDetId,  
  
		HSMDMthdRef = inputItem.HSMDMthdRef,  
  
		HSMDParamName = inputItem.HSMDParamName,  
  
		HSMDParamTitle = inputItem.HSMDParamTitle,  
  
		HSMDMainParam = inputItem.HSMDMainParam, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmStatMthdDet Map(HrmStatMthdDet entity ,EditHrmStatMthdDetCommand inputItem)
        {
              
  
		entity.HrmStatMthdDetId = inputItem.HrmStatMthdDetId;  
  
		entity.HSMDMthdRef = inputItem.HSMDMthdRef;  
  
		entity.HSMDParamName = inputItem.HSMDParamName;  
  
		entity.HSMDParamTitle = inputItem.HSMDParamTitle;  
  
		entity.HSMDMainParam = inputItem.HSMDMainParam; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmStatMthdDetDto Map(HrmStatMthdDet inputItem)
        {
            var dto = new HrmStatMthdDetDto()
            {
                  
  
		HrmStatMthdDetId = inputItem.HrmStatMthdDetId,  
  
		HSMDMthdRef = inputItem.HSMDMthdRef,  
  
		HSMDParamName = inputItem.HSMDParamName,  
  
		HSMDParamTitle = inputItem.HSMDParamTitle,  
  
		HSMDMainParam = inputItem.HSMDMainParam, 
            };
            return dto;
        }

        public static List<HrmStatMthdDetDto> Map(ICollection<HrmStatMthdDet> entities)
        {
            var dtos = new List<HrmStatMthdDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmStatMthdDetDto()
                {
                      
  
		HrmStatMthdDetId = inputItem.HrmStatMthdDetId,  
  
		HSMDMthdRef = inputItem.HSMDMthdRef,  
  
		HSMDParamName = inputItem.HSMDParamName,  
  
		HSMDParamTitle = inputItem.HSMDParamTitle,  
  
		HSMDMainParam = inputItem.HSMDMainParam, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmStatTypes Map(AddHrmStatTypesCommand inputItem)
        {
            var entity = new HrmStatTypes() {
                  
  
		HrmStatTypeId = inputItem.HrmStatTypeId,  
  
		HSTDescr = inputItem.HSTDescr,  
  
		HSTKind = inputItem.HSTKind,  
  
		HSTRole = inputItem.HSTRole,  
  
		HSTExElmnt = inputItem.HSTExElmnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmStatTypes Map(HrmStatTypes entity ,EditHrmStatTypesCommand inputItem)
        {
              
  
		entity.HrmStatTypeId = inputItem.HrmStatTypeId;  
  
		entity.HSTDescr = inputItem.HSTDescr;  
  
		entity.HSTKind = inputItem.HSTKind;  
  
		entity.HSTRole = inputItem.HSTRole;  
  
		entity.HSTExElmnt = inputItem.HSTExElmnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmStatTypesDto Map(HrmStatTypes inputItem)
        {
            var dto = new HrmStatTypesDto()
            {
                  
  
		HrmStatTypeId = inputItem.HrmStatTypeId,  
  
		HSTDescr = inputItem.HSTDescr,  
  
		HSTKind = inputItem.HSTKind,  
  
		HSTRole = inputItem.HSTRole,  
  
		HSTExElmnt = inputItem.HSTExElmnt, 
            };
            return dto;
        }

        public static List<HrmStatTypesDto> Map(ICollection<HrmStatTypes> entities)
        {
            var dtos = new List<HrmStatTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmStatTypesDto()
                {
                      
  
		HrmStatTypeId = inputItem.HrmStatTypeId,  
  
		HSTDescr = inputItem.HSTDescr,  
  
		HSTKind = inputItem.HSTKind,  
  
		HSTRole = inputItem.HSTRole,  
  
		HSTExElmnt = inputItem.HSTExElmnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmTables Map(AddHrmTablesCommand inputItem)
        {
            var entity = new HrmTables() {
                  
  
		HrmTablesId = inputItem.HrmTablesId,  
  
		HTTitle = inputItem.HTTitle,  
  
		HTLevel = inputItem.HTLevel,  
  
		HTKind = inputItem.HTKind,  
  
		HTField1 = inputItem.HTField1,  
  
		HTField2 = inputItem.HTField2,  
  
		HTField3 = inputItem.HTField3, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmTables Map(HrmTables entity ,EditHrmTablesCommand inputItem)
        {
              
  
		entity.HrmTablesId = inputItem.HrmTablesId;  
  
		entity.HTTitle = inputItem.HTTitle;  
  
		entity.HTLevel = inputItem.HTLevel;  
  
		entity.HTKind = inputItem.HTKind;  
  
		entity.HTField1 = inputItem.HTField1;  
  
		entity.HTField2 = inputItem.HTField2;  
  
		entity.HTField3 = inputItem.HTField3; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmTablesDto Map(HrmTables inputItem)
        {
            var dto = new HrmTablesDto()
            {
                  
  
		HrmTablesId = inputItem.HrmTablesId,  
  
		HTTitle = inputItem.HTTitle,  
  
		HTLevel = inputItem.HTLevel,  
  
		HTKind = inputItem.HTKind,  
  
		HTField1 = inputItem.HTField1,  
  
		HTField2 = inputItem.HTField2,  
  
		HTField3 = inputItem.HTField3, 
            };
            return dto;
        }

        public static List<HrmTablesDto> Map(ICollection<HrmTables> entities)
        {
            var dtos = new List<HrmTablesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmTablesDto()
                {
                      
  
		HrmTablesId = inputItem.HrmTablesId,  
  
		HTTitle = inputItem.HTTitle,  
  
		HTLevel = inputItem.HTLevel,  
  
		HTKind = inputItem.HTKind,  
  
		HTField1 = inputItem.HTField1,  
  
		HTField2 = inputItem.HTField2,  
  
		HTField3 = inputItem.HTField3, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmTablesDet Map(AddHrmTablesDetCommand inputItem)
        {
            var entity = new HrmTablesDet() {
                  
  
		HrmTablesDetId = inputItem.HrmTablesDetId,  
  
		HTDHdrRef = inputItem.HTDHdrRef,  
  
		HTDFVal1 = inputItem.HTDFVal1,  
  
		HTDEVal1 = inputItem.HTDEVal1,  
  
		HTDFVal2 = inputItem.HTDFVal2,  
  
		HTDEVal2 = inputItem.HTDEVal2,  
  
		HTDFVal3 = inputItem.HTDFVal3,  
  
		HTDEVal3 = inputItem.HTDEVal3,  
  
		HTDOutVal = inputItem.HTDOutVal,  
  
		HTDDescr = inputItem.HTDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmTablesDet Map(HrmTablesDet entity ,EditHrmTablesDetCommand inputItem)
        {
              
  
		entity.HrmTablesDetId = inputItem.HrmTablesDetId;  
  
		entity.HTDHdrRef = inputItem.HTDHdrRef;  
  
		entity.HTDFVal1 = inputItem.HTDFVal1;  
  
		entity.HTDEVal1 = inputItem.HTDEVal1;  
  
		entity.HTDFVal2 = inputItem.HTDFVal2;  
  
		entity.HTDEVal2 = inputItem.HTDEVal2;  
  
		entity.HTDFVal3 = inputItem.HTDFVal3;  
  
		entity.HTDEVal3 = inputItem.HTDEVal3;  
  
		entity.HTDOutVal = inputItem.HTDOutVal;  
  
		entity.HTDDescr = inputItem.HTDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmTablesDetDto Map(HrmTablesDet inputItem)
        {
            var dto = new HrmTablesDetDto()
            {
                  
  
		HrmTablesDetId = inputItem.HrmTablesDetId,  
  
		HTDHdrRef = inputItem.HTDHdrRef,  
  
		HTDFVal1 = inputItem.HTDFVal1,  
  
		HTDEVal1 = inputItem.HTDEVal1,  
  
		HTDFVal2 = inputItem.HTDFVal2,  
  
		HTDEVal2 = inputItem.HTDEVal2,  
  
		HTDFVal3 = inputItem.HTDFVal3,  
  
		HTDEVal3 = inputItem.HTDEVal3,  
  
		HTDOutVal = inputItem.HTDOutVal,  
  
		HTDDescr = inputItem.HTDDescr, 
            };
            return dto;
        }

        public static List<HrmTablesDetDto> Map(ICollection<HrmTablesDet> entities)
        {
            var dtos = new List<HrmTablesDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmTablesDetDto()
                {
                      
  
		HrmTablesDetId = inputItem.HrmTablesDetId,  
  
		HTDHdrRef = inputItem.HTDHdrRef,  
  
		HTDFVal1 = inputItem.HTDFVal1,  
  
		HTDEVal1 = inputItem.HTDEVal1,  
  
		HTDFVal2 = inputItem.HTDFVal2,  
  
		HTDEVal2 = inputItem.HTDEVal2,  
  
		HTDFVal3 = inputItem.HTDFVal3,  
  
		HTDEVal3 = inputItem.HTDEVal3,  
  
		HTDOutVal = inputItem.HTDOutVal,  
  
		HTDDescr = inputItem.HTDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmTimeSheet Map(AddHrmTimeSheetCommand inputItem)
        {
            var entity = new HrmTimeSheet() {
                  
  
		HTSPersRef = inputItem.HTSPersRef,  
  
		HTSDate = inputItem.HTSDate,  
  
		HTSEnt1 = inputItem.HTSEnt1,  
  
		HTSExt1 = inputItem.HTSExt1,  
  
		HTSEnt2 = inputItem.HTSEnt2,  
  
		HTSExt2 = inputItem.HTSExt2,  
  
		HTSEnt3 = inputItem.HTSEnt3,  
  
		HTSExt3 = inputItem.HTSExt3,  
  
		HTSVac1Type = inputItem.HTSVac1Type,  
  
		HTSVacBg1 = inputItem.HTSVacBg1,  
  
		HTSVacEx1 = inputItem.HTSVacEx1,  
  
		HTSVac2Type = inputItem.HTSVac2Type,  
  
		HTSVacBg2 = inputItem.HTSVacBg2,  
  
		HTSVacEx2 = inputItem.HTSVacEx2,  
  
		HTSMis1Type = inputItem.HTSMis1Type,  
  
		HTSMisBg1 = inputItem.HTSMisBg1,  
  
		HTSMisEx1 = inputItem.HTSMisEx1,  
  
		HTSMis2Type = inputItem.HTSMis2Type,  
  
		HTSMisBg2 = inputItem.HTSMisBg2,  
  
		HTSMisEx2 = inputItem.HTSMisEx2, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmTimeSheet Map(HrmTimeSheet entity ,EditHrmTimeSheetCommand inputItem)
        {
              
  
		entity.HTSPersRef = inputItem.HTSPersRef;  
  
		entity.HTSDate = inputItem.HTSDate;  
  
		entity.HTSEnt1 = inputItem.HTSEnt1;  
  
		entity.HTSExt1 = inputItem.HTSExt1;  
  
		entity.HTSEnt2 = inputItem.HTSEnt2;  
  
		entity.HTSExt2 = inputItem.HTSExt2;  
  
		entity.HTSEnt3 = inputItem.HTSEnt3;  
  
		entity.HTSExt3 = inputItem.HTSExt3;  
  
		entity.HTSVac1Type = inputItem.HTSVac1Type;  
  
		entity.HTSVacBg1 = inputItem.HTSVacBg1;  
  
		entity.HTSVacEx1 = inputItem.HTSVacEx1;  
  
		entity.HTSVac2Type = inputItem.HTSVac2Type;  
  
		entity.HTSVacBg2 = inputItem.HTSVacBg2;  
  
		entity.HTSVacEx2 = inputItem.HTSVacEx2;  
  
		entity.HTSMis1Type = inputItem.HTSMis1Type;  
  
		entity.HTSMisBg1 = inputItem.HTSMisBg1;  
  
		entity.HTSMisEx1 = inputItem.HTSMisEx1;  
  
		entity.HTSMis2Type = inputItem.HTSMis2Type;  
  
		entity.HTSMisBg2 = inputItem.HTSMisBg2;  
  
		entity.HTSMisEx2 = inputItem.HTSMisEx2; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmTimeSheetDto Map(HrmTimeSheet inputItem)
        {
            var dto = new HrmTimeSheetDto()
            {
                  
  
		HTSPersRef = inputItem.HTSPersRef,  
  
		HTSDate = inputItem.HTSDate,  
  
		HTSEnt1 = inputItem.HTSEnt1,  
  
		HTSExt1 = inputItem.HTSExt1,  
  
		HTSEnt2 = inputItem.HTSEnt2,  
  
		HTSExt2 = inputItem.HTSExt2,  
  
		HTSEnt3 = inputItem.HTSEnt3,  
  
		HTSExt3 = inputItem.HTSExt3,  
  
		HTSVac1Type = inputItem.HTSVac1Type,  
  
		HTSVacBg1 = inputItem.HTSVacBg1,  
  
		HTSVacEx1 = inputItem.HTSVacEx1,  
  
		HTSVac2Type = inputItem.HTSVac2Type,  
  
		HTSVacBg2 = inputItem.HTSVacBg2,  
  
		HTSVacEx2 = inputItem.HTSVacEx2,  
  
		HTSMis1Type = inputItem.HTSMis1Type,  
  
		HTSMisBg1 = inputItem.HTSMisBg1,  
  
		HTSMisEx1 = inputItem.HTSMisEx1,  
  
		HTSMis2Type = inputItem.HTSMis2Type,  
  
		HTSMisBg2 = inputItem.HTSMisBg2,  
  
		HTSMisEx2 = inputItem.HTSMisEx2, 
            };
            return dto;
        }

        public static List<HrmTimeSheetDto> Map(ICollection<HrmTimeSheet> entities)
        {
            var dtos = new List<HrmTimeSheetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmTimeSheetDto()
                {
                      
  
		HTSPersRef = inputItem.HTSPersRef,  
  
		HTSDate = inputItem.HTSDate,  
  
		HTSEnt1 = inputItem.HTSEnt1,  
  
		HTSExt1 = inputItem.HTSExt1,  
  
		HTSEnt2 = inputItem.HTSEnt2,  
  
		HTSExt2 = inputItem.HTSExt2,  
  
		HTSEnt3 = inputItem.HTSEnt3,  
  
		HTSExt3 = inputItem.HTSExt3,  
  
		HTSVac1Type = inputItem.HTSVac1Type,  
  
		HTSVacBg1 = inputItem.HTSVacBg1,  
  
		HTSVacEx1 = inputItem.HTSVacEx1,  
  
		HTSVac2Type = inputItem.HTSVac2Type,  
  
		HTSVacBg2 = inputItem.HTSVacBg2,  
  
		HTSVacEx2 = inputItem.HTSVacEx2,  
  
		HTSMis1Type = inputItem.HTSMis1Type,  
  
		HTSMisBg1 = inputItem.HTSMisBg1,  
  
		HTSMisEx1 = inputItem.HTSMisEx1,  
  
		HTSMis2Type = inputItem.HTSMis2Type,  
  
		HTSMisBg2 = inputItem.HTSMisBg2,  
  
		HTSMisEx2 = inputItem.HTSMisEx2, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmVacancy Map(AddHrmVacancyCommand inputItem)
        {
            var entity = new HrmVacancy() {
                  
  
		HrmVacancyId = inputItem.HrmVacancyId,  
  
		HVTitle = inputItem.HVTitle,  
  
		HVType = inputItem.HVType,  
  
		HVRole = inputItem.HVRole, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmVacancy Map(HrmVacancy entity ,EditHrmVacancyCommand inputItem)
        {
              
  
		entity.HrmVacancyId = inputItem.HrmVacancyId;  
  
		entity.HVTitle = inputItem.HVTitle;  
  
		entity.HVType = inputItem.HVType;  
  
		entity.HVRole = inputItem.HVRole; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmVacancyDto Map(HrmVacancy inputItem)
        {
            var dto = new HrmVacancyDto()
            {
                  
  
		HrmVacancyId = inputItem.HrmVacancyId,  
  
		HVTitle = inputItem.HVTitle,  
  
		HVType = inputItem.HVType,  
  
		HVRole = inputItem.HVRole, 
            };
            return dto;
        }

        public static List<HrmVacancyDto> Map(ICollection<HrmVacancy> entities)
        {
            var dtos = new List<HrmVacancyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmVacancyDto()
                {
                      
  
		HrmVacancyId = inputItem.HrmVacancyId,  
  
		HVTitle = inputItem.HVTitle,  
  
		HVType = inputItem.HVType,  
  
		HVRole = inputItem.HVRole, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmVacMthods Map(AddHrmVacMthodsCommand inputItem)
        {
            var entity = new HrmVacMthods() {
                  
  
		HrmVacMthodId = inputItem.HrmVacMthodId,  
  
		HVMVacRef = inputItem.HVMVacRef,  
  
		HVMEmpRef = inputItem.HVMEmpRef,  
  
		HVMYear = inputItem.HVMYear,  
  
		HVMStVal = inputItem.HVMStVal,  
  
		HVMMaxVal = inputItem.HVMMaxVal,  
  
		HVMFixVal = inputItem.HVMFixVal,  
  
		HVMTransRem = inputItem.HVMTransRem, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmVacMthods Map(HrmVacMthods entity ,EditHrmVacMthodsCommand inputItem)
        {
              
  
		entity.HrmVacMthodId = inputItem.HrmVacMthodId;  
  
		entity.HVMVacRef = inputItem.HVMVacRef;  
  
		entity.HVMEmpRef = inputItem.HVMEmpRef;  
  
		entity.HVMYear = inputItem.HVMYear;  
  
		entity.HVMStVal = inputItem.HVMStVal;  
  
		entity.HVMMaxVal = inputItem.HVMMaxVal;  
  
		entity.HVMFixVal = inputItem.HVMFixVal;  
  
		entity.HVMTransRem = inputItem.HVMTransRem; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmVacMthodsDto Map(HrmVacMthods inputItem)
        {
            var dto = new HrmVacMthodsDto()
            {
                  
  
		HrmVacMthodId = inputItem.HrmVacMthodId,  
  
		HVMVacRef = inputItem.HVMVacRef,  
  
		HVMEmpRef = inputItem.HVMEmpRef,  
  
		HVMYear = inputItem.HVMYear,  
  
		HVMStVal = inputItem.HVMStVal,  
  
		HVMMaxVal = inputItem.HVMMaxVal,  
  
		HVMFixVal = inputItem.HVMFixVal,  
  
		HVMTransRem = inputItem.HVMTransRem, 
            };
            return dto;
        }

        public static List<HrmVacMthodsDto> Map(ICollection<HrmVacMthods> entities)
        {
            var dtos = new List<HrmVacMthodsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmVacMthodsDto()
                {
                      
  
		HrmVacMthodId = inputItem.HrmVacMthodId,  
  
		HVMVacRef = inputItem.HVMVacRef,  
  
		HVMEmpRef = inputItem.HVMEmpRef,  
  
		HVMYear = inputItem.HVMYear,  
  
		HVMStVal = inputItem.HVMStVal,  
  
		HVMMaxVal = inputItem.HVMMaxVal,  
  
		HVMFixVal = inputItem.HVMFixVal,  
  
		HVMTransRem = inputItem.HVMTransRem, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmWorkGroups Map(AddHrmWorkGroupsCommand inputItem)
        {
            var entity = new HrmWorkGroups() {
                  
  
		HrmWorkGroupId = inputItem.HrmWorkGroupId,  
  
		HWGTitle = inputItem.HWGTitle,  
  
		HWGType = inputItem.HWGType,  
  
		HWGCalndRef = inputItem.HWGCalndRef,  
  
		HWGDayPrDelay = inputItem.HWGDayPrDelay,  
  
		HWGDayPrPost = inputItem.HWGDayPrPost,  
  
		HWGMonPityDelay = inputItem.HWGMonPityDelay,  
  
		HWGMonPrDelayCnt = inputItem.HWGMonPrDelayCnt,  
  
		HWGCalcDelaySit = inputItem.HWGCalcDelaySit,  
  
		HWGYrMinResrvVac = inputItem.HWGYrMinResrvVac,  
  
		HWGYrMaxResrvVac = inputItem.HWGYrMaxResrvVac,  
  
		HWGMonMinResrvVac = inputItem.HWGMonMinResrvVac,  
  
		HWGMonMaxResrvVac = inputItem.HWGMonMaxResrvVac,  
  
		HWGTmEmpMinHour = inputItem.HWGTmEmpMinHour,  
  
		HWGTmEmpMaxHour = inputItem.HWGTmEmpMaxHour,  
  
		HWGDcTimeFromOvrTime = inputItem.HWGDcTimeFromOvrTime,  
  
		HWGDcTimeFromVac = inputItem.HWGDcTimeFromVac,  
  
		HWGOvrTimeMinBfr = inputItem.HWGOvrTimeMinBfr,  
  
		HWGOvrTimeMinAftr = inputItem.HWGOvrTimeMinAftr,  
  
		HWGOvrTimeNeedPrm = inputItem.HWGOvrTimeNeedPrm,  
  
		HWGAccPrdRef = inputItem.HWGAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmWorkGroups Map(HrmWorkGroups entity ,EditHrmWorkGroupsCommand inputItem)
        {
              
  
		entity.HrmWorkGroupId = inputItem.HrmWorkGroupId;  
  
		entity.HWGTitle = inputItem.HWGTitle;  
  
		entity.HWGType = inputItem.HWGType;  
  
		entity.HWGCalndRef = inputItem.HWGCalndRef;  
  
		entity.HWGDayPrDelay = inputItem.HWGDayPrDelay;  
  
		entity.HWGDayPrPost = inputItem.HWGDayPrPost;  
  
		entity.HWGMonPityDelay = inputItem.HWGMonPityDelay;  
  
		entity.HWGMonPrDelayCnt = inputItem.HWGMonPrDelayCnt;  
  
		entity.HWGCalcDelaySit = inputItem.HWGCalcDelaySit;  
  
		entity.HWGYrMinResrvVac = inputItem.HWGYrMinResrvVac;  
  
		entity.HWGYrMaxResrvVac = inputItem.HWGYrMaxResrvVac;  
  
		entity.HWGMonMinResrvVac = inputItem.HWGMonMinResrvVac;  
  
		entity.HWGMonMaxResrvVac = inputItem.HWGMonMaxResrvVac;  
  
		entity.HWGTmEmpMinHour = inputItem.HWGTmEmpMinHour;  
  
		entity.HWGTmEmpMaxHour = inputItem.HWGTmEmpMaxHour;  
  
		entity.HWGDcTimeFromOvrTime = inputItem.HWGDcTimeFromOvrTime;  
  
		entity.HWGDcTimeFromVac = inputItem.HWGDcTimeFromVac;  
  
		entity.HWGOvrTimeMinBfr = inputItem.HWGOvrTimeMinBfr;  
  
		entity.HWGOvrTimeMinAftr = inputItem.HWGOvrTimeMinAftr;  
  
		entity.HWGOvrTimeNeedPrm = inputItem.HWGOvrTimeNeedPrm;  
  
		entity.HWGAccPrdRef = inputItem.HWGAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmWorkGroupsDto Map(HrmWorkGroups inputItem)
        {
            var dto = new HrmWorkGroupsDto()
            {
                  
  
		HrmWorkGroupId = inputItem.HrmWorkGroupId,  
  
		HWGTitle = inputItem.HWGTitle,  
  
		HWGType = inputItem.HWGType,  
  
		HWGCalndRef = inputItem.HWGCalndRef,  
  
		HWGDayPrDelay = inputItem.HWGDayPrDelay,  
  
		HWGDayPrPost = inputItem.HWGDayPrPost,  
  
		HWGMonPityDelay = inputItem.HWGMonPityDelay,  
  
		HWGMonPrDelayCnt = inputItem.HWGMonPrDelayCnt,  
  
		HWGCalcDelaySit = inputItem.HWGCalcDelaySit,  
  
		HWGYrMinResrvVac = inputItem.HWGYrMinResrvVac,  
  
		HWGYrMaxResrvVac = inputItem.HWGYrMaxResrvVac,  
  
		HWGMonMinResrvVac = inputItem.HWGMonMinResrvVac,  
  
		HWGMonMaxResrvVac = inputItem.HWGMonMaxResrvVac,  
  
		HWGTmEmpMinHour = inputItem.HWGTmEmpMinHour,  
  
		HWGTmEmpMaxHour = inputItem.HWGTmEmpMaxHour,  
  
		HWGDcTimeFromOvrTime = inputItem.HWGDcTimeFromOvrTime,  
  
		HWGDcTimeFromVac = inputItem.HWGDcTimeFromVac,  
  
		HWGOvrTimeMinBfr = inputItem.HWGOvrTimeMinBfr,  
  
		HWGOvrTimeMinAftr = inputItem.HWGOvrTimeMinAftr,  
  
		HWGOvrTimeNeedPrm = inputItem.HWGOvrTimeNeedPrm,  
  
		HWGAccPrdRef = inputItem.HWGAccPrdRef, 
            };
            return dto;
        }

        public static List<HrmWorkGroupsDto> Map(ICollection<HrmWorkGroups> entities)
        {
            var dtos = new List<HrmWorkGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmWorkGroupsDto()
                {
                      
  
		HrmWorkGroupId = inputItem.HrmWorkGroupId,  
  
		HWGTitle = inputItem.HWGTitle,  
  
		HWGType = inputItem.HWGType,  
  
		HWGCalndRef = inputItem.HWGCalndRef,  
  
		HWGDayPrDelay = inputItem.HWGDayPrDelay,  
  
		HWGDayPrPost = inputItem.HWGDayPrPost,  
  
		HWGMonPityDelay = inputItem.HWGMonPityDelay,  
  
		HWGMonPrDelayCnt = inputItem.HWGMonPrDelayCnt,  
  
		HWGCalcDelaySit = inputItem.HWGCalcDelaySit,  
  
		HWGYrMinResrvVac = inputItem.HWGYrMinResrvVac,  
  
		HWGYrMaxResrvVac = inputItem.HWGYrMaxResrvVac,  
  
		HWGMonMinResrvVac = inputItem.HWGMonMinResrvVac,  
  
		HWGMonMaxResrvVac = inputItem.HWGMonMaxResrvVac,  
  
		HWGTmEmpMinHour = inputItem.HWGTmEmpMinHour,  
  
		HWGTmEmpMaxHour = inputItem.HWGTmEmpMaxHour,  
  
		HWGDcTimeFromOvrTime = inputItem.HWGDcTimeFromOvrTime,  
  
		HWGDcTimeFromVac = inputItem.HWGDcTimeFromVac,  
  
		HWGOvrTimeMinBfr = inputItem.HWGOvrTimeMinBfr,  
  
		HWGOvrTimeMinAftr = inputItem.HWGOvrTimeMinAftr,  
  
		HWGOvrTimeNeedPrm = inputItem.HWGOvrTimeNeedPrm,  
  
		HWGAccPrdRef = inputItem.HWGAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmWorkGroupsInf Map(AddHrmWorkGroupsInfCommand inputItem)
        {
            var entity = new HrmWorkGroupsInf() {
                  
  
		HWGIHdrRef = inputItem.HWGIHdrRef,  
  
		HWGIMonth = inputItem.HWGIMonth,  
  
		HWGIDayDur = inputItem.HWGIDayDur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmWorkGroupsInf Map(HrmWorkGroupsInf entity ,EditHrmWorkGroupsInfCommand inputItem)
        {
              
  
		entity.HWGIHdrRef = inputItem.HWGIHdrRef;  
  
		entity.HWGIMonth = inputItem.HWGIMonth;  
  
		entity.HWGIDayDur = inputItem.HWGIDayDur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmWorkGroupsInfDto Map(HrmWorkGroupsInf inputItem)
        {
            var dto = new HrmWorkGroupsInfDto()
            {
                  
  
		HWGIHdrRef = inputItem.HWGIHdrRef,  
  
		HWGIMonth = inputItem.HWGIMonth,  
  
		HWGIDayDur = inputItem.HWGIDayDur, 
            };
            return dto;
        }

        public static List<HrmWorkGroupsInfDto> Map(ICollection<HrmWorkGroupsInf> entities)
        {
            var dtos = new List<HrmWorkGroupsInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmWorkGroupsInfDto()
                {
                      
  
		HWGIHdrRef = inputItem.HWGIHdrRef,  
  
		HWGIMonth = inputItem.HWGIMonth,  
  
		HWGIDayDur = inputItem.HWGIDayDur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HrmWorkLoc Map(AddHrmWorkLocCommand inputItem)
        {
            var entity = new HrmWorkLoc() {
                  
  
		HrmWrkLocId = inputItem.HrmWrkLocId,  
  
		HWLTitle = inputItem.HWLTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HrmWorkLoc Map(HrmWorkLoc entity ,EditHrmWorkLocCommand inputItem)
        {
              
  
		entity.HrmWrkLocId = inputItem.HrmWrkLocId;  
  
		entity.HWLTitle = inputItem.HWLTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HrmWorkLocDto Map(HrmWorkLoc inputItem)
        {
            var dto = new HrmWorkLocDto()
            {
                  
  
		HrmWrkLocId = inputItem.HrmWrkLocId,  
  
		HWLTitle = inputItem.HWLTitle, 
            };
            return dto;
        }

        public static List<HrmWorkLocDto> Map(ICollection<HrmWorkLoc> entities)
        {
            var dtos = new List<HrmWorkLocDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HrmWorkLocDto()
                {
                      
  
		HrmWrkLocId = inputItem.HrmWrkLocId,  
  
		HWLTitle = inputItem.HWLTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
