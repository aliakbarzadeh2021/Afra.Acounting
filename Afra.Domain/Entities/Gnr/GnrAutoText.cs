using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrAutoText : BaseEntity
    {
          
 
		public Int32 GnrAutoTextId { get; set; }  
 
		public String GATFormRef { get; set; }  
 
		public String GATObjName { get; set; }  
 
		public String GATText { get; set; } 
    }
}


