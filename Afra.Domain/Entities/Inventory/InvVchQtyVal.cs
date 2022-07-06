using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvVchQtyVal : BaseEntity
    {
          
 
		public Int32 InvVchQtyValId { get; set; }  
 
		public Int32 IVQVchItmRef { get; set; }  
 
		public Nullable<Int32> IVQPrjRef { get; set; }  
 
		public String IVQDLRef { get; set; }  
 
		public Nullable<Int32> IVQProductRef { get; set; }  
 
		public String IVQOthVal { get; set; }  
 
		public String IVQOthDate { get; set; }  
 
		public Double IVQQty { get; set; } 
    }
}


