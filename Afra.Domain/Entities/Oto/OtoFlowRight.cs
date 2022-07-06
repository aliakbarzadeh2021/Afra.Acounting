using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoFlowRight : BaseEntity
    {
          
 
		public Int32 OtoFlowRightId { get; set; }  
 
		public Int32 OFRUserRef { get; set; }  
 
		public Int32 OFRToUser { get; set; }  
 
		public Nullable<Int32> OFRRight { get; set; } 
    }
}


