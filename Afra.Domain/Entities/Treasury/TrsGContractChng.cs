using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsGContractChng : BaseEntity
    {
          
 
		public Int32 TrsGuaContractChngId { get; set; }  
 
		public Int32 TrsGuaContractRef { get; set; }  
 
		public DateTime TGCCDate { get; set; }  
 
		public String TGCCDescr { get; set; }  
 
		public Nullable<Double> TGCCAmount { get; set; } 
    }
}


