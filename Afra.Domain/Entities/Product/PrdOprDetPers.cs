using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOprDetPers : BaseEntity
    {
          
 
		public Int32 PODPItmRef { get; set; }  
 
		public Int32 PODPPersRef { get; set; }  
 
		public Int32 PODPShiftRef { get; set; }  
 
		public DateTime PODPTime { get; set; } 
    }
}


