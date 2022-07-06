using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AccSLDLRel : BaseEntity
    {
          
 
		public String rel_SLRef { get; set; }  
 
		public String rel_DlType { get; set; }  
 
		public Int32 relType { get; set; } 
    }
}


