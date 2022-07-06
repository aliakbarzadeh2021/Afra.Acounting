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
    public class EditGnrDashFieldsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GDFHdrRef { get; set; }  
 
		public String GDFName { get; set; }  
 
		public String GDFFormula { get; set; } 

        public void Validate()
        {
            new EditGnrDashFieldsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
