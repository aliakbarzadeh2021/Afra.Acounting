using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SleSrvPrcHdr : BaseEntity
    {
          
 
		public Int32 SleSrvPrcHdrID { get; set; }  
 
		public Nullable<Int32> SSPHBranchRef { get; set; }  
 
		public Int32 SSPHNum { get; set; }  
 
		public Nullable<Int32> SSPHLocalNum { get; set; }  
 
		public DateTime SSPHDate { get; set; }  
 
		public String SSPHDescr { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<Int32> Confimer { get; set; }  
 
		public Nullable<Int32> SSPHState { get; set; }  
 
		public Nullable<Int32> SSPAccPrdRef { get; set; }  
 
		public Nullable<Int32> SSPHCurRef { get; set; }  
 
		public Nullable<Double> SSPHCurRate { get; set; } 
    }
}


