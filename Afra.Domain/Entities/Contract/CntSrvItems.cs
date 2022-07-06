using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntSrvItems : BaseEntity
    {
          
 
		public Int32 CntSrvItemId { get; set; }  
 
		public String CSITitle { get; set; }  
 
		public String CSISLRef { get; set; } 
    }
}


