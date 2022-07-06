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
    public class AddOtoTransScriptCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoTransScriptId { get; set; }  
 
		public Nullable<Int32> OTSUserRef { get; set; }  
 
		public Nullable<Int32> OTSOrder { get; set; }  
 
		public String OTSDescr { get; set; } 

        public void Validate()
        {
            new AddOtoTransScriptCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
