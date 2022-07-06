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
    public class EditBdgCurExchangeCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgCurExchangeId { get; set; }  
 
		public DateTime BCEDate { get; set; }  
 
		public Int32 BCECurRef { get; set; }  
 
		public Double BCERate { get; set; }  
 
		public Int32 BCEPeriodRef { get; set; } 

        public void Validate()
        {
            new EditBdgCurExchangeCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
