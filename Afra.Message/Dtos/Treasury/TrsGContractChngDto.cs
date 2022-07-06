using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsGContractChngDto
    {
          
 
		public Int32 TrsGuaContractChngId { get; set; }  
 
		public Int32 TrsGuaContractRef { get; set; }  
 
		public DateTime TGCCDate { get; set; }  
 
		public String TGCCDescr { get; set; }  
 
		public Nullable<Double> TGCCAmount { get; set; } 
    }
}


