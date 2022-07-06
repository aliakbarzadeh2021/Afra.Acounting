using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsGuaranteeGua : BaseEntity
    {
          
 
		public Int32 TrsGuaranteeGuaId { get; set; }  
 
		public Int32 TGGGuaRef { get; set; }  
 
		public Nullable<Int32> TGGRcvDocId { get; set; }  
 
		public String TGGDescr { get; set; } 
    }
}


