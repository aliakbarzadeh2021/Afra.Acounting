using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class OtoFiles : BaseEntity
    {
          
 
		public Int32 OtoFilesId { get; set; }  
 
		public Nullable<Int32> OFParent { get; set; }  
 
		public String OFTitle { get; set; } 
    }
}


