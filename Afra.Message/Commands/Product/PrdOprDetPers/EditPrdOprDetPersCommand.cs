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
    public class EditPrdOprDetPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PODPItmRef { get; set; }  
 
		public Int32 PODPPersRef { get; set; }  
 
		public Int32 PODPShiftRef { get; set; }  
 
		public DateTime PODPTime { get; set; } 

        public void Validate()
        {
            new EditPrdOprDetPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
