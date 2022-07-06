using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayLoanRcvDto
    {
          
 
		public Int32 PayLoanRcvId { get; set; }  
 
		public Int32 PLRLoanRef { get; set; }  
 
		public Int32 PLRPersRef { get; set; }  
 
		public DateTime PLRRcvDate { get; set; }  
 
		public Int32 PLRBeginYear { get; set; }  
 
		public Int32 PLRBeginMonth { get; set; }  
 
		public Int32 PLRAmount { get; set; }  
 
		public Int32 PLRCalcAmnt { get; set; }  
 
		public Int32 PLRMonthVal { get; set; }  
 
		public Nullable<Int32> PLRMonthCnt { get; set; }  
 
		public Nullable<Int32> PLRDiffVal { get; set; }  
 
		public Nullable<Int32> PLRDValPayType { get; set; }  
 
		public Nullable<Int32> PLRGrpRef { get; set; }  
 
		public Nullable<Int32> PLRIYearMonth { get; set; } 
    }
}


