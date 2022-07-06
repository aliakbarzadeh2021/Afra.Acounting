using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class HrmStatTypes : BaseEntity
    {
          
 
		public Int32 HrmStatTypeId { get; set; }  
 
		public String HSTDescr { get; set; }  
 
		public String HSTKind { get; set; }  
 
		public String HSTRole { get; set; }  
 
		public String HSTExElmnt { get; set; } 
    }
}


