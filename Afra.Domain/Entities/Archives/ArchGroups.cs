using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class ArchGroups : BaseEntity
    {
          
 
		public Int32 ArchGrpId { get; set; }  
 
		public String AcGTitle { get; set; }  
 
		public String AcSysRef { get; set; } 
    }
}


