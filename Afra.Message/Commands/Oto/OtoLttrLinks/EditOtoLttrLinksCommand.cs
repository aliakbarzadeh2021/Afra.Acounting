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
    public class EditOtoLttrLinksCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OtoLttrLinksId { get; set; }  
 
		public Int32 OLLBaseLttr { get; set; }  
 
		public Int32 OLLRelLttr { get; set; }  
 
		public Int32 OLLType { get; set; }  
 
		public String OLLDescr { get; set; } 

        public void Validate()
        {
            new EditOtoLttrLinksCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
