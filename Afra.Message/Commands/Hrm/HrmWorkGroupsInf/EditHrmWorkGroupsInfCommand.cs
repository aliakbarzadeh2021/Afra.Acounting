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
    public class EditHrmWorkGroupsInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HWGIHdrRef { get; set; }  
 
		public String HWGIMonth { get; set; }  
 
		public DateTime HWGIDayDur { get; set; } 

        public void Validate()
        {
            new EditHrmWorkGroupsInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
