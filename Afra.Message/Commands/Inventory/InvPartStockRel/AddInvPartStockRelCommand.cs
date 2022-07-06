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
    public class AddInvPartStockRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PSRPartRef { get; set; }  
 
		public Int32 PSRStockRef { get; set; }  
 
		public Nullable<Int32> PSRActive { get; set; } 

        public void Validate()
        {
            new AddInvPartStockRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
