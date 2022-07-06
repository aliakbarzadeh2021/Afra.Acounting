using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsPayChqOpr : BaseEntity
    {
          
 
		public Int32 PCOHdrId { get; set; }  
 
		public Int32 PCONum { get; set; }  
 
		public Nullable<Int32> PCOLocalNum { get; set; }  
 
		public DateTime PCODate { get; set; }  
 
		public String PCODescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> PCOState { get; set; }  
 
		public Nullable<Int32> TPAccPrdRef { get; set; }  
 
		public Nullable<Int32> PCOCreator { get; set; }  
 
		public Nullable<Int32> PCOSit { get; set; } 
    }
}


