using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdSendItmDto
    {
          
 
		public Int32 PrdSendItmId { get; set; }  
 
		public Int32 PSISeq { get; set; }  
 
		public Int32 PrdSendHdrRef { get; set; }  
 
		public Nullable<Int32> PSIOprRef { get; set; }  
 
		public Nullable<Double> PSIMainQty { get; set; }  
 
		public String PSIDescr { get; set; } 
    }
}


