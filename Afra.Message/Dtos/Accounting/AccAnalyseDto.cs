using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class AccAnalyseDto
    {
          
 
		public Int32 DebitVchItmRef { get; set; }  
 
		public Int32 CreditVchItmRef { get; set; }  
 
		public Nullable<Int32> AccLevel { get; set; }  
 
		public Nullable<Int32> State { get; set; } 
    }
}


