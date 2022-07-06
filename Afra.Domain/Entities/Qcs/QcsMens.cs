using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class QcsMens : BaseEntity
    {
          
 
		public Int32 QcsMenId { get; set; }  
 
		public Int32 QMCrsRef { get; set; }  
 
		public Int32 QMDegreeRef { get; set; } 
    }
}


