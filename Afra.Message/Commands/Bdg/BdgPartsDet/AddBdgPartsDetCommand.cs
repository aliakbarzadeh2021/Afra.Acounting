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
    public class AddBdgPartsDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BPDParentRef { get; set; }  
 
		public Int32 BPDMonth { get; set; }  
 
		public Nullable<Double> BPDQty { get; set; }  
 
		public Nullable<Double> BPDPrice { get; set; }  
 
		public Nullable<Double> BPDCost { get; set; } 

        public void Validate()
        {
            new AddBdgPartsDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
