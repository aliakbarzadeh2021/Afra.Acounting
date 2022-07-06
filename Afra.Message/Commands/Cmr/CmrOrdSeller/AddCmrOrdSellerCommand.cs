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
    public class AddCmrOrdSellerCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 COSSellerRef { get; set; }  
 
		public Int32 COSHdrRef { get; set; } 

        public void Validate()
        {
            new AddCmrOrdSellerCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
