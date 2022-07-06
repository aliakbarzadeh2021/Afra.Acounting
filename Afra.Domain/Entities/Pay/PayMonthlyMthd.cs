using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayMonthlyMthd : BaseEntity
    {
          
 
		public Int32 PayMonthlyMthdId { get; set; }  
 
		public String PMMTitle { get; set; }  
 
		public Int32 PMMType { get; set; }  
 
		public String PMMVals { get; set; } 
    }
}


