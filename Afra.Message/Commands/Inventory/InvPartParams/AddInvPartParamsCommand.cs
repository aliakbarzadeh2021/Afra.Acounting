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
    public class AddInvPartParamsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvPartParamId { get; set; }  
 
		public Int32 IPPPartRef { get; set; }  
 
		public String IPPParamRef { get; set; }  
 
		public String IPPVal { get; set; } 

        public void Validate()
        {
            new AddInvPartParamsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
