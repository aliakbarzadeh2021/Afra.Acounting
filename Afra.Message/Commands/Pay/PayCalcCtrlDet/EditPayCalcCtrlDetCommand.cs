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
    public class EditPayCalcCtrlDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PCCDCtrlRef { get; set; }  
 
		public Int32 PCCDYearNum { get; set; }  
 
		public Int32 PCCDMonthNum { get; set; }  
 
		public Int32 PCCDPersRef { get; set; }  
 
		public Nullable<Int32> PCCDUserRef { get; set; }  
 
		public Nullable<Int32> PCCDSit { get; set; } 

        public void Validate()
        {
            new EditPayCalcCtrlDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
