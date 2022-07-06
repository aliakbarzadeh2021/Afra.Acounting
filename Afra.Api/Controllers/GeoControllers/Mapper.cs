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
                
        
        public static GeoPos Map(AddGeoPosCommand inputItem)
        {
            var entity = new GeoPos() {
                  
  
		GeoPosId = inputItem.GeoPosId,  
  
		GeoPostParent = inputItem.GeoPostParent,  
  
		GeoPostTitle = inputItem.GeoPostTitle, 
                CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GeoPos Map(GeoPos entity ,EditGeoPosCommand inputItem)
        {
              
  
		entity.GeoPosId = inputItem.GeoPosId;  
  
		entity.GeoPostParent = inputItem.GeoPostParent;  
  
		entity.GeoPostTitle = inputItem.GeoPostTitle; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GeoPosDto Map(GeoPos inputItem)
        {
            var dto = new GeoPosDto()
            {
                  
  
		GeoPosId = inputItem.GeoPosId,  
  
		GeoPostParent = inputItem.GeoPostParent,  
  
		GeoPostTitle = inputItem.GeoPostTitle, 
            };
            return dto;
        }

        public static List<GeoPosDto> Map(ICollection<GeoPos> entities)
        {
            var dtos = new List<GeoPosDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GeoPosDto()
                {
                      
  
		GeoPosId = inputItem.GeoPosId,  
  
		GeoPostParent = inputItem.GeoPostParent,  
  
		GeoPostTitle = inputItem.GeoPostTitle, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}
