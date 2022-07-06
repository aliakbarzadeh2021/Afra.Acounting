using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PrdPOrdItmDetDto
    {
          
 
		public Int32 PPOIDItmRef { get; set; }  
 
		public Int32 PPOIDPartRef { get; set; }  
 
		public Nullable<Int32> PPOIDFrmlRef { get; set; }  
 
		public Nullable<Int32> PPOIDLev { get; set; }  
 
		public Nullable<Double> PPOIDQty { get; set; } 
    }
}


