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
    public class AddHrmIncDecWorkCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmIncDecWorkId { get; set; }  
 
		public Nullable<Int32> HIDWNum { get; set; }  
 
		public DateTime HIDWDate { get; set; }  
 
		public Nullable<Int32> HIDWPersRef { get; set; }  
 
		public Nullable<Int32> HIDWType { get; set; }  
 
		public DateTime HIDWTime { get; set; } 

        public void Validate()
        {
            new AddHrmIncDecWorkCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
