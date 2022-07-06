using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvStckPeriod : BaseEntity
    {
          
 
		public Int32 InvStckPeriodID { get; set; }  
 
		public String ISPTitle { get; set; }  
 
		public DateTime ISPDate { get; set; }  
 
		public Int32 ISPSCount { get; set; }  
 
		public Nullable<Double> ISPCnt1MinQty { get; set; }  
 
		public Nullable<Double> ISPCnt1MinAmount { get; set; }  
 
		public Nullable<Double> ISPCnt1MinVch { get; set; }  
 
		public Nullable<Int32> ISPList1Cond { get; set; }  
 
		public Nullable<Int32> ISPList2Cond { get; set; }  
 
		public Nullable<Int32> ISPList3Cond { get; set; }  
 
		public Nullable<Int32> ISPAccPrdRef { get; set; }  
 
		public Nullable<Int32> ISPIncVchRef { get; set; }  
 
		public Nullable<Int32> ISPDecVchRef { get; set; } 
    }
}


