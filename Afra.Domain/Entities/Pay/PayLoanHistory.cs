using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayLoanHistory : BaseEntity
    {
          
 
		public Int32 PayLoanHostoryId { get; set; }  
 
		public Int32 PLHLoanRef { get; set; }  
 
		public Nullable<Int32> PLHState { get; set; }  
 
		public Int32 PLHIYearMonth { get; set; } 
    }
}


