using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgPeriods : BaseEntity
    {
          
 
		public Int32 BdgPeriodId { get; set; }  
 
		public String BPTitle { get; set; }  
 
		public DateTime BPFromDate { get; set; }  
 
		public DateTime BPToDate { get; set; }  
 
		public Nullable<Int32> BPState { get; set; }  
 
		public DateTime BPRepDate { get; set; }  
 
		public DateTime BPOpFDate { get; set; }  
 
		public DateTime BPOpTDate { get; set; } 
    }
}


