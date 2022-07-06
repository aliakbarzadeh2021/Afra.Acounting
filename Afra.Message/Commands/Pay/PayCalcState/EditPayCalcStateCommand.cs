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
    public class EditPayCalcStateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayCalcStateId { get; set; }  
 
		public Int32 PCSPersRef { get; set; }  
 
		public Int32 PCSYearNum { get; set; }  
 
		public Int32 PCSMonthNum { get; set; }  
 
		public Nullable<Int32> PCSCalcType { get; set; }  
 
		public Nullable<Int32> PCSYearMonth { get; set; }  
 
		public Nullable<Int32> PCSUserRef { get; set; }  
 
		public Nullable<Int32> PCSOrgType { get; set; } 

        public void Validate()
        {
            new EditPayCalcStateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
