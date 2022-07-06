using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserRepAccess : BaseEntity
    {
          
 
		public Int32 UserRef { get; set; }  
 
		public Int32 ReportRef { get; set; }  
 
		public Nullable<Int32> Access { get; set; } 
    }
}


