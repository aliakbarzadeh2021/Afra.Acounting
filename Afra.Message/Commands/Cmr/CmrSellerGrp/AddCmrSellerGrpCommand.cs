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
    public class AddCmrSellerGrpCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CmrSellerGrpId { get; set; }  
 
		public String CSGTitle { get; set; } 

        public void Validate()
        {
            new AddCmrSellerGrpCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
