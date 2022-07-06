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
    public class AddPrdPOrdItmCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PrdPOrdItmId { get; set; }  
 
		public Int32 PPOISeq { get; set; }  
 
		public Int32 PrdPOrdHdrRef { get; set; }  
 
		public Int32 PPOIOrdRef { get; set; }  
 
		public Nullable<Double> PPOIOthQty { get; set; }  
 
		public Nullable<Double> PPOIMainQty { get; set; }  
 
		public Nullable<Int32> PPOIFormulRef { get; set; }  
 
		public Nullable<Int32> PPOIConsumAll { get; set; }  
 
		public String PPOIDescr { get; set; }  
 
		public Nullable<Int32> PPOIStatus { get; set; } 

        public void Validate()
        {
            new AddPrdPOrdItmCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
