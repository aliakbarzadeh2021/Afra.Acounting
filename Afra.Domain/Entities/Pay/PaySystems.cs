using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PaySystems : BaseEntity
    {
          
 
		public Int32 PaySystemId { get; set; }  
 
		public String PSTitle { get; set; } 
    }
}


