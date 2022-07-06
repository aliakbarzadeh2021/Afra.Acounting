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
    public class AddBdgBalanceValsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BBVDParentRef { get; set; }  
 
		public Int32 BBVDMonth { get; set; }  
 
		public Nullable<Double> BBVDVal { get; set; } 

        public void Validate()
        {
            new AddBdgBalanceValsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
