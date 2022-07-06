using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrTools : BaseEntity
    {
          
 
		public Int32 GnrToolsId { get; set; }  
 
		public String GTTitle { get; set; }  
 
		public String GTSysRef { get; set; }  
 
		public String GTListQry { get; set; }  
 
		public String GTOprQry { get; set; } 
    }
}


