using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrReleaseStockDto
    {
          
 
		public Int32 CmrReleaseStockId { get; set; }  
 
		public Int32 CRSItmRef { get; set; }  
 
		public String CRSNum { get; set; }  
 
		public DateTime CRSDate { get; set; }  
 
		public String CRSDescr { get; set; } 
    }
}


