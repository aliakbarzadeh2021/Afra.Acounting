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
    public class AddAccTransVchCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String ATVSrcName { get; set; }  
 
		public Int32 ATVSrcTempNum { get; set; }  
 
		public Int32 ATVTempNum { get; set; }  
 
		public Int32 ATVYear { get; set; } 

        public void Validate()
        {
            new AddAccTransVchCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
