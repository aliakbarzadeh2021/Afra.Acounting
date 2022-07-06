using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserSignRight : BaseEntity
    {
          
 
		public Int32 UserSignRightId { get; set; }  
 
		public Nullable<Int32> USRUserRef { get; set; }  
 
		public Nullable<Int32> USRToUser { get; set; }  
 
		public Nullable<Int32> USRAccess { get; set; } 
    }
}


