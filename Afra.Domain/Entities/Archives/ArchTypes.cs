using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ArchTypes : BaseEntity
    {
          
 
		public Int32 ArchTypeId { get; set; }  
 
		public Int32 AcTTableRef { get; set; }  
 
		public String AcTTitle { get; set; }  
 
		public Nullable<Int32> AcTIsDef { get; set; }  
 
		public Nullable<Int32> AcGrpRef { get; set; } 
    }
}


