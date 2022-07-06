using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccPeriod : BaseEntity
    {
          
 
		public Int32 PeriodId { get; set; }  
 
		public String PeriodTitle { get; set; }  
 
		public DateTime p_FromDate { get; set; }  
 
		public DateTime p_ToDate { get; set; }  
 
		public Int32 p_Year { get; set; } 
    }
}


