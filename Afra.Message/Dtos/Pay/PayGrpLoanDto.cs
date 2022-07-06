using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Dtos
{
    public class PayGrpLoanDto
    {
          
 
		public Int32 PayGrpLoanId { get; set; }  
 
		public Nullable<Int32> PGLLoanRef { get; set; }  
 
		public DateTime PGLRcvDate { get; set; }  
 
		public Int32 PGLBeginYear { get; set; }  
 
		public Int32 PGLBeginMonth { get; set; }  
 
		public Int32 PGLAmount { get; set; }  
 
		public Int32 PGLCalcAmnt { get; set; }  
 
		public Int32 PGLMonthVal { get; set; }  
 
		public Nullable<Int32> PGLMonthCnt { get; set; }  
 
		public Nullable<Int32> PGLDiffVal { get; set; }  
 
		public Nullable<Int32> PGLDValPayType { get; set; } 
    }
}


