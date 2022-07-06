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
    public class EditUserPlaningCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserPlaningId { get; set; }  
 
		public String UPDescr { get; set; }  
 
		public Int32 UPCreator { get; set; }  
 
		public DateTime UPStartDate { get; set; }  
 
		public DateTime UPStartTime { get; set; }  
 
		public Int32 UPRepeat { get; set; }  
 
		public DateTime UPEndDate { get; set; } 

        public void Validate()
        {
            new EditUserPlaningCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
