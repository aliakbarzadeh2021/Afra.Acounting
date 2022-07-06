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
    public class AddTrsFContractDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TrsFContractDetId { get; set; }  
 
		public Int32 TFCDType { get; set; }  
 
		public Int32 TFCDItmRef { get; set; }  
 
		public Int32 TFCDSrcRef { get; set; }  
 
		public Double TFCDPrc { get; set; } 

        public void Validate()
        {
            new AddTrsFContractDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
