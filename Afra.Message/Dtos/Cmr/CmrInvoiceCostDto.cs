using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class CmrInvoiceCostDto
    {
          
 
		public Int32 CmrInvoiceCostId { get; set; }  
 
		public Int32 CICItmRef { get; set; }  
 
		public String CICDescr { get; set; }  
 
		public Double CICAmount { get; set; } 
    }
}


