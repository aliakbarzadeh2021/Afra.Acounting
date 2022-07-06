using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdSendItm : BaseEntity
    {
          
 
		public Int32 PrdSendItmId { get; set; }  
 
		public Int32 PSISeq { get; set; }  
 
		public Int32 PrdSendHdrRef { get; set; }  
 
		public Nullable<Int32> PSIOprRef { get; set; }  
 
		public Nullable<Double> PSIMainQty { get; set; }  
 
		public String PSIDescr { get; set; } 
    }
}


