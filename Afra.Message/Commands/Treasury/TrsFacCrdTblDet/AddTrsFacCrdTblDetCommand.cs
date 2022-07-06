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
    public class AddTrsFacCrdTblDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TFCTDHdrRef { get; set; }  
 
		public Double TFCTDFVal { get; set; }  
 
		public Nullable<Double> TFCTDTVal { get; set; }  
 
		public Nullable<Double> TFCTDDirect { get; set; }  
 
		public Nullable<Double> TFCTDInDirect { get; set; } 

        public void Validate()
        {
            new AddTrsFacCrdTblDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
