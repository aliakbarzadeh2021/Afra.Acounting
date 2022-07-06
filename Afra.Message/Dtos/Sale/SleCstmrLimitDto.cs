using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class SleCstmrLimitDto
    {
          
 
		public Int32 SleCstmrLimitId { get; set; }  
 
		public Int32 SCLCstmrRef { get; set; }  
 
		public DateTime SCLDate { get; set; }  
 
		public Nullable<Double> SCLAmount { get; set; } 
    }
}


