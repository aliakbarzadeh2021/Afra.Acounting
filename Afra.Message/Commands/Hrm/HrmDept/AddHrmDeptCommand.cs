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
    public class AddHrmDeptCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmDeptID { get; set; }  
 
		public Nullable<Int32> HDParentRef { get; set; }  
 
		public String HrmDeptTitle { get; set; }  
 
		public String HrmDeptCode { get; set; }  
 
		public Nullable<Int32> HrmDeptBaseRef { get; set; }  
 
		public Nullable<Int32> HrmDeptCount { get; set; } 

        public void Validate()
        {
            new AddHrmDeptCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
