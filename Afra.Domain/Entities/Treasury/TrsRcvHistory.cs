using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsRcvHistory : BaseEntity
    {
          
 
		public Int32 TrsRcvHistoryId { get; set; }  
 
		public Int32 TRHItmRef { get; set; }  
 
		public DateTime TRHItmDate { get; set; }  
 
		public String TRHItmState { get; set; }  
 
		public Nullable<Int32> TRHOprId { get; set; }  
 
		public Nullable<Int32> TRHTrsOpr { get; set; } 
    }
}


