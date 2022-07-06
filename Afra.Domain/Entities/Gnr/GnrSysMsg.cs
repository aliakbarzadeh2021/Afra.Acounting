using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysMsg : BaseEntity
    {
          
 
		public Int32 GnrSysMsgId { get; set; }  
 
		public String GSMTitle { get; set; }  
 
		public String GSMDescr { get; set; }  
 
		public DateTime GSMSDate { get; set; }  
 
		public DateTime GSMEDate { get; set; }  
 
		public Nullable<Int32> GSMType { get; set; }  
 
		public Int32 GSMCreator { get; set; } 
    }
}


