using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayTaxTableDto
    {
          
 
		public Int32 PayTaxTblId { get; set; }  
 
		public String PTTTitle { get; set; }  
 
		public Int32 PTTIssueYear { get; set; }  
 
		public Int32 PTTIssueMonth { get; set; }  
 
		public String PTTGrpType { get; set; }  
 
		public Nullable<Int32> PTTIYearMonth { get; set; } 
    }
}


