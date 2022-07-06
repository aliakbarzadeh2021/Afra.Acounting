using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartUnits : BaseEntity
    {
          
 
		public Int32 PUPartRef { get; set; }  
 
		public Int32 PUUnitRef { get; set; }  
 
		public Nullable<Double> PURatio { get; set; }  
 
		public Nullable<Int32> PUCanChange { get; set; }  
 
		public Nullable<Int32> PUIsDef { get; set; } 
    }
}


