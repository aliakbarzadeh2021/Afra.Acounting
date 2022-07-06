using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrProcessDetUsers : BaseEntity
    {
          
 
		public Int32 GPDUHdrRef { get; set; }  
 
		public Int32 GPDUUsrRef { get; set; }  
 
		public Nullable<Int32> GPDUInd { get; set; }  
 
		public Nullable<Int32> GPDUAnsDur { get; set; }  
 
		public Nullable<Int32> GPDUPersuitUser { get; set; } 
    }
}


