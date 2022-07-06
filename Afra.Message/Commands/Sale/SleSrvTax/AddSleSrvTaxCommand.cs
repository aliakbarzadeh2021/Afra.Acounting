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
    public class AddSleSrvTaxCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Nullable<Int32> SleSrvHdrRef { get; set; }  
 
		public Int32 SleSrvItmRef { get; set; }  
 
		public Int32 SSTTaxRef { get; set; }  
 
		public Nullable<Double> SSTTaxAmount { get; set; }  
 
		public Nullable<Double> SSTAmount { get; set; }  
 
		public Nullable<Double> SSTCurVal { get; set; } 

        public void Validate()
        {
            new AddSleSrvTaxCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
