using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgContAcc : BaseEntity
    {
          
 
		public Int32 BdgContAccId { get; set; }  
 
		public Int32 BCAContRef { get; set; }  
 
		public String BCASLCode { get; set; }  
 
		public Double BCAAmount { get; set; } 
    }
}


