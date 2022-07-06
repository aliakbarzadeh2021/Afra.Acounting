using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayGrpValStat : BaseEntity
    {
          
 
		public Int32 PayGrpValStatId { get; set; }  
 
		public Nullable<Int32> PGVSNum { get; set; }  
 
		public DateTime PGVSIssueDate { get; set; }  
 
		public DateTime PGVSEffectDate { get; set; }  
 
		public String PGVSDescr { get; set; } 
    }
}


