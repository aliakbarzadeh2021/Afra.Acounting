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
    public class AddTaxDutyInfCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TaxDutyId { get; set; }  
 
		public DateTime TDDate { get; set; }  
 
		public Nullable<Double> TDTaxPrc { get; set; }  
 
		public Nullable<Double> TDDutyPrc { get; set; }  
 
		public String TDRcvTaxSLRef { get; set; }  
 
		public String TDRcvDutySLRef { get; set; }  
 
		public String TDRcvTaxDLRef { get; set; }  
 
		public String TDRcvDutyDLRef { get; set; }  
 
		public String TDPayTaxSLRef { get; set; }  
 
		public String TDPayDutySLRef { get; set; }  
 
		public String TDPayTaxDLRef { get; set; }  
 
		public String TDPayDutyDLRef { get; set; } 

        public void Validate()
        {
            new AddTaxDutyInfCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
