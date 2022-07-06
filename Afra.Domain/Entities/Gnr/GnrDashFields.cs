using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class GnrDashFields : BaseEntity
    {
          
 
		public Int32 GDFHdrRef { get; set; }  
 
		public String GDFName { get; set; }  
 
		public String GDFFormula { get; set; } 
    }
}


