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
    public class AddTablesLastIdCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String tblName { get; set; }  
 
		public Nullable<Int32> LastId { get; set; } 

        public void Validate()
        {
            new AddTablesLastIdCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
