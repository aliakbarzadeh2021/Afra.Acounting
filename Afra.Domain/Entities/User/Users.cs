using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class Users : BaseEntity
    {
          
 
		public Int32 UserId { get; set; }  
 
		public String UserName { get; set; }  
 
		public String UserPass { get; set; }  
 
		public Nullable<Int32> UserGroupRef { get; set; }  
 
		public Byte[] UserSign { get; set; }  
 
		public Nullable<Int32> UserState { get; set; } 
    }
}


