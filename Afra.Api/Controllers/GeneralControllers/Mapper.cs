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
                
        
        public static Address Map(AddAddressCommand inputItem)
        {
            var entity = new Address() {
                  
  
		AddressId = inputItem.AddressId,  
  
		AdCrsRef = inputItem.AdCrsRef,  
  
		AdGeoRef = inputItem.AdGeoRef,  
  
		AdDescr = inputItem.AdDescr,  
  
		AdPhone1 = inputItem.AdPhone1,  
  
		AdPhone2 = inputItem.AdPhone2,  
  
		AdMobile = inputItem.AdMobile,  
  
		AdFax = inputItem.AdFax,  
  
		AdPostCode = inputItem.AdPostCode,  
  
		AdEMail = inputItem.AdEMail, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Address Map(Address entity ,EditAddressCommand inputItem)
        {
              
  
		entity.AddressId = inputItem.AddressId;  
  
		entity.AdCrsRef = inputItem.AdCrsRef;  
  
		entity.AdGeoRef = inputItem.AdGeoRef;  
  
		entity.AdDescr = inputItem.AdDescr;  
  
		entity.AdPhone1 = inputItem.AdPhone1;  
  
		entity.AdPhone2 = inputItem.AdPhone2;  
  
		entity.AdMobile = inputItem.AdMobile;  
  
		entity.AdFax = inputItem.AdFax;  
  
		entity.AdPostCode = inputItem.AdPostCode;  
  
		entity.AdEMail = inputItem.AdEMail; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AddressDto Map(Address inputItem)
        {
            var dto = new AddressDto()
            {
                  
  
		AddressId = inputItem.AddressId,  
  
		AdCrsRef = inputItem.AdCrsRef,  
  
		AdGeoRef = inputItem.AdGeoRef,  
  
		AdDescr = inputItem.AdDescr,  
  
		AdPhone1 = inputItem.AdPhone1,  
  
		AdPhone2 = inputItem.AdPhone2,  
  
		AdMobile = inputItem.AdMobile,  
  
		AdFax = inputItem.AdFax,  
  
		AdPostCode = inputItem.AdPostCode,  
  
		AdEMail = inputItem.AdEMail, 
            };
            return dto;
        }

        public static List<AddressDto> Map(ICollection<Address> entities)
        {
            var dtos = new List<AddressDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AddressDto()
                {
                      
  
		AddressId = inputItem.AddressId,  
  
		AdCrsRef = inputItem.AdCrsRef,  
  
		AdGeoRef = inputItem.AdGeoRef,  
  
		AdDescr = inputItem.AdDescr,  
  
		AdPhone1 = inputItem.AdPhone1,  
  
		AdPhone2 = inputItem.AdPhone2,  
  
		AdMobile = inputItem.AdMobile,  
  
		AdFax = inputItem.AdFax,  
  
		AdPostCode = inputItem.AdPostCode,  
  
		AdEMail = inputItem.AdEMail, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Crspnds Map(AddCrspndsCommand inputItem)
        {
            var entity = new Crspnds() {
                  
  
		CrspndId = inputItem.CrspndId,  
  
		CrspndName = inputItem.CrspndName,  
  
		CrsDLRef = inputItem.CrsDLRef,  
  
		CrsType = inputItem.CrsType,  
  
		ECode = inputItem.ECode,  
  
		AcCtgry = inputItem.AcCtgry,  
  
		RegNo = inputItem.RegNo,  
  
		NatCode = inputItem.NatCode,  
  
		CrsTitle = inputItem.CrsTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Crspnds Map(Crspnds entity ,EditCrspndsCommand inputItem)
        {
              
  
		entity.CrspndId = inputItem.CrspndId;  
  
		entity.CrspndName = inputItem.CrspndName;  
  
		entity.CrsDLRef = inputItem.CrsDLRef;  
  
		entity.CrsType = inputItem.CrsType;  
  
		entity.ECode = inputItem.ECode;  
  
		entity.AcCtgry = inputItem.AcCtgry;  
  
		entity.RegNo = inputItem.RegNo;  
  
		entity.NatCode = inputItem.NatCode;  
  
		entity.CrsTitle = inputItem.CrsTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CrspndsDto Map(Crspnds inputItem)
        {
            var dto = new CrspndsDto()
            {
                  
  
		CrspndId = inputItem.CrspndId,  
  
		CrspndName = inputItem.CrspndName,  
  
		CrsDLRef = inputItem.CrsDLRef,  
  
		CrsType = inputItem.CrsType,  
  
		ECode = inputItem.ECode,  
  
		AcCtgry = inputItem.AcCtgry,  
  
		RegNo = inputItem.RegNo,  
  
		NatCode = inputItem.NatCode,  
  
		CrsTitle = inputItem.CrsTitle, 
            };
            return dto;
        }

        public static List<CrspndsDto> Map(ICollection<Crspnds> entities)
        {
            var dtos = new List<CrspndsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CrspndsDto()
                {
                      
  
		CrspndId = inputItem.CrspndId,  
  
		CrspndName = inputItem.CrspndName,  
  
		CrsDLRef = inputItem.CrsDLRef,  
  
		CrsType = inputItem.CrsType,  
  
		ECode = inputItem.ECode,  
  
		AcCtgry = inputItem.AcCtgry,  
  
		RegNo = inputItem.RegNo,  
  
		NatCode = inputItem.NatCode,  
  
		CrsTitle = inputItem.CrsTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Lookups Map(AddLookupsCommand inputItem)
        {
            var entity = new Lookups() {
                  
  
		LkpId = inputItem.LkpId,  
  
		LkpType = inputItem.LkpType,  
  
		LkpTitle = inputItem.LkpTitle,  
  
		LkpOrder = inputItem.LkpOrder, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Lookups Map(Lookups entity ,EditLookupsCommand inputItem)
        {
              
  
		entity.LkpId = inputItem.LkpId;  
  
		entity.LkpType = inputItem.LkpType;  
  
		entity.LkpTitle = inputItem.LkpTitle;  
  
		entity.LkpOrder = inputItem.LkpOrder; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LookupsDto Map(Lookups inputItem)
        {
            var dto = new LookupsDto()
            {
                  
  
		LkpId = inputItem.LkpId,  
  
		LkpType = inputItem.LkpType,  
  
		LkpTitle = inputItem.LkpTitle,  
  
		LkpOrder = inputItem.LkpOrder, 
            };
            return dto;
        }

        public static List<LookupsDto> Map(ICollection<Lookups> entities)
        {
            var dtos = new List<LookupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LookupsDto()
                {
                      
  
		LkpId = inputItem.LkpId,  
  
		LkpType = inputItem.LkpType,  
  
		LkpTitle = inputItem.LkpTitle,  
  
		LkpOrder = inputItem.LkpOrder, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Settings Map(AddSettingsCommand inputItem)
        {
            var entity = new Settings() {
                  
  
		SettingID = inputItem.SettingID,  
  
		StgValue = inputItem.StgValue, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Settings Map(Settings entity ,EditSettingsCommand inputItem)
        {
              
  
		entity.SettingID = inputItem.SettingID;  
  
		entity.StgValue = inputItem.StgValue; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SettingsDto Map(Settings inputItem)
        {
            var dto = new SettingsDto()
            {
                  
  
		SettingID = inputItem.SettingID,  
  
		StgValue = inputItem.StgValue, 
            };
            return dto;
        }

        public static List<SettingsDto> Map(ICollection<Settings> entities)
        {
            var dtos = new List<SettingsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SettingsDto()
                {
                      
  
		SettingID = inputItem.SettingID,  
  
		StgValue = inputItem.StgValue, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static sysdiagrams Map(AddsysdiagramsCommand inputItem)
        {
            var entity = new sysdiagrams() {
                  
  
		name = inputItem.name,  
  
		principal_id = inputItem.principal_id,  
  
		diagram_id = inputItem.diagram_id,  
  
		version = inputItem.version,  
  
		definition = inputItem.definition, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static sysdiagrams Map(sysdiagrams entity ,EditsysdiagramsCommand inputItem)
        {
              
  
		entity.name = inputItem.name;  
  
		entity.principal_id = inputItem.principal_id;  
  
		entity.diagram_id = inputItem.diagram_id;  
  
		entity.version = inputItem.version;  
  
		entity.definition = inputItem.definition; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static sysdiagramsDto Map(sysdiagrams inputItem)
        {
            var dto = new sysdiagramsDto()
            {
                  
  
		name = inputItem.name,  
  
		principal_id = inputItem.principal_id,  
  
		diagram_id = inputItem.diagram_id,  
  
		version = inputItem.version,  
  
		definition = inputItem.definition, 
            };
            return dto;
        }

        public static List<sysdiagramsDto> Map(ICollection<sysdiagrams> entities)
        {
            var dtos = new List<sysdiagramsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new sysdiagramsDto()
                {
                      
  
		name = inputItem.name,  
  
		principal_id = inputItem.principal_id,  
  
		diagram_id = inputItem.diagram_id,  
  
		version = inputItem.version,  
  
		definition = inputItem.definition, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TablesLastId Map(AddTablesLastIdCommand inputItem)
        {
            var entity = new TablesLastId() {
                  
  
		tblName = inputItem.tblName,  
  
		LastId = inputItem.LastId, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TablesLastId Map(TablesLastId entity ,EditTablesLastIdCommand inputItem)
        {
              
  
		entity.tblName = inputItem.tblName;  
  
		entity.LastId = inputItem.LastId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TablesLastIdDto Map(TablesLastId inputItem)
        {
            var dto = new TablesLastIdDto()
            {
                  
  
		tblName = inputItem.tblName,  
  
		LastId = inputItem.LastId, 
            };
            return dto;
        }

        public static List<TablesLastIdDto> Map(ICollection<TablesLastId> entities)
        {
            var dtos = new List<TablesLastIdDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TablesLastIdDto()
                {
                      
  
		tblName = inputItem.tblName,  
  
		LastId = inputItem.LastId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TaxDutyInf Map(AddTaxDutyInfCommand inputItem)
        {
            var entity = new TaxDutyInf() {
                  
  
		TaxDutyId = inputItem.TaxDutyId,  
  
		TDDate = inputItem.TDDate,  
  
		TDTaxPrc = inputItem.TDTaxPrc,  
  
		TDDutyPrc = inputItem.TDDutyPrc,  
  
		TDRcvTaxSLRef = inputItem.TDRcvTaxSLRef,  
  
		TDRcvDutySLRef = inputItem.TDRcvDutySLRef,  
  
		TDRcvTaxDLRef = inputItem.TDRcvTaxDLRef,  
  
		TDRcvDutyDLRef = inputItem.TDRcvDutyDLRef,  
  
		TDPayTaxSLRef = inputItem.TDPayTaxSLRef,  
  
		TDPayDutySLRef = inputItem.TDPayDutySLRef,  
  
		TDPayTaxDLRef = inputItem.TDPayTaxDLRef,  
  
		TDPayDutyDLRef = inputItem.TDPayDutyDLRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TaxDutyInf Map(TaxDutyInf entity ,EditTaxDutyInfCommand inputItem)
        {
              
  
		entity.TaxDutyId = inputItem.TaxDutyId;  
  
		entity.TDDate = inputItem.TDDate;  
  
		entity.TDTaxPrc = inputItem.TDTaxPrc;  
  
		entity.TDDutyPrc = inputItem.TDDutyPrc;  
  
		entity.TDRcvTaxSLRef = inputItem.TDRcvTaxSLRef;  
  
		entity.TDRcvDutySLRef = inputItem.TDRcvDutySLRef;  
  
		entity.TDRcvTaxDLRef = inputItem.TDRcvTaxDLRef;  
  
		entity.TDRcvDutyDLRef = inputItem.TDRcvDutyDLRef;  
  
		entity.TDPayTaxSLRef = inputItem.TDPayTaxSLRef;  
  
		entity.TDPayDutySLRef = inputItem.TDPayDutySLRef;  
  
		entity.TDPayTaxDLRef = inputItem.TDPayTaxDLRef;  
  
		entity.TDPayDutyDLRef = inputItem.TDPayDutyDLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TaxDutyInfDto Map(TaxDutyInf inputItem)
        {
            var dto = new TaxDutyInfDto()
            {
                  
  
		TaxDutyId = inputItem.TaxDutyId,  
  
		TDDate = inputItem.TDDate,  
  
		TDTaxPrc = inputItem.TDTaxPrc,  
  
		TDDutyPrc = inputItem.TDDutyPrc,  
  
		TDRcvTaxSLRef = inputItem.TDRcvTaxSLRef,  
  
		TDRcvDutySLRef = inputItem.TDRcvDutySLRef,  
  
		TDRcvTaxDLRef = inputItem.TDRcvTaxDLRef,  
  
		TDRcvDutyDLRef = inputItem.TDRcvDutyDLRef,  
  
		TDPayTaxSLRef = inputItem.TDPayTaxSLRef,  
  
		TDPayDutySLRef = inputItem.TDPayDutySLRef,  
  
		TDPayTaxDLRef = inputItem.TDPayTaxDLRef,  
  
		TDPayDutyDLRef = inputItem.TDPayDutyDLRef, 
            };
            return dto;
        }

        public static List<TaxDutyInfDto> Map(ICollection<TaxDutyInf> entities)
        {
            var dtos = new List<TaxDutyInfDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TaxDutyInfDto()
                {
                      
  
		TaxDutyId = inputItem.TaxDutyId,  
  
		TDDate = inputItem.TDDate,  
  
		TDTaxPrc = inputItem.TDTaxPrc,  
  
		TDDutyPrc = inputItem.TDDutyPrc,  
  
		TDRcvTaxSLRef = inputItem.TDRcvTaxSLRef,  
  
		TDRcvDutySLRef = inputItem.TDRcvDutySLRef,  
  
		TDRcvTaxDLRef = inputItem.TDRcvTaxDLRef,  
  
		TDRcvDutyDLRef = inputItem.TDRcvDutyDLRef,  
  
		TDPayTaxSLRef = inputItem.TDPayTaxSLRef,  
  
		TDPayDutySLRef = inputItem.TDPayDutySLRef,  
  
		TDPayTaxDLRef = inputItem.TDPayTaxDLRef,  
  
		TDPayDutyDLRef = inputItem.TDPayDutyDLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Units Map(AddUnitsCommand inputItem)
        {
            var entity = new Units() {
                  
  
		UnitId = inputItem.UnitId,  
  
		UnitName = inputItem.UnitName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Units Map(Units entity ,EditUnitsCommand inputItem)
        {
              
  
		entity.UnitId = inputItem.UnitId;  
  
		entity.UnitName = inputItem.UnitName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UnitsDto Map(Units inputItem)
        {
            var dto = new UnitsDto()
            {
                  
  
		UnitId = inputItem.UnitId,  
  
		UnitName = inputItem.UnitName, 
            };
            return dto;
        }

        public static List<UnitsDto> Map(ICollection<Units> entities)
        {
            var dtos = new List<UnitsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UnitsDto()
                {
                      
  
		UnitId = inputItem.UnitId,  
  
		UnitName = inputItem.UnitName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
