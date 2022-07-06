using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProjectHrm : BaseEntity
    {
          
 
		public Int32 BdgProjectHrmId { get; set; }  
 
		public Int32 BPHHdrRef { get; set; }  
 
		public String BPHDescr { get; set; }  
 
		public Nullable<Int32> BPHQty { get; set; }  
 
		public Nullable<Int32> BPHDay { get; set; }  
 
		public Nullable<Double> BPHCost { get; set; } 
    }
}


