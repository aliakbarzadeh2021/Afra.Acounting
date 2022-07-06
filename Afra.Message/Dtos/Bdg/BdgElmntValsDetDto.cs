using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgElmntValsDetDto
    {
          
 
		public Int32 BEVDParentRef { get; set; }  
 
		public Int32 PEVDMonth { get; set; }  
 
		public Nullable<Double> PEVDVal { get; set; }  
 
		public Int32 BEVDMonth { get; set; }  
 
		public Nullable<Double> BEVDVal { get; set; } 
    }
}


