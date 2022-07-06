using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PartFormulaDetDto
    {
          
 
		public Int32 PartFrmlDetId { get; set; }  
 
		public Int32 PFDHdrRef { get; set; }  
 
		public Int32 PFDPartRef { get; set; }  
 
		public Nullable<Double> PFDQtyRatio { get; set; }  
 
		public Nullable<Double> PFDWast { get; set; } 
    }
}


