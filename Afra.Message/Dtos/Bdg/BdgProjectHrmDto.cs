using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class BdgProjectHrmDto
    {
          
 
		public Int32 BdgProjectHrmId { get; set; }  
 
		public Int32 BPHHdrRef { get; set; }  
 
		public String BPHDescr { get; set; }  
 
		public Nullable<Int32> BPHQty { get; set; }  
 
		public Nullable<Int32> BPHDay { get; set; }  
 
		public Nullable<Double> BPHCost { get; set; } 
    }
}


