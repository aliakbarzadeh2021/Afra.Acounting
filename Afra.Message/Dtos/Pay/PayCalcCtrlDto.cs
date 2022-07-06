using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayCalcCtrlDto
    {
          
 
		public Int32 PayCalcCtrlId { get; set; }  
 
		public Nullable<Int32> PCCYearNum { get; set; }  
 
		public Nullable<Int32> PCCMonthNum { get; set; }  
 
		public Nullable<Int32> PCCType { get; set; }  
 
		public Nullable<Int32> PCCUserRef { get; set; }  
 
		public Nullable<Int32> PCCSit { get; set; }  
 
		public String PCCTitle { get; set; }  
 
		public Nullable<Int32> PCCKind { get; set; }  
 
		public String PCCDefQry { get; set; } 
    }
}


