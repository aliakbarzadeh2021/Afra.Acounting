using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmPrsntStat : BaseEntity
    {
          
 
		public Int32 HrmPrsntStatId { get; set; }  
 
		public Nullable<Int32> HPSType { get; set; }  
 
		public Nullable<Int32> HPSNum { get; set; }  
 
		public DateTime HPSDate { get; set; }  
 
		public Nullable<Int32> HPSPersRef { get; set; }  
 
		public DateTime HPSFromDate { get; set; }  
 
		public DateTime HPSToDate { get; set; } 
    }
}


