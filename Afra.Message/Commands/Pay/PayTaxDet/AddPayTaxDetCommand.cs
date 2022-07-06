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
    public class AddPayTaxDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PayTaxTblDetId { get; set; }  
 
		public Nullable<Int32> PTTDTableRef { get; set; }  
 
		public Int32 PTTDFromVal { get; set; }  
 
		public Int32 PTTDToVal { get; set; }  
 
		public Double PTTDValPrc { get; set; }  
 
		public Nullable<Double> PTTDTax { get; set; } 

        public void Validate()
        {
            new AddPayTaxDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
