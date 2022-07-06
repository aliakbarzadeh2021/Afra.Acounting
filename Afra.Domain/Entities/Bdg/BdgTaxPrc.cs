using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgTaxPrc : BaseEntity
    {
          
 
		public Int32 BdgTaxPrcId { get; set; }  
 
		public Int32 BTPElmnt { get; set; }  
 
		public Int32 BTPType { get; set; }  
 
		public String BTPSLRef { get; set; }  
 
		public String BTPDLRef { get; set; }  
 
		public String BTPDL5Ref { get; set; }  
 
		public String BTPDL6Ref { get; set; }  
 
		public String BTPDL7Ref { get; set; }  
 
		public Nullable<Double> BTPPercent { get; set; }  
 
		public Nullable<Int32> BTPPeriodRef { get; set; } 
    }
}


