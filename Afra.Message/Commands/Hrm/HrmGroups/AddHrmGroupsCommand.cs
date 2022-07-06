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
    public class AddHrmGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmGrpId { get; set; }  
 
		public String HrmGrpCode { get; set; }  
 
		public String HrmGrpTitle { get; set; } 

        public void Validate()
        {
            new AddHrmGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
