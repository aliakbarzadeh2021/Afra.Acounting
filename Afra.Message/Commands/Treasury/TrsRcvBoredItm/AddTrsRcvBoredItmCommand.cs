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
    public class AddTrsRcvBoredItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RcvBoredOprItmId { get; set; }  
 
		public Nullable<Int32> RBOHdrRef { get; set; }  
 
		public Int32 RBOIAccOprRef { get; set; }  
 
		public Nullable<Int32> RBOIBankAccRef { get; set; }  
 
		public Nullable<Int32> RBOICashRef { get; set; }  
 
		public Int32 RBOIBoredRef { get; set; }  
 
		public Nullable<Int32> RBOISeq { get; set; }  
 
		public String RBOIDescr { get; set; }  
 
		public DateTime RBOIDate { get; set; }  
 
		public String RBOIDLRef { get; set; } 

        public void Validate()
        {
            new AddTrsRcvBoredItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
