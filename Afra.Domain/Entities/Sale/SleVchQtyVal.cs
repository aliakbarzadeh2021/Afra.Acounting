using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleVchQtyVal : BaseEntity
    {
          
 
		public Int32 SleVchQtyValId { get; set; }  
 
		public Int32 SVQVchItmRef { get; set; }  
 
		public Nullable<Int32> SVQPrjRef { get; set; }  
 
		public String SVQDLRef { get; set; }  
 
		public Nullable<Int32> SVQProductRef { get; set; }  
 
		public String SVQOthVal { get; set; }  
 
		public String SVQOthDate { get; set; }  
 
		public Double SVQQty { get; set; } 
    }
}


