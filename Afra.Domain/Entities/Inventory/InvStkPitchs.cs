using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvStkPitchs : BaseEntity
    {
          
 
		public Int32 InvStkPitchId { get; set; }  
 
		public Nullable<Int32> ISPParent { get; set; }  
 
		public String ISPCode { get; set; }  
 
		public String ISPTitle { get; set; } 
    }
}


