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
    public class EditGnrSysQryFieldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GSFQryRef { get; set; }  
 
		public String GSFTitle { get; set; }  
 
		public String GSFName { get; set; } 

        public void Validate()
        {
            new EditGnrSysQryFieldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
