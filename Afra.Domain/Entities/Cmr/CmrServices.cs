using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrServices : BaseEntity
    {
          
 
		public Int32 CmrServicesId { get; set; }  
 
		public String CSCode { get; set; }  
 
		public String CSTitle { get; set; } 
    }
}


