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
                
        
        public static CurExChange Map(AddCurExChangeCommand inputItem)
        {
            var entity = new CurExChange() {
                  
  
		CurExchangeId = inputItem.CurExchangeId,  
  
		CExMainCurRef = inputItem.CExMainCurRef,  
  
		CExRelCurRef = inputItem.CExRelCurRef,  
  
		CExDate = inputItem.CExDate,  
  
		CExRate = inputItem.CExRate, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CurExChange Map(CurExChange entity ,EditCurExChangeCommand inputItem)
        {
              
  
		entity.CurExchangeId = inputItem.CurExchangeId;  
  
		entity.CExMainCurRef = inputItem.CExMainCurRef;  
  
		entity.CExRelCurRef = inputItem.CExRelCurRef;  
  
		entity.CExDate = inputItem.CExDate;  
  
		entity.CExRate = inputItem.CExRate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CurExChangeDto Map(CurExChange inputItem)
        {
            var dto = new CurExChangeDto()
            {
                  
  
		CurExchangeId = inputItem.CurExchangeId,  
  
		CExMainCurRef = inputItem.CExMainCurRef,  
  
		CExRelCurRef = inputItem.CExRelCurRef,  
  
		CExDate = inputItem.CExDate,  
  
		CExRate = inputItem.CExRate, 
            };
            return dto;
        }

        public static List<CurExChangeDto> Map(ICollection<CurExChange> entities)
        {
            var dtos = new List<CurExChangeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CurExChangeDto()
                {
                      
  
		CurExchangeId = inputItem.CurExchangeId,  
  
		CExMainCurRef = inputItem.CExMainCurRef,  
  
		CExRelCurRef = inputItem.CExRelCurRef,  
  
		CExDate = inputItem.CExDate,  
  
		CExRate = inputItem.CExRate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Currency Map(AddCurrencyCommand inputItem)
        {
            var entity = new Currency() {
                  
  
		CurrencyId = inputItem.CurrencyId,  
  
		CurTitle = inputItem.CurTitle,  
  
		CurDigitCnt = inputItem.CurDigitCnt,  
  
		CurDigitTitle = inputItem.CurDigitTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Currency Map(Currency entity ,EditCurrencyCommand inputItem)
        {
              
  
		entity.CurrencyId = inputItem.CurrencyId;  
  
		entity.CurTitle = inputItem.CurTitle;  
  
		entity.CurDigitCnt = inputItem.CurDigitCnt;  
  
		entity.CurDigitTitle = inputItem.CurDigitTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CurrencyDto Map(Currency inputItem)
        {
            var dto = new CurrencyDto()
            {
                  
  
		CurrencyId = inputItem.CurrencyId,  
  
		CurTitle = inputItem.CurTitle,  
  
		CurDigitCnt = inputItem.CurDigitCnt,  
  
		CurDigitTitle = inputItem.CurDigitTitle, 
            };
            return dto;
        }

        public static List<CurrencyDto> Map(ICollection<Currency> entities)
        {
            var dtos = new List<CurrencyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CurrencyDto()
                {
                      
  
		CurrencyId = inputItem.CurrencyId,  
  
		CurTitle = inputItem.CurTitle,  
  
		CurDigitCnt = inputItem.CurDigitCnt,  
  
		CurDigitTitle = inputItem.CurDigitTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
