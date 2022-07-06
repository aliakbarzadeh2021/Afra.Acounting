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
    public class AddGnrDashFieldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GDFHdrRef { get; set; }  
 
		public String GDFName { get; set; }  
 
		public String GDFFormula { get; set; } 

        public void Validate()
        {
            new AddGnrDashFieldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
