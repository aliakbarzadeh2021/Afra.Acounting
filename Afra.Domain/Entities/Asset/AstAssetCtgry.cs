using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class AstAssetCtgry : BaseEntity
    {
          
 
		public Int32 AstAssetCtgryId { get; set; }  
 
		public String AACCode { get; set; }  
 
		public String AACName { get; set; } 
    }
}


