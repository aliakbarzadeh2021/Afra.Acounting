using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsFacilitiesGua : BaseEntity
    {
          
 
		public Int32 TrsFacilitiesGuaId { get; set; }  
 
		public Int32 TFGFacRef { get; set; }  
 
		public Nullable<Int32> TFGRcvDocId { get; set; }  
 
		public String TFGDescr { get; set; } 
    }
}


