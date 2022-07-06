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
                
        
        public static TrsAccOpr Map(AddTrsAccOprCommand inputItem)
        {
            var entity = new TrsAccOpr() {
                  
  
		TrsOprId = inputItem.TrsOprId,  
  
		TrsOprCode = inputItem.TrsOprCode,  
  
		TrsOprDescr = inputItem.TrsOprDescr,  
  
		TrsOprType = inputItem.TrsOprType,  
  
		TrsOprRole = inputItem.TrsOprRole,  
  
		TrsOprVtType = inputItem.TrsOprVtType,  
  
		TrsOprSLRef = inputItem.TrsOprSLRef,  
  
		TrsOprDL4Type = inputItem.TrsOprDL4Type,  
  
		TrsOprDL4Code = inputItem.TrsOprDL4Code,  
  
		TrsOprDL5Type = inputItem.TrsOprDL5Type,  
  
		TrsOprDL5Code = inputItem.TrsOprDL5Code,  
  
		TrsOprDL6Type = inputItem.TrsOprDL6Type,  
  
		TrsOprDL6Code = inputItem.TrsOprDL6Code,  
  
		TrsOprItmType = inputItem.TrsOprItmType,  
  
		TrsOprVtItmType = inputItem.TrsOprVtItmType,  
  
		TrsOprHaveAcc = inputItem.TrsOprHaveAcc,  
  
		TrsOprPayItmType = inputItem.TrsOprPayItmType,  
  
		TrsOprOpositType = inputItem.TrsOprOpositType,  
  
		TrsOprItmNorm = inputItem.TrsOprItmNorm,  
  
		TrsOprCur = inputItem.TrsOprCur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsAccOpr Map(TrsAccOpr entity ,EditTrsAccOprCommand inputItem)
        {
              
  
		entity.TrsOprId = inputItem.TrsOprId;  
  
		entity.TrsOprCode = inputItem.TrsOprCode;  
  
		entity.TrsOprDescr = inputItem.TrsOprDescr;  
  
		entity.TrsOprType = inputItem.TrsOprType;  
  
		entity.TrsOprRole = inputItem.TrsOprRole;  
  
		entity.TrsOprVtType = inputItem.TrsOprVtType;  
  
		entity.TrsOprSLRef = inputItem.TrsOprSLRef;  
  
		entity.TrsOprDL4Type = inputItem.TrsOprDL4Type;  
  
		entity.TrsOprDL4Code = inputItem.TrsOprDL4Code;  
  
		entity.TrsOprDL5Type = inputItem.TrsOprDL5Type;  
  
		entity.TrsOprDL5Code = inputItem.TrsOprDL5Code;  
  
		entity.TrsOprDL6Type = inputItem.TrsOprDL6Type;  
  
		entity.TrsOprDL6Code = inputItem.TrsOprDL6Code;  
  
		entity.TrsOprItmType = inputItem.TrsOprItmType;  
  
		entity.TrsOprVtItmType = inputItem.TrsOprVtItmType;  
  
		entity.TrsOprHaveAcc = inputItem.TrsOprHaveAcc;  
  
		entity.TrsOprPayItmType = inputItem.TrsOprPayItmType;  
  
		entity.TrsOprOpositType = inputItem.TrsOprOpositType;  
  
		entity.TrsOprItmNorm = inputItem.TrsOprItmNorm;  
  
		entity.TrsOprCur = inputItem.TrsOprCur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsAccOprDto Map(TrsAccOpr inputItem)
        {
            var dto = new TrsAccOprDto()
            {
                  
  
		TrsOprId = inputItem.TrsOprId,  
  
		TrsOprCode = inputItem.TrsOprCode,  
  
		TrsOprDescr = inputItem.TrsOprDescr,  
  
		TrsOprType = inputItem.TrsOprType,  
  
		TrsOprRole = inputItem.TrsOprRole,  
  
		TrsOprVtType = inputItem.TrsOprVtType,  
  
		TrsOprSLRef = inputItem.TrsOprSLRef,  
  
		TrsOprDL4Type = inputItem.TrsOprDL4Type,  
  
		TrsOprDL4Code = inputItem.TrsOprDL4Code,  
  
		TrsOprDL5Type = inputItem.TrsOprDL5Type,  
  
		TrsOprDL5Code = inputItem.TrsOprDL5Code,  
  
		TrsOprDL6Type = inputItem.TrsOprDL6Type,  
  
		TrsOprDL6Code = inputItem.TrsOprDL6Code,  
  
		TrsOprItmType = inputItem.TrsOprItmType,  
  
		TrsOprVtItmType = inputItem.TrsOprVtItmType,  
  
		TrsOprHaveAcc = inputItem.TrsOprHaveAcc,  
  
		TrsOprPayItmType = inputItem.TrsOprPayItmType,  
  
		TrsOprOpositType = inputItem.TrsOprOpositType,  
  
		TrsOprItmNorm = inputItem.TrsOprItmNorm,  
  
		TrsOprCur = inputItem.TrsOprCur, 
            };
            return dto;
        }

        public static List<TrsAccOprDto> Map(ICollection<TrsAccOpr> entities)
        {
            var dtos = new List<TrsAccOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsAccOprDto()
                {
                      
  
		TrsOprId = inputItem.TrsOprId,  
  
		TrsOprCode = inputItem.TrsOprCode,  
  
		TrsOprDescr = inputItem.TrsOprDescr,  
  
		TrsOprType = inputItem.TrsOprType,  
  
		TrsOprRole = inputItem.TrsOprRole,  
  
		TrsOprVtType = inputItem.TrsOprVtType,  
  
		TrsOprSLRef = inputItem.TrsOprSLRef,  
  
		TrsOprDL4Type = inputItem.TrsOprDL4Type,  
  
		TrsOprDL4Code = inputItem.TrsOprDL4Code,  
  
		TrsOprDL5Type = inputItem.TrsOprDL5Type,  
  
		TrsOprDL5Code = inputItem.TrsOprDL5Code,  
  
		TrsOprDL6Type = inputItem.TrsOprDL6Type,  
  
		TrsOprDL6Code = inputItem.TrsOprDL6Code,  
  
		TrsOprItmType = inputItem.TrsOprItmType,  
  
		TrsOprVtItmType = inputItem.TrsOprVtItmType,  
  
		TrsOprHaveAcc = inputItem.TrsOprHaveAcc,  
  
		TrsOprPayItmType = inputItem.TrsOprPayItmType,  
  
		TrsOprOpositType = inputItem.TrsOprOpositType,  
  
		TrsOprItmNorm = inputItem.TrsOprItmNorm,  
  
		TrsOprCur = inputItem.TrsOprCur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankAccounts Map(AddTrsBankAccountsCommand inputItem)
        {
            var entity = new TrsBankAccounts() {
                  
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankAccountNo = inputItem.BankAccountNo,  
  
		BABrnchRef = inputItem.BABrnchRef,  
  
		BankAccountType = inputItem.BankAccountType,  
  
		BAFirstQty = inputItem.BAFirstQty,  
  
		BAOpenDate = inputItem.BAOpenDate,  
  
		BADLRef = inputItem.BADLRef,  
  
		BAReconDate = inputItem.BAReconDate,  
  
		BAReconRem = inputItem.BAReconRem,  
  
		BARemWithInst = inputItem.BARemWithInst, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankAccounts Map(TrsBankAccounts entity ,EditTrsBankAccountsCommand inputItem)
        {
              
  
		entity.BankAccountId = inputItem.BankAccountId;  
  
		entity.BankAccountNo = inputItem.BankAccountNo;  
  
		entity.BABrnchRef = inputItem.BABrnchRef;  
  
		entity.BankAccountType = inputItem.BankAccountType;  
  
		entity.BAFirstQty = inputItem.BAFirstQty;  
  
		entity.BAOpenDate = inputItem.BAOpenDate;  
  
		entity.BADLRef = inputItem.BADLRef;  
  
		entity.BAReconDate = inputItem.BAReconDate;  
  
		entity.BAReconRem = inputItem.BAReconRem;  
  
		entity.BARemWithInst = inputItem.BARemWithInst; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankAccountsDto Map(TrsBankAccounts inputItem)
        {
            var dto = new TrsBankAccountsDto()
            {
                  
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankAccountNo = inputItem.BankAccountNo,  
  
		BABrnchRef = inputItem.BABrnchRef,  
  
		BankAccountType = inputItem.BankAccountType,  
  
		BAFirstQty = inputItem.BAFirstQty,  
  
		BAOpenDate = inputItem.BAOpenDate,  
  
		BADLRef = inputItem.BADLRef,  
  
		BAReconDate = inputItem.BAReconDate,  
  
		BAReconRem = inputItem.BAReconRem,  
  
		BARemWithInst = inputItem.BARemWithInst, 
            };
            return dto;
        }

        public static List<TrsBankAccountsDto> Map(ICollection<TrsBankAccounts> entities)
        {
            var dtos = new List<TrsBankAccountsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankAccountsDto()
                {
                      
  
		BankAccountId = inputItem.BankAccountId,  
  
		BankAccountNo = inputItem.BankAccountNo,  
  
		BABrnchRef = inputItem.BABrnchRef,  
  
		BankAccountType = inputItem.BankAccountType,  
  
		BAFirstQty = inputItem.BAFirstQty,  
  
		BAOpenDate = inputItem.BAOpenDate,  
  
		BADLRef = inputItem.BADLRef,  
  
		BAReconDate = inputItem.BAReconDate,  
  
		BAReconRem = inputItem.BAReconRem,  
  
		BARemWithInst = inputItem.BARemWithInst, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankBill Map(AddTrsBankBillCommand inputItem)
        {
            var entity = new TrsBankBill() {
                  
  
		TrsBankBillId = inputItem.TrsBankBillId,  
  
		TBBNum = inputItem.TBBNum,  
  
		TBBDate = inputItem.TBBDate,  
  
		TBBBankAccRef = inputItem.TBBBankAccRef,  
  
		TBBDescr = inputItem.TBBDescr,  
  
		TBBState = inputItem.TBBState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TBBCreator = inputItem.TBBCreator,  
  
		TBBSit = inputItem.TBBSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankBill Map(TrsBankBill entity ,EditTrsBankBillCommand inputItem)
        {
              
  
		entity.TrsBankBillId = inputItem.TrsBankBillId;  
  
		entity.TBBNum = inputItem.TBBNum;  
  
		entity.TBBDate = inputItem.TBBDate;  
  
		entity.TBBBankAccRef = inputItem.TBBBankAccRef;  
  
		entity.TBBDescr = inputItem.TBBDescr;  
  
		entity.TBBState = inputItem.TBBState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TBBCreator = inputItem.TBBCreator;  
  
		entity.TBBSit = inputItem.TBBSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankBillDto Map(TrsBankBill inputItem)
        {
            var dto = new TrsBankBillDto()
            {
                  
  
		TrsBankBillId = inputItem.TrsBankBillId,  
  
		TBBNum = inputItem.TBBNum,  
  
		TBBDate = inputItem.TBBDate,  
  
		TBBBankAccRef = inputItem.TBBBankAccRef,  
  
		TBBDescr = inputItem.TBBDescr,  
  
		TBBState = inputItem.TBBState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TBBCreator = inputItem.TBBCreator,  
  
		TBBSit = inputItem.TBBSit, 
            };
            return dto;
        }

        public static List<TrsBankBillDto> Map(ICollection<TrsBankBill> entities)
        {
            var dtos = new List<TrsBankBillDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankBillDto()
                {
                      
  
		TrsBankBillId = inputItem.TrsBankBillId,  
  
		TBBNum = inputItem.TBBNum,  
  
		TBBDate = inputItem.TBBDate,  
  
		TBBBankAccRef = inputItem.TBBBankAccRef,  
  
		TBBDescr = inputItem.TBBDescr,  
  
		TBBState = inputItem.TBBState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TBBCreator = inputItem.TBBCreator,  
  
		TBBSit = inputItem.TBBSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankBillDet Map(AddTrsBankBillDetCommand inputItem)
        {
            var entity = new TrsBankBillDet() {
                  
  
		TrsBankBillDetId = inputItem.TrsBankBillDetId,  
  
		TrsBankBillRef = inputItem.TrsBankBillRef,  
  
		TBBDSeq = inputItem.TBBDSeq,  
  
		TBBDItemNo = inputItem.TBBDItemNo,  
  
		TBBDItmDate = inputItem.TBBDItmDate,  
  
		TBBDDebit = inputItem.TBBDDebit,  
  
		TBBDCredit = inputItem.TBBDCredit,  
  
		TBBDDescr = inputItem.TBBDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankBillDet Map(TrsBankBillDet entity ,EditTrsBankBillDetCommand inputItem)
        {
              
  
		entity.TrsBankBillDetId = inputItem.TrsBankBillDetId;  
  
		entity.TrsBankBillRef = inputItem.TrsBankBillRef;  
  
		entity.TBBDSeq = inputItem.TBBDSeq;  
  
		entity.TBBDItemNo = inputItem.TBBDItemNo;  
  
		entity.TBBDItmDate = inputItem.TBBDItmDate;  
  
		entity.TBBDDebit = inputItem.TBBDDebit;  
  
		entity.TBBDCredit = inputItem.TBBDCredit;  
  
		entity.TBBDDescr = inputItem.TBBDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankBillDetDto Map(TrsBankBillDet inputItem)
        {
            var dto = new TrsBankBillDetDto()
            {
                  
  
		TrsBankBillDetId = inputItem.TrsBankBillDetId,  
  
		TrsBankBillRef = inputItem.TrsBankBillRef,  
  
		TBBDSeq = inputItem.TBBDSeq,  
  
		TBBDItemNo = inputItem.TBBDItemNo,  
  
		TBBDItmDate = inputItem.TBBDItmDate,  
  
		TBBDDebit = inputItem.TBBDDebit,  
  
		TBBDCredit = inputItem.TBBDCredit,  
  
		TBBDDescr = inputItem.TBBDDescr, 
            };
            return dto;
        }

        public static List<TrsBankBillDetDto> Map(ICollection<TrsBankBillDet> entities)
        {
            var dtos = new List<TrsBankBillDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankBillDetDto()
                {
                      
  
		TrsBankBillDetId = inputItem.TrsBankBillDetId,  
  
		TrsBankBillRef = inputItem.TrsBankBillRef,  
  
		TBBDSeq = inputItem.TBBDSeq,  
  
		TBBDItemNo = inputItem.TBBDItemNo,  
  
		TBBDItmDate = inputItem.TBBDItmDate,  
  
		TBBDDebit = inputItem.TBBDDebit,  
  
		TBBDCredit = inputItem.TBBDCredit,  
  
		TBBDDescr = inputItem.TBBDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankBranchs Map(AddTrsBankBranchsCommand inputItem)
        {
            var entity = new TrsBankBranchs() {
                  
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankBranchName = inputItem.BankBranchName,  
  
		BankBranchCode = inputItem.BankBranchCode,  
  
		BBBankRef = inputItem.BBBankRef,  
  
		BankBranchType = inputItem.BankBranchType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankBranchs Map(TrsBankBranchs entity ,EditTrsBankBranchsCommand inputItem)
        {
              
  
		entity.BankBranchId = inputItem.BankBranchId;  
  
		entity.BankBranchName = inputItem.BankBranchName;  
  
		entity.BankBranchCode = inputItem.BankBranchCode;  
  
		entity.BBBankRef = inputItem.BBBankRef;  
  
		entity.BankBranchType = inputItem.BankBranchType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankBranchsDto Map(TrsBankBranchs inputItem)
        {
            var dto = new TrsBankBranchsDto()
            {
                  
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankBranchName = inputItem.BankBranchName,  
  
		BankBranchCode = inputItem.BankBranchCode,  
  
		BBBankRef = inputItem.BBBankRef,  
  
		BankBranchType = inputItem.BankBranchType, 
            };
            return dto;
        }

        public static List<TrsBankBranchsDto> Map(ICollection<TrsBankBranchs> entities)
        {
            var dtos = new List<TrsBankBranchsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankBranchsDto()
                {
                      
  
		BankBranchId = inputItem.BankBranchId,  
  
		BankBranchName = inputItem.BankBranchName,  
  
		BankBranchCode = inputItem.BankBranchCode,  
  
		BBBankRef = inputItem.BBBankRef,  
  
		BankBranchType = inputItem.BankBranchType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankChqs Map(AddTrsBankChqsCommand inputItem)
        {
            var entity = new TrsBankChqs() {
                  
  
		BankChqId = inputItem.BankChqId,  
  
		BChqBeginSerial = inputItem.BChqBeginSerial,  
  
		BChqShtCnt = inputItem.BChqShtCnt,  
  
		BChqAcnRef = inputItem.BChqAcnRef,  
  
		BChqFmtRef = inputItem.BChqFmtRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankChqs Map(TrsBankChqs entity ,EditTrsBankChqsCommand inputItem)
        {
              
  
		entity.BankChqId = inputItem.BankChqId;  
  
		entity.BChqBeginSerial = inputItem.BChqBeginSerial;  
  
		entity.BChqShtCnt = inputItem.BChqShtCnt;  
  
		entity.BChqAcnRef = inputItem.BChqAcnRef;  
  
		entity.BChqFmtRef = inputItem.BChqFmtRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankChqsDto Map(TrsBankChqs inputItem)
        {
            var dto = new TrsBankChqsDto()
            {
                  
  
		BankChqId = inputItem.BankChqId,  
  
		BChqBeginSerial = inputItem.BChqBeginSerial,  
  
		BChqShtCnt = inputItem.BChqShtCnt,  
  
		BChqAcnRef = inputItem.BChqAcnRef,  
  
		BChqFmtRef = inputItem.BChqFmtRef, 
            };
            return dto;
        }

        public static List<TrsBankChqsDto> Map(ICollection<TrsBankChqs> entities)
        {
            var dtos = new List<TrsBankChqsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankChqsDto()
                {
                      
  
		BankChqId = inputItem.BankChqId,  
  
		BChqBeginSerial = inputItem.BChqBeginSerial,  
  
		BChqShtCnt = inputItem.BChqShtCnt,  
  
		BChqAcnRef = inputItem.BChqAcnRef,  
  
		BChqFmtRef = inputItem.BChqFmtRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankChqsDet Map(AddTrsBankChqsDetCommand inputItem)
        {
            var entity = new TrsBankChqsDet() {
                  
  
		TrsBankChqDetId = inputItem.TrsBankChqDetId,  
  
		TBCDHdrRef = inputItem.TBCDHdrRef,  
  
		TBCDChqNo = inputItem.TBCDChqNo,  
  
		TBCDSit = inputItem.TBCDSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankChqsDet Map(TrsBankChqsDet entity ,EditTrsBankChqsDetCommand inputItem)
        {
              
  
		entity.TrsBankChqDetId = inputItem.TrsBankChqDetId;  
  
		entity.TBCDHdrRef = inputItem.TBCDHdrRef;  
  
		entity.TBCDChqNo = inputItem.TBCDChqNo;  
  
		entity.TBCDSit = inputItem.TBCDSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankChqsDetDto Map(TrsBankChqsDet inputItem)
        {
            var dto = new TrsBankChqsDetDto()
            {
                  
  
		TrsBankChqDetId = inputItem.TrsBankChqDetId,  
  
		TBCDHdrRef = inputItem.TBCDHdrRef,  
  
		TBCDChqNo = inputItem.TBCDChqNo,  
  
		TBCDSit = inputItem.TBCDSit, 
            };
            return dto;
        }

        public static List<TrsBankChqsDetDto> Map(ICollection<TrsBankChqsDet> entities)
        {
            var dtos = new List<TrsBankChqsDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankChqsDetDto()
                {
                      
  
		TrsBankChqDetId = inputItem.TrsBankChqDetId,  
  
		TBCDHdrRef = inputItem.TBCDHdrRef,  
  
		TBCDChqNo = inputItem.TBCDChqNo,  
  
		TBCDSit = inputItem.TBCDSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankReconcile Map(AddTrsBankReconcileCommand inputItem)
        {
            var entity = new TrsBankReconcile() {
                  
  
		TrsBankReconcileId = inputItem.TrsBankReconcileId,  
  
		TBRBankBillRef = inputItem.TBRBankBillRef,  
  
		TBRNum = inputItem.TBRNum,  
  
		TBRDate = inputItem.TBRDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankReconcile Map(TrsBankReconcile entity ,EditTrsBankReconcileCommand inputItem)
        {
              
  
		entity.TrsBankReconcileId = inputItem.TrsBankReconcileId;  
  
		entity.TBRBankBillRef = inputItem.TBRBankBillRef;  
  
		entity.TBRNum = inputItem.TBRNum;  
  
		entity.TBRDate = inputItem.TBRDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankReconcileDto Map(TrsBankReconcile inputItem)
        {
            var dto = new TrsBankReconcileDto()
            {
                  
  
		TrsBankReconcileId = inputItem.TrsBankReconcileId,  
  
		TBRBankBillRef = inputItem.TBRBankBillRef,  
  
		TBRNum = inputItem.TBRNum,  
  
		TBRDate = inputItem.TBRDate, 
            };
            return dto;
        }

        public static List<TrsBankReconcileDto> Map(ICollection<TrsBankReconcile> entities)
        {
            var dtos = new List<TrsBankReconcileDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankReconcileDto()
                {
                      
  
		TrsBankReconcileId = inputItem.TrsBankReconcileId,  
  
		TBRBankBillRef = inputItem.TBRBankBillRef,  
  
		TBRNum = inputItem.TBRNum,  
  
		TBRDate = inputItem.TBRDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBankReconcileDet Map(AddTrsBankReconcileDetCommand inputItem)
        {
            var entity = new TrsBankReconcileDet() {
                  
  
		TrsBankReconcileDetId = inputItem.TrsBankReconcileDetId,  
  
		TrsBankReconcileRef = inputItem.TrsBankReconcileRef,  
  
		TBRDItmType = inputItem.TBRDItmType,  
  
		TBRDItmKind = inputItem.TBRDItmKind,  
  
		TBRDItmRef = inputItem.TBRDItmRef,  
  
		TBRDItmDate = inputItem.TBRDItmDate,  
  
		TBRDItmNo = inputItem.TBRDItmNo,  
  
		TBRDDebit = inputItem.TBRDDebit,  
  
		TBRDCredit = inputItem.TBRDCredit,  
  
		TBRDDescr = inputItem.TBRDDescr,  
  
		TBRDRelId = inputItem.TBRDRelId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBankReconcileDet Map(TrsBankReconcileDet entity ,EditTrsBankReconcileDetCommand inputItem)
        {
              
  
		entity.TrsBankReconcileDetId = inputItem.TrsBankReconcileDetId;  
  
		entity.TrsBankReconcileRef = inputItem.TrsBankReconcileRef;  
  
		entity.TBRDItmType = inputItem.TBRDItmType;  
  
		entity.TBRDItmKind = inputItem.TBRDItmKind;  
  
		entity.TBRDItmRef = inputItem.TBRDItmRef;  
  
		entity.TBRDItmDate = inputItem.TBRDItmDate;  
  
		entity.TBRDItmNo = inputItem.TBRDItmNo;  
  
		entity.TBRDDebit = inputItem.TBRDDebit;  
  
		entity.TBRDCredit = inputItem.TBRDCredit;  
  
		entity.TBRDDescr = inputItem.TBRDDescr;  
  
		entity.TBRDRelId = inputItem.TBRDRelId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBankReconcileDetDto Map(TrsBankReconcileDet inputItem)
        {
            var dto = new TrsBankReconcileDetDto()
            {
                  
  
		TrsBankReconcileDetId = inputItem.TrsBankReconcileDetId,  
  
		TrsBankReconcileRef = inputItem.TrsBankReconcileRef,  
  
		TBRDItmType = inputItem.TBRDItmType,  
  
		TBRDItmKind = inputItem.TBRDItmKind,  
  
		TBRDItmRef = inputItem.TBRDItmRef,  
  
		TBRDItmDate = inputItem.TBRDItmDate,  
  
		TBRDItmNo = inputItem.TBRDItmNo,  
  
		TBRDDebit = inputItem.TBRDDebit,  
  
		TBRDCredit = inputItem.TBRDCredit,  
  
		TBRDDescr = inputItem.TBRDDescr,  
  
		TBRDRelId = inputItem.TBRDRelId, 
            };
            return dto;
        }

        public static List<TrsBankReconcileDetDto> Map(ICollection<TrsBankReconcileDet> entities)
        {
            var dtos = new List<TrsBankReconcileDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBankReconcileDetDto()
                {
                      
  
		TrsBankReconcileDetId = inputItem.TrsBankReconcileDetId,  
  
		TrsBankReconcileRef = inputItem.TrsBankReconcileRef,  
  
		TBRDItmType = inputItem.TBRDItmType,  
  
		TBRDItmKind = inputItem.TBRDItmKind,  
  
		TBRDItmRef = inputItem.TBRDItmRef,  
  
		TBRDItmDate = inputItem.TBRDItmDate,  
  
		TBRDItmNo = inputItem.TBRDItmNo,  
  
		TBRDDebit = inputItem.TBRDDebit,  
  
		TBRDCredit = inputItem.TBRDCredit,  
  
		TBRDDescr = inputItem.TBRDDescr,  
  
		TBRDRelId = inputItem.TBRDRelId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsBanks Map(AddTrsBanksCommand inputItem)
        {
            var entity = new TrsBanks() {
                  
  
		TrsBankId = inputItem.TrsBankId,  
  
		TrsBankName = inputItem.TrsBankName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsBanks Map(TrsBanks entity ,EditTrsBanksCommand inputItem)
        {
              
  
		entity.TrsBankId = inputItem.TrsBankId;  
  
		entity.TrsBankName = inputItem.TrsBankName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsBanksDto Map(TrsBanks inputItem)
        {
            var dto = new TrsBanksDto()
            {
                  
  
		TrsBankId = inputItem.TrsBankId,  
  
		TrsBankName = inputItem.TrsBankName, 
            };
            return dto;
        }

        public static List<TrsBanksDto> Map(ICollection<TrsBanks> entities)
        {
            var dtos = new List<TrsBanksDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsBanksDto()
                {
                      
  
		TrsBankId = inputItem.TrsBankId,  
  
		TrsBankName = inputItem.TrsBankName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsCalcFormula Map(AddTrsCalcFormulaCommand inputItem)
        {
            var entity = new TrsCalcFormula() {
                  
  
		TrsCalcFormulId = inputItem.TrsCalcFormulId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCKind = inputItem.TFCKind,  
  
		TFCFormula = inputItem.TFCFormula,  
  
		TFCInstCalc = inputItem.TFCInstCalc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsCalcFormula Map(TrsCalcFormula entity ,EditTrsCalcFormulaCommand inputItem)
        {
              
  
		entity.TrsCalcFormulId = inputItem.TrsCalcFormulId;  
  
		entity.TFCType = inputItem.TFCType;  
  
		entity.TFCKind = inputItem.TFCKind;  
  
		entity.TFCFormula = inputItem.TFCFormula;  
  
		entity.TFCInstCalc = inputItem.TFCInstCalc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsCalcFormulaDto Map(TrsCalcFormula inputItem)
        {
            var dto = new TrsCalcFormulaDto()
            {
                  
  
		TrsCalcFormulId = inputItem.TrsCalcFormulId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCKind = inputItem.TFCKind,  
  
		TFCFormula = inputItem.TFCFormula,  
  
		TFCInstCalc = inputItem.TFCInstCalc, 
            };
            return dto;
        }

        public static List<TrsCalcFormulaDto> Map(ICollection<TrsCalcFormula> entities)
        {
            var dtos = new List<TrsCalcFormulaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsCalcFormulaDto()
                {
                      
  
		TrsCalcFormulId = inputItem.TrsCalcFormulId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCKind = inputItem.TFCKind,  
  
		TFCFormula = inputItem.TFCFormula,  
  
		TFCInstCalc = inputItem.TFCInstCalc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsCashs Map(AddTrsCashsCommand inputItem)
        {
            var entity = new TrsCashs() {
                  
  
		TrsCashId = inputItem.TrsCashId,  
  
		TCName = inputItem.TCName,  
  
		TCCashier = inputItem.TCCashier,  
  
		TCFirstQty = inputItem.TCFirstQty,  
  
		TCDLRef = inputItem.TCDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsCashs Map(TrsCashs entity ,EditTrsCashsCommand inputItem)
        {
              
  
		entity.TrsCashId = inputItem.TrsCashId;  
  
		entity.TCName = inputItem.TCName;  
  
		entity.TCCashier = inputItem.TCCashier;  
  
		entity.TCFirstQty = inputItem.TCFirstQty;  
  
		entity.TCDLRef = inputItem.TCDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsCashsDto Map(TrsCashs inputItem)
        {
            var dto = new TrsCashsDto()
            {
                  
  
		TrsCashId = inputItem.TrsCashId,  
  
		TCName = inputItem.TCName,  
  
		TCCashier = inputItem.TCCashier,  
  
		TCFirstQty = inputItem.TCFirstQty,  
  
		TCDLRef = inputItem.TCDLRef, 
            };
            return dto;
        }

        public static List<TrsCashsDto> Map(ICollection<TrsCashs> entities)
        {
            var dtos = new List<TrsCashsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsCashsDto()
                {
                      
  
		TrsCashId = inputItem.TrsCashId,  
  
		TCName = inputItem.TCName,  
  
		TCCashier = inputItem.TCCashier,  
  
		TCFirstQty = inputItem.TCFirstQty,  
  
		TCDLRef = inputItem.TCDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsChqFmt Map(AddTrsChqFmtCommand inputItem)
        {
            var entity = new TrsChqFmt() {
                  
  
		TrsChqFmtId = inputItem.TrsChqFmtId,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFFile = inputItem.TCFFile, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsChqFmt Map(TrsChqFmt entity ,EditTrsChqFmtCommand inputItem)
        {
              
  
		entity.TrsChqFmtId = inputItem.TrsChqFmtId;  
  
		entity.TCFTitle = inputItem.TCFTitle;  
  
		entity.TCFFile = inputItem.TCFFile; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsChqFmtDto Map(TrsChqFmt inputItem)
        {
            var dto = new TrsChqFmtDto()
            {
                  
  
		TrsChqFmtId = inputItem.TrsChqFmtId,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFFile = inputItem.TCFFile, 
            };
            return dto;
        }

        public static List<TrsChqFmtDto> Map(ICollection<TrsChqFmt> entities)
        {
            var dtos = new List<TrsChqFmtDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsChqFmtDto()
                {
                      
  
		TrsChqFmtId = inputItem.TrsChqFmtId,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFFile = inputItem.TCFFile, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsCostFactors Map(AddTrsCostFactorsCommand inputItem)
        {
            var entity = new TrsCostFactors() {
                  
  
		TrsCostFactorId = inputItem.TrsCostFactorId,  
  
		TCFCode = inputItem.TCFCode,  
  
		TCFParent = inputItem.TCFParent,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFSLRef = inputItem.TCFSLRef,  
  
		TCFDLRef = inputItem.TCFDLRef,  
  
		TCFDLFive = inputItem.TCFDLFive,  
  
		TCFDLSix = inputItem.TCFDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsCostFactors Map(TrsCostFactors entity ,EditTrsCostFactorsCommand inputItem)
        {
              
  
		entity.TrsCostFactorId = inputItem.TrsCostFactorId;  
  
		entity.TCFCode = inputItem.TCFCode;  
  
		entity.TCFParent = inputItem.TCFParent;  
  
		entity.TCFTitle = inputItem.TCFTitle;  
  
		entity.TCFSLRef = inputItem.TCFSLRef;  
  
		entity.TCFDLRef = inputItem.TCFDLRef;  
  
		entity.TCFDLFive = inputItem.TCFDLFive;  
  
		entity.TCFDLSix = inputItem.TCFDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsCostFactorsDto Map(TrsCostFactors inputItem)
        {
            var dto = new TrsCostFactorsDto()
            {
                  
  
		TrsCostFactorId = inputItem.TrsCostFactorId,  
  
		TCFCode = inputItem.TCFCode,  
  
		TCFParent = inputItem.TCFParent,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFSLRef = inputItem.TCFSLRef,  
  
		TCFDLRef = inputItem.TCFDLRef,  
  
		TCFDLFive = inputItem.TCFDLFive,  
  
		TCFDLSix = inputItem.TCFDLSix, 
            };
            return dto;
        }

        public static List<TrsCostFactorsDto> Map(ICollection<TrsCostFactors> entities)
        {
            var dtos = new List<TrsCostFactorsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsCostFactorsDto()
                {
                      
  
		TrsCostFactorId = inputItem.TrsCostFactorId,  
  
		TCFCode = inputItem.TCFCode,  
  
		TCFParent = inputItem.TCFParent,  
  
		TCFTitle = inputItem.TCFTitle,  
  
		TCFSLRef = inputItem.TCFSLRef,  
  
		TCFDLRef = inputItem.TCFDLRef,  
  
		TCFDLFive = inputItem.TCFDLFive,  
  
		TCFDLSix = inputItem.TCFDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsCreditTbl Map(AddTrsCreditTblCommand inputItem)
        {
            var entity = new TrsCreditTbl() {
                  
  
		TrsCreditTblId = inputItem.TrsCreditTblId,  
  
		TCTType = inputItem.TCTType,  
  
		TCTDescr = inputItem.TCTDescr,  
  
		TCTDate = inputItem.TCTDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsCreditTbl Map(TrsCreditTbl entity ,EditTrsCreditTblCommand inputItem)
        {
              
  
		entity.TrsCreditTblId = inputItem.TrsCreditTblId;  
  
		entity.TCTType = inputItem.TCTType;  
  
		entity.TCTDescr = inputItem.TCTDescr;  
  
		entity.TCTDate = inputItem.TCTDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsCreditTblDto Map(TrsCreditTbl inputItem)
        {
            var dto = new TrsCreditTblDto()
            {
                  
  
		TrsCreditTblId = inputItem.TrsCreditTblId,  
  
		TCTType = inputItem.TCTType,  
  
		TCTDescr = inputItem.TCTDescr,  
  
		TCTDate = inputItem.TCTDate, 
            };
            return dto;
        }

        public static List<TrsCreditTblDto> Map(ICollection<TrsCreditTbl> entities)
        {
            var dtos = new List<TrsCreditTblDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsCreditTblDto()
                {
                      
  
		TrsCreditTblId = inputItem.TrsCreditTblId,  
  
		TCTType = inputItem.TCTType,  
  
		TCTDescr = inputItem.TCTDescr,  
  
		TCTDate = inputItem.TCTDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsCreditTblDet Map(AddTrsCreditTblDetCommand inputItem)
        {
            var entity = new TrsCreditTblDet() {
                  
  
		TCTDHdrRef = inputItem.TCTDHdrRef,  
  
		TCTDFVal = inputItem.TCTDFVal,  
  
		TCTDTVal = inputItem.TCTDTVal,  
  
		TCTDDirect = inputItem.TCTDDirect,  
  
		TCTDInDirect = inputItem.TCTDInDirect, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsCreditTblDet Map(TrsCreditTblDet entity ,EditTrsCreditTblDetCommand inputItem)
        {
              
  
		entity.TCTDHdrRef = inputItem.TCTDHdrRef;  
  
		entity.TCTDFVal = inputItem.TCTDFVal;  
  
		entity.TCTDTVal = inputItem.TCTDTVal;  
  
		entity.TCTDDirect = inputItem.TCTDDirect;  
  
		entity.TCTDInDirect = inputItem.TCTDInDirect; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsCreditTblDetDto Map(TrsCreditTblDet inputItem)
        {
            var dto = new TrsCreditTblDetDto()
            {
                  
  
		TCTDHdrRef = inputItem.TCTDHdrRef,  
  
		TCTDFVal = inputItem.TCTDFVal,  
  
		TCTDTVal = inputItem.TCTDTVal,  
  
		TCTDDirect = inputItem.TCTDDirect,  
  
		TCTDInDirect = inputItem.TCTDInDirect, 
            };
            return dto;
        }

        public static List<TrsCreditTblDetDto> Map(ICollection<TrsCreditTblDet> entities)
        {
            var dtos = new List<TrsCreditTblDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsCreditTblDetDto()
                {
                      
  
		TCTDHdrRef = inputItem.TCTDHdrRef,  
  
		TCTDFVal = inputItem.TCTDFVal,  
  
		TCTDTVal = inputItem.TCTDTVal,  
  
		TCTDDirect = inputItem.TCTDDirect,  
  
		TCTDInDirect = inputItem.TCTDInDirect, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsDeposit Map(AddTrsDepositCommand inputItem)
        {
            var entity = new TrsDeposit() {
                  
  
		TrsDepositId = inputItem.TrsDepositId,  
  
		TDType = inputItem.TDType,  
  
		TDNum = inputItem.TDNum,  
  
		TDDate = inputItem.TDDate,  
  
		TDSrcUseRef = inputItem.TDSrcUseRef,  
  
		TDDLRef = inputItem.TDDLRef,  
  
		TDDescr = inputItem.TDDescr,  
  
		TDAmount = inputItem.TDAmount,  
  
		TDInstRate = inputItem.TDInstRate,  
  
		TDInstDate = inputItem.TDInstDate,  
  
		TDPayDur = inputItem.TDPayDur,  
  
		TDAccPrdRef = inputItem.TDAccPrdRef,  
  
		TDState = inputItem.TDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsDeposit Map(TrsDeposit entity ,EditTrsDepositCommand inputItem)
        {
              
  
		entity.TrsDepositId = inputItem.TrsDepositId;  
  
		entity.TDType = inputItem.TDType;  
  
		entity.TDNum = inputItem.TDNum;  
  
		entity.TDDate = inputItem.TDDate;  
  
		entity.TDSrcUseRef = inputItem.TDSrcUseRef;  
  
		entity.TDDLRef = inputItem.TDDLRef;  
  
		entity.TDDescr = inputItem.TDDescr;  
  
		entity.TDAmount = inputItem.TDAmount;  
  
		entity.TDInstRate = inputItem.TDInstRate;  
  
		entity.TDInstDate = inputItem.TDInstDate;  
  
		entity.TDPayDur = inputItem.TDPayDur;  
  
		entity.TDAccPrdRef = inputItem.TDAccPrdRef;  
  
		entity.TDState = inputItem.TDState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsDepositDto Map(TrsDeposit inputItem)
        {
            var dto = new TrsDepositDto()
            {
                  
  
		TrsDepositId = inputItem.TrsDepositId,  
  
		TDType = inputItem.TDType,  
  
		TDNum = inputItem.TDNum,  
  
		TDDate = inputItem.TDDate,  
  
		TDSrcUseRef = inputItem.TDSrcUseRef,  
  
		TDDLRef = inputItem.TDDLRef,  
  
		TDDescr = inputItem.TDDescr,  
  
		TDAmount = inputItem.TDAmount,  
  
		TDInstRate = inputItem.TDInstRate,  
  
		TDInstDate = inputItem.TDInstDate,  
  
		TDPayDur = inputItem.TDPayDur,  
  
		TDAccPrdRef = inputItem.TDAccPrdRef,  
  
		TDState = inputItem.TDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
            };
            return dto;
        }

        public static List<TrsDepositDto> Map(ICollection<TrsDeposit> entities)
        {
            var dtos = new List<TrsDepositDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsDepositDto()
                {
                      
  
		TrsDepositId = inputItem.TrsDepositId,  
  
		TDType = inputItem.TDType,  
  
		TDNum = inputItem.TDNum,  
  
		TDDate = inputItem.TDDate,  
  
		TDSrcUseRef = inputItem.TDSrcUseRef,  
  
		TDDLRef = inputItem.TDDLRef,  
  
		TDDescr = inputItem.TDDescr,  
  
		TDAmount = inputItem.TDAmount,  
  
		TDInstRate = inputItem.TDInstRate,  
  
		TDInstDate = inputItem.TDInstDate,  
  
		TDPayDur = inputItem.TDPayDur,  
  
		TDAccPrdRef = inputItem.TDAccPrdRef,  
  
		TDState = inputItem.TDState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsDepositCalc Map(AddTrsDepositCalcCommand inputItem)
        {
            var entity = new TrsDepositCalc() {
                  
  
		TrsDepositCalcId = inputItem.TrsDepositCalcId,  
  
		TDCItemRef = inputItem.TDCItemRef,  
  
		TDCYear = inputItem.TDCYear,  
  
		TDCMonth = inputItem.TDCMonth,  
  
		TDCAmount = inputItem.TDCAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsDepositCalc Map(TrsDepositCalc entity ,EditTrsDepositCalcCommand inputItem)
        {
              
  
		entity.TrsDepositCalcId = inputItem.TrsDepositCalcId;  
  
		entity.TDCItemRef = inputItem.TDCItemRef;  
  
		entity.TDCYear = inputItem.TDCYear;  
  
		entity.TDCMonth = inputItem.TDCMonth;  
  
		entity.TDCAmount = inputItem.TDCAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsDepositCalcDto Map(TrsDepositCalc inputItem)
        {
            var dto = new TrsDepositCalcDto()
            {
                  
  
		TrsDepositCalcId = inputItem.TrsDepositCalcId,  
  
		TDCItemRef = inputItem.TDCItemRef,  
  
		TDCYear = inputItem.TDCYear,  
  
		TDCMonth = inputItem.TDCMonth,  
  
		TDCAmount = inputItem.TDCAmount, 
            };
            return dto;
        }

        public static List<TrsDepositCalcDto> Map(ICollection<TrsDepositCalc> entities)
        {
            var dtos = new List<TrsDepositCalcDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsDepositCalcDto()
                {
                      
  
		TrsDepositCalcId = inputItem.TrsDepositCalcId,  
  
		TDCItemRef = inputItem.TDCItemRef,  
  
		TDCYear = inputItem.TDCYear,  
  
		TDCMonth = inputItem.TDCMonth,  
  
		TDCAmount = inputItem.TDCAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsDepositDet Map(AddTrsDepositDetCommand inputItem)
        {
            var entity = new TrsDepositDet() {
                  
  
		TrsDepositDetId = inputItem.TrsDepositDetId,  
  
		TDDType = inputItem.TDDType,  
  
		TDDDeptRef = inputItem.TDDDeptRef,  
  
		TDDDate = inputItem.TDDDate,  
  
		TDDAmount = inputItem.TDDAmount,  
  
		TDDDescr = inputItem.TDDDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsDepositDet Map(TrsDepositDet entity ,EditTrsDepositDetCommand inputItem)
        {
              
  
		entity.TrsDepositDetId = inputItem.TrsDepositDetId;  
  
		entity.TDDType = inputItem.TDDType;  
  
		entity.TDDDeptRef = inputItem.TDDDeptRef;  
  
		entity.TDDDate = inputItem.TDDDate;  
  
		entity.TDDAmount = inputItem.TDDAmount;  
  
		entity.TDDDescr = inputItem.TDDDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsDepositDetDto Map(TrsDepositDet inputItem)
        {
            var dto = new TrsDepositDetDto()
            {
                  
  
		TrsDepositDetId = inputItem.TrsDepositDetId,  
  
		TDDType = inputItem.TDDType,  
  
		TDDDeptRef = inputItem.TDDDeptRef,  
  
		TDDDate = inputItem.TDDDate,  
  
		TDDAmount = inputItem.TDDAmount,  
  
		TDDDescr = inputItem.TDDDescr, 
            };
            return dto;
        }

        public static List<TrsDepositDetDto> Map(ICollection<TrsDepositDet> entities)
        {
            var dtos = new List<TrsDepositDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsDepositDetDto()
                {
                      
  
		TrsDepositDetId = inputItem.TrsDepositDetId,  
  
		TDDType = inputItem.TDDType,  
  
		TDDDeptRef = inputItem.TDDDeptRef,  
  
		TDDDate = inputItem.TDDDate,  
  
		TDDAmount = inputItem.TDDAmount,  
  
		TDDDescr = inputItem.TDDDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacCrdTbl Map(AddTrsFacCrdTblCommand inputItem)
        {
            var entity = new TrsFacCrdTbl() {
                  
  
		TrsFacCrdTblId = inputItem.TrsFacCrdTblId,  
  
		TFCTDescr = inputItem.TFCTDescr,  
  
		TFCTDate = inputItem.TFCTDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacCrdTbl Map(TrsFacCrdTbl entity ,EditTrsFacCrdTblCommand inputItem)
        {
              
  
		entity.TrsFacCrdTblId = inputItem.TrsFacCrdTblId;  
  
		entity.TFCTDescr = inputItem.TFCTDescr;  
  
		entity.TFCTDate = inputItem.TFCTDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacCrdTblDto Map(TrsFacCrdTbl inputItem)
        {
            var dto = new TrsFacCrdTblDto()
            {
                  
  
		TrsFacCrdTblId = inputItem.TrsFacCrdTblId,  
  
		TFCTDescr = inputItem.TFCTDescr,  
  
		TFCTDate = inputItem.TFCTDate, 
            };
            return dto;
        }

        public static List<TrsFacCrdTblDto> Map(ICollection<TrsFacCrdTbl> entities)
        {
            var dtos = new List<TrsFacCrdTblDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacCrdTblDto()
                {
                      
  
		TrsFacCrdTblId = inputItem.TrsFacCrdTblId,  
  
		TFCTDescr = inputItem.TFCTDescr,  
  
		TFCTDate = inputItem.TFCTDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacCrdTblDet Map(AddTrsFacCrdTblDetCommand inputItem)
        {
            var entity = new TrsFacCrdTblDet() {
                  
  
		TFCTDHdrRef = inputItem.TFCTDHdrRef,  
  
		TFCTDFVal = inputItem.TFCTDFVal,  
  
		TFCTDTVal = inputItem.TFCTDTVal,  
  
		TFCTDDirect = inputItem.TFCTDDirect,  
  
		TFCTDInDirect = inputItem.TFCTDInDirect, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacCrdTblDet Map(TrsFacCrdTblDet entity ,EditTrsFacCrdTblDetCommand inputItem)
        {
              
  
		entity.TFCTDHdrRef = inputItem.TFCTDHdrRef;  
  
		entity.TFCTDFVal = inputItem.TFCTDFVal;  
  
		entity.TFCTDTVal = inputItem.TFCTDTVal;  
  
		entity.TFCTDDirect = inputItem.TFCTDDirect;  
  
		entity.TFCTDInDirect = inputItem.TFCTDInDirect; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacCrdTblDetDto Map(TrsFacCrdTblDet inputItem)
        {
            var dto = new TrsFacCrdTblDetDto()
            {
                  
  
		TFCTDHdrRef = inputItem.TFCTDHdrRef,  
  
		TFCTDFVal = inputItem.TFCTDFVal,  
  
		TFCTDTVal = inputItem.TFCTDTVal,  
  
		TFCTDDirect = inputItem.TFCTDDirect,  
  
		TFCTDInDirect = inputItem.TFCTDInDirect, 
            };
            return dto;
        }

        public static List<TrsFacCrdTblDetDto> Map(ICollection<TrsFacCrdTblDet> entities)
        {
            var dtos = new List<TrsFacCrdTblDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacCrdTblDetDto()
                {
                      
  
		TFCTDHdrRef = inputItem.TFCTDHdrRef,  
  
		TFCTDFVal = inputItem.TFCTDFVal,  
  
		TFCTDTVal = inputItem.TFCTDTVal,  
  
		TFCTDDirect = inputItem.TFCTDDirect,  
  
		TFCTDInDirect = inputItem.TFCTDInDirect, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacilities Map(AddTrsFacilitiesCommand inputItem)
        {
            var entity = new TrsFacilities() {
                  
  
		TrsFacilitiesId = inputItem.TrsFacilitiesId,  
  
		TFType = inputItem.TFType,  
  
		TFKind = inputItem.TFKind,  
  
		TFContRef = inputItem.TFContRef,  
  
		TFNum = inputItem.TFNum,  
  
		TFDate = inputItem.TFDate,  
  
		TFSrcUseRef = inputItem.TFSrcUseRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDescr = inputItem.TFDescr,  
  
		TFAmount = inputItem.TFAmount,  
  
		TFInstAmount = inputItem.TFInstAmount,  
  
		TFInstDate = inputItem.TFInstDate,  
  
		TFShareAmnt = inputItem.TFShareAmnt,  
  
		TFSharePrc = inputItem.TFSharePrc,  
  
		TFLatePrc = inputItem.TFLatePrc,  
  
		TFLateType = inputItem.TFLateType,  
  
		TFPayDur = inputItem.TFPayDur,  
  
		TFAccPrdRef = inputItem.TFAccPrdRef,  
  
		TFState = inputItem.TFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFTaxAmnt = inputItem.TFTaxAmnt,  
  
		TFDutyAmnt = inputItem.TFDutyAmnt,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix,  
  
		TFOpsType = inputItem.TFOpsType,  
  
		TFIInstPayType = inputItem.TFIInstPayType,  
  
		TFIWorkLoc = inputItem.TFIWorkLoc,  
  
		TFIComp = inputItem.TFIComp,  
  
		TFIPersCode = inputItem.TFIPersCode,  
  
		TFIOthCode = inputItem.TFIOthCode,  
  
		TFIBankInf = inputItem.TFIBankInf,  
  
		TFIAcnNo = inputItem.TFIAcnNo,  
  
		TFIsLoan = inputItem.TFIsLoan,  
  
		TFBlockAmnt = inputItem.TFBlockAmnt,  
  
		TFCreator = inputItem.TFCreator,  
  
		TFSit = inputItem.TFSit,  
  
		TFDelayShare = inputItem.TFDelayShare, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacilities Map(TrsFacilities entity ,EditTrsFacilitiesCommand inputItem)
        {
              
  
		entity.TrsFacilitiesId = inputItem.TrsFacilitiesId;  
  
		entity.TFType = inputItem.TFType;  
  
		entity.TFKind = inputItem.TFKind;  
  
		entity.TFContRef = inputItem.TFContRef;  
  
		entity.TFNum = inputItem.TFNum;  
  
		entity.TFDate = inputItem.TFDate;  
  
		entity.TFSrcUseRef = inputItem.TFSrcUseRef;  
  
		entity.TFDLRef = inputItem.TFDLRef;  
  
		entity.TFDescr = inputItem.TFDescr;  
  
		entity.TFAmount = inputItem.TFAmount;  
  
		entity.TFInstAmount = inputItem.TFInstAmount;  
  
		entity.TFInstDate = inputItem.TFInstDate;  
  
		entity.TFShareAmnt = inputItem.TFShareAmnt;  
  
		entity.TFSharePrc = inputItem.TFSharePrc;  
  
		entity.TFLatePrc = inputItem.TFLatePrc;  
  
		entity.TFLateType = inputItem.TFLateType;  
  
		entity.TFPayDur = inputItem.TFPayDur;  
  
		entity.TFAccPrdRef = inputItem.TFAccPrdRef;  
  
		entity.TFState = inputItem.TFState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TFTaxAmnt = inputItem.TFTaxAmnt;  
  
		entity.TFDutyAmnt = inputItem.TFDutyAmnt;  
  
		entity.TFDLFive = inputItem.TFDLFive;  
  
		entity.TFDLSix = inputItem.TFDLSix;  
  
		entity.TFOpsType = inputItem.TFOpsType;  
  
		entity.TFIInstPayType = inputItem.TFIInstPayType;  
  
		entity.TFIWorkLoc = inputItem.TFIWorkLoc;  
  
		entity.TFIComp = inputItem.TFIComp;  
  
		entity.TFIPersCode = inputItem.TFIPersCode;  
  
		entity.TFIOthCode = inputItem.TFIOthCode;  
  
		entity.TFIBankInf = inputItem.TFIBankInf;  
  
		entity.TFIAcnNo = inputItem.TFIAcnNo;  
  
		entity.TFIsLoan = inputItem.TFIsLoan;  
  
		entity.TFBlockAmnt = inputItem.TFBlockAmnt;  
  
		entity.TFCreator = inputItem.TFCreator;  
  
		entity.TFSit = inputItem.TFSit;  
  
		entity.TFDelayShare = inputItem.TFDelayShare; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacilitiesDto Map(TrsFacilities inputItem)
        {
            var dto = new TrsFacilitiesDto()
            {
                  
  
		TrsFacilitiesId = inputItem.TrsFacilitiesId,  
  
		TFType = inputItem.TFType,  
  
		TFKind = inputItem.TFKind,  
  
		TFContRef = inputItem.TFContRef,  
  
		TFNum = inputItem.TFNum,  
  
		TFDate = inputItem.TFDate,  
  
		TFSrcUseRef = inputItem.TFSrcUseRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDescr = inputItem.TFDescr,  
  
		TFAmount = inputItem.TFAmount,  
  
		TFInstAmount = inputItem.TFInstAmount,  
  
		TFInstDate = inputItem.TFInstDate,  
  
		TFShareAmnt = inputItem.TFShareAmnt,  
  
		TFSharePrc = inputItem.TFSharePrc,  
  
		TFLatePrc = inputItem.TFLatePrc,  
  
		TFLateType = inputItem.TFLateType,  
  
		TFPayDur = inputItem.TFPayDur,  
  
		TFAccPrdRef = inputItem.TFAccPrdRef,  
  
		TFState = inputItem.TFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFTaxAmnt = inputItem.TFTaxAmnt,  
  
		TFDutyAmnt = inputItem.TFDutyAmnt,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix,  
  
		TFOpsType = inputItem.TFOpsType,  
  
		TFIInstPayType = inputItem.TFIInstPayType,  
  
		TFIWorkLoc = inputItem.TFIWorkLoc,  
  
		TFIComp = inputItem.TFIComp,  
  
		TFIPersCode = inputItem.TFIPersCode,  
  
		TFIOthCode = inputItem.TFIOthCode,  
  
		TFIBankInf = inputItem.TFIBankInf,  
  
		TFIAcnNo = inputItem.TFIAcnNo,  
  
		TFIsLoan = inputItem.TFIsLoan,  
  
		TFBlockAmnt = inputItem.TFBlockAmnt,  
  
		TFCreator = inputItem.TFCreator,  
  
		TFSit = inputItem.TFSit,  
  
		TFDelayShare = inputItem.TFDelayShare, 
            };
            return dto;
        }

        public static List<TrsFacilitiesDto> Map(ICollection<TrsFacilities> entities)
        {
            var dtos = new List<TrsFacilitiesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacilitiesDto()
                {
                      
  
		TrsFacilitiesId = inputItem.TrsFacilitiesId,  
  
		TFType = inputItem.TFType,  
  
		TFKind = inputItem.TFKind,  
  
		TFContRef = inputItem.TFContRef,  
  
		TFNum = inputItem.TFNum,  
  
		TFDate = inputItem.TFDate,  
  
		TFSrcUseRef = inputItem.TFSrcUseRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDescr = inputItem.TFDescr,  
  
		TFAmount = inputItem.TFAmount,  
  
		TFInstAmount = inputItem.TFInstAmount,  
  
		TFInstDate = inputItem.TFInstDate,  
  
		TFShareAmnt = inputItem.TFShareAmnt,  
  
		TFSharePrc = inputItem.TFSharePrc,  
  
		TFLatePrc = inputItem.TFLatePrc,  
  
		TFLateType = inputItem.TFLateType,  
  
		TFPayDur = inputItem.TFPayDur,  
  
		TFAccPrdRef = inputItem.TFAccPrdRef,  
  
		TFState = inputItem.TFState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFTaxAmnt = inputItem.TFTaxAmnt,  
  
		TFDutyAmnt = inputItem.TFDutyAmnt,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix,  
  
		TFOpsType = inputItem.TFOpsType,  
  
		TFIInstPayType = inputItem.TFIInstPayType,  
  
		TFIWorkLoc = inputItem.TFIWorkLoc,  
  
		TFIComp = inputItem.TFIComp,  
  
		TFIPersCode = inputItem.TFIPersCode,  
  
		TFIOthCode = inputItem.TFIOthCode,  
  
		TFIBankInf = inputItem.TFIBankInf,  
  
		TFIAcnNo = inputItem.TFIAcnNo,  
  
		TFIsLoan = inputItem.TFIsLoan,  
  
		TFBlockAmnt = inputItem.TFBlockAmnt,  
  
		TFCreator = inputItem.TFCreator,  
  
		TFSit = inputItem.TFSit,  
  
		TFDelayShare = inputItem.TFDelayShare, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacilitiesDet Map(AddTrsFacilitiesDetCommand inputItem)
        {
            var entity = new TrsFacilitiesDet() {
                  
  
		TrsFacilitiesDetId = inputItem.TrsFacilitiesDetId,  
  
		TFDFacRef = inputItem.TFDFacRef,  
  
		TFDNum = inputItem.TFDNum,  
  
		TFDPaySerial = inputItem.TFDPaySerial,  
  
		TFDDate = inputItem.TFDDate,  
  
		TFDInstAmnt = inputItem.TFDInstAmnt,  
  
		TFDShareAmnt = inputItem.TFDShareAmnt,  
  
		TFDTaxAmnt = inputItem.TFDTaxAmnt,  
  
		TFDDutyAmnt = inputItem.TFDDutyAmnt,  
  
		TFDLateAmnt = inputItem.TFDLateAmnt,  
  
		TFDPayAmnt = inputItem.TFDPayAmnt,  
  
		TFDDescr = inputItem.TFDDescr,  
  
		TFDPayDate = inputItem.TFDPayDate,  
  
		TFDAccPrdRef = inputItem.TFDAccPrdRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacilitiesDet Map(TrsFacilitiesDet entity ,EditTrsFacilitiesDetCommand inputItem)
        {
              
  
		entity.TrsFacilitiesDetId = inputItem.TrsFacilitiesDetId;  
  
		entity.TFDFacRef = inputItem.TFDFacRef;  
  
		entity.TFDNum = inputItem.TFDNum;  
  
		entity.TFDPaySerial = inputItem.TFDPaySerial;  
  
		entity.TFDDate = inputItem.TFDDate;  
  
		entity.TFDInstAmnt = inputItem.TFDInstAmnt;  
  
		entity.TFDShareAmnt = inputItem.TFDShareAmnt;  
  
		entity.TFDTaxAmnt = inputItem.TFDTaxAmnt;  
  
		entity.TFDDutyAmnt = inputItem.TFDDutyAmnt;  
  
		entity.TFDLateAmnt = inputItem.TFDLateAmnt;  
  
		entity.TFDPayAmnt = inputItem.TFDPayAmnt;  
  
		entity.TFDDescr = inputItem.TFDDescr;  
  
		entity.TFDPayDate = inputItem.TFDPayDate;  
  
		entity.TFDAccPrdRef = inputItem.TFDAccPrdRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacilitiesDetDto Map(TrsFacilitiesDet inputItem)
        {
            var dto = new TrsFacilitiesDetDto()
            {
                  
  
		TrsFacilitiesDetId = inputItem.TrsFacilitiesDetId,  
  
		TFDFacRef = inputItem.TFDFacRef,  
  
		TFDNum = inputItem.TFDNum,  
  
		TFDPaySerial = inputItem.TFDPaySerial,  
  
		TFDDate = inputItem.TFDDate,  
  
		TFDInstAmnt = inputItem.TFDInstAmnt,  
  
		TFDShareAmnt = inputItem.TFDShareAmnt,  
  
		TFDTaxAmnt = inputItem.TFDTaxAmnt,  
  
		TFDDutyAmnt = inputItem.TFDDutyAmnt,  
  
		TFDLateAmnt = inputItem.TFDLateAmnt,  
  
		TFDPayAmnt = inputItem.TFDPayAmnt,  
  
		TFDDescr = inputItem.TFDDescr,  
  
		TFDPayDate = inputItem.TFDPayDate,  
  
		TFDAccPrdRef = inputItem.TFDAccPrdRef, 
            };
            return dto;
        }

        public static List<TrsFacilitiesDetDto> Map(ICollection<TrsFacilitiesDet> entities)
        {
            var dtos = new List<TrsFacilitiesDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacilitiesDetDto()
                {
                      
  
		TrsFacilitiesDetId = inputItem.TrsFacilitiesDetId,  
  
		TFDFacRef = inputItem.TFDFacRef,  
  
		TFDNum = inputItem.TFDNum,  
  
		TFDPaySerial = inputItem.TFDPaySerial,  
  
		TFDDate = inputItem.TFDDate,  
  
		TFDInstAmnt = inputItem.TFDInstAmnt,  
  
		TFDShareAmnt = inputItem.TFDShareAmnt,  
  
		TFDTaxAmnt = inputItem.TFDTaxAmnt,  
  
		TFDDutyAmnt = inputItem.TFDDutyAmnt,  
  
		TFDLateAmnt = inputItem.TFDLateAmnt,  
  
		TFDPayAmnt = inputItem.TFDPayAmnt,  
  
		TFDDescr = inputItem.TFDDescr,  
  
		TFDPayDate = inputItem.TFDPayDate,  
  
		TFDAccPrdRef = inputItem.TFDAccPrdRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacilitiesGua Map(AddTrsFacilitiesGuaCommand inputItem)
        {
            var entity = new TrsFacilitiesGua() {
                  
  
		TrsFacilitiesGuaId = inputItem.TrsFacilitiesGuaId,  
  
		TFGFacRef = inputItem.TFGFacRef,  
  
		TFGRcvDocId = inputItem.TFGRcvDocId,  
  
		TFGDescr = inputItem.TFGDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacilitiesGua Map(TrsFacilitiesGua entity ,EditTrsFacilitiesGuaCommand inputItem)
        {
              
  
		entity.TrsFacilitiesGuaId = inputItem.TrsFacilitiesGuaId;  
  
		entity.TFGFacRef = inputItem.TFGFacRef;  
  
		entity.TFGRcvDocId = inputItem.TFGRcvDocId;  
  
		entity.TFGDescr = inputItem.TFGDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacilitiesGuaDto Map(TrsFacilitiesGua inputItem)
        {
            var dto = new TrsFacilitiesGuaDto()
            {
                  
  
		TrsFacilitiesGuaId = inputItem.TrsFacilitiesGuaId,  
  
		TFGFacRef = inputItem.TFGFacRef,  
  
		TFGRcvDocId = inputItem.TFGRcvDocId,  
  
		TFGDescr = inputItem.TFGDescr, 
            };
            return dto;
        }

        public static List<TrsFacilitiesGuaDto> Map(ICollection<TrsFacilitiesGua> entities)
        {
            var dtos = new List<TrsFacilitiesGuaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacilitiesGuaDto()
                {
                      
  
		TrsFacilitiesGuaId = inputItem.TrsFacilitiesGuaId,  
  
		TFGFacRef = inputItem.TFGFacRef,  
  
		TFGRcvDocId = inputItem.TFGRcvDocId,  
  
		TFGDescr = inputItem.TFGDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacilitiesSec Map(AddTrsFacilitiesSecCommand inputItem)
        {
            var entity = new TrsFacilitiesSec() {
                  
  
		TrsFacilitiesSecId = inputItem.TrsFacilitiesSecId,  
  
		TFSFacRef = inputItem.TFSFacRef,  
  
		TFSDLRef = inputItem.TFSDLRef,  
  
		TFSFullName = inputItem.TFSFullName,  
  
		TFSNatCode = inputItem.TFSNatCode,  
  
		TFSPhone = inputItem.TFSPhone,  
  
		TFSMobile = inputItem.TFSMobile,  
  
		TFSDescr = inputItem.TFSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacilitiesSec Map(TrsFacilitiesSec entity ,EditTrsFacilitiesSecCommand inputItem)
        {
              
  
		entity.TrsFacilitiesSecId = inputItem.TrsFacilitiesSecId;  
  
		entity.TFSFacRef = inputItem.TFSFacRef;  
  
		entity.TFSDLRef = inputItem.TFSDLRef;  
  
		entity.TFSFullName = inputItem.TFSFullName;  
  
		entity.TFSNatCode = inputItem.TFSNatCode;  
  
		entity.TFSPhone = inputItem.TFSPhone;  
  
		entity.TFSMobile = inputItem.TFSMobile;  
  
		entity.TFSDescr = inputItem.TFSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacilitiesSecDto Map(TrsFacilitiesSec inputItem)
        {
            var dto = new TrsFacilitiesSecDto()
            {
                  
  
		TrsFacilitiesSecId = inputItem.TrsFacilitiesSecId,  
  
		TFSFacRef = inputItem.TFSFacRef,  
  
		TFSDLRef = inputItem.TFSDLRef,  
  
		TFSFullName = inputItem.TFSFullName,  
  
		TFSNatCode = inputItem.TFSNatCode,  
  
		TFSPhone = inputItem.TFSPhone,  
  
		TFSMobile = inputItem.TFSMobile,  
  
		TFSDescr = inputItem.TFSDescr, 
            };
            return dto;
        }

        public static List<TrsFacilitiesSecDto> Map(ICollection<TrsFacilitiesSec> entities)
        {
            var dtos = new List<TrsFacilitiesSecDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacilitiesSecDto()
                {
                      
  
		TrsFacilitiesSecId = inputItem.TrsFacilitiesSecId,  
  
		TFSFacRef = inputItem.TFSFacRef,  
  
		TFSDLRef = inputItem.TFSDLRef,  
  
		TFSFullName = inputItem.TFSFullName,  
  
		TFSNatCode = inputItem.TFSNatCode,  
  
		TFSPhone = inputItem.TFSPhone,  
  
		TFSMobile = inputItem.TFSMobile,  
  
		TFSDescr = inputItem.TFSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacManCredit Map(AddTrsFacManCreditCommand inputItem)
        {
            var entity = new TrsFacManCredit() {
                  
  
		TrsFacManCreditId = inputItem.TrsFacManCreditId,  
  
		TFMCCrspndRef = inputItem.TFMCCrspndRef,  
  
		TFMCType = inputItem.TFMCType,  
  
		TFMCAmount = inputItem.TFMCAmount,  
  
		TFMCDescr = inputItem.TFMCDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacManCredit Map(TrsFacManCredit entity ,EditTrsFacManCreditCommand inputItem)
        {
              
  
		entity.TrsFacManCreditId = inputItem.TrsFacManCreditId;  
  
		entity.TFMCCrspndRef = inputItem.TFMCCrspndRef;  
  
		entity.TFMCType = inputItem.TFMCType;  
  
		entity.TFMCAmount = inputItem.TFMCAmount;  
  
		entity.TFMCDescr = inputItem.TFMCDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacManCreditDto Map(TrsFacManCredit inputItem)
        {
            var dto = new TrsFacManCreditDto()
            {
                  
  
		TrsFacManCreditId = inputItem.TrsFacManCreditId,  
  
		TFMCCrspndRef = inputItem.TFMCCrspndRef,  
  
		TFMCType = inputItem.TFMCType,  
  
		TFMCAmount = inputItem.TFMCAmount,  
  
		TFMCDescr = inputItem.TFMCDescr, 
            };
            return dto;
        }

        public static List<TrsFacManCreditDto> Map(ICollection<TrsFacManCredit> entities)
        {
            var dtos = new List<TrsFacManCreditDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacManCreditDto()
                {
                      
  
		TrsFacManCreditId = inputItem.TrsFacManCreditId,  
  
		TFMCCrspndRef = inputItem.TFMCCrspndRef,  
  
		TFMCType = inputItem.TFMCType,  
  
		TFMCAmount = inputItem.TFMCAmount,  
  
		TFMCDescr = inputItem.TFMCDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacTypeInf Map(AddTrsFacTypeInfCommand inputItem)
        {
            var entity = new TrsFacTypeInf() {
                  
  
		TrsFacTypeInfId = inputItem.TrsFacTypeInfId,  
  
		TFTIFacRef = inputItem.TFTIFacRef,  
  
		TFTIDate = inputItem.TFTIDate,  
  
		TFTIRate = inputItem.TFTIRate,  
  
		TFTIDur = inputItem.TFTIDur, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacTypeInf Map(TrsFacTypeInf entity ,EditTrsFacTypeInfCommand inputItem)
        {
              
  
		entity.TrsFacTypeInfId = inputItem.TrsFacTypeInfId;  
  
		entity.TFTIFacRef = inputItem.TFTIFacRef;  
  
		entity.TFTIDate = inputItem.TFTIDate;  
  
		entity.TFTIRate = inputItem.TFTIRate;  
  
		entity.TFTIDur = inputItem.TFTIDur; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacTypeInfDto Map(TrsFacTypeInf inputItem)
        {
            var dto = new TrsFacTypeInfDto()
            {
                  
  
		TrsFacTypeInfId = inputItem.TrsFacTypeInfId,  
  
		TFTIFacRef = inputItem.TFTIFacRef,  
  
		TFTIDate = inputItem.TFTIDate,  
  
		TFTIRate = inputItem.TFTIRate,  
  
		TFTIDur = inputItem.TFTIDur, 
            };
            return dto;
        }

        public static List<TrsFacTypeInfDto> Map(ICollection<TrsFacTypeInf> entities)
        {
            var dtos = new List<TrsFacTypeInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacTypeInfDto()
                {
                      
  
		TrsFacTypeInfId = inputItem.TrsFacTypeInfId,  
  
		TFTIFacRef = inputItem.TFTIFacRef,  
  
		TFTIDate = inputItem.TFTIDate,  
  
		TFTIRate = inputItem.TFTIRate,  
  
		TFTIDur = inputItem.TFTIDur, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFacYearShare Map(AddTrsFacYearShareCommand inputItem)
        {
            var entity = new TrsFacYearShare() {
                  
  
		TFYSFacRef = inputItem.TFYSFacRef,  
  
		TFYSPeriodRef = inputItem.TFYSPeriodRef,  
  
		TFYSToDate = inputItem.TFYSToDate,  
  
		TFYSVal = inputItem.TFYSVal,  
  
		TFYSDescr = inputItem.TFYSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFacYearShare Map(TrsFacYearShare entity ,EditTrsFacYearShareCommand inputItem)
        {
              
  
		entity.TFYSFacRef = inputItem.TFYSFacRef;  
  
		entity.TFYSPeriodRef = inputItem.TFYSPeriodRef;  
  
		entity.TFYSToDate = inputItem.TFYSToDate;  
  
		entity.TFYSVal = inputItem.TFYSVal;  
  
		entity.TFYSDescr = inputItem.TFYSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFacYearShareDto Map(TrsFacYearShare inputItem)
        {
            var dto = new TrsFacYearShareDto()
            {
                  
  
		TFYSFacRef = inputItem.TFYSFacRef,  
  
		TFYSPeriodRef = inputItem.TFYSPeriodRef,  
  
		TFYSToDate = inputItem.TFYSToDate,  
  
		TFYSVal = inputItem.TFYSVal,  
  
		TFYSDescr = inputItem.TFYSDescr, 
            };
            return dto;
        }

        public static List<TrsFacYearShareDto> Map(ICollection<TrsFacYearShare> entities)
        {
            var dtos = new List<TrsFacYearShareDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFacYearShareDto()
                {
                      
  
		TFYSFacRef = inputItem.TFYSFacRef,  
  
		TFYSPeriodRef = inputItem.TFYSPeriodRef,  
  
		TFYSToDate = inputItem.TFYSToDate,  
  
		TFYSVal = inputItem.TFYSVal,  
  
		TFYSDescr = inputItem.TFYSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFContract Map(AddTrsFContractCommand inputItem)
        {
            var entity = new TrsFContract() {
                  
  
		TrsFacContractId = inputItem.TrsFacContractId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCNum = inputItem.TFCNum,  
  
		TFCDate = inputItem.TFCDate,  
  
		TFCDLRef = inputItem.TFCDLRef,  
  
		TFCAmount = inputItem.TFCAmount,  
  
		TFCMaxAmnt = inputItem.TFCMaxAmnt,  
  
		TFCCreator = inputItem.TFCCreator,  
  
		TFCSit = inputItem.TFCSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFContract Map(TrsFContract entity ,EditTrsFContractCommand inputItem)
        {
              
  
		entity.TrsFacContractId = inputItem.TrsFacContractId;  
  
		entity.TFCType = inputItem.TFCType;  
  
		entity.TFCNum = inputItem.TFCNum;  
  
		entity.TFCDate = inputItem.TFCDate;  
  
		entity.TFCDLRef = inputItem.TFCDLRef;  
  
		entity.TFCAmount = inputItem.TFCAmount;  
  
		entity.TFCMaxAmnt = inputItem.TFCMaxAmnt;  
  
		entity.TFCCreator = inputItem.TFCCreator;  
  
		entity.TFCSit = inputItem.TFCSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFContractDto Map(TrsFContract inputItem)
        {
            var dto = new TrsFContractDto()
            {
                  
  
		TrsFacContractId = inputItem.TrsFacContractId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCNum = inputItem.TFCNum,  
  
		TFCDate = inputItem.TFCDate,  
  
		TFCDLRef = inputItem.TFCDLRef,  
  
		TFCAmount = inputItem.TFCAmount,  
  
		TFCMaxAmnt = inputItem.TFCMaxAmnt,  
  
		TFCCreator = inputItem.TFCCreator,  
  
		TFCSit = inputItem.TFCSit, 
            };
            return dto;
        }

        public static List<TrsFContractDto> Map(ICollection<TrsFContract> entities)
        {
            var dtos = new List<TrsFContractDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFContractDto()
                {
                      
  
		TrsFacContractId = inputItem.TrsFacContractId,  
  
		TFCType = inputItem.TFCType,  
  
		TFCNum = inputItem.TFCNum,  
  
		TFCDate = inputItem.TFCDate,  
  
		TFCDLRef = inputItem.TFCDLRef,  
  
		TFCAmount = inputItem.TFCAmount,  
  
		TFCMaxAmnt = inputItem.TFCMaxAmnt,  
  
		TFCCreator = inputItem.TFCCreator,  
  
		TFCSit = inputItem.TFCSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFContractDet Map(AddTrsFContractDetCommand inputItem)
        {
            var entity = new TrsFContractDet() {
                  
  
		TrsFContractDetId = inputItem.TrsFContractDetId,  
  
		TFCDType = inputItem.TFCDType,  
  
		TFCDItmRef = inputItem.TFCDItmRef,  
  
		TFCDSrcRef = inputItem.TFCDSrcRef,  
  
		TFCDPrc = inputItem.TFCDPrc, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFContractDet Map(TrsFContractDet entity ,EditTrsFContractDetCommand inputItem)
        {
              
  
		entity.TrsFContractDetId = inputItem.TrsFContractDetId;  
  
		entity.TFCDType = inputItem.TFCDType;  
  
		entity.TFCDItmRef = inputItem.TFCDItmRef;  
  
		entity.TFCDSrcRef = inputItem.TFCDSrcRef;  
  
		entity.TFCDPrc = inputItem.TFCDPrc; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFContractDetDto Map(TrsFContractDet inputItem)
        {
            var dto = new TrsFContractDetDto()
            {
                  
  
		TrsFContractDetId = inputItem.TrsFContractDetId,  
  
		TFCDType = inputItem.TFCDType,  
  
		TFCDItmRef = inputItem.TFCDItmRef,  
  
		TFCDSrcRef = inputItem.TFCDSrcRef,  
  
		TFCDPrc = inputItem.TFCDPrc, 
            };
            return dto;
        }

        public static List<TrsFContractDetDto> Map(ICollection<TrsFContractDet> entities)
        {
            var dtos = new List<TrsFContractDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFContractDetDto()
                {
                      
  
		TrsFContractDetId = inputItem.TrsFContractDetId,  
  
		TFCDType = inputItem.TFCDType,  
  
		TFCDItmRef = inputItem.TFCDItmRef,  
  
		TFCDSrcRef = inputItem.TFCDSrcRef,  
  
		TFCDPrc = inputItem.TFCDPrc, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFixAcc Map(AddTrsFixAccCommand inputItem)
        {
            var entity = new TrsFixAcc() {
                  
  
		TrsFixAccId = inputItem.TrsFixAccId,  
  
		TFARcvFacSLRef = inputItem.TFARcvFacSLRef,  
  
		TFARcvFacShareSLRef = inputItem.TFARcvFacShareSLRef,  
  
		TFARcvFacLateSLRef = inputItem.TFARcvFacLateSLRef,  
  
		TFARcvFacInstSLRef = inputItem.TFARcvFacInstSLRef,  
  
		TFAPayFacSLRef = inputItem.TFAPayFacSLRef,  
  
		TFAPayFacShareSLRef = inputItem.TFAPayFacShareSLRef,  
  
		TFAPayFacLateSLRef = inputItem.TFAPayFacLateSLRef,  
  
		TFAPayFacInstSLRef = inputItem.TFAPayFacInstSLRef,  
  
		TFAPayDepSLRef = inputItem.TFAPayDepSLRef,  
  
		TFAPayDepShareSLRef = inputItem.TFAPayDepShareSLRef,  
  
		TFARcvDepSLRef = inputItem.TFARcvDepSLRef,  
  
		TFARcvDepShareSLRef = inputItem.TFARcvDepShareSLRef,  
  
		TFARcvGuarantee = inputItem.TFARcvGuarantee,  
  
		TFARcvGuaDeposit = inputItem.TFARcvGuaDeposit,  
  
		TFARcvGuaCharge = inputItem.TFARcvGuaCharge,  
  
		TFAPayGuarantee = inputItem.TFAPayGuarantee,  
  
		TFAPayGuaDeposit = inputItem.TFAPayGuaDeposit,  
  
		TFAPayGuaCharge = inputItem.TFAPayGuaCharge,  
  
		TFARcvGuaCredit = inputItem.TFARcvGuaCredit,  
  
		TFAPayGuaCredit = inputItem.TFAPayGuaCredit,  
  
		TFARFacCtrlDebit = inputItem.TFARFacCtrlDebit,  
  
		TFAPFacCtrlDebit = inputItem.TFAPFacCtrlDebit,  
  
		TFARFacCtrlCredit = inputItem.TFARFacCtrlCredit,  
  
		TFAPFacCtrlCredit = inputItem.TFAPFacCtrlCredit,  
  
		TFARGuaCtrlDebit = inputItem.TFARGuaCtrlDebit,  
  
		TFAPGuaCtrlDebit = inputItem.TFAPGuaCtrlDebit,  
  
		TFARGuaCtrlCredit = inputItem.TFARGuaCtrlCredit,  
  
		TFAPGuaCtrlCredit = inputItem.TFAPGuaCtrlCredit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFixAcc Map(TrsFixAcc entity ,EditTrsFixAccCommand inputItem)
        {
              
  
		entity.TrsFixAccId = inputItem.TrsFixAccId;  
  
		entity.TFARcvFacSLRef = inputItem.TFARcvFacSLRef;  
  
		entity.TFARcvFacShareSLRef = inputItem.TFARcvFacShareSLRef;  
  
		entity.TFARcvFacLateSLRef = inputItem.TFARcvFacLateSLRef;  
  
		entity.TFARcvFacInstSLRef = inputItem.TFARcvFacInstSLRef;  
  
		entity.TFAPayFacSLRef = inputItem.TFAPayFacSLRef;  
  
		entity.TFAPayFacShareSLRef = inputItem.TFAPayFacShareSLRef;  
  
		entity.TFAPayFacLateSLRef = inputItem.TFAPayFacLateSLRef;  
  
		entity.TFAPayFacInstSLRef = inputItem.TFAPayFacInstSLRef;  
  
		entity.TFAPayDepSLRef = inputItem.TFAPayDepSLRef;  
  
		entity.TFAPayDepShareSLRef = inputItem.TFAPayDepShareSLRef;  
  
		entity.TFARcvDepSLRef = inputItem.TFARcvDepSLRef;  
  
		entity.TFARcvDepShareSLRef = inputItem.TFARcvDepShareSLRef;  
  
		entity.TFARcvGuarantee = inputItem.TFARcvGuarantee;  
  
		entity.TFARcvGuaDeposit = inputItem.TFARcvGuaDeposit;  
  
		entity.TFARcvGuaCharge = inputItem.TFARcvGuaCharge;  
  
		entity.TFAPayGuarantee = inputItem.TFAPayGuarantee;  
  
		entity.TFAPayGuaDeposit = inputItem.TFAPayGuaDeposit;  
  
		entity.TFAPayGuaCharge = inputItem.TFAPayGuaCharge;  
  
		entity.TFARcvGuaCredit = inputItem.TFARcvGuaCredit;  
  
		entity.TFAPayGuaCredit = inputItem.TFAPayGuaCredit;  
  
		entity.TFARFacCtrlDebit = inputItem.TFARFacCtrlDebit;  
  
		entity.TFAPFacCtrlDebit = inputItem.TFAPFacCtrlDebit;  
  
		entity.TFARFacCtrlCredit = inputItem.TFARFacCtrlCredit;  
  
		entity.TFAPFacCtrlCredit = inputItem.TFAPFacCtrlCredit;  
  
		entity.TFARGuaCtrlDebit = inputItem.TFARGuaCtrlDebit;  
  
		entity.TFAPGuaCtrlDebit = inputItem.TFAPGuaCtrlDebit;  
  
		entity.TFARGuaCtrlCredit = inputItem.TFARGuaCtrlCredit;  
  
		entity.TFAPGuaCtrlCredit = inputItem.TFAPGuaCtrlCredit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFixAccDto Map(TrsFixAcc inputItem)
        {
            var dto = new TrsFixAccDto()
            {
                  
  
		TrsFixAccId = inputItem.TrsFixAccId,  
  
		TFARcvFacSLRef = inputItem.TFARcvFacSLRef,  
  
		TFARcvFacShareSLRef = inputItem.TFARcvFacShareSLRef,  
  
		TFARcvFacLateSLRef = inputItem.TFARcvFacLateSLRef,  
  
		TFARcvFacInstSLRef = inputItem.TFARcvFacInstSLRef,  
  
		TFAPayFacSLRef = inputItem.TFAPayFacSLRef,  
  
		TFAPayFacShareSLRef = inputItem.TFAPayFacShareSLRef,  
  
		TFAPayFacLateSLRef = inputItem.TFAPayFacLateSLRef,  
  
		TFAPayFacInstSLRef = inputItem.TFAPayFacInstSLRef,  
  
		TFAPayDepSLRef = inputItem.TFAPayDepSLRef,  
  
		TFAPayDepShareSLRef = inputItem.TFAPayDepShareSLRef,  
  
		TFARcvDepSLRef = inputItem.TFARcvDepSLRef,  
  
		TFARcvDepShareSLRef = inputItem.TFARcvDepShareSLRef,  
  
		TFARcvGuarantee = inputItem.TFARcvGuarantee,  
  
		TFARcvGuaDeposit = inputItem.TFARcvGuaDeposit,  
  
		TFARcvGuaCharge = inputItem.TFARcvGuaCharge,  
  
		TFAPayGuarantee = inputItem.TFAPayGuarantee,  
  
		TFAPayGuaDeposit = inputItem.TFAPayGuaDeposit,  
  
		TFAPayGuaCharge = inputItem.TFAPayGuaCharge,  
  
		TFARcvGuaCredit = inputItem.TFARcvGuaCredit,  
  
		TFAPayGuaCredit = inputItem.TFAPayGuaCredit,  
  
		TFARFacCtrlDebit = inputItem.TFARFacCtrlDebit,  
  
		TFAPFacCtrlDebit = inputItem.TFAPFacCtrlDebit,  
  
		TFARFacCtrlCredit = inputItem.TFARFacCtrlCredit,  
  
		TFAPFacCtrlCredit = inputItem.TFAPFacCtrlCredit,  
  
		TFARGuaCtrlDebit = inputItem.TFARGuaCtrlDebit,  
  
		TFAPGuaCtrlDebit = inputItem.TFAPGuaCtrlDebit,  
  
		TFARGuaCtrlCredit = inputItem.TFARGuaCtrlCredit,  
  
		TFAPGuaCtrlCredit = inputItem.TFAPGuaCtrlCredit, 
            };
            return dto;
        }

        public static List<TrsFixAccDto> Map(ICollection<TrsFixAcc> entities)
        {
            var dtos = new List<TrsFixAccDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFixAccDto()
                {
                      
  
		TrsFixAccId = inputItem.TrsFixAccId,  
  
		TFARcvFacSLRef = inputItem.TFARcvFacSLRef,  
  
		TFARcvFacShareSLRef = inputItem.TFARcvFacShareSLRef,  
  
		TFARcvFacLateSLRef = inputItem.TFARcvFacLateSLRef,  
  
		TFARcvFacInstSLRef = inputItem.TFARcvFacInstSLRef,  
  
		TFAPayFacSLRef = inputItem.TFAPayFacSLRef,  
  
		TFAPayFacShareSLRef = inputItem.TFAPayFacShareSLRef,  
  
		TFAPayFacLateSLRef = inputItem.TFAPayFacLateSLRef,  
  
		TFAPayFacInstSLRef = inputItem.TFAPayFacInstSLRef,  
  
		TFAPayDepSLRef = inputItem.TFAPayDepSLRef,  
  
		TFAPayDepShareSLRef = inputItem.TFAPayDepShareSLRef,  
  
		TFARcvDepSLRef = inputItem.TFARcvDepSLRef,  
  
		TFARcvDepShareSLRef = inputItem.TFARcvDepShareSLRef,  
  
		TFARcvGuarantee = inputItem.TFARcvGuarantee,  
  
		TFARcvGuaDeposit = inputItem.TFARcvGuaDeposit,  
  
		TFARcvGuaCharge = inputItem.TFARcvGuaCharge,  
  
		TFAPayGuarantee = inputItem.TFAPayGuarantee,  
  
		TFAPayGuaDeposit = inputItem.TFAPayGuaDeposit,  
  
		TFAPayGuaCharge = inputItem.TFAPayGuaCharge,  
  
		TFARcvGuaCredit = inputItem.TFARcvGuaCredit,  
  
		TFAPayGuaCredit = inputItem.TFAPayGuaCredit,  
  
		TFARFacCtrlDebit = inputItem.TFARFacCtrlDebit,  
  
		TFAPFacCtrlDebit = inputItem.TFAPFacCtrlDebit,  
  
		TFARFacCtrlCredit = inputItem.TFARFacCtrlCredit,  
  
		TFAPFacCtrlCredit = inputItem.TFAPFacCtrlCredit,  
  
		TFARGuaCtrlDebit = inputItem.TFARGuaCtrlDebit,  
  
		TFAPGuaCtrlDebit = inputItem.TFAPGuaCtrlDebit,  
  
		TFARGuaCtrlCredit = inputItem.TFARGuaCtrlCredit,  
  
		TFAPGuaCtrlCredit = inputItem.TFAPGuaCtrlCredit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFixAccDet Map(AddTrsFixAccDetCommand inputItem)
        {
            var entity = new TrsFixAccDet() {
                  
  
		TFADType = inputItem.TFADType,  
  
		TFADRole = inputItem.TFADRole,  
  
		TFADSLRef = inputItem.TFADSLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFixAccDet Map(TrsFixAccDet entity ,EditTrsFixAccDetCommand inputItem)
        {
              
  
		entity.TFADType = inputItem.TFADType;  
  
		entity.TFADRole = inputItem.TFADRole;  
  
		entity.TFADSLRef = inputItem.TFADSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFixAccDetDto Map(TrsFixAccDet inputItem)
        {
            var dto = new TrsFixAccDetDto()
            {
                  
  
		TFADType = inputItem.TFADType,  
  
		TFADRole = inputItem.TFADRole,  
  
		TFADSLRef = inputItem.TFADSLRef, 
            };
            return dto;
        }

        public static List<TrsFixAccDetDto> Map(ICollection<TrsFixAccDet> entities)
        {
            var dtos = new List<TrsFixAccDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFixAccDetDto()
                {
                      
  
		TFADType = inputItem.TFADType,  
  
		TFADRole = inputItem.TFADRole,  
  
		TFADSLRef = inputItem.TFADSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFundBillHdr Map(AddTrsFundBillHdrCommand inputItem)
        {
            var entity = new TrsFundBillHdr() {
                  
  
		TrsFundBillHdrId = inputItem.TrsFundBillHdrId,  
  
		TFBHFundRef = inputItem.TFBHFundRef,  
  
		TFBHNum = inputItem.TFBHNum,  
  
		TFBHLocalNum = inputItem.TFBHLocalNum,  
  
		TFBHDate = inputItem.TFBHDate,  
  
		TFBHDescr = inputItem.TFBHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFBHState = inputItem.TFBHState,  
  
		TBAccPrdRef = inputItem.TBAccPrdRef,  
  
		TFBTrans = inputItem.TFBTrans,  
  
		TFBHCreator = inputItem.TFBHCreator,  
  
		TFBHSit = inputItem.TFBHSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFundBillHdr Map(TrsFundBillHdr entity ,EditTrsFundBillHdrCommand inputItem)
        {
              
  
		entity.TrsFundBillHdrId = inputItem.TrsFundBillHdrId;  
  
		entity.TFBHFundRef = inputItem.TFBHFundRef;  
  
		entity.TFBHNum = inputItem.TFBHNum;  
  
		entity.TFBHLocalNum = inputItem.TFBHLocalNum;  
  
		entity.TFBHDate = inputItem.TFBHDate;  
  
		entity.TFBHDescr = inputItem.TFBHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TFBHState = inputItem.TFBHState;  
  
		entity.TBAccPrdRef = inputItem.TBAccPrdRef;  
  
		entity.TFBTrans = inputItem.TFBTrans;  
  
		entity.TFBHCreator = inputItem.TFBHCreator;  
  
		entity.TFBHSit = inputItem.TFBHSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFundBillHdrDto Map(TrsFundBillHdr inputItem)
        {
            var dto = new TrsFundBillHdrDto()
            {
                  
  
		TrsFundBillHdrId = inputItem.TrsFundBillHdrId,  
  
		TFBHFundRef = inputItem.TFBHFundRef,  
  
		TFBHNum = inputItem.TFBHNum,  
  
		TFBHLocalNum = inputItem.TFBHLocalNum,  
  
		TFBHDate = inputItem.TFBHDate,  
  
		TFBHDescr = inputItem.TFBHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFBHState = inputItem.TFBHState,  
  
		TBAccPrdRef = inputItem.TBAccPrdRef,  
  
		TFBTrans = inputItem.TFBTrans,  
  
		TFBHCreator = inputItem.TFBHCreator,  
  
		TFBHSit = inputItem.TFBHSit, 
            };
            return dto;
        }

        public static List<TrsFundBillHdrDto> Map(ICollection<TrsFundBillHdr> entities)
        {
            var dtos = new List<TrsFundBillHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFundBillHdrDto()
                {
                      
  
		TrsFundBillHdrId = inputItem.TrsFundBillHdrId,  
  
		TFBHFundRef = inputItem.TFBHFundRef,  
  
		TFBHNum = inputItem.TFBHNum,  
  
		TFBHLocalNum = inputItem.TFBHLocalNum,  
  
		TFBHDate = inputItem.TFBHDate,  
  
		TFBHDescr = inputItem.TFBHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFBHState = inputItem.TFBHState,  
  
		TBAccPrdRef = inputItem.TBAccPrdRef,  
  
		TFBTrans = inputItem.TFBTrans,  
  
		TFBHCreator = inputItem.TFBHCreator,  
  
		TFBHSit = inputItem.TFBHSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFundBillItm Map(AddTrsFundBillItmCommand inputItem)
        {
            var entity = new TrsFundBillItm() {
                  
  
		TrsFundBillItmId = inputItem.TrsFundBillItmId,  
  
		TrsFundBillHdrRef = inputItem.TrsFundBillHdrRef,  
  
		TFBISeq = inputItem.TFBISeq,  
  
		TFBICostFactorRef = inputItem.TFBICostFactorRef,  
  
		TFBIRqstNo = inputItem.TFBIRqstNo,  
  
		TFBIRqstDate = inputItem.TFBIRqstDate,  
  
		TFBIFactNum = inputItem.TFBIFactNum,  
  
		TFBIFactDate = inputItem.TFBIFactDate,  
  
		TFBIDescr = inputItem.TFBIDescr,  
  
		TFBIFactAmnt = inputItem.TFBIFactAmnt,  
  
		TFBIDLRef = inputItem.TFBIDLRef,  
  
		TFBIDLFive = inputItem.TFBIDLFive,  
  
		TFBIDLSix = inputItem.TFBIDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFundBillItm Map(TrsFundBillItm entity ,EditTrsFundBillItmCommand inputItem)
        {
              
  
		entity.TrsFundBillItmId = inputItem.TrsFundBillItmId;  
  
		entity.TrsFundBillHdrRef = inputItem.TrsFundBillHdrRef;  
  
		entity.TFBISeq = inputItem.TFBISeq;  
  
		entity.TFBICostFactorRef = inputItem.TFBICostFactorRef;  
  
		entity.TFBIRqstNo = inputItem.TFBIRqstNo;  
  
		entity.TFBIRqstDate = inputItem.TFBIRqstDate;  
  
		entity.TFBIFactNum = inputItem.TFBIFactNum;  
  
		entity.TFBIFactDate = inputItem.TFBIFactDate;  
  
		entity.TFBIDescr = inputItem.TFBIDescr;  
  
		entity.TFBIFactAmnt = inputItem.TFBIFactAmnt;  
  
		entity.TFBIDLRef = inputItem.TFBIDLRef;  
  
		entity.TFBIDLFive = inputItem.TFBIDLFive;  
  
		entity.TFBIDLSix = inputItem.TFBIDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFundBillItmDto Map(TrsFundBillItm inputItem)
        {
            var dto = new TrsFundBillItmDto()
            {
                  
  
		TrsFundBillItmId = inputItem.TrsFundBillItmId,  
  
		TrsFundBillHdrRef = inputItem.TrsFundBillHdrRef,  
  
		TFBISeq = inputItem.TFBISeq,  
  
		TFBICostFactorRef = inputItem.TFBICostFactorRef,  
  
		TFBIRqstNo = inputItem.TFBIRqstNo,  
  
		TFBIRqstDate = inputItem.TFBIRqstDate,  
  
		TFBIFactNum = inputItem.TFBIFactNum,  
  
		TFBIFactDate = inputItem.TFBIFactDate,  
  
		TFBIDescr = inputItem.TFBIDescr,  
  
		TFBIFactAmnt = inputItem.TFBIFactAmnt,  
  
		TFBIDLRef = inputItem.TFBIDLRef,  
  
		TFBIDLFive = inputItem.TFBIDLFive,  
  
		TFBIDLSix = inputItem.TFBIDLSix, 
            };
            return dto;
        }

        public static List<TrsFundBillItmDto> Map(ICollection<TrsFundBillItm> entities)
        {
            var dtos = new List<TrsFundBillItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFundBillItmDto()
                {
                      
  
		TrsFundBillItmId = inputItem.TrsFundBillItmId,  
  
		TrsFundBillHdrRef = inputItem.TrsFundBillHdrRef,  
  
		TFBISeq = inputItem.TFBISeq,  
  
		TFBICostFactorRef = inputItem.TFBICostFactorRef,  
  
		TFBIRqstNo = inputItem.TFBIRqstNo,  
  
		TFBIRqstDate = inputItem.TFBIRqstDate,  
  
		TFBIFactNum = inputItem.TFBIFactNum,  
  
		TFBIFactDate = inputItem.TFBIFactDate,  
  
		TFBIDescr = inputItem.TFBIDescr,  
  
		TFBIFactAmnt = inputItem.TFBIFactAmnt,  
  
		TFBIDLRef = inputItem.TFBIDLRef,  
  
		TFBIDLFive = inputItem.TFBIDLFive,  
  
		TFBIDLSix = inputItem.TFBIDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFundItmDet Map(AddTrsFundItmDetCommand inputItem)
        {
            var entity = new TrsFundItmDet() {
                  
  
		TrsFundItmDetId = inputItem.TrsFundItmDetId,  
  
		TFIDItemRef = inputItem.TFIDItemRef,  
  
		TFIDTaxAmnt = inputItem.TFIDTaxAmnt,  
  
		TFIDDutyAmnt = inputItem.TFIDDutyAmnt,  
  
		TFIDOthAmnt = inputItem.TFIDOthAmnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFundItmDet Map(TrsFundItmDet entity ,EditTrsFundItmDetCommand inputItem)
        {
              
  
		entity.TrsFundItmDetId = inputItem.TrsFundItmDetId;  
  
		entity.TFIDItemRef = inputItem.TFIDItemRef;  
  
		entity.TFIDTaxAmnt = inputItem.TFIDTaxAmnt;  
  
		entity.TFIDDutyAmnt = inputItem.TFIDDutyAmnt;  
  
		entity.TFIDOthAmnt = inputItem.TFIDOthAmnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFundItmDetDto Map(TrsFundItmDet inputItem)
        {
            var dto = new TrsFundItmDetDto()
            {
                  
  
		TrsFundItmDetId = inputItem.TrsFundItmDetId,  
  
		TFIDItemRef = inputItem.TFIDItemRef,  
  
		TFIDTaxAmnt = inputItem.TFIDTaxAmnt,  
  
		TFIDDutyAmnt = inputItem.TFIDDutyAmnt,  
  
		TFIDOthAmnt = inputItem.TFIDOthAmnt, 
            };
            return dto;
        }

        public static List<TrsFundItmDetDto> Map(ICollection<TrsFundItmDet> entities)
        {
            var dtos = new List<TrsFundItmDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFundItmDetDto()
                {
                      
  
		TrsFundItmDetId = inputItem.TrsFundItmDetId,  
  
		TFIDItemRef = inputItem.TFIDItemRef,  
  
		TFIDTaxAmnt = inputItem.TFIDTaxAmnt,  
  
		TFIDDutyAmnt = inputItem.TFIDDutyAmnt,  
  
		TFIDOthAmnt = inputItem.TFIDOthAmnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFundOpr Map(AddTrsFundOprCommand inputItem)
        {
            var entity = new TrsFundOpr() {
                  
  
		TrsFundOprId = inputItem.TrsFundOprId,  
  
		TFONum = inputItem.TFONum,  
  
		TFODate = inputItem.TFODate,  
  
		TFOFundRef = inputItem.TFOFundRef,  
  
		TFODescr = inputItem.TFODescr,  
  
		TFOType = inputItem.TFOType,  
  
		TFOOpsId = inputItem.TFOOpsId,  
  
		TFOAmount = inputItem.TFOAmount,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFOState = inputItem.TFOState,  
  
		TFOAccPrdRef = inputItem.TFOAccPrdRef,  
  
		TFOTrsVchRef = inputItem.TFOTrsVchRef,  
  
		TFOFundBillRef = inputItem.TFOFundBillRef,  
  
		TFOCreator = inputItem.TFOCreator,  
  
		TFOSit = inputItem.TFOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFundOpr Map(TrsFundOpr entity ,EditTrsFundOprCommand inputItem)
        {
              
  
		entity.TrsFundOprId = inputItem.TrsFundOprId;  
  
		entity.TFONum = inputItem.TFONum;  
  
		entity.TFODate = inputItem.TFODate;  
  
		entity.TFOFundRef = inputItem.TFOFundRef;  
  
		entity.TFODescr = inputItem.TFODescr;  
  
		entity.TFOType = inputItem.TFOType;  
  
		entity.TFOOpsId = inputItem.TFOOpsId;  
  
		entity.TFOAmount = inputItem.TFOAmount;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TFOState = inputItem.TFOState;  
  
		entity.TFOAccPrdRef = inputItem.TFOAccPrdRef;  
  
		entity.TFOTrsVchRef = inputItem.TFOTrsVchRef;  
  
		entity.TFOFundBillRef = inputItem.TFOFundBillRef;  
  
		entity.TFOCreator = inputItem.TFOCreator;  
  
		entity.TFOSit = inputItem.TFOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFundOprDto Map(TrsFundOpr inputItem)
        {
            var dto = new TrsFundOprDto()
            {
                  
  
		TrsFundOprId = inputItem.TrsFundOprId,  
  
		TFONum = inputItem.TFONum,  
  
		TFODate = inputItem.TFODate,  
  
		TFOFundRef = inputItem.TFOFundRef,  
  
		TFODescr = inputItem.TFODescr,  
  
		TFOType = inputItem.TFOType,  
  
		TFOOpsId = inputItem.TFOOpsId,  
  
		TFOAmount = inputItem.TFOAmount,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFOState = inputItem.TFOState,  
  
		TFOAccPrdRef = inputItem.TFOAccPrdRef,  
  
		TFOTrsVchRef = inputItem.TFOTrsVchRef,  
  
		TFOFundBillRef = inputItem.TFOFundBillRef,  
  
		TFOCreator = inputItem.TFOCreator,  
  
		TFOSit = inputItem.TFOSit, 
            };
            return dto;
        }

        public static List<TrsFundOprDto> Map(ICollection<TrsFundOpr> entities)
        {
            var dtos = new List<TrsFundOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFundOprDto()
                {
                      
  
		TrsFundOprId = inputItem.TrsFundOprId,  
  
		TFONum = inputItem.TFONum,  
  
		TFODate = inputItem.TFODate,  
  
		TFOFundRef = inputItem.TFOFundRef,  
  
		TFODescr = inputItem.TFODescr,  
  
		TFOType = inputItem.TFOType,  
  
		TFOOpsId = inputItem.TFOOpsId,  
  
		TFOAmount = inputItem.TFOAmount,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TFOState = inputItem.TFOState,  
  
		TFOAccPrdRef = inputItem.TFOAccPrdRef,  
  
		TFOTrsVchRef = inputItem.TFOTrsVchRef,  
  
		TFOFundBillRef = inputItem.TFOFundBillRef,  
  
		TFOCreator = inputItem.TFOCreator,  
  
		TFOSit = inputItem.TFOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsFunds Map(AddTrsFundsCommand inputItem)
        {
            var entity = new TrsFunds() {
                  
  
		TrsFundId = inputItem.TrsFundId,  
  
		TFTitle = inputItem.TFTitle,  
  
		TFCrsRef = inputItem.TFCrsRef,  
  
		TFOpenDate = inputItem.TFOpenDate,  
  
		TFBeginAmnt = inputItem.TFBeginAmnt,  
  
		TFMaxAmnt = inputItem.TFMaxAmnt,  
  
		TFSLRef = inputItem.TFSLRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsFunds Map(TrsFunds entity ,EditTrsFundsCommand inputItem)
        {
              
  
		entity.TrsFundId = inputItem.TrsFundId;  
  
		entity.TFTitle = inputItem.TFTitle;  
  
		entity.TFCrsRef = inputItem.TFCrsRef;  
  
		entity.TFOpenDate = inputItem.TFOpenDate;  
  
		entity.TFBeginAmnt = inputItem.TFBeginAmnt;  
  
		entity.TFMaxAmnt = inputItem.TFMaxAmnt;  
  
		entity.TFSLRef = inputItem.TFSLRef;  
  
		entity.TFDLRef = inputItem.TFDLRef;  
  
		entity.TFDLFive = inputItem.TFDLFive;  
  
		entity.TFDLSix = inputItem.TFDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsFundsDto Map(TrsFunds inputItem)
        {
            var dto = new TrsFundsDto()
            {
                  
  
		TrsFundId = inputItem.TrsFundId,  
  
		TFTitle = inputItem.TFTitle,  
  
		TFCrsRef = inputItem.TFCrsRef,  
  
		TFOpenDate = inputItem.TFOpenDate,  
  
		TFBeginAmnt = inputItem.TFBeginAmnt,  
  
		TFMaxAmnt = inputItem.TFMaxAmnt,  
  
		TFSLRef = inputItem.TFSLRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix, 
            };
            return dto;
        }

        public static List<TrsFundsDto> Map(ICollection<TrsFunds> entities)
        {
            var dtos = new List<TrsFundsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsFundsDto()
                {
                      
  
		TrsFundId = inputItem.TrsFundId,  
  
		TFTitle = inputItem.TFTitle,  
  
		TFCrsRef = inputItem.TFCrsRef,  
  
		TFOpenDate = inputItem.TFOpenDate,  
  
		TFBeginAmnt = inputItem.TFBeginAmnt,  
  
		TFMaxAmnt = inputItem.TFMaxAmnt,  
  
		TFSLRef = inputItem.TFSLRef,  
  
		TFDLRef = inputItem.TFDLRef,  
  
		TFDLFive = inputItem.TFDLFive,  
  
		TFDLSix = inputItem.TFDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGContract Map(AddTrsGContractCommand inputItem)
        {
            var entity = new TrsGContract() {
                  
  
		TrsGuaContractId = inputItem.TrsGuaContractId,  
  
		TGCType = inputItem.TGCType,  
  
		TGCKind = inputItem.TGCKind,  
  
		TGCNum = inputItem.TGCNum,  
  
		TGCDescr = inputItem.TGCDescr,  
  
		TGCDate = inputItem.TGCDate,  
  
		TGCAmount = inputItem.TGCAmount,  
  
		TGCSLRef = inputItem.TGCSLRef,  
  
		TGCCreator = inputItem.TGCCreator,  
  
		TGCSit = inputItem.TGCSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGContract Map(TrsGContract entity ,EditTrsGContractCommand inputItem)
        {
              
  
		entity.TrsGuaContractId = inputItem.TrsGuaContractId;  
  
		entity.TGCType = inputItem.TGCType;  
  
		entity.TGCKind = inputItem.TGCKind;  
  
		entity.TGCNum = inputItem.TGCNum;  
  
		entity.TGCDescr = inputItem.TGCDescr;  
  
		entity.TGCDate = inputItem.TGCDate;  
  
		entity.TGCAmount = inputItem.TGCAmount;  
  
		entity.TGCSLRef = inputItem.TGCSLRef;  
  
		entity.TGCCreator = inputItem.TGCCreator;  
  
		entity.TGCSit = inputItem.TGCSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGContractDto Map(TrsGContract inputItem)
        {
            var dto = new TrsGContractDto()
            {
                  
  
		TrsGuaContractId = inputItem.TrsGuaContractId,  
  
		TGCType = inputItem.TGCType,  
  
		TGCKind = inputItem.TGCKind,  
  
		TGCNum = inputItem.TGCNum,  
  
		TGCDescr = inputItem.TGCDescr,  
  
		TGCDate = inputItem.TGCDate,  
  
		TGCAmount = inputItem.TGCAmount,  
  
		TGCSLRef = inputItem.TGCSLRef,  
  
		TGCCreator = inputItem.TGCCreator,  
  
		TGCSit = inputItem.TGCSit, 
            };
            return dto;
        }

        public static List<TrsGContractDto> Map(ICollection<TrsGContract> entities)
        {
            var dtos = new List<TrsGContractDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGContractDto()
                {
                      
  
		TrsGuaContractId = inputItem.TrsGuaContractId,  
  
		TGCType = inputItem.TGCType,  
  
		TGCKind = inputItem.TGCKind,  
  
		TGCNum = inputItem.TGCNum,  
  
		TGCDescr = inputItem.TGCDescr,  
  
		TGCDate = inputItem.TGCDate,  
  
		TGCAmount = inputItem.TGCAmount,  
  
		TGCSLRef = inputItem.TGCSLRef,  
  
		TGCCreator = inputItem.TGCCreator,  
  
		TGCSit = inputItem.TGCSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGContractChng Map(AddTrsGContractChngCommand inputItem)
        {
            var entity = new TrsGContractChng() {
                  
  
		TrsGuaContractChngId = inputItem.TrsGuaContractChngId,  
  
		TrsGuaContractRef = inputItem.TrsGuaContractRef,  
  
		TGCCDate = inputItem.TGCCDate,  
  
		TGCCDescr = inputItem.TGCCDescr,  
  
		TGCCAmount = inputItem.TGCCAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGContractChng Map(TrsGContractChng entity ,EditTrsGContractChngCommand inputItem)
        {
              
  
		entity.TrsGuaContractChngId = inputItem.TrsGuaContractChngId;  
  
		entity.TrsGuaContractRef = inputItem.TrsGuaContractRef;  
  
		entity.TGCCDate = inputItem.TGCCDate;  
  
		entity.TGCCDescr = inputItem.TGCCDescr;  
  
		entity.TGCCAmount = inputItem.TGCCAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGContractChngDto Map(TrsGContractChng inputItem)
        {
            var dto = new TrsGContractChngDto()
            {
                  
  
		TrsGuaContractChngId = inputItem.TrsGuaContractChngId,  
  
		TrsGuaContractRef = inputItem.TrsGuaContractRef,  
  
		TGCCDate = inputItem.TGCCDate,  
  
		TGCCDescr = inputItem.TGCCDescr,  
  
		TGCCAmount = inputItem.TGCCAmount, 
            };
            return dto;
        }

        public static List<TrsGContractChngDto> Map(ICollection<TrsGContractChng> entities)
        {
            var dtos = new List<TrsGContractChngDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGContractChngDto()
                {
                      
  
		TrsGuaContractChngId = inputItem.TrsGuaContractChngId,  
  
		TrsGuaContractRef = inputItem.TrsGuaContractRef,  
  
		TGCCDate = inputItem.TGCCDate,  
  
		TGCCDescr = inputItem.TGCCDescr,  
  
		TGCCAmount = inputItem.TGCCAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGuarantee Map(AddTrsGuaranteeCommand inputItem)
        {
            var entity = new TrsGuarantee() {
                  
  
		TrsGuaranteeId = inputItem.TrsGuaranteeId,  
  
		TGContRef = inputItem.TGContRef,  
  
		TGKind = inputItem.TGKind,  
  
		TGNum = inputItem.TGNum,  
  
		TGIssuDate = inputItem.TGIssuDate,  
  
		TGEffDate = inputItem.TGEffDate,  
  
		TGAmount = inputItem.TGAmount,  
  
		TGDeposit = inputItem.TGDeposit,  
  
		TGCharge = inputItem.TGCharge,  
  
		TGBankAccRef = inputItem.TGBankAccRef,  
  
		TGDescr = inputItem.TGDescr,  
  
		TGDLRef = inputItem.TGDLRef,  
  
		TGState = inputItem.TGState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TGChargeTax = inputItem.TGChargeTax,  
  
		TGChargeDuty = inputItem.TGChargeDuty,  
  
		TGSerNo = inputItem.TGSerNo,  
  
		TGSepNo = inputItem.TGSepNo,  
  
		TGBenefy = inputItem.TGBenefy,  
  
		TGDepRate = inputItem.TGDepRate,  
  
		TGChargeRate = inputItem.TGChargeRate,  
  
		TGCreator = inputItem.TGCreator,  
  
		TGSit = inputItem.TGSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGuarantee Map(TrsGuarantee entity ,EditTrsGuaranteeCommand inputItem)
        {
              
  
		entity.TrsGuaranteeId = inputItem.TrsGuaranteeId;  
  
		entity.TGContRef = inputItem.TGContRef;  
  
		entity.TGKind = inputItem.TGKind;  
  
		entity.TGNum = inputItem.TGNum;  
  
		entity.TGIssuDate = inputItem.TGIssuDate;  
  
		entity.TGEffDate = inputItem.TGEffDate;  
  
		entity.TGAmount = inputItem.TGAmount;  
  
		entity.TGDeposit = inputItem.TGDeposit;  
  
		entity.TGCharge = inputItem.TGCharge;  
  
		entity.TGBankAccRef = inputItem.TGBankAccRef;  
  
		entity.TGDescr = inputItem.TGDescr;  
  
		entity.TGDLRef = inputItem.TGDLRef;  
  
		entity.TGState = inputItem.TGState;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TGChargeTax = inputItem.TGChargeTax;  
  
		entity.TGChargeDuty = inputItem.TGChargeDuty;  
  
		entity.TGSerNo = inputItem.TGSerNo;  
  
		entity.TGSepNo = inputItem.TGSepNo;  
  
		entity.TGBenefy = inputItem.TGBenefy;  
  
		entity.TGDepRate = inputItem.TGDepRate;  
  
		entity.TGChargeRate = inputItem.TGChargeRate;  
  
		entity.TGCreator = inputItem.TGCreator;  
  
		entity.TGSit = inputItem.TGSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGuaranteeDto Map(TrsGuarantee inputItem)
        {
            var dto = new TrsGuaranteeDto()
            {
                  
  
		TrsGuaranteeId = inputItem.TrsGuaranteeId,  
  
		TGContRef = inputItem.TGContRef,  
  
		TGKind = inputItem.TGKind,  
  
		TGNum = inputItem.TGNum,  
  
		TGIssuDate = inputItem.TGIssuDate,  
  
		TGEffDate = inputItem.TGEffDate,  
  
		TGAmount = inputItem.TGAmount,  
  
		TGDeposit = inputItem.TGDeposit,  
  
		TGCharge = inputItem.TGCharge,  
  
		TGBankAccRef = inputItem.TGBankAccRef,  
  
		TGDescr = inputItem.TGDescr,  
  
		TGDLRef = inputItem.TGDLRef,  
  
		TGState = inputItem.TGState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TGChargeTax = inputItem.TGChargeTax,  
  
		TGChargeDuty = inputItem.TGChargeDuty,  
  
		TGSerNo = inputItem.TGSerNo,  
  
		TGSepNo = inputItem.TGSepNo,  
  
		TGBenefy = inputItem.TGBenefy,  
  
		TGDepRate = inputItem.TGDepRate,  
  
		TGChargeRate = inputItem.TGChargeRate,  
  
		TGCreator = inputItem.TGCreator,  
  
		TGSit = inputItem.TGSit, 
            };
            return dto;
        }

        public static List<TrsGuaranteeDto> Map(ICollection<TrsGuarantee> entities)
        {
            var dtos = new List<TrsGuaranteeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGuaranteeDto()
                {
                      
  
		TrsGuaranteeId = inputItem.TrsGuaranteeId,  
  
		TGContRef = inputItem.TGContRef,  
  
		TGKind = inputItem.TGKind,  
  
		TGNum = inputItem.TGNum,  
  
		TGIssuDate = inputItem.TGIssuDate,  
  
		TGEffDate = inputItem.TGEffDate,  
  
		TGAmount = inputItem.TGAmount,  
  
		TGDeposit = inputItem.TGDeposit,  
  
		TGCharge = inputItem.TGCharge,  
  
		TGBankAccRef = inputItem.TGBankAccRef,  
  
		TGDescr = inputItem.TGDescr,  
  
		TGDLRef = inputItem.TGDLRef,  
  
		TGState = inputItem.TGState,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TGChargeTax = inputItem.TGChargeTax,  
  
		TGChargeDuty = inputItem.TGChargeDuty,  
  
		TGSerNo = inputItem.TGSerNo,  
  
		TGSepNo = inputItem.TGSepNo,  
  
		TGBenefy = inputItem.TGBenefy,  
  
		TGDepRate = inputItem.TGDepRate,  
  
		TGChargeRate = inputItem.TGChargeRate,  
  
		TGCreator = inputItem.TGCreator,  
  
		TGSit = inputItem.TGSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGuaranteeGua Map(AddTrsGuaranteeGuaCommand inputItem)
        {
            var entity = new TrsGuaranteeGua() {
                  
  
		TrsGuaranteeGuaId = inputItem.TrsGuaranteeGuaId,  
  
		TGGGuaRef = inputItem.TGGGuaRef,  
  
		TGGRcvDocId = inputItem.TGGRcvDocId,  
  
		TGGDescr = inputItem.TGGDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGuaranteeGua Map(TrsGuaranteeGua entity ,EditTrsGuaranteeGuaCommand inputItem)
        {
              
  
		entity.TrsGuaranteeGuaId = inputItem.TrsGuaranteeGuaId;  
  
		entity.TGGGuaRef = inputItem.TGGGuaRef;  
  
		entity.TGGRcvDocId = inputItem.TGGRcvDocId;  
  
		entity.TGGDescr = inputItem.TGGDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGuaranteeGuaDto Map(TrsGuaranteeGua inputItem)
        {
            var dto = new TrsGuaranteeGuaDto()
            {
                  
  
		TrsGuaranteeGuaId = inputItem.TrsGuaranteeGuaId,  
  
		TGGGuaRef = inputItem.TGGGuaRef,  
  
		TGGRcvDocId = inputItem.TGGRcvDocId,  
  
		TGGDescr = inputItem.TGGDescr, 
            };
            return dto;
        }

        public static List<TrsGuaranteeGuaDto> Map(ICollection<TrsGuaranteeGua> entities)
        {
            var dtos = new List<TrsGuaranteeGuaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGuaranteeGuaDto()
                {
                      
  
		TrsGuaranteeGuaId = inputItem.TrsGuaranteeGuaId,  
  
		TGGGuaRef = inputItem.TGGGuaRef,  
  
		TGGRcvDocId = inputItem.TGGRcvDocId,  
  
		TGGDescr = inputItem.TGGDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGuaranteeOpr Map(AddTrsGuaranteeOprCommand inputItem)
        {
            var entity = new TrsGuaranteeOpr() {
                  
  
		TrsGuaranteeOprId = inputItem.TrsGuaranteeOprId,  
  
		TGOItemRef = inputItem.TGOItemRef,  
  
		TGOOprDate = inputItem.TGOOprDate,  
  
		TGOType = inputItem.TGOType,  
  
		TGOAmount = inputItem.TGOAmount,  
  
		TGODate = inputItem.TGODate,  
  
		TGOTaxAmnt = inputItem.TGOTaxAmnt,  
  
		TGODutyAmnt = inputItem.TGODutyAmnt,  
  
		TGOCreator = inputItem.TGOCreator,  
  
		TGOSit = inputItem.TGOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGuaranteeOpr Map(TrsGuaranteeOpr entity ,EditTrsGuaranteeOprCommand inputItem)
        {
              
  
		entity.TrsGuaranteeOprId = inputItem.TrsGuaranteeOprId;  
  
		entity.TGOItemRef = inputItem.TGOItemRef;  
  
		entity.TGOOprDate = inputItem.TGOOprDate;  
  
		entity.TGOType = inputItem.TGOType;  
  
		entity.TGOAmount = inputItem.TGOAmount;  
  
		entity.TGODate = inputItem.TGODate;  
  
		entity.TGOTaxAmnt = inputItem.TGOTaxAmnt;  
  
		entity.TGODutyAmnt = inputItem.TGODutyAmnt;  
  
		entity.TGOCreator = inputItem.TGOCreator;  
  
		entity.TGOSit = inputItem.TGOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGuaranteeOprDto Map(TrsGuaranteeOpr inputItem)
        {
            var dto = new TrsGuaranteeOprDto()
            {
                  
  
		TrsGuaranteeOprId = inputItem.TrsGuaranteeOprId,  
  
		TGOItemRef = inputItem.TGOItemRef,  
  
		TGOOprDate = inputItem.TGOOprDate,  
  
		TGOType = inputItem.TGOType,  
  
		TGOAmount = inputItem.TGOAmount,  
  
		TGODate = inputItem.TGODate,  
  
		TGOTaxAmnt = inputItem.TGOTaxAmnt,  
  
		TGODutyAmnt = inputItem.TGODutyAmnt,  
  
		TGOCreator = inputItem.TGOCreator,  
  
		TGOSit = inputItem.TGOSit, 
            };
            return dto;
        }

        public static List<TrsGuaranteeOprDto> Map(ICollection<TrsGuaranteeOpr> entities)
        {
            var dtos = new List<TrsGuaranteeOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGuaranteeOprDto()
                {
                      
  
		TrsGuaranteeOprId = inputItem.TrsGuaranteeOprId,  
  
		TGOItemRef = inputItem.TGOItemRef,  
  
		TGOOprDate = inputItem.TGOOprDate,  
  
		TGOType = inputItem.TGOType,  
  
		TGOAmount = inputItem.TGOAmount,  
  
		TGODate = inputItem.TGODate,  
  
		TGOTaxAmnt = inputItem.TGOTaxAmnt,  
  
		TGODutyAmnt = inputItem.TGODutyAmnt,  
  
		TGOCreator = inputItem.TGOCreator,  
  
		TGOSit = inputItem.TGOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGuaranteeSec Map(AddTrsGuaranteeSecCommand inputItem)
        {
            var entity = new TrsGuaranteeSec() {
                  
  
		TrsGuaranteeSecId = inputItem.TrsGuaranteeSecId,  
  
		TGSGuaRef = inputItem.TGSGuaRef,  
  
		TGSDLRef = inputItem.TGSDLRef,  
  
		TGSFullName = inputItem.TGSFullName,  
  
		TGSNatCode = inputItem.TGSNatCode,  
  
		TGSPhone = inputItem.TGSPhone,  
  
		TGSMobile = inputItem.TGSMobile,  
  
		TGSDescr = inputItem.TGSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGuaranteeSec Map(TrsGuaranteeSec entity ,EditTrsGuaranteeSecCommand inputItem)
        {
              
  
		entity.TrsGuaranteeSecId = inputItem.TrsGuaranteeSecId;  
  
		entity.TGSGuaRef = inputItem.TGSGuaRef;  
  
		entity.TGSDLRef = inputItem.TGSDLRef;  
  
		entity.TGSFullName = inputItem.TGSFullName;  
  
		entity.TGSNatCode = inputItem.TGSNatCode;  
  
		entity.TGSPhone = inputItem.TGSPhone;  
  
		entity.TGSMobile = inputItem.TGSMobile;  
  
		entity.TGSDescr = inputItem.TGSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGuaranteeSecDto Map(TrsGuaranteeSec inputItem)
        {
            var dto = new TrsGuaranteeSecDto()
            {
                  
  
		TrsGuaranteeSecId = inputItem.TrsGuaranteeSecId,  
  
		TGSGuaRef = inputItem.TGSGuaRef,  
  
		TGSDLRef = inputItem.TGSDLRef,  
  
		TGSFullName = inputItem.TGSFullName,  
  
		TGSNatCode = inputItem.TGSNatCode,  
  
		TGSPhone = inputItem.TGSPhone,  
  
		TGSMobile = inputItem.TGSMobile,  
  
		TGSDescr = inputItem.TGSDescr, 
            };
            return dto;
        }

        public static List<TrsGuaranteeSecDto> Map(ICollection<TrsGuaranteeSec> entities)
        {
            var dtos = new List<TrsGuaranteeSecDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGuaranteeSecDto()
                {
                      
  
		TrsGuaranteeSecId = inputItem.TrsGuaranteeSecId,  
  
		TGSGuaRef = inputItem.TGSGuaRef,  
  
		TGSDLRef = inputItem.TGSDLRef,  
  
		TGSFullName = inputItem.TGSFullName,  
  
		TGSNatCode = inputItem.TGSNatCode,  
  
		TGSPhone = inputItem.TGSPhone,  
  
		TGSMobile = inputItem.TGSMobile,  
  
		TGSDescr = inputItem.TGSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsGuaYearShare Map(AddTrsGuaYearShareCommand inputItem)
        {
            var entity = new TrsGuaYearShare() {
                  
  
		TGYSItmRef = inputItem.TGYSItmRef,  
  
		TGYSItmType = inputItem.TGYSItmType,  
  
		TGYSPeriodRef = inputItem.TGYSPeriodRef,  
  
		TGYSToDate = inputItem.TGYSToDate,  
  
		TGYSVal = inputItem.TGYSVal,  
  
		TGYSDescr = inputItem.TGYSDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsGuaYearShare Map(TrsGuaYearShare entity ,EditTrsGuaYearShareCommand inputItem)
        {
              
  
		entity.TGYSItmRef = inputItem.TGYSItmRef;  
  
		entity.TGYSItmType = inputItem.TGYSItmType;  
  
		entity.TGYSPeriodRef = inputItem.TGYSPeriodRef;  
  
		entity.TGYSToDate = inputItem.TGYSToDate;  
  
		entity.TGYSVal = inputItem.TGYSVal;  
  
		entity.TGYSDescr = inputItem.TGYSDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsGuaYearShareDto Map(TrsGuaYearShare inputItem)
        {
            var dto = new TrsGuaYearShareDto()
            {
                  
  
		TGYSItmRef = inputItem.TGYSItmRef,  
  
		TGYSItmType = inputItem.TGYSItmType,  
  
		TGYSPeriodRef = inputItem.TGYSPeriodRef,  
  
		TGYSToDate = inputItem.TGYSToDate,  
  
		TGYSVal = inputItem.TGYSVal,  
  
		TGYSDescr = inputItem.TGYSDescr, 
            };
            return dto;
        }

        public static List<TrsGuaYearShareDto> Map(ICollection<TrsGuaYearShare> entities)
        {
            var dtos = new List<TrsGuaYearShareDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsGuaYearShareDto()
                {
                      
  
		TGYSItmRef = inputItem.TGYSItmRef,  
  
		TGYSItmType = inputItem.TGYSItmType,  
  
		TGYSPeriodRef = inputItem.TGYSPeriodRef,  
  
		TGYSToDate = inputItem.TGYSToDate,  
  
		TGYSVal = inputItem.TGYSVal,  
  
		TGYSDescr = inputItem.TGYSDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsManCredit Map(AddTrsManCreditCommand inputItem)
        {
            var entity = new TrsManCredit() {
                  
  
		TrsManCreditId = inputItem.TrsManCreditId,  
  
		TMCType = inputItem.TMCType,  
  
		TMCCrspndRef = inputItem.TMCCrspndRef,  
  
		TMCKind = inputItem.TMCKind,  
  
		TMCAmount = inputItem.TMCAmount,  
  
		TMCDescr = inputItem.TMCDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsManCredit Map(TrsManCredit entity ,EditTrsManCreditCommand inputItem)
        {
              
  
		entity.TrsManCreditId = inputItem.TrsManCreditId;  
  
		entity.TMCType = inputItem.TMCType;  
  
		entity.TMCCrspndRef = inputItem.TMCCrspndRef;  
  
		entity.TMCKind = inputItem.TMCKind;  
  
		entity.TMCAmount = inputItem.TMCAmount;  
  
		entity.TMCDescr = inputItem.TMCDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsManCreditDto Map(TrsManCredit inputItem)
        {
            var dto = new TrsManCreditDto()
            {
                  
  
		TrsManCreditId = inputItem.TrsManCreditId,  
  
		TMCType = inputItem.TMCType,  
  
		TMCCrspndRef = inputItem.TMCCrspndRef,  
  
		TMCKind = inputItem.TMCKind,  
  
		TMCAmount = inputItem.TMCAmount,  
  
		TMCDescr = inputItem.TMCDescr, 
            };
            return dto;
        }

        public static List<TrsManCreditDto> Map(ICollection<TrsManCredit> entities)
        {
            var dtos = new List<TrsManCreditDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsManCreditDto()
                {
                      
  
		TrsManCreditId = inputItem.TrsManCreditId,  
  
		TMCType = inputItem.TMCType,  
  
		TMCCrspndRef = inputItem.TMCCrspndRef,  
  
		TMCKind = inputItem.TMCKind,  
  
		TMCAmount = inputItem.TMCAmount,  
  
		TMCDescr = inputItem.TMCDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsPayBoredItm Map(AddTrsPayBoredItmCommand inputItem)
        {
            var entity = new TrsPayBoredItm() {
                  
  
		PayBoredOprItmId = inputItem.PayBoredOprItmId,  
  
		PBOHdrRef = inputItem.PBOHdrRef,  
  
		PBOIAccOprRef = inputItem.PBOIAccOprRef,  
  
		PBOIBankAccRef = inputItem.PBOIBankAccRef,  
  
		PBOICashRef = inputItem.PBOICashRef,  
  
		PBOIBoredRef = inputItem.PBOIBoredRef,  
  
		PBOISeq = inputItem.PBOISeq,  
  
		PBOIDescr = inputItem.PBOIDescr,  
  
		PBOIDate = inputItem.PBOIDate,  
  
		PBOIDLRef = inputItem.PBOIDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsPayBoredItm Map(TrsPayBoredItm entity ,EditTrsPayBoredItmCommand inputItem)
        {
              
  
		entity.PayBoredOprItmId = inputItem.PayBoredOprItmId;  
  
		entity.PBOHdrRef = inputItem.PBOHdrRef;  
  
		entity.PBOIAccOprRef = inputItem.PBOIAccOprRef;  
  
		entity.PBOIBankAccRef = inputItem.PBOIBankAccRef;  
  
		entity.PBOICashRef = inputItem.PBOICashRef;  
  
		entity.PBOIBoredRef = inputItem.PBOIBoredRef;  
  
		entity.PBOISeq = inputItem.PBOISeq;  
  
		entity.PBOIDescr = inputItem.PBOIDescr;  
  
		entity.PBOIDate = inputItem.PBOIDate;  
  
		entity.PBOIDLRef = inputItem.PBOIDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsPayBoredItmDto Map(TrsPayBoredItm inputItem)
        {
            var dto = new TrsPayBoredItmDto()
            {
                  
  
		PayBoredOprItmId = inputItem.PayBoredOprItmId,  
  
		PBOHdrRef = inputItem.PBOHdrRef,  
  
		PBOIAccOprRef = inputItem.PBOIAccOprRef,  
  
		PBOIBankAccRef = inputItem.PBOIBankAccRef,  
  
		PBOICashRef = inputItem.PBOICashRef,  
  
		PBOIBoredRef = inputItem.PBOIBoredRef,  
  
		PBOISeq = inputItem.PBOISeq,  
  
		PBOIDescr = inputItem.PBOIDescr,  
  
		PBOIDate = inputItem.PBOIDate,  
  
		PBOIDLRef = inputItem.PBOIDLRef, 
            };
            return dto;
        }

        public static List<TrsPayBoredItmDto> Map(ICollection<TrsPayBoredItm> entities)
        {
            var dtos = new List<TrsPayBoredItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsPayBoredItmDto()
                {
                      
  
		PayBoredOprItmId = inputItem.PayBoredOprItmId,  
  
		PBOHdrRef = inputItem.PBOHdrRef,  
  
		PBOIAccOprRef = inputItem.PBOIAccOprRef,  
  
		PBOIBankAccRef = inputItem.PBOIBankAccRef,  
  
		PBOICashRef = inputItem.PBOICashRef,  
  
		PBOIBoredRef = inputItem.PBOIBoredRef,  
  
		PBOISeq = inputItem.PBOISeq,  
  
		PBOIDescr = inputItem.PBOIDescr,  
  
		PBOIDate = inputItem.PBOIDate,  
  
		PBOIDLRef = inputItem.PBOIDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsPayBoredOpr Map(AddTrsPayBoredOprCommand inputItem)
        {
            var entity = new TrsPayBoredOpr() {
                  
  
		PBOHdrId = inputItem.PBOHdrId,  
  
		PBONum = inputItem.PBONum,  
  
		PBOLocalNum = inputItem.PBOLocalNum,  
  
		PBODate = inputItem.PBODate,  
  
		PBODescr = inputItem.PBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PBOState = inputItem.PBOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PBOCreator = inputItem.PBOCreator,  
  
		PBOSit = inputItem.PBOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsPayBoredOpr Map(TrsPayBoredOpr entity ,EditTrsPayBoredOprCommand inputItem)
        {
              
  
		entity.PBOHdrId = inputItem.PBOHdrId;  
  
		entity.PBONum = inputItem.PBONum;  
  
		entity.PBOLocalNum = inputItem.PBOLocalNum;  
  
		entity.PBODate = inputItem.PBODate;  
  
		entity.PBODescr = inputItem.PBODescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PBOState = inputItem.PBOState;  
  
		entity.TPAccPrdRef = inputItem.TPAccPrdRef;  
  
		entity.PBOCreator = inputItem.PBOCreator;  
  
		entity.PBOSit = inputItem.PBOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsPayBoredOprDto Map(TrsPayBoredOpr inputItem)
        {
            var dto = new TrsPayBoredOprDto()
            {
                  
  
		PBOHdrId = inputItem.PBOHdrId,  
  
		PBONum = inputItem.PBONum,  
  
		PBOLocalNum = inputItem.PBOLocalNum,  
  
		PBODate = inputItem.PBODate,  
  
		PBODescr = inputItem.PBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PBOState = inputItem.PBOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PBOCreator = inputItem.PBOCreator,  
  
		PBOSit = inputItem.PBOSit, 
            };
            return dto;
        }

        public static List<TrsPayBoredOprDto> Map(ICollection<TrsPayBoredOpr> entities)
        {
            var dtos = new List<TrsPayBoredOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsPayBoredOprDto()
                {
                      
  
		PBOHdrId = inputItem.PBOHdrId,  
  
		PBONum = inputItem.PBONum,  
  
		PBOLocalNum = inputItem.PBOLocalNum,  
  
		PBODate = inputItem.PBODate,  
  
		PBODescr = inputItem.PBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PBOState = inputItem.PBOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PBOCreator = inputItem.PBOCreator,  
  
		PBOSit = inputItem.PBOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsPayChqItm Map(AddTrsPayChqItmCommand inputItem)
        {
            var entity = new TrsPayChqItm() {
                  
  
		PayChqOprItmId = inputItem.PayChqOprItmId,  
  
		PCOHdrRef = inputItem.PCOHdrRef,  
  
		PCOIAccOprRef = inputItem.PCOIAccOprRef,  
  
		PCOIBankAccRef = inputItem.PCOIBankAccRef,  
  
		PCOICashRef = inputItem.PCOICashRef,  
  
		PCOIChqRef = inputItem.PCOIChqRef,  
  
		PCOISeq = inputItem.PCOISeq,  
  
		PCOIDescr = inputItem.PCOIDescr,  
  
		PCOIDate = inputItem.PCOIDate,  
  
		PCOIDLRef = inputItem.PCOIDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsPayChqItm Map(TrsPayChqItm entity ,EditTrsPayChqItmCommand inputItem)
        {
              
  
		entity.PayChqOprItmId = inputItem.PayChqOprItmId;  
  
		entity.PCOHdrRef = inputItem.PCOHdrRef;  
  
		entity.PCOIAccOprRef = inputItem.PCOIAccOprRef;  
  
		entity.PCOIBankAccRef = inputItem.PCOIBankAccRef;  
  
		entity.PCOICashRef = inputItem.PCOICashRef;  
  
		entity.PCOIChqRef = inputItem.PCOIChqRef;  
  
		entity.PCOISeq = inputItem.PCOISeq;  
  
		entity.PCOIDescr = inputItem.PCOIDescr;  
  
		entity.PCOIDate = inputItem.PCOIDate;  
  
		entity.PCOIDLRef = inputItem.PCOIDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsPayChqItmDto Map(TrsPayChqItm inputItem)
        {
            var dto = new TrsPayChqItmDto()
            {
                  
  
		PayChqOprItmId = inputItem.PayChqOprItmId,  
  
		PCOHdrRef = inputItem.PCOHdrRef,  
  
		PCOIAccOprRef = inputItem.PCOIAccOprRef,  
  
		PCOIBankAccRef = inputItem.PCOIBankAccRef,  
  
		PCOICashRef = inputItem.PCOICashRef,  
  
		PCOIChqRef = inputItem.PCOIChqRef,  
  
		PCOISeq = inputItem.PCOISeq,  
  
		PCOIDescr = inputItem.PCOIDescr,  
  
		PCOIDate = inputItem.PCOIDate,  
  
		PCOIDLRef = inputItem.PCOIDLRef, 
            };
            return dto;
        }

        public static List<TrsPayChqItmDto> Map(ICollection<TrsPayChqItm> entities)
        {
            var dtos = new List<TrsPayChqItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsPayChqItmDto()
                {
                      
  
		PayChqOprItmId = inputItem.PayChqOprItmId,  
  
		PCOHdrRef = inputItem.PCOHdrRef,  
  
		PCOIAccOprRef = inputItem.PCOIAccOprRef,  
  
		PCOIBankAccRef = inputItem.PCOIBankAccRef,  
  
		PCOICashRef = inputItem.PCOICashRef,  
  
		PCOIChqRef = inputItem.PCOIChqRef,  
  
		PCOISeq = inputItem.PCOISeq,  
  
		PCOIDescr = inputItem.PCOIDescr,  
  
		PCOIDate = inputItem.PCOIDate,  
  
		PCOIDLRef = inputItem.PCOIDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsPayChqOpr Map(AddTrsPayChqOprCommand inputItem)
        {
            var entity = new TrsPayChqOpr() {
                  
  
		PCOHdrId = inputItem.PCOHdrId,  
  
		PCONum = inputItem.PCONum,  
  
		PCOLocalNum = inputItem.PCOLocalNum,  
  
		PCODate = inputItem.PCODate,  
  
		PCODescr = inputItem.PCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCOState = inputItem.PCOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PCOCreator = inputItem.PCOCreator,  
  
		PCOSit = inputItem.PCOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsPayChqOpr Map(TrsPayChqOpr entity ,EditTrsPayChqOprCommand inputItem)
        {
              
  
		entity.PCOHdrId = inputItem.PCOHdrId;  
  
		entity.PCONum = inputItem.PCONum;  
  
		entity.PCOLocalNum = inputItem.PCOLocalNum;  
  
		entity.PCODate = inputItem.PCODate;  
  
		entity.PCODescr = inputItem.PCODescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.PCOState = inputItem.PCOState;  
  
		entity.TPAccPrdRef = inputItem.TPAccPrdRef;  
  
		entity.PCOCreator = inputItem.PCOCreator;  
  
		entity.PCOSit = inputItem.PCOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsPayChqOprDto Map(TrsPayChqOpr inputItem)
        {
            var dto = new TrsPayChqOprDto()
            {
                  
  
		PCOHdrId = inputItem.PCOHdrId,  
  
		PCONum = inputItem.PCONum,  
  
		PCOLocalNum = inputItem.PCOLocalNum,  
  
		PCODate = inputItem.PCODate,  
  
		PCODescr = inputItem.PCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCOState = inputItem.PCOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PCOCreator = inputItem.PCOCreator,  
  
		PCOSit = inputItem.PCOSit, 
            };
            return dto;
        }

        public static List<TrsPayChqOprDto> Map(ICollection<TrsPayChqOpr> entities)
        {
            var dtos = new List<TrsPayChqOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsPayChqOprDto()
                {
                      
  
		PCOHdrId = inputItem.PCOHdrId,  
  
		PCONum = inputItem.PCONum,  
  
		PCOLocalNum = inputItem.PCOLocalNum,  
  
		PCODate = inputItem.PCODate,  
  
		PCODescr = inputItem.PCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		PCOState = inputItem.PCOState,  
  
		TPAccPrdRef = inputItem.TPAccPrdRef,  
  
		PCOCreator = inputItem.PCOCreator,  
  
		PCOSit = inputItem.PCOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsPayHistory Map(AddTrsPayHistoryCommand inputItem)
        {
            var entity = new TrsPayHistory() {
                  
  
		TrsPayHistoryId = inputItem.TrsPayHistoryId,  
  
		TPHItmRef = inputItem.TPHItmRef,  
  
		TPHItmDate = inputItem.TPHItmDate,  
  
		TPHItmState = inputItem.TPHItmState,  
  
		TPHOprId = inputItem.TPHOprId,  
  
		TPHTrsOpr = inputItem.TPHTrsOpr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsPayHistory Map(TrsPayHistory entity ,EditTrsPayHistoryCommand inputItem)
        {
              
  
		entity.TrsPayHistoryId = inputItem.TrsPayHistoryId;  
  
		entity.TPHItmRef = inputItem.TPHItmRef;  
  
		entity.TPHItmDate = inputItem.TPHItmDate;  
  
		entity.TPHItmState = inputItem.TPHItmState;  
  
		entity.TPHOprId = inputItem.TPHOprId;  
  
		entity.TPHTrsOpr = inputItem.TPHTrsOpr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsPayHistoryDto Map(TrsPayHistory inputItem)
        {
            var dto = new TrsPayHistoryDto()
            {
                  
  
		TrsPayHistoryId = inputItem.TrsPayHistoryId,  
  
		TPHItmRef = inputItem.TPHItmRef,  
  
		TPHItmDate = inputItem.TPHItmDate,  
  
		TPHItmState = inputItem.TPHItmState,  
  
		TPHOprId = inputItem.TPHOprId,  
  
		TPHTrsOpr = inputItem.TPHTrsOpr, 
            };
            return dto;
        }

        public static List<TrsPayHistoryDto> Map(ICollection<TrsPayHistory> entities)
        {
            var dtos = new List<TrsPayHistoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsPayHistoryDto()
                {
                      
  
		TrsPayHistoryId = inputItem.TrsPayHistoryId,  
  
		TPHItmRef = inputItem.TPHItmRef,  
  
		TPHItmDate = inputItem.TPHItmDate,  
  
		TPHItmState = inputItem.TPHItmState,  
  
		TPHOprId = inputItem.TPHOprId,  
  
		TPHTrsOpr = inputItem.TPHTrsOpr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRcvBoredItm Map(AddTrsRcvBoredItmCommand inputItem)
        {
            var entity = new TrsRcvBoredItm() {
                  
  
		RcvBoredOprItmId = inputItem.RcvBoredOprItmId,  
  
		RBOHdrRef = inputItem.RBOHdrRef,  
  
		RBOIAccOprRef = inputItem.RBOIAccOprRef,  
  
		RBOIBankAccRef = inputItem.RBOIBankAccRef,  
  
		RBOICashRef = inputItem.RBOICashRef,  
  
		RBOIBoredRef = inputItem.RBOIBoredRef,  
  
		RBOISeq = inputItem.RBOISeq,  
  
		RBOIDescr = inputItem.RBOIDescr,  
  
		RBOIDate = inputItem.RBOIDate,  
  
		RBOIDLRef = inputItem.RBOIDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRcvBoredItm Map(TrsRcvBoredItm entity ,EditTrsRcvBoredItmCommand inputItem)
        {
              
  
		entity.RcvBoredOprItmId = inputItem.RcvBoredOprItmId;  
  
		entity.RBOHdrRef = inputItem.RBOHdrRef;  
  
		entity.RBOIAccOprRef = inputItem.RBOIAccOprRef;  
  
		entity.RBOIBankAccRef = inputItem.RBOIBankAccRef;  
  
		entity.RBOICashRef = inputItem.RBOICashRef;  
  
		entity.RBOIBoredRef = inputItem.RBOIBoredRef;  
  
		entity.RBOISeq = inputItem.RBOISeq;  
  
		entity.RBOIDescr = inputItem.RBOIDescr;  
  
		entity.RBOIDate = inputItem.RBOIDate;  
  
		entity.RBOIDLRef = inputItem.RBOIDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRcvBoredItmDto Map(TrsRcvBoredItm inputItem)
        {
            var dto = new TrsRcvBoredItmDto()
            {
                  
  
		RcvBoredOprItmId = inputItem.RcvBoredOprItmId,  
  
		RBOHdrRef = inputItem.RBOHdrRef,  
  
		RBOIAccOprRef = inputItem.RBOIAccOprRef,  
  
		RBOIBankAccRef = inputItem.RBOIBankAccRef,  
  
		RBOICashRef = inputItem.RBOICashRef,  
  
		RBOIBoredRef = inputItem.RBOIBoredRef,  
  
		RBOISeq = inputItem.RBOISeq,  
  
		RBOIDescr = inputItem.RBOIDescr,  
  
		RBOIDate = inputItem.RBOIDate,  
  
		RBOIDLRef = inputItem.RBOIDLRef, 
            };
            return dto;
        }

        public static List<TrsRcvBoredItmDto> Map(ICollection<TrsRcvBoredItm> entities)
        {
            var dtos = new List<TrsRcvBoredItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRcvBoredItmDto()
                {
                      
  
		RcvBoredOprItmId = inputItem.RcvBoredOprItmId,  
  
		RBOHdrRef = inputItem.RBOHdrRef,  
  
		RBOIAccOprRef = inputItem.RBOIAccOprRef,  
  
		RBOIBankAccRef = inputItem.RBOIBankAccRef,  
  
		RBOICashRef = inputItem.RBOICashRef,  
  
		RBOIBoredRef = inputItem.RBOIBoredRef,  
  
		RBOISeq = inputItem.RBOISeq,  
  
		RBOIDescr = inputItem.RBOIDescr,  
  
		RBOIDate = inputItem.RBOIDate,  
  
		RBOIDLRef = inputItem.RBOIDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRcvBoredOpr Map(AddTrsRcvBoredOprCommand inputItem)
        {
            var entity = new TrsRcvBoredOpr() {
                  
  
		RBOHdrId = inputItem.RBOHdrId,  
  
		RBONum = inputItem.RBONum,  
  
		RBOLocalNum = inputItem.RBOLocalNum,  
  
		RBODate = inputItem.RBODate,  
  
		RBODescr = inputItem.RBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RBOState = inputItem.RBOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RBOCreator = inputItem.RBOCreator,  
  
		RBOSit = inputItem.RBOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRcvBoredOpr Map(TrsRcvBoredOpr entity ,EditTrsRcvBoredOprCommand inputItem)
        {
              
  
		entity.RBOHdrId = inputItem.RBOHdrId;  
  
		entity.RBONum = inputItem.RBONum;  
  
		entity.RBOLocalNum = inputItem.RBOLocalNum;  
  
		entity.RBODate = inputItem.RBODate;  
  
		entity.RBODescr = inputItem.RBODescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.RBOState = inputItem.RBOState;  
  
		entity.TRAccPrdRef = inputItem.TRAccPrdRef;  
  
		entity.RBOCreator = inputItem.RBOCreator;  
  
		entity.RBOSit = inputItem.RBOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRcvBoredOprDto Map(TrsRcvBoredOpr inputItem)
        {
            var dto = new TrsRcvBoredOprDto()
            {
                  
  
		RBOHdrId = inputItem.RBOHdrId,  
  
		RBONum = inputItem.RBONum,  
  
		RBOLocalNum = inputItem.RBOLocalNum,  
  
		RBODate = inputItem.RBODate,  
  
		RBODescr = inputItem.RBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RBOState = inputItem.RBOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RBOCreator = inputItem.RBOCreator,  
  
		RBOSit = inputItem.RBOSit, 
            };
            return dto;
        }

        public static List<TrsRcvBoredOprDto> Map(ICollection<TrsRcvBoredOpr> entities)
        {
            var dtos = new List<TrsRcvBoredOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRcvBoredOprDto()
                {
                      
  
		RBOHdrId = inputItem.RBOHdrId,  
  
		RBONum = inputItem.RBONum,  
  
		RBOLocalNum = inputItem.RBOLocalNum,  
  
		RBODate = inputItem.RBODate,  
  
		RBODescr = inputItem.RBODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RBOState = inputItem.RBOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RBOCreator = inputItem.RBOCreator,  
  
		RBOSit = inputItem.RBOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRcvChqItm Map(AddTrsRcvChqItmCommand inputItem)
        {
            var entity = new TrsRcvChqItm() {
                  
  
		RcvChqOprItmId = inputItem.RcvChqOprItmId,  
  
		RCOHdrRef = inputItem.RCOHdrRef,  
  
		RCOIAccOprRef = inputItem.RCOIAccOprRef,  
  
		RCOIBankAccRef = inputItem.RCOIBankAccRef,  
  
		RCOICashRef = inputItem.RCOICashRef,  
  
		RCOIChqRef = inputItem.RCOIChqRef,  
  
		RCOISeq = inputItem.RCOISeq,  
  
		RCOIDescr = inputItem.RCOIDescr,  
  
		RCOIDate = inputItem.RCOIDate,  
  
		RCOIDLRef = inputItem.RCOIDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRcvChqItm Map(TrsRcvChqItm entity ,EditTrsRcvChqItmCommand inputItem)
        {
              
  
		entity.RcvChqOprItmId = inputItem.RcvChqOprItmId;  
  
		entity.RCOHdrRef = inputItem.RCOHdrRef;  
  
		entity.RCOIAccOprRef = inputItem.RCOIAccOprRef;  
  
		entity.RCOIBankAccRef = inputItem.RCOIBankAccRef;  
  
		entity.RCOICashRef = inputItem.RCOICashRef;  
  
		entity.RCOIChqRef = inputItem.RCOIChqRef;  
  
		entity.RCOISeq = inputItem.RCOISeq;  
  
		entity.RCOIDescr = inputItem.RCOIDescr;  
  
		entity.RCOIDate = inputItem.RCOIDate;  
  
		entity.RCOIDLRef = inputItem.RCOIDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRcvChqItmDto Map(TrsRcvChqItm inputItem)
        {
            var dto = new TrsRcvChqItmDto()
            {
                  
  
		RcvChqOprItmId = inputItem.RcvChqOprItmId,  
  
		RCOHdrRef = inputItem.RCOHdrRef,  
  
		RCOIAccOprRef = inputItem.RCOIAccOprRef,  
  
		RCOIBankAccRef = inputItem.RCOIBankAccRef,  
  
		RCOICashRef = inputItem.RCOICashRef,  
  
		RCOIChqRef = inputItem.RCOIChqRef,  
  
		RCOISeq = inputItem.RCOISeq,  
  
		RCOIDescr = inputItem.RCOIDescr,  
  
		RCOIDate = inputItem.RCOIDate,  
  
		RCOIDLRef = inputItem.RCOIDLRef, 
            };
            return dto;
        }

        public static List<TrsRcvChqItmDto> Map(ICollection<TrsRcvChqItm> entities)
        {
            var dtos = new List<TrsRcvChqItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRcvChqItmDto()
                {
                      
  
		RcvChqOprItmId = inputItem.RcvChqOprItmId,  
  
		RCOHdrRef = inputItem.RCOHdrRef,  
  
		RCOIAccOprRef = inputItem.RCOIAccOprRef,  
  
		RCOIBankAccRef = inputItem.RCOIBankAccRef,  
  
		RCOICashRef = inputItem.RCOICashRef,  
  
		RCOIChqRef = inputItem.RCOIChqRef,  
  
		RCOISeq = inputItem.RCOISeq,  
  
		RCOIDescr = inputItem.RCOIDescr,  
  
		RCOIDate = inputItem.RCOIDate,  
  
		RCOIDLRef = inputItem.RCOIDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRcvChqOpr Map(AddTrsRcvChqOprCommand inputItem)
        {
            var entity = new TrsRcvChqOpr() {
                  
  
		RCOHdrId = inputItem.RCOHdrId,  
  
		RCONum = inputItem.RCONum,  
  
		RCOLocalNum = inputItem.RCOLocalNum,  
  
		RCODate = inputItem.RCODate,  
  
		RCODescr = inputItem.RCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RCOState = inputItem.RCOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RCOCreator = inputItem.RCOCreator,  
  
		RCOSit = inputItem.RCOSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRcvChqOpr Map(TrsRcvChqOpr entity ,EditTrsRcvChqOprCommand inputItem)
        {
              
  
		entity.RCOHdrId = inputItem.RCOHdrId;  
  
		entity.RCONum = inputItem.RCONum;  
  
		entity.RCOLocalNum = inputItem.RCOLocalNum;  
  
		entity.RCODate = inputItem.RCODate;  
  
		entity.RCODescr = inputItem.RCODescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.RCOState = inputItem.RCOState;  
  
		entity.TRAccPrdRef = inputItem.TRAccPrdRef;  
  
		entity.RCOCreator = inputItem.RCOCreator;  
  
		entity.RCOSit = inputItem.RCOSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRcvChqOprDto Map(TrsRcvChqOpr inputItem)
        {
            var dto = new TrsRcvChqOprDto()
            {
                  
  
		RCOHdrId = inputItem.RCOHdrId,  
  
		RCONum = inputItem.RCONum,  
  
		RCOLocalNum = inputItem.RCOLocalNum,  
  
		RCODate = inputItem.RCODate,  
  
		RCODescr = inputItem.RCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RCOState = inputItem.RCOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RCOCreator = inputItem.RCOCreator,  
  
		RCOSit = inputItem.RCOSit, 
            };
            return dto;
        }

        public static List<TrsRcvChqOprDto> Map(ICollection<TrsRcvChqOpr> entities)
        {
            var dtos = new List<TrsRcvChqOprDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRcvChqOprDto()
                {
                      
  
		RCOHdrId = inputItem.RCOHdrId,  
  
		RCONum = inputItem.RCONum,  
  
		RCOLocalNum = inputItem.RCOLocalNum,  
  
		RCODate = inputItem.RCODate,  
  
		RCODescr = inputItem.RCODescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		RCOState = inputItem.RCOState,  
  
		TRAccPrdRef = inputItem.TRAccPrdRef,  
  
		RCOCreator = inputItem.RCOCreator,  
  
		RCOSit = inputItem.RCOSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRcvHistory Map(AddTrsRcvHistoryCommand inputItem)
        {
            var entity = new TrsRcvHistory() {
                  
  
		TrsRcvHistoryId = inputItem.TrsRcvHistoryId,  
  
		TRHItmRef = inputItem.TRHItmRef,  
  
		TRHItmDate = inputItem.TRHItmDate,  
  
		TRHItmState = inputItem.TRHItmState,  
  
		TRHOprId = inputItem.TRHOprId,  
  
		TRHTrsOpr = inputItem.TRHTrsOpr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRcvHistory Map(TrsRcvHistory entity ,EditTrsRcvHistoryCommand inputItem)
        {
              
  
		entity.TrsRcvHistoryId = inputItem.TrsRcvHistoryId;  
  
		entity.TRHItmRef = inputItem.TRHItmRef;  
  
		entity.TRHItmDate = inputItem.TRHItmDate;  
  
		entity.TRHItmState = inputItem.TRHItmState;  
  
		entity.TRHOprId = inputItem.TRHOprId;  
  
		entity.TRHTrsOpr = inputItem.TRHTrsOpr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRcvHistoryDto Map(TrsRcvHistory inputItem)
        {
            var dto = new TrsRcvHistoryDto()
            {
                  
  
		TrsRcvHistoryId = inputItem.TrsRcvHistoryId,  
  
		TRHItmRef = inputItem.TRHItmRef,  
  
		TRHItmDate = inputItem.TRHItmDate,  
  
		TRHItmState = inputItem.TRHItmState,  
  
		TRHOprId = inputItem.TRHOprId,  
  
		TRHTrsOpr = inputItem.TRHTrsOpr, 
            };
            return dto;
        }

        public static List<TrsRcvHistoryDto> Map(ICollection<TrsRcvHistory> entities)
        {
            var dtos = new List<TrsRcvHistoryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRcvHistoryDto()
                {
                      
  
		TrsRcvHistoryId = inputItem.TrsRcvHistoryId,  
  
		TRHItmRef = inputItem.TRHItmRef,  
  
		TRHItmDate = inputItem.TRHItmDate,  
  
		TRHItmState = inputItem.TRHItmState,  
  
		TRHOprId = inputItem.TRHOprId,  
  
		TRHTrsOpr = inputItem.TRHTrsOpr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRqstHdr Map(AddTrsRqstHdrCommand inputItem)
        {
            var entity = new TrsRqstHdr() {
                  
  
		TrsRqstHdrId = inputItem.TrsRqstHdrId,  
  
		TRHRqstRef = inputItem.TRHRqstRef,  
  
		TRHNum = inputItem.TRHNum,  
  
		TRHLocalNum = inputItem.TRHLocalNum,  
  
		TRHDate = inputItem.TRHDate,  
  
		TRHDescr = inputItem.TRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TRHState = inputItem.TRHState,  
  
		TQAccPrdRef = inputItem.TQAccPrdRef,  
  
		TRHCreator = inputItem.TRHCreator,  
  
		TRHSit = inputItem.TRHSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRqstHdr Map(TrsRqstHdr entity ,EditTrsRqstHdrCommand inputItem)
        {
              
  
		entity.TrsRqstHdrId = inputItem.TrsRqstHdrId;  
  
		entity.TRHRqstRef = inputItem.TRHRqstRef;  
  
		entity.TRHNum = inputItem.TRHNum;  
  
		entity.TRHLocalNum = inputItem.TRHLocalNum;  
  
		entity.TRHDate = inputItem.TRHDate;  
  
		entity.TRHDescr = inputItem.TRHDescr;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TRHState = inputItem.TRHState;  
  
		entity.TQAccPrdRef = inputItem.TQAccPrdRef;  
  
		entity.TRHCreator = inputItem.TRHCreator;  
  
		entity.TRHSit = inputItem.TRHSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRqstHdrDto Map(TrsRqstHdr inputItem)
        {
            var dto = new TrsRqstHdrDto()
            {
                  
  
		TrsRqstHdrId = inputItem.TrsRqstHdrId,  
  
		TRHRqstRef = inputItem.TRHRqstRef,  
  
		TRHNum = inputItem.TRHNum,  
  
		TRHLocalNum = inputItem.TRHLocalNum,  
  
		TRHDate = inputItem.TRHDate,  
  
		TRHDescr = inputItem.TRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TRHState = inputItem.TRHState,  
  
		TQAccPrdRef = inputItem.TQAccPrdRef,  
  
		TRHCreator = inputItem.TRHCreator,  
  
		TRHSit = inputItem.TRHSit, 
            };
            return dto;
        }

        public static List<TrsRqstHdrDto> Map(ICollection<TrsRqstHdr> entities)
        {
            var dtos = new List<TrsRqstHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRqstHdrDto()
                {
                      
  
		TrsRqstHdrId = inputItem.TrsRqstHdrId,  
  
		TRHRqstRef = inputItem.TRHRqstRef,  
  
		TRHNum = inputItem.TRHNum,  
  
		TRHLocalNum = inputItem.TRHLocalNum,  
  
		TRHDate = inputItem.TRHDate,  
  
		TRHDescr = inputItem.TRHDescr,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TRHState = inputItem.TRHState,  
  
		TQAccPrdRef = inputItem.TQAccPrdRef,  
  
		TRHCreator = inputItem.TRHCreator,  
  
		TRHSit = inputItem.TRHSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsRqstItm Map(AddTrsRqstItmCommand inputItem)
        {
            var entity = new TrsRqstItm() {
                  
  
		TrsRqstItmId = inputItem.TrsRqstItmId,  
  
		TrsRqstHdrRef = inputItem.TrsRqstHdrRef,  
  
		TRICashFactRef = inputItem.TRICashFactRef,  
  
		TRIBankAccRef = inputItem.TRIBankAccRef,  
  
		TRICashRef = inputItem.TRICashRef,  
  
		TRIDLRef = inputItem.TRIDLRef,  
  
		TRISeq = inputItem.TRISeq,  
  
		TRIDescr = inputItem.TRIDescr,  
  
		TRIDate = inputItem.TRIDate,  
  
		TRIQty = inputItem.TRIQty,  
  
		TRIDLFive = inputItem.TRIDLFive,  
  
		TRIDLSix = inputItem.TRIDLSix, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsRqstItm Map(TrsRqstItm entity ,EditTrsRqstItmCommand inputItem)
        {
              
  
		entity.TrsRqstItmId = inputItem.TrsRqstItmId;  
  
		entity.TrsRqstHdrRef = inputItem.TrsRqstHdrRef;  
  
		entity.TRICashFactRef = inputItem.TRICashFactRef;  
  
		entity.TRIBankAccRef = inputItem.TRIBankAccRef;  
  
		entity.TRICashRef = inputItem.TRICashRef;  
  
		entity.TRIDLRef = inputItem.TRIDLRef;  
  
		entity.TRISeq = inputItem.TRISeq;  
  
		entity.TRIDescr = inputItem.TRIDescr;  
  
		entity.TRIDate = inputItem.TRIDate;  
  
		entity.TRIQty = inputItem.TRIQty;  
  
		entity.TRIDLFive = inputItem.TRIDLFive;  
  
		entity.TRIDLSix = inputItem.TRIDLSix; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsRqstItmDto Map(TrsRqstItm inputItem)
        {
            var dto = new TrsRqstItmDto()
            {
                  
  
		TrsRqstItmId = inputItem.TrsRqstItmId,  
  
		TrsRqstHdrRef = inputItem.TrsRqstHdrRef,  
  
		TRICashFactRef = inputItem.TRICashFactRef,  
  
		TRIBankAccRef = inputItem.TRIBankAccRef,  
  
		TRICashRef = inputItem.TRICashRef,  
  
		TRIDLRef = inputItem.TRIDLRef,  
  
		TRISeq = inputItem.TRISeq,  
  
		TRIDescr = inputItem.TRIDescr,  
  
		TRIDate = inputItem.TRIDate,  
  
		TRIQty = inputItem.TRIQty,  
  
		TRIDLFive = inputItem.TRIDLFive,  
  
		TRIDLSix = inputItem.TRIDLSix, 
            };
            return dto;
        }

        public static List<TrsRqstItmDto> Map(ICollection<TrsRqstItm> entities)
        {
            var dtos = new List<TrsRqstItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsRqstItmDto()
                {
                      
  
		TrsRqstItmId = inputItem.TrsRqstItmId,  
  
		TrsRqstHdrRef = inputItem.TrsRqstHdrRef,  
  
		TRICashFactRef = inputItem.TRICashFactRef,  
  
		TRIBankAccRef = inputItem.TRIBankAccRef,  
  
		TRICashRef = inputItem.TRICashRef,  
  
		TRIDLRef = inputItem.TRIDLRef,  
  
		TRISeq = inputItem.TRISeq,  
  
		TRIDescr = inputItem.TRIDescr,  
  
		TRIDate = inputItem.TRIDate,  
  
		TRIQty = inputItem.TRIQty,  
  
		TRIDLFive = inputItem.TRIDLFive,  
  
		TRIDLSix = inputItem.TRIDLSix, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsSourceUse Map(AddTrsSourceUseCommand inputItem)
        {
            var entity = new TrsSourceUse() {
                  
  
		TrsSourceUseID = inputItem.TrsSourceUseID,  
  
		TSUCode = inputItem.TSUCode,  
  
		TSUTitle = inputItem.TSUTitle,  
  
		TSUSLRef = inputItem.TSUSLRef,  
  
		TSUDLRef = inputItem.TSUDLRef,  
  
		TSUDLFive = inputItem.TSUDLFive,  
  
		TSUDLSix = inputItem.TSUDLSix,  
  
		TSUType = inputItem.TSUType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsSourceUse Map(TrsSourceUse entity ,EditTrsSourceUseCommand inputItem)
        {
              
  
		entity.TrsSourceUseID = inputItem.TrsSourceUseID;  
  
		entity.TSUCode = inputItem.TSUCode;  
  
		entity.TSUTitle = inputItem.TSUTitle;  
  
		entity.TSUSLRef = inputItem.TSUSLRef;  
  
		entity.TSUDLRef = inputItem.TSUDLRef;  
  
		entity.TSUDLFive = inputItem.TSUDLFive;  
  
		entity.TSUDLSix = inputItem.TSUDLSix;  
  
		entity.TSUType = inputItem.TSUType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsSourceUseDto Map(TrsSourceUse inputItem)
        {
            var dto = new TrsSourceUseDto()
            {
                  
  
		TrsSourceUseID = inputItem.TrsSourceUseID,  
  
		TSUCode = inputItem.TSUCode,  
  
		TSUTitle = inputItem.TSUTitle,  
  
		TSUSLRef = inputItem.TSUSLRef,  
  
		TSUDLRef = inputItem.TSUDLRef,  
  
		TSUDLFive = inputItem.TSUDLFive,  
  
		TSUDLSix = inputItem.TSUDLSix,  
  
		TSUType = inputItem.TSUType, 
            };
            return dto;
        }

        public static List<TrsSourceUseDto> Map(ICollection<TrsSourceUse> entities)
        {
            var dtos = new List<TrsSourceUseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsSourceUseDto()
                {
                      
  
		TrsSourceUseID = inputItem.TrsSourceUseID,  
  
		TSUCode = inputItem.TSUCode,  
  
		TSUTitle = inputItem.TSUTitle,  
  
		TSUSLRef = inputItem.TSUSLRef,  
  
		TSUDLRef = inputItem.TSUDLRef,  
  
		TSUDLFive = inputItem.TSUDLFive,  
  
		TSUDLSix = inputItem.TSUDLSix,  
  
		TSUType = inputItem.TSUType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsSourceUseRels Map(AddTrsSourceUseRelsCommand inputItem)
        {
            var entity = new TrsSourceUseRels() {
                  
  
		TSURMaster = inputItem.TSURMaster,  
  
		TSURChild = inputItem.TSURChild, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsSourceUseRels Map(TrsSourceUseRels entity ,EditTrsSourceUseRelsCommand inputItem)
        {
              
  
		entity.TSURMaster = inputItem.TSURMaster;  
  
		entity.TSURChild = inputItem.TSURChild; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsSourceUseRelsDto Map(TrsSourceUseRels inputItem)
        {
            var dto = new TrsSourceUseRelsDto()
            {
                  
  
		TSURMaster = inputItem.TSURMaster,  
  
		TSURChild = inputItem.TSURChild, 
            };
            return dto;
        }

        public static List<TrsSourceUseRelsDto> Map(ICollection<TrsSourceUseRels> entities)
        {
            var dtos = new List<TrsSourceUseRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsSourceUseRelsDto()
                {
                      
  
		TSURMaster = inputItem.TSURMaster,  
  
		TSURChild = inputItem.TSURChild, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsVchHdr Map(AddTrsVchHdrCommand inputItem)
        {
            var entity = new TrsVchHdr() {
                  
  
		TrsVchHdrId = inputItem.TrsVchHdrId,  
  
		TVHVchKind = inputItem.TVHVchKind,  
  
		TVHType = inputItem.TVHType,  
  
		TVHRole = inputItem.TVHRole,  
  
		TVHNum = inputItem.TVHNum,  
  
		TVHLocalNum = inputItem.TVHLocalNum,  
  
		TVHDate = inputItem.TVHDate,  
  
		TVHDescr = inputItem.TVHDescr,  
  
		TVHDocRef = inputItem.TVHDocRef,  
  
		TVHDocRefType = inputItem.TVHDocRefType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TVHState = inputItem.TVHState,  
  
		TAccPrdRef = inputItem.TAccPrdRef,  
  
		TVHRefID = inputItem.TVHRefID,  
  
		TVHRefType = inputItem.TVHRefType,  
  
		TVHCreator = inputItem.TVHCreator,  
  
		TVHSit = inputItem.TVHSit, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsVchHdr Map(TrsVchHdr entity ,EditTrsVchHdrCommand inputItem)
        {
              
  
		entity.TrsVchHdrId = inputItem.TrsVchHdrId;  
  
		entity.TVHVchKind = inputItem.TVHVchKind;  
  
		entity.TVHType = inputItem.TVHType;  
  
		entity.TVHRole = inputItem.TVHRole;  
  
		entity.TVHNum = inputItem.TVHNum;  
  
		entity.TVHLocalNum = inputItem.TVHLocalNum;  
  
		entity.TVHDate = inputItem.TVHDate;  
  
		entity.TVHDescr = inputItem.TVHDescr;  
  
		entity.TVHDocRef = inputItem.TVHDocRef;  
  
		entity.TVHDocRefType = inputItem.TVHDocRefType;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.TVHState = inputItem.TVHState;  
  
		entity.TAccPrdRef = inputItem.TAccPrdRef;  
  
		entity.TVHRefID = inputItem.TVHRefID;  
  
		entity.TVHRefType = inputItem.TVHRefType;  
  
		entity.TVHCreator = inputItem.TVHCreator;  
  
		entity.TVHSit = inputItem.TVHSit; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsVchHdrDto Map(TrsVchHdr inputItem)
        {
            var dto = new TrsVchHdrDto()
            {
                  
  
		TrsVchHdrId = inputItem.TrsVchHdrId,  
  
		TVHVchKind = inputItem.TVHVchKind,  
  
		TVHType = inputItem.TVHType,  
  
		TVHRole = inputItem.TVHRole,  
  
		TVHNum = inputItem.TVHNum,  
  
		TVHLocalNum = inputItem.TVHLocalNum,  
  
		TVHDate = inputItem.TVHDate,  
  
		TVHDescr = inputItem.TVHDescr,  
  
		TVHDocRef = inputItem.TVHDocRef,  
  
		TVHDocRefType = inputItem.TVHDocRefType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TVHState = inputItem.TVHState,  
  
		TAccPrdRef = inputItem.TAccPrdRef,  
  
		TVHRefID = inputItem.TVHRefID,  
  
		TVHRefType = inputItem.TVHRefType,  
  
		TVHCreator = inputItem.TVHCreator,  
  
		TVHSit = inputItem.TVHSit, 
            };
            return dto;
        }

        public static List<TrsVchHdrDto> Map(ICollection<TrsVchHdr> entities)
        {
            var dtos = new List<TrsVchHdrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsVchHdrDto()
                {
                      
  
		TrsVchHdrId = inputItem.TrsVchHdrId,  
  
		TVHVchKind = inputItem.TVHVchKind,  
  
		TVHType = inputItem.TVHType,  
  
		TVHRole = inputItem.TVHRole,  
  
		TVHNum = inputItem.TVHNum,  
  
		TVHLocalNum = inputItem.TVHLocalNum,  
  
		TVHDate = inputItem.TVHDate,  
  
		TVHDescr = inputItem.TVHDescr,  
  
		TVHDocRef = inputItem.TVHDocRef,  
  
		TVHDocRefType = inputItem.TVHDocRefType,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		TVHState = inputItem.TVHState,  
  
		TAccPrdRef = inputItem.TAccPrdRef,  
  
		TVHRefID = inputItem.TVHRefID,  
  
		TVHRefType = inputItem.TVHRefType,  
  
		TVHCreator = inputItem.TVHCreator,  
  
		TVHSit = inputItem.TVHSit, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsVchItm Map(AddTrsVchItmCommand inputItem)
        {
            var entity = new TrsVchItm() {
                  
  
		TrsVchItmId = inputItem.TrsVchItmId,  
  
		TrsVchHdrRef = inputItem.TrsVchHdrRef,  
  
		TVIAccOprRef = inputItem.TVIAccOprRef,  
  
		TVICashFactRef = inputItem.TVICashFactRef,  
  
		TVIBankAccRef = inputItem.TVIBankAccRef,  
  
		TVIBankRef = inputItem.TVIBankRef,  
  
		TVIBranchName = inputItem.TVIBranchName,  
  
		TVICashRef = inputItem.TVICashRef,  
  
		TVIChqRef = inputItem.TVIChqRef,  
  
		TVIDLRef = inputItem.TVIDLRef,  
  
		TVISeq = inputItem.TVISeq,  
  
		TVIItmNo = inputItem.TVIItmNo,  
  
		TVIDescr = inputItem.TVIDescr,  
  
		TVIDate = inputItem.TVIDate,  
  
		TVIQty = inputItem.TVIQty,  
  
		TVIItmType = inputItem.TVIItmType,  
  
		TVIBankAcnName = inputItem.TVIBankAcnName,  
  
		TVIItmRef = inputItem.TVIItmRef,  
  
		TVIOpsBankAcn = inputItem.TVIOpsBankAcn,  
  
		TVIOpsCash = inputItem.TVIOpsCash,  
  
		TVIOpsFund = inputItem.TVIOpsFund,  
  
		TVIRefID = inputItem.TVIRefID,  
  
		TVIRefType = inputItem.TVIRefType,  
  
		TVIItmRole = inputItem.TVIItmRole,  
  
		TVIDLFive = inputItem.TVIDLFive,  
  
		TVIDLSix = inputItem.TVIDLSix,  
  
		TVICurRef = inputItem.TVICurRef,  
  
		TVICurVal = inputItem.TVICurVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsVchItm Map(TrsVchItm entity ,EditTrsVchItmCommand inputItem)
        {
              
  
		entity.TrsVchItmId = inputItem.TrsVchItmId;  
  
		entity.TrsVchHdrRef = inputItem.TrsVchHdrRef;  
  
		entity.TVIAccOprRef = inputItem.TVIAccOprRef;  
  
		entity.TVICashFactRef = inputItem.TVICashFactRef;  
  
		entity.TVIBankAccRef = inputItem.TVIBankAccRef;  
  
		entity.TVIBankRef = inputItem.TVIBankRef;  
  
		entity.TVIBranchName = inputItem.TVIBranchName;  
  
		entity.TVICashRef = inputItem.TVICashRef;  
  
		entity.TVIChqRef = inputItem.TVIChqRef;  
  
		entity.TVIDLRef = inputItem.TVIDLRef;  
  
		entity.TVISeq = inputItem.TVISeq;  
  
		entity.TVIItmNo = inputItem.TVIItmNo;  
  
		entity.TVIDescr = inputItem.TVIDescr;  
  
		entity.TVIDate = inputItem.TVIDate;  
  
		entity.TVIQty = inputItem.TVIQty;  
  
		entity.TVIItmType = inputItem.TVIItmType;  
  
		entity.TVIBankAcnName = inputItem.TVIBankAcnName;  
  
		entity.TVIItmRef = inputItem.TVIItmRef;  
  
		entity.TVIOpsBankAcn = inputItem.TVIOpsBankAcn;  
  
		entity.TVIOpsCash = inputItem.TVIOpsCash;  
  
		entity.TVIOpsFund = inputItem.TVIOpsFund;  
  
		entity.TVIRefID = inputItem.TVIRefID;  
  
		entity.TVIRefType = inputItem.TVIRefType;  
  
		entity.TVIItmRole = inputItem.TVIItmRole;  
  
		entity.TVIDLFive = inputItem.TVIDLFive;  
  
		entity.TVIDLSix = inputItem.TVIDLSix;  
  
		entity.TVICurRef = inputItem.TVICurRef;  
  
		entity.TVICurVal = inputItem.TVICurVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsVchItmDto Map(TrsVchItm inputItem)
        {
            var dto = new TrsVchItmDto()
            {
                  
  
		TrsVchItmId = inputItem.TrsVchItmId,  
  
		TrsVchHdrRef = inputItem.TrsVchHdrRef,  
  
		TVIAccOprRef = inputItem.TVIAccOprRef,  
  
		TVICashFactRef = inputItem.TVICashFactRef,  
  
		TVIBankAccRef = inputItem.TVIBankAccRef,  
  
		TVIBankRef = inputItem.TVIBankRef,  
  
		TVIBranchName = inputItem.TVIBranchName,  
  
		TVICashRef = inputItem.TVICashRef,  
  
		TVIChqRef = inputItem.TVIChqRef,  
  
		TVIDLRef = inputItem.TVIDLRef,  
  
		TVISeq = inputItem.TVISeq,  
  
		TVIItmNo = inputItem.TVIItmNo,  
  
		TVIDescr = inputItem.TVIDescr,  
  
		TVIDate = inputItem.TVIDate,  
  
		TVIQty = inputItem.TVIQty,  
  
		TVIItmType = inputItem.TVIItmType,  
  
		TVIBankAcnName = inputItem.TVIBankAcnName,  
  
		TVIItmRef = inputItem.TVIItmRef,  
  
		TVIOpsBankAcn = inputItem.TVIOpsBankAcn,  
  
		TVIOpsCash = inputItem.TVIOpsCash,  
  
		TVIOpsFund = inputItem.TVIOpsFund,  
  
		TVIRefID = inputItem.TVIRefID,  
  
		TVIRefType = inputItem.TVIRefType,  
  
		TVIItmRole = inputItem.TVIItmRole,  
  
		TVIDLFive = inputItem.TVIDLFive,  
  
		TVIDLSix = inputItem.TVIDLSix,  
  
		TVICurRef = inputItem.TVICurRef,  
  
		TVICurVal = inputItem.TVICurVal, 
            };
            return dto;
        }

        public static List<TrsVchItmDto> Map(ICollection<TrsVchItm> entities)
        {
            var dtos = new List<TrsVchItmDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsVchItmDto()
                {
                      
  
		TrsVchItmId = inputItem.TrsVchItmId,  
  
		TrsVchHdrRef = inputItem.TrsVchHdrRef,  
  
		TVIAccOprRef = inputItem.TVIAccOprRef,  
  
		TVICashFactRef = inputItem.TVICashFactRef,  
  
		TVIBankAccRef = inputItem.TVIBankAccRef,  
  
		TVIBankRef = inputItem.TVIBankRef,  
  
		TVIBranchName = inputItem.TVIBranchName,  
  
		TVICashRef = inputItem.TVICashRef,  
  
		TVIChqRef = inputItem.TVIChqRef,  
  
		TVIDLRef = inputItem.TVIDLRef,  
  
		TVISeq = inputItem.TVISeq,  
  
		TVIItmNo = inputItem.TVIItmNo,  
  
		TVIDescr = inputItem.TVIDescr,  
  
		TVIDate = inputItem.TVIDate,  
  
		TVIQty = inputItem.TVIQty,  
  
		TVIItmType = inputItem.TVIItmType,  
  
		TVIBankAcnName = inputItem.TVIBankAcnName,  
  
		TVIItmRef = inputItem.TVIItmRef,  
  
		TVIOpsBankAcn = inputItem.TVIOpsBankAcn,  
  
		TVIOpsCash = inputItem.TVIOpsCash,  
  
		TVIOpsFund = inputItem.TVIOpsFund,  
  
		TVIRefID = inputItem.TVIRefID,  
  
		TVIRefType = inputItem.TVIRefType,  
  
		TVIItmRole = inputItem.TVIItmRole,  
  
		TVIDLFive = inputItem.TVIDLFive,  
  
		TVIDLSix = inputItem.TVIDLSix,  
  
		TVICurRef = inputItem.TVICurRef,  
  
		TVICurVal = inputItem.TVICurVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsVchItmBase Map(AddTrsVchItmBaseCommand inputItem)
        {
            var entity = new TrsVchItmBase() {
                  
  
		TVIBItmId = inputItem.TVIBItmId,  
  
		TVIBRefId = inputItem.TVIBRefId,  
  
		TVIBRefType = inputItem.TVIBRefType, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsVchItmBase Map(TrsVchItmBase entity ,EditTrsVchItmBaseCommand inputItem)
        {
              
  
		entity.TVIBItmId = inputItem.TVIBItmId;  
  
		entity.TVIBRefId = inputItem.TVIBRefId;  
  
		entity.TVIBRefType = inputItem.TVIBRefType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsVchItmBaseDto Map(TrsVchItmBase inputItem)
        {
            var dto = new TrsVchItmBaseDto()
            {
                  
  
		TVIBItmId = inputItem.TVIBItmId,  
  
		TVIBRefId = inputItem.TVIBRefId,  
  
		TVIBRefType = inputItem.TVIBRefType, 
            };
            return dto;
        }

        public static List<TrsVchItmBaseDto> Map(ICollection<TrsVchItmBase> entities)
        {
            var dtos = new List<TrsVchItmBaseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsVchItmBaseDto()
                {
                      
  
		TVIBItmId = inputItem.TVIBItmId,  
  
		TVIBRefId = inputItem.TVIBRefId,  
  
		TVIBRefType = inputItem.TVIBRefType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsVchItmRel Map(AddTrsVchItmRelCommand inputItem)
        {
            var entity = new TrsVchItmRel() {
                  
  
		TrsVchItmRef = inputItem.TrsVchItmRef,  
  
		TVIRSysRef = inputItem.TVIRSysRef,  
  
		TVIRVchRef = inputItem.TVIRVchRef,  
  
		TVIRQty = inputItem.TVIRQty,  
  
		TVIRDescr = inputItem.TVIRDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsVchItmRel Map(TrsVchItmRel entity ,EditTrsVchItmRelCommand inputItem)
        {
              
  
		entity.TrsVchItmRef = inputItem.TrsVchItmRef;  
  
		entity.TVIRSysRef = inputItem.TVIRSysRef;  
  
		entity.TVIRVchRef = inputItem.TVIRVchRef;  
  
		entity.TVIRQty = inputItem.TVIRQty;  
  
		entity.TVIRDescr = inputItem.TVIRDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsVchItmRelDto Map(TrsVchItmRel inputItem)
        {
            var dto = new TrsVchItmRelDto()
            {
                  
  
		TrsVchItmRef = inputItem.TrsVchItmRef,  
  
		TVIRSysRef = inputItem.TVIRSysRef,  
  
		TVIRVchRef = inputItem.TVIRVchRef,  
  
		TVIRQty = inputItem.TVIRQty,  
  
		TVIRDescr = inputItem.TVIRDescr, 
            };
            return dto;
        }

        public static List<TrsVchItmRelDto> Map(ICollection<TrsVchItmRel> entities)
        {
            var dtos = new List<TrsVchItmRelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsVchItmRelDto()
                {
                      
  
		TrsVchItmRef = inputItem.TrsVchItmRef,  
  
		TVIRSysRef = inputItem.TVIRSysRef,  
  
		TVIRVchRef = inputItem.TVIRVchRef,  
  
		TVIRQty = inputItem.TVIRQty,  
  
		TVIRDescr = inputItem.TVIRDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TrsVchSrcUse Map(AddTrsVchSrcUseCommand inputItem)
        {
            var entity = new TrsVchSrcUse() {
                  
  
		TrsVchSrcUseId = inputItem.TrsVchSrcUseId,  
  
		TVSUItemRef = inputItem.TVSUItemRef,  
  
		TVSUSrcRef = inputItem.TVSUSrcRef,  
  
		TVSUAmount = inputItem.TVSUAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TrsVchSrcUse Map(TrsVchSrcUse entity ,EditTrsVchSrcUseCommand inputItem)
        {
              
  
		entity.TrsVchSrcUseId = inputItem.TrsVchSrcUseId;  
  
		entity.TVSUItemRef = inputItem.TVSUItemRef;  
  
		entity.TVSUSrcRef = inputItem.TVSUSrcRef;  
  
		entity.TVSUAmount = inputItem.TVSUAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TrsVchSrcUseDto Map(TrsVchSrcUse inputItem)
        {
            var dto = new TrsVchSrcUseDto()
            {
                  
  
		TrsVchSrcUseId = inputItem.TrsVchSrcUseId,  
  
		TVSUItemRef = inputItem.TVSUItemRef,  
  
		TVSUSrcRef = inputItem.TVSUSrcRef,  
  
		TVSUAmount = inputItem.TVSUAmount, 
            };
            return dto;
        }

        public static List<TrsVchSrcUseDto> Map(ICollection<TrsVchSrcUse> entities)
        {
            var dtos = new List<TrsVchSrcUseDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TrsVchSrcUseDto()
                {
                      
  
		TrsVchSrcUseId = inputItem.TrsVchSrcUseId,  
  
		TVSUItemRef = inputItem.TVSUItemRef,  
  
		TVSUSrcRef = inputItem.TVSUSrcRef,  
  
		TVSUAmount = inputItem.TVSUAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
