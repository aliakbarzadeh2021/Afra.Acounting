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
    public class AddPayTaxTableCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayTaxTblId { get; set; }  
 
		public String PTTTitle { get; set; }  
 
		public Int32 PTTIssueYear { get; set; }  
 
		public Int32 PTTIssueMonth { get; set; }  
 
		public String PTTGrpType { get; set; }  
 
		public Nullable<Int32> PTTIYearMonth { get; set; } 

        public void Validate()
        {
            new AddPayTaxTableCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
