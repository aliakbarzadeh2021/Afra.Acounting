using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsersRels : BaseEntity
    {
          
 
		public Int32 MainUser { get; set; }  
 
		public Int32 RelUser { get; set; } 
    }
}


