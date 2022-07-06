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
    public class AddPayGrpLoanPersCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PGLHdrRef { get; set; }  
 
		public Int32 PGLPersRef { get; set; } 

        public void Validate()
        {
            new AddPayGrpLoanPersCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
