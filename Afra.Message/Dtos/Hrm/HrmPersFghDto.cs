using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class HrmPersFghDto
    {
          
 
		public Int32 PersFghId { get; set; }  
 
		public Nullable<Int32> PersFghPersRef { get; set; }  
 
		public DateTime PersFghDate { get; set; }  
 
		public String PersFghType { get; set; }  
 
		public Nullable<Int32> PersFghDay { get; set; }  
 
		public String PersFghDescr { get; set; } 
    }
}


