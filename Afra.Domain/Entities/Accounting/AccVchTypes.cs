using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccVchTypes : BaseEntity
    {
          
 
		public Int32 VchTypeId { get; set; }  
 
		public String VchTypeDescr { get; set; } 
    }
}


