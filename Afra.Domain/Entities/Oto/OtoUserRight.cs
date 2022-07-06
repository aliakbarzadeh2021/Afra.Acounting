using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoUserRight : BaseEntity
    {
          
 
		public Int32 OtoUserRightId { get; set; }  
 
		public Int32 OURUserRef { get; set; }  
 
		public Int32 OURRelType { get; set; }  
 
		public Int32 OURRelId { get; set; }  
 
		public Int32 OURObjType { get; set; }  
 
		public Int32 OURAccess { get; set; } 
    }
}


