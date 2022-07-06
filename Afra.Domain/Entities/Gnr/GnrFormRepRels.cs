using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrFormRepRels : BaseEntity
    {
          
 
		public Int32 FormRepRelId { get; set; }  
 
		public String FRRFormId { get; set; }  
 
		public Nullable<Int32> FRRepRef { get; set; } 
    }
}


