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
                
        
        public static ElementRoles Map(AddElementRolesCommand inputItem)
        {
            var entity = new ElementRoles() {
                  
  
		ElementRoleId = inputItem.ElementRoleId,  
  
		ERTitle = inputItem.ERTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ElementRoles Map(ElementRoles entity ,EditElementRolesCommand inputItem)
        {
              
  
		entity.ElementRoleId = inputItem.ElementRoleId;  
  
		entity.ERTitle = inputItem.ERTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElementRolesDto Map(ElementRoles inputItem)
        {
            var dto = new ElementRolesDto()
            {
                  
  
		ElementRoleId = inputItem.ElementRoleId,  
  
		ERTitle = inputItem.ERTitle, 
            };
            return dto;
        }

        public static List<ElementRolesDto> Map(ICollection<ElementRoles> entities)
        {
            var dtos = new List<ElementRolesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElementRolesDto()
                {
                      
  
		ElementRoleId = inputItem.ElementRoleId,  
  
		ERTitle = inputItem.ERTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Elements Map(AddElementsCommand inputItem)
        {
            var entity = new Elements() {
                  
  
		ElmntId = inputItem.ElmntId,  
  
		ElmntTitle = inputItem.ElmntTitle,  
  
		ElmntType = inputItem.ElmntType,  
  
		ElmntRole = inputItem.ElmntRole,  
  
		ElmntFishPr = inputItem.ElmntFishPr,  
  
		ElmntCalcPr = inputItem.ElmntCalcPr,  
  
		ElmntCompRef = inputItem.ElmntCompRef,  
  
		ElmntStatPr = inputItem.ElmntStatPr,  
  
		ElmntPayListPr = inputItem.ElmntPayListPr, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Elements Map(Elements entity ,EditElementsCommand inputItem)
        {
              
  
		entity.ElmntId = inputItem.ElmntId;  
  
		entity.ElmntTitle = inputItem.ElmntTitle;  
  
		entity.ElmntType = inputItem.ElmntType;  
  
		entity.ElmntRole = inputItem.ElmntRole;  
  
		entity.ElmntFishPr = inputItem.ElmntFishPr;  
  
		entity.ElmntCalcPr = inputItem.ElmntCalcPr;  
  
		entity.ElmntCompRef = inputItem.ElmntCompRef;  
  
		entity.ElmntStatPr = inputItem.ElmntStatPr;  
  
		entity.ElmntPayListPr = inputItem.ElmntPayListPr; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElementsDto Map(Elements inputItem)
        {
            var dto = new ElementsDto()
            {
                  
  
		ElmntId = inputItem.ElmntId,  
  
		ElmntTitle = inputItem.ElmntTitle,  
  
		ElmntType = inputItem.ElmntType,  
  
		ElmntRole = inputItem.ElmntRole,  
  
		ElmntFishPr = inputItem.ElmntFishPr,  
  
		ElmntCalcPr = inputItem.ElmntCalcPr,  
  
		ElmntCompRef = inputItem.ElmntCompRef,  
  
		ElmntStatPr = inputItem.ElmntStatPr,  
  
		ElmntPayListPr = inputItem.ElmntPayListPr, 
            };
            return dto;
        }

        public static List<ElementsDto> Map(ICollection<Elements> entities)
        {
            var dtos = new List<ElementsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElementsDto()
                {
                      
  
		ElmntId = inputItem.ElmntId,  
  
		ElmntTitle = inputItem.ElmntTitle,  
  
		ElmntType = inputItem.ElmntType,  
  
		ElmntRole = inputItem.ElmntRole,  
  
		ElmntFishPr = inputItem.ElmntFishPr,  
  
		ElmntCalcPr = inputItem.ElmntCalcPr,  
  
		ElmntCompRef = inputItem.ElmntCompRef,  
  
		ElmntStatPr = inputItem.ElmntStatPr,  
  
		ElmntPayListPr = inputItem.ElmntPayListPr, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ElmntMethod Map(AddElmntMethodCommand inputItem)
        {
            var entity = new ElmntMethod() {
                  
  
		EmthdId = inputItem.EmthdId,  
  
		EmthdElmntRef = inputItem.EmthdElmntRef,  
  
		EmthdEmpRef = inputItem.EmthdEmpRef,  
  
		EmthdIYear = inputItem.EmthdIYear,  
  
		EmthdIMonth = inputItem.EmthdIMonth,  
  
		EmthdEYear = inputItem.EmthdEYear,  
  
		EmthdEMonth = inputItem.EmthdEMonth,  
  
		EmthdIYearMonth = inputItem.EmthdIYearMonth,  
  
		EmthdEYearMonth = inputItem.EmthdEYearMonth,  
  
		EmthdAct = inputItem.EmthdAct,  
  
		EmthdFormula = inputItem.EmthdFormula,  
  
		EmthdRoles = inputItem.EmthdRoles,  
  
		EmthdLastChange = inputItem.EmthdLastChange, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ElmntMethod Map(ElmntMethod entity ,EditElmntMethodCommand inputItem)
        {
              
  
		entity.EmthdId = inputItem.EmthdId;  
  
		entity.EmthdElmntRef = inputItem.EmthdElmntRef;  
  
		entity.EmthdEmpRef = inputItem.EmthdEmpRef;  
  
		entity.EmthdIYear = inputItem.EmthdIYear;  
  
		entity.EmthdIMonth = inputItem.EmthdIMonth;  
  
		entity.EmthdEYear = inputItem.EmthdEYear;  
  
		entity.EmthdEMonth = inputItem.EmthdEMonth;  
  
		entity.EmthdIYearMonth = inputItem.EmthdIYearMonth;  
  
		entity.EmthdEYearMonth = inputItem.EmthdEYearMonth;  
  
		entity.EmthdAct = inputItem.EmthdAct;  
  
		entity.EmthdFormula = inputItem.EmthdFormula;  
  
		entity.EmthdRoles = inputItem.EmthdRoles;  
  
		entity.EmthdLastChange = inputItem.EmthdLastChange; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElmntMethodDto Map(ElmntMethod inputItem)
        {
            var dto = new ElmntMethodDto()
            {
                  
  
		EmthdId = inputItem.EmthdId,  
  
		EmthdElmntRef = inputItem.EmthdElmntRef,  
  
		EmthdEmpRef = inputItem.EmthdEmpRef,  
  
		EmthdIYear = inputItem.EmthdIYear,  
  
		EmthdIMonth = inputItem.EmthdIMonth,  
  
		EmthdEYear = inputItem.EmthdEYear,  
  
		EmthdEMonth = inputItem.EmthdEMonth,  
  
		EmthdIYearMonth = inputItem.EmthdIYearMonth,  
  
		EmthdEYearMonth = inputItem.EmthdEYearMonth,  
  
		EmthdAct = inputItem.EmthdAct,  
  
		EmthdFormula = inputItem.EmthdFormula,  
  
		EmthdRoles = inputItem.EmthdRoles,  
  
		EmthdLastChange = inputItem.EmthdLastChange, 
            };
            return dto;
        }

        public static List<ElmntMethodDto> Map(ICollection<ElmntMethod> entities)
        {
            var dtos = new List<ElmntMethodDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElmntMethodDto()
                {
                      
  
		EmthdId = inputItem.EmthdId,  
  
		EmthdElmntRef = inputItem.EmthdElmntRef,  
  
		EmthdEmpRef = inputItem.EmthdEmpRef,  
  
		EmthdIYear = inputItem.EmthdIYear,  
  
		EmthdIMonth = inputItem.EmthdIMonth,  
  
		EmthdEYear = inputItem.EmthdEYear,  
  
		EmthdEMonth = inputItem.EmthdEMonth,  
  
		EmthdIYearMonth = inputItem.EmthdIYearMonth,  
  
		EmthdEYearMonth = inputItem.EmthdEYearMonth,  
  
		EmthdAct = inputItem.EmthdAct,  
  
		EmthdFormula = inputItem.EmthdFormula,  
  
		EmthdRoles = inputItem.EmthdRoles,  
  
		EmthdLastChange = inputItem.EmthdLastChange, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ElmntMethodRoles Map(AddElmntMethodRolesCommand inputItem)
        {
            var entity = new ElmntMethodRoles() {
                  
  
		EMRMthdRef = inputItem.EMRMthdRef,  
  
		EMRRoleRef = inputItem.EMRRoleRef, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ElmntMethodRoles Map(ElmntMethodRoles entity ,EditElmntMethodRolesCommand inputItem)
        {
              
  
		entity.EMRMthdRef = inputItem.EMRMthdRef;  
  
		entity.EMRRoleRef = inputItem.EMRRoleRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElmntMethodRolesDto Map(ElmntMethodRoles inputItem)
        {
            var dto = new ElmntMethodRolesDto()
            {
                  
  
		EMRMthdRef = inputItem.EMRMthdRef,  
  
		EMRRoleRef = inputItem.EMRRoleRef, 
            };
            return dto;
        }

        public static List<ElmntMethodRolesDto> Map(ICollection<ElmntMethodRoles> entities)
        {
            var dtos = new List<ElmntMethodRolesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElmntMethodRolesDto()
                {
                      
  
		EMRMthdRef = inputItem.EMRMthdRef,  
  
		EMRRoleRef = inputItem.EMRRoleRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
