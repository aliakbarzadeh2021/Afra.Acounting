using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayLoanHistoryDto
    {
          
 
		public Int32 PayLoanHostoryId { get; set; }  
 
		public Int32 PLHLoanRef { get; set; }  
 
		public Nullable<Int32> PLHState { get; set; }  
 
		public Int32 PLHIYearMonth { get; set; } 
    }
}


