using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PmiReqPartDto
    {
          
 
		public Int32 PMIReqPartId { get; set; }  
 
		public Int32 PRPPrjRef { get; set; }  
 
		public Int32 PRPPartRef { get; set; }  
 
		public DateTime PRPDate { get; set; }  
 
		public Nullable<Double> PRPQty { get; set; }  
 
		public Nullable<Int32> PRPCreator { get; set; } 
    }
}


