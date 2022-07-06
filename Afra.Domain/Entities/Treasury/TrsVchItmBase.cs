using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsVchItmBase : BaseEntity
    {
          
 
		public Int32 TVIBItmId { get; set; }  
 
		public Int32 TVIBRefId { get; set; }  
 
		public String TVIBRefType { get; set; } 
    }
}


