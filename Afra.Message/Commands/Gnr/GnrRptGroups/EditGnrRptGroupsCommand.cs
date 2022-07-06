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
    public class EditGnrRptGroupsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 RptGroupId { get; set; }  
 
		public String RptGroupTitle { get; set; }  
 
		public String RptSysRef { get; set; }  
 
		public Nullable<Int32> RGParentRef { get; set; } 

        public void Validate()
        {
            new EditGnrRptGroupsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
