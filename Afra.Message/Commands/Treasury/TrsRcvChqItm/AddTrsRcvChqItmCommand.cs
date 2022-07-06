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
    public class AddTrsRcvChqItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RcvChqOprItmId { get; set; }  
 
		public Nullable<Int32> RCOHdrRef { get; set; }  
 
		public Int32 RCOIAccOprRef { get; set; }  
 
		public Nullable<Int32> RCOIBankAccRef { get; set; }  
 
		public Nullable<Int32> RCOICashRef { get; set; }  
 
		public Int32 RCOIChqRef { get; set; }  
 
		public Nullable<Int32> RCOISeq { get; set; }  
 
		public String RCOIDescr { get; set; }  
 
		public DateTime RCOIDate { get; set; }  
 
		public String RCOIDLRef { get; set; } 

        public void Validate()
        {
            new AddTrsRcvChqItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
