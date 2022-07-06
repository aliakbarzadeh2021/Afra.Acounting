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
    public class EditTrsVchItmBaseCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TVIBItmId { get; set; }  
 
		public Int32 TVIBRefId { get; set; }  
 
		public String TVIBRefType { get; set; } 

        public void Validate()
        {
            new EditTrsVchItmBaseCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
