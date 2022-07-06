using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgProjDetInf : BaseEntity
    {
          
 
		public Int32 BPDIParentRef { get; set; }  
 
		public Int32 BPDIMonth { get; set; }  
 
		public Nullable<Double> BPDIAmount { get; set; } 
    }
}


