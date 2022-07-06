using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmIncDecVac : BaseEntity
    {
          
 
		public Int32 HrmIncDecVacId { get; set; }  
 
		public Nullable<Int32> HIDVNum { get; set; }  
 
		public DateTime HIDVDate { get; set; }  
 
		public Nullable<Int32> HIDVPersRef { get; set; }  
 
		public Nullable<Int32> HIDVType { get; set; }  
 
		public DateTime HIDVTime { get; set; } 
    }
}


