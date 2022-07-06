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
    public class AddUserProcessStpCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserProcessStpId { get; set; }  
 
		public Int32 UPSHdrRef { get; set; }  
 
		public Int32 UPSStepRef { get; set; }  
 
		public Int32 UPSUserRef { get; set; }  
 
		public Nullable<Int32> UPSRefId { get; set; }  
 
		public DateTime UPSCrDate { get; set; }  
 
		public DateTime UPSShDate { get; set; }  
 
		public DateTime UPSEnDate { get; set; } 

        public void Validate()
        {
            new AddUserProcessStpCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
