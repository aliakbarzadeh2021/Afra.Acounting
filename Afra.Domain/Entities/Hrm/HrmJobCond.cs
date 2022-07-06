using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmJobCond : BaseEntity
    {
          
 
		public Int32 HrmJobCondId { get; set; }  
 
		public Int32 HJCJobRef { get; set; }  
 
		public DateTime HJCDate { get; set; }  
 
		public String HJCCondStr { get; set; }  
 
		public String HJCCondTitle { get; set; }  
 
		public String HJCCondSQL { get; set; } 
    }
}


