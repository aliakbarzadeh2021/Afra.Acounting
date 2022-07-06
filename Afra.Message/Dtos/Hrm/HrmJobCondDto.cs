using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmJobCondDto
    {
          
 
		public Int32 HrmJobCondId { get; set; }  
 
		public Int32 HJCJobRef { get; set; }  
 
		public DateTime HJCDate { get; set; }  
 
		public String HJCCondStr { get; set; }  
 
		public String HJCCondTitle { get; set; }  
 
		public String HJCCondSQL { get; set; } 
    }
}


