using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrSysLogs : BaseEntity
    {
          
 
		public Int32 AsmLogId { get; set; }  
 
		public String LogTableName { get; set; }  
 
		public Nullable<Int32> LogOprType { get; set; }  
 
		public Nullable<Int32> LogParentId { get; set; }  
 
		public Nullable<Int32> LogUserRef { get; set; }  
 
		public String LogDate { get; set; }  
 
		public String LogDescr { get; set; }  
 
		public String UserDescr { get; set; } 
    }
}


