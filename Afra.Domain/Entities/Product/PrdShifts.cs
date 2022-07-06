using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdShifts : BaseEntity
    {
          
 
		public Int32 PrdShiftId { get; set; }  
 
		public String PSTitle { get; set; }  
 
		public DateTime PSStTime { get; set; }  
 
		public DateTime PSEnTime { get; set; } 
    }
}


