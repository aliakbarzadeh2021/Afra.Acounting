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
    public class AddInvFormTypesCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvFormTypeID { get; set; }  
 
		public String IFTTitle { get; set; }  
 
		public String IFDLType { get; set; } 

        public void Validate()
        {
            new AddInvFormTypesCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
