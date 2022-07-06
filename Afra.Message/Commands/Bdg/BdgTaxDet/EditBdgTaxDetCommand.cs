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
    public class EditBdgTaxDetCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BdgTaxDetId { get; set; }  
 
		public Int32 BTDType { get; set; }  
 
		public Int32 BTDParentRef { get; set; }  
 
		public Int32 BTDTaxRef { get; set; }  
 
		public Nullable<Int32> BTDPriority { get; set; }  
 
		public Double BTDVal { get; set; } 

        public void Validate()
        {
            new EditBdgTaxDetCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
