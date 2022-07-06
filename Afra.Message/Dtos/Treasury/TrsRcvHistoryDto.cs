using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsRcvHistoryDto
    {
          
 
		public Int32 TrsRcvHistoryId { get; set; }  
 
		public Int32 TRHItmRef { get; set; }  
 
		public DateTime TRHItmDate { get; set; }  
 
		public String TRHItmState { get; set; }  
 
		public Nullable<Int32> TRHOprId { get; set; }  
 
		public Nullable<Int32> TRHTrsOpr { get; set; } 
    }
}


