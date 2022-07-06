using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoBaseTypeVals : BaseEntity
    {
          
 
		public Int32 OtoBaseTypeValsId { get; set; }  
 
		public Int32 OtoBaseTypeRef { get; set; }  
 
		public String OBTValue { get; set; } 
    }
}


