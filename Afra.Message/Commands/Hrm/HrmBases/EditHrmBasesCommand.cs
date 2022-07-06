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
    public class EditHrmBasesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 HrmBaseId { get; set; }  
 
		public String HrmBaseCode { get; set; }  
 
		public String HrmBaseTitle { get; set; } 

        public void Validate()
        {
            new EditHrmBasesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
