using Afra.Message.Base;
using Afra.Message.Extentions;
using Afra.Message.Validators;
using Afra.Infrastructure.Enum;
using System;

namespace Afra.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddPayGrpLoanCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
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

        public void Validate()
        {
            new AddPayGrpLoanCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
