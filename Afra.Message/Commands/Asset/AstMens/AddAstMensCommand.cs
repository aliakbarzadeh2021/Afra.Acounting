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
    public class AddAstMensCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AstMenId { get; set; }  
 
		public Int32 AMCrsRef { get; set; }  
 
		public DateTime AMIDate { get; set; } 

        public void Validate()
        {
            new AddAstMensCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
