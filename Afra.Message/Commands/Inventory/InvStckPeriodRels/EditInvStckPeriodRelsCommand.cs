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
    public class EditInvStckPeriodRelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 SRStckPeriodRef { get; set; }  
 
		public Int32 SRStockRef { get; set; }  
 
		public Nullable<Int32> Active { get; set; } 

        public void Validate()
        {
            new EditInvStckPeriodRelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
