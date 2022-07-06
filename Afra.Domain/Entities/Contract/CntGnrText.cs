using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntGnrText : BaseEntity
    {
          
 
		public Int32 CntGnrTextId { get; set; }  
 
		public Int32 CGTType { get; set; }  
 
		public String CGTContain { get; set; } 
    }
}


