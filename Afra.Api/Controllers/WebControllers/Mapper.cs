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
                
        
        public static WebDocs Map(AddWebDocsCommand inputItem)
        {
            var entity = new WebDocs() {
                  
  
		WebDocsId = inputItem.WebDocsId,  
  
		WDType = inputItem.WDType,  
  
		WDTitle = inputItem.WDTitle,  
  
		WDFileName = inputItem.WDFileName, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WebDocs Map(WebDocs entity ,EditWebDocsCommand inputItem)
        {
              
  
		entity.WebDocsId = inputItem.WebDocsId;  
  
		entity.WDType = inputItem.WDType;  
  
		entity.WDTitle = inputItem.WDTitle;  
  
		entity.WDFileName = inputItem.WDFileName; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WebDocsDto Map(WebDocs inputItem)
        {
            var dto = new WebDocsDto()
            {
                  
  
		WebDocsId = inputItem.WebDocsId,  
  
		WDType = inputItem.WDType,  
  
		WDTitle = inputItem.WDTitle,  
  
		WDFileName = inputItem.WDFileName, 
            };
            return dto;
        }

        public static List<WebDocsDto> Map(ICollection<WebDocs> entities)
        {
            var dtos = new List<WebDocsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WebDocsDto()
                {
                      
  
		WebDocsId = inputItem.WebDocsId,  
  
		WDType = inputItem.WDType,  
  
		WDTitle = inputItem.WDTitle,  
  
		WDFileName = inputItem.WDFileName, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WebImages Map(AddWebImagesCommand inputItem)
        {
            var entity = new WebImages() {
                  
  
		WebImageId = inputItem.WebImageId,  
  
		WIPersRef = inputItem.WIPersRef,  
  
		WIDate = inputItem.WIDate,  
  
		WIType = inputItem.WIType,  
  
		WIData = inputItem.WIData, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WebImages Map(WebImages entity ,EditWebImagesCommand inputItem)
        {
              
  
		entity.WebImageId = inputItem.WebImageId;  
  
		entity.WIPersRef = inputItem.WIPersRef;  
  
		entity.WIDate = inputItem.WIDate;  
  
		entity.WIType = inputItem.WIType;  
  
		entity.WIData = inputItem.WIData; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WebImagesDto Map(WebImages inputItem)
        {
            var dto = new WebImagesDto()
            {
                  
  
		WebImageId = inputItem.WebImageId,  
  
		WIPersRef = inputItem.WIPersRef,  
  
		WIDate = inputItem.WIDate,  
  
		WIType = inputItem.WIType,  
  
		WIData = inputItem.WIData, 
            };
            return dto;
        }

        public static List<WebImagesDto> Map(ICollection<WebImages> entities)
        {
            var dtos = new List<WebImagesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WebImagesDto()
                {
                      
  
		WebImageId = inputItem.WebImageId,  
  
		WIPersRef = inputItem.WIPersRef,  
  
		WIDate = inputItem.WIDate,  
  
		WIType = inputItem.WIType,  
  
		WIData = inputItem.WIData, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WebLogins Map(AddWebLoginsCommand inputItem)
        {
            var entity = new WebLogins() {
                  
  
		WebLoginId = inputItem.WebLoginId,  
  
		WLNatCode = inputItem.WLNatCode,  
  
		WLPCName = inputItem.WLPCName,  
  
		WLDateTime = inputItem.WLDateTime,  
  
		WLExit = inputItem.WLExit,  
  
		WLState = inputItem.WLState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WebLogins Map(WebLogins entity ,EditWebLoginsCommand inputItem)
        {
              
  
		entity.WebLoginId = inputItem.WebLoginId;  
  
		entity.WLNatCode = inputItem.WLNatCode;  
  
		entity.WLPCName = inputItem.WLPCName;  
  
		entity.WLDateTime = inputItem.WLDateTime;  
  
		entity.WLExit = inputItem.WLExit;  
  
		entity.WLState = inputItem.WLState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WebLoginsDto Map(WebLogins inputItem)
        {
            var dto = new WebLoginsDto()
            {
                  
  
		WebLoginId = inputItem.WebLoginId,  
  
		WLNatCode = inputItem.WLNatCode,  
  
		WLPCName = inputItem.WLPCName,  
  
		WLDateTime = inputItem.WLDateTime,  
  
		WLExit = inputItem.WLExit,  
  
		WLState = inputItem.WLState, 
            };
            return dto;
        }

        public static List<WebLoginsDto> Map(ICollection<WebLogins> entities)
        {
            var dtos = new List<WebLoginsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WebLoginsDto()
                {
                      
  
		WebLoginId = inputItem.WebLoginId,  
  
		WLNatCode = inputItem.WLNatCode,  
  
		WLPCName = inputItem.WLPCName,  
  
		WLDateTime = inputItem.WLDateTime,  
  
		WLExit = inputItem.WLExit,  
  
		WLState = inputItem.WLState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WebMessages Map(AddWebMessagesCommand inputItem)
        {
            var entity = new WebMessages() {
                  
  
		WebMsgId = inputItem.WebMsgId,  
  
		WMNatCode = inputItem.WMNatCode,  
  
		WMSndDate = inputItem.WMSndDate,  
  
		WMRcvDate = inputItem.WMRcvDate,  
  
		WMTitle = inputItem.WMTitle,  
  
		WMMsg = inputItem.WMMsg, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WebMessages Map(WebMessages entity ,EditWebMessagesCommand inputItem)
        {
              
  
		entity.WebMsgId = inputItem.WebMsgId;  
  
		entity.WMNatCode = inputItem.WMNatCode;  
  
		entity.WMSndDate = inputItem.WMSndDate;  
  
		entity.WMRcvDate = inputItem.WMRcvDate;  
  
		entity.WMTitle = inputItem.WMTitle;  
  
		entity.WMMsg = inputItem.WMMsg; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WebMessagesDto Map(WebMessages inputItem)
        {
            var dto = new WebMessagesDto()
            {
                  
  
		WebMsgId = inputItem.WebMsgId,  
  
		WMNatCode = inputItem.WMNatCode,  
  
		WMSndDate = inputItem.WMSndDate,  
  
		WMRcvDate = inputItem.WMRcvDate,  
  
		WMTitle = inputItem.WMTitle,  
  
		WMMsg = inputItem.WMMsg, 
            };
            return dto;
        }

        public static List<WebMessagesDto> Map(ICollection<WebMessages> entities)
        {
            var dtos = new List<WebMessagesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WebMessagesDto()
                {
                      
  
		WebMsgId = inputItem.WebMsgId,  
  
		WMNatCode = inputItem.WMNatCode,  
  
		WMSndDate = inputItem.WMSndDate,  
  
		WMRcvDate = inputItem.WMRcvDate,  
  
		WMTitle = inputItem.WMTitle,  
  
		WMMsg = inputItem.WMMsg, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
