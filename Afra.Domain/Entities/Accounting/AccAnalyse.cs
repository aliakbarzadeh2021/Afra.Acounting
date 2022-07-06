using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccAnalyse : BaseEntity
    {
          
 
		public Int32 DebitVchItmRef { get; set; }  
 
		public Int32 CreditVchItmRef { get; set; }  
 
		public Nullable<Int32> AccLevel { get; set; }  
 
		public Nullable<Int32> State { get; set; } 
    }
}


