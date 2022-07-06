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
    public class EditGnrTablesDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TableRef { get; set; }  
 
		public String ColName { get; set; }  
 
		public String ColTitle { get; set; } 

        public void Validate()
        {
            new EditGnrTablesDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
