using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class UserArchType : BaseEntity
    {
          
 
		public Int32 UserArchTypeId { get; set; }  
 
		public Int32 UATUsrRef { get; set; }  
 
		public String UATTitle { get; set; }  
 
		public Nullable<Int32> UATParent { get; set; } 
    }
}


