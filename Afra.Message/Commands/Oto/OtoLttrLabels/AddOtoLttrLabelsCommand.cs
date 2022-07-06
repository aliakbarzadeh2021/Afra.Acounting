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
    public class AddOtoLttrLabelsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OLLRefType { get; set; }  
 
		public Int32 OLLRefId { get; set; }  
 
		public Int32 OLLabelRef { get; set; } 

        public void Validate()
        {
            new AddOtoLttrLabelsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
