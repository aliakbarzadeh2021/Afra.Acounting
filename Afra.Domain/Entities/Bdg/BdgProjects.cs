using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProjects : BaseEntity
    {
          
 
		public Int32 BdgProjectId { get; set; }  
 
		public Int32 BPPrjRef { get; set; }  
 
		public Int32 BPType { get; set; }  
 
		public String BPDescr { get; set; }  
 
		public Int32 BPPeriodRef { get; set; } 
    }
}


