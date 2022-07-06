using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserAccess : BaseEntity
    {
          
 
		public Int32 UsrAccId { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String AccessName { get; set; }  
 
		public Int32 Rights { get; set; } 
    }
}


