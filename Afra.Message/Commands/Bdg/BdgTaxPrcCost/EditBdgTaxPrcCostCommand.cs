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
    public class EditBdgTaxPrcCostCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BTPCItemRef { get; set; }  
 
		public String BTPCSLCode { get; set; }  
 
		public Int32 BTPCCalcType { get; set; } 

        public void Validate()
        {
            new EditBdgTaxPrcCostCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
