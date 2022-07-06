using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayCompBranchsDto
    {
          
 
		public Int32 PayCompBranchId { get; set; }  
 
		public Int32 PCBCompRef { get; set; }  
 
		public Int32 PCBCrspndRef { get; set; }  
 
		public String PCBCompID { get; set; }  
 
		public Nullable<Int32> PCBIsMain { get; set; }  
 
		public String PCBContNum { get; set; } 
    }
}


