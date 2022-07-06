using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class InvPartParams : BaseEntity
    {
          
 
		public Int32 InvPartParamId { get; set; }  
 
		public Int32 IPPPartRef { get; set; }  
 
		public String IPPParamRef { get; set; }  
 
		public String IPPVal { get; set; } 
    }
}


