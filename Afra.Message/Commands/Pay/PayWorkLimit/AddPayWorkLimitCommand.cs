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
    public class AddPayWorkLimitCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PWLEmpRef { get; set; }  
 
		public Int32 PWLGrpRef { get; set; }  
 
		public Int32 PWLElmntRef { get; set; }  
 
		public Int32 PWLYearNum { get; set; }  
 
		public Int32 PWLMonthNum { get; set; }  
 
		public Nullable<Int32> PWLDay { get; set; }  
 
		public Nullable<Int32> PWLHour { get; set; }  
 
		public Nullable<Int32> PWLMinute { get; set; } 

        public void Validate()
        {
            new AddPayWorkLimitCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
