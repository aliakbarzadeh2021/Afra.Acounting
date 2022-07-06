using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoLttrLabels : BaseEntity
    {
          
 
		public Int32 OLLRefType { get; set; }  
 
		public Int32 OLLRefId { get; set; }  
 
		public Int32 OLLabelRef { get; set; } 
    }
}


