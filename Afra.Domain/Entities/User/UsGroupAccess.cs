using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UsGroupAccess : BaseEntity
    {
          
 
		public Int32 UsGrpAccId { get; set; }  
 
		public Int32 GroupRef { get; set; }  
 
		public String AccessName { get; set; }  
 
		public Int32 Rights { get; set; } 
    }
}


