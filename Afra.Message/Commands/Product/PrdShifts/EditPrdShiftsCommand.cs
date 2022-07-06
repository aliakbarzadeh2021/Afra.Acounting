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
    public class EditPrdShiftsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdShiftId { get; set; }  
 
		public String PSTitle { get; set; }  
 
		public DateTime PSStTime { get; set; }  
 
		public DateTime PSEnTime { get; set; } 

        public void Validate()
        {
            new EditPrdShiftsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
