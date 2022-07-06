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
                
        
        public static ShopGiftCard Map(AddShopGiftCardCommand inputItem)
        {
            var entity = new ShopGiftCard() {
                  
  
		ShopGiftCardId = inputItem.ShopGiftCardId,  
  
		SGCNumber = inputItem.SGCNumber,  
  
		SGCAmount = inputItem.SGCAmount,  
  
		SGCExpDate = inputItem.SGCExpDate,  
  
		SGCDescr = inputItem.SGCDescr,  
  
		SGCGrpRef = inputItem.SGCGrpRef,  
  
		SGCState = inputItem.SGCState, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShopGiftCard Map(ShopGiftCard entity ,EditShopGiftCardCommand inputItem)
        {
              
  
		entity.ShopGiftCardId = inputItem.ShopGiftCardId;  
  
		entity.SGCNumber = inputItem.SGCNumber;  
  
		entity.SGCAmount = inputItem.SGCAmount;  
  
		entity.SGCExpDate = inputItem.SGCExpDate;  
  
		entity.SGCDescr = inputItem.SGCDescr;  
  
		entity.SGCGrpRef = inputItem.SGCGrpRef;  
  
		entity.SGCState = inputItem.SGCState; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShopGiftCardDto Map(ShopGiftCard inputItem)
        {
            var dto = new ShopGiftCardDto()
            {
                  
  
		ShopGiftCardId = inputItem.ShopGiftCardId,  
  
		SGCNumber = inputItem.SGCNumber,  
  
		SGCAmount = inputItem.SGCAmount,  
  
		SGCExpDate = inputItem.SGCExpDate,  
  
		SGCDescr = inputItem.SGCDescr,  
  
		SGCGrpRef = inputItem.SGCGrpRef,  
  
		SGCState = inputItem.SGCState, 
            };
            return dto;
        }

        public static List<ShopGiftCardDto> Map(ICollection<ShopGiftCard> entities)
        {
            var dtos = new List<ShopGiftCardDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShopGiftCardDto()
                {
                      
  
		ShopGiftCardId = inputItem.ShopGiftCardId,  
  
		SGCNumber = inputItem.SGCNumber,  
  
		SGCAmount = inputItem.SGCAmount,  
  
		SGCExpDate = inputItem.SGCExpDate,  
  
		SGCDescr = inputItem.SGCDescr,  
  
		SGCGrpRef = inputItem.SGCGrpRef,  
  
		SGCState = inputItem.SGCState, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ShopGiftPart Map(AddShopGiftPartCommand inputItem)
        {
            var entity = new ShopGiftPart() {
                  
  
		ShopGiftPartId = inputItem.ShopGiftPartId,  
  
		SGPPartRef = inputItem.SGPPartRef,  
  
		SGPDate = inputItem.SGPDate,  
  
		SGPVchAmnt = inputItem.SGPVchAmnt,  
  
		SGPVal = inputItem.SGPVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShopGiftPart Map(ShopGiftPart entity ,EditShopGiftPartCommand inputItem)
        {
              
  
		entity.ShopGiftPartId = inputItem.ShopGiftPartId;  
  
		entity.SGPPartRef = inputItem.SGPPartRef;  
  
		entity.SGPDate = inputItem.SGPDate;  
  
		entity.SGPVchAmnt = inputItem.SGPVchAmnt;  
  
		entity.SGPVal = inputItem.SGPVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShopGiftPartDto Map(ShopGiftPart inputItem)
        {
            var dto = new ShopGiftPartDto()
            {
                  
  
		ShopGiftPartId = inputItem.ShopGiftPartId,  
  
		SGPPartRef = inputItem.SGPPartRef,  
  
		SGPDate = inputItem.SGPDate,  
  
		SGPVchAmnt = inputItem.SGPVchAmnt,  
  
		SGPVal = inputItem.SGPVal, 
            };
            return dto;
        }

        public static List<ShopGiftPartDto> Map(ICollection<ShopGiftPart> entities)
        {
            var dtos = new List<ShopGiftPartDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShopGiftPartDto()
                {
                      
  
		ShopGiftPartId = inputItem.ShopGiftPartId,  
  
		SGPPartRef = inputItem.SGPPartRef,  
  
		SGPDate = inputItem.SGPDate,  
  
		SGPVchAmnt = inputItem.SGPVchAmnt,  
  
		SGPVal = inputItem.SGPVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ShopPartPrice Map(AddShopPartPriceCommand inputItem)
        {
            var entity = new ShopPartPrice() {
                  
  
		ShopPartPriceId = inputItem.ShopPartPriceId,  
  
		SPPDate = inputItem.SPPDate,  
  
		SPPPartRef = inputItem.SPPPartRef,  
  
		SPPSaleType = inputItem.SPPSaleType,  
  
		SPPVal = inputItem.SPPVal, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShopPartPrice Map(ShopPartPrice entity ,EditShopPartPriceCommand inputItem)
        {
              
  
		entity.ShopPartPriceId = inputItem.ShopPartPriceId;  
  
		entity.SPPDate = inputItem.SPPDate;  
  
		entity.SPPPartRef = inputItem.SPPPartRef;  
  
		entity.SPPSaleType = inputItem.SPPSaleType;  
  
		entity.SPPVal = inputItem.SPPVal; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShopPartPriceDto Map(ShopPartPrice inputItem)
        {
            var dto = new ShopPartPriceDto()
            {
                  
  
		ShopPartPriceId = inputItem.ShopPartPriceId,  
  
		SPPDate = inputItem.SPPDate,  
  
		SPPPartRef = inputItem.SPPPartRef,  
  
		SPPSaleType = inputItem.SPPSaleType,  
  
		SPPVal = inputItem.SPPVal, 
            };
            return dto;
        }

        public static List<ShopPartPriceDto> Map(ICollection<ShopPartPrice> entities)
        {
            var dtos = new List<ShopPartPriceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShopPartPriceDto()
                {
                      
  
		ShopPartPriceId = inputItem.ShopPartPriceId,  
  
		SPPDate = inputItem.SPPDate,  
  
		SPPPartRef = inputItem.SPPPartRef,  
  
		SPPSaleType = inputItem.SPPSaleType,  
  
		SPPVal = inputItem.SPPVal, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Shops Map(AddShopsCommand inputItem)
        {
            var entity = new Shops() {
                  
  
		ShopsId = inputItem.ShopsId,  
  
		ShopName = inputItem.ShopName,  
  
		ShopDb = inputItem.ShopDb,  
  
		ShopSaleBranch = inputItem.ShopSaleBranch,  
  
		ShopStock = inputItem.ShopStock, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Shops Map(Shops entity ,EditShopsCommand inputItem)
        {
              
  
		entity.ShopsId = inputItem.ShopsId;  
  
		entity.ShopName = inputItem.ShopName;  
  
		entity.ShopDb = inputItem.ShopDb;  
  
		entity.ShopSaleBranch = inputItem.ShopSaleBranch;  
  
		entity.ShopStock = inputItem.ShopStock; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShopsDto Map(Shops inputItem)
        {
            var dto = new ShopsDto()
            {
                  
  
		ShopsId = inputItem.ShopsId,  
  
		ShopName = inputItem.ShopName,  
  
		ShopDb = inputItem.ShopDb,  
  
		ShopSaleBranch = inputItem.ShopSaleBranch,  
  
		ShopStock = inputItem.ShopStock, 
            };
            return dto;
        }

        public static List<ShopsDto> Map(ICollection<Shops> entities)
        {
            var dtos = new List<ShopsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShopsDto()
                {
                      
  
		ShopsId = inputItem.ShopsId,  
  
		ShopName = inputItem.ShopName,  
  
		ShopDb = inputItem.ShopDb,  
  
		ShopSaleBranch = inputItem.ShopSaleBranch,  
  
		ShopStock = inputItem.ShopStock, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ShopTaxVals Map(AddShopTaxValsCommand inputItem)
        {
            var entity = new ShopTaxVals() {
                  
  
		ShopTaxValsId = inputItem.ShopTaxValsId,  
  
		STVTaxRef = inputItem.STVTaxRef,  
  
		STVDate = inputItem.STVDate,  
  
		STVPartRef = inputItem.STVPartRef,  
  
		STVDescr = inputItem.STVDescr,  
  
		STVAmount = inputItem.STVAmount, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ShopTaxVals Map(ShopTaxVals entity ,EditShopTaxValsCommand inputItem)
        {
              
  
		entity.ShopTaxValsId = inputItem.ShopTaxValsId;  
  
		entity.STVTaxRef = inputItem.STVTaxRef;  
  
		entity.STVDate = inputItem.STVDate;  
  
		entity.STVPartRef = inputItem.STVPartRef;  
  
		entity.STVDescr = inputItem.STVDescr;  
  
		entity.STVAmount = inputItem.STVAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ShopTaxValsDto Map(ShopTaxVals inputItem)
        {
            var dto = new ShopTaxValsDto()
            {
                  
  
		ShopTaxValsId = inputItem.ShopTaxValsId,  
  
		STVTaxRef = inputItem.STVTaxRef,  
  
		STVDate = inputItem.STVDate,  
  
		STVPartRef = inputItem.STVPartRef,  
  
		STVDescr = inputItem.STVDescr,  
  
		STVAmount = inputItem.STVAmount, 
            };
            return dto;
        }

        public static List<ShopTaxValsDto> Map(ICollection<ShopTaxVals> entities)
        {
            var dtos = new List<ShopTaxValsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ShopTaxValsDto()
                {
                      
  
		ShopTaxValsId = inputItem.ShopTaxValsId,  
  
		STVTaxRef = inputItem.STVTaxRef,  
  
		STVDate = inputItem.STVDate,  
  
		STVPartRef = inputItem.STVPartRef,  
  
		STVDescr = inputItem.STVDescr,  
  
		STVAmount = inputItem.STVAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
