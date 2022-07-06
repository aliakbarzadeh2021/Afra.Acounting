using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class BdgHrmValsPers : BaseEntity
    {
          
 
		public Int32 BdgHrmValsPersId { get; set; }  
 
		public Int32 BHVPParentRef { get; set; }  
 
		public String BHVPFullName { get; set; }  
 
		public Double BHVPAmount { get; set; }  
 
		public Nullable<Int32> BHVPCurRef { get; set; } 
    }
}


