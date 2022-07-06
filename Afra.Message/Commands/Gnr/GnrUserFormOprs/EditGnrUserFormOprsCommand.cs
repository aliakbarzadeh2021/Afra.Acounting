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
    public class EditGnrUserFormOprsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GUFOItmType { get; set; }  
 
		public Int32 GUFOItmId { get; set; }  
 
		public String GUFOCmd { get; set; } 

        public void Validate()
        {
            new EditGnrUserFormOprsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
