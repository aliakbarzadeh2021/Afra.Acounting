using Afra.Domain.Entities.Base;
using Afra.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Afra.Domain.Entities
{
    public class TrsCalcFormula : BaseEntity
    {
          
 
		public Int32 TrsCalcFormulId { get; set; }  
 
		public Int32 TFCType { get; set; }  
 
		public Nullable<Int32> TFCKind { get; set; }  
 
		public String TFCFormula { get; set; }  
 
		public String TFCInstCalc { get; set; } 
    }
}


