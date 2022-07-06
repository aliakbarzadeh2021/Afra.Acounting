using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsVchSrcUse : BaseEntity
    {
          
 
		public Int32 TrsVchSrcUseId { get; set; }  
 
		public Int32 TVSUItemRef { get; set; }  
 
		public Int32 TVSUSrcRef { get; set; }  
 
		public Double TVSUAmount { get; set; } 
    }
}


