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
    public class AddGnrUFCtgryCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GnrUFCtgryId { get; set; }  
 
		public Nullable<Int32> GUFCParent { get; set; }  
 
		public String GUFTitle { get; set; } 

        public void Validate()
        {
            new AddGnrUFCtgryCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}
