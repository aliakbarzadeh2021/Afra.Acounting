using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrFormFlow : BaseEntity
    {
          
 
		public Int32 GnrFormFlowId { get; set; }  
 
		public String GFFTitle { get; set; }  
 
		public String GFFName { get; set; } 
    }
}


