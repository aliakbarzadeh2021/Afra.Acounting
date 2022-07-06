using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsRcvChqOpr : BaseEntity
    {
          
 
		public Int32 RCOHdrId { get; set; }  
 
		public Int32 RCONum { get; set; }  
 
		public Nullable<Int32> RCOLocalNum { get; set; }  
 
		public DateTime RCODate { get; set; }  
 
		public String RCODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> RCOState { get; set; }  
 
		public Nullable<Int32> TRAccPrdRef { get; set; }  
 
		public Nullable<Int32> RCOCreator { get; set; }  
 
		public Nullable<Int32> RCOSit { get; set; } 
    }
}


