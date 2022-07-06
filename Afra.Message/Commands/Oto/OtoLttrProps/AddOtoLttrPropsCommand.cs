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
    public class AddOtoLttrPropsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OLPLttrRef { get; set; }  
 
		public Int32 OLPPropVal { get; set; } 

        public void Validate()
        {
            new AddOtoLttrPropsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
