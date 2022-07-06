using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrLimitUser : BaseEntity
    {
          
 
		public Int32 GnrLimitUserId { get; set; }  
 
		public Int32 GLUGroupRef { get; set; }  
 
		public Int32 GLUUserRef { get; set; }  
 
		public Int32 GLUObjRef { get; set; }  
 
		public Nullable<Int32> GLUAccess { get; set; } 
    }
}


