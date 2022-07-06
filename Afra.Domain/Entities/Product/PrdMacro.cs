using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class PrdMacro : BaseEntity
    {
          
 
		public Int32 PMProdRef { get; set; }  
 
		public DateTime PMSDate { get; set; }  
 
		public DateTime PMEDate { get; set; }  
 
		public String PMDur { get; set; }  
 
		public Double PMQty { get; set; }  
 
		public Int32 PMYear { get; set; } 
    }
}


