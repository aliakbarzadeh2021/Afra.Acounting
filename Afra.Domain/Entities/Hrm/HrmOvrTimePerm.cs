using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmOvrTimePerm : BaseEntity
    {
          
 
		public Int32 HrmOvrTimePermId { get; set; }  
 
		public Nullable<Int32> HOvPPersRef { get; set; }  
 
		public Nullable<Int32> HOvPNum { get; set; }  
 
		public DateTime HOvPDate { get; set; }  
 
		public DateTime HOvPFromDate { get; set; }  
 
		public DateTime HOvPFromTime { get; set; }  
 
		public DateTime HOvPToDate { get; set; }  
 
		public DateTime HOvPToTime { get; set; } 
    }
}


