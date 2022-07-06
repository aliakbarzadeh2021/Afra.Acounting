using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayBdgState : BaseEntity
    {
          
 
		public Int32 PayBdgStateId { get; set; }  
 
		public Int32 PBSPersRef { get; set; }  
 
		public Int32 PBSYearNum { get; set; }  
 
		public Int32 PBSMonthNum { get; set; }  
 
		public Nullable<Int32> PBSCalcType { get; set; }  
 
		public Nullable<Int32> PBSYearMonth { get; set; } 
    }
}


