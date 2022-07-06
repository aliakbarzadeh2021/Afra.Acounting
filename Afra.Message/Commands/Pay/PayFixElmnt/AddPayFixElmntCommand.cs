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
    public class AddPayFixElmntCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayFixElmntId { get; set; }  
 
		public String PFETitle { get; set; } 

        public void Validate()
        {
            new AddPayFixElmntCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
