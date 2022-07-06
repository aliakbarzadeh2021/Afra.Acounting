using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoFlowCrs : BaseEntity
    {
          
 
		public Int32 OtoFlowRef { get; set; }  
 
		public Int32 OFCUserRef { get; set; }  
 
		public DateTime OFCRcvDate { get; set; } 
    }
}


