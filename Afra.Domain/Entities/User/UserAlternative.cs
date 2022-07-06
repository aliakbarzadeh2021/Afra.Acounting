using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserAlternative : BaseEntity
    {
          
 
		public Int32 MainUserRef { get; set; }  
 
		public Int32 AlterUserRef { get; set; }  
 
		public Nullable<Int32> OrderInd { get; set; } 
    }
}


