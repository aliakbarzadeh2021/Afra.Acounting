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
    public class EditWorkStationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 WorkStationId { get; set; }  
 
		public Nullable<Int32> WCostCenterRef { get; set; }  
 
		public String WTitle { get; set; } 

        public void Validate()
        {
            new EditWorkStationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
