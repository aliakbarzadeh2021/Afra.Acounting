using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartGrpRel : BaseEntity
    {
          
 
		public Int32 IGRGrpRef { get; set; }  
 
		public Int32 IGRPartRef { get; set; }  
 
		public Int32 IGRActive { get; set; } 
    }
}


