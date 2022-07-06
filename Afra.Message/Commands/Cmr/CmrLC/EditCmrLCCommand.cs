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
    public class EditCmrLCCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrLCId { get; set; }  
 
		public String CLNum { get; set; }  
 
		public Int32 CLMainBank { get; set; }  
 
		public Int32 CLFactRef { get; set; }  
 
		public DateTime CLDate { get; set; }  
 
		public DateTime CLIssDate { get; set; }  
 
		public DateTime CLAdvDate { get; set; }  
 
		public String CLDescr { get; set; }  
 
		public Nullable<Int32> CLBrkBank { get; set; }  
 
		public Nullable<Double> CLBankPrePay { get; set; }  
 
		public Nullable<Double> CLTransAmnt { get; set; }  
 
		public DateTime CLTransLDate { get; set; }  
 
		public Nullable<Double> CLAmount { get; set; }  
 
		public Nullable<Int32> CLCurRef { get; set; }  
 
		public Nullable<Double> CLCurRate { get; set; } 

        public void Validate()
        {
            new EditCmrLCCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
