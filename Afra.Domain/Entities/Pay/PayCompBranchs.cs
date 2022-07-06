using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayCompBranchs : BaseEntity
    {
          
 
		public Int32 PayCompBranchId { get; set; }  
 
		public Int32 PCBCompRef { get; set; }  
 
		public Int32 PCBCrspndRef { get; set; }  
 
		public String PCBCompID { get; set; }  
 
		public Nullable<Int32> PCBIsMain { get; set; }  
 
		public String PCBContNum { get; set; } 
    }
}


