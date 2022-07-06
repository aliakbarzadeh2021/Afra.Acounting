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
                
        
        public static QcsBases Map(AddQcsBasesCommand inputItem)
        {
            var entity = new QcsBases() {
                  
  
		QBCode = inputItem.QBCode,  
  
		QBType = inputItem.QBType,  
  
		QBTItle = inputItem.QBTItle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsBases Map(QcsBases entity ,EditQcsBasesCommand inputItem)
        {
              
  
		entity.QBCode = inputItem.QBCode;  
  
		entity.QBType = inputItem.QBType;  
  
		entity.QBTItle = inputItem.QBTItle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsBasesDto Map(QcsBases inputItem)
        {
            var dto = new QcsBasesDto()
            {
                  
  
		QBCode = inputItem.QBCode,  
  
		QBType = inputItem.QBType,  
  
		QBTItle = inputItem.QBTItle, 
            };
            return dto;
        }

        public static List<QcsBasesDto> Map(ICollection<QcsBases> entities)
        {
            var dtos = new List<QcsBasesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsBasesDto()
                {
                      
  
		QBCode = inputItem.QBCode,  
  
		QBType = inputItem.QBType,  
  
		QBTItle = inputItem.QBTItle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsDocs Map(AddQcsDocsCommand inputItem)
        {
            var entity = new QcsDocs() {
                  
  
		QcsDocId = inputItem.QcsDocId,  
  
		QDCode = inputItem.QDCode,  
  
		QDTitle = inputItem.QDTitle,  
  
		QDFileExt = inputItem.QDFileExt,  
  
		QDImage = inputItem.QDImage, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsDocs Map(QcsDocs entity ,EditQcsDocsCommand inputItem)
        {
              
  
		entity.QcsDocId = inputItem.QcsDocId;  
  
		entity.QDCode = inputItem.QDCode;  
  
		entity.QDTitle = inputItem.QDTitle;  
  
		entity.QDFileExt = inputItem.QDFileExt;  
  
		entity.QDImage = inputItem.QDImage; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsDocsDto Map(QcsDocs inputItem)
        {
            var dto = new QcsDocsDto()
            {
                  
  
		QcsDocId = inputItem.QcsDocId,  
  
		QDCode = inputItem.QDCode,  
  
		QDTitle = inputItem.QDTitle,  
  
		QDFileExt = inputItem.QDFileExt,  
  
		QDImage = inputItem.QDImage, 
            };
            return dto;
        }

        public static List<QcsDocsDto> Map(ICollection<QcsDocs> entities)
        {
            var dtos = new List<QcsDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsDocsDto()
                {
                      
  
		QcsDocId = inputItem.QcsDocId,  
  
		QDCode = inputItem.QDCode,  
  
		QDTitle = inputItem.QDTitle,  
  
		QDFileExt = inputItem.QDFileExt,  
  
		QDImage = inputItem.QDImage, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsMenLabs Map(AddQcsMenLabsCommand inputItem)
        {
            var entity = new QcsMenLabs() {
                  
  
		QMLMenRef = inputItem.QMLMenRef,  
  
		QMLLabRef = inputItem.QMLLabRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsMenLabs Map(QcsMenLabs entity ,EditQcsMenLabsCommand inputItem)
        {
              
  
		entity.QMLMenRef = inputItem.QMLMenRef;  
  
		entity.QMLLabRef = inputItem.QMLLabRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsMenLabsDto Map(QcsMenLabs inputItem)
        {
            var dto = new QcsMenLabsDto()
            {
                  
  
		QMLMenRef = inputItem.QMLMenRef,  
  
		QMLLabRef = inputItem.QMLLabRef, 
            };
            return dto;
        }

        public static List<QcsMenLabsDto> Map(ICollection<QcsMenLabs> entities)
        {
            var dtos = new List<QcsMenLabsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsMenLabsDto()
                {
                      
  
		QMLMenRef = inputItem.QMLMenRef,  
  
		QMLLabRef = inputItem.QMLLabRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsMens Map(AddQcsMensCommand inputItem)
        {
            var entity = new QcsMens() {
                  
  
		QcsMenId = inputItem.QcsMenId,  
  
		QMCrsRef = inputItem.QMCrsRef,  
  
		QMDegreeRef = inputItem.QMDegreeRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsMens Map(QcsMens entity ,EditQcsMensCommand inputItem)
        {
              
  
		entity.QcsMenId = inputItem.QcsMenId;  
  
		entity.QMCrsRef = inputItem.QMCrsRef;  
  
		entity.QMDegreeRef = inputItem.QMDegreeRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsMensDto Map(QcsMens inputItem)
        {
            var dto = new QcsMensDto()
            {
                  
  
		QcsMenId = inputItem.QcsMenId,  
  
		QMCrsRef = inputItem.QMCrsRef,  
  
		QMDegreeRef = inputItem.QMDegreeRef, 
            };
            return dto;
        }

        public static List<QcsMensDto> Map(ICollection<QcsMens> entities)
        {
            var dtos = new List<QcsMensDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsMensDto()
                {
                      
  
		QcsMenId = inputItem.QcsMenId,  
  
		QMCrsRef = inputItem.QMCrsRef,  
  
		QMDegreeRef = inputItem.QMDegreeRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsRequest Map(AddQcsRequestCommand inputItem)
        {
            var entity = new QcsRequest() {
                  
  
		QcsRequestId = inputItem.QcsRequestId,  
  
		QRNum = inputItem.QRNum,  
  
		QRDate = inputItem.QRDate,  
  
		QRDLRef = inputItem.QRDLRef,  
  
		QRPartRef = inputItem.QRPartRef,  
  
		QRStepName = inputItem.QRStepName,  
  
		QRQty = inputItem.QRQty,  
  
		QRDescr = inputItem.QRDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QRState = inputItem.QRState,  
  
		QRAccPrdRef = inputItem.QRAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsRequest Map(QcsRequest entity ,EditQcsRequestCommand inputItem)
        {
              
  
		entity.QcsRequestId = inputItem.QcsRequestId;  
  
		entity.QRNum = inputItem.QRNum;  
  
		entity.QRDate = inputItem.QRDate;  
  
		entity.QRDLRef = inputItem.QRDLRef;  
  
		entity.QRPartRef = inputItem.QRPartRef;  
  
		entity.QRStepName = inputItem.QRStepName;  
  
		entity.QRQty = inputItem.QRQty;  
  
		entity.QRDescr = inputItem.QRDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.QRState = inputItem.QRState;  
  
		entity.QRAccPrdRef = inputItem.QRAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsRequestDto Map(QcsRequest inputItem)
        {
            var dto = new QcsRequestDto()
            {
                  
  
		QcsRequestId = inputItem.QcsRequestId,  
  
		QRNum = inputItem.QRNum,  
  
		QRDate = inputItem.QRDate,  
  
		QRDLRef = inputItem.QRDLRef,  
  
		QRPartRef = inputItem.QRPartRef,  
  
		QRStepName = inputItem.QRStepName,  
  
		QRQty = inputItem.QRQty,  
  
		QRDescr = inputItem.QRDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QRState = inputItem.QRState,  
  
		QRAccPrdRef = inputItem.QRAccPrdRef, 
            };
            return dto;
        }

        public static List<QcsRequestDto> Map(ICollection<QcsRequest> entities)
        {
            var dtos = new List<QcsRequestDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsRequestDto()
                {
                      
  
		QcsRequestId = inputItem.QcsRequestId,  
  
		QRNum = inputItem.QRNum,  
  
		QRDate = inputItem.QRDate,  
  
		QRDLRef = inputItem.QRDLRef,  
  
		QRPartRef = inputItem.QRPartRef,  
  
		QRStepName = inputItem.QRStepName,  
  
		QRQty = inputItem.QRQty,  
  
		QRDescr = inputItem.QRDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QRState = inputItem.QRState,  
  
		QRAccPrdRef = inputItem.QRAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsTestDet Map(AddQcsTestDetCommand inputItem)
        {
            var entity = new QcsTestDet() {
                  
  
		QcsTestDetId = inputItem.QcsTestDetId,  
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDPropRef = inputItem.QTDPropRef,  
  
		QTDName = inputItem.QTDName,  
  
		QTUnitRef = inputItem.QTUnitRef,  
  
		QTDMinVal = inputItem.QTDMinVal,  
  
		QTDMaxVal = inputItem.QTDMaxVal,  
  
		QTDCheck = inputItem.QTDCheck,  
  
		QTDTestType = inputItem.QTDTestType,  
  
		QTDMachine = inputItem.QTDMachine,  
  
		QTDDescr = inputItem.QTDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsTestDet Map(QcsTestDet entity ,EditQcsTestDetCommand inputItem)
        {
              
  
		entity.QcsTestDetId = inputItem.QcsTestDetId;  
  
		entity.QTDTestRef = inputItem.QTDTestRef;  
  
		entity.QTDPropRef = inputItem.QTDPropRef;  
  
		entity.QTDName = inputItem.QTDName;  
  
		entity.QTUnitRef = inputItem.QTUnitRef;  
  
		entity.QTDMinVal = inputItem.QTDMinVal;  
  
		entity.QTDMaxVal = inputItem.QTDMaxVal;  
  
		entity.QTDCheck = inputItem.QTDCheck;  
  
		entity.QTDTestType = inputItem.QTDTestType;  
  
		entity.QTDMachine = inputItem.QTDMachine;  
  
		entity.QTDDescr = inputItem.QTDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsTestDetDto Map(QcsTestDet inputItem)
        {
            var dto = new QcsTestDetDto()
            {
                  
  
		QcsTestDetId = inputItem.QcsTestDetId,  
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDPropRef = inputItem.QTDPropRef,  
  
		QTDName = inputItem.QTDName,  
  
		QTUnitRef = inputItem.QTUnitRef,  
  
		QTDMinVal = inputItem.QTDMinVal,  
  
		QTDMaxVal = inputItem.QTDMaxVal,  
  
		QTDCheck = inputItem.QTDCheck,  
  
		QTDTestType = inputItem.QTDTestType,  
  
		QTDMachine = inputItem.QTDMachine,  
  
		QTDDescr = inputItem.QTDDescr, 
            };
            return dto;
        }

        public static List<QcsTestDetDto> Map(ICollection<QcsTestDet> entities)
        {
            var dtos = new List<QcsTestDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsTestDetDto()
                {
                      
  
		QcsTestDetId = inputItem.QcsTestDetId,  
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDPropRef = inputItem.QTDPropRef,  
  
		QTDName = inputItem.QTDName,  
  
		QTUnitRef = inputItem.QTUnitRef,  
  
		QTDMinVal = inputItem.QTDMinVal,  
  
		QTDMaxVal = inputItem.QTDMaxVal,  
  
		QTDCheck = inputItem.QTDCheck,  
  
		QTDTestType = inputItem.QTDTestType,  
  
		QTDMachine = inputItem.QTDMachine,  
  
		QTDDescr = inputItem.QTDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsTestDocs Map(AddQcsTestDocsCommand inputItem)
        {
            var entity = new QcsTestDocs() {
                  
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDDocRef = inputItem.QTDDocRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsTestDocs Map(QcsTestDocs entity ,EditQcsTestDocsCommand inputItem)
        {
              
  
		entity.QTDTestRef = inputItem.QTDTestRef;  
  
		entity.QTDDocRef = inputItem.QTDDocRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsTestDocsDto Map(QcsTestDocs inputItem)
        {
            var dto = new QcsTestDocsDto()
            {
                  
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDDocRef = inputItem.QTDDocRef, 
            };
            return dto;
        }

        public static List<QcsTestDocsDto> Map(ICollection<QcsTestDocs> entities)
        {
            var dtos = new List<QcsTestDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsTestDocsDto()
                {
                      
  
		QTDTestRef = inputItem.QTDTestRef,  
  
		QTDDocRef = inputItem.QTDDocRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsTests Map(AddQcsTestsCommand inputItem)
        {
            var entity = new QcsTests() {
                  
  
		QcsTestsId = inputItem.QcsTestsId,  
  
		QTPartRef = inputItem.QTPartRef,  
  
		QTStepName = inputItem.QTStepName,  
  
		QTName = inputItem.QTName,  
  
		QTLabRef = inputItem.QTLabRef,  
  
		QTRepeat = inputItem.QTRepeat, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsTests Map(QcsTests entity ,EditQcsTestsCommand inputItem)
        {
              
  
		entity.QcsTestsId = inputItem.QcsTestsId;  
  
		entity.QTPartRef = inputItem.QTPartRef;  
  
		entity.QTStepName = inputItem.QTStepName;  
  
		entity.QTName = inputItem.QTName;  
  
		entity.QTLabRef = inputItem.QTLabRef;  
  
		entity.QTRepeat = inputItem.QTRepeat; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsTestsDto Map(QcsTests inputItem)
        {
            var dto = new QcsTestsDto()
            {
                  
  
		QcsTestsId = inputItem.QcsTestsId,  
  
		QTPartRef = inputItem.QTPartRef,  
  
		QTStepName = inputItem.QTStepName,  
  
		QTName = inputItem.QTName,  
  
		QTLabRef = inputItem.QTLabRef,  
  
		QTRepeat = inputItem.QTRepeat, 
            };
            return dto;
        }

        public static List<QcsTestsDto> Map(ICollection<QcsTests> entities)
        {
            var dtos = new List<QcsTestsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsTestsDto()
                {
                      
  
		QcsTestsId = inputItem.QcsTestsId,  
  
		QTPartRef = inputItem.QTPartRef,  
  
		QTStepName = inputItem.QTStepName,  
  
		QTName = inputItem.QTName,  
  
		QTLabRef = inputItem.QTLabRef,  
  
		QTRepeat = inputItem.QTRepeat, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsVchHdr Map(AddQcsVchHdrCommand inputItem)
        {
            var entity = new QcsVchHdr() {
                  
  
		QcsVchHdrId = inputItem.QcsVchHdrId,  
  
		QVHNum = inputItem.QVHNum,  
  
		QVHLocalNum = inputItem.QVHLocalNum,  
  
		QVHDate = inputItem.QVHDate,  
  
		QVHProdRef = inputItem.QVHProdRef,  
  
		QVHStepRef = inputItem.QVHStepRef,  
  
		QVHMenRef = inputItem.QVHMenRef,  
  
		QVHTestRef = inputItem.QVHTestRef,  
  
		QVHLabRef = inputItem.QVHLabRef,  
  
		QVHAllQty = inputItem.QVHAllQty,  
  
		QVHTestQty = inputItem.QVHTestQty,  
  
		QVHOKQty = inputItem.QVHOKQty,  
  
		QVHDescr = inputItem.QVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QVHState = inputItem.QVHState,  
  
		QAccPrdRef = inputItem.QAccPrdRef,  
  
		QVHRefID = inputItem.QVHRefID,  
  
		QVHRefType = inputItem.QVHRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsVchHdr Map(QcsVchHdr entity ,EditQcsVchHdrCommand inputItem)
        {
              
  
		entity.QcsVchHdrId = inputItem.QcsVchHdrId;  
  
		entity.QVHNum = inputItem.QVHNum;  
  
		entity.QVHLocalNum = inputItem.QVHLocalNum;  
  
		entity.QVHDate = inputItem.QVHDate;  
  
		entity.QVHProdRef = inputItem.QVHProdRef;  
  
		entity.QVHStepRef = inputItem.QVHStepRef;  
  
		entity.QVHMenRef = inputItem.QVHMenRef;  
  
		entity.QVHTestRef = inputItem.QVHTestRef;  
  
		entity.QVHLabRef = inputItem.QVHLabRef;  
  
		entity.QVHAllQty = inputItem.QVHAllQty;  
  
		entity.QVHTestQty = inputItem.QVHTestQty;  
  
		entity.QVHOKQty = inputItem.QVHOKQty;  
  
		entity.QVHDescr = inputItem.QVHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.QVHState = inputItem.QVHState;  
  
		entity.QAccPrdRef = inputItem.QAccPrdRef;  
  
		entity.QVHRefID = inputItem.QVHRefID;  
  
		entity.QVHRefType = inputItem.QVHRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsVchHdrDto Map(QcsVchHdr inputItem)
        {
            var dto = new QcsVchHdrDto()
            {
                  
  
		QcsVchHdrId = inputItem.QcsVchHdrId,  
  
		QVHNum = inputItem.QVHNum,  
  
		QVHLocalNum = inputItem.QVHLocalNum,  
  
		QVHDate = inputItem.QVHDate,  
  
		QVHProdRef = inputItem.QVHProdRef,  
  
		QVHStepRef = inputItem.QVHStepRef,  
  
		QVHMenRef = inputItem.QVHMenRef,  
  
		QVHTestRef = inputItem.QVHTestRef,  
  
		QVHLabRef = inputItem.QVHLabRef,  
  
		QVHAllQty = inputItem.QVHAllQty,  
  
		QVHTestQty = inputItem.QVHTestQty,  
  
		QVHOKQty = inputItem.QVHOKQty,  
  
		QVHDescr = inputItem.QVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QVHState = inputItem.QVHState,  
  
		QAccPrdRef = inputItem.QAccPrdRef,  
  
		QVHRefID = inputItem.QVHRefID,  
  
		QVHRefType = inputItem.QVHRefType, 
            };
            return dto;
        }

        public static List<QcsVchHdrDto> Map(ICollection<QcsVchHdr> entities)
        {
            var dtos = new List<QcsVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsVchHdrDto()
                {
                      
  
		QcsVchHdrId = inputItem.QcsVchHdrId,  
  
		QVHNum = inputItem.QVHNum,  
  
		QVHLocalNum = inputItem.QVHLocalNum,  
  
		QVHDate = inputItem.QVHDate,  
  
		QVHProdRef = inputItem.QVHProdRef,  
  
		QVHStepRef = inputItem.QVHStepRef,  
  
		QVHMenRef = inputItem.QVHMenRef,  
  
		QVHTestRef = inputItem.QVHTestRef,  
  
		QVHLabRef = inputItem.QVHLabRef,  
  
		QVHAllQty = inputItem.QVHAllQty,  
  
		QVHTestQty = inputItem.QVHTestQty,  
  
		QVHOKQty = inputItem.QVHOKQty,  
  
		QVHDescr = inputItem.QVHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		QVHState = inputItem.QVHState,  
  
		QAccPrdRef = inputItem.QAccPrdRef,  
  
		QVHRefID = inputItem.QVHRefID,  
  
		QVHRefType = inputItem.QVHRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QcsVchItm Map(AddQcsVchItmCommand inputItem)
        {
            var entity = new QcsVchItm() {
                  
  
		QcsVchItmId = inputItem.QcsVchItmId,  
  
		QcsVchHdrRef = inputItem.QcsVchHdrRef,  
  
		QVITestItmRef = inputItem.QVITestItmRef,  
  
		QVIRes = inputItem.QVIRes,  
  
		QVIResDescr = inputItem.QVIResDescr,  
  
		QVIOK = inputItem.QVIOK, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QcsVchItm Map(QcsVchItm entity ,EditQcsVchItmCommand inputItem)
        {
              
  
		entity.QcsVchItmId = inputItem.QcsVchItmId;  
  
		entity.QcsVchHdrRef = inputItem.QcsVchHdrRef;  
  
		entity.QVITestItmRef = inputItem.QVITestItmRef;  
  
		entity.QVIRes = inputItem.QVIRes;  
  
		entity.QVIResDescr = inputItem.QVIResDescr;  
  
		entity.QVIOK = inputItem.QVIOK; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QcsVchItmDto Map(QcsVchItm inputItem)
        {
            var dto = new QcsVchItmDto()
            {
                  
  
		QcsVchItmId = inputItem.QcsVchItmId,  
  
		QcsVchHdrRef = inputItem.QcsVchHdrRef,  
  
		QVITestItmRef = inputItem.QVITestItmRef,  
  
		QVIRes = inputItem.QVIRes,  
  
		QVIResDescr = inputItem.QVIResDescr,  
  
		QVIOK = inputItem.QVIOK, 
            };
            return dto;
        }

        public static List<QcsVchItmDto> Map(ICollection<QcsVchItm> entities)
        {
            var dtos = new List<QcsVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QcsVchItmDto()
                {
                      
  
		QcsVchItmId = inputItem.QcsVchItmId,  
  
		QcsVchHdrRef = inputItem.QcsVchHdrRef,  
  
		QVITestItmRef = inputItem.QVITestItmRef,  
  
		QVIRes = inputItem.QVIRes,  
  
		QVIResDescr = inputItem.QVIResDescr,  
  
		QVIOK = inputItem.QVIOK, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
