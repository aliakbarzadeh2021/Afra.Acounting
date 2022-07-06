using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntContText : BaseEntity
    {
          
 
		public Int32 CntContTextId { get; set; }  
 
		public Int32 CCTContRef { get; set; }  
 
		public Nullable<Int32> CCTRefId { get; set; }  
 
		public String CCTDescr { get; set; } 
    }
}


