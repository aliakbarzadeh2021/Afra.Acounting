using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayVchDetInfs : BaseEntity
    {
          
 
		public Int32 PayVchDetId { get; set; }  
 
		public Int32 PayVchDetRef { get; set; }  
 
		public Nullable<Int32> PVDEmpRef { get; set; }  
 
		public Nullable<Int32> PVDCostCntrRef { get; set; } 
    }
}


