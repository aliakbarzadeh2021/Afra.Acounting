using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrReleaseCostDto
    {
          
 
		public Int32 CmrReleaseCostId { get; set; }  
 
		public Int32 CRCItmRef { get; set; }  
 
		public String CRCDescr { get; set; }  
 
		public Double CRCAmount { get; set; } 
    }
}


