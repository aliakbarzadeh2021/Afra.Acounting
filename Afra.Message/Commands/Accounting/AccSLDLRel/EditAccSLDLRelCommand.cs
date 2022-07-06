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
    public class EditAccSLDLRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String rel_SLRef { get; set; }  
 
		public String rel_DlType { get; set; }  
 
		public Int32 relType { get; set; } 

        public void Validate()
        {
            new EditAccSLDLRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
