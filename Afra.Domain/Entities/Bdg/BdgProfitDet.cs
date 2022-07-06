using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProfitDet : BaseEntity
    {
          
 
		public Int32 BdgProfitDetId { get; set; }  
 
		public String BPDDLRef { get; set; }  
 
		public String BPDDL5Ref { get; set; }  
 
		public String BPDDL6Ref { get; set; }  
 
		public String BPDDL7Ref { get; set; }  
 
		public Double BPDPercent { get; set; }  
 
		public Int32 BPDPeriodRef { get; set; } 
    }
}


