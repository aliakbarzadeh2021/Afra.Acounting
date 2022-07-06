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
    public class AddAccPLCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public String pl_Code { get; set; }  
 
		public String pl_Title { get; set; }  
 
		public String pl_Type { get; set; } 

        public void Validate()
        {
            new AddAccPLCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
