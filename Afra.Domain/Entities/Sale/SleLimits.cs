using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleLimits : BaseEntity
    {
          
 
		public Int32 SleLimitId { get; set; }  
 
		public DateTime SLDate { get; set; }  
 
		public Int32 SLType { get; set; }  
 
		public Int32 SLBranchRef { get; set; }  
 
		public Nullable<Int32> SLCstmrGrpRef { get; set; }  
 
		public Nullable<Int32> SLCstmrRef { get; set; }  
 
		public Nullable<Int32> SLPartGrpRef { get; set; }  
 
		public Nullable<Int32> SLPartRef { get; set; }  
 
		public Nullable<Int32> SLPlaceRef { get; set; }  
 
		public Nullable<Int32> SLSaleType { get; set; }  
 
		public Nullable<Double> SLMaxQty { get; set; }  
 
		public Nullable<Double> SLMaxAmount { get; set; } 
    }
}


