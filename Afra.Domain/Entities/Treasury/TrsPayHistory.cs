using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsPayHistory : BaseEntity
    {
          
 
		public Int32 TrsPayHistoryId { get; set; }  
 
		public Int32 TPHItmRef { get; set; }  
 
		public DateTime TPHItmDate { get; set; }  
 
		public String TPHItmState { get; set; }  
 
		public Nullable<Int32> TPHOprId { get; set; }  
 
		public Nullable<Int32> TPHTrsOpr { get; set; } 
    }
}


