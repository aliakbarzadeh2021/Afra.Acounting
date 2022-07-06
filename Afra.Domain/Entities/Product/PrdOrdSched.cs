using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOrdSched : BaseEntity
    {
          
 
		public Int32 PrdOrdSchedId { get; set; }  
 
		public Int32 POSItmRef { get; set; }  
 
		public Int32 POSPartRef { get; set; }  
 
		public Nullable<Int32> POSFrmlRef { get; set; }  
 
		public DateTime POSVDStart { get; set; }  
 
		public DateTime POSVTStart { get; set; }  
 
		public Nullable<Int32> POSState { get; set; }  
 
		public Nullable<Int32> POSPriority { get; set; }  
 
		public Nullable<Int32> POSMashRef { get; set; }  
 
		public Nullable<Int32> POSWStation { get; set; } 
    }
}


