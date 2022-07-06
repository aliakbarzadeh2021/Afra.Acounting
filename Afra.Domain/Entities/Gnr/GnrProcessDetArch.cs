using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDetArch : BaseEntity
    {
          
 
		public Int32 GPDAHdrRef { get; set; }  
 
		public Int32 GPDAArchRef { get; set; }  
 
		public Nullable<Int32> GPDAForce { get; set; } 
    }
}


