using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class InvPartUnitsDto
    {
          
 
		public Int32 PUPartRef { get; set; }  
 
		public Int32 PUUnitRef { get; set; }  
 
		public Nullable<Double> PURatio { get; set; }  
 
		public Nullable<Int32> PUCanChange { get; set; }  
 
		public Nullable<Int32> PUIsDef { get; set; } 
    }
}


