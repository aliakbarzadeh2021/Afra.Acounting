using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PayFixElmnt : BaseEntity
    {
          
 
		public Int32 PayFixElmntId { get; set; }  
 
		public String PFETitle { get; set; } 
    }
}


