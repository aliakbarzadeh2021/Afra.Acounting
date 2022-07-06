using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayValStatsDto
    {
          
 
		public Int32 PayValStatId { get; set; }  
 
		public Int32 PVSPersRef { get; set; }  
 
		public DateTime PVSIssueDate { get; set; }  
 
		public DateTime PVSEffectDate { get; set; }  
 
		public String PVSDescr { get; set; }  
 
		public Nullable<Int32> PVSGrpStatRef { get; set; }  
 
		public String PVSIYrMonth { get; set; }  
 
		public String PVSEYrMonth { get; set; }  
 
		public Nullable<DateTime> PVSLastChange { get; set; }  
 
		public Nullable<Int32> PVSCreator { get; set; }  
 
		public Nullable<Int32> PVSSit { get; set; } 
    }
}


