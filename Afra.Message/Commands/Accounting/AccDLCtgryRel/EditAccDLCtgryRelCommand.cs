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
    public class EditAccDLCtgryRelCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ADCRCtgryRef { get; set; }  
 
		public String ADCRDLRef { get; set; } 

        public void Validate()
        {
            new EditAccDLCtgryRelCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
