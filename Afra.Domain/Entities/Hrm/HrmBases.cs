using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmBases : BaseEntity
    {
          
 
		public Int32 HrmBaseId { get; set; }  
 
		public String HrmBaseCode { get; set; }  
 
		public String HrmBaseTitle { get; set; } 
    }
}


