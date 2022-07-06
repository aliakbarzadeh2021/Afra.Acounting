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
    public class EditGnrProcessDetTransCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrProcessDetTransId { get; set; }  
 
		public Int32 GPDTItemRef { get; set; }  
 
		public Int32 GPDTProcRef { get; set; } 

        public void Validate()
        {
            new EditGnrProcessDetTransCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
