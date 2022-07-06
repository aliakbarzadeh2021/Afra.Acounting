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
    public class AddTrsFundItmDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFundItmDetId { get; set; }  
 
		public Int32 TFIDItemRef { get; set; }  
 
		public Nullable<Double> TFIDTaxAmnt { get; set; }  
 
		public Nullable<Double> TFIDDutyAmnt { get; set; }  
 
		public Nullable<Double> TFIDOthAmnt { get; set; } 

        public void Validate()
        {
            new AddTrsFundItmDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
