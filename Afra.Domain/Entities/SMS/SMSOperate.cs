using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SMSOperate : BaseEntity
    {
          
 
		public Int32 SMSOperateId { get; set; }  
 
		public Int32 SMSMethodRef { get; set; }  
 
		public Nullable<Int32> SMSRole { get; set; }  
 
		public Nullable<Int32> SMSDur { get; set; }  
 
		public Nullable<Double> SMSDelay { get; set; }  
 
		public DateTime SMSStartDate { get; set; } 
    }
}


