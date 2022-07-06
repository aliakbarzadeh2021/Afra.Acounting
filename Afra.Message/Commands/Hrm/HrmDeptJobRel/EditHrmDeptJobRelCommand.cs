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
    public class EditHrmDeptJobRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HDJRDeptRef { get; set; }  
 
		public Int32 HDJRJobRef { get; set; }  
 
		public Nullable<Int32> HDJRCnt { get; set; }  
 
		public String HDJRDescr { get; set; } 

        public void Validate()
        {
            new EditHrmDeptJobRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
