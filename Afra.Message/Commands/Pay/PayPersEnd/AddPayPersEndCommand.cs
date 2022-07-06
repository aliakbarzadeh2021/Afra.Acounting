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
    public class AddPayPersEndCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayPersEndId { get; set; }  
 
		public Int32 PPEYearNum { get; set; }  
 
		public Int32 PPEMonthNum { get; set; }  
 
		public Int32 PPEPersRef { get; set; }  
 
		public Nullable<Int32> PPEElmntRef { get; set; }  
 
		public String PPETitle { get; set; }  
 
		public String PPEBase { get; set; }  
 
		public Double PPEVal { get; set; } 

        public void Validate()
        {
            new AddPayPersEndCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
