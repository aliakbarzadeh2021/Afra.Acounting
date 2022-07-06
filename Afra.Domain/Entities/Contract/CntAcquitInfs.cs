using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class CntAcquitInfs : BaseEntity
    {
          
 
		public Int32 CntAcquitInfId { get; set; }  
 
		public Int32 CAIContRef { get; set; }  
 
		public String CAIType { get; set; }  
 
		public DateTime CAIDate { get; set; } 
    }
}


