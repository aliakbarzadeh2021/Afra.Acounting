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
    public class EditGnrSysMsgDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GSMDHdrRef { get; set; }  
 
		public Int32 GSMDUserRef { get; set; }  
 
		public Nullable<Int32> GSMDSit { get; set; } 

        public void Validate()
        {
            new EditGnrSysMsgDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
