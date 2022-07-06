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
                
        
        public static UsrBuyService Map(AddUsrBuyServiceCommand inputItem)
        {
            var entity = new UsrBuyService() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		DocNo = inputItem.DocNo,  
  
		DocDate = inputItem.DocDate,  
  
		DLRef = inputItem.DLRef,  
  
		HDescr = inputItem.HDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrBuyService Map(UsrBuyService entity ,EditUsrBuyServiceCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.DocNo = inputItem.DocNo;  
  
		entity.DocDate = inputItem.DocDate;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.HDescr = inputItem.HDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrBuyServiceDto Map(UsrBuyService inputItem)
        {
            var dto = new UsrBuyServiceDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		DocNo = inputItem.DocNo,  
  
		DocDate = inputItem.DocDate,  
  
		DLRef = inputItem.DLRef,  
  
		HDescr = inputItem.HDescr, 
            };
            return dto;
        }

        public static List<UsrBuyServiceDto> Map(ICollection<UsrBuyService> entities)
        {
            var dtos = new List<UsrBuyServiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrBuyServiceDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		DocNo = inputItem.DocNo,  
  
		DocDate = inputItem.DocDate,  
  
		DLRef = inputItem.DLRef,  
  
		HDescr = inputItem.HDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrBuyServiceDet Map(AddUsrBuyServiceDetCommand inputItem)
        {
            var entity = new UsrBuyServiceDet() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		SrvRef = inputItem.SrvRef,  
  
		Qty = inputItem.Qty,  
  
		Rate = inputItem.Rate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrBuyServiceDet Map(UsrBuyServiceDet entity ,EditUsrBuyServiceDetCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.SrvRef = inputItem.SrvRef;  
  
		entity.Qty = inputItem.Qty;  
  
		entity.Rate = inputItem.Rate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrBuyServiceDetDto Map(UsrBuyServiceDet inputItem)
        {
            var dto = new UsrBuyServiceDetDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		SrvRef = inputItem.SrvRef,  
  
		Qty = inputItem.Qty,  
  
		Rate = inputItem.Rate, 
            };
            return dto;
        }

        public static List<UsrBuyServiceDetDto> Map(ICollection<UsrBuyServiceDet> entities)
        {
            var dtos = new List<UsrBuyServiceDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrBuyServiceDetDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		SrvRef = inputItem.SrvRef,  
  
		Qty = inputItem.Qty,  
  
		Rate = inputItem.Rate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrCash Map(AddUsrCashCommand inputItem)
        {
            var entity = new UsrCash() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo,  
  
		VDate = inputItem.VDate,  
  
		Descr = inputItem.Descr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrCash Map(UsrCash entity ,EditUsrCashCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.VNo = inputItem.VNo;  
  
		entity.VDate = inputItem.VDate;  
  
		entity.Descr = inputItem.Descr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrCashDto Map(UsrCash inputItem)
        {
            var dto = new UsrCashDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo,  
  
		VDate = inputItem.VDate,  
  
		Descr = inputItem.Descr, 
            };
            return dto;
        }

        public static List<UsrCashDto> Map(ICollection<UsrCash> entities)
        {
            var dtos = new List<UsrCashDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrCashDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo,  
  
		VDate = inputItem.VDate,  
  
		Descr = inputItem.Descr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrCashDet Map(AddUsrCashDetCommand inputItem)
        {
            var entity = new UsrCashDet() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FishNo = inputItem.FishNo,  
  
		Amnt = inputItem.Amnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrCashDet Map(UsrCashDet entity ,EditUsrCashDetCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.FishNo = inputItem.FishNo;  
  
		entity.Amnt = inputItem.Amnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrCashDetDto Map(UsrCashDet inputItem)
        {
            var dto = new UsrCashDetDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FishNo = inputItem.FishNo,  
  
		Amnt = inputItem.Amnt, 
            };
            return dto;
        }

        public static List<UsrCashDetDto> Map(ICollection<UsrCashDet> entities)
        {
            var dtos = new List<UsrCashDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrCashDetDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FishNo = inputItem.FishNo,  
  
		Amnt = inputItem.Amnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrContInf Map(AddUsrContInfCommand inputItem)
        {
            var entity = new UsrContInf() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ContNum = inputItem.ContNum,  
  
		StDate = inputItem.StDate,  
  
		EnDate = inputItem.EnDate,  
  
		Descr = inputItem.Descr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrContInf Map(UsrContInf entity ,EditUsrContInfCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.ContNum = inputItem.ContNum;  
  
		entity.StDate = inputItem.StDate;  
  
		entity.EnDate = inputItem.EnDate;  
  
		entity.Descr = inputItem.Descr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrContInfDto Map(UsrContInf inputItem)
        {
            var dto = new UsrContInfDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ContNum = inputItem.ContNum,  
  
		StDate = inputItem.StDate,  
  
		EnDate = inputItem.EnDate,  
  
		Descr = inputItem.Descr, 
            };
            return dto;
        }

        public static List<UsrContInfDto> Map(ICollection<UsrContInf> entities)
        {
            var dtos = new List<UsrContInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrContInfDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ContNum = inputItem.ContNum,  
  
		StDate = inputItem.StDate,  
  
		EnDate = inputItem.EnDate,  
  
		Descr = inputItem.Descr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrCrsOthInf Map(AddUsrCrsOthInfCommand inputItem)
        {
            var entity = new UsrCrsOthInf() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		ContType = inputItem.ContType,  
  
		AcntNo = inputItem.AcntNo,  
  
		BaygNo = inputItem.BaygNo, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrCrsOthInf Map(UsrCrsOthInf entity ,EditUsrCrsOthInfCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.PersCode = inputItem.PersCode;  
  
		entity.WorkLoc = inputItem.WorkLoc;  
  
		entity.ContType = inputItem.ContType;  
  
		entity.AcntNo = inputItem.AcntNo;  
  
		entity.BaygNo = inputItem.BaygNo; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrCrsOthInfDto Map(UsrCrsOthInf inputItem)
        {
            var dto = new UsrCrsOthInfDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		ContType = inputItem.ContType,  
  
		AcntNo = inputItem.AcntNo,  
  
		BaygNo = inputItem.BaygNo, 
            };
            return dto;
        }

        public static List<UsrCrsOthInfDto> Map(ICollection<UsrCrsOthInf> entities)
        {
            var dtos = new List<UsrCrsOthInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrCrsOthInfDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		ContType = inputItem.ContType,  
  
		AcntNo = inputItem.AcntNo,  
  
		BaygNo = inputItem.BaygNo, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrExhibitionRqst Map(AddUsrExhibitionRqstCommand inputItem)
        {
            var entity = new UsrExhibitionRqst() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FullName = inputItem.FullName,  
  
		BDate = inputItem.BDate,  
  
		Subject = inputItem.Subject,  
  
		Shora = inputItem.Shora,  
  
		SaleRqst = inputItem.SaleRqst,  
  
		RqstGavahi = inputItem.RqstGavahi,  
  
		OrdAmnt = inputItem.OrdAmnt,  
  
		Acept = inputItem.Acept, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrExhibitionRqst Map(UsrExhibitionRqst entity ,EditUsrExhibitionRqstCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.FullName = inputItem.FullName;  
  
		entity.BDate = inputItem.BDate;  
  
		entity.Subject = inputItem.Subject;  
  
		entity.Shora = inputItem.Shora;  
  
		entity.SaleRqst = inputItem.SaleRqst;  
  
		entity.RqstGavahi = inputItem.RqstGavahi;  
  
		entity.OrdAmnt = inputItem.OrdAmnt;  
  
		entity.Acept = inputItem.Acept; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrExhibitionRqstDto Map(UsrExhibitionRqst inputItem)
        {
            var dto = new UsrExhibitionRqstDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FullName = inputItem.FullName,  
  
		BDate = inputItem.BDate,  
  
		Subject = inputItem.Subject,  
  
		Shora = inputItem.Shora,  
  
		SaleRqst = inputItem.SaleRqst,  
  
		RqstGavahi = inputItem.RqstGavahi,  
  
		OrdAmnt = inputItem.OrdAmnt,  
  
		Acept = inputItem.Acept, 
            };
            return dto;
        }

        public static List<UsrExhibitionRqstDto> Map(ICollection<UsrExhibitionRqst> entities)
        {
            var dtos = new List<UsrExhibitionRqstDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrExhibitionRqstDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FullName = inputItem.FullName,  
  
		BDate = inputItem.BDate,  
  
		Subject = inputItem.Subject,  
  
		Shora = inputItem.Shora,  
  
		SaleRqst = inputItem.SaleRqst,  
  
		RqstGavahi = inputItem.RqstGavahi,  
  
		OrdAmnt = inputItem.OrdAmnt,  
  
		Acept = inputItem.Acept, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrMissionDet Map(AddUsrMissionDetCommand inputItem)
        {
            var entity = new UsrMissionDet() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Mahal = inputItem.Mahal,  
  
		Sobhane = inputItem.Sobhane,  
  
		Nahar = inputItem.Nahar,  
  
		Sham = inputItem.Sham,  
  
		Ruz = inputItem.Ruz,  
  
		Mehmansara = inputItem.Mehmansara,  
  
		Karvan = inputItem.Karvan,  
  
		Khab = inputItem.Khab,  
  
		FoghShabane = inputItem.FoghShabane,  
  
		Saku = inputItem.Saku,  
  
		Aghmar = inputItem.Aghmar,  
  
		AyabZahab = inputItem.AyabZahab,  
  
		Khoshk = inputItem.Khoshk,  
  
		Elima = inputItem.Elima, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrMissionDet Map(UsrMissionDet entity ,EditUsrMissionDetCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Mahal = inputItem.Mahal;  
  
		entity.Sobhane = inputItem.Sobhane;  
  
		entity.Nahar = inputItem.Nahar;  
  
		entity.Sham = inputItem.Sham;  
  
		entity.Ruz = inputItem.Ruz;  
  
		entity.Mehmansara = inputItem.Mehmansara;  
  
		entity.Karvan = inputItem.Karvan;  
  
		entity.Khab = inputItem.Khab;  
  
		entity.FoghShabane = inputItem.FoghShabane;  
  
		entity.Saku = inputItem.Saku;  
  
		entity.Aghmar = inputItem.Aghmar;  
  
		entity.AyabZahab = inputItem.AyabZahab;  
  
		entity.Khoshk = inputItem.Khoshk;  
  
		entity.Elima = inputItem.Elima; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrMissionDetDto Map(UsrMissionDet inputItem)
        {
            var dto = new UsrMissionDetDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Mahal = inputItem.Mahal,  
  
		Sobhane = inputItem.Sobhane,  
  
		Nahar = inputItem.Nahar,  
  
		Sham = inputItem.Sham,  
  
		Ruz = inputItem.Ruz,  
  
		Mehmansara = inputItem.Mehmansara,  
  
		Karvan = inputItem.Karvan,  
  
		Khab = inputItem.Khab,  
  
		FoghShabane = inputItem.FoghShabane,  
  
		Saku = inputItem.Saku,  
  
		Aghmar = inputItem.Aghmar,  
  
		AyabZahab = inputItem.AyabZahab,  
  
		Khoshk = inputItem.Khoshk,  
  
		Elima = inputItem.Elima, 
            };
            return dto;
        }

        public static List<UsrMissionDetDto> Map(ICollection<UsrMissionDet> entities)
        {
            var dtos = new List<UsrMissionDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrMissionDetDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Mahal = inputItem.Mahal,  
  
		Sobhane = inputItem.Sobhane,  
  
		Nahar = inputItem.Nahar,  
  
		Sham = inputItem.Sham,  
  
		Ruz = inputItem.Ruz,  
  
		Mehmansara = inputItem.Mehmansara,  
  
		Karvan = inputItem.Karvan,  
  
		Khab = inputItem.Khab,  
  
		FoghShabane = inputItem.FoghShabane,  
  
		Saku = inputItem.Saku,  
  
		Aghmar = inputItem.Aghmar,  
  
		AyabZahab = inputItem.AyabZahab,  
  
		Khoshk = inputItem.Khoshk,  
  
		Elima = inputItem.Elima, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrNewsCheckRqst Map(AddUsrNewsCheckRqstCommand inputItem)
        {
            var entity = new UsrNewsCheckRqst() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ExhName = inputItem.ExhName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrNewsCheckRqst Map(UsrNewsCheckRqst entity ,EditUsrNewsCheckRqstCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.ExhName = inputItem.ExhName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrNewsCheckRqstDto Map(UsrNewsCheckRqst inputItem)
        {
            var dto = new UsrNewsCheckRqstDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ExhName = inputItem.ExhName, 
            };
            return dto;
        }

        public static List<UsrNewsCheckRqstDto> Map(ICollection<UsrNewsCheckRqst> entities)
        {
            var dtos = new List<UsrNewsCheckRqstDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrNewsCheckRqstDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ExhName = inputItem.ExhName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRels Map(AddUsrPersHrmRelsCommand inputItem)
        {
            var entity = new UsrPersHrmRels() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		FullName = inputItem.FullName,  
  
		NatCode = inputItem.NatCode,  
  
		EmpDate = inputItem.EmpDate,  
  
		CostCenter = inputItem.CostCenter,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		Job = inputItem.Job, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRels Map(UsrPersHrmRels entity ,EditUsrPersHrmRelsCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.PersCode = inputItem.PersCode;  
  
		entity.FullName = inputItem.FullName;  
  
		entity.NatCode = inputItem.NatCode;  
  
		entity.EmpDate = inputItem.EmpDate;  
  
		entity.CostCenter = inputItem.CostCenter;  
  
		entity.WorkLoc = inputItem.WorkLoc;  
  
		entity.Job = inputItem.Job; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsDto Map(UsrPersHrmRels inputItem)
        {
            var dto = new UsrPersHrmRelsDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		FullName = inputItem.FullName,  
  
		NatCode = inputItem.NatCode,  
  
		EmpDate = inputItem.EmpDate,  
  
		CostCenter = inputItem.CostCenter,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		Job = inputItem.Job, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsDto> Map(ICollection<UsrPersHrmRels> entities)
        {
            var dtos = new List<UsrPersHrmRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		PersCode = inputItem.PersCode,  
  
		FullName = inputItem.FullName,  
  
		NatCode = inputItem.NatCode,  
  
		EmpDate = inputItem.EmpDate,  
  
		CostCenter = inputItem.CostCenter,  
  
		WorkLoc = inputItem.WorkLoc,  
  
		Job = inputItem.Job, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRelsAppl Map(AddUsrPersHrmRelsApplCommand inputItem)
        {
            var entity = new UsrPersHrmRelsAppl() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Cause = inputItem.Cause,  
  
		LttrNo = inputItem.LttrNo,  
  
		LttrDate = inputItem.LttrDate,  
  
		Appler = inputItem.Appler,  
  
		Oprs = inputItem.Oprs, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRelsAppl Map(UsrPersHrmRelsAppl entity ,EditUsrPersHrmRelsApplCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Cause = inputItem.Cause;  
  
		entity.LttrNo = inputItem.LttrNo;  
  
		entity.LttrDate = inputItem.LttrDate;  
  
		entity.Appler = inputItem.Appler;  
  
		entity.Oprs = inputItem.Oprs; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsApplDto Map(UsrPersHrmRelsAppl inputItem)
        {
            var dto = new UsrPersHrmRelsApplDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Cause = inputItem.Cause,  
  
		LttrNo = inputItem.LttrNo,  
  
		LttrDate = inputItem.LttrDate,  
  
		Appler = inputItem.Appler,  
  
		Oprs = inputItem.Oprs, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsApplDto> Map(ICollection<UsrPersHrmRelsAppl> entities)
        {
            var dtos = new List<UsrPersHrmRelsApplDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsApplDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Cause = inputItem.Cause,  
  
		LttrNo = inputItem.LttrNo,  
  
		LttrDate = inputItem.LttrDate,  
  
		Appler = inputItem.Appler,  
  
		Oprs = inputItem.Oprs, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRelsCons Map(AddUsrPersHrmRelsConsCommand inputItem)
        {
            var entity = new UsrPersHrmRelsCons() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		LttrNo = inputItem.LttrNo,  
  
		DefDate = inputItem.DefDate,  
  
		Reason = inputItem.Reason,  
  
		Conser = inputItem.Conser,  
  
		DefQty = inputItem.DefQty,  
  
		SessionQty = inputItem.SessionQty,  
  
		Center = inputItem.Center, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRelsCons Map(UsrPersHrmRelsCons entity ,EditUsrPersHrmRelsConsCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Relation = inputItem.Relation;  
  
		entity.LttrNo = inputItem.LttrNo;  
  
		entity.DefDate = inputItem.DefDate;  
  
		entity.Reason = inputItem.Reason;  
  
		entity.Conser = inputItem.Conser;  
  
		entity.DefQty = inputItem.DefQty;  
  
		entity.SessionQty = inputItem.SessionQty;  
  
		entity.Center = inputItem.Center; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsConsDto Map(UsrPersHrmRelsCons inputItem)
        {
            var dto = new UsrPersHrmRelsConsDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		LttrNo = inputItem.LttrNo,  
  
		DefDate = inputItem.DefDate,  
  
		Reason = inputItem.Reason,  
  
		Conser = inputItem.Conser,  
  
		DefQty = inputItem.DefQty,  
  
		SessionQty = inputItem.SessionQty,  
  
		Center = inputItem.Center, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsConsDto> Map(ICollection<UsrPersHrmRelsCons> entities)
        {
            var dtos = new List<UsrPersHrmRelsConsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsConsDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		LttrNo = inputItem.LttrNo,  
  
		DefDate = inputItem.DefDate,  
  
		Reason = inputItem.Reason,  
  
		Conser = inputItem.Conser,  
  
		DefQty = inputItem.DefQty,  
  
		SessionQty = inputItem.SessionQty,  
  
		Center = inputItem.Center, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRelsDoc Map(AddUsrPersHrmRelsDocCommand inputItem)
        {
            var entity = new UsrPersHrmRelsDoc() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		TestDate = inputItem.TestDate,  
  
		Result = inputItem.Result,  
  
		NextDate = inputItem.NextDate,  
  
		City = inputItem.City,  
  
		JobType = inputItem.JobType,  
  
		Descr = inputItem.Descr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRelsDoc Map(UsrPersHrmRelsDoc entity ,EditUsrPersHrmRelsDocCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.TestDate = inputItem.TestDate;  
  
		entity.Result = inputItem.Result;  
  
		entity.NextDate = inputItem.NextDate;  
  
		entity.City = inputItem.City;  
  
		entity.JobType = inputItem.JobType;  
  
		entity.Descr = inputItem.Descr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsDocDto Map(UsrPersHrmRelsDoc inputItem)
        {
            var dto = new UsrPersHrmRelsDocDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		TestDate = inputItem.TestDate,  
  
		Result = inputItem.Result,  
  
		NextDate = inputItem.NextDate,  
  
		City = inputItem.City,  
  
		JobType = inputItem.JobType,  
  
		Descr = inputItem.Descr, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsDocDto> Map(ICollection<UsrPersHrmRelsDoc> entities)
        {
            var dtos = new List<UsrPersHrmRelsDocDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsDocDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		TestDate = inputItem.TestDate,  
  
		Result = inputItem.Result,  
  
		NextDate = inputItem.NextDate,  
  
		City = inputItem.City,  
  
		JobType = inputItem.JobType,  
  
		Descr = inputItem.Descr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRelsKigr Map(AddUsrPersHrmRelsKigrCommand inputItem)
        {
            var entity = new UsrPersHrmRelsKigr() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRelsKigr Map(UsrPersHrmRelsKigr entity ,EditUsrPersHrmRelsKigrCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.MonthYear = inputItem.MonthYear;  
  
		entity.Amount = inputItem.Amount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsKigrDto Map(UsrPersHrmRelsKigr inputItem)
        {
            var dto = new UsrPersHrmRelsKigrDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsKigrDto> Map(ICollection<UsrPersHrmRelsKigr> entities)
        {
            var dtos = new List<UsrPersHrmRelsKigrDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsKigrDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrPersHrmRelsRehab Map(AddUsrPersHrmRelsRehabCommand inputItem)
        {
            var entity = new UsrPersHrmRelsRehab() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		TDisease = inputItem.TDisease,  
  
		BDate = inputItem.BDate,  
  
		Sick = inputItem.Sick,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrPersHrmRelsRehab Map(UsrPersHrmRelsRehab entity ,EditUsrPersHrmRelsRehabCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Relation = inputItem.Relation;  
  
		entity.TDisease = inputItem.TDisease;  
  
		entity.BDate = inputItem.BDate;  
  
		entity.Sick = inputItem.Sick;  
  
		entity.MonthYear = inputItem.MonthYear;  
  
		entity.Amount = inputItem.Amount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrPersHrmRelsRehabDto Map(UsrPersHrmRelsRehab inputItem)
        {
            var dto = new UsrPersHrmRelsRehabDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		TDisease = inputItem.TDisease,  
  
		BDate = inputItem.BDate,  
  
		Sick = inputItem.Sick,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
            };
            return dto;
        }

        public static List<UsrPersHrmRelsRehabDto> Map(ICollection<UsrPersHrmRelsRehab> entities)
        {
            var dtos = new List<UsrPersHrmRelsRehabDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrPersHrmRelsRehabDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Relation = inputItem.Relation,  
  
		TDisease = inputItem.TDisease,  
  
		BDate = inputItem.BDate,  
  
		Sick = inputItem.Sick,  
  
		MonthYear = inputItem.MonthYear,  
  
		Amount = inputItem.Amount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdCost Map(AddUsrProdCostCommand inputItem)
        {
            var entity = new UsrProdCost() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		CostAmnt = inputItem.CostAmnt, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdCost Map(UsrProdCost entity ,EditUsrProdCostCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.CostRef = inputItem.CostRef;  
  
		entity.CostAmnt = inputItem.CostAmnt; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdCostDto Map(UsrProdCost inputItem)
        {
            var dto = new UsrProdCostDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		CostAmnt = inputItem.CostAmnt, 
            };
            return dto;
        }

        public static List<UsrProdCostDto> Map(ICollection<UsrProdCost> entities)
        {
            var dtos = new List<UsrProdCostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdCostDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		CostAmnt = inputItem.CostAmnt, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdExt Map(AddUsrProdExtCommand inputItem)
        {
            var entity = new UsrProdExt() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		RcvCostCntr = inputItem.RcvCostCntr,  
  
		OutPart = inputItem.OutPart,  
  
		OutQty = inputItem.OutQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdExt Map(UsrProdExt entity ,EditUsrProdExtCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.RcvCostCntr = inputItem.RcvCostCntr;  
  
		entity.OutPart = inputItem.OutPart;  
  
		entity.OutQty = inputItem.OutQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdExtDto Map(UsrProdExt inputItem)
        {
            var dto = new UsrProdExtDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		RcvCostCntr = inputItem.RcvCostCntr,  
  
		OutPart = inputItem.OutPart,  
  
		OutQty = inputItem.OutQty, 
            };
            return dto;
        }

        public static List<UsrProdExtDto> Map(ICollection<UsrProdExt> entities)
        {
            var dtos = new List<UsrProdExtDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdExtDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		RcvCostCntr = inputItem.RcvCostCntr,  
  
		OutPart = inputItem.OutPart,  
  
		OutQty = inputItem.OutQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdRcv Map(AddUsrProdRcvCommand inputItem)
        {
            var entity = new UsrProdRcv() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		PartRef = inputItem.PartRef,  
  
		Qty = inputItem.Qty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdRcv Map(UsrProdRcv entity ,EditUsrProdRcvCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.CostRef = inputItem.CostRef;  
  
		entity.PartRef = inputItem.PartRef;  
  
		entity.Qty = inputItem.Qty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdRcvDto Map(UsrProdRcv inputItem)
        {
            var dto = new UsrProdRcvDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		PartRef = inputItem.PartRef,  
  
		Qty = inputItem.Qty, 
            };
            return dto;
        }

        public static List<UsrProdRcvDto> Map(ICollection<UsrProdRcv> entities)
        {
            var dtos = new List<UsrProdRcvDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdRcvDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		CostRef = inputItem.CostRef,  
  
		PartRef = inputItem.PartRef,  
  
		Qty = inputItem.Qty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdRes Map(AddUsrProdResCommand inputItem)
        {
            var entity = new UsrProdRes() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ProdRef = inputItem.ProdRef,  
  
		ProdQty = inputItem.ProdQty,  
  
		FlaseQty = inputItem.FlaseQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdRes Map(UsrProdRes entity ,EditUsrProdResCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.ProdRef = inputItem.ProdRef;  
  
		entity.ProdQty = inputItem.ProdQty;  
  
		entity.FlaseQty = inputItem.FlaseQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdResDto Map(UsrProdRes inputItem)
        {
            var dto = new UsrProdResDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ProdRef = inputItem.ProdRef,  
  
		ProdQty = inputItem.ProdQty,  
  
		FlaseQty = inputItem.FlaseQty, 
            };
            return dto;
        }

        public static List<UsrProdResDto> Map(ICollection<UsrProdRes> entities)
        {
            var dtos = new List<UsrProdResDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdResDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ProdRef = inputItem.ProdRef,  
  
		ProdQty = inputItem.ProdQty,  
  
		FlaseQty = inputItem.FlaseQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdVch Map(AddUsrProdVchCommand inputItem)
        {
            var entity = new UsrProdVch() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Dater = inputItem.Dater,  
  
		CostRef = inputItem.CostRef,  
  
		Descr = inputItem.Descr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdVch Map(UsrProdVch entity ,EditUsrProdVchCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Dater = inputItem.Dater;  
  
		entity.CostRef = inputItem.CostRef;  
  
		entity.Descr = inputItem.Descr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdVchDto Map(UsrProdVch inputItem)
        {
            var dto = new UsrProdVchDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Dater = inputItem.Dater,  
  
		CostRef = inputItem.CostRef,  
  
		Descr = inputItem.Descr, 
            };
            return dto;
        }

        public static List<UsrProdVchDto> Map(ICollection<UsrProdVch> entities)
        {
            var dtos = new List<UsrProdVchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdVchDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Dater = inputItem.Dater,  
  
		CostRef = inputItem.CostRef,  
  
		Descr = inputItem.Descr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrProdWast Map(AddUsrProdWastCommand inputItem)
        {
            var entity = new UsrProdWast() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		WastPart = inputItem.WastPart,  
  
		WastQty = inputItem.WastQty, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrProdWast Map(UsrProdWast entity ,EditUsrProdWastCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.WastPart = inputItem.WastPart;  
  
		entity.WastQty = inputItem.WastQty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrProdWastDto Map(UsrProdWast inputItem)
        {
            var dto = new UsrProdWastDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		WastPart = inputItem.WastPart,  
  
		WastQty = inputItem.WastQty, 
            };
            return dto;
        }

        public static List<UsrProdWastDto> Map(ICollection<UsrProdWast> entities)
        {
            var dtos = new List<UsrProdWastDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrProdWastDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		WastPart = inputItem.WastPart,  
  
		WastQty = inputItem.WastQty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrRqstVac Map(AddUsrRqstVacCommand inputItem)
        {
            var entity = new UsrRqstVac() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FDate = inputItem.FDate,  
  
		TDate = inputItem.TDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrRqstVac Map(UsrRqstVac entity ,EditUsrRqstVacCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.FDate = inputItem.FDate;  
  
		entity.TDate = inputItem.TDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrRqstVacDto Map(UsrRqstVac inputItem)
        {
            var dto = new UsrRqstVacDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FDate = inputItem.FDate,  
  
		TDate = inputItem.TDate, 
            };
            return dto;
        }

        public static List<UsrRqstVacDto> Map(ICollection<UsrRqstVac> entities)
        {
            var dtos = new List<UsrRqstVacDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrRqstVacDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FDate = inputItem.FDate,  
  
		TDate = inputItem.TDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrTest1 Map(AddUsrTest1Command inputItem)
        {
            var entity = new UsrTest1() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrTest1 Map(UsrTest1 entity ,EditUsrTest1Command inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.VNo = inputItem.VNo; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrTest1Dto Map(UsrTest1 inputItem)
        {
            var dto = new UsrTest1Dto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo, 
            };
            return dto;
        }

        public static List<UsrTest1Dto> Map(ICollection<UsrTest1> entities)
        {
            var dtos = new List<UsrTest1Dto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrTest1Dto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		VNo = inputItem.VNo, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrTestForm Map(AddUsrTestFormCommand inputItem)
        {
            var entity = new UsrTestForm() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FName = inputItem.FName,  
  
		LName = inputItem.LName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrTestForm Map(UsrTestForm entity ,EditUsrTestFormCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.FName = inputItem.FName;  
  
		entity.LName = inputItem.LName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrTestFormDto Map(UsrTestForm inputItem)
        {
            var dto = new UsrTestFormDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FName = inputItem.FName,  
  
		LName = inputItem.LName, 
            };
            return dto;
        }

        public static List<UsrTestFormDto> Map(ICollection<UsrTestForm> entities)
        {
            var dtos = new List<UsrTestFormDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrTestFormDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		FName = inputItem.FName,  
  
		LName = inputItem.LName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrTestGrid Map(AddUsrTestGridCommand inputItem)
        {
            var entity = new UsrTestGrid() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Code = inputItem.Code,  
  
		Num = inputItem.Num, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrTestGrid Map(UsrTestGrid entity ,EditUsrTestGridCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Code = inputItem.Code;  
  
		entity.Num = inputItem.Num; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrTestGridDto Map(UsrTestGrid inputItem)
        {
            var dto = new UsrTestGridDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Code = inputItem.Code,  
  
		Num = inputItem.Num, 
            };
            return dto;
        }

        public static List<UsrTestGridDto> Map(ICollection<UsrTestGrid> entities)
        {
            var dtos = new List<UsrTestGridDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrTestGridDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Code = inputItem.Code,  
  
		Num = inputItem.Num, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrTrsRqstBankInf Map(AddUsrTrsRqstBankInfCommand inputItem)
        {
            var entity = new UsrTrsRqstBankInf() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Shaba = inputItem.Shaba,  
  
		AcnNo = inputItem.AcnNo,  
  
		CartNo = inputItem.CartNo, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrTrsRqstBankInf Map(UsrTrsRqstBankInf entity ,EditUsrTrsRqstBankInfCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.Shaba = inputItem.Shaba;  
  
		entity.AcnNo = inputItem.AcnNo;  
  
		entity.CartNo = inputItem.CartNo; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrTrsRqstBankInfDto Map(UsrTrsRqstBankInf inputItem)
        {
            var dto = new UsrTrsRqstBankInfDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Shaba = inputItem.Shaba,  
  
		AcnNo = inputItem.AcnNo,  
  
		CartNo = inputItem.CartNo, 
            };
            return dto;
        }

        public static List<UsrTrsRqstBankInfDto> Map(ICollection<UsrTrsRqstBankInf> entities)
        {
            var dtos = new List<UsrTrsRqstBankInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrTrsRqstBankInfDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		Shaba = inputItem.Shaba,  
  
		AcnNo = inputItem.AcnNo,  
  
		CartNo = inputItem.CartNo, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsrvchBaseInfo Map(AddUsrvchBaseInfoCommand inputItem)
        {
            var entity = new UsrvchBaseInfo() {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ReqUser = inputItem.ReqUser,  
  
		Stp1 = inputItem.Stp1,  
  
		Step2 = inputItem.Step2,  
  
		Descr = inputItem.Descr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsrvchBaseInfo Map(UsrvchBaseInfo entity ,EditUsrvchBaseInfoCommand inputItem)
        {
              
  
		entity.ParentId = inputItem.ParentId;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.Confimer = inputItem.Confimer;  
  
		entity.State = inputItem.State;  
  
		entity.ReqUser = inputItem.ReqUser;  
  
		entity.Stp1 = inputItem.Stp1;  
  
		entity.Step2 = inputItem.Step2;  
  
		entity.Descr = inputItem.Descr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsrvchBaseInfoDto Map(UsrvchBaseInfo inputItem)
        {
            var dto = new UsrvchBaseInfoDto()
            {
                  
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ReqUser = inputItem.ReqUser,  
  
		Stp1 = inputItem.Stp1,  
  
		Step2 = inputItem.Step2,  
  
		Descr = inputItem.Descr, 
            };
            return dto;
        }

        public static List<UsrvchBaseInfoDto> Map(ICollection<UsrvchBaseInfo> entities)
        {
            var dtos = new List<UsrvchBaseInfoDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsrvchBaseInfoDto()
                {
                      
  
		ParentId = inputItem.ParentId,  
  
		Creator = inputItem.Creator,  
  
		Confimer = inputItem.Confimer,  
  
		State = inputItem.State,  
  
		ReqUser = inputItem.ReqUser,  
  
		Stp1 = inputItem.Stp1,  
  
		Step2 = inputItem.Step2,  
  
		Descr = inputItem.Descr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserAccess Map(AddUserAccessCommand inputItem)
        {
            var entity = new UserAccess() {
                  
  
		UsrAccId = inputItem.UsrAccId,  
  
		UserRef = inputItem.UserRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserAccess Map(UserAccess entity ,EditUserAccessCommand inputItem)
        {
              
  
		entity.UsrAccId = inputItem.UsrAccId;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.AccessName = inputItem.AccessName;  
  
		entity.Rights = inputItem.Rights; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserAccessDto Map(UserAccess inputItem)
        {
            var dto = new UserAccessDto()
            {
                  
  
		UsrAccId = inputItem.UsrAccId,  
  
		UserRef = inputItem.UserRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
            };
            return dto;
        }

        public static List<UserAccessDto> Map(ICollection<UserAccess> entities)
        {
            var dtos = new List<UserAccessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserAccessDto()
                {
                      
  
		UsrAccId = inputItem.UsrAccId,  
  
		UserRef = inputItem.UserRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserAlternative Map(AddUserAlternativeCommand inputItem)
        {
            var entity = new UserAlternative() {
                  
  
		MainUserRef = inputItem.MainUserRef,  
  
		AlterUserRef = inputItem.AlterUserRef,  
  
		OrderInd = inputItem.OrderInd, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserAlternative Map(UserAlternative entity ,EditUserAlternativeCommand inputItem)
        {
              
  
		entity.MainUserRef = inputItem.MainUserRef;  
  
		entity.AlterUserRef = inputItem.AlterUserRef;  
  
		entity.OrderInd = inputItem.OrderInd; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserAlternativeDto Map(UserAlternative inputItem)
        {
            var dto = new UserAlternativeDto()
            {
                  
  
		MainUserRef = inputItem.MainUserRef,  
  
		AlterUserRef = inputItem.AlterUserRef,  
  
		OrderInd = inputItem.OrderInd, 
            };
            return dto;
        }

        public static List<UserAlternativeDto> Map(ICollection<UserAlternative> entities)
        {
            var dtos = new List<UserAlternativeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserAlternativeDto()
                {
                      
  
		MainUserRef = inputItem.MainUserRef,  
  
		AlterUserRef = inputItem.AlterUserRef,  
  
		OrderInd = inputItem.OrderInd, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserArchive Map(AddUserArchiveCommand inputItem)
        {
            var entity = new UserArchive() {
                  
  
		UserArchiveId = inputItem.UserArchiveId,  
  
		UATypeRef = inputItem.UATypeRef,  
  
		UADescr = inputItem.UADescr,  
  
		UAFileName = inputItem.UAFileName,  
  
		UAData = inputItem.UAData, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserArchive Map(UserArchive entity ,EditUserArchiveCommand inputItem)
        {
              
  
		entity.UserArchiveId = inputItem.UserArchiveId;  
  
		entity.UATypeRef = inputItem.UATypeRef;  
  
		entity.UADescr = inputItem.UADescr;  
  
		entity.UAFileName = inputItem.UAFileName;  
  
		entity.UAData = inputItem.UAData; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserArchiveDto Map(UserArchive inputItem)
        {
            var dto = new UserArchiveDto()
            {
                  
  
		UserArchiveId = inputItem.UserArchiveId,  
  
		UATypeRef = inputItem.UATypeRef,  
  
		UADescr = inputItem.UADescr,  
  
		UAFileName = inputItem.UAFileName,  
  
		UAData = inputItem.UAData, 
            };
            return dto;
        }

        public static List<UserArchiveDto> Map(ICollection<UserArchive> entities)
        {
            var dtos = new List<UserArchiveDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserArchiveDto()
                {
                      
  
		UserArchiveId = inputItem.UserArchiveId,  
  
		UATypeRef = inputItem.UATypeRef,  
  
		UADescr = inputItem.UADescr,  
  
		UAFileName = inputItem.UAFileName,  
  
		UAData = inputItem.UAData, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserArchType Map(AddUserArchTypeCommand inputItem)
        {
            var entity = new UserArchType() {
                  
  
		UserArchTypeId = inputItem.UserArchTypeId,  
  
		UATUsrRef = inputItem.UATUsrRef,  
  
		UATTitle = inputItem.UATTitle,  
  
		UATParent = inputItem.UATParent, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserArchType Map(UserArchType entity ,EditUserArchTypeCommand inputItem)
        {
              
  
		entity.UserArchTypeId = inputItem.UserArchTypeId;  
  
		entity.UATUsrRef = inputItem.UATUsrRef;  
  
		entity.UATTitle = inputItem.UATTitle;  
  
		entity.UATParent = inputItem.UATParent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserArchTypeDto Map(UserArchType inputItem)
        {
            var dto = new UserArchTypeDto()
            {
                  
  
		UserArchTypeId = inputItem.UserArchTypeId,  
  
		UATUsrRef = inputItem.UATUsrRef,  
  
		UATTitle = inputItem.UATTitle,  
  
		UATParent = inputItem.UATParent, 
            };
            return dto;
        }

        public static List<UserArchTypeDto> Map(ICollection<UserArchType> entities)
        {
            var dtos = new List<UserArchTypeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserArchTypeDto()
                {
                      
  
		UserArchTypeId = inputItem.UserArchTypeId,  
  
		UATUsrRef = inputItem.UATUsrRef,  
  
		UATTitle = inputItem.UATTitle,  
  
		UATParent = inputItem.UATParent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserPlaning Map(AddUserPlaningCommand inputItem)
        {
            var entity = new UserPlaning() {
                  
  
		UserPlaningId = inputItem.UserPlaningId,  
  
		UPDescr = inputItem.UPDescr,  
  
		UPCreator = inputItem.UPCreator,  
  
		UPStartDate = inputItem.UPStartDate,  
  
		UPStartTime = inputItem.UPStartTime,  
  
		UPRepeat = inputItem.UPRepeat,  
  
		UPEndDate = inputItem.UPEndDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserPlaning Map(UserPlaning entity ,EditUserPlaningCommand inputItem)
        {
              
  
		entity.UserPlaningId = inputItem.UserPlaningId;  
  
		entity.UPDescr = inputItem.UPDescr;  
  
		entity.UPCreator = inputItem.UPCreator;  
  
		entity.UPStartDate = inputItem.UPStartDate;  
  
		entity.UPStartTime = inputItem.UPStartTime;  
  
		entity.UPRepeat = inputItem.UPRepeat;  
  
		entity.UPEndDate = inputItem.UPEndDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserPlaningDto Map(UserPlaning inputItem)
        {
            var dto = new UserPlaningDto()
            {
                  
  
		UserPlaningId = inputItem.UserPlaningId,  
  
		UPDescr = inputItem.UPDescr,  
  
		UPCreator = inputItem.UPCreator,  
  
		UPStartDate = inputItem.UPStartDate,  
  
		UPStartTime = inputItem.UPStartTime,  
  
		UPRepeat = inputItem.UPRepeat,  
  
		UPEndDate = inputItem.UPEndDate, 
            };
            return dto;
        }

        public static List<UserPlaningDto> Map(ICollection<UserPlaning> entities)
        {
            var dtos = new List<UserPlaningDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserPlaningDto()
                {
                      
  
		UserPlaningId = inputItem.UserPlaningId,  
  
		UPDescr = inputItem.UPDescr,  
  
		UPCreator = inputItem.UPCreator,  
  
		UPStartDate = inputItem.UPStartDate,  
  
		UPStartTime = inputItem.UPStartTime,  
  
		UPRepeat = inputItem.UPRepeat,  
  
		UPEndDate = inputItem.UPEndDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserPlaningDet Map(AddUserPlaningDetCommand inputItem)
        {
            var entity = new UserPlaningDet() {
                  
  
		UserPlaningDetId = inputItem.UserPlaningDetId,  
  
		UPDPlanRef = inputItem.UPDPlanRef,  
  
		UPDUserRef = inputItem.UPDUserRef,  
  
		UPDDescr = inputItem.UPDDescr,  
  
		UPDEndDate = inputItem.UPDEndDate,  
  
		UPDProgress = inputItem.UPDProgress, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserPlaningDet Map(UserPlaningDet entity ,EditUserPlaningDetCommand inputItem)
        {
              
  
		entity.UserPlaningDetId = inputItem.UserPlaningDetId;  
  
		entity.UPDPlanRef = inputItem.UPDPlanRef;  
  
		entity.UPDUserRef = inputItem.UPDUserRef;  
  
		entity.UPDDescr = inputItem.UPDDescr;  
  
		entity.UPDEndDate = inputItem.UPDEndDate;  
  
		entity.UPDProgress = inputItem.UPDProgress; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserPlaningDetDto Map(UserPlaningDet inputItem)
        {
            var dto = new UserPlaningDetDto()
            {
                  
  
		UserPlaningDetId = inputItem.UserPlaningDetId,  
  
		UPDPlanRef = inputItem.UPDPlanRef,  
  
		UPDUserRef = inputItem.UPDUserRef,  
  
		UPDDescr = inputItem.UPDDescr,  
  
		UPDEndDate = inputItem.UPDEndDate,  
  
		UPDProgress = inputItem.UPDProgress, 
            };
            return dto;
        }

        public static List<UserPlaningDetDto> Map(ICollection<UserPlaningDet> entities)
        {
            var dtos = new List<UserPlaningDetDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserPlaningDetDto()
                {
                      
  
		UserPlaningDetId = inputItem.UserPlaningDetId,  
  
		UPDPlanRef = inputItem.UPDPlanRef,  
  
		UPDUserRef = inputItem.UPDUserRef,  
  
		UPDDescr = inputItem.UPDDescr,  
  
		UPDEndDate = inputItem.UPDEndDate,  
  
		UPDProgress = inputItem.UPDProgress, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserPlaningDetInf Map(AddUserPlaningDetInfCommand inputItem)
        {
            var entity = new UserPlaningDetInf() {
                  
  
		UPDIItmRef = inputItem.UPDIItmRef,  
  
		UPDIDate = inputItem.UPDIDate,  
  
		UPDIDescr = inputItem.UPDIDescr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserPlaningDetInf Map(UserPlaningDetInf entity ,EditUserPlaningDetInfCommand inputItem)
        {
              
  
		entity.UPDIItmRef = inputItem.UPDIItmRef;  
  
		entity.UPDIDate = inputItem.UPDIDate;  
  
		entity.UPDIDescr = inputItem.UPDIDescr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserPlaningDetInfDto Map(UserPlaningDetInf inputItem)
        {
            var dto = new UserPlaningDetInfDto()
            {
                  
  
		UPDIItmRef = inputItem.UPDIItmRef,  
  
		UPDIDate = inputItem.UPDIDate,  
  
		UPDIDescr = inputItem.UPDIDescr, 
            };
            return dto;
        }

        public static List<UserPlaningDetInfDto> Map(ICollection<UserPlaningDetInf> entities)
        {
            var dtos = new List<UserPlaningDetInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserPlaningDetInfDto()
                {
                      
  
		UPDIItmRef = inputItem.UPDIItmRef,  
  
		UPDIDate = inputItem.UPDIDate,  
  
		UPDIDescr = inputItem.UPDIDescr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserProcess Map(AddUserProcessCommand inputItem)
        {
            var entity = new UserProcess() {
                  
  
		UserProcessId = inputItem.UserProcessId,  
  
		UPProcessRef = inputItem.UPProcessRef,  
  
		UPCrDate = inputItem.UPCrDate,  
  
		UPUserRef = inputItem.UPUserRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserProcess Map(UserProcess entity ,EditUserProcessCommand inputItem)
        {
              
  
		entity.UserProcessId = inputItem.UserProcessId;  
  
		entity.UPProcessRef = inputItem.UPProcessRef;  
  
		entity.UPCrDate = inputItem.UPCrDate;  
  
		entity.UPUserRef = inputItem.UPUserRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserProcessDto Map(UserProcess inputItem)
        {
            var dto = new UserProcessDto()
            {
                  
  
		UserProcessId = inputItem.UserProcessId,  
  
		UPProcessRef = inputItem.UPProcessRef,  
  
		UPCrDate = inputItem.UPCrDate,  
  
		UPUserRef = inputItem.UPUserRef, 
            };
            return dto;
        }

        public static List<UserProcessDto> Map(ICollection<UserProcess> entities)
        {
            var dtos = new List<UserProcessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserProcessDto()
                {
                      
  
		UserProcessId = inputItem.UserProcessId,  
  
		UPProcessRef = inputItem.UPProcessRef,  
  
		UPCrDate = inputItem.UPCrDate,  
  
		UPUserRef = inputItem.UPUserRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserProcessStp Map(AddUserProcessStpCommand inputItem)
        {
            var entity = new UserProcessStp() {
                  
  
		UserProcessStpId = inputItem.UserProcessStpId,  
  
		UPSHdrRef = inputItem.UPSHdrRef,  
  
		UPSStepRef = inputItem.UPSStepRef,  
  
		UPSUserRef = inputItem.UPSUserRef,  
  
		UPSRefId = inputItem.UPSRefId,  
  
		UPSCrDate = inputItem.UPSCrDate,  
  
		UPSShDate = inputItem.UPSShDate,  
  
		UPSEnDate = inputItem.UPSEnDate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserProcessStp Map(UserProcessStp entity ,EditUserProcessStpCommand inputItem)
        {
              
  
		entity.UserProcessStpId = inputItem.UserProcessStpId;  
  
		entity.UPSHdrRef = inputItem.UPSHdrRef;  
  
		entity.UPSStepRef = inputItem.UPSStepRef;  
  
		entity.UPSUserRef = inputItem.UPSUserRef;  
  
		entity.UPSRefId = inputItem.UPSRefId;  
  
		entity.UPSCrDate = inputItem.UPSCrDate;  
  
		entity.UPSShDate = inputItem.UPSShDate;  
  
		entity.UPSEnDate = inputItem.UPSEnDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserProcessStpDto Map(UserProcessStp inputItem)
        {
            var dto = new UserProcessStpDto()
            {
                  
  
		UserProcessStpId = inputItem.UserProcessStpId,  
  
		UPSHdrRef = inputItem.UPSHdrRef,  
  
		UPSStepRef = inputItem.UPSStepRef,  
  
		UPSUserRef = inputItem.UPSUserRef,  
  
		UPSRefId = inputItem.UPSRefId,  
  
		UPSCrDate = inputItem.UPSCrDate,  
  
		UPSShDate = inputItem.UPSShDate,  
  
		UPSEnDate = inputItem.UPSEnDate, 
            };
            return dto;
        }

        public static List<UserProcessStpDto> Map(ICollection<UserProcessStp> entities)
        {
            var dtos = new List<UserProcessStpDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserProcessStpDto()
                {
                      
  
		UserProcessStpId = inputItem.UserProcessStpId,  
  
		UPSHdrRef = inputItem.UPSHdrRef,  
  
		UPSStepRef = inputItem.UPSStepRef,  
  
		UPSUserRef = inputItem.UPSUserRef,  
  
		UPSRefId = inputItem.UPSRefId,  
  
		UPSCrDate = inputItem.UPSCrDate,  
  
		UPSShDate = inputItem.UPSShDate,  
  
		UPSEnDate = inputItem.UPSEnDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserRepAccess Map(AddUserRepAccessCommand inputItem)
        {
            var entity = new UserRepAccess() {
                  
  
		UserRef = inputItem.UserRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserRepAccess Map(UserRepAccess entity ,EditUserRepAccessCommand inputItem)
        {
              
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.ReportRef = inputItem.ReportRef;  
  
		entity.Access = inputItem.Access; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserRepAccessDto Map(UserRepAccess inputItem)
        {
            var dto = new UserRepAccessDto()
            {
                  
  
		UserRef = inputItem.UserRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
            };
            return dto;
        }

        public static List<UserRepAccessDto> Map(ICollection<UserRepAccess> entities)
        {
            var dtos = new List<UserRepAccessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserRepAccessDto()
                {
                      
  
		UserRef = inputItem.UserRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Users Map(AddUsersCommand inputItem)
        {
            var entity = new Users() {
                  
  
		UserId = inputItem.UserId,  
  
		UserName = inputItem.UserName,  
  
		UserPass = inputItem.UserPass,  
  
		UserGroupRef = inputItem.UserGroupRef,  
  
		UserSign = inputItem.UserSign,  
  
		UserState = inputItem.UserState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Users Map(Users entity ,EditUsersCommand inputItem)
        {
              
  
		entity.UserId = inputItem.UserId;  
  
		entity.UserName = inputItem.UserName;  
  
		entity.UserPass = inputItem.UserPass;  
  
		entity.UserGroupRef = inputItem.UserGroupRef;  
  
		entity.UserSign = inputItem.UserSign;  
  
		entity.UserState = inputItem.UserState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsersDto Map(Users inputItem)
        {
            var dto = new UsersDto()
            {
                  
  
		UserId = inputItem.UserId,  
  
		UserName = inputItem.UserName,  
  
		UserPass = inputItem.UserPass,  
  
		UserGroupRef = inputItem.UserGroupRef,  
  
		UserSign = inputItem.UserSign,  
  
		UserState = inputItem.UserState, 
            };
            return dto;
        }

        public static List<UsersDto> Map(ICollection<Users> entities)
        {
            var dtos = new List<UsersDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsersDto()
                {
                      
  
		UserId = inputItem.UserId,  
  
		UserName = inputItem.UserName,  
  
		UserPass = inputItem.UserPass,  
  
		UserGroupRef = inputItem.UserGroupRef,  
  
		UserSign = inputItem.UserSign,  
  
		UserState = inputItem.UserState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserSignRight Map(AddUserSignRightCommand inputItem)
        {
            var entity = new UserSignRight() {
                  
  
		UserSignRightId = inputItem.UserSignRightId,  
  
		USRUserRef = inputItem.USRUserRef,  
  
		USRToUser = inputItem.USRToUser,  
  
		USRAccess = inputItem.USRAccess, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserSignRight Map(UserSignRight entity ,EditUserSignRightCommand inputItem)
        {
              
  
		entity.UserSignRightId = inputItem.UserSignRightId;  
  
		entity.USRUserRef = inputItem.USRUserRef;  
  
		entity.USRToUser = inputItem.USRToUser;  
  
		entity.USRAccess = inputItem.USRAccess; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserSignRightDto Map(UserSignRight inputItem)
        {
            var dto = new UserSignRightDto()
            {
                  
  
		UserSignRightId = inputItem.UserSignRightId,  
  
		USRUserRef = inputItem.USRUserRef,  
  
		USRToUser = inputItem.USRToUser,  
  
		USRAccess = inputItem.USRAccess, 
            };
            return dto;
        }

        public static List<UserSignRightDto> Map(ICollection<UserSignRight> entities)
        {
            var dtos = new List<UserSignRightDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserSignRightDto()
                {
                      
  
		UserSignRightId = inputItem.UserSignRightId,  
  
		USRUserRef = inputItem.USRUserRef,  
  
		USRToUser = inputItem.USRToUser,  
  
		USRAccess = inputItem.USRAccess, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsersRels Map(AddUsersRelsCommand inputItem)
        {
            var entity = new UsersRels() {
                  
  
		MainUser = inputItem.MainUser,  
  
		RelUser = inputItem.RelUser, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsersRels Map(UsersRels entity ,EditUsersRelsCommand inputItem)
        {
              
  
		entity.MainUser = inputItem.MainUser;  
  
		entity.RelUser = inputItem.RelUser; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsersRelsDto Map(UsersRels inputItem)
        {
            var dto = new UsersRelsDto()
            {
                  
  
		MainUser = inputItem.MainUser,  
  
		RelUser = inputItem.RelUser, 
            };
            return dto;
        }

        public static List<UsersRelsDto> Map(ICollection<UsersRels> entities)
        {
            var dtos = new List<UsersRelsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsersRelsDto()
                {
                      
  
		MainUser = inputItem.MainUser,  
  
		RelUser = inputItem.RelUser, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsGroupAccess Map(AddUsGroupAccessCommand inputItem)
        {
            var entity = new UsGroupAccess() {
                  
  
		UsGrpAccId = inputItem.UsGrpAccId,  
  
		GroupRef = inputItem.GroupRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsGroupAccess Map(UsGroupAccess entity ,EditUsGroupAccessCommand inputItem)
        {
              
  
		entity.UsGrpAccId = inputItem.UsGrpAccId;  
  
		entity.GroupRef = inputItem.GroupRef;  
  
		entity.AccessName = inputItem.AccessName;  
  
		entity.Rights = inputItem.Rights; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsGroupAccessDto Map(UsGroupAccess inputItem)
        {
            var dto = new UsGroupAccessDto()
            {
                  
  
		UsGrpAccId = inputItem.UsGrpAccId,  
  
		GroupRef = inputItem.GroupRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
            };
            return dto;
        }

        public static List<UsGroupAccessDto> Map(ICollection<UsGroupAccess> entities)
        {
            var dtos = new List<UsGroupAccessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsGroupAccessDto()
                {
                      
  
		UsGrpAccId = inputItem.UsGrpAccId,  
  
		GroupRef = inputItem.GroupRef,  
  
		AccessName = inputItem.AccessName,  
  
		Rights = inputItem.Rights, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsGroupRepAccess Map(AddUsGroupRepAccessCommand inputItem)
        {
            var entity = new UsGroupRepAccess() {
                  
  
		GroupRef = inputItem.GroupRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsGroupRepAccess Map(UsGroupRepAccess entity ,EditUsGroupRepAccessCommand inputItem)
        {
              
  
		entity.GroupRef = inputItem.GroupRef;  
  
		entity.ReportRef = inputItem.ReportRef;  
  
		entity.Access = inputItem.Access; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsGroupRepAccessDto Map(UsGroupRepAccess inputItem)
        {
            var dto = new UsGroupRepAccessDto()
            {
                  
  
		GroupRef = inputItem.GroupRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
            };
            return dto;
        }

        public static List<UsGroupRepAccessDto> Map(ICollection<UsGroupRepAccess> entities)
        {
            var dtos = new List<UsGroupRepAccessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsGroupRepAccessDto()
                {
                      
  
		GroupRef = inputItem.GroupRef,  
  
		ReportRef = inputItem.ReportRef,  
  
		Access = inputItem.Access, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UsGroups Map(AddUsGroupsCommand inputItem)
        {
            var entity = new UsGroups() {
                  
  
		UsGroupId = inputItem.UsGroupId,  
  
		UsGroupTitle = inputItem.UsGroupTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UsGroups Map(UsGroups entity ,EditUsGroupsCommand inputItem)
        {
              
  
		entity.UsGroupId = inputItem.UsGroupId;  
  
		entity.UsGroupTitle = inputItem.UsGroupTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UsGroupsDto Map(UsGroups inputItem)
        {
            var dto = new UsGroupsDto()
            {
                  
  
		UsGroupId = inputItem.UsGroupId,  
  
		UsGroupTitle = inputItem.UsGroupTitle, 
            };
            return dto;
        }

        public static List<UsGroupsDto> Map(ICollection<UsGroups> entities)
        {
            var dtos = new List<UsGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UsGroupsDto()
                {
                      
  
		UsGroupId = inputItem.UsGroupId,  
  
		UsGroupTitle = inputItem.UsGroupTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
