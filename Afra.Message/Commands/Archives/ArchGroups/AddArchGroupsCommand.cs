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
    public class AddArchGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ArchGrpId { get; set; }  
 
		public String AcGTitle { get; set; }  
 
		public String AcSysRef { get; set; } 

        public void Validate()
        {
            new AddArchGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
