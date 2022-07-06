using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdMatPkg : BaseEntity
    {
          
 
		public Int32 PMPMatRef { get; set; }  
 
		public Nullable<Double> PMPPkgQty { get; set; } 
    }
}


