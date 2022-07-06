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
    public class AddHrmIncDecVacCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmIncDecVacId { get; set; }  
 
		public Nullable<Int32> HIDVNum { get; set; }  
 
		public DateTime HIDVDate { get; set; }  
 
		public Nullable<Int32> HIDVPersRef { get; set; }  
 
		public Nullable<Int32> HIDVType { get; set; }  
 
		public DateTime HIDVTime { get; set; } 

        public void Validate()
        {
            new AddHrmIncDecVacCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
