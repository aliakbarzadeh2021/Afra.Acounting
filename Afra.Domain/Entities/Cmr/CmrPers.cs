using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CmrPers : BaseEntity
    {
          
 
		public Int32 CmrPersId { get; set; }  
 
		public Int32 CPCrspndRef { get; set; }  
 
		public Nullable<Int32> CPType { get; set; } 
    }
}


