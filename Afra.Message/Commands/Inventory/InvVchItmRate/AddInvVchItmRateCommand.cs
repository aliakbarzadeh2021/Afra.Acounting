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
    public class AddInvVchItmRateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvItmRateId { get; set; }  
 
		public Nullable<Int32> InvVchItmRef { get; set; }  
 
		public Int32 IVRType { get; set; }  
 
		public String IVRDescr { get; set; }  
 
		public Double IVRMainAmount { get; set; }  
 
		public DateTime IVRDate { get; set; } 

        public void Validate()
        {
            new AddInvVchItmRateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
