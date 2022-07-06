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
                
        
        public static ArchGroups Map(AddArchGroupsCommand inputItem)
        {
            var entity = new ArchGroups() {
                  
  
		ArchGrpId = inputItem.ArchGrpId,  
  
		AcGTitle = inputItem.AcGTitle,  
  
		AcSysRef = inputItem.AcSysRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ArchGroups Map(ArchGroups entity ,EditArchGroupsCommand inputItem)
        {
              
  
		entity.ArchGrpId = inputItem.ArchGrpId;  
  
		entity.AcGTitle = inputItem.AcGTitle;  
  
		entity.AcSysRef = inputItem.AcSysRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ArchGroupsDto Map(ArchGroups inputItem)
        {
            var dto = new ArchGroupsDto()
            {
                  
  
		ArchGrpId = inputItem.ArchGrpId,  
  
		AcGTitle = inputItem.AcGTitle,  
  
		AcSysRef = inputItem.AcSysRef, 
            };
            return dto;
        }

        public static List<ArchGroupsDto> Map(ICollection<ArchGroups> entities)
        {
            var dtos = new List<ArchGroupsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ArchGroupsDto()
                {
                      
  
		ArchGrpId = inputItem.ArchGrpId,  
  
		AcGTitle = inputItem.AcGTitle,  
  
		AcSysRef = inputItem.AcSysRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Archive Map(AddArchiveCommand inputItem)
        {
            var entity = new Archive() {
                  
  
		ArchiveId = inputItem.ArchiveId,  
  
		AcTitle = inputItem.AcTitle,  
  
		AcTypeRef = inputItem.AcTypeRef,  
  
		TableItmId = inputItem.TableItmId,  
  
		FileKind = inputItem.FileKind,  
  
		FileContent = inputItem.FileContent,  
  
		FilePath = inputItem.FilePath, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Archive Map(Archive entity ,EditArchiveCommand inputItem)
        {
              
  
		entity.ArchiveId = inputItem.ArchiveId;  
  
		entity.AcTitle = inputItem.AcTitle;  
  
		entity.AcTypeRef = inputItem.AcTypeRef;  
  
		entity.TableItmId = inputItem.TableItmId;  
  
		entity.FileKind = inputItem.FileKind;  
  
		entity.FileContent = inputItem.FileContent;  
  
		entity.FilePath = inputItem.FilePath; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ArchiveDto Map(Archive inputItem)
        {
            var dto = new ArchiveDto()
            {
                  
  
		ArchiveId = inputItem.ArchiveId,  
  
		AcTitle = inputItem.AcTitle,  
  
		AcTypeRef = inputItem.AcTypeRef,  
  
		TableItmId = inputItem.TableItmId,  
  
		FileKind = inputItem.FileKind,  
  
		FileContent = inputItem.FileContent,  
  
		FilePath = inputItem.FilePath, 
            };
            return dto;
        }

        public static List<ArchiveDto> Map(ICollection<Archive> entities)
        {
            var dtos = new List<ArchiveDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ArchiveDto()
                {
                      
  
		ArchiveId = inputItem.ArchiveId,  
  
		AcTitle = inputItem.AcTitle,  
  
		AcTypeRef = inputItem.AcTypeRef,  
  
		TableItmId = inputItem.TableItmId,  
  
		FileKind = inputItem.FileKind,  
  
		FileContent = inputItem.FileContent,  
  
		FilePath = inputItem.FilePath, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ArchTypes Map(AddArchTypesCommand inputItem)
        {
            var entity = new ArchTypes() {
                  
  
		ArchTypeId = inputItem.ArchTypeId,  
  
		AcTTableRef = inputItem.AcTTableRef,  
  
		AcTTitle = inputItem.AcTTitle,  
  
		AcTIsDef = inputItem.AcTIsDef,  
  
		AcGrpRef = inputItem.AcGrpRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ArchTypes Map(ArchTypes entity ,EditArchTypesCommand inputItem)
        {
              
  
		entity.ArchTypeId = inputItem.ArchTypeId;  
  
		entity.AcTTableRef = inputItem.AcTTableRef;  
  
		entity.AcTTitle = inputItem.AcTTitle;  
  
		entity.AcTIsDef = inputItem.AcTIsDef;  
  
		entity.AcGrpRef = inputItem.AcGrpRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ArchTypesDto Map(ArchTypes inputItem)
        {
            var dto = new ArchTypesDto()
            {
                  
  
		ArchTypeId = inputItem.ArchTypeId,  
  
		AcTTableRef = inputItem.AcTTableRef,  
  
		AcTTitle = inputItem.AcTTitle,  
  
		AcTIsDef = inputItem.AcTIsDef,  
  
		AcGrpRef = inputItem.AcGrpRef, 
            };
            return dto;
        }

        public static List<ArchTypesDto> Map(ICollection<ArchTypes> entities)
        {
            var dtos = new List<ArchTypesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ArchTypesDto()
                {
                      
  
		ArchTypeId = inputItem.ArchTypeId,  
  
		AcTTableRef = inputItem.AcTTableRef,  
  
		AcTTitle = inputItem.AcTTitle,  
  
		AcTIsDef = inputItem.AcTIsDef,  
  
		AcGrpRef = inputItem.AcGrpRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
