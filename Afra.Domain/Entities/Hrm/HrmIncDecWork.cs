using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmIncDecWork : BaseEntity
    {
          
 
		public Int32 HrmIncDecWorkId { get; set; }  
 
		public Nullable<Int32> HIDWNum { get; set; }  
 
		public DateTime HIDWDate { get; set; }  
 
		public Nullable<Int32> HIDWPersRef { get; set; }  
 
		public Nullable<Int32> HIDWType { get; set; }  
 
		public DateTime HIDWTime { get; set; } 
    }
}


