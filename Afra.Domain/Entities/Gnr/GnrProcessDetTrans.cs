using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDetTrans : BaseEntity
    {
          
 
		public Int32 GnrProcessDetTransId { get; set; }  
 
		public Int32 GPDTItemRef { get; set; }  
 
		public Int32 GPDTProcRef { get; set; } 
    }
}


