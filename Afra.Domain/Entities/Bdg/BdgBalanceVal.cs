using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgBalanceVal : BaseEntity
    {
          
 
		public Int32 BdgBalanceValId { get; set; }  
 
		public Nullable<Int32> BBVType { get; set; }  
 
		public String BBVSLRef { get; set; }  
 
		public String BBVDLRef { get; set; }  
 
		public String BBVDL5Ref { get; set; }  
 
		public String BBVDL6Ref { get; set; }  
 
		public String BBVDL7Ref { get; set; }  
 
		public Nullable<Double> BBVAmount { get; set; }  
 
		public Int32 BBVPeriodRef { get; set; }  
 
		public Nullable<Int32> BBVCurRef { get; set; } 
    }
}


