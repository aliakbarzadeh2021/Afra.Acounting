using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdOrdSchedDto
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


