using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class SMSOperateDet : BaseEntity
    {
          
 
		public Int32 SMSOperateDetId { get; set; }  
 
		public DateTime SMSOperateDate { get; set; }  
 
		public Int32 SMSOperateRef { get; set; }  
 
		public String SODNumber { get; set; }  
 
		public String SODDeliver { get; set; }  
 
		public String SODText { get; set; }  
 
		public DateTime SODSendDate { get; set; }  
 
		public DateTime SODRcvDate { get; set; }  
 
		public Nullable<Int32> SODSit { get; set; }  
 
		public String SODRefId { get; set; }  
 
		public String SODError { get; set; } 
    }
}


