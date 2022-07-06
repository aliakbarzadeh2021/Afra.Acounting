using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmVacMthodsDto
    {
          
 
		public Int32 HrmVacMthodId { get; set; }  
 
		public Int32 HVMVacRef { get; set; }  
 
		public Int32 HVMEmpRef { get; set; }  
 
		public Int32 HVMYear { get; set; }  
 
		public String HVMStVal { get; set; }  
 
		public String HVMMaxVal { get; set; }  
 
		public String HVMFixVal { get; set; }  
 
		public Nullable<Int32> HVMTransRem { get; set; } 
    }
}


