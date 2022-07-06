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
    public class AddCmrReleaseCostCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrReleaseCostId { get; set; }  
 
		public Int32 CRCItmRef { get; set; }  
 
		public String CRCDescr { get; set; }  
 
		public Double CRCAmount { get; set; } 

        public void Validate()
        {
            new AddCmrReleaseCostCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
