using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class UserProcessStpDto
    {
          
 
		public Int32 UserProcessStpId { get; set; }  
 
		public Int32 UPSHdrRef { get; set; }  
 
		public Int32 UPSStepRef { get; set; }  
 
		public Int32 UPSUserRef { get; set; }  
 
		public Nullable<Int32> UPSRefId { get; set; }  
 
		public DateTime UPSCrDate { get; set; }  
 
		public DateTime UPSShDate { get; set; }  
 
		public DateTime UPSEnDate { get; set; } 
    }
}


