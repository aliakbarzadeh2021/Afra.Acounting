using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserProcess : BaseEntity
    {
          
 
		public Int32 UserProcessId { get; set; }  
 
		public Int32 UPProcessRef { get; set; }  
 
		public DateTime UPCrDate { get; set; }  
 
		public Int32 UPUserRef { get; set; } 
    }
}


