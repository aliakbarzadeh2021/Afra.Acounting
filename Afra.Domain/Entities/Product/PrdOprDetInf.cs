using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdOprDetInf : BaseEntity
    {
          
 
		public Int32 PODIItmRef { get; set; }  
 
		public Int32 PODIType { get; set; }  
 
		public String PODITitle { get; set; }  
 
		public String PODIDescr { get; set; } 
    }
}


