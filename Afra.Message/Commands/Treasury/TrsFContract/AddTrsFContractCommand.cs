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
    public class AddTrsFContractCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFacContractId { get; set; }  
 
		public Int32 TFCType { get; set; }  
 
		public Int32 TFCNum { get; set; }  
 
		public DateTime TFCDate { get; set; }  
 
		public String TFCDLRef { get; set; }  
 
		public Double TFCAmount { get; set; }  
 
		public Nullable<Double> TFCMaxAmnt { get; set; }  
 
		public Nullable<Int32> TFCCreator { get; set; }  
 
		public Nullable<Int32> TFCSit { get; set; } 

        public void Validate()
        {
            new AddTrsFContractCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
