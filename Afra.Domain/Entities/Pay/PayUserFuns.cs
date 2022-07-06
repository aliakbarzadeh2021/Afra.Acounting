using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayUserFuns : BaseEntity
    {
          
 
		public Int32 PayUserFuncId { get; set; }  
 
		public String PUFTitle { get; set; }  
 
		public String PUFName { get; set; } 
    }
}


