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
    public class EditCntDeliveryInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CntDeliveryInfId { get; set; }  
 
		public Int32 CDIContRef { get; set; }  
 
		public String CDIType { get; set; }  
 
		public DateTime CDIDate { get; set; } 

        public void Validate()
        {
            new EditCntDeliveryInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
