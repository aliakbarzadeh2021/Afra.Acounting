using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class TrsCalcFormulaDto
    {
          
 
		public Int32 TrsCalcFormulId { get; set; }  
 
		public Int32 TFCType { get; set; }  
 
		public Nullable<Int32> TFCKind { get; set; }  
 
		public String TFCFormula { get; set; }  
 
		public String TFCInstCalc { get; set; } 
    }
}


