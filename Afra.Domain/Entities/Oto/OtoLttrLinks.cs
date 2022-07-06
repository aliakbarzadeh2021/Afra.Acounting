using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoLttrLinks : BaseEntity
    {
          
 
		public Int32 OtoLttrLinksId { get; set; }  
 
		public Int32 OLLBaseLttr { get; set; }  
 
		public Int32 OLLRelLttr { get; set; }  
 
		public Int32 OLLType { get; set; }  
 
		public String OLLDescr { get; set; } 
    }
}


