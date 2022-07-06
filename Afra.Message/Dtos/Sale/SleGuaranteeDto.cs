using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleGuaranteeDto
    {
          
 
		public Int32 SleGuaranteeId { get; set; }  
 
		public String SGTitle { get; set; }  
 
		public String SGSLRef { get; set; }  
 
		public Nullable<Int32> SGDL4Type { get; set; }  
 
		public Nullable<Int32> SGDL5Type { get; set; }  
 
		public Nullable<Int32> SGDL6Type { get; set; } 
    }
}


