using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrUserRole : BaseEntity
    {
          
 
		public Nullable<Int32> GURUserRef { get; set; }  
 
		public Int32 GURRoleRef { get; set; } 
    }
}


