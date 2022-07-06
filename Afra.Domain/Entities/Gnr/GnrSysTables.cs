using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysTables : BaseEntity
    {
          
 
		public Int32 GnrSysTableId { get; set; }  
 
		public String GSTName { get; set; }  
 
		public String GSTTitle { get; set; }  
 
		public Nullable<Int32> GSTParent { get; set; }  
 
		public String GSTKeyName { get; set; }  
 
		public String GSTRelKeyName { get; set; }  
 
		public String GSTSystem { get; set; }  
 
		public String GSTQuery { get; set; } 
    }
}


