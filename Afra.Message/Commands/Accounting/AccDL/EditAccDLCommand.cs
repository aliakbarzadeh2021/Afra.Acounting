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
    public class EditAccDLCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String dl_Code { get; set; }  
 
		public String dl_Title { get; set; }  
 
		public String dl_type { get; set; }  
 
		public Nullable<Int32> dl_disable { get; set; } 

        public void Validate()
        {
            new EditAccDLCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
