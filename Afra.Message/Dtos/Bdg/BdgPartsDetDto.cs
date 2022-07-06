using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgPartsDetDto
    {
          
 
		public Int32 BPDParentRef { get; set; }  
 
		public Int32 BPDMonth { get; set; }  
 
		public Nullable<Double> BPDQty { get; set; }  
 
		public Nullable<Double> BPDPrice { get; set; }  
 
		public Nullable<Double> BPDCost { get; set; } 
    }
}


