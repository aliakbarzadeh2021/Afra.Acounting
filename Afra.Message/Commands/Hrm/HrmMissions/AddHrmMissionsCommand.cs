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
    public class AddHrmMissionsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmMissionId { get; set; }  
 
		public String HMTitle { get; set; }  
 
		public Nullable<Int32> HMType { get; set; } 

        public void Validate()
        {
            new AddHrmMissionsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
