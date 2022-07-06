using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgTaxDetDto
    {
          
 
		public Int32 BdgTaxDetId { get; set; }  
 
		public Int32 BTDType { get; set; }  
 
		public Int32 BTDParentRef { get; set; }  
 
		public Int32 BTDTaxRef { get; set; }  
 
		public Nullable<Int32> BTDPriority { get; set; }  
 
		public Double BTDVal { get; set; } 
    }
}


