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
    public class EditInvPartDLInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartDLInfId { get; set; }  
 
		public Nullable<Int32> IPDIPartRef { get; set; }  
 
		public DateTime IPDIDate { get; set; }  
 
		public String IPDISupplier { get; set; }  
 
		public Nullable<Int32> IPDISupIsLimit { get; set; }  
 
		public String IPDIConsumer { get; set; }  
 
		public Nullable<Int32> IPDIConsIsLimit { get; set; }  
 
		public Nullable<Double> IPDIBuyPrice { get; set; } 

        public void Validate()
        {
            new EditInvPartDLInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
