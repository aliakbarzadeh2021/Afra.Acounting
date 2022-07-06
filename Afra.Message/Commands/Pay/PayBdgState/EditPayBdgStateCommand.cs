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
    public class EditPayBdgStateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayBdgStateId { get; set; }  
 
		public Int32 PBSPersRef { get; set; }  
 
		public Int32 PBSYearNum { get; set; }  
 
		public Int32 PBSMonthNum { get; set; }  
 
		public Nullable<Int32> PBSCalcType { get; set; }  
 
		public Nullable<Int32> PBSYearMonth { get; set; } 

        public void Validate()
        {
            new EditPayBdgStateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
