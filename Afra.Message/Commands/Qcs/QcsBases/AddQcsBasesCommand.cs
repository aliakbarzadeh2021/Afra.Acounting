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
    public class AddQcsBasesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QBCode { get; set; }  
 
		public String QBType { get; set; }  
 
		public String QBTItle { get; set; } 

        public void Validate()
        {
            new AddQcsBasesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
