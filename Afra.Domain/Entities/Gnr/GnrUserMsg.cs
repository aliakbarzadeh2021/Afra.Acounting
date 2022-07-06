using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserMsg : BaseEntity
    {
          
 
		public Int32 GnrUserMsgId { get; set; }  
 
		public Int32 GUMFromUser { get; set; }  
 
		public Int32 GUMToUser { get; set; }  
 
		public String GUMMsg { get; set; }  
 
		public Nullable<Int32> GUMSit { get; set; }  
 
		public Nullable<Int32> GUMAlarmRef { get; set; }  
 
		public DateTime GUMDate { get; set; } 
    }
}


