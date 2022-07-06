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
    public class EditPayCalcCtrlCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCalcCtrlId { get; set; }  
 
		public Nullable<Int32> PCCYearNum { get; set; }  
 
		public Nullable<Int32> PCCMonthNum { get; set; }  
 
		public Nullable<Int32> PCCType { get; set; }  
 
		public Nullable<Int32> PCCUserRef { get; set; }  
 
		public Nullable<Int32> PCCSit { get; set; }  
 
		public String PCCTitle { get; set; }  
 
		public Nullable<Int32> PCCKind { get; set; }  
 
		public String PCCDefQry { get; set; } 

        public void Validate()
        {
            new EditPayCalcCtrlCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
