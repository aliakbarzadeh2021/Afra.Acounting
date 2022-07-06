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
    public class EditPrdMachineCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdMachineId { get; set; }  
 
		public String PMTitle { get; set; }  
 
		public Int32 PMWorkStRef { get; set; }  
 
		public DateTime PMStartTime { get; set; }  
 
		public Nullable<Int32> PMDurHour { get; set; } 

        public void Validate()
        {
            new EditPrdMachineCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
