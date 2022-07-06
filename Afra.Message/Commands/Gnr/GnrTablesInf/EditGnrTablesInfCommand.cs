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
    public class EditGnrTablesInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrTabesInfId { get; set; }  
 
		public String TableName { get; set; }  
 
		public String Title { get; set; } 

        public void Validate()
        {
            new EditGnrTablesInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
