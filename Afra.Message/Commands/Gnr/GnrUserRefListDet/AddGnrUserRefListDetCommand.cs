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
    public class AddGnrUserRefListDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GURLListRef { get; set; }  
 
		public String GURLFieldName { get; set; }  
 
		public String GURLFieldTitle { get; set; }  
 
		public Nullable<Int32> GURLShowOnForm { get; set; }  
 
		public Nullable<Int32> GURLSize { get; set; } 

        public void Validate()
        {
            new AddGnrUserRefListDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
