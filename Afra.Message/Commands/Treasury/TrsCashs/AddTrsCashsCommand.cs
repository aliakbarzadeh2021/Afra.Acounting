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
    public class AddTrsCashsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsCashId { get; set; }  
 
		public String TCName { get; set; }  
 
		public Int32 TCCashier { get; set; }  
 
		public Double TCFirstQty { get; set; }  
 
		public String TCDLRef { get; set; } 

        public void Validate()
        {
            new AddTrsCashsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
