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
    public class AddPayLoanTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayLoanId { get; set; }  
 
		public String PLnTitle { get; set; }  
 
		public Nullable<Int32> PLnElmntRef { get; set; }  
 
		public Nullable<Double> PLnMaxAmnt { get; set; }  
 
		public String PLnDLRef { get; set; }  
 
		public Nullable<Int32> PLnActive { get; set; } 

        public void Validate()
        {
            new AddPayLoanTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
